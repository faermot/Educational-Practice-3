using ConsoleApp23.Utils;
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
using WpfApp20.Pages;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var variables = new List<string> { "x", "a", "c" };
            MainFrame.Navigate(new TasksPage(1, variables, Task1.Calculate));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Закрытие приложения
        }

        private void OpenTask1(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "x", "y", "f"};
            MainFrame.Navigate(new TasksPage(1, variables, Task1.Calculate));
        }

        private void OpenTask2(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "d", "y"};
            MainFrame.Navigate(new TasksPage(2, variables, Task2.Calculate));
        }

        private void OpenTask3(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "k", "y", "e"};
            MainFrame.Navigate(new TasksPage(3, variables, Task3.Calculate));
        }

        private void OpenTask4(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "x", "y", "w" };
            MainFrame.Navigate(new TasksPage(4, variables, Task4.Calculate));
        }

        private void OpenTask5(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "a", "y", "e", "t"};
            MainFrame.Navigate(new TasksPage(5, variables, Task5.Calculate));
        }

        private void OpenTask6(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "i", "y"};
            MainFrame.Navigate(new TasksPage(6, variables, Task6.Calculate));
        }

        private void OpenTask7(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "m", "y" };
            MainFrame.Navigate(new TasksPage(7, variables, Task7.Calculate));
        }

        private void OpenTask8(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "t", "y" };
            MainFrame.Navigate(new TasksPage(8, variables, Task8.Calculate));
        }

        private void OpenTask9(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "w", "y" };
            MainFrame.Navigate(new TasksPage(9, variables, Task9.Calculate));
        }

        private void OpenTask10(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "t", "y" };
            MainFrame.Navigate(new TasksPage(10, variables, Task10.Calculate));
        }

        private void OpenTask11(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "n", "y" };
            MainFrame.Navigate(new TasksPage(11, variables, Task11.Calculate));
        }

        private void OpenTask12(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "t", "y" };
            MainFrame.Navigate(new TasksPage(12, variables, Task12.Calculate));
        }

        private void OpenTask13(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "h", "y", "e"};
            MainFrame.Navigate(new TasksPage(13, variables, Task13.Calculate));
        }

        private void OpenTask14(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "h", "y", "e"};
            MainFrame.Navigate(new TasksPage(14, variables, Task14.Calculate));
        }

        private void OpenTask15(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "j", "y"};
            MainFrame.Navigate(new TasksPage(15, variables, Task15.Calculate));
        }

        private void OpenTask16(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "e", "y", "r", "t"};
            MainFrame.Navigate(new TasksPage(16, variables, Task16.Calculate));
        }

        private void OpenTask17(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "n", "y"};
            MainFrame.Navigate(new TasksPage(17, variables, Task17.Calculate));
        }

        private void OpenTask18(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "k", "y"};
            MainFrame.Navigate(new TasksPage(18, variables, Task18.Calculate));
        }

        private void OpenTask19(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "q", "y"};
            MainFrame.Navigate(new TasksPage(19, variables, Task19.Calculate));
        }

        private void OpenTask20(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "t", "y", "l", "e" };
            MainFrame.Navigate(new TasksPage(20, variables, Task20.Calculate));
        }

        private void OpenTask21(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "k", "p", "d", "x" };
            MainFrame.Navigate(new TasksPage(21, variables, Task21.Calculate));
        }

        private void OpenTask22(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "t", "y"};
            MainFrame.Navigate(new TasksPage(22, variables, Task22.Calculate));
        }

        private void OpenTask23(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "d", "y", "e"};
            MainFrame.Navigate(new TasksPage(23, variables, Task23.Calculate));
        }

        private void OpenTask24(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "k", "y", "e"};
            MainFrame.Navigate(new TasksPage(24, variables, Task24.Calculate));
        }

        private void OpenTask25(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "c", "t"};
            MainFrame.Navigate(new TasksPage(25, variables, Task25.Calculate));
        }

        private void OpenTask26(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "y", "u"};
            MainFrame.Navigate(new TasksPage(26, variables, Task26.Calculate));
        }

        private void OpenTask27(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "y", "p"};
            MainFrame.Navigate(new TasksPage(27, variables, Task27.Calculate));
        }

        private void OpenTask28(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "v", "p", "y"};
            MainFrame.Navigate(new TasksPage(28, variables, Task28.Calculate));
        }

        private void OpenTask29(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "h", "e", "y"};
            MainFrame.Navigate(new TasksPage(29, variables, Task29.Calculate));
        }

        private void OpenTask30(object sender, MouseButtonEventArgs e)
        {
            var variables = new List<string> { "p", "e", "y"};
            MainFrame.Navigate(new TasksPage(30, variables, Task30.Calculate));
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            this.DragMove();
        }
    }
}
