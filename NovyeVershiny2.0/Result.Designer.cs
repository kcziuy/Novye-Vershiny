namespace NovyeVershiny2._0
{
    partial class Result
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
            this.btLoad = new System.Windows.Forms.Button();
            this.prtNumber = new System.Windows.Forms.NumericUpDown();
            this.btCancel = new System.Windows.Forms.Button();
            this.boxNomination = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(141, 11);
            this.btLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(163, 25);
            this.btLoad.TabIndex = 32;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // prtNumber
            // 
            this.prtNumber.Location = new System.Drawing.Point(15, 11);
            this.prtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prtNumber.Name = "prtNumber";
            this.prtNumber.Size = new System.Drawing.Size(120, 22);
            this.prtNumber.TabIndex = 31;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(69, 41);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(162, 25);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
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
            this.boxNomination.Location = new System.Drawing.Point(-1, 72);
            this.boxNomination.Name = "boxNomination";
            this.boxNomination.Size = new System.Drawing.Size(305, 24);
            this.boxNomination.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 25);
            this.button1.TabIndex = 35;
            this.button1.Text = "Присвоить места";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxNomination);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.prtNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Result";
            this.Text = "int";
            ((System.ComponentModel.ISupportInitialize)(this.prtNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btLoad;
        public System.Windows.Forms.NumericUpDown prtNumber;
        public System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.ComboBox boxNomination;
        public System.Windows.Forms.Button button1;
    }
}