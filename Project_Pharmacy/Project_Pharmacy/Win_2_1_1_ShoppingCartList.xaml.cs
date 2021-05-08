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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Project_Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для Win_2_1_1_ShoppingCartList.xaml
    /// </summary>
    public partial class Win_2_1_1_ShoppingCartList : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        SqlConnection connection = null;
        DataTable supplTable;
        string sql = "SELECT * from Basket";
        public string stuffid = Login.StuffId;
        public Win_2_1_1_ShoppingCartList()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_2_1_1_ShoppingCartList winShopCartList = this;    // Вызов открытого окна
            Win_2_1_New_Order winNewOrd = new Win_2_1_New_Order();    // Создание нового окна

            winNewOrd.Show();    // Проявление созданного окна
            winShopCartList.Close();    // Закрытие основного окна
        }

        private void ButtonClickGood(object sender, RoutedEventArgs e)
        {
            Win_1_1_Inf_Of_Item winItemInf = new Win_1_1_Inf_Of_Item();
            winItemInf.Owner = this;
            winItemInf.Show();

        }

        private void ButtonClickAdd(object sender, RoutedEventArgs e)
        {
            connection.Open();
            string tov = IdTovar.Text ;
            string kolv = Kolvo.Text ;
                var selectCommand = connection.CreateCommand(); // создаем команду для запроса
            selectCommand.CommandText = $"INSERT INTO Basket (IdItem, IdOrder, Amount) values('{tov}', '{Win_2_1_New_Order.order}', '{kolv}')";//прописываем запрос
            var reader = selectCommand.ExecuteReader();
            reader.Close();
            connection.Close();
        }
        private void UpdateDB()
        {

            try
            {
                supplTable.Clear();
                connection.Close();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(supplTable);
                Suppl.ItemsSource = supplTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void ButtonClickUpdate(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            supplTable = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(supplTable);
                Suppl.ItemsSource = supplTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
