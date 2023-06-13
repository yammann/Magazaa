using Business.Methods;
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
using System.Data.Entity;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;
using DevExpress.XtraGrid;

namespace WebFormsUI
{
    public partial class ProductDisplayUI : Form
    {
        public ProductDisplayUI()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProduct());
        }
        private IProductService _productService;
        ImageMethod imageMethod =new ImageMethod();
        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            ProductAditUI productAditUI = new ProductAditUI();

            productAditUI.id = 0;
            productAditUI.Show();
            productAditUI.btnAdd.Text = "Ekle";
            productAditUI.btnAdd.ForeColor = Color.LawnGreen;
        }

        private void btnAditUpdate_Click(object sender, EventArgs e)
        {
            ProductAditUI productAditUI = new ProductAditUI();

            productAditUI.id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("Id"));
            productAditUI.Show();
            productAditUI.btnAdd.Text = "Günceleme";
            productAditUI.btnAdd.ForeColor = Color.Tomato;
            productAditUI.tbxName.Text = tileView1.GetFocusedRowCellValue("ProductName").ToString();
            productAditUI.tbxPrice.Text = tileView1.GetFocusedRowCellValue("Price").ToString();
            productAditUI.tbxQuantity.Text = tileView1.GetFocusedRowCellValue("Quantiti").ToString();
            imageMethod.by = (byte[])tileView1.GetFocusedRowCellValue("Covir");
            productAditUI.pictureEdit1.Image = Image.FromStream(imageMethod.ConvertToImage());
        }

        private void btnAditDelet_Click(object sender, EventArgs e)
        {
            ProductAditUI productAditUI = new ProductAditUI();

            productAditUI.id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("Id"));
            var result= MessageBox.Show("Bu ürün silmek istediğni emin misin?", "Silme işlem", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                productAditUI._productService.Delete(new Product { Id = productAditUI.id });
                Dialog dialog = new Dialog();
                dialog.Width = 400;
                dialog.lblDialog.Text = "Ürürn Silindi!";
                dialog.PnlColor.BackColor = Color.Tomato;
                dialog.Show();
                DataLoade();
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataLoade();
        }
        public void DataLoade()
        {
            ProductAditUI productAditUI = new ProductAditUI();

            gcData.DataSource = _productService.GetAll();
        }

    

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length == 0)
            {
                gcData.DataSource = _productService.GetAll();
            }
            else
            {
                gcData.DataSource = _productService.GetProductsbyProductName(tbxSearch.Text);

            }
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
