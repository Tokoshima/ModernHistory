using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernHistoryMuseum
{
    public partial class CustomerExhibitView : Form
    {
        public CustomerExhibitView()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex==0)
            {
                
            }
        }
    }
}
