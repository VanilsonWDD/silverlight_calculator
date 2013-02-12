using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace calculadora
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Operations o = new Operations();

            if (optAdd.IsChecked == true)
            {
                double addResult = add(Convert.ToDouble(txtFirstNumber.Text), Convert.ToDouble(txtSecondNumber.Text));
                txtResult.Text = "" + addResult;
            }
            else if (optSub.IsChecked == true)
            {
                double subResult = sub(Convert.ToDouble(txtFirstNumber.Text), Convert.ToDouble(txtSecondNumber.Text));
                txtResult.Text = "" + subResult;
            }
            else if (optMult.IsChecked == true)
            {
                double multResult = mult(Convert.ToDouble(txtFirstNumber.Text), Convert.ToDouble(txtSecondNumber.Text));
                txtResult.Text = "" + multResult;
            }
            else if (optDiv.IsChecked == true)
            {
                double divResult = sub(Convert.ToDouble(txtFirstNumber.Text), Convert.ToDouble(txtSecondNumber.Text));
                txtResult.Text = "" + divResult;
            }
        }
        public double add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double mult(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double div(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
