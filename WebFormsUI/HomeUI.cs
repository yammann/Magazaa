using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProduct());
            _oneOrderService = new oneOrderManager(new EfoneOrder());
            _storeService = new StoreManager(new EfStore());
            _orderService = new OrderManager(new EfOrder());
            _usersService = new UsersManager(new EfUser());
            _storeExpensesService = new StoreExpensesManager(new EfstoreExpenses());
        }
        private IProductService _productService;
        private IoneOrderService _oneOrderService;
        private IStoreService _storeService;
        private IOrderService _orderService;
        private IUsersService _usersService;
        private IStoreExpensesService _storeExpensesService;

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleUI saleUI = new SaleUI();
            saleUI.lblOrderId.Text = _oneOrderService.OrderId().ToString();
            saleUI.cobProduct.Items.AddRange(_productService.GetProductname());
            saleUI.tbxQuantiti.Enabled = false;
            saleUI.cobDiscount.Enabled = false;
            saleUI.btnAdd.Enabled = false;
            saleUI.ShowDialog();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnUI returnUI = new ReturnUI();
            returnUI.ShowDialog();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            PriceDisplayUI priceDisplay = new PriceDisplayUI();
            priceDisplay.gridControl1.DataSource = _productService.GetAll();
            priceDisplay.ShowDialog();

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            DepoUI depoUI = new DepoUI();
            depoUI.gridControl1.DataSource = _storeService.GetAll();
            depoUI.ShowDialog();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ExpensesUI expensesUI = new ExpensesUI();           
            expensesUI.gridControl1.DataSource = _storeExpensesService.GetAll();
            expensesUI.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductDisplayUI displayUI = new ProductDisplayUI();
            displayUI.gcData.DataSource = _productService.GetAll(); 
            displayUI.ShowDialog();

        }
    }
}
