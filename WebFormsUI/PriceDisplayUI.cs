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
using Entities.Concreate;

namespace WebFormsUI
{
    public partial class PriceDisplayUI : Form
    {
        public PriceDisplayUI()
        {
            InitializeComponent();
            
            _productService = new ProductManager(new EfProduct());
        }
        IProductService _productService;
        private void gridControl1_Click(object sender, EventArgs e)
        {
            tbxFiyat.Text = tileView1.GetFocusedRowCellValue("Price").ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           if(tbxFiyat.Text.Length!=0)
            {
                var result = MessageBox.Show("Bu fiyat güncellemek istedinizdan emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _productService.Update(new Product
                    {
                        Id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("Id")),
                        ProductName = tileView1.GetFocusedRowCellValue("ProductName").ToString(),
                        Covir = (byte[])tileView1.GetFocusedRowCellValue("Covir"),
                        Quantiti = Convert.ToInt32(tileView1.GetFocusedRowCellValue("Quantiti")),
                        Price = Convert.ToDecimal(tbxFiyat.Text)
                    });
                    gridControl1.DataSource = _productService.GetAll();

                    Dialog dialog = new Dialog();
                    dialog.Width = 400;
                    dialog.lblDialog.Text = "Fiyat Güncelendi!";
                    dialog.PnlColor.BackColor = Color.Green;
                    dialog.Show();
                }
            }
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = _productService.GetProductsbyProductName(tbxSearch.Text);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length == 0)
            {
                gridControl1.DataSource = _productService.GetAll();
            }
            else
            {
                gridControl1.DataSource = _productService.GetProductsbyProductName(tbxSearch.Text);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
