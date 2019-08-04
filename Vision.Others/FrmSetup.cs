using Apteka.BarCodeScanner;
using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;
using System;
using System.Linq;

namespace Apteka.Others
{
    public partial class FrmSetup : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmSetup()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinters.Properties.Items.Add(printer);
            }

            var usbDevices = ListHidDevices.Get();
            cbBarcode.Properties.Items.AddRange(usbDevices);

            cbBarcode.EditValue = Vars.DevBacodeScanner;
            cbPrinters.EditValue = Vars.DevPrinterName;
            cbSizePaper.EditValue = Vars.SizePaper;

            cbDrugStores.Properties.DataSource = db.DrugStore.GetSp();
            cbRegion.Properties.DataSource = db.Region.GetSp();
            cbRegion.EditValueChanged += (s, e) =>
            {
                if (cbRegion.EditValue?.ToString() != "")
                    cbDistrict.Properties.DataSource = db.District.GetSp(cbRegion.EditValue.ToStr());
            };

            var di = Vars.DrugStoreId;
            SetValues(di);
        }

        private void SetValues(Guid di)
        {
            var ds = db.DrugStore.Find(x => x.Id == di).FirstOrDefault();
            if (di != null)
            {
                cbDrugStores.EditValue = di;
                bsDrugStore.DataSource = ds;
            } else
            {
                bsDrugStore.DataSource = new tbSetup();
            }
        }

        private void cbDrugStores_EditValueChanged(object sender, EventArgs e)
        {
            var di = cbDrugStores.EditValue.ToGuid();
            SetValues(di);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var bc = cbBarcode.SelectedItem as USBDeviceInfo;

            if (bc != null)
                Vars.DevBacodeScanner = bc.DeviceID;

            if (cbPrinters.SelectedIndex != -1)
                Vars.DevPrinterName = cbPrinters.SelectedItem.ToString();
            Vars.SizePaper = cbSizePaper.SelectedItem.ToString();

            Vars.DrugStoreId = cbDrugStores.EditValue.ToGuid();
            Vars.SaveParameters();
        }

        private void cbDrugStores_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var fd = new FrmDrugStore();
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    cbDrugStores.Properties.DataSource = db.DrugStore.GetSp();
                fd.Dispose();
            }
        }

    }
}