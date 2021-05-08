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
    /// Логика взаимодействия для Win_2_1_New_Order.xaml
    /// </summary>
    public partial class Win_2_1_New_Order : Window
    {
        static public string customer;
        static public string order;
        string connectionString;
        SqlDataAdapter adapter;
        SqlConnection connection = null;
        DataTable supplTable;
        string sql = "SELECT * from Order";
        public string stuffid = Login.StuffId;
        public Win_2_1_New_Order()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonClickShopCart(object sender, RoutedEventArgs e)
        {
            Win_2_1_New_Order winNewOrd = this;    // Вызов открытого окна
            Win_2_1_1_ShoppingCartList winShopCart = new Win_2_1_1_ShoppingCartList();    // Создание нового окна

            winShopCart.Show();    // Проявление созданного окна
            winNewOrd.Close();    // Закрытие основного окна
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_2_1_New_Order winNewOrd = this;    // Вызов открытого окна
            Win_1_Order winOrd = new Win_1_Order();    // Создание нового окна

            winOrd.Show();    // Проявление созданного окна
            winNewOrd.Close();    // Закрытие основного окна
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
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

        private void ButtonClEnter(object sender, RoutedEventArgs e)
        {
            string imm = Ima.Text;
            string fam = Famil.Text;
            string tel = Telefon.Text;
            string poch = Pochta.Text;
            sql = $"INSERT INTO Customer (FirstName, LastName, PhoneNumber, EMail) values ('{imm}', '{fam}', '{tel}', '{poch}')";
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            var selectCommand = connection.CreateCommand(); // создаем команду для запроса
            selectCommand.CommandText = sql;//прописываем запрос
            var reader = selectCommand.ExecuteReader();
            reader.Close();

            selectCommand.CommandText = "select max(IdCustomer) from Customer";//прописываем запрос
            reader = selectCommand.ExecuteReader(); //результат возвращаем в reader
            if (reader.Read()) //и считываем построчно
                customer = Convert.ToString(reader.GetInt32(0));
            IdCust.Text = customer;
            reader.Close(); //закрываем reader

            
            selectCommand.CommandText = $"Insert into [Order] (IdCustomer, IdStaff, CustDateOfTheVisit) values('{customer}', '{Login.StuffId}', getdate())";//прописываем запрос
            reader = selectCommand.ExecuteReader();
            reader.Close();

            selectCommand.CommandText = "select max(IdOrder) from [Order]";//прописываем запрос
            reader = selectCommand.ExecuteReader(); //результат возвращаем в reader
            if (reader.Read()) //и считываем построчно
                order = Convert.ToString(reader.GetInt32(0));
            IdCust_Copy.Text = order;
            reader.Close();

            connection.Close();

            Enty.Visibility = Visibility.Hidden;
            Cart.Visibility = Visibility.Visible;
        }
    }
}
