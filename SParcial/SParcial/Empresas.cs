using System;
using System.Windows.Forms;

namespace SParcial
{
    public partial class Empresas : UserControl
    {
        public Empresas()
        {
            InitializeComponent();
        }
        private string idBusiness = "0";
        
        private void LoadDataToTables()
        {
            var dt = ConnectionDB.executeQuery("SELECT * FROM business");
            dataGridView1.DataSource = dt;
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO BUSINESS(name, description) " +
                                   $"VALUES(" +
                                   $"'{textBox1.Text}'," +
                                   $"'{textBox2.Text}')";
                    ConnectionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Empresa agregada");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }
            }
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            LoadDataToTables();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals(""))
            {
                MessageBox.Show("Seleccione la empresa que desea eliminar");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = {idBusiness}");

                    MessageBox.Show("Se elimino una empresa");
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }   
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                idBusiness = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}