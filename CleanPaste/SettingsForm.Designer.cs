namespace CleanPaste
{
    partial class SettingsForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLineBreaks = new System.Windows.Forms.TextBox();
            this.chkAddLineBreaks = new System.Windows.Forms.CheckBox();
            this.chkConvertToHTML = new System.Windows.Forms.CheckBox();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.chkLineBreak = new System.Windows.Forms.CheckBox();
            this.chkTextFormat = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(187, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 38);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLineBreaks);
            this.groupBox1.Controls.Add(this.chkAddLineBreaks);
            this.groupBox1.Controls.Add(this.chkConvertToHTML);
            this.groupBox1.Controls.Add(this.chkUnicode);
            this.groupBox1.Controls.Add(this.chkLineBreak);
            this.groupBox1.Controls.Add(this.chkTextFormat);
            this.groupBox1.Location = new System.Drawing.Point(21, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtLineBreaks
            // 
            this.txtLineBreaks.Location = new System.Drawing.Point(147, 120);
            this.txtLineBreaks.Name = "txtLineBreaks";
            this.txtLineBreaks.Size = new System.Drawing.Size(35, 23);
            this.txtLineBreaks.TabIndex = 1;
            // 
            // chkAddLineBreaks
            // 
            this.chkAddLineBreaks.AutoSize = true;
            this.chkAddLineBreaks.Location = new System.Drawing.Point(7, 123);
            this.chkAddLineBreaks.Name = "chkAddLineBreaks";
            this.chkAddLineBreaks.Size = new System.Drawing.Size(134, 19);
            this.chkAddLineBreaks.TabIndex = 0;
            this.chkAddLineBreaks.Text = "Add line breaks after";
            this.chkAddLineBreaks.UseVisualStyleBackColor = true;
            this.chkAddLineBreaks.CheckedChanged += new System.EventHandler(this.chkAddLineBreaks_CheckedChanged);
            // 
            // chkConvertToHTML
            // 
            this.chkConvertToHTML.AutoSize = true;
            this.chkConvertToHTML.Location = new System.Drawing.Point(6, 98);
            this.chkConvertToHTML.Name = "chkConvertToHTML";
            this.chkConvertToHTML.Size = new System.Drawing.Size(115, 19);
            this.chkConvertToHTML.TabIndex = 0;
            this.chkConvertToHTML.Text = "Try extract HTML";
            this.chkConvertToHTML.UseVisualStyleBackColor = true;
            this.chkConvertToHTML.CheckedChanged += new System.EventHandler(this.chkConvertToHTML_CheckedChanged);
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Location = new System.Drawing.Point(6, 73);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(147, 19);
            this.chkUnicode.TabIndex = 0;
            this.chkUnicode.Text = "Remove Unicode chars";
            this.chkUnicode.UseVisualStyleBackColor = true;
            this.chkUnicode.CheckedChanged += new System.EventHandler(this.chkUnicode_CheckedChanged);
            // 
            // chkLineBreak
            // 
            this.chkLineBreak.AutoSize = true;
            this.chkLineBreak.Location = new System.Drawing.Point(6, 48);
            this.chkLineBreak.Name = "chkLineBreak";
            this.chkLineBreak.Size = new System.Drawing.Size(128, 19);
            this.chkLineBreak.TabIndex = 0;
            this.chkLineBreak.Text = "Remove line breaks";
            this.chkLineBreak.UseVisualStyleBackColor = true;
            this.chkLineBreak.CheckedChanged += new System.EventHandler(this.chkLineBreak_CheckedChanged);
            // 
            // chkTextFormat
            // 
            this.chkTextFormat.AutoSize = true;
            this.chkTextFormat.Location = new System.Drawing.Point(7, 23);
            this.chkTextFormat.Name = "chkTextFormat";
            this.chkTextFormat.Size = new System.Drawing.Size(152, 19);
            this.chkTextFormat.TabIndex = 0;
            this.chkTextFormat.Text = "Remove text formatting";
            this.chkTextFormat.UseVisualStyleBackColor = true;
            this.chkTextFormat.CheckedChanged += new System.EventHandler(this.chkTextFormat_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 38);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use Ctr+Shift+V to do a clean paste";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(21, 52);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(265, 19);
            this.chkAutoStart.TabIndex = 3;
            this.chkAutoStart.Text = "Automatically start CleanPaste with Windows";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 287);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "CleanPaste - Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.CheckBox chkLineBreak;
        private System.Windows.Forms.CheckBox chkTextFormat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkConvertToHTML;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.TextBox txtLineBreaks;
        private System.Windows.Forms.CheckBox chkAddLineBreaks;
    }
}

