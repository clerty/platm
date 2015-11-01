﻿namespace TableGenerator
{
    partial class DescriptionTableForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.descriptionTable = new System.Windows.Forms.DataGridView();
            this.FIELD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIELD_CAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIELD_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIELD_LEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIELD_DEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.descriptionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descriptionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIELD_NAME,
            this.FIELD_CAP,
            this.FIELD_TYPE,
            this.FIELD_LEN,
            this.FIELD_DEC});
            this.descriptionTable.Location = new System.Drawing.Point(12, 12);
            this.descriptionTable.Name = "descriptionTable";
            this.descriptionTable.Size = new System.Drawing.Size(627, 150);
            this.descriptionTable.TabIndex = 0;
            // 
            // FIELD_NAME
            // 
            this.FIELD_NAME.HeaderText = "Имя поля";
            this.FIELD_NAME.MaxInputLength = 10;
            this.FIELD_NAME.Name = "FIELD_NAME";
            // 
            // FIELD_CAP
            // 
            this.FIELD_CAP.HeaderText = "Русифицированное имя";
            this.FIELD_CAP.MaxInputLength = 30;
            this.FIELD_CAP.Name = "FIELD_CAP";
            // 
            // FIELD_TYPE
            // 
            this.FIELD_TYPE.HeaderText = "Тип поля";
            this.FIELD_TYPE.MaxInputLength = 1;
            this.FIELD_TYPE.Name = "FIELD_TYPE";
            // 
            // FIELD_LEN
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.FIELD_LEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.FIELD_LEN.HeaderText = "Длина поля";
            this.FIELD_LEN.MaxInputLength = 3;
            this.FIELD_LEN.Name = "FIELD_LEN";
            // 
            // FIELD_DEC
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.FIELD_DEC.DefaultCellStyle = dataGridViewCellStyle3;
            this.FIELD_DEC.HeaderText = "Количество цифр после запятой для типа N";
            this.FIELD_DEC.MaxInputLength = 3;
            this.FIELD_DEC.Name = "FIELD_DEC";
            // 
            // DescriptionTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.descriptionTable);
            this.Name = "DescriptionTableForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView descriptionTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD_CAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD_LEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD_DEC;
    }
}

