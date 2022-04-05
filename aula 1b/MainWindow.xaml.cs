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
using System.Media;

namespace aula_1b
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var soundPlayer = new SoundPlayer(@"C:\Users\2020102011064-2\Desktop\Artur\aula 1b\aula 1b\X2Download.com-Windows-XP-Startup-Sound-_128-kbps_.wav");
            soundPlayer.Play(); 
            
            Window window1 = new Window1();
            window1.ShowDialog();
        }
    }
}
