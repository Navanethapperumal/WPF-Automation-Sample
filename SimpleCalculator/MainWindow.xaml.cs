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

namespace SimpleCalculator
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double Number1 = Convert.ToDouble(firstNumber.Text);
            double Number2 = Convert.ToDouble(secondNumber.Text);

            double result;

            if (addRadioButton.IsChecked.Value)
            {
                result = Number1 + Number2;
            }else if(subRadioButton.IsChecked.Value)
            {
                result = Number1 - Number2;
            }else if(multiplyRadioButton.IsChecked.Value)
            {
                result = Number1 * Number2;
            }
            else
            {
                result = Number1 / Number2;
            }

            resultTxtBox.Text = result.ToString();
        }
    }
}
