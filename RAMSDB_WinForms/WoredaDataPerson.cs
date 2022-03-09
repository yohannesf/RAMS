using System;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class WoredaDataPerson : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public WoredaDataPerson()
        {
            InitializeComponent();
            // navigationPage3.Controls.Add(new UnpavedConditionSurveyView() { Dock = DockStyle.Fill });
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            // MessageBox.Show("HereActive");
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
            //  navigationPage3.Controls.Add(new UnpavedConditionSurveyView() { Dock = DockStyle.Fill });
            navigationPage2.Controls.Add(new UnpavedRoadConditionSurveyFilters() { Dock = DockStyle.Fill });

            //   MessageBox.Show(navigationFrame.SelectedPage[navBarControl.Groups.IndexOf(e.Group)]);
            //switch (e.Page.Caption)
            //{
            //    case ("Page 1"):
            //        e.Control = new MyUserControl1() { Dock = DockStyle.Fill };
            //        break;

        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
            MessageBox.Show("Here");
        }

        private void NavBarContro(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e)
        {

        }

        private void employeesLabelControl_Click(object sender, EventArgs e)
        {

        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}