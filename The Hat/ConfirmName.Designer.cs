namespace The_Hat
{
    partial class ConfirmName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmName));
            this.txt_listtitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.listItemsTableAdapter = new TheHat.SavedListsDataSetTableAdapters.ListItemsTableAdapter();
            this.listTitlesTableAdapter = new TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter();
            this.SuspendLayout();
            // 
            // txt_listtitle
            // 
            this.txt_listtitle.Location = new System.Drawing.Point(12, 28);
            this.txt_listtitle.Name = "txt_listtitle";
            this.txt_listtitle.Size = new System.Drawing.Size(152, 20);
            this.txt_listtitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a name for the list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(170, 25);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // listItemsTableAdapter
            // 
            this.listItemsTableAdapter.ClearBeforeFill = true;
            // 
            // listTitlesTableAdapter
            // 
            this.listTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // ConfirmName
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 60);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_listtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hat";
            this.Load += new System.EventHandler(this.ConfirmName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirm;
        private TheHat.SavedListsDataSetTableAdapters.ListItemsTableAdapter listItemsTableAdapter;
        private TheHat.SavedListsDataSetTableAdapters.ListTitlesTableAdapter listTitlesTableAdapter;
        public System.Windows.Forms.TextBox txt_listtitle;
    }
}