﻿namespace TableGenerator
{
    partial class GeneratedTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneratedTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratedTable
            // 
            this.GeneratedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GeneratedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneratedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedTable.Location = new System.Drawing.Point(0, 0);
            this.GeneratedTable.Name = "GeneratedTable";
            this.GeneratedTable.Size = new System.Drawing.Size(577, 161);
            this.GeneratedTable.TabIndex = 0;
            this.GeneratedTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GeneratedTable_CellFormatting);
            // 
            // GeneratedTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 161);
            this.Controls.Add(this.GeneratedTable);
            this.Name = "GeneratedTableForm";
            this.Text = "Генерируемая таблица";
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GeneratedTable;
    }
}