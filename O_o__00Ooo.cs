using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003AD RID: 941
	internal class O_o__00Ooo : TreeNode
	{
		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x001BD05B File Offset: 0x001BB25B
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x001BD064 File Offset: 0x001BB264
		public string ImageFile
		{
			get
			{
				return this.o0Ooo_O0oo.O__.;
			}
			set
			{
				if (Operators.CompareString(base.SelectedImageKey, base.ImageKey, true) == 0 && Operators.CompareString(this.O.OOO_., "", true) == 0)
				{
					base.SelectedImageKey = "";
				}
				base.ImageKey = "";
				if (Operators.CompareString(this.o0Ooo_O0oo.O__., value, true) != 0 && Operators.CompareString(this.o0Ooo_O0oo.O__., "", true) > 0 && !oOO0oo_o0.o.O0o000_.(base.TreeView, base.TreeView.Nodes, this.o0Ooo_O0oo.O__.))
				{
					base.TreeView.ImageList.Images.RemoveByKey(this.ImageFile);
				}
				this.o0Ooo_O0oo.O__. = value;
				this.o0Ooo_O0oo.O__.();
			}
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001BD117 File Offset: 0x001BB317
		public string <<EMPTY_NAME>>()
		{
			return this.O.OOO_.;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x001BD120 File Offset: 0x001BB320
		public void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(base.ImageKey, base.SelectedImageKey, true) == 0 && Operators.CompareString(this.o0Ooo_O0oo.O__., "", true) == 0)
			{
				base.ImageKey = "";
			}
			base.SelectedImageKey = "";
			if (Operators.CompareString(this.O.OOO_., A_0, true) != 0 && Operators.CompareString(this.O.OOO_., "", true) > 0 && !oOO0oo_o0.o.O0o000_.(base.TreeView, base.TreeView.Nodes, this.O.OOO_.))
			{
				base.TreeView.ImageList.Images.RemoveByKey(this.o0Ooo_O0oo.O__.());
			}
			this.O.OOO_. = A_0;
			this.o0Ooo_O0oo.O__.();
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x001BD1D4 File Offset: 0x001BB3D4
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.ImageFile, "", true) > 0 || Operators.CompareString(this.o0Ooo_O0oo.O__.(), "", true) > 0)
			{
				ImageList imageList;
				if (base.TreeView.ImageList == null)
				{
					imageList = new ImageList();
					base.TreeView.ImageList = imageList;
				}
				else
				{
					imageList = base.TreeView.ImageList;
				}
				if (Operators.CompareString(this.ImageFile, "", true) > 0 && !imageList.Images.Keys.Contains(this.ImageFile))
				{
					Image image = OO_00oOO.GetImage(this.ImageFile);
					if (image != null)
					{
						imageList.Images.Add(this.ImageFile, image);
					}
				}
				if (Operators.CompareString(this.o0Ooo_O0oo.O__.(), "", true) > 0 && !imageList.Images.Keys.Contains(this.o0Ooo_O0oo.O__.()))
				{
					Image image2 = OO_00oOO.GetImage(this.o0Ooo_O0oo.O__.());
					if (image2 != null)
					{
						imageList.Images.Add(this.o0Ooo_O0oo.O__.(), image2);
					}
				}
				if (Operators.CompareString(this.ImageFile, "", true) > 0)
				{
					base.ImageKey = this.ImageFile;
				}
				else if (Operators.CompareString(this.o0Ooo_O0oo.O__.(), "", true) > 0)
				{
					base.ImageKey = this.o0Ooo_O0oo.O__.();
				}
				else
				{
					base.ImageKey = string.Empty;
				}
				if (Operators.CompareString(this.o0Ooo_O0oo.O__.(), "", true) > 0)
				{
					base.SelectedImageKey = this.o0Ooo_O0oo.O__.();
				}
				else if (Operators.CompareString(this.ImageFile, "", true) > 0)
				{
					base.SelectedImageKey = this.ImageFile;
				}
				else
				{
					base.SelectedImageKey = string.Empty;
				}
				if (base.TreeView.ImageList != null && base.TreeView.ImageList.Images.Count == 0)
				{
					base.TreeView.ImageList = null;
				}
			}
			else
			{
				base.ImageKey = string.Empty;
				base.SelectedImageKey = string.Empty;
				if (base.TreeView.ImageList != null && base.TreeView.ImageList.Images.Count == 0)
				{
					base.TreeView.ImageList = null;
					return;
				}
			}
		}

		// Token: 0x04001922 RID: 6434
		private string <<EMPTY_NAME>>;

		// Token: 0x04001923 RID: 6435
		private string <<EMPTY_NAME>>;
	}
}
