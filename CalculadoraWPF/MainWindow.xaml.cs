using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double a;
        double b;
        string c;
        bool total = false;
        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "0";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "0";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "1";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "1";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "2";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "2";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "3";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "3";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "4";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "4";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "5";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "5";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "6";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "6";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "7";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "7";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "8";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "8";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
                this.txtboxscreen.Clear();
            try
            {
                if (txtboxscreen.Text == "")
                    txtboxscreen.Text = "9";
                else
                    txtboxscreen.Text = txtboxscreen.Text + "9";
            }
            catch
            {
                MessageBox.Show("error in the system");
            }
        }

        private void btplus_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length < 1)
                txtboxscreen.Clear();
            else
            {
                a = Convert.ToDouble(txtboxscreen.Text);
                c = "+";
                txtboxscreen.Clear();
            }
            //this.txtboxscreen.Focus();
        }

        private void btsubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length < 1)
                txtboxscreen.Clear();
            else
            {
                a = Convert.ToDouble(txtboxscreen.Text);
                c = "-";
                txtboxscreen.Clear();
            }
            //this.txtboxscreen.Focus();
        }

        private void btproduct_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length < 1)
                txtboxscreen.Clear();
            else
            {
                a = Convert.ToDouble(txtboxscreen.Text);
                c = "*";
                txtboxscreen.Clear();
            }
            //this.txtboxscreen.Focus();
        }

        private void btdiv_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length < 1)
                txtboxscreen.Clear();
            else
            {
                a = Convert.ToDouble(txtboxscreen.Text);
                c = "/";
                txtboxscreen.Clear();
            }
            //this.txtboxscreen.Focus();
        }

        private void btequal_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length < 1)
                txtboxscreen.Clear();
            else
            {
                //txtboxscreen.Text = txtboxscreen.Text + 2;
                b = Convert.ToDouble(txtboxscreen.Text);
                switch (c)
                {
                    case "+":
                        txtboxscreen.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        txtboxscreen.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        txtboxscreen.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        txtboxscreen.Text = Convert.ToString(a / b);
                        break;
                }
                total = true;
            }
            total = false;// Restablecer total a false después de mostrar el resultado
        }

        private void btonlyclean_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length == 1)
                txtboxscreen.Text = "";
            else
            {
                if (txtboxscreen.Text.Length > 1)
                    txtboxscreen.Text = txtboxscreen.Text.Remove(txtboxscreen.Text.Length - 1);
                    //txbScreen.Text = txbScreen.Text.Substring(0, txbScreen.Text.Length - 1);
                else
                    txtboxscreen.Clear();
            }
                
        }

        private void btdot_Click(object sender, RoutedEventArgs e)
        {
            //Button Clean
            a = 0;
            b = 0;
            this.txtboxscreen.Clear();
        }
    }
}
