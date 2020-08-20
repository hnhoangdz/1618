namespace CreatAccount
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.lbProductList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEoPN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbMale = new System.Windows.Forms.RadioButton();
            this.rtbFemale = new System.Windows.Forms.RadioButton();
            this.button24 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductList
            // 
            this.lbProductList.BackColor = System.Drawing.SystemColors.Info;
            this.lbProductList.ForeColor = System.Drawing.Color.Peru;
            this.lbProductList.FormattingEnabled = true;
            this.lbProductList.ItemHeight = 20;
            this.lbProductList.Location = new System.Drawing.Point(624, 214);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.ScrollAlwaysVisible = true;
            this.lbProductList.Size = new System.Drawing.Size(453, 364);
            this.lbProductList.TabIndex = 12;
            this.lbProductList.SelectedIndexChanged += new System.EventHandler(this.lbProductList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(727, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Bill List";
            // 
            // lable1
            // 
            this.lable1.BackColor = System.Drawing.SystemColors.Info;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Peru;
            this.lable1.Location = new System.Drawing.Point(12, 225);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(116, 44);
            this.lable1.TabIndex = 20;
            this.lable1.Text = "Name";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(12, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 48);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEoPN
            // 
            this.lbEoPN.BackColor = System.Drawing.SystemColors.Info;
            this.lbEoPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEoPN.ForeColor = System.Drawing.Color.Peru;
            this.lbEoPN.Location = new System.Drawing.Point(12, 596);
            this.lbEoPN.Name = "lbEoPN";
            this.lbEoPN.Size = new System.Drawing.Size(116, 53);
            this.lbEoPN.TabIndex = 22;
            this.lbEoPN.Text = "Email ";
            this.lbEoPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(12, 741);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 72);
            this.label3.TabIndex = 23;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Info;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Peru;
            this.tbName.Location = new System.Drawing.Point(10, 272);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(565, 44);
            this.tbName.TabIndex = 24;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.Peru;
            this.tbPhoneNumber.Location = new System.Drawing.Point(10, 519);
            this.tbPhoneNumber.Multiline = true;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(566, 48);
            this.tbPhoneNumber.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Info;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Peru;
            this.tbEmail.Location = new System.Drawing.Point(10, 652);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(567, 54);
            this.tbEmail.TabIndex = 26;
            // 
            // rtbAddress
            // 
            this.rtbAddress.BackColor = System.Drawing.SystemColors.Info;
            this.rtbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.ForeColor = System.Drawing.Color.Peru;
            this.rtbAddress.Location = new System.Drawing.Point(190, 741);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(372, 132);
            this.rtbAddress.TabIndex = 27;
            this.rtbAddress.Text = "";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(1, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1076, 166);
            this.label4.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(5, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = " < Back to Shopping";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(113, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Shipping Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(190, 909);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 73);
            this.button2.TabIndex = 31;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.BackColor = System.Drawing.SystemColors.Info;
            this.lbInformation.ForeColor = System.Drawing.Color.Peru;
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.ItemHeight = 20;
            this.lbInformation.Location = new System.Drawing.Point(624, 674);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(453, 144);
            this.lbInformation.TabIndex = 32;
            this.lbInformation.SelectedIndexChanged += new System.EventHandler(this.lbInformation_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(450, 909);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 73);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(12, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 44);
            this.label6.TabIndex = 34;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbMale
            // 
            this.rtbMale.BackColor = System.Drawing.Color.Linen;
            this.rtbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMale.ForeColor = System.Drawing.Color.Peru;
            this.rtbMale.Location = new System.Drawing.Point(171, 338);
            this.rtbMale.Name = "rtbMale";
            this.rtbMale.Size = new System.Drawing.Size(119, 44);
            this.rtbMale.TabIndex = 35;
            this.rtbMale.TabStop = true;
            this.rtbMale.Text = "Male";
            this.rtbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtbMale.UseVisualStyleBackColor = false;
            // 
            // rtbFemale
            // 
            this.rtbFemale.BackColor = System.Drawing.Color.Linen;
            this.rtbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFemale.ForeColor = System.Drawing.Color.Peru;
            this.rtbFemale.Location = new System.Drawing.Point(359, 339);
            this.rtbFemale.Name = "rtbFemale";
            this.rtbFemale.Size = new System.Drawing.Size(146, 50);
            this.rtbFemale.TabIndex = 36;
            this.rtbFemale.TabStop = true;
            this.rtbFemale.Text = "Female";
            this.rtbFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtbFemale.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.Location = new System.Drawing.Point(856, 12);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(91, 64);
            this.button24.TabIndex = 75;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(971, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 64);
            this.button8.TabIndex = 76;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(12, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 44);
            this.label7.TabIndex = 77;
            this.label7.Text = "Height";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudHeight
            // 
            this.nudHeight.BackColor = System.Drawing.SystemColors.Info;
            this.nudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.ForeColor = System.Drawing.Color.Peru;
            this.nudHeight.Location = new System.Drawing.Point(171, 405);
            this.nudHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(119, 39);
            this.nudHeight.TabIndex = 78;
            this.nudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(313, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 44);
            this.label8.TabIndex = 79;
            this.label8.Text = "Weight";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudWeight
            // 
            this.nudWeight.BackColor = System.Drawing.SystemColors.Info;
            this.nudWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.ForeColor = System.Drawing.Color.Peru;
            this.nudWeight.Location = new System.Drawing.Point(456, 405);
            this.nudWeight.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(119, 39);
            this.nudWeight.TabIndex = 80;
            this.nudWeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.BackColor = System.Drawing.SystemColors.Info;
            this.lbltotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Peru;
            this.lbltotalprice.Location = new System.Drawing.Point(672, 618);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(373, 53);
            this.lbltotalprice.TabIndex = 81;
            this.lbltotalprice.Text = "Personal Information";
            this.lbltotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(658, 909);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 73);
            this.button4.TabIndex = 82;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 994);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.rtbFemale);
            this.Controls.Add(this.rtbMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEoPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListBox lbProductList;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEoPN;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.ListBox lbInformation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rtbMale;
        private System.Windows.Forms.RadioButton rtbFemale;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button button4;
    }
}