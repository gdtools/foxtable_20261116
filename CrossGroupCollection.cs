using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200028E RID: 654
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossGroupCollection : IEnumerable<CrossGroupOn>
	{
		// Token: 0x06002098 RID: 8344 RVA: 0x000E2E44 File Offset: 0x000E1044
		public CrossGroupCollection()
		{
			this.OOOOO_0._o0O0o. = new List<CrossGroupOn>();
			this.OOOOO_0._o0O0o. = new List<CrossExpressionGroup>();
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000E2E62 File Offset: 0x000E1062
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(CrossGroupOn item)
		{
			this.OOOOO_0._o0O0o..Add(item);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000E2E70 File Offset: 0x000E1070
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddDef(params object[] args)
		{
			switch (args.Length)
			{
			case 1:
			{
				object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
				if (objectValue is string)
				{
					string name = Conversions.ToString(objectValue).Trim();
					this.AddDef(name);
					return;
				}
				break;
			}
			case 2:
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[1]);
				if (objectValue2 is string)
				{
					if (objectValue3 is string)
					{
						string name2 = Conversions.ToString(objectValue2).Trim();
						string pattern = Conversions.ToString(objectValue3).Trim();
						this.AddDef(name2, pattern);
						return;
					}
					if (objectValue3 is int || objectValue3 is DateGroupEnum)
					{
						string name3 = Conversions.ToString(objectValue2).Trim();
						DateGroupEnum dateGroup = (DateGroupEnum)Conversions.ToInteger(objectValue3);
						this.AddDef(name3, dateGroup);
						return;
					}
				}
				break;
			}
			case 3:
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue5 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[2]);
				if (objectValue4 is string && (objectValue5 is int || objectValue5 is DateGroupEnum) && objectValue6 is string)
				{
					string name4 = Conversions.ToString(objectValue4).Trim();
					DateGroupEnum dateGroup2 = (DateGroupEnum)Conversions.ToInteger(objectValue5);
					string pattern2 = Conversions.ToString(objectValue6).Trim();
					this.AddDef(name4, dateGroup2, pattern2);
				}
				break;
			}
			default:
				return;
			}
		}

		/// <summary>
		/// 增加分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		// Token: 0x0600209B RID: 8347 RVA: 0x000E2FB4 File Offset: 0x000E11B4
		public void AddDef(string Name)
		{
			this.OOOOO_0._o0O0o..Add(new CrossGroupOn(Name));
		}

		/// <summary>
		/// 增加分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="Pattern">指定生成标题的模式，用字符"{0}"表示分组值；假定分组值是10，模式是"第{0}周"，生成的分组标题将是"第10周"</param>
		// Token: 0x0600209C RID: 8348 RVA: 0x000E2FC7 File Offset: 0x000E11C7
		public void AddDef(string Name, string Pattern)
		{
			this.OOOOO_0._o0O0o..Add(new CrossGroupOn(Name, Pattern));
		}

		/// <summary>
		/// 增加日期型分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="DateGroup">日期列的分组方式</param>
		// Token: 0x0600209D RID: 8349 RVA: 0x000E2FDB File Offset: 0x000E11DB
		public void AddDef(string Name, DateGroupEnum DateGroup)
		{
			this.OOOOO_0._o0O0o..Add(new CrossGroupOn(Name, DateGroup));
		}

		/// <summary>
		/// 增加日期型分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="DateGroup">日期列的分组方式</param>
		/// <param name="Pattern">指定生成标题的模式，用字符"{0}"表示分组值；假定分组值是10，模式是"第{0}周"，生成的分组标题将是"第10周"</param>
		// Token: 0x0600209E RID: 8350 RVA: 0x000E2FEF File Offset: 0x000E11EF
		public void AddDef(string Name, DateGroupEnum DateGroup, string Pattern)
		{
			this.OOOOO_0._o0O0o..Add(new CrossGroupOn(Name, DateGroup, Pattern));
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x000E3004 File Offset: 0x000E1204
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddExp(params object[] args)
		{
			string[] array = new string[args.Length - 1 + 1];
			int num = args.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Conversions.ToString(args[i]).Trim();
			}
			int num2 = array.Length;
			if (num2 == 2)
			{
				string name = array[0];
				string expression = array[1];
				this.AddExp(name, expression);
				return;
			}
			if (num2 != 3)
			{
				return;
			}
			string name2 = array[0];
			string expression2 = array[1];
			string pattern = array[2];
			this.AddExp(name2, expression2, pattern);
		}

		/// <summary>
		/// 增加表达式分组列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x060020A0 RID: 8352 RVA: 0x000E307D File Offset: 0x000E127D
		public void AddExp(string Name, string Expression)
		{
			this.Exprs.Add(new CrossExpressionGroup(Name, Expression, ""));
		}

		/// <summary>
		/// 增加表达式分组列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x060020A1 RID: 8353 RVA: 0x000E3096 File Offset: 0x000E1296
		public void AddExp(string Name, string Expression, string Pattern)
		{
			this.Exprs.Add(new CrossExpressionGroup(Name, Expression, Pattern));
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000E30AB File Offset: 0x000E12AB
		public IEnumerator<CrossGroupOn> GetEnumerator()
		{
			return (IEnumerator<CrossGroupOn>)this.OOOOO_0._o0O0o..GetEnumerator();
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000E30C2 File Offset: 0x000E12C2
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.GetEnumerator();
		}

		/// <param name="Pattern">指定生成标题的模式，用字符"{0}"表示分组值；假定分组值是10，模式是"第{0}周"，生成的分组标题将是"第10周"</param>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000E30CA File Offset: 0x000E12CA
		public List<CrossExpressionGroup> Exprs
		{
			get
			{
				return this.OOOOO_0._o0O0o.;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000E30D2 File Offset: 0x000E12D2
		public int Count
		{
			get
			{
				return this.OOOOO_0._o0O0o..Count;
			}
		}

		// Token: 0x170006CD RID: 1741
		public CrossGroupOn this[int A_0]
		{
			get
			{
				return this.OOOOO_0._o0O0o.[A_0];
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000E30ED File Offset: 0x000E12ED
		public void RemoveAt(int index)
		{
			this.OOOOO_0._o0O0o..RemoveAt(index);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x000E30FB File Offset: 0x000E12FB
		public void AddRange(IEnumerable<CrossGroupOn> items)
		{
			this.OOOOO_0._o0O0o..AddRange(items);
		}

		// Token: 0x04000DAD RID: 3501
		private List<CrossGroupOn> <<EMPTY_NAME>>;

		// Token: 0x04000DAE RID: 3502
		private List<CrossExpressionGroup> <<EMPTY_NAME>>;
	}
}
