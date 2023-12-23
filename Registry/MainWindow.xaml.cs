using Microsoft.Win32;
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

namespace Registry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RegistryKey key = Microsoft.Win32.Registry.CurrentUser;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Height = double.Parse(box.Text);
            key.SetValue("height", Height);
            Width = double.Parse(box_.Text);
            key.SetValue("width", Width);
            Height = double.Parse(key.GetValue("height").ToString());
            Width = double.Parse(key.GetValue("width").ToString());
            block3.Text = $"{Height}; {Width}";
        }
    }
}