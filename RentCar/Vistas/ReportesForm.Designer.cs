
namespace RentCar.Vistas
{
    partial class ReportesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.v_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cb_fecha = new System.Windows.Forms.CheckBox();
            this.v_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.v_marca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.v_tipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_marca = new System.Windows.Forms.CheckBox();
            this.cb_tipo = new System.Windows.Forms.CheckBox();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1237, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_export);
            this.splitContainer1.Panel1.Controls.Add(this.cb_tipo);
            this.splitContainer1.Panel1.Controls.Add(this.cb_marca);
            this.splitContainer1.Panel1.Controls.Add(this.v_tipoVehiculo);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.v_marca);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.v_fechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cb_fecha);
            this.splitContainer1.Panel1.Controls.Add(this.v_fechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 497);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 3;
            // 
            // v_fechaDesde
            // 
            this.v_fechaDesde.Location = new System.Drawing.Point(130, 15);
            this.v_fechaDesde.Name = "v_fechaDesde";
            this.v_fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.v_fechaDesde.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desde";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(908, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 27);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cb_fecha
            // 
            this.cb_fecha.AutoSize = true;
            this.cb_fecha.Location = new System.Drawing.Point(12, 41);
            this.cb_fecha.Name = "cb_fecha";
            this.cb_fecha.Size = new System.Drawing.Size(15, 14);
            this.cb_fecha.TabIndex = 10;
            this.cb_fecha.UseVisualStyleBackColor = true;
            this.cb_fecha.CheckedChanged += new System.EventHandler(this.cb_fecha_CheckedChanged);
            // 
            // v_fechaHasta
            // 
            this.v_fechaHasta.Location = new System.Drawing.Point(130, 55);
            this.v_fechaHasta.Name = "v_fechaHasta";
            this.v_fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.v_fechaHasta.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta";
            // 
            // v_marca
            // 
            this.v_marca.DisplayMember = "Id";
            this.v_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_marca.FormattingEnabled = true;
            this.v_marca.Location = new System.Drawing.Point(525, 12);
            this.v_marca.Name = "v_marca";
            this.v_marca.Size = new System.Drawing.Size(208, 24);
            this.v_marca.TabIndex = 26;
            this.v_marca.Tag = "";
            this.v_marca.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // v_tipoVehiculo
            // 
            this.v_tipoVehiculo.DisplayMember = "Id";
            this.v_tipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_tipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_tipoVehiculo.FormattingEnabled = true;
            this.v_tipoVehiculo.Location = new System.Drawing.Point(525, 51);
            this.v_tipoVehiculo.Name = "v_tipoVehiculo";
            this.v_tipoVehiculo.Size = new System.Drawing.Size(208, 24);
            this.v_tipoVehiculo.TabIndex = 36;
            this.v_tipoVehiculo.Tag = "";
            this.v_tipoVehiculo.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tipo Vehiculo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_marca
            // 
            this.cb_marca.AutoSize = true;
            this.cb_marca.Location = new System.Drawing.Point(394, 21);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(15, 14);
            this.cb_marca.TabIndex = 37;
            this.cb_marca.UseVisualStyleBackColor = true;
            this.cb_marca.CheckedChanged += new System.EventHandler(this.cb_marca_CheckedChanged);
            // 
            // cb_tipo
            // 
            this.cb_tipo.AutoSize = true;
            this.cb_tipo.Location = new System.Drawing.Point(394, 57);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(15, 14);
            this.cb_tipo.TabIndex = 38;
            this.cb_tipo.UseVisualStyleBackColor = true;
            this.cb_tipo.CheckedChanged += new System.EventHandler(this.cb_tipo_CheckedChanged);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(908, 55);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(89, 27);
            this.btn_export.TabIndex = 39;
            this.btn_export.Text = "exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 497);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker v_fechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox cb_fecha;
        private System.Windows.Forms.DateTimePicker v_fechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox v_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_tipo;
        private System.Windows.Forms.CheckBox cb_marca;
        private System.Windows.Forms.ComboBox v_tipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_export;
    }
}