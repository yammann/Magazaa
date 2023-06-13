using Business.Abstract;
using Business.Concreate;
using Business.Methods;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class ReturnUI : Form
    {
        public ReturnUI()
        {
            InitializeComponent();
            _oneOrderService = new oneOrderManager(new EfoneOrder());
            _productService = new ProductManager(new EfProduct());
            _orderService = new OrderManager(new EfOrder());
        }
        IoneOrderService _oneOrderService;
        IProductService _productService;
        IOrderService _orderService;
        ImageMethod imageMethod = new ImageMethod();
        bool defanc = false;
        private void tbxQuantiti_TextChanged(object sender, EventArgs e)
        {
            if(tbxOrderId.Text.Length!=0)
            {
                gridControl1.DataSource= _oneOrderService.GetoneOrderbyOrderId(Convert.ToInt64(tbxOrderId.Text));
                if(gridControl1.DataSource!=null)
                {
                    lblSparişFiyat.Text = _orderService.GetOrderPrice(Convert.ToInt64(tbxOrderId.Text)).ToString() ;
                }
            }
           
        }

        private void tbxQuantiti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            defanc = true;
            int productid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProductId"));
            var product=_productService.GetProductById(productid);
            imageMethod.by = product.Covir;
            lblName.Text = product.ProductName;
            lblPrice.Text = product.Price.ToString();
            lblProductId.Text = product.Id.ToString();
            lblQuantiti.Text=product.Quantiti.ToString();
            picProduct.Image = Image.FromStream(imageMethod.ConvertToImage());
            lblFinalPrice.Text = gridView1.GetFocusedRowCellValue("FinalPrice").ToString();
            lblOrderProductId.Text=gridView1.GetFocusedRowCellValue("Id").ToString();
            lblOrderQuantiti.Text = gridView1.GetFocusedRowCellValue("Quantiti").ToString();
        }

        private void btnReturnOneProduct_Click(object sender, EventArgs e)
        {
            if(defanc)
            {
                int id = Convert.ToInt32(lblOrderProductId.Text);
                var result = MessageBox.Show("bu ürün iade edelecek!", "Uyar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _oneOrderService.Delete(new oneOrder { Id = id });
                    var orderPrice = _orderService.GetOrderPrice(Convert.ToInt64(tbxOrderId.Text));
                    var productPrice = Convert.ToDouble(lblFinalPrice.Text);
                    _orderService.Update(new Order
                    {
                        OrderDate = DateTime.Now,
                        orderId = Convert.ToInt64(tbxOrderId.Text),
                        OrderPrice = orderPrice - productPrice
                    });
                    lblSparişFiyat.Text = _orderService.GetOrderPrice(Convert.ToInt64(tbxOrderId.Text)).ToString();
                    gridControl1.DataSource = _oneOrderService.GetoneOrderbyOrderId(Convert.ToInt64(tbxOrderId.Text));
                    int adet = Convert.ToInt32(lblOrderQuantiti.Text);
                    _productService.Update(new Product
                    {
                        Id = Convert.ToInt32(lblProductId.Text),
                        ProductName = lblName.Text,
                        Quantiti = Convert.ToInt32(lblQuantiti.Text) + adet,
                        Price = Convert.ToDecimal(lblPrice.Text),
                        Covir = imageMethod.by
                    });
                    var product = _productService.GetProductById(Convert.ToInt32(lblProductId.Text));
                    lblQuantiti.Text = product.Quantiti.ToString();
                    defanc = false;
                }
            }
            
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if(tbxOrderId.Text.Length!=0)
            {
                var orderid = Convert.ToInt64(tbxOrderId.Text);
                var result = MessageBox.Show("Bu sipariş silmek istediğinizden emin misin ?", "Uyar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var orderProductId = _oneOrderService.GetoneOrderProductId(orderid);
                    foreach (var id in orderProductId)
                    {

                        var product = _productService.GetProductById(id);
                        var quantiti = _oneOrderService.GetoneOrderQuantitiByProductId(id, orderid);
                        _productService.Update(new Product
                        {
                            Id = product.Id,
                            ProductName = product.ProductName,
                            Quantiti = product.Quantiti + quantiti,
                            Price = product.Price,
                            Covir = product.Covir
                        });
                    }
                    var oneorder = _oneOrderService.GetoneOrderId(Convert.ToInt64(tbxOrderId.Text));
                    foreach (var id in oneorder)
                    {
                        _oneOrderService.Delete(new oneOrder { Id = id });
                    }
                    _orderService.Delete(new Order { orderId = orderid });
                    gridControl1.DataSource = _oneOrderService.GetoneOrderbyOrderId(Convert.ToInt64(tbxOrderId.Text));

                }
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
