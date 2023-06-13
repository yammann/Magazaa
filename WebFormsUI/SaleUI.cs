using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Abstract;
using Entities.Concreate;
using Business.Methods;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Business.Report;

namespace WebFormsUI
{
    public partial class SaleUI : Form
    {
        public SaleUI()
        {
            InitializeComponent();
            _oneorderService = new oneOrderManager(new EfoneOrder());
            _productService = new ProductManager(new EfProduct());
            _orderService = new OrderManager(new EfOrder());
        }
        IoneOrderService _oneorderService;
        IProductService _productService;
        IOrderService _orderService;
        BaseForm baseForm = new BaseForm();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(lblQuantiti.Text);
            int y=Convert.ToInt32(tbxQuantiti.Text);
            if(x>=y)
            {
                var productIdInTheOrder = _oneorderService.GetoneOrderProductId(Convert.ToInt64(lblOrderId.Text));
                var productId = Convert.ToInt32(lblProductId.Text);
                var orderId = Convert.ToInt64(lblOrderId.Text);
                if (productIdInTheOrder.Contains(productId))
                {
                    var oneorder = _oneorderService.GetonOrder(productId, orderId);
                    _oneorderService.Update(new oneOrder
                    {
                        Id = oneorder.Id,
                        ProductId = oneorder.ProductId,
                        Ddate = oneorder.Ddate,
                        Price = oneorder.Price,
                        Quantiti = oneorder.Quantiti + Convert.ToInt32(tbxQuantiti.Text),
                        FinalPrice = oneorder.FinalPrice + Convert.ToInt32(lblFinalPrice.Text),
                        discount = oneorder.discount,
                        OrderId = oneorder.OrderId,
                    });
                }
                else
                {
                    _oneorderService.Add(new oneOrder
                    {
                        ProductId = Convert.ToInt32(lblProductId.Text),
                        Price = Convert.ToDouble(lblPrice.Text),
                        discount =1- Convert.ToDouble(cobDiscount.Text),
                        Ddate = DateTime.Now,
                        OrderId = Convert.ToInt64(lblOrderId.Text),
                        FinalPrice = Convert.ToDouble(lblFinalPrice.Text),
                        Quantiti = Convert.ToInt16(tbxQuantiti.Text)
                    });
                }
                gridControl1.DataSource = _oneorderService.GetoneOrderbyOrderId(Convert.ToInt64(lblOrderId.Text));
                TotalOrderPrice();
                int adet = Convert.ToInt32(tbxQuantiti.Text);
                ImageMethod imageMethod = new ImageMethod();
                picProduct.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _productService.Update(new Product
                {
                    Id = Convert.ToInt32(lblProductId.Text),
                    Quantiti = Convert.ToInt32(lblQuantiti.Text) - adet,
                    ProductName = lblName.Text,
                    Price = Convert.ToDecimal(lblPrice.Text),
                    Covir = imageMethod.ConvertToByte()
                });
                var product = _productService.GetProductName(cobProduct.Text);
                lblQuantiti.Text = product.Quantiti.ToString();
            }
            else
            {
                Dialog dialog= new Dialog();
                dialog.lblDialog.Text = "mağazadaki melzeme yetmiyor!";
                dialog.PnlColor.BackColor = Color.Tomato;
                dialog.Show();
            }
            
            
        }

        private void TotalOrderPrice()
        {
            double result = 0;
            double[] fiyatlar = _oneorderService.GetFiyatlar(Convert.ToInt64(lblOrderId.Text));
            foreach (var fiyat in fiyatlar)
            {
                result += fiyat;
            }
            lblSparişFiyat.Text = result.ToString();
        }

        private void cobProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = _productService.GetProductName(cobProduct.Text);

            ImageMethod imageMethod = new ImageMethod();
            imageMethod.by = product.Covir;
            lblName.Text = product.ProductName;
            lblPrice.Text = product.Price.ToString();
            lblProductId.Text=product.Id.ToString();
            lblQuantiti.Text= product.Quantiti.ToString();
            picProduct.Image = Image.FromStream(imageMethod.ConvertToImage());
            lblFinalPrice.Text = PriceCalculator().ToString();
            tbxQuantiti.Enabled = true;
            cobDiscount.Enabled = true;
            btnAdd.Enabled = true;

        }
        public double PriceCalculator()
        {
            var product = _productService.GetProductName(cobProduct.Text);
            var price=Convert.ToDouble(product.Price);
            var discount = 1-Convert.ToDouble(cobDiscount.Text);
            int quantiti;
            if (tbxQuantiti.Text.Length==0)
            {
                quantiti =0 ;

            }
            else   quantiti =Convert.ToInt16( tbxQuantiti.Text);
            
            double result = price * quantiti * discount;
            return result;
        }

        private void cobDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFinalPrice.Text = PriceCalculator().ToString();

        }

        private void tbxQuantiti_TextChanged(object sender, EventArgs e)
        {
            lblFinalPrice.Text = PriceCalculator().ToString();
        }

        private void tbxQuantiti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnOrderFinish_Click(object sender, EventArgs e)
        {
            var oneorder = _oneorderService.GetoneOrderbyOrderId(Convert.ToInt64( lblOrderId.Text));
            if(oneorder.Count!=0)
            {
                var result = MessageBox.Show("fiş yazdırmak istiyormusun !", "Uyar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OneOrderRepo oneOrderRepo = new OneOrderRepo();
                    var orderid = Convert.ToInt64(lblOrderId.Text);
                    string filter = string.Format("OrderId={0} ", orderid);
                    oneOrderRepo.FilterString = filter;
                    oneOrderRepo.ShowPreview();
                }
                _orderService.Add(new Order
                {
                    orderId = Convert.ToInt64(lblOrderId.Text),
                    OrderPrice = Convert.ToDouble(lblSparişFiyat.Text),
                    OrderDate = DateTime.Now,
                    EmployeeName =baseForm.lblEmployeeName.Text
                });
                gridControl1.DataSource = null;
                lblOrderId.Text =_oneorderService.OrderId().ToString();
            }
            
        }
        private void btnDelet_Click(object sender, EventArgs e)
        {
            int id = 0;
            int adet = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Quantiti"));
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            int productid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProductId"));
            if (id != 0)
            {
                _oneorderService.Delete(new oneOrder
                {
                    Id = id,
                });
                gridControl1.DataSource = _oneorderService.GetoneOrderbyOrderId(Convert.ToInt64(lblOrderId.Text));
                TotalOrderPrice();
                var product = _productService.GetProductById(productid);
                _productService.Update(new Product
                {
                    Id = productid,
                    Quantiti = product.Quantiti + adet,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Covir = product.Covir
                });
            }          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mağaza Adı", new Font("tahoma", 10), Brushes.Black, new Point(100, 50));
            e.Graphics.DrawString("Tarih "+"   "+DateTime.Now, new Font("tahoma", 10), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("----------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(100, 150));
            Bitmap gridbmp = new Bitmap(gridControl1.Width, gridControl1.Height);
            gridControl1.DrawToBitmap(gridbmp, new Rectangle(0, 0, gridControl1.Width, gridControl1.Height));
            e.Graphics.DrawImage(gridbmp, 120, 200);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
