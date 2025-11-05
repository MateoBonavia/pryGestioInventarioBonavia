namespace pryGestioInventarioBonavia
{
    partial class frmMain
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
            this.mtbMain = new MetroFramework.Controls.MetroTabControl();
            this.mtbGestion = new MetroFramework.Controls.MetroTabPage();
            this.txtCodigo_gestion = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo_gestion = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar_gestion = new MetroFramework.Controls.MetroButton();
            this.btnModificar_gestion = new MetroFramework.Controls.MetroButton();
            this.btnAgregar_gestion = new MetroFramework.Controls.MetroButton();
            this.txtDesc_gestion = new MetroFramework.Controls.MetroTextBox();
            this.txtStock_gestion = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio_gestion = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre_gestion = new MetroFramework.Controls.MetroTextBox();
            this.cboCat_gestion = new MetroFramework.Controls.MetroComboBox();
            this.lblDesc_gestion = new MetroFramework.Controls.MetroLabel();
            this.lblStock_gestion = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio_gestion = new MetroFramework.Controls.MetroLabel();
            this.lblNombre_gestion = new MetroFramework.Controls.MetroLabel();
            this.lblCat_gestion = new MetroFramework.Controls.MetroLabel();
            this.gpbBuscar_gestion = new System.Windows.Forms.GroupBox();
            this.btnBuscar_gestion = new MetroFramework.Controls.MetroButton();
            this.txtBuscar_gestion = new MetroFramework.Controls.MetroTextBox();
            this.lblBuscarPor_gestion = new MetroFramework.Controls.MetroLabel();
            this.rdbNombre_gestion = new MetroFramework.Controls.MetroRadioButton();
            this.rdbCodigo_gestion = new MetroFramework.Controls.MetroRadioButton();
            this.mtbBuscarCategoria = new MetroFramework.Controls.MetroTabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBuscar_buscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar_buscar = new MetroFramework.Controls.MetroButton();
            this.txtBuscar_buscar = new MetroFramework.Controls.MetroTextBox();
            this.mtbInforme = new MetroFramework.Controls.MetroTabPage();
            this.lblBuscar_buscar = new MetroFramework.Controls.MetroLabel();
            this.mtbMain.SuspendLayout();
            this.mtbGestion.SuspendLayout();
            this.gpbBuscar_gestion.SuspendLayout();
            this.mtbBuscarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpbBuscar_buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbMain
            // 
            this.mtbMain.Controls.Add(this.mtbGestion);
            this.mtbMain.Controls.Add(this.mtbBuscarCategoria);
            this.mtbMain.Controls.Add(this.mtbInforme);
            this.mtbMain.Location = new System.Drawing.Point(12, 12);
            this.mtbMain.Name = "mtbMain";
            this.mtbMain.SelectedIndex = 1;
            this.mtbMain.Size = new System.Drawing.Size(677, 373);
            this.mtbMain.TabIndex = 0;
            this.mtbMain.UseSelectable = true;
            // 
            // mtbGestion
            // 
            this.mtbGestion.Controls.Add(this.txtCodigo_gestion);
            this.mtbGestion.Controls.Add(this.lblCodigo_gestion);
            this.mtbGestion.Controls.Add(this.btnEliminar_gestion);
            this.mtbGestion.Controls.Add(this.btnModificar_gestion);
            this.mtbGestion.Controls.Add(this.btnAgregar_gestion);
            this.mtbGestion.Controls.Add(this.txtDesc_gestion);
            this.mtbGestion.Controls.Add(this.txtStock_gestion);
            this.mtbGestion.Controls.Add(this.txtPrecio_gestion);
            this.mtbGestion.Controls.Add(this.txtNombre_gestion);
            this.mtbGestion.Controls.Add(this.cboCat_gestion);
            this.mtbGestion.Controls.Add(this.lblDesc_gestion);
            this.mtbGestion.Controls.Add(this.lblStock_gestion);
            this.mtbGestion.Controls.Add(this.lblPrecio_gestion);
            this.mtbGestion.Controls.Add(this.lblNombre_gestion);
            this.mtbGestion.Controls.Add(this.lblCat_gestion);
            this.mtbGestion.Controls.Add(this.gpbBuscar_gestion);
            this.mtbGestion.HorizontalScrollbarBarColor = true;
            this.mtbGestion.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbGestion.HorizontalScrollbarSize = 3;
            this.mtbGestion.Location = new System.Drawing.Point(4, 38);
            this.mtbGestion.Name = "mtbGestion";
            this.mtbGestion.Size = new System.Drawing.Size(669, 323);
            this.mtbGestion.TabIndex = 0;
            this.mtbGestion.Text = "Gestión de Producto";
            this.mtbGestion.VerticalScrollbarBarColor = true;
            this.mtbGestion.VerticalScrollbarHighlightOnWheel = false;
            this.mtbGestion.VerticalScrollbarSize = 4;
            // 
            // txtCodigo_gestion
            // 
            // 
            // 
            // 
            this.txtCodigo_gestion.CustomButton.Image = null;
            this.txtCodigo_gestion.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtCodigo_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtCodigo_gestion.CustomButton.Name = "";
            this.txtCodigo_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCodigo_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo_gestion.CustomButton.TabIndex = 1;
            this.txtCodigo_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo_gestion.CustomButton.UseSelectable = true;
            this.txtCodigo_gestion.CustomButton.Visible = false;
            this.txtCodigo_gestion.Lines = new string[0];
            this.txtCodigo_gestion.Location = new System.Drawing.Point(361, 88);
            this.txtCodigo_gestion.MaxLength = 32767;
            this.txtCodigo_gestion.Name = "txtCodigo_gestion";
            this.txtCodigo_gestion.PasswordChar = '\0';
            this.txtCodigo_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo_gestion.SelectedText = "";
            this.txtCodigo_gestion.SelectionLength = 0;
            this.txtCodigo_gestion.SelectionStart = 0;
            this.txtCodigo_gestion.ShortcutsEnabled = true;
            this.txtCodigo_gestion.Size = new System.Drawing.Size(287, 23);
            this.txtCodigo_gestion.TabIndex = 10;
            this.txtCodigo_gestion.UseSelectable = true;
            this.txtCodigo_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo_gestion.TextChanged += new System.EventHandler(this.txtCodigo_gestion_TextChanged);
            // 
            // lblCodigo_gestion
            // 
            this.lblCodigo_gestion.AutoSize = true;
            this.lblCodigo_gestion.Location = new System.Drawing.Point(268, 89);
            this.lblCodigo_gestion.Name = "lblCodigo_gestion";
            this.lblCodigo_gestion.Size = new System.Drawing.Size(53, 20);
            this.lblCodigo_gestion.TabIndex = 11;
            this.lblCodigo_gestion.Text = "Código";
            // 
            // btnEliminar_gestion
            // 
            this.btnEliminar_gestion.Location = new System.Drawing.Point(91, 226);
            this.btnEliminar_gestion.Name = "btnEliminar_gestion";
            this.btnEliminar_gestion.Size = new System.Drawing.Size(96, 31);
            this.btnEliminar_gestion.TabIndex = 18;
            this.btnEliminar_gestion.Text = "Eliminar";
            this.btnEliminar_gestion.UseSelectable = true;
            this.btnEliminar_gestion.Click += new System.EventHandler(this.btnEliminar_gestion_Click);
            // 
            // btnModificar_gestion
            // 
            this.btnModificar_gestion.Location = new System.Drawing.Point(91, 165);
            this.btnModificar_gestion.Name = "btnModificar_gestion";
            this.btnModificar_gestion.Size = new System.Drawing.Size(96, 31);
            this.btnModificar_gestion.TabIndex = 17;
            this.btnModificar_gestion.Text = "Modificar";
            this.btnModificar_gestion.UseSelectable = true;
            this.btnModificar_gestion.Click += new System.EventHandler(this.btnModificar_gestion_Click);
            // 
            // btnAgregar_gestion
            // 
            this.btnAgregar_gestion.Location = new System.Drawing.Point(91, 104);
            this.btnAgregar_gestion.Name = "btnAgregar_gestion";
            this.btnAgregar_gestion.Size = new System.Drawing.Size(96, 31);
            this.btnAgregar_gestion.TabIndex = 8;
            this.btnAgregar_gestion.Text = "Agregar";
            this.btnAgregar_gestion.UseSelectable = true;
            this.btnAgregar_gestion.Click += new System.EventHandler(this.btnAgregar_gestion_Click);
            // 
            // txtDesc_gestion
            // 
            // 
            // 
            // 
            this.txtDesc_gestion.CustomButton.Image = null;
            this.txtDesc_gestion.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtDesc_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtDesc_gestion.CustomButton.Name = "";
            this.txtDesc_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDesc_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc_gestion.CustomButton.TabIndex = 1;
            this.txtDesc_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc_gestion.CustomButton.UseSelectable = true;
            this.txtDesc_gestion.CustomButton.Visible = false;
            this.txtDesc_gestion.Lines = new string[0];
            this.txtDesc_gestion.Location = new System.Drawing.Point(361, 255);
            this.txtDesc_gestion.MaxLength = 32767;
            this.txtDesc_gestion.Name = "txtDesc_gestion";
            this.txtDesc_gestion.PasswordChar = '\0';
            this.txtDesc_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc_gestion.SelectedText = "";
            this.txtDesc_gestion.SelectionLength = 0;
            this.txtDesc_gestion.SelectionStart = 0;
            this.txtDesc_gestion.ShortcutsEnabled = true;
            this.txtDesc_gestion.Size = new System.Drawing.Size(287, 23);
            this.txtDesc_gestion.TabIndex = 16;
            this.txtDesc_gestion.UseSelectable = true;
            this.txtDesc_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc_gestion.TextChanged += new System.EventHandler(this.txtDesc_gestion_TextChanged);
            // 
            // txtStock_gestion
            // 
            // 
            // 
            // 
            this.txtStock_gestion.CustomButton.Image = null;
            this.txtStock_gestion.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtStock_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtStock_gestion.CustomButton.Name = "";
            this.txtStock_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtStock_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock_gestion.CustomButton.TabIndex = 1;
            this.txtStock_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock_gestion.CustomButton.UseSelectable = true;
            this.txtStock_gestion.CustomButton.Visible = false;
            this.txtStock_gestion.Lines = new string[0];
            this.txtStock_gestion.Location = new System.Drawing.Point(531, 212);
            this.txtStock_gestion.MaxLength = 32767;
            this.txtStock_gestion.Name = "txtStock_gestion";
            this.txtStock_gestion.PasswordChar = '\0';
            this.txtStock_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock_gestion.SelectedText = "";
            this.txtStock_gestion.SelectionLength = 0;
            this.txtStock_gestion.SelectionStart = 0;
            this.txtStock_gestion.ShortcutsEnabled = true;
            this.txtStock_gestion.Size = new System.Drawing.Size(117, 23);
            this.txtStock_gestion.TabIndex = 15;
            this.txtStock_gestion.UseSelectable = true;
            this.txtStock_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStock_gestion.TextChanged += new System.EventHandler(this.txtStock_gestion_TextChanged);
            // 
            // txtPrecio_gestion
            // 
            // 
            // 
            // 
            this.txtPrecio_gestion.CustomButton.Image = null;
            this.txtPrecio_gestion.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtPrecio_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtPrecio_gestion.CustomButton.Name = "";
            this.txtPrecio_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPrecio_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio_gestion.CustomButton.TabIndex = 1;
            this.txtPrecio_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio_gestion.CustomButton.UseSelectable = true;
            this.txtPrecio_gestion.CustomButton.Visible = false;
            this.txtPrecio_gestion.Lines = new string[0];
            this.txtPrecio_gestion.Location = new System.Drawing.Point(361, 212);
            this.txtPrecio_gestion.MaxLength = 32767;
            this.txtPrecio_gestion.Name = "txtPrecio_gestion";
            this.txtPrecio_gestion.PasswordChar = '\0';
            this.txtPrecio_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio_gestion.SelectedText = "";
            this.txtPrecio_gestion.SelectionLength = 0;
            this.txtPrecio_gestion.SelectionStart = 0;
            this.txtPrecio_gestion.ShortcutsEnabled = true;
            this.txtPrecio_gestion.Size = new System.Drawing.Size(117, 23);
            this.txtPrecio_gestion.TabIndex = 14;
            this.txtPrecio_gestion.UseSelectable = true;
            this.txtPrecio_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio_gestion.TextChanged += new System.EventHandler(this.txtPrecio_gestion_TextChanged);
            // 
            // txtNombre_gestion
            // 
            // 
            // 
            // 
            this.txtNombre_gestion.CustomButton.Image = null;
            this.txtNombre_gestion.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtNombre_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombre_gestion.CustomButton.Name = "";
            this.txtNombre_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNombre_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre_gestion.CustomButton.TabIndex = 1;
            this.txtNombre_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre_gestion.CustomButton.UseSelectable = true;
            this.txtNombre_gestion.CustomButton.Visible = false;
            this.txtNombre_gestion.Lines = new string[0];
            this.txtNombre_gestion.Location = new System.Drawing.Point(361, 173);
            this.txtNombre_gestion.MaxLength = 32767;
            this.txtNombre_gestion.Name = "txtNombre_gestion";
            this.txtNombre_gestion.PasswordChar = '\0';
            this.txtNombre_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre_gestion.SelectedText = "";
            this.txtNombre_gestion.SelectionLength = 0;
            this.txtNombre_gestion.SelectionStart = 0;
            this.txtNombre_gestion.ShortcutsEnabled = true;
            this.txtNombre_gestion.Size = new System.Drawing.Size(287, 23);
            this.txtNombre_gestion.TabIndex = 8;
            this.txtNombre_gestion.UseSelectable = true;
            this.txtNombre_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre_gestion.TextChanged += new System.EventHandler(this.txtNombre_gestion_TextChanged);
            // 
            // cboCat_gestion
            // 
            this.cboCat_gestion.FormattingEnabled = true;
            this.cboCat_gestion.ItemHeight = 24;
            this.cboCat_gestion.Location = new System.Drawing.Point(361, 125);
            this.cboCat_gestion.Name = "cboCat_gestion";
            this.cboCat_gestion.Size = new System.Drawing.Size(287, 30);
            this.cboCat_gestion.TabIndex = 13;
            this.cboCat_gestion.UseSelectable = true;
            this.cboCat_gestion.TextChanged += new System.EventHandler(this.cboCat_gestion_TextChanged);
            // 
            // lblDesc_gestion
            // 
            this.lblDesc_gestion.AutoSize = true;
            this.lblDesc_gestion.Location = new System.Drawing.Point(268, 259);
            this.lblDesc_gestion.Name = "lblDesc_gestion";
            this.lblDesc_gestion.Size = new System.Drawing.Size(82, 20);
            this.lblDesc_gestion.TabIndex = 12;
            this.lblDesc_gestion.Text = "Descripción";
            // 
            // lblStock_gestion
            // 
            this.lblStock_gestion.AutoSize = true;
            this.lblStock_gestion.Location = new System.Drawing.Point(484, 214);
            this.lblStock_gestion.Name = "lblStock_gestion";
            this.lblStock_gestion.Size = new System.Drawing.Size(42, 20);
            this.lblStock_gestion.TabIndex = 11;
            this.lblStock_gestion.Text = "Stock";
            // 
            // lblPrecio_gestion
            // 
            this.lblPrecio_gestion.AutoSize = true;
            this.lblPrecio_gestion.Location = new System.Drawing.Point(268, 214);
            this.lblPrecio_gestion.Name = "lblPrecio_gestion";
            this.lblPrecio_gestion.Size = new System.Drawing.Size(48, 20);
            this.lblPrecio_gestion.TabIndex = 10;
            this.lblPrecio_gestion.Text = "Precio";
            // 
            // lblNombre_gestion
            // 
            this.lblNombre_gestion.AutoSize = true;
            this.lblNombre_gestion.Location = new System.Drawing.Point(268, 174);
            this.lblNombre_gestion.Name = "lblNombre_gestion";
            this.lblNombre_gestion.Size = new System.Drawing.Size(61, 20);
            this.lblNombre_gestion.TabIndex = 9;
            this.lblNombre_gestion.Text = "Nombre";
            // 
            // lblCat_gestion
            // 
            this.lblCat_gestion.AutoSize = true;
            this.lblCat_gestion.Location = new System.Drawing.Point(268, 132);
            this.lblCat_gestion.Name = "lblCat_gestion";
            this.lblCat_gestion.Size = new System.Drawing.Size(74, 20);
            this.lblCat_gestion.TabIndex = 8;
            this.lblCat_gestion.Text = "Categorias";
            // 
            // gpbBuscar_gestion
            // 
            this.gpbBuscar_gestion.BackColor = System.Drawing.Color.Transparent;
            this.gpbBuscar_gestion.Controls.Add(this.btnBuscar_gestion);
            this.gpbBuscar_gestion.Controls.Add(this.txtBuscar_gestion);
            this.gpbBuscar_gestion.Controls.Add(this.lblBuscarPor_gestion);
            this.gpbBuscar_gestion.Controls.Add(this.rdbNombre_gestion);
            this.gpbBuscar_gestion.Controls.Add(this.rdbCodigo_gestion);
            this.gpbBuscar_gestion.Location = new System.Drawing.Point(3, 3);
            this.gpbBuscar_gestion.Name = "gpbBuscar_gestion";
            this.gpbBuscar_gestion.Size = new System.Drawing.Size(645, 60);
            this.gpbBuscar_gestion.TabIndex = 2;
            this.gpbBuscar_gestion.TabStop = false;
            this.gpbBuscar_gestion.Text = "Buscar";
            // 
            // btnBuscar_gestion
            // 
            this.btnBuscar_gestion.Location = new System.Drawing.Point(547, 22);
            this.btnBuscar_gestion.Name = "btnBuscar_gestion";
            this.btnBuscar_gestion.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar_gestion.TabIndex = 7;
            this.btnBuscar_gestion.Text = "Buscar";
            this.btnBuscar_gestion.UseSelectable = true;
            this.btnBuscar_gestion.Click += new System.EventHandler(this.btnBuscar_gestion_Click);
            // 
            // txtBuscar_gestion
            // 
            // 
            // 
            // 
            this.txtBuscar_gestion.CustomButton.Image = null;
            this.txtBuscar_gestion.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtBuscar_gestion.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtBuscar_gestion.CustomButton.Name = "";
            this.txtBuscar_gestion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBuscar_gestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar_gestion.CustomButton.TabIndex = 1;
            this.txtBuscar_gestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar_gestion.CustomButton.UseSelectable = true;
            this.txtBuscar_gestion.CustomButton.Visible = false;
            this.txtBuscar_gestion.Lines = new string[0];
            this.txtBuscar_gestion.Location = new System.Drawing.Point(358, 22);
            this.txtBuscar_gestion.MaxLength = 32767;
            this.txtBuscar_gestion.Name = "txtBuscar_gestion";
            this.txtBuscar_gestion.PasswordChar = '\0';
            this.txtBuscar_gestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar_gestion.SelectedText = "";
            this.txtBuscar_gestion.SelectionLength = 0;
            this.txtBuscar_gestion.SelectionStart = 0;
            this.txtBuscar_gestion.ShortcutsEnabled = true;
            this.txtBuscar_gestion.Size = new System.Drawing.Size(169, 23);
            this.txtBuscar_gestion.TabIndex = 6;
            this.txtBuscar_gestion.UseSelectable = true;
            this.txtBuscar_gestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar_gestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBuscarPor_gestion
            // 
            this.lblBuscarPor_gestion.AutoSize = true;
            this.lblBuscarPor_gestion.Location = new System.Drawing.Point(6, 22);
            this.lblBuscarPor_gestion.Name = "lblBuscarPor_gestion";
            this.lblBuscarPor_gestion.Size = new System.Drawing.Size(79, 20);
            this.lblBuscarPor_gestion.TabIndex = 5;
            this.lblBuscarPor_gestion.Text = "Buscar por:";
            // 
            // rdbNombre_gestion
            // 
            this.rdbNombre_gestion.AutoSize = true;
            this.rdbNombre_gestion.Location = new System.Drawing.Point(166, 25);
            this.rdbNombre_gestion.Name = "rdbNombre_gestion";
            this.rdbNombre_gestion.Size = new System.Drawing.Size(73, 17);
            this.rdbNombre_gestion.TabIndex = 3;
            this.rdbNombre_gestion.Text = "Nombre";
            this.rdbNombre_gestion.UseSelectable = true;
            // 
            // rdbCodigo_gestion
            // 
            this.rdbCodigo_gestion.AutoSize = true;
            this.rdbCodigo_gestion.Location = new System.Drawing.Point(88, 25);
            this.rdbCodigo_gestion.Name = "rdbCodigo_gestion";
            this.rdbCodigo_gestion.Size = new System.Drawing.Size(67, 17);
            this.rdbCodigo_gestion.TabIndex = 2;
            this.rdbCodigo_gestion.Text = "Código";
            this.rdbCodigo_gestion.UseSelectable = true;
            // 
            // mtbBuscarCategoria
            // 
            this.mtbBuscarCategoria.Controls.Add(this.dgvData);
            this.mtbBuscarCategoria.Controls.Add(this.gpbBuscar_buscar);
            this.mtbBuscarCategoria.HorizontalScrollbarBarColor = true;
            this.mtbBuscarCategoria.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbBuscarCategoria.HorizontalScrollbarSize = 3;
            this.mtbBuscarCategoria.Location = new System.Drawing.Point(4, 38);
            this.mtbBuscarCategoria.Name = "mtbBuscarCategoria";
            this.mtbBuscarCategoria.Size = new System.Drawing.Size(669, 331);
            this.mtbBuscarCategoria.TabIndex = 1;
            this.mtbBuscarCategoria.Text = "Buscar por categoria";
            this.mtbBuscarCategoria.VerticalScrollbarBarColor = true;
            this.mtbBuscarCategoria.VerticalScrollbarHighlightOnWheel = false;
            this.mtbBuscarCategoria.VerticalScrollbarSize = 4;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cat,
            this.precio,
            this.stock,
            this.desc});
            this.dgvData.Location = new System.Drawing.Point(9, 69);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(647, 251);
            this.dgvData.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // cat
            // 
            this.cat.HeaderText = "Categoría";
            this.cat.MinimumWidth = 6;
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            this.cat.Width = 120;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 75;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 55;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 150;
            // 
            // gpbBuscar_buscar
            // 
            this.gpbBuscar_buscar.BackColor = System.Drawing.Color.Transparent;
            this.gpbBuscar_buscar.Controls.Add(this.btnBuscar_buscar);
            this.gpbBuscar_buscar.Controls.Add(this.txtBuscar_buscar);
            this.gpbBuscar_buscar.Controls.Add(this.lblBuscar_buscar);
            this.gpbBuscar_buscar.Location = new System.Drawing.Point(3, 3);
            this.gpbBuscar_buscar.Name = "gpbBuscar_buscar";
            this.gpbBuscar_buscar.Size = new System.Drawing.Size(653, 60);
            this.gpbBuscar_buscar.TabIndex = 3;
            this.gpbBuscar_buscar.TabStop = false;
            this.gpbBuscar_buscar.Text = "Buscar";
            // 
            // btnBuscar_buscar
            // 
            this.btnBuscar_buscar.Location = new System.Drawing.Point(272, 25);
            this.btnBuscar_buscar.Name = "btnBuscar_buscar";
            this.btnBuscar_buscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar_buscar.TabIndex = 7;
            this.btnBuscar_buscar.Text = "Buscar";
            this.btnBuscar_buscar.UseSelectable = true;
            this.btnBuscar_buscar.Click += new System.EventHandler(this.btnBuscar_buscar_Click);
            // 
            // txtBuscar_buscar
            // 
            // 
            // 
            // 
            this.txtBuscar_buscar.CustomButton.Image = null;
            this.txtBuscar_buscar.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtBuscar_buscar.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtBuscar_buscar.CustomButton.Name = "";
            this.txtBuscar_buscar.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBuscar_buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar_buscar.CustomButton.TabIndex = 1;
            this.txtBuscar_buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar_buscar.CustomButton.UseSelectable = true;
            this.txtBuscar_buscar.CustomButton.Visible = false;
            this.txtBuscar_buscar.Lines = new string[0];
            this.txtBuscar_buscar.Location = new System.Drawing.Point(83, 25);
            this.txtBuscar_buscar.MaxLength = 32767;
            this.txtBuscar_buscar.Name = "txtBuscar_buscar";
            this.txtBuscar_buscar.PasswordChar = '\0';
            this.txtBuscar_buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar_buscar.SelectedText = "";
            this.txtBuscar_buscar.SelectionLength = 0;
            this.txtBuscar_buscar.SelectionStart = 0;
            this.txtBuscar_buscar.ShortcutsEnabled = true;
            this.txtBuscar_buscar.Size = new System.Drawing.Size(169, 23);
            this.txtBuscar_buscar.TabIndex = 6;
            this.txtBuscar_buscar.UseSelectable = true;
            this.txtBuscar_buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar_buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbInforme
            // 
            this.mtbInforme.HorizontalScrollbarBarColor = true;
            this.mtbInforme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbInforme.HorizontalScrollbarSize = 3;
            this.mtbInforme.Location = new System.Drawing.Point(4, 38);
            this.mtbInforme.Name = "mtbInforme";
            this.mtbInforme.Size = new System.Drawing.Size(655, 323);
            this.mtbInforme.TabIndex = 2;
            this.mtbInforme.Text = "Informe";
            this.mtbInforme.VerticalScrollbarBarColor = true;
            this.mtbInforme.VerticalScrollbarHighlightOnWheel = false;
            this.mtbInforme.VerticalScrollbarSize = 4;
            // 
            // lblBuscar_buscar
            // 
            this.lblBuscar_buscar.AutoSize = true;
            this.lblBuscar_buscar.Location = new System.Drawing.Point(6, 25);
            this.lblBuscar_buscar.Name = "lblBuscar_buscar";
            this.lblBuscar_buscar.Size = new System.Drawing.Size(71, 20);
            this.lblBuscar_buscar.TabIndex = 5;
            this.lblBuscar_buscar.Text = "Categoría:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 395);
            this.Controls.Add(this.mtbMain);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mtbMain.ResumeLayout(false);
            this.mtbGestion.ResumeLayout(false);
            this.mtbGestion.PerformLayout();
            this.gpbBuscar_gestion.ResumeLayout(false);
            this.gpbBuscar_gestion.PerformLayout();
            this.mtbBuscarCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpbBuscar_buscar.ResumeLayout(false);
            this.gpbBuscar_buscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtbMain;
        private MetroFramework.Controls.MetroTabPage mtbGestion;
        private MetroFramework.Controls.MetroTabPage mtbBuscarCategoria;
        private MetroFramework.Controls.MetroTabPage mtbInforme;
        private System.Windows.Forms.GroupBox gpbBuscar_gestion;
        private MetroFramework.Controls.MetroTextBox txtBuscar_gestion;
        private MetroFramework.Controls.MetroLabel lblBuscarPor_gestion;
        private MetroFramework.Controls.MetroRadioButton rdbNombre_gestion;
        private MetroFramework.Controls.MetroRadioButton rdbCodigo_gestion;
        private MetroFramework.Controls.MetroButton btnBuscar_gestion;
        private MetroFramework.Controls.MetroLabel lblDesc_gestion;
        private MetroFramework.Controls.MetroLabel lblStock_gestion;
        private MetroFramework.Controls.MetroLabel lblPrecio_gestion;
        private MetroFramework.Controls.MetroLabel lblNombre_gestion;
        private MetroFramework.Controls.MetroLabel lblCat_gestion;
        private MetroFramework.Controls.MetroButton btnEliminar_gestion;
        private MetroFramework.Controls.MetroButton btnModificar_gestion;
        private MetroFramework.Controls.MetroButton btnAgregar_gestion;
        private MetroFramework.Controls.MetroTextBox txtDesc_gestion;
        private MetroFramework.Controls.MetroTextBox txtStock_gestion;
        private MetroFramework.Controls.MetroTextBox txtPrecio_gestion;
        private MetroFramework.Controls.MetroTextBox txtNombre_gestion;
        private MetroFramework.Controls.MetroComboBox cboCat_gestion;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox gpbBuscar_buscar;
        private MetroFramework.Controls.MetroButton btnBuscar_buscar;
        private MetroFramework.Controls.MetroTextBox txtBuscar_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private MetroFramework.Controls.MetroTextBox txtCodigo_gestion;
        private MetroFramework.Controls.MetroLabel lblCodigo_gestion;
        private MetroFramework.Controls.MetroLabel lblBuscar_buscar;
    }
}