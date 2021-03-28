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
        bool abclicked = false;
        bool mbclicked = false;
        bool ebclicked = false;
        bool dbclicked = false;
        bool mubclicked = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            // If the Equals Button is clicked
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                // If none of the buttons (+, -, x or ÷) have been clicked
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {  
		    // Set the variable 'var' to the contents of 'textBox1'
                    var = textBox1.Text;  
                    // Set the text in 'textBox1' from whatever it already is to whatever it already is as well as a 1
                    textBox1.Text = var + 1;                 
                }
                // If the + button has been clicked
                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 1;
                }
                // If the - button has been clicked
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 1;
                }
                // If the ÷ button has been clicked
                if (dbclicked == true)
                {                  
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 1;
                }
                // If the x button has been clicked
                if (mubclicked == true)
                {
                    
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 1;
                }
            }
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 2;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 2;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 2;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 2;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 2;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 3;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 3;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 3;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 3;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 3;
                }
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 4;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 4;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 4;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 4;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 4;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 5;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 5;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 5;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 5;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 5;
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 6;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 6;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 6;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 6;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 6;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 7;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 7;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 7;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 7;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 7;
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 8;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 8;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 8;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 8;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 8;
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 9;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 9;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 9;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 9;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 9;
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (ebclicked == false)
            {
                textBox2.Text = String.Empty;
                if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
                {
                    var = textBox1.Text;
                    textBox1.Text = var + 0;
                }

                if (abclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 0;
                }
                if (mbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 0;
                }
                if (dbclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 0;
                }
                if (mubclicked == true)
                {
                    var2 = textBox1.Text;
                    textBox1.Text = var2 + 0;
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
            {
                mbclicked = true;
                ebclicked = false;
                var = textBox1.Text;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
            {
                abclicked = true;
                ebclicked = false;
                var = textBox1.Text;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (abclicked == true)
            {
                var2 = textBox1.Text;
                long var3 = Int64.Parse(var);
                long var4 = Int64.Parse(var2);
                string var5 = Convert.ToString(var3 + var4);
                textBox1.Text = var5;
                abclicked = false;
                mbclicked = false;
                dbclicked = false;
                mubclicked = false;
                ebclicked = true;
                var = String.Empty;
                var2 = String.Empty;
            }
            if (mbclicked == true)
            {
                var2 = textBox1.Text;
                long var3 = Int64.Parse(var);
                long var4 = Int64.Parse(var2);
                string var5 = Convert.ToString(var3 - var4);
                textBox1.Text = var5;
                abclicked = false;
                mbclicked = false;
                dbclicked = false;
                mubclicked = false;
                ebclicked = true;
                var = String.Empty;
                var2 = String.Empty;
            }
            if (dbclicked == true)
            {
                var2 = textBox1.Text;
                long var3 = Int64.Parse(var);
                long var4 = Int64.Parse(var2);
                string var5 = Convert.ToString(var3 / var4);
                string var6 = Convert.ToString(var3 % var4);
                textBox1.Text = var5;
                textBox2.Text = ("Remaninder ") + var6;
                abclicked = false;
                mbclicked = false;
                dbclicked = false;
                mubclicked = false;
                ebclicked = true;
                var = String.Empty;
                var2 = String.Empty;
            }
            if (mubclicked == true)
            {
                var2 = textBox1.Text;
                long var3 = Int64.Parse(var);
                long var4 = Int64.Parse(var2);
                string var5 = Convert.ToString(var3 * var4);
                textBox1.Text = var5;
                abclicked = false;
                mbclicked = false;
                dbclicked = false;
                mubclicked = false;
                ebclicked = true;
                var = String.Empty;
                var2 = String.Empty;
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            abclicked = false;
            mbclicked = false;
            dbclicked = false;
            mubclicked = false;
            ebclicked = false;
            var = textBox1.Text;
            var2 = textBox1.Text;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
            {
                dbclicked = true;
                ebclicked = false;
                var = textBox1.Text;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if ((abclicked == false) && (mbclicked == false) && (dbclicked == false) && (mubclicked == false))
            {
                mubclicked = true;
                ebclicked = false;
                var = textBox1.Text;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            abclicked = false;
            mbclicked = false;
            dbclicked = false;
            mubclicked = false;
            ebclicked = false;
            var = textBox1.Text;
            var2 = textBox1.Text;
        }
    }
}
