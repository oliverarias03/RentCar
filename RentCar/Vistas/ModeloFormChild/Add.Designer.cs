
namespace RentCar.Vistas.ModeloFormChild
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
            this.v_status = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.v_descripcion = new System.Windows.Forms.TextBox();
            this.l_contrasena = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.v_marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sistemaRentCarDataSet = new RentCar.SistemaRentCarDataSet();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new RentCar.SistemaRentCarDataSetTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // v_status
            // 
            this.v_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_status.FormattingEnabled = true;
            this.v_status.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.v_status.Location = new System.Drawing.Point(200, 108);
            this.v_status.Name = "v_status";
            this.v_status.Size = new System.Drawing.Size(208, 24);
            this.v_status.TabIndex = 15;
            this.v_status.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(270, 232);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 37);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // v_descripcion
            // 
            this.v_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_descripcion.Location = new System.Drawing.Point(200, 52);
            this.v_descripcion.Name = "v_descripcion";
            this.v_descripcion.Size = new System.Drawing.Size(208, 22);
            this.v_descripcion.TabIndex = 13;
            this.v_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_contrasena
            // 
            this.l_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_contrasena.AutoSize = true;
            this.l_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contrasena.Location = new System.Drawing.Point(53, 105);
            this.l_contrasena.Name = "l_contrasena";
            this.l_contrasena.Size = new System.Drawing.Size(79, 25);
            this.l_contrasena.TabIndex = 12;
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
            this.l_usuario.Location = new System.Drawing.Point(53, 49);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(125, 25);
            this.l_usuario.TabIndex = 11;
            this.l_usuario.Text = "Descripcion";
            this.l_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_marca
            // 
            this.v_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_marca.FormattingEnabled = true;
            this.v_marca.Location = new System.Drawing.Point(200, 167);
            this.v_marca.Name = "v_marca";
            this.v_marca.Size = new System.Drawing.Size(208, 24);
            this.v_marca.TabIndex = 17;
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
            this.label1.Location = new System.Drawing.Point(53, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Marca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 322);
            this.Controls.Add(this.v_marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.v_descripcion);
            this.Controls.Add(this.l_contrasena);
            this.Controls.Add(this.l_usuario);
            this.Name = "Add";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox v_status;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox v_descripcion;
        private System.Windows.Forms.Label l_contrasena;
        public System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.ComboBox v_marca;
        private System.Windows.Forms.Label label1;
        private SistemaRentCarDataSet sistemaRentCarDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private SistemaRentCarDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}