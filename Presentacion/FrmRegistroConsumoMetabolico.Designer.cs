namespace Presentacion
{
    partial class FrmRegistroConsumoMetabolico
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtMetabolico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRango = new System.Windows.Forms.ComboBox();
            this.textClinico = new System.Windows.Forms.TextBox();
            this.textNivel = new System.Windows.Forms.TextBox();
            this.textTiempoB = new System.Windows.Forms.TextBox();
            this.textTiempoA = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIdMeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMetabolico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.img3;
            this.pictureBox1.Location = new System.Drawing.Point(542, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // dtMetabolico
            // 
            this.dtMetabolico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMetabolico.Location = new System.Drawing.Point(12, 351);
            this.dtMetabolico.MultiSelect = false;
            this.dtMetabolico.Name = "dtMetabolico";
            this.dtMetabolico.ReadOnly = true;
            this.dtMetabolico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMetabolico.Size = new System.Drawing.Size(742, 200);
            this.dtMetabolico.TabIndex = 62;
            this.dtMetabolico.SelectionChanged += new System.EventHandler(this.dtMetabolico_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Consumo Metabolico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRango);
            this.groupBox1.Controls.Add(this.textClinico);
            this.groupBox1.Controls.Add(this.textNivel);
            this.groupBox1.Controls.Add(this.textTiempoB);
            this.groupBox1.Controls.Add(this.textTiempoA);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.cbPosicion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textIdMeta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 240);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumo Metabolico";
            // 
            // cbRango
            // 
            this.cbRango.FormattingEnabled = true;
            this.cbRango.Location = new System.Drawing.Point(78, 173);
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(260, 21);
            this.cbRango.TabIndex = 66;
            // 
            // textClinico
            // 
            this.textClinico.Location = new System.Drawing.Point(108, 206);
            this.textClinico.Name = "textClinico";
            this.textClinico.Size = new System.Drawing.Size(180, 20);
            this.textClinico.TabIndex = 65;
            // 
            // textNivel
            // 
            this.textNivel.Location = new System.Drawing.Point(78, 145);
            this.textNivel.Name = "textNivel";
            this.textNivel.Size = new System.Drawing.Size(180, 20);
            this.textNivel.TabIndex = 63;
            // 
            // textTiempoB
            // 
            this.textTiempoB.Location = new System.Drawing.Point(78, 121);
            this.textTiempoB.Name = "textTiempoB";
            this.textTiempoB.Size = new System.Drawing.Size(180, 20);
            this.textTiempoB.TabIndex = 62;
            // 
            // textTiempoA
            // 
            this.textTiempoA.Location = new System.Drawing.Point(62, 69);
            this.textTiempoA.Name = "textTiempoA";
            this.textTiempoA.Size = new System.Drawing.Size(196, 20);
            this.textTiempoA.TabIndex = 61;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Trabajo manual",
            "Trabajo con un brazo",
            "Trabajo con dos brazos",
            "Trabajo con el cuerpo"});
            this.cbTipo.Location = new System.Drawing.Point(78, 95);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(260, 21);
            this.cbTipo.TabIndex = 60;
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Items.AddRange(new object[] {
            "sentado",
            "de pie",
            "caminado"});
            this.cbPosicion.Location = new System.Drawing.Point(62, 45);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(237, 21);
            this.cbPosicion.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Rango:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Laboratorio clinico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nivel:";
            // 
            // textIdMeta
            // 
            this.textIdMeta.Location = new System.Drawing.Point(93, 22);
            this.textIdMeta.Name = "textIdMeta";
            this.textIdMeta.Size = new System.Drawing.Size(91, 20);
            this.textIdMeta.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id_Metabolico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo trabajo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Posicion:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(424, 237);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 23);
            this.buttonLimpiar.TabIndex = 72;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(424, 162);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(94, 23);
            this.buttonGrabar.TabIndex = 71;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(424, 198);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 23);
            this.buttonEliminar.TabIndex = 70;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FrmRegistroConsumoMetabolico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtMetabolico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroConsumoMetabolico";
            this.Text = "FrmRegistroConsumoMetabolico";
            this.Load += new System.EventHandler(this.FrmRegistroConsumoMetabolico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMetabolico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtMetabolico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textClinico;
        private System.Windows.Forms.TextBox textNivel;
        private System.Windows.Forms.TextBox textTiempoB;
        private System.Windows.Forms.TextBox textTiempoA;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdMeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox cbRango;
    }
}