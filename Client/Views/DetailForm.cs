using Client.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class DetailForm : Form
    {
        LogicalDisk logicalDisk;
        public DetailForm(LogicalDisk logicalDisk)
        {
            InitializeComponent();
            this.logicalDisk = logicalDisk;
            SetGui();
        }
        public void SetGui()
        {
            this.Text = "Disk (" + this.logicalDisk.Name + "):Property";

            txtNameDrive.Text = this.logicalDisk.Name;
            txtType.Text = this.logicalDisk.FileSystem;
            txtFreeSpace.Text = this.logicalDisk.FreeSpace.ToString() + " GB";
            txtSpace.Text = this.logicalDisk.Space.ToString() + " GB";
            txtUsedSpace.Text = (this.logicalDisk.Space - this.logicalDisk.FreeSpace).ToString() + " GB";
            txtSectorsPerCluster.Text = this.logicalDisk.SectorsPerCluster.ToString();
            lbNameDrive.Text = "Drive " + this.logicalDisk.Name;
            var valueOfProcessBar = ((this.logicalDisk.Space - this.logicalDisk.FreeSpace) * 1.0 / this.logicalDisk.Space) * 100;

            circularProgressBar1.Value = (int)valueOfProcessBar;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
