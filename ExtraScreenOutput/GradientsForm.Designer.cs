namespace ExtraScreenOutput
{
    partial class GradientsForm
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
            this.tabControl1 = new ExtraScreenOutput.CustomizedTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxAngleTwoColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxColor2TwoColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxColor1TwoColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxAngleThreeColor = new System.Windows.Forms.ComboBox();
            this.comboBoxColor3ThreeColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxColor2ThreeColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxColor1ThreeColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxAngleTwoColor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxColor2TwoColor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxColor1TwoColor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxAngleTwoColor
            // 
            this.comboBoxAngleTwoColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngleTwoColor.FormattingEnabled = true;
            this.comboBoxAngleTwoColor.Items.AddRange(new object[] {
            "0",
            "45",
            "90",
            "180",
            "270"});
            this.comboBoxAngleTwoColor.Location = new System.Drawing.Point(84, 159);
            this.comboBoxAngleTwoColor.Name = "comboBoxAngleTwoColor";
            this.comboBoxAngleTwoColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxAngleTwoColor.TabIndex = 11;
            this.comboBoxAngleTwoColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAngleTwoColor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Angle";
            // 
            // comboBoxColor2TwoColor
            // 
            this.comboBoxColor2TwoColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor2TwoColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor2TwoColor.FormattingEnabled = true;
            this.comboBoxColor2TwoColor.Location = new System.Drawing.Point(84, 60);
            this.comboBoxColor2TwoColor.Name = "comboBoxColor2TwoColor";
            this.comboBoxColor2TwoColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColor2TwoColor.TabIndex = 10;
            this.comboBoxColor2TwoColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawColorComboBoxes);
            this.comboBoxColor2TwoColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor2TwoColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color 2";
            // 
            // comboBoxColor1TwoColor
            // 
            this.comboBoxColor1TwoColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor1TwoColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor1TwoColor.FormattingEnabled = true;
            this.comboBoxColor1TwoColor.Location = new System.Drawing.Point(84, 20);
            this.comboBoxColor1TwoColor.Name = "comboBoxColor1TwoColor";
            this.comboBoxColor1TwoColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColor1TwoColor.TabIndex = 10;
            this.comboBoxColor1TwoColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawColorComboBoxes);
            this.comboBoxColor1TwoColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor1TwoColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxAngleThreeColor);
            this.tabPage2.Controls.Add(this.comboBoxColor3ThreeColor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxColor2ThreeColor);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBoxColor1ThreeColor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(301, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxAngleThreeColor
            // 
            this.comboBoxAngleThreeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngleThreeColor.FormattingEnabled = true;
            this.comboBoxAngleThreeColor.Items.AddRange(new object[] {
            "0",
            "45",
            "90",
            "180",
            "270"});
            this.comboBoxAngleThreeColor.Location = new System.Drawing.Point(102, 168);
            this.comboBoxAngleThreeColor.Name = "comboBoxAngleThreeColor";
            this.comboBoxAngleThreeColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxAngleThreeColor.TabIndex = 19;
            this.comboBoxAngleThreeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAngleThreeColor_SelectedIndexChanged);
            // 
            // comboBoxColor3ThreeColor
            // 
            this.comboBoxColor3ThreeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor3ThreeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor3ThreeColor.FormattingEnabled = true;
            this.comboBoxColor3ThreeColor.Location = new System.Drawing.Point(102, 107);
            this.comboBoxColor3ThreeColor.Name = "comboBoxColor3ThreeColor";
            this.comboBoxColor3ThreeColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColor3ThreeColor.TabIndex = 17;
            this.comboBoxColor3ThreeColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawColorComboBoxes);
            this.comboBoxColor3ThreeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor3ThreeColor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Color 3";
            // 
            // comboBoxColor2ThreeColor
            // 
            this.comboBoxColor2ThreeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor2ThreeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor2ThreeColor.FormattingEnabled = true;
            this.comboBoxColor2ThreeColor.Location = new System.Drawing.Point(102, 69);
            this.comboBoxColor2ThreeColor.Name = "comboBoxColor2ThreeColor";
            this.comboBoxColor2ThreeColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColor2ThreeColor.TabIndex = 18;
            this.comboBoxColor2ThreeColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawColorComboBoxes);
            this.comboBoxColor2ThreeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor2ThreeColor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color 2";
            // 
            // comboBoxColor1ThreeColor
            // 
            this.comboBoxColor1ThreeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor1ThreeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor1ThreeColor.FormattingEnabled = true;
            this.comboBoxColor1ThreeColor.Location = new System.Drawing.Point(102, 29);
            this.comboBoxColor1ThreeColor.Name = "comboBoxColor1ThreeColor";
            this.comboBoxColor1ThreeColor.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColor1ThreeColor.TabIndex = 16;
            this.comboBoxColor1ThreeColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawColorComboBoxes);
            this.comboBoxColor1ThreeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor1ThreeColor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Color 1";
            // 
            // GradientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 293);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GradientsForm";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public CustomizedTab tabControl1;
        public System.Windows.Forms.ComboBox comboBoxColor1TwoColor;
        public System.Windows.Forms.ComboBox comboBoxColor2TwoColor;
        public System.Windows.Forms.ComboBox comboBoxAngleTwoColor;
        public System.Windows.Forms.ComboBox comboBoxAngleThreeColor;
        public System.Windows.Forms.ComboBox comboBoxColor3ThreeColor;
        public System.Windows.Forms.ComboBox comboBoxColor2ThreeColor;
        public System.Windows.Forms.ComboBox comboBoxColor1ThreeColor;
    }
}