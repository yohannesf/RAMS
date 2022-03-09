using RAMSDBModel;
using System;
using System.Windows.Forms;

namespace RAMSDB_WinForms.PPP
{
    public partial class Form1 : Form
    {
        RAMSDBEntities dbContext = new RAMSDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // structureConditionSurveyBindingSource.DataSource = dbContext.StructureConditionSurvey.ToList();
            // structuresInventoryBindingSource.DataSource = dbContext.StructuresInventory.ToList();
            //      contractPeriodiMSpotRRehabBindingSource.DataSource = dbContext.ContractPeriodiMSpotRRehab.ToList();
            // contractPeformancePeriodiMSpotRRehabsBindingSource.DataSource = dbContext.ContractPeformancePeriodiMSpotRRehab.ToList();
        }

        private void contractPeformancePeriodiMSpotRRehabsGridControl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var c = ccB.Text;
            var t = 1;
        }

        private void ccB_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string UserText = ccB.Text;

            if (e.Button.Index == 1)
            {
                //User clicked the "plus" button--add the item if it is not already present  
                if (ccB.Properties.Items.Contains(UserText) == false)
                    ccB.Properties.Items.Add(UserText);
            }
            else if (e.Button.Index == 2)
            {
                //User clicked the "minus" button  
                ccB.Properties.Items.Remove(UserText);
                //Clear out the control  
                ccB.EditValue = null;
            }
        }
    }
}
