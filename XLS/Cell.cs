using System;
using System.Runtime.CompilerServices;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004EF RID: 1263
	[oO0oooo("1160")]
	public class Cell
	{
		// Token: 0x060052E7 RID: 21223 RVA: 0x002554F4 File Offset: 0x002536F4
		internal Cell(XLSheet A_0, int A_1, int A_2)
		{
			this.o0_.O_o. = A_0;
			this.o__0_.oO. = A_1;
			this.o0.o0O__0oo. = A_2;
			this.o0_.O_o. = A_0[A_1, A_2];
		}

		/// <summary>
		/// 返回或设置单元格的值
		/// </summary>
		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060052E8 RID: 21224 RVA: 0x00255520 File Offset: 0x00253720
		// (set) Token: 0x060052E9 RID: 21225 RVA: 0x00255554 File Offset: 0x00253754
		public object Value
		{
			get
			{
				object result;
				if (this.o0_.O_o..Value == DBNull.Value)
				{
					result = "";
				}
				else
				{
					result = this.o0_.O_o..Value;
				}
				return result;
			}
			set
			{
				if (value is Picture)
				{
					this.o0_.O_o..Value = ((Picture)value).o0_.O_o.;
					return;
				}
				this.o0_.O_o..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 只读属性，返回单元格的文本内容
		/// </summary>
		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x00255586 File Offset: 0x00253786
		public string Text
		{
			get
			{
				return this.o0_.O_o..Text;
			}
		}

		/// <summary>
		/// 字符型，设置单元格的超链接
		/// </summary>
		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060052EB RID: 21227 RVA: 0x00255593 File Offset: 0x00253793
		// (set) Token: 0x060052EC RID: 21228 RVA: 0x002555A0 File Offset: 0x002537A0
		public string Hyperlink
		{
			get
			{
				return this.o0_.O_o..Hyperlink;
			}
			set
			{
				this.o0_.O_o..Hyperlink = value;
			}
		}

		/// <summary>
		/// 设置单元格的样式
		/// </summary>
		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x002555AE File Offset: 0x002537AE
		// (set) Token: 0x060052EE RID: 21230 RVA: 0x002555C0 File Offset: 0x002537C0
		public Style Style
		{
			get
			{
				return new Style(this.o0_.O_o..Style);
			}
			set
			{
				if (value == null)
				{
					this.o0_.O_o..Style = null;
					return;
				}
				this.o0_.O_o..Style = value.Ooo_O__.0.;
			}
		}

		/// <summary>
		/// 一次性设置单元格的值和样式
		/// </summary>
		/// <param name="Value">值</param>
		/// <param name="Style">样式</param>
		// Token: 0x060052EF RID: 21231 RVA: 0x002555E3 File Offset: 0x002537E3
		public void SetValue(object Value, Style Style)
		{
			this.o0_.O_o..SetValue(RuntimeHelpers.GetObjectValue(Value), Style.Ooo_O__.0.);
		}

		/// <summary>
		/// 将单元格中的图片保存为文件
		/// </summary>
		/// <param name="FileName"></param>
		// Token: 0x060052F0 RID: 21232 RVA: 0x002555FC File Offset: 0x002537FC
		public bool SaveImage(string FileName)
		{
			int num = this.o0_.O_o..Shapes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.o0_.O_o..Shapes[i] is XLPictureShape)
				{
					XLPictureShape xlpictureShape = (XLPictureShape)this.o0_.O_o..Shapes[i];
					if (xlpictureShape.Row == this.o__0_.oO. && xlpictureShape.Column == this.o0.o0O__0oo. && xlpictureShape.Image != null)
					{
						if (OO_00oOO.FileSys.FileExists(FileName))
						{
							OO_00oOO.FileSys.DeleteFile(FileName);
						}
						xlpictureShape.Image.Save(FileName, O_O0OO.OoO_00._.(FileName));
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x002556B2 File Offset: 0x002538B2
		// (set) Token: 0x060052F2 RID: 21234 RVA: 0x002556BF File Offset: 0x002538BF
		public string Formula
		{
			get
			{
				return this.o0_.O_o..Formula;
			}
			set
			{
				this.o0_.O_o..Value = " ";
				this.o0_.O_o..Formula = value.Trim(new char[]
				{
					'='
				}).Trim();
			}
		}

		// Token: 0x04002274 RID: 8820
		private XLSheet <<EMPTY_NAME>>;

		// Token: 0x04002275 RID: 8821
		private XLCell <<EMPTY_NAME>>;

		// Token: 0x04002276 RID: 8822
		private int <<EMPTY_NAME>>;

		// Token: 0x04002277 RID: 8823
		private int <<EMPTY_NAME>>;
	}
}
