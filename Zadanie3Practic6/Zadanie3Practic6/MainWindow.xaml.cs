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

namespace Zadanie3Practic6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int Sign(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        void BtnOK_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(TbNumberA.Text);
            double b = Convert.ToInt32(TbNumberB.Text);

            int signA = Sign(a);
            int signB = Sign(b);
            int result = signA + signB;

            TextBlockAnswer.Text = $"{result}";
        }
    }
}
