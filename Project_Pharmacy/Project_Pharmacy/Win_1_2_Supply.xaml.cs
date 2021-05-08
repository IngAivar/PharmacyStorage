using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Configuration;

namespace Project_Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для Win_1_2_Supply.xaml
    /// </summary>
    public partial class Win_1_2_Supply : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        string connectionString;
        SqlDataAdapter adapter;
        DataTable postTable;
        SqlConnection connection = null;
        string sql = "SELECT dbo.Item.IdItem, dbo.Prowider.ProviderName, dbo.Item.ItemName, dbo.Prowider.WorkRegion, dbo.Supply.DateOfSupply, dbo.Supply.Amount " +
            "FROM dbo.Item INNER JOIN dbo.Supply ON dbo.Item.IdItem = dbo.Supply.IdItem INNER JOIN dbo.Prowider ON dbo.Supply.IdProvider = dbo.Prowider.IdProvider";

        public Win_1_2_Supply()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_1_2_Supply winSupp = this;    // Вызов открытого окна
            Win_2_Storage winStor = new Win_2_Storage();    // Создание нового окна

            winStor.Show();    // Проявление созданного окна
            winSupp.Close();    // Закрытие основного окна
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        { ++a; }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        { a = 0; }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        { ++b; }
        

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        { b = 0; }


        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        { ++c; }
        

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        { c = 0; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            postTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(postTable);
                Suppl.ItemsSource = postTable.DefaultView;
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
        private void UpdateDB()
        {
            sql = "SELECT dbo.Item.IdItem, dbo.Prowider.ProviderName, dbo.Item.ItemName, dbo.Prowider.WorkRegion, dbo.Supply.DateOfSupply, dbo.Supply.Amount " +
            "FROM dbo.Item INNER JOIN dbo.Supply ON dbo.Item.IdItem = dbo.Supply.IdItem INNER JOIN dbo.Prowider ON dbo.Supply.IdProvider = dbo.Prowider.IdProvider";
            if (a != 0 || b != 0 || c != 0)
            {
                sql = sql + " where ";
                if (a != 0)
                {
                    string idtext = SearchTextId.Text;
                    sql = sql + $"dbo.Item.IdItem like '%{idtext}%' ";
                }
                if ((a != 0 & b != 0) || (a != 0 & c != 0))
                    sql = sql + " and ";
                if (b != 0)
                {
                    string nametext = SearchTextName.Text;
                    sql = sql + $"dbo.Prowider.ProviderName like '%{nametext}%' ";
                }
                if ((b != 0 & c != 0) || (a != 0 & b != 0 & c != 0))
                    sql = sql + " and ";
                if (c != 0)
                {
                    string datetext = SearchTextDate.Text;
                    sql = sql + $"dbo.Supply.DateOfSupply LIKE '%{datetext}%' ";
                }
            }
            try
            {
                postTable.Clear();
                connection.Close();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(postTable);
                Suppl.ItemsSource = postTable.DefaultView;
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
        private void ButtonUpdateDb(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
    }
}
