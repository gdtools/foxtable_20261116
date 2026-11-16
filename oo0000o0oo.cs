using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000048 RID: 72
	internal class oo0000o0oo : UITypeEditor
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x00005ED1 File Offset: 0x000040D1
		[CompilerGenerated]
		private virtual TreeView <<EMPTY_NAME>>()
		{
			return this.O0._O.;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00005EDC File Offset: 0x000040DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O_O_.0oooo_oo.);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.O_O_.0oooo_oo.);
			TreeNodeMouseClickEventHandler value3 = new TreeNodeMouseClickEventHandler(this.O_O_.0oooo_oo.);
			TreeView o0._O. = this.O0._O.;
			if (o0._O. != null)
			{
				o0._O..MouseDown -= value;
				o0._O..AfterSelect -= value2;
				o0._O..NodeMouseClick -= value3;
			}
			this.O0._O. = A_0;
			o0._O. = this.O0._O.;
			if (o0._O. != null)
			{
				o0._O..MouseDown += value;
				o0._O..AfterSelect += value2;
				o0._O..NodeMouseClick += value3;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00005F58 File Offset: 0x00004158
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			UITypeEditorEditStyle result;
			if (context != null && context.Instance != null)
			{
				result = UITypeEditorEditStyle.DropDown;
			}
			else
			{
				result = base.GetEditStyle(context);
			}
			return result;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00005F80 File Offset: 0x00004180
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			int num;
			object result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (context != null && context.Instance != null && provider != null)
				{
					goto IL_20;
				}
				IL_17:
				num2 = 3;
				result = value;
				goto IL_277;
				IL_20:
				num2 = 4;
				this.O0._O. = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_3D:
				num2 = 5;
				if (this.O0._O. != null)
				{
					goto IL_50;
				}
				IL_47:
				num2 = 6;
				result = value;
				goto IL_277;
				IL_50:
				num2 = 7;
				this.O_O_.0oooo_oo.(new TreeView());
				IL_5D:
				num2 = 8;
				this.O_O_.0oooo_oo.().Size = new Size(200, 200);
				IL_79:
				num2 = 9;
				this.O_O_.0oooo_oo.().PathSeparator = ".";
				IL_8C:
				num2 = 10;
				this.O_O_.0oooo_oo.().Nodes.Add("(无)");
				IL_A5:
				num2 = 11;
				oOO0oo_o0.o.O0o000_.(this.O_O_.0oooo_oo.());
				IL_B3:
				num2 = 12;
				if (Operators.CompareString(Conversions.ToString(value), "", true) <= 0)
				{
					goto IL_E7;
				}
				IL_CA:
				num2 = 13;
				this.O_O_.0oooo_oo.(this.O_O_.0oooo_oo.().Nodes, Conversions.ToString(value));
				goto IL_117;
				IL_E7:
				num2 = 15;
				if (Operators.CompareString(oo0000o0oo.O0._O., "", true) <= 0)
				{
					goto IL_117;
				}
				IL_FD:
				num2 = 16;
				this.O_O_.0oooo_oo.(this.O_O_.0oooo_oo.().Nodes, oo0000o0oo.O0._O.);
				IL_117:
				num2 = 17;
				this.O0._O. = false;
				IL_121:
				num2 = 18;
				this.oO_.0Oo. = false;
				IL_12B:
				num2 = 19;
				this.O0._O..DropDownControl(this.O_O_.0oooo_oo.());
				IL_13F:
				num2 = 20;
				if (this.O_O_.0oooo_oo.().SelectedNode != this.O_O_.0oooo_oo.().Nodes[0])
				{
					goto IL_16E;
				}
				IL_160:
				num2 = 21;
				result = "";
				goto IL_277;
				IL_16E:
				num2 = 23;
				if (this.O_O_.0oooo_oo.().SelectedNode == null || !this.oO_.0Oo.)
				{
					goto IL_25A;
				}
				IL_18C:
				num2 = 24;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_22C;
				}
				IL_19F:
				num2 = 25;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is PropertyBase))
				{
					goto IL_22C;
				}
				IL_1B9:
				num2 = 26;
				ControlTypeEnum a_ = ((PropertyBase)((o_0oooo_OO)context.Instance).Oo._o.()).Type;
				IL_1D8:
				num2 = 27;
				if (this.O_O_.0oooo_oo.().SelectedNode.Tag == null)
				{
					goto IL_22C;
				}
				IL_1ED:
				num2 = 28;
				DataCol a_2 = (DataCol)this.O_O_.0oooo_oo.().SelectedNode.Tag;
				IL_207:
				num2 = 29;
				if (ooO_0O.o_O0.O_.(a_, this.O_O_.0oooo_oo.().SelectedNode.FullPath, a_2))
				{
					goto IL_22C;
				}
				IL_225:
				num2 = 30;
				result = value;
				goto IL_277;
				IL_22C:
				num2 = 31;
				oo0000o0oo.O0._O. = this.O_O_.0oooo_oo.().SelectedNode.FullPath;
				IL_244:
				num2 = 32;
				result = this.O_O_.0oooo_oo.().SelectedNode.FullPath;
				goto IL_277;
				IL_25A:
				num2 = 33;
				this.O_O_.0oooo_oo.().Dispose();
				IL_268:
				num2 = 34;
				this.O_O_.0oooo_oo.(null);
				IL_272:
				num2 = 35;
				result = value;
				IL_277:
				goto IL_359;
				IL_27C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_31A:
				goto IL_34E;
				IL_31C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_32C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_31C;
			}
			IL_34E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_359:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000630C File Offset: 0x0000450C
		private bool <<EMPTY_NAME>>(TreeNodeCollection A_0, string A_1)
		{
			bool result;
			try
			{
				foreach (object obj in A_0)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (Operators.CompareString(treeNode.FullPath, A_1, true) == 0)
					{
						this.O_O_.0oooo_oo.().SelectedNode = treeNode;
						result = true;
						break;
					}
					if (this.O_O_.0oooo_oo.(treeNode.Nodes, A_1))
					{
						result = true;
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
			return result;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00006390 File Offset: 0x00004590
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.O0._O. = true;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000639C File Offset: 0x0000459C
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if ((this.O0._O. != null & this.O0._O.) && this.O_O_.0oooo_oo.().SelectedNode != null && this.O_O_.0oooo_oo.().SelectedNode.GetNodeCount(true) <= 0)
			{
				this.oO_.0Oo. = true;
				this.O0._O..CloseDropDown();
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000063EE File Offset: 0x000045EE
		private void <<EMPTY_NAME>>(object A_0, TreeNodeMouseClickEventArgs A_1)
		{
			if (A_1.Node.Nodes.Count == 0)
			{
				this.O_O_.0oooo_oo.(RuntimeHelpers.GetObjectValue(A_0), new TreeViewEventArgs(A_1.Node));
			}
		}

		// Token: 0x04000068 RID: 104
		private IWindowsFormsEditorService <<EMPTY_NAME>>;

		// Token: 0x04000069 RID: 105
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x0400006A RID: 106
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400006B RID: 107
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400006C RID: 108
		private static string <<EMPTY_NAME>>;
	}
}
