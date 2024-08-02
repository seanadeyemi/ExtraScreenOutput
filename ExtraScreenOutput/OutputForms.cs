using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ExtraScreenOutput
{
	public partial class OutputForms : Form
	{
		Font fnt = new Font("Tahoma", 26f, FontStyle.Bold);
		public Bitmap screenStuff = null;
		MyLabel myLabel = new MyLabel();
		Bitmap _bmpText;
		private const int BlurAmount = 6;
		private Form1 mainForm = null;

		public OutputForms(Form1 mForm)
		{
			InitializeComponent();
			mainForm = mForm;

			//this.Controls.Add(myLabel);
			//myLabel.Size = webCameraControl1.Size;
			//myLabel.Location = webCameraControl1.Location;
			//myLabel.Top += 20;

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Invalidate();
		}

		private void OutputForms_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
				Graphics gr = Graphics.FromImage(bmp);

				Graphics g = e.Graphics;
				switch (mainForm.bgStyle)
				{
					case BackgroundStyle.Color:
						g.FillRectangle(new SolidBrush(mainForm.bgColor), ClientRectangle);
						gr.FillRectangle(new SolidBrush(mainForm.bgColor), ClientRectangle);
						break;
					case BackgroundStyle.Gradient:
						switch (mainForm.backInfo.BgGradientTypes)
						{
							case GradientTypes.TwoColor:
								LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, mainForm.backInfo.Color1, mainForm.backInfo.Color2, mainForm.backInfo.TwoColorAngle);
								g.FillRectangle(lgb, ClientRectangle);
								gr.FillRectangle(lgb, ClientRectangle);
								lgb.Dispose();
								break;
							case GradientTypes.ThreeColor:
								LinearGradientBrush lbr = new LinearGradientBrush(ClientRectangle, mainForm.backInfo.Color1, mainForm.backInfo.Color2, mainForm.backInfo.ThreeColorAngle);

								ColorBlend bl = new ColorBlend();

								Color[] colors = { mainForm.backInfo.Color1, mainForm.backInfo.Color2, mainForm.backInfo.Color3 };

								bl.Colors = colors;

								bl.Positions = new float[] { 0, 0.5f, 1.0f }; //distance

								lbr.InterpolationColors = bl;

								g.FillRectangle(lbr, this.ClientRectangle);
								gr.FillRectangle(lbr, this.ClientRectangle);

								lbr.Dispose();

								break;
							default:
								throw new ArgumentOutOfRangeException();
						}
						break;
					case BackgroundStyle.Image:
						if (mainForm.backInfo.BgImage != null)
						{
							g.DrawImage(mainForm.backInfo.BgImage, ClientRectangle);
							gr.DrawImage(mainForm.backInfo.BgImage, ClientRectangle);
						}
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}


				RectangleF rtf = new RectangleF(0, 0, ClientRectangle.Width, ClientRectangle.Height);
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Center;

				if (mainForm.textVisible)
				{
					if (mainForm.fontfam != null)
					{
						fnt = new Font(mainForm.fontfam, 45f, FontStyle.Bold);
					}
					if (mainForm.glowChecked)
					{
						//DrawGlow(g, rtf);
						//DrawGlow(gr, rtf);
						DrawGlow2(g, rtf);
						DrawGlow2(gr, rtf);
					}
					else
					{
						if (mainForm.textShadow)
						{
							DrawShadow(g, rtf);
							DrawShadow(gr, rtf);
						}

						if (mainForm.outlineChecked)
						{

							DrawOutlineText(g, rtf, sf);
							DrawOutlineText(gr, rtf, sf);

						}
						else
						{
							g.SmoothingMode = SmoothingMode.AntiAlias;
							gr.SmoothingMode = SmoothingMode.AntiAlias;
							g.DrawString(mainForm.TextOutput, fnt, new SolidBrush(mainForm.foreColor), rtf, sf);
							gr.DrawString(mainForm.TextOutput, fnt, new SolidBrush(mainForm.foreColor), rtf, sf);
						}


					}


				}

				screenStuff = (Bitmap)bmp.Clone();
				bmp.Dispose();
				sf.Dispose();
			}
			catch (Exception ex)
			{



			}



		}
		void DrawShadow(Graphics grx, RectangleF rtf)
		{
			grx.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath pth = new GraphicsPath();


			StringFormat stf = new StringFormat();
			stf.Alignment = StringAlignment.Center;
			stf.LineAlignment = StringAlignment.Center;
			pth.AddString(mainForm.TextOutput, mainForm.fontfam, (int)FontStyle.Bold, (45 * 1.26f), rtf, stf);
			Font fnt = new Font(mainForm.fontfam, 45f);




			using (Matrix mx = new Matrix())
			{
				mx.Translate(7, 7);
				pth.Transform(mx);
			}
			//int xx = Convert.ToInt32((fnt.Height/30) + 1);
			//for (int i = 1; i < xx; ++i)//1 and 8//++i
			//{
			//    Pen pen = new Pen(Color.FromArgb(Convert.ToInt32(200 - ((200 / xx) * i)), 90, 90, 90), i);
			//    pen.LineJoin = LineJoin.Round;
			//    grx.DrawPath(pen, pth);
			//    pen.Dispose();
			//}
			SolidBrush br = new SolidBrush(Color.FromArgb(80, 0, 0, 0));
			grx.FillPath(br, pth);
			br.Dispose();
			fnt.Dispose();
		}


		void DrawGlow2(Graphics grx, RectangleF rtf)
		{
			//create a path
			// grx.TextRenderingHint = TextRenderingHint.AntiAlias;

			grx.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath pth = new GraphicsPath();

			//Select the pen             
			StringFormat stf = new StringFormat();
			stf.Alignment = StringAlignment.Center;
			stf.LineAlignment = StringAlignment.Center;


			pth.AddString(mainForm.TextOutput, mainForm.fontfam, (int)FontStyle.Bold, (45 * 1.26f), rtf, stf);

			//Fill it

			for (int i = 2; i < 16; i += 2)//1 and 8//++i
			{
				Pen pen = new Pen(Color.FromArgb(32, 0, 128, 192), i);
				pen.LineJoin = LineJoin.Round;
				grx.DrawPath(pen, pth);
				pen.Dispose();
			}

			SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
			grx.FillPath(brush, pth);

			pth.Dispose();
			brush.Dispose();
		}
		void DrawGlow(Graphics g, RectangleF rtf)
		{

			int _Glow = 25;
			int _Feather = 100;

			Rectangle rt = ClientRectangle;//Rectangle.Truncate(rtf);//ClientRectangle;
										   //rt.Inflate(-15, -15);
			Color gColor = Color.Black;


			GraphicsPath path = new GraphicsPath();
			path.AddRectangle(rt);

			if (mainForm.fontfam != null)
			{
				fnt = new Font(mainForm.fontfam, 45f, FontStyle.Bold);

				for (int i = 1; i <= _Glow; i += 2)
				{
					int aGlow = Convert.ToInt32(_Feather - ((_Feather / _Glow) * i));
					using (Pen pen = new Pen(Color.FromArgb(aGlow, EnabledColor(gColor)), i))
					{
						pen.LineJoin = LineJoin.Round;
						g.DrawPath(pen, path);
					}
				}


				_bmpText = (Bitmap)ImageFromText(mainForm.TextOutput, fnt, Color.LawnGreen, Color.White);//Color.White
				g.DrawImageUnscaled(_bmpText, ((int)path.GetBounds().Width / 2) - (_bmpText.Width / 2), 50);

			}
		}
		private Color EnabledColor(Color ColorIn)
		{
			if (Enabled)
			{
				return ColorIn;
			}
			else
			{
				int gray = Convert.ToInt32(ColorIn.R * 0.3 + ColorIn.G * 0.59 + ColorIn.B * 0.11);
				return Color.FromArgb(ColorIn.A, gray, gray, gray);
			}
		}
		public static Image ImageFromText(string strText, Font fnt, Color clrFore, Color clrBack)
		{
			Bitmap bmpOut = null; // bitmap we are creating and will return from this function.

			using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
			{
				SizeF sz = g.MeasureString(strText, fnt);
				using (Bitmap bmp = new Bitmap((int)sz.Width, (int)sz.Height))
				using (Graphics gBmp = Graphics.FromImage(bmp))
				using (SolidBrush brBack = new SolidBrush(Color.FromArgb(16, clrBack.R, clrBack.G, clrBack.B)))
				using (SolidBrush brFore = new SolidBrush(clrFore))
				{
					gBmp.SmoothingMode = SmoothingMode.HighQuality;
					gBmp.InterpolationMode = InterpolationMode.HighQualityBilinear;
					gBmp.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

					gBmp.DrawString(strText, fnt, brBack, 0, 0);

					// make bitmap we will return.
					bmpOut = new Bitmap(bmp.Width + BlurAmount, bmp.Height + BlurAmount);
					using (Graphics gBmpOut = Graphics.FromImage(bmpOut))
					{
						gBmpOut.SmoothingMode = SmoothingMode.HighQuality;
						gBmpOut.InterpolationMode = InterpolationMode.HighQualityBilinear;
						gBmpOut.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

						// smear image of background of text about to make blurred background "halo"
						for (int x = 0; x <= BlurAmount; x++)
							for (int y = 0; y <= BlurAmount; y++)
								gBmpOut.DrawImageUnscaled(bmp, x, y);

						// draw actual text
						gBmpOut.DrawString(strText, fnt, brFore, BlurAmount / 2, BlurAmount / 2);
					}
				}
			}

			return bmpOut;
		}

		void DrawOutlineText(Graphics grx, RectangleF rtf, StringFormat sf)
		{
			//create a path
			// grx.TextRenderingHint = TextRenderingHint.AntiAlias;

			grx.SmoothingMode = SmoothingMode.AntiAlias;

			GraphicsPath pth = new GraphicsPath();


			//Select the pen             


			StringFormat stf = new StringFormat();
			stf.Alignment = StringAlignment.Center;
			stf.LineAlignment = StringAlignment.Center;


			pth.AddString(mainForm.TextOutput, mainForm.fontfam, (int)FontStyle.Bold, (45 * 1.26f), rtf, stf);
			//StringFormat.GenericTypographic
			//Fill it


			SizeF sz = grx.MeasureString("S", new Font(mainForm.fontfam, 38));

			//outline it
			if (mainForm.textOutlineBehind)
			{
				if (mainForm.textDoubleOutlineBehind)
				{
					Pen pb = new Pen(Color.Blue, 12.0f);
					pb.LineJoin = LineJoin.Round;
					grx.DrawPath(pb, pth);
					pb.Dispose();
				}

				Pen p = new Pen(Color.Black, 6.0f);
				p.LineJoin = LineJoin.Round;
				grx.DrawPath(p, pth);
				p.Dispose();

			}


			if (mainForm.gradientTextForeColor)
			{
				LinearGradientBrush lgb = new LinearGradientBrush(new RectangleF(pth.GetBounds().X - 1, pth.GetBounds().Y - 1, pth.GetBounds().Width + 2, sz.Height/*pth.GetBounds().Height+2*/), Color.White, Color.SlateGray, LinearGradientMode.Vertical);
				grx.FillPath(lgb, pth);
				lgb.Dispose();
			}
			else
			{
				SolidBrush lgb = new SolidBrush(mainForm.foreColor);//new RectangleF(pth.GetBounds().X - 1, pth.GetBounds().Y - 1, pth.GetBounds().Width + 2, sz.Height), );
				grx.FillPath(lgb, pth);
				lgb.Dispose();
			}

			if (!mainForm.textOutlineBehind)
			{
				Pen p = new Pen(Color.Black, 1.0f);
				grx.DrawPath(p, pth);
				p.Dispose();
			}
			//tidy up.

			pth.Dispose();
			stf.Dispose();

		}


		private void MakeTextPath(ref GraphicsPath path, ref Graphics g)
		{

			//   if (_AutoFit)
			{
				try
				{
					//Determine the outer margin for the text so there
					//is enough room for the glow and shadow
					//    int pad = 2;
					//    if (GlowState)
					{
						//       pad += Convert.ToInt32(_Glow - (_Glow / 2) + (int)(_Glow / 30) * 3);
					}
					//  if (Border != AnchorStyles.None)
					{
						//      pad += Convert.ToInt32(BorderWidth + 1);
					}

					//Add Padding
					//  Padding TextMargin = Windows.Forms.Padding.Add(Padding, new Padding(pad));

					// if (ShadowState)
					{
						//   TextMargin.Right += Convert.ToInt32(_ShadowOffset.X);
						//   TextMargin.Bottom += Convert.ToInt32(_ShadowOffset.Y + ((_ShadowOffset.Y) / 3));
					}

					//Get a rectangle for the area to paint the text
					//  Rectangle target = new Rectangle(TextMargin.Left, TextMargin.Top, Math.Max(5, ClientSize.Width - TextMargin.Horizontal), Math.Max(5, ClientSize.Height - TextMargin.Vertical));

					//Get the points for the corners of the area
					PointF[] target_pts = {
					//new PointF(target.Left, target.Top),
					//new PointF(target.Right, target.Top),
					//new PointF(target.Left, target.Bottom)
				};

					//Make a GraphicsPath of the Text String 
					//close to the size it needs to be
					//path.AddString(Text, Font.FontFamily, Font.Style, target.Height, new PointF(0, 0), sf);

					//Get a rectangle for the path of the text
					RectangleF text_rectf = path.GetBounds();

					//Transform the Graphics Object with the Matrix
					//to fit the path rectangle inside the target rectangle
					g.Transform = new Matrix(text_rectf, target_pts);

				}
				catch (Exception ex)
				{

				}

			}
			//else
			{
				//create a GraphicsPath of the text
				//Because the GraphicsPath does not match exactly with
				//Drawing a String normally, multiply the font Size by
				//1.26 to get a pretty close representation of the size.
				// path.AddString(Text, Font.FontFamily, Font.Style, Convert.ToInt32(Font.Size * 1.26), new Rectangle(ClientRectangle.X + Padding.Left, ClientRectangle.Y + Padding.Top, ClientRectangle.Width - Padding.Horizontal, ClientRectangle.Height - Padding.Vertical), sf);

			}

		}

		private void OutputForms_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
	public class MyLabel : Label
	{
		public MyLabel()
		{
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
			DoubleBuffered = true;
			this.Paint += new PaintEventHandler(MyLabel_Paint);
		}

		void MyLabel_Paint(object sender, PaintEventArgs e)
		{
			//throw new NotImplementedException();
			Graphics g = e.Graphics;
			g.DrawString("Helloooooooooooooooooo", SystemFonts.MenuFont, Brushes.Blue, ClientRectangle);
		}


	}

}
