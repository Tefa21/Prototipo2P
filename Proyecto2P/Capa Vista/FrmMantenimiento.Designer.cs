namespace Capa_Vista
{
    partial class FrmMantenimiento
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
            this.Tbc_Mantenimientos = new System.Windows.Forms.TabControl();
            this.Tbp_Ingreso = new System.Windows.Forms.TabPage();
            this.Tbp_Eliminar = new System.Windows.Forms.TabPage();
            this.Btn_Ingreso = new System.Windows.Forms.Button();
            this.Gpb_Datos_Ingreso = new System.Windows.Forms.GroupBox();
            this.Lbl_Sueldo_Ingreso = new System.Windows.Forms.Label();
            this.Txt_Sueldo_Ingreso = new System.Windows.Forms.TextBox();
            this.Cmb_Departamento_Ingreso = new System.Windows.Forms.ComboBox();
            this.Lbl_Departamento_Ingreso = new System.Windows.Forms.Label();
            this.Cmb_Puesto_Ingreso = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoPuesto_Ingreso = new System.Windows.Forms.Label();
            this.Txt_Nombre1_Ingreso = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre1_Ingreso = new System.Windows.Forms.Label();
            this.Lbl_Nombre2_Ingreso = new System.Windows.Forms.Label();
            this.Lbl_Apellido1_Ingreso = new System.Windows.Forms.Label();
            this.Txt_Apellido2_Ingreso = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido2_Ingreso = new System.Windows.Forms.Label();
            this.Txt_Apellido1_Ingreso = new System.Windows.Forms.TextBox();
            this.Txt_Nombre2_Ingreso = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo2 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Gpb_Datos_Eliminar = new System.Windows.Forms.GroupBox();
            this.Lbl_Sueldo_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Sueldo_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Departamento_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_Puesto_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Nombre1_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre1_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_Nombre2_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_Apellido1_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Apellido2_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido2_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Apellido1_Eliminar = new System.Windows.Forms.TextBox();
            this.Txt_Nombre2_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo4 = new System.Windows.Forms.Label();
            this.Btn_Busqueda_Eliminar = new System.Windows.Forms.Button();
            this.Txt_Busqueda_Eliminar = new System.Windows.Forms.TextBox();
            this.Txt_Puesto_Eliminar = new System.Windows.Forms.TextBox();
            this.Txt_Departamento_Eliminar = new System.Windows.Forms.TextBox();
            this.Tbc_Mantenimientos.SuspendLayout();
            this.Tbp_Ingreso.SuspendLayout();
            this.Tbp_Eliminar.SuspendLayout();
            this.Gpb_Datos_Ingreso.SuspendLayout();
            this.Gpb_Datos_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Mantenimientos
            // 
            this.Tbc_Mantenimientos.Controls.Add(this.Tbp_Ingreso);
            this.Tbc_Mantenimientos.Controls.Add(this.Tbp_Eliminar);
            this.Tbc_Mantenimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Mantenimientos.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Mantenimientos.Name = "Tbc_Mantenimientos";
            this.Tbc_Mantenimientos.SelectedIndex = 0;
            this.Tbc_Mantenimientos.Size = new System.Drawing.Size(800, 450);
            this.Tbc_Mantenimientos.TabIndex = 0;
            // 
            // Tbp_Ingreso
            // 
            this.Tbp_Ingreso.Controls.Add(this.Btn_Ingreso);
            this.Tbp_Ingreso.Controls.Add(this.Gpb_Datos_Ingreso);
            this.Tbp_Ingreso.Controls.Add(this.Lbl_Titulo2);
            this.Tbp_Ingreso.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Ingreso.Name = "Tbp_Ingreso";
            this.Tbp_Ingreso.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Ingreso.Size = new System.Drawing.Size(792, 424);
            this.Tbp_Ingreso.TabIndex = 0;
            this.Tbp_Ingreso.Text = "Ingreso de Empleado";
            this.Tbp_Ingreso.UseVisualStyleBackColor = true;
            // 
            // Tbp_Eliminar
            // 
            this.Tbp_Eliminar.Controls.Add(this.Btn_Busqueda_Eliminar);
            this.Tbp_Eliminar.Controls.Add(this.Txt_Busqueda_Eliminar);
            this.Tbp_Eliminar.Controls.Add(this.Lbl_Titulo4);
            this.Tbp_Eliminar.Controls.Add(this.Btn_Eliminar);
            this.Tbp_Eliminar.Controls.Add(this.Gpb_Datos_Eliminar);
            this.Tbp_Eliminar.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Eliminar.Name = "Tbp_Eliminar";
            this.Tbp_Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Eliminar.Size = new System.Drawing.Size(792, 424);
            this.Tbp_Eliminar.TabIndex = 1;
            this.Tbp_Eliminar.Text = "Despedir Empleado";
            this.Tbp_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Ingreso
            // 
            this.Btn_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Ingreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Ingreso.FlatAppearance.BorderSize = 0;
            this.Btn_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingreso.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingreso.Location = new System.Drawing.Point(322, 351);
            this.Btn_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingreso.Name = "Btn_Ingreso";
            this.Btn_Ingreso.Size = new System.Drawing.Size(136, 41);
            this.Btn_Ingreso.TabIndex = 29;
            this.Btn_Ingreso.Text = "INGRESAR";
            this.Btn_Ingreso.UseVisualStyleBackColor = false;
            this.Btn_Ingreso.Click += new System.EventHandler(this.Btn_Ingreso_Click);
            // 
            // Gpb_Datos_Ingreso
            // 
            this.Gpb_Datos_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Sueldo_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Txt_Sueldo_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Cmb_Departamento_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Departamento_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Cmb_Puesto_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_TipoPuesto_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Txt_Nombre1_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Nombre1_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Nombre2_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Apellido1_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Txt_Apellido2_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Lbl_Apellido2_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Txt_Apellido1_Ingreso);
            this.Gpb_Datos_Ingreso.Controls.Add(this.Txt_Nombre2_Ingreso);
            this.Gpb_Datos_Ingreso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_Ingreso.Location = new System.Drawing.Point(26, 72);
            this.Gpb_Datos_Ingreso.Name = "Gpb_Datos_Ingreso";
            this.Gpb_Datos_Ingreso.Size = new System.Drawing.Size(744, 246);
            this.Gpb_Datos_Ingreso.TabIndex = 28;
            this.Gpb_Datos_Ingreso.TabStop = false;
            this.Gpb_Datos_Ingreso.Text = "Datos Personales";
            // 
            // Lbl_Sueldo_Ingreso
            // 
            this.Lbl_Sueldo_Ingreso.AutoSize = true;
            this.Lbl_Sueldo_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Sueldo_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sueldo_Ingreso.Location = new System.Drawing.Point(25, 194);
            this.Lbl_Sueldo_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sueldo_Ingreso.Name = "Lbl_Sueldo_Ingreso";
            this.Lbl_Sueldo_Ingreso.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Sueldo_Ingreso.TabIndex = 42;
            this.Lbl_Sueldo_Ingreso.Text = "SUELDO";
            // 
            // Txt_Sueldo_Ingreso
            // 
            this.Txt_Sueldo_Ingreso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Sueldo_Ingreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Sueldo_Ingreso.Location = new System.Drawing.Point(28, 210);
            this.Txt_Sueldo_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Sueldo_Ingreso.Name = "Txt_Sueldo_Ingreso";
            this.Txt_Sueldo_Ingreso.Size = new System.Drawing.Size(318, 15);
            this.Txt_Sueldo_Ingreso.TabIndex = 43;
            // 
            // Cmb_Departamento_Ingreso
            // 
            this.Cmb_Departamento_Ingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Departamento_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Departamento_Ingreso.FormattingEnabled = true;
            this.Cmb_Departamento_Ingreso.Location = new System.Drawing.Point(395, 155);
            this.Cmb_Departamento_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Departamento_Ingreso.Name = "Cmb_Departamento_Ingreso";
            this.Cmb_Departamento_Ingreso.Size = new System.Drawing.Size(318, 22);
            this.Cmb_Departamento_Ingreso.TabIndex = 41;
            // 
            // Lbl_Departamento_Ingreso
            // 
            this.Lbl_Departamento_Ingreso.AutoSize = true;
            this.Lbl_Departamento_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Departamento_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento_Ingreso.Location = new System.Drawing.Point(392, 137);
            this.Lbl_Departamento_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Departamento_Ingreso.Name = "Lbl_Departamento_Ingreso";
            this.Lbl_Departamento_Ingreso.Size = new System.Drawing.Size(90, 14);
            this.Lbl_Departamento_Ingreso.TabIndex = 40;
            this.Lbl_Departamento_Ingreso.Text = "DEPARTAMENTO";
            // 
            // Cmb_Puesto_Ingreso
            // 
            this.Cmb_Puesto_Ingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Puesto_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Puesto_Ingreso.FormattingEnabled = true;
            this.Cmb_Puesto_Ingreso.Location = new System.Drawing.Point(28, 155);
            this.Cmb_Puesto_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Puesto_Ingreso.Name = "Cmb_Puesto_Ingreso";
            this.Cmb_Puesto_Ingreso.Size = new System.Drawing.Size(318, 22);
            this.Cmb_Puesto_Ingreso.TabIndex = 39;
            // 
            // Lbl_TipoPuesto_Ingreso
            // 
            this.Lbl_TipoPuesto_Ingreso.AutoSize = true;
            this.Lbl_TipoPuesto_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_TipoPuesto_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoPuesto_Ingreso.Location = new System.Drawing.Point(25, 137);
            this.Lbl_TipoPuesto_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TipoPuesto_Ingreso.Name = "Lbl_TipoPuesto_Ingreso";
            this.Lbl_TipoPuesto_Ingreso.Size = new System.Drawing.Size(47, 14);
            this.Lbl_TipoPuesto_Ingreso.TabIndex = 23;
            this.Lbl_TipoPuesto_Ingreso.Text = "PUESTO";
            // 
            // Txt_Nombre1_Ingreso
            // 
            this.Txt_Nombre1_Ingreso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre1_Ingreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre1_Ingreso.Location = new System.Drawing.Point(28, 46);
            this.Txt_Nombre1_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre1_Ingreso.Name = "Txt_Nombre1_Ingreso";
            this.Txt_Nombre1_Ingreso.Size = new System.Drawing.Size(318, 15);
            this.Txt_Nombre1_Ingreso.TabIndex = 28;
            // 
            // Lbl_Nombre1_Ingreso
            // 
            this.Lbl_Nombre1_Ingreso.AutoSize = true;
            this.Lbl_Nombre1_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre1_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre1_Ingreso.Location = new System.Drawing.Point(25, 30);
            this.Lbl_Nombre1_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre1_Ingreso.Name = "Lbl_Nombre1_Ingreso";
            this.Lbl_Nombre1_Ingreso.Size = new System.Drawing.Size(95, 14);
            this.Lbl_Nombre1_Ingreso.TabIndex = 33;
            this.Lbl_Nombre1_Ingreso.Text = "PRIMER NOMBRE";
            // 
            // Lbl_Nombre2_Ingreso
            // 
            this.Lbl_Nombre2_Ingreso.AutoSize = true;
            this.Lbl_Nombre2_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre2_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre2_Ingreso.Location = new System.Drawing.Point(392, 30);
            this.Lbl_Nombre2_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre2_Ingreso.Name = "Lbl_Nombre2_Ingreso";
            this.Lbl_Nombre2_Ingreso.Size = new System.Drawing.Size(108, 14);
            this.Lbl_Nombre2_Ingreso.TabIndex = 24;
            this.Lbl_Nombre2_Ingreso.Text = "SEGUNDO NOMBRE";
            // 
            // Lbl_Apellido1_Ingreso
            // 
            this.Lbl_Apellido1_Ingreso.AutoSize = true;
            this.Lbl_Apellido1_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido1_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido1_Ingreso.Location = new System.Drawing.Point(25, 80);
            this.Lbl_Apellido1_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Apellido1_Ingreso.Name = "Lbl_Apellido1_Ingreso";
            this.Lbl_Apellido1_Ingreso.Size = new System.Drawing.Size(97, 14);
            this.Lbl_Apellido1_Ingreso.TabIndex = 25;
            this.Lbl_Apellido1_Ingreso.Text = "PRIMER APELLIDO";
            // 
            // Txt_Apellido2_Ingreso
            // 
            this.Txt_Apellido2_Ingreso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido2_Ingreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido2_Ingreso.Location = new System.Drawing.Point(395, 96);
            this.Txt_Apellido2_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Apellido2_Ingreso.Name = "Txt_Apellido2_Ingreso";
            this.Txt_Apellido2_Ingreso.Size = new System.Drawing.Size(318, 15);
            this.Txt_Apellido2_Ingreso.TabIndex = 31;
            // 
            // Lbl_Apellido2_Ingreso
            // 
            this.Lbl_Apellido2_Ingreso.AutoSize = true;
            this.Lbl_Apellido2_Ingreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido2_Ingreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido2_Ingreso.Location = new System.Drawing.Point(392, 80);
            this.Lbl_Apellido2_Ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Apellido2_Ingreso.Name = "Lbl_Apellido2_Ingreso";
            this.Lbl_Apellido2_Ingreso.Size = new System.Drawing.Size(110, 14);
            this.Lbl_Apellido2_Ingreso.TabIndex = 26;
            this.Lbl_Apellido2_Ingreso.Text = "SEGUNDO APELLIDO";
            // 
            // Txt_Apellido1_Ingreso
            // 
            this.Txt_Apellido1_Ingreso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido1_Ingreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido1_Ingreso.Location = new System.Drawing.Point(28, 96);
            this.Txt_Apellido1_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Apellido1_Ingreso.Name = "Txt_Apellido1_Ingreso";
            this.Txt_Apellido1_Ingreso.Size = new System.Drawing.Size(318, 15);
            this.Txt_Apellido1_Ingreso.TabIndex = 30;
            // 
            // Txt_Nombre2_Ingreso
            // 
            this.Txt_Nombre2_Ingreso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre2_Ingreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre2_Ingreso.Location = new System.Drawing.Point(395, 46);
            this.Txt_Nombre2_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre2_Ingreso.Name = "Txt_Nombre2_Ingreso";
            this.Txt_Nombre2_Ingreso.Size = new System.Drawing.Size(318, 15);
            this.Txt_Nombre2_Ingreso.TabIndex = 29;
            // 
            // Lbl_Titulo2
            // 
            this.Lbl_Titulo2.AutoSize = true;
            this.Lbl_Titulo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Titulo2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo2.Location = new System.Drawing.Point(300, 31);
            this.Lbl_Titulo2.Name = "Lbl_Titulo2";
            this.Lbl_Titulo2.Size = new System.Drawing.Size(185, 14);
            this.Lbl_Titulo2.TabIndex = 27;
            this.Lbl_Titulo2.Text = "Ingrese los siguiente datos";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(322, 351);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(136, 41);
            this.Btn_Eliminar.TabIndex = 32;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Gpb_Datos_Eliminar
            // 
            this.Gpb_Datos_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Departamento_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Puesto_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Sueldo_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Sueldo_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Departamento_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Puesto_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Nombre1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Nombre1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Nombre2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Apellido1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Apellido2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Apellido2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Apellido1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Nombre2_Eliminar);
            this.Gpb_Datos_Eliminar.Enabled = false;
            this.Gpb_Datos_Eliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_Eliminar.Location = new System.Drawing.Point(26, 72);
            this.Gpb_Datos_Eliminar.Name = "Gpb_Datos_Eliminar";
            this.Gpb_Datos_Eliminar.Size = new System.Drawing.Size(744, 246);
            this.Gpb_Datos_Eliminar.TabIndex = 31;
            this.Gpb_Datos_Eliminar.TabStop = false;
            this.Gpb_Datos_Eliminar.Text = "Datos Personales";
            // 
            // Lbl_Sueldo_Eliminar
            // 
            this.Lbl_Sueldo_Eliminar.AutoSize = true;
            this.Lbl_Sueldo_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Sueldo_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sueldo_Eliminar.Location = new System.Drawing.Point(25, 194);
            this.Lbl_Sueldo_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sueldo_Eliminar.Name = "Lbl_Sueldo_Eliminar";
            this.Lbl_Sueldo_Eliminar.Size = new System.Drawing.Size(48, 14);
            this.Lbl_Sueldo_Eliminar.TabIndex = 42;
            this.Lbl_Sueldo_Eliminar.Text = "SUELDO";
            // 
            // Txt_Sueldo_Eliminar
            // 
            this.Txt_Sueldo_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Sueldo_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Sueldo_Eliminar.Location = new System.Drawing.Point(28, 210);
            this.Txt_Sueldo_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Sueldo_Eliminar.Name = "Txt_Sueldo_Eliminar";
            this.Txt_Sueldo_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Sueldo_Eliminar.TabIndex = 43;
            // 
            // Lbl_Departamento_Eliminar
            // 
            this.Lbl_Departamento_Eliminar.AutoSize = true;
            this.Lbl_Departamento_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Departamento_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento_Eliminar.Location = new System.Drawing.Point(392, 137);
            this.Lbl_Departamento_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Departamento_Eliminar.Name = "Lbl_Departamento_Eliminar";
            this.Lbl_Departamento_Eliminar.Size = new System.Drawing.Size(90, 14);
            this.Lbl_Departamento_Eliminar.TabIndex = 40;
            this.Lbl_Departamento_Eliminar.Text = "DEPARTAMENTO";
            // 
            // Lbl_Puesto_Eliminar
            // 
            this.Lbl_Puesto_Eliminar.AutoSize = true;
            this.Lbl_Puesto_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Puesto_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puesto_Eliminar.Location = new System.Drawing.Point(25, 137);
            this.Lbl_Puesto_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Puesto_Eliminar.Name = "Lbl_Puesto_Eliminar";
            this.Lbl_Puesto_Eliminar.Size = new System.Drawing.Size(47, 14);
            this.Lbl_Puesto_Eliminar.TabIndex = 23;
            this.Lbl_Puesto_Eliminar.Text = "PUESTO";
            // 
            // Txt_Nombre1_Eliminar
            // 
            this.Txt_Nombre1_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre1_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre1_Eliminar.Location = new System.Drawing.Point(28, 46);
            this.Txt_Nombre1_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre1_Eliminar.Name = "Txt_Nombre1_Eliminar";
            this.Txt_Nombre1_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Nombre1_Eliminar.TabIndex = 28;
            // 
            // Lbl_Nombre1_Eliminar
            // 
            this.Lbl_Nombre1_Eliminar.AutoSize = true;
            this.Lbl_Nombre1_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre1_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre1_Eliminar.Location = new System.Drawing.Point(25, 30);
            this.Lbl_Nombre1_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre1_Eliminar.Name = "Lbl_Nombre1_Eliminar";
            this.Lbl_Nombre1_Eliminar.Size = new System.Drawing.Size(95, 14);
            this.Lbl_Nombre1_Eliminar.TabIndex = 33;
            this.Lbl_Nombre1_Eliminar.Text = "PRIMER NOMBRE";
            // 
            // Lbl_Nombre2_Eliminar
            // 
            this.Lbl_Nombre2_Eliminar.AutoSize = true;
            this.Lbl_Nombre2_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre2_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre2_Eliminar.Location = new System.Drawing.Point(392, 30);
            this.Lbl_Nombre2_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre2_Eliminar.Name = "Lbl_Nombre2_Eliminar";
            this.Lbl_Nombre2_Eliminar.Size = new System.Drawing.Size(108, 14);
            this.Lbl_Nombre2_Eliminar.TabIndex = 24;
            this.Lbl_Nombre2_Eliminar.Text = "SEGUNDO NOMBRE";
            // 
            // Lbl_Apellido1_Eliminar
            // 
            this.Lbl_Apellido1_Eliminar.AutoSize = true;
            this.Lbl_Apellido1_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido1_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido1_Eliminar.Location = new System.Drawing.Point(25, 80);
            this.Lbl_Apellido1_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Apellido1_Eliminar.Name = "Lbl_Apellido1_Eliminar";
            this.Lbl_Apellido1_Eliminar.Size = new System.Drawing.Size(97, 14);
            this.Lbl_Apellido1_Eliminar.TabIndex = 25;
            this.Lbl_Apellido1_Eliminar.Text = "PRIMER APELLIDO";
            // 
            // Txt_Apellido2_Eliminar
            // 
            this.Txt_Apellido2_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido2_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido2_Eliminar.Location = new System.Drawing.Point(395, 96);
            this.Txt_Apellido2_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Apellido2_Eliminar.Name = "Txt_Apellido2_Eliminar";
            this.Txt_Apellido2_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Apellido2_Eliminar.TabIndex = 31;
            // 
            // Lbl_Apellido2_Eliminar
            // 
            this.Lbl_Apellido2_Eliminar.AutoSize = true;
            this.Lbl_Apellido2_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido2_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido2_Eliminar.Location = new System.Drawing.Point(392, 80);
            this.Lbl_Apellido2_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Apellido2_Eliminar.Name = "Lbl_Apellido2_Eliminar";
            this.Lbl_Apellido2_Eliminar.Size = new System.Drawing.Size(110, 14);
            this.Lbl_Apellido2_Eliminar.TabIndex = 26;
            this.Lbl_Apellido2_Eliminar.Text = "SEGUNDO APELLIDO";
            // 
            // Txt_Apellido1_Eliminar
            // 
            this.Txt_Apellido1_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido1_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido1_Eliminar.Location = new System.Drawing.Point(28, 96);
            this.Txt_Apellido1_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Apellido1_Eliminar.Name = "Txt_Apellido1_Eliminar";
            this.Txt_Apellido1_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Apellido1_Eliminar.TabIndex = 30;
            // 
            // Txt_Nombre2_Eliminar
            // 
            this.Txt_Nombre2_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre2_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre2_Eliminar.Location = new System.Drawing.Point(395, 46);
            this.Txt_Nombre2_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre2_Eliminar.Name = "Txt_Nombre2_Eliminar";
            this.Txt_Nombre2_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Nombre2_Eliminar.TabIndex = 29;
            // 
            // Lbl_Titulo4
            // 
            this.Lbl_Titulo4.AutoSize = true;
            this.Lbl_Titulo4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Titulo4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo4.Location = new System.Drawing.Point(23, 32);
            this.Lbl_Titulo4.Name = "Lbl_Titulo4";
            this.Lbl_Titulo4.Size = new System.Drawing.Size(186, 14);
            this.Lbl_Titulo4.TabIndex = 33;
            this.Lbl_Titulo4.Text = "Ingrese el ID del empleado";
            // 
            // Btn_Busqueda_Eliminar
            // 
            this.Btn_Busqueda_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Busqueda_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Busqueda_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Busqueda_Eliminar.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Busqueda_Eliminar.Location = new System.Drawing.Point(603, 26);
            this.Btn_Busqueda_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Busqueda_Eliminar.Name = "Btn_Busqueda_Eliminar";
            this.Btn_Busqueda_Eliminar.Size = new System.Drawing.Size(136, 26);
            this.Btn_Busqueda_Eliminar.TabIndex = 35;
            this.Btn_Busqueda_Eliminar.Text = "BUSCAR";
            this.Btn_Busqueda_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Txt_Busqueda_Eliminar
            // 
            this.Txt_Busqueda_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Busqueda_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Busqueda_Eliminar.Location = new System.Drawing.Point(229, 33);
            this.Txt_Busqueda_Eliminar.Name = "Txt_Busqueda_Eliminar";
            this.Txt_Busqueda_Eliminar.Size = new System.Drawing.Size(313, 13);
            this.Txt_Busqueda_Eliminar.TabIndex = 34;
            // 
            // Txt_Puesto_Eliminar
            // 
            this.Txt_Puesto_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Puesto_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Puesto_Eliminar.Location = new System.Drawing.Point(28, 153);
            this.Txt_Puesto_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Puesto_Eliminar.Name = "Txt_Puesto_Eliminar";
            this.Txt_Puesto_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Puesto_Eliminar.TabIndex = 44;
            // 
            // Txt_Departamento_Eliminar
            // 
            this.Txt_Departamento_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Departamento_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Departamento_Eliminar.Location = new System.Drawing.Point(395, 153);
            this.Txt_Departamento_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Departamento_Eliminar.Name = "Txt_Departamento_Eliminar";
            this.Txt_Departamento_Eliminar.Size = new System.Drawing.Size(318, 15);
            this.Txt_Departamento_Eliminar.TabIndex = 45;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Mantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimiento";
            this.Tbc_Mantenimientos.ResumeLayout(false);
            this.Tbp_Ingreso.ResumeLayout(false);
            this.Tbp_Ingreso.PerformLayout();
            this.Tbp_Eliminar.ResumeLayout(false);
            this.Tbp_Eliminar.PerformLayout();
            this.Gpb_Datos_Ingreso.ResumeLayout(false);
            this.Gpb_Datos_Ingreso.PerformLayout();
            this.Gpb_Datos_Eliminar.ResumeLayout(false);
            this.Gpb_Datos_Eliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Mantenimientos;
        private System.Windows.Forms.TabPage Tbp_Ingreso;
        private System.Windows.Forms.Button Btn_Ingreso;
        private System.Windows.Forms.GroupBox Gpb_Datos_Ingreso;
        private System.Windows.Forms.Label Lbl_Sueldo_Ingreso;
        private System.Windows.Forms.TextBox Txt_Sueldo_Ingreso;
        private System.Windows.Forms.ComboBox Cmb_Departamento_Ingreso;
        private System.Windows.Forms.Label Lbl_Departamento_Ingreso;
        private System.Windows.Forms.ComboBox Cmb_Puesto_Ingreso;
        private System.Windows.Forms.Label Lbl_TipoPuesto_Ingreso;
        private System.Windows.Forms.TextBox Txt_Nombre1_Ingreso;
        private System.Windows.Forms.Label Lbl_Nombre1_Ingreso;
        private System.Windows.Forms.Label Lbl_Nombre2_Ingreso;
        private System.Windows.Forms.Label Lbl_Apellido1_Ingreso;
        private System.Windows.Forms.TextBox Txt_Apellido2_Ingreso;
        private System.Windows.Forms.Label Lbl_Apellido2_Ingreso;
        private System.Windows.Forms.TextBox Txt_Apellido1_Ingreso;
        private System.Windows.Forms.TextBox Txt_Nombre2_Ingreso;
        private System.Windows.Forms.Label Lbl_Titulo2;
        private System.Windows.Forms.TabPage Tbp_Eliminar;
        private System.Windows.Forms.Button Btn_Busqueda_Eliminar;
        private System.Windows.Forms.TextBox Txt_Busqueda_Eliminar;
        private System.Windows.Forms.Label Lbl_Titulo4;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.GroupBox Gpb_Datos_Eliminar;
        private System.Windows.Forms.Label Lbl_Sueldo_Eliminar;
        private System.Windows.Forms.TextBox Txt_Sueldo_Eliminar;
        private System.Windows.Forms.Label Lbl_Departamento_Eliminar;
        private System.Windows.Forms.Label Lbl_Puesto_Eliminar;
        private System.Windows.Forms.TextBox Txt_Nombre1_Eliminar;
        private System.Windows.Forms.Label Lbl_Nombre1_Eliminar;
        private System.Windows.Forms.Label Lbl_Nombre2_Eliminar;
        private System.Windows.Forms.Label Lbl_Apellido1_Eliminar;
        private System.Windows.Forms.TextBox Txt_Apellido2_Eliminar;
        private System.Windows.Forms.Label Lbl_Apellido2_Eliminar;
        private System.Windows.Forms.TextBox Txt_Apellido1_Eliminar;
        private System.Windows.Forms.TextBox Txt_Nombre2_Eliminar;
        private System.Windows.Forms.TextBox Txt_Departamento_Eliminar;
        private System.Windows.Forms.TextBox Txt_Puesto_Eliminar;
    }
}