using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Please fill in the amount.");
            }

            else if (string.IsNullOrEmpty((string)toComboBox.SelectedItem) || string.IsNullOrEmpty((string)fromComboBox.SelectedItem))
            {
                MessageBox.Show("Please choose the currency first.");
            }

            else
            {
                //from IDR to ...

                if (fromComboBox.SelectedItem == "IDR - Indonesian Rupiah" && toComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi")
                {
                    Double conv = Double.Parse(textBox.Text) / 2203.65;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-cn"));
                }
                if (fromComboBox.SelectedItem == "IDR - Indonesian Rupiah" && toComboBox.SelectedItem == "EUR - Euro")
                {
                    Double conv = Double.Parse(textBox.Text) / 16983.9;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                }
                if (fromComboBox.SelectedItem == "IDR - Indonesian Rupiah" && toComboBox.SelectedItem == "USD - US Dollar")
                {
                    Double conv = Double.Parse(textBox.Text) / 14415.6;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
                }
                if (fromComboBox.SelectedItem == "IDR - Indonesian Rupiah" && toComboBox.SelectedItem == "IDR - Indonesian Rupiah")
                {
                    Double conv = Double.Parse(textBox.Text); ;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-id"));
                }

                //from USD to ...

                if (fromComboBox.SelectedItem == "USD - US Dollar" && toComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi")
                {
                    Double conv = Double.Parse(textBox.Text) * 6.54;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-cn"));
                }
                if (fromComboBox.SelectedItem == "USD - US Dollar" && toComboBox.SelectedItem == "EUR - Euro")
                {
                    Double conv = Double.Parse(textBox.Text) * 0.85;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                }
                if (fromComboBox.SelectedItem == "USD - US Dollar" && toComboBox.SelectedItem == "IDR - Indonesian Rupiah")
                {
                    Double conv = Double.Parse(textBox.Text) * 14415.6;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-id"));
                }
                if (fromComboBox.SelectedItem == "USD - US Dollar" && toComboBox.SelectedItem == "USD - US Dollar")
                {
                    Double conv = Double.Parse(textBox.Text); ;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
                }

                //from EUR to ...
                if (fromComboBox.SelectedItem == "EUR - Euro" && toComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi")
                {
                    Double conv = Double.Parse(textBox.Text) * 7.72;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-cn"));
                }
                if (fromComboBox.SelectedItem == "EUR - Euro" && toComboBox.SelectedItem == "USD - US Dollar")
                {
                    Double conv = Double.Parse(textBox.Text) / 0.85;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
                }
                if (fromComboBox.SelectedItem == "EUR - Euro" && toComboBox.SelectedItem == "IDR - Indonesian Rupiah")
                {
                    Double conv = Double.Parse(textBox.Text) * 16983.9;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-id"));
                }
                if (fromComboBox.SelectedItem == "EUR - Euro" && toComboBox.SelectedItem == "EUR - Euro")
                {
                    Double conv = Double.Parse(textBox.Text); ;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                }

                //from CNY to ...
                if (fromComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi" && toComboBox.SelectedItem == "EUR - Euro")
                {
                    Double conv = Double.Parse(textBox.Text) / 7.72;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                }
                if (fromComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi" && toComboBox.SelectedItem == "USD - US Dollar")
                {
                    Double conv = Double.Parse(textBox.Text) / 6.54;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
                }
                if (fromComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi" && toComboBox.SelectedItem == "IDR - Indonesian Rupiah")
                {
                    Double conv = Double.Parse(textBox.Text) * 2203.65;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-id"));
                }
                if (fromComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi" && toComboBox.SelectedItem == "CNY - Chinese Yuan Renminbi")
                {
                    Double conv = Double.Parse(textBox.Text); ;
                    labelConverted.Text = conv.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                }
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
