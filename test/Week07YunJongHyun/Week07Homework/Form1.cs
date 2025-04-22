using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    public partial class Form1: Form
    {
        List<Product> products;      

        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (tbxInputProductName.Text.Trim() == ""){//이름 미입력 시
                MessageBox.Show("제품이름을 입력해주세요");
                tbxInputProductName.Focus();
                return;
            }                        
            for (int i = 0; i < products.Count; i++){
                if (products[i] == null){   
                    if (index < 0) {
                        index = i;
                    }
                    index = i;
                }
                if (products[i].ProductName == tbxInputProductName.Text.Trim()){//중복 이름 제거
                    MessageBox.Show("같은 이름의 품목이 있습니다");
                    tbxInputProductName.Focus();
                    return;
                }
            }
                        
            Random random = new Random();
            string Now = DateTime.Now.ToString("yyyyMMdd");
            string code;
            bool isCode;
            do{
                code = Now + random.Next(1000).ToString("D3");//code생성
                isCode = false;
                foreach (var prod in products){
                    if (prod != null && prod.ProductCode == code){
                        isCode = true;
                        break;
                    }
                }
            } while (isCode);
            
            if (tbxInputProductPrice.Text.Trim() == ""){//가격 미입력시
                MessageBox.Show("가격을 입력해주세요");
                tbxInputProductPrice.Focus();
                return;
            }
            if (!int.TryParse(tbxInputProductPrice.Text, out int  pri)){//가격에 정수가 아닌게 들어왔을 시
                MessageBox.Show("가격에 정수를 입력해주세요");
                tbxInputProductPrice.Focus();
                return;
            }
            
            if (tbxInputProductStock.Text.Trim() == ""){//재고 미입력시
                MessageBox.Show("재고를 입력해주세요");
                tbxInputProductStock.Focus();
                return;
            }
            if (!int.TryParse(tbxInputProductStock.Text, out int sto)){//재고에 정수가 아닌게 들어왔을 시
                MessageBox.Show("재고에 정수를 입력해주세요");
                tbxInputProductStock.Focus();
                return;
            }

            lblInputProductName.Text = code;
            Product product = new Product();
            product.ProductName = tbxInputProductName.Text;
            product.ProductCode = code;
            product.ProductPrice = int.Parse(tbxInputProductPrice.Text);
            product.ProductStock = int.Parse(tbxInputProductStock.Text);
            product.ProductRegDate = DateTime.Now.AddDays(-random.Next(20, 100));
            
            products.Add(product);
            lbxSearchProduct.Items.Add(product);
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = (lbxSearchProduct.SelectedItem as Product);
            if (lbxSearchProduct.SelectedIndex < 0){
                return;
            }

            if (product != null){
                DisplaySelectedProduct(product);
            }
        }
        Product selectedProduct = null;
        private void DisplaySelectedProduct(Product product)
        {         
            selectedProduct = product;

            lblSearchProductName.Text = selectedProduct.ProductName;
            lblSearchProductCode.Text = selectedProduct.ProductCode;
            lblSearchProductPrice.Text = selectedProduct.ProductPrice.ToString();
            lblSearchProductSalePrice.Text = selectedProduct.SalePrice()+"%".ToString();
            lblSearchProductStock.Text = selectedProduct.ProductStock.ToString();
            lblSearchProductRegDate.Text = selectedProduct.ProductRegDate.ToString("yyyy-MM-dd");
        }

        private void DisplayReset()
        {
            lblSearchProductName.Text = "";
            lblSearchProductCode.Text = "";
            lblSearchProductPrice.Text = "";
            lblSearchProductSalePrice.Text = "";
            lblSearchProductStock.Text = "";
            lblSearchProductRegDate.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxSearchProduct.Items.Clear();
            DisplayReset();
            bool isExist = false;

            foreach (var pro in products) {
                isExist = pro.ProductName.Contains(tbxSearchNameCode.Text)|| 
                          pro.ProductCode.Contains(tbxSearchNameCode.Text);
                if (isExist) {
                    lbxSearchProduct.Items.Add(pro);
                }
                
            }
           
            if (isExist == false) { 
            MessageBox.Show("해당 코드 또는 제품이 없습니다");
            tbxSearchNameCode.Focus();
            return;
            }
        }

        

        private void btnCal_Click(object sender, EventArgs e)
        {
            
            if (tbxSearchProductCount.Text.Trim() == ""){
                MessageBox.Show("수량에 정수를 입력 해주세요");
                tbxSearchProductCount.Focus();
                return;
            }
            if(!int.TryParse(tbxSearchProductCount.Text, out int cnt)){
                MessageBox.Show("수량에 정수를 입력 해주세요");
                tbxSearchProductCount.Focus();
                return;
            }
            if (cnt>selectedProduct.ProductStock || cnt == 0){ 
                lblSearchProductTotalPrice.Text = "";
                return;
            }

            Product product = new Product();
            lblSearchProductTotalPrice.Text = selectedProduct.CalPrice(cnt).ToString();
        }
    }
}
