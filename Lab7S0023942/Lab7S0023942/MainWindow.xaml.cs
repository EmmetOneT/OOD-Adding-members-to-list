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

namespace Lab7S0023942
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //will run when window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expense e1 = new Expense()
            {
                Category = "Travel",
                Amount = 19.95m,
                ExpenseDate = new DateTime(2019, 6, 30)
            };
            Expense e2 = new Expense()
            {
                Category = "Entertainent",
                Amount = 99.95m,
                ExpenseDate = new DateTime(2019, 6, 30)
            };
            Expense e3 = new Expense()
            {
                Category = "TOffic",
                Amount = 9.99m,
                ExpenseDate = new DateTime(2019, 6, 30)
            };

            List<Expense> expenses = new List<Expense>();
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            lbxExpenses.ItemsSource = expenses;


        }
    }
}
