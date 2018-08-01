using System.Collections.Generic;
using System.Windows.Controls;
using WPFSamples.Common;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for DelegateExample.xaml
    /// </summary>
    public partial class DelegateExample : Page
    {
        public List<OperationType> operationTypes;
        private List<string> values;
        private OperationPerformer operationPerformer;
        public DelegateExample()
        {
            InitializeComponent();
            operationTypes = new List<OperationType>();
            values = new List<string>();
            operationPerformer = new OperationPerformer();
        }

        private void OnCalculatorClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if(e.OriginalSource is Button button)
            {
                if(button.DataContext is Operation operation)
                {
                    if (operation.Type == OperationType.Equal)
                        operationPerformer.Calculate(values,operationTypes);
                    else
                        operationTypes.Add(operation.Type);
                }
                else
                {
                    values.Add(button.Content.ToString());
                }
                
            }
        }
    }
}
