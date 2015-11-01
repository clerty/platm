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
            this.descriptionTable.AutoGenerateColumns = false;
            BindingList<FieldInfo> s = new BindingList<FieldInfo>();

            /*FieldInfo f = new FieldInfo();
            f.Name = "f";
            f.Caption = "ф";
            f.Type = 'c';
            f.Length = 2;
            f.Decimals = 0;
            s.Add(f);*/

            descriptionTable.DataSource = s;
            FIELD_NAME.DataPropertyName = "Name";
            FIELD_CAP.DataPropertyName = "Caption";
            FIELD_TYPE.DataPropertyName = "Type";
            FIELD_LEN.DataPropertyName = "Length";
            FIELD_DEC.DataPropertyName = "Decimals";

            //descriptionTable.DataBindings.Add()
        }
    }
}
