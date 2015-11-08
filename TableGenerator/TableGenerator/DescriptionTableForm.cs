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
    public partial class DescriptionTableForm : Form
    {
        public DescriptionTableForm()
        {
            InitializeComponent();
            this.DescriptionTable.AutoGenerateColumns = false;
            FieldsInfoList fieldsInfoList = new FieldsInfoList();
            DescriptionTable.DataSource = fieldsInfoList;
            FIELD_NAME.DataPropertyName = "Name";
            FIELD_CAP.DataPropertyName = "HeaderText";
            FIELD_TYPE.DataPropertyName = "DefaultCellStyle.Format";
            FIELD_LEN.DataPropertyName = "MaxInputLength";
            FIELD_DEC.DataPropertyName = "DefaultCellStyle.Format";

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Date";
            column.HeaderText = "Дата";
            column.DefaultCellStyle.Format = "D";
            fieldsInfoList.Add(column);

            GeneratedTableForm form = new GeneratedTableForm(fieldsInfoList);
            form.Show();
        }

        private void DescriptionTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((DescriptionTable.Columns[e.ColumnIndex].DataPropertyName != "") && (DescriptionTable.Rows[e.RowIndex].DataBoundItem != null))
                {
                    string propName = DescriptionTable.Columns[e.ColumnIndex].DataPropertyName;
                    object propVal = DescriptionTable.Rows[e.RowIndex].DataBoundItem;

                    if (propName.Contains('.'))
                        while (propName.Contains('.') && propVal != null)
                        {
                            propVal = propVal.GetType().GetProperty(propName.Substring(0, propName.IndexOf('.'))).GetValue(propVal, null);
                            propName = propName.Substring(propName.IndexOf('.') + 1);
                        }
                    string val = propVal.GetType().GetProperty(propName).GetValue(propVal, null).ToString();
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            if (val != "")
                                e.Value = val.Substring(0, 1);
                            break;
                        case 4:
                            if (val.Length > 1)
                                e.Value = val.Substring(1, val.Length-1);
                            break;
                        default:
                            e.Value = val;
                            break;
                    }
                }
        }
        private void DescriptionTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((DescriptionTable.Columns[e.ColumnIndex].DataPropertyName != "") && (DescriptionTable.Rows[e.RowIndex].DataBoundItem != null))
                {
                    string propName = DescriptionTable.Columns[e.ColumnIndex].DataPropertyName;
                    object propVal = DescriptionTable.Rows[e.RowIndex].DataBoundItem;

                    if (propName.Contains('.'))
                        while (propName.Contains('.') && propVal != null)
                        {
                            propVal = propVal.GetType().GetProperty(propName.Substring(0, propName.IndexOf('.'))).GetValue(propVal, null);
                            propName = propName.Substring(propName.IndexOf('.') + 1);
                        }
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            propVal.GetType().GetProperty(propName).SetValue(propVal, DescriptionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, null);
                            break;
                        case 4:
                            propVal.GetType().GetProperty(propName).SetValue(propVal, DescriptionTable.Rows[e.RowIndex].Cells[2].Value.ToString() + DescriptionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), null);
                            break;
                        default:
                            propVal.GetType().GetProperty(propName).SetValue(propVal, DescriptionTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, null);
                            break;
                    }
                }

        }
    }
}
