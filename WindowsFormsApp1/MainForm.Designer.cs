namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.allenRadiobutton = new System.Windows.Forms.RadioButton();
            this.pikeRadiobutton = new System.Windows.Forms.RadioButton();
            this.dbsRadiobutton = new System.Windows.Forms.RadioButton();
            this.suiteButton = new System.Windows.Forms.RadioButton();
            this.sevenRadiobutton = new System.Windows.Forms.RadioButton();
            this.fourteenRadiobutton = new System.Windows.Forms.RadioButton();
            this.unlimitedRadiobutton = new System.Windows.Forms.RadioButton();
            this.totalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Dormitory and a Meal plan:";
            // 
            // allenRadiobutton
            // 
            this.allenRadiobutton.AutoSize = true;
            this.allenRadiobutton.Location = new System.Drawing.Point(6, 19);
            this.allenRadiobutton.Name = "allenRadiobutton";
            this.allenRadiobutton.Size = new System.Drawing.Size(168, 17);
            this.allenRadiobutton.TabIndex = 1;
            this.allenRadiobutton.TabStop = true;
            this.allenRadiobutton.Text = "Allen Hall: €1500 per semester";
            this.allenRadiobutton.UseVisualStyleBackColor = true;
            // 
            // pikeRadiobutton
            // 
            this.pikeRadiobutton.AutoSize = true;
            this.pikeRadiobutton.Location = new System.Drawing.Point(6, 42);
            this.pikeRadiobutton.Name = "pikeRadiobutton";
            this.pikeRadiobutton.Size = new System.Drawing.Size(166, 17);
            this.pikeRadiobutton.TabIndex = 2;
            this.pikeRadiobutton.TabStop = true;
            this.pikeRadiobutton.Text = "Pike Hall: €1600 per semester";
            this.pikeRadiobutton.UseVisualStyleBackColor = true;
            // 
            // dbsRadiobutton
            // 
            this.dbsRadiobutton.AutoSize = true;
            this.dbsRadiobutton.Location = new System.Drawing.Point(6, 65);
            this.dbsRadiobutton.Name = "dbsRadiobutton";
            this.dbsRadiobutton.Size = new System.Drawing.Size(167, 17);
            this.dbsRadiobutton.TabIndex = 3;
            this.dbsRadiobutton.TabStop = true;
            this.dbsRadiobutton.Text = "DBS Hall: €1800 per semester";
            this.dbsRadiobutton.UseVisualStyleBackColor = true;
            // 
            // suiteButton
            // 
            this.suiteButton.AutoSize = true;
            this.suiteButton.Location = new System.Drawing.Point(6, 88);
            this.suiteButton.Name = "suiteButton";
            this.suiteButton.Size = new System.Drawing.Size(197, 17);
            this.suiteButton.TabIndex = 4;
            this.suiteButton.TabStop = true;
            this.suiteButton.Text = "University Suite: €2500 per semester";
            this.suiteButton.UseVisualStyleBackColor = true;
            // 
            // sevenRadiobutton
            // 
            this.sevenRadiobutton.AutoSize = true;
            this.sevenRadiobutton.Location = new System.Drawing.Point(6, 19);
            this.sevenRadiobutton.Name = "sevenRadiobutton";
            this.sevenRadiobutton.Size = new System.Drawing.Size(201, 17);
            this.sevenRadiobutton.TabIndex = 5;
            this.sevenRadiobutton.TabStop = true;
            this.sevenRadiobutton.Text = "7 meals per week: €600 per semester";
            this.sevenRadiobutton.UseVisualStyleBackColor = true;
            // 
            // fourteenRadiobutton
            // 
            this.fourteenRadiobutton.AutoSize = true;
            this.fourteenRadiobutton.Location = new System.Drawing.Point(6, 42);
            this.fourteenRadiobutton.Name = "fourteenRadiobutton";
            this.fourteenRadiobutton.Size = new System.Drawing.Size(213, 17);
            this.fourteenRadiobutton.TabIndex = 6;
            this.fourteenRadiobutton.TabStop = true;
            this.fourteenRadiobutton.Text = "14 meals per week: €1200 per semester";
            this.fourteenRadiobutton.UseVisualStyleBackColor = true;
            // 
            // unlimitedRadiobutton
            // 
            this.unlimitedRadiobutton.AutoSize = true;
            this.unlimitedRadiobutton.Location = new System.Drawing.Point(6, 65);
            this.unlimitedRadiobutton.Name = "unlimitedRadiobutton";
            this.unlimitedRadiobutton.Size = new System.Drawing.Size(197, 17);
            this.unlimitedRadiobutton.TabIndex = 7;
            this.unlimitedRadiobutton.TabStop = true;
            this.unlimitedRadiobutton.Text = "Unlimited meals: €1700 per semester";
            this.unlimitedRadiobutton.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(214, 308);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total:";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(502, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allenRadiobutton);
            this.groupBox1.Controls.Add(this.pikeRadiobutton);
            this.groupBox1.Controls.Add(this.dbsRadiobutton);
            this.groupBox1.Controls.Add(this.suiteButton);
            this.groupBox1.Location = new System.Drawing.Point(173, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormitory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sevenRadiobutton);
            this.groupBox2.Controls.Add(this.fourteenRadiobutton);
            this.groupBox2.Controls.Add(this.unlimitedRadiobutton);
            this.groupBox2.Location = new System.Drawing.Point(426, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Dormitory and meal plan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton allenRadiobutton;
        private System.Windows.Forms.RadioButton pikeRadiobutton;
        private System.Windows.Forms.RadioButton dbsRadiobutton;
        private System.Windows.Forms.RadioButton suiteButton;
        private System.Windows.Forms.RadioButton sevenRadiobutton;
        private System.Windows.Forms.RadioButton fourteenRadiobutton;
        private System.Windows.Forms.RadioButton unlimitedRadiobutton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

