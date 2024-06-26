using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    public class DataPath
    {
        public static readonly string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        public static readonly string imagePath = Path.Combine(dbPath, "Images");
    }
    public class DBManager
    {
        public void MakeDefaultData()
        {
            if (!Directory.Exists(DataPath.dbPath))
            {
                Directory.CreateDirectory(DataPath.dbPath);
            }
            if (!Directory.Exists(DataPath.imagePath))
            {
                Directory.CreateDirectory(DataPath.imagePath);
            }
            using (var context = new DatabaseContext())
            {
                    context.Database.EnsureCreated();                    
            }
        }
        public void SetACityLists()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.CityLists.Any())
                {
                    var CityLists = new List<CityList>
                        {
                            new CityList("HK", "北海道"), new CityList("AO", "青森県"),
                            new CityList("IT", "岩手県"), new CityList("MG", "宮城県"),
                            new CityList("AK", "秋田県"), new CityList("YG", "山形県"),
                            new CityList("FS", "福島県"), new CityList("IB", "茨城県"),
                            new CityList("TC", "栃木県"), new CityList("GU", "群馬県"),
                            new CityList("ST", "埼玉県"), new CityList("CB", "千葉県"),
                            new CityList("TY", "東京都"), new CityList("KN", "神奈川県"),
                            new CityList("NI", "新潟県"), new CityList("TM", "富山県"),
                            new CityList("IS", "石川県"), new CityList("FI", "福井県"),
                            new CityList("YN", "山梨県"), new CityList("NA", "長野県"),
                            new CityList("GI", "岐阜県"), new CityList("SZ", "静岡県"),
                            new CityList("AI", "愛知県"), new CityList("ME", "三重県"),
                            new CityList("SI", "滋賀県"), new CityList("KY", "京都府"),
                            new CityList("OS", "大阪府"), new CityList("HG", "兵庫県"),
                            new CityList("NR", "奈良県"), new CityList("WA", "和歌山県"),
                            new CityList("TT", "鳥取県"), new CityList("SM", "島根県"),
                            new CityList("OY", "岡山県"), new CityList("HS", "広島県"),
                            new CityList("YA", "山口県"), new CityList("TK", "徳島県"),
                            new CityList("KA", "香川県"), new CityList("EH", "愛媛県"),
                            new CityList("KO", "高知県"), new CityList("FO", "福岡県"),
                            new CityList("SG", "佐賀県"), new CityList("NS", "長崎県"),
                            new CityList("KU", "熊本県"), new CityList("OI", "大分県"),
                            new CityList("MZ", "宮崎県"), new CityList("KG", "鹿児島県"),
                            new CityList("OK", "沖縄県")
                        };
                    context.CityLists.AddRange(CityLists);
                    context.SaveChanges();
                }
            }
        }
    }
}
