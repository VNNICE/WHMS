using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Text;

namespace TranslationToolClass
{
    [ComImport]
    [Guid("019F7152-E6DB-11d0-83C3-00C04FDDB82E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFELanguage
    {
        int Open();
        int Close();
        int GetJMorphResult(uint dwRequest, uint dwCMode, int cwchInput, [MarshalAs(UnmanagedType.LPWStr)] string pwchInput, IntPtr pfCInfo, out object ppResult);
        int GetConversionModeCaps(ref uint pdwCaps);
        int GetPhonetic([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
        int GetConversion([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
    }

    public class Translation
    {
        static string KtoH(string input)
        {
            const int S_OK = 0;
            IFELanguage ifelang = null;
            try
            {
                ifelang = Activator.CreateInstance(Type.GetTypeFromProgID("MSIME.Japan")) as IFELanguage;
                int hr = ifelang.Open();
                if (hr != 0)
                {
                    throw Marshal.GetExceptionForHR(hr);
                }
                string yomigana;
                hr = ifelang.GetPhonetic(input, 1, -1, out yomigana);
                if (hr != 0)
                {
                    throw Marshal.GetExceptionForHR(hr);
                }
                return yomigana;
            }
            catch (COMException ex)
            {
                if (ifelang != null) ifelang.Close();
                return "err";
            }
        }

        static Dictionary<string, string> JapaneseToRomaji = new Dictionary<string, string>()
        {
            {"あ", "a"}, {"い", "i"}, {"う", "u"}, {"え", "e"}, {"お", "o"},
            {"か", "ka"}, {"き", "ki"}, {"く", "ku"}, {"け", "ke"}, {"こ", "ko"},
            {"さ", "sa"}, {"し", "shi"}, {"す", "su"}, {"せ", "se"}, {"そ", "so"},
            {"た", "ta"}, {"ち", "chi"}, {"つ", "tsu"}, {"て", "te"}, {"と", "to"},
            {"な", "na"}, {"に", "ni"}, {"ぬ", "nu"}, {"ね", "ne"}, {"の", "no"},
            {"は", "ha"}, {"ひ", "hi"}, {"ふ", "fu"}, {"へ", "he"}, {"ほ", "ho"},
            {"ま", "ma"}, {"み", "mi"}, {"む", "mu"}, {"め", "me"}, {"も", "mo"},
            {"や", "ya"}, {"ゆ", "yu"}, {"よ", "yo"},
            {"ら", "ra"}, {"り", "ri"}, {"る", "ru"}, {"れ", "re"}, {"ろ", "ro"},
            {"わ", "wa"}, {"を", "wo"}, {"ん", "n"},

            {"が", "ga"}, {"ぎ", "gi"}, {"ぐ", "gu"}, {"げ", "ge"}, {"ご", "go"},
            {"ざ", "za"}, {"じ", "ji"}, {"ず", "zu"}, {"ぜ", "ze"}, {"ぞ", "zo"},
            {"だ", "da"}, {"ぢ", "ji"}, {"づ", "zu"}, {"で", "de"}, {"ど", "do"},
            {"ば", "ba"}, {"び", "bi"}, {"ぶ", "bu"}, {"べ", "be"}, {"ぼ", "bo"},
            {"ぱ", "pa"}, {"ぴ", "pi"}, {"ぷ", "pu"}, {"ぺ", "pe"}, {"ぽ", "po"},

            {"ア", "a"}, {"イ", "i"}, {"ウ", "u"}, {"エ", "e"}, {"オ", "o"},
            {"カ", "ka"}, {"キ", "ki"}, {"ク", "ku"}, {"ケ", "ke"}, {"コ", "ko"},
            {"サ", "sa"}, {"シ", "shi"}, {"ス", "su"}, {"セ", "se"}, {"ソ", "so"},
            {"タ", "ta"}, {"チ", "chi"}, {"ツ", "tsu"}, {"テ", "te"}, {"ト", "to"},
            {"ナ", "na"}, {"ニ", "ni"}, {"ヌ", "nu"}, {"ネ", "ne"}, {"ノ", "no"},
            {"ハ", "ha"}, {"ヒ", "hi"}, {"フ", "fu"}, {"ヘ", "he"}, {"ホ", "ho"},
            {"マ", "ma"}, {"ミ", "mi"}, {"ム", "mu"}, {"メ", "me"}, {"モ", "mo"},
            {"ヤ", "ya"}, {"ユ", "yu"}, {"ヨ", "yo"},
            {"ラ", "ra"}, {"リ", "ri"}, {"ル", "ru"}, {"レ", "re"}, {"ロ", "ro"},
            {"ワ", "wa"}, {"ヲ", "wo"}, {"ン", "n"},

            {"ガ", "ga"}, {"ギ", "gi"}, {"グ", "gu"}, {"ゲ", "ge"}, {"ゴ", "go"},
            {"ザ", "za"}, {"ジ", "ji"}, {"ズ", "zu"}, {"ゼ", "ze"}, {"ゾ", "zo"},
            {"ダ", "da"}, {"ヂ", "ji"}, {"ヅ", "zu"}, {"デ", "de"}, {"ド", "do"},
            {"バ", "ba"}, {"ビ", "bi"}, {"ブ", "bu"}, {"ベ", "be"}, {"ボ", "bo"},
            {"パ", "pa"}, {"ピ", "pi"}, {"プ", "pu"}, {"ペ", "pe"}, {"ポ", "po"},
            {"ヴァ", "va"}, {"ヴィ", "vi"}, {"ヴ", "vu"}, {"ヴェ", "ve"}, {"ヴォ", "vo"}
        };
        public static string JtoR(string s)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string? input = Strings.StrConv(s, VbStrConv.Wide);
            string result = "";
            if (!String.IsNullOrEmpty(input))
            {
                foreach (char c in input)
                {
                    if (JapaneseToRomaji.ContainsKey(c.ToString()))
                    {
                        result += JapaneseToRomaji[c.ToString()];
                    }
                    else
                    {
                        result = "e";
                    }

                }
                return result;
            }
            else
            {
                return "データ入力がありません。";
            }
        }
    }
}