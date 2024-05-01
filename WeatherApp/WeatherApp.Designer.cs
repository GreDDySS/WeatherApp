
namespace WeatherApp
{
    partial class WeatherApp : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Windows Form Designer generated code

        // Настройка перетаскивания панели


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Header = new Guna.UI2.WinForms.Guna2Panel();
            MimimizedButton = new FontAwesome.Sharp.IconButton();
            CloseButton = new FontAwesome.Sharp.IconButton();
            SideBar = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            SettingsButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            CurrentButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            SearchButton = new FontAwesome.Sharp.IconButton();
            IconWeatherApp = new FontAwesome.Sharp.IconPictureBox();
            Main = new Panel();
            FMain = new Forms.FormMain();
            FSearch = new Forms.FormSearch();
            FSettings = new Forms.FormSettings();
            Header.SuspendLayout();
            SideBar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconWeatherApp).BeginInit();
            Main.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 24;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(25, 25, 25);
            Header.Controls.Add(MimimizedButton);
            Header.Controls.Add(CloseButton);
            Header.CustomizableEdges = customizableEdges1;
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Header.Size = new Size(1440, 25);
            Header.TabIndex = 0;
            Header.MouseDown += Header_MouseDown;
            Header.MouseMove += Header_MouseMove;
            Header.MouseUp += Header_MouseUp;
            // 
            // MimimizedButton
            // 
            MimimizedButton.Cursor = Cursors.Hand;
            MimimizedButton.FlatAppearance.BorderSize = 0;
            MimimizedButton.FlatStyle = FlatStyle.Flat;
            MimimizedButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            MimimizedButton.IconColor = Color.FromArgb(196, 196, 196);
            MimimizedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MimimizedButton.IconSize = 25;
            MimimizedButton.Location = new Point(1365, 0);
            MimimizedButton.Name = "MimimizedButton";
            MimimizedButton.Size = new Size(25, 25);
            MimimizedButton.TabIndex = 1;
            MimimizedButton.UseVisualStyleBackColor = true;
            MimimizedButton.Click += MimimizedButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CloseButton.IconColor = Color.FromArgb(196, 196, 196);
            CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseButton.IconSize = 25;
            CloseButton.Location = new Point(1395, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(22, 22, 22);
            SideBar.Controls.Add(panel5);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(IconWeatherApp);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 25);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(105, 875);
            SideBar.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(61, 61, 61);
            panel5.Location = new Point(104, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 830);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(SettingsButton);
            panel3.Location = new Point(23, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 58);
            panel3.TabIndex = 3;
            // 
            // SettingsButton
            // 
            SettingsButton.Dock = DockStyle.Fill;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            SettingsButton.ForeColor = Color.FromArgb(196, 196, 196);
            SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            SettingsButton.IconColor = Color.FromArgb(196, 196, 196);
            SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SettingsButton.IconSize = 24;
            SettingsButton.ImageAlign = ContentAlignment.TopCenter;
            SettingsButton.Location = new Point(0, 0);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(62, 58);
            SettingsButton.TabIndex = 1;
            SettingsButton.Text = "Settings";
            SettingsButton.TextAlign = ContentAlignment.BottomCenter;
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CurrentButton);
            panel2.Location = new Point(23, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(62, 58);
            panel2.TabIndex = 1;
            // 
            // CurrentButton
            // 
            CurrentButton.Dock = DockStyle.Fill;
            CurrentButton.FlatAppearance.BorderSize = 0;
            CurrentButton.FlatStyle = FlatStyle.Flat;
            CurrentButton.Font = new Font("Roboto Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CurrentButton.ForeColor = Color.FromArgb(196, 196, 196);
            CurrentButton.IconChar = FontAwesome.Sharp.IconChar.CloudShowersHeavy;
            CurrentButton.IconColor = Color.FromArgb(196, 196, 196);
            CurrentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CurrentButton.IconSize = 24;
            CurrentButton.ImageAlign = ContentAlignment.TopCenter;
            CurrentButton.Location = new Point(0, 0);
            CurrentButton.Margin = new Padding(0);
            CurrentButton.Name = "CurrentButton";
            CurrentButton.Size = new Size(62, 58);
            CurrentButton.TabIndex = 0;
            CurrentButton.Text = "Current";
            CurrentButton.TextAlign = ContentAlignment.BottomCenter;
            CurrentButton.UseVisualStyleBackColor = true;
            CurrentButton.Click += CurrentButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchButton);
            panel1.Location = new Point(23, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 58);
            panel1.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Roboto Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchButton.ForeColor = Color.FromArgb(196, 196, 196);
            SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            SearchButton.IconColor = Color.FromArgb(196, 196, 196);
            SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchButton.IconSize = 24;
            SearchButton.ImageAlign = ContentAlignment.TopCenter;
            SearchButton.Location = new Point(0, 0);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(62, 58);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.TextAlign = ContentAlignment.BottomCenter;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // IconWeatherApp
            // 
            IconWeatherApp.BackColor = Color.FromArgb(22, 22, 22);
            IconWeatherApp.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            IconWeatherApp.IconColor = Color.White;
            IconWeatherApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconWeatherApp.IconSize = 48;
            IconWeatherApp.Location = new Point(25, 0);
            IconWeatherApp.Name = "IconWeatherApp";
            IconWeatherApp.Size = new Size(48, 48);
            IconWeatherApp.TabIndex = 0;
            IconWeatherApp.TabStop = false;
            // 
            // Main
            // 
            Main.BackColor = Color.FromArgb(22, 22, 22);
            Main.Controls.Add(FMain);
            Main.Controls.Add(FSearch);
            Main.Controls.Add(FSettings);
            Main.Cursor = Cursors.Hand;
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(105, 25);
            Main.Name = "Main";
            Main.Size = new Size(1335, 875);
            Main.TabIndex = 2;
            // 
            // FMain
            // 
            FMain.BackColor = Color.FromArgb(22, 22, 22);
            FMain.Cursor = Cursors.Default;
            FMain.Dock = DockStyle.Fill;
            FMain.Location = new Point(0, 0);
            FMain.Name = "FMain";
            FMain.Size = new Size(1335, 875);
            FMain.TabIndex = 0;
            // 
            // FSearch
            // 
            FSearch.BackColor = Color.FromArgb(22, 22, 22);
            FSearch.Dock = DockStyle.Fill;
            FSearch.Location = new Point(0, 0);
            FSearch.Name = "FSearch";
            FSearch.Size = new Size(1335, 875);
            FSearch.TabIndex = 2;
            // 
            // FSettings
            // 
            FSettings.BackColor = Color.FromArgb(22, 22, 22);
            FSettings.Dock = DockStyle.Fill;
            FSettings.Location = new Point(0, 0);
            FSettings.Name = "FSettings";
            FSettings.Size = new Size(1335, 875);
            FSettings.TabIndex = 1;
            // 
            // WeatherApp
            // 
            ClientSize = new Size(1440, 900);
            Controls.Add(Main);
            Controls.Add(SideBar);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WeatherApp";
            Header.ResumeLayout(false);
            SideBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconWeatherApp).EndInit();
            Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel Header;
        private Panel SideBar;
        private Panel Main;
        private FontAwesome.Sharp.IconPictureBox IconWeatherApp;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton CurrentButton;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private FontAwesome.Sharp.IconButton SearchButton;
        private Panel panel3;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton MimimizedButton;
        private Forms.FormMain FMain;
        private Forms.FormSettings FSettings;
        private Forms.FormSearch FSearch;
    }
}
