using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000358 RID: 856
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002 : Form
	{
		// Token: 0x06003556 RID: 13654 RVA: 0x00171338 File Offset: 0x0016F538
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOo0OoO.oO0oo_. != null)
				{
					this.oOo0OoO.oO0oo_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00171378 File Offset: 0x0016F578
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.O_O0ooO_.(new Label());
			this.o.O_O0ooO_.(new C1ComboBox());
			this.o_.0_00_o_o.(new C1CheckBox());
			this.o.O_O0ooO_.(new C1Button());
			this.OO__o._O_.(new C1Button());
			this.o.O_O0ooO_.(new C1CheckBox());
			this.O_.o0__00.(new C1CheckBox());
			this.O.Oo0oO_.(new C1CheckBox());
			this.OO__o._O_.(new C1CheckBox());
			base.SuspendLayout();
			this.o_.0_0_0OoO__.().AutoSize = true;
			this.o_.0_0_0OoO__.().Location = new Point(24, 27);
			this.o_.0_0_0OoO__.().Name = "Label1";
			this.o_.0_0_0OoO__.().Size = new Size(59, 12);
			this.o_.0_0_0OoO__.().TabIndex = 0;
			this.o_.0_0_0OoO__.().Text = "停靠位置:";
			this.o_.0_0_0OoO__.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_.0_0_0OoO__.().Items.AddRange(new object[]
			{
				"靠左",
				"靠右",
				"靠底",
				"靠上"
			});
			this.o_.0_0_0OoO__.().Location = new Point(89, 24);
			this.o_.0_0_0OoO__.().Name = "cmbDockArea";
			this.o_.0_0_0OoO__.().Size = new Size(121, 20);
			this.o_.0_0_0OoO__.().TabIndex = 0;
			this.OOo_.ooo0O.().AutoSize = true;
			this.OOo_.ooo0O.().Location = new Point(64, 61);
			this.OOo_.ooo0O.().Name = "chkTitle";
			this.OOo_.ooo0O.().Size = new Size(72, 16);
			this.OOo_.ooo0O.().TabIndex = 1;
			this.OOo_.ooo0O.().Text = "独立停靠";
			this.OOo_.ooo0O.().UseVisualStyleBackColor = true;
			this.o.__o___0_0O_.().DialogResult = DialogResult.OK;
			this.o.__o___0_0O_.().Location = new Point(68, 141);
			this.o.__o___0_0O_.().Name = "Button1";
			this.o.__o___0_0O_.().Size = new Size(75, 23);
			this.o.__o___0_0O_.().TabIndex = 5;
			this.o.__o___0_0O_.().Text = "确定";
			this.o.__o___0_0O_.().UseVisualStyleBackColor = true;
			this.o_.0_0_0OoO__.().DialogResult = DialogResult.Cancel;
			this.o_.0_0_0OoO__.().Location = new Point(149, 141);
			this.o_.0_0_0OoO__.().Name = "Button2";
			this.o_.0_0_0OoO__.().Size = new Size(75, 23);
			this.o_.0_0_0OoO__.().TabIndex = 6;
			this.o_.0_0_0OoO__.().Text = "取消";
			this.o_.0_0_0OoO__.().UseVisualStyleBackColor = true;
			this.Ooo_O._.().AutoSize = true;
			this.Ooo_O._.().Location = new Point(64, 84);
			this.Ooo_O._.().Name = "chkAutoOpen";
			this.Ooo_O._.().Size = new Size(72, 16);
			this.Ooo_O._.().TabIndex = 2;
			this.Ooo_O._.().Text = "自动打开";
			this.Ooo_O._.().UseVisualStyleBackColor = true;
			this.o.__o___0_0O_.().AutoSize = true;
			this.o.__o___0_0O_.().Location = new Point(64, 107);
			this.o.__o___0_0O_.().Name = "chkAutoHide";
			this.o.__o___0_0O_.().Size = new Size(72, 16);
			this.o.__o___0_0O_.().TabIndex = 2;
			this.o.__o___0_0O_.().Text = "自动隐藏";
			this.o.__o___0_0O_.().UseVisualStyleBackColor = true;
			this.o_.0_0_0OoO__.().AutoSize = true;
			this.o_.0_0_0OoO__.().Location = new Point(143, 84);
			this.o_.0_0_0OoO__.().Name = "chkShowCaption";
			this.o_.0_0_0OoO__.().Size = new Size(72, 16);
			this.o_.0_0_0OoO__.().TabIndex = 3;
			this.o_.0_0_0OoO__.().Text = "显示标题";
			this.o_.0_0_0OoO__.().UseVisualStyleBackColor = true;
			this.O_.oOOo0_00.().AutoSize = true;
			this.O_.oOOo0_00.().Location = new Point(143, 107);
			this.O_.oOOo0_00.().Name = "chkAllowClose";
			this.O_.oOOo0_00.().Size = new Size(72, 16);
			this.O_.oOOo0_00.().TabIndex = 4;
			this.O_.oOOo0_00.().Text = "允许关闭";
			this.O_.oOOo0_00.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(293, 176);
			base.Controls.Add(this.O_.oOOo0_00.());
			base.Controls.Add(this.o_.0_0_0OoO__.());
			base.Controls.Add(this.o.__o___0_0O_.());
			base.Controls.Add(this.Ooo_O._.());
			base.Controls.Add(this.o_.0_0_0OoO__.());
			base.Controls.Add(this.o.__o___0_0O_.());
			base.Controls.Add(this.OOo_.ooo0O.());
			base.Controls.Add(this.o_.0_0_0OoO__.());
			base.Controls.Add(this.o_.0_0_0OoO__.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0..oo..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "停靠设置";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x001718EE File Offset: 0x0016FAEE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo0OoO.oO0oo_.;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x001718F6 File Offset: 0x0016FAF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOo0OoO.oO0oo_. = A_0;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x001718FF File Offset: 0x0016FAFF
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oOo0OoO.oO0oo_.;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00171907 File Offset: 0x0016FB07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oOo0OoO.oO0oo_. = A_0;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00171910 File Offset: 0x0016FB10
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oOo0OoO.oO0oo_.;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00171918 File Offset: 0x0016FB18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oOo0OoO.oO0oo_. = A_0;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00171921 File Offset: 0x0016FB21
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.O_O0ooO_.;
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0017192C File Offset: 0x0016FB2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.OoO0.);
			C1Button c1Button = this.o.O_O0ooO_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.O_O0ooO_. = A_0;
			c1Button = this.o.O_O0ooO_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0017196F File Offset: 0x0016FB6F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_._Oo.;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00171977 File Offset: 0x0016FB77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_._Oo. = A_0;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00171980 File Offset: 0x0016FB80
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_._Oo.;
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00171988 File Offset: 0x0016FB88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o_._Oo. = A_0;
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00171991 File Offset: 0x0016FB91
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.OOO.oo.;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00171999 File Offset: 0x0016FB99
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.OOO.oo. = A_0;
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x001719A2 File Offset: 0x0016FBA2
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oo0oO.0.;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x001719AA File Offset: 0x0016FBAA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oo0oO.0. = A_0;
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x001719B3 File Offset: 0x0016FBB3
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O___0Oo.o.;
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x001719BB File Offset: 0x0016FBBB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O___0Oo.o. = A_0;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x001719C4 File Offset: 0x0016FBC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				o_O0_0O0 o_O0_0O;
				switch (this.oOo0OoO.oO0oo_.._frdDockArea)
				{
				case DockAreaEnum.右:
					IL_61:
					num2 = 7;
					this.o_.0_0_0OoO__.().SelectedIndex = 1;
					IL_6F:
					num2 = 8;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab).o__0_.o0OoOOO.();
					break;
				case DockAreaEnum.底:
					IL_8D:
					num2 = 10;
					this.o_.0_0_0OoO__.().SelectedIndex = 2;
					IL_9C:
					num2 = 11;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab).O._o_00__.();
					break;
				case DockAreaEnum.左:
					IL_32:
					num2 = 4;
					this.o_.0_0_0OoO__.().SelectedIndex = 0;
					IL_40:
					num2 = 5;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab).O__O.o_oOO.();
					break;
				case DockAreaEnum.上:
					IL_BB:
					num2 = 13;
					this.o_.0_0_0OoO__.().SelectedIndex = 3;
					IL_CA:
					num2 = 14;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab).O_000__.o.();
					break;
				default:
					goto IL_1CD;
				}
				IL_E7:
				num2 = 18;
				IEnumerator enumerator = o_O0_0O.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_107:
					num2 = 19;
					if (control is C1DockingTab)
					{
						IL_113:
						num2 = 20;
						((C1DockingTab)control).AutoHiding = false;
					}
					IL_123:
					num2 = 21;
				}
				IL_12F:
				num2 = 22;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_147:
				num2 = 23;
				o_O0_0O.Refresh();
				IL_150:
				num2 = 24;
				this.OOo_.ooo0O.().Checked = this.oOo0OoO.oO0oo_.._frdDockTitle;
				IL_169:
				num2 = 25;
				this.Ooo_O._.().Checked = this.oOo0OoO.oO0oo_.._frdAutoOpen;
				IL_182:
				num2 = 26;
				this.o.__o___0_0O_.().Checked = this.oOo0OoO.oO0oo_.._frdAutoHide;
				IL_19B:
				num2 = 27;
				this.o_.0_0_0OoO__.().Checked = this.oOo0OoO.oO0oo_.._frdShowCaption;
				IL_1B4:
				num2 = 28;
				this.O_.oOOo0_00.().Checked = this.oOo0OoO.oO0oo_.._frdAllowClose;
				IL_1CD:
				goto IL_293;
				IL_1D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_254:
				goto IL_288;
				IL_256:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_266:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_256;
			}
			IL_288:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_293:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00171C88 File Offset: 0x0016FE88
		public O\u3002\u3002\u3002(Table A_0)
		{
			base.Load += this.O___O.O_o0OooO.;
			base.MenuStart += this.o.o_o.;
			this.o_.0_0_0OoO__.();
			this.oOo0OoO.oO0oo_. = A_0;
			this.Text = this.Text + " - " + A_0.Name;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00171D00 File Offset: 0x0016FF00
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
				switch (this.o_.0_0_0OoO__.().SelectedIndex)
				{
				case 0:
					IL_2D:
					num2 = 4;
					this.oOo0OoO.oO0oo_.._frdDockArea = DockAreaEnum.左;
					break;
				case 1:
					IL_3D:
					num2 = 6;
					this.oOo0OoO.oO0oo_.._frdDockArea = DockAreaEnum.右;
					break;
				case 2:
					IL_4D:
					num2 = 8;
					this.oOo0OoO.oO0oo_.._frdDockArea = DockAreaEnum.底;
					break;
				case 3:
					IL_5D:
					num2 = 10;
					this.oOo0OoO.oO0oo_.._frdDockArea = DockAreaEnum.上;
					break;
				}
				IL_6C:
				num2 = 12;
				this.oOo0OoO.oO0oo_.._frdDockTitle = this.OOo_.ooo0O.().Checked;
				IL_85:
				num2 = 13;
				this.oOo0OoO.oO0oo_.._frdAutoOpen = this.Ooo_O._.().Checked;
				IL_9E:
				num2 = 14;
				this.oOo0OoO.oO0oo_.._frdAutoHide = this.o.__o___0_0O_.().Checked;
				IL_B7:
				num2 = 15;
				this.oOo0OoO.oO0oo_.._frdShowCaption = this.o_.0_0_0OoO__.().Checked;
				IL_D0:
				num2 = 16;
				this.oOo0OoO.oO0oo_.._frdAllowClose = this.O_.oOOo0_00.().Checked;
				IL_E9:
				num2 = 17;
				this.oOo0OoO.oO0oo_..NeedSaveSetting = true;
				IL_F8:
				num2 = 18;
				this.oOo0OoO.oO0oo_..Oo._0oO.();
				IL_106:
				num2 = 19;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				IL_123:
				num2 = 20;
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle);
				IL_136:
				num2 = 21;
				OO_00oOO.BaseMainForm.SuspendLayout();
				IL_143:
				num2 = 22;
				this.oOo0OoO.oO0oo_..Visible = false;
				IL_152:
				num2 = 23;
				this.oOo0OoO.oO0oo_..Visible = true;
				IL_161:
				num2 = 24;
				OO_00oOO.BaseMainForm.ResumeLayout();
				IL_16E:
				num2 = 25;
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				IL_17C:
				goto IL_236;
				IL_181:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1F7:
				goto IL_22B;
				IL_1F9:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_209:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1F9;
			}
			IL_22B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_236:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00171F68 File Offset: 0x00170168
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400157C RID: 5500
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400157D RID: 5501
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400157E RID: 5502
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400157F RID: 5503
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001580 RID: 5504
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001581 RID: 5505
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001582 RID: 5506
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001583 RID: 5507
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001584 RID: 5508
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001585 RID: 5509
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001586 RID: 5510
		private Table <<EMPTY_NAME>>;
	}
}
