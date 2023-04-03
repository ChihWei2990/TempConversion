using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        bool ignore = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            ConvertFromKelvin();
        }

        private void btn_fahrenheight_Click(object sender, EventArgs e)
        {
            ConvertFromFahren();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            ConvertFromCelsius();
        }

        private void ConvertFromFahren()
        {
            if (ignore)
            {
                return;
            }

            ignore = true;

            float fahren = FloatFromTxtBox(txt_fahrenheight.Text);

            float celcius = 5f / 9 * (fahren - 32);
            txt_celsius.Text = celcius.ToString();

            txt_kelvin.Text = (celcius + 273).ToString();

            ignore = false;
        }

        private void ConvertFromKelvin()
        {
            if (ignore)
            {
                return;
            }

            ignore = true;

            float kelvin = FloatFromTxtBox(txt_kelvin.Text);

            txt_celsius.Text = (kelvin - 273).ToString();
            txt_fahrenheight.Text = ((kelvin - 273) * 9 / 5f + 32).ToString();

            ignore = false;
        }

        private void ConvertFromCelsius()
        {
            if (ignore)
            {
                return;
            }

            ignore = true;

            float celsius = FloatFromTxtBox(txt_celsius.Text);
            txt_fahrenheight.Text = (celsius * 9 / 5f + 32).ToString();
            txt_kelvin.Text = (celsius + 273).ToString();

            ignore = false;
        }

        private float FloatFromTxtBox(string txtBox)
        {
            try
            {
                return float.Parse(txtBox);
            }
            catch
            {
                MessageBox.Show("input only integers");
            }
            return 0;
        }


        private void onTxtKelvinChanged(object sender, EventArgs e)
        {
            if (txt_kelvin.Text == "")
            {
                return;
            }
            ConvertFromKelvin();
        }

        private void onTxtFahrenChanged(object sender, EventArgs e)
        {
            if (txt_fahrenheight.Text == "")
            {
                return;
            }
            ConvertFromFahren();
        }

        private void onTxtCelsiusChanged(object sender, EventArgs e)
        {
            if(txt_celsius.Text == "")
            {
                return;
            }
            ConvertFromCelsius();
        }
    }
}
