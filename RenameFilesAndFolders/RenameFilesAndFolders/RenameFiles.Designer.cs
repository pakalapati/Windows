namespace RenameFilesAndFolders
{
    partial class RenameFiles
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
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblReplaceText = new System.Windows.Forms.Label();
            this.fbDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplaceCharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(42, 21);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 0;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(510, 92);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(124, 53);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(461, 23);
            this.txtReplace.TabIndex = 3;
            // 
            // lblReplaceText
            // 
            this.lblReplaceText.AutoSize = true;
            this.lblReplaceText.Location = new System.Drawing.Point(42, 56);
            this.lblReplaceText.Name = "lblReplaceText";
            this.lblReplaceText.Size = new System.Drawing.Size(75, 15);
            this.lblReplaceText.TabIndex = 4;
            this.lblReplaceText.Text = "Replace Text:";
            // 
            // txtSelectedFolder
            // 
            this.txtSelectedFolder.Location = new System.Drawing.Point(124, 21);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.ReadOnly = true;
            this.txtSelectedFolder.Size = new System.Drawing.Size(461, 23);
            this.txtSelectedFolder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Replace Character:";
            // 
            // txtReplaceCharacter
            // 
            this.txtReplaceCharacter.Location = new System.Drawing.Point(124, 89);
            this.txtReplaceCharacter.Name = "txtReplaceCharacter";
            this.txtReplaceCharacter.Size = new System.Drawing.Size(100, 23);
            this.txtReplaceCharacter.TabIndex = 7;
            // 
            // RenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 153);
            this.Controls.Add(this.txtReplaceCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelectedFolder);
            this.Controls.Add(this.lblReplaceText);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnOpenFolder);
            this.Name = "RenameFiles";
            this.Text = "Rename Files And Folders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenFolder;
        private Button btnRename;
        private TextBox txtReplace;
        private Label lblReplaceText;
        private FolderBrowserDialog fbDialogue;
        private TextBox txtSelectedFolder;
        private Label label1;
        private TextBox txtReplaceCharacter;
    }
}