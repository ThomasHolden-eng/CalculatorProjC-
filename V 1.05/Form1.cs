using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Attempt_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        // Written By Thomas Worsley
        string var;
        string var2;
        bool abClicked = false;
        bool mbClicked = false;
        bool ebClicked = false;
        bool dbClicked = false;
        bool mubClicked = false;
        bool dec = false;
        bool decInNum = false;
        bool sqrtbClicked = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            // If the Equals Button has not yet been clicked
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                // If none of the buttons (+, -, x or ÷) have been clicked
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    // Set the text in 'textBox1' from whatever it already is to whatever it already is as well as a 1
                    textBox1.Text += 1;
                    // Set the variable 'var' to the contents of 'textBox1'
                    var = textBox1.Text;
                }
                // If the + button has been clicked
                if (abClicked == true)
                {
                    textBox1.Text += 1;
                    var2 = textBox1.Text;
                }
                // If the - button has been clicked
                if (mbClicked == true)
                {
                    textBox1.Text += 1;
                    var2 = textBox1.Text;
                }
                // If the ÷ button has been clicked
                if (dbClicked == true)
                {
                    textBox1.Text += 1;
                    var2 = textBox1.Text;
                }
                // If the x button has been clicked
                if (mubClicked == true)
                {

                    textBox1.Text += 1;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 2;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 2;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 2;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 2;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 2;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 3;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 3;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 3;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 3;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 3;
                    var2 = textBox1.Text;
                }
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 4;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 4;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 4;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 4;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 4;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 5;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 5;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 5;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 5;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 5;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 6;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 6;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 6;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 6;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 6;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 7;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 7;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 7;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 7;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 7;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 8;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 8;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 8;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 8;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 8;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 9;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 9;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 9;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 9;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 9;
                    var2 = textBox1.Text;
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (ebClicked == false)
            {
                textBox2.Text = string.Empty;
                if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    textBox1.Text += 0;
                    var = textBox1.Text;
                }

                if (abClicked == true)
                {
                    textBox1.Text += 0;
                    var2 = textBox1.Text;
                }
                if (mbClicked == true)
                {
                    textBox1.Text += 0;
                    var2 = textBox1.Text;
                }
                if (dbClicked == true)
                {
                    textBox1.Text += 0;
                    var2 = textBox1.Text;
                }
                if (mubClicked == true)
                {
                    textBox1.Text += 0;
                    var2 = textBox1.Text;
                }
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (ebClicked == true)
                {
                    var = textBox1.Text;
                    if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                    {
                        IfSqrtBClicked();
                        mbClicked = true;
                        ebClicked = false;
                        Empty_String();
                    }
                }
                else if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    IfSqrtBClicked();
                    mbClicked = true;
                    ebClicked = false;
                    Empty_String();
                }
            }
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (ebClicked == true)
                {
                    var = textBox1.Text;
                    if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                    {
                        IfSqrtBClicked();
                        abClicked = true;
                        ebClicked = false;
                        Empty_String();
                    }
                }
                else if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    IfSqrtBClicked();
                    abClicked = true;
                    ebClicked = false;
                    Empty_String();
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if ((abClicked == true) && (dec != true))
            {
                long var3 = long.Parse(var);
                long var4 = long.Parse(var2);
                string var5 = Convert.ToString(var3 + var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((abClicked == true) && (dec == true))
            {
                decimal var3;
                if (decimal.TryParse(var, out var3))
                {
                    try
                    {
                        var3 = System.Convert.ToDecimal(var);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                decimal var4;
                if (decimal.TryParse(var, out var4))
                {
                    try
                    {
                        var4 = System.Convert.ToDecimal(var2);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                string var5 = Convert.ToString(var3 + var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                dec = true;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((mbClicked == true) && (dec != true))
            {
                long var3 = long.Parse(var);
                long var4 = long.Parse(var2);
                string var5 = Convert.ToString(var3 - var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((mbClicked == true) && (dec == true))
            {
                decimal var3;
                if (decimal.TryParse(var, out var3))
                {
                    try
                    {
                        var3 = System.Convert.ToDecimal(var);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                decimal var4;
                if (decimal.TryParse(var, out var4))
                {
                    try
                    {
                        var4 = System.Convert.ToDecimal(var2);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                string var5 = Convert.ToString(var3 - var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                dec = true;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((dbClicked == true) && (dec != true))
            {
                long var3 = long.Parse(var);
                long var4 = long.Parse(var2);
                string var5 = Convert.ToString(var3 / var4);
                string var6 = Convert.ToString(var3 % var4);
                textBox1.Text = var5;
                textBox2.Text = ("Remaninder ") + var6;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((dbClicked == true) && (dec == true))
            {
                decimal var3;
                if (decimal.TryParse(var, out var3))
                {
                    try
                    {
                        var3 = System.Convert.ToDecimal(var);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                decimal var4;
                if (decimal.TryParse(var, out var4))
                {
                    try
                    {
                        var4 = System.Convert.ToDecimal(var2);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                string var5 = Convert.ToString(var3 / var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                dec = true;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((mubClicked == true) && (dec != true))
            {
                long var3 = long.Parse(var);
                long var4 = long.Parse(var2);
                string var5 = Convert.ToString(var3 * var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
            if ((mubClicked == true) && (dec == true))
            {
                decimal var3;
                if (decimal.TryParse(var, out var3))
                {
                    try
                    {
                        var3 = System.Convert.ToDecimal(var);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                decimal var4;
                if (decimal.TryParse(var, out var4))
                {
                    try
                    {
                        var4 = System.Convert.ToDecimal(var2);
                    }
                    catch (FormatException)
                    {
                    }
                    catch (OverflowException)
                    {
                    }
                }
                string var5 = Convert.ToString(var3 * var4);
                textBox1.Text = var5;
                abClicked = false;
                mbClicked = false;
                dbClicked = false;
                mubClicked = false;
                dec = true;
                ebClicked = true;
                var = string.Empty;
                var2 = string.Empty;
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            Empty_String();
            abClicked = false;
            mbClicked = false;
            dbClicked = false;
            mubClicked = false;
            ebClicked = false;
            dec = false;
            decInNum = false;
            sqrtbClicked = false;
            var = string.Empty;
            var2 = string.Empty;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (ebClicked == true)
                {
                    var = textBox1.Text;
                    if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                    {
                        IfSqrtBClicked();
                        dbClicked = true;
                        ebClicked = false;
                        Empty_String();
                    }
                }
                else if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    IfSqrtBClicked();
                    dbClicked = true;
                    ebClicked = false;
                    Empty_String();
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (ebClicked == true)
                {
                    var = textBox1.Text;
                    if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                    {
                        IfSqrtBClicked();
                        mubClicked = true;
                        ebClicked = false;
                        Empty_String();
                    }
                }
                else if ((abClicked == false) && (mbClicked == false) && (dbClicked == false) && (mubClicked == false))
                {
                    IfSqrtBClicked();
                    mubClicked = true;
                    ebClicked = false;
                    Empty_String();
                }
            }
        }
        private void Empty_String()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            decInNum = false;
        }

        private void IfSqrtBClicked()
        {
            if (sqrtbClicked != false)
            {
                string var = Convert.ToString(textBox1.Text);
                sqrtbClicked = false;
            }
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            Empty_String();
            abClicked = false;
            mbClicked = false;
            dbClicked = false;
            mubClicked = false;
            ebClicked = false;
            dec = false;
            decInNum = false;
            sqrtbClicked = false;
            var = textBox1.Text;
            var2 = textBox1.Text;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if ((ebClicked == false) && (decInNum == false))
            {
                textBox1.Text += ".";
                decInNum = true;
                dec = true;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if ((abClicked == false) && (mbClicked == false) && (mubClicked == false) && (dbClicked == false))
                {
                    Double var = Convert.ToDouble(textBox1.Text);
                    var = Math.Sqrt(var);
                    textBox1.Text = Convert.ToString(var);
                    sqrtbClicked = true;
                    dec = true;
                    ebClicked = true;
                }
            }
        }
    }
}
