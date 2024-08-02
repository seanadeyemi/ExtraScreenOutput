using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using vbAccelerator.Components.Controls;

namespace ExtraScreenOutput
{
    public partial class Form1 : Form
    {

        public string TextOutput;
        public Color bgColor = Color.Black;
        public Color foreColor = Color.White;
        public FontFamily fontfam = FontFamily.GenericSansSerif;
        private OutputForms firstForm = null;
        List<Image> images = new List<Image>();
        private PopupWindowHelper popupHelper = null;
        public BackgroundStyle bgStyle;
        public BackgroundInfo backInfo;
        public bool outlineChecked = false;
        public bool glowChecked = false;
        public bool gradientTextForeColor = false;
        public bool textOutlineBehind = false;
        public bool textDoubleOutlineBehind = false;
        public bool textShadow = false;
        public bool textVisible = false;


        public Form1()
        {
            InitializeComponent();
            bgStyle = BackgroundStyle.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           comboBoxBGColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxBGColor.SelectedIndex = 0;

            comboBox2.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBox2.SelectedIndex = 0;

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

            comboBoxGradientColors.SelectedIndex = 0;
            EnableCurrentControls();
            timer1.Start();

        }

        private void popupHelper_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            GradientsForm popup = (GradientsForm)e.Popup;
           // lblSelectedItem.Text = popup.SelectedItem;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            //popupHelper.AssignHandle(tabPage1.Handle);
            //base.OnHandleCreated(e);
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int count = 0;


            foreach (Screen screen in Screen.AllScreens)
            {
                //MessageBox.Show(screen.DeviceName);
                count++;
            }
            int screenstart = 1;
            if(checkBoxIncludeFirstScreen.Checked)
            {
                screenstart = 0;
            }


            if (count > 0)
            {
                //MessageBox.Show("yes");
                for (int k = screenstart; k < count; k++)
                {
                    Rectangle rct = Screen.AllScreens[k].Bounds;
                    OutputForms screenForm = new OutputForms(this);
                    screenForm.StartPosition = FormStartPosition.Manual;
                    screenForm.DesktopLocation = rct.Location;
                    screenForm.DesktopBounds = rct;
                    if(k == 1)
                    {
                        firstForm = screenForm;
                    }
                    screenForm.Show();
                }
            }

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            int itemIndex = e.Index;

            e.DrawBackground();

