﻿namespace KeeAnywhere.OAuth2
{
    partial class OAuth2Form
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
            this.m_browser = new System.Windows.Forms.WebBrowser();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // m_browser
            // 
            this.m_browser.AllowWebBrowserDrop = false;
            this.m_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_browser.IsWebBrowserContextMenuEnabled = false;
            this.m_browser.Location = new System.Drawing.Point(0, 66);
            this.m_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_browser.Name = "m_browser";
            this.m_browser.Size = new System.Drawing.Size(653, 559);
            this.m_browser.TabIndex = 0;
            this.m_browser.WebBrowserShortcutsEnabled = false;
            this.m_browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.OnDocumentCompleted);
            this.m_browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnNavigated);
            this.m_browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.OnNavigating);
            this.m_browser.NewWindow += new System.ComponentModel.CancelEventHandler(this.OnNewWindow);
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(653, 60);
            this.m_bannerImage.TabIndex = 17;
            this.m_bannerImage.TabStop = false;
            // 
            // OAuth2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 625);
            this.Controls.Add(this.m_bannerImage);
            this.Controls.Add(this.m_browser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OAuth2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OAuth2Form";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser m_browser;
        private System.Windows.Forms.PictureBox m_bannerImage;
    }
}