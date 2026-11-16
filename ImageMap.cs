using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 图形字典
	/// </summary>
	// Token: 0x02000323 RID: 803
	[ComVisible(true)]
	[oO0oooo("0583")]
	public class ImageMap : Dictionary<string, string>
	{
		/// <summary>
		/// 增加图片
		/// </summary>
		/// <param name="Value">值</param>
		/// <param name="ImageFile">图片文件</param>
		// Token: 0x06002CFE RID: 11518 RVA: 0x0014CDDF File Offset: 0x0014AFDF
		public new void Add(string Value, string ImageFile)
		{
			base.Add(Value, ImageFile);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0014CDEC File Offset: 0x0014AFEC
		internal string ImageKeys
		{
			get
			{
				string text = "";
				try
				{
					foreach (string str in base.Keys)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "|";
						}
						text += str;
					}
				}
				finally
				{
					Dictionary<string, string>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return text;
			}
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0014CE64 File Offset: 0x0014B064
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IDictionary <<EMPTY_NAME>>()
		{
			Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
			try
			{
				foreach (string key in base.Keys)
				{
					dictionary.Add(key, OO_00oOO.GetImage(base[key]));
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return dictionary;
		}
	}
}
