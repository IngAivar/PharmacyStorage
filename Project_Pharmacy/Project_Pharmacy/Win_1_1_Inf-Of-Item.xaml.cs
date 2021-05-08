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
    ///        .\SQLEXPRESS
    /// ISERPO
    /// </summary>
    public partial class Win_1_1_Inf_Of_Item : Window
    {
        int a = 0;
        int b = 0;
        string connectionString;
        SqlDataAdapter adapter;
        DataTable supplTable;

        SqlConnection connection = null;
        string sql = "SELECT dbo.Item.IdItem, dbo.Item.Unit, dbo.Item.Price, dbo.Item.Amount, dbo.Item.Deskription, dbo.Item.Picture, dbo.Item.ItemName, dbo.Manufacturer.ManufactName, dbo.Prowider.ProviderName " +
                "FROM dbo.Item INNER JOIN " +
                "dbo.Manufacturer ON dbo.Item.IdManufacturer = dbo.Manufacturer.IdManufacturer INNER JOIN " +
                "dbo.Supply ON dbo.Item.IdItem = dbo.Supply.IdItem INNER JOIN " +
                "dbo.Prowider ON dbo.Supply.IdProvider = dbo.Prowider.IdProvider";
        public Win_1_1_Inf_Of_Item()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {++a;}

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {++b;}
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        { a = 0; }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        { b = 0; }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_1_1_Inf_Of_Item winItemInf = this;    // Вызов открытого окна
            Win_2_Storage winStor = new Win_2_Storage();    // Создание нового окна

            winStor.Show();    // Проявление созданного окна
            winItemInf.Close();    // Закрытие основного окна
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
        private void UpdateDB()
        {
            sql = "SELECT dbo.Item.IdItem, dbo.Item.Unit, dbo.Item.Price, dbo.Item.Amount, dbo.Item.Deskription, dbo.Item.Picture, dbo.Item.ItemName, dbo.Manufacturer.ManufactName, dbo.Prowider.ProviderName " +
                "FROM dbo.Item INNER JOIN " +
                "dbo.Manufacturer ON dbo.Item.IdManufacturer = dbo.Manufacturer.IdManufacturer INNER JOIN " +
                "dbo.Supply ON dbo.Item.IdItem = dbo.Supply.IdItem INNER JOIN " +
                "dbo.Prowider ON dbo.Supply.IdProvider = dbo.Prowider.IdProvider";
            if (a != 0 || b != 0)
            {
                sql = sql + " where ";
                if (a != 0)
                {
                    string idtext = SearchTextId.Text;
                    sql = sql + $"dbo.Item.IdItem like '%{idtext}%' ";
                }
                if (a != 0 & b != 0)
                    sql = sql + " and ";
                if (b != 0)
                {
                    string nametext = SearchTextName.Text;
                    sql = sql + $"dbo.Item.ItemName like '%{nametext}%' ";
                }
            }
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

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }


    }
}
