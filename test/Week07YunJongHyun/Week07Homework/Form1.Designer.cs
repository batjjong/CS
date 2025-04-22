namespace Week07Homework
{
    partial class Form1
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxInputProductStock = new System.Windows.Forms.TextBox();
            this.tbxInputProductPrice = new System.Windows.Forms.TextBox();
            this.tbxInputProductName = new System.Windows.Forms.TextBox();
            this.lblInputProductStock = new System.Windows.Forms.Label();
            this.lblInputProductPrice = new System.Windows.Forms.Label();
            this.lblInputProductName = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblSearchProductRegDate = new System.Windows.Forms.Label();
            this.lblSearchProductStock = new System.Windows.Forms.Label();
            this.lblSearchProductSalePrice = new System.Windows.Forms.Label();
            this.lblSearchProductPrice = new System.Windows.Forms.Label();
            this.lblSearchProductCode = new System.Windows.Forms.Label();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.lblSearchProductTotalPrice = new System.Windows.Forms.Label();
            this.tbxSearchProductCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchNameCode = new System.Windows.Forms.TextBox();
            this.lbxSearchProduct = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxInput.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnInput);
            this.gbxInput.Controls.Add(this.tbxInputProductStock);
            this.gbxInput.Controls.Add(this.tbxInputProductPrice);
            this.gbxInput.Controls.Add(this.tbxInputProductName);
            this.gbxInput.Controls.Add(this.lblInputProductStock);
            this.gbxInput.Controls.Add(this.lblInputProductPrice);
            this.gbxInput.Controls.Add(this.lblInputProductName);
            this.gbxInput.Location = new System.Drawing.Point(13, 13);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(200, 211);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "상품등록";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(94, 123);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(100, 23);
            this.btnInput.TabIndex = 7;
            this.btnInput.Text = "등록";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbxInputProductStock
            // 
            this.tbxInputProductStock.Location = new System.Drawing.Point(94, 84);
            this.tbxInputProductStock.Name = "tbxInputProductStock";
            this.tbxInputProductStock.Size = new System.Drawing.Size(100, 21);
            this.tbxInputProductStock.TabIndex = 8;
            // 
            // tbxInputProductPrice
            // 
            this.tbxInputProductPrice.Location = new System.Drawing.Point(94, 51);
            this.tbxInputProductPrice.Name = "tbxInputProductPrice";
            this.tbxInputProductPrice.Size = new System.Drawing.Size(100, 21);
            this.tbxInputProductPrice.TabIndex = 7;
            // 
            // tbxInputProductName
            // 
            this.tbxInputProductName.Location = new System.Drawing.Point(94, 18);
            this.tbxInputProductName.Name = "tbxInputProductName";
            this.tbxInputProductName.Size = new System.Drawing.Size(100, 21);
            this.tbxInputProductName.TabIndex = 6;
            // 
            // lblInputProductStock
            // 
            this.lblInputProductStock.AutoSize = true;
            this.lblInputProductStock.Location = new System.Drawing.Point(6, 87);
            this.lblInputProductStock.Name = "lblInputProductStock";
            this.lblInputProductStock.Size = new System.Drawing.Size(29, 12);
            this.lblInputProductStock.TabIndex = 2;
            this.lblInputProductStock.Text = "재고";
            // 
            // lblInputProductPrice
            // 
            this.lblInputProductPrice.AutoSize = true;
            this.lblInputProductPrice.Location = new System.Drawing.Point(6, 54);
            this.lblInputProductPrice.Name = "lblInputProductPrice";
            this.lblInputProductPrice.Size = new System.Drawing.Size(29, 12);
            this.lblInputProductPrice.TabIndex = 1;
            this.lblInputProductPrice.Text = "가격";
            // 
            // lblInputProductName
            // 
            this.lblInputProductName.AutoSize = true;
            this.lblInputProductName.Location = new System.Drawing.Point(6, 21);
            this.lblInputProductName.Name = "lblInputProductName";
            this.lblInputProductName.Size = new System.Drawing.Size(29, 12);
            this.lblInputProductName.TabIndex = 0;
            this.lblInputProductName.Text = "이름";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnCal);
            this.gbxSearch.Controls.Add(this.lblSearchProductRegDate);
            this.gbxSearch.Controls.Add(this.lblSearchProductStock);
            this.gbxSearch.Controls.Add(this.lblSearchProductSalePrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductPrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductCode);
            this.gbxSearch.Controls.Add(this.lblSearchProductName);
            this.gbxSearch.Controls.Add(this.lblSearchProductTotalPrice);
            this.gbxSearch.Controls.Add(this.tbxSearchProductCount);
            this.gbxSearch.Controls.Add(this.label9);
            this.gbxSearch.Controls.Add(this.label10);
            this.gbxSearch.Controls.Add(this.label11);
            this.gbxSearch.Controls.Add(this.label12);
            this.gbxSearch.Controls.Add(this.label7);
            this.gbxSearch.Controls.Add(this.label8);
            this.gbxSearch.Controls.Add(this.label6);
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.tbxSearchNameCode);
            this.gbxSearch.Controls.Add(this.lbxSearchProduct);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Location = new System.Drawing.Point(235, 13);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(404, 286);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "상품조회";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(329, 218);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(58, 23);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "수량";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblSearchProductRegDate
            // 
            this.lblSearchProductRegDate.Location = new System.Drawing.Point(243, 185);
            this.lblSearchProductRegDate.Name = "lblSearchProductRegDate";
            this.lblSearchProductRegDate.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductRegDate.TabIndex = 24;
            // 
            // lblSearchProductStock
            // 
            this.lblSearchProductStock.Location = new System.Drawing.Point(243, 156);
            this.lblSearchProductStock.Name = "lblSearchProductStock";
            this.lblSearchProductStock.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductStock.TabIndex = 23;
            // 
            // lblSearchProductSalePrice
            // 
            this.lblSearchProductSalePrice.Location = new System.Drawing.Point(243, 127);
            this.lblSearchProductSalePrice.Name = "lblSearchProductSalePrice";
            this.lblSearchProductSalePrice.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductSalePrice.TabIndex = 22;
            // 
            // lblSearchProductPrice
            // 
            this.lblSearchProductPrice.Location = new System.Drawing.Point(243, 98);
            this.lblSearchProductPrice.Name = "lblSearchProductPrice";
            this.lblSearchProductPrice.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductPrice.TabIndex = 21;
            // 
            // lblSearchProductCode
            // 
            this.lblSearchProductCode.Location = new System.Drawing.Point(243, 69);
            this.lblSearchProductCode.Name = "lblSearchProductCode";
            this.lblSearchProductCode.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductCode.TabIndex = 20;
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.Location = new System.Drawing.Point(243, 40);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductName.TabIndex = 19;
            // 
            // lblSearchProductTotalPrice
            // 
            this.lblSearchProductTotalPrice.Location = new System.Drawing.Point(243, 252);
            this.lblSearchProductTotalPrice.Name = "lblSearchProductTotalPrice";
            this.lblSearchProductTotalPrice.Size = new System.Drawing.Size(144, 12);
            this.lblSearchProductTotalPrice.TabIndex = 18;
            // 
            // tbxSearchProductCount
            // 
            this.tbxSearchProductCount.Location = new System.Drawing.Point(245, 220);
            this.tbxSearchProductCount.Name = "tbxSearchProductCount";
            this.tbxSearchProductCount.Size = new System.Drawing.Size(78, 21);
            this.tbxSearchProductCount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(180, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "총가격";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(180, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "수량";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(180, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "등록일자";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(180, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "재고";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(180, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "할인가격";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(180, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "가격";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(180, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "코드";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(180, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "이름";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearchNameCode
            // 
            this.tbxSearchNameCode.Location = new System.Drawing.Point(8, 37);
            this.tbxSearchNameCode.Name = "tbxSearchNameCode";
            this.tbxSearchNameCode.Size = new System.Drawing.Size(142, 21);
            this.tbxSearchNameCode.TabIndex = 5;
            // 
            // lbxSearchProduct
            // 
            this.lbxSearchProduct.FormattingEnabled = true;
            this.lbxSearchProduct.ItemHeight = 12;
            this.lbxSearchProduct.Location = new System.Drawing.Point(8, 93);
            this.lbxSearchProduct.Name = "lbxSearchProduct";
            this.lbxSearchProduct.Size = new System.Drawing.Size(142, 88);
            this.lbxSearchProduct.TabIndex = 4;
            this.lbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.lbxSearchProduct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "이름 & 코드";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 311);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "7주차 숙제";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Label lblInputProductStock;
        private System.Windows.Forms.Label lblInputProductPrice;
        private System.Windows.Forms.Label lblInputProductName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbxInputProductStock;
        private System.Windows.Forms.TextBox tbxInputProductPrice;
        private System.Windows.Forms.TextBox tbxInputProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchNameCode;
        private System.Windows.Forms.ListBox lbxSearchProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSearchProductName;
        private System.Windows.Forms.Label lblSearchProductTotalPrice;
        private System.Windows.Forms.TextBox tbxSearchProductCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSearchProductRegDate;
        private System.Windows.Forms.Label lblSearchProductStock;
        private System.Windows.Forms.Label lblSearchProductSalePrice;
        private System.Windows.Forms.Label lblSearchProductPrice;
        private System.Windows.Forms.Label lblSearchProductCode;
        private System.Windows.Forms.Button btnCal;
    }
}

