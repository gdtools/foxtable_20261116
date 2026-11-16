using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000212 RID: 530
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0079")]
	public class wArticle : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019C3 RID: 6595 RVA: 0x000B8224 File Offset: 0x000B6424
		internal wArticle(string A_0, string A_1, Dictionary<string, wElement> A_2) : base(A_0, A_1)
		{
			this.oO.0oO0. = A_2;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000B8238 File Offset: 0x000B6438
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BeginSection()
		{
			string text = OoOo0O.OO_o.0o_O.(6);
			while (this.oO.0oO0..ContainsKey(text))
			{
				text = OoOo0O.OO_o.0o_O.(6);
			}
			wRawHtml value = new wRawHtml(base.ID, text, "<section>");
			this.oO.0oO0..Add(text, value);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000B8284 File Offset: 0x000B6484
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void EndSection()
		{
			string text = OoOo0O.OO_o.0o_O.(6);
			while (this.oO.0oO0..ContainsKey(text))
			{
				text = OoOo0O.OO_o.0o_O.(6);
			}
			wRawHtml value = new wRawHtml(base.ID, text, "</section>");
			this.oO.0oO0..Add(text, value);
		}

		/// <summary>
		/// 增加标题
		/// </summary>
		/// <param name="level">标题层级，有6个可选值，分别为：h1、h2、h3、h4、h5、h6。</param>
		/// <param name="Title">标题内容</param>
		/// <param name="Attribute">可选值，标题属性</param>
		// Token: 0x060019C6 RID: 6598 RVA: 0x000B82D0 File Offset: 0x000B64D0
		public void AddTitle(string level, string Title, string Attribute = "")
		{
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			string text = base.ID + "_Title_" + Conversions.ToString(this.OOOO.__O__Oo.);
			this.OOOO.__O__Oo.++;
			wRawHtml value = new wRawHtml(base.ID, text, string.Concat(new string[]
			{
				"<",
				level,
				Attribute,
				">",
				Title,
				"</",
				level,
				">"
			}));
			this.oO.0oO0..Add(text, value);
		}

		/// <summary>
		/// 增加文本段落
		/// </summary>
		/// <param name="Content">段落内容</param>
		/// <param name="Attribute">可选参数，段落属性</param>
		// Token: 0x060019C7 RID: 6599 RVA: 0x000B8378 File Offset: 0x000B6578
		public void AddContent(string Content, string Attribute = "")
		{
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			string text = base.ID + "_Content_" + Conversions.ToString(this.oO.0oO0.);
			this.oO.0oO0.++;
			wRawHtml value = new wRawHtml(base.ID, text, string.Concat(new string[]
			{
				"<p",
				Attribute,
				">",
				Content,
				"</p>"
			}));
			this.oO.0oO0..Add(text, value);
		}

		/// <summary>
		/// 增加图片
		/// </summary>
		/// <param name="Image">图片文件</param>
		/// <param name="Attribute">可选参数，图片属性</param>
		// Token: 0x060019C8 RID: 6600 RVA: 0x000B8410 File Offset: 0x000B6610
		public void AddImage(string Image, string Attribute = "")
		{
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			if (this.UseGallery)
			{
				string text = base.ID + "_gallery";
				if (this.oO.0oO0. == null)
				{
					this.oO.0oO0. = new wGallery("", text, false, true);
				}
				this.oO.0oO0..AddImage(new string[]
				{
					Image
				});
				Attribute = string.Concat(new string[]
				{
					Attribute,
					" class='article_image' data-gid='",
					text,
					"' data-image='",
					Image,
					"'"
				});
			}
			string text2 = OoOo0O.OO_o.0o_O.(6);
			while (this.oO.0oO0..ContainsKey(text2))
			{
				text2 = OoOo0O.OO_o.0o_O.(6);
			}
			wRawHtml value = new wRawHtml(base.ID, text2, string.Concat(new string[]
			{
				"<img  src='",
				Image,
				"'",
				Attribute,
				">"
			}));
			this.oO.0oO0..Add(text2, value);
		}

		/// <summary>
		/// 是否启用Gallery,
		/// </summary>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x000B8516 File Offset: 0x000B6716
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x000B851E File Offset: 0x000B671E
		[oO0oooo("A0088")]
		public bool UseGallery
		{
			get
			{
				return this.oO.0oO0.;
			}
			set
			{
				this.oO.0oO0. = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000B8527 File Offset: 0x000B6727
		private string baseClass
		{
			get
			{
				return "weui_article";
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000B8530 File Offset: 0x000B6730
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text;
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = "<article class='" + this.baseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					"<article class='",
					this.baseClass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			text += ">";
			A_0.AppendLine(text);
			try
			{
				foreach (wElement wElement in A_1.o0_._00..Values)
				{
					if (Operators.CompareString(wElement.PID, base.ID, true) == 0)
					{
						((o_oOOOoo_O_O)wElement).OOO.__O_oO_.(A_0, A_1);
					}
				}
			}
			finally
			{
				Dictionary<string, wElement>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</article>");
			if (this.oO.0oO0. != null)
			{
				A_1.O.oO_oO..Add(base.ID + "_gallery", this.oO.0oO0.);
			}
		}

		// Token: 0x04000AD2 RID: 2770
		private Dictionary<string, wElement> <<EMPTY_NAME>>;

		// Token: 0x04000AD3 RID: 2771
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AD4 RID: 2772
		private wGallery <<EMPTY_NAME>>;

		// Token: 0x04000AD5 RID: 2773
		private int <<EMPTY_NAME>>;

		// Token: 0x04000AD6 RID: 2774
		private int <<EMPTY_NAME>>;
	}
}
