using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001A3 RID: 419
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class gv : DropDownForm
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x00095788 File Offset: 0x00093988
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0.OO_o__00o0_. != null)
				{
					this.o0.OO_o__00o0_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000957C8 File Offset: 0x000939C8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0.OO_o__00o0_. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(gv));
			this.o0.OO_o__00o0_.(new System.Windows.Forms.TreeView());
			this.Oo_O.O000_oo0.(new ImageList(this.o0.OO_o__00o0_.));
			base.SuspendLayout();
			this.Oo_O.O000_oo0.().Dock = DockStyle.Fill;
			this.Oo_O.O000_oo0.().ImageIndex = 0;
			this.Oo_O.O000_oo0.().ImageList = this.Oo_O.O000_oo0.();
			this.Oo_O.O000_oo0.().Location = new Point(0, 0);
			this.Oo_O.O000_oo0.().Margin = new Padding(4, 4, 4, 4);
			this.Oo_O.O000_oo0.().Name = "TreeView1";
			this.Oo_O.O000_oo0.().SelectedImageIndex = 0;
			this.Oo_O.O000_oo0.().Size = new Size(285, 598);
			this.Oo_O.O000_oo0.().TabIndex = 0;
			this.Oo_O.O000_oo0.().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.Oo_O.O000_oo0.().TransparentColor = Color.Transparent;
			this.Oo_O.O000_oo0.().Images.SetKeyName(0, "Form");
			this.Oo_O.O000_oo0.().Images.SetKeyName(1, "Folder");
			base.AutoScaleDimensions = new SizeF(8f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(285, 598);
			base.Controls.Add(this.Oo_O.O000_oo0.());
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "o.oO...O";
			this.Text = "frmWinFormSelector";
			base.ResumeLayout(false);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00095968 File Offset: 0x00093B68
		[CompilerGenerated]
		internal virtual System.Windows.Forms.TreeView <<EMPTY_NAME>>()
		{
			return this.o0.OO_o__00o0_.;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00095970 File Offset: 0x00093B70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.TreeView A_0)
		{
			this.o0.OO_o__00o0_. = A_0;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00095979 File Offset: 0x00093B79
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.o0.OO_o__00o0_.;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00095981 File Offset: 0x00093B81
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.o0.OO_o__00o0_. = A_0;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0009598C File Offset: 0x00093B8C
		public gv(string A_0)
		{
			this.Oo_O.O000_oo0.();
			string text = string.Concat(new string[]
			{
				"([Type] = ",
				Conversions.ToString(229),
				"Or [Type] = ",
				Conversions.ToString(233),
				"Or [Type] = ",
				Conversions.ToString(35),
				") And pth > ''"
			});
			Foxtable.WinForm.TreeView treeView = new Foxtable.WinForm.TreeView(this.Oo_O.O000_oo0.());
			treeView.CreateDataTree(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()], "pth", "\\", text, "", "", "");
			try
			{
				foreach (Foxtable.WinForm.TreeNode treeNode in treeView.AllNodes)
				{
					treeNode.BaseNode.Tag = null;
				}
			}
			finally
			{
				List<Foxtable.WinForm.TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			List<O_o__00Ooo> list = new List<O_o__00Ooo>();
			this.Oo_O.O000_oo0.(this.Oo_O.O000_oo0.().Nodes, list);
			try
			{
				foreach (O_o__00Ooo o_o__00Ooo in list)
				{
					o_o__00Ooo.ImageIndex = 1;
					o_o__00Ooo.SelectedImageIndex = 1;
				}
			}
			finally
			{
				List<O_o__00Ooo>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			text = "[Type] = " + Conversions.ToString(229) + "Or [Type] = " + Conversions.ToString(233);
			foreach (DataRow dataRow in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Select(text, "srt", DataViewRowState.CurrentRows))
			{
				O_o__00Ooo o_o__00Ooo2 = new O_o__00Ooo();
				o_o__00Ooo2.Name = dataRow["Name"].ToString();
				o_o__00Ooo2.Text = dataRow["Name"].ToString();
				o_o__00Ooo2.Tag = dataRow;
				try
				{
					foreach (System.Windows.Forms.TreeNode treeNode2 in list)
					{
						if (Operators.CompareString(treeNode2.FullPath, dataRow["pth"].ToString(), true) == 0)
						{
							treeNode2.Nodes.Add(o_o__00Ooo2);
						}
					}
				}
				finally
				{
					List<O_o__00Ooo>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				if (o_o__00Ooo2.Parent == null)
				{
					this.Oo_O.O000_oo0.().Nodes.Add(o_o__00Ooo2);
				}
				o_o__00Ooo2.ImageIndex = 0;
				o_o__00Ooo2.SelectedImageIndex = 0;
			}
			if (Operators.CompareString(A_0, "", true) > 0)
			{
				list.Clear();
				this.Oo_O.O000_oo0.(this.Oo_O.O000_oo0.().Nodes, list);
				try
				{
					foreach (System.Windows.Forms.TreeNode treeNode3 in list)
					{
						if (Operators.CompareString(treeNode3.Text, A_0, true) == 0 && treeNode3.ImageIndex == 0)
						{
							this.Oo_O.O000_oo0.().SelectedNode = treeNode3;
							break;
						}
					}
				}
				finally
				{
					List<O_o__00Ooo>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00095C9C File Offset: 0x00093E9C
		private void <<EMPTY_NAME>>(TreeNodeCollection A_0, List<O_o__00Ooo> A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					O_o__00Ooo o_o__00Ooo = (O_o__00Ooo)obj;
					A_1.Add(o_o__00Ooo);
					if (o_o__00Ooo.Nodes.Count > 0)
					{
						this.Oo_O.O000_oo0.(o_o__00Ooo.Nodes, A_1);
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

		// Token: 0x0400082D RID: 2093
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400082E RID: 2094
		[CompilerGenerated]
		private System.Windows.Forms.TreeView <<EMPTY_NAME>>;

		// Token: 0x0400082F RID: 2095
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;
	}
}
