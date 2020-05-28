using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SParcial
{
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }
        private string idProduct = "0";
        private string idBusiness = "0";

        private void Productos_Load(object sender, EventArgs e)
        {
            string query = "SELECT name from business";
            var businessCombo = new List<string>();
            var business = ConnectionDB.executeQuery(query);

            foreach (DataRow dr in business.Rows)
            {
                businessCombo.Add(dr[0].ToString());
            }
            comboBox1.DataSource = businessCombo;
            LoadDataToTables();
        }

        private void LoadDataToTables()
        {
            string query = $"SELECT idbusiness from business where name = '{comboBox1.Text.ToString()}'";
            var dr = ConnectionDB.executeQuery(query);
            idBusiness = dr.Rows[0][0].ToString();
            var dt = ConnectionDB.executeQuery($"SELECT p.idProduct, p.name FROM PRODUCT p WHERE idbusiness = {idBusiness} ");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                idProduct = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" )
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    LoadDataToTables();
                    string query = $"INSERT INTO product(name, idbusiness) " +
                                   $"VALUES(" +
                                   $"'{textBox1.Text}'," +
                                   $"{idBusiness})";
                    ConnectionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Producto agregado");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Seleccione el producto que desea eliminar");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM Product WHERE idproduct = {idProduct}");

                    MessageBox.Show("El producto fue eliminado");
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }   
            }
        }
    }
}