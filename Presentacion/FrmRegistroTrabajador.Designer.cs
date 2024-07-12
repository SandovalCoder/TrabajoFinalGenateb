namespace Presentacion
{
    partial class FrmRegistroTrabajador
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
            this.dtregistro = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtrabajador = new System.Windows.Forms.ComboBox();
            this.cbtermica = new System.Windows.Forms.ComboBox();
            this.cbErgonomico = new System.Windows.Forms.ComboBox();
            this.cbconsumo = new System.Windows.Forms.ComboBox();
            this.textIdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtregistro)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtregistro
            // 
            this.dtregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtregistro.Location = new System.Drawing.Point(12, 351);
            this.dtregistro.MultiSelect = false;
            this.dtregistro.Name = "dtregistro";
            this.dtregistro.ReadOnly = true;
            this.dtregistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtregistro.Size = new System.Drawing.Size(742, 200);
            this.dtregistro.TabIndex = 57;
            this.dtregistro.SelectionChanged += new System.EventHandler(this.dtregistro_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 23);
            this.label9.TabIndex = 56;
            this.label9.Text = "RegistroTrabajador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtrabajador);
            this.groupBox1.Controls.Add(this.cbtermica);
            this.groupBox1.Controls.Add(this.cbErgonomico);
            this.groupBox1.Controls.Add(this.cbconsumo);
            this.groupBox1.Controls.Add(this.textIdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 222);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitoreo Ergonomico";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbtrabajador
            // 
            this.cbtrabajador.FormattingEnabled = true;
            this.cbtrabajador.Location = new System.Drawing.Point(82, 172);
            this.cbtrabajador.Name = "cbtrabajador";
            this.cbtrabajador.Size = new System.Drawing.Size(274, 21);
            this.cbtrabajador.TabIndex = 35;
            // 
            // cbtermica
            // 
            this.cbtermica.FormattingEnabled = true;
            this.cbtermica.Location = new System.Drawing.Point(119, 84);
            this.cbtermica.Name = "cbtermica";
            this.cbtermica.Size = new System.Drawing.Size(237, 21);
            this.cbtermica.TabIndex = 34;
            // 
            // cbErgonomico
            // 
            this.cbErgonomico.FormattingEnabled = true;
            this.cbErgonomico.Location = new System.Drawing.Point(134, 125);
            this.cbErgonomico.Name = "cbErgonomico";
            this.cbErgonomico.Size = new System.Drawing.Size(222, 21);
            this.cbErgonomico.TabIndex = 33;
            // 
            // cbconsumo
            // 
            this.cbconsumo.FormattingEnabled = true;
            this.cbconsumo.Location = new System.Drawing.Point(119, 48);
            this.cbconsumo.Name = "cbconsumo";
            this.cbconsumo.Size = new System.Drawing.Size(237, 21);
            this.cbconsumo.TabIndex = 32;
            // 
            // textIdres
            // 
            this.textIdres.Location = new System.Drawing.Point(93, 22);
            this.textIdres.Name = "textIdres";
            this.textIdres.Size = new System.Drawing.Size(91, 20);
            this.textIdres.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Resgitro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TrabajadorId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MonitoreoErgonomicoId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ResistenciaTermicaId:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ConsumoMetabolicoId:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(425, 244);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 69;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(425, 169);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 68;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(425, 205);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 67;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Imagen_de_WhatsApp_2023_11_20_a_las_19_50_15_e0d95743;
            this.pictureBox1.Location = new System.Drawing.Point(542, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtregistro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroTrabajador";
            this.Text = "FrmRegistroTrabajador";
            this.Load += new System.EventHandler(this.FrmRegistroTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtregistro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtregistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtrabajador;
        private System.Windows.Forms.ComboBox cbtermica;
        private System.Windows.Forms.ComboBox cbErgonomico;
        private System.Windows.Forms.ComboBox cbconsumo;
        private System.Windows.Forms.TextBox textIdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}