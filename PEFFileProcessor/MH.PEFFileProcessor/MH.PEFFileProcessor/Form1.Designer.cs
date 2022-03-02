﻿
namespace MH.PEFFileProcessor
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
            this.btnCountLines = new System.Windows.Forms.Button();
            this.btnProcessPEFtoDB = new System.Windows.Forms.Button();
            this.rtb_Status = new System.Windows.Forms.RichTextBox();
            this.btnSplitFile = new System.Windows.Forms.Button();
            this.btnProcessAllfiles = new System.Windows.Forms.Button();
            this.btnCreateDbTbl = new System.Windows.Forms.Button();
            this.btn1SplitPEfFileProcess = new System.Windows.Forms.Button();
            this.btn_Process_repeatgrp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountLines
            // 
            this.btnCountLines.Location = new System.Drawing.Point(12, 12);
            this.btnCountLines.Name = "btnCountLines";
            this.btnCountLines.Size = new System.Drawing.Size(123, 73);
            this.btnCountLines.TabIndex = 0;
            this.btnCountLines.Text = "Count total Lines";
            this.btnCountLines.UseVisualStyleBackColor = true;
            this.btnCountLines.Click += new System.EventHandler(this.btnCountLines_Click);
            // 
            // btnProcessPEFtoDB
            // 
            this.btnProcessPEFtoDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcessPEFtoDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcessPEFtoDB.Location = new System.Drawing.Point(12, 109);
            this.btnProcessPEFtoDB.Name = "btnProcessPEFtoDB";
            this.btnProcessPEFtoDB.Size = new System.Drawing.Size(111, 73);
            this.btnProcessPEFtoDB.TabIndex = 1;
            this.btnProcessPEFtoDB.Text = "Process PEF to DB";
            this.btnProcessPEFtoDB.UseVisualStyleBackColor = false;
            this.btnProcessPEFtoDB.Click += new System.EventHandler(this.btnProcessPEFtoDB_Click);
            // 
            // rtb_Status
            // 
            this.rtb_Status.Location = new System.Drawing.Point(12, 257);
            this.rtb_Status.Name = "rtb_Status";
            this.rtb_Status.Size = new System.Drawing.Size(529, 353);
            this.rtb_Status.TabIndex = 2;
            this.rtb_Status.Text = "";
            // 
            // btnSplitFile
            // 
            this.btnSplitFile.Location = new System.Drawing.Point(567, 65);
            this.btnSplitFile.Name = "btnSplitFile";
            this.btnSplitFile.Size = new System.Drawing.Size(105, 74);
            this.btnSplitFile.TabIndex = 3;
            this.btnSplitFile.Text = "Split File";
            this.btnSplitFile.UseVisualStyleBackColor = true;
            this.btnSplitFile.Click += new System.EventHandler(this.btnSplitFile_Click);
            // 
            // btnProcessAllfiles
            // 
            this.btnProcessAllfiles.Location = new System.Drawing.Point(149, 12);
            this.btnProcessAllfiles.Name = "btnProcessAllfiles";
            this.btnProcessAllfiles.Size = new System.Drawing.Size(139, 73);
            this.btnProcessAllfiles.TabIndex = 4;
            this.btnProcessAllfiles.Text = "Process All Files";
            this.btnProcessAllfiles.UseVisualStyleBackColor = true;
            this.btnProcessAllfiles.Click += new System.EventHandler(this.btnProcessAllfiles_Click);
            // 
            // btnCreateDbTbl
            // 
            this.btnCreateDbTbl.Location = new System.Drawing.Point(564, 155);
            this.btnCreateDbTbl.Name = "btnCreateDbTbl";
            this.btnCreateDbTbl.Size = new System.Drawing.Size(108, 66);
            this.btnCreateDbTbl.TabIndex = 5;
            this.btnCreateDbTbl.Text = "Create d/b tbl from ORMLite";
            this.btnCreateDbTbl.UseVisualStyleBackColor = true;
            this.btnCreateDbTbl.Click += new System.EventHandler(this.btnCreateDbTbl_Click);
            // 
            // btn1SplitPEfFileProcess
            // 
            this.btn1SplitPEfFileProcess.Location = new System.Drawing.Point(149, 109);
            this.btn1SplitPEfFileProcess.Name = "btn1SplitPEfFileProcess";
            this.btn1SplitPEfFileProcess.Size = new System.Drawing.Size(139, 66);
            this.btn1SplitPEfFileProcess.TabIndex = 6;
            this.btn1SplitPEfFileProcess.Text = "Process 1-Split PEF File";
            this.btn1SplitPEfFileProcess.UseVisualStyleBackColor = true;
            this.btn1SplitPEfFileProcess.Click += new System.EventHandler(this.btn1SplitPEfFileProcess_Click);
            // 
            // btn_Process_repeatgrp
            // 
            this.btn_Process_repeatgrp.Location = new System.Drawing.Point(318, 109);
            this.btn_Process_repeatgrp.Name = "btn_Process_repeatgrp";
            this.btn_Process_repeatgrp.Size = new System.Drawing.Size(135, 66);
            this.btn_Process_repeatgrp.TabIndex = 7;
            this.btn_Process_repeatgrp.Text = "Prcoess Repeat Group 1-file";
            this.btn_Process_repeatgrp.UseVisualStyleBackColor = true;
            this.btn_Process_repeatgrp.Click += new System.EventHandler(this.btn_Process_repeatgrp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 689);
            this.Controls.Add(this.btn_Process_repeatgrp);
            this.Controls.Add(this.btn1SplitPEfFileProcess);
            this.Controls.Add(this.btnCreateDbTbl);
            this.Controls.Add(this.btnProcessAllfiles);
            this.Controls.Add(this.btnSplitFile);
            this.Controls.Add(this.rtb_Status);
            this.Controls.Add(this.btnProcessPEFtoDB);
            this.Controls.Add(this.btnCountLines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountLines;
        private System.Windows.Forms.Button btnProcessPEFtoDB;
        private System.Windows.Forms.RichTextBox rtb_Status;
        private System.Windows.Forms.Button btnSplitFile;
        private System.Windows.Forms.Button btnProcessAllfiles;
        private System.Windows.Forms.Button btnCreateDbTbl;
        private System.Windows.Forms.Button btn1SplitPEfFileProcess;
        private System.Windows.Forms.Button btn_Process_repeatgrp;
    }
}

