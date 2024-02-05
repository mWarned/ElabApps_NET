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

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string nmProfText = nmProfTxt.Text;

            if (!string.IsNullOrEmpty(nmProfText))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Server=YourServerName;Database=YourDatabaseName;Integrated Security=True;"))
                    {
                        connection.Open();

                        string query = $"INSERT INTO profesor (idprofesor, nmprofesor) VALUES ('{GetLastIdFromTable(connection) + 1}', '{nmProfText}')";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Datele au for introduse!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in the text field.");
            }
        }

        private int GetLastIdFromTable(SqlConnection connection)
        {
            string query = "SELECT TOP 1 idprofesor FROM profesor ORDER BY idprofesor DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }
    }
}
