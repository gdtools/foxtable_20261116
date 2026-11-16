using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200043E RID: 1086
	internal class OOOoo0 : O_o_0o
	{
		// Token: 0x060048DB RID: 18651 RVA: 0x001F5A94 File Offset: 0x001F3C94
		internal OOOoo0(string A_0, TreeNode A_1, PropertyBase A_2)
		{
			this.Node = A_1;
			this.Obj = A_2;
			this.PropertyName = A_0;
			PropertyInfo property = A_2.GetType().GetProperty(A_0);
			this.Value = RuntimeHelpers.GetObjectValue(property.GetValue(A_2, null));
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		internal void Undo()
		{
			TreeView treeView = (TreeView)this.Obj.Holder.ChildControl;
			if (treeView.SelectedNode != this.Node)
			{
				treeView.SelectedNode = this.Node;
				Application.DoEvents();
			}
			this.Obj.GetType().GetProperty(this.PropertyName).SetValue(this.Obj, RuntimeHelpers.GetObjectValue(this.Value), null);
			if (!this.Obj.Holder.Selected)
			{
				this.Obj.Holder.Selected = true;
			}
		}

		// Token: 0x04001D85 RID: 7557
		private string PropertyName;

		// Token: 0x04001D86 RID: 7558
		private TreeNode Node;

		// Token: 0x04001D87 RID: 7559
		private PropertyBase Obj;

		// Token: 0x04001D88 RID: 7560
		private object Value;
	}
}
