namespace The_Hat
{
    partial class EditList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditList));
            this.lst_names = new System.Windows.Forms.ListBox();
            this.txt_addname = new System.Windows.Forms.TextBox();
            this.btn_addname = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.listTitlesTableAdapter = new TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_names
            // 
            this.lst_names.FormattingEnabled = true;
            this.lst_names.Location = new System.Drawing.Point(12, 12);
            this.lst_names.Name = "lst_names";
            this.lst_names.Size = new System.Drawing.Size(260, 173);
            this.lst_names.TabIndex = 0;
            // 
            // txt_addname
            // 
            this.txt_addname.Location = new System.Drawing.Point(12, 200);
            this.txt_addname.Name = "txt_addname";
            this.txt_addname.Size = new System.Drawing.Size(173, 20);
            this.txt_addname.TabIndex = 1;
            // 
            // btn_addname
            // 
            this.btn_addname.Location = new System.Drawing.Point(191, 198);
            this.btn_addname.Name = "btn_addname";
            this.btn_addname.Size = new System.Drawing.Size(81, 23);
            this.btn_addname.TabIndex = 2;
            this.btn_addname.Text = "Add Name";
            this.btn_addname.UseVisualStyleBackColor = true;
            this.btn_addname.Click += new System.EventHandler(this.btn_addname_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 226);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete Name";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(99, 226);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Names";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(191, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save Names";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listTitlesTableAdapter
            // 
            this.listTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // EditList
            // 
            this.AcceptButton = this.btn_addname;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_addname);
            this.Controls.Add(this.txt_addname);
            this.Controls.Add(this.lst_names);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hat";
            this.Load += new System.EventHandler(this.EditList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_addname;
        private System.Windows.Forms.Button btn_addname;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.ListBox lst_names;
        private TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter listTitlesTableAdapter;
    }
}