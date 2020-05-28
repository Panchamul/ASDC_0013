using System;
using System.Windows.Forms;

namespace SParcial
{
    public partial class Main : Form
    {
        private UserControl current = null;
        public Main()
        {
            InitializeComponent();
            current = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Perfil();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Ordenes();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Productos();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Empresas();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Program.activeUser.Type)
            {
                button3.Visible = false;
                button2.Visible = false;
            }
        }
    }
}