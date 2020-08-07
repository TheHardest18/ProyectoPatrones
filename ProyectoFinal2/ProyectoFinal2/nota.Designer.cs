namespace ProyectoFinal2
{
    partial class nota
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
            this.nota1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Location = new System.Drawing.Point(136, 60);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(37, 17);
            this.nota1.TabIndex = 0;
            this.nota1.Text = "lkasf";
            this.nota1.Click += new System.EventHandler(this.nota1_Click);
            // 
            // nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.nota1);
            this.Name = "nota";
            this.Text = "Qualification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nota1;
    }
}