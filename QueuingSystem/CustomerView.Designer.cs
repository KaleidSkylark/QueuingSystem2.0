namespace QueuingSystem
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.lblQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.BackColor = System.Drawing.Color.Transparent;
            this.lblQueue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQueue.ForeColor = System.Drawing.Color.White;
            this.lblQueue.Location = new System.Drawing.Point(78, 114);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(0, 43);
            this.lblQueue.TabIndex = 0;
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QueuingSystem.Properties.Resources.NowServingBG;
            this.ClientSize = new System.Drawing.Size(338, 249);
            this.Controls.Add(this.lblQueue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(354, 288);
            this.MinimumSize = new System.Drawing.Size(354, 288);
            this.Name = "CustomerView";
            this.Text = "Skylark View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQueue;
    }
}