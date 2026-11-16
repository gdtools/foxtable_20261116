using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000089 RID: 137
	internal class o_O0_0O0 : C1CommandDock
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x0002160B File Offset: 0x0001F80B
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.oO.O_0_.;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00021614 File Offset: 0x0001F814
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.OoOoo_O0o0.0O_.);
			Timer timer = this.oO.O_0_.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.oO.O_0_. = A_0;
			timer = this.oO.O_0_.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00021658 File Offset: 0x0001F858
		public void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				foreach (object obj in base.Controls)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is OO___OO0O_0)
					{
						((C1DockingTab)control).AutoHiding = A_0;
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

		// Token: 0x060004F4 RID: 1268 RVA: 0x000216C4 File Offset: 0x0001F8C4
		internal void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			base.SuspendLayout();
			System.Windows.Forms.Control control = A_0;
			do
			{
				control = control.Parent;
				if (control == null)
				{
					goto IL_32;
				}
			}
			while (!(control is C1DockingTabPage));
			C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)control;
			((OO___OO0O_0)c1DockingTabPage.Parent).Close(c1DockingTabPage);
			IL_32:
			if (A_0.Parent != null && control.Parent == null)
			{
				A_0.Parent.Controls.Remove(A_0);
			}
			base.ResumeLayout();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002172C File Offset: 0x0001F92C
		internal int <<EMPTY_NAME>>()
		{
			DockStyle dock = this.Dock;
			int num;
			if (dock - DockStyle.Top > 1)
			{
				if (dock - DockStyle.Left <= 1)
				{
					num = base.Size.Width;
				}
			}
			else
			{
				num = base.Size.Height;
			}
			if (num >= 60)
			{
				this.oO.O_0_. = num;
			}
			return this.oO.O_0_.;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002177E File Offset: 0x0001F97E
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.oO.O_0_. = A_0;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00021788 File Offset: 0x0001F988
		internal string <<EMPTY_NAME>>()
		{
			OO___OO0O_0 oo___OO0O_ = null;
			string text = "";
			try
			{
				foreach (object obj in base.Controls)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is OO___OO0O_0 && Operators.CompareString(control.Tag.ToString(), "Shared", true) == 0)
					{
						oo___OO0O_ = (OO___OO0O_0)control;
						break;
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
			if (oo___OO0O_ != null)
			{
				try
				{
					foreach (object obj2 in oo___OO0O_.TabPages)
					{
						C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj2;
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\t";
						}
						text += c1DockingTabPage.Text;
					}
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
			return text;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00021888 File Offset: 0x0001FA88
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.oO.O_0_. = A_0;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00021894 File Offset: 0x0001FA94
		internal void <<EMPTY_NAME>>()
		{
			OO___OO0O_0 oo___OO0O_ = null;
			if (Operators.CompareString(this.oO.O_0_., "", true) != 0)
			{
				List<string> list = new List<string>();
				list.AddRange(this.oO.O_0_..Split(new char[]
				{
					'\t'
				}));
				try
				{
					foreach (object obj in base.Controls)
					{
						System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
						if (control is OO___OO0O_0 && Operators.CompareString(control.Tag.ToString(), "Shared", true) == 0)
						{
							oo___OO0O_ = (OO___OO0O_0)control;
							break;
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
				if (oo___OO0O_ != null)
				{
					List<C1DockingTabPage> list2 = new List<C1DockingTabPage>();
					try
					{
						foreach (string right in list)
						{
							try
							{
								foreach (object obj2 in oo___OO0O_.TabPages)
								{
									C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj2;
									if (Operators.CompareString(c1DockingTabPage.Text, right, true) == 0 && !list2.Contains(c1DockingTabPage))
									{
										list2.Add(c1DockingTabPage);
									}
								}
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
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (list2.Count > 0)
					{
						int num = 0;
						try
						{
							foreach (C1DockingTabPage value in list2)
							{
								oo___OO0O_.TabPages.Insert(num, value);
								num++;
							}
						}
						finally
						{
							List<C1DockingTabPage>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00021A5C File Offset: 0x0001FC5C
		internal C1DockingTabPage <<EMPTY_NAME>>(System.Windows.Forms.Control A_0, string A_1, bool A_2, Image A_3, DataCol A_4 = null, bool A_5 = true)
		{
			this.OoOoo_O0o0.0O_.();
			A_0.Dock = DockStyle.Fill;
			base.SuspendLayout();
			C1DockingTabPage c1DockingTabPage = new C1DockingTabPage();
			if (A_2)
			{
				OO___OO0O_0 oo___OO0O_ = this.OO_o0_oO.0.();
				oo___OO0O_.Tag = "tile";
				oo___OO0O_.Visible = false;
				c1DockingTabPage.Text = A_1;
				c1DockingTabPage.CaptionText = A_1;
				c1DockingTabPage.TabVisible = A_5;
				base.Controls.Add(oo___OO0O_);
				oo___OO0O_.TabPages.Add(c1DockingTabPage);
				c1DockingTabPage.Controls.Add(A_0);
				oo___OO0O_.o0.oOO_O.(c1DockingTabPage);
				oo___OO0O_.Visible = A_5;
				if (A_0 is FormPanel)
				{
					oo___OO0O_.AutoHiding = OO_00oOO.Forms[A_0.Name].AutoHide;
					OO_00oOO.Forms[A_0.Name].O_0.O00o_00_O. = oo___OO0O_;
				}
				else if (A_4 != null)
				{
					oo___OO0O_.AutoHiding = A_4.AutoHide;
				}
			}
			else
			{
				OO___OO0O_0 oo___OO0O_2 = null;
				try
				{
					foreach (object obj in base.Controls)
					{
						System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
						if (control is OO___OO0O_0 && Operators.CompareString(control.Tag.ToString(), "Shared", true) == 0)
						{
							oo___OO0O_2 = (OO___OO0O_0)control;
							break;
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
				if (oo___OO0O_2 == null)
				{
					oo___OO0O_2 = this.OO_o0_oO.0.();
					oo___OO0O_2.Tag = "Shared";
					oo___OO0O_2.Visible = false;
					base.Controls.Add(oo___OO0O_2);
				}
				c1DockingTabPage.Text = A_1;
				c1DockingTabPage.CaptionText = A_1;
				c1DockingTabPage.TabVisible = A_5;
				if (O_O0OO.O0_00o.o0__o..ShowTableIcon)
				{
					c1DockingTabPage.Image = A_3;
				}
				oo___OO0O_2.TabPages.Add(c1DockingTabPage);
				c1DockingTabPage.Controls.Add(A_0);
				oo___OO0O_2.o0.oOO_O.(c1DockingTabPage);
				oo___OO0O_2.Visible = A_5;
				if (A_0 is FormPanel)
				{
					oo___OO0O_2.AutoHiding = OO_00oOO.Forms[A_0.Name].AutoHide;
					OO_00oOO.Forms[A_0.Name].O_0.O00o_00_O. = oo___OO0O_2;
				}
				else if (A_4 != null)
				{
					oo___OO0O_2.AutoHiding = A_4.AutoHide;
				}
			}
			base.ResumeLayout();
			return c1DockingTabPage;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00021C88 File Offset: 0x0001FE88
		internal void <<EMPTY_NAME>>(Table A_0, bool A_1)
		{
			this.OoOoo_O0o0.0O_.();
			A_0.foxGrid.Dock = DockStyle.Fill;
			if (A_1)
			{
				OO___OO0O_0 oo___OO0O_ = this.OO_o0_oO.0.();
				OO0_O_0O oo0_O_0O = new OO0_O_0O(A_0);
				oo0_O_0O.TabVisible = false;
				oo___OO0O_.TabPages.Add(oo0_O_0O);
				oo___OO0O_.Tag = "tile";
				base.Controls.Add(oo___OO0O_);
				A_0.oO_o_0o._0oooo.(true);
				oo___OO0O_.AutoHiding = A_0._frdAutoHide;
				oo___OO0O_.ShowCaption = A_0._frdShowCaption;
				oo___OO0O_.CanCloseTabs = A_0._frdAllowClose;
				oo0_O_0O.TabVisible = true;
				return;
			}
			OO___OO0O_0 oo___OO0O_2 = null;
			OO0_O_0O oo0_O_0O2 = new OO0_O_0O(A_0);
			try
			{
				foreach (object obj in base.Controls)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is OO___OO0O_0 && Operators.CompareString(control.Tag.ToString(), "Shared", true) == 0)
					{
						oo___OO0O_2 = (OO___OO0O_0)control;
						break;
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
			if (oo___OO0O_2 == null)
			{
				oo___OO0O_2 = this.OO_o0_oO.0.();
				oo___OO0O_2.Tag = "Shared";
				base.Controls.Add(oo___OO0O_2);
			}
			if (O_O0OO.O0_00o.o0__o..ShowTableIcon)
			{
				oo0_O_0O2.Image = A_0._frdIcon;
			}
			oo0_O_0O2.TabVisible = false;
			oo___OO0O_2.TabPages.Add(oo0_O_0O2);
			A_0.oO_o_0o._0oooo.(true);
			oo___OO0O_2.AutoHiding = A_0._frdAutoHide;
			oo___OO0O_2.ShowCaption = A_0._frdShowCaption;
			oo___OO0O_2.CanCloseTabs = A_0._frdAllowClose;
			oo0_O_0O2.TabVisible = true;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00021E18 File Offset: 0x00020018
		internal o_O0_0O0(DockStyle A_0)
		{
			base.ControlAdded += this.OO_o0_oO.0.;
			this.OoOoo_O0o0.0O_.(new Timer());
			this.Dock = A_0;
			base.AllowFloat = false;
			base.AutoDockLeft = false;
			base.AutoDockRight = false;
			base.AutoDockTop = false;
			base.AutoDockBottom = false;
			this.OoOoo_O0o0.0O_.().Interval = 10;
			this.OoOoo_O0o0.0O_.().Enabled = false;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00021E8C File Offset: 0x0002008C
		private OO___OO0O_0 <<EMPTY_NAME>>()
		{
			OO___OO0O_0 oo___OO0O_ = new OO___OO0O_0();
			oo___OO0O_.Alignment = TabAlignment.Bottom;
			if (this.Dock == DockStyle.Left | this.Dock == DockStyle.Right)
			{
				oo___OO0O_.AlignTabs = StringAlignment.Near;
			}
			else
			{
				oo___OO0O_.AlignTabs = StringAlignment.Far;
			}
			oo___OO0O_.BorderStyle = BorderStyle.None;
			oo___OO0O_.CanCloseTabs = true;
			oo___OO0O_.CanAutoHide = true;
			oo___OO0O_.ShowCaption = true;
			oo___OO0O_.TabSizeMode = TabSizeModeEnum.Fit;
			oo___OO0O_.CanMoveTabs = true;
			oo___OO0O_.ShowSingleTab = false;
			oo___OO0O_.TabsSpacing = 0;
			oo___OO0O_.Indent = 0;
			oo___OO0O_.ShowTabList = false;
			oo___OO0O_.MultiLine = true;
			oo___OO0O_.GotFocus += this.OoOo.O__0.;
			oo___OO0O_.TabPageClosed += this.oO.O_0_.;
			oo___OO0O_.TabPageClosing += this.oO.O_0_.;
			oo___OO0O_.Tag = "";
			this.OoOoo_O0o0.0O_.(oo___OO0O_);
			return oo___OO0O_;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00021F64 File Offset: 0x00020164
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO___OO0O_0 oo___OO0O_ = (OO___OO0O_0)A_0;
			if (oo___OO0O_.SelectedTab != null)
			{
				oo___OO0O_.SelectedTab.Focus();
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00021F90 File Offset: 0x00020190
		private void <<EMPTY_NAME>>(object A_0, TabPageEventArgs A_1)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				OO___OO0O_0 oo___OO0O_ = (OO___OO0O_0)A_0;
				IL_09:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_10:
				num = 3;
				A_1.TabPage.Controls.Clear();
				IL_22:
				num = 4;
				A_1.TabPage.Dispose();
				IL_2F:
				num = 5;
				if (oo___OO0O_.TabPages.Count != 0)
				{
					goto IL_4C;
				}
				IL_3E:
				num = 6;
				this.OoOoo_O0o0.0O_.().Enabled = true;
				IL_4C:
				goto IL_B7;
				IL_4E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_78:
				goto IL_AC;
				IL_7A:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_8A:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7A;
			}
			IL_AC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002206C File Offset: 0x0002026C
		private void <<EMPTY_NAME>>(object A_0, TabPageCancelEventArgs A_1)
		{
			C1DockingTabPage tabPage = A_1.TabPage;
			if (((C1DockingTab)A_0).TabPages.Count == 1)
			{
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						dataTable.frd_RightDockSize = dataTable.frd_RightDockSize;
						dataTable.frd_LeftDockSize = dataTable.frd_LeftDockSize;
						dataTable.frd_BottomDockSize = dataTable.frd_BottomDockSize;
						dataTable.frd_TopDockSize = dataTable.frd_TopDockSize;
					}
				}
				finally
				{
					IEnumerator<DataTable> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			if (tabPage != null)
			{
				System.Windows.Forms.Control control = ooO.o.O_0000_O.(tabPage.Controls);
				if (control != null && control.DataBindings.Count > 0)
				{
					control.DataBindings[0].WriteValue();
				}
				if (tabPage.Controls.Count == 1)
				{
					control = tabPage.Controls[0];
					if (control is FormPanel)
					{
						try
						{
							foreach (DataTable dataTable2 in OO_00oOO.DataTables)
							{
								if (dataTable2.Name.ToLower().StartsWith(control.Name.ToLower() + "_") && dataTable2.o00o.00oO___0.)
								{
									MessageBox.Show("正在加载数据的过程中，暂不能关闭窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									A_1.Cancel = true;
									return;
								}
							}
						}
						finally
						{
							IEnumerator<DataTable> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						Foxtable.WinForm.Form form = OO_00oOO.Forms[control.Name];
						FormEventArgs formEventArgs = new FormEventArgs(OO_00oOO.Forms[control.Name]);
						string a_ = "BeforeClose_" + Conversions.ToString(form.O_o_.0o0__o0O.["Key"]);
						O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[control.Name].O_0.O00o_00_O., a_, new object[]
						{
							formEventArgs
						}, false, form.Name, false);
						if (form.O_0.O00o_00_O.)
						{
							A_1.Cancel = formEventArgs.Cancel;
						}
						if (!A_1.Cancel)
						{
							form.oOO0OO0O.o0oO.();
							form.OoOO_._0.();
						}
						return;
					}
					if (control is OooOo0___oO)
					{
						OooOo0___oO oooOo0___oO = (OooOo0___oO)control;
						if (oooOo0___oO.Editor != null && !oooOo0___oO.FinishEditing())
						{
							oooOo0___oO.FinishEditing(true);
						}
						oooOo0___oO.O_._0o00_.();
						return;
					}
					if (control is PictureViewer)
					{
						((PictureViewer)control).ImageFiles = "";
						return;
					}
					if (control is o_o0ooOooO)
					{
						((o_o0ooOooO)control).Nodes.Clear();
						control.Dispose();
						return;
					}
					if (control is oo__)
					{
						((oo__)control).Nodes.Clear();
						control.Dispose();
						return;
					}
					if (control is oO_oo0Oo)
					{
						((oO_oo0Oo)control).Nodes.Clear();
						control.Dispose();
						return;
					}
					if (control is o_0)
					{
						((o_0)control).OOOO_.o.().Nodes.Clear();
						control.Controls.Clear();
						control.Dispose();
					}
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00022364 File Offset: 0x00020564
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() != null)
			{
				this.OoOoo_O0o0.0O_.();
			}
			this.OoOoo_O0o0.0O_.().Enabled = false;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00022380 File Offset: 0x00020580
		private void <<EMPTY_NAME>>()
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
				IEnumerator enumerator = base.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					IL_27:
					num2 = 3;
					if (control is C1DockingTab)
					{
						IL_32:
						num2 = 4;
						C1DockingTab c1DockingTab = (C1DockingTab)control;
						IL_3D:
						num2 = 5;
						if (c1DockingTab.TabPages.Count == 0)
						{
							IL_4D:
							num2 = 6;
							c1DockingTab.GotFocus -= this.OoOo.O__0.;
							IL_62:
							num2 = 7;
							c1DockingTab.TabPageClosed -= this.oO.O_0_.;
							IL_77:
							num2 = 8;
							c1DockingTab.TabPageClosing -= this.oO.O_0_.;
							IL_8C:
							num2 = 9;
							base.Controls.Remove(control);
							IL_9C:
							num2 = 10;
							control.Dispose();
						}
						IL_A6:
						c1DockingTab = null;
					}
					IL_A9:
					num2 = 12;
				}
				IL_B7:
				num2 = 13;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_CD:
				goto IL_157;
				IL_D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_118:
				goto IL_14C;
				IL_11A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_12A:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_11A;
			}
			IL_14C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_157:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00022508 File Offset: 0x00020708
		private void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			if (this.oO.O_0_. != 0)
			{
				DockStyle dock = this.Dock;
				if (dock - DockStyle.Top > 1)
				{
					if (dock - DockStyle.Left <= 1)
					{
						A_0.Width = Math.Max(60, Math.Min(this.oO.O_0_., Main.OO_O.o..OO_O_0Oo.___o.().Width - 300));
						return;
					}
				}
				else
				{
					A_0.Height = Math.Max(60, Math.Min(this.oO.O_0_., Main.OO_O.o..OO_O_0Oo.___o.().Height - 200));
				}
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002258C File Offset: 0x0002078C
		private void <<EMPTY_NAME>>(object A_0, ControlEventArgs A_1)
		{
			for (int i = base.Controls.Count - 1; i >= 0; i += -1)
			{
				if (this.Dock == DockStyle.Right | this.Dock == DockStyle.Left)
				{
					((C1DockingTab)base.Controls[i]).Height = base.ClientRectangle.Height / base.Controls.Count;
				}
				else
				{
					((C1DockingTab)base.Controls[i]).Width = base.ClientRectangle.Width / base.Controls.Count;
				}
			}
		}

		// Token: 0x04000147 RID: 327
		private string <<EMPTY_NAME>>;

		// Token: 0x04000148 RID: 328
		private int <<EMPTY_NAME>>;

		// Token: 0x04000149 RID: 329
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400014A RID: 330
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;
	}
}
