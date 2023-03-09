using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object saveFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tekstovi failove |*.txt|Word files|*.doc,*docx|All files|*.*";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile("C://11D Miglena Разработка на софтуер//proba.txt");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = "Tekstovi failove |*.txt|Word files|*.doc,*docx|All files|*.*";
            saveFileDialog2.FilterIndex = 1;
            saveFileDialog2.ShowDialog();
            richTextBox1.SaveFile("C://11D Miglena Разработка на софтуер//proba.txt");
            richTextBox1.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.RichText);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
          
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();   
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
