namespace Presentacion
{
    partial class FrmTrabajador
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
            this.dtTrabajador = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.textTraba = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellidoTra = new System.Windows.Forms.TextBox();
            this.textNombreTra = new System.Windows.Forms.TextBox();
            this.textDniTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTrabajador)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTrabajador
            // 
            this.dtTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTrabajador.Location = new System.Drawing.Point(12, 368);
            this.dtTrabajador.MultiSelect = false;
            this.dtTrabajador.Name = "dtTrabajador";
            this.dtTrabajador.ReadOnly = true;
            this.dtTrabajador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTrabajador.Size = new System.Drawing.Size(742, 179);
            this.dtTrabajador.TabIndex = 49;
            this.dtTrabajador.SelectionChanged += new System.EventHandler(this.dtTrabajador_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Registro de Trabajador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Controls.Add(this.radioTrue);
            this.groupBox1.Controls.Add(this.textTraba);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textApellidoTra);
            this.groupBox1.Controls.Add(this.textNombreTra);
            this.groupBox1.Controls.Add(this.textDniTra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 260);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "EmpresaId:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "Especialista en Ergonomia ",
            "Especialista en Consumo Metabolico",
            "Especialista en Resistencia Termica"});
            this.cbEmpresa.Location = new System.Drawing.Point(74, 191);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(266, 21);
            this.cbEmpresa.TabIndex = 44;
            // 
            // radioTrue
            // 
            this.radioTrue.AutoSize = true;
            this.radioTrue.Location = new System.Drawing.Point(59, 163);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(55, 17);
            this.radioTrue.TabIndex = 29;
            this.radioTrue.TabStop = true;
            this.radioTrue.Text = "Activo";
            this.radioTrue.UseVisualStyleBackColor = true;
            // 
            // textTraba
            // 
            this.textTraba.Location = new System.Drawing.Point(93, 22);
            this.textTraba.Name = "textTraba";
            this.textTraba.Size = new System.Drawing.Size(91, 20);
            this.textTraba.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Trabajador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Activo:";
            // 
            // textApellidoTra
            // 
            this.textApellidoTra.Location = new System.Drawing.Point(59, 121);
            this.textApellidoTra.Name = "textApellidoTra";
            this.textApellidoTra.Size = new System.Drawing.Size(281, 20);
            this.textApellidoTra.TabIndex = 7;
            // 
            // textNombreTra
            // 
            this.textNombreTra.Location = new System.Drawing.Point(59, 81);
            this.textNombreTra.Name = "textNombreTra";
            this.textNombreTra.Size = new System.Drawing.Size(281, 20);
            this.textNombreTra.TabIndex = 6;
            // 
            // textDniTra
            // 
            this.textDniTra.Location = new System.Drawing.Point(55, 48);
            this.textDniTra.Name = "textDniTra";
            this.textDniTra.Size = new System.Drawing.Size(285, 20);
            this.textDniTra.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dni:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(426, 247);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 69;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(426, 172);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 68;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(426, 208);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 67;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Imagen_de_WhatsApp_2023_11_20_a_las_19_08_36_3b07c006;
            this.pictureBox1.Location = new System.Drawing.Point(542, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtTrabajador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTrabajador";
            this.Text = "FrmTrabajador";
            this.Load += new System.EventHandler(this.FrmTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTrabajador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtTrabajador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.TextBox textTraba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApellidoTra;
        private System.Windows.Forms.TextBox textNombreTra;
        private System.Windows.Forms.TextBox textDniTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}