namespace The_Hat
{
    partial class ChooseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseList));
            this.lst_lists = new System.Windows.Forms.ListBox();
            this.btn_newlist = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_editlist = new System.Windows.Forms.Button();
            this.btn_deletelist = new System.Windows.Forms.Button();
            this.btn_renamelist = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.listTitlesTableAdapter = new TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter();
            this.listItemsTableAdapter = new TheHat.SavedListsDataSetTableAdapters.ListItemsTableAdapter();
            this.SuspendLayout();
            // 
            // lst_lists
            // 
            this.lst_lists.FormattingEnabled = true;
            this.lst_lists.Location = new System.Drawing.Point(13, 13);
            this.lst_lists.Name = "lst_lists";
            this.lst_lists.Size = new System.Drawing.Size(217, 95);
            this.lst_lists.TabIndex = 0;
            // 
            // btn_newlist
            // 
            this.btn_newlist.Location = new System.Drawing.Point(12, 144);
            this.btn_newlist.Name = "btn_newlist";
            this.btn_newlist.Size = new System.Drawing.Size(106, 23);
            this.btn_newlist.TabIndex = 1;
            this.btn_newlist.Text = "New List";
            this.btn_newlist.UseVisualStyleBackColor = true;
            this.btn_newlist.Click += new System.EventHandler(this.btn_newlist_Click);
            // 
            // btn_select
            // 
            this.btn_select.Enabled = false;
            this.btn_select.Location = new System.Drawing.Point(13, 114);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(217, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select List";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_editlist
            // 
            this.btn_editlist.Enabled = false;
            this.btn_editlist.Location = new System.Drawing.Point(124, 144);
            this.btn_editlist.Name = "btn_editlist";
            this.btn_editlist.Size = new System.Drawing.Size(106, 23);
            this.btn_editlist.TabIndex = 3;
            this.btn_editlist.Text = "Edit List";
            this.btn_editlist.UseVisualStyleBackColor = true;
            this.btn_editlist.Click += new System.EventHandler(this.btn_editlist_Click);
            // 
            // btn_deletelist
            // 
            this.btn_deletelist.Enabled = false;
            this.btn_deletelist.Location = new System.Drawing.Point(124, 173);
            this.btn_deletelist.Name = "btn_deletelist";
            this.btn_deletelist.Size = new System.Drawing.Size(106, 23);
            this.btn_deletelist.TabIndex = 5;
            this.btn_deletelist.Text = "Delete List";
            this.btn_deletelist.UseVisualStyleBackColor = true;
            this.btn_deletelist.Click += new System.EventHandler(this.btn_deletelist_Click);
            // 
            // btn_renamelist
            // 
            this.btn_renamelist.Enabled = false;
            this.btn_renamelist.Location = new System.Drawing.Point(12, 173);
            this.btn_renamelist.Name = "btn_renamelist";
            this.btn_renamelist.Size = new System.Drawing.Size(106, 23);
            this.btn_renamelist.TabIndex = 4;
            this.btn_renamelist.Text = "Rename List";
            this.btn_renamelist.UseVisualStyleBackColor = true;
            this.btn_renamelist.Click += new System.EventHandler(this.btn_renamelist_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(124, 202);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(12, 202);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(106, 23);
            this.btn_about.TabIndex = 6;
            this.btn_about.Text = "About The Hat";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // listTitlesTableAdapter
            // 
            this.listTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // listItemsTableAdapter
            // 
            this.listItemsTableAdapter.ClearBeforeFill = true;
            // 
            // ChooseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 239);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_deletelist);
            this.Controls.Add(this.btn_renamelist);
            this.Controls.Add(this.btn_editlist);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_newlist);
            this.Controls.Add(this.lst_lists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChooseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_lists;
        private TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter listTitlesTableAdapter;
        private System.Windows.Forms.Button btn_newlist;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_editlist;
        private System.Windows.Forms.Button btn_deletelist;
        private System.Windows.Forms.Button btn_renamelist;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_about;
        private TheHat.SavedListsDataSetTableAdapters.ListItemsTableAdapter listItemsTableAdapter;
    }
}

