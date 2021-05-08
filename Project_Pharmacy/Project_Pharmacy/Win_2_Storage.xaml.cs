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
    /// Логика взаимодействия для Win_2_Storage.xaml
    /// </summary>
    public partial class Win_2_Storage : Window
    {
        public Win_2_Storage()
        {
            InitializeComponent();
        }

        private void ButtonClickInfItem(object sender, RoutedEventArgs e)
        {
            Win_2_Storage winStor = this;    // Вызов открытого окна
            Win_1_1_Inf_Of_Item winItemInf = new Win_1_1_Inf_Of_Item();    // Создание нового окна

            winItemInf.Show();    // Проявление созданного окна
            winStor.Close();    // Закрытие основного окна
        }

        private void ButtonClickSupply(object sender, RoutedEventArgs e)
        {
            Win_2_Storage winStor = this;    // Вызов открытого окна
            Win_1_2_Supply winSupp = new Win_1_2_Supply();    // Создание нового окна

            winSupp.Show();    // Проявление созданного окна
            winStor.Close();    // Закрытие основного окна
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_2_Storage winStor = this;    // Вызов открытого окна
            MainWindow mainWin = new MainWindow();    // Создание нового окна

            mainWin.Show();    // Проявление созданного окна
            winStor.Close();    // Закрытие основного окна
        }
    }
}
