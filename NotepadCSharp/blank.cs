using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotepadCSharp
{
    public partial class blank : Form
    {
        public blank()
        {
            InitializeComponent();
            //Свойству Text панели sbTime устанавливаем системное время, 
            // конвертировав его в тип String
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            //В тексте всплывающей подсказки  выводим текущую дату
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        public string DocName = "";
        public bool IsSaved = false;

        // Вырезание текста
        public void Cut()
        {
            richTextBox1.Cut();
        }

        // Копирование текста
        public void Copy()
        {
            richTextBox1.Copy();
        }

        // Вставка
        public void Paste()
        {
            richTextBox1.Paste();
        }

        // Выделение всего текста — используем свойство SelectAll элемента управления RichTextBox 
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        // Удаление
        public void Delete()
        {
            richTextBox1.SelectedText = "";
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        //Создаем метод Open, в качестве параметра объявляем строку адреса  файла.
        public void Open(string OpenFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                //Создаем новый объект StreamReader и передаем ему переменную //OpenFileName
                StreamReader sr = new StreamReader(OpenFileName);
                //Читаем весь файл и записываем его в richTextBox1
                richTextBox1.Text = sr.ReadToEnd();
                // Закрываем поток
                sr.Close();
                //Переменной DocName присваиваем адресную строку
                DocName = OpenFileName;
            }
        }

        //Создаем метод Save, в качестве параметра объявляем строку адреса  файла.
        public void Save(string SaveFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                //Создаем новый объект StreamWriter и передаем ему переменную //OpenFileName
                StreamWriter sw = new StreamWriter(SaveFileName);
                //Содержимое richTextBox1 записываем в файл
                sw.WriteLine(richTextBox1.Text);
                //Закрываем поток
                sw.Close();
                //Устанавливаем в качестве имени документа название сохраненного файла
                DocName = SaveFileName;
            }
        }

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmain frmm = (frmmain)this.MdiParent;
            //Если переменная IsSaved имеет значение true, т. е.  новый документ 
            //был сохранен (Save As) или в открытом документе были сохранены изменения (Save), то //выполняется условие
            if (IsSaved == true) //Появляется диалоговое окно, предлагающее сохранить документ.
             // if (MessageBox.Show(frmm.resourceManager.GetString("MessageText"), frmm.resourceManager.GetString("ItemText"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (MessageBox.Show("Вы хотите сохранить изменения в документе?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName); //Если была нажата  кнопка Yes, вызываем метод Save
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Свойству Text панели sbAmount устанавливаем надпись "Аmount of symbols" 
            //и длину  текста в RichTextBox.
            sbAmount.Text = "Аmount of symbols " + richTextBox1.Text.Length.ToString();
        }
    }
}
