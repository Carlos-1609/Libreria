namespace ProyectoVisual_III
{
    partial class frmAdicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtco = new System.Windows.Forms.TextBox();
            this.txtti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataadic = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtedi = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataadic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 39);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 58);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar y Eliminar Libros";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(317, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar.Location = new System.Drawing.Point(186, 382);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(100, 23);
            this.btnconsultar.TabIndex = 30;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(68, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(69, 230);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(100, 20);
            this.txtautor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Autor";
            // 
            // txtca
            // 
            this.txtca.Location = new System.Drawing.Point(69, 175);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(100, 20);
            this.txtca.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad";
            // 
            // txtco
            // 
            this.txtco.Location = new System.Drawing.Point(69, 104);
            this.txtco.Name = "txtco";
            this.txtco.Size = new System.Drawing.Size(100, 20);
            this.txtco.TabIndex = 22;
            // 
            // txtti
            // 
            this.txtti.Location = new System.Drawing.Point(69, 140);
            this.txtti.Name = "txtti";
            this.txtti.Size = new System.Drawing.Size(100, 20);
            this.txtti.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Titulo ";
            // 
            // dataadic
            // 
            this.dataadic.AllowUserToAddRows = false;
            this.dataadic.AllowUserToDeleteRows = false;
            this.dataadic.AllowUserToOrderColumns = true;
            this.dataadic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataadic.Location = new System.Drawing.Point(228, 123);
            this.dataadic.Name = "dataadic";
            this.dataadic.ReadOnly = true;
            this.dataadic.Size = new System.Drawing.Size(355, 228);
            this.dataadic.TabIndex = 32;
            this.dataadic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellClick);
            this.dataadic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Carrera";
            // 
            // txtedi
            // 
            this.txtedi.Location = new System.Drawing.Point(69, 266);
            this.txtedi.Name = "txtedi";
            this.txtedi.Size = new System.Drawing.Size(100, 20);
            this.txtedi.TabIndex = 34;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(69, 302);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 20);
            this.txtyear.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Editorial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Año ";
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(457, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Items.AddRange(new object[] {
            "Ing. Sistemas",
            "Ing. Civil",
            "Ing. Industrial",
            "Ing. Ambiental",
            "Ing. Electrica",
            "Ing. Quimica",
            "Ing. Mecatronica"});
            this.cmbcarrera.Location = new System.Drawing.Point(69, 334);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(100, 21);
            this.cmbcarrera.TabIndex = 40;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(68, 204);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Precio";
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 417);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbcarrera);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtedi);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataadic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtco);
            this.Controls.Add(this.txtti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionar";
            this.Text = "frmAdicionar";
            this.Load += new System.EventHandler(this.frmAdicionar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataadic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtco;
        private System.Windows.Forms.TextBox txtti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataadic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtedi;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbcarrera;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label9;
    }
}