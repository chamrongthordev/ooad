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
    public partial class FormMessageBoxInfo : Form
    {
        public FormMessageBoxInfo()
        {
            InitializeComponent();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Cursor = Cursors.Hand;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void SetInfo(string messageBox, string status)
        {
            timerCounter.Start();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);

            lblInfo.Text = messageBox;
            switch (status)
            {
                case "warning":
                    {
                        BackColor = Color.DarkViolet;
                        break;
                    }
                case "danger":
                    {
                        BackColor = Color.DarkRed;
                        break ;
                    }
                case "info":
                    {
                        BackColor= Color.Blue;
                        break;
                    }
                case "success":
                    {
                        BackColor = Color.DarkGreen;
                        break;
                    }
            }

        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
            timerCounter.Stop();
            Hide();
        }
    }
}
