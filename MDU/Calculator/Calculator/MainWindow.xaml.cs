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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;
        string operation = "";
        string output = "";

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
            Divide.Content = "\u00F7";
            Sqrt.Content = "\u221A";
            Square.Content = "X" + "\u00B2";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "Zero":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

                case "One":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "Two":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "Three":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "Four":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "Five":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "Six":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "Seven":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "Eight":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "Nine":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "DecimalBtn":
                    if (!output.Contains("."))
                    {
                        output += ".";
                        OutputTextBlock.Text = output;
                    }
                    break;
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
                switch (operation)
                {
                    case "Minus":
                        double outputTemp = temp - double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;
                    case "Plus":
                        outputTemp = temp + double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;
                    case "Times":
                        outputTemp = temp * double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;
                    case "Divide":
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;
                }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Times";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            output = "";
            OutputTextBlock.Text = output;
        }

        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            double square = double.Parse(output);
            output = (square * square).ToString();
            OutputTextBlock.Text = output;
        }

        private void SqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double sqrt = double.Parse(output);
                output = Math.Sqrt(sqrt).ToString();
                OutputTextBlock.Text = output;
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
                operation = "";
            if (output != "")
            {
                char[] arr = output.ToCharArray(0, output.Length - 1);
                output = String.Concat<char>(arr);
                OutputTextBlock.Text = output;
            }
        }
    }
}
