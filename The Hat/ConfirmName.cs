using System;
using System.Windows.Forms;

namespace The_Hat
{
    public partial class ConfirmName : Form
    {
        public ListBox.ObjectCollection Items;
        public ChooseList Instance;

        public ConfirmName()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            String ListTitle = txt_listtitle.Text;
            Int32 Count = (Int32) listTitlesTableAdapter.CountTitles(ListTitle);
            Int32 ItemCount = Items.Count;

            if (ItemCount > 0 && ListTitle != "")
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                String ID;
                if (Count == 0)
                {
                    listTitlesTableAdapter.Add(ListTitle);
                    ID = listTitlesTableAdapter.GetIDByTitle(ListTitle).ToString();
                }
                else
                {
                    ID = listTitlesTableAdapter.GetIDByTitle(ListTitle).ToString();
                    listItemsTableAdapter.DeleteByID(ID);
                }
                for (int x = 0; x < Items.Count; x++)
                {
                    listItemsTableAdapter.Add(ID, Items[x].ToString());
                }
                Application.OpenForms["EditList"].Close();
                this.Close();
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                Instance.Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please provide a list title and some list items.", "Cannot Save List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConfirmName_Load(object sender, EventArgs e)
        {
            if (txt_listtitle.Text != "")
            {
                btn_confirm.PerformClick();
            }
        }
    }
}
