namespace WF.SmoothStylishSideBar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuTranslation = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 64);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1021, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAFAEL SUAREZ | SIDEBAR";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 12);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(49, 44);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.Black;
            this.sidebar.Location = new System.Drawing.Point(0, 64);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(315, 616);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.Black;
            this.pnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnDashboard.Controls.Add(this.dashboard);
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(297, 66);
            this.pnDashboard.TabIndex = 3;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Black;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(18, 6);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(267, 57);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "              Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Black;
            this.menuContainer.Controls.Add(this.pnMenu);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Location = new System.Drawing.Point(0, 75);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(314, 69);
            this.menuContainer.TabIndex = 6;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Black;
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMenu.Controls.Add(this.menu);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(297, 66);
            this.pnMenu.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(18, 6);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(267, 57);
            this.menu.TabIndex = 2;
            this.menu.Text = "              Menu";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Controls.Add(this.btnSub1);
            this.panel6.Location = new System.Drawing.Point(0, 66);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 66);
            this.panel6.TabIndex = 6;
            // 
            // btnSub1
            // 
            this.btnSub1.BackColor = System.Drawing.Color.Black;
            this.btnSub1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSub1.FlatAppearance.BorderSize = 0;
            this.btnSub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub1.ForeColor = System.Drawing.Color.White;
            this.btnSub1.Image = ((System.Drawing.Image)(resources.GetObject("btnSub1.Image")));
            this.btnSub1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub1.Location = new System.Drawing.Point(18, 6);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub1.Size = new System.Drawing.Size(267, 57);
            this.btnSub1.TabIndex = 2;
            this.btnSub1.Text = "              Components 1";
            this.btnSub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub1.UseVisualStyleBackColor = false;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.btnSub2);
            this.panel5.Location = new System.Drawing.Point(0, 132);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 66);
            this.panel5.TabIndex = 7;
            // 
            // btnSub2
            // 
            this.btnSub2.BackColor = System.Drawing.Color.Black;
            this.btnSub2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSub2.FlatAppearance.BorderSize = 0;
            this.btnSub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub2.ForeColor = System.Drawing.Color.White;
            this.btnSub2.Image = ((System.Drawing.Image)(resources.GetObject("btnSub2.Image")));
            this.btnSub2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub2.Location = new System.Drawing.Point(18, 6);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub2.Size = new System.Drawing.Size(267, 57);
            this.btnSub2.TabIndex = 2;
            this.btnSub2.Text = "              Componentes 2";
            this.btnSub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub2.UseVisualStyleBackColor = false;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.Color.Black;
            this.pnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnSettings.Controls.Add(this.btnSettings);
            this.pnSettings.Location = new System.Drawing.Point(3, 150);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(297, 66);
            this.pnSettings.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(18, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(267, 57);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "              Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.BackColor = System.Drawing.Color.Black;
            this.pnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnAbout.Controls.Add(this.btnAbout);
            this.pnAbout.Location = new System.Drawing.Point(3, 222);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(297, 66);
            this.pnAbout.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(18, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(267, 57);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "              About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.Black;
            this.pnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 294);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(297, 66);
            this.pnLogout.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(18, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(267, 57);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "              Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuTranslation
            // 
            this.menuTranslation.Interval = 5;
            this.menuTranslation.Tick += new System.EventHandler(this.menuTranslation_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 5;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 680);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Timer menuTranslation;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}

