namespace Presentacion
{
    partial class FrmEspecialista
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
            this.dataEspecialista = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioactivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textIdEs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOcupacion = new System.Windows.Forms.ComboBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelModificado = new System.Windows.Forms.Label();
            this.labelCreado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labalfechacrea = new System.Windows.Forms.Label();
            this.labelfechamodi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecialista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEspecialista
            // 
            this.dataEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEspecialista.Location = new System.Drawing.Point(12, 358);
            this.dataEspecialista.MultiSelect = false;
            this.dataEspecialista.Name = "dataEspecialista";
            this.dataEspecialista.ReadOnly = true;
            this.dataEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEspecialista.Size = new System.Drawing.Size(742, 185);
            this.dataEspecialista.TabIndex = 58;
            this.dataEspecialista.SelectionChanged += new System.EventHandler(this.dataEspecialista_SelectionChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(411, 198);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 57;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textContraseña);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioactivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textIdEs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbOcupacion);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textDni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 240);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialista";
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(74, 75);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(266, 20);
            this.textContraseña.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Contraseña:";
            // 
            // radioactivo
            // 
            this.radioactivo.AutoSize = true;
            this.radioactivo.Location = new System.Drawing.Point(59, 217);
            this.radioactivo.Name = "radioactivo";
            this.radioactivo.Size = new System.Drawing.Size(55, 17);
            this.radioactivo.TabIndex = 33;
            this.radioactivo.TabStop = true;
            this.radioactivo.Text = "Activo";
            this.radioactivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Activo:";
            // 
            // textIdEs
            // 
            this.textIdEs.Location = new System.Drawing.Point(93, 22);
            this.textIdEs.Name = "textIdEs";
            this.textIdEs.Size = new System.Drawing.Size(91, 20);
            this.textIdEs.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Especialista:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ocupacion:";
            // 
            // cbOcupacion
            // 
            this.cbOcupacion.FormattingEnabled = true;
            this.cbOcupacion.Items.AddRange(new object[] {
            "Especialista en Ergonomia ",
            "Especialista en Consumo Metabolico",
            "Especialista en Resistencia Termica"});
            this.cbOcupacion.Location = new System.Drawing.Point(74, 177);
            this.cbOcupacion.Name = "cbOcupacion";
            this.cbOcupacion.Size = new System.Drawing.Size(266, 21);
            this.cbOcupacion.TabIndex = 9;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(59, 141);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(281, 20);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(59, 101);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(281, 20);
            this.textNombre.TabIndex = 6;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(55, 48);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(285, 20);
            this.textDni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
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
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dni";
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(411, 162);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 62;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(411, 237);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 63;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Registro de especialista";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.tra;
            this.pictureBox1.Location = new System.Drawing.Point(542, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // labelModificado
            // 
            this.labelModificado.AutoSize = true;
            this.labelModificado.Location = new System.Drawing.Point(539, 93);
            this.labelModificado.Name = "labelModificado";
            this.labelModificado.Size = new System.Drawing.Size(78, 13);
            this.labelModificado.TabIndex = 65;
            this.labelModificado.Text = "ModificadoPor:";
            // 
            // labelCreado
            // 
            this.labelCreado.AutoSize = true;
            this.labelCreado.Location = new System.Drawing.Point(539, 61);
            this.labelCreado.Name = "labelCreado";
            this.labelCreado.Size = new System.Drawing.Size(60, 13);
            this.labelCreado.TabIndex = 64;
            this.labelCreado.Text = "CreadoPor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "CreadoPor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "ModificadoPor:";
            // 
            // labalfechacrea
            // 
            this.labalfechacrea.AutoSize = true;
            this.labalfechacrea.Location = new System.Drawing.Point(633, 61);
            this.labalfechacrea.Name = "labalfechacrea";
            this.labalfechacrea.Size = new System.Drawing.Size(67, 13);
            this.labalfechacrea.TabIndex = 68;
            this.labalfechacrea.Text = "fechacreado";
            // 
            // labelfechamodi
            // 
            this.labelfechamodi.AutoSize = true;
            this.labelfechamodi.Location = new System.Drawing.Point(633, 93);
            this.labelfechamodi.Name = "labelfechamodi";
            this.labelfechamodi.Size = new System.Drawing.Size(93, 13);
            this.labelfechamodi.TabIndex = 69;
            this.labelfechamodi.Text = "fechamodificacion";
            // 
            // FrmEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.labelfechamodi);
            this.Controls.Add(this.labalfechacrea);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelModificado);
            this.Controls.Add(this.labelCreado);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.dataEspecialista);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEspecialista";
            this.Text = "FrmEspecialista";
            this.Load += new System.EventHandler(this.FrmEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecialista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataEspecialista;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioactivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIdEs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOcupacion;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelModificado;
        private System.Windows.Forms.Label labelCreado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labalfechacrea;
        private System.Windows.Forms.Label labelfechamodi;
    }
}