using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200026B RID: 619
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000 : DropDownForm
	{
		// Token: 0x06001DAB RID: 7595 RVA: 0x000CB9F4 File Offset: 0x000C9BF4
		public O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000()
		{
			this.o_O0_O.O_OOO.();
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000CBA04 File Offset: 0x000C9C04
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo_.000o. != null)
				{
					this.oo_.000o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000CBA44 File Offset: 0x000C9C44
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo_.000o.(new TreeView());
			base.SuspendLayout();
			this.o_O0_O.O_OOO.().CheckBoxes = true;
			this.o_O0_O.O_OOO.().Dock = DockStyle.Fill;
			this.o_O0_O.O_OOO.().ItemHeight = 16;
			this.o_O0_O.O_OOO.().Location = new Point(0, 0);
			this.o_O0_O.O_OOO.().Name = "tre";
			this.o_O0_O.O_OOO.().Size = new Size(262, 339);
			this.o_O0_O.O_OOO.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(262, 339);
			base.Controls.Add(this.o_O0_O.O_OOO.());
			base.Name = "O.O...0.";
			this.Text = "frmJoinColumnSelecter";
			base.ResumeLayout(false);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000CBB2E File Offset: 0x000C9D2E
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.oo_.000o.;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000CBB38 File Offset: 0x000C9D38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.oo_.000o.);
			TreeView treeView = this.oo_.000o.;
			if (treeView != null)
			{
				treeView.AfterCheck -= value;
			}
			this.oo_.000o. = A_0;
			treeView = this.oo_.000o.;
			if (treeView != null)
			{
				treeView.AfterCheck += value;
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000CBB7C File Offset: 0x000C9D7C
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
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
				if (!this.oo_.000o.)
				{
					goto IL_385;
				}
				IL_14:
				num2 = 4;
				if (A_1.Action != TreeViewAction.ByMouse && A_1.Action != TreeViewAction.ByKeyboard)
				{
					goto IL_9E;
				}
				IL_28:
				num2 = 5;
				if (A_1.Node.Level != 0)
				{
					goto IL_8A;
				}
				IL_37:
				num2 = 6;
				IEnumerator enumerator = A_1.Node.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					TreeNode treeNode = (TreeNode)obj;
					IL_5B:
					num2 = 7;
					treeNode.Checked = false;
					IL_65:
					num2 = 8;
				}
				IL_70:
				num2 = 9;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_9E;
				}
				goto IL_9E;
				IL_8A:
				num2 = 11;
				A_1.Node.Parent.Checked = false;
				IL_9E:
				num2 = 12;
				List<string> list = new List<string>();
				IL_A8:
				num2 = 13;
				if (Operators.CompareString(base.OwnerControl.Text, "", true) <= 0)
				{
					goto IL_EA;
				}
				IL_C4:
				num2 = 14;
				list.AddRange(base.OwnerControl.Text.Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries));
				IL_EA:
				num2 = 15;
				if (A_1.Node.Level != 0)
				{
					goto IL_11D;
				}
				IL_FA:
				num2 = 16;
				string text = Oo00.o.oo_0.(A_1.Node.Name) + ".*";
				goto IL_1E1;
				IL_11D:
				num2 = 18;
				string text2 = A_1.Node.Name;
				IL_12D:
				num2 = 19;
				bool flag = false;
				IL_133:
				num2 = 20;
				foreach (char c in text2)
				{
					IL_14A:
					num2 = 21;
					if (!char.IsLetterOrDigit(c))
					{
						IL_156:
						num2 = 22;
						flag = true;
						break;
					}
					IL_15E:
					num2 = 24;
				}
				IL_172:
				num2 = 25;
				if (!text2.StartsWith("_") && !flag)
				{
					goto IL_19D;
				}
				IL_187:
				num2 = 26;
				text2 = "[" + text2 + "]";
				IL_19D:
				num2 = 27;
				if (this.o_O0_O.O_OOO.(A_1.Node.Name) <= 1)
				{
					goto IL_1DB;
				}
				IL_1B4:
				num2 = 28;
				text = Oo00.o.oo_0.(A_1.Node.Parent.Name) + "." + text2;
				goto IL_1E1;
				IL_1DB:
				num2 = 30;
				text = text2;
				IL_1E1:
				num2 = 31;
				if (!list.Contains(text) && !list.Contains(text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				})))
				{
					goto IL_2A5;
				}
				IL_21B:
				num2 = 32;
				if (A_1.Node.Checked)
				{
					goto IL_319;
				}
				IL_22E:
				num2 = 33;
				if (!list.Contains(text))
				{
					goto IL_247;
				}
				IL_23B:
				num2 = 34;
				list.Remove(text);
				IL_247:
				num2 = 35;
				if (!list.Contains(text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				})))
				{
					goto IL_319;
				}
				IL_277:
				num2 = 36;
				list.Remove(text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				}));
				goto IL_319;
				IL_2A5:
				num2 = 38;
				if (!A_1.Node.Checked)
				{
					goto IL_2C2;
				}
				IL_2B5:
				num2 = 39;
				list.Add(text);
				goto IL_319;
				IL_2C2:
				num2 = 41;
				text = A_1.Node.Name;
				IL_2D1:
				num2 = 42;
				if (!list.Contains(text))
				{
					goto IL_2EC;
				}
				IL_2DE:
				num2 = 43;
				list.Remove(text);
				goto IL_319;
				IL_2EC:
				num2 = 45;
				text = "[" + text + "]";
				IL_300:
				num2 = 46;
				if (!list.Contains(text))
				{
					goto IL_319;
				}
				IL_30D:
				num2 = 47;
				list.Remove(text);
				IL_319:
				num2 = 48;
				text = "";
				IL_322:
				num2 = 49;
				List<string>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string str = enumerator2.Current;
					IL_339:
					num2 = 50;
					text = text + "," + str;
					IL_34A:
					num2 = 51;
				}
				IL_356:
				num2 = 52;
				((IDisposable)enumerator2).Dispose();
				IL_366:
				num2 = 53;
				base.OwnerControl.Value = text.Trim(new char[]
				{
					','
				});
				IL_385:
				goto IL_4AF;
				IL_38A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_470:
				goto IL_4A4;
				IL_472:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_482:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_472;
			}
			IL_4A4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4AF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000CC05C File Offset: 0x000CA25C
		private int <<EMPTY_NAME>>(string A_0)
		{
			int num;
			try
			{
				foreach (object obj in this.o_O0_O.O_OOO.().Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					try
					{
						IEnumerator enumerator2 = treeNode.Nodes.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							if (Operators.CompareString(((TreeNode)enumerator2.Current).Name, A_0, true) == 0)
							{
								num++;
								break;
							}
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
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return num;
		}

		// Token: 0x04000CA0 RID: 3232
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000CA1 RID: 3233
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04000CA2 RID: 3234
		internal bool <<EMPTY_NAME>>;
	}
}
