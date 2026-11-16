using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
	// Token: 0x0200045C RID: 1116
	[DesignerGenerated]
	internal partial class lz : Form
	{
		// Token: 0x06004B15 RID: 19221 RVA: 0x0021F278 File Offset: 0x0021D478
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OOOOo.o000. != null)
				{
					this.OOOOo.o000..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x0021F2B8 File Offset: 0x0021D4B8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(lz));
			this.o.0oOOO_.(new C1Button());
			this.o.o_O0O_O_ooO0.(new C1FlexGrid());
			this.o0_Oo0oOo.Ooo_.(new C1Button());
			this.o.o_O0O_O_ooO0.(new C1TextBox());
			this.o.o_O0O_O_ooO0.(new Label());
			this.o.o_O0O_O_ooO0.(new C1ComboBox());
			this.o0o_.0o.(new C1Button());
			this.o0oO.O_o0Oo0.(new C1Button());
			this.Ooo_oO.O0oO0.(new C1Button());
			((ISupportInitialize)this.o0.Ooo__o.()).BeginInit();
			base.SuspendLayout();
			this.O.ooO_.().Location = new Point(475, 468);
			this.O.ooO_.().Name = "btnCancel";
			this.O.ooO_.().Size = new Size(75, 23);
			this.O.ooO_.().TabIndex = 4;
			this.O.ooO_.().Text = "取消";
			this.O.ooO_.().UseVisualStyleBackColor = true;
			this.o0.Ooo__o.().AllowDragging = AllowDraggingEnum.None;
			this.o0.Ooo__o.().AllowEditing = false;
			this.o0.Ooo__o.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.o0.Ooo__o.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.o0.Ooo__o.().ExtendLastCol = true;
			this.o0.Ooo__o.().FocusRect = FocusRectEnum.None;
			this.o0.Ooo__o.().Location = new Point(11, 37);
			this.o0.Ooo__o.().Name = "C1FlexGrid1";
			this.o0.Ooo__o.().Rows.Count = 2;
			this.o0.Ooo__o.().Rows.DefaultSize = 20;
			this.o0.Ooo__o.().SelectionMode = SelectionModeEnum.ListBox;
			this.o0.Ooo__o.().Size = new Size(538, 328);
			this.o0.Ooo__o.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.o0.Ooo__o.().TabIndex = 0;
			this.o0.Ooo__o.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.o0.Ooo__o.().Location = new Point(394, 468);
			this.o0.Ooo__o.().Name = "btnOK";
			this.o0.Ooo__o.().Size = new Size(75, 23);
			this.o0.Ooo__o.().TabIndex = 3;
			this.o0.Ooo__o.().Text = "确定";
			this.o0.Ooo__o.().UseVisualStyleBackColor = true;
			this.o0_Oo0oOo.Ooo_.().ForeColor = Color.Blue;
			this.o0_Oo0oOo.Ooo_.().Location = new Point(12, 371);
			this.o0_Oo0oOo.Ooo_.().Multiline = true;
			this.o0_Oo0oOo.Ooo_.().Name = "TextBox1";
			this.o0_Oo0oOo.Ooo_.().ScrollBars = ScrollBars.Vertical;
			this.o0_Oo0oOo.Ooo_.().Size = new Size(538, 86);
			this.o0_Oo0oOo.Ooo_.().TabIndex = 2;
			this.o0_Oo0oOo.Ooo_.().AutoSize = true;
			this.o0_Oo0oOo.Ooo_.().Location = new Point(9, 13);
			this.o0_Oo0oOo.Ooo_.().Name = "Label1";
			this.o0_Oo0oOo.Ooo_.().Size = new Size(53, 12);
			this.o0_Oo0oOo.Ooo_.().TabIndex = 15;
			this.o0_Oo0oOo.Ooo_.().Text = "FTP路径:";
			this.o0.Ooo__o.().Location = new Point(72, 10);
			this.o0.Ooo__o.().Name = "cmbFTPPath";
			this.o0.Ooo__o.().Size = new Size(477, 20);
			this.o0.Ooo__o.().TabIndex = 0;
			this.O_0___O_.00ooO.().Location = new Point(13, 467);
			this.O_0___O_.00ooO.().Name = "Button1";
			this.O_0___O_.00ooO.().Size = new Size(75, 23);
			this.O_0___O_.00ooO.().TabIndex = 1;
			this.O_0___O_.00ooO.().Text = "刷新";
			this.O_0___O_.00ooO.().UseVisualStyleBackColor = true;
			this.O0_.0O.().Location = new Point(94, 467);
			this.O0_.0O.().Name = "Button2";
			this.O0_.0O.().Size = new Size(75, 23);
			this.O0_.0O.().TabIndex = 2;
			this.O0_.0O.().Text = "上传文件";
			this.O0_.0O.().UseVisualStyleBackColor = true;
			this.O0OoO0oO.0_0Oo.().Location = new Point(175, 467);
			this.O0OoO0oO.0_0Oo.().Name = "Button3";
			this.O0OoO0oO.0_0Oo.().Size = new Size(75, 23);
			this.O0OoO0oO.0_0Oo.().TabIndex = 16;
			this.O0OoO0oO.0_0Oo.().Text = "新建目录";
			this.O0OoO0oO.0_0Oo.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(561, 502);
			base.Controls.Add(this.O0OoO0oO.0_0Oo.());
			base.Controls.Add(this.O0_.0O.());
			base.Controls.Add(this.O_0___O_.00ooO.());
			base.Controls.Add(this.o0.Ooo__o.());
			base.Controls.Add(this.o0_Oo0oOo.Ooo_.());
			base.Controls.Add(this.o0_Oo0oOo.Ooo_.());
			base.Controls.Add(this.o0.Ooo__o.());
			base.Controls.Add(this.O.ooO_.());
			base.Controls.Add(this.o0.Ooo__o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oo0..O..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择文件";
			((ISupportInitialize)this.o0.Ooo__o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0021F86B File Offset: 0x0021DA6B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o_O0O_O_ooO0.;
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0021F874 File Offset: 0x0021DA74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.0o.);
			C1Button c1Button = this.o.o_O0O_O_ooO0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.o_O0O_O_ooO0. = A_0;
			c1Button = this.o.o_O0O_O_ooO0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0021F8B7 File Offset: 0x0021DAB7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OOOOo.o000.;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0021F8C0 File Offset: 0x0021DAC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			SortColEventHandler value = new SortColEventHandler(this.O_0O.o.);
			EventHandler value2 = new EventHandler(this.oO.0O0.);
			KeyEventHandler value3 = new KeyEventHandler(this.OOoO0Oo_o000.0.);
			OwnerDrawCellEventHandler value4 = new OwnerDrawCellEventHandler(this.O_.OOO.);
			C1FlexGrid ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..AfterSort -= value;
				ooooo.o000..DoubleClick -= value2;
				ooooo.o000..KeyDown -= value3;
				ooooo.o000..OwnerDrawCell -= value4;
			}
			this.OOOOo.o000. = A_0;
			ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..AfterSort += value;
				ooooo.o000..DoubleClick += value2;
				ooooo.o000..KeyDown += value3;
				ooooo.o000..OwnerDrawCell += value4;
			}
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0021F960 File Offset: 0x0021DB60
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__oo_._oOOO.;
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x0021F968 File Offset: 0x0021DB68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.Ooooo_o.);
			C1Button o__oo_._oOOO. = this.O__oo_._oOOO.;
			if (o__oo_._oOOO. != null)
			{
				o__oo_._oOOO..Click -= value;
			}
			this.O__oo_._oOOO. = A_0;
			o__oo_._oOOO. = this.O__oo_._oOOO.;
			if (o__oo_._oOOO. != null)
			{
				o__oo_._oOOO..Click += value;
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0021F9AB File Offset: 0x0021DBAB
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OOOOo.o000.;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0021F9B3 File Offset: 0x0021DBB3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OOOOo.o000. = A_0;
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0021F9BC File Offset: 0x0021DBBC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOOOo.o000.;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0021F9C4 File Offset: 0x0021DBC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOOOo.o000. = A_0;
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0021F9CD File Offset: 0x0021DBCD
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.OOOOo.o000.;
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0021F9D8 File Offset: 0x0021DBD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			KeyEventHandler value = new KeyEventHandler(this.O_.OOO.);
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.O_.OOO.);
			EventHandler value3 = new EventHandler(this.OOOOOo.Ooo.);
			EventHandler value4 = new EventHandler(this.o____0O_oOo0._.);
			C1ComboBox ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..KeyDown -= value;
				ooooo.o000..KeyPress -= value2;
				ooooo.o000..SelectedIndexChanged -= value3;
				ooooo.o000..Enter -= value4;
			}
			this.OOOOo.o000. = A_0;
			ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..KeyDown += value;
				ooooo.o000..KeyPress += value2;
				ooooo.o000..SelectedIndexChanged += value3;
				ooooo.o000..Enter += value4;
			}
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0021FA78 File Offset: 0x0021DC78
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0o__0._.;
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0021FA80 File Offset: 0x0021DC80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.O0ooo_o.);
			C1Button o0o__0._. = this.O0o__0._.;
			if (o0o__0._. != null)
			{
				o0o__0._..Click -= value;
			}
			this.O0o__0._. = A_0;
			o0o__0._. = this.O0o__0._.;
			if (o0o__0._. != null)
			{
				o0o__0._..Click += value;
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0021FAC3 File Offset: 0x0021DCC3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0_.oOoo.;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0021FACC File Offset: 0x0021DCCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_oOo_00_0.OoO.);
			C1Button c1Button = this.oO0_.oOoo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0_.oOoo. = A_0;
			c1Button = this.oO0_.oOoo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0021FB0F File Offset: 0x0021DD0F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.O000.;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0021FB18 File Offset: 0x0021DD18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0O.o.);
			C1Button c1Button = this.o.O000.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.O000. = A_0;
			c1Button = this.o.O000.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0021FB5B File Offset: 0x0021DD5B
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.OOOOo.o000.;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x0021FB64 File Offset: 0x0021DD64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.OooO_O0O_0_O a_ = new FTPClient.OooO_O0O_0_O(this.o0.Ooo__o.);
			FTPClient.OoO_00_o a_2 = new FTPClient.OoO_00_o(this.o0.Ooo__o.);
			FTPClient.OOOOO00OoOOo a_3 = new FTPClient.OOOOO00OoOOo(this.o0.Ooo__o.);
			FTPClient ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..ServerConnected -= a_;
				ooooo.o000..ShowError -= a_2;
				ooooo.o000..ShowMessage -= a_3;
			}
			this.OOOOo.o000. = A_0;
			ooooo.o000. = this.OOOOo.o000.;
			if (ooooo.o000. != null)
			{
				ooooo.o000..ServerConnected += a_;
				ooooo.o000..ShowError += a_2;
				ooooo.o000..ShowMessage += a_3;
			}
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x0021FBE0 File Offset: 0x0021DDE0
		public lz(FTPClient A_0, string A_1 = "")
		{
			base.Activated += this.O._OO0_.;
			base.FormClosed += this.O_.OOO.;
			base.Load += this.o00_OO_._oO.;
			this.OOOOo.o000. = true;
			this.Ooo_oO.O0oO0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o.o_O0O_O_ooO0.(A_0);
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				this.o0_Oo0oOo.Ooo_.().ChangeDir(A_1);
			}
			this.o0.Ooo__o.().Styles.Focus.MergeWith(this.o0.Ooo__o.().Styles.Highlight);
			this.o0.Ooo__o.().Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
			this.o0.Ooo__o.().Styles.EmptyArea.BackColor = this.o0.Ooo__o.().Styles.Normal.BackColor;
			this.o0.Ooo__o.().DrawMode = DrawModeEnum.OwnerDraw;
			this.o0.Ooo__o.().Cols[1].Format = "yyyy-MM-dd HH:mm";
			this.OOOOo.o000. = new List<string>();
			this.o0.Ooo__o.().Value = this.o0_Oo0oOo.Ooo_.().CurrentDir;
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0021FD1F File Offset: 0x0021DF1F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.OOOOo.o000.)
			{
				this.o0.Ooo__o.().SelectionMode = SelectionModeEnum.Row;
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0021FD35 File Offset: 0x0021DF35
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.o.o_O0O_O_ooO0.(null);
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0021FD4E File Offset: 0x0021DF4E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_Oo0oOo.Ooo_.(false, ".");
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0021FD5C File Offset: 0x0021DF5C
		private void <<EMPTY_NAME>>(bool A_0 = false, string A_1 = ".")
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
				if (!this.o0_Oo0oOo.Ooo_.().Ooo_Oo_O0.00O..ContainsKey(this.o0_Oo0oOo.Ooo_.().CurrentDir) || A_0)
				{
					goto IL_49;
				}
				IL_29:
				num2 = 3;
				List<string> a_ = this.o0_Oo0oOo.Ooo_.().Ooo_Oo_O0.00O.[this.o0_Oo0oOo.Ooo_.().CurrentDir];
				goto IL_5C;
				IL_49:
				num2 = 5;
				a_ = this.o0_Oo0oOo.Ooo_.().GetDetailList("");
				IL_5C:
				num2 = 6;
				FTPBeforeListDetailsEventArgs ftpbeforeListDetailsEventArgs = new FTPBeforeListDetailsEventArgs(this.o0_Oo0oOo.Ooo_.().CurrentDir, a_, this.o0_Oo0oOo.Ooo_.().FTPName);
				IL_7C:
				num2 = 7;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", new object[]
				{
					ftpbeforeListDetailsEventArgs
				}, true, "FTP", false);
				IL_A0:
				num2 = 8;
				string[] array = ftpbeforeListDetailsEventArgs.RemovedItems;
				IL_AB:
				num2 = 9;
				this.o0.Ooo__o.().Rows.Count = 1;
				IL_BF:
				num2 = 10;
				this.o0.Ooo__o.().BeginUpdate();
				IL_CD:
				num2 = 11;
				List<string[]>.Enumerator enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string[] array2 = enumerator.Current;
					IL_EC:
					num2 = 12;
					if (Operators.CompareString(array2[2], "D", true) == 0)
					{
						IL_103:
						num2 = 14;
						if (Array.BinarySearch<string>(array, array2[0]) < 0)
						{
							IL_117:
							num2 = 16;
							this.o0.Ooo__o.().AddItem(string.Concat(new string[]
							{
								array2[0],
								"\t",
								array2[1],
								"\t \t",
								Conversions.ToString(1)
							}));
							IL_158:
							num2 = 17;
							this.o0.Ooo__o.().SetCellImage(this.o0.Ooo__o.().Rows.Count - 1, 0, a.oO0O_O.__oo.().ToBitmap());
							IL_183:
							num2 = 18;
							if (Operators.CompareString(this.o0.Ooo__o.().GetData(this.o0.Ooo__o.().Rows.Count - 1, 0).ToString(), A_1, true) == 0)
							{
								IL_1B2:
								num2 = 19;
								this.o0.Ooo__o.().Row = this.o0.Ooo__o.().Rows.Count - 1;
							}
						}
					}
					IL_1D2:
					num2 = 20;
				}
				IL_1E1:
				num2 = 21;
				((IDisposable)enumerator).Dispose();
				IL_1F1:
				num2 = 22;
				List<string[]>.Enumerator enumerator2 = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string[] array3 = enumerator2.Current;
					IL_210:
					num2 = 23;
					if (Operators.CompareString(array3[2], "D", true) != 0)
					{
						IL_227:
						num2 = 25;
						if (Array.BinarySearch<string>(array, array3[0]) < 0)
						{
							IL_23B:
							num2 = 27;
							this.o0.Ooo__o.().AddItem(string.Concat(new string[]
							{
								array3[0],
								"\t",
								array3[1],
								"\t",
								array3[2],
								"\t",
								Conversions.ToString(2)
							}));
							IL_28B:
							num2 = 28;
							string text = array3[0];
							IL_294:
							num2 = 29;
							Bitmap bitmap = O_O0OO.O0_00o.o0__o.;
							IL_29E:
							num2 = 30;
							if (text.LastIndexOf(".") > 0)
							{
								IL_2B0:
								num2 = 31;
								text = text.Substring(text.LastIndexOf(".")).ToLower();
								IL_2CD:
								num2 = 32;
								if (O_O0OO.O0_00o.o0__o..ContainsKey(text))
								{
									IL_2DE:
									num2 = 33;
									bitmap = O_O0OO.O0_00o.o0__o.[text];
								}
								else
								{
									IL_2F1:
									num2 = 35;
									bitmap = ooO.OoO_0._oO00_o.(text);
									IL_2FD:
									num2 = 36;
									if (bitmap == null)
									{
										IL_304:
										num2 = 37;
										bitmap = O_O0OO.O0_00o.o0__o.;
									}
									IL_30E:
									num2 = 38;
									O_O0OO.O0_00o.o0__o..Add(text, bitmap);
								}
							}
							IL_31F:
							num2 = 39;
							this.o0.Ooo__o.().SetCellImage(this.o0.Ooo__o.().Rows.Count - 1, 0, bitmap);
							IL_342:
							num2 = 40;
							if (Operators.CompareString(this.o0.Ooo__o.().GetData(this.o0.Ooo__o.().Rows.Count - 1, 0).ToString(), A_1, true) == 0)
							{
								IL_371:
								num2 = 41;
								this.o0.Ooo__o.().Row = this.o0.Ooo__o.().Rows.Count - 1;
							}
						}
					}
					IL_391:
					num2 = 42;
				}
				IL_3A0:
				num2 = 43;
				((IDisposable)enumerator2).Dispose();
				IL_3B0:
				num2 = 44;
				if (Operators.CompareString(this.o0_Oo0oOo.Ooo_.().CurrentDir, "/", true) == 0)
				{
					goto IL_45D;
				}
				IL_3CE:
				num2 = 45;
				this.o0.Ooo__o.().AddItem("..", 1);
				IL_3E3:
				num2 = 46;
				this.o0.Ooo__o.().SetData(1, 3, 0);
				IL_3FA:
				num2 = 47;
				this.o0.Ooo__o.().SetCellImage(1, 0, a.o___o.00Oo__.().ToBitmap());
				IL_414:
				num2 = 48;
				if (this.o0.Ooo__o.().Rows.Count <= 2 || this.o0.Ooo__o.().Rows.Selected.Count != 0)
				{
					goto IL_4A4;
				}
				IL_441:
				num2 = 49;
				this.o0.Ooo__o.().Rows[2].Selected = true;
				goto IL_4A4;
				IL_45D:
				num2 = 51;
				if (this.o0.Ooo__o.().Rows.Count <= 1 || this.o0.Ooo__o.().Rows.Selected.Count != 0)
				{
					goto IL_4A4;
				}
				IL_48A:
				num2 = 52;
				this.o0.Ooo__o.().Rows[1].Selected = true;
				IL_4A4:
				num2 = 53;
				this.o0.Ooo__o.().EndUpdate();
				IL_4B2:
				goto IL_5DC;
				IL_4B7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_59D:
				goto IL_5D1;
				IL_59F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5AF:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_59F;
			}
			IL_5D1:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5DC:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x0022036C File Offset: 0x0021E56C
		private void <<EMPTY_NAME>>(object A_0, SortColEventArgs A_1)
		{
			if (this.o0.Ooo__o.().Row > 0)
			{
				this.o0.Ooo__o.().Sort(SortFlags.Ascending, 3);
				this.o0.Ooo__o.().ShowCell(this.o0.Ooo__o.().Row, this.o0.Ooo__o.().Col);
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x002203AA File Offset: 0x0021E5AA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0.Ooo__o.().PerformClick();
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x002203B8 File Offset: 0x0021E5B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.o0.Ooo__o.().Row <= 0)
				{
					goto IL_378;
				}
				IL_1A:
				num2 = 3;
				if (Operators.CompareString(this.o0.Ooo__o.()[this.o0.Ooo__o.().Row, 3].ToString(), "2", true) != 0)
				{
					goto IL_17D;
				}
				IL_48:
				num2 = 4;
				if (!this.OOOOo.o000.)
				{
					goto IL_10B;
				}
				IL_55:
				num2 = 5;
				int num3 = this.o0.Ooo__o.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_72:
					num2 = 6;
					if (this.o0.Ooo__o.().Rows[i].Selected)
					{
						IL_8D:
						num2 = 7;
						if (Operators.CompareString(this.o0.Ooo__o.()[i, 3].ToString(), "2", true) != 0)
						{
							goto IL_378;
						}
						IL_B2:
						num2 = 10;
						this.OOOOo.o000..Add(this.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(new char[]
						{
							'/'
						}) + "/" + this.o0.Ooo__o.()[i, 0].ToString());
					}
					IL_F8:
					num2 = 11;
				}
				goto IL_15A;
				IL_10B:
				num2 = 13;
				this.OOOOo.o000..Add(this.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + this.o0.Ooo__o.()[this.o0.Ooo__o.().Row, 0].ToString());
				IL_15A:
				num2 = 14;
				if (this.OOOOo.o000..Count <= 0)
				{
					goto IL_378;
				}
				IL_16E:
				num2 = 15;
				base.DialogResult = DialogResult.OK;
				goto IL_378;
				IL_17D:
				num2 = 17;
				if (Operators.CompareString(this.o0.Ooo__o.()[this.o0.Ooo__o.().Row, 3].ToString(), "1", true) != 0)
				{
					goto IL_23F;
				}
				IL_1AC:
				num2 = 18;
				string text = this.o0.Ooo__o.()[this.o0.Ooo__o.().Row, 0].ToString();
				IL_1CD:
				num2 = 19;
				if (!this.O_0O.o.(this.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + text))
				{
					goto IL_378;
				}
				IL_202:
				num2 = 21;
				this.o0_Oo0oOo.Ooo_.().ChangeDir(text);
				IL_212:
				num2 = 22;
				this.o0_Oo0oOo.Ooo_.(false, ".");
				IL_221:
				num2 = 23;
				this.o0.Ooo__o.().Value = this.o0_Oo0oOo.Ooo_.().CurrentDir;
				goto IL_378;
				IL_23F:
				num2 = 25;
				if (Operators.CompareString(this.o0.Ooo__o.()[this.o0.Ooo__o.().Row, 3].ToString(), "0", true) != 0)
				{
					goto IL_378;
				}
				IL_26E:
				num2 = 26;
				string text2 = this.o0_Oo0oOo.Ooo_.().CurrentDir;
				IL_27E:
				num2 = 27;
				string[] array = text2.Split(new char[]
				{
					'/'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_296:
				num2 = 28;
				if (array.Length <= 0)
				{
					goto IL_350;
				}
				IL_2A3:
				num2 = 29;
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1);
				IL_2BE:
				num2 = 30;
				if (Operators.CompareString(this.o0_Oo0oOo.Ooo_.().RootDir, "", true) <= 0)
				{
					goto IL_322;
				}
				IL_2DA:
				num2 = 31;
				if (text2.Length >= this.o0_Oo0oOo.Ooo_.().RootDir.Length || !this.o0_Oo0oOo.Ooo_.().RootDir.StartsWith(text2))
				{
					goto IL_322;
				}
				IL_30A:
				num2 = 32;
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_378;
				IL_322:
				num2 = 34;
				if (!this.O_0O.o.(text2))
				{
					goto IL_378;
				}
				IL_32F:
				num2 = 36;
				this.o0_Oo0oOo.Ooo_.().ChangeDir(text2);
				IL_33F:
				num2 = 37;
				this.o0_Oo0oOo.Ooo_.(false, ".");
				goto IL_35F;
				IL_350:
				num2 = 39;
				this.o0_Oo0oOo.Ooo_.(false, ".");
				IL_35F:
				num2 = 40;
				this.o0.Ooo__o.().Value = this.o0_Oo0oOo.Ooo_.().CurrentDir;
				IL_378:
				goto IL_46E;
				IL_37D:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_42F:
				goto IL_463;
				IL_431:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_441:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_431;
			}
			IL_463:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_46E:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00220858 File Offset: 0x0021EA58
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00220861 File Offset: 0x0021EA61
		private void <<EMPTY_NAME>>()
		{
			this.o0_Oo0oOo.Ooo_.(false, ".");
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00220870 File Offset: 0x0021EA70
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (!this.o_0O0.OO00.)
			{
				this.o0_Oo0oOo.Ooo_.().AppendText(string.Concat(new string[]
				{
					"[",
					Strings.Format(DateTime.Now, "HH:mm:ss"),
					"] ",
					A_0,
					",服务器返回信息:",
					A_1
				}));
				this.o0_Oo0oOo.Ooo_.().AppendText("\r\n");
			}
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x002208E4 File Offset: 0x0021EAE4
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (!this.o_0O0.OO00. && base.Visible)
			{
				this.o0_Oo0oOo.Ooo_.().AppendText("[" + Strings.Format(DateTime.Now, "HH:mm:ss") + "] " + A_0);
				this.o0_Oo0oOo.Ooo_.().AppendText("\r\n");
			}
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00220940 File Offset: 0x0021EB40
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.KeyCode != Keys.Delete)
				{
					goto IL_197;
				}
				IL_16:
				num2 = 3;
				C1FlexGrid c1FlexGrid = this.o0.Ooo__o.();
				IL_1F:
				num2 = 4;
				int num3 = c1FlexGrid.Rows.Count - 1;
				int num4;
				for (int i = 1; i <= num3; i++)
				{
					IL_35:
					num2 = 5;
					if (c1FlexGrid.Rows[i].Selected)
					{
						IL_4B:
						num2 = 6;
						string left = c1FlexGrid.GetData(i, 3).ToString();
						IL_5D:
						num2 = 7;
						if (Operators.CompareString(left, "1", true) == 0 || Operators.CompareString(left, "2", true) == 0)
						{
							IL_7D:
							num2 = 8;
							num4++;
						}
					}
					IL_85:
					num2 = 9;
				}
				IL_94:
				num2 = 10;
				if (num4 == 0)
				{
					goto IL_197;
				}
				IL_9E:
				num2 = 13;
				if (MessageBox.Show("确定要删除选定项目吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					goto IL_197;
				}
				IL_B9:
				num2 = 15;
				int num5 = c1FlexGrid.Rows.Count - 1;
				for (int j = 1; j <= num5; j++)
				{
					IL_D3:
					num2 = 16;
					if (c1FlexGrid.Rows[j].Selected)
					{
						IL_ED:
						num2 = 17;
						if (Operators.CompareString(c1FlexGrid.GetData(j, 3).ToString(), "1", true) == 0)
						{
							IL_10B:
							num2 = 18;
							string dirName = c1FlexGrid.GetData(j, 0).ToString();
							IL_11E:
							num2 = 19;
							this.o0_Oo0oOo.Ooo_.().DeleteDir(dirName, true);
						}
						else
						{
							IL_132:
							num2 = 21;
							if (Operators.CompareString(c1FlexGrid.GetData(j, 3).ToString(), "2", true) == 0)
							{
								IL_150:
								num2 = 22;
								string fileName = c1FlexGrid.GetData(j, 0).ToString();
								IL_163:
								num2 = 23;
								this.o0_Oo0oOo.Ooo_.().DeleteFile(fileName);
							}
						}
					}
					IL_174:
					num2 = 24;
				}
				IL_186:
				num2 = 25;
				this.o0_Oo0oOo.Ooo_.(true, ".");
				IL_195:
				c1FlexGrid = null;
				IL_197:
				goto IL_255;
				IL_19C:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_216:
				goto IL_24A;
				IL_218:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_228:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_218;
			}
			IL_24A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_255:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00220BC8 File Offset: 0x0021EDC8
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

		// Token: 0x06004B39 RID: 19257 RVA: 0x00220C64 File Offset: 0x0021EE64
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x00220C6D File Offset: 0x0021EE6D
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00220C78 File Offset: 0x0021EE78
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0.Ooo__o.().Focus();
			string text = this.o0.Ooo__o.().SelectedItem.ToString();
			if (Operators.CompareString(this.o0_Oo0oOo.Ooo_.().CurrentDir.Trim(new char[]
			{
				'/'
			}), text.Trim(new char[]
			{
				'/'
			}), true) != 0)
			{
				if (Operators.CompareString(this.o0_Oo0oOo.Ooo_.().RootDir, "", true) > 0 && text.Length < this.o0_Oo0oOo.Ooo_.().RootDir.Length && this.o0_Oo0oOo.Ooo_.().RootDir.StartsWith(text))
				{
					this.o0.Ooo__o.().SelectedItem = this.o0_Oo0oOo.Ooo_.().CurrentDir + "/";
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.O_0O.o.(text))
				{
					this.o0_Oo0oOo.Ooo_.().ChangeDir(text);
					this.o0_Oo0oOo.Ooo_.(false, ".");
				}
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00220D74 File Offset: 0x0021EF74
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string[] array = this.o0.Ooo__o.().Text.Split(new char[]
			{
				'/'
			}, StringSplitOptions.RemoveEmptyEntries);
			this.o0.Ooo__o.().Items.Clear();
			this.o0.Ooo__o.().Items.Add("/");
			string text = "/";
			foreach (string str in array)
			{
				text = text + str + "/";
				this.o0.Ooo__o.().Items.Add(text);
			}
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00220DFB File Offset: 0x0021EFFB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_Oo0oOo.Ooo_.(true, ".");
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00220E0C File Offset: 0x0021F00C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				FTPUploadEventArgs ftpuploadEventArgs = new FTPUploadEventArgs(fileName, this.o0_Oo0oOo.Ooo_.().CurrentDir, this.o0_Oo0oOo.Ooo_.().FTPName);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeUpload", new object[]
				{
					ftpuploadEventArgs
				}, true, "FTP", false);
				if (!ftpuploadEventArgs.CancelAll && !ftpuploadEventArgs.Cancel)
				{
					string name = OO_00oOO.FileSys.GetName(openFileDialog.FileName);
					int num = this.o0.Ooo__o.().Rows.Count - 1;
					for (int i = 1; i <= num; i++)
					{
						if (Operators.CompareString(this.o0.Ooo__o.().GetData(i, 0).ToString(), name, true) == 0 && MessageBox.Show("文件\"" + name + "\"已经存在，是否覆盖?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							return;
						}
					}
					string text = "/" + this.o0_Oo0oOo.Ooo_.().CurrentDir.Trim(new char[]
					{
						'/'
					}) + "/" + OO_00oOO.FileSys.GetName(fileName);
					new FileInfo(fileName);
					if (text.StartsWith("//"))
					{
						text = text.Substring(1);
					}
					this.o_0O0.OO00. = true;
					if (this.o0_Oo0oOo.Ooo_.().Upload(fileName, text, true))
					{
						this.o0_Oo0oOo.Ooo_.(true, OO_00oOO.FileSys.GetName(fileName));
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterUpload", new object[]
						{
							ftpuploadEventArgs
						}, true, "FTP", false);
					}
					this.o_0O0.OO00. = false;
				}
			}
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00220FA4 File Offset: 0x0021F1A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3000\u3000 o_u3000_u = new o\u3000\u3000("新建目录", "输入目录名称:", "");
			if (o_u3000_u.ShowDialog() == DialogResult.OK && Operators.CompareString(o_u3000_u.Value, "", true) > 0)
			{
				string a_ = this.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + o_u3000_u.Value;
				FTPFolderEventArgs ftpfolderEventArgs = new FTPFolderEventArgs(a_, this.o0_Oo0oOo.Ooo_.().FTPName);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCreateFolder", new object[]
				{
					ftpfolderEventArgs
				}, true, "FTP", false);
				if (!ftpfolderEventArgs.Cancel && this.o0_Oo0oOo.Ooo_.().MakeDir(o_u3000_u.Value))
				{
					this.o0_Oo0oOo.Ooo_.(true, o_u3000_u.Value);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterCreateFolder", new object[]
					{
						ftpfolderEventArgs
					}, true, "FTP", false);
				}
			}
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00221094 File Offset: 0x0021F294
		private bool <<EMPTY_NAME>>(string A_0)
		{
			FTPFolderEventArgs ftpfolderEventArgs = new FTPFolderEventArgs(A_0, this.o0_Oo0oOo.Ooo_.().FTPName);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", new object[]
			{
				ftpfolderEventArgs
			}, true, "FTP", false);
			return !ftpfolderEventArgs.Cancel;
		}

		// Token: 0x04001E80 RID: 7808
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001E81 RID: 7809
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E82 RID: 7810
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001E83 RID: 7811
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E84 RID: 7812
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001E85 RID: 7813
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001E86 RID: 7814
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001E87 RID: 7815
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E88 RID: 7816
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E89 RID: 7817
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E8A RID: 7818
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04001E8B RID: 7819
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04001E8C RID: 7820
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001E8D RID: 7821
		private bool <<EMPTY_NAME>>;
	}
}
