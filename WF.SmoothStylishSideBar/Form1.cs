using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.SmoothStylishSideBar
{
    public partial class Form1 : Form
    {
        FormDashboard formDashboard = null;
        FormComponents1 formComponents1 = null;
        FormComponentsDangeon frmComponentsDangeon = null;
        FormForever frmForever = null;
        FormHope frmHope = null;

        public Form1()
        {
            InitializeComponent();
        }
        public bool menuExpand = false;

        private void MdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTranslation.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 85)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 315)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void menuTranslation_Tick(object sender, EventArgs e)
        {
            if (menuExpand is false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 231)
                {
                    menuTranslation.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 57)
                {
                    menuTranslation.Stop();
                    menuExpand = false;
                }
            }
        }

 
        private void dashboard_Click(object sender, EventArgs e)
        {
            if(formDashboard is null)
            {
                formDashboard = new FormDashboard();
                formDashboard.FormClosed += FormDashboard_FormClosed;
                formDashboard.MdiParent = this;
                formDashboard.Show();
            }
            else
            {
                formDashboard.Activate();
            }
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashboard = null;
            formComponents1 = null;
            frmComponentsDangeon = null;
            frmForever = null;
            frmHope = null;
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            if (formComponents1 is null)
            {
                formComponents1 = new FormComponents1();
                formComponents1.FormClosed += FormDashboard_FormClosed;
                formComponents1.MdiParent = this;
                formComponents1.Show();
            }
            else
            {
                formComponents1.Activate();
            }
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            if (frmComponentsDangeon is null)
            {
                frmComponentsDangeon = new FormComponentsDangeon();
                frmComponentsDangeon.FormClosed += FormDashboard_FormClosed;
                frmComponentsDangeon.MdiParent = this;
                frmComponentsDangeon.Show();
            }
            else
            {
                frmComponentsDangeon.Activate();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            if (frmForever is null)
            {
                frmForever = new FormForever();
                frmForever.FormClosed += FormDashboard_FormClosed;
                frmForever.MdiParent = this;
                frmForever.Show();
            }
            else
            {
                frmForever.Activate();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (frmHope is null)
            {
                frmHope = new FormHope();
                frmHope.FormClosed += FormDashboard_FormClosed;
                frmHope.MdiParent = this;
                frmHope.Show();
            }
            else
            {
                frmHope.Activate();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
