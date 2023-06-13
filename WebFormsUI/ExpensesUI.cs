using Business.Abstract;
using Business.Concreate;
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
    public partial class ExpensesUI : Form
    {
        public ExpensesUI()
        {
            InitializeComponent();
            _storeExpensesService = new StoreExpensesManager(new EfstoreExpenses());
        }
        private IStoreExpensesService _storeExpensesService;
        DialogsShow dialogsShow = new DialogsShow();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxAmount.Text != "" && tbxNote.Text != "") 
            {
                _storeExpensesService.Add(new StoreExpenses
                        {
                            Amont = Convert.ToDecimal(tbxAmount.Text),
                            ExpensesDate=DateTime.Now,
                            Not=tbxNote.Text
                        });

                gridControl1.DataSource= _storeExpensesService.GetAll();
                dialogsShow.DialogShow("Ekleme işlem tamamlandı", Color.Green);

            }
            else
            {
                dialogsShow.DialogShow("Bilgiler eksik", Color.Red);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            var result = MessageBox.Show("Silmek istedinizden emin misin", "silme işlem", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _storeExpensesService.Delete(new StoreExpenses { Id = id });

                gridControl1.DataSource = _storeExpensesService.GetAll();
                dialogsShow.DialogShow("Silme işlem tamamlandı", Color.Red);
            }
            else dialogsShow.DialogShow("Silme işlem iptal edildi", Color.Red);
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
