using System.Windows.Forms;

namespace Printers.View
{
    public partial class DeviceInfoForm : Form
    {
        public DeviceInfoForm()
        {
            InitializeComponent();
        }

        private void devTypeRedactBtn_Click(object sender, System.EventArgs e)
        {
            devTypeCB.Enabled = !devTypeCB.Enabled;
            if (devTypeCB.Enabled)
                devTypeCB.DropDownStyle = ComboBoxStyle.DropDown;
            else
                devTypeCB.DropDownStyle = ComboBoxStyle.Simple;
           
        }

        private void invNumRedactBtn_Click(object sender, System.EventArgs e)
        {
            inventNum.ReadOnly = !inventNum.ReadOnly;
            if (!inventNum.ReadOnly)
                inventNum.BorderStyle = BorderStyle.FixedSingle;
            else
                inventNum.BorderStyle = BorderStyle.None;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UsingHistory().ShowDialog();
        }

        private void devStatusRedactBtn_Click(object sender, System.EventArgs e)
        {
            new ChangeStatus().ShowDialog();
        }
    }
}
