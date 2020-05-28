using System;
using System.Windows.Forms;
using System.Data;
using Npgsql;
namespace SParcial
{
    public partial class Ordenes : UserControl
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            if (Program.activeUser.Type)
            {
                tabControl1.TabPages.Remove(tabPage2);
                button1.Visible = false;
            }

            LoadDataToTables();
        }

        private void LoadDataToTables()
        {
            string query = "";
            if (Program.activeUser.Type)
            {
                query = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser";
                
            }
            else
            {
                query = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {Program.activeUser.Id.ToString()}";

            }
            var dt = ConnectionDB.executeQuery(query);
            dataGridView1.DataSource = dt;

            if (Program.activeUser.Type)
            {
                var dt2 = ConnectionDB.executeQuery("SELECT p.idProduct, p.name, b.name as empresa FROM PRODUCT p, business b WHERE b.idbusiness = p.idbusiness");
                dataGridView2.DataSource = dt2;
                var dt3 = ConnectionDB.executeQuery($"SELECT * FROM address where iduser = '{Program.activeUser.Id.ToString()}'");
                dataGridView3.DataSource = dt3;
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"DELETE FROM apporder WHERE idorder = {dataGridView2.SelectedRows[0].Cells[0].Value.ToString()}");

                MessageBox.Show("La orden fue eliminada exitosamente");
                LoadDataToTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error @.@");
            }   
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                button3.Enabled = true;
            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(dataGridView2.SelectedRows.Count > 0 && dataGridView3.SelectedRows.Count > 0))
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO apporder(createdate, idproduct, idaddress) " +
                                   $"VALUES(" +
                                   "CURRENT_DATE, " +
                                   $"'{dataGridView2.SelectedRows[0].Cells[0].Value.ToString()}'," +
                                   $"'{dataGridView3.SelectedRows[0].Cells[0].Value.ToString()}')";
                    ConnectionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Orden agregada");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }
            }
        }
    }
}