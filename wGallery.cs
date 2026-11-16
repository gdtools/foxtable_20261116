using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200020C RID: 524
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0087")]
	public class wGallery : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019AB RID: 6571 RVA: 0x000B7A2C File Offset: 0x000B5C2C
		internal wGallery(string A_0, string A_1, bool A_2, bool A_3) : base(A_0, A_1)
		{
			this.o.O___oOOOOoo. = new List<string>();
			this.o.O___oOOOOoo. = A_2;
			this.O0_O_o._. = A_3;
		}

		/// <summary>
		/// 向Gallery添加图片
		/// </summary>
		/// <param name="Images">要增加的图片</param>
		// Token: 0x060019AC RID: 6572 RVA: 0x000B7A50 File Offset: 0x000B5C50
		public void AddImage(params string[] Images)
		{
			this.o.O___oOOOOoo..AddRange(Images);
		}

		/// <summary>
		/// 向Gallery添加图片
		/// </summary>
		/// <param name="Images">一个集合，包括所有要增加的图片</param>
		// Token: 0x060019AD RID: 6573 RVA: 0x000B7A5E File Offset: 0x000B5C5E
		public void AddImage(List<string> Images)
		{
			this.o.O___oOOOOoo..AddRange(Images);
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x000B7A6C File Offset: 0x000B5C6C
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x000B7A74 File Offset: 0x000B5C74
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Delete
		{
			get
			{
				return this.O_0.o0o_.;
			}
			set
			{
				this.O_0.o0o_. = value;
			}
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000B7A80 File Offset: 0x000B5C80
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append(string.Concat(new string[]
			{
				"<div id='",
				base.ID,
				"' name='",
				base.ID,
				"' class='weui-gallery"
			}));
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			A_0.Append("'");
			if (!this.o.O___oOOOOoo.)
			{
				A_0.Append(" style='display:none'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (this.O0_O_o._.)
			{
				A_0.Append(" data-autohide");
			}
			string text = " data-images='";
			try
			{
				foreach (string str in this.o.O___oOOOOoo.)
				{
					text = text + str + "|";
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.Append(text.Trim(new char[]
			{
				'|'
			}) + "'");
			A_0.AppendLine(">");
			string str2 = "";
			if (this.o.O___oOOOOoo..Count > 0)
			{
				str2 = this.o.O___oOOOOoo.[0];
			}
			if (this.O_0.o0o_.)
			{
				A_0.AppendLine("<span class='weui-gallery__img delete' style='background-image: url(" + str2 + ");'></span>");
			}
			else
			{
				A_0.AppendLine("<span class='weui-gallery__img' style='background-image: url(" + str2 + ");'></span>");
			}
			if (this.O_0.o0o_.)
			{
				A_0.AppendLine("<div class='weui-gallery__opr'>");
				A_0.AppendLine("<a class='weui-gallery__del' href='javascript:; ' data-uid='" + this.OooO_o0o0O.0_. + "'>");
				A_0.AppendLine("<i class='weui_icon_delete weui-icon_gallery-delete'></i>");
				A_0.AppendLine("</a>");
				A_0.AppendLine("</div>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000AC0 RID: 2752
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AC1 RID: 2753
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AC2 RID: 2754
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000AC3 RID: 2755
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AC4 RID: 2756
		internal string <<EMPTY_NAME>>;
	}
}
