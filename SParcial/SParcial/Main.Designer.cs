using System.ComponentModel;

namespace SParcial
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.53846F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 436);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.button2.Location = new System.Drawing.Point(3, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 101);
            this.button2.TabIndex = 9;
            this.button2.Text = "Productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 98);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ordenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.button3.Location = new System.Drawing.Point(3, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 102);
            this.button3.TabIndex = 10;
            this.button3.Text = "Empresas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.button4.Location = new System.Drawing.Point(3, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 110);
            this.button4.TabIndex = 11;
            this.button4.Text = "Usuarios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.button5.Location = new System.Drawing.Point(780, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}