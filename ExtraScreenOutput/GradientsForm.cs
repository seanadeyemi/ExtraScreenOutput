using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtraScreenOutput
{
    public partial class GradientsForm : Form
    {
        private Form1 mainForm = null;
        public GradientsForm(Form1 mForm)
        {
            InitializeComponent();
            comboBoxColor1TwoColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxColor1TwoColor.SelectedIndex = 0;
            comboBoxColor2TwoColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxColor2TwoColor.SelectedIndex = 0;

            comboBoxColor1ThreeColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxColor1ThreeColor.SelectedIndex = 0;
            comboBoxColor2ThreeColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxColor2ThreeColor.SelectedIndex = 0;
            comboBoxColor3ThreeColor.Items.AddRange(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            comboBoxColor3ThreeColor.SelectedIndex = 0;

            //comboBoxAngleTwoColor.SelectedIndex = 0;
            //comboBoxAngleThreeColor.SelectedIndex = 0;

        }
        public CustomizedTab GetTabControl()
        {
            return tabControl1;
        }
        private void DrawColorComboBoxes(object sender, DrawItemEventArgs e)
        {
             int itemIndex = e.Index;

            e.DrawBackground();

            if (itemIndex >= 0)
            {
                string knownColorName = ((ComboBox) sender).Items[itemIndex].ToString();

                Rectangle textRectangle = e.Bounds;
                Rectangle colorRectangle = e.Bounds;
                colorRectangle.X += 2;
                colorRectangle.Y += 2;
                colorRectangle.Width = 16;
                colorRectangle.Height -= 4;

                KnownColor k = (KnownColor) Enum.Parse(typeof (System.Drawing.KnownColor), knownColorName);
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
        }

        private void comboBoxColor1TwoColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxColor1TwoColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxColor1TwoColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor) Enum.Parse(typeof (System.Drawing.KnownColor), knownColorName);
                mainForm.backInfo.Color1 = Color.FromKnownColor(k);
            }
        }

        private void comboBoxColor2TwoColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxColor2TwoColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxColor2TwoColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor) Enum.Parse(typeof (System.Drawing.KnownColor), knownColorName);
                mainForm.backInfo.Color2 = Color.FromKnownColor(k);
            }
        }

        private void comboBoxAngleTwoColor_SelectedIndexChanged(object sender, EventArgs e)
        {
       mainForm.backInfo.TwoColorAngle = Convert.ToSingle(comboBoxAngleTwoColor.Items[comboBoxAngleTwoColor.SelectedIndex]);

        }

        private void comboBoxAngleThreeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
  mainForm.backInfo.ThreeColorAngle = Convert.ToSingle(comboBoxAngleThreeColor.Items[comboBoxAngleThreeColor.SelectedIndex]);
        
       
        }

        private void comboBoxColor1ThreeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxColor1ThreeColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxColor1ThreeColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                mainForm.backInfo.Color1 = Color.FromKnownColor(k);
            }
        }

        private void comboBoxColor2ThreeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxColor2ThreeColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxColor2ThreeColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                mainForm.backInfo.Color2 = Color.FromKnownColor(k);
            }
        }

        private void comboBoxColor3ThreeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = comboBoxColor3ThreeColor.SelectedIndex;
            if (itemIndex > 0)
            {
                string knownColorName = comboBoxColor3ThreeColor.Items[itemIndex].ToString();
                KnownColor k = (KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), knownColorName);
                mainForm.backInfo.Color3 = Color.FromKnownColor(k);
            }
        }

    }
    public class CustomizedTab : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }
}
