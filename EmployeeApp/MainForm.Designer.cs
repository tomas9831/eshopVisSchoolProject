namespace EmployeeApp
{
    partial class MainForm
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
            this.addGameB = new System.Windows.Forms.Button();
            this.addUserB = new System.Windows.Forms.Button();
            this.verifyB = new System.Windows.Forms.Button();
            this.requestsB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGameB
            // 
            this.addGameB.Location = new System.Drawing.Point(33, 21);
            this.addGameB.Name = "addGameB";
            this.addGameB.Size = new System.Drawing.Size(187, 96);
            this.addGameB.TabIndex = 0;
            this.addGameB.Text = "Add Game";
            this.addGameB.UseVisualStyleBackColor = true;
            this.addGameB.Click += new System.EventHandler(this.addGameB_Click);
            // 
            // addUserB
            // 
            this.addUserB.Location = new System.Drawing.Point(269, 21);
            this.addUserB.Name = "addUserB";
            this.addUserB.Size = new System.Drawing.Size(187, 96);
            this.addUserB.TabIndex = 0;
            this.addUserB.Text = "Add User";
            this.addUserB.UseVisualStyleBackColor = true;
            this.addUserB.Click += new System.EventHandler(this.addUserB_Click);
            // 
            // verifyB
            // 
            this.verifyB.Location = new System.Drawing.Point(494, 21);
            this.verifyB.Name = "verifyB";
            this.verifyB.Size = new System.Drawing.Size(187, 96);
            this.verifyB.TabIndex = 0;
            this.verifyB.Text = "Verify User";
            this.verifyB.UseVisualStyleBackColor = true;
            this.verifyB.Click += new System.EventHandler(this.verifyuserB_Click);
            // 
            // requestsB
            // 
            this.requestsB.Location = new System.Drawing.Point(33, 151);
            this.requestsB.Name = "requestsB";
            this.requestsB.Size = new System.Drawing.Size(187, 96);
            this.requestsB.TabIndex = 0;
            this.requestsB.Text = "Incoming Requests";
            this.requestsB.UseVisualStyleBackColor = true;
            this.requestsB.Click += new System.EventHandler(this.requestsB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestsB);
            this.Controls.Add(this.verifyB);
            this.Controls.Add(this.addUserB);
            this.Controls.Add(this.addGameB);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGameB;
        private System.Windows.Forms.Button addUserB;
        private System.Windows.Forms.Button verifyB;
        private System.Windows.Forms.Button requestsB;
    }
}