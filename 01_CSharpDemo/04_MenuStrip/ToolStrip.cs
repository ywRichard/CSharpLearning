using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MenuStrip
{
    public partial class ToolStrip : Form
    {
        public ToolStrip()
        {
            InitializeComponent();

            fontToolStripComboBox.SelectedIndex = 0;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"Help.rtf");
            }
            catch { }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile(@"Help.rtf");
            }
            catch { }
        }

        private void BoldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            boldToolStripButton.Checked = boldToolStripMenuItem.Checked;
        }

        private void ItalicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            italicToolStripButton.Checked = italicToolStripMenuItem.Checked;
        }

        private void UnderlineToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            underlineToolStripButton.Checked = underlineToolStripMenuItem.Checked;
        }

        private void boldToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBox1.Font;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);//取消粗体
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);//设置粗体

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

            boldToolStripButton.CheckedChanged -= new EventHandler(boldToolStripButton_CheckedChanged);
            boldToolStripButton.Checked = checkState;
            boldToolStripButton.CheckedChanged += new EventHandler(boldToolStripButton_CheckedChanged);

            tssLabelBold.Enabled = checkState;
        }

        private void italicToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = ((ToolStripButton)sender).Checked;
            var oldFont = this.richTextBox1.Font;

            Font newFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

            italicToolStripButton.CheckedChanged -= new EventHandler(italicToolStripButton_CheckedChanged);//下面防止初始化，触发事件
            italicToolStripButton.Checked = checkState;
            italicToolStripButton.CheckedChanged += new EventHandler(italicToolStripButton_CheckedChanged);

            tssLabelItalic.Enabled = checkState;
        }

        private void underlineToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = ((ToolStripButton)sender).Checked;
            var oldFont = this.richTextBox1.Font;

            Font newFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

            underlineToolStripButton.CheckedChanged -= new EventHandler(underlineToolStripButton_CheckedChanged);
            underlineToolStripButton.Checked = checkState;
            underlineToolStripButton.CheckedChanged += new EventHandler(underlineToolStripButton_CheckedChanged);

            tssLabelUnderline.Enabled = checkState;
        }

        private void fontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            Font newFont = null;

            if (richTextBox1.SelectionFont == null)
                newFont = new Font(text, richTextBox1.Font.Size);
            else
                newFont = new Font(text, 
                    richTextBox1.SelectionFont.Size, 
                    richTextBox1.SelectionFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tssLabelText.Text = "Number of chracter:" + richTextBox1.Text.Length;
        }
    }
}
