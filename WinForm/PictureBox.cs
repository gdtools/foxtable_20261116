using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 图片框
	/// </summary>
	// Token: 0x02000532 RID: 1330
	[ComVisible(true)]
	public class PictureBox : Control, OoO_
	{
		// Token: 0x060058A6 RID: 22694 RVA: 0x0025F1B5 File Offset: 0x0025D3B5
		internal PictureBox(CustomPictureBox A_0) : base(A_0, ControlTypeEnum.PictureBox)
		{
			this.Oo_.0_0O0o00o. = 21;
			this.oOoo._0o0. = A_0;
			this.oOoo._0o0..AutoScroll = true;
			this.oOoo._0o0..PictureBox1.Enabled = true;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x0025F1EC File Offset: 0x0025D3EC
		// (set) Token: 0x060058A8 RID: 22696 RVA: 0x0025F1F4 File Offset: 0x0025D3F4
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.oOoo._0o0..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (value.StartsWith("全局变量."))
					{
						string text = value.Substring(value.IndexOf('.') + 1);
						if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
						{
							this.oOoo._0o0..DataBindings.Add("ImageFile", OO_00oOO.Vars.VariableTable, text);
							return;
						}
					}
					else
					{
						Binding binding = Oo00.OO.0O0o.("ImageFile", value);
						if (binding != null)
						{
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							this.oOoo._0o0..DataBindings.Add(binding);
						}
					}
				}
			}
		}

		/// <summary>
		/// 图片
		/// </summary>
		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060058A9 RID: 22697 RVA: 0x0025F2C6 File Offset: 0x0025D4C6
		// (set) Token: 0x060058AA RID: 22698 RVA: 0x0025F2D3 File Offset: 0x0025D4D3
		[oO0oooo("0814")]
		public Image Image
		{
			get
			{
				return this.oOoo._0o0..Image;
			}
			set
			{
				this.oOoo._0o0..Image = value;
			}
		}

		/// <summary>
		/// 图片缩放模式
		/// </summary>
		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x0025F2E1 File Offset: 0x0025D4E1
		// (set) Token: 0x060058AC RID: 22700 RVA: 0x0025F2EE File Offset: 0x0025D4EE
		[oO0oooo("0813")]
		public ImageSizeMode SizeMode
		{
			get
			{
				return this.oOoo._0o0..SizeMode;
			}
			set
			{
				this.oOoo._0o0..SizeMode = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x060058AD RID: 22701 RVA: 0x0025F2FC File Offset: 0x0025D4FC
		// (set) Token: 0x060058AE RID: 22702 RVA: 0x0025F309 File Offset: 0x0025D509
		public BorderStyle BorderStyle
		{
			get
			{
				return this.oOoo._0o0..BorderStyle;
			}
			set
			{
				this.oOoo._0o0..BorderStyle = value;
			}
		}

		/// <summary>
		/// 是否自动出现滚动条
		/// </summary>
		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x060058AF RID: 22703 RVA: 0x0025F317 File Offset: 0x0025D517
		// (set) Token: 0x060058B0 RID: 22704 RVA: 0x0025F324 File Offset: 0x0025D524
		public bool AutoScroll
		{
			get
			{
				return this.oOoo._0o0..AutoScroll;
			}
			set
			{
				this.oOoo._0o0..AutoScroll = value;
			}
		}

		/// <summary>
		/// 设置要显示的图片文件
		/// </summary>
		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x0025F332 File Offset: 0x0025D532
		// (set) Token: 0x060058B2 RID: 22706 RVA: 0x0025F33F File Offset: 0x0025D53F
		public string ImageFile
		{
			get
			{
				return this.oOoo._0o0..ImageFile;
			}
			set
			{
				this.oOoo._0o0..ImageFile = value;
			}
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x060058B3 RID: 22707 RVA: 0x0025F350 File Offset: 0x0025D550
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			this.oOoo._0o0..PictureBox1.Controls.Add(Control.BaseControl);
			if (Control.BaseControl is O_oOooO_O)
			{
				Table o.0O_O0o_. = ((O_oOooO_O)Control.BaseControl).o.0O_O0o_.;
				if (o.0O_O0o_..TableType != TableTypeEnum.Normal || o.0O_O0o_..IsCopy)
				{
					o.0O_O0o_..oO_o_0o._0oooo.(true);
				}
			}
			Control.TopMost = true;
		}

		/// <summary>
		/// 删除指定名称的控件
		/// </summary>
		/// <param name="Name">要被删除的控件的名称</param>
		// Token: 0x060058B4 RID: 22708 RVA: 0x0025F3B8 File Offset: 0x0025D5B8
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in this.oOoo._0o0..PictureBox1.Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(this.oOoo._0o0..PictureBox1.Controls, control);
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
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.oOoo._0o0..PictureBox1);
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x060058B5 RID: 22709 RVA: 0x0025F450 File Offset: 0x0025D650
		public void ClearControl()
		{
			for (int i = this.oOoo._0o0..PictureBox1.Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = this.oOoo._0o0..PictureBox1.Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(this.oOoo._0o0..PictureBox1.Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.oOoo._0o0..PictureBox1);
		}

		/// <summary>
		/// 返回一个集合，包括所有顶层子控件
		/// </summary>
		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x0025F4BC File Offset: 0x0025D6BC
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this.oOoo._0o0..PictureBox1);
			}
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x0025F4CE File Offset: 0x0025D6CE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x0025F4D7 File Offset: 0x0025D6D7
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x0025F4DF File Offset: 0x0025D6DF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Remote
		{
			get
			{
				return this.Oo_.0_0O0o00o.;
			}
			set
			{
				this.Oo_.0_0O0o00o. = value;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x060058BA RID: 22714 RVA: 0x0025F4E8 File Offset: 0x0025D6E8
		// (set) Token: 0x060058BB RID: 22715 RVA: 0x0025F4F0 File Offset: 0x0025D6F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Host
		{
			get
			{
				return this.O.oo0o_O_O.;
			}
			set
			{
				this.O.oo0o_O_O. = value;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x0025F4F9 File Offset: 0x0025D6F9
		// (set) Token: 0x060058BD RID: 22717 RVA: 0x0025F501 File Offset: 0x0025D701
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Account
		{
			get
			{
				return this.Oo0__O.o__oO.;
			}
			set
			{
				this.Oo0__O.o__oO. = value;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x0025F50A File Offset: 0x0025D70A
		// (set) Token: 0x060058BF RID: 22719 RVA: 0x0025F512 File Offset: 0x0025D712
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Password
		{
			get
			{
				return this.OOoo0_0o_O_.0o.;
			}
			set
			{
				this.OOoo0_0o_O_.0o. = value;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060058C0 RID: 22720 RVA: 0x0025F51B File Offset: 0x0025D71B
		// (set) Token: 0x060058C1 RID: 22721 RVA: 0x0025F523 File Offset: 0x0025D723
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool UTF8
		{
			get
			{
				return this.O.oo0o_O_O.;
			}
			set
			{
				this.O.oo0o_O_O. = value;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0025F52C File Offset: 0x0025D72C
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0025F534 File Offset: 0x0025D734
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Port
		{
			get
			{
				return this.Oo_.0_0O0o00o.;
			}
			set
			{
				this.Oo_.0_0O0o00o. = value;
			}
		}

		/// <summary>
		/// 用于设置远程FTPClient
		/// </summary>
		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x0025F53D File Offset: 0x0025D73D
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x0025F54A File Offset: 0x0025D74A
		[oO0oooo("2701")]
		public FTPClient FTPClient
		{
			get
			{
				return this.oOoo._0o0..FTPClient;
			}
			set
			{
				this.oOoo._0o0..FTPClient = value;
			}
		}

		/// <summary>
		/// 是否自动更新图片
		/// </summary>
		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x0025F558 File Offset: 0x0025D758
		// (set) Token: 0x060058C7 RID: 22727 RVA: 0x0025F565 File Offset: 0x0025D765
		public bool AutoUpdate
		{
			get
			{
				return this.oOoo._0o0..AutoUpdate;
			}
			set
			{
				this.oOoo._0o0..AutoUpdate = value;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0025F573 File Offset: 0x0025D773
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x0025F57B File Offset: 0x0025D77B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string WebImage
		{
			get
			{
				return this.ImageFile;
			}
			set
			{
				this.ImageFile = value;
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0025F584 File Offset: 0x0025D784
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x0025F58C File Offset: 0x0025D78C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FolderName
		{
			get
			{
				return this.ooO0O.__.;
			}
			set
			{
				this.ooO0O.__. = value;
			}
		}

		// Token: 0x0400230E RID: 8974
		private string <<EMPTY_NAME>>;

		// Token: 0x0400230F RID: 8975
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002310 RID: 8976
		private string <<EMPTY_NAME>>;

		// Token: 0x04002311 RID: 8977
		private string <<EMPTY_NAME>>;

		// Token: 0x04002312 RID: 8978
		private string <<EMPTY_NAME>>;

		// Token: 0x04002313 RID: 8979
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002314 RID: 8980
		private string <<EMPTY_NAME>>;

		// Token: 0x04002315 RID: 8981
		private CustomPictureBox <<EMPTY_NAME>>;

		// Token: 0x04002316 RID: 8982
		private int <<EMPTY_NAME>>;
	}
}
