using Apteka.Models.Core;
using Apteka.Models.Entity;
using System;

namespace Apteka.Others
{
    public partial class FrmNewCustomer : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmNewCustomer()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };
        }

        public tbCustomer GetData()
        {
            var d = new tbCustomer();
            d.Address = edAdress.Text;
            d.FIO = edFIO.Text;
            d.Email = edEmail.Text;

            d.CreateDate = DateTime.Now;
            d.CreateUser = Vars.UserId;
            d.Phone = edPhone.Text;
            d.Status = 1;
            return d;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbCustomer sp = GetData();
            if (sp.Id == Guid.Empty)
            {
                sp.Id = Guid.NewGuid();
            }

            db.Customers.Add(sp);
            db.Complete();
            UtilsUI.AlertMessage.Show("Данные успешно сохранены");
        }
    }
}