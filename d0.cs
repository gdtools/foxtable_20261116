using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002EC RID: 748
	[DesignerGenerated]
	internal partial class d0 : Form
	{
		// Token: 0x060028E2 RID: 10466 RVA: 0x00126744 File Offset: 0x00124944
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O00_._. != null)
				{
					this.O00_._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00126784 File Offset: 0x00124984
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(d0));
			this.o_0O._O_O.(new C1Button());
			this.oO_0oO.oo_.(new C1FlexGrid());
			this.oO_0oO.oo_.(new C1Button());
			this.O00_._.(new C1TextBox());
			this.O00_._.(new Label());
			this.oO_0oO.oo_.(new C1ComboBox());
			((ISupportInitialize)this.O.__OO.()).BeginInit();
			base.SuspendLayout();
			this.oo0.oo.().Location = new Point(475, 468);
			this.oo0.oo.().Name = "btnCancel";
			this.oo0.oo.().Size = new Size(75, 23);
			this.oo0.oo.().TabIndex = 12;
			this.oo0.oo.().Text = "取消";
			this.oo0.oo.().UseVisualStyleBackColor = true;
			this.O.__OO.().AllowDragging = AllowDraggingEnum.None;
			this.O.__OO.().AllowEditing = false;
			this.O.__OO.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O.__OO.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.O.__OO.().ExtendLastCol = true;
			this.O.__OO.().FocusRect = FocusRectEnum.None;
			this.O.__OO.().Location = new Point(11, 37);
			this.O.__OO.().Name = "C1FlexGrid1";
			this.O.__OO.().Rows.Count = 2;
			this.O.__OO.().Rows.DefaultSize = 19;
			this.O.__OO.().SelectionMode = SelectionModeEnum.ListBox;
			this.O.__OO.().Size = new Size(538, 328);
			this.O.__OO.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.O.__OO.().TabIndex = 7;
			this.O.__OO.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.O.__OO.().Location = new Point(394, 468);
			this.O.__OO.().Name = "btnOK";
			this.O.__OO.().Size = new Size(75, 23);
			this.O.__OO.().TabIndex = 13;
			this.O.__OO.().Text = "确定";
			this.O.__OO.().UseVisualStyleBackColor = true;
			this.oO_0oO.oo_.().ForeColor = Color.Blue;
			this.oO_0oO.oo_.().Location = new Point(12, 371);
			this.oO_0oO.oo_.().Multiline = true;
			this.oO_0oO.oo_.().Name = "TextBox1";
			this.oO_0oO.oo_.().ScrollBars = ScrollBars.Vertical;
			this.oO_0oO.oo_.().Size = new Size(538, 86);
			this.oO_0oO.oo_.().TabIndex = 14;
			this.oO_0oO.oo_.().AutoSize = true;
			this.oO_0oO.oo_.().Location = new Point(9, 13);
			this.oO_0oO.oo_.().Name = "Label1";
			this.oO_0oO.oo_.().Size = new Size(53, 12);
			this.oO_0oO.oo_.().TabIndex = 15;
			this.oO_0oO.oo_.().Text = "FTP路径:";
			this.O.__OO.().Location = new Point(72, 10);
			this.O.__OO.().Name = "cmbFTPPath";
			this.O.__OO.().Size = new Size(477, 20);
			this.O.__OO.().TabIndex = 20;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(561, 502);
			base.Controls.Add(this.O.__OO.());
			base.Controls.Add(this.oO_0oO.oo_.());
			base.Controls.Add(this.oO_0oO.oo_.());
			base.Controls.Add(this.O.__OO.());
			base.Controls.Add(this.oo0.oo.());
			base.Controls.Add(this.O.__OO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..o.0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择目录";
			((ISupportInitialize)this.O.__OO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00126BBA File Offset: 0x00124DBA
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00126BC4 File Offset: 0x00124DC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo.oo__.);
			C1Button o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..Click -= value;
			}
			this.O00_._. = A_0;
			o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..Click += value;
			}
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00126C07 File Offset: 0x00124E07
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00126C10 File Offset: 0x00124E10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			SortColEventHandler value = new SortColEventHandler(this.O0O_.oO.);
			EventHandler value2 = new EventHandler(this.oO__00._O.);
			OwnerDrawCellEventHandler value3 = new OwnerDrawCellEventHandler(this.O0O_.oO.);
			C1FlexGrid o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..AfterSort -= value;
				o00_._..DoubleClick -= value2;
				o00_._..OwnerDrawCell -= value3;
			}
			this.O00_._. = A_0;
			o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..AfterSort += value;
				o00_._..DoubleClick += value2;
				o00_._..OwnerDrawCell += value3;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00126C89 File Offset: 0x00124E89
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._0_0o.;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00126C94 File Offset: 0x00124E94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o._ooOOoooO000.);
			C1Button c1Button = this.o._0_0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o._0_0o. = A_0;
			c1Button = this.o._0_0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00126CD7 File Offset: 0x00124ED7
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00126CDF File Offset: 0x00124EDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O00_._. = A_0;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00126CE8 File Offset: 0x00124EE8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00126CF0 File Offset: 0x00124EF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O00_._. = A_0;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00126CF9 File Offset: 0x00124EF9
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00126D04 File Offset: 0x00124F04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			KeyEventHandler value = new KeyEventHandler(this.O0O_.oO.);
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.O0O_.oO.);
			EventHandler value3 = new EventHandler(this.O0.Oo0O_o.);
			EventHandler value4 = new EventHandler(this.O0O_.oO.);
			C1ComboBox o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..KeyDown -= value;
				o00_._..KeyPress -= value2;
				o00_._..SelectedIndexChanged -= value3;
				o00_._..Enter -= value4;
			}
			this.O00_._. = A_0;
			o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..KeyDown += value;
				o00_._..KeyPress += value2;
				o00_._..SelectedIndexChanged += value3;
				o00_._..Enter += value4;
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00126DA4 File Offset: 0x00124FA4
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.O00_._.;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00126DAC File Offset: 0x00124FAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.OooO_O0O_0_O a_ = new FTPClient.OooO_O0O_0_O(this.O.__OO.);
			FTPClient.OoO_00_o a_2 = new FTPClient.OoO_00_o(this.O.__OO.);
			FTPClient.OOOOO00OoOOo a_3 = new FTPClient.OOOOO00OoOOo(this.O.__OO.);
			FTPClient o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..ServerConnected -= a_;
				o00_._..ShowError -= a_2;
				o00_._..ShowMessage -= a_3;
			}
			this.O00_._. = A_0;
			o00_._. = this.O00_._.;
			if (o00_._. != null)
			{
				o00_._..ServerConnected += a_;
				o00_._..ShowError += a_2;
				o00_._..ShowMessage += a_3;
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00126E28 File Offset: 0x00125028
		public d0(FTPClient A_0, string A_1 = "")
		{
			base.Activated += this.Oooo.o0O00o.;
			base.FormClosed += this.O.__OO.;
			base.Load += this.oO0Oo0.Oo0.;
			this.O0OO.o00O00o. = true;
			this.O.o_oo_o00OOO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO_0oO.oo_.(A_0);
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				this.oO_0oO.oo_.().ChangeDir(A_1);
			}
			this.O.__OO.().Styles.Focus.MergeWith(this.O.__OO.().Styles.Highlight);
			this.O.__OO.().Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
			this.O.__OO.().Styles.EmptyArea.BackColor = this.O.__OO.().Styles.Normal.BackColor;
			this.O.__OO.().DrawMode = DrawModeEnum.OwnerDraw;
			this.O.__OO.().Cols[1].Format = "yyyy-MM-dd HH:mm";
			this.O.__OO.().Value = this.oO_0oO.oo_.().CurrentDir;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00126F5C File Offset: 0x0012515C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.O0OO.o00O00o.)
			{
				this.O.__OO.().SelectionMode = SelectionModeEnum.Row;
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00126F72 File Offset: 0x00125172
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.oO_0oO.oo_.(null);
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00126F8B File Offset: 0x0012518B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0O._O_O.();
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00126F94 File Offset: 0x00125194
		private void <<EMPTY_NAME>>()
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
				if (!this.oO_0oO.oo_.().Ooo_Oo_O0.00O..ContainsKey(this.oO_0oO.oo_.().CurrentDir))
				{
					goto IL_46;
				}
				IL_26:
				num2 = 3;
				List<string> a_ = this.oO_0oO.oo_.().Ooo_Oo_O0.00O.[this.oO_0oO.oo_.().CurrentDir];
				goto IL_59;
				IL_46:
				num2 = 5;
				a_ = this.oO_0oO.oo_.().GetDetailList("");
				IL_59:
				num2 = 6;
				FTPBeforeListDetailsEventArgs ftpbeforeListDetailsEventArgs = new FTPBeforeListDetailsEventArgs(this.oO_0oO.oo_.().CurrentDir, a_, this.oO_0oO.oo_.().FTPName);
				IL_79:
				num2 = 7;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", new object[]
				{
					ftpbeforeListDetailsEventArgs
				}, true, "FTP", false);
				IL_9D:
				num2 = 8;
				string[] array = ftpbeforeListDetailsEventArgs.RemovedItems;
				IL_A8:
				num2 = 9;
				this.O.__OO.().Rows.Count = 1;
				IL_BC:
				num2 = 10;
				this.O.__OO.().BeginUpdate();
				IL_CA:
				num2 = 11;
				List<string[]>.Enumerator enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string[] array2 = enumerator.Current;
					IL_E9:
					num2 = 12;
					if (Operators.CompareString(array2[2], "D", true) == 0)
					{
						IL_FD:
						num2 = 14;
						if (Array.BinarySearch<string>(array, array2[0]) < 0)
						{
							IL_10E:
							num2 = 16;
							this.O.__OO.().AddItem(string.Concat(new string[]
							{
								array2[0],
								"\t",
								array2[1],
								"\t \t",
								Conversions.ToString(1)
							}));
							IL_14F:
							num2 = 17;
							this.O.__OO.().SetCellImage(this.O.__OO.().Rows.Count - 1, 0, a.oO0O_O.__oo.().ToBitmap());
						}
					}
					IL_17A:
					num2 = 18;
				}
				IL_189:
				num2 = 19;
				((IDisposable)enumerator).Dispose();
				IL_199:
				num2 = 20;
				if (Operators.CompareString(this.oO_0oO.oo_.().CurrentDir, "/", true) == 0)
				{
					goto IL_22C;
				}
				IL_1B4:
				num2 = 21;
				this.O.__OO.().AddItem("..", 1);
				IL_1C9:
				num2 = 22;
				this.O.__OO.().SetData(1, 3, 0);
				IL_1E0:
				num2 = 23;
				this.O.__OO.().SetCellImage(1, 0, a.o___o.00Oo__.().ToBitmap());
				IL_1FA:
				num2 = 24;
				if (this.O.__OO.().Rows.Count <= 2)
				{
					goto IL_25C;
				}
				IL_210:
				num2 = 25;
				this.O.__OO.().Rows[2].Selected = true;
				goto IL_25C;
				IL_22C:
				num2 = 27;
				if (this.O.__OO.().Rows.Count <= 1)
				{
					goto IL_25C;
				}
				IL_242:
				num2 = 28;
				this.O.__OO.().Rows[1].Selected = true;
				IL_25C:
				num2 = 29;
				this.O.__OO.().EndUpdate();
				IL_26A:
				goto IL_334;
				IL_26F:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2F5:
				goto IL_329;
				IL_2F7:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_307:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2F7;
			}
			IL_329:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_334:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x001272FC File Offset: 0x001254FC
		private void <<EMPTY_NAME>>(object A_0, SortColEventArgs A_1)
		{
			if (this.O.__OO.().Row > 0)
			{
				this.O.__OO.().Sort(SortFlags.Ascending, 3);
				this.O.__OO.().ShowCell(this.O.__OO.().Row, this.O.__OO.().Col);
			}
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0012733C File Offset: 0x0012553C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				if (this.O.__OO.().Row <= 0)
				{
					goto IL_1FB;
				}
				IL_1A:
				num2 = 3;
				if (Operators.CompareString(this.O.__OO.()[this.O.__OO.().Row, 3].ToString(), "1", true) != 0)
				{
					goto IL_CE;
				}
				IL_48:
				num2 = 4;
				string text = this.O.__OO.()[this.O.__OO.().Row, 0].ToString();
				IL_67:
				num2 = 5;
				if (!this.OOOOo.o000.(this.oO_0oO.oo_.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + text))
				{
					goto IL_1FB;
				}
				IL_9A:
				num2 = 7;
				this.oO_0oO.oo_.().ChangeDir(text);
				IL_A8:
				num2 = 8;
				this.o_0O._O_O.();
				IL_B0:
				num2 = 9;
				this.O.__OO.().Value = this.oO_0oO.oo_.().CurrentDir;
				goto IL_1FB;
				IL_CE:
				num2 = 11;
				if (Operators.CompareString(this.O.__OO.()[this.O.__OO.().Row, 3].ToString(), "0", true) != 0)
				{
					goto IL_1FB;
				}
				IL_FD:
				num2 = 12;
				string text2 = this.oO_0oO.oo_.().CurrentDir;
				IL_10D:
				num2 = 13;
				string[] array = text2.Split(new char[]
				{
					'/'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_125:
				num2 = 14;
				if (array.Length <= 0)
				{
					goto IL_1D9;
				}
				IL_132:
				num2 = 15;
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1);
				IL_14D:
				num2 = 16;
				if (Operators.CompareString(this.oO_0oO.oo_.().RootDir, "", true) <= 0)
				{
					goto IL_1B1;
				}
				IL_169:
				num2 = 17;
				if (text2.Length >= this.oO_0oO.oo_.().RootDir.Length || !this.oO_0oO.oo_.().RootDir.StartsWith(text2))
				{
					goto IL_1B1;
				}
				IL_199:
				num2 = 18;
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_1FB;
				IL_1B1:
				num2 = 20;
				if (!this.OOOOo.o000.(text2))
				{
					goto IL_1FB;
				}
				IL_1BE:
				num2 = 22;
				this.oO_0oO.oo_.().ChangeDir(text2);
				IL_1CE:
				num2 = 23;
				this.o_0O._O_O.();
				goto IL_1E2;
				IL_1D9:
				num2 = 25;
				this.o_0O._O_O.();
				IL_1E2:
				num2 = 26;
				this.O.__OO.().Value = this.oO_0oO.oo_.().CurrentDir;
				IL_1FB:
				goto IL_2B9;
				IL_200:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_27A:
				goto IL_2AE;
				IL_27C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_28C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_27C;
			}
			IL_2AE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2B9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00127628 File Offset: 0x00125828
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0OO.o00O00o. = this.O.__OO.().Text;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00127642 File Offset: 0x00125842
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0012764B File Offset: 0x0012584B
		private void <<EMPTY_NAME>>()
		{
			this.o_0O._O_O.();
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00127654 File Offset: 0x00125854
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			this.oO_0oO.oo_.().AppendText(string.Concat(new string[]
			{
				"[",
				Strings.Format(DateTime.Now, "HH:mm:ss"),
				"] ",
				A_0,
				",服务器返回信息:",
				A_1
			}));
			this.oO_0oO.oo_.().AppendText("\r\n");
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x001276C0 File Offset: 0x001258C0
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (base.Visible)
			{
				this.oO_0oO.oo_.().AppendText("[" + Strings.Format(DateTime.Now, "HH:mm:ss") + "] " + A_0);
				this.oO_0oO.oo_.().AppendText("\r\n");
			}
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00127714 File Offset: 0x00125914
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Row > 0 && A_1.Col == 2)
			{
				string text = A_1.Text;
				if (Operators.CompareString(text, "", true) > 0 && Versioned.IsNumeric(text))
				{
					long num = Conversions.ToLong(text);
					if (num == 0L)
					{
						A_1.Text = "0 KB";
						return;
					}
					if (num <= 1024L)
					{
						A_1.Text = "1 KB";
						return;
					}
					A_1.Text = Strings.Format((int)Math.Round((double)num / 1024.0), "#,##0") + " KB";
				}
			}
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x001277B0 File Offset: 0x001259B0
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x001277B9 File Offset: 0x001259B9
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x001277C4 File Offset: 0x001259C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.__OO.().Focus();
			string text = this.O.__OO.().SelectedItem.ToString();
			if (Operators.CompareString(this.oO_0oO.oo_.().CurrentDir.Trim(new char[]
			{
				'/'
			}), text.Trim(new char[]
			{
				'/'
			}), true) != 0)
			{
				if (Operators.CompareString(this.oO_0oO.oo_.().RootDir, "", true) > 0 && text.Length < this.oO_0oO.oo_.().RootDir.Length && this.oO_0oO.oo_.().RootDir.StartsWith(text))
				{
					this.O.__OO.().SelectedItem = this.oO_0oO.oo_.().CurrentDir + "/";
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.OOOOo.o000.(text))
				{
					this.oO_0oO.oo_.().ChangeDir(text);
					this.o_0O._O_O.();
				}
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x001278B8 File Offset: 0x00125AB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string[] array = this.O.__OO.().Text.Split(new char[]
			{
				'/'
			}, StringSplitOptions.RemoveEmptyEntries);
			this.O.__OO.().Items.Clear();
			this.O.__OO.().Items.Add("/");
			string text = "/";
			foreach (string str in array)
			{
				text = text + str + "/";
				this.O.__OO.().Items.Add(text);
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00127940 File Offset: 0x00125B40
		private bool <<EMPTY_NAME>>(string A_0)
		{
			FTPFolderEventArgs ftpfolderEventArgs = new FTPFolderEventArgs(A_0, this.oO_0oO.oo_.().FTPName);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", new object[]
			{
				ftpfolderEventArgs
			}, true, "FTP", false);
			return !ftpfolderEventArgs.Cancel;
		}

		// Token: 0x040010E8 RID: 4328
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040010E9 RID: 4329
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040010EA RID: 4330
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040010EB RID: 4331
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040010EC RID: 4332
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040010ED RID: 4333
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040010EE RID: 4334
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040010EF RID: 4335
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x040010F0 RID: 4336
		internal string <<EMPTY_NAME>>;

		// Token: 0x040010F1 RID: 4337
		internal bool <<EMPTY_NAME>>;
	}
}
