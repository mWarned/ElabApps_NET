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
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace Laborator1
{

    public partial class MainForm : Form
    {
        private int nrModificari = 0;

        // Connection string
        private string connectionString = "Server=localhost;Database=elabapp_net;User ID=mihai;Password=elabapp;";
        public MainForm()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                try
                {
                    conn.Open();

                    string insertSql;
                    insertSql = "INSERT INTO lab1 (ID, NUME, PRENUME, VECHIME, SALAR) VALUES ('";
                    insertSql += idText.Text + "','" + numeText.Text + "','" + prenumeText.Text + "','" + vechimeText.Text + "','" + salarText.Text + "')";
                    using (MySqlCommand cmd = new MySqlCommand(insertSql, conn))
                    {
                        nrModificari = nrModificari + cmd.ExecuteNonQuery();
                        nrModificariText.Text = Convert.ToString(nrModificari);
                    }

                    idText.Text = ""; numeText.Text = ""; prenumeText.Text = ""; vechimeText.Text = ""; salarText.Text = "";

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void afisareBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string selectSql = "SELECT * FROM lab1";
                    using (MySqlCommand cmd = new MySqlCommand(selectSql, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "lab1");
                        numeOut.Text = "NUME"; prenumeOut.Text = "PRENUME"; vechimeOut.Text = "VECHIME"; salarOut.Text = "SALAR";

                        foreach (DataRow r in ds.Tables["lab1"].Rows)
                        {
                            numeOut.Text = numeOut.Text + "\n" + r["NUME"] + "\n";
                            prenumeOut.Text = prenumeOut.Text + "\n" + r["PRENUME"] + "\n";
                            vechimeOut.Text = vechimeOut.Text + "\n" + r["VECHIME"] + "\n";
                            salarOut.Text = salarOut.Text + "\n" + r["SALAR"] + "\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string deleteSql;
                    deleteSql = "DELETE FROM lab1 WHERE NUME = @Nume";
                    using (MySqlCommand cmd = new MySqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", deleteText.Text);

                        nrModificari = nrModificari + cmd.ExecuteNonQuery();
                        nrModificariText.Text = Convert.ToString(nrModificari);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void sumSalBtn_Click(object sender, EventArgs e)
        {
            int suma;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT SUM(SALAR) FROM lab1", conn))
                    {
                        suma = Convert.ToInt32(cmd.ExecuteScalar());
                        sumSalariiText.Text = Convert.ToString(suma);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void lowVechimeBtn_Click(object sender, EventArgs e)
        {
            int min;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT MIN(VECHIME) FROM lab1", conn))
                    {
                        min = Convert.ToInt32(cmd.ExecuteScalar());
                        lowVechimeText.Text = Convert.ToString(min);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void highSalarBtn_Click(object sender, EventArgs e)
        {
            int max;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT MAX(SALAR) FROM lab1", conn))
                    {
                        max = Convert.ToInt32(cmd.ExecuteScalar());
                        highSalarText.Text = Convert.ToString(max);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void afisareLexBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string selectSql = "SELECT * FROM lab1 ORDER BY NUME ASC";
                    using (MySqlCommand cmd = new MySqlCommand(selectSql, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "lab1");
                        numeOut.Text = "NUME"; prenumeOut.Text = "PRENUME"; vechimeOut.Text = "VECHIME"; salarOut.Text = "SALAR";

                        foreach (DataRow r in ds.Tables["lab1"].Rows)
                        {
                            numeOut.Text = numeOut.Text + "\n" + r["NUME"] + "\n";
                            prenumeOut.Text = prenumeOut.Text + "\n" + r["PRENUME"] + "\n";
                            vechimeOut.Text = vechimeOut.Text + "\n" + r["VECHIME"] + "\n";
                            salarOut.Text = salarOut.Text + "\n" + r["SALAR"] + "\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

