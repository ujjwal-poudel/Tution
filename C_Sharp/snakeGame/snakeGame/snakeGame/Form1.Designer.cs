namespace snakeGame
{
    partial class Form1
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
            this.pbgraphic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbgraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbgraphic
            // 
            this.pbgraphic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbgraphic.Location = new System.Drawing.Point(13, 13);
            this.pbgraphic.Name = "pbgraphic";
            this.pbgraphic.Size = new System.Drawing.Size(800, 600);
            this.pbgraphic.TabIndex = 0;
            this.pbgraphic.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1065, 666);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbgraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbgraphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}