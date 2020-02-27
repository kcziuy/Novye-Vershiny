namespace NovyeVershiny2._0
{
    partial class ELSlalom
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgEdit = new System.Windows.Forms.DataGridView();
            this.Победа = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btTourCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Sum,
            this.Out});
            this.dgView.Location = new System.Drawing.Point(12, 12);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(540, 426);
            this.dgView.TabIndex = 0;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Out
            // 
            this.Out.HeaderText = "Выбыл";
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            // 
            // dgEdit
            // 
            this.dgEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Победа,
            this.dataGridViewTextBoxColumn1,
            this.Save,
            this.id2,
            this.Win2});
            this.dgEdit.Location = new System.Drawing.Point(558, 51);
            this.dgEdit.Name = "dgEdit";
            this.dgEdit.ReadOnly = true;
            this.dgEdit.RowTemplate.Height = 24;
            this.dgEdit.Size = new System.Drawing.Size(788, 387);
            this.dgEdit.TabIndex = 1;
            this.dgEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEdit_CellContentClick);
            // 
            // Победа
            // 
            this.Победа.HeaderText = "Выиграл";
            this.Победа.Name = "Победа";
            this.Победа.ReadOnly = true;
            this.Победа.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Победа.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Save
            // 
            this.Save.HeaderText = "Сохранить";
            this.Save.Name = "Save";
            this.Save.ReadOnly = true;
            // 
            // id2
            // 
            this.id2.HeaderText = "id2";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            // 
            // Win2
            // 
            this.Win2.HeaderText = "Выиграл";
            this.Win2.Name = "Win2";
            this.Win2.ReadOnly = true;
            // 
            // btTourCreate
            // 
            this.btTourCreate.Location = new System.Drawing.Point(558, 12);
            this.btTourCreate.Name = "btTourCreate";
            this.btTourCreate.Size = new System.Drawing.Size(788, 33);
            this.btTourCreate.TabIndex = 2;
            this.btTourCreate.Text = "Создать тур";
            this.btTourCreate.UseVisualStyleBackColor = true;
            this.btTourCreate.Click += new System.EventHandler(this.BtTourCreate_Click);
            // 
            // ELSlalom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.btTourCreate);
            this.Controls.Add(this.dgEdit);
            this.Controls.Add(this.dgView);
            this.Name = "ELSlalom";
            this.Text = "ELSlalom";
            this.Load += new System.EventHandler(this.ELSlalom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridView dgEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Победа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Win2;
        private System.Windows.Forms.Button btTourCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Out;
    }
}