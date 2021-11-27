using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem.Utils
{
    public partial class FormMessageBoxConfirm : Form
    {
        private bool IsDeleted = false;
        public FormMessageBoxConfirm()
        {
            InitializeComponent();
        }

        private void FormMessageBoxConfirm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IsDeleted = true;
            Hide();
        }

        public bool GetIsDeleted()
        {
            return IsDeleted;
        }
  
    }
}
