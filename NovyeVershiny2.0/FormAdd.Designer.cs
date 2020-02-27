namespace Novye
{
    partial class FormAdd
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNameM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNameL = new System.Windows.Forms.TextBox();
            this.boxNameF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxNameMR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNameLR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxNameFR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxOrganization = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxNomination = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxAge1 = new System.Windows.Forms.CheckBox();
            this.boxAge2 = new System.Windows.Forms.CheckBox();
            this.boxAge3 = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.formAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxTeam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formAddBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxNameM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxNameL);
            this.groupBox1.Controls.Add(this.boxNameF);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Участник";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // boxNameM
            // 
            this.boxNameM.Location = new System.Drawing.Point(554, 38);
            this.boxNameM.Name = "boxNameM";
            this.boxNameM.Size = new System.Drawing.Size(234, 22);
            this.boxNameM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // boxNameL
            // 
            this.boxNameL.Location = new System.Drawing.Point(280, 38);
            this.boxNameL.Name = "boxNameL";
            this.boxNameL.Size = new System.Drawing.Size(268, 22);
            this.boxNameL.TabIndex = 5;
            // 
            // boxNameF
            // 
            this.boxNameF.Location = new System.Drawing.Point(15, 38);
            this.boxNameF.Name = "boxNameF";
            this.boxNameF.Size = new System.Drawing.Size(259, 22);
            this.boxNameF.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxNameMR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.boxNameLR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.boxNameFR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Руководитель";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // boxNameMR
            // 
            this.boxNameMR.Location = new System.Drawing.Point(554, 38);
            this.boxNameMR.Name = "boxNameMR";
            this.boxNameMR.Size = new System.Drawing.Size(234, 22);
            this.boxNameMR.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество";
            // 
            // boxNameLR
            // 
            this.boxNameLR.Location = new System.Drawing.Point(280, 38);
            this.boxNameLR.Name = "boxNameLR";
            this.boxNameLR.Size = new System.Drawing.Size(268, 22);
            this.boxNameLR.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фамилия";
            // 
            // boxNameFR
            // 
            this.boxNameFR.Location = new System.Drawing.Point(15, 38);
            this.boxNameFR.Name = "boxNameFR";
            this.boxNameFR.Size = new System.Drawing.Size(259, 22);
            this.boxNameFR.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя";
            // 
            // boxOrganization
            // 
            this.boxOrganization.Location = new System.Drawing.Point(15, 199);
            this.boxOrganization.Name = "boxOrganization";
            this.boxOrganization.Size = new System.Drawing.Size(403, 22);
            this.boxOrganization.TabIndex = 13;
            this.boxOrganization.TextChanged += new System.EventHandler(this.BoxOrganization_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Организация";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
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
            this.boxNomination.Location = new System.Drawing.Point(12, 247);
            this.boxNomination.Name = "boxNomination";
            this.boxNomination.Size = new System.Drawing.Size(617, 24);
            this.boxNomination.TabIndex = 15;
            this.boxNomination.SelectedIndexChanged += new System.EventHandler(this.BoxNomination_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номинация";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxAge1);
            this.groupBox3.Controls.Add(this.boxAge2);
            this.groupBox3.Controls.Add(this.boxAge3);
            this.groupBox3.Location = new System.Drawing.Point(635, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Возраст";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // boxAge1
            // 
            this.boxAge1.AutoSize = true;
            this.boxAge1.Location = new System.Drawing.Point(6, 22);
            this.boxAge1.Name = "boxAge1";
            this.boxAge1.Size = new System.Drawing.Size(98, 21);
            this.boxAge1.TabIndex = 18;
            this.boxAge1.Text = "checkBox1";
            this.boxAge1.UseVisualStyleBackColor = true;
            // 
            // boxAge2
            // 
            this.boxAge2.AutoSize = true;
            this.boxAge2.Location = new System.Drawing.Point(6, 47);
            this.boxAge2.Name = "boxAge2";
            this.boxAge2.Size = new System.Drawing.Size(98, 21);
            this.boxAge2.TabIndex = 19;
            this.boxAge2.Text = "checkBox2";
            this.boxAge2.UseVisualStyleBackColor = true;
            // 
            // boxAge3
            // 
            this.boxAge3.AutoSize = true;
            this.boxAge3.Location = new System.Drawing.Point(6, 70);
            this.boxAge3.Name = "boxAge3";
            this.boxAge3.Size = new System.Drawing.Size(98, 21);
            this.boxAge3.TabIndex = 20;
            this.boxAge3.Text = "checkBox3";
            this.boxAge3.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(460, 290);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(162, 25);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(628, 290);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(164, 25);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // formAddBindingSource
            // 
            this.formAddBindingSource.DataSource = typeof(Novye.FormAdd);
            // 
            // boxTeam
            // 
            this.boxTeam.Location = new System.Drawing.Point(424, 199);
            this.boxTeam.Name = "boxTeam";
            this.boxTeam.Size = new System.Drawing.Size(205, 22);
            this.boxTeam.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Команда";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxTeam);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxNomination);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxOrganization);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdd";
            this.Text = "Добавление участника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formAddBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxNameM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNameL;
        private System.Windows.Forms.TextBox boxNameF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox boxNameMR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxNameLR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxNameFR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxOrganization;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox boxNomination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox boxAge1;
        private System.Windows.Forms.CheckBox boxAge2;
        private System.Windows.Forms.CheckBox boxAge3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource formAddBindingSource;
        private System.Windows.Forms.TextBox boxTeam;
        private System.Windows.Forms.Label label9;
    }
}