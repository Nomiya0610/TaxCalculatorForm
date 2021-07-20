
namespace HomeWork0716.Forms
{
    partial class FormCalculator
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
            this.PnCQLTPn1 = new System.Windows.Forms.Panel();
            this.PnCQLT4 = new System.Windows.Forms.Panel();
            this.lblCQLtion = new System.Windows.Forms.Label();
            this.PnCQLT3 = new System.Windows.Forms.Panel();
            this.lblCC = new System.Windows.Forms.Label();
            this.PnCQLT2 = new System.Windows.Forms.Panel();
            this.lblUse = new System.Windows.Forms.Label();
            this.PnCQLT1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.radioBtnY = new System.Windows.Forms.RadioButton();
            this.radioBtnM = new System.Windows.Forms.RadioButton();
            this.lblFrom = new System.Windows.Forms.Label();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.CBboxUse = new System.Windows.Forms.ComboBox();
            this.CBboxCC = new System.Windows.Forms.ComboBox();
            this.btnCQL = new System.Windows.Forms.Button();
            this.btnDle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PnCQLTPn1.SuspendLayout();
            this.PnCQLT4.SuspendLayout();
            this.PnCQLT3.SuspendLayout();
            this.PnCQLT2.SuspendLayout();
            this.PnCQLT1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnCQLTPn1
            // 
            this.PnCQLTPn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.PnCQLTPn1.Controls.Add(this.PnCQLT4);
            this.PnCQLTPn1.Controls.Add(this.PnCQLT3);
            this.PnCQLTPn1.Controls.Add(this.PnCQLT2);
            this.PnCQLTPn1.Controls.Add(this.PnCQLT1);
            this.PnCQLTPn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnCQLTPn1.Location = new System.Drawing.Point(0, 0);
            this.PnCQLTPn1.Name = "PnCQLTPn1";
            this.PnCQLTPn1.Size = new System.Drawing.Size(206, 663);
            this.PnCQLTPn1.TabIndex = 0;
            // 
            // PnCQLT4
            // 
            this.PnCQLT4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.PnCQLT4.Controls.Add(this.lblCQLtion);
            this.PnCQLT4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCQLT4.Location = new System.Drawing.Point(0, 353);
            this.PnCQLT4.Margin = new System.Windows.Forms.Padding(0);
            this.PnCQLT4.Name = "PnCQLT4";
            this.PnCQLT4.Size = new System.Drawing.Size(206, 488);
            this.PnCQLT4.TabIndex = 3;
            // 
            // lblCQLtion
            // 
            this.lblCQLtion.AutoSize = true;
            this.lblCQLtion.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCQLtion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCQLtion.Location = new System.Drawing.Point(37, 124);
            this.lblCQLtion.Name = "lblCQLtion";
            this.lblCQLtion.Size = new System.Drawing.Size(123, 35);
            this.lblCQLtion.TabIndex = 0;
            this.lblCQLtion.Text = "試算結果";
            // 
            // PnCQLT3
            // 
            this.PnCQLT3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.PnCQLT3.Controls.Add(this.lblCC);
            this.PnCQLT3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCQLT3.Location = new System.Drawing.Point(0, 218);
            this.PnCQLT3.Margin = new System.Windows.Forms.Padding(0);
            this.PnCQLT3.Name = "PnCQLT3";
            this.PnCQLT3.Size = new System.Drawing.Size(206, 135);
            this.PnCQLT3.TabIndex = 2;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCC.Location = new System.Drawing.Point(37, 13);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(129, 62);
            this.lblCC.TabIndex = 0;
            this.lblCC.Text = "汽缸CC數/\r\n馬達馬力";
            // 
            // PnCQLT2
            // 
            this.PnCQLT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.PnCQLT2.Controls.Add(this.lblUse);
            this.PnCQLT2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCQLT2.Location = new System.Drawing.Point(0, 149);
            this.PnCQLT2.Margin = new System.Windows.Forms.Padding(0);
            this.PnCQLT2.Name = "PnCQLT2";
            this.PnCQLT2.Size = new System.Drawing.Size(206, 69);
            this.PnCQLT2.TabIndex = 1;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUse.Location = new System.Drawing.Point(69, 16);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(62, 31);
            this.lblUse.TabIndex = 0;
            this.lblUse.Text = "用途";
            // 
            // PnCQLT1
            // 
            this.PnCQLT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.PnCQLT1.Controls.Add(this.lblTime);
            this.PnCQLT1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCQLT1.Location = new System.Drawing.Point(0, 0);
            this.PnCQLT1.Margin = new System.Windows.Forms.Padding(0);
            this.PnCQLT1.Name = "PnCQLT1";
            this.PnCQLT1.Size = new System.Drawing.Size(206, 149);
            this.PnCQLT1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.Location = new System.Drawing.Point(31, 61);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(145, 40);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "使用期間";
            // 
            // radioBtnY
            // 
            this.radioBtnY.AutoSize = true;
            this.radioBtnY.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnY.Location = new System.Drawing.Point(278, 12);
            this.radioBtnY.Name = "radioBtnY";
            this.radioBtnY.Size = new System.Drawing.Size(127, 39);
            this.radioBtnY.TabIndex = 1;
            this.radioBtnY.TabStop = true;
            this.radioBtnY.Text = "全年度";
            this.radioBtnY.UseVisualStyleBackColor = true;
            // 
            // radioBtnM
            // 
            this.radioBtnM.AutoSize = true;
            this.radioBtnM.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnM.Location = new System.Drawing.Point(431, 12);
            this.radioBtnM.Name = "radioBtnM";
            this.radioBtnM.Size = new System.Drawing.Size(127, 39);
            this.radioBtnM.TabIndex = 2;
            this.radioBtnM.TabStop = true;
            this.radioBtnM.Text = "依期間";
            this.radioBtnM.UseVisualStyleBackColor = true;
            this.radioBtnM.CheckedChanged += new System.EventHandler(this.radioBtnMonth_CheckedChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFrom.Location = new System.Drawing.Point(209, 78);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(42, 35);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "從";
            this.lblFrom.Visible = false;
            // 
            // DTPFrom
            // 
            this.DTPFrom.Location = new System.Drawing.Point(278, 77);
            this.DTPFrom.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.DTPFrom.MinDate = new System.DateTime(1945, 6, 11, 0, 0, 0, 0);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(200, 36);
            this.DTPFrom.TabIndex = 4;
            this.DTPFrom.Value = new System.DateTime(2021, 7, 17, 3, 0, 40, 0);
            this.DTPFrom.Visible = false;
            // 
            // DTPTo
            // 
            this.DTPTo.Location = new System.Drawing.Point(588, 78);
            this.DTPTo.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.DTPTo.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(200, 36);
            this.DTPTo.TabIndex = 5;
            this.DTPTo.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTo.Location = new System.Drawing.Point(513, 79);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(42, 35);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "至";
            this.lblTo.Visible = false;
            // 
            // CBboxUse
            // 
            this.CBboxUse.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBboxUse.FormattingEnabled = true;
            this.CBboxUse.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.CBboxUse.Location = new System.Drawing.Point(278, 165);
            this.CBboxUse.Name = "CBboxUse";
            this.CBboxUse.Size = new System.Drawing.Size(542, 43);
            this.CBboxUse.TabIndex = 7;
            this.CBboxUse.Text = "              ----------請選擇----------";
            this.CBboxUse.SelectedIndexChanged += new System.EventHandler(this.CBboxUse_SelectedIndexChanged);
            // 
            // CBboxCC
            // 
            this.CBboxCC.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBboxCC.FormattingEnabled = true;
            this.CBboxCC.Location = new System.Drawing.Point(278, 250);
            this.CBboxCC.Name = "CBboxCC";
            this.CBboxCC.Size = new System.Drawing.Size(542, 43);
            this.CBboxCC.TabIndex = 8;
            this.CBboxCC.Text = "              ----------請選擇----------";
            // 
            // btnCQL
            // 
            this.btnCQL.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCQL.Location = new System.Drawing.Point(359, 304);
            this.btnCQL.Name = "btnCQL";
            this.btnCQL.Size = new System.Drawing.Size(119, 49);
            this.btnCQL.TabIndex = 9;
            this.btnCQL.Text = "計算";
            this.btnCQL.UseVisualStyleBackColor = true;
            this.btnCQL.Click += new System.EventHandler(this.btnCQL_Click);
            // 
            // btnDle
            // 
            this.btnDle.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDle.Location = new System.Drawing.Point(588, 304);
            this.btnDle.Name = "btnDle";
            this.btnDle.Size = new System.Drawing.Size(119, 49);
            this.btnDle.TabIndex = 10;
            this.btnDle.Text = "清除";
            this.btnDle.UseVisualStyleBackColor = true;
            this.btnDle.Click += new System.EventHandler(this.btnDle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 353);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(608, 298);
            this.textBox1.TabIndex = 12;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1422, 663);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDle);
            this.Controls.Add(this.btnCQL);
            this.Controls.Add(this.CBboxCC);
            this.Controls.Add(this.CBboxUse);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.DTPTo);
            this.Controls.Add(this.DTPFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.radioBtnM);
            this.Controls.Add(this.radioBtnY);
            this.Controls.Add(this.PnCQLTPn1);
            this.Name = "FormCalculator";
            this.Text = "使用牌照稅試算";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.PnCQLTPn1.ResumeLayout(false);
            this.PnCQLT4.ResumeLayout(false);
            this.PnCQLT4.PerformLayout();
            this.PnCQLT3.ResumeLayout(false);
            this.PnCQLT3.PerformLayout();
            this.PnCQLT2.ResumeLayout(false);
            this.PnCQLT2.PerformLayout();
            this.PnCQLT1.ResumeLayout(false);
            this.PnCQLT1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnCQLTPn1;
        private System.Windows.Forms.Panel PnCQLT1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel PnCQLT4;
        private System.Windows.Forms.Label lblCQLtion;
        private System.Windows.Forms.Panel PnCQLT3;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Panel PnCQLT2;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.RadioButton radioBtnY;
        private System.Windows.Forms.RadioButton radioBtnM;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox CBboxUse;
        private System.Windows.Forms.ComboBox CBboxCC;
        private System.Windows.Forms.Button btnCQL;
        private System.Windows.Forms.Button btnDle;
        private System.Windows.Forms.TextBox textBox1;
    }
}