namespace Chat_App
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.titpanel = new System.Windows.Forms.Panel();
            this.btnexit2 = new DevExpress.XtraEditors.SimpleButton();
            this.tbcntrlchat = new DevExpress.XtraTab.XtraTabControl();
            this.lstcontrolcustomer = new DevExpress.XtraEditors.ListBoxControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.BtnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcntrlchat)).BeginInit();
            this.tbcntrlchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstcontrolcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.titpanel);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnexit2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.tbcntrlchat);
            this.splitContainerControl1.Panel2.Controls.Add(this.lstcontrolcustomer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(498, 510);
            this.splitContainerControl1.SplitterPosition = 49;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // titpanel
            // 
            this.titpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titpanel.Location = new System.Drawing.Point(0, 0);
            this.titpanel.Name = "titpanel";
            this.titpanel.Size = new System.Drawing.Size(452, 49);
            this.titpanel.TabIndex = 14;
            this.titpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titpanel_MouseDown);
            this.titpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titpanel_MouseMove);
            // 
            // btnexit2
            // 
            this.btnexit2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.btnexit2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnexit2.Appearance.Options.UseBackColor = true;
            this.btnexit2.Appearance.Options.UseFont = true;
            this.btnexit2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnexit2.AppearanceHovered.Options.UseBackColor = true;
            this.btnexit2.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.btnexit2.AppearancePressed.Options.UseBackColor = true;
            this.btnexit2.AutoSize = true;
            this.btnexit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnexit2.ImageOptions.SvgImage")));
            this.btnexit2.Location = new System.Drawing.Point(452, 0);
            this.btnexit2.Name = "btnexit2";
            this.btnexit2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnexit2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnexit2.Size = new System.Drawing.Size(46, 49);
            this.btnexit2.TabIndex = 13;
            this.btnexit2.Click += new System.EventHandler(this.btnexit2_Click);
            // 
            // tbcntrlchat
            // 
            this.tbcntrlchat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.Appearance.Options.UseBackColor = true;
            this.tbcntrlchat.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.AppearancePage.Header.Options.UseBackColor = true;
            this.tbcntrlchat.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tbcntrlchat.AppearancePage.HeaderDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.AppearancePage.HeaderDisabled.Options.UseBackColor = true;
            this.tbcntrlchat.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.AppearancePage.HeaderHotTracked.Options.UseBackColor = true;
            this.tbcntrlchat.AppearancePage.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.tbcntrlchat.AppearancePage.PageClient.Options.UseBackColor = true;
            this.tbcntrlchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcntrlchat.Location = new System.Drawing.Point(106, 0);
            this.tbcntrlchat.Name = "tbcntrlchat";
            this.tbcntrlchat.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.tbcntrlchat.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tbcntrlchat.Size = new System.Drawing.Size(392, 449);
            this.tbcntrlchat.TabIndex = 1;
            // 
            // lstcontrolcustomer
            // 
            this.lstcontrolcustomer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.lstcontrolcustomer.Appearance.ForeColor = System.Drawing.Color.White;
            this.lstcontrolcustomer.Appearance.Options.UseBackColor = true;
            this.lstcontrolcustomer.Appearance.Options.UseForeColor = true;
            this.lstcontrolcustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstcontrolcustomer.Location = new System.Drawing.Point(0, 0);
            this.lstcontrolcustomer.Margin = new System.Windows.Forms.Padding(0);
            this.lstcontrolcustomer.MultiColumn = true;
            this.lstcontrolcustomer.Name = "lstcontrolcustomer";
            this.lstcontrolcustomer.Size = new System.Drawing.Size(106, 449);
            this.lstcontrolcustomer.TabIndex = 0;
            this.lstcontrolcustomer.SelectedIndexChanged += new System.EventHandler(this.lstcontrolcustomer_SelectedIndexChanged);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(82, 52);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(236, 254);
            this.memoEdit1.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSend.Location = new System.Drawing.Point(1, 410);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(390, 38);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "button1";
            this.BtnSend.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 510);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbcntrlchat)).EndInit();
            this.tbcntrlchat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstcontrolcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lstcontrolcustomer;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        public DevExpress.XtraTab.XtraTabControl tbcntrlchat;
        private DevExpress.XtraEditors.SimpleButton btnexit2;
        public System.Windows.Forms.Panel titpanel;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Button BtnSend;
    }
}