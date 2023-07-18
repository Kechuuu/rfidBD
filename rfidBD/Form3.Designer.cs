
namespace rfidBD
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.networkVariableDataSource1 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource(this.components);
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_user = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_verPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.button1.Location = new System.Drawing.Point(234, 483);
            this.button1.Name = "button1";
            this.button1.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.button1.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button1.Size = new System.Drawing.Size(134, 36);
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
            this.button1.TabIndex = 71;
            this.button1.Values.Text = "LOGIN";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txt_password
            // 
            this.txt_password.AllowDrop = true;
            this.txt_password.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txt_password.Location = new System.Drawing.Point(148, 406);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(307, 33);
            this.txt_password.StateActive.Back.Color1 = System.Drawing.Color.Gray;
            this.txt_password.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_password.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_password.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_password.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.txt_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_password.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_password.StateCommon.Border.Rounding = 20;
            this.txt_password.StateCommon.Border.Width = 1;
            this.txt_password.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_password.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_password.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.txt_password.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_password.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_password.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.txt_password.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txt_password.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_password.StateNormal.Content.Color1 = System.Drawing.Color.Firebrick;
            this.txt_password.TabIndex = 44;
            // 
            // txt_user
            // 
            this.txt_user.AllowDrop = true;
            this.txt_user.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txt_user.Location = new System.Drawing.Point(148, 321);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(307, 33);
            this.txt_user.StateActive.Back.Color1 = System.Drawing.Color.Gray;
            this.txt_user.StateActive.Border.Color1 = System.Drawing.Color.DimGray;
            this.txt_user.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_user.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_user.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.txt_user.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_user.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_user.StateCommon.Border.Rounding = 20;
            this.txt_user.StateCommon.Border.Width = 1;
            this.txt_user.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txt_user.StateCommon.Content.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_user.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.txt_user.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_user.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_user.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.txt_user.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txt_user.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_user.StateNormal.Content.Color1 = System.Drawing.Color.Firebrick;
            this.txt_user.TabIndex = 43;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(558, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 72;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(522, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 27);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 78;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_verPassword
            // 
            this.btn_verPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_verPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verPassword.Image = global::rfidBD.Properties.Resources._1;
            this.btn_verPassword.Location = new System.Drawing.Point(461, 406);
            this.btn_verPassword.Name = "btn_verPassword";
            this.btn_verPassword.Size = new System.Drawing.Size(28, 28);
            this.btn_verPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verPassword.TabIndex = 81;
            this.btn_verPassword.TabStop = false;
            this.btn_verPassword.Click += new System.EventHandler(this.btn_verPassword_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 694);
            this.Controls.Add(this.btn_verPassword);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(49)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(49)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 5;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_user;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource networkVariableDataSource1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_verPassword;
    }
}