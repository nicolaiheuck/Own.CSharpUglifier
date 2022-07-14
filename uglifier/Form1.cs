using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglifierLib;

namespace uglifier
{
    public partial class Form1 : Form
    {
        private readonly CodeUglifier _uglifier;
        private FileInfo _file;
        private IndentationUglificationMode _mode;
        public Form1()
        {
            InitializeComponent();
            _uglifier = new CodeUglifier();
        }
        private void RunBtn_Click(object sender, EventArgs e)
        {
            string code = File.ReadAllText(_file.FullName);
            GetModeFromRadioButtons();
            string output = _uglifier.UglifyCode(code, _mode);

            Clipboard.SetText(output);
            MessageBox.Show("Uglified code copied to your clipboard");
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            PrivateDragDrop(e);
        }
        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            PrivateDragDrop(e);
        }
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            PrivateDragEnter(e);
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            PrivateDragEnter(e);
        }

        private void PrivateDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void PrivateDragDrop(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            string file = files.FirstOrDefault();

            if (file == null)
            {
                MessageBox.Show("File not found");
                return;
            }
            if (!file.EndsWith(".cs"))
            {
                MessageBox.Show("The file needs to end with .cs");
                return;
            }

            _file = new FileInfo(file);
            DragDropLabel.Text = $"File: {_file.Name}";
        }

        private void GetModeFromRadioButtons()
        {
            if (NoIndentationOption.Checked)
            {
                _mode = IndentationUglificationMode.NoIndentation;
            }
            else if (LineNumberSpaceOption.Checked)
            {
                _mode = IndentationUglificationMode.LineNumberAmountOfSpace;
            }
            else if (LineNumberSpaceInvertedOption.Checked)
            {
                _mode = IndentationUglificationMode.LineNumberAmountOfSpaceInverted;
            }
            else if (RandomIndentationOption.Checked)
            {
                _mode = IndentationUglificationMode.RandomIndentation;
            }
        }
    }
}