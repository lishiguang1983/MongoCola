﻿namespace MagicMongoDBTool
{
    partial class frmElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElement));
            this.AddBsonElement = new MagicMongoDBTool.ctlAddBsonEl();
            this.cmdCancel = new System.Windows.Forms.VistaButton();
            this.cmdOK = new System.Windows.Forms.VistaButton();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentPanel.BackgroundImage")));
            this.contentPanel.Controls.Add(this.cmdCancel);
            this.contentPanel.Controls.Add(this.cmdOK);
            this.contentPanel.Controls.Add(this.AddBsonElement);
            this.contentPanel.Location = new System.Drawing.Point(1, 38);
            this.contentPanel.Size = new System.Drawing.Size(383, 152);
            // 
            // AddBsonElement
            // 
            this.AddBsonElement.BackColor = System.Drawing.Color.Transparent;
            this.AddBsonElement.Location = new System.Drawing.Point(27, 44);
            this.AddBsonElement.Name = "AddBsonElement";
            this.AddBsonElement.Size = new System.Drawing.Size(326, 30);
            this.AddBsonElement.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancel.Location = new System.Drawing.Point(225, 95);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 32);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "取消";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Transparent;
            this.cmdOK.Location = new System.Drawing.Point(59, 94);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(100, 32);
            this.cmdOK.TabIndex = 7;
            this.cmdOK.Text = "确定";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // frmElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 215);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmElement";
            this.Text = "frmElement";
            this.Load += new System.EventHandler(this.frmElement_Load);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlAddBsonEl AddBsonElement;
        private System.Windows.Forms.VistaButton cmdCancel;
        private System.Windows.Forms.VistaButton cmdOK;

    }
}