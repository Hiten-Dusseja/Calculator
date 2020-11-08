using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool gl_dot = true;
        string gl_op = "+-.×÷";
        string gl_opp = "+-×÷";
        char gl_operation;
        string label;
        bool gl_eqlenabled = false; 
        int gl_eqlcounter=0;
        float[] op = new float[16];
        int divcount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 1;
        }
        private void button02_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 2;
        }

       

        private void button03_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 3;
        }

        private void button04_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 4;
        }

        private void button05_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 5;
        }

        private void button06_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 6;
        }
        private void button07_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 7;
        }

        private void button08_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;


            label1.Text += 8;
        }

        private void button09_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            gl_eqlenabled = true;

            label1.Text += 9;

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (gl_eqlcounter >= 1)
            {
                operate();
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "+";
                gl_dot = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "+";
                gl_dot = true;

            }
            gl_eqlenabled = false;
            gl_eqlcounter++;
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            if (gl_eqlcounter >= 1)
            {
                operate();
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "÷";
                gl_dot = true;
            }
            else
            {

                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "÷";
                gl_dot = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false ;

        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            if (gl_eqlcounter >= 1)
            {
                operate();
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "×";
                gl_dot = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }
                label1.Text += "×";
                gl_dot = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;

        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            if (gl_eqlcounter >= 1)
            {
                operate();
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }

                label1.Text += "-";
                gl_dot = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (gl_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);

                }

                label1.Text += "-";
                gl_dot = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;


        }

        private void buttonbs_Click(object sender, EventArgs e)
        {
            try
            {
                int len = label1.Text.Length;

                if (len == 1)
                {
                    label1.Text = label1.Text.Remove(len - 2);
          
                }
                if(label1.Text[len - 1] == '+'|| label1.Text[len - 1] == '-' 
                    || label1.Text[len - 1] == '÷'|| label1.Text[len - 1] == '×' )
                {
                    gl_dot = false;
                    gl_eqlenabled = true;

                }
                else if(label1.Text[len-1]=='.')
                {
                    gl_dot = true;
                }
                label1.Text = label1.Text.Remove(len - 1);
                

            }
           catch(ArgumentOutOfRangeException)
            {
                label1.Text = "0";
            }
        }

        private void buttonclr_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            gl_dot = true;
            gl_eqlcounter=0;
            label2.Text = null;
            gl_eqlenabled = false;


        }

        private void buttondot_Click(object sender, EventArgs e)
        { 
            if (gl_dot==false)
            {
                
            }
            else
            { int len = label1.Text.Length;
                if (label1.Text[len - 1] == '+' || label1.Text[len - 1] == '-' ||
                    label1.Text[len - 1] == '×' || label1.Text[len - 1] == '÷')
                {
                    label1.Text += "0.";
                }
              
                else
                {
                    label1.Text += ".";
                    
                }

                gl_dot = false;
                buttoneql.Enabled = false;

            }
        }

        private void operate()
        {
            gl_dot = false;
            int i, len;
            label = label1.Text;
            string substr;
            int checkneg = 0;
            int checkoperation = 2;
  
            float result = 0;
            int k = 0, opc = 0;
            len = label.Length;
            if (label[0] == '-')
            {
                StringBuilder sb = new StringBuilder(label);
           
                sb[0] = '0';
                label = sb.ToString();
                checkneg = 1;

                
            }
            for (i = 0; i < len; i++)
            {   
                if (gl_opp.Contains(label[i]) || (i == len - 1))
                {
                   
                    if ((gl_opp.Contains(label[i])&&i>=1))
                    {
                        gl_operation = label[i];
                    }
                    if (k == i && k == (len - 1))
                    {
                        substr = label.Substring(i);
                        k = i + 1;
                    }
                 
                    else if (i == len - 1)
                    {
                        substr = label.Substring(k, i - k + 1);
                    }
                    else if (k == 0)
                    {
                        substr = label.Substring(k, i - k);
                        k = i + 1;
                    }
                    else
                    {
                        substr = label.Substring(k, i - k);
                        k = i + 1;
                    }
                    if (opc == 0)
                    {
                        op[0] = float.Parse(substr);
                   
                        opc++;
                    }
                    else
                    {
                        op[1] = float.Parse(substr);
                        label1.Text = op[0].ToString();
                        
                    }

                }

                if (gl_opp.Contains(label[i]) || k == i + 1 || (op[0] != 0 && op[1] != 0))
                {
                    switch (gl_operation)
                    {
                        case '+':
                            result = op[0] + op[1];
                            checkoperation = 0;
                            break;

                        case '-':
                            result = op[0] - op[1];
                            checkoperation = 0;
                            break;

                        case '×':
                            result = op[0] * op[1];
                            checkoperation = 1;
                            break;

                        case '÷':
                            try
                            {
                                result = op[0] / op[1];
                            }
                            catch (DivideByZeroException)
                            {
                                label1.Text = "Can't divide by zero";
                            }
                            checkoperation = 1;
                            break;

                        default:
                            label1.Text = "Default ";
                            break;
                    }
                }
            }
            if(checkneg == 1)
            {  if(checkoperation == 1)
                {
                    result = result * -1;
                }
              else if(checkoperation == 0)
                {
                    result = result - op[0] - op[0];
                }
              
            }
            label2.Text = label + " =";
            label1.Text = result.ToString();
            opc = 0;
        }





        private void buttoneql_Click(object sender, EventArgs e)
        {  
          
            if(gl_eqlenabled == true)
            {
                
                operate();
                gl_eqlenabled = false;
          

            }
            else
            {

            }
        

        }

    }
}


