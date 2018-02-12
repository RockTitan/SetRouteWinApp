namespace SetRouteWinApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SetDNS = new System.Windows.Forms.Button();
            this.On = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RestoreDNS = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.IPv4TitleLabel = new System.Windows.Forms.Label();
            this.IPv4ShowLabel = new System.Windows.Forms.Label();
            this.HostNameTitleLabel = new System.Windows.Forms.Label();
            this.HostNameSHowlabel = new System.Windows.Forms.Label();
            this.IPv4ShowlistBox = new System.Windows.Forms.ListBox();
            this.DNSTitleLabel = new System.Windows.Forms.Label();
            this.DNSServerShowlistBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(121, 106);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SetDNS);
            this.tabPage1.Controls.Add(this.On);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(113, 79);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "On";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SetDNS
            // 
            this.SetDNS.Location = new System.Drawing.Point(6, 42);
            this.SetDNS.Name = "SetDNS";
            this.SetDNS.Size = new System.Drawing.Size(100, 30);
            this.SetDNS.TabIndex = 1;
            this.SetDNS.Text = "Set DNS";
            this.SetDNS.UseVisualStyleBackColor = true;
            this.SetDNS.Click += new System.EventHandler(this.SetDNS_Click);
            // 
            // On
            // 
            this.On.Location = new System.Drawing.Point(6, 6);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(100, 30);
            this.On.TabIndex = 0;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = true;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RestoreDNS);
            this.tabPage2.Controls.Add(this.Off);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(113, 79);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Off";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RestoreDNS
            // 
            this.RestoreDNS.Location = new System.Drawing.Point(6, 42);
            this.RestoreDNS.Name = "RestoreDNS";
            this.RestoreDNS.Size = new System.Drawing.Size(100, 30);
            this.RestoreDNS.TabIndex = 1;
            this.RestoreDNS.Text = "Restore DNS";
            this.RestoreDNS.UseVisualStyleBackColor = true;
            this.RestoreDNS.Click += new System.EventHandler(this.RestoreDNS_Click);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(6, 6);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(100, 30);
            this.Off.TabIndex = 0;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(425, 467);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 30);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // IPv4TitleLabel
            // 
            this.IPv4TitleLabel.AutoSize = true;
            this.IPv4TitleLabel.Location = new System.Drawing.Point(13, 155);
            this.IPv4TitleLabel.Name = "IPv4TitleLabel";
            this.IPv4TitleLabel.Size = new System.Drawing.Size(49, 14);
            this.IPv4TitleLabel.TabIndex = 3;
            this.IPv4TitleLabel.Text = "IPv4 :";
            // 
            // IPv4ShowLabel
            // 
            this.IPv4ShowLabel.AutoSize = true;
            this.IPv4ShowLabel.Location = new System.Drawing.Point(68, 155);
            this.IPv4ShowLabel.Name = "IPv4ShowLabel";
            this.IPv4ShowLabel.Size = new System.Drawing.Size(14, 14);
            this.IPv4ShowLabel.TabIndex = 4;
            this.IPv4ShowLabel.Text = " ";
            this.IPv4ShowLabel.Click += new System.EventHandler(this.IPv4ShowLabel_Click);
            // 
            // HostNameTitleLabel
            // 
            this.HostNameTitleLabel.AutoSize = true;
            this.HostNameTitleLabel.Location = new System.Drawing.Point(13, 131);
            this.HostNameTitleLabel.Name = "HostNameTitleLabel";
            this.HostNameTitleLabel.Size = new System.Drawing.Size(84, 14);
            this.HostNameTitleLabel.TabIndex = 5;
            this.HostNameTitleLabel.Text = "Host Name :";
            // 
            // HostNameSHowlabel
            // 
            this.HostNameSHowlabel.AutoSize = true;
            this.HostNameSHowlabel.Location = new System.Drawing.Point(103, 131);
            this.HostNameSHowlabel.Name = "HostNameSHowlabel";
            this.HostNameSHowlabel.Size = new System.Drawing.Size(14, 14);
            this.HostNameSHowlabel.TabIndex = 6;
            this.HostNameSHowlabel.Text = " ";
            this.HostNameSHowlabel.Click += new System.EventHandler(this.HostNameSHowlabel_Click);
            // 
            // IPv4ShowlistBox
            // 
            this.IPv4ShowlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPv4ShowlistBox.FormattingEnabled = true;
            this.IPv4ShowlistBox.ItemHeight = 14;
            this.IPv4ShowlistBox.Location = new System.Drawing.Point(16, 172);
            this.IPv4ShowlistBox.Name = "IPv4ShowlistBox";
            this.IPv4ShowlistBox.ScrollAlwaysVisible = true;
            this.IPv4ShowlistBox.Size = new System.Drawing.Size(214, 74);
            this.IPv4ShowlistBox.TabIndex = 7;
            this.IPv4ShowlistBox.SelectedIndexChanged += new System.EventHandler(this.IPv4ShowlistBox_SelectedIndexChanged);
            // 
            // DNSTitleLabel
            // 
            this.DNSTitleLabel.AutoSize = true;
            this.DNSTitleLabel.Location = new System.Drawing.Point(13, 259);
            this.DNSTitleLabel.Name = "DNSTitleLabel";
            this.DNSTitleLabel.Size = new System.Drawing.Size(91, 14);
            this.DNSTitleLabel.TabIndex = 8;
            this.DNSTitleLabel.Text = "DNS Server :";
            // 
            // DNSServerShowlistBox
            // 
            this.DNSServerShowlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DNSServerShowlistBox.FormattingEnabled = true;
            this.DNSServerShowlistBox.ItemHeight = 14;
            this.DNSServerShowlistBox.Location = new System.Drawing.Point(16, 278);
            this.DNSServerShowlistBox.Name = "DNSServerShowlistBox";
            this.DNSServerShowlistBox.ScrollAlwaysVisible = true;
            this.DNSServerShowlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DNSServerShowlistBox.Size = new System.Drawing.Size(214, 214);
            this.DNSServerShowlistBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 509);
            this.Controls.Add(this.DNSServerShowlistBox);
            this.Controls.Add(this.DNSTitleLabel);
            this.Controls.Add(this.IPv4ShowlistBox);
            this.Controls.Add(this.HostNameSHowlabel);
            this.Controls.Add(this.HostNameTitleLabel);
            this.Controls.Add(this.IPv4ShowLabel);
            this.Controls.Add(this.IPv4TitleLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SetRouteWinApp V1.0.20180208";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SetDNS;
        private System.Windows.Forms.Button On;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RestoreDNS;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label IPv4TitleLabel;
        private System.Windows.Forms.Label IPv4ShowLabel;
        private System.Windows.Forms.Label HostNameTitleLabel;
        private System.Windows.Forms.Label HostNameSHowlabel;
        private System.Windows.Forms.ListBox IPv4ShowlistBox;
        private System.Windows.Forms.Label DNSTitleLabel;
        private System.Windows.Forms.ListBox DNSServerShowlistBox;
    }
}

