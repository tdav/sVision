using Apteka.UtilsUI;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using Vision.Alpr.Engine;
using Vision.Face.Engine;
using Vision.Fingerprint.Engine;
using Vision.Player;

namespace Vision
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            RibbonControl childRibbon = e.MergedChild;
            //parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar);

            Ribbon.SelectedPage = Ribbon.MergedPages[0];
        }

        private void ribbonControl1_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            // RibbonControl parentRRibbon = sender as RibbonControl;
            // parentRRibbon?.StatusBar.UnMergeStatusBar();
        }

        private void btnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // vp.Start(1, "111", "rtsp://admin:123456@192.168.1.120");


            WaitFormManager.Show();
            var frm = new FrmAlpr();
            frm.MdiParent = this;

            frm.Shown += (s, d) =>
            {
                WaitFormManager.Close();
            };

            frm.FormClosed += (s, d) => { };
            frm.Show();

        }
               
        private void btnFace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WaitFormManager.Show();
            var frm = new FrmFace();
            frm.MdiParent = this;

            frm.Shown += (s, d) =>
            {
                WaitFormManager.Close();
            };

            frm.FormClosed += (s, d) => { };
            frm.Show();
        }

        private void btnFingerprint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WaitFormManager.Show();
            var frm = new FrmFingerprint();
            frm.MdiParent = this;

            frm.Shown += (s, d) =>
            {
                WaitFormManager.Close();
            };

            frm.FormClosed += (s, d) => { };
            frm.Show();
        }

        private void FrmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

    }
}
