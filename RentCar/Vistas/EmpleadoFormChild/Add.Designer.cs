
namespace RentCar.Vistas.EmpleadoFormChild
{
    partial class Add
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
            this.v_comision = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.v_tanda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.v_cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.v_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_status = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.v_nombre = new System.Windows.Forms.TextBox();
            this.l_contrasena = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.v_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.v_contrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.v_comision)).BeginInit();
            this.SuspendLayout();
            // 
            // v_comision
            // 
            this.v_comision.Location = new System.Drawing.Point(660, 38);
            this.v_comision.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.v_comision.Name = "v_comision";
            this.v_comision.Size = new System.Drawing.Size(208, 20);
            this.v_comision.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha Ingreso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Comision";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_tanda
            // 
            this.v_tanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_tanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_tanda.FormattingEnabled = true;
            this.v_tanda.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Mixta"});
            this.v_tanda.Location = new System.Drawing.Point(204, 202);
            this.v_tanda.Name = "v_tanda";
            this.v_tanda.Size = new System.Drawing.Size(208, 24);
            this.v_tanda.TabIndex = 38;
            this.v_tanda.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tanda";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_cedula
            // 
            this.v_cedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_cedula.Location = new System.Drawing.Point(204, 147);
            this.v_cedula.Name = "v_cedula";
            this.v_cedula.Size = new System.Drawing.Size(208, 22);
            this.v_cedula.TabIndex = 36;
            this.v_cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cedula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_apellido
            // 
            this.v_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_apellido.Location = new System.Drawing.Point(204, 92);
            this.v_apellido.Name = "v_apellido";
            this.v_apellido.Size = new System.Drawing.Size(208, 22);
            this.v_apellido.TabIndex = 34;
            this.v_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Apellido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_status
            // 
            this.v_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_status.FormattingEnabled = true;
            this.v_status.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.v_status.Location = new System.Drawing.Point(660, 145);
            this.v_status.Name = "v_status";
            this.v_status.Size = new System.Drawing.Size(208, 24);
            this.v_status.TabIndex = 32;
            this.v_status.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(397, 279);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 37);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // v_nombre
            // 
            this.v_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_nombre.Location = new System.Drawing.Point(204, 36);
            this.v_nombre.Name = "v_nombre";
            this.v_nombre.Size = new System.Drawing.Size(208, 22);
            this.v_nombre.TabIndex = 30;
            this.v_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_contrasena
            // 
            this.l_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_contrasena.AutoSize = true;
            this.l_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contrasena.Location = new System.Drawing.Point(456, 147);
            this.l_contrasena.Name = "l_contrasena";
            this.l_contrasena.Size = new System.Drawing.Size(79, 25);
            this.l_contrasena.TabIndex = 29;
            this.l_contrasena.Text = "Estado";
            this.l_contrasena.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_usuario
            // 
            this.l_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_usuario.AutoSize = true;
            this.l_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_usuario.Location = new System.Drawing.Point(57, 33);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(87, 25);
            this.l_usuario.TabIndex = 28;
            this.l_usuario.Text = "Nombre";
            this.l_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_fecha
            // 
            this.v_fecha.Location = new System.Drawing.Point(660, 97);
            this.v_fecha.Name = "v_fecha";
            this.v_fecha.Size = new System.Drawing.Size(208, 20);
            this.v_fecha.TabIndex = 42;
            this.v_fecha.ValueChanged += new System.EventHandler(this.v_fecha_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Contraseña";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_contrasena
            // 
            this.v_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_contrasena.Location = new System.Drawing.Point(660, 199);
            this.v_contrasena.Name = "v_contrasena";
            this.v_contrasena.Size = new System.Drawing.Size(208, 22);
            this.v_contrasena.TabIndex = 44;
            this.v_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.v_contrasena.UseSystemPasswordChar = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 361);
            this.Controls.Add(this.v_contrasena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.v_fecha);
            this.Controls.Add(this.v_comision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v_tanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v_cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.v_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.v_nombre);
            this.Controls.Add(this.l_contrasena);
            this.Controls.Add(this.l_usuario);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.v_comision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown v_comision;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox v_tanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v_cedula;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v_apellido;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox v_status;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox v_nombre;
        private System.Windows.Forms.Label l_contrasena;
        public System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.DateTimePicker v_fecha;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox v_contrasena;
    }
}