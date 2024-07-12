namespace Presentacion
{
    partial class FrmRegistroResistenciaTermica
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
            this.dtTermica = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChaqueta = new System.Windows.Forms.ComboBox();
            this.textIdTer = new System.Windows.Forms.TextBox();
            this.cbVestidos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPantalones = new System.Windows.Forms.ComboBox();
            this.cbCamisa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInterior = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTermica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTermica
            // 
            this.dtTermica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTermica.Location = new System.Drawing.Point(12, 368);
            this.dtTermica.MultiSelect = false;
            this.dtTermica.Name = "dtTermica";
            this.dtTermica.ReadOnly = true;
            this.dtTermica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTermica.Size = new System.Drawing.Size(742, 179);
            this.dtTermica.TabIndex = 49;
            this.dtTermica.SelectionChanged += new System.EventHandler(this.dtTermica_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Resistencia Termica";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChaqueta);
            this.groupBox1.Controls.Add(this.textIdTer);
            this.groupBox1.Controls.Add(this.cbVestidos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPantalones);
            this.groupBox1.Controls.Add(this.cbCamisa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbInterior);
            this.groupBox1.Location = new System.Drawing.Point(36, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 260);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resistencia Termica";
            // 
            // cbChaqueta
            // 
            this.cbChaqueta.FormattingEnabled = true;
            this.cbChaqueta.Items.AddRange(new object[] {
            "Chaqueta ligera de verano",
            "Chaqueta normal",
            "Bata de trabajo (guardapolvo)"});
            this.cbChaqueta.Location = new System.Drawing.Point(107, 218);
            this.cbChaqueta.Name = "cbChaqueta";
            this.cbChaqueta.Size = new System.Drawing.Size(256, 21);
            this.cbChaqueta.TabIndex = 50;
            // 
            // textIdTer
            // 
            this.textIdTer.Location = new System.Drawing.Point(93, 22);
            this.textIdTer.Name = "textIdTer";
            this.textIdTer.Size = new System.Drawing.Size(91, 20);
            this.textIdTer.TabIndex = 28;
            // 
            // cbVestidos
            // 
            this.cbVestidos.FormattingEnabled = true;
            this.cbVestidos.Items.AddRange(new object[] {
            "Falda ligera (verano)",
            "Falda gruesa (invierno)",
            "Vestido ligero, mangas cortas",
            "Vestido de invierno, mangas largas"});
            this.cbVestidos.Location = new System.Drawing.Point(107, 181);
            this.cbVestidos.Name = "cbVestidos";
            this.cbVestidos.Size = new System.Drawing.Size(256, 21);
            this.cbVestidos.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Termica:";
            // 
            // cbPantalones
            // 
            this.cbPantalones.FormattingEnabled = true;
            this.cbPantalones.Items.AddRange(new object[] {
            "Corto",
            "Ligero",
            "Normal",
            "Franela"});
            this.cbPantalones.Location = new System.Drawing.Point(120, 147);
            this.cbPantalones.Name = "cbPantalones";
            this.cbPantalones.Size = new System.Drawing.Size(243, 21);
            this.cbPantalones.TabIndex = 48;
            // 
            // cbCamisa
            // 
            this.cbCamisa.FormattingEnabled = true;
            this.cbCamisa.Items.AddRange(new object[] {
            "Manga corta",
            "Ligera, mangas cortas",
            "Normal, mangas largas",
            "Camisa de franela, mangas largas",
            "Blusa ligera, mangas largas"});
            this.cbCamisa.Location = new System.Drawing.Point(107, 117);
            this.cbCamisa.Name = "cbCamisa";
            this.cbCamisa.Size = new System.Drawing.Size(256, 21);
            this.cbCamisa.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Prenda_camisa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Prenda_chaqueta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Prendas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Prenda_vestidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Prenda_ropa_interior:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Prenda_pantalones:";
            // 
            // cbInterior
            // 
            this.cbInterior.FormattingEnabled = true;
            this.cbInterior.Items.AddRange(new object[] {
            "Calzoncillos",
            "Calzoncillos largos",
            "Camiseta de tirantes",
            "Camiseta de manga corta",
            "Camiseta de manga larga",
            ""});
            this.cbInterior.Location = new System.Drawing.Point(126, 78);
            this.cbInterior.Name = "cbInterior";
            this.cbInterior.Size = new System.Drawing.Size(237, 21);
            this.cbInterior.TabIndex = 43;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(420, 274);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 72;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(420, 199);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 71;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(420, 235);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 70;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.temperatura;
            this.pictureBox1.Location = new System.Drawing.Point(542, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroResistenciaTermica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtTermica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroResistenciaTermica";
            this.Text = "FrmRegistroResistenciaTermica";
            this.Load += new System.EventHandler(this.FrmRegistroResistenciaTermica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTermica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtTermica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChaqueta;
        private System.Windows.Forms.TextBox textIdTer;
        private System.Windows.Forms.ComboBox cbVestidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPantalones;
        private System.Windows.Forms.ComboBox cbCamisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbInterior;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}