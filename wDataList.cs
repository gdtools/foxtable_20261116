using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200021A RID: 538
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wDataList : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A0B RID: 6667 RVA: 0x000B9808 File Offset: 0x000B7A08
		internal wDataList(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.o00.0Oo. = A_2;
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x000B9819 File Offset: 0x000B7A19
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x000B9821 File Offset: 0x000B7A21
		public string options
		{
			get
			{
				return this.o00.0Oo.;
			}
			set
			{
				this.o00.0Oo. = value;
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000B982C File Offset: 0x000B7A2C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.AppendLine("<datalist id='" + base.ID + "' >");
			checked
			{
				if (Operators.CompareString(this.options, "", true) > 0)
				{
					string[] array = this.options.Split(new char[]
					{
						'|'
					});
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							':'
						});
						if (array2.Length > 1)
						{
							A_0.AppendLine(string.Concat(new string[]
							{
								" <option value='",
								array2[0],
								"' label='",
								array2[1],
								"'/>"
							}));
						}
						else
						{
							A_0.AppendLine(" <option value='" + array2[0] + "'>");
						}
					}
				}
				A_0.AppendLine("</datalist>");
			}
		}

		// Token: 0x04000AF3 RID: 2803
		private string <<EMPTY_NAME>>;
	}
}
