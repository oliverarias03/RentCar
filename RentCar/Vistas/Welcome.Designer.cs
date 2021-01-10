
namespace RentCar.Vistas
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.v_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.v_fechaActual = new System.Windows.Forms.Label();
            this.btn_Combustibles = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Marcas = new System.Windows.Forms.Button();
            this.btn_Vehiculos = new System.Windows.Forms.Button();
            this.btn_inspeccion = new System.Windows.Forms.Button();
            this.btn_Modelos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_renta = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_tipoVehiculos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saludos,";
            // 
            // v_username
            // 
            this.v_username.AutoSize = true;
            this.v_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_username.Location = new System.Drawing.Point(182, 9);
            this.v_username.Name = "v_username";
            this.v_username.Size = new System.Drawing.Size(191, 42);
            this.v_username.TabIndex = 1;
            this.v_username.Text = "Oliver Aria";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(854, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(107, 39);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Cerrar Sesion";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // v_fechaActual
            // 
            this.v_fechaActual.AutoSize = true;
            this.v_fechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_fechaActual.Location = new System.Drawing.Point(826, 560);
            this.v_fechaActual.Name = "v_fechaActual";
            this.v_fechaActual.Size = new System.Drawing.Size(24, 16);
            this.v_fechaActual.TabIndex = 3;
            this.v_fechaActual.Text = "rrrr";
            // 
            // btn_Combustibles
            // 
            this.btn_Combustibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Combustibles.Location = new System.Drawing.Point(34, 192);
            this.btn_Combustibles.Name = "btn_Combustibles";
            this.btn_Combustibles.Size = new System.Drawing.Size(230, 47);
            this.btn_Combustibles.TabIndex = 5;
            this.btn_Combustibles.Text = "Gestion de Tipos de Combustibles";
            this.btn_Combustibles.UseVisualStyleBackColor = true;
            this.btn_Combustibles.Click += new System.EventHandler(this.btn_Combustibles_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.Location = new System.Drawing.Point(34, 272);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(230, 47);
            this.btn_Empleados.TabIndex = 6;
            this.btn_Empleados.Text = "Gestion de Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = true;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Marcas
            // 
            this.btn_Marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Marcas.Location = new System.Drawing.Point(363, 114);
            this.btn_Marcas.Name = "btn_Marcas";
            this.btn_Marcas.Size = new System.Drawing.Size(230, 47);
            this.btn_Marcas.TabIndex = 7;
            this.btn_Marcas.Text = "Gestion de Marcas";
            this.btn_Marcas.UseVisualStyleBackColor = true;
            this.btn_Marcas.Click += new System.EventHandler(this.btn_Marcas_Click);
            // 
            // btn_Vehiculos
            // 
            this.btn_Vehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vehiculos.Location = new System.Drawing.Point(363, 192);
            this.btn_Vehiculos.Name = "btn_Vehiculos";
            this.btn_Vehiculos.Size = new System.Drawing.Size(230, 47);
            this.btn_Vehiculos.TabIndex = 8;
            this.btn_Vehiculos.Text = "Gestion de Vehiculos";
            this.btn_Vehiculos.UseVisualStyleBackColor = true;
            this.btn_Vehiculos.Click += new System.EventHandler(this.btn_Vehiculos_Click);
            // 
            // btn_inspeccion
            // 
            this.btn_inspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inspeccion.Location = new System.Drawing.Point(363, 272);
            this.btn_inspeccion.Name = "btn_inspeccion";
            this.btn_inspeccion.Size = new System.Drawing.Size(230, 47);
            this.btn_inspeccion.TabIndex = 9;
            this.btn_inspeccion.Text = "Proceso de Inspeccion";
            this.btn_inspeccion.UseVisualStyleBackColor = true;
            this.btn_inspeccion.Click += new System.EventHandler(this.btn_inspeccion_Click);
            // 
            // btn_Modelos
            // 
            this.btn_Modelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modelos.Location = new System.Drawing.Point(684, 114);
            this.btn_Modelos.Name = "btn_Modelos";
            this.btn_Modelos.Size = new System.Drawing.Size(230, 47);
            this.btn_Modelos.TabIndex = 10;
            this.btn_Modelos.Text = "Gestion de Modelos";
            this.btn_Modelos.UseVisualStyleBackColor = true;
            this.btn_Modelos.Click += new System.EventHandler(this.btn_Modelos_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(684, 192);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(230, 47);
            this.btn_Clientes.TabIndex = 11;
            this.btn_Clientes.Text = "Gestion de Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_renta
            // 
            this.btn_renta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renta.Location = new System.Drawing.Point(684, 272);
            this.btn_renta.Name = "btn_renta";
            this.btn_renta.Size = new System.Drawing.Size(230, 47);
            this.btn_renta.TabIndex = 12;
            this.btn_renta.Text = "Renta y Devolucion de Vehiculos";
            this.btn_renta.UseVisualStyleBackColor = true;
            this.btn_renta.Click += new System.EventHandler(this.btn_renta_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.Location = new System.Drawing.Point(34, 389);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(230, 47);
            this.btn_consultas.TabIndex = 13;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = true;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Location = new System.Drawing.Point(363, 389);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(230, 47);
            this.btn_reportes.TabIndex = 14;
            this.btn_reportes.Text = "Reportes de Rentas";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_tipoVehiculos
            // 
            this.btn_tipoVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipoVehiculos.Location = new System.Drawing.Point(34, 114);
            this.btn_tipoVehiculos.Name = "btn_tipoVehiculos";
            this.btn_tipoVehiculos.Size = new System.Drawing.Size(230, 47);
            this.btn_tipoVehiculos.TabIndex = 15;
            this.btn_tipoVehiculos.Text = "Gestion Tipo de Vehiculos";
            this.btn_tipoVehiculos.UseVisualStyleBackColor = true;
            this.btn_tipoVehiculos.Click += new System.EventHandler(this.btn_tipoVehiculos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Inicio de Sesion:";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tipoVehiculos);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_renta);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Modelos);
            this.Controls.Add(this.btn_inspeccion);
            this.Controls.Add(this.btn_Vehiculos);
            this.Controls.Add(this.btn_Marcas);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.btn_Combustibles);
            this.Controls.Add(this.v_fechaActual);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.v_username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label v_username;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label v_fechaActual;
        private System.Windows.Forms.Button btn_Combustibles;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Marcas;
        private System.Windows.Forms.Button btn_Vehiculos;
        private System.Windows.Forms.Button btn_inspeccion;
        private System.Windows.Forms.Button btn_Modelos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_renta;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_tipoVehiculos;
        private System.Windows.Forms.Label label2;
    }
}