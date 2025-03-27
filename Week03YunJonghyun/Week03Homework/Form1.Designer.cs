namespace Week03Homework
{
    partial class FormMain
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
            this.ｂｔｎ７ = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ｂｔｎ７
            // 
            this.ｂｔｎ７.Location = new System.Drawing.Point(11, 78);
            this.ｂｔｎ７.Name = "ｂｔｎ７";
            this.ｂｔｎ７.Size = new System.Drawing.Size(42, 34);
            this.ｂｔｎ７.TabIndex = 0;
            this.ｂｔｎ７.Text = "７";
            this.ｂｔｎ７.UseVisualStyleBackColor = true;
            this.ｂｔｎ７.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.Location = new System.Drawing.Point(12, 9);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(173, 26);
            this.lblExpression.TabIndex = 1;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(12, 45);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(173, 30);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(55, 78);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 34);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(99, 78);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 34);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(143, 78);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(42, 34);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOper_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(143, 115);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(42, 34);
            this.btnMul.TabIndex = 9;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOper_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(99, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 34);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(55, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 34);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 34);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(143, 152);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(42, 34);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOper_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(99, 152);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 34);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(55, 152);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 34);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 152);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 34);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 34);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOper_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(55, 189);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(86, 34);
            this.btnCal.TabIndex = 16;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(11, 189);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 34);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 242);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.ｂｔｎ７);
            this.Name = "FormMain";
            this.Text = "계산기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ｂｔｎ７;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btn0;
    }
}

