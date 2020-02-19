namespace DefaultDesktopMessageBoxIssue
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
            this.desktopMsgBoxBtn = new System.Windows.Forms.Button();
            this.standardMsgBoxBtn = new System.Windows.Forms.Button();
            this.enumerateFilesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.msgBoxResultTbx = new System.Windows.Forms.TextBox();
            this.toListBtn = new System.Windows.Forms.Button();
            this.demoFolderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.selectedFolderTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // desktopMsgBoxBtn
            // 
            this.desktopMsgBoxBtn.Location = new System.Drawing.Point(104, 110);
            this.desktopMsgBoxBtn.Margin = new System.Windows.Forms.Padding(2);
            this.desktopMsgBoxBtn.Name = "desktopMsgBoxBtn";
            this.desktopMsgBoxBtn.Size = new System.Drawing.Size(96, 41);
            this.desktopMsgBoxBtn.TabIndex = 0;
            this.desktopMsgBoxBtn.Text = "MessageBox Desktop Only";
            this.desktopMsgBoxBtn.UseVisualStyleBackColor = true;
            this.desktopMsgBoxBtn.Click += new System.EventHandler(this.desktopMsgBoxBtn_Click);
            // 
            // standardMsgBoxBtn
            // 
            this.standardMsgBoxBtn.Location = new System.Drawing.Point(220, 112);
            this.standardMsgBoxBtn.Margin = new System.Windows.Forms.Padding(2);
            this.standardMsgBoxBtn.Name = "standardMsgBoxBtn";
            this.standardMsgBoxBtn.Size = new System.Drawing.Size(93, 39);
            this.standardMsgBoxBtn.TabIndex = 1;
            this.standardMsgBoxBtn.Text = "MessageBox standard";
            this.standardMsgBoxBtn.UseVisualStyleBackColor = true;
            this.standardMsgBoxBtn.Click += new System.EventHandler(this.standardMsgBoxBtn_Click);
            // 
            // enumerateFilesBtn
            // 
            this.enumerateFilesBtn.Location = new System.Drawing.Point(104, 70);
            this.enumerateFilesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enumerateFilesBtn.Name = "enumerateFilesBtn";
            this.enumerateFilesBtn.Size = new System.Drawing.Size(96, 36);
            this.enumerateFilesBtn.TabIndex = 2;
            this.enumerateFilesBtn.Text = "Enumerate files";
            this.enumerateFilesBtn.UseVisualStyleBackColor = true;
            this.enumerateFilesBtn.Click += new System.EventHandler(this.enumerateFilesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MessageBox result:";
            // 
            // msgBoxResultTbx
            // 
            this.msgBoxResultTbx.Location = new System.Drawing.Point(115, 37);
            this.msgBoxResultTbx.Margin = new System.Windows.Forms.Padding(2);
            this.msgBoxResultTbx.Name = "msgBoxResultTbx";
            this.msgBoxResultTbx.ReadOnly = true;
            this.msgBoxResultTbx.Size = new System.Drawing.Size(149, 20);
            this.msgBoxResultTbx.TabIndex = 4;
            // 
            // toListBtn
            // 
            this.toListBtn.Location = new System.Drawing.Point(220, 70);
            this.toListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toListBtn.Name = "toListBtn";
            this.toListBtn.Size = new System.Drawing.Size(93, 36);
            this.toListBtn.TabIndex = 5;
            this.toListBtn.Text = "To List";
            this.toListBtn.UseVisualStyleBackColor = true;
            this.toListBtn.Click += new System.EventHandler(this.toListBtn_Click);
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(269, 12);
            this.browseFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(25, 20);
            this.browseFileBtn.TabIndex = 6;
            this.browseFileBtn.Text = "...";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // selectedFolderTbx
            // 
            this.selectedFolderTbx.Location = new System.Drawing.Point(115, 12);
            this.selectedFolderTbx.Name = "selectedFolderTbx";
            this.selectedFolderTbx.Size = new System.Drawing.Size(149, 20);
            this.selectedFolderTbx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedFolderTbx);
            this.Controls.Add(this.browseFileBtn);
            this.Controls.Add(this.toListBtn);
            this.Controls.Add(this.msgBoxResultTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enumerateFilesBtn);
            this.Controls.Add(this.standardMsgBoxBtn);
            this.Controls.Add(this.desktopMsgBoxBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button desktopMsgBoxBtn;
        private System.Windows.Forms.Button standardMsgBoxBtn;
        private System.Windows.Forms.Button enumerateFilesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgBoxResultTbx;
        private System.Windows.Forms.Button toListBtn;
        private System.Windows.Forms.FolderBrowserDialog demoFolderBrowserDlg;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.TextBox selectedFolderTbx;
        private System.Windows.Forms.Label label2;
    }
}

