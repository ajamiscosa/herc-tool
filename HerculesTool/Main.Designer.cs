namespace HerculesTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mNewProject = new System.Windows.Forms.MenuItem();
            this.mOpenProject = new System.Windows.Forms.MenuItem();
            this.mSaveProject = new System.Windows.Forms.MenuItem();
            this.mQuickSave = new System.Windows.Forms.MenuItem();
            this.mSaveDB = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.mConnectHost = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.mPreferences = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mExit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mTipOfDay = new System.Windows.Forms.MenuItem();
            this.mCheckUpdates = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mAbout = new System.Windows.Forms.MenuItem();
            this.pageView = new Telerik.WinControls.UI.RadPageView();
            this.homePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.swxPanel1 = new SwingWERX.Controls.SwxPanel();
            this.pageViewConfig = new Telerik.WinControls.UI.RadPageView();
            this.hServerSetup = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pBattleConf = new Telerik.WinControls.UI.RadPageViewPage();
            this.pCommands = new Telerik.WinControls.UI.RadPageViewPage();
            this.pConnections = new Telerik.WinControls.UI.RadPageViewPage();
            this.hDatabase = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pItems = new Telerik.WinControls.UI.RadPageViewPage();
            this.pMonsters = new Telerik.WinControls.UI.RadPageViewPage();
            this.pSummonItems = new Telerik.WinControls.UI.RadPageViewPage();
            this.pSkills = new Telerik.WinControls.UI.RadPageViewPage();
            this.pPetsHomunculus = new Telerik.WinControls.UI.RadPageViewPage();
            this.pCastles = new Telerik.WinControls.UI.RadPageViewPage();
            this.pClasses = new Telerik.WinControls.UI.RadPageViewPage();
            this.pMaps = new Telerik.WinControls.UI.RadPageViewPage();
            this.hNPC = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pServerScripts = new Telerik.WinControls.UI.RadPageViewPage();
            this.pCustomScripts = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.vistaMenu = new wyDay.Controls.VistaMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pageView)).BeginInit();
            this.pageView.SuspendLayout();
            this.homePage.SuspendLayout();
            this.swxPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewConfig)).BeginInit();
            this.pageViewConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mNewProject,
            this.mOpenProject,
            this.mSaveProject,
            this.mQuickSave,
            this.mSaveDB,
            this.menuItem15,
            this.mConnectHost,
            this.menuItem19,
            this.mPreferences,
            this.menuItem6,
            this.mExit});
            this.menuItem1.Text = "&File";
            // 
            // mNewProject
            // 
            this.mNewProject.Index = 0;
            this.mNewProject.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
            this.mNewProject.Text = "&New Project";
            // 
            // mOpenProject
            // 
            this.mOpenProject.Index = 1;
            this.mOpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO;
            this.mOpenProject.Text = "&Open Project";
            // 
            // mSaveProject
            // 
            this.mSaveProject.Index = 2;
            this.mSaveProject.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mSaveProject.Text = "&Save Project...";
            // 
            // mQuickSave
            // 
            this.mQuickSave.Index = 3;
            this.mQuickSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mQuickSave.Text = "Save Database (Quick)";
            // 
            // mSaveDB
            // 
            this.mSaveDB.Index = 4;
            this.mSaveDB.Text = "Save Database";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 5;
            this.menuItem15.Text = "-";
            // 
            // mConnectHost
            // 
            this.mConnectHost.Index = 6;
            this.mConnectHost.Text = "&Connect to host...";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 7;
            this.menuItem19.Text = "-";
            // 
            // mPreferences
            // 
            this.mPreferences.Index = 8;
            this.mPreferences.Text = "&Preferences";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 9;
            this.menuItem6.Text = "-";
            // 
            // mExit
            // 
            this.mExit.Index = 10;
            this.mExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mExit.Text = "&Exit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem2.Text = "&Setup";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "&Folders Setup";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mTipOfDay,
            this.mCheckUpdates,
            this.menuItem9,
            this.mAbout});
            this.menuItem3.Text = "&Help";
            // 
            // mTipOfDay
            // 
            this.mTipOfDay.Index = 0;
            this.mTipOfDay.Text = "&Tip of the Day...";
            // 
            // mCheckUpdates
            // 
            this.mCheckUpdates.Index = 1;
            this.mCheckUpdates.Text = "Check for &Updates...";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "-";
            // 
            // mAbout
            // 
            this.mAbout.Index = 3;
            this.mAbout.Text = "&About";
            // 
            // pageView
            // 
            this.pageView.Controls.Add(this.homePage);
            this.pageView.Controls.Add(this.radPageViewPage2);
            this.pageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pageView.Location = new System.Drawing.Point(0, 0);
            this.pageView.Name = "pageView";
            this.pageView.SelectedPage = this.homePage;
            this.pageView.Size = new System.Drawing.Size(784, 517);
            this.pageView.TabIndex = 0;
            this.pageView.Text = "radPageView1";
            this.pageView.ThemeName = "Office2013Light";
            this.pageView.SelectedPageChanging += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.SelectedPageChanging_Event);
            this.pageView.SelectedPageChanged += new System.EventHandler(this.SelectedPageChanged_Event);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.pageView.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(0);
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.swxPanel1);
            this.homePage.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.homePage.ItemSize = new System.Drawing.SizeF(52F, 29F);
            this.homePage.Location = new System.Drawing.Point(1, 29);
            this.homePage.Margin = new System.Windows.Forms.Padding(0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(782, 487);
            this.homePage.Text = "Home";
            // 
            // swxPanel1
            // 
            this.swxPanel1.BackColor = System.Drawing.Color.Transparent;
            this.swxPanel1.Controls.Add(this.pageViewConfig);
            this.swxPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swxPanel1.GradientColor2 = System.Drawing.Color.White;
            this.swxPanel1.Location = new System.Drawing.Point(0, 0);
            this.swxPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.swxPanel1.Name = "swxPanel1";
            this.swxPanel1.Size = new System.Drawing.Size(782, 487);
            this.swxPanel1.TabIndex = 0;
            // 
            // pageViewConfig
            // 
            this.pageViewConfig.Controls.Add(this.hServerSetup);
            this.pageViewConfig.Controls.Add(this.pBattleConf);
            this.pageViewConfig.Controls.Add(this.pCommands);
            this.pageViewConfig.Controls.Add(this.pConnections);
            this.pageViewConfig.Controls.Add(this.hDatabase);
            this.pageViewConfig.Controls.Add(this.pItems);
            this.pageViewConfig.Controls.Add(this.pMonsters);
            this.pageViewConfig.Controls.Add(this.pSummonItems);
            this.pageViewConfig.Controls.Add(this.pSkills);
            this.pageViewConfig.Controls.Add(this.pPetsHomunculus);
            this.pageViewConfig.Controls.Add(this.pCastles);
            this.pageViewConfig.Controls.Add(this.pClasses);
            this.pageViewConfig.Controls.Add(this.pMaps);
            this.pageViewConfig.Controls.Add(this.hNPC);
            this.pageViewConfig.Controls.Add(this.pServerScripts);
            this.pageViewConfig.Controls.Add(this.pCustomScripts);
            this.pageViewConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewConfig.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.pageViewConfig.Location = new System.Drawing.Point(0, 0);
            this.pageViewConfig.Name = "pageViewConfig";
            this.pageViewConfig.SelectedPage = this.hServerSetup;
            this.pageViewConfig.Size = new System.Drawing.Size(782, 487);
            this.pageViewConfig.TabIndex = 0;
            this.pageViewConfig.Text = "radPageView2";
            this.pageViewConfig.ThemeName = "Windows8";
            this.pageViewConfig.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pageViewConfig.GetChildAt(0))).ShowHorizontalLine = true;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pageViewConfig.GetChildAt(0))).StretchHorizontally = false;
            // 
            // hServerSetup
            // 
            this.hServerSetup.ItemSize = new System.Drawing.SizeF(143F, 27F);
            this.hServerSetup.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.hServerSetup.Location = new System.Drawing.Point(204, 5);
            this.hServerSetup.Name = "hServerSetup";
            this.hServerSetup.Size = new System.Drawing.Size(573, 477);
            this.hServerSetup.Text = "Server Setup";
            // 
            // pBattleConf
            // 
            this.pBattleConf.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pBattleConf.Location = new System.Drawing.Point(204, 5);
            this.pBattleConf.Name = "pBattleConf";
            this.pBattleConf.Size = new System.Drawing.Size(573, 477);
            this.pBattleConf.Text = "Battle Config";
            // 
            // pCommands
            // 
            this.pCommands.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pCommands.Location = new System.Drawing.Point(204, 5);
            this.pCommands.Name = "pCommands";
            this.pCommands.Size = new System.Drawing.Size(573, 477);
            this.pCommands.Text = "Commands";
            // 
            // pConnections
            // 
            this.pConnections.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pConnections.Location = new System.Drawing.Point(204, 5);
            this.pConnections.Name = "pConnections";
            this.pConnections.Size = new System.Drawing.Size(573, 479);
            this.pConnections.Text = "Connections";
            // 
            // hDatabase
            // 
            this.hDatabase.ItemSize = new System.Drawing.SizeF(143F, 27F);
            this.hDatabase.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.hDatabase.Location = new System.Drawing.Point(204, 5);
            this.hDatabase.Name = "hDatabase";
            this.hDatabase.Size = new System.Drawing.Size(573, 477);
            this.hDatabase.Text = "Database";
            // 
            // pItems
            // 
            this.pItems.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pItems.Location = new System.Drawing.Point(204, 5);
            this.pItems.Name = "pItems";
            this.pItems.Size = new System.Drawing.Size(573, 479);
            this.pItems.Text = "Items";
            // 
            // pMonsters
            // 
            this.pMonsters.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pMonsters.Location = new System.Drawing.Point(204, 5);
            this.pMonsters.Name = "pMonsters";
            this.pMonsters.Size = new System.Drawing.Size(573, 479);
            this.pMonsters.Text = "Monsters";
            // 
            // pSummonItems
            // 
            this.pSummonItems.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pSummonItems.Location = new System.Drawing.Point(204, 5);
            this.pSummonItems.Name = "pSummonItems";
            this.pSummonItems.Size = new System.Drawing.Size(573, 479);
            this.pSummonItems.Text = "Summoning Items";
            // 
            // pSkills
            // 
            this.pSkills.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pSkills.Location = new System.Drawing.Point(204, 5);
            this.pSkills.Name = "pSkills";
            this.pSkills.Size = new System.Drawing.Size(573, 479);
            this.pSkills.Text = "Skills";
            // 
            // pPetsHomunculus
            // 
            this.pPetsHomunculus.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pPetsHomunculus.Location = new System.Drawing.Point(204, 5);
            this.pPetsHomunculus.Name = "pPetsHomunculus";
            this.pPetsHomunculus.Size = new System.Drawing.Size(573, 479);
            this.pPetsHomunculus.Text = "Pets and Humunculus";
            // 
            // pCastles
            // 
            this.pCastles.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pCastles.Location = new System.Drawing.Point(204, 5);
            this.pCastles.Name = "pCastles";
            this.pCastles.Size = new System.Drawing.Size(573, 477);
            this.pCastles.Text = "Castles";
            // 
            // pClasses
            // 
            this.pClasses.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pClasses.Location = new System.Drawing.Point(204, 5);
            this.pClasses.Name = "pClasses";
            this.pClasses.Size = new System.Drawing.Size(573, 479);
            this.pClasses.Text = "Classes";
            // 
            // pMaps
            // 
            this.pMaps.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pMaps.Location = new System.Drawing.Point(204, 5);
            this.pMaps.Name = "pMaps";
            this.pMaps.Size = new System.Drawing.Size(573, 479);
            this.pMaps.Text = "Maps";
            // 
            // hNPC
            // 
            this.hNPC.ItemSize = new System.Drawing.SizeF(143F, 27F);
            this.hNPC.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.hNPC.Location = new System.Drawing.Point(154, 5);
            this.hNPC.Name = "hNPC";
            this.hNPC.Size = new System.Drawing.Size(623, 503);
            this.hNPC.Text = "NPC Scripts";
            // 
            // pServerScripts
            // 
            this.pServerScripts.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pServerScripts.Location = new System.Drawing.Point(0, 0);
            this.pServerScripts.Name = "pServerScripts";
            this.pServerScripts.Size = new System.Drawing.Size(200, 100);
            this.pServerScripts.Text = "Server Scripts";
            // 
            // pCustomScripts
            // 
            this.pCustomScripts.ItemSize = new System.Drawing.SizeF(143F, 29F);
            this.pCustomScripts.Location = new System.Drawing.Point(0, 0);
            this.pCustomScripts.Name = "pCustomScripts";
            this.pCustomScripts.Size = new System.Drawing.Size(200, 100);
            this.pCustomScripts.Text = "Custom Scripts";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(131F, 29F);
            this.radPageViewPage2.Location = new System.Drawing.Point(1, 29);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(782, 487);
            this.radPageViewPage2.Text = "radPageViewPage2";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 517);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(784, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Windows8";
            // 
            // vistaMenu
            // 
            this.vistaMenu.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.radStatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hercules® Server Configuration Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pageView)).EndInit();
            this.pageView.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.swxPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageViewConfig)).EndInit();
            this.pageViewConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private Telerik.WinControls.UI.RadPageView pageView;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadPageViewPage homePage;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.MenuItem mPreferences;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem mExit;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private SwingWERX.Controls.SwxPanel swxPanel1;
        private Telerik.WinControls.UI.RadPageView pageViewConfig;
        private Telerik.WinControls.UI.RadPageViewItemPage hServerSetup;
        private Telerik.WinControls.UI.RadPageViewPage pBattleConf;
        private Telerik.WinControls.UI.RadPageViewItemPage hDatabase;
        private Telerik.WinControls.UI.RadPageViewPage pCommands;
        private Telerik.WinControls.UI.RadPageViewPage pConnections;
        private Telerik.WinControls.UI.RadPageViewPage pItems;
        private Telerik.WinControls.UI.RadPageViewItemPage hNPC;
        private Telerik.WinControls.UI.RadPageViewPage pMonsters;
        private Telerik.WinControls.UI.RadPageViewPage pSummonItems;
        private Telerik.WinControls.UI.RadPageViewPage pSkills;
        private Telerik.WinControls.UI.RadPageViewPage pPetsHomunculus;
        private Telerik.WinControls.UI.RadPageViewPage pCastles;
        private Telerik.WinControls.UI.RadPageViewPage pClasses;
        private Telerik.WinControls.UI.RadPageViewPage pMaps;
        private Telerik.WinControls.UI.RadPageViewPage pServerScripts;
        private Telerik.WinControls.UI.RadPageViewPage pCustomScripts;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.MenuItem mCheckUpdates;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem mAbout;
        private System.Windows.Forms.MenuItem mTipOfDay;
        private System.Windows.Forms.MenuItem mNewProject;
        private System.Windows.Forms.MenuItem mOpenProject;
        private System.Windows.Forms.MenuItem mSaveProject;
        private System.Windows.Forms.MenuItem mQuickSave;
        private System.Windows.Forms.MenuItem mSaveDB;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem mConnectHost;
        private System.Windows.Forms.MenuItem menuItem19;
        private wyDay.Controls.VistaMenu vistaMenu;
    }
}

