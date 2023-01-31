namespace Simple_calculation
{
    partial class calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.Highlight;
            this.n1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n1.Location = new System.Drawing.Point(51, 57);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(53, 39);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.Highlight;
            this.n2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n2.Location = new System.Drawing.Point(101, 57);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(48, 39);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.Highlight;
            this.n3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n3.Location = new System.Drawing.Point(146, 57);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 39);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.Highlight;
            this.n4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n4.Location = new System.Drawing.Point(51, 86);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(53, 39);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.Highlight;
            this.n5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n5.Location = new System.Drawing.Point(101, 86);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(48, 39);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.Highlight;
            this.n6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n6.Location = new System.Drawing.Point(146, 86);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 39);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.Highlight;
            this.n7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n7.Location = new System.Drawing.Point(51, 115);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(53, 39);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.Highlight;
            this.n8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n8.Location = new System.Drawing.Point(101, 115);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(48, 39);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.Highlight;
            this.n9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n9.Location = new System.Drawing.Point(146, 115);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(50, 39);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.Highlight;
            this.n0.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n0.Location = new System.Drawing.Point(101, 150);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(48, 35);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.SystemColors.Highlight;
            this.bad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bad.Location = new System.Drawing.Point(202, 57);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(46, 31);
            this.bad.TabIndex = 11;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = false;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.Highlight;
            this.bsub.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bsub.Location = new System.Drawing.Point(202, 95);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(46, 23);
            this.bsub.TabIndex = 12;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmult
            // 
            this.bmult.BackColor = System.Drawing.SystemColors.Highlight;
            this.bmult.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bmult.Location = new System.Drawing.Point(202, 124);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(46, 23);
            this.bmult.TabIndex = 13;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = false;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.SystemColors.Highlight;
            this.bdot.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdot.Location = new System.Drawing.Point(51, 153);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(53, 33);
            this.bdot.TabIndex = 14;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.Highlight;
            this.bC.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bC.Location = new System.Drawing.Point(146, 153);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(50, 32);
            this.bC.TabIndex = 15;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.bdiv.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdiv.Location = new System.Drawing.Point(202, 153);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(46, 32);
            this.bdiv.TabIndex = 16;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.Highlight;
            this.bequal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bequal.Location = new System.Drawing.Point(101, 191);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(48, 23);
            this.bequal.TabIndex = 17;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bequal;
    }
}

