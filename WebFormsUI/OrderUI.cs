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

namespace WebFormsUI
{
    public partial class OrderUI : Form
    {
        public OrderUI()
        {
            InitializeComponent();
            _oneOrderService = new oneOrderManager(new EfoneOrder());
          
        }
        private IoneOrderService _oneOrderService;
        DialogsShow dialogsShow=new DialogsShow();
        long orderId;
        private void btnOrderDetayları_Click(object sender, EventArgs e)
        {
            if(orderId!=0)
            {
             OrderDetaylarUI orderDetaylarUI = new OrderDetaylarUI();
            pnlOrder.Controls.Clear();
            pnlOrder.Controls.Add(orderDetaylarUI.pnlOrderDetaylar);
            orderDetaylarUI.gridControl1.DataSource =_oneOrderService.GetoneOrderbyOrderId(orderId);
            }
            else
            {
                dialogsShow.DialogShow("Bir sipariş seçiniz!", Color.Silver);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            orderId = Convert.ToInt64(gridView1.GetFocusedRowCellValue("orderId").ToString());
            lblOrderId.Text = gridView1.GetFocusedRowCellValue("orderId").ToString();
        }
    }
}
