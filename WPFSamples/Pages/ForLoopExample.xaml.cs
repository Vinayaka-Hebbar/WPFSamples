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

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for ForLoopExample.xaml
    /// </summary>
    public partial class ForLoopExample : Page
    {
        private bool doIncrement = true;
        public ForLoopExample()
        {
            InitializeComponent();
        }

        private void OnForExecute(object sender, RoutedEventArgs e)
        {
            int value = 0;
            int incrementValue = 0;
            int condition = 0;
            int conditionValue = 0;
            try
            {
                ResultBlock.Text = string.Empty;
                if (!string.IsNullOrEmpty(ValueBox.Text))
                {
                    value = int.Parse(ValueBox.Text);
                }
                if(!string.IsNullOrEmpty(ConditionBox.Text))
                {
                    conditionValue = int.Parse(ConditionBox.Text);
                }
                condition = ConditionComboBox.SelectedIndex;
                switch(condition)
                {
                    case 1:
                        for (int count = value; count <= conditionValue; incrementValue = doIncrement ? count++ : count--)
                        {
                            ResultBlock.Text += string.Format(" {0}", count);
                        }
                        break;
                    case 2:
                        for (int count = value; count == conditionValue; incrementValue = doIncrement ? count++ : count--)
                        {
                            ResultBlock.Text += string.Format(" {0}", count);
                        }
                        break;
                    case 3:
                        for (int count = value; count > conditionValue;incrementValue =  doIncrement ? count++:count--)
                        {
                            ResultBlock.Text += string.Format(" {0}",count);
                        }
                        break;
                    case 4:
                        for (int count = value; count >= conditionValue; incrementValue = doIncrement ? count++ : count--)
                        {
                            ResultBlock.Text += string.Format(" {0}", count);
                        }
                        break;
                    default:
                        for (int count = value; count < conditionValue; incrementValue = doIncrement ? count++ : count--)
                        {
                            ResultBlock.Text += string.Format(" {0}", count);
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                ResultBlock.Text = string.Format("Exception = {0}\nStackTrace = {1}", ex.Message, ex.StackTrace);
            }
        }

        private void OnIncrementChecked(object sender, RoutedEventArgs e)
        {
            doIncrement = true;
        }

        private void DoDecrementChecked(object sender, RoutedEventArgs e)
        {
            doIncrement = false;
        }
    }
}
