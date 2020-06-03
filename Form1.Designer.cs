namespace TrafficLights
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
            this.red = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(63, 25);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(130, 102);
            this.red.TabIndex = 0;
            this.red.TabStop = false;
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(63, 133);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(130, 102);
            this.yellow.TabIndex = 1;
            this.yellow.TabStop = false;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(63, 241);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(130, 102);
            this.green.TabIndex = 2;
            this.green.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 380);
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox green;
    }
}

