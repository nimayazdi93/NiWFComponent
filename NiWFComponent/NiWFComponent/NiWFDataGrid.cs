using NiWFComponent.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiWFComponent
{

    public partial class NiWFDataGrid : UserControl
    {
        public NiWFDataGrid() : base()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            DataGrid.ForeColor = Color.Black;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Dock = DockStyle.Fill;
        }

        List<string> Columns = new List<string>();

        private object dataSource = null;
        public object DataSource
        {
            get
            {
                return dataSource;
            }
            set
            {
                dataSource = value;
                DataGrid.DataSource = value;
            foreach(var column in DataGrid.Columns)
                {
                    var col = column as DataGridViewColumn;
                    Columns.Add(col.HeaderText);
                }
            }
        }
        public List<object>? DataList
        {
            get => dataSource as List<object>;
            set => dataSource = value;
        }
        private Font font = null;
        public Font Font
        {
            get { return font; }
            set { font = value; DataGrid.Font = value; }
        }

        private List<Tuple<int, int, List<ItemSelect>>> Filters = new List<Tuple<int, int, List<ItemSelect>>>();

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var forcheck = new List<string>();
            forcheck = DataList.Select(c => c.GetValue(e.ColumnIndex).ToString()).Distinct().ToList();
            var prevfilter = Filters.FirstOrDefault(c => c.Item1 == e.ColumnIndex);
            var ItemSelects = forcheck.Select(c => new ItemSelect()
            {
                Selected = prevfilter == null ?
                true
                :
                (prevfilter.Item3.Any(cc => cc.Item == c & cc.Selected)),
                Item = c
            }
            ).ToList();
            var a = new SortFilter(e.ColumnIndex, ItemSelects, true, this.Font);
            a.ShowDialog();

            var ToRemove = Filters.FirstOrDefault(c => c.Item1 == e.ColumnIndex);
            Filters.Remove(ToRemove);
            //if(ToRemove != null)
            //DataGrid.Columns[e.ColumnIndex].HeaderText = DataGrid.Columns[e.ColumnIndex].HeaderText.Replace("", "↑").Replace("", "↓").Replace("", "🝖") + (ToRemove.Item2 == 1 ? "↑" : (ToRemove.Item2 == -1 ? "↓" : "🝖"));
            if (!a.Cleared)
            {
                ItemSelects = ItemSelects.Select(c => new ItemSelect() { Item = c.Item, Selected = a.Selected.Any(cc => cc.Item == c.Item) }).ToList();
                Filters.Add(new Tuple<int, int, List<ItemSelect>>(e.ColumnIndex, a.Sort, ItemSelects));
            }

            ProcessFilters();

            for (int i = 0; i < DataGrid.Columns.Count; i++)
            {
                var thisfilter = Filters.FirstOrDefault(c => c.Item1 == i);
                DataGrid.EnableHeadersVisualStyles = false;

                DataGrid.Columns[i].HeaderCell.Style.ForeColor = thisfilter != null ? Color.Blue : Color.Black;
                if (thisfilter != null)
                {

                    DataGrid.Columns[i].HeaderText = DataGrid.Columns[i].HeaderText.Replace("↑", "").Replace("↓", "").Replace("🝖", "")
                        + (thisfilter.Item2 == 1 ? "↑" : (thisfilter.Item2 == -1 ? "↓" : "🝖"));
                }
                else
                {
                    DataGrid.Columns[i].HeaderText = DataGrid.Columns[i].HeaderText.Replace("↑", "").Replace("↓", "").Replace("🝖", "");
                }
            }
        }
        public void ProcessFilters()
        {
            var orderShowing = DataList;
            foreach (var filter in Filters)
            {
                orderShowing = orderShowing.Where(c => filter.Item3.Where(ccc => ccc.Selected).Any(cc => cc.Item == c.GetValue(filter.Item1).ToString())).ToList();
                switch (filter.Item2)
                {
                    case 1:
                        orderShowing = orderShowing.OrderBy(c => c.GetValue(filter.Item1)).ToList();
                        break;
                    case -1:
                        orderShowing = orderShowing.OrderByDescending(c => c.GetValue(filter.Item1)).ToList();
                        break;
                    default:
                        break;
                }
            }

            DataGrid.DataSource = orderShowing==null?new List<object>():orderShowing;
            if (orderShowing.Count == 0)
            {
                DataGrid.Columns.Clear();
                Columns.ForEach(c =>
                {
                    DataGrid.Columns.Add(new DataGridViewColumn() { HeaderText=c});
                });
            }
        }




    }
}
