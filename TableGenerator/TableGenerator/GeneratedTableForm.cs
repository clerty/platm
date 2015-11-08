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
        FieldsInfoList FieldsInfoBindingList = new FieldsInfoList();
        public GeneratedTableForm(FieldsInfoList FieldsInfoBindingList)
        {
            InitializeComponent();
            this.FieldsInfoBindingList = FieldsInfoBindingList;
            List<DataGridViewTextBoxColumn> fieldsInfoList = new List<DataGridViewTextBoxColumn>(this.FieldsInfoBindingList);
            GeneratedTable.Columns.AddRange(fieldsInfoList.ToArray());
            this.FieldsInfoBindingList.ListChanged += new ListChangedEventHandler(OnFieldsInfoListChange);

            GeneratedTable.Rows.Add();
            GeneratedTable.Rows[0].Cells[0].Value = DateTime.Now;
        }

        public void OnFieldsInfoListChange(object sender, ListChangedEventArgs e)
        {
                GeneratedTable.Columns.Clear();
                List<DataGridViewTextBoxColumn> fieldsInfoList = new List<DataGridViewTextBoxColumn>(this.FieldsInfoBindingList);
                GeneratedTable.Columns.AddRange(fieldsInfoList.ToArray());
        }

        private void GeneratedTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle.Format != "")
                switch (e.CellStyle.Format.Substring(0, 1))
                {
                    case "N":
                        GeneratedTable.Columns[e.ColumnIndex].ValueType = typeof(decimal);
                        break;
                    case "D":
                        GeneratedTable.Columns[e.ColumnIndex].ValueType = typeof(DateTime);
                        break;
                    case "C":
                    default:
                        break;
                }
        }
    }
}
