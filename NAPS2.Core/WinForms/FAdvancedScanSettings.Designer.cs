using System;
using System.Collections.Generic;
using System.Linq;

namespace NAPS2.WinForms
{
    partial class FAdvancedScanSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdvancedScanSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbHighQuality = new System.Windows.Forms.CheckBox();
            this.ilProfileIcons = new NAPS2.WinForms.ILProfileIcons(this.components);
            this.txtImageQuality = new System.Windows.Forms.TextBox();
            this.tbImageQuality = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbForcePageSize = new System.Windows.Forms.CheckBox();
            this.cbBrightnessContrastAfterScan = new System.Windows.Forms.CheckBox();
            this.cmbTwainImpl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageQuality)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbHighQuality
            // 
            resources.ApplyResources(this.cbHighQuality, "cbHighQuality");
            this.cbHighQuality.Name = "cbHighQuality";
            this.cbHighQuality.UseVisualStyleBackColor = true;
            // 
            // txtImageQuality
            // 
            resources.ApplyResources(this.txtImageQuality, "txtImageQuality");
            this.txtImageQuality.Name = "txtImageQuality";
            this.txtImageQuality.TextChanged += new System.EventHandler(this.txtImageQuality_TextChanged);
            // 
            // tbImageQuality
            // 
            resources.ApplyResources(this.tbImageQuality, "tbImageQuality");
            this.tbImageQuality.Maximum = 100;
            this.tbImageQuality.Name = "tbImageQuality";
            this.tbImageQuality.TickFrequency = 25;
            this.tbImageQuality.Scroll += new System.EventHandler(this.tbImageQuality_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbImageQuality);
            this.groupBox1.Controls.Add(this.txtImageQuality);
            this.groupBox1.Controls.Add(this.cbHighQuality);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbForcePageSize);
            this.groupBox2.Controls.Add(this.cbBrightnessContrastAfterScan);
            this.groupBox2.Controls.Add(this.cmbTwainImpl);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbForcePageSize
            // 
            resources.ApplyResources(this.cbForcePageSize, "cbForcePageSize");
            this.cbForcePageSize.Name = "cbForcePageSize";
            this.cbForcePageSize.UseVisualStyleBackColor = true;
            // 
            // cbBrightnessContrastAfterScan
            // 
            resources.ApplyResources(this.cbBrightnessContrastAfterScan, "cbBrightnessContrastAfterScan");
            this.cbBrightnessContrastAfterScan.Name = "cbBrightnessContrastAfterScan";
            this.cbBrightnessContrastAfterScan.UseVisualStyleBackColor = true;
            // 
            // cmbTwainImpl
            // 
            this.cmbTwainImpl.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTwainImpl, "cmbTwainImpl");
            this.cmbTwainImpl.Name = "cmbTwainImpl";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FAdvancedScanSettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAdvancedScanSettings";
            ((System.ComponentModel.ISupportInitialize)(this.tbImageQuality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private ILProfileIcons ilProfileIcons;
        private System.Windows.Forms.CheckBox cbHighQuality;
        private System.Windows.Forms.TextBox txtImageQuality;
        private System.Windows.Forms.TrackBar tbImageQuality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTwainImpl;
        private System.Windows.Forms.CheckBox cbBrightnessContrastAfterScan;
        private System.Windows.Forms.CheckBox cbForcePageSize;
    }
}