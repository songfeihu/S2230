﻿namespace Day08_0200单例
{
    partial class FrmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(39, 69);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(502, 277);
            this.Player1.TabIndex = 0;
            //this.Player1.Enter += new System.EventHandler(this.Player1_Enter);
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 483);
            this.Controls.Add(this.Player1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPlay_FormClosing);
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player1;
    }
}