namespace GameControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cam1 = new System.Windows.Forms.Panel();
            this.cam2 = new System.Windows.Forms.Panel();
            this.cam3 = new System.Windows.Forms.Panel();
            this.cam1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cam Cycle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cam1
            // 
            this.cam1.Controls.Add(this.cam2);
            this.cam1.Location = new System.Drawing.Point(294, 130);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(200, 100);
            this.cam1.TabIndex = 2;
            // 
            // cam2
            // 
            this.cam2.Location = new System.Drawing.Point(3, 0);
            this.cam2.Name = "cam2";
            this.cam2.Size = new System.Drawing.Size(200, 100);
            this.cam2.TabIndex = 3;
            // 
            // cam3
            // 
            this.cam3.Location = new System.Drawing.Point(291, 127);
            this.cam3.Name = "cam3";
            this.cam3.Size = new System.Drawing.Size(200, 100);
            this.cam3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cam3);
            this.Controls.Add(this.cam1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cam1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel cam1;
        private System.Windows.Forms.Panel cam2;
        private System.Windows.Forms.Panel cam3;
    }
}

