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
            //GeneratedTableFieldsSource s = new GeneratedTableFieldsSource();
            this.DescriptionTable.AutoGenerateColumns = false;

            /*DataGridViewTextBoxColumn f = new DataGridViewTextBoxColumn();
            f.Name = "f";
            f.HeaderText = "ф";
            //f.Type = 'c';
            f.MaxInputLength = 2;
            //f.Decimals = 0;
            FieldInfo.s.Add(f);*/

            DescriptionTable.DataSource = cFieldsInfo.Info;
            FIELD_NAME.DataPropertyName = "Name";
            FIELD_CAP.DataPropertyName = "HeaderText";
            FIELD_TYPE.DataPropertyName = "DefaultCellStyle.Format";
            FIELD_LEN.DataPropertyName = "MaxInputLength";
            //FIELD_DEC.DataPropertyName = "DefaultCellStyle.Format";

            GeneratedTableForm form = new GeneratedTableForm();
            form.Show();

            //descriptionTable.DataBindings.Add()
        }
    }
}
