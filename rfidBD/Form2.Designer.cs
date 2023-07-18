
namespace rfidBD
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbAcceso = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txt_uid1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tabla_form2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.UID_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cb_Puertos = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_conectar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonverificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Regresar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_form2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Puertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(533, 318);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM10";
            this.serialPort1.RtsEnable = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 179);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 13);
            this.lbNombre.TabIndex = 39;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(12, 201);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 13);
            this.lbFecha.TabIndex = 40;
            // 
            // lbAcceso
            // 
            this.lbAcceso.AutoSize = true;
            this.lbAcceso.Location = new System.Drawing.Point(12, 224);
            this.lbAcceso.Name = "lbAcceso";
            this.lbAcceso.Size = new System.Drawing.Size(0, 13);
            this.lbAcceso.TabIndex = 41;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(12, 249);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(0, 13);
            this.lbTelefono.TabIndex = 42;
            // 
            // txt_uid1
            // 
            this.txt_uid1.AllowDrop = true;
            this.txt_uid1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txt_uid1.Location = new System.Drawing.Point(596, 185);
            this.txt_uid1.Name = "txt_uid1";
            this.txt_uid1.Size = new System.Drawing.Size(202, 33);
            this.txt_uid1.StateActive.Back.Color1 = System.Drawing.Color.DimGray;
            this.txt_uid1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_uid1.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_uid1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid1.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.txt_uid1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_uid1.StateCommon.Border.Rounding = 20;
            this.txt_uid1.StateCommon.Border.Width = 1;
            this.txt_uid1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_uid1.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_uid1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.txt_uid1.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_uid1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid1.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.txt_uid1.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txt_uid1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid1.StateNormal.Content.Color1 = System.Drawing.Color.Firebrick;
            this.txt_uid1.TabIndex = 71;
            this.txt_uid1.TextChanged += new System.EventHandler(this.txt_uid1_TextChanged);
            // 
            // tabla_form2
            // 
            this.tabla_form2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_form2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID_1,
            this.NOMBRE_1,
            this.FECHA_1,
            this.NIVEL_1,
            this.TELEFONO});
            this.tabla_form2.Location = new System.Drawing.Point(95, 425);
            this.tabla_form2.Name = "tabla_form2";
            this.tabla_form2.RowHeadersWidth = 50;
            this.tabla_form2.Size = new System.Drawing.Size(681, 62);
            this.tabla_form2.StateCommon.Background.Color1 = System.Drawing.Color.DimGray;
            this.tabla_form2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.tabla_form2.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DimGray;
            this.tabla_form2.StateCommon.DataCell.Back.ColorAngle = 1F;
            this.tabla_form2.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabla_form2.StateCommon.DataCell.Border.Rounding = 5;
            this.tabla_form2.StateCommon.DataCell.Border.Width = 1;
            this.tabla_form2.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.tabla_form2.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_form2.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.tabla_form2.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.tabla_form2.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.tabla_form2.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabla_form2.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.tabla_form2.StateCommon.HeaderColumn.Border.Width = 1;
            this.tabla_form2.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.DimGray;
            this.tabla_form2.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.DimGray;
            this.tabla_form2.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.tabla_form2.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.Transparent;
            this.tabla_form2.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabla_form2.StateCommon.HeaderRow.Border.Rounding = 5;
            this.tabla_form2.StateCommon.HeaderRow.Border.Width = 1;
            this.tabla_form2.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tabla_form2.StateNormal.DataCell.Border.Rounding = 5;
            this.tabla_form2.StateNormal.DataCell.Border.Width = 1;
            this.tabla_form2.TabIndex = 72;
            // 
            // UID_1
            // 
            this.UID_1.HeaderText = "UID";
            this.UID_1.MinimumWidth = 6;
            this.UID_1.Name = "UID_1";
            this.UID_1.Width = 125;
            // 
            // NOMBRE_1
            // 
            this.NOMBRE_1.HeaderText = "NAME";
            this.NOMBRE_1.MinimumWidth = 6;
            this.NOMBRE_1.Name = "NOMBRE_1";
            this.NOMBRE_1.Width = 125;
            // 
            // FECHA_1
            // 
            this.FECHA_1.HeaderText = "DATE";
            this.FECHA_1.MinimumWidth = 6;
            this.FECHA_1.Name = "FECHA_1";
            this.FECHA_1.Width = 125;
            // 
            // NIVEL_1
            // 
            this.NIVEL_1.HeaderText = "ACCESS";
            this.NIVEL_1.MinimumWidth = 6;
            this.NIVEL_1.Name = "NIVEL_1";
            this.NIVEL_1.Width = 125;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "PHONE";
            this.TELEFONO.MinimumWidth = 6;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Width = 125;
            // 
            // btn_delete
            // 
            this.btn_delete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btn_delete.Location = new System.Drawing.Point(717, 310);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.btn_delete.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btn_delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_delete.Size = new System.Drawing.Size(106, 32);
            this.btn_delete.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btn_delete.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.btn_delete.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_delete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_delete.StateCommon.Border.Rounding = 15;
            this.btn_delete.StateCommon.Border.Width = 1;
            this.btn_delete.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_delete.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_delete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_delete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.btn_delete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_delete.StatePressed.Border.Rounding = 15;
            this.btn_delete.StatePressed.Border.Width = 1;
            this.btn_delete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.btn_delete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_delete.TabIndex = 73;
            this.btn_delete.Values.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_Puertos
            // 
            this.cb_Puertos.AutoCompleteCustomSource.AddRange(new string[] {
            "ALTO",
            "MEDIO",
            "BAJO"});
            this.cb_Puertos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_Puertos.DropDownWidth = 121;
            this.cb_Puertos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Puertos.Location = new System.Drawing.Point(596, 258);
            this.cb_Puertos.MinimumSize = new System.Drawing.Size(0, 32);
            this.cb_Puertos.Name = "cb_Puertos";
            this.cb_Puertos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cb_Puertos.Size = new System.Drawing.Size(202, 32);
            this.cb_Puertos.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_Puertos.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cb_Puertos.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_Puertos.StateActive.ComboBox.Border.Rounding = 10;
            this.cb_Puertos.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.DimGray;
            this.cb_Puertos.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.cb_Puertos.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_Puertos.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.cb_Puertos.TabIndex = 82;
            this.cb_Puertos.DropDown += new System.EventHandler(this.cb_Puertos_DropDown);
            this.cb_Puertos.SelectedIndexChanged += new System.EventHandler(this.cb_Puertos_SelectedIndexChanged);
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Transparent;
            this.btn_conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
            this.btn_conectar.Location = new System.Drawing.Point(804, 262);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(28, 28);
            this.btn_conectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_conectar.TabIndex = 83;
            this.btn_conectar.TabStop = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
            this.pictureBox1.Location = new System.Drawing.Point(804, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonverificar
            // 
            this.buttonverificar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.buttonverificar.Location = new System.Drawing.Point(605, 310);
            this.buttonverificar.Name = "buttonverificar";
            this.buttonverificar.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.buttonverificar.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.buttonverificar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonverificar.Size = new System.Drawing.Size(106, 32);
            this.buttonverificar.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.buttonverificar.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.buttonverificar.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.buttonverificar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonverificar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonverificar.StateCommon.Border.Rounding = 15;
            this.buttonverificar.StateCommon.Border.Width = 1;
            this.buttonverificar.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.buttonverificar.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.buttonverificar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonverificar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonverificar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonverificar.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.buttonverificar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonverificar.StatePressed.Border.Rounding = 15;
            this.buttonverificar.StatePressed.Border.Width = 1;
            this.buttonverificar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.buttonverificar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonverificar.TabIndex = 85;
            this.buttonverificar.Values.Text = "CHECK";
            this.buttonverificar.Click += new System.EventHandler(this.buttonverificar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btn_Regresar.Location = new System.Drawing.Point(605, 364);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.btn_Regresar.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btn_Regresar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Regresar.Size = new System.Drawing.Size(218, 32);
            this.btn_Regresar.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btn_Regresar.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.btn_Regresar.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_Regresar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Regresar.StateCommon.Border.Rounding = 15;
            this.btn_Regresar.StateCommon.Border.Width = 1;
            this.btn_Regresar.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_Regresar.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_Regresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Regresar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Regresar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.btn_Regresar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Regresar.StatePressed.Border.Rounding = 15;
            this.btn_Regresar.StatePressed.Border.Width = 1;
            this.btn_Regresar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.btn_Regresar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Regresar.TabIndex = 86;
            this.btn_Regresar.Values.Text = "BACK";
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(778, 10);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 27);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 88;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(814, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 87;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.buttonverificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.cb_Puertos);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tabla_form2);
            this.Controls.Add(this.txt_uid1);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbAcceso);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Border.Width = 1;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_form2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Puertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbAcceso;
        private System.Windows.Forms.Label lbTelefono;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_uid1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tabla_form2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_delete;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_Puertos;
        private System.Windows.Forms.PictureBox btn_conectar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonverificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Regresar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btnClose;
    }
}