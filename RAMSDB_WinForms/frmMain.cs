using DevExpress.XtraBars.Docking2010.Views;


namespace RAMSDB_WinForms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += WindowsUIView1_QueryControl;
        }

        void WindowsUIView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document == ucUnpavedMainNavDoc)
                e.Control = new RAMSDB_WinForms.MainNavigation();

            if (e.Document == ucPavedMainNavDoc)
                e.Control = new RAMSDB_WinForms.PavedMainNavigation();


            if (e.Document == ucPPPMainNavDoc)
                e.Control = new RAMSDB_WinForms.PPPMainNavigation();

            if (e.Document == ucAdminNavigation)
                e.Control = new RAMSDB_WinForms.Administration.AdminNavigation();






            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }



    }
}