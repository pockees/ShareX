﻿namespace ShareX
{
    partial class QRCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeForm));
            this.cmsQR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEncode = new System.Windows.Forms.TabPage();
            this.tpDecode = new System.Windows.Forms.TabPage();
            this.btnDecodeFromFile = new System.Windows.Forms.Button();
            this.txtDecodeResult = new System.Windows.Forms.TextBox();
            this.lblDecodeResult = new System.Windows.Forms.Label();
            this.btnDecodeFromScreen = new System.Windows.Forms.Button();
            this.tpEncodeMulti = new System.Windows.Forms.TabPage();
            this.btnPrevQrImage = new System.Windows.Forms.Button();
            this.btnNextQrImage = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnGenQrcode = new System.Windows.Forms.Button();
            this.pbQrImage = new System.Windows.Forms.PictureBox();
            this.txtQRContentMulti = new System.Windows.Forms.TextBox();
            this.cmsQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpEncode.SuspendLayout();
            this.tpDecode.SuspendLayout();
            this.tpEncodeMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsQR
            // 
            this.cmsQR.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsQR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiSaveAs});
            this.cmsQR.Name = "cmsQR";
            this.cmsQR.ShowImageMargin = false;
            resources.ApplyResources(this.cmsQR, "cmsQR");
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            resources.ApplyResources(this.tsmiCopy, "tsmiCopy");
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            resources.ApplyResources(this.tsmiSaveAs, "tsmiSaveAs");
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // txtQRCode
            // 
            resources.ApplyResources(this.txtQRCode, "txtQRCode");
            this.txtQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.TextChanged += new System.EventHandler(this.txtQRCode_TextChanged);
            // 
            // pbQRCode
            // 
            resources.ApplyResources(this.pbQRCode, "pbQRCode");
            this.pbQRCode.ContextMenuStrip = this.cmsQR;
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEncodeMulti);
            this.tcMain.Controls.Add(this.tpEncode);
            this.tcMain.Controls.Add(this.tpDecode);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tpEncode
            // 
            this.tpEncode.Controls.Add(this.txtQRCode);
            this.tpEncode.Controls.Add(this.pbQRCode);
            resources.ApplyResources(this.tpEncode, "tpEncode");
            this.tpEncode.Name = "tpEncode";
            this.tpEncode.UseVisualStyleBackColor = true;
            // 
            // tpDecode
            // 
            this.tpDecode.Controls.Add(this.btnDecodeFromFile);
            this.tpDecode.Controls.Add(this.txtDecodeResult);
            this.tpDecode.Controls.Add(this.lblDecodeResult);
            this.tpDecode.Controls.Add(this.btnDecodeFromScreen);
            resources.ApplyResources(this.tpDecode, "tpDecode");
            this.tpDecode.Name = "tpDecode";
            this.tpDecode.UseVisualStyleBackColor = true;
            // 
            // btnDecodeFromFile
            // 
            resources.ApplyResources(this.btnDecodeFromFile, "btnDecodeFromFile");
            this.btnDecodeFromFile.Name = "btnDecodeFromFile";
            this.btnDecodeFromFile.UseVisualStyleBackColor = true;
            this.btnDecodeFromFile.Click += new System.EventHandler(this.btnDecodeFromFile_Click);
            // 
            // txtDecodeResult
            // 
            resources.ApplyResources(this.txtDecodeResult, "txtDecodeResult");
            this.txtDecodeResult.Name = "txtDecodeResult";
            // 
            // lblDecodeResult
            // 
            resources.ApplyResources(this.lblDecodeResult, "lblDecodeResult");
            this.lblDecodeResult.Name = "lblDecodeResult";
            // 
            // btnDecodeFromScreen
            // 
            resources.ApplyResources(this.btnDecodeFromScreen, "btnDecodeFromScreen");
            this.btnDecodeFromScreen.Name = "btnDecodeFromScreen";
            this.btnDecodeFromScreen.UseVisualStyleBackColor = true;
            this.btnDecodeFromScreen.Click += new System.EventHandler(this.btnDecodeFromScreen_Click);
            // 
            // tpEncodeMulti
            // 
            this.tpEncodeMulti.Controls.Add(this.btnPrevQrImage);
            this.tpEncodeMulti.Controls.Add(this.btnNextQrImage);
            this.tpEncodeMulti.Controls.Add(this.lblTip);
            this.tpEncodeMulti.Controls.Add(this.btnSaveAs);
            this.tpEncodeMulti.Controls.Add(this.btnGenQrcode);
            this.tpEncodeMulti.Controls.Add(this.pbQrImage);
            this.tpEncodeMulti.Controls.Add(this.txtQRContentMulti);
            resources.ApplyResources(this.tpEncodeMulti, "tpEncodeMulti");
            this.tpEncodeMulti.Name = "tpEncodeMulti";
            this.tpEncodeMulti.UseVisualStyleBackColor = true;
            // 
            // btnPrevQrImage
            // 
            this.btnPrevQrImage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPrevQrImage, "btnPrevQrImage");
            this.btnPrevQrImage.Name = "btnPrevQrImage";
            this.btnPrevQrImage.UseVisualStyleBackColor = true;
            this.btnPrevQrImage.Click += new System.EventHandler(this.btnPrevQrImage_Click);
            // 
            // btnNextQrImage
            // 
            this.btnNextQrImage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNextQrImage, "btnNextQrImage");
            this.btnNextQrImage.Name = "btnNextQrImage";
            this.btnNextQrImage.UseVisualStyleBackColor = true;
            this.btnNextQrImage.Click += new System.EventHandler(this.btnNextQrImage_Click);
            // 
            // lblTip
            // 
            resources.ApplyResources(this.lblTip, "lblTip");
            this.lblTip.Name = "lblTip";
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnGenQrcode
            // 
            resources.ApplyResources(this.btnGenQrcode, "btnGenQrcode");
            this.btnGenQrcode.Name = "btnGenQrcode";
            this.btnGenQrcode.UseVisualStyleBackColor = true;
            this.btnGenQrcode.Click += new System.EventHandler(this.btnGenQrcode_Click);
            // 
            // pbQrImage
            // 
            resources.ApplyResources(this.pbQrImage, "pbQrImage");
            this.pbQrImage.ContextMenuStrip = this.cmsQR;
            this.pbQrImage.Name = "pbQrImage";
            this.pbQrImage.TabStop = false;
            // 
            // txtQRContentMulti
            // 
            resources.ApplyResources(this.txtQRContentMulti, "txtQRContentMulti");
            this.txtQRContentMulti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQRContentMulti.Name = "txtQRContentMulti";
            // 
            // QRCodeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tcMain);
            this.Name = "QRCodeForm";
            this.Shown += new System.EventHandler(this.QRCodeForm_Shown);
            this.Resize += new System.EventHandler(this.QRCodeForm_Resize);
            this.cmsQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpEncode.ResumeLayout(false);
            this.tpEncode.PerformLayout();
            this.tpDecode.ResumeLayout(false);
            this.tpDecode.PerformLayout();
            this.tpEncodeMulti.ResumeLayout(false);
            this.tpEncodeMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.ContextMenuStrip cmsQR;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEncode;
        private System.Windows.Forms.TabPage tpDecode;
        private System.Windows.Forms.Button btnDecodeFromScreen;
        private System.Windows.Forms.TextBox txtDecodeResult;
        private System.Windows.Forms.Label lblDecodeResult;
        private System.Windows.Forms.Button btnDecodeFromFile;
        private System.Windows.Forms.TabPage tpEncodeMulti;
        private System.Windows.Forms.PictureBox pbQrImage;
        private System.Windows.Forms.TextBox txtQRContentMulti;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnGenQrcode;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnPrevQrImage;
        private System.Windows.Forms.Button btnNextQrImage;
    }
}