using System;
using System.Windows.Forms;

namespace The_Hat
{
    public partial class EditList : Form
    {
        public String ListName;
        public ChooseList Instance;

        public EditList()
        {
            InitializeComponent();
        }

        private void btn_addname_Click(object sender, EventArgs e)
        {
            String NewName;
            NewName = txt_addname.Text;
            if (NewName != "")
            {
                lst_names.Items.Add(NewName);
                txt_addname.Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String SelectedName;
            SelectedName = lst_names.Text;
            lst_names.Items.Remove(SelectedName);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_names.Items.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var NewForm = new ConfirmName();
            NewForm.Items = lst_names.Items;
            NewForm.txt_listtitle.Text = ListName;
            NewForm.Instance = Instance;
            NewForm.ShowDialog(); 
        }

        private void EditList_Load(object sender, EventArgs e)
        {
            
        }
    }
}
