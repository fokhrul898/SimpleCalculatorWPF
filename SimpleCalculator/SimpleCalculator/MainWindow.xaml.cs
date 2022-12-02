using SimpleCalculator.ViewModels;
using System.Windows;

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       CalculatorModelView ViewModel;
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new CalculatorModelView();
            this.DataContext = ViewModel;
        }
    }
}
