 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiWFComponent
{

    public partial class SortFilter : Form
    {

        public int Sort { get; set; } = 0;
        public string Search { get; set; }
        public List<ItemSelect> Selected { get; set; } = new List<ItemSelect>();
        public bool Cleared { get; set; } = false;
        public SortFilter(int ColumnIndex, List<ItemSelect> Data, bool Night, Font font)
        {
            InitializeComponent();
            Selected = Data.ToList();
            this.Font= font;
            dataGridView1.DataSource = Data.Distinct().ToList();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].HeaderText = "✔";
            dataGridView1.Columns[1].HeaderText = "";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FormBorderStyle = FormBorderStyle.None;
            tableLayoutPanel1.BackColor = Color.FromArgb(40, 40, 40);
            StartPosition = FormStartPosition.CenterParent;
            Padding = new Padding(3);
            BackColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("IRAN Sans",7);
        }

        PrivateFontCollection pfc = new PrivateFontCollection();
        string workingDirectory = Environment.CurrentDirectory;
      
        private void btnA2Z_Click(object sender, EventArgs e)
        {
            Sort = 1;
            Close();
        }

        private void btnZ2A_Click(object sender, EventArgs e)
        {
            Sort = -1;
            Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Search = txtSearch.Text;
            Selected.Clear();
            foreach (DataGridViewRow data in dataGridView1.Rows)
            {
                var a = (ItemSelect)data.DataBoundItem;
                if (a.Selected)
                    Selected.Add(a);
                //  Selected.FirstOrDefault(c => c.Item == a.Item).Selected = a.Selected;
            }
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search = txtSearch.Text;
            if (string.IsNullOrEmpty(Search))
            {
                dataGridView1.DataSource = Selected;
            }
            else
            {
                dataGridView1.DataSource = Selected.Where(c => c.Item.Contains(Search)).ToList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cleared = true;
            Close();
        }


    }

    //private void txtSearch_KeyDown(object sender, text e)
    //{
    //    Search = txtSearch.Text;
    //    if (string.IsNullOrEmpty(Search))
    //    {
    //        dataGridView1.DataSource = Selected;
    //    }
    //    else
    //    {
    //        dataGridView1.DataSource = Selected.Where(c => c.Item.Contains(Search)).ToList();
    //    }
    //}


}

