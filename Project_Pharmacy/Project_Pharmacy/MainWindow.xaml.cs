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

namespace Project_Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string StuffId;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickOrder(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = this;    // Вызов открытого окна
            Win_1_Order winOrd = new Win_1_Order();    // Создание нового окна
            winOrd.Show();    // Проявление созданного окна
            mainWin.Close();    // Закрытие основного окна
        }

        private void ButtonClickStorage(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = this;    // Вызов открытого окна
            Win_2_Storage winStor = new Win_2_Storage();    // Создание нового окна

            winStor.Show();    // Проявление созданного окна
            mainWin.Close();    // Закрытие основного окна
        }
    }
}
