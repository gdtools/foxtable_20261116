using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000351 RID: 849
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x0600341A RID: 13338 RVA: 0x00164BC8 File Offset: 0x00162DC8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_ooo_0.0o_. != null)
				{
					this.O_ooo_0.0o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00164C08 File Offset: 0x00162E08
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0oOo0OoO0.0oO.(new C1FlexGrid());
			this.oo0.o_OooOoOO_.(new C1Button());
			this.o0O00o0O.0o0.(new C1Button());
			this.Oo_0oO_OOO.00.(new C1Button());
			this.o0oOo0OoO0.0oO.(new C1Button());
			this.o0oOo0OoO0.0oO.(new Label());
			this.o0oOo0OoO0.0oO.(new C1CheckBox());
			((ISupportInitialize)this.o.0_0o0__.()).BeginInit();
			base.SuspendLayout();
			this.o.0_0o0__.().AllowDragging = AllowDraggingEnum.None;
			this.o.0_0o0__.().AllowSorting = AllowSortingEnum.None;
			this.o.0_0o0__.().ColumnInfo = "3,0,0,40,0,0,Columns:0{Width:92;Caption:\"名称\";}\t1{Width:94;Caption:\"类型\";Style:\"DataType:System.Int32;TextAlign:RightCenter;\";}\t2{Caption:\"候选值\";}\t";
			this.o.0_0o0__.().ExtendLastCol = true;
			this.o.0_0o0__.().Location = new Point(12, 12);
			this.o.0_0o0__.().Name = "C1FlexGrid1";
			this.o.0_0o0__.().Rows.Count = 1;
			this.o.0_0o0__.().Rows.DefaultSize = 22;
			this.o.0_0o0__.().Size = new Size(485, 222);
			this.o.0_0o0__.().TabIndex = 0;
			this.O_Oo__0oO_.0.().Location = new Point(340, 298);
			this.O_Oo__0oO_.0.().Name = "btnOk";
			this.O_Oo__0oO_.0.().Size = new Size(75, 23);
			this.O_Oo__0oO_.0.().TabIndex = 1;
			this.O_Oo__0oO_.0.().Text = "确定";
			this.O_Oo__0oO_.0.().UseVisualStyleBackColor = true;
			this.OO0_O._.().CausesValidation = false;
			this.OO0_O._.().Location = new Point(421, 298);
			this.OO0_O._.().Name = "btnCancel";
			this.OO0_O._.().Size = new Size(75, 23);
			this.OO0_O._.().TabIndex = 2;
			this.OO0_O._.().Text = "取消";
			this.OO0_O._.().UseVisualStyleBackColor = true;
			this.o.0_0o0__.().Location = new Point(12, 298);
			this.o.0_0o0__.().Name = "btnAdd";
			this.o.0_0o0__.().Size = new Size(75, 23);
			this.o.0_0o0__.().TabIndex = 3;
			this.o.0_0o0__.().Text = "增加";
			this.o.0_0o0__.().UseVisualStyleBackColor = true;
			this.oO0Oo_.0000.().Location = new Point(93, 298);
			this.oO0Oo_.0000.().Name = "btnDel";
			this.oO0Oo_.0000.().Size = new Size(75, 23);
			this.oO0Oo_.0000.().TabIndex = 4;
			this.oO0Oo_.0000.().Text = "删除";
			this.oO0Oo_.0000.().UseVisualStyleBackColor = true;
			this.o.0_0o0__.().AutoSize = true;
			this.o.0_0o0__.().Location = new Point(12, 246);
			this.o.0_0o0__.().Name = "Label1";
			this.o.0_0o0__.().Size = new Size(341, 12);
			this.o.0_0o0__.().TabIndex = 5;
			this.o.0_0o0__.().Text = "提示：候选值之间用符号\"|\"隔开，例如：华东|华北|华南|西北";
			this.o.0_0o0__.().AutoSize = true;
			this.o.0_0o0__.().Checked = true;
			this.o.0_0o0__.().CheckState = CheckState.Checked;
			this.o.0_0o0__.().Location = new Point(12, 269);
			this.o.0_0o0__.().Name = "CheckBox1";
			this.o.0_0o0__.().Size = new Size(96, 16);
			this.o.0_0o0__.().TabIndex = 6;
			this.o.0_0o0__.().Text = "记忆密码属性";
			this.o.0_0o0__.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(509, 333);
			base.Controls.Add(this.o.0_0o0__.());
			base.Controls.Add(this.o.0_0o0__.());
			base.Controls.Add(this.oO0Oo_.0000.());
			base.Controls.Add(this.o.0_0o0__.());
			base.Controls.Add(this.OO0_O._.());
			base.Controls.Add(this.O_Oo__0oO_.0.());
			base.Controls.Add(this.o.0_0o0__.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.oOO...";
			base.ShowIcon = false;
			this.Text = "扩展用户属性设置";
			((ISupportInitialize)this.o.0_0o0__.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00165091 File Offset: 0x00163291
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_ooo_0.0o_.;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x0016509C File Offset: 0x0016329C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			ValidateEditEventHandler value = new ValidateEditEventHandler(this.OO._O_00O.);
			C1FlexGrid o_ooo_0.0o_. = this.O_ooo_0.0o_.;
			if (o_ooo_0.0o_. != null)
			{
				o_ooo_0.0o_..ValidateEdit -= value;
			}
			this.O_ooo_0.0o_. = A_0;
			o_ooo_0.0o_. = this.O_ooo_0.0o_.;
			if (o_ooo_0.0o_. != null)
			{
				o_ooo_0.0o_..ValidateEdit += value;
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x001650DF File Offset: 0x001632DF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_ooo_0.0o_.;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x001650E8 File Offset: 0x001632E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO._O_00O.);
			C1Button o_ooo_0.0o_. = this.O_ooo_0.0o_.;
			if (o_ooo_0.0o_. != null)
			{
				o_ooo_0.0o_..Click -= value;
			}
			this.O_ooo_0.0o_. = A_0;
			o_ooo_0.0o_. = this.O_ooo_0.0o_.;
			if (o_ooo_0.0o_. != null)
			{
				o_ooo_0.0o_..Click += value;
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0016512B File Offset: 0x0016332B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_0oO_OOO.00.;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00165134 File Offset: 0x00163334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOO_._.);
			C1Button oo_0oO_OOO.00. = this.Oo_0oO_OOO.00.;
			if (oo_0oO_OOO.00. != null)
			{
				oo_0oO_OOO.00..Click -= value;
			}
			this.Oo_0oO_OOO.00. = A_0;
			oo_0oO_OOO.00. = this.Oo_0oO_OOO.00.;
			if (oo_0oO_OOO.00. != null)
			{
				oo_0oO_OOO.00..Click += value;
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00165177 File Offset: 0x00163377
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O00o0O.0o0.;
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00165180 File Offset: 0x00163380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOO.__oO_OO.);
			C1Button c1Button = this.o0O00o0O.0o0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O00o0O.0o0. = A_0;
			c1Button = this.o0O00o0O.0o0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x001651C3 File Offset: 0x001633C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO.__O.;
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x001651CC File Offset: 0x001633CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOO.o00_000o.);
			C1Button c1Button = this.oO.__O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO.__O. = A_0;
			c1Button = this.oO.__O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0016520F File Offset: 0x0016340F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_ooo_0.0o_.;
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00165217 File Offset: 0x00163417
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_ooo_0.0o_. = A_0;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00165220 File Offset: 0x00163420
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_ooo_0.0o_.;
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00165228 File Offset: 0x00163428
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O_ooo_0.0o_. = A_0;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00165234 File Offset: 0x00163434
		public o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000(DataTable A_0)
		{
			base.Load += this.OO0_O._.;
			base.FormClosed += this.o.0_0o0__.;
			this.o0oOo0OoO0.0oO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o.0_0o0__.().Styles.SelectedColumnHeader.Clear();
			this.o.0_0o0__.().Styles.Alternate.Clear();
			this.o.0_0o0__.().Styles.Focus.Clear();
			this.o.0_0o0__.().Styles.Focus.MergeWith(this.o.0_0o0__.().Styles.Normal);
			this.o.0_0o0__.().FocusRect = FocusRectEnum.Solid;
			this.O_ooo_0.0o_. = A_0;
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00165300 File Offset: 0x00163500
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o.0_0o0__.();
			c1FlexGrid.Rows.Count = c1FlexGrid.Rows.Count + 1;
			c1FlexGrid.Row = c1FlexGrid.Rows.Count - 1;
			c1FlexGrid[c1FlexGrid.Row, 1] = 0;
			c1FlexGrid.Focus();
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x0016535B File Offset: 0x0016355B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0o0__.().Row > 0)
			{
				this.o.0_0o0__.().Rows.Remove(this.o.0_0o0__.().Row);
			}
			this.o.0_0o0__.().Focus();
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00165394 File Offset: 0x00163594
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataRow dataRow = null;
			try
			{
				foreach (object obj in this.O_ooo_0.0o_..Rows)
				{
					DataRow dataRow2 = (DataRow)obj;
					if (Conversions.ToInteger(dataRow2["Type"]) == 7)
					{
						dataRow = dataRow2;
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
			if (dataRow != null)
			{
				string text = dataRow["Config"].ToString();
				if (text.StartsWith("{") & text.EndsWith("}"))
				{
					this.o.0_0o0__.().Checked = false;
					text = text.Trim(new char[]
					{
						'{',
						'}'
					});
				}
				foreach (string item in text.Split(new char[]
				{
					'\r'
				}))
				{
					this.o.0_0o0__.().AddItem(item);
				}
			}
			this.o.0_0o0__.().Col = 0;
			ListDictionary listDictionary = new ListDictionary();
			listDictionary.Add(0, "字符型");
			listDictionary.Add(1, "数值型");
			listDictionary.Add(2, "日期型");
			listDictionary.Add(3, "逻辑型");
			listDictionary.Add(4, "密码型");
			this.o.0_0o0__.().Cols[1].DataMap = listDictionary;
			this.o.0_0o0__.().Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00165530 File Offset: 0x00163730
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0o0__.().Editor != null)
			{
				this.o.0_0o0__.().FinishEditing(true);
			}
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00165554 File Offset: 0x00163754
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataRow dataRow = null;
				IL_0B:
				num2 = 3;
				IEnumerator enumerator = this.O_ooo_0.0o_..Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow2 = (DataRow)obj;
					IL_2F:
					num2 = 4;
					if (Conversions.ToInteger(dataRow2["Type"]) == 7)
					{
						IL_45:
						num2 = 5;
						dataRow = dataRow2;
						break;
					}
					IL_4C:
					num2 = 7;
				}
				IL_57:
				num2 = 8;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_6E:
				num2 = 9;
				this.o.0_0o0__.().BeginUpdate();
				IL_7C:
				num2 = 10;
				if (dataRow != null)
				{
					goto IL_CC;
				}
				IL_82:
				num2 = 11;
				dataRow = this.O_ooo_0.0o_..NewRow();
				IL_91:
				num2 = 12;
				dataRow["Name"] = "AttatchInfo";
				IL_A4:
				num2 = 13;
				dataRow["Type"] = UserTypeEnum.AttatchInfo;
				IL_B8:
				num2 = 14;
				this.O_ooo_0.0o_..Rows.Add(dataRow);
				IL_CC:
				num2 = 15;
				if (this.o.0_0o0__.().Rows.Count != 1)
				{
					goto IL_FA;
				}
				IL_E2:
				num2 = 16;
				dataRow["Config"] = "";
				goto IL_29A;
				IL_FA:
				num2 = 18;
				string text = "";
				IL_104:
				num2 = 19;
				int num3 = this.o.0_0o0__.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_123:
					num2 = 20;
					if (this.o.0_0o0__.().Rows[i][0] == null || Operators.CompareString(this.o.0_0o0__.().Rows[i][0].ToString(), "", true) == 0)
					{
						IL_16A:
						num2 = 21;
						MessageBox.Show("请输入信息名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						IL_180:
						num2 = 22;
						this.o.0_0o0__.().EndUpdate();
						goto IL_2B3;
					}
					IL_193:
					num2 = 25;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_1A6:
						num2 = 26;
						text += "\r";
					}
					IL_1B7:
					num2 = 27;
					string text2 = "";
					IL_1C1:
					num2 = 28;
					int num4 = this.o.0_0o0__.().Cols.Count - 1;
					for (int j = 0; j <= num4; j++)
					{
						IL_1DD:
						num2 = 29;
						if (Operators.CompareString(text2, "", true) > 0)
						{
							IL_1F0:
							num2 = 30;
							text2 += "\t";
						}
						IL_201:
						num2 = 31;
						if (this.o.0_0o0__.().GetData(i, j) != null)
						{
							IL_215:
							num2 = 32;
							text2 += this.o.0_0o0__.().GetData(i, j).ToString();
						}
						IL_235:
						num2 = 33;
					}
					IL_244:
					num2 = 34;
					text += text2;
					IL_252:
					num2 = 35;
				}
				IL_264:
				num2 = 36;
				if (this.o.0_0o0__.().Checked)
				{
					goto IL_28A;
				}
				IL_274:
				num2 = 37;
				text = "{" + text + "}";
				IL_28A:
				num2 = 38;
				dataRow["Config"] = text;
				IL_29A:
				num2 = 39;
				Oo00.o0_o._O_.(this.O_ooo_0.0o_., true);
				IL_2A9:
				num2 = 40;
				base.DialogResult = DialogResult.OK;
				IL_2B3:
				goto IL_3A9;
				IL_2B8:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_36A:
				goto IL_39E;
				IL_36C:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_37C:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_36C;
			}
			IL_39E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3A9:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00165930 File Offset: 0x00163B30
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o.0_0o0__.();
			if (A_1.Col == 0 && Operators.CompareString(c1FlexGrid.Editor.Text, "", true) > 0)
			{
				int num = c1FlexGrid.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (i != A_1.Row && c1FlexGrid.GetData(i, 0) != null && Operators.CompareString(c1FlexGrid.GetData(i, 0).ToString(), c1FlexGrid.Editor.Text, true) == 0)
					{
						MessageBox.Show("存在同名项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_1.Cancel = true;
					}
				}
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x001659D1 File Offset: 0x00163BD1
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014F2 RID: 5362
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014F3 RID: 5363
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040014F4 RID: 5364
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014F5 RID: 5365
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014F6 RID: 5366
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014F7 RID: 5367
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014F8 RID: 5368
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014F9 RID: 5369
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014FA RID: 5370
		private DataTable <<EMPTY_NAME>>;
	}
}
