using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200023A RID: 570
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0054")]
	public class wUploader : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x000BFA0C File Offset: 0x000BDC0C
		internal wUploader(string A_0, string A_1, string A_2, bool A_3, string A_4) : base(A_0, A_1)
		{
			this.oo.oO0. = new Dictionary<string, string>();
			this.oo.oO0. = new List<string>();
			this.o_.o_o_O000_0_. = new List<string>();
			this.OoOoo_o_.o_. = 1;
			this.o0.oO0O_oO__O_. = true;
			this.Oo0o_._00_O. = false;
			this.o_.o_o_O000_0_. = -1;
			this.oO_0oo.0oo__0_. = -1;
			this.o0_.OO_00. = 0;
			this.oo.oO0. = A_2;
			this.oo.oO0. = A_3;
			this.Oo0o_._00_O. = A_4;
		}

		/// <summary>
		/// 增加图片
		/// </summary>
		/// <param name="image">图片文件，含路径</param>
		// Token: 0x06001B36 RID: 6966 RVA: 0x000BFA83 File Offset: 0x000BDC83
		public void AddImage(string image)
		{
			this.oo.oO0..Add(image, image);
			this.o_.o_o_O000_0_..Add(image);
		}

		/// <summary>
		/// 增加缩略图及对应的图片
		/// </summary>
		/// <param name="thumbnail">缩略图文件，含路径</param>
		/// <param name="image">图片文件，含路径</param>
		// Token: 0x06001B37 RID: 6967 RVA: 0x000BFA9E File Offset: 0x000BDC9E
		[oO0oooo("A0093")]
		public void AddImage(string thumbnail, string image)
		{
			this.oo.oO0..Add(thumbnail, image);
			this.o_.o_o_O000_0_..Add(thumbnail);
		}

		/// <summary>
		/// 组件标题
		/// </summary>
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000BFAB9 File Offset: 0x000BDCB9
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x000BFAC1 File Offset: 0x000BDCC1
		public string Label
		{
			get
			{
				return this.oo.oO0.;
			}
			set
			{
				this.oo.oO0. = value;
			}
		}

		/// <summary>
		/// 是否允许删除图片，默认为False
		/// </summary>
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000BFACA File Offset: 0x000BDCCA
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x000BFAD2 File Offset: 0x000BDCD2
		[oO0oooo("A0092")]
		public bool AllowDelete
		{
			get
			{
				return this.Oo0o_._00_O.;
			}
			set
			{
				this.Oo0o_._00_O. = value;
			}
		}

		/// <summary>
		/// 是否允许增加图片，默认为True
		/// </summary>
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x000BFADB File Offset: 0x000BDCDB
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x000BFAE3 File Offset: 0x000BDCE3
		[oO0oooo("A0091")]
		public bool AllowAdd
		{
			get
			{
				return this.o0.oO0O_oO__O_.;
			}
			set
			{
				this.o0.oO0O_oO__O_. = value;
			}
		}

		/// <summary>
		/// 标题位置，0表示标题靠左，1表示标题靠上，默认为1
		/// </summary>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x000BFAEC File Offset: 0x000BDCEC
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x000BFAF4 File Offset: 0x000BDCF4
		[oO0oooo("A0089")]
		public int TextPosition
		{
			get
			{
				return this.OoOoo_o_.o_.;
			}
			set
			{
				this.OoOoo_o_.o_. = value;
			}
		}

		/// <summary>
		/// 设置为True，可以逐个增加或删除文件
		/// </summary>
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x000BFAFD File Offset: 0x000BDCFD
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x000BFB05 File Offset: 0x000BDD05
		[oO0oooo("A0106")]
		public bool Incremental
		{
			get
			{
				return this.o0_.OO_00.;
			}
			set
			{
				this.o0_.OO_00. = value;
			}
		}

		/// <summary>
		/// 图片压缩后的宽度
		/// </summary>
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x000BFB0E File Offset: 0x000BDD0E
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x000BFB16 File Offset: 0x000BDD16
		[oO0oooo("A0251")]
		public int ScaleWidth
		{
			get
			{
				return this.o_.o_o_O000_0_.;
			}
			set
			{
				this.o_.o_o_O000_0_. = value;
			}
		}

		/// <summary>
		/// 图片压缩后的高度
		/// </summary>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x000BFB1F File Offset: 0x000BDD1F
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x000BFB27 File Offset: 0x000BDD27
		[oO0oooo("A0251")]
		public int ScaleHeight
		{
			get
			{
				return this.oO_0oo.0oo__0_.;
			}
			set
			{
				this.oO_0oo.0oo__0_. = value;
			}
		}

		/// <summary>
		/// 图片旋转角度,1旋转90度,2旋转180度,3旋转270度
		/// </summary>
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x000BFB30 File Offset: 0x000BDD30
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x000BFB38 File Offset: 0x000BDD38
		[oO0oooo("0257")]
		public int Rotate
		{
			get
			{
				return this.o0_.OO_00.;
			}
			set
			{
				this.o0_.OO_00. = value;
			}
		}

		/// <summary>
		/// 如果希望不能从相册选择，而是直接拍照上传，可以将此属性设置为"camera"，
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000BFB41 File Offset: 0x000BDD41
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x000BFB49 File Offset: 0x000BDD49
		public string Capture
		{
			get
			{
				return this.o0.oO0O_oO__O_.;
			}
			set
			{
				this.o0.oO0O_oO__O_. = value;
			}
		}

		/// <summary>
		/// 在安卓手机中使用微信浏览器，需要将此属性设置为"image/*"，才能使用摄像头拍照上传
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000BFB52 File Offset: 0x000BDD52
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x000BFB5A File Offset: 0x000BDD5A
		public string Accept
		{
			get
			{
				return this.Oo0o_._00_O.;
			}
			set
			{
				this.Oo0o_._00_O. = value;
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000BFB64 File Offset: 0x000BDD64
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHtml(StringBuilder sb, wui wui)
		{
			sb.AppendLine("  <div class='weui_cell'>");
			if (Operators.CompareString(this.oo.oO0., "", true) > 0 && this.OoOoo_o_.o_. == 0)
			{
				sb.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + this.oo.oO0. + "</label></div>");
			}
			sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			sb.AppendLine(" <div class='weui_uploader'>");
			if (Operators.CompareString(this.oo.oO0., "", true) > 0 && this.OoOoo_o_.o_. == 1)
			{
				sb.AppendLine("<div class='weui_uploader_hd weui_cell'>");
				if (this.oo.oO0..IndexOf('\v') == -1)
				{
					sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>" + this.oo.oO0. + "</div>");
				}
				else
				{
					string[] array = this.oo.oO0..Split(new char[]
					{
						'\v'
					});
					sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>" + array[0] + "</div>");
					sb.AppendLine("<div class='weui_cell_ft'>" + array[1] + "</div>");
				}
				sb.AppendLine("</div>");
			}
			sb.AppendLine(" <div class='weui_uploader_bd'>");
			sb.AppendLine("<ul class='weui_uploader_files' id='" + base.ID + "_thumbnails'>");
			if (this.oo.oO0..Count > 0)
			{
				try
				{
					foreach (string text in this.o_.o_o_O000_0_.)
					{
						sb.AppendLine(string.Concat(new string[]
						{
							"<li data-gid='",
							base.ID,
							"_gallery' data-image='",
							this.oo.oO0.[text],
							"' class='weui_uploader_file' style='background-image:url(",
							text,
							")'></li>"
						}));
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			sb.AppendLine("</ul>");
			if (this.o0.oO0O_oO__O_.)
			{
				sb.AppendLine("<div class='weui_uploader_input_wrp'>");
				sb.AppendLine("<div id='" + base.ID + "_counter' class='fox_uploader_Counter'></div>");
				sb.AppendLine(string.Concat(new string[]
				{
					"<input class='weui_uploader_input' type='file' id='",
					base.ID,
					"' name='",
					base.ID,
					"'",
					Interaction.IIf(this.oo.oO0., " multiple ", "").ToString(),
					Interaction.IIf(this.o0_.OO_00., " data-incremental", "").ToString(),
					Interaction.IIf(Operators.CompareString(this.Oo0o_._00_O., "", true) > 0, " accept='" + this.Oo0o_._00_O. + "'", "").ToString(),
					Interaction.IIf(Operators.CompareString(this.o0.oO0O_oO__O_., "", true) > 0, " capture='" + this.o0.oO0O_oO__O_. + "'", "").ToString(),
					Interaction.IIf(this.o_.o_o_O000_0_. > 0, " data-scalewidth=" + Conversions.ToString(this.o_.o_o_O000_0_.), "").ToString(),
					Interaction.IIf(this.oO_0oo.0oo__0_. > 0, " data-scaleheight=" + Conversions.ToString(this.oO_0oo.0oo__0_.), "").ToString(),
					Interaction.IIf(this.o0_.OO_00. > 0, " data-rotate=" + Conversions.ToString(this.o0_.OO_00.), "").ToString(),
					" />"
				}));
				sb.AppendLine("</div>");
			}
			sb.AppendLine("</div>");
			sb.AppendLine("</div>");
			sb.AppendLine("</div>");
			sb.AppendLine("</div>");
			if (this.Oo0o_._00_O. && this.oo.oO0..Count > 0)
			{
				string text2 = base.ID + "_deleted";
				sb.Append(string.Concat(new string[]
				{
					"<input name='",
					text2,
					"' id='",
					text2,
					"' hidden>"
				}));
			}
			wGallery wGallery = new wGallery("", base.ID + "_gallery", false, true);
			wGallery.Delete = this.Oo0o_._00_O.;
			wGallery.OooO_o0o0O.0_. = base.ID;
			try
			{
				foreach (string text3 in this.oo.oO0..Values)
				{
					wGallery.AddImage(new string[]
					{
						text3
					});
				}
			}
			finally
			{
				Dictionary<string, string>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			wui.O.oO_oO..Add(base.ID + "_gallery", wGallery);
		}

		// Token: 0x04000B74 RID: 2932
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B75 RID: 2933
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B76 RID: 2934
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000B77 RID: 2935
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B78 RID: 2936
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B79 RID: 2937
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B7A RID: 2938
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B7B RID: 2939
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B7C RID: 2940
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B7D RID: 2941
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B7E RID: 2942
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B7F RID: 2943
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B80 RID: 2944
		public string <<EMPTY_NAME>>;

		// Token: 0x04000B81 RID: 2945
		private string <<EMPTY_NAME>>;
	}
}
