using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace The_Hat
{
    public partial class DrawList : Form
    {
        public List<String> Items;
        private List<String> ShuffledItems;

        public DrawList()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            lbl_name.Location = new Point(12, 200);
            lbl_name.Text = ShuffledItems.Last();
            ShuffledItems.Remove(ShuffledItems.Last());
            btn_draw.Enabled = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_name.Location = new Point(lbl_name.Location.X, lbl_name.Location.Y - 3);
            if (lbl_name.Location.Y <= 50)
            {
                timer.Stop();
                if (ShuffledItems.Count > 0)
                {
                    btn_draw.Enabled = true;
                }
                lst_names.Items.Add(lbl_name.Text);
            }
        }

        private void DrawList_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ShuffledItems = Items.Select(x => new { value = x, order = rnd.Next() }).OrderBy(x => x.order).Select(x => x.value).ToList();
            btn_draw.Enabled = true;
        }
    }
}
