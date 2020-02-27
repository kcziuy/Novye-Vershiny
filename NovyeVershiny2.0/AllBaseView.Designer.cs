namespace NovyeVershiny2._0
{
    partial class AllBaseView
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
            this.baseView = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseView
            // 
            this.baseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.baseView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.baseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LName,
            this.FName,
            this.MName,
            this.Team,
            this.LNameR,
            this.FNameR,
            this.MNameR,
            this.org,
            this.nom,
            this.age,
            this.Result,
            this.isOut,
            this.win});
            this.baseView.Location = new System.Drawing.Point(12, 43);
            this.baseView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baseView.Name = "baseView";
            this.baseView.RowTemplate.Height = 24;
            this.baseView.Size = new System.Drawing.Size(1123, 606);
            this.baseView.TabIndex = 0;
            this.baseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BaseView_CellContentClick);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(12, 12);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(163, 25);
            this.btCancel.TabIndex = 28;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // refresh
            // 
            this.refresh.Image = global::NovyeVershiny2._0.Properties.Resources.refresh2;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.refresh.Location = new System.Drawing.Point(1089, 586);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(41, 39);
            this.refresh.TabIndex = 29;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 48;
            // 
            // LName
            // 
            this.LName.HeaderText = "Фамилия";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Width = 99;
            // 
            // FName
            // 
            this.FName.HeaderText = "Имя";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 64;
            // 
            // MName
            // 
            this.MName.HeaderText = "Отчество";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.HeaderText = "Команда";
            this.Team.Name = "Team";
            this.Team.Width = 95;
            // 
            // LNameR
            // 
            this.LNameR.HeaderText = "Рук. Фамилия";
            this.LNameR.Name = "LNameR";
            this.LNameR.ReadOnly = true;
            this.LNameR.Width = 130;
            // 
            // FNameR
            // 
            this.FNameR.HeaderText = "Рук. Имя";
            this.FNameR.Name = "FNameR";
            this.FNameR.ReadOnly = true;
            this.FNameR.Width = 95;
            // 
            // MNameR
            // 
            this.MNameR.HeaderText = "Рук. Отчество";
            this.MNameR.Name = "MNameR";
            this.MNameR.ReadOnly = true;
            this.MNameR.Width = 120;
            // 
            // org
            // 
            this.org.HeaderText = "Организация";
            this.org.Name = "org";
            this.org.ReadOnly = true;
            this.org.Width = 124;
            // 
            // nom
            // 
            this.nom.HeaderText = "Номинация";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 112;
            // 
            // age
            // 
            this.age.HeaderText = "Возрастная категория";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 170;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.Width = 105;
            // 
            // isOut
            // 
            this.isOut.HeaderText = "Выбыл";
            this.isOut.Name = "isOut";
            this.isOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isOut.Width = 59;
            // 
            // win
            // 
            this.win.HeaderText = "DEBWIN";
            this.win.Name = "win";
            this.win.Width = 91;
            // 
            // AllBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 665);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.baseView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllBaseView";
            this.Text = "AllBaseView";
            this.Load += new System.EventHandler(this.AllBaseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView baseView;
        public System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNameR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNameR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNameR;
        private System.Windows.Forms.DataGridViewTextBoxColumn org;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn isOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn win;
    }
}