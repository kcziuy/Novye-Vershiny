namespace NovyeVershiny2._0
{
    partial class OutResults
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
            this.button1 = new System.Windows.Forms.Button();
            this.boxNomination = new System.Windows.Forms.ComboBox();
            this.baseView = new System.Windows.Forms.DataGridView();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.baseView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1139, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // boxNomination
            // 
            this.boxNomination.FormattingEnabled = true;
            this.boxNomination.Items.AddRange(new object[] {
            "HLG",
            "HLG-P",
            "F1N-E",
            "Простейшие",
            "Дальность",
            "Кордовые1",
            "Кордовые2",
            "Дроны 1",
            "Дроны 2"});
            this.boxNomination.Location = new System.Drawing.Point(12, 12);
            this.boxNomination.Name = "boxNomination";
            this.boxNomination.Size = new System.Drawing.Size(1139, 24);
            this.boxNomination.TabIndex = 16;
            this.boxNomination.SelectedIndexChanged += new System.EventHandler(this.BoxNomination_SelectedIndexChanged);
            // 
            // baseView
            // 
            this.baseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.baseView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.baseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.age,
            this.Result,
            this.id,
            this.LName,
            this.FName,
            this.MName,
            this.Team,
            this.LNameR,
            this.FNameR,
            this.MNameR,
            this.org,
            this.nom});
            this.baseView.Location = new System.Drawing.Point(12, 75);
            this.baseView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baseView.Name = "baseView";
            this.baseView.RowTemplate.Height = 24;
            this.baseView.Size = new System.Drawing.Size(1139, 364);
            this.baseView.TabIndex = 17;
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
            this.Result.HeaderText = "Место";
            this.Result.Name = "Result";
            this.Result.Width = 78;
            // 
            // id
            // 
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
            this.LNameR.Width = 119;
            // 
            // FNameR
            // 
            this.FNameR.HeaderText = "Рук. Имя";
            this.FNameR.Name = "FNameR";
            this.FNameR.ReadOnly = true;
            this.FNameR.Width = 64;
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
            // OutResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 450);
            this.Controls.Add(this.baseView);
            this.Controls.Add(this.boxNomination);
            this.Controls.Add(this.button1);
            this.Name = "OutResults";
            this.Text = "OutResults";
            ((System.ComponentModel.ISupportInitialize)(this.baseView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox boxNomination;
        public System.Windows.Forms.DataGridView baseView;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
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
    }
}