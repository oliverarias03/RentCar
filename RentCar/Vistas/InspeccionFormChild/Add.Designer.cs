
namespace RentCar.Vistas.InspeccionFormChild
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
            this.v_cliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.v_vehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.v_status = new System.Windows.Forms.ComboBox();
            this.l_contrasena = new System.Windows.Forms.Label();
            this.v_empleado = new System.Windows.Forms.ComboBox();
            this.v_combustible = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.v_gomasDelanteras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v_gomasTraseras = new System.Windows.Forms.ComboBox();
            this.v_fecha = new System.Windows.Forms.DateTimePicker();
            this.l_usuario = new System.Windows.Forms.Label();
            this.v_comentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_ralladuras = new System.Windows.Forms.CheckBox();
            this.cb_goma = new System.Windows.Forms.CheckBox();
            this.cb_gato = new System.Windows.Forms.CheckBox();
            this.cb_cristal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // v_cliente
            // 
            this.v_cliente.DisplayMember = "Id";
            this.v_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_cliente.FormattingEnabled = true;
            this.v_cliente.Location = new System.Drawing.Point(146, 75);
            this.v_cliente.Name = "v_cliente";
            this.v_cliente.Size = new System.Drawing.Size(279, 24);
            this.v_cliente.TabIndex = 61;
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
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_vehiculo
            // 
            this.v_vehiculo.DisplayMember = "Id";
            this.v_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_vehiculo.FormattingEnabled = true;
            this.v_vehiculo.Location = new System.Drawing.Point(146, 22);
            this.v_vehiculo.Name = "v_vehiculo";
            this.v_vehiculo.Size = new System.Drawing.Size(279, 24);
            this.v_vehiculo.TabIndex = 59;
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
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Vehiculo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 56;
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
            this.v_status.Location = new System.Drawing.Point(146, 180);
            this.v_status.Name = "v_status";
            this.v_status.Size = new System.Drawing.Size(279, 24);
            this.v_status.TabIndex = 55;
            this.v_status.Tag = "";
            // 
            // l_contrasena
            // 
            this.l_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_contrasena.AutoSize = true;
            this.l_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contrasena.Location = new System.Drawing.Point(469, 22);
            this.l_contrasena.Name = "l_contrasena";
            this.l_contrasena.Size = new System.Drawing.Size(223, 25);
            this.l_contrasena.TabIndex = 54;
            this.l_contrasena.Text = "Cantidad Combustible";
            this.l_contrasena.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_empleado
            // 
            this.v_empleado.DisplayMember = "Id";
            this.v_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_empleado.FormattingEnabled = true;
            this.v_empleado.Location = new System.Drawing.Point(146, 128);
            this.v_empleado.Name = "v_empleado";
            this.v_empleado.Size = new System.Drawing.Size(279, 24);
            this.v_empleado.TabIndex = 57;
            this.v_empleado.Tag = "";
            this.v_empleado.ValueMember = "Id";
            // 
            // v_combustible
            // 
            this.v_combustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_combustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_combustible.FormattingEnabled = true;
            this.v_combustible.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "3/4",
            "Lleno"});
            this.v_combustible.Location = new System.Drawing.Point(738, 21);
            this.v_combustible.Name = "v_combustible";
            this.v_combustible.Size = new System.Drawing.Size(279, 24);
            this.v_combustible.TabIndex = 63;
            this.v_combustible.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Estado Gomas Delanteras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_gomasDelanteras
            // 
            this.v_gomasDelanteras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_gomasDelanteras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gomasDelanteras.FormattingEnabled = true;
            this.v_gomasDelanteras.Items.AddRange(new object[] {
            "Correcto",
            "Incorrecto"});
            this.v_gomasDelanteras.Location = new System.Drawing.Point(738, 74);
            this.v_gomasDelanteras.Name = "v_gomasDelanteras";
            this.v_gomasDelanteras.Size = new System.Drawing.Size(279, 24);
            this.v_gomasDelanteras.TabIndex = 64;
            this.v_gomasDelanteras.Tag = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Estado Gomas Traseras";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_gomasTraseras
            // 
            this.v_gomasTraseras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_gomasTraseras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gomasTraseras.FormattingEnabled = true;
            this.v_gomasTraseras.Items.AddRange(new object[] {
            "Correcto",
            "Incorrecto"});
            this.v_gomasTraseras.Location = new System.Drawing.Point(738, 129);
            this.v_gomasTraseras.Name = "v_gomasTraseras";
            this.v_gomasTraseras.Size = new System.Drawing.Size(279, 24);
            this.v_gomasTraseras.TabIndex = 66;
            this.v_gomasTraseras.Tag = "";
            // 
            // v_fecha
            // 
            this.v_fecha.Location = new System.Drawing.Point(738, 185);
            this.v_fecha.Name = "v_fecha";
            this.v_fecha.Size = new System.Drawing.Size(279, 20);
            this.v_fecha.TabIndex = 69;
            // 
            // l_usuario
            // 
            this.l_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_usuario.AutoSize = true;
            this.l_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_usuario.Location = new System.Drawing.Point(469, 180);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(181, 25);
            this.l_usuario.TabIndex = 68;
            this.l_usuario.Text = "Fecha Inspeccion";
            this.l_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v_comentario
            // 
            this.v_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_comentario.Location = new System.Drawing.Point(146, 340);
            this.v_comentario.Multiline = true;
            this.v_comentario.Name = "v_comentario";
            this.v_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.v_comentario.Size = new System.Drawing.Size(871, 110);
            this.v_comentario.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Comentario";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(474, 503);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 37);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 73;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_ralladuras
            // 
            this.cb_ralladuras.AutoSize = true;
            this.cb_ralladuras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ralladuras.Location = new System.Drawing.Point(85, 259);
            this.cb_ralladuras.Name = "cb_ralladuras";
            this.cb_ralladuras.Size = new System.Drawing.Size(131, 20);
            this.cb_ralladuras.TabIndex = 74;
            this.cb_ralladuras.Text = "Tiene Ralladuras";
            this.cb_ralladuras.UseVisualStyleBackColor = true;
            // 
            // cb_goma
            // 
            this.cb_goma.AutoSize = true;
            this.cb_goma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_goma.Location = new System.Drawing.Point(294, 259);
            this.cb_goma.Name = "cb_goma";
            this.cb_goma.Size = new System.Drawing.Size(171, 20);
            this.cb_goma.TabIndex = 75;
            this.cb_goma.Text = "Tiene Goma Respuesta";
            this.cb_goma.UseVisualStyleBackColor = true;
            // 
            // cb_gato
            // 
            this.cb_gato.AutoSize = true;
            this.cb_gato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gato.Location = new System.Drawing.Point(567, 259);
            this.cb_gato.Name = "cb_gato";
            this.cb_gato.Size = new System.Drawing.Size(94, 20);
            this.cb_gato.TabIndex = 76;
            this.cb_gato.Text = "Tiene Gato";
            this.cb_gato.UseVisualStyleBackColor = true;
            // 
            // cb_cristal
            // 
            this.cb_cristal.AutoSize = true;
            this.cb_cristal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cristal.Location = new System.Drawing.Point(771, 258);
            this.cb_cristal.Name = "cb_cristal";
            this.cb_cristal.Size = new System.Drawing.Size(184, 20);
            this.cb_cristal.TabIndex = 77;
            this.cb_cristal.Text = "Tiene Roturas en el Cristal";
            this.cb_cristal.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 586);
            this.Controls.Add(this.cb_cristal);
            this.Controls.Add(this.cb_gato);
            this.Controls.Add(this.cb_goma);
            this.Controls.Add(this.cb_ralladuras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.v_comentario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.v_fecha);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.v_gomasTraseras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v_gomasDelanteras);
            this.Controls.Add(this.v_combustible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.v_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.v_vehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_status);
            this.Controls.Add(this.l_contrasena);
            this.Controls.Add(this.v_empleado);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox v_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox v_vehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox v_status;
        private System.Windows.Forms.Label l_contrasena;
        private System.Windows.Forms.ComboBox v_empleado;
        private System.Windows.Forms.ComboBox v_combustible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox v_gomasDelanteras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox v_gomasTraseras;
        private System.Windows.Forms.DateTimePicker v_fecha;
        public System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.TextBox v_comentario;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_ralladuras;
        private System.Windows.Forms.CheckBox cb_goma;
        private System.Windows.Forms.CheckBox cb_gato;
        private System.Windows.Forms.CheckBox cb_cristal;
    }
}