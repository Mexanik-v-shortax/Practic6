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

namespace Zadanie2Practic6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static int f(int x)
        {
            int a = x / 100; // первая цифра
            int b = x % 10; // последняя цифра
            int c = (x / 10) % 10; // средняя цифра

            return b * 100 + c * 10 + a;
        }
        void BtnOK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TbNumberA.Text);
            int y = f(x);
            TextBlockAnswer.Text = $" {y}";
        }
    }
}
