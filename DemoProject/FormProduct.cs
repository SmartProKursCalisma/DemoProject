using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class FormProduct : Form
    {
        string connectionString = "Server=202-00;Database=Northwind;User Id=sa;Password=1234;";
        List<Product> products;
        public FormProduct()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select ProductId,ProductName,UnitPrice,UnitsInStock  from Products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product()
                            {
                                ProductId = Convert.ToInt32(reader["ProductId"]),
                                ProductName = reader["ProductName"].ToString(),
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                                UnitStock = Convert.ToInt32(reader["UnitsInStock"])
                            };
                            products.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            gridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProduct.DataSource = products;
        }
    }
}
