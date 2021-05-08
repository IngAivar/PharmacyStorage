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
    /// Логика взаимодействия для Win_2_2_Hist_Order.xaml
    /// </summary>
    public partial class Win_2_2_Hist_Order : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        string connectionString;
        SqlDataAdapter adapter;
        DataTable OrderTable;
        SqlConnection connection = null;
        string sql = "SELECT dbo.[Order].IdOrder, dbo.[Order].CustDateOfTheVisit AS [Дата заказа], dbo.Customer.IdCustomer, dbo.Customer.LastName + ' ' + dbo.Customer.FirstName  AS Покупатель," +
            " dbo.Customer.PhoneNumber, dbo.Customer.EMail, dbo.Staff.IdStaff, dbo.Staff.FirstName + ' ' + dbo.Staff.LastName AS Продавец FROM dbo.Customer " +
            "INNER JOIN dbo.[Order] ON dbo.Customer.IdCustomer = dbo.[Order].IdCustomer INNER JOIN dbo.Staff ON dbo.[Order].IdStaff = dbo.Staff.IdStaff";

        public Win_2_2_Hist_Order()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void ButtonClickBack(object sender, RoutedEventArgs e)
        {
            Win_2_2_Hist_Order winOrdHist = this;    // Вызов открытого окна
            Win_1_Order winOrd = new Win_1_Order();    // Создание нового окна

            winOrd.Show();    // Проявление созданного окна
            winOrdHist.Close();    // Закрытие основного окна
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
            OrderTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(OrderTable);
                Suppl.ItemsSource = OrderTable.DefaultView;
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
            sql = "SELECT dbo.[Order].IdOrder, dbo.[Order].CustDateOfTheVisit AS [Дата заказа], dbo.Customer.IdCustomer, dbo.Customer.LastName + ' ' + dbo.Customer.FirstName  AS Покупатель," +
            " dbo.Customer.PhoneNumber, dbo.Customer.EMail, dbo.Staff.IdStaff, dbo.Staff.FirstName + ' ' + dbo.Staff.LastName AS Продавец FROM dbo.Customer " +
            "INNER JOIN dbo.[Order] ON dbo.Customer.IdCustomer = dbo.[Order].IdCustomer INNER JOIN dbo.Staff ON dbo.[Order].IdStaff = dbo.Staff.IdStaff";
            if (a != 0 || b != 0 || c != 0)
            {
                sql = sql + " where ";
                if (a != 0)
                {
                    string idtext = SearchTextId.Text;
                    sql = sql + $"dbo.Customer.IdCustomer like '%{idtext}%' ";
                }
                if ((a != 0 & b != 0) || (a != 0 & c != 0))
                    sql = sql + " and ";
                if (b != 0)
                {
                    string nametext = SearchTextName.Text;
                    sql = sql + $"dbo.Staff.IdStaff like '%{nametext}%' ";
                }
                if ((b != 0 & c != 0) || (a != 0 & b != 0 & c != 0))
                    sql = sql + " and ";
                if (c != 0)
                {
                    string datetext = SearchTextDate.Text;
                    sql = sql + $"dbo.[Order].CustDateOfTheVisit LIKE '%{datetext}%' ";
                }
            }
            try
            {
                OrderTable.Clear();
                connection.Close();
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(OrderTable);
                Suppl.ItemsSource = OrderTable.DefaultView;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuscetHistory buscetHistory = new BuscetHistory();
            Win_2_2_Hist_Order winOrdHist = this;
            buscetHistory.Show();
            winOrdHist.Close();
        }
    }
}
