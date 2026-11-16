using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000405 RID: 1029
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3000 : Form
	{
		// Token: 0x0600434C RID: 17228 RVA: 0x001EEA04 File Offset: 0x001ECC04
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0Oo.____oOo. != null)
				{
					this.o0Oo.____oOo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x001EEA44 File Offset: 0x001ECC44
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0.0oO_0__OO.(new C1Button());
			this.OoO_0_0._00_0.(new C1Button());
			this.OO.o_O00.(new C1Button());
			this.oO0O.Ooo.(new C1Button());
			this.O_ooo0.o.(new C1Button());
			this.OoO_0_0._00_0.(new TreeView());
			this.OoO_0_0._00_0.(new PropertyGrid());
			this.ooOo0o0O.oo__0.(new C1Button());
			this.O0_oo_o._0.(new C1Button());
			base.SuspendLayout();
			this.O00.oo.().Location = new Point(163, 12);
			this.O00.oo.().Name = "btnAddGroup";
			this.O00.oo.().Size = new Size(75, 23);
			this.O00.oo.().TabIndex = 1;
			this.O00.oo.().Text = "增加页面";
			this.O00.oo.().UseVisualStyleBackColor = true;
			this.O_._oo.().Location = new Point(163, 41);
			this.O_._oo.().Name = "btnAddTask";
			this.O_._oo.().Size = new Size(75, 23);
			this.O_._oo.().TabIndex = 3;
			this.O_._oo.().Text = "增加任务";
			this.O_._oo.().UseVisualStyleBackColor = true;
			this.OO0_o.o00.().Location = new Point(163, 128);
			this.OO0_o.o00.().Name = "btnDelete";
			this.OO0_o.o00.().Size = new Size(75, 23);
			this.OO0_o.o00.().TabIndex = 4;
			this.OO0_o.o00.().Text = "删除";
			this.OO0_o.o00.().UseVisualStyleBackColor = true;
			this.o0.0oO_0__OO.().Location = new Point(163, 70);
			this.o0.0oO_0__OO.().Name = "BtnMoveUp";
			this.o0.0oO_0__OO.().Size = new Size(75, 23);
			this.o0.0oO_0__OO.().TabIndex = 5;
			this.o0.0oO_0__OO.().Text = "上移";
			this.o0.0oO_0__OO.().UseVisualStyleBackColor = true;
			this.o_._00oO0.().Location = new Point(163, 99);
			this.o_._00oO0.().Name = "btnNoveDown";
			this.o_._00oO0.().Size = new Size(75, 23);
			this.o_._00oO0.().TabIndex = 6;
			this.o_._00oO0.().Text = "下移";
			this.o_._00oO0.().UseVisualStyleBackColor = true;
			this.OO_o.O_0.().HideSelection = false;
			this.OO_o.O_0.().Location = new Point(12, 12);
			this.OO_o.O_0.().Name = "TreeView1";
			this.OO_o.O_0.().Size = new Size(145, 275);
			this.OO_o.O_0.().TabIndex = 7;
			this.OO_o.O_0.().Location = new Point(244, 12);
			this.OO_o.O_0.().Name = "PropertyGrid1";
			this.OO_o.O_0.().Size = new Size(275, 275);
			this.OO_o.O_0.().TabIndex = 8;
			this.OO_o.O_0.().ToolbarVisible = false;
			this.o0O__.Oo_O__.().Location = new Point(364, 302);
			this.o0O__.Oo_O__.().Name = "btnOk";
			this.o0O__.Oo_O__.().Size = new Size(75, 23);
			this.o0O__.Oo_O__.().TabIndex = 9;
			this.o0O__.Oo_O__.().Text = "确定";
			this.o0O__.Oo_O__.().UseVisualStyleBackColor = true;
			this.o0o.o__OOOo_.().Location = new Point(445, 302);
			this.o0o.o__OOOo_.().Name = "btnCancel";
			this.o0o.o__OOOo_.().Size = new Size(75, 23);
			this.o0o.o__OOOo_.().TabIndex = 10;
			this.o0o.o__OOOo_.().Text = "取消";
			this.o0o.o__OOOo_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(531, 336);
			base.Controls.Add(this.o0o.o__OOOo_.());
			base.Controls.Add(this.o0O__.Oo_O__.());
			base.Controls.Add(this.OO_o.O_0.());
			base.Controls.Add(this.OO_o.O_0.());
			base.Controls.Add(this.o_._00oO0.());
			base.Controls.Add(this.o0.0oO_0__OO.());
			base.Controls.Add(this.OO0_o.o00.());
			base.Controls.Add(this.O_._oo.());
			base.Controls.Add(this.O00.oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.00.O0o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "任务栏编辑器";
			base.ResumeLayout(false);
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x001EEF33 File Offset: 0x001ED133
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0Oo.____oOo.;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x001EEF3C File Offset: 0x001ED13C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00o.o.);
			C1Button c1Button = this.o0Oo.____oOo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0Oo.____oOo. = A_0;
			c1Button = this.o0Oo.____oOo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x001EEF7F File Offset: 0x001ED17F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_ooO_0O_O.o_.;
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x001EEF88 File Offset: 0x001ED188
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__._00o_O0.);
			C1Button o_ooO_0O_O.o_. = this.O_ooO_0O_O.o_.;
			if (o_ooO_0O_O.o_. != null)
			{
				o_ooO_0O_O.o_..Click -= value;
			}
			this.O_ooO_0O_O.o_. = A_0;
			o_ooO_0O_O.o_. = this.O_ooO_0O_O.o_.;
			if (o_ooO_0O_O.o_. != null)
			{
				o_ooO_0O_O.o_..Click += value;
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x001EEFCB File Offset: 0x001ED1CB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_._oOoO.;
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x001EEFD4 File Offset: 0x001ED1D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_._oo.);
			C1Button c1Button = this.o_._oOoO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_._oOoO. = A_0;
			c1Button = this.o_._oOoO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x001EF017 File Offset: 0x001ED217
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo.0Oo0oO000o.;
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x001EF020 File Offset: 0x001ED220
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O00.oo.);
			C1Button c1Button = this.oo.0Oo0oO000o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo.0Oo0oO000o. = A_0;
			c1Button = this.oo.0Oo0oO000o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x001EF063 File Offset: 0x001ED263
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoOo0oO__.0O.;
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x001EF06C File Offset: 0x001ED26C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_OoO._0o_OOo0.);
			C1Button c1Button = this.oOoOo0oO__.0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOoOo0oO__.0O. = A_0;
			c1Button = this.oOoOo0oO__.0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x001EF0AF File Offset: 0x001ED2AF
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.o0Oo.____oOo.;
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x001EF0B8 File Offset: 0x001ED2B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.OoO_0_0._00_0.);
			TreeView treeView = this.o0Oo.____oOo.;
			if (treeView != null)
			{
				treeView.AfterSelect -= value;
			}
			this.o0Oo.____oOo. = A_0;
			treeView = this.o0Oo.____oOo.;
			if (treeView != null)
			{
				treeView.AfterSelect += value;
			}
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x001EF0FB File Offset: 0x001ED2FB
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.o0Oo.____oOo.;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x001EF104 File Offset: 0x001ED304
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyTabChangedEventHandler value = new PropertyTabChangedEventHandler(this.OO_o.O_0.);
			PropertyValueChangedEventHandler value2 = new PropertyValueChangedEventHandler(this.OO_o.O_0.);
			PropertyGrid propertyGrid = this.o0Oo.____oOo.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyTabChanged -= value;
				propertyGrid.PropertyValueChanged -= value2;
			}
			this.o0Oo.____oOo. = A_0;
			propertyGrid = this.o0Oo.____oOo.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyTabChanged += value;
				propertyGrid.PropertyValueChanged += value2;
			}
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x001EF162 File Offset: 0x001ED362
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo.OO0o_0ooo.;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x001EF16C File Offset: 0x001ED36C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0_o.o00.);
			C1Button c1Button = this.oo.OO0o_0ooo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo.OO0o_0ooo. = A_0;
			c1Button = this.oo.OO0o_0ooo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x001EF1AF File Offset: 0x001ED3AF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOO_oo.O_0o.;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x001EF1B8 File Offset: 0x001ED3B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0_O0o.o_.);
			C1Button c1Button = this.oOO_oo.O_0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOO_oo.O_0o. = A_0;
			c1Button = this.oOO_oo.O_0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x001EF1FB File Offset: 0x001ED3FB
		public O\u3002\u3002\u3000()
		{
			base.FormClosed += this.OO0_o.o00.;
			this.OO_o.O_0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x001EF230 File Offset: 0x001ED430
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.OO_o.O_0.();
			TreeNode treeNode = new TreeNode();
			treeView.Nodes.Add(treeNode);
			treeNode.Text = "页面" + Conversions.ToString(treeView.Nodes.Count);
			treeNode.Name = treeNode.Text;
			treeNode.EnsureVisible();
			treeNode.Tag = new TopicPageProperty
			{
				Name = treeNode.Name,
				Text = treeNode.Text
			};
			treeView.SelectedNode = treeNode;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x001EF2B8 File Offset: 0x001ED4B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.OO_o.O_0.();
			if (treeView.SelectedNode != null)
			{
				TreeNode treeNode = new TreeNode();
				if (treeView.SelectedNode.Level == 0)
				{
					treeView.SelectedNode.Nodes.Add(treeNode);
					treeNode.Text = "任务" + Conversions.ToString(treeView.SelectedNode.GetNodeCount(false));
				}
				else
				{
					treeView.SelectedNode.Parent.Nodes.Add(treeNode);
					treeNode.Text = "任务" + Conversions.ToString(treeView.SelectedNode.Parent.GetNodeCount(false));
				}
				treeNode.Name = treeNode.Text;
				treeNode.EnsureVisible();
				treeNode.Tag = new TopicLinkProperty
				{
					Name = treeNode.Name,
					Text = treeNode.Text
				};
				treeView.SelectedNode = treeNode;
			}
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x001EF39C File Offset: 0x001ED59C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.OO_o.O_0.();
			if (treeView.SelectedNode != null)
			{
				TreeNode selectedNode = treeView.SelectedNode;
				int index = selectedNode.Index;
				if (index != 0)
				{
					TreeNodeCollection nodes;
					if (selectedNode.Parent == null)
					{
						nodes = treeView.Nodes;
					}
					else
					{
						nodes = selectedNode.Parent.Nodes;
					}
					nodes.Remove(selectedNode);
					nodes.Insert(index - 1, selectedNode);
					treeView.SelectedNode = selectedNode;
					selectedNode.EnsureVisible();
				}
			}
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x001EF408 File Offset: 0x001ED608
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.OO_o.O_0.();
			if (treeView.SelectedNode != null)
			{
				TreeNode selectedNode = treeView.SelectedNode;
				int index = selectedNode.Index;
				TreeNodeCollection nodes;
				if (selectedNode.Parent == null)
				{
					nodes = treeView.Nodes;
				}
				else
				{
					nodes = selectedNode.Parent.Nodes;
				}
				if (index != nodes.Count - 1)
				{
					nodes.Remove(selectedNode);
					nodes.Insert(index + 1, selectedNode);
					treeView.SelectedNode = selectedNode;
					selectedNode.EnsureVisible();
				}
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x001EF47C File Offset: 0x001ED67C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			TreeView treeView = this.OO_o.O_0.();
			if (treeView.SelectedNode != null)
			{
				if (treeView.SelectedNode.Parent == null)
				{
					treeView.Nodes.Remove(treeView.SelectedNode);
				}
				else
				{
					treeView.SelectedNode.Parent.Nodes.Remove(treeView.SelectedNode);
				}
			}
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x001EF4D5 File Offset: 0x001ED6D5
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x001EF4DE File Offset: 0x001ED6DE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x001EF4E8 File Offset: 0x001ED6E8
		internal string <<EMPTY_NAME>>()
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (object obj in this.OO_o.O_0.().Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append('\f');
					}
					stringBuilder.Append("Page");
					stringBuilder.Append('\f');
					stringBuilder.Append(o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(treeNode.Tag), false, '\t', false).Replace("\f", ""));
					if (treeNode.Nodes.Count > 0)
					{
						try
						{
							foreach (object obj2 in treeNode.Nodes)
							{
								TreeNode treeNode2 = (TreeNode)obj2;
								stringBuilder.Append('\f');
								stringBuilder.Append(o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(treeNode2.Tag), false, '\t', false).Replace("\f", ""));
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
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x001EF62C File Offset: 0x001ED82C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.OO_o.O_0.().Nodes.Clear();
			if (Operators.CompareString(A_0, "", true) != 0)
			{
				foreach (string text in A_0.Split(new char[]
				{
					'\f'
				}))
				{
					if (Operators.CompareString(text, "Page", true) == 0)
					{
						bool flag = true;
					}
					else
					{
						TreeNode treeNode = new TreeNode();
						bool flag;
						object obj;
						if (flag)
						{
							obj = new TopicPageProperty();
						}
						else
						{
							obj = new TopicLinkProperty();
						}
						o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(obj), text, '\t');
						treeNode.Tag = RuntimeHelpers.GetObjectValue(obj);
						if (flag)
						{
							this.OO_o.O_0.().Nodes.Add(treeNode);
							treeNode.Text = ((TopicPageProperty)obj).Text;
						}
						else
						{
							this.OO_o.O_0.().Nodes[this.OO_o.O_0.().Nodes.Count - 1].Nodes.Add(treeNode);
							treeNode.Text = ((TopicLinkProperty)obj).Text;
						}
						flag = false;
					}
				}
			}
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x001EF73F File Offset: 0x001ED93F
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (this.OO_o.O_0.().SelectedNode == null)
			{
				this.OO_o.O_0.().SelectedObject = null;
				return;
			}
			this.OO_o.O_0.().SelectedObject = RuntimeHelpers.GetObjectValue(this.OO_o.O_0.().SelectedNode.Tag);
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x001EF77B File Offset: 0x001ED97B
		private void <<EMPTY_NAME>>(object A_0, PropertyTabChangedEventArgs A_1)
		{
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x001EF77D File Offset: 0x001ED97D
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			if (Operators.CompareString(A_1.ChangedItem.Label, "标题", true) == 0)
			{
				this.OO_o.O_0.().SelectedNode.Text = A_1.ChangedItem.Value.ToString();
			}
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x001EF7B7 File Offset: 0x001ED9B7
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001BB3 RID: 7091
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001BB4 RID: 7092
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BB5 RID: 7093
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BB6 RID: 7094
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BB7 RID: 7095
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BB8 RID: 7096
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BB9 RID: 7097
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04001BBA RID: 7098
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04001BBB RID: 7099
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BBC RID: 7100
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
