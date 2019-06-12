using System;

namespace Lab8
{
    partial class Form1
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
            this.SelectProgram = new System.Windows.Forms.DataGridView();
            this.RunButton = new System.Windows.Forms.Button();
            this.MyAppNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MyAppTimer = new System.Windows.Forms.Timer(this.components);
            this.ParamsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectProgram
            // 
            this.SelectProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectProgram.Location = new System.Drawing.Point(1, 1);
            this.SelectProgram.Name = "SelectProgram";
            this.SelectProgram.Size = new System.Drawing.Size(240, 449);
            this.SelectProgram.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(274, 50);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(200, 23);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Open";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MyAppNotifyIcon
            // 
            this.MyAppNotifyIcon.Text = "MyApplication";
            this.MyAppNotifyIcon.Visible = true;
            this.MyAppNotifyIcon.Click += new System.EventHandler(this.MyAppNotifyIcon_Click);
            this.MyAppNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyAppNotifyIcon_MouseDoubleClick);
            // 
            // MyAppTimer
            // 
            this.MyAppTimer.Tick += new System.EventHandler(this.MyAppTimer_Tick);
            // 
            // ParamsText
            // 
            this.ParamsText.Location = new System.Drawing.Point(347, 13);
            this.ParamsText.Name = "ParamsText";
            this.ParamsText.Size = new System.Drawing.Size(127, 20);
            this.ParamsText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Params:";
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(274, 80);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(200, 23);
            this.ChooseFile.TabIndex = 4;
            this.ChooseFile.Text = "Choose file";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParamsText);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SelectProgram);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activate);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectProgram;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.NotifyIcon MyAppNotifyIcon;
        private System.Windows.Forms.Timer MyAppTimer;
        private System.Windows.Forms.TextBox ParamsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog MyOpenFileDialog;
        private System.Windows.Forms.Button ChooseFile;
    }
}