            if (itemIndex >= 0)
            {
                string knownColorName = ((ComboBox)sender).Items[itemIndex].ToString();

                Rectangle textRectangle = e.Bounds;
                Rectangle colorRectangle = e.Bounds;
                colorRectangle.X += 2;
                colorRectangle.Y += 2;
                colorRectangle.Width = 16;
                colorRectangle.Height -= 4;

                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                Color color = Color.FromKnownColor(k);
                SolidBrush colorBrush = new SolidBrush(color);
                e.Graphics.FillRectangle(colorBrush, colorRectangle);
                colorBrush.Dispose();
                e.Graphics.DrawRectangle(SystemPens.ControlDarkDark, colorRectangle);

                textRectangle.X += 20;
                textRectangle.Width -= 20;

                Brush textBrush;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    textBrush = SystemBrushes.HighlightText;
                }
                else
                {
                    textBrush = SystemBrushes.ControlText;
                }
                e.Graphics.DrawString(knownColorName, e.Font, textBrush, textRectangle);
            }
            //else if (itemIndex == 0)
            //{
            //    Rectangle textRectangle = e.Bounds;
            //    Brush textBrush;
            //    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //    {
            //        textBrush = SystemBrushes.HighlightText;
            //    }
            //    else
            //    {
            //        textBrush = SystemBrushes.ControlText;
            //    }
            //    e.Graphics.DrawString(((ComboBox)sender).Items[itemIndex].ToString(), e.Font, textBrush, textRectangle);
            //}

            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
            {
                e.DrawFocusRectangle();
            }	
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxBGColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxBGColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                Color color = Color.FromKnownColor(k);
                bgColor = color;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBox2.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBox2.Items[itemIndex].ToString();
                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                Color color = Color.FromKnownColor(k);
                foreColor = color;

            }
        }

        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            comboBox1_DrawItem(sender, e);
        }

        private void cgFontCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontfam = cgFontCombo1.SelectedFontFamily;
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 55;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxLyricsOutput.Text))
            {
                AddText(textBoxLyricsOutput.Text);
                textBoxLyricsOutput.Clear();
                textBoxLyricsOutput.Focus();
            }
        }
        void AddText(string textToAdd)
        {
            listBoxSongLyrics.Items.Add(textToAdd);
            labelCurrentStanzaPosition.Text = string.Format("{0} of {1}", (listBoxSongLyrics.SelectedIndex + 1), listBoxSongLyrics.Items.Count);
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
          if((listBoxSongLyrics.SelectedIndex) > 0)
          {
              listBoxSongLyrics.SelectedIndex = listBoxSongLyrics.SelectedIndex - 1;
          }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
  if((listBoxSongLyrics.SelectedIndex + 1) < listBoxSongLyrics.Items.Count)
            {
                listBoxSongLyrics.SelectedIndex = listBoxSongLyrics.SelectedIndex + 1;
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;
            Graphics g = e.Graphics;
           if(e.Index != -1)
           {
               if ((e.State & DrawItemState.Selected) != DrawItemState.Selected) //if (e.State != (e.State & DrawItemState.Selected))
               {
                   g.FillRectangle(Brushes.White, e.Bounds);
                   g.DrawString(listBoxSongLyrics.Items[e.Index].ToString(), SystemFonts.MenuFont, Brushes.Black, e.Bounds, sf);
                   sf.Dispose();
               }
               else
               {
                   g.FillRectangle(SystemBrushes.MenuHighlight, e.Bounds);
                   g.DrawString(listBoxSongLyrics.Items[e.Index].ToString(), SystemFonts.MenuFont, Brushes.White, e.Bounds, sf);
                   sf.Dispose();
               }
           }
        }

        private void listBoxSongLyrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongLyrics.SelectedIndex != -1)
            {
                labelCurrentStanzaPosition.Text = string.Format("{0} of {1}", (listBoxSongLyrics.SelectedIndex + 1), listBoxSongLyrics.Items.Count);
                TextOutput = listBoxSongLyrics.Items[listBoxSongLyrics.SelectedIndex].ToString();
            }
        }

        private void buttonRemoveSongStanza_Click(object sender, EventArgs e)
        {
            if(listBoxSongLyrics.SelectedIndex >= 0)
            {
                int oldpos = listBoxSongLyrics.SelectedIndex;
                listBoxSongLyrics.Items.RemoveAt(listBoxSongLyrics.SelectedIndex);
                if (listBoxSongLyrics.Items.Count >= 1)
                {
                    if((oldpos - 1) > 0)
                    {
                        listBoxSongLyrics.SelectedIndex = oldpos - 1;
                    }
                    labelCurrentStanzaPosition.Text = string.Format("{0} of {1}", (listBoxSongLyrics.SelectedIndex + 1), listBoxSongLyrics.Items.Count);
                }
            }
        }

        private void pictureBoxSampleOutput_Paint(object sender, PaintEventArgs e)
        {
            if(firstForm != null)
            {
                Graphics g = e.Graphics;
                if(firstForm.screenStuff != null)
                g.DrawImage(firstForm.screenStuff,0,0,pictureBox1.ClientRectangle.Width,pictureBox1.ClientRectangle.Height);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void textBoxOutput_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Return)
            //{
            //    buttonAdd.PerformClick();
            //}
        }

        private void listBox2BGImages_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            //e.ItemHeight = listBox2BGImages.Height;
           
        }

        private void listBox2BGImages_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;
            Graphics g = e.Graphics;

            if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)//if (e.State != (e.State & DrawItemState.Selected))
            {
                g.FillRectangle(Brushes.White, e.Bounds);
                g.DrawString(((ListBox)sender).Items[e.Index].ToString(), SystemFonts.MenuFont, Brushes.Black, e.Bounds, sf);
                sf.Dispose();
            }
            else
            {
                g.FillRectangle(SystemBrushes.MenuHighlight, e.Bounds);
                g.DrawString(((ListBox)sender).Items[e.Index].ToString(), SystemFonts.MenuFont, Brushes.White, e.Bounds, sf);
                sf.Dispose();
            }
            
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;
            Graphics g = e.Graphics;

            if ((e.State & ListViewItemStates.Selected) != ListViewItemStates.Selected)//if (e.State != (e.State & DrawItemState.Selected))
            {
                g.FillRectangle(Brushes.White, e.Bounds);//((ListBox)sender).Items[e.ItemIndex].ToString()
                //g.DrawString("Helloo", SystemFonts.MenuFont, Brushes.Black, e.Bounds, sf);
                RectangleF rt = e.Bounds;
                rt.Inflate(-5,-5);
                g.DrawImage(images[e.ItemIndex],rt) ;
                sf.Dispose();
            }
            else
            {
                g.FillRectangle(SystemBrushes.MenuHighlight, e.Bounds);//((ListBox)sender).Items[e.ItemIndex].ToString()
               // g.DrawString("Helloo", SystemFonts.MenuFont, Brushes.White, e.Bounds, sf);
                 RectangleF rt = e.Bounds;
                rt.Inflate(-5,-5);
                g.DrawImage(images[e.ItemIndex],rt) ;
                sf.Dispose();
            }
        }

        private void buttonBrowseImages_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileNames.Length > 0)
                {
                    foreach (string nm in openFileDialog1.FileNames)
                    {
                        string fname = nm;//openFileDialog1.FileName;
                        Image img = Image.FromFile(fname);
                        images.Add(img);
                        listViewBGImages.Items.Add("");
                        //listViewBGImages.Refresh();
                        //if(listViewBGImages.Items.Count > 0)
                        {
                            // listViewBGImages.Items[0].Selected = true;
                        }
                    }
                }

            }
        }

        private void RenewImageList()
        {

        }

        private void checkBoxGradients_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGradients.Checked)
            {
                GradientsForm popup = new GradientsForm(this);
                //int itemIndex = comboBoxColor1ThreeColor.SelectedIndex;
                //if (itemIndex > 0)
                //{
                //    string knownColorName = comboBoxColor1ThreeColor.Items[itemIndex].ToString();
                //    KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                //    Form1.backInfo.Color1 = Color.FromKnownColor(k);
                //}
                if(popup.comboBoxColor1TwoColor.Items.Count > 0)
                {
                    KnownColor k = backInfo.Color1.ToKnownColor();
                    int index = popup.comboBoxColor1TwoColor.FindStringExact(k.ToString());
                    popup.comboBoxColor1TwoColor.SelectedIndex = index;
                }

                if (popup.comboBoxColor2TwoColor.Items.Count > 0)
                {
                    KnownColor k = backInfo.Color2.ToKnownColor();
                    int index = popup.comboBoxColor2TwoColor.FindStringExact(k.ToString());
                    popup.comboBoxColor2TwoColor.SelectedIndex = index;
                }
                if (popup.comboBoxColor1ThreeColor.Items.Count > 0)
                {
                    KnownColor k = backInfo.Color1.ToKnownColor();
                    int index = popup.comboBoxColor1ThreeColor.FindStringExact(k.ToString());
                    popup.comboBoxColor1ThreeColor.SelectedIndex = index;
                }

                if (popup.comboBoxColor2ThreeColor.Items.Count > 0)
                {
                    KnownColor k = backInfo.Color2.ToKnownColor();
                    int index = popup.comboBoxColor2ThreeColor.FindStringExact(k.ToString());
                    popup.comboBoxColor2ThreeColor.SelectedIndex = index;
                }
                if (popup.comboBoxColor3ThreeColor.Items.Count > 0)
                {
                    KnownColor k = backInfo.Color3.ToKnownColor();
                    int index = popup.comboBoxColor3ThreeColor.FindStringExact(k.ToString());
                    popup.comboBoxColor3ThreeColor.SelectedIndex = index;
                }

                int ind1 = popup.comboBoxAngleTwoColor.FindStringExact(Convert.ToInt32(backInfo.TwoColorAngle).ToString());
                int ind2 = popup.comboBoxAngleThreeColor.FindStringExact(Convert.ToInt32(backInfo.ThreeColorAngle).ToString());
                popup.comboBoxAngleTwoColor.SelectedIndex = ind1;
                popup.comboBoxAngleThreeColor.SelectedIndex = ind2;




                if(comboBoxGradientColors.Items[comboBoxGradientColors.SelectedIndex].ToString() == "Two Colors")
                {
                    popup.tabControl1.SelectedIndex = 0;
                }
                else if(comboBoxGradientColors.Items[comboBoxGradientColors.SelectedIndex].ToString() == "Three Colors")
                {
                    popup.tabControl1.SelectedIndex = 1;
                }
                //popup.comboBoxColor1TwoColor.SelectedItem = backInfo.Color1;
                Point location = this.PointToScreen(new Point(checkBoxGradients.Right+16, checkBoxGradients.Top + popup.Height - 16));
                popupHelper.ShowPopup(this, popup, location);
            }
        }

        private void checkBoxGradients_Leave(object sender, EventArgs e)
        {
            //checkBoxGradients.Checked = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            checkBoxGradients.Checked = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            checkBoxGradients.Checked = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            checkBoxGradients.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableCurrentControls();
            
        }
        private void EnableCurrentControls()
        {
           
            if (radioButtonUseColor.Checked)
            {
                comboBoxBGColor.Enabled = true;
                labelBGColor.Enabled = true;
                comboBoxGradientColors.Enabled = false;
                checkBoxGradients.Enabled = false;
                listViewBGImages.Enabled = false;
                bgStyle = BackgroundStyle.Color;
            }
           
        }

        private void radioButtonUseGradient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUseGradient.Checked)
            {
                comboBoxBGColor.Enabled = false;
                labelBGColor.Enabled = false;
                comboBoxGradientColors.Enabled = true;
                checkBoxGradients.Enabled = true;
                listViewBGImages.Enabled = false;
                bgStyle = BackgroundStyle.Gradient;
            }
        }

        private void radioButtonUseImage_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButtonUseImage.Checked)
             {
                 comboBoxBGColor.Enabled = false;
                labelBGColor.Enabled = false;
                comboBoxGradientColors.Enabled = false;
                checkBoxGradients.Enabled = false;
                listViewBGImages.Enabled = true;
                 bgStyle = BackgroundStyle.Image;
            }
        }

        private void listViewBGImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBGImages.SelectedIndices.Count > 0)
            {
                int indx = listViewBGImages.SelectedIndices[0];
                if((indx >= 0)&&(indx < images.Count))
                {
                    backInfo.BgImage = images[indx];
                    //this.BackgroundImage = backInfo.BgImage;
                    //this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void comboBoxGradientColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxGradientColors.Items[comboBoxGradientColors.SelectedIndex].ToString())
            {
                case "Two Colors":
                    backInfo.BgGradientTypes = GradientTypes.TwoColor;
                    break;
                case "Three Colors":
                    backInfo.BgGradientTypes = GradientTypes.ThreeColor;
                    break;
            }
        }

        private void checkBoxOutlineText_CheckedChanged(object sender, EventArgs e)
        {
            outlineChecked = checkBoxOutlineText.Checked;
        }

        private void buttonOpenNotepadLyrics_Click(object sender, EventArgs e)
        {
            if(openFileDialogNotePadLyrics.ShowDialog() ==DialogResult.OK )
            {
                if(openFileDialogNotePadLyrics.FileName != string.Empty)
                {
                    System.Diagnostics.Process.Start(openFileDialogNotePadLyrics.FileName);
                }
            }
        }

        private void buttonSavePage_Click(object sender, EventArgs e)
        {
            if(saveFileDialogLyrics.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialogLyrics.FileName != string.Empty)
                {
                    
                }
            }
        }

        private void buttonOpenNotepadLyrics_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open a Text file", buttonOpenNotepadLyrics);
        }

        private void checkBoxGlow_CheckedChanged(object sender, EventArgs e)
        {
            glowChecked = checkBoxGlow.Checked;
            checkBoxOutlineText.Enabled = !checkBoxGlow.Checked;
        }

        private void buttonOpenSaved_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpenSaved.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialogOpenSaved.FileName != string.Empty)
                {
                    string fname = openFileDialogOpenSaved.FileName;
                    if(System.IO.Path.GetExtension(fname) == ".txt")
                    {
                      
                        string lyrics = System.IO.File.ReadAllText(fname);
                        string[] lyricLines = lyrics.Split(new string[] {Environment.NewLine+Environment.NewLine}, StringSplitOptions.None);
                         //MessageBox.Show(lyricLines.Count().ToString());
                        listBoxSongLyrics.Items.Clear();
                        foreach (string lyricLine in lyricLines)
                        {
                            AddText(lyricLine);
                        }
                    }
                }
            }
        }

        private void checkBoxOutlineBehind_CheckedChanged(object sender, EventArgs e)
        {
            textOutlineBehind = checkBoxOutlineBehind.Checked;
           
        }

        private void checkBoxTextGradientForeColor_CheckedChanged(object sender, EventArgs e)
        {
            gradientTextForeColor = checkBoxTextGradientForeColor.Checked;
            
        }

        private void checkBoxDoubleOutline_CheckedChanged(object sender, EventArgs e)
        {
            textDoubleOutlineBehind = checkBoxDoubleOutline.Checked;
        }

        private void checkBoxShadow_CheckedChanged(object sender, EventArgs e)
        {
            textShadow = checkBoxShadow.Checked;
        }

        private void checkBoxShowText_CheckedChanged(object sender, EventArgs e)
        {
            textVisible = checkBoxShowText.Checked;
        }

        private void buttonEditSongStanza_Click(object sender, EventArgs e)
        {

        }
    }
    public enum BackgroundStyle
    {
        Color,
        Gradient,
        Image
    }
    public enum GradientTypes
    {
        TwoColor,
        ThreeColor
    }
    public struct BackgroundInfo
    {
        public Color Color1;
        public Color Color2;
        public Color Color3;
        public Image BgImage;
        public Color FillColor;
        public float TwoColorAngle;
        public float ThreeColorAngle;
        public GradientTypes BgGradientTypes;
    }
}
