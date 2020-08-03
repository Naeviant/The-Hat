using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace The_Hat
{
    public partial class ChooseList : Form
    {
        public ChooseList()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            lst_lists.Items.Clear();
            var Items = listTitlesTableAdapter.GetAll();
            for (int x = 0; x < Items.Count; x++)
            {
                lst_lists.Items.Add(Items.ElementAt(x).ListTitle);
            }

            if (lst_lists.Items.Count == 0)
            {
                btn_editlist.Enabled = false;
                btn_renamelist.Enabled = false;
                btn_deletelist.Enabled = false;
                btn_select.Enabled = false;
            }
            else
            {
                lst_lists.SetSelected(0, true);
                btn_editlist.Enabled = true;
                btn_renamelist.Enabled = true;
                btn_deletelist.Enabled = true;
                btn_select.Enabled = true;
            }
        }

        private void btn_newlist_Click(object sender, EventArgs e)
        {
            var NewForm = new EditList();
            NewForm.Instance = this;
            NewForm.ShowDialog();
        }

        private void btn_editlist_Click(object sender, EventArgs e)
        {
            var SelectedList = lst_lists.SelectedItem.ToString();
            var ID = listTitlesTableAdapter.GetIDByTitle(SelectedList).ToString();
            var NewForm = new EditList();
            var Items = listItemsTableAdapter.GetItemsByID(ID);
            for (int x = 0; x < Items.Count; x++)
            {
                NewForm.lst_names.Items.Add(Items.ElementAt(x).Item);
            }
            NewForm.ListName = lst_lists.SelectedItem.ToString();
            NewForm.Instance = this;
            NewForm.ShowDialog();
        }

        private void btn_renamelist_Click(object sender, EventArgs e)
        {
            var SelectedList = lst_lists.SelectedItem.ToString();
            var ID = listTitlesTableAdapter.GetIDByTitle(SelectedList).ToString();
            var NewForm = new Rename();
            NewForm.ID = ID;
            NewForm.ListName = SelectedList;
            NewForm.Instance = this;
            NewForm.ShowDialog();
        }

        private void btn_deletelist_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this list?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var SelectedList = lst_lists.SelectedItem.ToString();
                Int32 ID = (Int32)listTitlesTableAdapter.GetIDByTitle(SelectedList);
                listTitlesTableAdapter.DeleteByID(ID);
                listItemsTableAdapter.DeleteByID(ID.ToString());
                Form1_Load(sender, e);
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var NewForm = new About();
            NewForm.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            var SelectedList = lst_lists.SelectedItem.ToString();
            var ID = listTitlesTableAdapter.GetIDByTitle(SelectedList).ToString();
            var Items = listItemsTableAdapter.GetItemsByID(ID);
            var NewForm = new DrawList();
            var ListItems = new List<String>();
            for (int x = 0; x < Items.Count; x++)
            {
                ListItems.Add(Items.ElementAt(x).Item);
            }
            NewForm.Items = ListItems;
            NewForm.ShowDialog();
        }
    }
}
