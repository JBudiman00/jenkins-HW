namespace Hello_World
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btwCMI = new System.Windows.Forms.Button();
            this.lblCMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(91, 45);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(106, 105);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 13);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // btwCMI
            // 
            this.btwCMI.Location = new System.Drawing.Point(439, 105);
            this.btwCMI.Name = "btwCMI";
            this.btwCMI.Size = new System.Drawing.Size(136, 23);
            this.btwCMI.TabIndex = 2;
            this.btwCMI.Text = "Click Me Instead";
            this.btwCMI.UseVisualStyleBackColor = true;
            this.btwCMI.Click += new System.EventHandler(this.btwCMI_Click);
            // 
            // lblCMI
            // 
            this.lblCMI.AutoSize = true;
            this.lblCMI.Location = new System.Drawing.Point(515, 175);
            this.lblCMI.Name = "lblCMI";
            this.lblCMI.Size = new System.Drawing.Size(0, 13);
            this.lblCMI.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCMI);
            this.Controls.Add(this.btwCMI);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btwCMI;
        private System.Windows.Forms.Label lblCMI;
    }
}

