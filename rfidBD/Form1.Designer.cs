
namespace rfidBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txt_uid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_tel = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cb1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnCaptura = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCamara = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.combobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cb_Puertos = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_conectar = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Puertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(73, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::rfidBD.Properties.Resources.cancel_close_button_png_11;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::rfidBD.Properties.Resources.cancel_close_button_png_11;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.ColorAngle = -3F;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 30;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = -3;
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(448, 166);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(239, 33);
            this.txt_uid.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_uid.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_uid.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_uid.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_uid.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_uid.StateCommon.Border.Rounding = 20;
            this.txt_uid.StateCommon.Border.Width = 1;
            this.txt_uid.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_uid.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_uid.TabIndex = 43;
            this.txt_uid.Enter += new System.EventHandler(this.txt_uid_Enter);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(448, 290);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(239, 33);
            this.txt_tel.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_tel.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_tel.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tel.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_tel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_tel.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_tel.StateCommon.Border.Rounding = 20;
            this.txt_tel.StateCommon.Border.Width = 1;
            this.txt_tel.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_tel.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_tel.TabIndex = 44;
            this.txt_tel.Enter += new System.EventHandler(this.txt_tel_Enter);
            // 
            // cb1
            // 
            this.cb1.AutoCompleteCustomSource.AddRange(new string[] {
            "ALTO",
            "MEDIO",
            "BAJO"});
            this.cb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb1.DropDownWidth = 121;
            this.cb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb1.Location = new System.Drawing.Point(446, 441);
            this.cb1.Name = "cb1";
            this.cb1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cb1.Size = new System.Drawing.Size(239, 27);
            this.cb1.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.cb1.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cb1.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb1.StateActive.ComboBox.Border.Rounding = 10;
            this.cb1.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.cb1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.cb1.TabIndex = 46;
            this.cb1.Text = "CAMERA";
            // 
            // btnCaptura
            // 
            this.btnCaptura.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnCaptura.Location = new System.Drawing.Point(569, 483);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCaptura.Size = new System.Drawing.Size(116, 32);
            this.btnCaptura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaptura.StateCommon.Border.Rounding = 15;
            this.btnCaptura.StateCommon.Border.Width = 1;
            this.btnCaptura.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCaptura.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCaptura.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCaptura.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCaptura.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.btnCaptura.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaptura.StatePressed.Border.Rounding = 15;
            this.btnCaptura.StatePressed.Border.Width = 1;
            this.btnCaptura.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCaptura.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.btnCaptura.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaptura.TabIndex = 63;
            this.btnCaptura.Values.Text = "SCREENSHOT";
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnCamara.Location = new System.Drawing.Point(446, 483);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCamara.Size = new System.Drawing.Size(117, 32);
            this.btnCamara.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.btnCamara.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCamara.StateCommon.Border.Rounding = 15;
            this.btnCamara.StateCommon.Border.Width = 1;
            this.btnCamara.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCamara.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCamara.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCamara.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCamara.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamara.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.btnCamara.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCamara.StatePressed.Border.Rounding = 15;
            this.btnCamara.StatePressed.Border.Width = 1;
            this.btnCamara.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.btnCamara.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCamara.TabIndex = 64;
            this.btnCamara.Values.Text = "CAMERA";
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // button2
            // 
            this.button2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.button2.Location = new System.Drawing.Point(569, 530);
            this.button2.Name = "button2";
            this.button2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateCommon.Border.Rounding = 15;
            this.button2.StateCommon.Border.Width = 1;
            this.button2.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button2.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button2.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.button2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StatePressed.Border.Rounding = 15;
            this.button2.StatePressed.Border.Width = 1;
            this.button2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.button2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.TabIndex = 66;
            this.button2.Values.Text = "CHECK";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // combobox
            // 
            this.combobox.AutoCompleteCustomSource.AddRange(new string[] {
            "ALTO",
            "MEDIO",
            "BAJO"});
            this.combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combobox.DropDownWidth = 121;
            this.combobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combobox.Items.AddRange(new object[] {
            "ALTO",
            "MEDIO",
            "BAJO"});
            this.combobox.Location = new System.Drawing.Point(446, 396);
            this.combobox.Name = "combobox";
            this.combobox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.combobox.Size = new System.Drawing.Size(239, 27);
            this.combobox.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.combobox.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.combobox.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.combobox.StateActive.ComboBox.Border.Rounding = 10;
            this.combobox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.combobox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.combobox.TabIndex = 68;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(759, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 69;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.button1.Location = new System.Drawing.Point(447, 530);
            this.button1.Name = "button1";
            this.button1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.button1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateCommon.Border.Rounding = 15;
            this.button1.StateCommon.Border.Width = 1;
            this.button1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.button1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.button1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StatePressed.Border.Rounding = 15;
            this.button1.StatePressed.Border.Width = 1;
            this.button1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(201)))), ((int)(((byte)(90)))));
            this.button1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.TabIndex = 70;
            this.button1.Values.Text = "ADD";
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cb_Puertos.Location = new System.Drawing.Point(448, 112);
            this.cb_Puertos.Name = "cb_Puertos";
            this.cb_Puertos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cb_Puertos.Size = new System.Drawing.Size(204, 27);
            this.cb_Puertos.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.cb_Puertos.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cb_Puertos.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_Puertos.StateActive.ComboBox.Border.Rounding = 10;
            this.cb_Puertos.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.cb_Puertos.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.cb_Puertos.TabIndex = 71;
            this.cb_Puertos.DropDown += new System.EventHandler(this.cb_Puertos_DropDown);
            this.cb_Puertos.SelectedIndexChanged += new System.EventHandler(this.cb_puerto_SelectedIndexChanged);
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Transparent;
            this.btn_conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
            this.btn_conectar.Location = new System.Drawing.Point(658, 111);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(28, 28);
            this.btn_conectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_conectar.TabIndex = 76;
            this.btn_conectar.TabStop = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AllowDrop = true;
            this.txt_nombre.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txt_nombre.Location = new System.Drawing.Point(447, 227);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(239, 33);
            this.txt_nombre.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_nombre.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(181)))), ((int)(((byte)(142)))));
            this.txt_nombre.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_nombre.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.txt_nombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_nombre.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_nombre.StateCommon.Border.Rounding = 20;
            this.txt_nombre.StateCommon.Border.Width = 1;
            this.txt_nombre.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_nombre.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_nombre.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.txt_nombre.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_nombre.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_nombre.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.txt_nombre.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txt_nombre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_nombre.StateNormal.Content.Color1 = System.Drawing.Color.Firebrick;
            this.txt_nombre.TabIndex = 42;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(732, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 27);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 77;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
            this.pictureBox5.Location = new System.Drawing.Point(654, 170);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 80;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(791, 598);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.cb_Puertos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(89)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 5;
            this.Text = "NAS";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Puertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_uid;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_tel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCaptura;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCamara;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox combobox;
        private System.Windows.Forms.PictureBox btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_Puertos;
        private System.Windows.Forms.PictureBox btn_conectar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_nombre;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

