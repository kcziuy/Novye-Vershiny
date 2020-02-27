namespace NovyeVershiny2._0
{
    partial class ResultF1NE
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
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.Tour1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTable
            // 
            this.ResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tour1,
            this.Tour2,
            this.Tour3,
            this.Tour4,
            this.Tour5,
            this.Tour6,
            this.Tour7,
            this.Tour8,
            this.Tour9});
            this.ResultTable.Location = new System.Drawing.Point(12, 0);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowTemplate.Height = 24;
            this.ResultTable.Size = new System.Drawing.Size(751, 150);
            this.ResultTable.TabIndex = 0;
            this.ResultTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultTable_CellContentClick);
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
            this.Tour2.Frozen = true;
            this.Tour2.HeaderText = "Тур 2";
            this.Tour2.Name = "Tour2";
            this.Tour2.Width = 73;
            // 
            // Tour3
            // 
            this.Tour3.Frozen = true;
            this.Tour3.HeaderText = "Тур 3";
            this.Tour3.Name = "Tour3";
            this.Tour3.Width = 73;
            // 
            // Tour4
            // 
            this.Tour4.Frozen = true;
            this.Tour4.HeaderText = "Тур 4";
            this.Tour4.Name = "Tour4";
            this.Tour4.Width = 73;
            // 
            // Tour5
            // 
            this.Tour5.Frozen = true;
            this.Tour5.HeaderText = "Тур 5";
            this.Tour5.Name = "Tour5";
            this.Tour5.Width = 73;
            // 
            // Tour6
            // 
            this.Tour6.Frozen = true;
            this.Tour6.HeaderText = "Тур 6";
            this.Tour6.Name = "Tour6";
            this.Tour6.Width = 73;
            // 
            // Tour7
            // 
            this.Tour7.Frozen = true;
            this.Tour7.HeaderText = "Тур 7";
            this.Tour7.Name = "Tour7";
            this.Tour7.Width = 73;
            // 
            // Tour8
            // 
            this.Tour8.Frozen = true;
            this.Tour8.HeaderText = "Тур 8";
            this.Tour8.Name = "Tour8";
            this.Tour8.Width = 73;
            // 
            // Tour9
            // 
            this.Tour9.Frozen = true;
            this.Tour9.HeaderText = "Тур 9";
            this.Tour9.Name = "Tour9";
            this.Tour9.Width = 73;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(384, 156);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(164, 25);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(216, 156);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(162, 25);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ResultF1NE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 191);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.ResultTable);
            this.Name = "ResultF1NE";
            this.Text = "ResultF1NE";
            this.Load += new System.EventHandler(this.ResultF1NE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour9;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}