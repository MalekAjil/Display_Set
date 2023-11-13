namespace Display_set
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrUsbCheck = new System.Windows.Forms.Timer(this.components);
            this.USB = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChar = new System.Windows.Forms.ComboBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.nudAddress = new System.Windows.Forms.NumericUpDown();
            this.nextIdLbl = new System.Windows.Forms.Label();
            this.nextIdPhraseLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img_usb = new System.Windows.Forms.PictureBox();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_usb)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUsbCheck
            // 
            this.tmrUsbCheck.Enabled = true;
            this.tmrUsbCheck.Interval = 10;
            this.tmrUsbCheck.Tick += new System.EventHandler(this.tmrUsbCheck_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChar);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.nudAddress);
            this.panel1.Controls.Add(this.nextIdLbl);
            this.panel1.Controls.Add(this.nextIdPhraseLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.img_usb);
            this.panel1.Controls.Add(this.cbSymbol);
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.btnSend2);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 277);
            this.panel1.TabIndex = 0;
            // 
            // cbChar
            // 
            this.cbChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChar.FormattingEnabled = true;
            this.cbChar.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbChar.Location = new System.Drawing.Point(258, 192);
            this.cbChar.Name = "cbChar";
            this.cbChar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbChar.Size = new System.Drawing.Size(42, 27);
            this.cbChar.TabIndex = 48;
            // 
            // nudNumber
            // 
            this.nudNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumber.Location = new System.Drawing.Point(306, 193);
            this.nudNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(59, 27);
            this.nudNumber.TabIndex = 47;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "المحرف";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPort.Location = new System.Drawing.Point(123, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(54, 19);
            this.lblPort.TabIndex = 45;
            this.lblPort.Text = "Port0";
            this.lblPort.Visible = false;
            // 
            // nudAddress
            // 
            this.nudAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAddress.Location = new System.Drawing.Point(111, 193);
            this.nudAddress.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddress.Name = "nudAddress";
            this.nudAddress.Size = new System.Drawing.Size(59, 27);
            this.nudAddress.TabIndex = 44;
            this.nudAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAddress.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nextIdLbl
            // 
            this.nextIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextIdLbl.AutoSize = true;
            this.nextIdLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.nextIdLbl.Location = new System.Drawing.Point(18, 240);
            this.nextIdLbl.Name = "nextIdLbl";
            this.nextIdLbl.Size = new System.Drawing.Size(109, 19);
            this.nextIdLbl.TabIndex = 43;
            this.nextIdLbl.Text = "1234567890";
            this.nextIdLbl.Visible = false;
            // 
            // nextIdPhraseLbl
            // 
            this.nextIdPhraseLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextIdPhraseLbl.AutoSize = true;
            this.nextIdPhraseLbl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nextIdPhraseLbl.Location = new System.Drawing.Point(189, 240);
            this.nextIdPhraseLbl.Name = "nextIdPhraseLbl";
            this.nextIdPhraseLbl.Size = new System.Drawing.Size(180, 19);
            this.nextIdPhraseLbl.TabIndex = 42;
            this.nextIdPhraseLbl.Text = "الرسالة المستلمة هي : ";
            this.nextIdPhraseLbl.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "الرقم";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "الأمر";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "العنوان";
            // 
            // img_usb
            // 
            this.img_usb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_usb.BackgroundImage = global::Display_set.Properties.Resources.usb_black;
            this.img_usb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_usb.Location = new System.Drawing.Point(18, 12);
            this.img_usb.Name = "img_usb";
            this.img_usb.Size = new System.Drawing.Size(87, 60);
            this.img_usb.TabIndex = 6;
            this.img_usb.TabStop = false;
            // 
            // cbSymbol
            // 
            this.cbSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(178, 193);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSymbol.Size = new System.Drawing.Size(74, 27);
            this.cbSymbol.TabIndex = 4;

            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMsg.Location = new System.Drawing.Point(111, 92);
            this.txtMsg.MaxLength = 100;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMsg.Size = new System.Drawing.Size(252, 27);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.Text = "*2003dA555#";
            this.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMsg.Enter += new System.EventHandler(this.txtMsg_Enter);
            this.txtMsg.Leave += new System.EventHandler(this.txtMsg_Leave);
            // 
            // btnSend2
            // 
            this.btnSend2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend2.Location = new System.Drawing.Point(18, 186);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(87, 37);
            this.btnSend2.TabIndex = 6;
            this.btnSend2.Text = "ارسال";
            this.btnSend2.UseVisualStyleBackColor = false;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(18, 87);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 277);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Display Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_usb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrUsbCheck;
        private System.IO.Ports.SerialPort USB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.PictureBox img_usb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nextIdPhraseLbl;
        private System.Windows.Forms.Label nextIdLbl;
        private System.Windows.Forms.NumericUpDown nudAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cbChar;
    }
}

