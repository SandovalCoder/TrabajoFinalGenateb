namespace Presentacion
{
    partial class FrmEspecialistaTrabajador
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
            this.dtEspecialistaTraba = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrabajadorId = new System.Windows.Forms.ComboBox();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.textIEspeTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEspecialistaId = new System.Windows.Forms.ComboBox();
            this.textAreaTra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtEspecialistaTraba)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEspecialistaTraba
            // 
            this.dtEspecialistaTraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEspecialistaTraba.Location = new System.Drawing.Point(12, 344);
            this.dtEspecialistaTraba.MultiSelect = false;
            this.dtEspecialistaTraba.Name = "dtEspecialistaTraba";
            this.dtEspecialistaTraba.ReadOnly = true;
            this.dtEspecialistaTraba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtEspecialistaTraba.Size = new System.Drawing.Size(742, 207);
            this.dtEspecialistaTraba.TabIndex = 49;
            this.dtEspecialistaTraba.SelectionChanged += new System.EventHandler(this.dtEspecialistaTraba_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(428, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Registro de especialista trabajador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTrabajadorId);
            this.groupBox1.Controls.Add(this.radioTrue);
            this.groupBox1.Controls.Add(this.textIEspeTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbEspecialistaId);
            this.groupBox1.Controls.Add(this.textAreaTra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 212);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialista trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "TrabajadorId:";
            // 
            // cbTrabajadorId
            // 
            this.cbTrabajadorId.FormattingEnabled = true;
            this.cbTrabajadorId.Items.AddRange(new object[] {
            "Especialista en Ergonomia ",
            "Especialista en Consumo Metabolico",
            "Especialista en Resistencia Termica"});
            this.cbTrabajadorId.Location = new System.Drawing.Point(87, 121);
            this.cbTrabajadorId.Name = "cbTrabajadorId";
            this.cbTrabajadorId.Size = new System.Drawing.Size(266, 21);
            this.cbTrabajadorId.TabIndex = 31;
            // 
            // radioTrue
            // 
            this.radioTrue.AutoSize = true;
            this.radioTrue.Location = new System.Drawing.Point(63, 84);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(55, 17);
            this.radioTrue.TabIndex = 29;
            this.radioTrue.TabStop = true;
            this.radioTrue.Text = "Activo";
            this.radioTrue.UseVisualStyleBackColor = true;
            // 
            // textIEspeTra
            // 
            this.textIEspeTra.Location = new System.Drawing.Point(93, 22);
            this.textIEspeTra.Name = "textIEspeTra";
            this.textIEspeTra.Size = new System.Drawing.Size(91, 20);
            this.textIEspeTra.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_EspeTraba:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "EspecialistaId:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Activo:";
            // 
            // cbEspecialistaId
            // 
            this.cbEspecialistaId.FormattingEnabled = true;
            this.cbEspecialistaId.Items.AddRange(new object[] {
            "Especialista en Ergonomia ",
            "Especialista en Consumo Metabolico",
            "Especialista en Resistencia Termica"});
            this.cbEspecialistaId.Location = new System.Drawing.Point(87, 152);
            this.cbEspecialistaId.Name = "cbEspecialistaId";
            this.cbEspecialistaId.Size = new System.Drawing.Size(253, 21);
            this.cbEspecialistaId.TabIndex = 9;
            // 
            // textAreaTra
            // 
            this.textAreaTra.Location = new System.Drawing.Point(74, 48);
            this.textAreaTra.Name = "textAreaTra";
            this.textAreaTra.Size = new System.Drawing.Size(285, 20);
            this.textAreaTra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AreaTrabajo:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(422, 222);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 66;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(422, 147);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 65;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(422, 183);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 64;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.img31;
            this.pictureBox1.Location = new System.Drawing.Point(542, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEspecialistaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtEspecialistaTraba);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEspecialistaTrabajador";
            this.Text = "FrmEspecialistaTrabajador";
            this.Load += new System.EventHandler(this.FrmEspecialistaTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEspecialistaTraba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtEspecialistaTraba;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrabajadorId;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.TextBox textIEspeTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEspecialistaId;
        private System.Windows.Forms.TextBox textAreaTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}