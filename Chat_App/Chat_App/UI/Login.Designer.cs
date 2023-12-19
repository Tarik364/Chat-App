namespace Chat_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtpass = new DevExpress.XtraEditors.TextEdit();
            this.lbluser = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndisable = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblpass = new DevExpress.XtraEditors.LabelControl();
            this.cmbuser = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbuser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            resources.ApplyResources(this.txtpass, "txtpass");
            this.txtpass.Name = "txtpass";
            this.txtpass.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.txtpass.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtpass.Properties.Appearance.Font")));
            this.txtpass.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtpass.Properties.Appearance.Options.UseBackColor = true;
            this.txtpass.Properties.Appearance.Options.UseFont = true;
            this.txtpass.Properties.Appearance.Options.UseForeColor = true;
            // 
            // lbluser
            // 
            this.lbluser.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbluser.Appearance.Font")));
            this.lbluser.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lbluser.Appearance.Options.UseFont = true;
            this.lbluser.Appearance.Options.UseForeColor = true;
            this.lbluser.Appearance.Options.UseTextOptions = true;
            this.lbluser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lbluser, "lbluser");
            this.lbluser.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbluser.Name = "lbluser";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnexit);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btndisable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            // 
            // btnexit
            // 
            resources.ApplyResources(this.btnexit, "btnexit");
            this.btnexit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.btnexit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnexit.Appearance.Font")));
            this.btnexit.Appearance.Options.UseBackColor = true;
            this.btnexit.Appearance.Options.UseFont = true;
            this.btnexit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnexit.AppearanceHovered.Options.UseBackColor = true;
            this.btnexit.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.btnexit.AppearancePressed.Options.UseBackColor = true;
            this.btnexit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnexit.ImageOptions.SvgImage")));
            this.btnexit.Name = "btnexit";
            this.btnexit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnexit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btndisable
            // 
            this.btndisable.Appearance.BackColor = System.Drawing.Color.Olive;
            this.btndisable.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btndisable.Appearance.Font")));
            this.btndisable.Appearance.ForeColor = System.Drawing.Color.White;
            this.btndisable.Appearance.Options.UseBackColor = true;
            this.btndisable.Appearance.Options.UseFont = true;
            this.btndisable.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.btndisable, "btndisable");
            this.btndisable.Name = "btndisable";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnlogin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblpass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtpass, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbluser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbuser, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnlogin
            // 
            this.btnlogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlogin.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnlogin.Appearance.Font")));
            this.btnlogin.Appearance.Options.UseBackColor = true;
            this.btnlogin.Appearance.Options.UseFont = true;
            this.btnlogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnlogin.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.btnlogin.AppearancePressed.Options.UseBackColor = true;
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpass
            // 
            this.lblpass.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblpass.Appearance.Font")));
            this.lblpass.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lblpass.Appearance.Options.UseFont = true;
            this.lblpass.Appearance.Options.UseForeColor = true;
            this.lblpass.Appearance.Options.UseTextOptions = true;
            this.lblpass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lblpass, "lblpass");
            this.lblpass.Name = "lblpass";
            // 
            // cmbuser
            // 
            resources.ApplyResources(this.cmbuser, "cmbuser");
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.cmbuser.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmbuser.Properties.Appearance.Options.UseBackColor = true;
            this.cmbuser.Properties.Appearance.Options.UseForeColor = true;
            this.cmbuser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbuser.Properties.Buttons"))))});
            this.cmbuser.Properties.SelectAllItemVisible = false;
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbuser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtpass;
        private DevExpress.XtraEditors.LabelControl lbluser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblpass;
        private DevExpress.XtraEditors.SimpleButton btnlogin;
        private DevExpress.XtraEditors.SimpleButton btndisable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        public DevExpress.XtraEditors.CheckedComboBoxEdit cmbuser;
    }
}