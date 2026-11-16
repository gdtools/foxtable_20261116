using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000D3 RID: 211
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x0004D828 File Offset: 0x0004BA28
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O00_.__0OO. != null)
				{
					this.O00_.__0OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0004D868 File Offset: 0x0004BA68
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_O.O_oOo_.(new C1FlexGrid());
			this.O_.oo0o.(new C1ComboBox());
			this.o_O.O_oOo_.(new C1ComboBox());
			this.O_.oo0o.(new Label());
			this.oO.O_o__O0O.(new Label());
			this.O_.oo0o.(new C1FlexGrid());
			this.o__0oo._0o.(new Label());
			this.O00O0O.Oo__oOO.(new Label());
			this.O0O.0oo00__o0O.(new Label());
			this.oo.o_O00.(new Label());
			this.o_O.O_oOo_.(new C1Button());
			this.O_.oo0o.(new C1Button());
			this.O_.oo0o.(new C1CheckBox());
			this.o_O.O_oOo_.(new C1CheckBox());
			((ISupportInitialize)this.oOoOoO_OO.0o.()).BeginInit();
			((ISupportInitialize)this.o00.oo__O_o.()).BeginInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).BeginInit();
			((ISupportInitialize)this.o00.oo__O_o.()).BeginInit();
			((ISupportInitialize)this.o00.oo__O_o.()).BeginInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).BeginInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).BeginInit();
			((ISupportInitialize)this.o00.oo__O_o.()).BeginInit();
			base.SuspendLayout();
			this.oOoOoO_OO.0o.().AllowAddNew = true;
			this.oOoOoO_OO.0o.().AllowDelete = true;
			this.oOoOoO_OO.0o.().AutoClipboard = true;
			this.oOoOoO_OO.0o.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.oOoOoO_OO.0o.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}\t";
			this.oOoOoO_OO.0o.().ExtendLastCol = true;
			this.oOoOoO_OO.0o.().HighLight = HighLightEnum.WithFocus;
			this.oOoOoO_OO.0o.().Location = new Point(22, 88);
			this.oOoOoO_OO.0o.().Name = "grdRelationCols";
			this.oOoOoO_OO.0o.().Rows.Count = 0;
			this.oOoOoO_OO.0o.().Rows.DefaultSize = 21;
			this.oOoOoO_OO.0o.().Rows.Fixed = 0;
			this.oOoOoO_OO.0o.().Size = new Size(526, 65);
			this.oOoOoO_OO.0o.().TabIndex = 2;
			this.o00.oo__O_o.().AllowSpinLoop = false;
			this.o00.oo__O_o.().Cursor = Cursors.Arrow;
			this.o00.oo__O_o.().DropDownStyle = DropDownStyle.DropDownList;
			this.o00.oo__O_o.().GapHeight = 0;
			this.o00.oo__O_o.().ImagePadding = new Padding(0);
			this.o00.oo__O_o.().ItemsDisplayMember = "";
			this.o00.oo__O_o.().ItemsValueMember = "";
			this.o00.oo__O_o.().Location = new Point(285, 39);
			this.o00.oo__O_o.().Name = "cmbDestinationTable";
			this.o00.oo__O_o.().Size = new Size(263, 19);
			this.o00.oo__O_o.().TabIndex = 1;
			this.o00.oo__O_o.().Tag = null;
			this.o0_00.0O0oO.().AllowSpinLoop = false;
			this.o0_00.0O0oO.().Cursor = Cursors.Arrow;
			this.o0_00.0O0oO.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0_00.0O0oO.().GapHeight = 0;
			this.o0_00.0O0oO.().ImagePadding = new Padding(0);
			this.o0_00.0O0oO.().ItemsDisplayMember = "";
			this.o0_00.0O0oO.().ItemsValueMember = "";
			this.o0_00.0O0oO.().Location = new Point(22, 39);
			this.o0_00.0O0oO.().Name = "cmbSourceTable";
			this.o0_00.0O0oO.().Size = new Size(263, 19);
			this.o0_00.0O0oO.().TabIndex = 0;
			this.o0_00.0O0oO.().Tag = null;
			this.o0_ooooO._O.().AutoSize = true;
			this.o0_ooooO._O.().Location = new Point(283, 18);
			this.o0_ooooO._O.().Name = "Label2";
			this.o0_ooooO._O.().Size = new Size(47, 12);
			this.o0_ooooO._O.().TabIndex = 6;
			this.o0_ooooO._O.().Tag = "子表";
			this.o0_ooooO._O.().Text = "目标表:";
			this.Oo.o_.().AutoSize = true;
			this.Oo.o_.().Location = new Point(22, 18);
			this.Oo.o_.().Name = "Label1";
			this.Oo.o_.().Size = new Size(47, 12);
			this.Oo.o_.().TabIndex = 4;
			this.Oo.o_.().Text = "来源表:";
			this.o00.oo__O_o.().AllowAddNew = true;
			this.o00.oo__O_o.().AllowDelete = true;
			this.o00.oo__O_o.().AutoClipboard = true;
			this.o00.oo__O_o.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.o00.oo__O_o.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}\t";
			this.o00.oo__O_o.().ExtendLastCol = true;
			this.o00.oo__O_o.().HighLight = HighLightEnum.WithFocus;
			this.o00.oo__O_o.().Location = new Point(22, 183);
			this.o00.oo__O_o.().Name = "grdDataCols";
			this.o00.oo__O_o.().Rows.Count = 0;
			this.o00.oo__O_o.().Rows.DefaultSize = 21;
			this.o00.oo__O_o.().Rows.Fixed = 0;
			this.o00.oo__O_o.().Size = new Size(526, 149);
			this.o00.oo__O_o.().TabIndex = 3;
			this.oo.O_o_oO.().AutoSize = true;
			this.oo.O_o_oO.().Location = new Point(283, 69);
			this.oo.O_o_oO.().Name = "lblre2";
			this.oo.O_o_oO.().Size = new Size(47, 12);
			this.oo.O_o_oO.().TabIndex = 10;
			this.oo.O_o_oO.().Tag = "子表";
			this.oo.O_o_oO.().Text = "关联列:";
			this.O.oo_000_.().AutoSize = true;
			this.O.oo_000_.().Location = new Point(22, 69);
			this.O.oo_000_.().Name = "lbre1";
			this.O.oo_000_.().Size = new Size(47, 12);
			this.O.oo_000_.().TabIndex = 9;
			this.O.oo_000_.().Text = "关联列:";
			this.oOoOoO_OO.0o.().AutoSize = true;
			this.oOoOoO_OO.0o.().Location = new Point(283, 164);
			this.oOoOoO_OO.0o.().Name = "Label5";
			this.oOoOoO_OO.0o.().Size = new Size(47, 12);
			this.oOoOoO_OO.0o.().TabIndex = 12;
			this.oOoOoO_OO.0o.().Tag = "子表";
			this.oOoOoO_OO.0o.().Text = "目标列:";
			this.o.o_o__.().AutoSize = true;
			this.o.o_o__.().Location = new Point(22, 164);
			this.o.o_o__.().Name = "Label6";
			this.o.o_o__.().Size = new Size(47, 12);
			this.o.o_o__.().TabIndex = 11;
			this.o.o_o__.().Text = "来源列:";
			this.o00.oo__O_o.().Location = new Point(204, 382);
			this.o00.oo__O_o.().Name = "btnOK";
			this.o00.oo__O_o.().Size = new Size(75, 23);
			this.o00.oo__O_o.().TabIndex = 6;
			this.o00.oo__O_o.().Text = "确定";
			this.o00.oo__O_o.().UseVisualStyleBackColor = true;
			this.o0_00.0O0oO.().DialogResult = DialogResult.Cancel;
			this.o0_00.0O0oO.().Location = new Point(291, 382);
			this.o0_00.0O0oO.().Name = "btnCancel";
			this.o0_00.0O0oO.().Size = new Size(75, 23);
			this.o0_00.0O0oO.().TabIndex = 7;
			this.o0_00.0O0oO.().Text = "取消";
			this.o0_00.0O0oO.().UseVisualStyleBackColor = true;
			this.o0_00.0O0oO.().BorderStyle = BorderStyle.None;
			this.o0_00.0O0oO.().Checked = true;
			this.o0_00.0O0oO.().CheckState = CheckState.Checked;
			this.o0_00.0O0oO.().Location = new Point(164, 338);
			this.o0_00.0O0oO.().Name = "chkAutoAddNew";
			this.o0_00.0O0oO.().Size = new Size(115, 24);
			this.o0_00.0O0oO.().TabIndex = 5;
			this.o0_00.0O0oO.().Text = "自动追加新行";
			this.o0_00.0O0oO.().UseVisualStyleBackColor = true;
			this.o0_00.0O0oO.().Value = true;
			this.o00.oo__O_o.().BorderStyle = BorderStyle.None;
			this.o00.oo__O_o.().Checked = true;
			this.o00.oo__O_o.().CheckState = CheckState.Checked;
			this.o00.oo__O_o.().Location = new Point(24, 338);
			this.o00.oo__O_o.().Name = "chkAutoUpdate";
			this.o00.oo__O_o.().Size = new Size(117, 24);
			this.o00.oo__O_o.().TabIndex = 4;
			this.o00.oo__O_o.().Text = "自动更新数据";
			this.o00.oo__O_o.().UseVisualStyleBackColor = true;
			this.o00.oo__O_o.().Value = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(571, 421);
			base.Controls.Add(this.o00.oo__O_o.());
			base.Controls.Add(this.o0_00.0O0oO.());
			base.Controls.Add(this.o0_00.0O0oO.());
			base.Controls.Add(this.o00.oo__O_o.());
			base.Controls.Add(this.oOoOoO_OO.0o.());
			base.Controls.Add(this.o.o_o__.());
			base.Controls.Add(this.oo.O_o_oO.());
			base.Controls.Add(this.O.oo_000_.());
			base.Controls.Add(this.o00.oo__O_o.());
			base.Controls.Add(this.oOoOoO_OO.0o.());
			base.Controls.Add(this.o00.oo__O_o.());
			base.Controls.Add(this.o0_00.0O0oO.());
			base.Controls.Add(this.o0_ooooO._O.());
			base.Controls.Add(this.Oo.o_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o_0.0...o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "批量更新数据";
			((ISupportInitialize)this.oOoOoO_OO.0o.()).EndInit();
			((ISupportInitialize)this.o00.oo__O_o.()).EndInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).EndInit();
			((ISupportInitialize)this.o00.oo__O_o.()).EndInit();
			((ISupportInitialize)this.o00.oo__O_o.()).EndInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).EndInit();
			((ISupportInitialize)this.o0_00.0O0oO.()).EndInit();
			((ISupportInitialize)this.o00.oo__O_o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0004E2DE File Offset: 0x0004C4DE
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O00_.__0OO.;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.Oo.o_.);
			C1FlexGrid o00_.__0OO. = this.O00_.__0OO.;
			if (o00_.__0OO. != null)
			{
				o00_.__0OO..AfterEdit -= value;
			}
			this.O00_.__0OO. = A_0;
			o00_.__0OO. = this.O00_.__0OO.;
			if (o00_.__0OO. != null)
			{
				o00_.__0OO..AfterEdit += value;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0004E32B File Offset: 0x0004C52B
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oo.o_O00.;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0004E334 File Offset: 0x0004C534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0_Oo_._.);
			C1ComboBox c1ComboBox = this.oo.o_O00.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.oo.o_O00. = A_0;
			c1ComboBox = this.oo.o_O00.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0004E377 File Offset: 0x0004C577
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o.o_o_0000_.;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0004E380 File Offset: 0x0004C580
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0o.0.);
			C1ComboBox c1ComboBox = this.o.o_o_0000_.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o.o_o_0000_. = A_0;
			c1ComboBox = this.o.o_o_0000_.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0004E3C3 File Offset: 0x0004C5C3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O00_.__0OO.;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0004E3CB File Offset: 0x0004C5CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O00_.__0OO. = A_0;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0004E3D4 File Offset: 0x0004C5D4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOo_.o.;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0004E3DC File Offset: 0x0004C5DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOo_.o. = A_0;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004E3E5 File Offset: 0x0004C5E5
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OOo_.o.;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0004E3F0 File Offset: 0x0004C5F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.Oo.o_.);
			C1FlexGrid ooo_.o. = this.OOo_.o.;
			if (ooo_.o. != null)
			{
				ooo_.o..AfterEdit -= value;
			}
			this.OOo_.o. = A_0;
			ooo_.o. = this.OOo_.o.;
			if (ooo_.o. != null)
			{
				ooo_.o..AfterEdit += value;
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0004E433 File Offset: 0x0004C633
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.oO0O__o_0o0.;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0004E43B File Offset: 0x0004C63B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.oO0O__o_0o0. = A_0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0004E444 File Offset: 0x0004C644
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O00oo0_0oo.0O.;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0004E44C File Offset: 0x0004C64C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O00oo0_0oo.0O. = A_0;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0004E455 File Offset: 0x0004C655
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.0_o.;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0004E45D File Offset: 0x0004C65D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.0_o. = A_0;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0004E466 File Offset: 0x0004C666
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o00O0.Ooo0O0.;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0004E46E File Offset: 0x0004C66E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o00O0.Ooo0O0. = A_0;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0004E477 File Offset: 0x0004C677
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo.o_O00.;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0004E480 File Offset: 0x0004C680
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.oo_.);
			C1Button c1Button = this.oo.o_O00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo.o_O00. = A_0;
			c1Button = this.oo.o_O00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0004E4C3 File Offset: 0x0004C6C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o_o_0000_.;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0004E4CB File Offset: 0x0004C6CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o.o_o_0000_. = A_0;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oo.o_O00.;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0004E4DC File Offset: 0x0004C6DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oo.o_O00. = A_0;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0004E4E5 File Offset: 0x0004C6E5
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o.o_o_0000_.;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0004E4ED File Offset: 0x0004C6ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o.o_o_0000_. = A_0;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
		public o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000(bool A_0 = false)
		{
			base.Load += this.oO.o0o__.;
			base.FormClosed += this.o00.oo__O_o.;
			this.Oo.o_.();
			this.O00_.__0OO. = A_0;
			if (A_0)
			{
				Control[] array = new Control[]
				{
					this.O.oo_000_.(),
					this.oo.O_o_oO.(),
					this.oOoOoO_OO.0o.()
				};
				checked
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Visible = false;
					}
				}
				try
				{
					foreach (object obj in base.Controls)
					{
						Control control = (Control)obj;
						if (control.Top > this.oOoOoO_OO.0o.().Top)
						{
							if (control is C1Button)
							{
								control.Top -= 110;
							}
							else
							{
								control.Top -= 95;
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
				base.Height -= 110;
				this.o0_00.0O0oO.().Visible = false;
				this.o00.oo__O_o.().Visible = false;
				this.Text = "批量复制数据";
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0004E634 File Offset: 0x0004C834
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if (!dataTable.frd_IsTemporary)
					{
						this.o0_00.0O0oO.().Items.Add(dataTable.Name);
						this.o00.oo__O_o.().Items.Add(dataTable.Name);
					}
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

		// Token: 0x0600097F RID: 2431 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0_00.0O0oO.().SelectedItem != null)
			{
				string a_ = Conversions.ToString(this.o0_00.0O0oO.().SelectedItem);
				this.oOoOoO_OO.0o.().Cols[0].ComboList = this.Oo.o_.(OO_00oOO.DataTables[a_]);
				this.o00.oo__O_o.().Cols[0].ComboList = this.oOoOoO_OO.0o.().Cols[0].ComboList;
				foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
				{
					this.oOoOoO_OO.0o.(),
					this.o00.oo__O_o.()
				})
				{
					int num = c1FlexGrid.Rows.Count - 1;
					for (int j = 0; j <= num; j++)
					{
						if (Operators.CompareString(Conversions.ToString(c1FlexGrid[j, 0]), "", true) > 0 && !OO_00oOO.DataTables[Conversions.ToString(this.o0_00.0O0oO.().SelectedItem)].DataCols.Contains(Conversions.ToString(c1FlexGrid[j, 0])))
						{
							c1FlexGrid[j, 0] = "";
						}
					}
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o00.oo__O_o.().SelectedItem != null)
			{
				this.oOoOoO_OO.0o.().Cols[1].ComboList = this.Oo.o_.(OO_00oOO.DataTables[Conversions.ToString(this.o00.oo__O_o.().SelectedItem)]);
				this.o00.oo__O_o.().Cols[1].ComboList = this.oOoOoO_OO.0o.().Cols[1].ComboList;
				foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
				{
					this.oOoOoO_OO.0o.(),
					this.o00.oo__O_o.()
				})
				{
					int num = c1FlexGrid.Rows.Count - 1;
					for (int j = 0; j <= num; j++)
					{
						if (Operators.CompareString(Conversions.ToString(c1FlexGrid[j, 1]), "", true) > 0 && !OO_00oOO.DataTables[Conversions.ToString(this.o00.oo__O_o.().SelectedItem)].DataCols.Contains(Conversions.ToString(c1FlexGrid[j, 1])))
						{
							c1FlexGrid[j, 1] = "";
						}
					}
				}
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0004E920 File Offset: 0x0004CB20
		private string <<EMPTY_NAME>>(DataTable A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (DataCol dataCol in A_0.DataCols)
				{
					if (!dataCol.IsTemporary)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("|");
						}
						stringBuilder.Append(dataCol.Name);
					}
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0004E99C File Offset: 0x0004CB9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0_00.0O0oO.().SelectedItem != null && this.o00.oo__O_o.().SelectedItem != null)
			{
				string a_ = this.o0_00.0O0oO.().SelectedItem.ToString();
				string a_2 = this.o00.oo__O_o.().SelectedItem.ToString();
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>();
				List<string> list4 = new List<string>();
				int num = this.oOoOoO_OO.0o.().Rows.Count - 2;
				for (int i = 0; i <= num; i++)
				{
					if (this.oOoOoO_OO.0o.().GetData(i, 0) != null && this.oOoOoO_OO.0o.().GetData(i, 1) != null)
					{
						list.Add(this.oOoOoO_OO.0o.().GetData(i, 0).ToString());
						list2.Add(this.oOoOoO_OO.0o.().GetData(i, 1).ToString());
					}
				}
				int num2 = this.o00.oo__O_o.().Rows.Count - 2;
				for (int j = 0; j <= num2; j++)
				{
					if (this.o00.oo__O_o.().GetData(j, 0) != null && this.o00.oo__O_o.().GetData(j, 1) != null)
					{
						string item = this.o00.oo__O_o.().GetData(j, 0).ToString();
						string item2 = this.o00.oo__O_o.().GetData(j, 1).ToString();
						if (!list.Contains(item) && !list2.Contains(item2))
						{
							list3.Add(item);
							list4.Add(item2);
						}
					}
				}
				if ((list.Count != 0 || this.O00_.__0OO.) && list3.Count != 0)
				{
					if (this.O00_.__0OO.)
					{
						DataView dataView = new DataView(OO_00oOO.DataTables[a_].BaseTable, OO_00oOO.Tables[a_].Filter, "", DataViewRowState.CurrentRows);
						DataTable dataTable = OO_00oOO.DataTables[a_2].BaseTable;
						int num3 = dataView.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							DataRow dataRow = dataTable.NewRow();
							int num4 = list4.Count - 1;
							for (int l = 0; l <= num4; l++)
							{
								dataRow[list4[l]] = RuntimeHelpers.GetObjectValue(dataView[k][list3[l]]);
							}
							dataTable.Rows.Add(dataRow);
						}
					}
					else
					{
						DataView dataView2 = new DataView(OO_00oOO.DataTables[a_].BaseTable, OO_00oOO.Tables[a_].Filter, string.Join(",", list), DataViewRowState.CurrentRows);
						DataView dataView3 = new DataView(OO_00oOO.DataTables[a_2].BaseTable, "", string.Join(",", list2), DataViewRowState.CurrentRows);
						object[] array = new object[list.Count - 1 + 1];
						object[] array2 = new object[list.Count - 1 + 1];
						int num5 = dataView2.Count - 1;
						int m = 0;
						while (m <= num5)
						{
							int num6 = array.Length - 1;
							for (int n = 0; n <= num6; n++)
							{
								array[n] = RuntimeHelpers.GetObjectValue(dataView2[m][list[n]]);
							}
							if (m <= 0)
							{
								goto IL_366;
							}
							bool flag = true;
							int num7 = array.Length - 1;
							for (int num8 = 0; num8 <= num7; num8++)
							{
								if (Operators.CompareString(array[num8].ToString(), array2[num8].ToString(), true) != 0)
								{
									flag = false;
									break;
								}
							}
							if (!flag)
							{
								goto IL_366;
							}
							IL_46D:
							m++;
							continue;
							IL_366:
							DataRowView[] array3 = dataView3.FindRows(array);
							if (!this.o00.oo__O_o.().Checked && array3.Length > 0)
							{
								array3 = new DataRowView[0];
							}
							else if (array3.Length == 0 && this.o0_00.0O0oO.().Checked)
							{
								DataRowView dataRowView = dataView3.AddNew();
								int num9 = list2.Count - 1;
								for (int num10 = 0; num10 <= num9; num10++)
								{
									dataRowView[list2[num10]] = RuntimeHelpers.GetObjectValue(array[num10]);
								}
								dataRowView.EndEdit();
								array3 = new DataRowView[]
								{
									dataRowView
								};
							}
							foreach (DataRowView dataRowView2 in array3)
							{
								int num12 = list4.Count - 1;
								for (int num13 = 0; num13 <= num12; num13++)
								{
									dataRowView2[list4[num13]] = RuntimeHelpers.GetObjectValue(dataView2[m][list3[num13]]);
								}
								dataRowView2.EndEdit();
							}
							Array.Copy(array, array2, array.Length);
							goto IL_46D;
						}
					}
					base.DialogResult = DialogResult.OK;
				}
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0004EE2C File Offset: 0x0004D02C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.o0_00.0O0oO.().SelectedItem != null && this.o00.oo__O_o.().SelectedItem != null)
			{
				this.o0_00.0O0oO.().SelectedItem.ToString();
				string a_ = this.o00.oo__O_o.().SelectedItem.ToString();
				if (A_1.Col == 0)
				{
					C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
					string text = c1FlexGrid.GetData(A_1.Row, 0).ToString();
					if (OO_00oOO.DataTables[a_].BaseTable.Columns.Contains(text))
					{
						c1FlexGrid[A_1.Row, 1] = text;
					}
				}
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0004EEC2 File Offset: 0x0004D0C2
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400035F RID: 863
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000360 RID: 864
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000361 RID: 865
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000362 RID: 866
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000363 RID: 867
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000364 RID: 868
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000365 RID: 869
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000366 RID: 870
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000367 RID: 871
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000368 RID: 872
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000369 RID: 873
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400036A RID: 874
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400036B RID: 875
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400036C RID: 876
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400036D RID: 877
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400036E RID: 878
		private bool <<EMPTY_NAME>>;
	}
}
