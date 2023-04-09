namespace HGatesApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.parish = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.RadioButton();
            this.f = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.registerdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HGatesAPP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(1, 129);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(353, 34);
            this.FN.TabIndex = 1;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(0, 197);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(354, 34);
            this.LN.TabIndex = 2;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(-1, 267);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(355, 34);
            this.address.TabIndex = 3;
            this.address.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-6, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone Number ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parish ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(0, 347);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(354, 34);
            this.telephone.TabIndex = 11;
            // 
            // parish
            // 
            this.parish.FormattingEnabled = true;
            this.parish.Location = new System.Drawing.Point(1, 440);
            this.parish.Name = "parish";
            this.parish.Size = new System.Drawing.Size(353, 38);
            this.parish.TabIndex = 12;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(7, 534);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(85, 34);
            this.m.TabIndex = 13;
            this.m.TabStop = true;
            this.m.Text = "Male ";
            this.m.UseVisualStyleBackColor = true;
            this.m.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(125, 534);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(101, 34);
            this.f.TabIndex = 14;
            this.f.TabStop = true;
            this.f.Text = "Female";
            this.f.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender ";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(562, 561);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(180, 95);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerdate
            // 
            this.registerdate.Location = new System.Drawing.Point(612, 186);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(406, 34);
            this.registerdate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Registration Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 668);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerdate);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.f);
            this.Controls.Add(this.m);
            this.Controls.Add(this.parish);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.ComboBox parish;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker registerdate;
        private System.Windows.Forms.Label label9;
    }
}

