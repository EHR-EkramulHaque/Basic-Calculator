using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.Text)
            {
                case "+":
                    if (lbl_Operation.Text == txt_Expression.Text)
                    {
                        txt_Expression.Text = "";
                        lbl_Operation.Text += "+";
                    }
                    if (txt_Expression.Text.Length >= 1 && txt_Expression.Text != ".")
                    {
                        if(lbl_Operation.Text.Contains("+") || lbl_Operation.Text.Contains("-") || lbl_Operation.Text.Contains("*") || lbl_Operation.Text.Contains("/"))
                        {
                            MessageBox.Show("This Calculator can perform 1 Operation at a time");
                        }
                        else
                        {
                            lbl_Operation.Text += txt_Expression.Text + "+";
                            txt_Expression.Text = "";
                            txt_Expression.Focus();
                            txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        }
                    }
                    break;
                case "X":

                    if (lbl_Operation.Text == txt_Expression.Text)
                    {
                        txt_Expression.Text = "";
                        lbl_Operation.Text += "*";
                    }
                    if (txt_Expression.Text.Length >= 1 && txt_Expression.Text != ".")
                    {
                        if (lbl_Operation.Text.Contains("+") || lbl_Operation.Text.Contains("-") || lbl_Operation.Text.Contains("*") || lbl_Operation.Text.Contains("/"))
                        {
                            MessageBox.Show("This Calculator can perform 1 Operation at a time");
                        }
                        else
                        {
                            lbl_Operation.Text += txt_Expression.Text + "*";
                            txt_Expression.Text = "";
                            txt_Expression.Focus();
                            txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        }
                    }
                    break;
                case "_":
                    if (lbl_Operation.Text == txt_Expression.Text)
                    {
                        txt_Expression.Text = "";
                        lbl_Operation.Text += "-";
                    }
                    if (txt_Expression.Text.Length >= 1 && txt_Expression.Text != ".")
                    {
                        if (lbl_Operation.Text.Contains("+") || lbl_Operation.Text.Contains("-") || lbl_Operation.Text.Contains("*") || lbl_Operation.Text.Contains("/"))
                        {
                            MessageBox.Show("This Calculator can perform 1 Operation at a time");
                        }
                        else
                        {
                            lbl_Operation.Text += txt_Expression.Text + "-";
                            txt_Expression.Text = "";
                            txt_Expression.Focus();
                            txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        }
                    }
                    break;
                case "/":
                    if (lbl_Operation.Text == txt_Expression.Text)
                    {
                        txt_Expression.Text = "";
                        lbl_Operation.Text += "/";
                    }
                    if (txt_Expression.Text.Length >= 1 && txt_Expression.Text != ".")
                    {
                        if (lbl_Operation.Text.Contains("+") || lbl_Operation.Text.Contains("-") || lbl_Operation.Text.Contains("*") || lbl_Operation.Text.Contains("/"))
                        {
                            MessageBox.Show("This Calculator can perform 1 Operation at a time");
                        }
                        else
                        {
                            lbl_Operation.Text += txt_Expression.Text + "/";
                            txt_Expression.Text = "";
                            txt_Expression.Focus();
                            txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        }
                    }
                    break;
                case "CLR":
                    lbl_Operation.Text = "";
                    txt_Expression.Text = "";
                    break;
            }
        }
        private void btn_EQUAL_Click(object sender, EventArgs e)
        {
            if (lbl_Operation.Text == txt_Expression.Text)
            {
                return;
            }
            string expression = lbl_Operation.Text;
            if(txt_Expression.Text.Length>=1 && txt_Expression.Text != ".")
            {
                expression += txt_Expression.Text;
            }
            string lastCharacter = expression.Substring(expression.Length-1,1);
            if (lastCharacter=="+" || lastCharacter == "-" || lastCharacter == "*" || lastCharacter == "/")
            {
                expression = expression.Substring(0, expression.Length - 1);
            }

            if (expression.Contains("+") || expression.Contains("-") || expression.Contains("*") || expression.Contains("/"))
            {
                string[] arr;
                double result;
                if (expression.Contains("+"))
                {
                    arr = expression.Split('+');
                    result = double.Parse(arr[0]) + double.Parse(arr[1]);
                }
                else if(expression.Contains("-"))
                {
                    arr = expression.Split('-');
                    result = double.Parse(arr[0]) - double.Parse(arr[1]);
                }
                else if (expression.Contains("*"))
                {
                    arr = expression.Split('*');
                    result = double.Parse(arr[0]) * double.Parse(arr[1]);
                }
                else
                {
                    arr = expression.Split('/');
                    result = double.Parse(arr[0]) / double.Parse(arr[1]);
                }
                lbl_Operation.Text = expression;
                txt_Expression.Text = result.ToString();
            }
            else
            {
                lbl_Operation.Text = expression;
                txt_Expression.Text = expression;
            }

        }

        private void btn_Number_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;

                switch (clickedButton.Text)
                {
                    case "0":
                        txt_Expression.Text += "0";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "1":
                        txt_Expression.Text += "1";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "2":
                        txt_Expression.Text += "2";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "3":
                        txt_Expression.Text += "3";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "4":
                        txt_Expression.Text += "4";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "5":
                        txt_Expression.Text += "5";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "6":
                        txt_Expression.Text += "6";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "7":
                        txt_Expression.Text += "7";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "8":
                        txt_Expression.Text += "8";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case "9":
                        txt_Expression.Text += "9";
                        txt_Expression.Focus();
                        txt_Expression.SelectionStart = txt_Expression.Text.Length;
                        break;
                    case ".":
                        if (!txt_Expression.Text.Contains("."))
                        {
                            txt_Expression.Text += ".";
                        }
                        break;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Enter Valid Numbers");
            }
        }

        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No char accepted except numbers and dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
