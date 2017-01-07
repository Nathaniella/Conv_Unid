namespace Conv_Unid
{
    partial class Frm_Fondo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fondo));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nroDecimales = new System.Windows.Forms.DomainUpDown();
            this.checkBoxNotacion = new System.Windows.Forms.CheckBox();
            this.lDecimal = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbUnidades = new System.Windows.Forms.ComboBox();
            this.lMsj = new System.Windows.Forms.Label();
            this.lMsjError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Navy;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(12, 194);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Clear";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcercaDe.BackColor = System.Drawing.Color.Navy;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Rockwell", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(60, 229);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcercaDe.TabIndex = 1;
            this.btnAcercaDe.Text = "Acerca de...";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(101, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // nroDecimales
            // 
            this.nroDecimales.ForeColor = System.Drawing.Color.Navy;
            this.nroDecimales.Items.Add("1");
            this.nroDecimales.Items.Add("2");
            this.nroDecimales.Items.Add("3");
            this.nroDecimales.Items.Add("4");
            this.nroDecimales.Items.Add("5");
            this.nroDecimales.Location = new System.Drawing.Point(12, 122);
            this.nroDecimales.Name = "nroDecimales";
            this.nroDecimales.Size = new System.Drawing.Size(57, 20);
            this.nroDecimales.TabIndex = 4;
            this.nroDecimales.SelectedItemChanged += new System.EventHandler(this.nroDecimales_SelectedItemChanged);
            // 
            // checkBoxNotacion
            // 
            this.checkBoxNotacion.AutoSize = true;
            this.checkBoxNotacion.Location = new System.Drawing.Point(12, 156);
            this.checkBoxNotacion.Name = "checkBoxNotacion";
            this.checkBoxNotacion.Size = new System.Drawing.Size(96, 17);
            this.checkBoxNotacion.TabIndex = 5;
            this.checkBoxNotacion.Text = "Usar Notación";
            this.checkBoxNotacion.UseVisualStyleBackColor = true;
            // 
            // lDecimal
            // 
            this.lDecimal.AutoSize = true;
            this.lDecimal.Location = new System.Drawing.Point(75, 125);
            this.lDecimal.Name = "lDecimal";
            this.lDecimal.Size = new System.Drawing.Size(60, 13);
            this.lDecimal.TabIndex = 6;
            this.lDecimal.Text = "Decimales";
            // 
            // tb1
            // 
            this.tb1.ForeColor = System.Drawing.Color.Navy;
            this.tb1.Location = new System.Drawing.Point(199, 28);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 7;
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // tb2
            // 
            this.tb2.ForeColor = System.Drawing.Color.Navy;
            this.tb2.Location = new System.Drawing.Point(199, 54);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 8;
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_KeyPress);
            // 
            // tb3
            // 
            this.tb3.ForeColor = System.Drawing.Color.Navy;
            this.tb3.Location = new System.Drawing.Point(199, 80);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 9;
            this.tb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3_KeyPress);
            // 
            // tb4
            // 
            this.tb4.ForeColor = System.Drawing.Color.Navy;
            this.tb4.Location = new System.Drawing.Point(199, 106);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 10;
            this.tb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb4_KeyPress);
            // 
            // tb5
            // 
            this.tb5.ForeColor = System.Drawing.Color.Navy;
            this.tb5.Location = new System.Drawing.Point(199, 132);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 11;
            this.tb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb5_KeyPress);
            // 
            // tb6
            // 
            this.tb6.ForeColor = System.Drawing.Color.Navy;
            this.tb6.Location = new System.Drawing.Point(199, 158);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 20);
            this.tb6.TabIndex = 12;
            this.tb6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb6_KeyPress);
            // 
            // tb7
            // 
            this.tb7.ForeColor = System.Drawing.Color.Navy;
            this.tb7.Location = new System.Drawing.Point(199, 184);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(100, 20);
            this.tb7.TabIndex = 13;
            this.tb7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb7_KeyPress);
            // 
            // tb8
            // 
            this.tb8.ForeColor = System.Drawing.Color.Navy;
            this.tb8.Location = new System.Drawing.Point(199, 210);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(100, 20);
            this.tb8.TabIndex = 14;
            this.tb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb8_KeyPress);
            // 
            // tb9
            // 
            this.tb9.ForeColor = System.Drawing.Color.Navy;
            this.tb9.Location = new System.Drawing.Point(199, 236);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(100, 20);
            this.tb9.TabIndex = 15;
            this.tb9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb9_KeyPress);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(302, 35);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(21, 13);
            this.lb1.TabIndex = 16;
            this.lb1.Text = "Kg";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(301, 61);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(20, 13);
            this.lb2.TabIndex = 17;
            this.lb2.Text = "Lb";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(301, 87);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(26, 13);
            this.lb3.TabIndex = 18;
            this.lb3.Text = "Grs";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(301, 113);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(24, 13);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "Mg";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(301, 139);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(33, 13);
            this.lb5.TabIndex = 20;
            this.lb5.Text = "Onza";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(302, 165);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(29, 13);
            this.lb6.TabIndex = 21;
            this.lb6.Text = "Slug";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Rockwell", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(302, 194);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(49, 11);
            this.lb7.TabIndex = 22;
            this.lb7.Text = "TM(Tonne)";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(303, 217);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(46, 13);
            this.lb8.TabIndex = 23;
            this.lb8.Text = "Ton(US)";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(304, 243);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(47, 13);
            this.lb9.TabIndex = 24;
            this.lb9.Text = "Ton(UK)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 63);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbUnidades
            // 
            this.cbUnidades.ForeColor = System.Drawing.Color.Navy;
            this.cbUnidades.FormattingEnabled = true;
            this.cbUnidades.Items.AddRange(new object[] {
            "Longitud",
            "Área",
            "Volumen",
            "Temperatura",
            "Presión",
            "Masa",
            "Moles",
            "Densidad",
            "Energía",
            "Potencia",
            "Flujo Volumétrico",
            "Flujo Másico",
            "Flujo Molar",
            "Velocidad",
            "Viscosidad Cinemática",
            "Viscosidad Dinámica",
            "Conductividad Térmica",
            "Coeficiente de Transferencia de Calor",
            "Entalpía Específica",
            "Entropía Específica",
            "Volumen Específico",
            "Ángulo Plano",
            "Tiempo",
            "Fuerza"});
            this.cbUnidades.Location = new System.Drawing.Point(12, 88);
            this.cbUnidades.Name = "cbUnidades";
            this.cbUnidades.Size = new System.Drawing.Size(164, 21);
            this.cbUnidades.TabIndex = 26;
            this.cbUnidades.Text = "Unidades";
            this.cbUnidades.SelectedIndexChanged += new System.EventHandler(this.cbUnidades_SelectedIndexChanged);
            // 
            // lMsj
            // 
            this.lMsj.AutoSize = true;
            this.lMsj.ForeColor = System.Drawing.Color.Red;
            this.lMsj.Location = new System.Drawing.Point(144, 243);
            this.lMsj.Name = "lMsj";
            this.lMsj.Size = new System.Drawing.Size(0, 13);
            this.lMsj.TabIndex = 27;
            // 
            // lMsjError
            // 
            this.lMsjError.AutoSize = true;
            this.lMsjError.ForeColor = System.Drawing.Color.Red;
            this.lMsjError.Location = new System.Drawing.Point(225, 9);
            this.lMsjError.Name = "lMsjError";
            this.lMsjError.Size = new System.Drawing.Size(0, 13);
            this.lMsjError.TabIndex = 28;
            // 
            // Frm_Fondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(383, 264);
            this.Controls.Add(this.lMsjError);
            this.Controls.Add(this.lMsj);
            this.Controls.Add(this.cbUnidades);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lDecimal);
            this.Controls.Add(this.checkBoxNotacion);
            this.Controls.Add(this.nroDecimales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnBorrar);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Fondo";
            this.ShowIcon = false;
            this.Text = "ACCADYA - Oil & Gas Training Group";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Frm_Fondo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DomainUpDown nroDecimales;
        private System.Windows.Forms.CheckBox checkBoxNotacion;
        private System.Windows.Forms.Label lDecimal;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbUnidades;
        private System.Windows.Forms.Label lMsj;
        private System.Windows.Forms.Label lMsjError;
    }
}

