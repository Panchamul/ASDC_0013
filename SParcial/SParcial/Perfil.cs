using System;
using System.Windows.Forms;

namespace SParcial
{
    public partial class Perfil : UserControl
    {
        public Perfil()
        {
            InitializeComponent();
        }
        private string idAdress = "0";
        private string idUser = "0";
        private void label8_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            textBox7.Text = Program.activeUser.Name;
            textBox6.Text = Program.activeUser.Nickname;
            textBox5.Text = Program.activeUser.Password;
            if (Program.activeUser.Type)
            {
                tabControl1.TabPages.Remove(tabPage2);
                textBox8.Text = "Administrador";
                
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage1);
                textBox8.Text = "Cliente";
            }
            
            
            LoadDataToTables();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery(
                        $"UPDATE appuser SET password = '{textBox5.Text}' WHERE idUser = {Program.activeUser.Id.ToString()}");
                    Program.activeUser.Password = textBox5.Text;
                    textBox5.Text = "";
                    
                    MessageBox.Show("Modificado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error");
                }   
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                idAdress = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void LoadDataToTables()
        {
            if (Program.activeUser.Type)
            {
                var dtu = ConnectionDB.executeQuery("SELECT * FROM appuser");
                dataGridView1.DataSource = dtu;
            }
            else
            {
                var dt = ConnectionDB.executeQuery(
                    $"SELECT * FROM address where iduser = '{Program.activeUser.Id.ToString()}'");
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[1].Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO address(iduser, address) " +
                                   $"VALUES(" +
                                   $"'{Program.activeUser.Id.ToString()}'," +
                                   $"'{textBox4.Text}')";
                    ConnectionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Agregado exitosamente");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{textBox4.Text}' WHERE idAddress = {idAdress}");

                    MessageBox.Show("Modificado exitosamente");
                    
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error");
                }   
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Seleccione el registro a eliminar");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM address WHERE idAddress = {idAdress}");

                    MessageBox.Show("Eliminado exitosamente");
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error");
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {if (e.RowIndex >= 0)
            { 
                idUser = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "True")
                {
                    comboBox1.SelectedIndex = 1;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == ""|| textBox3.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    bool admin = false;
                    if (comboBox1.SelectedIndex == 0)
                    {
                        admin = false;
                    }
                    else
                    {
                        admin = true;
                    }
                    string query = $"INSERT INTO appuser(fullname, username, password, usertype) " +
                                   $"VALUES(" +
                                   $"'{textBox1.Text}'," +
                                   $"'{textBox2.Text}'," +
                                   $"'{textBox3.Text}'," +
                                   $"'{admin}')";
                    ConnectionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Agregado exitosamente");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals(""))
            {
                MessageBox.Show("Seleccione el registro a eliminar");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM appuser WHERE iduser = {idUser}");

                    MessageBox.Show("Eliminado exitosamente");
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error");
                }   
            }
        }
    }
}