namespace NovyeVershiny2._0
{
    partial class ElliminationMode
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
            this.btSlalom = new System.Windows.Forms.Button();
            this.btFPV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSlalom
            // 
            this.btSlalom.Location = new System.Drawing.Point(0, 0);
            this.btSlalom.Name = "btSlalom";
            this.btSlalom.Size = new System.Drawing.Size(204, 144);
            this.btSlalom.TabIndex = 0;
            this.btSlalom.Text = "Эллиминация Дрон-слалом";
            this.btSlalom.UseVisualStyleBackColor = true;
            this.btSlalom.Click += new System.EventHandler(this.BtSlalom_Click);
            // 
            // btFPV
            // 
            this.btFPV.Location = new System.Drawing.Point(210, 0);
            this.btFPV.Name = "btFPV";
            this.btFPV.Size = new System.Drawing.Size(204, 144);
            this.btFPV.TabIndex = 1;
            this.btFPV.Text = "Эллиминация FPV";
            this.btFPV.UseVisualStyleBackColor = true;
            this.btFPV.Click += new System.EventHandler(this.BtFPV_Click);
            // 
            // ElliminationMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 146);
            this.Controls.Add(this.btFPV);
            this.Controls.Add(this.btSlalom);
            this.Name = "ElliminationMode";
            this.Text = "ElliminationMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSlalom;
        private System.Windows.Forms.Button btFPV;
    }
}