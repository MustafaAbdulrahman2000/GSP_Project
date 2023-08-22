namespace GSP_Assignment
{
    partial class Sequence2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Temporal_lst = new System.Windows.Forms.ListView();
            this.Nontemporal_lst = new System.Windows.Forms.ListView();
            this.Frequent2_lst = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "2-Sequences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(196, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Non-temporal Candidate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temporal Candidate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(514, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Frequent";
            // 
            // Temporal_lst
            // 
            this.Temporal_lst.Location = new System.Drawing.Point(49, 95);
            this.Temporal_lst.Name = "Temporal_lst";
            this.Temporal_lst.Size = new System.Drawing.Size(79, 197);
            this.Temporal_lst.TabIndex = 13;
            this.Temporal_lst.UseCompatibleStateImageBehavior = false;
            // 
            // Nontemporal_lst
            // 
            this.Nontemporal_lst.Location = new System.Drawing.Point(243, 95);
            this.Nontemporal_lst.Name = "Nontemporal_lst";
            this.Nontemporal_lst.Size = new System.Drawing.Size(79, 197);
            this.Nontemporal_lst.TabIndex = 14;
            this.Nontemporal_lst.UseCompatibleStateImageBehavior = false;
            // 
            // Frequent2_lst
            // 
            this.Frequent2_lst.Location = new System.Drawing.Point(514, 95);
            this.Frequent2_lst.Name = "Frequent2_lst";
            this.Frequent2_lst.Size = new System.Drawing.Size(79, 197);
            this.Frequent2_lst.TabIndex = 15;
            this.Frequent2_lst.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(373, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 56);
            this.button2.TabIndex = 19;
            this.button2.Text = "-->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sequence2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Frequent2_lst);
            this.Controls.Add(this.Nontemporal_lst);
            this.Controls.Add(this.Temporal_lst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Sequence2";
            this.Size = new System.Drawing.Size(637, 300);
            this.Load += new System.EventHandler(this.Sequence2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private ListView Temporal_lst;
        private ListView Nontemporal_lst;
        private ListView Frequent2_lst;
        private Button button2;
    }
}
