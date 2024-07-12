namespace Presentacion
{
    partial class FrmRegistroMonitoreoErgonomico
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
            this.dtErgonomico = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.cbA = new System.Windows.Forms.ComboBox();
            this.texttiempo = new System.Windows.Forms.TextBox();
            this.textIdEr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textdato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtErgonomico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtErgonomico
            // 
            this.dtErgonomico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtErgonomico.Location = new System.Drawing.Point(12, 351);
            this.dtErgonomico.MultiSelect = false;
            this.dtErgonomico.Name = "dtErgonomico";
            this.dtErgonomico.ReadOnly = true;
            this.dtErgonomico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtErgonomico.Size = new System.Drawing.Size(742, 200);
            this.dtErgonomico.TabIndex = 49;
            this.dtErgonomico.SelectionChanged += new System.EventHandler(this.dtErgonomico_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Monitoreo Ergonomico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbB);
            this.groupBox1.Controls.Add(this.cbA);
            this.groupBox1.Controls.Add(this.texttiempo);
            this.groupBox1.Controls.Add(this.textIdEr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textdato);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 240);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitoreo Ergonomico";
            // 
            // cbB
            // 
            this.cbB.FormattingEnabled = true;
            this.cbB.Items.AddRange(new object[] {
            "Monitor",
            "Teléfono",
            "Ratón",
            "Teclado"});
            this.cbB.Location = new System.Drawing.Point(119, 125);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(237, 21);
            this.cbB.TabIndex = 33;
            // 
            // cbA
            // 
            this.cbA.FormattingEnabled = true;
            this.cbA.Items.AddRange(new object[] {
            "Altura silla",
            "Longitud de asiento",
            "Repo  sabrazos",
            "Respaldo"});
            this.cbA.Location = new System.Drawing.Point(93, 48);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(263, 21);
            this.cbA.TabIndex = 32;
            // 
            // texttiempo
            // 
            this.texttiempo.Location = new System.Drawing.Point(119, 172);
            this.texttiempo.Name = "texttiempo";
            this.texttiempo.Size = new System.Drawing.Size(237, 20);
            this.texttiempo.TabIndex = 31;
            // 
            // textIdEr
            // 
            this.textIdEr.Location = new System.Drawing.Point(93, 22);
            this.textIdEr.Name = "textIdEr";
            this.textIdEr.Size = new System.Drawing.Size(91, 20);
            this.textIdEr.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Ergonomico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TiempoEquipamiento:";
            // 
            // textdato
            // 
            this.textdato.Location = new System.Drawing.Point(80, 81);
            this.textdato.Name = "textdato";
            this.textdato.Size = new System.Drawing.Size(276, 20);
            this.textdato.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "EquipamientoOficina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TiempoDato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ErgonomiaDatos:\r\n";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(423, 231);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 69;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(423, 156);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 68;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(423, 192);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 67;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(542, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroMonitoreoErgonomico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtErgonomico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroMonitoreoErgonomico";
            this.Text = "FrmRegistroConsumoMetabolico";
            this.Load += new System.EventHandler(this.FrmRegistroConsumoMetabolico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtErgonomico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtErgonomico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbB;
        private System.Windows.Forms.ComboBox cbA;
        private System.Windows.Forms.TextBox texttiempo;
        private System.Windows.Forms.TextBox textIdEr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textdato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}