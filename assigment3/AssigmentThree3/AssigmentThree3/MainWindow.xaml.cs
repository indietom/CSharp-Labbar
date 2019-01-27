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
using System.Data.SqlClient;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Logic;

namespace AssigmentThree3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DatabaseManager databaseManager;
        int nextId;

        /// <summary>
        /// Iniate database manager
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            UpdateDataGrid();

            databaseManager = new DatabaseManager();

            nextId = 0;
        }

        /// <summary>
        /// sync the datagrid with the database
        /// </summary>
        private void UpdateDataGrid()
        {
            try
            {
                String connectionString =
                    @"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                dataAdapter = new SqlDataAdapter("select * from Test", connectionString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                grid.DataContext = table.DefaultView;

            }
            catch (SqlException)
            {
                MessageBox.Show("NO CONNECTYION");
                this.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// Insert with generic values based on id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            databaseManager.Add(nextId++, nextId.ToString(), nextId.ToString() + nextId.ToString() + nextId.ToString());
            UpdateDataGrid();
        }

        /// <summary>
        /// Delete based on selected ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            databaseManager.Delete(grid.SelectedIndex);
            UpdateDataGrid();
        }
    }
}
