namespace Novye
{
    partial class InitForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStatusText = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.lbStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatusText.Location = new System.Drawing.Point(12, 79);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(95, 25);
            this.lbStatusText.TabIndex = 0;
            this.lbStatusText.Text = "OFFLINE";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 37);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStart.Location = new System.Drawing.Point(12, 9);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(190, 25);
            this.lbStart.TabIndex = 2;
            this.lbStart.Text = "Запуск программы";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 119);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.lbStatusText);
            this.MaximumSize = new System.Drawing.Size(229, 166);
            this.MinimumSize = new System.Drawing.Size(229, 166);
            this.Name = "InitForm";
            this.Text = "Инициализация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label lbStart;
    }
}

