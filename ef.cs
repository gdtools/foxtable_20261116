using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200035C RID: 860
	[DesignerGenerated]
	internal partial class ef : Form
	{
		// Token: 0x0600359D RID: 13725 RVA: 0x001731F8 File Offset: 0x001713F8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO.____oo. != null)
				{
					this.OO.____oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00173238 File Offset: 0x00171438
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ef));
			this.O_O.__OO____o.(new C1FlexGrid());
			this.O_O.__OO____o.(new C1Button());
			this.o_0.0.(new C1Button());
			this.O.0oooO.(new C1Button());
			this.O____O._0oo_.(new C1Button());
			this.o.0OOO.(new C1Button());
			this.O_O.__OO____o.(new ListBox());
			this.O.O0_O.(new C1Button());
			((ISupportInitialize)this.O.O00O0oOo_.()).BeginInit();
			base.SuspendLayout();
			this.O.O00O0oOo_.().AllowDragging = AllowDraggingEnum.None;
			this.O.O00O0oOo_.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.O.O00O0oOo_.().AutoClipboard = true;
			this.O.O00O0oOo_.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O.O00O0oOo_.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.O.O00O0oOo_.().ExtendLastCol = true;
			this.O.O00O0oOo_.().Font = new Font("宋体", 9f);
			this.O.O00O0oOo_.().Location = new Point(18, 18);
			this.O.O00O0oOo_.().Margin = new Padding(4, 4, 4, 4);
			this.O.O00O0oOo_.().Name = "C1FlexGrid1";
			this.O.O00O0oOo_.().Rows.Count = 1;
			this.O.O00O0oOo_.().Rows.DefaultSize = 21;
			this.O.O00O0oOo_.().SelectionMode = SelectionModeEnum.Cell;
			this.O.O00O0oOo_.().Size = new Size(731, 311);
			this.O.O00O0oOo_.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.O.O00O0oOo_.().TabIndex = 0;
			this.O.O00O0oOo_.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.OO0.o0o.().Location = new Point(836, 339);
			this.OO0.o0o.().Margin = new Padding(4, 4, 4, 4);
			this.OO0.o0o.().Name = "btnOK";
			this.OO0.o0o.().Size = new Size(112, 34);
			this.OO0.o0o.().TabIndex = 3;
			this.OO0.o0o.().Text = "筛选";
			this.OO0.o0o.().UseVisualStyleBackColor = true;
			this.o_0o.0oO0OO_.().Location = new Point(18, 339);
			this.o_0o.0oO0OO_.().Margin = new Padding(4, 4, 4, 4);
			this.o_0o.0oO0OO_.().Name = "btnDelete";
			this.o_0o.0oO0OO_.().Size = new Size(112, 34);
			this.o_0o.0oO0OO_.().TabIndex = 1;
			this.o_0o.0oO0OO_.().Text = "删除条件";
			this.o_0o.0oO0OO_.().UseVisualStyleBackColor = true;
			this.oOoo0__o00o.o.().Location = new Point(140, 339);
			this.oOoo0__o00o.o.().Margin = new Padding(4, 4, 4, 4);
			this.oOoo0__o00o.o.().Name = "btnClear";
			this.oOoo0__o00o.o.().Size = new Size(112, 34);
			this.oOoo0__o00o.o.().TabIndex = 2;
			this.oOoo0__o00o.o.().Text = "清除条件";
			this.oOoo0__o00o.o.().UseVisualStyleBackColor = true;
			this.o0.0_oo_Oo0O.().Location = new Point(261, 339);
			this.o0.0_oo_Oo0O.().Margin = new Padding(4, 4, 4, 4);
			this.o0.0_oo_Oo0O.().Name = "btnSave";
			this.o0.0_oo_Oo0O.().Size = new Size(112, 34);
			this.o0.0_oo_Oo0O.().TabIndex = 11;
			this.o0.0_oo_Oo0O.().Text = "保存设置";
			this.o0.0_oo_Oo0O.().UseVisualStyleBackColor = true;
			this.O._O0OO00_O.().Location = new Point(382, 339);
			this.O._O0OO00_O.().Margin = new Padding(4, 4, 4, 4);
			this.O._O0OO00_O.().Name = "btnList";
			this.O._O0OO00_O.().Size = new Size(112, 34);
			this.O._O0OO00_O.().TabIndex = 12;
			this.O._O0OO00_O.().Text = "设置管理";
			this.O._O0OO00_O.().UseVisualStyleBackColor = true;
			this.O.O00O0oOo_.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O.O00O0oOo_.().FormattingEnabled = true;
			this.O.O00O0oOo_.().IntegralHeight = false;
			this.O.O00O0oOo_.().ItemHeight = 18;
			this.O.O00O0oOo_.().Location = new Point(759, 18);
			this.O.O00O0oOo_.().Margin = new Padding(4, 4, 4, 4);
			this.O.O00O0oOo_.().Name = "ListBox1";
			this.O.O00O0oOo_.().Size = new Size(187, 310);
			this.O.O00O0oOo_.().TabIndex = 13;
			this.OO._O.().Location = new Point(714, 339);
			this.OO._O.().Margin = new Padding(4, 4, 4, 4);
			this.OO._O.().Name = "Button1";
			this.OO._O.().Size = new Size(112, 34);
			this.OO._O.().TabIndex = 14;
			this.OO._O.().Text = "撤销筛选";
			this.OO._O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(966, 388);
			base.Controls.Add(this.OO._O.());
			base.Controls.Add(this.O.O00O0oOo_.());
			base.Controls.Add(this.o0.0_oo_Oo0O.());
			base.Controls.Add(this.O._O0OO00_O.());
			base.Controls.Add(this.oOoo0__o00o.o.());
			base.Controls.Add(this.o_0o.0oO0OO_.());
			base.Controls.Add(this.OO0.o0o.());
			base.Controls.Add(this.O.O00O0oOo_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oo._.1_0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "高级筛选";
			((ISupportInitialize)this.O.O00O0oOo_.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00173864 File Offset: 0x00171A64
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OO.____oo.;
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0017386C File Offset: 0x00171A6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.O_O0_.0O.);
			EventHandler value2 = new EventHandler(this.O00O0.oo_0.);
			ValidateEditEventHandler value3 = new ValidateEditEventHandler(this.OO0.o0o.);
			C1FlexGrid oo.____oo. = this.OO.____oo.;
			if (oo.____oo. != null)
			{
				oo.____oo..AfterAddRow -= value;
				oo.____oo..EnterCell -= value2;
				oo.____oo..ValidateEdit -= value3;
			}
			this.OO.____oo. = A_0;
			oo.____oo. = this.OO.____oo.;
			if (oo.____oo. != null)
			{
				oo.____oo..AfterAddRow += value;
				oo.____oo..EnterCell += value2;
				oo.____oo..ValidateEdit += value3;
			}
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x001738E5 File Offset: 0x00171AE5
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O.__OO____o.;
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x001738F0 File Offset: 0x00171AF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o_o000Oo.);
			C1Button o_O.__OO____o. = this.O_O.__OO____o.;
			if (o_O.__OO____o. != null)
			{
				o_O.__OO____o..Click -= value;
			}
			this.O_O.__OO____o. = A_0;
			o_O.__OO____o. = this.O_O.__OO____o.;
			if (o_O.__OO____o. != null)
			{
				o_O.__OO____o..Click += value;
			}
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x00173933 File Offset: 0x00171B33
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.O0_O.;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0017393C File Offset: 0x00171B3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0.oOO_O__oO0.);
			C1Button o.O0_O. = this.O.O0_O.;
			if (o.O0_O. != null)
			{
				o.O0_O..Click -= value;
			}
			this.O.O0_O. = A_0;
			o.O0_O. = this.O.O0_O.;
			if (o.O0_O. != null)
			{
				o.O0_O..Click += value;
			}
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0017397F File Offset: 0x00171B7F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0OOO.;
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00173988 File Offset: 0x00171B88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOOo.o.);
			C1Button c1Button = this.o.0OOO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.0OOO. = A_0;
			c1Button = this.o.0OOO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x001739CB File Offset: 0x00171BCB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_0._o0oO.;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x001739D4 File Offset: 0x00171BD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo00OO_00o.o0_.);
			C1Button o0_0._o0oO. = this.O0_0._o0oO.;
			if (o0_0._o0oO. != null)
			{
				o0_0._o0oO..Click -= value;
			}
			this.O0_0._o0oO. = A_0;
			o0_0._o0oO. = this.O0_0._o0oO.;
			if (o0_0._o0oO. != null)
			{
				o0_0._o0oO..Click += value;
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00173A17 File Offset: 0x00171C17
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_o_.0.;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00173A20 File Offset: 0x00171C20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.o0.);
			C1Button ooo_o_.0. = this.Ooo_o_.0.;
			if (ooo_o_.0. != null)
			{
				ooo_o_.0..Click -= value;
			}
			this.Ooo_o_.0. = A_0;
			ooo_o_.0. = this.Ooo_o_.0.;
			if (ooo_o_.0. != null)
			{
				ooo_o_.0..Click += value;
			}
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00173A63 File Offset: 0x00171C63
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.OO.____oo.;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00173A6C File Offset: 0x00171C6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O.O00O0oOo_.);
			ListBox oo.____oo. = this.OO.____oo.;
			if (oo.____oo. != null)
			{
				oo.____oo..MouseDoubleClick -= value;
			}
			this.OO.____oo. = A_0;
			oo.____oo. = this.OO.____oo.;
			if (oo.____oo. != null)
			{
				oo.____oo..MouseDoubleClick += value;
			}
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00173AAF File Offset: 0x00171CAF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_._oo_.;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00173AB8 File Offset: 0x00171CB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O0_.0O.);
			C1Button c1Button = this.o0_._oo_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_._oo_. = A_0;
			c1Button = this.o0_._oo_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00173AFC File Offset: 0x00171CFC
		public ef(Table A_0)
		{
			base.FormClosing += this.OO0.o0o.;
			base.Load += this.oO_0_o_.00O.;
			base.FormClosed += this.OO0.o0o.;
			this.OO.____oo. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			this.O.O00O0oOo_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			C1FlexGrid c1FlexGrid = this.O.O00O0oOo_.();
			c1FlexGrid.Styles.SelectedColumnHeader.Clear();
			c1FlexGrid.Styles.Alternate.Clear();
			c1FlexGrid.Styles.Focus.Clear();
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
			c1FlexGrid.FocusRect = FocusRectEnum.Solid;
			c1FlexGrid.AllowSorting = AllowSortingEnum.None;
			this.OO.____oo. = A_0;
			this.OO.____oo. = new DataView(this.OO.____oo., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(7), "", DataViewRowState.CurrentRows);
			this.OO.____oo. = (CurrencyManager)this.BindingContext[this.OO.____oo.];
			this.O.O00O0oOo_.().DataSource = this.OO.____oo.;
			this.O.O00O0oOo_.().DisplayMember = "Name";
			this.O.O00O0oOo_.().Rows.DefaultSize = 22;
			this.O.O00O0oOo_.().Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00173C7E File Offset: 0x00171E7E
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			this.OO.____oo..o.OO0O0O. = this.o00o_.0.();
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00173C94 File Offset: 0x00171E94
		private string <<EMPTY_NAME>>()
		{
			string text = "";
			int @fixed = this.O.O00O0oOo_.().Rows.Fixed;
			int num = this.O.O00O0oOo_.().Rows.Count - 2;
			for (int i = @fixed; i <= num; i++)
			{
				if (Operators.CompareString(text, "", true) > 0)
				{
					text += this.O.O00O0oOo_.().ClipSeparators.Substring(1);
				}
				int fixed2 = this.O.O00O0oOo_.().Cols.Fixed;
				int num2 = this.O.O00O0oOo_.().Cols.Count - 1;
				for (int j = fixed2; j <= num2; j++)
				{
					if (j > this.O.O00O0oOo_.().Cols.Fixed)
					{
						text += this.O.O00O0oOo_.().ClipSeparators.Substring(0, 1);
					}
					if (this.O.O00O0oOo_.().GetData(i, j) == null)
					{
						text = (text ?? "");
					}
					else
					{
						text += this.O.O00O0oOo_.().GetData(i, j).ToString();
					}
				}
			}
			return text;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00173D9C File Offset: 0x00171F9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.O00O0oOo_.().Rows.Count > 2)
			{
				this.OO.____oo..o.OO0O0O. = this.o00o_.0.();
			}
			this.O.O00O0oOo_.().Rows.Count = this.O.O00O0oOo_.().Rows.Fixed;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				foreach (Col col in this.OO.____oo..Cols)
				{
					string text = col.Caption;
					if (dictionary.ContainsKey(text) || this.OO.____oo..Cols.Contains(text))
					{
						text = col.Name;
					}
					dictionary.Add(col.Name, text);
				}
			}
			finally
			{
				IEnumerator<Col> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.O.O00O0oOo_.().Cols[1].DataMap = dictionary;
			if (Operators.CompareString(this.OO.____oo..o.OO0O0O., "", true) > 0)
			{
				this.O.O00O0oOo_.(this.OO.____oo..o.OO0O0O.);
			}
			this.O.O00O0oOo_.().AllowAddNew = true;
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00173EB8 File Offset: 0x001720B8
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.O.O00O0oOo_.().AllowAddNew = false;
			this.O.O00O0oOo_.().Rows.Count = this.O.O00O0oOo_.().Rows.Fixed;
			foreach (string item in A_0.Split(this.O.O00O0oOo_.().ClipSeparators.Substring(1).ToCharArray()))
			{
				this.O.O00O0oOo_.().AddItem(item);
			}
			int num = this.O.O00O0oOo_.().Rows.Count - 1;
			int @fixed = this.O.O00O0oOo_.().Rows.Fixed;
			for (int j = num; j >= @fixed; j += -1)
			{
				if (!this.OO.____oo..foxGrid.Cols.Contains(this.O.O00O0oOo_.()[j, 1].ToString()))
				{
					this.O.O00O0oOo_.().RemoveItem(j);
				}
			}
			this.O.O00O0oOo_.().AllowAddNew = true;
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00173FA2 File Offset: 0x001721A2
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.O.O00O0oOo_.()[A_1.Row, 0] = "And";
			this.O.O00O0oOo_.()[A_1.Row, 2] = "等于";
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00173FD4 File Offset: 0x001721D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.O00O0oOo_.().Rows.Count > 2 && this.O.O00O0oOo_.().Row >= this.O.O00O0oOo_.().Rows.Fixed)
			{
				this.O.O00O0oOo_.().Rows.Remove(this.O.O00O0oOo_.().Row);
			}
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00174030 File Offset: 0x00172230
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.O.O00O0oOo_.();
			if (Operators.CompareString(text, "", true) > 0)
			{
				Filter.O0O0o.Oo0OO_oO.(this.OO.____oo., text, false);
				Main.OO_O.o..Refresh();
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0017406C File Offset: 0x0017226C
		private string <<EMPTY_NAME>>()
		{
			int num;
			string result;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = this.O.O00O0oOo_.().Rows.Fixed;
				IL_1B:
				num2 = 3;
				string text = "";
				IL_24:
				num2 = 4;
				bool flag = Oo00.O____0O._0.(this.OO.____oo.);
				for (;;)
				{
					IL_61B:
					num2 = 6;
					if (num3 > this.O.O00O0oOo_.().Rows.Count - 1)
					{
						goto IL_636;
					}
					IL_38:
					num2 = 7;
					int @fixed = this.O.O00O0oOo_.().Cols.Fixed;
					int num4 = this.O.O00O0oOo_.().Cols.Count - 2;
					for (int i = @fixed; i <= num4; i++)
					{
						IL_62:
						num2 = 8;
						if (this.O.O00O0oOo_.()[num3, i] == null)
						{
							IL_75:
							num2 = 9;
							num3++;
							goto IL_61B;
						}
						IL_83:
						num2 = 11;
					}
					IL_92:
					num2 = 12;
					if (num3 > this.O.O00O0oOo_.().Rows.Fixed)
					{
						IL_A9:
						num2 = 13;
						text = text + " " + this.O.O00O0oOo_.()[num3, 0].ToString() + " ";
					}
					IL_D2:
					num2 = 14;
					string text2 = this.O.O00O0oOo_.()[num3, 1].ToString();
					IL_EA:
					num2 = 15;
					string str;
					if (flag)
					{
						IL_F1:
						num2 = 16;
						str = Oo00.OoOo_oo_.o_o.(text2, this.OO.____oo.);
					}
					else
					{
						IL_105:
						num2 = 18;
						str = "[" + text2 + "]";
					}
					IL_11B:
					num2 = 19;
					text += str;
					IL_129:
					num2 = 20;
					if (Operators.CompareString(this.O.O00O0oOo_.().GetDataDisplay(num3, 3), "", true) == 0)
					{
						IL_147:
						num2 = 21;
						if (Operators.CompareString(this.O.O00O0oOo_.()[num3, 2].ToString(), "等于", true) == 0)
						{
							IL_16A:
							num2 = 22;
							text += " Is Null";
						}
						else
						{
							IL_180:
							num2 = 24;
							if (Operators.CompareString(this.O.O00O0oOo_.()[num3, 2].ToString(), "不等于", true) == 0)
							{
								IL_1A6:
								num2 = 25;
								text += " Is Not Null";
							}
						}
					}
					else
					{
						IL_1BC:
						num2 = 27;
						if (this.O.O00O0oOo_.()[num3, 2].ToString().EndsWith("类似"))
						{
							IL_1E1:
							num2 = 28;
							string text3 = this.O.O00O0oOo_.()[num3, 3].ToString();
							IL_1F9:
							num2 = 29;
							if (Operators.CompareString(text3, "", true) > 0)
							{
								IL_20C:
								num2 = 30;
								string text4 = OoOo0O.OO_o.0o_O.(5);
								IL_217:
								num2 = 31;
								text3 = text3.Replace("[*]", text4);
								IL_22A:
								num2 = 32;
								text3 = text3.Replace("*", "%");
								IL_240:
								num2 = 33;
								text3 = text3.Replace(text4, "[*]");
							}
							IL_253:
							num2 = 34;
							if (Operators.CompareString(this.O.O00O0oOo_.()[num3, 2].ToString(), "类似", true) == 0)
							{
								IL_276:
								num2 = 35;
								text = text + " Like '" + text3 + "'";
							}
							else
							{
								IL_293:
								num2 = 37;
								text = text + " Not Like '" + text3 + "'";
							}
						}
						else
						{
							IL_2B0:
							num2 = 39;
							if (Operators.CompareString(this.O.O00O0oOo_.()[num3, 2].ToString(), "包含", true) == 0)
							{
								IL_2D3:
								num2 = 40;
								text = text + " Like '%" + this.O.O00O0oOo_.()[num3, 3].ToString() + "%'";
							}
							else
							{
								IL_301:
								num2 = 42;
								if (Operators.CompareString(this.O.O00O0oOo_.()[num3, 2].ToString(), "不包含", true) == 0)
								{
									IL_324:
									num2 = 43;
									text = text + " Not Like '%" + this.O.O00O0oOo_.()[num3, 3].ToString() + "%'";
								}
								else
								{
									IL_352:
									num2 = 45;
									string left = this.O.O00O0oOo_.()[num3, 2].ToString();
									IL_36A:
									num2 = 47;
									if (Operators.CompareString(left, "等于", true) == 0)
									{
										IL_37C:
										num2 = 48;
										text += " = ";
									}
									else
									{
										IL_392:
										num2 = 50;
										if (Operators.CompareString(left, "不等于", true) == 0)
										{
											IL_3A4:
											num2 = 51;
											text += " <> ";
										}
										else
										{
											IL_3BA:
											num2 = 53;
											if (Operators.CompareString(left, "大于", true) == 0)
											{
												IL_3CC:
												num2 = 54;
												text += " > ";
											}
											else
											{
												IL_3DF:
												num2 = 56;
												if (Operators.CompareString(left, "不大于", true) == 0)
												{
													IL_3F1:
													num2 = 57;
													text += " <= ";
												}
												else
												{
													IL_404:
													num2 = 59;
													if (Operators.CompareString(left, "小于", true) == 0)
													{
														IL_416:
														num2 = 60;
														text += " < ";
													}
													else
													{
														IL_429:
														num2 = 62;
														if (Operators.CompareString(left, "不小于", true) == 0)
														{
															IL_43B:
															num2 = 63;
															text += " >= ";
														}
													}
												}
											}
										}
									}
									IL_44C:
									num2 = 64;
									DataCol dataCol = OO_00oOO.DataTables[this.OO.____oo..View.o_o.O0ooOo.().TableName].DataCols[text2];
									IL_47C:
									num2 = 65;
									if (dataCol.IsString)
									{
										IL_488:
										num2 = 66;
										text = text + "'" + this.O.O00O0oOo_.()[num3, 3].ToString() + "'";
									}
									else
									{
										IL_4B6:
										num2 = 68;
										if (dataCol.IsNumeric || dataCol.IsBoolean)
										{
											IL_4CB:
											num2 = 69;
											text += this.O.O00O0oOo_.()[num3, 3].ToString();
										}
										else
										{
											IL_4EF:
											num2 = 71;
											if (dataCol.IsDate)
											{
												IL_4FE:
												num2 = 72;
												DateTime dateTime;
												if (!DateTime.TryParse(this.O.O00O0oOo_.()[num3, 3].ToString(), out dateTime))
												{
													break;
												}
												IL_541:
												num2 = 75;
												string str2 = Strings.Format(dateTime, "MM/dd/yyyy HH:mm:ss");
												IL_557:
												num2 = 76;
												if (flag)
												{
													IL_561:
													num2 = 77;
													if (this.OO.____oo..DataTable.SourceType == 1)
													{
														IL_577:
														num2 = 78;
														str2 = "#" + str2 + "#";
													}
													else
													{
														IL_58F:
														num2 = 80;
														if (this.OO.____oo..DataTable.SourceType == 2)
														{
															IL_5A5:
															num2 = 81;
															str2 = "'" + str2 + "'";
														}
														else
														{
															IL_5BD:
															num2 = 83;
															if (this.OO.____oo..DataTable.SourceType == 3)
															{
																IL_5D3:
																num2 = 84;
																str2 = "TO_DATE('" + str2 + "', 'MM/DD/YYYY HH24:MI:SS')";
															}
														}
													}
												}
												else
												{
													IL_5EB:
													num2 = 86;
													str2 = "#" + str2 + "#";
												}
												IL_601:
												num2 = 87;
												text += str2;
											}
										}
									}
									IL_60F:
									dataCol = null;
								}
							}
						}
					}
					IL_612:
					num2 = 89;
					num3++;
				}
				IL_51D:
				num2 = 73;
				MessageBox.Show("无效日期值!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_533:
				num2 = 74;
				result = "";
				goto IL_63C;
				IL_636:
				num2 = 91;
				result = text;
				IL_63C:
				goto IL_7FE;
				IL_641:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_7BF:
				goto IL_7F3;
				IL_7C1:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7D1:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7C1;
			}
			IL_7F3:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7FE:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0017489C File Offset: 0x00172A9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O00O0oOo_.().Rows.Count = this.O.O00O0oOo_.().Rows.Fixed + 1;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x001748C0 File Offset: 0x00172AC0
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
				C1FlexGrid c1FlexGrid = this.O.O00O0oOo_.();
				IL_10:
				num2 = 3;
				if (c1FlexGrid.Col != 3 || c1FlexGrid.Row < c1FlexGrid.Rows.Fixed)
				{
					goto IL_35F;
				}
				IL_34:
				num2 = 4;
				string text = "";
				IL_3D:
				num2 = 5;
				if (c1FlexGrid.GetData(c1FlexGrid.Row, 1) == null)
				{
					goto IL_64;
				}
				IL_4E:
				num2 = 6;
				text = c1FlexGrid.GetData(c1FlexGrid.Row, 1).ToString();
				IL_64:
				num2 = 7;
				if (Operators.CompareString(text, "", true) == 0 || !this.OO.____oo..Cols.Contains(text))
				{
					goto IL_35F;
				}
				IL_8F:
				num2 = 9;
				CellStyle cellStyle = c1FlexGrid.GetCellRange(c1FlexGrid.Row, 3).StyleNew;
				IL_AA:
				num2 = 10;
				Col col = this.OO.____oo..Cols[text];
				IL_C1:
				num2 = 11;
				DataColumn dataColumn = this.OO.____oo..DataTable.BaseTable.Columns[text];
				IL_E2:
				num2 = 12;
				cellStyle.ComboList = "";
				IL_F1:
				num2 = 13;
				cellStyle.EditMask = this.OO.____oo..foxGrid.Cols[text].EditMask;
				IL_117:
				num2 = 14;
				cellStyle.Format = this.OO.____oo..foxGrid.Cols[text].Format;
				IL_13D:
				num2 = 15;
				if (Operators.CompareString(col.ComboList, "", true) <= 0)
				{
					goto IL_197;
				}
				IL_155:
				num2 = 16;
				if (!col.AllowDirectType)
				{
					goto IL_181;
				}
				IL_161:
				num2 = 17;
				cellStyle.ComboList = "|" + col.ComboList;
				goto IL_35C;
				IL_181:
				num2 = 19;
				cellStyle.ComboList = col.ComboList;
				goto IL_35C;
				IL_197:
				num2 = 21;
				if (dataColumn.DataType != typeof(string) || dataColumn.MaxLength <= 0 || dataColumn.MaxLength >= 64)
				{
					goto IL_35C;
				}
				IL_1CB:
				num2 = 22;
				bool flag = Oo00.O____0O._0.(this.OO.____oo.);
				IL_1DB:
				num2 = 23;
				if (!flag)
				{
					goto IL_32C;
				}
				IL_1E5:
				num2 = 24;
				string str = Oo00.oo_0__0.o.(this.OO.____oo..DataTable._Adapter.SelectCommand.CommandText);
				IL_209:
				num2 = 25;
				text = Oo00.OoOo_oo_.o_o.(text, this.OO.____oo.);
				IL_21B:
				num2 = 26;
				string text2 = "Select distinct top 100 " + text + " from " + str;
				IL_233:
				num2 = 27;
				if (Operators.CompareString(this.OO.____oo..DataTable.OOOOO._., "", true) <= 0)
				{
					goto IL_275;
				}
				IL_254:
				num2 = 28;
				text2 = text2 + " where " + this.OO.____oo..DataTable.OOOOO._.;
				IL_275:
				num2 = 29;
				DataTable dataTable = new DataTable();
				IL_27F:
				num2 = 30;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text2, this.OO.____oo..DataTable.frd_Connection);
				IL_29B:
				num2 = 31;
				oleDbDataAdapter.Fill(dataTable);
				IL_2A8:
				num2 = 32;
				StringBuilder stringBuilder = new StringBuilder();
				IL_2B2:
				num2 = 33;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_2D3:
					num2 = 34;
					stringBuilder.Append("|" + dataRow[0].ToString());
					IL_2F5:
					num2 = 35;
				}
				IL_301:
				num2 = 36;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_319:
				num2 = 37;
				cellStyle.ComboList = stringBuilder.ToString();
				goto IL_35C;
				IL_32C:
				num2 = 39;
				cellStyle.ComboList = "|" + this.OO.____oo..DataTable.GetComboListString(text, "", "");
				IL_35C:
				cellStyle = null;
				IL_35F:
				goto IL_455;
				IL_364:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_416:
				goto IL_44A;
				IL_418:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_428:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_418;
			}
			IL_44A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_455:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00174D48 File Offset: 0x00172F48
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			if (A_1.Col == 3 && this.O.O00O0oOo_.().Editor != null)
			{
				string text = this.O.O00O0oOo_.().Editor.Text;
				text = text.Trim(new char[]
				{
					'\n',
					'\r'
				});
				this.O.O00O0oOo_.().Editor.Text = text;
			}
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00174DA4 File Offset: 0x00172FA4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3000\u3000\u3002\u3002\u3002\u3002o(this.OO.____oo., ExtendTablePropertyTypeEnum.AdvancedFilter).ShowDialog();
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00174DB8 File Offset: 0x00172FB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.o00o_.0.();
			if (Operators.CompareString(text, "", true) > 0)
			{
				new O\u3002_\u3002\u3000\u3002(this.OO.____oo., text, ExtendTablePropertyTypeEnum.AdvancedFilter).ShowDialog();
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00174DEE File Offset: 0x00172FEE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Oo00.O____0O._0.(this.OO.____oo.))
			{
				this.OO.____oo..DataTable.o0o_ooOOo0.OO.();
				return;
			}
			this.OO.____oo..Filter = "";
			this.OO.____oo..Grid.Refresh();
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00174E30 File Offset: 0x00173030
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (this.OO.____oo..Position >= 0)
			{
				string text = ((DataRowView)this.OO.____oo..Current)["Property"].ToString();
				if (Operators.CompareString(text, "", true) > 0)
				{
					this.O.O00O0oOo_.(text);
				}
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00174E81 File Offset: 0x00173081
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400159D RID: 5533
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400159E RID: 5534
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400159F RID: 5535
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A0 RID: 5536
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A1 RID: 5537
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A2 RID: 5538
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A3 RID: 5539
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A4 RID: 5540
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040015A5 RID: 5541
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015A6 RID: 5542
		internal Table <<EMPTY_NAME>>;

		// Token: 0x040015A7 RID: 5543
		private DataView <<EMPTY_NAME>>;

		// Token: 0x040015A8 RID: 5544
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x040015A9 RID: 5545
		private DataTable <<EMPTY_NAME>>;
	}
}
