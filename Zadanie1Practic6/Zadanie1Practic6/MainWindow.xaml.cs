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

namespace Zadanie1Practic6
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
        void BtnOK_Click(object sender, EventArgs e)
        {
            int min(int a, int b)
            {
                if (a < b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }

            int x = Convert.ToInt32(TbNumberA.Text);
            int y = Convert.ToInt32(TbNumberB.Text);
            int z = Convert.ToInt32(TbNumberC.Text);
            int v = Convert.ToInt32(TbNumberD.Text);

            int min1 = min(x, y);
            int min2 = min(z, v);
            int result = min(min1, min2);

            TextBlockAnswer.Text = $"{result}";

        }
    }
}
