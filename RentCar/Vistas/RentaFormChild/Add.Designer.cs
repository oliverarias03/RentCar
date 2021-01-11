
namespace RentCar.Vistas.RentaFormChild
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
            this.v_cliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.v_vehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaRentCarDataSet = new RentCar.SistemaRentCarDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.v_status = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.l_contrasena = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.marcaTableAdapter = new RentCar.SistemaRentCarDataSetTableAdapters.MarcaTableAdapter();
            this.v_empleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.v_fechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.v_fechaRenta = new System.Windows.Forms.DateTimePicker();
            this.v_montoDia = new System.Windows.Forms.NumericUpDown();
            this.v_dias = new System.Windows.Forms.NumericUpDown();
            this.v_comentario = new System.Windows.Forms.TextBox();
            this.check_devolucion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_montoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dias)).BeginInit();
            this.SuspendLayout();
            // 
            // v_cliente
            // 
            this.v_cliente.DisplayMember = "Id";
            this.v_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_cliente.FormattingEnabled = true;
            this.v_cliente.Location = new System.Drawing.Point(157, 129);
            this.v_cliente.Name = "v_cliente";
            this.v_cliente.Size = new System.Drawing.Size(279, 24);
            this.v_cliente.TabIndex = 53;
            this.v_cliente.Tag = "";
            this.v_cliente.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_vehiculo
            // 
            this.v_vehiculo.DisplayMember = "Id";
            this.v_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_vehiculo.FormattingEnabled = true;
            this.v_vehiculo.Location = new System.Drawing.Point(157, 80);
            this.v_vehiculo.Name = "v_vehiculo";
            this.v_vehiculo.Size = new System.Drawing.Size(279, 24);
            this.v_vehiculo.TabIndex = 51;
            this.v_vehiculo.Tag = "";
            this.v_vehiculo.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Vehiculo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Comentario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Monto x Dia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Fecha Devolucion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.sistemaRentCarDataSet;
            // 
            // sistemaRentCarDataSet
            // 
            this.sistemaRentCarDataSet.DataSetName = "SistemaRentCarDataSet";
            this.sistemaRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_status
            // 
            this.v_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_status.FormattingEnabled = true;
            this.v_status.Items.AddRange(new object[] {
            "Proceso",
            "Completado"});
            this.v_status.Location = new System.Drawing.Point(157, 188);
            this.v_status.Name = "v_status";
            this.v_status.Size = new System.Drawing.Size(279, 24);
            this.v_status.TabIndex = 41;
            this.v_status.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(391, 433);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 37);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // l_contrasena
            // 
            this.l_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_contrasena.AutoSize = true;
            this.l_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contrasena.Location = new System.Drawing.Point(29, 187);
            this.l_contrasena.Name = "l_contrasena";
            this.l_contrasena.Size = new System.Drawing.Size(79, 25);
            this.l_contrasena.TabIndex = 38;
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
            this.l_usuario.Location = new System.Drawing.Point(474, 30);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(135, 25);
            this.l_usuario.TabIndex = 37;
            this.l_usuario.Text = "Fecha Renta";
            this.l_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // v_empleado
            // 
            this.v_empleado.DisplayMember = "Id";
            this.v_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_empleado.FormattingEnabled = true;
            this.v_empleado.Location = new System.Drawing.Point(157, 30);
            this.v_empleado.Name = "v_empleado";
            this.v_empleado.Size = new System.Drawing.Size(279, 24);
            this.v_empleado.TabIndex = 43;
            this.v_empleado.Tag = "";
            this.v_empleado.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Dias";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_fechaDevolucion
            // 
            this.v_fechaDevolucion.Location = new System.Drawing.Point(665, 82);
            this.v_fechaDevolucion.Name = "v_fechaDevolucion";
            this.v_fechaDevolucion.Size = new System.Drawing.Size(223, 20);
            this.v_fechaDevolucion.TabIndex = 55;
            // 
            // v_fechaRenta
            // 
            this.v_fechaRenta.Location = new System.Drawing.Point(665, 35);
            this.v_fechaRenta.Name = "v_fechaRenta";
            this.v_fechaRenta.Size = new System.Drawing.Size(223, 20);
            this.v_fechaRenta.TabIndex = 56;
            // 
            // v_montoDia
            // 
            this.v_montoDia.Location = new System.Drawing.Point(665, 138);
            this.v_montoDia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.v_montoDia.Name = "v_montoDia";
            this.v_montoDia.Size = new System.Drawing.Size(223, 20);
            this.v_montoDia.TabIndex = 57;
            // 
            // v_dias
            // 
            this.v_dias.Location = new System.Drawing.Point(665, 189);
            this.v_dias.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.v_dias.Name = "v_dias";
            this.v_dias.Size = new System.Drawing.Size(223, 20);
            this.v_dias.TabIndex = 58;
            // 
            // v_comentario
            // 
            this.v_comentario.Location = new System.Drawing.Point(157, 256);
            this.v_comentario.Multiline = true;
            this.v_comentario.Name = "v_comentario";
            this.v_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.v_comentario.Size = new System.Drawing.Size(731, 110);
            this.v_comentario.TabIndex = 59;
            // 
            // check_devolucion
            // 
            this.check_devolucion.AutoSize = true;
            this.check_devolucion.Location = new System.Drawing.Point(909, 85);
            this.check_devolucion.Name = "check_devolucion";
            this.check_devolucion.Size = new System.Drawing.Size(15, 14);
            this.check_devolucion.TabIndex = 60;
            this.check_devolucion.UseVisualStyleBackColor = true;
            this.check_devolucion.CheckedChanged += new System.EventHandler(this.check_devolucion_CheckedChanged);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 527);
            this.Controls.Add(this.check_devolucion);
            this.Controls.Add(this.v_comentario);
            this.Controls.Add(this.v_dias);
            this.Controls.Add(this.v_montoDia);
            this.Controls.Add(this.v_fechaRenta);
            this.Controls.Add(this.v_fechaDevolucion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.v_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.v_vehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.l_contrasena);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.v_empleado);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renta y Devolucion";
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_montoDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_dias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox v_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox v_vehiculo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private SistemaRentCarDataSet sistemaRentCarDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox v_status;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label l_contrasena;
        public System.Windows.Forms.Label l_usuario;
        private SistemaRentCarDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.ComboBox v_empleado;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker v_fechaDevolucion;
        private System.Windows.Forms.DateTimePicker v_fechaRenta;
        private System.Windows.Forms.NumericUpDown v_montoDia;
        private System.Windows.Forms.NumericUpDown v_dias;
        private System.Windows.Forms.TextBox v_comentario;
        private System.Windows.Forms.CheckBox check_devolucion;
    }
}