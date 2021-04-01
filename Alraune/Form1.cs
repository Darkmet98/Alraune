using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private string oriPath;
        private bool modified;
        private string fontFile =
            $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}FOT-TsukuMinPro-B.otf";
        private string mapFile =
            $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}Dictionary.map";

        public Form1()
        {
            InitializeComponent();
            nodes = new List<XmlNodeGust>();
            replacer = new StringReplacer();
            if (File.Exists(mapFile))
                LoadDictionary(mapFile);
            LoadFont();
        }


        private void LoadFont()
        {
            if (!File.Exists(fontFile))
                return;

            var newFont = new PrivateFontCollection();

            newFont.AddFontFile(fontFile);
            var font = new Font(newFont.Families[0], 16);
            xmlAttributeText.Font = font;
            xmlOriAttributeText.Font = font;

        }
        
        private void LoadXml(string path)
        {
            oriPath = path;
            nodes.Clear();
            doc = new XmlDocument();
            var attributes = new List<XmlAttributeGust>();
            doc.LoadXml(File.ReadAllText(path, Encoding.GetEncoding(932)));
            var i = 0;

            foreach (XmlNode entry in doc.DocumentElement.ChildNodes)
            {
                attributes.Clear();
                foreach (var aceptedXml in (string[])Enum.GetNames(typeof(AcceptedAtributesXml)))
                {
                    var e = entry.Attributes?[aceptedXml];

                    if (e != null)
                    {
                        var ori = entry.Attributes?[aceptedXml + "_ori"];

                        if (ori == null)
                            attributes.Add(new XmlAttributeGust()
                            {
                                ValueOri = e.Value,
                                Name = e.Name
                            });
                        else
                        {
                            attributes.Add(new XmlAttributeGust()
                            {
                                ValueOri = ori.Value,
                                Value = ori.Value == e.Value ? "" : e.Value,
                                Name = e.Name
                            });
                        }
                            
                    }
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


            if (modified)
            {
                var dialogResult = MessageBox.Show("You have modified the translation.\nDo you want to change the entry without saving your text?", "Translation modified", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                
            }

            attributeXmlList.DataSource = nodes[Convert.ToInt32(entryIndex.Value - 1)].Attributes;
            FillText();
        }

        private void FillText()
        {

            if (modified)
            {
                var dialogResult = MessageBox.Show("You have modified the translation.\nDo you want to change the entry without saving your text?", "Translation modified", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            var x = attributeXmlList.SelectedItem as XmlAttributeGust;
            xmlAttributeText.Text = replacer.GetOriginal(x?.Value);
            xmlOriAttributeText.Text = replacer.GetOriginal(x?.ValueOri);
            modified = false;
            labelTranslated.Text = "Translated";
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lineCountLabel.Text = $@"Lines: {xmlAttributeText.Lines.Count()}";
            totalLabel.Text = $@"Total: {xmlAttributeText.Text.Length}";
            var current = xmlAttributeText.GetLineFromCharIndex(xmlAttributeText.SelectionStart);
            currentLineLabel.Text = $@"Current line: {current + 1}";
            if (xmlAttributeText.Lines.Length == 0)
                return;
            charaCountLabel.Text =
                $@"Characters: {xmlAttributeText.Lines[current].Length}";
        }

        private void LoadDictionary(string path)
        {
            var result = replacer.GenerateFontMap(path);
            if (!result.Item1)
            {
                MessageBox.Show(result.Item2, "Error loading Map file.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            dictionaryLabel.Text = $"Dictionary: {(result.Item1 ? "Yes" : "No")}";
        }

        private void SaveTranslation()
        {
            var x = attributeXmlList.SelectedItem as XmlAttributeGust;
            x.Value = replacer.GetModified(xmlAttributeText.Text);
            labelTranslated.Text = "Translated";
            modified = false;
        }

        #region Winforms_Actions

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
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                SaveTranslation();
                return;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Left)
            {
                if (entryIndex.Value == 1)
                    return;

                entryIndex.Value--;
                return;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Right)
            {
                if (entryIndex.Value == entryIndex.Maximum)
                    return;

                entryIndex.Value++;
                return;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Up)
            {
                if (attributeXmlList.SelectedIndex == 0)
                    return;
                attributeXmlList.SelectedIndex--;
                FillText();
                return;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Down)
            {
                if (attributeXmlList.SelectedIndex == attributeXmlList.Items.Count-1)
                    return;
                attributeXmlList.SelectedIndex++;
                FillText();
                return;
            }

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
                LoadDictionary(openFileDialog1.FileName);
        }

        private void updateEntryButton_Click(object sender, EventArgs e)
        {
            SaveTranslation();
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            // Make a backup
            doc.Save(oriPath + $"_{DateTime.Now:dd-MM-yyyy HH-mm-ss}_.backup");
            var root = doc.DocumentElement.ChildNodes;
            foreach (var node in nodes)
            {
                foreach (var attribute in node.Attributes)
                {
                    root[node.Entry].Attributes[attribute.Name].Value = (string.IsNullOrWhiteSpace(attribute.Value))
                        ? attribute.ValueOri
                        : attribute.Value;
                    if (root[node.Entry].Attributes[attribute.Name + "_ori"] == null)
                    {
                        var attr = doc.CreateAttribute(attribute.Name + "_ori");
                        attr.Value = attribute.ValueOri;
                        root[node.Entry].Attributes.Append(attr);
                    }
                }

            }

            doc.Save(oriPath);
        }

        private void xmlAttributeText_TextChanged(object sender, EventArgs e)
        {
            modified = true;
            labelTranslated.Text = "Translated - Modified";
        }

        private void xmlAttributeText_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = (e.KeyData == (Keys.Control | Keys.Enter));
        }

        #endregion

    }
}
