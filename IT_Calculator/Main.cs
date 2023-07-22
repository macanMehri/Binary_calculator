using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Calculator.SorceFiles;

namespace IT_Calculator
{
    public partial class Main : Form
    {
        int old_type;
        int type;
        int type1 = 0;
        int old_type1 = 0;
        int sub;
        Octals.Octal octal = new Octals.Octal();
        Octals.Octal octal2 = new Octals.Octal();
        Bin.Binary binary = new Bin.Binary();
        Bin.Binary binary2 = new Bin.Binary();
        Dec.Decimal dec = new Dec.Decimal();
        Dec.Decimal dec2 = new Dec.Decimal();
        public Main()
        {
            InitializeComponent();
            resultComboBox.SelectedIndex = 0;
            numComboBox.SelectedIndex = 0;
        }


        private void resultComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                type = resultComboBox.SelectedIndex;
                if (type == 1 && old_type == 0)
                {
                    binary.string_to_binary(resultTxt.Text);
                    octal = binary.binary_to_octal();
                    resultTxt.Text = octal.ToString();
                }
                else if (type == 2 && old_type == 0)
                {
                    binary.string_to_binary(resultTxt.Text);
                    dec = binary.binary_to_decimal();
                    resultTxt.Text = dec.ToString();
                }
                else if (type == 0 && old_type == 1)
                {
                    octal.string_to_octal(resultTxt.Text);
                    binary = octal.octal_to_binary();
                    resultTxt.Text = binary.ToString();
                }
                else if (type == 0 && old_type == 2)
                {
                    dec.string_to_decimal(resultTxt.Text);
                    binary = dec.decimal_to_binary();
                    resultTxt.Text = binary.ToString();
                }
                else if (type == 1 && old_type == 2)
                {
                    dec.string_to_decimal(resultTxt.Text);
                    binary = dec.decimal_to_binary();
                    octal = binary.binary_to_octal();
                    resultTxt.Text = octal.ToString();
                }
                else if (type == 2 && old_type == 1)
                {
                    octal.string_to_octal(resultTxt.Text);
                    binary = octal.octal_to_binary();
                    dec = binary.binary_to_decimal();
                    resultTxt.Text = dec.ToString();
                }

                old_type = resultComboBox.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }
        }

        public void clear()
        {
            resultTxt.Clear();
            number1txt.Clear();
            number2txt.Clear();
            numComboBox.SelectedIndex = 0;
            resultComboBox.SelectedIndex = 0;
        }

        private void sumBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                type = numComboBox.SelectedIndex;
                if (type == 0)
                {
                    binary.string_to_binary(number1txt.Text);
                    binary2.string_to_binary(number2txt.Text);
                    resultTxt.Text = binary.binary_adder(binary2).ToString();
                }
                else if (type == 1)
                {
                    octal.string_to_octal(number1txt.Text);
                    octal2.string_to_octal(number2txt.Text);
                    binary = octal.octal_to_binary();
                    binary2 = octal2.octal_to_binary();
                    resultTxt.Text = binary.binary_adder(binary2).ToString();
                }
                else if (type == 2)
                {
                    dec.string_to_decimal(number1txt.Text);
                    dec2.string_to_decimal(number2txt.Text);
                    binary = dec.decimal_to_binary();
                    binary2 = dec2.decimal_to_binary();
                    resultTxt.Text = binary.binary_adder(binary2).ToString();
                }
                resultComboBox.SelectedIndex = type;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }
        }

        private void subBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                type = numComboBox.SelectedIndex;
                if (type == 0)
                {
                    binary.string_to_binary(number1txt.Text);
                    binary2.string_to_binary(number2txt.Text);
                    dec = binary.binary_to_decimal();
                    dec2 = binary2.binary_to_decimal();
                }
                else if (type == 1)
                {
                    octal.string_to_octal(number1txt.Text);
                    octal2.string_to_octal(number2txt.Text);
                    binary = octal.octal_to_binary();
                    binary2 = octal2.octal_to_binary();
                    dec = binary.binary_to_decimal();
                    dec2 = binary2.binary_to_decimal();
                }
                else if (type == 2)
                {
                    dec.string_to_decimal(number1txt.Text);
                    dec2.string_to_decimal(number2txt.Text);
                }
                sub = dec.list_to_int() - dec2.list_to_int();
                resultTxt.Text = Convert.ToString(sub);
                old_type = 3;
                resultComboBox.SelectedIndex = numComboBox.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void numComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                type1 = numComboBox.SelectedIndex;
                if (type1 == 1 && old_type1 == 0)
                {
                    binary.string_to_binary(number1txt.Text);
                    binary2.string_to_binary(number2txt.Text);
                    octal = binary.binary_to_octal();
                    octal2 = binary2.binary_to_octal();
                    number1txt.Text = octal.ToString();
                    number2txt.Text = octal2.ToString();
                }
                else if (type1 == 2 && old_type1 == 0)
                {
                    binary.string_to_binary(number1txt.Text);
                    binary2.string_to_binary(number2txt.Text);
                    dec = binary.binary_to_decimal();
                    dec2 = binary2.binary_to_decimal();
                    number1txt.Text = dec.ToString();
                    number2txt.Text = dec2.ToString();
                }
                else if (type1 == 0 && old_type1 == 1)
                {
                    octal.string_to_octal(number1txt.Text);
                    octal2.string_to_octal(number2txt.Text);
                    binary = octal.octal_to_binary();
                    binary2 = octal2.octal_to_binary();
                    number1txt.Text = binary.ToString();
                    number2txt.Text = binary2.ToString();
                }
                else if (type1 == 0 && old_type1 == 2)
                {
                    dec.string_to_decimal(number1txt.Text);
                    dec2.string_to_decimal(number2txt.Text);
                    binary = dec.decimal_to_binary();
                    binary2 = dec2.decimal_to_binary();
                    number1txt.Text = binary.ToString();
                    number2txt.Text = binary2.ToString();
                }
                else if (type1 == 1 && old_type1 == 2)
                {
                    dec.string_to_decimal(number1txt.Text);
                    dec2.string_to_decimal(number2txt.Text);
                    binary = dec.decimal_to_binary();
                    binary2 = dec2.decimal_to_binary();
                    octal = binary.binary_to_octal();
                    octal2 = binary2.binary_to_octal();
                    number1txt.Text = octal.ToString();
                    number2txt.Text = octal2.ToString();
                }
                else if (type1 == 2 && old_type1 == 1)
                {
                    octal.string_to_octal(number1txt.Text);
                    octal2.string_to_octal(number2txt.Text);
                    binary = octal.octal_to_binary();
                    binary2 = octal2.octal_to_binary();
                    dec = binary.binary_to_decimal();
                    dec2 = binary2.binary_to_decimal();
                    number1txt.Text = dec.ToString();
                    number2txt.Text = dec2.ToString();
                }
                old_type1 = numComboBox.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
