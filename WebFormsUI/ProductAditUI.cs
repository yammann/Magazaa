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
    public partial class ProductAditUI : Form
    {
        public ProductAditUI()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProduct());
        }
        public IProductService _productService;
        ImageMethod imageMethod = new ImageMethod();
        DialogsShow dialogsShow = new DialogsShow();
        public int id;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(id==0)
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _productService.Add(new Product 
                {
                    ProductName=tbxName.Text,
                    Price=Convert.ToDecimal(tbxPrice.Text),
                    Quantiti=Convert.ToInt16(tbxQuantity.Text),
                    Covir=imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Eklendi!",Color.LawnGreen);                
                this.Close();
            }
            else
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _productService.Update(new Product
                {
                    Id=id,
                    ProductName = tbxName.Text,
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    Quantiti = Convert.ToInt32(tbxQuantity.Text),
                    Covir = imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Güncelendi!",Color.Thistle);              
                this.Close();
            }           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
