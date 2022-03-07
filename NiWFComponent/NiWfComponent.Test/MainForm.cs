using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiWfComponent.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var Tests=new List<object>()
            {
                new {@Name="Nima",@Family="Yazdi",@BirthDay=new DateTime(1993,10,27).Date, @Country="Iran"},
                new {@Name="Bill",@Family="Gates",@BirthDay=new DateTime(1959,10,28).Date, @Country="USA"},
                new {@Name="Elon",@Family="Musk",@BirthDay=new DateTime(1971,6,28).Date, @Country="South Africa"},
                new {@Name="Pavel",@Family="Durov",@BirthDay=new DateTime(1984,10,10).Date, @Country="Russia"}, 
            };
            NiWFDataGrid.DataSource = Tests;
        }
    }
}
