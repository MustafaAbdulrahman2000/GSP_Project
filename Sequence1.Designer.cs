namespace GSP_Assignment
{
    partial class Sequence1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Candidate1_lst = new System.Windows.Forms.ListView();
            this.Frequent1_lst = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "1-Sequences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(147, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Candidate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(393, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frequent";
            // 
            // Candidate1_lst
            // 
            this.Candidate1_lst.Location = new System.Drawing.Point(147, 92);
            this.Candidate1_lst.Name = "Candidate1_lst";
            this.Candidate1_lst.Size = new System.Drawing.Size(79, 189);
            this.Candidate1_lst.TabIndex = 11;
            this.Candidate1_lst.UseCompatibleStateImageBehavior = false;
            // 
            // Frequent1_lst
            // 
            this.Frequent1_lst.Location = new System.Drawing.Point(393, 92);
            this.Frequent1_lst.Name = "Frequent1_lst";
            this.Frequent1_lst.Size = new System.Drawing.Size(79, 189);
            this.Frequent1_lst.TabIndex = 12;
            this.Frequent1_lst.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(271, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sequence1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Frequent1_lst);
            this.Controls.Add(this.Candidate1_lst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Sequence1";
            this.Size = new System.Drawing.Size(637, 300);
            this.Load += new System.EventHandler(this.Sequence1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private ListView Candidate1_lst;
        private ListView Frequent1_lst;
        private Button button1;
    }
}
