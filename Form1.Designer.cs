using System;
using System.Speech.Recognition;

namespace smite_voice2vgs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.btn_enable = new System.Windows.Forms.Button();
            this.btn_disable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Centaur", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(12, 35);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(583, 275);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // btn_enable
            // 
            this.btn_enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_enable.Location = new System.Drawing.Point(12, 325);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(288, 54);
            this.btn_enable.TabIndex = 1;
            this.btn_enable.Text = "Enable Voice2VGS";
            this.btn_enable.UseVisualStyleBackColor = false;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_disable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_disable.Location = new System.Drawing.Point(306, 325);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(289, 54);
            this.btn_disable.TabIndex = 2;
            this.btn_disable.Text = "Disable Voice2VGS";
            this.btn_disable.UseVisualStyleBackColor = false;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "-Log Box-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(606, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.logBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SMITE - Voice 2 VGS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox logBox;
        private Button btn_enable;
        private Button btn_disable;
        private Label label1;
    }
}