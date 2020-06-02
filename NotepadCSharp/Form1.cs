using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization; //Пространство имен, используемое для определения культуры приложения и операционной системы
using System.Resources; //Пространство, используемое для работы с файлами ресурсов .resx, такими как ClosingText.en-US.resx, ClosingText.ru-RU.resx.
using System.Reflection; //Пространство для работы со сборками



namespace NotepadCSharp
{
    public partial class frmmain : Form
    { 
        public string CultureDefine; //Переменная выбора, необходимая для определения культуры
        private string EnglishCulture; //Переменная для хранения английской культуры
        private string RussianCulture; //Переменная для русской культуры
        public ResourceManager resourceManager;

        public frmmain()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
            EnglishCulture = "en-US"; //Инициализируем переменные
            RussianCulture = "ru-RU";
            CultureDefine = CultureInfo.InstalledUICulture.ToString(); // Перменной CultureDefine присваиваем значение культуры, установленной на компьютере, используя свойство класса ResourceManager
            resourceManager = new ResourceManager("NotepadCSharp.ClosingText", Assembly.GetExecutingAssembly()); // Создаем новый объект resourceManager, извлекающий из сборки текстовую переменную ClosingText
            mnuSave.Enabled = false;
        }

        public frmmain(string FormCulture)
        {
            InitializeComponent();
            EnglishCulture = "en-US";
            RussianCulture = "ru-RU";
            CultureDefine = FormCulture; //В качестве культуры устанавливаем значение CultureDefine
            resourceManager = new ResourceManager("NotepadCSharp.ClosingText", Assembly.GetExecutingAssembly()); // Создаем новый объект resourceManager, извлекающий из сборки текстовую переменную ClosingText
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }
        private int openDocuments = 0;

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Создаем новый документ
                blank frm = new blank();
                //Вызываем метод Open формы blank
                frm.Open(openFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной DocName имя открываемого файла
                frm.DocName = openFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                //Вызываем форму frm
                frm.Show();
            }
            mnuSave.Enabled = true;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void cmnuSaveAs_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Переключаем фокус на данную форму.
                blank frm = (blank)this.ActiveMdiChild;
                //Вызываем метод Save формы blank
                frm.Save(saveFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной FileName имя сохраняемого файла
                frm.DocName = saveFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                //Вызываем метод Save формы blank
                frm.Save(frm.DocName);
                frm.IsSaved = true;
            }
            mnuSave.Enabled = true;
        }

        private void mnuFront_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Указываем, что родительской формой является форма frmmain	
            frm.MdiParent = this;
            //Вызываем диалог
            fontDialog1.ShowColor = true;
            //Связываем свойства SelectionFont и SelectionColor элемента RichTextBox 
            //с соответствующими свойствами диалога
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            //Если выбран диалог открытия файла, выполняем условие
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //Показываем форму
            frm.Show();
        }

        private void mnuCollor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы  About
            About frm = new About();
            frm.ShowDialog();
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            mnuNew_Click(this, new EventArgs());
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            mnuOpen_Click(this, new EventArgs());
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            mnuSave_Click(this, new EventArgs());
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            mnuCut_Click(this, new EventArgs());
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            mnuCopy_Click(this, new EventArgs());
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            mnuPaste_Click(this, new EventArgs());
        }

        private void mnuHelp1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "https://vk.com/efimka08");
        }

        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            CultureDefine = EnglishCulture; //Устанавливаем английскую культуру в качестве выбранной. 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false); // Устанавливаем выбранную культуру в качестве культуры  пользовательского интерфейса
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false); // Устанавливаем в качестве текущей культуры выбранную
            frmmain frm = new frmmain(CultureDefine); //Создаем новый экземпляр frm формы frmmain:
            this.Hide(); //Скрываем текущий экземпляр
            frm.Show(); //Вызываем новый экземпляр
        }

        private void mnuRussian_Click(object sender, EventArgs e)
        {
            CultureDefine = RussianCulture;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false);
            frmmain frm = new frmmain(CultureDefine);
            this.Hide();
            frm.Show();
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "D:/Справка.html");
        }
    }
}
