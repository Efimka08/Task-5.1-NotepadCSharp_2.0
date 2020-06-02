namespace NotepadCSharp
{
    partial class frmmain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFront = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRussian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.helpProvider1.SetHelpString(this.menuStrip1, resources.GetString("menuStrip1.HelpString"));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat,
            this.mnuWindow,
            this.mnuLanguage,
            this.mnuHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.MdiWindowListItem = this.mnuWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.helpProvider1.SetShowHelp(this.menuStrip1, ((bool)(resources.GetObject("menuStrip1.ShowHelp"))));
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.cmnuSaveAs,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            resources.ApplyResources(this.mnuFile, "mnuFile");
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            resources.ApplyResources(this.mnuNew, "mnuNew");
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            resources.ApplyResources(this.mnuOpen, "mnuOpen");
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            resources.ApplyResources(this.mnuSave, "mnuSave");
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // cmnuSaveAs
            // 
            this.cmnuSaveAs.Name = "cmnuSaveAs";
            resources.ApplyResources(this.cmnuSaveAs, "cmnuSaveAs");
            this.cmnuSaveAs.Click += new System.EventHandler(this.cmnuSaveAs_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.mnuSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            resources.ApplyResources(this.mnuEdit, "mnuEdit");
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            resources.ApplyResources(this.mnuCut, "mnuCut");
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            resources.ApplyResources(this.mnuCopy, "mnuCopy");
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            resources.ApplyResources(this.mnuPaste, "mnuPaste");
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            resources.ApplyResources(this.mnuDelete, "mnuDelete");
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            resources.ApplyResources(this.mnuSelectAll, "mnuSelectAll");
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFront,
            this.mnuCollor});
            this.mnuFormat.Name = "mnuFormat";
            resources.ApplyResources(this.mnuFormat, "mnuFormat");
            // 
            // mnuFront
            // 
            this.mnuFront.Name = "mnuFront";
            resources.ApplyResources(this.mnuFront, "mnuFront");
            this.mnuFront.Click += new System.EventHandler(this.mnuFront_Click);
            // 
            // mnuCollor
            // 
            this.mnuCollor.Name = "mnuCollor";
            resources.ApplyResources(this.mnuCollor, "mnuCollor");
            this.mnuCollor.Click += new System.EventHandler(this.mnuCollor_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTile,
            this.mnuTileHorizontal,
            this.mnuTileVertical});
            this.mnuWindow.Name = "mnuWindow";
            resources.ApplyResources(this.mnuWindow, "mnuWindow");
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            resources.ApplyResources(this.mnuCascade, "mnuCascade");
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTile
            // 
            this.mnuTile.Name = "mnuTile";
            resources.ApplyResources(this.mnuTile, "mnuTile");
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            resources.ApplyResources(this.mnuTileHorizontal, "mnuTileHorizontal");
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            resources.ApplyResources(this.mnuTileVertical, "mnuTileVertical");
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuRussian});
            this.mnuLanguage.Name = "mnuLanguage";
            resources.ApplyResources(this.mnuLanguage, "mnuLanguage");
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Name = "mnuEnglish";
            resources.ApplyResources(this.mnuEnglish, "mnuEnglish");
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuRussian
            // 
            this.mnuRussian.Name = "mnuRussian";
            resources.ApplyResources(this.mnuRussian, "mnuRussian");
            this.mnuRussian.Click += new System.EventHandler(this.mnuRussian_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuHelp1});
            this.mnuHelp.Name = "mnuHelp";
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            resources.ApplyResources(this.mnuAbout, "mnuAbout");
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp1
            // 
            this.mnuHelp1.Name = "mnuHelp1";
            resources.ApplyResources(this.mnuHelp1, "mnuHelp1");
            this.mnuHelp1.Click += new System.EventHandler(this.mnuHelp1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Выберете файл";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // toolStripMain
            // 
            this.helpProvider1.SetHelpString(this.toolStripMain, resources.GetString("toolStripMain.HelpString"));
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.toolStripMain, "toolStripMain");
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.tbCut,
            this.tbCopy,
            this.tbPaste});
            this.toolStripMain.Name = "toolStripMain";
            this.helpProvider1.SetShowHelp(this.toolStripMain, ((bool)(resources.GetObject("toolStripMain.ShowHelp"))));
            // 
            // tbNew
            // 
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbNew, "tbNew");
            this.tbNew.Name = "tbNew";
            this.tbNew.Click += new System.EventHandler(this.tbNew_Click);
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbOpen, "tbOpen");
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbSave, "tbSave");
            this.tbSave.Name = "tbSave";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbCut, "tbCut");
            this.tbCut.Name = "tbCut";
            this.tbCut.Click += new System.EventHandler(this.tbCut_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbCopy, "tbCopy");
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbPaste, "tbPaste");
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Click += new System.EventHandler(this.tbPaste_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "new.ico");
            this.imageList1.Images.SetKeyName(1, "open.ico");
            this.imageList1.Images.SetKeyName(2, "save.ico");
            this.imageList1.Images.SetKeyName(3, "cut.ico");
            this.imageList1.Images.SetKeyName(4, "copy.ico");
            this.imageList1.Images.SetKeyName(5, "paste.ico");
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, resources.GetString("button1.HelpString"));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmmain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFront;
        private System.Windows.Forms.ToolStripMenuItem mnuCollor;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTile;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cmnuSaveAs;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton tbNew;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem mnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuRussian;
    }
}

