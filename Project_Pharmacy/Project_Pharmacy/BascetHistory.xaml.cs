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
    /// Логика взаимодействия для EnterCustomer.xaml
    /// </summary>
    ///         

    public partial class BuscetHistory : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        string connectionString;
        SqlDataAdapter adapter;
        DataTable BascetTable;
        SqlConnection connection = null;
        string sql = "SELECT dbo.Basket.IdBasket, dbo.Item.IdItem, dbo.Item.ItemName AS Товар," +
            " dbo.Basket.IdOrder, dbo.Basket.Amount, dbo.Item.Price, dbo.Basket.Amount * dbo.Item.Price AS [Сумма] FROM dbo.Basket INNER JOIN" +
            " dbo.Item ON dbo.Basket.IdItem = dbo.Item.IdItem";
        public BuscetHistory()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            BuscetHistory buscetHistory = this;
            Win_2_2_Hist_Order winOrdHist = new Win_2_2_Hist_Order();

            
            winOrdHist.Show();
            buscetHistory.Close();
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
            BascetTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(BascetTable);
                Suppl.ItemsSource = BascetTable.DefaultView;
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
            sql = "SELECT dbo.Basket.IdBasket, dbo.Item.IdItem, dbo.Item.ItemName AS Товар," +
            " dbo.Basket.IdOrder, dbo.Basket.Amount, dbo.Item.Price, dbo.Basket.Amount * dbo.Item.Price AS [Сумма] FROM dbo.Basket INNER JOIN" +
            " dbo.Item ON dbo.Basket.IdItem = dbo.Item.IdItem";
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
                    sql = sql + $"dbo.Item.ItemName like '%{nametext}%' ";
                }
                if ((b != 0 & c != 0) || (a != 0 & b != 0 & c != 0))
                    sql = sql + " and ";
                if (c != 0)
                {
                    string datetext = SearchTextIdOrd.Text;
                    sql = sql + $"dbo.Basket.IdOrder LIKE '%{datetext}%' ";
                }
            }
            try
            {
                BascetTable.Clear();
                connection.Close();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(BascetTable);
                Suppl.ItemsSource = BascetTable.DefaultView;
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
        private void ButtonUpdateDB(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
    }

   

}
