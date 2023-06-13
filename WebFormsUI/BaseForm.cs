using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using DevExpress.Utils;
using System.Security.Policy;
using DevExpress.XtraGrid.Views.Tile;

namespace WebFormsUI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProduct());
            _employeeService= new EmployeeManager(new EfEmployee());
            _oneOrderService=new oneOrderManager(new EfoneOrder());
            _storeService= new StoreManager(new EfStore());
            _orderService=new OrderManager(new EfOrder());
            _usersService=new UsersManager(new EfUser());
            _storeExpensesService=new StoreExpensesManager(new EfstoreExpenses());
        }
        private IProductService _productService;
        private IEmployeeService _employeeService;
        private IoneOrderService _oneOrderService;
        private IStoreService _storeService;
        private IOrderService _orderService;
        private IUsersService _usersService;
        private IStoreExpensesService _storeExpensesService;

        private void BaseForm_Load(object sender, EventArgs e)
        {
            HomeUI homeUI = new HomeUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(homeUI.pnlHome);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
           WindowState=FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else WindowState = FormWindowState.Normal; 
            
        }

       
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if(pnlNav.Width==175)
            {
                pnlNav.Width = 50;
                pnlUser.Visible= false;
            }
            else
            {
                pnlNav.Width = 175;
                pnlUser.Visible = true;
            }
        }
       

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserDisplayUI userDisplayUI=new UserDisplayUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(userDisplayUI.pnlDisplay);
            userDisplayUI.gridControl1.DataSource = _usersService.GetAll();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            HomeUI homeUI = new HomeUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(homeUI.pnlHome);
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            ProductDisplayUI displayUI = new ProductDisplayUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(displayUI.pnlDisplay);
            displayUI.gcData.DataSource = _productService.GetAll();
        }

        public void btnSale_Click_1(object sender, EventArgs e)
        {
            SaleUI saleUI = new SaleUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(saleUI.pnlSale);
            saleUI.lblOrderId.Text = _oneOrderService.OrderId().ToString();
            saleUI.cobProduct.Items.AddRange(_productService.GetProductname());
            saleUI.tbxQuantiti.Enabled = false;
            saleUI.cobDiscount.Enabled = false;
            saleUI.btnAdd.Enabled = false;
        }

        private void btnPrice_Click_1(object sender, EventArgs e)
        {
            PriceDisplayUI priceDisplay = new PriceDisplayUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(priceDisplay.pnlDisplay);
            priceDisplay.gridControl1.DataSource = _productService.GetAll();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            ReturnUI returnUI = new ReturnUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(returnUI.pnlReturn);
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            EmployeeDisplayUI employeeDisplayUI = new EmployeeDisplayUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(employeeDisplayUI.pnlDisplay);
            employeeDisplayUI.gridControl1.DataSource = _employeeService.GetAll();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            OrderUI orderUI = new OrderUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(orderUI.pnlOrder);
            orderUI.gridControl1.DataSource = _orderService.GetAll();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(reportUI.panel1);
        }

        private void btnStore_Click_1(object sender, EventArgs e)
        {
            DepoUI depoUI = new DepoUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(depoUI.pnlDepo);
            depoUI.gridControl1.DataSource = _storeService.GetAll();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ExpensesUI expensesUI = new ExpensesUI();
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(expensesUI.pnlExpenses);
            expensesUI.gridControl1.DataSource = _storeExpensesService.GetAll();
        }
       
    }
}
