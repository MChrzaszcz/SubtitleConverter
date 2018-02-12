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

namespace Subtitle_Converter
{
    public partial class Form1 : Form
    {
        private TextTools textTools;
        private StreamReader inputFile;
        private StreamReader outputFile;

        public Form1()
        {
            InitializeComponent();
            textTools = new TextTools();

    }

    private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                inputFile = new StreamReader(openFileDialog1.FileName);
                TBBrowse.Text = openFileDialog1.FileName;
                TBUnconverted.Text = inputFile.ReadToEnd();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                outputFile = new StreamReader(openFileDialog1.FileName);
                TBConverted.Text = textTools.convertToPolishLetters(outputFile);
            }
            catch (Exception)
            {
            }

        }

        private void TBUnconverted_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (TBConverted.Text != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                    outputFile.Close();
                    inputFile.Close();
                    File.WriteAllText(saveFileDialog.FileName, TBConverted.Text);
            }
        }
    }
}
