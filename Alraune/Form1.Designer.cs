
namespace Alraune
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.charaCountLabel = new System.Windows.Forms.Label();
            this.xmlAttributeText = new System.Windows.Forms.TextBox();
            this.entryIndex = new System.Windows.Forms.NumericUpDown();
            this.attributeXmlList = new System.Windows.Forms.ListBox();
            this.updateEntryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.entriesCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveXmlButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.lineCountLabel = new System.Windows.Forms.Label();
            this.currentLineLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dictionaryLabel = new System.Windows.Forms.Label();
            this.xmlOriAttributeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTranslated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // charaCountLabel
            // 
            this.charaCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charaCountLabel.AutoSize = true;
            this.charaCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charaCountLabel.Location = new System.Drawing.Point(783, 753);
            this.charaCountLabel.Name = "charaCountLabel";
            this.charaCountLabel.Size = new System.Drawing.Size(151, 32);
            this.charaCountLabel.TabIndex = 1;
            this.charaCountLabel.Text = "Characters: X";
            // 
            // xmlAttributeText
            // 
            this.xmlAttributeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlAttributeText.Enabled = false;
            this.xmlAttributeText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xmlAttributeText.Location = new System.Drawing.Point(495, 379);
            this.xmlAttributeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmlAttributeText.Multiline = true;
            this.xmlAttributeText.Name = "xmlAttributeText";
            this.xmlAttributeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlAttributeText.Size = new System.Drawing.Size(924, 369);
            this.xmlAttributeText.TabIndex = 3;
            this.xmlAttributeText.Click += new System.EventHandler(this.xmlAttributeText_Click);
            this.xmlAttributeText.CursorChanged += new System.EventHandler(this.xmlAttributeText_CursorChanged);
            this.xmlAttributeText.TextChanged += new System.EventHandler(this.xmlAttributeText_TextChanged);
            this.xmlAttributeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xmlAttributeText_KeyDown);
            this.xmlAttributeText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.xmlAttributeText_PreviewKeyDown);
            // 
            // entryIndex
            // 
            this.entryIndex.Enabled = false;
            this.entryIndex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryIndex.Location = new System.Drawing.Point(337, 133);
            this.entryIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entryIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entryIndex.Name = "entryIndex";
            this.entryIndex.Size = new System.Drawing.Size(151, 39);
            this.entryIndex.TabIndex = 7;
            this.entryIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entryIndex.ValueChanged += new System.EventHandler(this.entryIndex_ValueChanged);
            // 
            // attributeXmlList
            // 
            this.attributeXmlList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.attributeXmlList.Enabled = false;
            this.attributeXmlList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attributeXmlList.FormattingEnabled = true;
            this.attributeXmlList.ItemHeight = 32;
            this.attributeXmlList.Location = new System.Drawing.Point(14, 181);
            this.attributeXmlList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attributeXmlList.Name = "attributeXmlList";
            this.attributeXmlList.Size = new System.Drawing.Size(474, 580);
            this.attributeXmlList.TabIndex = 8;
            this.attributeXmlList.Click += new System.EventHandler(this.attributeXmlList_Click);
            // 
            // updateEntryButton
            // 
            this.updateEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateEntryButton.Enabled = false;
            this.updateEntryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateEntryButton.Location = new System.Drawing.Point(1309, 757);
            this.updateEntryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateEntryButton.Name = "updateEntryButton";
            this.updateEntryButton.Size = new System.Drawing.Size(111, 47);
            this.updateEntryButton.TabIndex = 9;
            this.updateEntryButton.Text = "Save text";
            this.updateEntryButton.UseVisualStyleBackColor = true;
            this.updateEntryButton.Click += new System.EventHandler(this.updateEntryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Entry";
            // 
            // entriesCount
            // 
            this.entriesCount.AutoSize = true;
            this.entriesCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entriesCount.Location = new System.Drawing.Point(267, 87);
            this.entriesCount.Name = "entriesCount";
            this.entriesCount.Size = new System.Drawing.Size(189, 37);
            this.entriesCount.TabIndex = 11;
            this.entriesCount.Text = "Total entries: X";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Load XML.e file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveXmlButton
            // 
            this.saveXmlButton.Enabled = false;
            this.saveXmlButton.Location = new System.Drawing.Point(264, 17);
            this.saveXmlButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveXmlButton.Name = "saveXmlButton";
            this.saveXmlButton.Size = new System.Drawing.Size(224, 31);
            this.saveXmlButton.TabIndex = 13;
            this.saveXmlButton.Text = "Save XML.e file";
            this.saveXmlButton.UseVisualStyleBackColor = true;
            this.saveXmlButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(958, 753);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(91, 32);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total: X";
            // 
            // lineCountLabel
            // 
            this.lineCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCountLabel.AutoSize = true;
            this.lineCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineCountLabel.Location = new System.Drawing.Point(501, 753);
            this.lineCountLabel.Name = "lineCountLabel";
            this.lineCountLabel.Size = new System.Drawing.Size(94, 32);
            this.lineCountLabel.TabIndex = 15;
            this.lineCountLabel.Text = "Lines: X";
            // 
            // currentLineLabel
            // 
            this.currentLineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentLineLabel.AutoSize = true;
            this.currentLineLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentLineLabel.Location = new System.Drawing.Point(608, 753);
            this.currentLineLabel.Name = "currentLineLabel";
            this.currentLineLabel.Size = new System.Drawing.Size(166, 32);
            this.currentLineLabel.TabIndex = 16;
            this.currentLineLabel.Text = "Current line: X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Load .map dictionary file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dictionaryLabel
            // 
            this.dictionaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryLabel.AutoSize = true;
            this.dictionaryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dictionaryLabel.Location = new System.Drawing.Point(53, 87);
            this.dictionaryLabel.Name = "dictionaryLabel";
            this.dictionaryLabel.Size = new System.Drawing.Size(166, 32);
            this.dictionaryLabel.TabIndex = 18;
            this.dictionaryLabel.Text = "Dictionary: No";
            // 
            // xmlOriAttributeText
            // 
            this.xmlOriAttributeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlOriAttributeText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xmlOriAttributeText.Location = new System.Drawing.Point(501, 56);
            this.xmlOriAttributeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmlOriAttributeText.Multiline = true;
            this.xmlOriAttributeText.Name = "xmlOriAttributeText";
            this.xmlOriAttributeText.ReadOnly = true;
            this.xmlOriAttributeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlOriAttributeText.Size = new System.Drawing.Size(924, 280);
            this.xmlOriAttributeText.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Original";
            // 
            // labelTranslated
            // 
            this.labelTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTranslated.AutoSize = true;
            this.labelTranslated.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTranslated.Location = new System.Drawing.Point(501, 341);
            this.labelTranslated.Name = "labelTranslated";
            this.labelTranslated.Size = new System.Drawing.Size(122, 32);
            this.labelTranslated.TabIndex = 21;
            this.labelTranslated.Text = "Translated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "CTRL + Enter: Save translation | CTRL + Up/Down: Change attribute | CTRL + Left/R" +
    "ight: Change entry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Attributes";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 807);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTranslated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmlOriAttributeText);
            this.Controls.Add(this.dictionaryLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentLineLabel);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.saveXmlButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.entriesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateEntryButton);
            this.Controls.Add(this.attributeXmlList);
            this.Controls.Add(this.entryIndex);
            this.Controls.Add(this.xmlAttributeText);
            this.Controls.Add(this.charaCountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alraune XML.e Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.entryIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label charaCountLabel;
        private System.Windows.Forms.TextBox xmlAttributeText;
        private System.Windows.Forms.NumericUpDown entryIndex;
        private System.Windows.Forms.ListBox attributeXmlList;
        private System.Windows.Forms.Button updateEntryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label entriesCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveXmlButton;
        private System.Windows.Forms.Label linCountLabel;
        private System.Windows.Forms.Label lineCountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label currentLineLabel;
        private System.Windows.Forms.Label cu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dictionaryLabel;
        private System.Windows.Forms.TextBox xmlOriAttributeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTranslated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

