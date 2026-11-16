using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000C9 RID: 201
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oOo___ : IComparer<TreeNode>
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x0004A62F File Offset: 0x0004882F
		public oOo___(O0_0_0O0___O A_0, bool A_1)
		{
			this.o0.OOOo. = A_0;
			this.o0.OOOo. = A_1;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0004A648 File Offset: 0x00048848
		public int <<EMPTY_NAME>>(TreeNode A_0, TreeNode A_1)
		{
			int result;
			if (Operators.CompareString(A_0.Text, "显示所有行", true) == 0)
			{
				result = -1;
			}
			else if (Operators.CompareString(A_1.Text, "显示所有行", true) == 0)
			{
				result = 1;
			}
			else
			{
				int[] array = new int[]
				{
					int.MinValue,
					int.MinValue
				};
				int[] array2 = new int[]
				{
					int.MinValue,
					int.MinValue
				};
				string[] array3 = new string[2];
				TreeNode[] array4 = new TreeNode[]
				{
					A_0,
					A_1
				};
				int num = 0;
				do
				{
					if (array4[num].Text.IndexOf("(") >= 0 && array4[num].Text.IndexOf(")") >= 0)
					{
						array3[num] = array4[num].Text.Substring(array4[num].Text.LastIndexOf("("));
						array3[num] = array3[num].Trim(new char[]
						{
							'(',
							')'
						});
						string[] array5 = array3[num].Split(new char[]
						{
							','
						});
						if (array5.Length == 1)
						{
							int.TryParse(array5[0], out array[num]);
						}
						else if (array5.Length == 2)
						{
							if (this.o0.OOOo. == O0_0_0O0___O.OOO.__O_oO_.)
							{
								int.TryParse(array5[1], out array[num]);
							}
							else
							{
								int.TryParse(array5[0], out array[num]);
								int.TryParse(array5[1], out array2[num]);
							}
						}
					}
					num++;
				}
				while (num <= 1);
				if (array[0] == array[1] && (array2[0] > -2147483648 || array2[1] > -2147483648))
				{
					array[0] = array2[0];
					array[1] = array2[1];
				}
				int num2 = Comparer<int>.Default.Compare(array[0], array[1]);
				if (this.o0.OOOo.)
				{
					num2 = -num2;
				}
				if (num2 == 0)
				{
					result = Comparer.DefaultInvariant.Compare(A_0.Text, A_1.Text);
				}
				else
				{
					result = num2;
				}
			}
			return result;
		}

		// Token: 0x0400032D RID: 813
		private O0_0_0O0___O <<EMPTY_NAME>>;

		// Token: 0x0400032E RID: 814
		private bool <<EMPTY_NAME>>;
	}
}
