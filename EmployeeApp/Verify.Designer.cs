namespace EmployeeApp
{
    partial class Verify
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchTb = new System.Windows.Forms.Button();
            this.applyTb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1395, 466);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 1;
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(365, 31);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(97, 35);
            this.searchTb.TabIndex = 3;
            this.searchTb.Text = "refresh";
            this.searchTb.UseVisualStyleBackColor = true;
            this.searchTb.Click += new System.EventHandler(this.button1_Click);
            // 
            // applyTb
            // 
            this.applyTb.Location = new System.Drawing.Point(570, 31);
            this.applyTb.Name = "applyTb";
            this.applyTb.Size = new System.Drawing.Size(195, 55);
            this.applyTb.TabIndex = 4;
            this.applyTb.Text = "Apply";
            this.applyTb.UseVisualStyleBackColor = true;
            this.applyTb.Click += new System.EventHandler(this.applyTb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chosen ID\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "UsersTable";
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applyTb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Verify";
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchTb;
        private System.Windows.Forms.Button applyTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}