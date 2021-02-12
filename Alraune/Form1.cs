using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Alraune
{
    public partial class Form1 : Form
    {
        private List<XmlNodeGust> nodes;
        private XmlDocument doc;
        private StringReplacer replacer;
        public Form1()
        {
            InitializeComponent();
            nodes = new List<XmlNodeGust>();
            replacer = new StringReplacer();
        }

        private void LoadXml(string path)
        {
            nodes.Clear();
            doc = new XmlDocument();
            var attributes = new List<XmlAttributeGust>();
            doc.LoadXml(File.ReadAllText(path, Encoding.GetEncoding(932)));
            var i = 0;

            foreach (XmlNode entry in doc.DocumentElement.ChildNodes)
            {
                attributes.Clear();
                foreach (var aceptedXml in (string[])Enum.GetNames(typeof(AceptedXml)))
                {
                    var e = entry.Attributes?[aceptedXml];

                    if (e != null)
                        attributes.Add(new XmlAttributeGust()
                        {
                            Value = e.Value,
                            Name = e.Name
                        });
                }
                
                if (attributes.Count == 0)
                {
                    i++;
                    continue;
                }

                nodes.Add(new XmlNodeGust()
                {
                    Attributes = attributes.ToArray(),
                    Entry = i++
                });
            }

            entriesCount.Text = $@"Total entries: {nodes.Count}";
            entryIndex.Maximum = nodes.Count;

            if (nodes.Count == 0)
            {
                entryIndex.Enabled = false;
                attributeXmlList.Enabled = false;
                xmlAttributeText.Enabled = false;
                updateEntryButton.Enabled = false;
                saveXmlButton.Enabled = false;

                MessageBox.Show("This xml doesn't contains any translatable entries.", "No translatable entries.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            entryIndex.Value = 1;
            entryIndex.Minimum = 1;
            entryIndex.Enabled = true;
            attributeXmlList.Enabled = true;
            xmlAttributeText.Enabled = true;
            updateEntryButton.Enabled = true;
            saveXmlButton.Enabled = true;

            UpdateBox();
        }

        private void UpdateBox()
        {
            if (nodes.Count == 0)
                return;

            attributeXmlList.DataSource = nodes[Convert.ToInt32(entryIndex.Value - 1)].Attributes;
            FillText();
        }

        private void FillText()
        {
            var x = attributeXmlList.SelectedItem as XmlAttributeGust;
            xmlAttributeText.Text = replacer.GetOriginal(x?.Value);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lineCountLabel.Text = $@"Lines: {xmlAttributeText.Lines.Count()}";
            totalLabel.Text = $@"Total: {xmlAttributeText.Text.Length}";
            var current = xmlAttributeText.GetLineFromCharIndex(xmlAttributeText.SelectionStart);
            currentLineLabel.Text = $@"Current line: {current + 1}";
            charaCountLabel.Text =
                $@"Characters: {xmlAttributeText.Lines[current].Length}";
        }

        private void attributeXmlList_Click(object sender, EventArgs e)
        {
            FillText();
        }

        private void entryIndex_ValueChanged(object sender, EventArgs e)
        {
            UpdateBox();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadXml(files[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a Gust xml file",
                Filter = "XML Files(*.xml;*.xml.e)|*.xml;*.xml.e",
                Title = "Open GUST Xml file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadXml(openFileDialog1.FileName);
            }
        }

        private void xmlAttributeText_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           UpdateInfo();
        }

        private void xmlAttributeText_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }


        // https://stackoverflow.com/questions/25696507/in-winforms-previewkeydown-never-fired-for-any-key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down ||
                keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void xmlAttributeText_CursorChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a dictionary MAP file",
                Filter = "Map Files(*.map)|*.map",
                Title = "Open dictionary Map file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var result = replacer.GenerateFontMap(openFileDialog1.FileName);
                if (!result.Item1)
                {
                    MessageBox.Show(result.Item2, "Error loading Map file.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

                dictionaryLabel.Text = $"Dictionary: {(result.Item1?"Yes":"No")}";
            }
        }
    }
}
