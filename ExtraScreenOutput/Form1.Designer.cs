using System.Windows.Forms;

namespace ExtraScreenOutput
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogNotePadLyrics = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogOpenSaved = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLyrics = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxIncludeFirstScreen = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxServiceOutput = new System.Windows.Forms.TextBox();
            this.listBoxServiceOrder = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPageSong = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxLyricsOutput = new System.Windows.Forms.TextBox();
            this.listBoxSongLyrics = new System.Windows.Forms.ListBox();
            this.buttonOpenNotepadLyrics = new System.Windows.Forms.Button();
            this.buttonAddSongStanza = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonOpenSaved = new System.Windows.Forms.Button();
            this.buttonSavePage = new System.Windows.Forms.Button();
            this.labelCurrentStanzaPosition = new System.Windows.Forms.Label();
            this.buttonEditSongStanza = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.tabPageSongList = new System.Windows.Forms.TabPage();
            this.checkBoxShowText = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxGradients = new System.Windows.Forms.CheckBox();
            this.listViewBGImages = new System.Windows.Forms.ListView();
            this.buttonBrowseImages = new System.Windows.Forms.Button();
            this.comboBoxGradientColors = new System.Windows.Forms.ComboBox();
            this.radioButtonUseGradient = new System.Windows.Forms.RadioButton();
            this.radioButtonUseImage = new System.Windows.Forms.RadioButton();
            this.radioButtonUseColor = new System.Windows.Forms.RadioButton();
            this.comboBoxBGColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBGColor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxShadow = new System.Windows.Forms.CheckBox();
            this.checkBoxTextGradientForeColor = new System.Windows.Forms.CheckBox();
            this.checkBoxOutlineBehind = new System.Windows.Forms.CheckBox();
            this.checkBoxGlow = new System.Windows.Forms.CheckBox();
            this.checkBoxDoubleOutline = new System.Windows.Forms.CheckBox();
            this.checkBoxOutlineText = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cgFontCombo1 = new CG.FontCombo.CGFontCombo();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageServiceList = new System.Windows.Forms.TabPage();
            this.tabPageBibleReading = new System.Windows.Forms.TabPage();
            this.comboBoxServiceActivity = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customTabControl1.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPageSong.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageBibleReading.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(364, 594);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(174, 42);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sample Output";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpeg files|*.jpg|png files|*.png";
            this.openFileDialog1.Multiselect = true;
            // 
            // openFileDialogNotePadLyrics
            // 
            this.openFileDialogNotePadLyrics.Filter = "Text Files|*.txt|All Files|*.*";
            this.openFileDialogNotePadLyrics.Title = "Open a text file";
            // 
            // openFileDialogOpenSaved
            // 
            this.openFileDialogOpenSaved.Filter = "Lyrics files|*.ly|Text files|*.txt";
            this.openFileDialogOpenSaved.Title = "Open a previously saved lyrics file";
            // 
            // checkBoxIncludeFirstScreen
            // 
            this.checkBoxIncludeFirstScreen.AutoSize = true;
            this.checkBoxIncludeFirstScreen.Location = new System.Drawing.Point(564, 610);
            this.checkBoxIncludeFirstScreen.Name = "checkBoxIncludeFirstScreen";
            this.checkBoxIncludeFirstScreen.Size = new System.Drawing.Size(115, 17);
            this.checkBoxIncludeFirstScreen.TabIndex = 14;
            this.checkBoxIncludeFirstScreen.Text = "Include this screen";
            this.checkBoxIncludeFirstScreen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(924, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 208);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSampleOutput_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Note: Make Sure you have your monitors or display devices set to - \'Extend these " +
                "displays\'";
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.tabPageService);
            this.customTabControl1.Controls.Add(this.tabPageSong);
            this.customTabControl1.Controls.Add(this.tabPageSongList);
            this.customTabControl1.Controls.Add(this.tabPageServiceList);
            this.customTabControl1.Controls.Add(this.tabPageBibleReading);
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Chrome;
            this.customTabControl1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customTabControl1.Location = new System.Drawing.Point(313, 113);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.Overlap = 16;
            this.customTabControl1.Padding = new System.Drawing.Point(13, 5);
            this.customTabControl1.Radius = 10;
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(605, 470);
            this.customTabControl1.TabIndex = 16;
            // 
            // tabPageService
            // 
            this.tabPageService.AutoScroll = true;
            this.tabPageService.BackColor = System.Drawing.Color.Transparent;
            this.tabPageService.Controls.Add(this.comboBoxServiceActivity);
            this.tabPageService.Controls.Add(this.splitContainer2);
            this.tabPageService.Controls.Add(this.button2);
            this.tabPageService.Controls.Add(this.button5);
            this.tabPageService.Controls.Add(this.button6);
            this.tabPageService.Controls.Add(this.button7);
            this.tabPageService.Controls.Add(this.button8);
            this.tabPageService.Controls.Add(this.button9);
            this.tabPageService.Controls.Add(this.button10);
            this.tabPageService.Location = new System.Drawing.Point(4, 27);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(597, 439);
            this.tabPageService.TabIndex = 0;
            this.tabPageService.Text = "Service";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(8, 59);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxServiceOutput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxServiceOrder);
            this.splitContainer2.Size = new System.Drawing.Size(450, 354);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 19;
            // 
            // textBoxServiceOutput
            // 
            this.textBoxServiceOutput.AcceptsReturn = true;
            this.textBoxServiceOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceOutput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServiceOutput.Location = new System.Drawing.Point(0, 3);
            this.textBoxServiceOutput.Multiline = true;
            this.textBoxServiceOutput.Name = "textBoxServiceOutput";
            this.textBoxServiceOutput.Size = new System.Drawing.Size(450, 104);
            this.textBoxServiceOutput.TabIndex = 1;
            // 
            // listBoxServiceOrder
            // 
            this.listBoxServiceOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxServiceOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxServiceOrder.FormattingEnabled = true;
            this.listBoxServiceOrder.Location = new System.Drawing.Point(0, 0);
            this.listBoxServiceOrder.Name = "listBoxServiceOrder";
            this.listBoxServiceOrder.Size = new System.Drawing.Size(450, 240);
            this.listBoxServiceOrder.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = global::ExtraScreenOutput.Properties.Resources._001_01;
            this.button2.Location = new System.Drawing.Point(466, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 44);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::ExtraScreenOutput.Properties.Resources.folder_explore;
            this.button5.Location = new System.Drawing.Point(466, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 28);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::ExtraScreenOutput.Properties.Resources.page_save;
            this.button6.Location = new System.Drawing.Point(466, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 28);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::ExtraScreenOutput.Properties.Resources._001_45;
            this.button7.Location = new System.Drawing.Point(466, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 44);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::ExtraScreenOutput.Properties.Resources._001_21;
            this.button8.Location = new System.Drawing.Point(530, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 44);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::ExtraScreenOutput.Properties.Resources._001_02;
            this.button9.Location = new System.Drawing.Point(466, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 44);
            this.button9.TabIndex = 18;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::ExtraScreenOutput.Properties.Resources._001_23;
            this.button10.Location = new System.Drawing.Point(466, 296);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 44);
            this.button10.TabIndex = 17;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tabPageSong
            // 
            this.tabPageSong.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSong.Controls.Add(this.splitContainer1);
            this.tabPageSong.Controls.Add(this.buttonOpenNotepadLyrics);
            this.tabPageSong.Controls.Add(this.buttonAddSongStanza);
            this.tabPageSong.Controls.Add(this.button4);
            this.tabPageSong.Controls.Add(this.buttonOpenSaved);
            this.tabPageSong.Controls.Add(this.buttonSavePage);
            this.tabPageSong.Controls.Add(this.labelCurrentStanzaPosition);
            this.tabPageSong.Controls.Add(this.buttonEditSongStanza);
            this.tabPageSong.Controls.Add(this.buttonNext);
            this.tabPageSong.Controls.Add(this.buttonRemove);
            this.tabPageSong.Controls.Add(this.buttonPrevious);
            this.tabPageSong.Location = new System.Drawing.Point(4, 27);
            this.tabPageSong.Name = "tabPageSong";
            this.tabPageSong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSong.Size = new System.Drawing.Size(597, 439);
            this.tabPageSong.TabIndex = 1;
            this.tabPageSong.Text = "Song";
            this.tabPageSong.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(10, 66);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLyricsOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxSongLyrics);
            this.splitContainer1.Size = new System.Drawing.Size(450, 354);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 12;
            // 
            // textBoxLyricsOutput
            // 
            this.textBoxLyricsOutput.AcceptsReturn = true;
            this.textBoxLyricsOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLyricsOutput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLyricsOutput.Location = new System.Drawing.Point(0, 3);
            this.textBoxLyricsOutput.Multiline = true;
            this.textBoxLyricsOutput.Name = "textBoxLyricsOutput";
            this.textBoxLyricsOutput.Size = new System.Drawing.Size(450, 104);
            this.textBoxLyricsOutput.TabIndex = 1;
            this.textBoxLyricsOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            this.textBoxLyricsOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOutput_KeyDown);
            // 
            // listBoxSongLyrics
            // 
            this.listBoxSongLyrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSongLyrics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxSongLyrics.FormattingEnabled = true;
            this.listBoxSongLyrics.Location = new System.Drawing.Point(0, 0);
            this.listBoxSongLyrics.Name = "listBoxSongLyrics";
            this.listBoxSongLyrics.Size = new System.Drawing.Size(450, 240);
            this.listBoxSongLyrics.TabIndex = 7;
            this.listBoxSongLyrics.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBoxSongLyrics.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            this.listBoxSongLyrics.SelectedIndexChanged += new System.EventHandler(this.listBoxSongLyrics_SelectedIndexChanged);
            // 
            // buttonOpenNotepadLyrics
            // 
            this.buttonOpenNotepadLyrics.Image = global::ExtraScreenOutput.Properties.Resources.page_attach;
            this.buttonOpenNotepadLyrics.Location = new System.Drawing.Point(274, 32);
            this.buttonOpenNotepadLyrics.Name = "buttonOpenNotepadLyrics";
            this.buttonOpenNotepadLyrics.Size = new System.Drawing.Size(38, 28);
            this.buttonOpenNotepadLyrics.TabIndex = 13;
            this.buttonOpenNotepadLyrics.UseVisualStyleBackColor = true;
            this.buttonOpenNotepadLyrics.Click += new System.EventHandler(this.buttonOpenNotepadLyrics_Click);
            this.buttonOpenNotepadLyrics.MouseHover += new System.EventHandler(this.buttonOpenNotepadLyrics_MouseHover);
            // 
            // buttonAddSongStanza
            // 
            this.buttonAddSongStanza.Image = global::ExtraScreenOutput.Properties.Resources._001_01;
            this.buttonAddSongStanza.Location = new System.Drawing.Point(468, 63);
            this.buttonAddSongStanza.Name = "buttonAddSongStanza";
            this.buttonAddSongStanza.Size = new System.Drawing.Size(58, 44);
            this.buttonAddSongStanza.TabIndex = 8;
            this.buttonAddSongStanza.UseVisualStyleBackColor = true;
            this.buttonAddSongStanza.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonOpenSaved
            // 
            this.buttonOpenSaved.Image = global::ExtraScreenOutput.Properties.Resources.folder_explore;
            this.buttonOpenSaved.Location = new System.Drawing.Point(318, 32);
            this.buttonOpenSaved.Name = "buttonOpenSaved";
            this.buttonOpenSaved.Size = new System.Drawing.Size(38, 28);
            this.buttonOpenSaved.TabIndex = 13;
            this.buttonOpenSaved.UseVisualStyleBackColor = true;
            this.buttonOpenSaved.Click += new System.EventHandler(this.buttonOpenSaved_Click);
            // 
            // buttonSavePage
            // 
            this.buttonSavePage.Image = global::ExtraScreenOutput.Properties.Resources.page_save;
            this.buttonSavePage.Location = new System.Drawing.Point(362, 32);
            this.buttonSavePage.Name = "buttonSavePage";
            this.buttonSavePage.Size = new System.Drawing.Size(38, 28);
            this.buttonSavePage.TabIndex = 13;
            this.buttonSavePage.UseVisualStyleBackColor = true;
            this.buttonSavePage.Click += new System.EventHandler(this.buttonSavePage_Click);
            // 
            // labelCurrentStanzaPosition
            // 
            this.labelCurrentStanzaPosition.AutoSize = true;
            this.labelCurrentStanzaPosition.Location = new System.Drawing.Point(465, 233);
            this.labelCurrentStanzaPosition.Name = "labelCurrentStanzaPosition";
            this.labelCurrentStanzaPosition.Size = new System.Drawing.Size(34, 13);
            this.labelCurrentStanzaPosition.TabIndex = 9;
            this.labelCurrentStanzaPosition.Text = "0 of 0";
            // 
            // buttonEditSongStanza
            // 
            this.buttonEditSongStanza.Image = global::ExtraScreenOutput.Properties.Resources._001_45;
            this.buttonEditSongStanza.Location = new System.Drawing.Point(468, 123);
            this.buttonEditSongStanza.Name = "buttonEditSongStanza";
            this.buttonEditSongStanza.Size = new System.Drawing.Size(58, 44);
            this.buttonEditSongStanza.TabIndex = 8;
            this.buttonEditSongStanza.UseVisualStyleBackColor = true;
            this.buttonEditSongStanza.Click += new System.EventHandler(this.buttonEditSongStanza_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Image = global::ExtraScreenOutput.Properties.Resources._001_21;
            this.buttonNext.Location = new System.Drawing.Point(532, 249);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(58, 44);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::ExtraScreenOutput.Properties.Resources._001_02;
            this.buttonRemove.Location = new System.Drawing.Point(468, 173);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(58, 44);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemoveSongStanza_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Image = global::ExtraScreenOutput.Properties.Resources._001_23;
            this.buttonPrevious.Location = new System.Drawing.Point(468, 249);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(58, 44);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // tabPageSongList
            // 
            this.tabPageSongList.Location = new System.Drawing.Point(4, 27);
            this.tabPageSongList.Name = "tabPageSongList";
            this.tabPageSongList.Size = new System.Drawing.Size(597, 439);
            this.tabPageSongList.TabIndex = 2;
            this.tabPageSongList.Text = "Song List";
            this.tabPageSongList.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowText
            // 
            this.checkBoxShowText.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowText.Image = global::ExtraScreenOutput.Properties.Resources.font_go;
            this.checkBoxShowText.Location = new System.Drawing.Point(927, 452);
            this.checkBoxShowText.Name = "checkBoxShowText";
            this.checkBoxShowText.Size = new System.Drawing.Size(44, 34);
            this.checkBoxShowText.TabIndex = 15;
            this.checkBoxShowText.UseVisualStyleBackColor = true;
            this.checkBoxShowText.CheckedChanged += new System.EventHandler(this.checkBoxShowText_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Chrome;
            this.tabControl1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl1.Location = new System.Drawing.Point(13, 232);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Overlap = 16;
            this.tabControl1.Padding = new System.Drawing.Point(13, 5);
            this.tabControl1.Radius = 10;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 404);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.checkBoxGradients);
            this.tabPage1.Controls.Add(this.listViewBGImages);
            this.tabPage1.Controls.Add(this.buttonBrowseImages);
            this.tabPage1.Controls.Add(this.comboBoxGradientColors);
            this.tabPage1.Controls.Add(this.radioButtonUseGradient);
            this.tabPage1.Controls.Add(this.radioButtonUseImage);
            this.tabPage1.Controls.Add(this.radioButtonUseColor);
            this.tabPage1.Controls.Add(this.comboBoxBGColor);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelBGColor);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Background";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // checkBoxGradients
            // 
            this.checkBoxGradients.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxGradients.AutoSize = true;
            this.checkBoxGradients.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBoxGradients.Location = new System.Drawing.Point(251, 53);
            this.checkBoxGradients.Name = "checkBoxGradients";
            this.checkBoxGradients.Size = new System.Drawing.Size(31, 28);
            this.checkBoxGradients.TabIndex = 15;
            this.checkBoxGradients.Text = "4";
            this.checkBoxGradients.UseVisualStyleBackColor = true;
            this.checkBoxGradients.Leave += new System.EventHandler(this.checkBoxGradients_Leave);
            this.checkBoxGradients.CheckedChanged += new System.EventHandler(this.checkBoxGradients_CheckedChanged);
            // 
            // listViewBGImages
            // 
            this.listViewBGImages.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewBGImages.Location = new System.Drawing.Point(13, 241);
            this.listViewBGImages.MultiSelect = false;
            this.listViewBGImages.Name = "listViewBGImages";
            this.listViewBGImages.OwnerDraw = true;
            this.listViewBGImages.Size = new System.Drawing.Size(225, 97);
            this.listViewBGImages.TabIndex = 14;
            this.listViewBGImages.TileSize = new System.Drawing.Size(100, 70);
            this.listViewBGImages.UseCompatibleStateImageBehavior = false;
            this.listViewBGImages.View = System.Windows.Forms.View.Tile;
            this.listViewBGImages.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listViewBGImages.SelectedIndexChanged += new System.EventHandler(this.listViewBGImages_SelectedIndexChanged);
            this.listViewBGImages.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // buttonBrowseImages
            // 
            this.buttonBrowseImages.Location = new System.Drawing.Point(186, 345);
            this.buttonBrowseImages.Name = "buttonBrowseImages";
            this.buttonBrowseImages.Size = new System.Drawing.Size(59, 23);
            this.buttonBrowseImages.TabIndex = 13;
            this.buttonBrowseImages.Text = "...";
            this.buttonBrowseImages.UseVisualStyleBackColor = true;
            this.buttonBrowseImages.Click += new System.EventHandler(this.buttonBrowseImages_Click);
            // 
            // comboBoxGradientColors
            // 
            this.comboBoxGradientColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGradientColors.FormattingEnabled = true;
            this.comboBoxGradientColors.Items.AddRange(new object[] {
            "Two Colors",
            "Three Colors"});
            this.comboBoxGradientColors.Location = new System.Drawing.Point(124, 55);
            this.comboBoxGradientColors.Name = "comboBoxGradientColors";
            this.comboBoxGradientColors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGradientColors.TabIndex = 11;
            this.comboBoxGradientColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxGradientColors_SelectedIndexChanged);
            // 
            // radioButtonUseGradient
            // 
            this.radioButtonUseGradient.AutoSize = true;
            this.radioButtonUseGradient.Location = new System.Drawing.Point(13, 56);
            this.radioButtonUseGradient.Name = "radioButtonUseGradient";
            this.radioButtonUseGradient.Size = new System.Drawing.Size(87, 17);
            this.radioButtonUseGradient.TabIndex = 10;
            this.radioButtonUseGradient.Text = "Use Gradient";
            this.radioButtonUseGradient.UseVisualStyleBackColor = true;
            this.radioButtonUseGradient.CheckedChanged += new System.EventHandler(this.radioButtonUseGradient_CheckedChanged);
            // 
            // radioButtonUseImage
            // 
            this.radioButtonUseImage.AutoSize = true;
            this.radioButtonUseImage.Location = new System.Drawing.Point(13, 79);
            this.radioButtonUseImage.Name = "radioButtonUseImage";
            this.radioButtonUseImage.Size = new System.Drawing.Size(76, 17);
            this.radioButtonUseImage.TabIndex = 10;
            this.radioButtonUseImage.Text = "Use Image";
            this.radioButtonUseImage.UseVisualStyleBackColor = true;
            this.radioButtonUseImage.CheckedChanged += new System.EventHandler(this.radioButtonUseImage_CheckedChanged);
            // 
            // radioButtonUseColor
            // 
            this.radioButtonUseColor.AutoSize = true;
            this.radioButtonUseColor.Checked = true;
            this.radioButtonUseColor.Location = new System.Drawing.Point(13, 33);
            this.radioButtonUseColor.Name = "radioButtonUseColor";
            this.radioButtonUseColor.Size = new System.Drawing.Size(71, 17);
            this.radioButtonUseColor.TabIndex = 10;
            this.radioButtonUseColor.TabStop = true;
            this.radioButtonUseColor.Text = "Use Color";
            this.radioButtonUseColor.UseVisualStyleBackColor = true;
            this.radioButtonUseColor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBoxBGColor
            // 
            this.comboBoxBGColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxBGColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBGColor.FormattingEnabled = true;
            this.comboBoxBGColor.Location = new System.Drawing.Point(90, 29);
            this.comboBoxBGColor.Name = "comboBoxBGColor";
            this.comboBoxBGColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxBGColor.TabIndex = 9;
            this.comboBoxBGColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBoxBGColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Background Image";
            // 
            // labelBGColor
            // 
            this.labelBGColor.AutoSize = true;
            this.labelBGColor.Location = new System.Drawing.Point(104, 13);
            this.labelBGColor.Name = "labelBGColor";
            this.labelBGColor.Size = new System.Drawing.Size(92, 13);
            this.labelBGColor.TabIndex = 8;
            this.labelBGColor.Text = "Background Color";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBoxShadow);
            this.tabPage2.Controls.Add(this.checkBoxTextGradientForeColor);
            this.tabPage2.Controls.Add(this.checkBoxOutlineBehind);
            this.tabPage2.Controls.Add(this.checkBoxGlow);
            this.tabPage2.Controls.Add(this.checkBoxDoubleOutline);
            this.tabPage2.Controls.Add(this.checkBoxOutlineText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cgFontCombo1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            // 
            // checkBoxShadow
            // 
            this.checkBoxShadow.AutoSize = true;
            this.checkBoxShadow.Location = new System.Drawing.Point(31, 335);
            this.checkBoxShadow.Name = "checkBoxShadow";
            this.checkBoxShadow.Size = new System.Drawing.Size(65, 17);
            this.checkBoxShadow.TabIndex = 18;
            this.checkBoxShadow.Text = "Shadow";
            this.checkBoxShadow.UseVisualStyleBackColor = true;
            this.checkBoxShadow.CheckedChanged += new System.EventHandler(this.checkBoxShadow_CheckedChanged);
            // 
            // checkBoxTextGradientForeColor
            // 
            this.checkBoxTextGradientForeColor.AutoSize = true;
            this.checkBoxTextGradientForeColor.Location = new System.Drawing.Point(31, 312);
            this.checkBoxTextGradientForeColor.Name = "checkBoxTextGradientForeColor";
            this.checkBoxTextGradientForeColor.Size = new System.Drawing.Size(150, 17);
            this.checkBoxTextGradientForeColor.TabIndex = 18;
            this.checkBoxTextGradientForeColor.Text = "Use Gradient as ForeColor";
            this.checkBoxTextGradientForeColor.UseVisualStyleBackColor = true;
            this.checkBoxTextGradientForeColor.CheckedChanged += new System.EventHandler(this.checkBoxTextGradientForeColor_CheckedChanged);
            // 
            // checkBoxOutlineBehind
            // 
            this.checkBoxOutlineBehind.AutoSize = true;
            this.checkBoxOutlineBehind.Location = new System.Drawing.Point(31, 289);
            this.checkBoxOutlineBehind.Name = "checkBoxOutlineBehind";
            this.checkBoxOutlineBehind.Size = new System.Drawing.Size(119, 17);
            this.checkBoxOutlineBehind.TabIndex = 18;
            this.checkBoxOutlineBehind.Text = "Text Outline Behind";
            this.checkBoxOutlineBehind.UseVisualStyleBackColor = true;
            this.checkBoxOutlineBehind.CheckedChanged += new System.EventHandler(this.checkBoxOutlineBehind_CheckedChanged);
            // 
            // checkBoxGlow
            // 
            this.checkBoxGlow.AutoSize = true;
            this.checkBoxGlow.Location = new System.Drawing.Point(31, 266);
            this.checkBoxGlow.Name = "checkBoxGlow";
            this.checkBoxGlow.Size = new System.Drawing.Size(50, 17);
            this.checkBoxGlow.TabIndex = 18;
            this.checkBoxGlow.Text = "Glow";
            this.checkBoxGlow.UseVisualStyleBackColor = true;
            this.checkBoxGlow.CheckedChanged += new System.EventHandler(this.checkBoxGlow_CheckedChanged);
            // 
            // checkBoxDoubleOutline
            // 
            this.checkBoxDoubleOutline.AutoSize = true;
            this.checkBoxDoubleOutline.Location = new System.Drawing.Point(156, 289);
            this.checkBoxDoubleOutline.Name = "checkBoxDoubleOutline";
            this.checkBoxDoubleOutline.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDoubleOutline.TabIndex = 17;
            this.checkBoxDoubleOutline.Text = "Double Outline";
            this.checkBoxDoubleOutline.UseVisualStyleBackColor = true;
            this.checkBoxDoubleOutline.CheckedChanged += new System.EventHandler(this.checkBoxDoubleOutline_CheckedChanged);
            // 
            // checkBoxOutlineText
            // 
            this.checkBoxOutlineText.AutoSize = true;
            this.checkBoxOutlineText.Location = new System.Drawing.Point(31, 243);
            this.checkBoxOutlineText.Name = "checkBoxOutlineText";
            this.checkBoxOutlineText.Size = new System.Drawing.Size(59, 17);
            this.checkBoxOutlineText.TabIndex = 17;
            this.checkBoxOutlineText.Text = "Outline";
            this.checkBoxOutlineText.UseVisualStyleBackColor = true;
            this.checkBoxOutlineText.CheckedChanged += new System.EventHandler(this.checkBoxOutlineText_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Text Font Family";
            // 
            // cgFontCombo1
            // 
            this.cgFontCombo1.BackColor = System.Drawing.SystemColors.Window;
            this.cgFontCombo1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cgFontCombo1.Location = new System.Drawing.Point(31, 198);
            this.cgFontCombo1.Name = "cgFontCombo1";
            this.cgFontCombo1.Size = new System.Drawing.Size(205, 22);
            this.cgFontCombo1.TabIndex = 15;
            this.cgFontCombo1.Text = "cgFontCombo1";
            this.cgFontCombo1.SelectedIndexChanged += new System.EventHandler(this.cgFontCombo1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox2_DrawItem);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text Color";
            // 
            // tabPageServiceList
            // 
            this.tabPageServiceList.Location = new System.Drawing.Point(4, 27);
            this.tabPageServiceList.Name = "tabPageServiceList";
            this.tabPageServiceList.Size = new System.Drawing.Size(597, 439);
            this.tabPageServiceList.TabIndex = 3;
            this.tabPageServiceList.Text = "Service List";
            this.tabPageServiceList.UseVisualStyleBackColor = true;
            // 
            // tabPageBibleReading
            // 
            this.tabPageBibleReading.Controls.Add(this.comboBox1);
            this.tabPageBibleReading.Controls.Add(this.textBox1);
            this.tabPageBibleReading.Controls.Add(this.label3);
            this.tabPageBibleReading.Controls.Add(this.label1);
            this.tabPageBibleReading.Location = new System.Drawing.Point(4, 27);
            this.tabPageBibleReading.Name = "tabPageBibleReading";
            this.tabPageBibleReading.Size = new System.Drawing.Size(597, 439);
            this.tabPageBibleReading.TabIndex = 4;
            this.tabPageBibleReading.Text = "Bible Reading";
            this.tabPageBibleReading.UseVisualStyleBackColor = true;
            // 
            // comboBoxServiceActivity
            // 
            this.comboBoxServiceActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServiceActivity.FormattingEnabled = true;
            this.comboBoxServiceActivity.Items.AddRange(new object[] {
            "<--Please Select -->",
            "Liturgy",
            "Bible Reading",
            "Song or Hymn"});
            this.comboBoxServiceActivity.Location = new System.Drawing.Point(8, 25);
            this.comboBoxServiceActivity.Name = "comboBoxServiceActivity";
            this.comboBoxServiceActivity.Size = new System.Drawing.Size(195, 21);
            this.comboBoxServiceActivity.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<--Please Select -->",
            "Liturgy",
            "Bible Reading",
            "Song or Hymn"});
            this.comboBox1.Location = new System.Drawing.Point(107, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bible Version";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxShowText);
            this.Controls.Add(this.customTabControl1);
            this.Controls.Add(this.checkBoxIncludeFirstScreen);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customTabControl1.ResumeLayout(false);
            this.tabPageService.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabPageSong.ResumeLayout(false);
            this.tabPageSong.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageBibleReading.ResumeLayout(false);
            this.tabPageBibleReading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLyricsOutput;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxSongLyrics;
        private System.Windows.Forms.Button buttonAddSongStanza;
        private System.Windows.Forms.Button buttonEditSongStanza;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCurrentStanzaPosition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private CustomTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxBGColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBGColor;
        private System.Windows.Forms.TabPage tabPage2;
        private RadioButton radioButtonUseGradient;
        private RadioButton radioButtonUseImage;
        private RadioButton radioButtonUseColor;
        private Label label5;
        private CG.FontCombo.CGFontCombo cgFontCombo1;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBoxGradientColors;
        private Button buttonBrowseImages;
        private ListView listViewBGImages;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBoxGradients;
        private SplitContainer splitContainer1;
        private CheckBox checkBoxOutlineText;
        private Button buttonOpenNotepadLyrics;
        private Button buttonOpenSaved;
        private Button buttonSavePage;
        private Button button4;
        private OpenFileDialog openFileDialogNotePadLyrics;
        private OpenFileDialog openFileDialogOpenSaved;
        private SaveFileDialog saveFileDialogLyrics;
        private ToolTip toolTip1;
        private CheckBox checkBoxIncludeFirstScreen;
        private CheckBox checkBoxGlow;
        private CheckBox checkBoxTextGradientForeColor;
        private CheckBox checkBoxOutlineBehind;
        private CheckBox checkBoxDoubleOutline;
        private CheckBox checkBoxShadow;
        private CheckBox checkBoxShowText;
        private CustomTabControl customTabControl1;
        private TabPage tabPageService;
        private TabPage tabPageSong;
        private Label label2;
        private TabPage tabPageSongList;
        private SplitContainer splitContainer2;
        private TextBox textBoxServiceOutput;
        private ListBox listBoxServiceOrder;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TabPage tabPageServiceList;
        private ComboBox comboBoxServiceActivity;
        private TabPage tabPageBibleReading;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
    }
}

