using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace LauncherLes1.View
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class MGAMESpage : Page
    {
        public MGAMESpage()
        {
            InitializeComponent();
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "G:\\ауе\\ПроектыВизуалСтудиё\\LauncherLes1\\LauncherLes1\\View\\Res\\MemoryGame1.exe");
            System.Diagnostics.Process.Start(path);

        }
        private void TicTacButton_Click(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "G:\\ауе\\ПроектыВизуалСтудиё\\LauncherLes1\\LauncherLes1\\View\\Res\\Tic-Tac-Toe.exe");
            System.Diagnostics.Process.Start(path);
        }
    }
}
