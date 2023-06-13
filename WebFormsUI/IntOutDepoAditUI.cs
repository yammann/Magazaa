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
    public partial class IntOutDepoAditUI : Form
    {
        public IntOutDepoAditUI()
        {
            InitializeComponent();
            _storeService = new StoreManager(new EfStore());
            _intOutStoreService = new IntOutStoreManager(new EfIntOutStore());
            _productService = new ProductManager(new EfProduct());
        }
        private IStoreService _storeService;
        IIntOutStoreService _intOutStoreService;
        private IProductService _productService;
        DialogsShow dialogsShow = new DialogsShow();

        public int id;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(tbxId.Text);
            if (id == 0)
            {
                var store=_storeService.GetStoreByProductId(productid);
                if(store!= null)
                {
                    _intOutStoreService.Add(new IntOutStore
                    {
                        ProductId= Convert.ToInt32(productid),
                        ProductName=tbxName.Text,
                        Quantiti=Convert.ToInt32(tbxQuantity.Text),
                        BusinessDate=DateTime.Now,
                        ByPrice=Convert.ToDouble(tbxByPrice.Text),
                        Note=tbxNote.Text,
                        SorceName=tbxSorceName.Text,
                        Business=tbxBusiness.Text,               
                    });
                    _storeService.Update(new Store
                    {
                        Id=store.Id,
                        ProductId=store.ProductId,
                        productName=store.productName,
                        ProductQuantiti=store.ProductQuantiti+ Convert.ToInt32(tbxQuantity.Text),
                        Covir=store.Covir,
                    });
                    dialogsShow.DialogShow("girdirme işlem ypıldı!",Color.LawnGreen);
                    this.Close();   
                }
            }
            if (id == 1)
            {
                var store = _storeService.GetStoreByProductId(productid);               
                if (store != null)
                {
                    if (store.ProductQuantiti < Convert.ToInt32(tbxQuantity.Text))
                    {
                        dialogsShow.DialogShow( "Depodaki adet yetersiz!",Color.BlueViolet);
                    }
                    else
                    {
                        var result = MessageBox.Show("Bu ürün mağazaya götürülecek mi ?", "Sorgulama", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            var product = _productService.GetProductById(productid);
                            if (product != null)
                            {
                                _productService.Update(new Product
                                {
                                    Id = productid,
                                    Quantiti = product.Quantiti + Convert.ToInt32(tbxQuantity.Text),
                                    ProductName = product.ProductName,
                                    Price = product.Price,
                                    Covir = product.Covir
                                });



                                _intOutStoreService.Add(new IntOutStore
                                {
                                    ProductId = Convert.ToInt32(productid),
                                    ProductName = tbxName.Text,
                                    Quantiti = Convert.ToInt32(tbxQuantity.Text),
                                    BusinessDate = DateTime.Now,
                                    Note = tbxNote.Text,
                                    SorceName = tbxSorceName.Text,
                                    Business = tbxBusiness.Text,
                                });
                                _storeService.Update(new Store
                                {
                                    Id = store.Id,
                                    ProductId = store.ProductId,
                                    productName = store.productName,
                                    ProductQuantiti = store.ProductQuantiti - Convert.ToInt32(tbxQuantity.Text),
                                    Covir = store.Covir,
                                });
                                var store1 = _storeService.GetStoreByProductId(productid);
                                if(store1.ProductQuantiti<=10)
                                {
                                    dialogsShow.DialogShow("Çıkartma işlem ypıldı ve bu ürün depo'de çok azaldı !", Color.BlueViolet);
                                    this.Close();
                                }
                                else
                                {
                                    dialogsShow.DialogShow("Çıkartma işlem ypıldı!", Color.BlueViolet);
                                    this.Close();
                                }
                                
                            }
                            else
                            {
                                dialogsShow.DialogShow("Bu ürün mağazda bulunmadı mağazaya eklemeniz gerekyor!",Color.BlueViolet);
                            }
                        }
                        else
                        {
                            _intOutStoreService.Add(new IntOutStore
                            {
                                ProductId = Convert.ToInt32(productid),
                                ProductName = tbxName.Text,
                                Quantiti = Convert.ToInt32(tbxQuantity.Text),
                                BusinessDate = DateTime.Now,
                                Note = tbxNote.Text,
                                SorceName = tbxSorceName.Text,
                                Business = tbxBusiness.Text,
                            });
                            _storeService.Update(new Store
                            {
                                Id = store.Id,
                                ProductId = store.ProductId,
                                productName = store.productName,
                                ProductQuantiti = store.ProductQuantiti - Convert.ToInt32(tbxQuantity.Text),
                                Covir = store.Covir,
                            });
                            dialogsShow.DialogShow("Çıkartma işlem ypıldı!", Color.BlueViolet);
                            this.Close();
                        }
                       
                    }
                }
                else
                {
                    dialogsShow.DialogShow("Depoda öyle bir ürün yoktur!",Color.BlueViolet);                  
                }           
            }
            if (id == 2)
            {
                var store = _storeService.GetStoreByProductId(Convert.ToInt32(tbxId.Text));
                if (store.ProductQuantiti < Convert.ToInt32(tbxQuantity.Text))
                {
                    dialogsShow.DialogShow( "Depodaki adet yetersiz!",Color.Tomato);                    
                }
                else
                {
                    if (store != null)
                    {
                        _intOutStoreService.Add(new IntOutStore
                        {
                            ProductId = Convert.ToInt32(tbxId.Text),
                            ProductName = tbxName.Text,
                            Quantiti = Convert.ToInt32(tbxQuantity.Text),
                            BusinessDate = DateTime.Now,
                            ByPrice = Convert.ToDouble(tbxByPrice.Text),
                            Note = tbxNote.Text,
                            SorceName = tbxSorceName.Text,
                            Business = tbxBusiness.Text,
                        });
                        _storeService.Update(new Store
                        {
                            Id = store.Id,
                            ProductId = store.ProductId,
                            productName = store.productName,
                            ProductQuantiti = store.ProductQuantiti - Convert.ToInt32(tbxQuantity.Text),
                            Covir = store.Covir,
                        });
                        dialogsShow.DialogShow("Yok Etme işlem ypıldı!", Color.Tomato);                      
                        this.Close();
                    }
                }
            }
        }
    }
}
