using System;
using System.Collections;
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
	// Token: 0x02000398 RID: 920
	[DesignerGenerated]
	internal partial class O\u3000\u3002\u3002\u3002\u30020\u3002\u3002 : Form
	{
		// Token: 0x06003C65 RID: 15461 RVA: 0x001B6BC5 File Offset: 0x001B4DC5
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.o.0_OoooOo0O. != null)
			{
				this.o.0_OoooOo0O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x001B6BE4 File Offset: 0x001B4DE4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.0_OoooOo0O.(new ListBox());
			this.o.0_OoooOo0O.(new C1Button());
			this.o_Oo0.0o.(new C1Button());
			base.SuspendLayout();
			this.o0.Oo__0Ooo0__.().FormattingEnabled = true;
			this.o0.Oo__0Ooo0__.().ItemHeight = 12;
			this.o0.Oo__0Ooo0__.().Location = new Point(12, 15);
			this.o0.Oo__0Ooo0__.().Name = "lstTables";
			this.o0.Oo__0Ooo0__.().Size = new Size(227, 256);
			this.o0.Oo__0Ooo0__.().TabIndex = 0;
			this.OooO.0O_O000.().DialogResult = DialogResult.OK;
			this.OooO.0O_O000.().Location = new Point(249, 15);
			this.OooO.0O_O000.().Name = "Button1";
			this.OooO.0O_O000.().Size = new Size(75, 23);
			this.OooO.0O_O000.().TabIndex = 1;
			this.OooO.0O_O000.().Text = "确定";
			this.OooO.0O_O000.().UseVisualStyleBackColor = true;
			this.o0.Oo__0Ooo0__.().DialogResult = DialogResult.Cancel;
			this.o0.Oo__0Ooo0__.().Location = new Point(249, 44);
			this.o0.Oo__0Ooo0__.().Name = "Button2";
			this.o0.Oo__0Ooo0__.().Size = new Size(75, 23);
			this.o0.Oo__0Ooo0__.().TabIndex = 2;
			this.o0.Oo__0Ooo0__.().Text = "取消";
			this.o0.Oo__0Ooo0__.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(334, 283);
			base.Controls.Add(this.o0.Oo__0Ooo0__.());
			base.Controls.Add(this.OooO.0O_O000.());
			base.Controls.Add(this.o0.Oo__0Ooo0__.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o.....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择表";
			base.ResumeLayout(false);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x001B6E04 File Offset: 0x001B5004
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o.0_OoooOo0O.;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x001B6E0C File Offset: 0x001B500C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o.0_OoooOo0O. = A_0;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001B6E15 File Offset: 0x001B5015
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0_OoooOo0O.;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x001B6E1D File Offset: 0x001B501D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o.0_OoooOo0O. = A_0;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x001B6E26 File Offset: 0x001B5026
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_Oo0.0o.;
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x001B6E2E File Offset: 0x001B502E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_Oo0.0o. = A_0;
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x001B6E38 File Offset: 0x001B5038
		public O\u3000\u3002\u3002\u3002\u30020\u3002\u3002(DataTable A_0, C1FlexGrid A_1)
		{
			base.FormClosed += this.o0.Oo__0Ooo0__.;
			int num2;
			int num5;
			object obj3;
			try
			{
				IL_18:
				int num = 1;
				this.o0.Oo__0Ooo0__.();
				IL_20:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_37:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_3E:
				num = 4;
				if (A_0 != null)
				{
					goto IL_A5;
				}
				IL_43:
				num = 5;
				IEnumerator enumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataTable dataTable = (DataTable)obj;
					IL_64:
					num = 6;
					this.o0.Oo__0Ooo0__.().Items.Add(dataTable.TableName);
					IL_7E:
					num = 7;
				}
				IL_88:
				num = 8;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_18A;
				}
				goto IL_18A;
				IL_A5:
				num = 10;
				IEnumerator enumerator2 = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRelation dataRelation = (DataRelation)obj2;
					IL_CC:
					num = 11;
					if (dataRelation.ChildTable == A_0)
					{
						IL_DC:
						num = 12;
						int num3 = A_1.Rows.Fixed;
						do
						{
							IL_EC:
							num = 14;
							if (A_1.Rows[num3].IsNode)
							{
								IL_103:
								num = 15;
								if (Operators.CompareString(Conversions.ToString(A_1[num3, 0]), dataRelation.ParentTable.TableName, true) == 0)
								{
									goto IL_163;
								}
							}
							IL_128:
							num = 17;
							num3++;
							IL_131:
							num = 18;
						}
						while (num3 < A_1.Rows.Count);
						IL_143:
						num = 19;
						this.o0.Oo__0Ooo0__.().Items.Add(dataRelation.ParentTable.TableName);
					}
					IL_163:
					num = 20;
				}
				IL_172:
				num = 21;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_18A:
				num = 22;
				if (this.o0.Oo__0Ooo0__.().Items.Count <= 0)
				{
					goto IL_1AF;
				}
				IL_1A0:
				num = 23;
				this.o0.Oo__0Ooo0__.().SelectedIndex = 0;
				IL_1AF:
				goto IL_261;
				IL_1B4:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_222:
				goto IL_256;
				IL_224:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_234:;
			}
			catch when (endfilter(obj3 is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_224;
			}
			IL_256:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_261:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x001B70CC File Offset: 0x001B52CC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018DF RID: 6367
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018E0 RID: 6368
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040018E1 RID: 6369
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018E2 RID: 6370
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
