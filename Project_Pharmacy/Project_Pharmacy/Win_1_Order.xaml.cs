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
using System.Windows.Shapes;

namespace Project_Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для Win_1_Order.xaml
    /// </summary>
    public partial class Win_1_Order : Window
    {
        public Win_1_Order()
        {
            InitializeComponent();
        }

        private void ButtonClickNewOrder(object sender, RoutedEventArgs e)
        {
            Win_1_Order winOrd = this;    // Вызов открытого окна
            Win_2_1_New_Order winNewOrd = new Win_2_1_New_Order();    // Создание нового окна
            winNewOrd.Show();    // Проявление созданного окна
            winOrd.Close();    // Закрытие основного окна
        }

        private void ButtonClickOrderHistory(object sender, RoutedEventArgs e)
        {
            Win_1_Order winOrd = this;    // Вызов открытого окна
            Win_2_2_Hist_Order winHistOrd = new Win_2_2_Hist_Order();    // Создание нового окна

            winHistOrd.Show();    // Проявление созданного окна
            winOrd.Close();    // Закрытие основного окна
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_1_Order winOrd = this;    // Вызов открытого окна
            MainWindow mainWin = new MainWindow();    // Создание нового окна

            mainWin.Show();    // Проявление созданного окна
            winOrd.Close();    // Закрытие основного окна
        }
    }
}
