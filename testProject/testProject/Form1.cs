using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProject
{
    public partial class Form1 : Form
    {

        string _operand1;
        string _operand2;

        bool _operand_check = false;

        int _operate;


        int result = 0;


        public const int _ADD = 1;
        public const int _SUB = 2;
        public const int _MUL = 3;
        public const int _DIV = 4;


        public Form1()
        {
            InitializeComponent();
            InputDataBox.Text = "0";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_operand_check == false)
            {
                _operand1 += "7";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "7";
                InputDataBox.Text = _operand2;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "8";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "8";
                InputDataBox.Text = _operand2;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "9";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "9";
                InputDataBox.Text = _operand2;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "4";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "4";
                InputDataBox.Text = _operand2;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "5";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "5";
                InputDataBox.Text = _operand2;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "6";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "6";
                InputDataBox.Text = _operand2;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "1";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "1";
                InputDataBox.Text = _operand2;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "2";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "2";
                InputDataBox.Text = _operand2;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "3";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "3";
                InputDataBox.Text = _operand2;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += "0";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += "0";
                InputDataBox.Text = _operand2;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_operand_check == false)
            {
                _operand1 += ".";
                InputDataBox.Text = _operand1;
            }
            else
            {
                _operand2 += ".";
                InputDataBox.Text = _operand2;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int changeNum = Convert.ToInt32(InputDataBox.Text);

            _operate = 4;
            if (result == 0)
            {
                txtDataBox.Text = _operand1;
                InputDataBox.Text = "0";
                _operand_check = true;
            }
            else
            {
                if (result.Equals(changeNum))
                {
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand_check = true;
                }
                else
                {
                    result = Convert.ToInt32(InputDataBox.Text);
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand2 = "";
                    _operand_check = true;
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int changeNum = Convert.ToInt32(InputDataBox.Text);

            _operate = 3;
            if (result == 0)
            {
                txtDataBox.Text = _operand1;
                InputDataBox.Text = "0";
                _operand_check = true;
            }
            else
            {
                if (result.Equals(changeNum))
                {
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand_check = true;
                }
                else
                {
                    result = Convert.ToInt32(InputDataBox.Text);
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand2 = "";
                    _operand_check = true;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int changeNum = Convert.ToInt32(InputDataBox.Text);

            _operate = 2;
            if (result == 0)
            {
                txtDataBox.Text = _operand1;
                InputDataBox.Text = "0";
                _operand_check = true;
            }
            else
            {
                if (result.Equals(changeNum))
                {
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand_check = true;
                }
                else
                {
                    result = Convert.ToInt32(InputDataBox.Text);
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand2 = "";
                    _operand_check = true;
                }
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int changeNum = Convert.ToInt32(InputDataBox.Text);

            _operate = 1;
            if(result == 0)
            {
                txtDataBox.Text = _operand1;
                InputDataBox.Text = "0";
                _operand_check = true;
            }
            else
            {
                if (result.Equals(changeNum))
                {
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand_check = true;
                }
                else
                {
                    result = Convert.ToInt32(InputDataBox.Text);
                    _operand1 = result.ToString();
                    txtDataBox.Text = result.ToString();
                    InputDataBox.Text = "0";
                    _operand2 = "";
                    _operand_check = true;
                }
            }

          
        }

        private void button16_Click(object sender, EventArgs e)
        {
          
           ResultNum(_operand1, _operand2);
          
        }

        private void ResultNum(string operand1, string operand2)
        {
            int Num1 = Convert.ToInt32(operand1);
            int Num2 = Convert.ToInt32(operand2);

            try
            {
                switch (_operate)
                {
                    case _ADD:
                        result = Num1 + Num2;
                        txtDataBox.Text = "";
                        InputDataBox.Text = result.ToString();
                        _operand1 = "";
                        _operand2 = "";
                        break;
                    case _SUB:
                        result = Num1 - Num2;
                        txtDataBox.Text = "";
                        InputDataBox.Text = result.ToString();
                        _operand1 = "";
                        _operand2 = "";
                        break;
                    case _MUL:
                        result = Num1 * Num2;
                        txtDataBox.Text = "";
                        InputDataBox.Text = result.ToString();
                        _operand1 = "";
                        _operand2 = "";
                        break;
                    case _DIV:
                        if(Num2 == 0)
                        {
                            result = 0;
                            txtDataBox.Text = "";
                            InputDataBox.Text = result.ToString();
                            _operand1 = "";
                            _operand2 = "";
                        }
                        else
                        {
                            result = Num1 / Num2;
                            txtDataBox.Text = "";
                            InputDataBox.Text = result.ToString();
                            _operand1 = "";
                            _operand2 = "";
                        }
                        break;

                }
                _operand_check = false;

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtDataBox.Text = "";
            InputDataBox.Text = "";
            _operand1 = "";
            _operand2 = "";
            _operand_check = false;
            result = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(_operand_check == false)
            {
                if (_operand1.Length <= 0)
                {
                    return;
                }
                else
                {
                    _operand1 = _operand1.Substring(0, _operand1.Length - 1);
                    InputDataBox.Text = _operand1;
                }
            }
            else
            {
                if (_operand2.Length <= 0)
                {
                    return;
                }
                else
                {
                    _operand2 = _operand2.Substring(0, _operand2.Length - 1);
                    InputDataBox.Text = _operand2;
                }
            }
        }
    }
}
