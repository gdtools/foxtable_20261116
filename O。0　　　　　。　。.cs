using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000275 RID: 629
	[DesignerGenerated]
	internal partial class O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002 : DropDownForm
	{
		// Token: 0x06001E78 RID: 7800 RVA: 0x000D11EC File Offset: 0x000CF3EC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OooOoOo_.o. != null)
				{
					this.OooOoOo_.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000D122C File Offset: 0x000CF42C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OooOoOo_.o.(new System.Windows.Forms.TreeView());
			base.SuspendLayout();
			this.o.00_O_.().Dock = DockStyle.Fill;
			this.o.00_O_.().Location = new Point(0, 0);
			this.o.00_O_.().Name = "TreeView1";
			this.o.00_O_.().Size = new Size(244, 327);
			this.o.00_O_.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.None;
			base.ClientSize = new Size(244, 327);
			base.Controls.Add(this.o.00_O_.());
			base.Name = "frmDropTree";
			this.Text = "DropTree";
			base.ResumeLayout(false);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000D1304 File Offset: 0x000CF504
		[CompilerGenerated]
		internal virtual System.Windows.Forms.TreeView <<EMPTY_NAME>>()
		{
			return this.OooOoOo_.o.;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000D130C File Offset: 0x000CF50C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.OooOoOo_.o.);
			System.Windows.Forms.TreeView oooOoOo_.o. = this.OooOoOo_.o.;
			if (oooOoOo_.o. != null)
			{
				oooOoOo_.o..AfterSelect -= value;
			}
			this.OooOoOo_.o. = A_0;
			oooOoOo_.o. = this.OooOoOo_.o.;
			if (oooOoOo_.o. != null)
			{
				oooOoOo_.o..AfterSelect += value;
			}
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000D1350 File Offset: 0x000CF550
		internal O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(string A_0, string A_1, bool A_2 = true)
		{
			base.PostChanges += this.o.00_O_.;
			this.OooOoOo_.o. = '\\';
			this.O0ooOO_o0.00. = '|';
			this.o.00_O_.();
			this.OooOoOo_.o. = A_1.Split(new char[]
			{
				'|'
			});
			Foxtable.WinForm.TreeView treeView = new Foxtable.WinForm.TreeView(this.o.00_O_.());
			if (A_2)
			{
				treeView.Load(A_0);
				return;
			}
			treeView.LoadFromString(A_0);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000D13C0 File Offset: 0x000CF5C0
		internal O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(DataTable A_0, string A_1, string A_2, string A_3, char A_4, string A_5, string A_6)
		{
			base.PostChanges += this.o.00_O_.;
			this.OooOoOo_.o. = '\\';
			this.O0ooOO_o0.00. = '|';
			this.o.00_O_.();
			this.o_Oo.O0o__o0O. = A_0;
			this.o_Oo.O0o__o0O. = A_1;
			this.oooo.00oO0OoOO. = A_2;
			this.OooOoOo_.o. = A_3.Split(new char[]
			{
				'|'
			});
			this.OooOoOo_.o. = A_4;
			this.o0_0o__o._. = A_5;
			this.O0_O_OO_0._o. = A_6;
			this.o_0.o0O.();
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000D1448 File Offset: 0x000CF648
		internal void <<EMPTY_NAME>>()
		{
			if (this.o_Oo.O0o__o0O. != null)
			{
				if (this.o_Oo.O0o__o0O..StartsWith("{") && this.o_Oo.O0o__o0O..EndsWith("}"))
				{
					new Foxtable.WinForm.TreeView(this.o.00_O_.()).CreateDataTree(this.o_Oo.O0o__o0O..BaseTable, this.o_Oo.O0o__o0O..Trim(new char[]
					{
						'{',
						'}'
					}), Conversions.ToString(this.OooOoOo_.o.), this.o0_0o__o._., this.O0_O_OO_0._o., "", this.oooo.00oO0OoOO.);
					return;
				}
				oOO0oo_o0.O.ooooo.(this.o.00_O_.(), this.o_Oo.O0o__o0O..BaseTable, this.o0_0o__o._., this.O0_O_OO_0._o., this.oooo.00oO0OoOO., this.o_Oo.O0o__o0O., true);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000D150C File Offset: 0x000CF70C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OooOoOo_.o. != null && base.DialogResult == DialogResult.OK && this.o.00_O_.().SelectedNode != null)
			{
				string a_ = "ValidateEdit";
				Table table = this.OooOoOo_.o..Table;
				List<string> list = new List<string>();
				string[] array;
				if (Operators.CompareString(this.oooo.00oO0OoOO., "", true) > 0)
				{
					System.Windows.Forms.TreeNode selectedNode = this.o.00_O_.().SelectedNode;
					if (selectedNode.Tag == null)
					{
						return;
					}
					array = selectedNode.Tag.ToString().Split(new char[]
					{
						'\t'
					});
				}
				else
				{
					array = this.o.00_O_.().SelectedNode.FullPath.Split(new char[]
					{
						'\\'
					});
				}
				if (this.OooOoOo_.o.)
				{
					foreach (string text in array)
					{
						if (text.IndexOf(this.O0ooOO_o0.00.) >= 0)
						{
							list.AddRange(text.Split(new char[]
							{
								this.O0ooOO_o0.00.
							}));
						}
						else
						{
							list.Add(text);
						}
					}
				}
				else
				{
					list.AddRange(array);
				}
				int num = this.OooOoOo_.o..Length;
				int num2 = num - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text2 = this.OooOoOo_.o.[j];
					if (Operators.CompareString(text2, "", true) != 0 && this.OooOoOo_.o..Table.DataTable.DataCols.Contains(text2))
					{
						string a_2;
						if (list.Count > j)
						{
							a_2 = list[j];
						}
						else
						{
							a_2 = "";
						}
						ValidateEditEventArgs validateEditEventArgs = new ValidateEditEventArgs(table, this.OooOoOo_.o., table.Cols[text2], a_2, null);
						O_O0OO.OoO_o.oO0o0O.(table.DataTable.o_0_00_.oo0O0., a_, new object[]
						{
							validateEditEventArgs
						}, false, table.DataTable.Name, false);
						if (!validateEditEventArgs.Cancel && table.foxGrid.FindForm() != null && table.DataTable.GlobalHandler.ValidateEdit)
						{
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
							{
								validateEditEventArgs
							}, false, "全局表事件", false);
						}
						if (validateEditEventArgs.Cancel)
						{
							return;
						}
						((C1FlexGrid)base.OwnerControl.Parent).FinishEditing(true);
					}
				}
				int num3 = num - 1;
				for (int k = 0; k <= num3; k++)
				{
					string text3 = this.OooOoOo_.o.[k];
					if (Operators.CompareString(text3, "", true) != 0 && this.OooOoOo_.o..Table.DataTable.DataCols.Contains(text3))
					{
						try
						{
							if (list.Count > k)
							{
								this.OooOoOo_.o.[text3] = list[k];
							}
							else
							{
								this.OooOoOo_.o.[text3] = null;
							}
						}
						catch (Exception a_3)
						{
							ooO.oOo0Oo.o.(a_3, "");
						}
						RowColEventArgs rowColEventArgs = new RowColEventArgs(table, this.OooOoOo_.o., table.Cols[text3], null);
						MethodInfo o0O00o_.0Oo. = table.DataTable.O0O00o_.0Oo.;
						if (o0O00o_.0Oo. != null)
						{
							try
							{
								o0O00o_.0Oo..Invoke(null, new object[]
								{
									rowColEventArgs
								});
							}
							catch (Exception a_4)
							{
								ooO.oOo0Oo.o.(a_4, "表，" + table.DataTable.Name + "，AfterEdit");
							}
						}
					}
				}
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000D1894 File Offset: 0x000CFA94
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (this.o.00_O_.().SelectedNode != null && this.O0ooOO_o0.00.)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x04000CCF RID: 3279
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000CD0 RID: 3280
		[CompilerGenerated]
		private System.Windows.Forms.TreeView <<EMPTY_NAME>>;

		// Token: 0x04000CD1 RID: 3281
		internal string[] <<EMPTY_NAME>>;

		// Token: 0x04000CD2 RID: 3282
		internal char <<EMPTY_NAME>>;

		// Token: 0x04000CD3 RID: 3283
		internal char <<EMPTY_NAME>>;

		// Token: 0x04000CD4 RID: 3284
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000CD5 RID: 3285
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000CD6 RID: 3286
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000CD7 RID: 3287
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000CD8 RID: 3288
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000CD9 RID: 3289
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000CDA RID: 3290
		internal Row <<EMPTY_NAME>>;

		// Token: 0x04000CDB RID: 3291
		internal bool <<EMPTY_NAME>>;
	}
}
