using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
namespace task2
{
    /// <summary>
    /// Interaction logic for contact_detail.xaml
    /// </summary>
    public partial class contact_detail : Window
    {
       

        public contact_detail()
        {
            InitializeComponent();
            gridload();
        }

        private void gridload()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from [table1]";
            cmd.Connection = con;
            OleDbDataReader db = cmd.ExecuteReader();
            grid1.ItemsSource = db;



        }

       




            }

        
    }
