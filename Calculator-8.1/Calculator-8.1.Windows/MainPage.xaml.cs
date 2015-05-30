using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace Calculator_8._1
{
    /// <summary>
    /// 可独立使用或用于导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string first = "", second = "", result = "", formula = "";
        string op = "";
        ObservableCollection<Item> Items;

        public MainPage()
        {
            this.InitializeComponent();
            Items = new ObservableCollection<Item>();
            itemsControl.ItemsSource = Items;
            DataContext = this;
        }

        private void modBt_Click(object sender, RoutedEventArgs e)
        {
            op = modBt.Content.ToString();
            first = numDisplay.Text;
            formulaDisplay.Text = first + "%";
            numDisplay.Text = "0";
        }

        private void sqrtBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            formulaDisplay.Text = "√(" + first + ")";
            result = Math.Sqrt(double.Parse(first)).ToString();
            first = result;
            numDisplay.Text = first;
            formula = formulaDisplay.Text;
            result = numDisplay.Text;
            Items.Add(new Item { Formula = formula + "=", Result = result });
        }

        private void powerBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            formulaDisplay.Text = "sqr(" + first + ")";
            result = Math.Pow(double.Parse(first), 2).ToString();
            first = result;
            numDisplay.Text = first;
            formula = formulaDisplay.Text;
            result = numDisplay.Text;
            Items.Add(new Item { Formula = formula + "=", Result = result });
        }

        private void reciprocalBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            if (first.Equals("") || first.Equals("0"))
            {
                numDisplay.Text = "除数不能为零";
            }
            else
            {
                formulaDisplay.Text = "1/(" + first + ")";
                result = (1 / double.Parse(first)).ToString();
                first = result;
                numDisplay.Text = first;
                formula = formulaDisplay.Text;
                result = numDisplay.Text;
                Items.Add(new Item { Formula = formula + "=", Result = result });
            }
        }

        private void clearBt_Click(object sender, RoutedEventArgs e)
        {
            formulaDisplay.Text = "";
            numDisplay.Text = "0";
            first = "";
            second = "";
            result = "";
        }

        private void delBt_Click(object sender, RoutedEventArgs e)
        {
            numDisplay.Text = "0";
        }

        private void backBt_Click(object sender, RoutedEventArgs e)
        {
            if (!formulaDisplay.Text.Equals("") || result.Equals("") || !numDisplay.Text.Equals("0"))
            {
                numDisplay.Text = numDisplay.Text.Substring(0, numDisplay.Text.Length - 1);
            }
        }

        private void divBt_Click(object sender, RoutedEventArgs e)
        {
            op = divBt.Content.ToString();
            first = numDisplay.Text;
            formulaDisplay.Text = first + "÷";
            numDisplay.Text = "0";
        }

        private void multiBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            op = multiBt.Content.ToString();
            formulaDisplay.Text = first + "×";
            numDisplay.Text = "0";
        }

        private void subBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            op = subBt.Content.ToString();
            formulaDisplay.Text = first + "-";
            numDisplay.Text = "0";
        }

        private void addBt_Click(object sender, RoutedEventArgs e)
        {
            first = numDisplay.Text;
            op = addBt.Content.ToString();
            formulaDisplay.Text = first + "+";
            numDisplay.Text = "0";
        }

        private void equalBt_Click(object sender, RoutedEventArgs e)
        {
            second = numDisplay.Text;
            switch (op)
            {
                case "%":
                    if (second.Equals(""))
                        result = "0";
                    else
                        result = (double.Parse(first) % double.Parse(second)).ToString();
                    numDisplay.Text = result;
                    break;
                case "×":
                    if (second.Equals(""))
                        result = Math.Pow(double.Parse(first), 2).ToString();
                    else
                        result = (double.Parse(first) * double.Parse(second)).ToString();
                    numDisplay.Text = result;
                    break;
                case "÷":
                    if (second.Equals(""))
                        result = "1";
                    else if (second.Equals("0"))
                        result = "除数不能为零";
                    else
                        result = (double.Parse(first) / double.Parse(second)).ToString();
                    numDisplay.Text = result;
                    break;
                case "+":
                    if (second.Equals(""))
                        result = (double.Parse(first) * 2).ToString();
                    else
                        result = (double.Parse(first) + double.Parse(second)).ToString();
                    numDisplay.Text = result;
                    break;
                case "-":
                    if (second.Equals(""))
                        result = "0";
                    else
                        result = (double.Parse(first) - double.Parse(second)).ToString();
                    numDisplay.Text = result;
                    break;
                default:
                    break;
            }
            if (!result.Equals("除数不能为零"))
            {
                formula = first + op + second;
                first = result;
                formulaDisplay.Text = "";
                Items.Add(new Item { Formula = formula + "=", Result = result });
            }
        }

        private void nineBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "9";
            else
                numDisplay.Text += "9";
        }

        private void eightBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "8";
            else
                numDisplay.Text += "8";
        }

        private void sevenBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "7";
            else
                numDisplay.Text += "7";
        }

        private void sixBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "6";
            else
                numDisplay.Text += "6";
        }

        private void fiveBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "5";
            else
                numDisplay.Text += "5";
        }

        private void fourBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "4";
            else
                numDisplay.Text += "4";
        }

        private void threeBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "3";
            else
                numDisplay.Text += "3";
        }

        private void twoBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "2";
            else
                numDisplay.Text += "2";
        }

        private void oneBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "1";
            else
                numDisplay.Text += "1";
        }

        private void dotBt_Click(object sender, RoutedEventArgs e)
        {
            if (!ClickHandler.isDot(numDisplay.Text))
                numDisplay.Text += ".";
        }

        private void zeroBt_Click(object sender, RoutedEventArgs e)
        {
            if (numDisplay.Text.Equals("0"))
                numDisplay.Text = "0";
            else
                numDisplay.Text += "0";
        }

        private void reverseBt_Click(object sender, RoutedEventArgs e)
        {
            numDisplay.Text = "-" + numDisplay.Text;
            result = numDisplay.Text;
            first = result;
        }
    }
}
