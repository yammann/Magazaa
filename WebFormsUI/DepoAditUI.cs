using Business.Abstract;
using Business.Concreate;
using Business.Methods;
using DataAccess.Concreate.EntityFrameWork;
using DevExpress.XtraGrid.Views.Tile;
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
    public partial class DepoAditUI : Form
    {
        public DepoAditUI()
        {
            InitializeComponent();
            _storeService = new StoreManager(new EfStore());
            _productService=new ProductManager(new EfProduct());
        }
        private IStoreService _storeService;
        IProductService _productService;       
        DepoUI depoUI=new DepoUI(); 
        DialogsShow dialogsShow=new DialogsShow();
        public int id;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ImageMethod imageMethod = new ImageMethod();
            if (id == 0)
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _storeService.Add(new Store
                {
                    ProductId = Convert.ToInt32(tbxId.Text),
                    productName = tbxName.Text,
                    ProductQuantiti = Convert.ToInt16(tbxQuantity.Text),
                    Covir = imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Eklendi!", Color.LawnGreen);
                this.Close();
            }
            else
            {
                pictureEdit1.Image.Save(imageMethod.memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                _storeService.Update(new Store
                {
                    Id = id,
                    productName = tbxName.Text,
                    ProductId = Convert.ToInt32(tbxId.Text),
                    ProductQuantiti = Convert.ToInt32(tbxQuantity.Text),
                    Covir = imageMethod.ConvertToByte()
                });
                dialogsShow.DialogShow("Ürürn Güncelendi!", Color.Thistle);              
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            ImageMethod imageMethod = new ImageMethod();
            if(id==0)
            {
                if (tbxId.Text.Length != 0)
                {
                    int x = Convert.ToInt32(tbxId.Text);
                    var product = _productService.GetProductById(x);
                    var store = _storeService.GetStoreByProductId(x);
                    if (product != null)
                    {
                        tbxName.Text = product.ProductName;
                        imageMethod.by = product.Covir;
                        pictureEdit1.Image = Image.FromStream(imageMethod.ConvertToImage());
                    }
                    else tbxName.Clear();

                    if (store != null)
                    {
                        btnAdd.Enabled = false;
                        dialogsShow.DialogShow("Bu Ürürn Vardır!", Color.Azure);
                    }
                    else btnAdd.Enabled = true;
                }
            }  
        }
       
    }
}
