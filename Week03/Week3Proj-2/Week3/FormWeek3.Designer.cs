namespace Week3
{
    partial class FormWeek3
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxData1 = new System.Windows.Forms.TextBox();
            this.tbxData2 = new System.Windows.Forms.TextBox();
            this.tbxData4 = new System.Windows.Forms.TextBox();
            this.tbxData3 = new System.Windows.Forms.TextBox();
            this.tbxData5 = new System.Windows.Forms.TextBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbtMul = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.btnProcess3 = new System.Windows.Forms.Button();
            this.btnProcess4 = new System.Windows.Forms.Button();
            this.btnProcess5 = new System.Windows.Forms.Button();
            this.btnProcess6 = new System.Windows.Forms.Button();
            this.btnProcess7 = new System.Windows.Forms.Button();
            this.btnProcess8 = new System.Windows.Forms.Button();
            this.btnProcess9 = new System.Windows.Forms.Button();
            this.btnProcess10 = new System.Windows.Forms.Button();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxData1
            // 
            this.tbxData1.Location = new System.Drawing.Point(13, 13);
            this.tbxData1.Name = "tbxData1";
            this.tbxData1.Size = new System.Drawing.Size(100, 21);
            this.tbxData1.TabIndex = 0;
            // 
            // tbxData2
            // 
            this.tbxData2.Location = new System.Drawing.Point(120, 12);
            this.tbxData2.Name = "tbxData2";
            this.tbxData2.Size = new System.Drawing.Size(100, 21);
            this.tbxData2.TabIndex = 1;
            // 
            // tbxData4
            // 
            this.tbxData4.Location = new System.Drawing.Point(333, 12);
            this.tbxData4.Name = "tbxData4";
            this.tbxData4.Size = new System.Drawing.Size(100, 21);
            this.tbxData4.TabIndex = 3;
            // 
            // tbxData3
            // 
            this.tbxData3.Location = new System.Drawing.Point(226, 13);
            this.tbxData3.Name = "tbxData3";
            this.tbxData3.Size = new System.Drawing.Size(100, 21);
            this.tbxData3.TabIndex = 2;
            // 
            // tbxData5
            // 
            this.tbxData5.Location = new System.Drawing.Point(439, 12);
            this.tbxData5.Name = "tbxData5";
            this.tbxData5.Size = new System.Drawing.Size(100, 21);
            this.tbxData5.TabIndex = 4;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(13, 40);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(60, 16);
            this.chkAdd.TabIndex = 5;
            this.chkAdd.Text = "더하기";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(120, 39);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(48, 16);
            this.chkSub.TabIndex = 6;
            this.chkSub.Text = "빼기";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(226, 40);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(60, 16);
            this.chkMul.TabIndex = 8;
            this.chkMul.Text = "곱하기";
            this.chkMul.UseVisualStyleBackColor = true;
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(333, 40);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(60, 16);
            this.chkDiv.TabIndex = 7;
            this.chkDiv.Text = "나누기";
            this.chkDiv.UseVisualStyleBackColor = true;
            // 
            // chkOption
            // 
            this.chkOption.AutoSize = true;
            this.chkOption.Location = new System.Drawing.Point(439, 40);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(50, 16);
            this.chkOption.TabIndex = 9;
            this.chkOption.Text = "ENG";
            this.chkOption.UseVisualStyleBackColor = true;
            this.chkOption.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rbtMul);
            this.pnlRadioGroup.Controls.Add(this.rbtDiv);
            this.pnlRadioGroup.Controls.Add(this.rbtSub);
            this.pnlRadioGroup.Controls.Add(this.rbtAdd);
            this.pnlRadioGroup.Location = new System.Drawing.Point(0, 63);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(433, 33);
            this.pnlRadioGroup.TabIndex = 11;
            this.pnlRadioGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbtMul
            // 
            this.rbtMul.AutoSize = true;
            this.rbtMul.Location = new System.Drawing.Point(226, 3);
            this.rbtMul.Name = "rbtMul";
            this.rbtMul.Size = new System.Drawing.Size(59, 16);
            this.rbtMul.TabIndex = 3;
            this.rbtMul.TabStop = true;
            this.rbtMul.Text = "곱하기";
            this.rbtMul.UseVisualStyleBackColor = true;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(333, 3);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(59, 16);
            this.rbtDiv.TabIndex = 2;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "나누기";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(120, 3);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(47, 16);
            this.rbtSub.TabIndex = 1;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "빼기";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Location = new System.Drawing.Point(12, 3);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(59, 16);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "더하기";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // btnProcess1
            // 
            this.btnProcess1.Location = new System.Drawing.Point(13, 111);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(75, 23);
            this.btnProcess1.TabIndex = 12;
            this.btnProcess1.Text = "연산1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.Location = new System.Drawing.Point(116, 111);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(75, 23);
            this.btnProcess2.TabIndex = 13;
            this.btnProcess2.Text = "연산2";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // btnProcess3
            // 
            this.btnProcess3.Location = new System.Drawing.Point(222, 111);
            this.btnProcess3.Name = "btnProcess3";
            this.btnProcess3.Size = new System.Drawing.Size(75, 23);
            this.btnProcess3.TabIndex = 15;
            this.btnProcess3.Text = "연산3";
            this.btnProcess3.UseVisualStyleBackColor = true;
            this.btnProcess3.Click += new System.EventHandler(this.btnProcess3_Click);
            // 
            // btnProcess4
            // 
            this.btnProcess4.Location = new System.Drawing.Point(329, 111);
            this.btnProcess4.Name = "btnProcess4";
            this.btnProcess4.Size = new System.Drawing.Size(75, 23);
            this.btnProcess4.TabIndex = 14;
            this.btnProcess4.Text = "연산4";
            this.btnProcess4.UseVisualStyleBackColor = true;
            this.btnProcess4.Click += new System.EventHandler(this.btnProcess4_Click);
            // 
            // btnProcess5
            // 
            this.btnProcess5.Location = new System.Drawing.Point(435, 111);
            this.btnProcess5.Name = "btnProcess5";
            this.btnProcess5.Size = new System.Drawing.Size(75, 23);
            this.btnProcess5.TabIndex = 17;
            this.btnProcess5.Text = "연산5";
            this.btnProcess5.UseVisualStyleBackColor = true;
            // 
            // btnProcess6
            // 
            this.btnProcess6.Location = new System.Drawing.Point(13, 159);
            this.btnProcess6.Name = "btnProcess6";
            this.btnProcess6.Size = new System.Drawing.Size(75, 23);
            this.btnProcess6.TabIndex = 16;
            this.btnProcess6.Text = "얼마1";
            this.btnProcess6.UseVisualStyleBackColor = true;
            this.btnProcess6.Click += new System.EventHandler(this.btnProcess6_Click);
            // 
            // btnProcess7
            // 
            this.btnProcess7.Location = new System.Drawing.Point(116, 159);
            this.btnProcess7.Name = "btnProcess7";
            this.btnProcess7.Size = new System.Drawing.Size(75, 23);
            this.btnProcess7.TabIndex = 19;
            this.btnProcess7.Text = "얼마2";
            this.btnProcess7.UseVisualStyleBackColor = true;
            this.btnProcess7.Click += new System.EventHandler(this.btnProcess7_Click);
            // 
            // btnProcess8
            // 
            this.btnProcess8.Location = new System.Drawing.Point(222, 159);
            this.btnProcess8.Name = "btnProcess8";
            this.btnProcess8.Size = new System.Drawing.Size(75, 23);
            this.btnProcess8.TabIndex = 18;
            this.btnProcess8.Text = "얼마3";
            this.btnProcess8.UseVisualStyleBackColor = true;
            this.btnProcess8.Click += new System.EventHandler(this.btnProcess8_Click);
            // 
            // btnProcess9
            // 
            this.btnProcess9.Location = new System.Drawing.Point(329, 159);
            this.btnProcess9.Name = "btnProcess9";
            this.btnProcess9.Size = new System.Drawing.Size(75, 23);
            this.btnProcess9.TabIndex = 21;
            this.btnProcess9.UseVisualStyleBackColor = true;
            // 
            // btnProcess10
            // 
            this.btnProcess10.Location = new System.Drawing.Point(435, 159);
            this.btnProcess10.Name = "btnProcess10";
            this.btnProcess10.Size = new System.Drawing.Size(75, 23);
            this.btnProcess10.TabIndex = 20;
            this.btnProcess10.UseVisualStyleBackColor = true;
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "아메리카노",
            "카페라떼",
            "플랫화이트"});
            this.cmbBeverage.Location = new System.Drawing.Point(12, 204);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(121, 20);
            this.cmbBeverage.TabIndex = 12;
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(139, 206);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(48, 16);
            this.chkIce.TabIndex = 22;
            this.chkIce.Text = "얼음";
            this.chkIce.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(13, 238);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(775, 203);
            this.lblResult.TabIndex = 23;
            // 
            // FormWeek3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkIce);
            this.Controls.Add(this.btnProcess9);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.btnProcess10);
            this.Controls.Add(this.pnlRadioGroup);
            this.Controls.Add(this.btnProcess7);
            this.Controls.Add(this.btnProcess8);
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.btnProcess5);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.btnProcess6);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.btnProcess3);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.btnProcess4);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.tbxData5);
            this.Controls.Add(this.btnProcess1);
            this.Controls.Add(this.tbxData4);
            this.Controls.Add(this.tbxData3);
            this.Controls.Add(this.tbxData2);
            this.Controls.Add(this.tbxData1);
            this.Name = "FormWeek3";
            this.Text = "Form1";
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData1;
        private System.Windows.Forms.TextBox tbxData2;
        private System.Windows.Forms.TextBox tbxData4;
        private System.Windows.Forms.TextBox tbxData3;
        private System.Windows.Forms.TextBox tbxData5;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.RadioButton rbtMul;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.Button btnProcess3;
        private System.Windows.Forms.Button btnProcess4;
        private System.Windows.Forms.Button btnProcess5;
        private System.Windows.Forms.Button btnProcess6;
        private System.Windows.Forms.Button btnProcess7;
        private System.Windows.Forms.Button btnProcess8;
        private System.Windows.Forms.Button btnProcess9;
        private System.Windows.Forms.Button btnProcess10;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.Label lblResult;
    }
}

