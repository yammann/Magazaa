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
using Bunifu.Framework.Lib;
using Entities.Concreate;
using Business.Methods;
using DevExpress.XtraEditors;
using System.Xml.Linq;

namespace WebFormsUI
{
    public partial class DepoUI : Form
    {
        public DepoUI()
        {
            InitializeComponent();
            _intOutStoreService = new IntOutStoreManager(new EfIntOutStore());
            _storeService = new StoreManager(new EfStore());
            _productService= new ProductManager(new EfProduct());
        }
        private IIntOutStoreService _intOutStoreService;
        private IStoreService _storeService;
        private IProductService _productService;
         ImageMethod imageMethod = new ImageMethod();
        DialogsShow dialogsShow=new DialogsShow();
        
        private void btnBusiness_Click(object sender, EventArgs e)
        {
            IntOutDepoUI intOutDepoUI= new IntOutDepoUI();        
            pnlDepo.Controls.Clear();
            pnlDepo.Controls.Add(intOutDepoUI.pnlIntOutDepo);            
            intOutDepoUI.gridControl1.DataSource = _intOutStoreService.GetAll();


            
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            DepoAditUI depoAditUI = new DepoAditUI();
            depoAditUI.id = 0;           
            depoAditUI.btnAdd.Text = "Ekle";
            depoAditUI.btnAdd.ForeColor = Color.LimeGreen;
            depoAditUI.Show();
        }

        private void btnAditUpdate_Click(object sender, EventArgs e)
        {
            DepoAditUI depoAditUI = new DepoAditUI();
            depoAditUI.id =Convert.ToInt32( gridView1.GetFocusedRowCellValue("Id"));           
            var store = _storeService.GetStoreById(depoAditUI.id);
            depoAditUI.tbxId.Text = store.ProductId.ToString();
            depoAditUI.tbxName.Text = store.productName;
            depoAditUI.tbxQuantity.Text = store.ProductQuantiti.ToString();
            imageMethod.by = store.Covir;
            depoAditUI.pictureEdit1.Image = Image.FromStream(imageMethod.ConvertToImage());
            depoAditUI.btnAdd.Text = "Günceleme";
            depoAditUI.btnAdd.ForeColor = Color.Tomato;
            depoAditUI.Show();
        }
        

        private void btnAditDelet_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Silmek istedinizden emin misin !","Silme işlme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.OK)
            {
                int ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                _storeService.Delete(new Store { Id = ID });
                dialogsShow.DialogShow("Ürürn Silindi!",Color.Tomato);
                gridControl1.DataSource= _storeService.GetAll();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = _storeService.GetAll();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            IntOutDepoAditUI intOutDepoAditUI = new IntOutDepoAditUI();
            intOutDepoAditUI.btnAdd.Text = "Girdirme";
            intOutDepoAditUI.tbxBusiness.Text = "Girdirme";
            intOutDepoAditUI.btnAdd.ForeColor = Color.LawnGreen;
            intOutDepoAditUI.id = 0;
            intOutDepoAditUI.tbxByPrice.Enabled = true;
            intOutDepoAditUI.Show();
        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {
            
            IntOutDepoAditUI intOutDepoAditUI = new IntOutDepoAditUI();
            intOutDepoAditUI.btnAdd.Text = "Çıkarma";
            intOutDepoAditUI.tbxBusiness.Text = "Çıkarma";
            intOutDepoAditUI.btnAdd.ForeColor = Color.BlueViolet;
            intOutDepoAditUI.id = 1;
            intOutDepoAditUI.lblToWhere.Text = "Nereye yönlendirilecek";
            intOutDepoAditUI.tbxByPrice.Enabled= false;
            intOutDepoAditUI.Show();
        }

        private void btnEnded_Click_1(object sender, EventArgs e)
        {
            IntOutDepoAditUI intOutDepoAditUI = new IntOutDepoAditUI();
            intOutDepoAditUI.btnAdd.Text = "Yok Et";
            intOutDepoAditUI.tbxBusiness.Text = "Yok Et";
            intOutDepoAditUI.btnAdd.ForeColor = Color.Tomato;
            intOutDepoAditUI.id = 2;
            intOutDepoAditUI.tbxByPrice.Enabled = false;
            intOutDepoAditUI.tbxSorceName.Enabled = false;
            intOutDepoAditUI.Show();
        }

        private void btnEnterList_Click(object sender, EventArgs e)
        {
            BusinessFilter("Girdirme");
        }

        private void BusinessFilter(string business)
        {
            IntOutDepoUI intOutDepoUI = new IntOutDepoUI();
            pnlDepo.Controls.Clear();
            pnlDepo.Controls.Add(intOutDepoUI.pnlIntOutDepo);
            intOutDepoUI.gridControl1.DataSource = _intOutStoreService.GetByBusiness(business);
        }

        private void btnOutList_Click(object sender, EventArgs e)
        {
             BusinessFilter("Çıkarma");
        }

        private void btnEndedList_Click(object sender, EventArgs e)
        {
            BusinessFilter("Yok Et");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
