using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp20.Pages
{
    public partial class TasksPage : Page
    {
        private int _number;
        private Dictionary<string, TextBox> _inputFields = new Dictionary<string, TextBox>();
        private Func<Dictionary<string, double>, double> _formula;

        public TasksPage(int number, List<string> variables, Func<Dictionary<string, double>, double> formula)
        {
            InitializeComponent();

            _formula = formula;
            _number = number;

            TaskNumberTextBlock.Text = $"Задача №{_number}";


            foreach (var variable in variables)
            {
                var stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 20, 0, 5) };

                stackPanel.Children.Add(new TextBlock
                {
                    Text = variable + ":",
                    Width = 50,
                    FontSize = 16,
                    Margin = new Thickness(0, 10, 0, 0),
                    VerticalAlignment = VerticalAlignment.Center
                });

                var inputField = new TextBox { 
                    Width = 150,
                    FontSize = 14,
                    Margin = new Thickness(0, 5, 0, 0)
                };
                stackPanel.Children.Add(inputField);

                _inputFields[variable] = inputField;
                InputFieldsContainer.Children.Add(stackPanel);
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var values = new Dictionary<string, double>();
                foreach (var kvp in _inputFields)
                {
                    values[kvp.Key] = double.Parse(kvp.Value.Text);
                }

                var result = _formula(values);

                ResultTextBlock.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}