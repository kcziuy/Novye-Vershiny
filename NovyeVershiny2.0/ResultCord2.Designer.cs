namespace NovyeVershiny2._0
{
    partial class ResultCord2
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
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.Tour1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(257, 77);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(164, 25);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(89, 77);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(162, 25);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ResultTable
            // 
            this.ResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ResultTable.BackgroundColor = System.Drawing.Color.White;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tour1,
            this.Tour2});
            this.ResultTable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ResultTable.Location = new System.Drawing.Point(12, 12);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowTemplate.Height = 24;
            this.ResultTable.Size = new System.Drawing.Size(466, 59);
            this.ResultTable.TabIndex = 22;
            // 
            // Tour1
            // 
            this.Tour1.Frozen = true;
            this.Tour1.HeaderText = "Тур 1";
            this.Tour1.Name = "Tour1";
            this.Tour1.Width = 73;
            // 
            // Tour2
            // 
            this.Tour2.HeaderText = "Тур2";
            this.Tour2.Name = "Tour2";
            this.Tour2.Width = 69;
            // 
            // ResultCord2_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 115);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.ResultTable);
            this.Name = "ResultCord2_cs";
            this.Text = "ResultCord2_cs";
            this.Load += new System.EventHandler(this.ResultCord2_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour2;
    }
}