using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMS
{
    internal class InputRules
    {
        public void Rule_Initial(TextBox textBox_Initial)
        {
            textBox_Initial.KeyPress += (o, e) =>
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (textBox_Initial.Text.Length > 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            textBox_Initial.LostFocus += (o, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBox_Initial.Text))
                {
                    textBox_Initial.Text = textBox_Initial.Text.ToUpper();
                    if (textBox_Initial.Text.Length == 3)
                    {
                        textBox_Initial.Text = textBox_Initial.Text.Substring(0, 2);
                    }
                }
            };
        }

        public void Rule_OnlyInt(TextBox textBox) 
        {
            textBox.KeyPress += (o, e) =>
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }
    }
}
