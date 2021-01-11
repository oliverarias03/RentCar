
namespace RentCar.Vistas.VehiculoFormChild
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
            this.components = new System.ComponentModel.Container();
            this.v_marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_status = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.v_descripcion = new System.Windows.Forms.TextBox();
            this.l_contrasena = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.sistemaRentCarDataSet = new RentCar.SistemaRentCarDataSet();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new RentCar.SistemaRentCarDataSetTableAdapters.MarcaTableAdapter();
            this.v_chasis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.v_placa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.v_motor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v_modelo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.v_tipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.v_tipoCombustible = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // v_marca
            // 
            this.v_marca.DisplayMember = "Id";
            this.v_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_marca.FormattingEnabled = true;
            this.v_marca.Location = new System.Drawing.Point(631, 40);
            this.v_marca.Name = "v_marca";
            this.v_marca.Size = new System.Drawing.Size(208, 24);
            this.v_marca.TabIndex = 24;
            this.v_marca.Tag = "";
            this.v_marca.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Marca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_status
            // 
            this.v_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_status.FormattingEnabled = true;
            this.v_status.Items.AddRange(new object[] {
            "Disponible",
            "Rentado",
            "Mantenimiento"});
            this.v_status.Location = new System.Drawing.Point(182, 249);
            this.v_status.Name = "v_status";
            this.v_status.Size = new System.Drawing.Size(208, 24);
            this.v_status.TabIndex = 22;
            this.v_status.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(380, 332);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 37);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // v_descripcion
            // 
            this.v_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_descripcion.Location = new System.Drawing.Point(182, 39);
            this.v_descripcion.Name = "v_descripcion";
            this.v_descripcion.Size = new System.Drawing.Size(208, 22);
            this.v_descripcion.TabIndex = 20;
            this.v_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_contrasena
            // 
            this.l_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_contrasena.AutoSize = true;
            this.l_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contrasena.Location = new System.Drawing.Point(34, 245);
            this.l_contrasena.Name = "l_contrasena";
            this.l_contrasena.Size = new System.Drawing.Size(79, 25);
            this.l_contrasena.TabIndex = 19;
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
            this.l_usuario.Location = new System.Drawing.Point(35, 36);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(125, 25);
            this.l_usuario.TabIndex = 18;
            this.l_usuario.Text = "Descripcion";
            this.l_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sistemaRentCarDataSet
            // 
            this.sistemaRentCarDataSet.DataSetName = "SistemaRentCarDataSet";
            this.sistemaRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.sistemaRentCarDataSet;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // v_chasis
            // 
            this.v_chasis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_chasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_chasis.Location = new System.Drawing.Point(182, 89);
            this.v_chasis.Name = "v_chasis";
            this.v_chasis.Size = new System.Drawing.Size(208, 22);
            this.v_chasis.TabIndex = 26;
            this.v_chasis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.v_chasis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Chasis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // v_placa
            // 
            this.v_placa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_placa.Location = new System.Drawing.Point(182, 193);
            this.v_placa.Name = "v_placa";
            this.v_placa.Size = new System.Drawing.Size(208, 22);
            this.v_placa.TabIndex = 30;
            this.v_placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Placa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_motor
            // 
            this.v_motor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_motor.Location = new System.Drawing.Point(182, 143);
            this.v_motor.Name = "v_motor";
            this.v_motor.Size = new System.Drawing.Size(208, 22);
            this.v_motor.TabIndex = 28;
            this.v_motor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Motor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_modelo
            // 
            this.v_modelo.DisplayMember = "Id";
            this.v_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_modelo.FormattingEnabled = true;
            this.v_modelo.Location = new System.Drawing.Point(631, 90);
            this.v_modelo.Name = "v_modelo";
            this.v_modelo.Size = new System.Drawing.Size(208, 24);
            this.v_modelo.TabIndex = 32;
            this.v_modelo.Tag = "";
            this.v_modelo.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Modelo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_tipoVehiculo
            // 
            this.v_tipoVehiculo.DisplayMember = "Id";
            this.v_tipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_tipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_tipoVehiculo.FormattingEnabled = true;
            this.v_tipoVehiculo.Location = new System.Drawing.Point(631, 139);
            this.v_tipoVehiculo.Name = "v_tipoVehiculo";
            this.v_tipoVehiculo.Size = new System.Drawing.Size(208, 24);
            this.v_tipoVehiculo.TabIndex = 34;
            this.v_tipoVehiculo.Tag = "";
            this.v_tipoVehiculo.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tipo Vehiculo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_tipoCombustible
            // 
            this.v_tipoCombustible.DisplayMember = "Id";
            this.v_tipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_tipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_tipoCombustible.FormattingEnabled = true;
            this.v_tipoCombustible.Location = new System.Drawing.Point(631, 190);
            this.v_tipoCombustible.Name = "v_tipoCombustible";
            this.v_tipoCombustible.Size = new System.Drawing.Size(208, 24);
            this.v_tipoCombustible.TabIndex = 36;
            this.v_tipoCombustible.Tag = "";
            this.v_tipoCombustible.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipo Combustible";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 411);
            this.Controls.Add(this.v_tipoCombustible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.v_tipoVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.v_modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v_placa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v_motor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.v_chasis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.v_marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.v_descripcion);
            this.Controls.Add(this.l_contrasena);
            this.Controls.Add(this.l_usuario);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox v_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox v_status;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox v_descripcion;
        private System.Windows.Forms.Label l_contrasena;
        public System.Windows.Forms.Label l_usuario;
        private SistemaRentCarDataSet sistemaRentCarDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private SistemaRentCarDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.TextBox v_chasis;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v_placa;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v_motor;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox v_modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox v_tipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox v_tipoCombustible;
        private System.Windows.Forms.Label label7;
    }
}