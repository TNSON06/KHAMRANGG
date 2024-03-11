namespace KHAMRANGG
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBCV = new System.Windows.Forms.CheckBox();
            this.cBTT = new System.Windows.Forms.CheckBox();
            this.cBCHR = new System.Windows.Forms.CheckBox();
            this.cBBTR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTT = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.tBTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(142, 94);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(182, 20);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "$100.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "$1.200.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "$200.000";
            // 
            // cBCV
            // 
            this.cBCV.AutoSize = true;
            this.cBCV.Location = new System.Drawing.Point(53, 146);
            this.cBCV.Name = "cBCV";
            this.cBCV.Size = new System.Drawing.Size(62, 17);
            this.cBCV.TabIndex = 7;
            this.cBCV.Text = "Cạo vôi";
            this.cBCV.UseVisualStyleBackColor = true;
            // 
            // cBTT
            // 
            this.cBTT.AutoSize = true;
            this.cBTT.Location = new System.Drawing.Point(53, 174);
            this.cBTT.Name = "cBTT";
            this.cBTT.Size = new System.Drawing.Size(71, 17);
            this.cBTT.TabIndex = 8;
            this.cBTT.Text = "Tẩy trắng";
            this.cBTT.UseVisualStyleBackColor = true;
            // 
            // cBCHR
            // 
            this.cBCHR.AutoSize = true;
            this.cBCHR.Location = new System.Drawing.Point(53, 197);
            this.cBCHR.Name = "cBCHR";
            this.cBCHR.Size = new System.Drawing.Size(98, 17);
            this.cBCHR.TabIndex = 9;
            this.cBCHR.Text = "Chụp hình răng";
            this.cBCHR.UseVisualStyleBackColor = true;
            // 
            // cBBTR
            // 
            this.cBBTR.FormattingEnabled = true;
            this.cBBTR.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cBBTR.Location = new System.Drawing.Point(111, 246);
            this.cBBTR.Name = "cBBTR";
            this.cBBTR.Size = new System.Drawing.Size(121, 21);
            this.cBBTR.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trám răng";
            // 
            // buttonTT
            // 
            this.buttonTT.Location = new System.Drawing.Point(206, 377);
            this.buttonTT.Name = "buttonTT";
            this.buttonTT.Size = new System.Drawing.Size(75, 31);
            this.buttonTT.TabIndex = 12;
            this.buttonTT.Text = "Tính tiền";
            this.buttonTT.UseVisualStyleBackColor = true;
            this.buttonTT.Click += new System.EventHandler(this.buttonTT_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(53, 377);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(75, 31);
            this.buttonT.TabIndex = 13;
            this.buttonT.Text = "Thoát";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // tBTotal
            // 
            this.tBTotal.Enabled = false;
            this.tBTotal.Location = new System.Drawing.Point(216, 310);
            this.tBTotal.Name = "tBTotal";
            this.tBTotal.Size = new System.Drawing.Size(100, 20);
            this.tBTotal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(26, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dental Payment Form";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBTotal);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBBTR);
            this.Controls.Add(this.cBCHR);
            this.Controls.Add(this.cBTT);
            this.Controls.Add(this.cBCV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cBCV;
        private System.Windows.Forms.CheckBox cBTT;
        private System.Windows.Forms.CheckBox cBCHR;
        private System.Windows.Forms.ComboBox cBBTR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTT;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.TextBox tBTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

