using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000188 RID: 392
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x06001276 RID: 4726 RVA: 0x000818D0 File Offset: 0x0007FAD0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0OO0OoOO0._. != null)
				{
					this.O0OO0OoOO0._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00081910 File Offset: 0x0007FB10
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0OO0OoOO0._. = new Container();
			this.o_O_00.0O0.(new TreeView());
			this.O__o__.O_.(new C1Button());
			this.o_.00ooo_O0.(new C1Button());
			this.oO0Oo0.0_oO0oO.(new C1Button());
			this.OOo0oOo._.(new C1Button());
			this.oOoo0.O_0__.(new C1Button());
			this.o.oOO0O0o.(new C1Button());
			this.oOo_.o_O0__0.(new C1Button());
			this.o00ooo_0.ooOO.(new C1Button());
			this.o_O_00.0O0.(new PropertyGrid());
			this.o0.0o_0o0o__.(new C1Button());
			this.oo0_oO_O_o.0o.(new C1Button());
			this.O_.O_OoOOo__.(new ContextMenuStrip(this.O0OO0OoOO0._.));
			this.oO0o._O_0000oo.(new ToolStripMenuItem());
			this.o0.0o_0o0o__.(new ToolStripMenuItem());
			this.O_.O_OoOOo__.(new ToolStripMenuItem());
			this.OooOO.0__.(new ToolStripMenuItem());
			this.O_.O_OoOOo__.(new C1Button());
			this.oooO0o_Oo00.0_.(new C1Button());
			this.o.0__0O.(new C1Button());
			this.ooOO0_OO.o000.().SuspendLayout();
			base.SuspendLayout();
			this.O.o_0O0.().HideSelection = false;
			this.O.o_0O0.().Location = new Point(12, 15);
			this.O.o_0O0.().Name = "TreeView1";
			this.O.o_0O0.().Size = new Size(204, 472);
			this.O.o_0O0.().TabIndex = 0;
			this.Oo_0_.o.().Location = new Point(223, 16);
			this.Oo_0_.o.().Name = "btnAddMenu";
			this.Oo_0_.o.().Size = new Size(84, 23);
			this.Oo_0_.o.().TabIndex = 1;
			this.Oo_0_.o.().Text = "增加菜单";
			this.Oo_0_.o.().UseVisualStyleBackColor = true;
			this.oO0_O._o_O.().Location = new Point(223, 46);
			this.oO0_O._o_O.().Name = "btnAddCommand";
			this.oO0_O._o_O.().Size = new Size(84, 23);
			this.oO0_O._o_O.().TabIndex = 2;
			this.oO0_O._o_O.().Text = "增加项";
			this.oO0_O._o_O.().UseVisualStyleBackColor = true;
			this.O00_o0.o_00_.().Location = new Point(223, 76);
			this.O00_o0.o_00_.().Name = "btnAddChild";
			this.O00_o0.o_00_.().Size = new Size(84, 23);
			this.O00_o0.o_00_.().TabIndex = 3;
			this.O00_o0.o_00_.().Text = "增加子项";
			this.O00_o0.o_00_.().UseVisualStyleBackColor = true;
			this.o__O.o00O0Oo.().Location = new Point(223, 106);
			this.o__O.o00O0Oo.().Name = "btnDelete";
			this.o__O.o00O0Oo.().Size = new Size(84, 23);
			this.o__O.o00O0Oo.().TabIndex = 4;
			this.o__O.o00O0Oo.().Text = "删除";
			this.o__O.o00O0Oo.().UseVisualStyleBackColor = true;
			this.O_oO0O.o_oo.().Location = new Point(223, 154);
			this.O_oO0O.o_oo.().Name = "btnMoveUP";
			this.O_oO0O.o_oo.().Size = new Size(84, 23);
			this.O_oO0O.o_oo.().TabIndex = 5;
			this.O_oO0O.o_oo.().Text = "上移";
			this.O_oO0O.o_oo.().UseVisualStyleBackColor = true;
			this.Oo_0O_0_.oO_.().Location = new Point(223, 184);
			this.Oo_0O_0_.oO_.().Name = "btnModeDown";
			this.Oo_0O_0_.oO_.().Size = new Size(84, 23);
			this.Oo_0O_0_.oO_.().TabIndex = 6;
			this.Oo_0O_0_.oO_.().Text = "下移";
			this.Oo_0O_0_.oO_.().UseVisualStyleBackColor = true;
			this.Oo._OO_.().Location = new Point(223, 213);
			this.Oo._OO_.().Name = "btnMoveLeft";
			this.Oo._OO_.().Size = new Size(84, 23);
			this.Oo._OO_.().TabIndex = 7;
			this.Oo._OO_.().Text = "左移";
			this.Oo._OO_.().UseVisualStyleBackColor = true;
			this.O.__O.().Location = new Point(223, 242);
			this.O.__O.().Name = "btnModeRight";
			this.O.__O.().Size = new Size(84, 23);
			this.O.__O.().TabIndex = 8;
			this.O.__O.().Text = "右移";
			this.O.__O.().UseVisualStyleBackColor = true;
			this.O.o_0O0.().Location = new Point(313, 16);
			this.O.o_0O0.().Name = "PropertyGrid1";
			this.O.o_0O0.().PropertySort = PropertySort.NoSort;
			this.O.o_0O0.().Size = new Size(392, 472);
			this.O.o_0O0.().TabIndex = 9;
			this.O.o_0O0.().ToolbarVisible = false;
			this.o_O___o_0.ooo_.().DialogResult = DialogResult.OK;
			this.o_O___o_0.ooo_.().Location = new Point(549, 501);
			this.o_O___o_0.ooo_.().Name = "btnOK";
			this.o_O___o_0.ooo_.().Size = new Size(75, 23);
			this.o_O___o_0.ooo_.().TabIndex = 10;
			this.o_O___o_0.ooo_.().Text = "确定";
			this.o_O___o_0.ooo_.().UseVisualStyleBackColor = true;
			this.O.OOoOO.().Location = new Point(630, 501);
			this.O.OOoOO.().Name = "btnCancel";
			this.O.OOoOO.().Size = new Size(75, 23);
			this.O.OOoOO.().TabIndex = 11;
			this.O.OOoOO.().Text = "取消";
			this.O.OOoOO.().UseVisualStyleBackColor = true;
			this.ooOO0_OO.o000.().Items.AddRange(new ToolStripItem[]
			{
				this.OO0.0ooO.(),
				this.o_O___o_0.ooo_.(),
				this.o.o_o0o_0o.(),
				this.ooOO0_OO.o000.()
			});
			this.ooOO0_OO.o000.().Name = "mnuAddMenu";
			this.ooOO0_OO.o000.().Size = new Size(149, 92);
			this.OO0.0ooO.().Name = "mnuAddMainMenu";
			this.OO0.0ooO.().Size = new Size(148, 22);
			this.OO0.0ooO.().Text = "增加主菜单";
			this.o_O___o_0.ooo_.().Name = "mnuAddToolBar";
			this.o_O___o_0.ooo_.().Size = new Size(148, 22);
			this.o_O___o_0.ooo_.().Text = "增加工具栏";
			this.o.o_o0o_0o.().Name = "mnuAddStatusBar";
			this.o.o_o0o_0o.().Size = new Size(148, 22);
			this.o.o_o0o_0o.().Text = "增加状态栏";
			this.ooOO0_OO.o000.().Name = "mnuAddContextMenu";
			this.ooOO0_OO.o000.().Size = new Size(148, 22);
			this.ooOO0_OO.o000.().Text = "增加快捷菜单";
			this.o.o_o0o_0o.().Location = new Point(12, 501);
			this.o.o_o0o_0o.().Name = "Button1";
			this.o.o_o0o_0o.().Size = new Size(75, 23);
			this.o.o_o0o_0o.().TabIndex = 12;
			this.o.o_o0o_0o.().Text = "存为模版";
			this.o.o_o0o_0o.().UseVisualStyleBackColor = true;
			this.oo0.0_oo0O00O0.().Location = new Point(93, 501);
			this.oo0.0_oo0O00O0.().Name = "Button2";
			this.oo0.0_oo0O00O0.().Size = new Size(75, 23);
			this.oo0.0_oo0O00O0.().TabIndex = 13;
			this.oo0.0_oo0O00O0.().Text = "调用模版";
			this.oo0.0_oo0O00O0.().UseVisualStyleBackColor = true;
			this.oOo.Oo00O.().Location = new Point(175, 501);
			this.oOo.Oo00O.().Name = "btnPreview";
			this.oOo.Oo00O.().Size = new Size(75, 23);
			this.oOo.Oo00O.().TabIndex = 14;
			this.oOo.Oo00O.().Text = "预览";
			this.oOo.Oo00O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(717, 534);
			base.Controls.Add(this.oOo.Oo00O.());
			base.Controls.Add(this.oo0.0_oo0O00O0.());
			base.Controls.Add(this.o.o_o0o_0o.());
			base.Controls.Add(this.O.OOoOO.());
			base.Controls.Add(this.o_O___o_0.ooo_.());
			base.Controls.Add(this.O.o_0O0.());
			base.Controls.Add(this.O.__O.());
			base.Controls.Add(this.Oo._OO_.());
			base.Controls.Add(this.Oo_0O_0_.oO_.());
			base.Controls.Add(this.O_oO0O.o_oo.());
			base.Controls.Add(this.o__O.o00O0Oo.());
			base.Controls.Add(this.O00_o0.o_00_.());
			base.Controls.Add(this.oO0_O._o_O.());
			base.Controls.Add(this.Oo_0_.o.());
			base.Controls.Add(this.O.o_0O0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DataTables";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "菜单编辑器";
			this.ooOO0_OO.o000.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000822BD File Offset: 0x000804BD
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.O0OO0OoOO0._.;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000822C8 File Offset: 0x000804C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.o_O_00.0O0.);
			TreeView o0OO0OoOO0._. = this.O0OO0OoOO0._.;
			if (o0OO0OoOO0._. != null)
			{
				o0OO0OoOO0._..AfterSelect -= value;
			}
			this.O0OO0OoOO0._. = A_0;
			o0OO0OoOO0._. = this.O0OO0OoOO0._.;
			if (o0OO0OoOO0._. != null)
			{
				o0OO0OoOO0._..AfterSelect += value;
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0008230B File Offset: 0x0008050B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O_00.0O0.;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00082314 File Offset: 0x00080514
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.o0__O.Oo0__.);
			C1Button c1Button = this.o_O_00.0O0.;
			if (c1Button != null)
			{
				c1Button.MouseDown -= value;
			}
			this.o_O_00.0O0. = A_0;
			c1Button = this.o_O_00.0O0.;
			if (c1Button != null)
			{
				c1Button.MouseDown += value;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00082357 File Offset: 0x00080557
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.OoO0_.;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00082360 File Offset: 0x00080560
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0Oo.0o_0O__.);
			C1Button o_.OoO0_. = this.O_.OoO0_.;
			if (o_.OoO0_. != null)
			{
				o_.OoO0_..Click -= value;
			}
			this.O_.OoO0_. = A_0;
			o_.OoO0_. = this.O_.OoO0_.;
			if (o_.OoO0_. != null)
			{
				o_.OoO0_..Click += value;
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000823A3 File Offset: 0x000805A3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_0.0.;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000823AC File Offset: 0x000805AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0ooOo_o.0o.);
			C1Button c1Button = this.o0_0.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_0.0. = A_0;
			c1Button = this.o0_0.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000823EF File Offset: 0x000805EF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0oO0_O_o0.0.;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000823F8 File Offset: 0x000805F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0_.Oo.);
			C1Button oo0oO0_O_o0.0. = this.Oo0oO0_O_o0.0.;
			if (oo0oO0_O_o0.0. != null)
			{
				oo0oO0_O_o0.0..Click -= value;
			}
			this.Oo0oO0_O_o0.0. = A_0;
			oo0oO0_O_o0.0. = this.Oo0oO0_O_o0.0.;
			if (oo0oO0_O_o0.0. != null)
			{
				oo0oO0_O_o0.0..Click += value;
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0008243B File Offset: 0x0008063B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oooO.o.;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00082444 File Offset: 0x00080644
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o0_.);
			C1Button c1Button = this.oooO.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oooO.o. = A_0;
			c1Button = this.oooO.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00082487 File Offset: 0x00080687
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00_oo0ooo._.;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00082490 File Offset: 0x00080690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.__O0O_.);
			C1Button o00_oo0ooo._. = this.O00_oo0ooo._.;
			if (o00_oo0ooo._. != null)
			{
				o00_oo0ooo._..Click -= value;
			}
			this.O00_oo0ooo._. = A_0;
			o00_oo0ooo._. = this.O00_oo0ooo._.;
			if (o00_oo0ooo._. != null)
			{
				o00_oo0ooo._..Click += value;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000824D3 File Offset: 0x000806D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.O.;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000824DC File Offset: 0x000806DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo00.OO_oO_o_.);
			C1Button oo_.O. = this.Oo_.O.;
			if (oo_.O. != null)
			{
				oo_.O..Click -= value;
			}
			this.Oo_.O. = A_0;
			oo_.O. = this.Oo_.O.;
			if (oo_.O. != null)
			{
				oo_.O..Click += value;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0008251F File Offset: 0x0008071F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0._0O.;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00082528 File Offset: 0x00080728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_0O.__Oo0.);
			C1Button c1Button = this.o0._0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0._0O. = A_0;
			c1Button = this.o0._0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0008256B File Offset: 0x0008076B
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.O0OO0OoOO0._.;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00082574 File Offset: 0x00080774
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O0oOOo_00O.oO_.);
			PropertyGrid o0OO0OoOO0._. = this.O0OO0OoOO0._.;
			if (o0OO0OoOO0._. != null)
			{
				o0OO0OoOO0._..PropertyValueChanged -= value;
			}
			this.O0OO0OoOO0._. = A_0;
			o0OO0OoOO0._. = this.O0OO0OoOO0._.;
			if (o0OO0OoOO0._. != null)
			{
				o0OO0OoOO0._..PropertyValueChanged += value;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000825B7 File Offset: 0x000807B7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooOo_0.o.;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000825C0 File Offset: 0x000807C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_._OOo_oo_.);
			C1Button c1Button = this.ooOo_0.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooOo_0.o. = A_0;
			c1Button = this.ooOo_0.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00082603 File Offset: 0x00080803
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_._oO0___o.;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0008260C File Offset: 0x0008080C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.O0__0.);
			C1Button o_._oO0___o. = this.O_._oO0___o.;
			if (o_._oO0___o. != null)
			{
				o_._oO0___o..Click -= value;
			}
			this.O_._oO0___o. = A_0;
			o_._oO0___o. = this.O_._oO0___o.;
			if (o_._oO0___o. != null)
			{
				o_._oO0___o..Click += value;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0008264F File Offset: 0x0008084F
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.O0OO0OoOO0._.;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00082657 File Offset: 0x00080857
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.O0OO0OoOO0._. = A_0;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00082660 File Offset: 0x00080860
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O00_.oOo.;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00082674 File Offset: 0x00080874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0Oo._o.);
				ToolStripMenuItem o00_.oOo. = this.O00_.oOo.;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						o00_.oOo..Click += value;
						num = 4;
						continue;
					case 1:
						o00_.oOo..Click -= value;
						num = 5;
						continue;
					case 2:
						if (true)
						{
						}
						if (o00_.oOo. != null)
						{
							num = 1;
							continue;
						}
						goto IL_62;
					case 3:
						if (o00_.oOo. != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						goto IL_62;
					}
					break;
					IL_62:
					this.O00_.oOo. = A_0;
					o00_.oOo. = this.O00_.oOo.;
					num = 3;
				}
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00082720 File Offset: 0x00080920
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o__0o._O.;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00082734 File Offset: 0x00080934
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oOOOO00.O.);
				ToolStripMenuItem toolStripMenuItem = this.o__0o._O.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 1:
						goto IL_62;
					case 2:
						return;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						toolStripMenuItem.Click -= value;
						num = 1;
						continue;
					case 5:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 4;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.o__0o._O. = A_0;
					toolStripMenuItem = this.o__0o._O.;
					num = 3;
				}
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000827E0 File Offset: 0x000809E0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0o.O.;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000827F4 File Offset: 0x000809F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0_oo.O00oO.);
				ToolStripMenuItem toolStripMenuItem = this.o0o.O.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_5A;
					case 1:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 2:
						return;
					case 3:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 4:
						goto IL_5A;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					}
					break;
					IL_5A:
					this.o0o.O. = A_0;
					toolStripMenuItem = this.o0o.O.;
					num = 5;
				}
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0008289C File Offset: 0x00080A9C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0_0.00.;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000828B0 File Offset: 0x00080AB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oO.oOOO_o_0.);
				ToolStripMenuItem toolStripMenuItem = this.o0_0.00.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 2:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						return;
					case 4:
						goto IL_5A;
					case 5:
						toolStripMenuItem.Click += value;
						num = 0;
						continue;
					}
					break;
					IL_5A:
					this.o0_0.00. = A_0;
					toolStripMenuItem = this.o0_0.00.;
					num = 3;
				}
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00082956 File Offset: 0x00080B56
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.O000o_0.;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00082960 File Offset: 0x00080B60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo__.0O__.);
			C1Button c1Button = this.o_.O000o_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.O000o_0. = A_0;
			c1Button = this.o_.O000o_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000829A3 File Offset: 0x00080BA3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_0___.ooOoo.;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000829AC File Offset: 0x00080BAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.oOOoo0oooo.);
			C1Button c1Button = this.o0_0___.ooOoo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_0___.ooOoo. = A_0;
			c1Button = this.o0_0___.ooOoo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000829EF File Offset: 0x00080BEF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0OO_._.;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000829F8 File Offset: 0x00080BF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOOoOo._.);
			C1Button o0OO_._. = this.O0OO_._.;
			if (o0OO_._. != null)
			{
				o0OO_._..Click -= value;
			}
			this.O0OO_._. = A_0;
			o0OO_._. = this.O0OO_._.;
			if (o0OO_._. != null)
			{
				o0OO_._..Click += value;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00082A3C File Offset: 0x00080C3C
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			if (Operators.CompareString(A_1.ChangedItem.Label, "名称", true) == 0)
			{
				this.O.o_0O0.().SelectedNode.Text = A_1.ChangedItem.Value.ToString();
				this.O.o_0O0.().SelectedNode.Name = A_1.ChangedItem.Value.ToString();
			}
			if (Operators.CompareString(A_1.ChangedItem.Label, "类型", true) == 0 && this.O.o_0O0.().SelectedNode.Tag is FormMenuItemProperty)
			{
				FormMenuItemProperty formMenuItemProperty = (FormMenuItemProperty)this.O.o_0O0.().SelectedNode.Tag;
				if (formMenuItemProperty.Type != StripItemTypeEnum.Button && formMenuItemProperty.Type != StripItemTypeEnum.SplitButton)
				{
					formMenuItemProperty.DisplayText = true;
				}
				this.O.o_0O0.().SelectedObject = new o_0oooo_OO(RuntimeHelpers.GetObjectValue(this.O.o_0O0.().SelectedNode.Tag), new string[0], false, false);
				this.o_O_00.0O0.(this.O.o_0O0.().SelectedNode, ((FormMenuItemProperty)this.O.o_0O0.().SelectedNode.Tag).Type);
			}
			this.O0OO0OoOO0._. = true;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00082B68 File Offset: 0x00080D68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o_0O0.().SelectedNode != null)
			{
				TreeNodeCollection nodes;
				if (this.O.o_0O0.().SelectedNode.Level == 0)
				{
					nodes = this.O.o_0O0.().SelectedNode.Nodes;
				}
				else
				{
					nodes = this.O.o_0O0.().SelectedNode.Parent.Nodes;
				}
				int num = 1;
				string text;
				for (;;)
				{
					text = "项目" + num.ToString();
					if (!nodes.ContainsKey(text))
					{
						break;
					}
					num++;
				}
				TreeNode treeNode = new TreeNode();
				FormMenuItemProperty formMenuItemProperty = new FormMenuItemProperty();
				treeNode.Name = text;
				treeNode.Text = text;
				formMenuItemProperty.Text = text;
				formMenuItemProperty.Name = text;
				StripTypeEnum2 stripTypeEnum = StripTypeEnum2.主菜单;
				if (this.O.o_0O0.().SelectedNode.Level == 0)
				{
					stripTypeEnum = ((FormMenuProperty)this.O.o_0O0.().SelectedNode.Tag).Type;
				}
				else if (this.O.o_0O0.().SelectedNode.Level == 1)
				{
					stripTypeEnum = ((FormMenuProperty)this.O.o_0O0.().SelectedNode.Parent.Tag).Type;
				}
				switch (stripTypeEnum)
				{
				case StripTypeEnum2.主菜单:
				case StripTypeEnum2.快捷菜单:
					formMenuItemProperty.Type = StripItemTypeEnum.MenuItem;
					break;
				case StripTypeEnum2.工具栏:
					if (this.O.o_0O0.().SelectedNode.Level <= 1)
					{
						formMenuItemProperty.Type = StripItemTypeEnum.Button;
					}
					else
					{
						formMenuItemProperty.Type = StripItemTypeEnum.MenuItem;
					}
					break;
				case StripTypeEnum2.状态栏:
					if (this.O.o_0O0.().SelectedNode.Level <= 1)
					{
						formMenuItemProperty.Type = StripItemTypeEnum.Label;
					}
					else
					{
						formMenuItemProperty.Type = StripItemTypeEnum.MenuItem;
					}
					break;
				}
				if (this.O.o_0O0.() == StripTypeEnum2.工具栏)
				{
					if (this.O.o_0O0.().SelectedNode.Level <= 1)
					{
						formMenuItemProperty.DisplayText = false;
					}
					else
					{
						formMenuItemProperty.DisplayText = true;
					}
				}
				else
				{
					formMenuItemProperty.DisplayText = true;
				}
				treeNode.Tag = formMenuItemProperty;
				nodes.Add(treeNode);
				treeNode.EnsureVisible();
				this.O.o_0O0.().SelectedNode = treeNode;
				this.o_O_00.0O0.(treeNode, formMenuItemProperty.Type);
				this.O0OO0OoOO0._. = true;
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00082D5C File Offset: 0x00080F5C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o_0O0.().SelectedNode != null)
			{
				if (this.O.o_0O0.().SelectedNode.Tag is FormMenuItemProperty)
				{
					FormMenuItemProperty formMenuItemProperty = (FormMenuItemProperty)this.O.o_0O0.().SelectedNode.Tag;
					if (formMenuItemProperty.Type != StripItemTypeEnum.MenuItem && formMenuItemProperty.Type != StripItemTypeEnum.SplitButton)
					{
						return;
					}
				}
				TreeNodeCollection nodes = this.O.o_0O0.().SelectedNode.Nodes;
				int num = 1;
				string text;
				for (;;)
				{
					text = "项目" + num.ToString();
					if (!nodes.ContainsKey(text))
					{
						break;
					}
					num++;
				}
				TreeNode treeNode = new TreeNode();
				FormMenuItemProperty formMenuItemProperty2 = new FormMenuItemProperty();
				treeNode.Name = text;
				treeNode.Text = text;
				formMenuItemProperty2.Text = text;
				formMenuItemProperty2.Name = text;
				formMenuItemProperty2.Type = StripItemTypeEnum.MenuItem;
				if (this.O.o_0O0.() == StripTypeEnum2.工具栏)
				{
					if (this.O.o_0O0.().SelectedNode.Level == 0)
					{
						formMenuItemProperty2.Type = StripItemTypeEnum.Button;
						formMenuItemProperty2.DisplayText = false;
					}
					else
					{
						formMenuItemProperty2.DisplayText = true;
					}
				}
				else
				{
					formMenuItemProperty2.DisplayText = true;
				}
				treeNode.Tag = formMenuItemProperty2;
				nodes.Add(treeNode);
				treeNode.EnsureVisible();
				this.O.o_0O0.().SelectedNode = treeNode;
				this.o_O_00.0O0.(treeNode, formMenuItemProperty2.Type);
				this.O0OO0OoOO0._. = true;
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00082EA0 File Offset: 0x000810A0
		private StripTypeEnum2 <<EMPTY_NAME>>()
		{
			TreeNode treeNode = this.O.o_0O0.().SelectedNode;
			while (treeNode.Level != 0)
			{
				treeNode = treeNode.Parent;
			}
			return ((FormMenuProperty)treeNode.Tag).Type;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00082EDC File Offset: 0x000810DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o_0O0.().SelectedNode != null)
			{
				TreeView treeView = this.O.o_0O0.();
				if (treeView.SelectedNode.Level == 0)
				{
					treeView.Nodes.Remove(treeView.SelectedNode);
				}
				else
				{
					treeView.SelectedNode.Parent.Nodes.Remove(treeView.SelectedNode);
				}
				this.O0OO0OoOO0._. = true;
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00082F44 File Offset: 0x00081144
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.O.o_0O0.();
			if (treeView.SelectedNode != null)
			{
				TreeNode selectedNode = treeView.SelectedNode;
				int index = selectedNode.Index;
				if (index != 0)
				{
					TreeNodeCollection nodes;
					if (selectedNode.Parent == null)
					{
						nodes = treeView.Nodes;
					}
					else
					{
						nodes = selectedNode.Parent.Nodes;
					}
					nodes.Remove(selectedNode);
					nodes.Insert(index - 1, selectedNode);
					treeView.SelectedNode = selectedNode;
					selectedNode.EnsureVisible();
					this.O0OO0OoOO0._. = true;
				}
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00082FB8 File Offset: 0x000811B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.O.o_0O0.();
			if (treeView.SelectedNode != null)
			{
				TreeNode selectedNode = treeView.SelectedNode;
				int index = selectedNode.Index;
				TreeNodeCollection nodes;
				if (selectedNode.Parent == null)
				{
					nodes = treeView.Nodes;
				}
				else
				{
					nodes = selectedNode.Parent.Nodes;
				}
				if (index != nodes.Count - 1)
				{
					nodes.Remove(selectedNode);
					nodes.Insert(index + 1, selectedNode);
					treeView.SelectedNode = selectedNode;
					selectedNode.EnsureVisible();
					this.O0OO0OoOO0._. = true;
				}
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00083034 File Offset: 0x00081234
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o_0O0.().SelectedNode != null)
			{
				TreeNode selectedNode = this.O.o_0O0.().SelectedNode;
				if (selectedNode.Level != 0 && selectedNode.Level != 1)
				{
					int index = selectedNode.Parent.Index + 1;
					TreeNodeCollection nodes = selectedNode.Parent.Parent.Nodes;
					selectedNode.Parent.Nodes.Remove(selectedNode);
					nodes.Insert(index, selectedNode);
					selectedNode.TreeView.SelectedNode = selectedNode;
					selectedNode.EnsureVisible();
					this.O0OO0OoOO0._. = true;
				}
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000830BC File Offset: 0x000812BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeNode selectedNode = this.O.o_0O0.().SelectedNode;
			if (selectedNode != null && selectedNode.Level != 0 && selectedNode.Index != 0)
			{
				if (selectedNode.PrevNode.Tag is FormMenuItemProperty)
				{
					FormMenuItemProperty formMenuItemProperty = (FormMenuItemProperty)selectedNode.PrevNode.Tag;
					if (formMenuItemProperty.Type != StripItemTypeEnum.MenuItem && formMenuItemProperty.Type != StripItemTypeEnum.SplitButton)
					{
						return;
					}
				}
				TreeNodeCollection nodes = selectedNode.PrevNode.Nodes;
				if (selectedNode.Parent != null)
				{
					selectedNode.Parent.Nodes.Remove(selectedNode);
				}
				else
				{
					selectedNode.TreeView.Nodes.Remove(selectedNode);
				}
				nodes.Add(selectedNode);
				selectedNode.TreeView.SelectedNode = selectedNode;
				selectedNode.EnsureVisible();
				this.O0OO0OoOO0._. = true;
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00083180 File Offset: 0x00081380
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (this.O.o_0O0.().SelectedNode == null)
			{
				this.O.o_0O0.().SelectedObject = null;
				return;
			}
			this.O.o_0O0.().SelectedObject = new o_0oooo_OO(RuntimeHelpers.GetObjectValue(this.O.o_0O0.().SelectedNode.Tag), new string[0], false, false);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000831D4 File Offset: 0x000813D4
		private void <<EMPTY_NAME>>(TreeNodeCollection A_0, ref string A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					TreeNode treeNode = (TreeNode)obj;
					object objectValue = RuntimeHelpers.GetObjectValue(treeNode.Tag);
					if (Operators.CompareString(A_1, "", true) != 0)
					{
						A_1 += "\f";
					}
					if (treeNode.Level == 0)
					{
						A_1 += "\t";
					}
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(objectValue), false, '\t', false).Replace("\f", "");
					if (treeNode.Nodes.Count > 0)
					{
						A_1 += "\fInner";
						this.O.o_0O0.(treeNode.Nodes, ref A_1);
						A_1 += "\fOuter";
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

		// Token: 0x060012AB RID: 4779 RVA: 0x000832C8 File Offset: 0x000814C8
		internal string <<EMPTY_NAME>>()
		{
			string result = "";
			this.O.o_0O0.(this.O.o_0O0.().Nodes, ref result);
			return result;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000832F0 File Offset: 0x000814F0
		internal void <<EMPTY_NAME>>(string A_0)
		{
			string[] array = A_0.Split(new char[]
			{
				'\f'
			});
			TreeNodeCollection nodes = this.O.o_0O0.().Nodes;
			TreeNode treeNode = null;
			this.O.o_0O0.().BeginUpdate();
			foreach (string text in array)
			{
				if (Operators.CompareString(text, "Inner", true) == 0)
				{
					nodes = treeNode.Nodes;
				}
				else if (Operators.CompareString(text, "Outer", true) == 0)
				{
					if (nodes[0].Parent.Parent == null)
					{
						nodes = this.O.o_0O0.().Nodes;
					}
					else
					{
						nodes = nodes[0].Parent.Parent.Nodes;
					}
				}
				else
				{
					text = text.Trim(new char[]
					{
						'\t'
					});
					treeNode = new TreeNode();
					nodes.Add(treeNode);
					if (treeNode.Level == 0)
					{
						FormMenuProperty formMenuProperty = new FormMenuProperty();
						o_O_o_oOoo__.OOOO_OO._oo.(formMenuProperty, text, '\t');
						treeNode.Text = formMenuProperty.Name;
						treeNode.Name = formMenuProperty.Name;
						treeNode.Tag = formMenuProperty;
						this.o_O_00.0O0.(treeNode, formMenuProperty.Type);
					}
					else
					{
						FormMenuItemProperty formMenuItemProperty = new FormMenuItemProperty();
						o_O_o_oOoo__.OOOO_OO._oo.(formMenuItemProperty, text, '\t');
						treeNode.Text = formMenuItemProperty.Name;
						treeNode.Name = formMenuItemProperty.Name;
						treeNode.Tag = formMenuItemProperty;
						this.o_O_00.0O0.(treeNode, formMenuItemProperty.Type);
					}
				}
			}
			this.O.o_0O0.().EndUpdate();
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00083464 File Offset: 0x00081664
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0OO0OoOO0._.)
			{
				if (MessageBox.Show("确定要放弃修改吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.O0OO0OoOO0._. = false;
					base.DialogResult = DialogResult.Cancel;
					return;
				}
			}
			else
			{
				base.DialogResult = DialogResult.Cancel;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00083499 File Offset: 0x00081699
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.ooOO0_OO.o000.().Show(this.Oo_0_.o.(), 0, this.Oo_0_.o.().Height);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000834B8 File Offset: 0x000816B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0__O.Oo0__.(StripTypeEnum2.快捷菜单);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000834C4 File Offset: 0x000816C4
		private void <<EMPTY_NAME>>(StripTypeEnum2 A_0)
		{
			string name = Enum.GetName(typeof(StripTypeEnum2), A_0);
			string text = "";
			if (A_0 == StripTypeEnum2.主菜单 || A_0 == StripTypeEnum2.状态栏)
			{
				text = name;
				try
				{
					IEnumerator enumerator = this.O.o_0O0.().Nodes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (((FormMenuProperty)((TreeNode)enumerator.Current).Tag).Type == A_0)
						{
							MessageBox.Show("一个窗口只能有一个" + name + "!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
					}
					goto IL_C7;
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
			int num = 1;
			for (;;)
			{
				text = name + num.ToString();
				if (!this.O.o_0O0.().Nodes.ContainsKey(text))
				{
					break;
				}
				num++;
			}
			IL_C7:
			TreeNode treeNode = new TreeNode();
			FormMenuProperty formMenuProperty = new FormMenuProperty();
			formMenuProperty.Name = text;
			formMenuProperty.Type = A_0;
			treeNode.Name = text;
			treeNode.Text = text;
			treeNode.Tag = formMenuProperty;
			this.O.o_0O0.().Nodes.Add(treeNode);
			treeNode.EnsureVisible();
			this.O.o_0O0.().SelectedNode = treeNode;
			this.o_O_00.0O0.(treeNode, A_0);
			this.O0OO0OoOO0._. = true;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0008360C File Offset: 0x0008180C
		private void <<EMPTY_NAME>>(TreeNode A_0, StripTypeEnum2 A_1)
		{
			switch (A_1)
			{
			case StripTypeEnum2.主菜单:
				A_0.ImageKey = "MainMenu";
				break;
			case StripTypeEnum2.工具栏:
				A_0.ImageKey = "ToolBar";
				break;
			case StripTypeEnum2.状态栏:
				A_0.ImageKey = "StatusBar";
				break;
			case StripTypeEnum2.快捷菜单:
				A_0.ImageKey = "ContentMenu";
				break;
			}
			A_0.SelectedImageKey = A_0.ImageKey;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00083671 File Offset: 0x00081871
		private void <<EMPTY_NAME>>(TreeNode A_0, StripItemTypeEnum A_1)
		{
			A_0.ImageKey = Enum.GetName(typeof(StripItemTypeEnum), A_1);
			A_0.SelectedImageKey = A_0.ImageKey;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0008369A File Offset: 0x0008189A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0__O.Oo0__.(StripTypeEnum2.主菜单);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000836A3 File Offset: 0x000818A3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0__O.Oo0__.(StripTypeEnum2.工具栏);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000836AC File Offset: 0x000818AC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0__O.Oo0__.(StripTypeEnum2.状态栏);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000836B5 File Offset: 0x000818B5
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0OO0OoOO0._. = false;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000836C8 File Offset: 0x000818C8
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.O0OO0OoOO0._.)
			{
				DialogResult dialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
				if (dialogResult == DialogResult.No)
				{
					base.DialogResult = DialogResult.Cancel;
					return;
				}
				A_1.Cancel = true;
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00083714 File Offset: 0x00081914
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o_0O0.().Nodes.Count > 0)
			{
				string text = this.O0oOOo_00O.oO_.();
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "窗口菜单文件(*.Strip)|*.Strip";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					OO_00oOO.FileSys.WriteAllText(saveFileDialog.FileName, text, false, Encoding.Default);
				}
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0008376C File Offset: 0x0008196C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "窗口菜单文件(*.Strip)|*.Strip";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.O0OO0OoOO0._. = true;
				this.O.o_0O0.().Nodes.Clear();
				string a_ = OO_00oOO.FileSys.ReadAllText(openFileDialog.FileName, Encoding.Default);
				this.O.o_0O0.(a_);
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000837C8 File Offset: 0x000819C8
		public o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002()
		{
			base.FormClosing += this.Oo_0O_0_.oO_.;
			base.FormClosed += this.Oo_0O_0_.oO_.;
			this.O0OO0OoOO0._. = "(default)";
			this.O.o_0O0.();
			this.O.o_0O0.().ImageList = O_O0OO.OoO.0OO__0ooo.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00083835 File Offset: 0x00081A35
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u = new o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000();
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.o_Ooo._. = this.O0OO0OoOO0._.;
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.o_Ooo._.(this.O0oOOo_00O.oO_.());
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.ShowDialog();
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0008385A File Offset: 0x00081A5A
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000726 RID: 1830
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000727 RID: 1831
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04000728 RID: 1832
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000729 RID: 1833
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072A RID: 1834
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072B RID: 1835
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072C RID: 1836
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072D RID: 1837
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072E RID: 1838
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400072F RID: 1839
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000730 RID: 1840
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04000731 RID: 1841
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000732 RID: 1842
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000733 RID: 1843
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000734 RID: 1844
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000735 RID: 1845
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000736 RID: 1846
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000737 RID: 1847
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000738 RID: 1848
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000739 RID: 1849
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400073A RID: 1850
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400073B RID: 1851
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400073C RID: 1852
		internal string <<EMPTY_NAME>>;
	}
}
