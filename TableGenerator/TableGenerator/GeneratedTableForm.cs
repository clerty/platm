using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableGenerator
{
    public partial class GeneratedTableForm : Form
    {
        public GeneratedTableForm()
        {
            InitializeComponent();
            cFieldsInfo.Info.ListChanged += new ListChangedEventHandler(OnChange);
        }

        public void OnChange(object sender, ListChangedEventArgs e)
        {
                GeneratedTable.Columns.Clear();
            List<DataGridViewTextBoxColumn> d = new List<DataGridViewTextBoxColumn>(cFieldsInfo.Info);
            GeneratedTable.Columns.AddRange(d.ToArray());
        }
    }
}
