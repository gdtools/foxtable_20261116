using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Command;
using C1.Win.C1Gauge;
using C1.Win.C1Input;
using Foxtable.My;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000400 RID: 1024
	[DesignerGenerated]
	internal partial class o\u3002\u3002\u3000\u3000\u3002 : Form, O0_0_0_0_
	{
		// Token: 0x060041D9 RID: 16857 RVA: 0x001E021F File Offset: 0x001DE41F
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.OO_O0_oO0__._. != null)
			{
				this.OO_O0_oO0__._..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x001E0240 File Offset: 0x001DE440
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			int a_ = 7;
			base.SuspendLayout();
			this.AllowDrop = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(503, 407);
			base.KeyPreview = true;
			base.Location = new Point(20, 20);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = O00OOOo_O0_O.b("藩ꗫ샭뿯\udcf1쓳\ud8f5ꟷ퓹", a_);
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = O00OOOo_O0_O.b("經ྸ", a_);
			base.ResumeLayout(false);
		}

		// Token: 0x060041DB RID: 16859
		[DllImport("gdi32.dll")]
		private static extern int GetPixel(IntPtr A_0, int A_1, int A_2);

		// Token: 0x060041DC RID: 16860
		[DllImport("gdi32.dll")]
		private static extern int SetPixel(IntPtr A_0, int A_1, int A_2, int A_3);

		// Token: 0x060041DD RID: 16861 RVA: 0x001E02F8 File Offset: 0x001DE4F8
		internal void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_0 != this || Control.ModifierKeys == System.Windows.Forms.Keys.Control)
				{
					goto IL_3E;
				}
				IL_19:
				num2 = 3;
				oOO0oo_o0.o0.Oo__.(base.Controls);
				IL_26:
				num2 = 4;
				((o\u3000\u3002)base.MdiParent).O0.0O00_O.().SelectedIndex = 0;
				IL_3E:
				num2 = 5;
				if (A_1.Button != MouseButtons.Left)
				{
					goto IL_8F;
				}
				IL_4D:
				num2 = 6;
				this.O0o._0. = true;
				IL_56:
				num2 = 7;
				this.o_0O.OO0_0_. = new Rectangle(A_1.X, A_1.Y, 0, 0);
				IL_71:
				num2 = 8;
				this.o_0O.OO0_0_. = new Point(A_1.X, A_1.Y);
				goto IL_11B;
				IL_8F:
				num2 = 10;
				this.O0o._0. = false;
				IL_99:
				num2 = 11;
				if (this.o_0O.OO0_0_..IsEmpty)
				{
					goto IL_11B;
				}
				IL_A9:
				num2 = 12;
				Graphics graphics = ((Control)A_0).CreateGraphics();
				IL_B8:
				num2 = 13;
				Pen pen = new Pen(((Control)A_0).BackColor);
				IL_CD:
				num2 = 14;
				if (((Control)A_0).BackgroundImage != null)
				{
					goto IL_F0;
				}
				IL_DD:
				num2 = 15;
				graphics.DrawRectangle(pen, this.o_0O.OO0_0_.);
				goto IL_FA;
				IL_F0:
				num2 = 17;
				this.oooo_._O.(graphics);
				IL_FA:
				num2 = 18;
				pen.Dispose();
				IL_104:
				num2 = 19;
				graphics.Dispose();
				IL_10D:
				num2 = 20;
				this.o_0O.OO0_0_. = Rectangle.Empty;
				IL_11B:
				goto IL_1C1;
				IL_120:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_182:
				goto IL_1B6;
				IL_184:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_194:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_184;
			}
			IL_1B6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1C1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x001E04EC File Offset: 0x001DE6EC
		private void <<EMPTY_NAME>>(Graphics A_0)
		{
			IntPtr hdc = A_0.GetHdc();
			try
			{
				foreach (o\u3002\u3002\u3000\u3000\u3002.o_O o_O in this.o_0O.OO0_0_.)
				{
					o\u3002\u3002\u3000\u3000\u3002.SetPixel(hdc, o_O.O.00OO00_oo., o_O.O0oOOo_o_O.O_O., o_O.o.oo_OOO.);
				}
			}
			finally
			{
				List<o\u3002\u3002\u3000\u3000\u3002.o_O>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.o_0O.OO0_0_..Clear();
			A_0.ReleaseHdc();
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001E056C File Offset: 0x001DE76C
		internal void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Graphics graphics = ((Control)A_0).CreateGraphics();
				IL_15:
				num2 = 3;
				if (!(A_1.Button == MouseButtons.Left & this.O0o._0.))
				{
					goto IL_2F1;
				}
				IL_30:
				num2 = 4;
				if (this.o_0O.OO0_0_..IsEmpty)
				{
					goto IL_87;
				}
				IL_3F:
				num2 = 5;
				if (((Control)A_0).BackgroundImage != null)
				{
					goto IL_7D;
				}
				IL_4E:
				num2 = 6;
				Pen pen = new Pen(((Control)A_0).BackColor);
				IL_62:
				num2 = 7;
				graphics.DrawRectangle(pen, this.o_0O.OO0_0_.);
				IL_72:
				num2 = 8;
				pen.Dispose();
				goto IL_87;
				IL_7D:
				num2 = 10;
				this.oooo_._O.(graphics);
				IL_87:
				num2 = 11;
				Rectangle rect = new Rectangle(Math.Min(this.o_0O.OO0_0_..X, A_1.X), Math.Min(this.o_0O.OO0_0_..Y, A_1.Y), Math.Abs(A_1.X - this.o_0O.OO0_0_..X), Math.Abs(A_1.Y - this.o_0O.OO0_0_..Y));
				IL_EB:
				num2 = 12;
				if (!(A_0 is oO_0))
				{
					goto IL_104;
				}
				IL_F6:
				num2 = 13;
				((oO_0)A_0).Refresh();
				IL_104:
				num2 = 14;
				if (!(A_0 is PictureBox) || ((PictureBox)A_0).Image == null)
				{
					goto IL_12A;
				}
				IL_11C:
				num2 = 15;
				((PictureBox)A_0).Refresh();
				IL_12A:
				num2 = 16;
				if (!(A_0 is C1Gauge))
				{
					goto IL_143;
				}
				IL_135:
				num2 = 17;
				((C1Gauge)A_0).Refresh();
				IL_143:
				num2 = 18;
				if (((Control)A_0).BackgroundImage == null)
				{
					goto IL_2A4;
				}
				IL_156:
				num2 = 19;
				this.o_0O.OO0_0_..Clear();
				IL_164:
				num2 = 20;
				IntPtr hdc = graphics.GetHdc();
				IL_16F:
				num2 = 21;
				int x = rect.X;
				int num3 = rect.X + rect.Width;
				for (int i = x; i <= num3; i++)
				{
					IL_18E:
					num2 = 22;
					this.o_0O.OO0_0_..Add(new o\u3002\u3002\u3000\u3000\u3002.o_O(i, rect.Y, o\u3002\u3002\u3000\u3000\u3002.GetPixel(hdc, i, rect.Y)));
					IL_1BA:
					num2 = 23;
					this.o_0O.OO0_0_..Add(new o\u3002\u3002\u3000\u3000\u3002.o_O(i, rect.Y + rect.Height, o\u3002\u3002\u3000\u3000\u3002.GetPixel(hdc, i, rect.Y + rect.Height)));
					IL_1F6:
					num2 = 24;
				}
				IL_205:
				num2 = 25;
				int y = rect.Y;
				int num4 = rect.Y + rect.Height;
				for (int j = y; j <= num4; j++)
				{
					IL_224:
					num2 = 26;
					this.o_0O.OO0_0_..Add(new o\u3002\u3002\u3000\u3000\u3002.o_O(rect.X, j, o\u3002\u3002\u3000\u3000\u3002.GetPixel(hdc, rect.X, j)));
					IL_250:
					num2 = 27;
					this.o_0O.OO0_0_..Add(new o\u3002\u3002\u3000\u3000\u3002.o_O(rect.X + rect.Width, j, o\u3002\u3002\u3000\u3000\u3002.GetPixel(hdc, rect.X + rect.Width, j)));
					IL_28C:
					num2 = 28;
				}
				IL_29B:
				num2 = 29;
				graphics.ReleaseHdc();
				IL_2A4:
				num2 = 30;
				pen = new Pen(((Control)A_0).ForeColor);
				IL_2B9:
				num2 = 31;
				pen.DashStyle = DashStyle.Dot;
				IL_2C4:
				num2 = 32;
				graphics.DrawRectangle(pen, rect);
				IL_2D1:
				num2 = 33;
				this.o_0O.OO0_0_. = rect;
				IL_2DC:
				num2 = 34;
				pen.Dispose();
				IL_2E6:
				num2 = 35;
				graphics.Dispose();
				goto IL_36E;
				IL_2F1:
				num2 = 37;
				this.O0o._0. = false;
				IL_2FB:
				num2 = 38;
				if (this.o_0O.OO0_0_..IsEmpty)
				{
					goto IL_36E;
				}
				IL_30B:
				num2 = 39;
				pen = new Pen(((Control)A_0).BackColor);
				IL_320:
				num2 = 40;
				if (((Control)A_0).BackgroundImage != null)
				{
					goto IL_343;
				}
				IL_330:
				num2 = 41;
				graphics.DrawRectangle(pen, this.o_0O.OO0_0_.);
				goto IL_34D;
				IL_343:
				num2 = 43;
				this.oooo_._O.(graphics);
				IL_34D:
				num2 = 44;
				this.o_0O.OO0_0_. = Rectangle.Empty;
				IL_35B:
				num2 = 45;
				pen.Dispose();
				IL_365:
				num2 = 46;
				graphics.Dispose();
				IL_36E:
				goto IL_47C;
				IL_373:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_43D:
				goto IL_471;
				IL_43F:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_44F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_43F;
			}
			IL_471:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_47C:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x001E0A1C File Offset: 0x001DEC1C
		internal void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.O0o._0. = false;
				IL_10:
				num2 = 3;
				if (this.o_0O.OO0_0_..IsEmpty)
				{
					goto IL_1B5;
				}
				IL_22:
				num2 = 4;
				this.ooOOOO.0o. = new Rectangle(Math.Min(this.o_0O.OO0_0_..X, A_1.X), Math.Min(this.o_0O.OO0_0_..Y, A_1.Y), Math.Abs(A_1.X - this.o_0O.OO0_0_..X), Math.Abs(A_1.Y - this.o_0O.OO0_0_..Y));
				IL_89:
				num2 = 5;
				Graphics graphics = ((Control)A_0).CreateGraphics();
				IL_97:
				num2 = 6;
				Pen pen = new Pen(((Control)A_0).BackColor);
				IL_AB:
				num2 = 7;
				if (((Control)A_0).BackgroundImage != null)
				{
					goto IL_CC;
				}
				IL_BA:
				num2 = 8;
				graphics.DrawRectangle(pen, this.o_0O.OO0_0_.);
				goto IL_D6;
				IL_CC:
				num2 = 10;
				this.oooo_._O.(graphics);
				IL_D6:
				num2 = 11;
				pen.Dispose();
				IL_E0:
				num2 = 12;
				graphics.Dispose();
				IL_E9:
				num2 = 13;
				if (this.ooOOOO.0o..Width < 2 && this.ooOOOO.0o..Height < 2)
				{
					goto IL_141;
				}
				IL_108:
				num2 = 14;
				if (!(A_0 != this & Control.ModifierKeys != System.Windows.Forms.Keys.Control))
				{
					goto IL_132;
				}
				IL_124:
				num2 = 15;
				oOO0oo_o0.o0.Oo__.(base.Controls);
				IL_132:
				num2 = 16;
				this.OO_O0_oO0__._.(RuntimeHelpers.GetObjectValue(A_0));
				IL_141:
				num2 = 17;
				this.o_0O.OO0_0_. = Rectangle.Empty;
				IL_14F:
				num2 = 18;
				this.o_0O.OO0_0_..Clear();
				IL_15D:
				num2 = 19;
				if (!(A_0 is oO_0))
				{
					goto IL_176;
				}
				IL_168:
				num2 = 20;
				((oO_0)A_0).Refresh();
				IL_176:
				num2 = 21;
				if (!(A_0 is PictureBox) || ((PictureBox)A_0).Image == null)
				{
					goto IL_19C;
				}
				IL_18E:
				num2 = 22;
				((PictureBox)A_0).Refresh();
				IL_19C:
				num2 = 23;
				if (!(A_0 is C1Gauge))
				{
					goto IL_1B5;
				}
				IL_1A7:
				num2 = 24;
				((C1Gauge)A_0).Refresh();
				IL_1B5:
				goto IL_26B;
				IL_1BA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_22C:
				goto IL_260;
				IL_22E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_23E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_22E;
			}
			IL_260:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_26B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x001E0CB8 File Offset: 0x001DEEB8
		private void <<EMPTY_NAME>>(object A_0)
		{
			try
			{
				foreach (object obj in ((Control)A_0).Controls)
				{
					Control control = (Control)obj;
					if (control is ControlHolder && control.Bounds.IntersectsWith(this.ooOOOO.0o.))
					{
						((ControlHolder)control).Selected = true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x001E0D3C File Offset: 0x001DEF3C
		internal bool <<EMPTY_NAME>>(Control.ControlCollection A_0, string A_1)
		{
			int num;
			bool result;
			int num4;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator enumerator = A_0.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_24:
					num2 = 3;
					if (control is ControlHolder)
					{
						IL_32:
						num2 = 4;
						if (Operators.CompareString(control.Name, A_1, true) == 0)
						{
							IL_44:
							num2 = 5;
							result = true;
						}
						else
						{
							IL_4D:
							num2 = 7;
							if (((ControlHolder)control).ControlType == ControlTypeEnum.GroupBox | ((ControlHolder)control).ControlType == ControlTypeEnum.Panel | ((ControlHolder)control).ControlType == ControlTypeEnum.Gauges | ((ControlHolder)control).ControlType == ControlTypeEnum.Map)
							{
								IL_94:
								num2 = 8;
								if (!this.OO__oo0.0O___.(((ControlHolder)control).ChildControl.Controls, A_1))
								{
									goto IL_280;
								}
								IL_B3:
								num2 = 9;
								result = true;
							}
							else
							{
								IL_BD:
								num2 = 11;
								if (((ControlHolder)control).ControlType == ControlTypeEnum.PictureBox)
								{
									IL_D0:
									num2 = 12;
									if (!this.OO__oo0.0O___.(((CustomPictureBox)((ControlHolder)control).ChildControl).PictureBox1.Controls, A_1))
									{
										goto IL_280;
									}
									IL_FA:
									num2 = 13;
									result = true;
								}
								else
								{
									IL_104:
									num2 = 15;
									if (((ControlHolder)control).ControlType == ControlTypeEnum.TabControl)
									{
										IL_117:
										num2 = 16;
										IEnumerator enumerator2 = ((C1DockingTab)((ControlHolder)control).ChildControl).TabPages.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											object obj2 = enumerator2.Current;
											O_O_ o_O_ = (O_O_)obj2;
											IL_147:
											num2 = 17;
											if (this.OO__oo0.0O___.(o_O_.Controls, A_1))
											{
												IL_15A:
												num2 = 18;
												result = true;
												goto IL_2AC;
											}
											IL_164:
											num2 = 19;
										}
										IL_170:
										num2 = 20;
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
											goto IL_280;
										}
										goto IL_280;
									}
									else
									{
										IL_190:
										num2 = 22;
										if (((ControlHolder)control).ControlType == ControlTypeEnum.NavBar)
										{
											IL_1A3:
											num2 = 23;
											IEnumerator enumerator3 = ((C1NavBar)((ControlHolder)control).ChildControl).Panels.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												object obj3 = enumerator3.Current;
												oO_0 oO_ = (oO_0)obj3;
												IL_1D3:
												num2 = 24;
												if (this.OO__oo0.0O___.(oO_.Controls, A_1))
												{
													IL_1E6:
													num2 = 25;
													result = true;
													goto IL_2AC;
												}
												IL_1F0:
												num2 = 26;
											}
											IL_1FC:
											num2 = 27;
											if (enumerator3 is IDisposable)
											{
												(enumerator3 as IDisposable).Dispose();
												goto IL_280;
											}
											goto IL_280;
										}
										else
										{
											IL_216:
											num2 = 29;
											if (((ControlHolder)control).ControlType != ControlTypeEnum.SplitContainer)
											{
												goto IL_280;
											}
											IL_229:
											num2 = 30;
											o0000O o0000O = (o0000O)((ControlHolder)control).ChildControl;
											IL_23F:
											num2 = 31;
											if (this.OO__oo0.0O___.(o0000O.oo0oO_O.oooO0O.().Controls, A_1))
											{
												IL_257:
												num2 = 32;
												result = true;
											}
											else
											{
												IL_25E:
												num2 = 33;
												if (!this.OO__oo0.0O___.(o0000O.o.Oo0oo000O.().Controls, A_1))
												{
													IL_27D:
													o0000O = null;
													goto IL_280;
												}
												IL_276:
												num2 = 34;
												result = true;
											}
										}
									}
								}
							}
						}
						IL_2AC:
						goto IL_39A;
					}
					IL_280:
					num2 = 36;
				}
				IL_28F:
				num2 = 37;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_2A7:
				num2 = 38;
				result = false;
				goto IL_2AC;
				IL_2B1:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_35B:
				goto IL_38F;
				IL_35D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_36D:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_35D;
			}
			IL_38F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_39A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x001E1108 File Offset: 0x001DF308
		private void <<EMPTY_NAME>>(object A_0, ControlEventArgs A_1)
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO.__0_. != 0)
				{
					goto IL_8E;
				}
				IL_11:
				num2 = 3;
				this.OO.__0_. = 1;
				IL_1A:
				num2 = 4;
				if (this.o_0O.OO0_0_..O__0oO._.())
				{
					goto IL_8E;
				}
				IL_29:
				num2 = 5;
				TreeView treeView = ((o\u3000\u3002)base.MdiParent).o.O00OO_O0.();
				IL_3C:
				num2 = 6;
				IEnumerator enumerator = treeView.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					TreeNode treeNode = (TreeNode)obj;
					IL_5B:
					num2 = 7;
					treeNode.Name = treeNode.Text;
					IL_6B:
					num2 = 8;
				}
				IL_76:
				num2 = 9;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_8E:
				goto IL_105;
				IL_90:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_C6:
				goto IL_FA;
				IL_C8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_D8:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_C8;
			}
			IL_FA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_105:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x001E1234 File Offset: 0x001DF434
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (A_1.CloseReason == CloseReason.UserClosing)
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x001E1248 File Offset: 0x001DF448
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.Shift)
			{
				switch (A_1.KeyCode)
				{
				case System.Windows.Forms.Keys.Left:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, O0OO000oo0O.o.00o000O00o__., -1, 0);
					return;
				case System.Windows.Forms.Keys.Up:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, O0OO000oo0O.o_.0_0O., 0, -1);
					return;
				case System.Windows.Forms.Keys.Right:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, O0OO000oo0O.o.00o000O00o__., 1, 0);
					return;
				case System.Windows.Forms.Keys.Down:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, O0OO000oo0O.o_.0_0O., 0, 1);
					return;
				default:
					return;
				}
			}
			else
			{
				if (!A_1.Control)
				{
					if (A_1.KeyCode == System.Windows.Forms.Keys.Delete)
					{
						this.o._0O0O_o00.();
					}
					return;
				}
				switch (A_1.KeyCode)
				{
				case System.Windows.Forms.Keys.Left:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, -1, 0, "");
					return;
				case System.Windows.Forms.Keys.Up:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, 0, -1, "");
					return;
				case System.Windows.Forms.Keys.Right:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, 1, 0, "");
					return;
				case System.Windows.Forms.Keys.Down:
					oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, 0, 1, "");
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x001E1340 File Offset: 0x001DF540
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int a_ = 8;
			base.MouseDown += this.O0ooOo0.o.;
			base.MouseMove += this.oooo_._O.;
			base.MouseUp += this.OOOoO.Oo_O0o_0.;
			base.DragEnter += this.o_.000OOOoo.;
			base.DragDrop += this.o.Ooo0__0.;
			this.OO__oo0.0O___.(this.o_0O.OO0_0_., this);
			this.OOOoO.Oo_O0o_0.();
			if (!this.o_0O.OO0_0_..IsNull(O00OOOo_O0_O.b("ꫪ飬鯮黰볲藴鋶韸", a_)))
			{
				this.o_0O.OO0_0_..AutoOpen = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.o_0O.OO0_0_.[O00OOOo_O0_O.b("ꫪ飬鯮黰볲藴鋶韸", a_)]));
			}
			if (((o\u3000\u3002)base.MdiParent).O0.0O00_O.().Items.Count == 0)
			{
				this.OOOoO.Oo_O0o_0.();
			}
			((o\u3000\u3002)base.MdiParent).O0.0O00_O.().SelectedIndex = 0;
			this.o_0O.OO0_0_..TablName = this.o_0O.OO0_0_.[O00OOOo_O0_O.b("뿪賬跮鷰雲", a_)].ToString();
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001E1470 File Offset: 0x001DF670
		internal o\u3002\u3002\u3000\u3000\u3002(DataRow A_0)
		{
			int a_ = 17;
			base..ctor();
			base.ControlAdded += this.o_.000OOOoo.;
			base.FormClosing += this.o_.000OOOoo.;
			base.KeyDown += this.o_.000OOOoo.;
			base.Load += this.o__.0__.;
			base.ResizeBegin += this.o.Ooo0__0.;
			base.ResizeEnd += this.OO__oo0.0O___.;
			this.o_0O.OO0_0_. = new List<o\u3002\u3002\u3000\u3000\u3002.o_O>();
			this.O0o._0. = new List<ControlHolder>();
			this.o_0O.OO0_0_. = new Dictionary<string, object>();
			this.ooOOOO.0o. = new Dictionary<string, object>();
			this.O0o._0. = new Dictionary<string, PropertyBase>();
			this.o_0O.OO0_0_. = new FormProperty(this);
			this.o_0O.OO0_0_. = new List<O_o_0o>();
			this.oOO_0._000. = new List<ControlHolder>();
			this.O0o._0. = O00OOOo_O0_O.b("웳웵", a_);
			this.O__.o. = O00OOOo_O0_O.b("샳", a_);
			this.o_0O.OO0_0_. = new o0OoOOoOOo0.Oo000OOooOO0O();
			this.OO__oo0.0O___.();
			this.o_0O.OO0_0_. = A_0;
			o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., this.o_0O.OO0_0_., false);
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x001E15A3 File Offset: 0x001DF7A3
		internal int <<EMPTY_NAME>>()
		{
			return this.O0o._0.;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x001E15AB File Offset: 0x001DF7AB
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.O0o._0. = A_0;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x001E15B4 File Offset: 0x001DF7B4
		internal int <<EMPTY_NAME>>()
		{
			return this.ooOOOO.0o.;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001E15BC File Offset: 0x001DF7BC
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.ooOOOO.0o. = A_0;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x001E15C5 File Offset: 0x001DF7C5
		internal void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, base.Controls);
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x001E15D3 File Offset: 0x001DF7D3
		internal void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O._0O0__o.(base.Controls);
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001E15E0 File Offset: 0x001DF7E0
		internal void <<EMPTY_NAME>>(object A_0, DragEventArgs A_1)
		{
			int a_ = 12;
			int num;
			int num4;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				Point a_2 = ((Control)A_0).PointToClient(new Point(A_1.X, A_1.Y));
				IL_2F:
				num2 = 3;
				if (!A_1.Data.GetDataPresent(typeof(TreeNode)))
				{
					goto IL_45D;
				}
				IL_4B:
				num2 = 4;
				TreeNode treeNode = (TreeNode)A_1.Data.GetData(typeof(TreeNode));
				IL_69:
				num2 = 5;
				if (Operators.CompareString(treeNode.TreeView.Name, O00OOOo_O0_O.b("곮黰鷲致藶雸韺ꧼ跾搀昂", a_), true) != 0)
				{
					goto IL_14E;
				}
				IL_90:
				num2 = 6;
				string name = treeNode.Name;
				IL_9B:
				num2 = 7;
				PropertyBase propertyBase = this.OO__oo0.0O___.((ControlTypeEnum)Conversions.ToInteger(Enum.Parse(typeof(ControlTypeEnum), name)), (Control)A_0, a_2, true, null, true);
				IL_C5:
				num2 = 8;
				if (Conversions.ToInteger(Enum.Parse(typeof(ControlTypeEnum), name)) != 44)
				{
					goto IL_45D;
				}
				IL_E4:
				num2 = 9;
				GanttView o0_oO0.o_o. = ((GanttViewProperty)propertyBase).O0_oO0.o_o.;
				IL_F5:
				num2 = 10;
				((ISupportInitialize)o0_oO0.o_o.).BeginInit();
				IL_FF:
				num2 = 11;
				o0_oO0.o_o..BeginUpdate();
				IL_109:
				num2 = 12;
				o0_oO0.o_o..LoadXml(OO_00oOO.FileSys.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("돮雰鋲鯴菶跸跺铼髾瘀ⴂ愄戆漈樊砌挎攐㴒洔稖甘", a_));
				IL_135:
				num2 = 13;
				o0_oO0.o_o..EndUpdate();
				IL_13F:
				num2 = 14;
				((ISupportInitialize)o0_oO0.o_o.).EndInit();
				goto IL_45D;
				IL_14E:
				num2 = 16;
				if (Operators.CompareString(treeNode.TreeView.Name, O00OOOo_O0_O.b("ꧮ飰雲駴鏶그觺飼髾", a_), true) != 0)
				{
					goto IL_45D;
				}
				IL_176:
				num2 = 17;
				if (treeNode.Nodes.Count != 0)
				{
					goto IL_45D;
				}
				IL_18A:
				num2 = 18;
				string text = treeNode.FullPath.Replace(treeNode.TreeView.PathSeparator, O00OOOo_O0_O.b("쇮", a_));
				IL_1B5:
				num2 = 19;
				O\u3000\u3002\u3000\u3002\u3000\u3000\u3000\u3002\u3002 o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u = new O\u3000\u3002\u3000\u3002\u3000\u3000\u3000\u3002\u3002(text, RuntimeHelpers.GetObjectValue(treeNode.Tag));
				IL_1CD:
				num2 = 20;
				PropertyBase propertyBase2 = null;
				IL_1D3:
				num2 = 21;
				if (o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_45D;
				}
				IL_1E3:
				num2 = 22;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.o0__.O0o0o.().Checked)
				{
					goto IL_2DD;
				}
				IL_1F7:
				num2 = 23;
				string[] array = text.Split(new char[]
				{
					'.'
				});
				IL_20E:
				num2 = 24;
				string text2 = array[array.Length - 1];
				IL_21C:
				num2 = 25;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.O__O._0.().Checked)
				{
					goto IL_258;
				}
				IL_22D:
				num2 = 26;
				string caption = o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.O0.O00ooO_..Caption;
				IL_23E:
				num2 = 27;
				if (Operators.CompareString(caption, "", true) <= 0)
				{
					goto IL_258;
				}
				IL_251:
				num2 = 28;
				text2 = caption;
				IL_258:
				num2 = 29;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.ooO.0o____o.().Checked)
				{
					goto IL_283;
				}
				IL_269:
				num2 = 30;
				text2 += O00OOOo_O0_O.b("헮", a_);
				IL_283:
				num2 = 31;
				PropertyBase propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.Label, (Control)A_0, a_2, true, null, true);
				IL_299:
				num2 = 32;
				((LabelProperty)propertyBase3).Text = text2;
				IL_2AA:
				num2 = 33;
				a_2 = new Point(a_2.X + propertyBase3.Size.Width + 5, a_2.Y - 4);
				IL_2D6:
				num2 = 34;
				propertyBase2 = propertyBase3;
				IL_2DD:
				num2 = 35;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.oOoOo.o0O.().Checked)
				{
					goto IL_31A;
				}
				IL_2EE:
				num2 = 36;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.TextBox, (Control)A_0, a_2, true, null, true);
				IL_304:
				num2 = 37;
				((TextBoxProperty)propertyBase3).BindingField = text;
				goto IL_441;
				IL_31A:
				num2 = 39;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.O0_o00_o._Oo_.().Checked)
				{
					goto IL_358;
				}
				IL_32B:
				num2 = 40;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.TimeSpanBox, (Control)A_0, a_2, true, null, true);
				IL_342:
				num2 = 41;
				((TimeSpanBoxProperty)propertyBase3).BindingField = text;
				goto IL_441;
				IL_358:
				num2 = 43;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.OO00O_o.__.().Checked)
				{
					goto IL_395;
				}
				IL_369:
				num2 = 44;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.ComboBox, (Control)A_0, a_2, true, null, true);
				IL_37F:
				num2 = 45;
				((ComboboxProperty)propertyBase3).BindingField = text;
				goto IL_441;
				IL_395:
				num2 = 47;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.OoOO_.OO0o.().Checked)
				{
					goto IL_3CF;
				}
				IL_3A6:
				num2 = 48;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.DateTimePicker, (Control)A_0, a_2, true, null, true);
				IL_3BC:
				num2 = 49;
				((DateTimePickerProperty)propertyBase3).BindingField = text;
				goto IL_441;
				IL_3CF:
				num2 = 51;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.O__O._0.().Checked)
				{
					goto IL_409;
				}
				IL_3E0:
				num2 = 52;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.NumericComboBox, (Control)A_0, a_2, true, null, true);
				IL_3F6:
				num2 = 53;
				((NumericComboBoxProperty)propertyBase3).BindingField = text;
				goto IL_441;
				IL_409:
				num2 = 55;
				if (!o_u3000_u3002_u3000_u3002_u3000_u3000_u3000_u3002_u.ooO.0o____o.().Checked)
				{
					goto IL_441;
				}
				IL_41A:
				num2 = 56;
				propertyBase3 = this.OO__oo0.0O___.(ControlTypeEnum.CheckBox, (Control)A_0, a_2, true, null, true);
				IL_430:
				num2 = 57;
				((CheckBoxProperty)propertyBase3).BindingField = text;
				IL_441:
				num2 = 58;
				if (propertyBase2 == null)
				{
					goto IL_45D;
				}
				IL_448:
				num2 = 59;
				((LabelProperty)propertyBase2).Holder.Selected = true;
				IL_45D:
				goto IL_59F;
				IL_462:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_560:
				goto IL_594;
				IL_562:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_572:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_562;
			}
			IL_594:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_59F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x001E1BB0 File Offset: 0x001DFDB0
		internal void <<EMPTY_NAME>>(object A_0, DragEventArgs A_1)
		{
			if (A_1.Data.GetDataPresent(typeof(TreeNode)))
			{
				A_1.Effect = DragDropEffects.All;
				return;
			}
			A_1.Effect = DragDropEffects.None;
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x001E1BDC File Offset: 0x001DFDDC
		private void <<EMPTY_NAME>>(DataRow A_0, Control A_1)
		{
			int a_ = 11;
			int num;
			int num4;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				Control a_2 = null;
				IL_15:
				num2 = 3;
				DataRow[] childRows = A_0.GetChildRows(O00OOOo_O0_O.b("귭鿯鿱蓳駵雷鿹鋻諽", a_));
				IL_2D:
				num2 = 4;
				foreach (DataRow dataRow in childRows)
				{
					IL_41:
					num2 = 5;
					ControlTypeEnum controlTypeEnum = (ControlTypeEnum)Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("뫭觯英釳", a_)]);
					IL_5E:
					num2 = 6;
					if (A_1 is o0000O)
					{
						IL_68:
						num2 = 7;
						if (Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("뻭釯闱釳", a_)]) == 1)
						{
							IL_86:
							num2 = 8;
							a_2 = ((o0000O)A_1).oo0oO_O.oooO0O.();
						}
						else
						{
							IL_9A:
							num2 = 10;
							a_2 = ((o0000O)A_1).o.Oo0oo000O.();
						}
					}
					else
					{
						IL_AF:
						num2 = 12;
						if (A_1 is C1DockingTab)
						{
							IL_BA:
							num2 = 13;
							a_2 = ((C1DockingTab)A_1).TabPages[Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("뻭釯闱釳", a_)])];
						}
						else
						{
							IL_EA:
							num2 = 15;
							if (A_1 is C1NavBar)
							{
								IL_F5:
								num2 = 16;
								a_2 = ((C1NavBar)A_1).Panels[Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("뻭釯闱釳", a_)])];
							}
							else
							{
								IL_125:
								num2 = 18;
								if (A_1 is CustomPictureBox)
								{
									IL_130:
									num2 = 19;
									a_2 = ((CustomPictureBox)A_1).PictureBox1;
								}
								else
								{
									IL_142:
									num2 = 21;
									a_2 = A_1;
								}
							}
						}
					}
					IL_148:
					num2 = 22;
					PropertyBase propertyBase = this.OO__oo0.0O___.(controlTypeEnum, a_2, new Point(0, 0), false, dataRow, false);
					IL_161:
					num2 = 23;
					if (propertyBase != null)
					{
						IL_16B:
						num2 = 24;
						o_O_o_oOoo__.OOOO_OO._oo.(propertyBase, dataRow, false);
						IL_177:
						num2 = 25;
						if (propertyBase is SplitContainerProperty)
						{
							IL_183:
							num2 = 26;
							SplitContainerProperty splitContainerProperty = (SplitContainerProperty)propertyBase;
							IL_18F:
							num2 = 27;
							if (splitContainerProperty.O00o.__OOo_. > 0)
							{
								IL_19C:
								num2 = 28;
								((SplitContainer)splitContainerProperty.o_O0.O_.).SplitterDistance = splitContainerProperty.O00o.__OOo_.;
							}
							IL_1B7:
							num2 = 29;
							if (splitContainerProperty.O00o.__OOo_. != FixedPanel.Panel1)
							{
								IL_1C4:
								num2 = 30;
								((SplitContainer)splitContainerProperty.o_O0.O_.).FixedPanel = splitContainerProperty.O00o.__OOo_.;
							}
							IL_1DF:
							splitContainerProperty = null;
						}
						IL_1E2:
						num2 = 32;
						if (controlTypeEnum == ControlTypeEnum.GroupBox || controlTypeEnum == ControlTypeEnum.Panel || controlTypeEnum == ControlTypeEnum.TabControl || controlTypeEnum == ControlTypeEnum.SplitContainer || controlTypeEnum == ControlTypeEnum.NavBar || controlTypeEnum == ControlTypeEnum.PictureBox || controlTypeEnum == ControlTypeEnum.Gauges || controlTypeEnum == ControlTypeEnum.Map)
						{
							IL_215:
							num2 = 33;
							this.OO__oo0.0O___.(dataRow, propertyBase.Holder.ChildControl);
						}
					}
					IL_22B:
					num2 = 34;
				}
				IL_23F:
				num2 = 35;
				if (o\u3002\u3002\u3000\u3000\u3002.ooOOOO.0o.)
				{
					goto IL_294;
				}
				IL_249:
				num2 = 36;
				if (OoOo0O.Oo_oOO_._Oo_o.() < 0.95)
				{
					goto IL_294;
				}
				IL_25C:
				num2 = 37;
				o\u3002\u3002\u3000\u3000\u3002.ooOOOO.0o. = true;
				IL_265:
				num2 = 38;
				Thread thread = new Thread(new ThreadStart(O_O0OO.O0_00o.o0__o..o__o.00oo0_o.));
				IL_27F:
				num2 = 39;
				thread.IsBackground = true;
				IL_28A:
				num2 = 40;
				thread.Start();
				IL_294:
				goto IL_38A;
				IL_299:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_34B:
				goto IL_37F;
				IL_34D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_35D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_34D;
			}
			IL_37F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_38A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x001E1F98 File Offset: 0x001E0198
		internal PropertyBase <<EMPTY_NAME>>(ControlTypeEnum A_0, Control A_1, Point A_2, bool A_3 = true, DataRow A_4 = null, bool A_5 = true)
		{
			int a_ = 0;
			ControlHolder controlHolder = new ControlHolder();
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()];
			oOO0oo_o0.o0.Oo__.(base.Controls);
			if (A_4 == null)
			{
				A_4 = dataTable.NewRow();
				controlHolder.Key = ShareLibriay.GetRandString(8);
				A_4[O00OOOo_O0_O.b("꣢胤黦", a_)] = controlHolder.Key;
				A_4[O00OOOo_O0_O.b("럢鳤韦賨", a_)] = A_0;
				dataTable.Rows.Add(A_4);
				this.o_0O.OO0_0_..Add(new Ooo(controlHolder));
			}
			else
			{
				controlHolder.Key = Conversions.ToString(A_4[O00OOOo_O0_O.b("꣢胤黦", a_)]);
			}
			controlHolder.DataRow = A_4;
			controlHolder.Location = A_2;
			controlHolder.ControlType = A_0;
			PropertyBase propertyBase;
			switch (A_0)
			{
			case ControlTypeEnum.Label:
			{
				C1Label c1Label = new C1Label();
				c1Label.AutoSize = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢蓤藦賨蟪", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				c1Label.AutoSize = true;
				if (A_4.RowState == DataRowState.Added)
				{
					c1Label.Value = controlHolder.Name;
				}
				controlHolder.ChildControl = c1Label;
				c1Label.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..Oo.oOo_o0Oo0.(O00OOOo_O0_O.b("쯢诤裦蟨軪쓬", a_), new object[]
				{
					c1Label
				});
				propertyBase = new LabelProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.TextBox:
			{
				C1TextBox c1TextBox = new C1TextBox();
				c1TextBox.AutoSize = false;
				c1TextBox.TextDetached = true;
				c1TextBox.ShortcutsEnabled = false;
				c1TextBox.VerticalAlign = VerticalAlignEnum.Top;
				c1TextBox.Padding = new Padding(0, 2, 0, 0);
				c1TextBox.Height = c1TextBox.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢胤鿦鷨ꧪ苬韮", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				c1TextBox.Text = controlHolder.Name;
				controlHolder.ChildControl = c1TextBox;
				c1TextBox.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1TextBox
				});
				propertyBase = new TextBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Button:
			{
				C1Button c1Button = new C1Button();
				c1Button.ImageAlign = ContentAlignment.MiddleLeft;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꇢ郤鏦鷨蓪菬", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				if (A_4.RowState == DataRowState.Added)
				{
					c1Button.Text = controlHolder.Name;
				}
				controlHolder.Size = new Size(75, 23);
				controlHolder.ChildControl = c1Button;
				c1Button.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1Button
				});
				propertyBase = new ButtonProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.CheckBox:
			{
				C1CheckBox c1CheckBox = new C1CheckBox();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ跤苦諨胪꿬胮觰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				if (A_4.RowState == DataRowState.Added)
				{
					c1CheckBox.Text = controlHolder.Name;
				}
				c1CheckBox.AutoCheck = false;
				controlHolder.Size = new Size(90, 21);
				controlHolder.ChildControl = c1CheckBox;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1CheckBox
				});
				propertyBase = new CheckBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.RadioButton:
			{
				RadioButton radioButton = new RadioButton();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("뇢蓤菦胨蓪꿬髮藰蟲髴駶", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				if (A_4.RowState == DataRowState.Added)
				{
					radioButton.Text = controlHolder.Name;
				}
				radioButton.AutoCheck = false;
				controlHolder.Size = new Size(105, 21);
				controlHolder.ChildControl = radioButton;
				propertyBase = new RadioButtonProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.ComboBox:
			{
				C1DropDownControl c1DropDownControl = new C1DropDownControl();
				c1DropDownControl.AutoSize = false;
				c1DropDownControl.ShowUpDownButtons = false;
				c1DropDownControl.ShortcutsEnabled = false;
				c1DropDownControl.TextDetached = true;
				c1DropDownControl.VerticalAlign = VerticalAlignEnum.Middle;
				c1DropDownControl.Padding = new Padding(0, 2, 0, 0);
				c1DropDownControl.Height = c1DropDownControl.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ諤諦诨蓪꿬胮觰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DropDownControl;
				controlHolder.ChildControl.Text = controlHolder.Name;
				c1DropDownControl.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DropDownControl
				});
				propertyBase = new ComboboxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.NumericComboBox:
			{
				C1DropDownControl c1DropDownControl2 = new C1DropDownControl();
				c1DropDownControl2.AutoSize = false;
				c1DropDownControl2.TextDetached = true;
				c1DropDownControl2.ShortcutsEnabled = false;
				c1DropDownControl2.VerticalAlign = VerticalAlignEnum.Middle;
				c1DropDownControl2.Padding = new Padding(0, 2, 0, 0);
				c1DropDownControl2.Height = c1DropDownControl2.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("귢郤諦賨駪蓬賮닰鳲飴闶雸맺鋼蟾", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DropDownControl2;
				controlHolder.ChildControl.Text = controlHolder.Name;
				c1DropDownControl2.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DropDownControl2
				});
				propertyBase = new NumericComboBoxProperty(controlHolder);
				((NumericComboBoxProperty)propertyBase).Increment = 1;
				goto IL_1EFE;
			}
			case ControlTypeEnum.TopicBar:
			{
				Oo_ oo_ = new Oo_();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢諤韦胨裪꿬軮菰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				oo_.Padding = new Padding(10);
				controlHolder.Height = 250;
				controlHolder.Width = 190;
				controlHolder.ChildControl = oo_;
				oo_.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					oo_
				});
				propertyBase = new TopicBarProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.DateTimePicker:
			{
				C1DropDownControl c1DropDownControl3 = new C1DropDownControl();
				c1DropDownControl3.AutoSize = false;
				c1DropDownControl3.TextDetached = true;
				c1DropDownControl3.ShortcutsEnabled = false;
				c1DropDownControl3.VerticalAlign = VerticalAlignEnum.Middle;
				c1DropDownControl3.Padding = new Padding(0, 2, 0, 0);
				c1DropDownControl3.Height = c1DropDownControl3.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꟢蓤鏦賨뿪蓬苮铰ꏲ鳴银鋸黺迼", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DropDownControl3;
				controlHolder.ChildControl.Text = controlHolder.Name;
				c1DropDownControl3.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DropDownControl3
				});
				propertyBase = new DateTimePickerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.ListBox:
			{
				CustomListBox customListBox = new CustomListBox();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢賤铦鷨ꧪ苬韮", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Height = 200;
				customListBox.IntegralHeight = false;
				controlHolder.ChildControl = customListBox;
				propertyBase = new ListBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.CheckedListBox:
			{
				CheckedListBox checkedListBox = new CheckedListBox();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ跤苦諨胪裬诮뷰髲蛴菶미铺藼", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Height = 200;
				checkedListBox.CheckOnClick = true;
				checkedListBox.IntegralHeight = false;
				controlHolder.ChildControl = checkedListBox;
				propertyBase = new CheckedListBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.GroupBox:
			{
				o00__0oo0 o00__0oo = new o00__0oo0();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꓢ韤裦鳨鯪꿬胮觰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Height = 150;
				if (A_4.RowState == DataRowState.Added)
				{
					o00__0oo.Text = controlHolder.Name;
				}
				controlHolder.ChildControl = o00__0oo;
				propertyBase = new GroupBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Panel:
			{
				oo0_0Oo a_2 = new oo0_0Oo();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢蓤触賨蟪", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = a_2;
				controlHolder.Height = 150;
				propertyBase = new PanelProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.SplitContainer:
			{
				o0000O o0000O = new o0000O();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("냢闤详胨鿪껬胮鿰蟲铴黶韸黺迼", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 200);
				controlHolder.ChildControl = o0000O;
				o0000O.Panel1MinSize = 0;
				o0000O.Panel2MinSize = 0;
				propertyBase = new SplitContainerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.PictureBox:
			{
				CustomPictureBox customPictureBox = new CustomPictureBox(null);
				customPictureBox.AutoScroll = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢賤蓦鷨黪鿬諮돰鳲跴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = customPictureBox;
				controlHolder.Height = 150;
				propertyBase = new PictureBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.TabControl:
			{
				C1DockingTab c1DockingTab = new C1DockingTab();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢蓤藦ꫨ蓪菬鯮菰鳲駴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DockingTab;
				controlHolder.Size = new Size(300, 200);
				c1DockingTab.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DockingTab
				});
				propertyBase = new TabControlProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.TreeView:
			{
				TreeView treeView = new TreeView();
				treeView.HideSelection = false;
				treeView.LabelEdit = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢韤苦賨뷪蓬諮蛰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = treeView;
				propertyBase = new TreeViewProperty(controlHolder);
				treeView.AfterSelect += this.o.OO_.;
				goto IL_1EFE;
			}
			case ControlTypeEnum.ProgressBar:
			{
				ProgressBar progressBar = new ProgressBar();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢韤裦軨駪裬鳮苰뇲铴藶", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(130, 20);
				controlHolder.ChildControl = progressBar;
				progressBar.Value = 50;
				propertyBase = new ProgressBarProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Chart:
			{
				OO___O_ a_3 = new OO___O_();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ跤蛦鯨鿪", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_3;
				propertyBase = new ChartProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.PictureViewer:
			{
				PictureViewer a_4 = new PictureViewer();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢賤蓦鷨黪鿬諮꟰髲郴胶鳸觺", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_4;
				propertyBase = new PictureViewerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.FileManager:
			{
				FileManager a_5 = new FileManager();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꗢ賤详賨ꛪ賬臮郰铲郴藶", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_5;
				propertyBase = new FileManagerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.ColorLabel:
			{
				Label label = new Label();
				label.AutoSize = false;
				label.Text = "";
				label.BackColor = Color.Red;
				label.BorderStyle = BorderStyle.Fixed3D;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ諤详蛨駪ꇬ軮鏰雲駴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = label;
				controlHolder.Size = new Size(50, 22);
				propertyBase = new ColorLabelProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.CheckedComboBox:
			{
				C1DropDownControl c1DropDownControl4 = new C1DropDownControl();
				c1DropDownControl4.AutoSize = false;
				c1DropDownControl4.TextDetached = true;
				c1DropDownControl4.ShowUpDownButtons = false;
				c1DropDownControl4.ShortcutsEnabled = false;
				c1DropDownControl4.VerticalAlign = VerticalAlignEnum.Middle;
				c1DropDownControl4.Padding = new Padding(0, 2, 0, 0);
				c1DropDownControl4.Height = c1DropDownControl4.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ跤苦諨胪裬诮닰鳲飴闶雸맺鋼蟾", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DropDownControl4;
				controlHolder.ChildControl.Text = controlHolder.Name;
				c1DropDownControl4.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DropDownControl4
				});
				propertyBase = new CheckedComboBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.NavBar:
			{
				O_OOO o_OOO = new O_OOO();
				o_OOO.ShowOptionsMenu = false;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("귢蓤釦ꯨ諪鿬", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Height = 250;
				controlHolder.Width = 190;
				controlHolder.ChildControl = o_OOO;
				o_OOO.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					o_OOO
				});
				propertyBase = new NavBarProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.DataList:
			case ControlTypeEnum.QRCode1:
			case ControlTypeEnum.FullPath:
				break;
			case ControlTypeEnum.WebBrowser:
			{
				O_O_00 a_6 = new O_O_00();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("듢胤藦ꯨ駪苬飮苰雲蟴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_6;
				propertyBase = new WebBrowserProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Painter:
			{
				o0Oo0OO a_7 = new o0Oo0OO();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢蓤軦蟨鿪裬鷮", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_7;
				propertyBase = new PainterProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Line:
			{
				LineControl a_8 = new LineControl();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢賤触賨", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = a_8;
				controlHolder.Size = new Size(100, 50);
				propertyBase = new LineProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.BarCode:
			{
				OOo00o_0o0_ a_9 = new OOo00o_0o0_();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꇢ蓤闦ꫨ蓪觬諮", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(143, 40);
				controlHolder.ChildControl = a_9;
				propertyBase = new BarCodeProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.DropDownBox:
			{
				C1DropDownControl c1DropDownControl5 = new C1DropDownControl();
				c1DropDownControl5.AutoSize = false;
				c1DropDownControl5.TextDetached = true;
				c1DropDownControl5.ShowUpDownButtons = false;
				c1DropDownControl5.ShortcutsEnabled = false;
				c1DropDownControl5.VerticalAlign = VerticalAlignEnum.Middle;
				c1DropDownControl5.Padding = new Padding(0, 2, 0, 0);
				c1DropDownControl5.Height = c1DropDownControl5.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꟢韤裦駨ꧪ苬韮", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = c1DropDownControl5;
				controlHolder.ChildControl.Text = controlHolder.Name;
				c1DropDownControl5.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1DropDownControl5
				});
				propertyBase = new DropDownBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Calendar:
			{
				MonthCalendar monthCalendar = new MonthCalendar();
				monthCalendar.FirstDayOfWeek = Day.Monday;
				monthCalendar.MaxSelectionCount = 1;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ蓤详賨藪觬軮菰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = monthCalendar;
				propertyBase = new CalendarProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.TrackBar:
			{
				TrackBar a_10 = new TrackBar();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢韤蛦諨胪꿬軮菰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.ChildControl = a_10;
				propertyBase = new TrackBarProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.RecordGrid:
			{
				O0O__ a_11 = new O0O__();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("뇢胤蓦蛨駪觬꣮菰髲釴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = a_11;
				propertyBase = new RecordGridProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.TimeSpanBox:
			{
				C1TextBox c1TextBox2 = new C1TextBox();
				c1TextBox2.AutoSize = false;
				c1TextBox2.TextDetached = true;
				c1TextBox2.ShortcutsEnabled = false;
				c1TextBox2.VerticalAlign = VerticalAlignEnum.Middle;
				c1TextBox2.Padding = new Padding(0, 2, 0, 0);
				c1TextBox2.Height = c1TextBox2.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢賤諦賨룪鷬軮鿰뇲髴迶", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				c1TextBox2.Text = controlHolder.Name;
				controlHolder.ChildControl = c1TextBox2;
				c1TextBox2.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1TextBox2
				});
				propertyBase = new TimeSpanBoxProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.ListView:
			{
				o00_o00 a_12 = new o00_o00();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢賤铦鷨뷪蓬諮蛰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_12;
				propertyBase = new ListViewProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.FilterTree:
			{
				TreeView treeView2 = new TreeView();
				treeView2.HideSelection = false;
				treeView2.LabelEdit = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꗢ賤详鷨軪鿬믮菰雲郴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = treeView2;
				propertyBase = new o000O_o(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.LoadTree:
			{
				TreeView treeView3 = new TreeView();
				treeView3.HideSelection = false;
				treeView3.LabelEdit = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢諤蛦跨뿪鿬諮铰", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = treeView3;
				propertyBase = new o__(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.InlineTree:
			{
				TreeView treeView4 = new TreeView();
				treeView4.HideSelection = false;
				treeView4.LabelEdit = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꫢ诤详胨藪裬믮菰雲郴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = treeView4;
				propertyBase = new O0o__oo0O(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.LayersTree:
			{
				TreeView treeView5 = new TreeView();
				treeView5.HideSelection = false;
				treeView5.LabelEdit = true;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("꿢蓤黦賨駪黬믮菰雲郴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(200, 250);
				controlHolder.ChildControl = treeView5;
				propertyBase = new O0oOo0_0(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.FontPicker:
			{
				C1FontPicker c1FontPicker = new C1FontPicker();
				c1FontPicker.AutoSize = false;
				c1FontPicker.TextDetached = true;
				c1FontPicker.ShortcutsEnabled = false;
				c1FontPicker.VerticalAlign = VerticalAlignEnum.Middle;
				c1FontPicker.Padding = new Padding(0, 2, 0, 0);
				c1FontPicker.Height = c1FontPicker.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꗢ諤触鷨믪蓬賮髰雲蟴", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				c1FontPicker.Text = controlHolder.Name;
				controlHolder.ChildControl = c1FontPicker;
				c1FontPicker.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1FontPicker
				});
				propertyBase = new FontPickerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.ColorPicker:
			{
				C1ColorPicker c1ColorPicker = new C1ColorPicker();
				c1ColorPicker.Color = Color.Empty;
				c1ColorPicker.AutoSize = false;
				c1ColorPicker.TextDetached = true;
				c1ColorPicker.ShortcutsEnabled = false;
				c1ColorPicker.VerticalAlign = VerticalAlignEnum.Middle;
				c1ColorPicker.Padding = new Padding(0, 2, 0, 0);
				c1ColorPicker.Height = c1ColorPicker.PreferredHeight;
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꃢ諤详蛨駪뷬蛮鋰飲郴藶", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				c1ColorPicker.Text = controlHolder.Name;
				controlHolder.ChildControl = c1ColorPicker;
				c1ColorPicker.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					c1ColorPicker
				});
				propertyBase = new ColorPickerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Gauges:
			{
				O0_O_0O a_13 = new O0_O_0O();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꓢ郤蛦軨軪黬", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(300, 250);
				controlHolder.ChildControl = a_13;
				propertyBase = new GaugesProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.GanttView:
			{
				GanttView a_14 = new GanttView(true);
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("ꓢ蓤触鷨鿪믬蛮铰蓲", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(400, 300);
				controlHolder.ChildControl = a_14;
				propertyBase = new GanttViewProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.PDFViewer:
			{
				o_O0 a_15 = new o_O0();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("돢ꇤꇦ뿨苪裬飮铰臲", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(400, 300);
				controlHolder.ChildControl = a_15;
				propertyBase = new PDFViewerProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.Map:
			{
				GeoMap a_16 = new GeoMap();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("껢蓤韦", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(500, 300);
				controlHolder.ChildControl = a_16;
				propertyBase = new MapProperty(controlHolder);
				goto IL_1EFE;
			}
			case ControlTypeEnum.WebViewer:
			{
				oo00 a_17 = new oo00();
				if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
				{
					controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("듢胤藦뿨苪裬飮铰臲", a_));
				}
				else
				{
					controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				}
				controlHolder.Size = new Size(400, 300);
				controlHolder.ChildControl = a_17;
				propertyBase = new WebViewerProperty(controlHolder);
				goto IL_1EFE;
			}
			default:
				if (A_0 == ControlTypeEnum.Table)
				{
					oOo__OO_ a_18 = new oOo__OO_();
					if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
					{
						controlHolder.Name = this.OO__oo0.0O___.(O00OOOo_O0_O.b("럢蓤藦藨軪", a_));
					}
					else
					{
						controlHolder.Name = A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
					}
					controlHolder.Size = new Size(300, 250);
					controlHolder.ChildControl = a_18;
					propertyBase = new TableGridProperty(controlHolder);
					goto IL_1EFE;
				}
				break;
			}
			return null;
			IL_1EFE:
			this.o_0O.OO0_0_..Add(controlHolder.Key, new o_0oooo_OO(propertyBase, new string[0], false, false));
			this.ooOOOO.0o..Add(controlHolder.Key, new o_0oooo_OO(propertyBase, new string[0], false, true));
			this.O0o._0..Add(controlHolder.Key, propertyBase);
			controlHolder.ActivatedChanged += this.o.OO_.;
			this.O0o._0..Add(controlHolder);
			if (A_5)
			{
				this.OOOoO.Oo_O0o_0.();
			}
			if (A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] == DBNull.Value)
			{
				A_4[O00OOOo_O0_O.b("귢蓤諦賨", a_)] = controlHolder.Name;
			}
			controlHolder.ChildControl.BackColor = controlHolder.ChildControl.BackColor;
			controlHolder.ChildControl.ForeColor = controlHolder.ChildControl.ForeColor;
			ControlHolder controlHolder2 = controlHolder;
			controlHolder2.Font = new Font(controlHolder2.Font.Name, controlHolder2.Font.Size, controlHolder2.Font.Style);
			Control control = controlHolder.ChildControl;
			control.Font = new Font(control.Font.Name, control.Font.Size, control.Font.Style);
			A_1.Controls.Add(controlHolder);
			controlHolder.ChildControl.SendToBack();
			controlHolder.SelectedChanged += this.O__.o.;
			controlHolder.BringToFront();
			if (A_3)
			{
				controlHolder.Selected = true;
			}
			return propertyBase;
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x001E402C File Offset: 0x001E222C
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (((o_0oooo_OO)((o\u3000\u3002)base.MdiParent).O0.0O00_O.().SelectedObject).Oo._o.() is TreeViewProperty)
			{
				PropertyBase propertyBase = (TreeViewProperty)((o_0oooo_OO)((o\u3000\u3002)base.MdiParent).O0.0O00_O.().SelectedObject).Oo._o.();
				((o\u3000\u3002)base.MdiParent).O.oOO_.(new PropertyBase[]
				{
					propertyBase
				});
			}
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x001E40A0 File Offset: 0x001E22A0
		internal string <<EMPTY_NAME>>(string A_0)
		{
			ControlHolder controlHolder = null;
			int num;
			for (;;)
			{
				num = 1;
				do
				{
					try
					{
						List<ControlHolder>.Enumerator enumerator = this.O0o._0..GetEnumerator();
						while (enumerator.MoveNext())
						{
							controlHolder = enumerator.Current;
							if (Operators.CompareString(controlHolder.Name, A_0 + Conversions.ToString(num), true) == 0)
							{
								break;
							}
						}
					}
					finally
					{
						List<ControlHolder>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (controlHolder == null || Operators.CompareString(controlHolder.Name, A_0 + Conversions.ToString(num), true) != 0)
					{
						goto IL_6D;
					}
					num++;
				}
				while (num <= 2147483647);
			}
			IL_6D:
			return A_0 + Conversions.ToString(num);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x001E4150 File Offset: 0x001E2350
		internal void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				PropertyGrid propertyGrid = ((o\u3000\u3002)base.MdiParent).O0.0O00_O.();
				IL_1A:
				num2 = 3;
				ArrayList arrayList = new ArrayList();
				IL_23:
				num2 = 4;
				arrayList.AddRange(propertyGrid.SelectedObjects);
				IL_32:
				num2 = 5;
				if (!A_0.Selected)
				{
					goto IL_E4;
				}
				IL_3F:
				num2 = 6;
				if (arrayList.Contains(RuntimeHelpers.GetObjectValue(this.o_0O.OO0_0_.[A_0.Key])))
				{
					goto IL_126;
				}
				IL_63:
				num2 = 7;
				arrayList.Add(RuntimeHelpers.GetObjectValue(this.o_0O.OO0_0_.[A_0.Key]));
				IL_83:
				num2 = 8;
				IEnumerator enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					o_0oooo_OO o_0oooo_OO = (o_0oooo_OO)obj;
					IL_9E:
					num2 = 9;
					if (o_0oooo_OO.Oo._o.() == this.o_0O.OO0_0_.)
					{
						IL_B0:
						num2 = 10;
						arrayList.Remove(o_0oooo_OO);
						break;
					}
					IL_BE:
					num2 = 12;
				}
				IL_CA:
				num2 = 13;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_126;
				}
				goto IL_126;
				IL_E4:
				num2 = 15;
				if (!arrayList.Contains(RuntimeHelpers.GetObjectValue(this.o_0O.OO0_0_.[A_0.Key])))
				{
					goto IL_126;
				}
				IL_106:
				num2 = 16;
				arrayList.Remove(RuntimeHelpers.GetObjectValue(this.o_0O.OO0_0_.[A_0.Key]));
				IL_126:
				num2 = 17;
				if (arrayList.Count <= 0)
				{
					goto IL_145;
				}
				IL_133:
				num2 = 18;
				propertyGrid.SelectedObjects = arrayList.ToArray();
				goto IL_14F;
				IL_145:
				num2 = 20;
				propertyGrid.SelectedObject = null;
				IL_14F:
				goto IL_1F5;
				IL_154:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1B6:
				goto IL_1EA;
				IL_1B8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1C8:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_1B8;
			}
			IL_1EA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F5:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x001E4378 File Offset: 0x001E2578
		internal void <<EMPTY_NAME>>()
		{
			int a_ = 16;
			int num;
			int num5;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				ComboBox comboBox = new ComboBox();
				IL_18:
				num2 = 3;
				List<ControlHolder>.Enumerator enumerator = this.O0o._0..GetEnumerator();
				while (enumerator.MoveNext())
				{
					ControlHolder item = enumerator.Current;
					IL_32:
					num2 = 4;
					comboBox.Items.Add(item);
					IL_42:
					num2 = 5;
				}
				IL_4D:
				num2 = 6;
				((IDisposable)enumerator).Dispose();
				IL_5C:
				num2 = 7;
				comboBox.DisplayMember = O00OOOo_O0_O.b("럲鳴蓶觸韺鳼蛾伀戂栄戆", a_);
				IL_72:
				num2 = 8;
				comboBox.Sorted = true;
				IL_7B:
				num2 = 9;
				ComboBox comboBox2 = ((o\u3000\u3002)base.MdiParent).O0.0O00_O.();
				IL_90:
				num2 = 10;
				comboBox2.Items.Clear();
				IL_9F:
				num2 = 11;
				comboBox2.Items.Add(this);
				IL_B0:
				num2 = 12;
				int num3 = comboBox.Items.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_C7:
					num2 = 13;
					comboBox2.Items.Add(RuntimeHelpers.GetObjectValue(comboBox.Items[i]));
					IL_E9:
					num2 = 14;
				}
				IL_F8:
				num2 = 15;
				comboBox2.DisplayMember = O00OOOo_O0_O.b("럲鳴蓶觸韺鳼蛾伀戂栄戆", a_);
				IL_110:
				comboBox2 = null;
				IL_113:
				goto IL_1A9;
				IL_118:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_16A:
				goto IL_19E;
				IL_16C:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_17C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_16C;
			}
			IL_19E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1A9:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x001E4554 File Offset: 0x001E2754
		internal void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			((o\u3000\u3002)base.MdiParent).O.oOO_.().Text = "";
			ComboBox comboBox = ((o\u3000\u3002)base.MdiParent).O0.0O00_O.();
			if (A_0.Activated)
			{
				if (comboBox.Items.Contains(A_0))
				{
					comboBox.SelectedItem = A_0;
				}
				((o\u3000\u3002)base.MdiParent).o_.OO000o___oo.().SelectedObject = RuntimeHelpers.GetObjectValue(this.ooOOOO.0o.[A_0.Key]);
			}
			else
			{
				comboBox.SelectedItem = null;
				((o\u3000\u3002)base.MdiParent).o_.OO000o___oo.().SelectedObject = null;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x001E45F8 File Offset: 0x001E27F8
		public string DisplayName
		{
			get
			{
				int a_ = 15;
				return this.o_0O.OO0_0_.[O00OOOo_O0_O.b("볱闳鯵鷷", a_)].ToString() + O00OOOo_O0_O.b("\udaf1掉ᖦ퇷", a_);
			}
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x001E4640 File Offset: 0x001E2840
		internal void <<EMPTY_NAME>>()
		{
			int a_ = 10;
			int num;
			int num4;
			object obj2;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				if (!O_O0OO.O0_00o.o0__o..oOO0_o_._ooO.)
				{
					goto IL_4A;
				}
				IL_1E:
				num2 = 3;
				if (Project.oOOoOOOo._O.())
				{
					goto IL_4A;
				}
				IL_27:
				num2 = 4;
				MessageBox.Show(O_O0OO.OO0._0.(), O00OOOo_O0_O.b("㶏햗", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_6A4;
				IL_4A:
				num2 = 6;
				Catalog catalog = new CatalogClass();
				IL_52:
				num2 = 7;
				ADOX.Table table = new TableClass();
				IL_5B:
				num2 = 8;
				Index index = new IndexClass();
				IL_64:
				num2 = 9;
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				IL_6E:
				num2 = 10;
				saveFileDialog.Filter = O00OOOo_O0_O.b("窖ಽ皕ּ\uddf4\uddf6\ud9f8", a_) + ooO0__OO.o_oo_oo_0.___.() + O00OOOo_O0_O.b("쓬鏮\udbf0", a_) + ooO0__OO.o_oo_oo_0.___.();
				IL_A3:
				num2 = 11;
				saveFileDialog.OverwritePrompt = true;
				IL_AE:
				num2 = 12;
				saveFileDialog.AddExtension = true;
				IL_B9:
				num2 = 13;
				saveFileDialog.CheckPathExists = true;
				IL_C4:
				num2 = 14;
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					goto IL_6A4;
				}
				IL_D4:
				num2 = 15;
				string fileName = saveFileDialog.FileName;
				IL_E0:
				num2 = 16;
				string file = OO_00oOO.FileSys.GetParentPath(saveFileDialog.FileName) + O00OOOo_O0_O.b("뇬", a_) + Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + O00OOOo_O0_O.b("쏬鳮藰臲鳴蟶", a_);
				IL_123:
				num2 = 19;
				if (!c.OOOOO.o.().FileSystem.FileExists(fileName))
				{
					goto IL_14D;
				}
				IL_139:
				num2 = 20;
				c.OOOOO.o.().FileSystem.DeleteFile(fileName);
				IL_14D:
				num2 = 21;
				catalog.Create(Oo00.o00.0OO.(fileName));
				IL_15E:
				num2 = 22;
				table = new TableClass();
				IL_168:
				num2 = 23;
				index = new IndexClass();
				IL_172:
				num2 = 24;
				table.Name = ooO0__OO.oo.__oOO_O.();
				IL_181:
				num2 = 25;
				table.Columns.Append(O00OOOo_O0_O.b("ꏬ軮鳰雲", a_), ADOX.DataTypeEnum.adVarWChar, 32);
				IL_1A5:
				num2 = 26;
				table.Columns.Append(O00OOOo_O0_O.b("맬軮鏰鿲郴", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				IL_1C9:
				num2 = 27;
				table.Columns.Append(O00OOOo_O0_O.b("ꛬ諮裰", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				IL_1EC:
				num2 = 28;
				table.Columns.Append(O00OOOo_O0_O.b("뷬軮菰雲鯴菶닸黺蓼", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				IL_20F:
				num2 = 29;
				table.Columns.Append(O00OOOo_O0_O.b("뷬軮雰雲", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				IL_22F:
				num2 = 30;
				table.Columns.Append(O00OOOo_O0_O.b("맬雮臰雲", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				IL_24F:
				num2 = 31;
				table.Columns.Append(O00OOOo_O0_O.b("뷬鷮黰菲郴藶跸苺", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				IL_272:
				num2 = 32;
				table.Columns.Append(O00OOOo_O0_O.b("껬胮闰雲", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				IL_295:
				num2 = 33;
				table.Columns[O00OOOo_O0_O.b("맬軮鏰鿲郴", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				IL_2B8:
				num2 = 34;
				table.Columns[O00OOOo_O0_O.b("뷬鷮黰菲郴藶跸苺", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				IL_2DB:
				num2 = 35;
				table.Columns[O00OOOo_O0_O.b("껬胮闰雲", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				IL_2FE:
				num2 = 36;
				table.Columns[O00OOOo_O0_O.b("뷬軮菰雲鯴菶닸黺蓼", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				IL_321:
				num2 = 37;
				table.Columns[O00OOOo_O0_O.b("뷬軮雰雲", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				IL_344:
				num2 = 38;
				index.Name = O00OOOo_O0_O.b("뷬鷮飰黲铴藶胸냺飼蛾", a_);
				IL_35C:
				num2 = 39;
				index.Columns.Append(O00OOOo_O0_O.b("ꛬ諮裰", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				IL_37F:
				num2 = 40;
				index.PrimaryKey = true;
				IL_38A:
				num2 = 41;
				index.Unique = true;
				IL_395:
				num2 = 42;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				IL_3B0:
				num2 = 43;
				catalog.Tables.Append(table);
				IL_3C0:
				num2 = 44;
				((Connection)catalog.ActiveConnection).Close();
				IL_3D3:
				num2 = 45;
				catalog = null;
				IL_3D8:
				num2 = 46;
				OleDbConnection oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(fileName));
				IL_3E9:
				num2 = 47;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("뻬諮鷰雲雴菶\ud9f8퇺\uddfc맾猀氂栄✆刈", a_) + ooO0__OO.oo.__oOO_O.() + O00OOOo_O0_O.b("냬", a_), oleDbConnection);
				IL_41B:
				num2 = 48;
				DataTable dataTable = this.o_0O.OO0_0_..Table.Clone();
				IL_430:
				num2 = 49;
				dataTable.AcceptChanges();
				IL_43A:
				num2 = 50;
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				IL_444:
				num2 = 51;
				string text = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				IL_466:
				num2 = 52;
				DataRow dataRow = dataTable.NewRow();
				IL_472:
				num2 = 53;
				dataRow.ItemArray = this.o_0O.OO0_0_..ItemArray;
				IL_487:
				num2 = 54;
				dataRow[O00OOOo_O0_O.b("뷬鷮黰菲郴藶跸苺", a_)] = O00OOOo_O0_O.b("雬", a_) + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., false, '\v', false), text, text) + O00OOOo_O0_O.b("郬", a_);
				IL_4D8:
				num2 = 55;
				dataRow[O00OOOo_O0_O.b("껬胮闰雲", a_)] = O00OOOo_O0_O.b("雬", a_) + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., true, '\v', false), text, text) + O00OOOo_O0_O.b("郬", a_);
				IL_529:
				num2 = 56;
				dataTable.Rows.Add(dataRow);
				IL_53A:
				num2 = 57;
				dataRow = dataTable.NewRow();
				IL_546:
				num2 = 58;
				dataRow[O00OOOo_O0_O.b("ꏬ軮鳰雲", a_)] = O00OOOo_O0_O.b("달ꛮ闰雲鯴菶郸鷺蓼ꃾ", a_);
				IL_56C:
				num2 = 59;
				dataRow[O00OOOo_O0_O.b("맬雮臰雲", a_)] = ControlTypeEnum.Identify;
				IL_58E:
				num2 = 60;
				dataRow[O00OOOo_O0_O.b("蛬諮裰", a_)] = OoOo0O.OO_o.0o_O.(8);
				IL_5AC:
				num2 = 61;
				dataRow[O00OOOo_O0_O.b("뷬鷮黰菲郴藶跸苺", a_)] = O_O0OO.O_O._Oo.();
				IL_5C9:
				num2 = 62;
				dataTable.Rows.Add(dataRow);
				IL_5DA:
				num2 = 63;
				IEnumerator enumerator = base.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_5FA:
					num2 = 64;
					if (control is ControlHolder)
					{
						IL_606:
						num2 = 65;
						((ControlHolder)control).o_.0Oo.(dataTable);
					}
					IL_618:
					num2 = 66;
				}
				IL_624:
				num2 = 67;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_63C:
				num2 = 68;
				oleDbConnection.Open();
				IL_646:
				num2 = 69;
				oleDbDataAdapter.Update(dataTable);
				IL_653:
				num2 = 70;
				oleDbConnection.Close();
				IL_65D:
				num2 = 71;
				o\u3000\u3002 o_u3000_u = (o\u3000\u3002)base.MdiParent;
				IL_66D:
				num2 = 72;
				if (Operators.CompareString(o_u3000_u.OO_._oOo., "", true) <= 0)
				{
					goto IL_6A1;
				}
				IL_685:
				num2 = 73;
				OO_00oOO.FileSys.WriteAllText(file, o_u3000_u.OO_._oOo., false, Encoding.Default);
				IL_6A1:
				o_u3000_u = null;
				IL_6A4:
				goto IL_822;
				IL_6A9:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_7E3:
				goto IL_817;
				IL_7E5:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7F5:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_7E5;
			}
			IL_817:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_822:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x001E4E94 File Offset: 0x001E3094
		internal void <<EMPTY_NAME>>()
		{
			int a_ = 0;
			int num;
			int num6;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				OpenFileDialog openFileDialog = new OpenFileDialog();
				IL_18:
				num2 = 3;
				DataSet dataSet = new DataSet();
				IL_21:
				num2 = 4;
				string text = "";
				IL_2A:
				num2 = 5;
				openFileDialog.CheckFileExists = true;
				IL_33:
				num2 = 6;
				openFileDialog.Filter = O00OOOo_O0_O.b("璘ڷ悃ᾦ쏪쟬쿮", a_) + ooO0__OO.o_oo_oo_0.___.() + O00OOOo_O0_O.b("쫢駤췦", a_) + ooO0__OO.o_oo_oo_0.___.();
				IL_66:
				num2 = 7;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					goto IL_8D5;
				}
				IL_74:
				num2 = 8;
				string fileName = openFileDialog.FileName;
				IL_7E:
				num2 = 11;
				OleDbConnection oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(fileName));
				IL_8F:
				num2 = 12;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("냢胤详賨裪駬쿮\udbf0폲돴藶雸雺\uddfc꓾", a_) + ooO0__OO.oo.__oOO_O.() + O00OOOo_O0_O.b("뻢", a_), oleDbConnection);
				IL_C1:
				num2 = 13;
				DataTable dataTable = this.o_0O.OO0_0_..Table.Clone();
				IL_D6:
				num2 = 14;
				oleDbConnection.Open();
				IL_E0:
				num2 = 15;
				oleDbDataAdapter.Fill(dataTable);
				IL_ED:
				num2 = 16;
				oleDbConnection.Close();
				IL_F7:
				num2 = 17;
				dataSet.Tables.Add(dataTable);
				IL_108:
				num2 = 18;
				dataSet.Relations.Add(O00OOOo_O0_O.b("ꃢ諤諦駨蓪菬諮鿰蟲", a_), dataTable.Columns[O00OOOo_O0_O.b("꣢胤黦", a_)], dataTable.Columns[O00OOOo_O0_O.b("돢蓤闦賨藪駬ꓮ铰諲", a_)]);
				IL_15A:
				num2 = 19;
				if (Conversions.ToInteger(this.o_0O.OO0_0_.[O00OOOo_O0_O.b("럢鳤韦賨", a_)]) == Conversions.ToInteger(dataTable.Rows[0][O00OOOo_O0_O.b("럢鳤韦賨", a_)]))
				{
					goto IL_1CF;
				}
				IL_1A2:
				num2 = 20;
				MessageBox.Show(O00OOOo_O0_O.b("璘ڷ鲚抿ᆕ⚞憪\udf83ᱳ沀ắ碛˽", a_), O00OOOo_O0_O.b("㎁\udf9d", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_8D5;
				IL_1CF:
				num2 = 22;
				if (dataTable.Rows.Count <= 1)
				{
					goto IL_430;
				}
				IL_1E4:
				num2 = 23;
				if (Conversions.ToInteger(dataTable.Rows[1][O00OOOo_O0_O.b("럢鳤韦賨", a_)]) != 250)
				{
					goto IL_430;
				}
				IL_216:
				num2 = 24;
				text = dataTable.Rows[1][O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)].ToString();
				IL_240:
				num2 = 25;
				string text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text.Substring(0, 5)).Substring(0, 5);
				IL_25F:
				num2 = 26;
				text = o0OO__.O.0ooOoO_0_.(text);
				IL_26B:
				num2 = 27;
				text = text.Substring(0, 6);
				IL_279:
				num2 = 28;
				dataTable.Rows.RemoveAt(1);
				IL_289:
				num2 = 29;
				DataRow dataRow = dataTable.Rows[0];
				IL_29B:
				num2 = 30;
				if (dataRow.IsNull(O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)))
				{
					goto IL_359;
				}
				IL_2B8:
				num2 = 31;
				string text3 = dataRow[O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)].ToString();
				IL_2D7:
				num2 = 32;
				if (!text3.StartsWith(O00OOOo_O0_O.b("飢", a_)) || !text3.EndsWith(O00OOOo_O0_O.b("黢", a_)))
				{
					goto IL_359;
				}
				IL_308:
				num2 = 33;
				text3 = text3.TrimStart(new char[]
				{
					'{'
				}).TrimEnd(new char[]
				{
					'}'
				});
				IL_32F:
				num2 = 34;
				text3 = O00.oO_.0o_oo_0O_.(text3, text2, text2);
				IL_33F:
				num2 = 35;
				dataRow[O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)] = text3;
				IL_359:
				num2 = 36;
				if (dataRow.IsNull(O00OOOo_O0_O.b("ꃢ諤菦賨", a_)))
				{
					goto IL_430;
				}
				IL_376:
				num2 = 37;
				string text4 = dataRow[O00OOOo_O0_O.b("ꃢ諤菦賨", a_)].ToString();
				IL_395:
				num2 = 38;
				if (!text4.StartsWith(O00OOOo_O0_O.b("飢", a_)) || !text4.EndsWith(O00OOOo_O0_O.b("黢", a_)))
				{
					goto IL_430;
				}
				IL_3C9:
				num2 = 39;
				text4 = text4.TrimStart(new char[]
				{
					'{'
				}).TrimEnd(new char[]
				{
					'}'
				});
				IL_3F0:
				num2 = 40;
				text4 = O00.oO_.0o_oo_0O_.(text4, text2, text2);
				IL_400:
				num2 = 41;
				text4 = O00.ooo000o_0.00o0.(text4, ooO0__OO.O_Oo00oO.Ooo.(), ooO0__OO.O_Oo00oO.Ooo.());
				IL_416:
				num2 = 42;
				dataRow[O00OOOo_O0_O.b("ꃢ諤菦賨", a_)] = text4;
				IL_430:
				num2 = 43;
				dataTable.Rows[0][O00OOOo_O0_O.b("꣢胤黦", a_)] = ShareLibriay.GetRandString(8);
				IL_459:
				num2 = 44;
				int num3 = dataTable.Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_474:
					num2 = 45;
					DataRow dataRow2 = dataTable.Rows[i];
					IL_487:
					num2 = 46;
					dataRow2[O00OOOo_O0_O.b("꣢胤黦", a_)] = ShareLibriay.GetRandString(8);
					IL_4A5:
					num2 = 47;
					if (Operators.CompareString(text, "", true) > 0 && !dataRow2.IsNull(O00OOOo_O0_O.b("ꃢ諤菦賨", a_)))
					{
						IL_4D5:
						num2 = 48;
						string text5 = dataRow2[O00OOOo_O0_O.b("胢諤菦賨", a_)].ToString();
						IL_4F4:
						num2 = 49;
						if (text5.StartsWith(O00OOOo_O0_O.b("飢", a_)) && text5.EndsWith(O00OOOo_O0_O.b("黢", a_)))
						{
							IL_52B:
							num2 = 50;
							text5 = text5.TrimStart(new char[]
							{
								'{'
							}).TrimEnd(new char[]
							{
								'}'
							});
							IL_552:
							num2 = 51;
							text5 = O00.oO_.0o_oo_0O_.(text5, ooO0__OO.O_Oo00oO.Ooo.(), text);
							IL_565:
							num2 = 52;
							text5 = O00OOOo_O0_O.b("飢", a_) + O00.ooo000o_0.00o0.(text5, ooO0__OO.O_Oo00oO.Ooo.(), Oo00.ooO.ooo.()) + O00OOOo_O0_O.b("黢", a_);
							IL_59C:
							num2 = 53;
							dataRow2[O00OOOo_O0_O.b("胢諤菦賨", a_)] = text5;
						}
					}
					IL_5B6:
					num2 = 54;
				}
				IL_5C8:
				num2 = 55;
				this.o_.000OOOoo.(base.Controls);
				IL_5D7:
				num2 = 56;
				this.OOOoO.Oo_O0o_0.();
				IL_5E0:
				num2 = 57;
				string value = this.o_0O.OO0_0_.[O00OOOo_O0_O.b("꣢胤黦", a_)].ToString();
				IL_603:
				num2 = 58;
				string value2 = this.o_0O.OO0_0_.[O00OOOo_O0_O.b("귢蓤諦賨", a_)].ToString();
				IL_626:
				num2 = 59;
				string value3 = this.o_0O.OO0_0_.[O00OOOo_O0_O.b("鏢釤迦", a_)].ToString();
				IL_649:
				num2 = 60;
				this.o_0O.OO0_0_..ItemArray = dataTable.Rows[0].ItemArray;
				IL_669:
				num2 = 61;
				int num4 = dataTable.Rows.Count - 1;
				for (int j = 1; j <= num4; j++)
				{
					IL_681:
					num2 = 62;
					DataRow dataRow3 = this.o_0O.OO0_0_..Table.NewRow();
					IL_696:
					num2 = 63;
					dataRow3.ItemArray = dataTable.Rows[j].ItemArray;
					IL_6B3:
					num2 = 64;
					this.o_0O.OO0_0_..Table.Rows.Add(dataRow3);
					IL_6CD:
					num2 = 65;
				}
				IL_6DC:
				num2 = 66;
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("꣢胤黦", a_)] = value;
				IL_6FA:
				num2 = 67;
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("귢蓤諦賨", a_)] = value2;
				IL_718:
				num2 = 68;
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("鏢釤迦", a_)] = value3;
				IL_736:
				num2 = 69;
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("럢蓤藦藨軪", a_)] = OO_00oOO.MainTable.Name;
				IL_75C:
				num2 = 70;
				if (this.o_0O.OO0_0_.[O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)] == DBNull.Value)
				{
					goto IL_7AD;
				}
				IL_77F:
				num2 = 71;
				o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., Conversions.ToString(this.o_0O.OO0_0_.[O00OOOo_O0_O.b("돢韤裦駨軪鿬鯮裰", a_)]), '\v');
				IL_7AD:
				num2 = 72;
				if (this.o_0O.OO0_0_.[O00OOOo_O0_O.b("ꃢ諤菦賨", a_)] == DBNull.Value)
				{
					goto IL_880;
				}
				IL_7D3:
				num2 = 73;
				string text6 = Conversions.ToString(this.o_0O.OO0_0_.[O00OOOo_O0_O.b("ꃢ諤菦賨", a_)]);
				IL_7F6:
				num2 = 74;
				string a_2 = ooO0__OO.O_Oo00oO.Ooo.();
				IL_800:
				num2 = 75;
				if (!text6.StartsWith(O00OOOo_O0_O.b("飢", a_)) || !text6.EndsWith(O00OOOo_O0_O.b("黢", a_)))
				{
					goto IL_862;
				}
				IL_831:
				num2 = 76;
				text6 = text6.TrimStart(new char[]
				{
					'{'
				}).TrimEnd(new char[]
				{
					'}'
				});
				IL_858:
				num2 = 77;
				a_2 = Oo00.ooO.ooo.();
				IL_862:
				num2 = 78;
				o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., O00.oO_.0o_oo_0O_.(text6, ooO0__OO.O_Oo00oO.Ooo.(), a_2), '\v');
				IL_880:
				num2 = 79;
				this.OO__oo0.0O___.(this.o_0O.OO0_0_., this);
				IL_890:
				num2 = 80;
				this.OOOoO.Oo_O0o_0.();
				IL_899:
				num2 = 81;
				o\u3000\u3002 o_u3000_u = (o\u3000\u3002)base.MdiParent;
				IL_8A9:
				num2 = 82;
				o_u3000_u.O0.0O00_O.().SelectedIndex = 0;
				IL_8B9:
				num2 = 83;
				o_u3000_u.OO_._oOo. = true;
				IL_8C4:
				o_u3000_u = null;
				IL_8C7:
				num2 = 85;
				this.o_0O.OO0_0_..Clear();
				IL_8D5:
				goto IL_A7F;
				IL_8DA:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_A40:
				goto IL_A74;
				IL_A42:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_A52:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A42;
			}
			IL_A74:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_A7F:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x001E5944 File Offset: 0x001E3B44
		internal void <<EMPTY_NAME>>()
		{
			int a_ = 16;
			base.AutoScrollPosition = new Point(0, 0);
			string text = o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., true, '\v', false);
			this.o_0O.OO0_0_.[O00OOOo_O0_O.b("ꏲ蟴飶觸黺迼课砀", a_)] = o_O_o_oOoo__.OOOO_OO._oo.(this.o_0O.OO0_0_., false, '\v', false);
			if (Operators.CompareString(text, "", true) > 0)
			{
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("냲髴鏶鳸", a_)] = O00OOOo_O0_O.b("裲", a_) + O00.ooo000o_0.00o0.(text, ooO0__OO.O_Oo00oO.Ooo.(), Oo00.ooO.ooo.()) + O00OOOo_O0_O.b("軲", a_);
			}
			else
			{
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("냲髴鏶鳸", a_)] = null;
			}
			this.o_0O.OO0_0_.[O00OOOo_O0_O.b("ꟲ铴闶闸黺", a_)] = this.o_0O.OO0_0_..TablName;
			this.o_0O.OO0_0_.[O00OOOo_O0_O.b("닲胴菶雸듺跼髾漀", a_)] = this.o_0O.OO0_0_..AutoOpen;
			try
			{
				foreach (object obj in base.Controls)
				{
					Control control = (Control)obj;
					if (control is ControlHolder)
					{
						((ControlHolder)control).oO_O.0O__o.();
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			DataRow[] array = this.o_0O.OO0_0_..Table.Select(O00OOOo_O0_O.b("럲郴鯶鳸迺飼\udffe㰀⌂億甆簈渊", a_), "", DataViewRowState.CurrentRows);
			for (int i = array.Length - 1; i >= 0; i += -1)
			{
				DataRow dataRow = array[i];
				if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached && dataRow[O00OOOo_O0_O.b("럲郴鯶鳸迺飼", a_)] != DBNull.Value && Conversions.ToBoolean(dataRow[O00OOOo_O0_O.b("럲郴鯶鳸迺飼", a_)]))
				{
					dataRow.Delete();
				}
			}
			DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("룲郴軶", a_)].ToString(),
				o0_O.o_.0oO_0o000.
			});
			if (dataRow2 != null)
			{
				dataRow2[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = "";
				Oo00.O0Oo_O.0O_0O.(dataRow2);
			}
			string oo_._oOo. = ((o\u3000\u3002)base.MdiParent).OO_._oOo.;
			DataRow dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				this.o_0O.OO0_0_.[O00OOOo_O0_O.b("룲郴軶", a_)].ToString(),
				o0_O.oo0_.O0Oo_o.
			});
			if (dataRow3 == null)
			{
				if (Operators.CompareString(oo_._oOo., "", true) > 0)
				{
					dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
					dataRow3[O00OOOo_O0_O.b("뷲铴髶鳸", a_)] = this.o_0O.OO0_0_.[O00OOOo_O0_O.b("룲郴軶", a_)].ToString();
					dataRow3[O00OOOo_O0_O.b("ꟲ賴蟶鳸", a_)] = o0_O.oo0_.O0Oo_o.;
					dataRow3[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = oo_._oOo.;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow3);
				}
			}
			else
			{
				dataRow3[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = oo_._oOo.;
			}
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x001E5D18 File Offset: 0x001E3F18
		internal void <<EMPTY_NAME>>(string A_0)
		{
			O___O_ o___O_ = new O___O_(A_0);
			this.oooo_._O.(base.Controls, o___O_);
			if (o___O_.Oo._o.() > 0)
			{
				this.o_0O.OO0_0_..Add(o___O_);
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x001E5D50 File Offset: 0x001E3F50
		internal void <<EMPTY_NAME>>(Control.ControlCollection A_0, O___O_ A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					Control control = (Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Selected)
						{
							A_1.o_0_.Oo.(this.O0o._0.[controlHolder.Key]);
						}
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							this.oooo_._O.(controlHolder.ChildControl.Controls, A_1);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							this.oooo_._O.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1);
						}
						else
						{
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								try
								{
									foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
									{
										O_O_ o_O_ = (O_O_)obj2;
										this.oooo_._O.(o_O_.Controls, A_1);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								try
								{
									foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
									{
										oO_0 oO_ = (oO_0)obj3;
										this.oooo_._O.(oO_.Controls, A_1);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								this.oooo_._O.(o0000O.oo0oO_O.oooO0O.().Controls, A_1);
								this.oooo_._O.(o0000O.o.Oo0oo000O.().Controls, A_1);
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x001E5F88 File Offset: 0x001E4188
		internal O___O_ <<EMPTY_NAME>>(string A_0)
		{
			O___O_ o___O_ = new O___O_(A_0);
			this.oooo_._O.(base.Controls, o___O_);
			O___O_ result;
			if (o___O_.Oo._o.() > 0)
			{
				result = o___O_;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x001E5FBC File Offset: 0x001E41BC
		internal void <<EMPTY_NAME>>()
		{
			if (this.o_0O.OO0_0_..Count > 0)
			{
				if (!(this.o_0O.OO0_0_.[this.o_0O.OO0_0_..Count - 1] is oO0_))
				{
					oOO0oo_o0.o0.Oo__.(base.Controls);
				}
				this.o_0O.OO0_0_.[this.o_0O.OO0_0_..Count - 1].O_OO0.O.();
				this.o_0O.OO0_0_..RemoveAt(this.o_0O.OO0_0_..Count - 1);
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x001E6038 File Offset: 0x001E4238
		internal void <<EMPTY_NAME>>()
		{
			ooo_0o ooo_0o = new ooo_0o();
			this.o_.000OOOoo.(base.Controls, ref ooo_0o, false);
			if (ooo_0o.ooO_O.O_O.() > 0)
			{
				this.o_0O.OO0_0_..Add(ooo_0o);
				this.OOOoO.Oo_O0o_0.();
			}
			((o\u3000\u3002)base.MdiParent).O0.0O00_O.().SelectedIndex = 0;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x001E608C File Offset: 0x001E428C
		internal void <<EMPTY_NAME>>(Control.ControlCollection A_0, ref ooo_0o A_1, bool A_2)
		{
			int a_ = 18;
			int num;
			int num4;
			object obj3;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				for (int i = A_0.Count - 1; i >= 0; i += -1)
				{
					IL_21:
					num2 = 3;
					Control control = A_0[i];
					IL_2C:
					num2 = 4;
					if (control is ControlHolder)
					{
						IL_39:
						num2 = 5;
						ControlHolder controlHolder = (ControlHolder)control;
						IL_43:
						num2 = 6;
						bool a_2;
						if (controlHolder.Selected || A_2)
						{
							IL_51:
							num2 = 7;
							a_2 = true;
						}
						else
						{
							IL_58:
							num2 = 9;
							a_2 = false;
						}
						IL_5E:
						num2 = 10;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							IL_92:
							num2 = 11;
							this.o_.000OOOoo.(controlHolder.ChildControl.Controls, ref A_1, a_2);
						}
						else
						{
							IL_AF:
							num2 = 13;
							if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
							{
								IL_BD:
								num2 = 14;
								this.o_.000OOOoo.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, ref A_1, a_2);
							}
							else
							{
								IL_E4:
								num2 = 16;
								if (controlHolder.ControlType == ControlTypeEnum.TabControl)
								{
									IL_F2:
									num2 = 17;
									IEnumerator enumerator = ((C1DockingTab)controlHolder.ChildControl).TabPages.GetEnumerator();
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										O_O_ o_O_ = (O_O_)obj;
										IL_11D:
										num2 = 18;
										this.o_.000OOOoo.(o_O_.Controls, ref A_1, a_2);
										IL_130:
										num2 = 19;
									}
									IL_13C:
									num2 = 20;
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								else
								{
									IL_15C:
									num2 = 22;
									if (controlHolder.ControlType == ControlTypeEnum.NavBar)
									{
										IL_16A:
										num2 = 23;
										IEnumerator enumerator2 = ((C1NavBar)controlHolder.ChildControl).Panels.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											object obj2 = enumerator2.Current;
											oO_0 oO_ = (oO_0)obj2;
											IL_195:
											num2 = 24;
											this.o_.000OOOoo.(oO_.Controls, ref A_1, a_2);
											IL_1A8:
											num2 = 25;
										}
										IL_1B4:
										num2 = 26;
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
									else
									{
										IL_1CE:
										num2 = 28;
										if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
										{
											IL_1DC:
											num2 = 29;
											o0000O o0000O = (o0000O)controlHolder.ChildControl;
											IL_1ED:
											num2 = 30;
											this.o_.000OOOoo.(o0000O.oo0oO_O.oooO0O.().Controls, ref A_1, a_2);
											IL_205:
											num2 = 31;
											this.o_.000OOOoo.(o0000O.o.Oo0oo000O.().Controls, ref A_1, a_2);
											IL_21D:
											o0000O = null;
										}
									}
								}
							}
						}
						IL_220:
						num2 = 33;
						if (controlHolder.Selected || A_2)
						{
							IL_232:
							num2 = 34;
							controlHolder.Selected = false;
							IL_23D:
							num2 = 35;
							controlHolder.DataRow[O00OOOo_O0_O.b("뇴鋶闸黺觼髾", a_)] = true;
							IL_260:
							num2 = 36;
							A_1.ooO_O.O_O.((ControlHolder)control);
							IL_270:
							num2 = 37;
							this.O0o._0..Remove((ControlHolder)control);
							IL_285:
							num2 = 38;
							this.O0o._0..Remove(controlHolder.Key);
							IL_29B:
							num2 = 39;
							this.o_0O.OO0_0_..Remove(controlHolder.Key);
							IL_2B1:
							num2 = 40;
							this.ooOOOO.0o..Remove(controlHolder.Key);
							IL_2C7:
							num2 = 41;
							A_0.Remove(control);
						}
						IL_2D1:
						controlHolder = null;
					}
					IL_2D4:
					num2 = 43;
				}
				IL_2E5:
				goto IL_3E7;
				IL_2EA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3A8:
				goto IL_3DC;
				IL_3AA:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3BA:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_3AA;
			}
			IL_3DC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3E7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x001E64A4 File Offset: 0x001E46A4
		private void <<EMPTY_NAME>>(Control.ControlCollection A_0)
		{
			int num;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				for (int i = A_0.Count - 1; i >= 0; i += -1)
				{
					IL_18:
					num2 = 3;
					Control control = A_0[i];
					IL_23:
					num2 = 4;
					if (control is ControlHolder)
					{
						IL_30:
						num2 = 5;
						ControlHolder controlHolder = (ControlHolder)control;
						IL_3A:
						num2 = 6;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							IL_6D:
							num2 = 7;
							this.o_.000OOOoo.(controlHolder.ChildControl.Controls);
						}
						else
						{
							IL_86:
							num2 = 9;
							if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
							{
								IL_94:
								num2 = 10;
								this.o_.000OOOoo.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls);
							}
							else
							{
								IL_B8:
								num2 = 12;
								if (controlHolder.ControlType == ControlTypeEnum.TabControl)
								{
									IL_C6:
									num2 = 13;
									IEnumerator enumerator = ((C1DockingTab)controlHolder.ChildControl).TabPages.GetEnumerator();
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										O_O_ o_O_ = (O_O_)obj;
										IL_F1:
										num2 = 14;
										this.o_.000OOOoo.(o_O_.Controls);
										IL_101:
										num2 = 15;
									}
									IL_10D:
									num2 = 16;
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								else
								{
									IL_12D:
									num2 = 18;
									if (controlHolder.ControlType == ControlTypeEnum.NavBar)
									{
										IL_13B:
										num2 = 19;
										IEnumerator enumerator2 = ((C1NavBar)controlHolder.ChildControl).Panels.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											object obj2 = enumerator2.Current;
											oO_0 oO_ = (oO_0)obj2;
											IL_166:
											num2 = 20;
											this.o_.000OOOoo.(oO_.Controls);
											IL_176:
											num2 = 21;
										}
										IL_182:
										num2 = 22;
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
									else
									{
										IL_19C:
										num2 = 24;
										if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
										{
											IL_1AA:
											num2 = 25;
											o0000O o0000O = (o0000O)controlHolder.ChildControl;
											IL_1BB:
											num2 = 26;
											this.o_.000OOOoo.(o0000O.oo0oO_O.oooO0O.().Controls);
											IL_1D0:
											num2 = 27;
											this.o_.000OOOoo.(o0000O.o.Oo0oo000O.().Controls);
											IL_1E5:
											o0000O = null;
										}
									}
								}
							}
						}
						IL_1E8:
						num2 = 29;
						if (controlHolder.Selected)
						{
							IL_1F4:
							num2 = 30;
							controlHolder.Selected = false;
						}
						IL_1FF:
						num2 = 31;
						if (controlHolder.DataRow.RowState != DataRowState.Deleted)
						{
							IL_211:
							num2 = 32;
							controlHolder.DataRow.Delete();
						}
						IL_220:
						num2 = 33;
						this.O0o._0..Remove((ControlHolder)control);
						IL_235:
						num2 = 34;
						this.O0o._0..Remove(controlHolder.Key);
						IL_24B:
						num2 = 35;
						this.o_0O.OO0_0_..Remove(controlHolder.Key);
						IL_261:
						num2 = 36;
						this.ooOOOO.0o..Remove(controlHolder.Key);
						IL_277:
						num2 = 37;
						A_0.Remove(control);
						IL_281:
						controlHolder = null;
					}
					IL_284:
					num2 = 39;
				}
				IL_295:
				goto IL_387;
				IL_29A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_348:
				goto IL_37C;
				IL_34A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_35A:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_34A;
			}
			IL_37C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_387:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x001E685C File Offset: 0x001E4A5C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int a_ = 1;
			this.O0o._0. = new O0oOO_(O00OOOo_O0_O.b("럣迥鋧迩", a_), this.o_0O.OO0_0_.);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x001E6891 File Offset: 0x001E4A91
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0o._0. != null)
			{
				this.o_0O.OO0_0_..Add(this.O0o._0.);
				this.O0o._0. = null;
				((o\u3000\u3002)base.MdiParent).O0.0O00_O.().Refresh();
			}
		}

		// Token: 0x04001B05 RID: 6917
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001B06 RID: 6918
		internal DataRow <<EMPTY_NAME>>;

		// Token: 0x04001B07 RID: 6919
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001B08 RID: 6920
		private Point <<EMPTY_NAME>>;

		// Token: 0x04001B09 RID: 6921
		private Rectangle <<EMPTY_NAME>>;

		// Token: 0x04001B0A RID: 6922
		private List<o\u3002\u3002\u3000\u3000\u3002.o_O> <<EMPTY_NAME>>;

		// Token: 0x04001B0B RID: 6923
		private Rectangle <<EMPTY_NAME>>;

		// Token: 0x04001B0C RID: 6924
		private int <<EMPTY_NAME>>;

		// Token: 0x04001B0D RID: 6925
		private int <<EMPTY_NAME>>;

		// Token: 0x04001B0E RID: 6926
		internal List<ControlHolder> <<EMPTY_NAME>>;

		// Token: 0x04001B0F RID: 6927
		internal Dictionary<string, object> <<EMPTY_NAME>>;

		// Token: 0x04001B10 RID: 6928
		internal Dictionary<string, object> <<EMPTY_NAME>>;

		// Token: 0x04001B11 RID: 6929
		internal Dictionary<string, PropertyBase> <<EMPTY_NAME>>;

		// Token: 0x04001B12 RID: 6930
		internal FormProperty <<EMPTY_NAME>>;

		// Token: 0x04001B13 RID: 6931
		internal List<O_o_0o> <<EMPTY_NAME>>;

		// Token: 0x04001B14 RID: 6932
		internal List<ControlHolder> <<EMPTY_NAME>>;

		// Token: 0x04001B15 RID: 6933
		private O0oOO_ <<EMPTY_NAME>>;

		// Token: 0x04001B16 RID: 6934
		private string <<EMPTY_NAME>>;

		// Token: 0x04001B17 RID: 6935
		private string <<EMPTY_NAME>>;

		// Token: 0x04001B18 RID: 6936
		private o0OoOOoOOo0.Oo000OOooOO0O <<EMPTY_NAME>>;

		// Token: 0x04001B19 RID: 6937
		private static bool <<EMPTY_NAME>> = false;

		// Token: 0x04001B1A RID: 6938
		private int <<EMPTY_NAME>>;

		// Token: 0x02000401 RID: 1025
		private struct o_O
		{
			// Token: 0x06004204 RID: 16900 RVA: 0x001E68C8 File Offset: 0x001E4AC8
			internal o_O(int A_0, int A_1, int A_2)
			{
				this = default(o\u3002\u3002\u3000\u3000\u3002.o_O);
				this.O.00OO00_oo. = A_0;
				this.O0oOOo_o_O.O_O. = A_1;
				this.o.oo_OOO. = A_2;
			}

			// Token: 0x04001B1B RID: 6939
			internal int <<EMPTY_NAME>>;

			// Token: 0x04001B1C RID: 6940
			internal int <<EMPTY_NAME>>;

			// Token: 0x04001B1D RID: 6941
			internal int <<EMPTY_NAME>>;
		}
	}
}
