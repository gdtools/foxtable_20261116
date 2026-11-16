using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000291 RID: 657
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossTotalCollection : IEnumerable<CrossTotalOn>
	{
		// Token: 0x060020F6 RID: 8438 RVA: 0x000E87F1 File Offset: 0x000E69F1
		public CrossTotalCollection()
		{
			this.O_oO_O_0.0_o. = new List<CrossTotalOn>();
			this.O_oO_O_0.0_o. = new List<ExpressionTotal>();
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000E880F File Offset: 0x000E6A0F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(CrossTotalOn item)
		{
			this.O_oO_O_0.0_o..Add(item);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000E8820 File Offset: 0x000E6A20
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
					this.AddDef(name, false);
					return;
				}
				break;
			}
			case 2:
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[1]);
				if (objectValue2 is string && objectValue3 is bool)
				{
					string name2 = Conversions.ToString(objectValue2).Trim();
					bool upto = Conversions.ToBoolean(objectValue3);
					this.AddDef(name2, upto);
					return;
				}
				if (objectValue2 is string && (objectValue3 is int || objectValue3 is AggregateEnum))
				{
					string name3 = Conversions.ToString(objectValue2).Trim();
					AggregateEnum aggregate = (AggregateEnum)Conversions.ToInteger(objectValue3);
					this.AddDef(name3, aggregate, false);
					return;
				}
				if (objectValue2 is string && objectValue3 is string)
				{
					string name4 = Conversions.ToString(objectValue2).Trim();
					string caption = Conversions.ToString(objectValue3).Trim();
					this.AddDef(name4, caption, false);
					return;
				}
				break;
			}
			case 3:
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue5 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[2]);
				if (objectValue4 is string && (objectValue5 is int || objectValue5 is AggregateEnum) && objectValue6 is bool)
				{
					string name5 = Conversions.ToString(objectValue4).Trim();
					AggregateEnum aggregate2 = (AggregateEnum)Conversions.ToInteger(objectValue5);
					bool upto2 = Conversions.ToBoolean(objectValue6);
					this.AddDef(name5, aggregate2, upto2);
					return;
				}
				if (objectValue4 is string && objectValue5 is string && objectValue6 is bool)
				{
					string name6 = Conversions.ToString(objectValue4).Trim();
					string caption2 = Conversions.ToString(objectValue5).Trim();
					bool upto3 = Conversions.ToBoolean(objectValue6);
					this.AddDef(name6, caption2, upto3);
					return;
				}
				if (objectValue4 is string && (objectValue5 is int || objectValue5 is AggregateEnum) && objectValue6 is string)
				{
					string name7 = Conversions.ToString(objectValue4).Trim();
					AggregateEnum aggregate3 = (AggregateEnum)Conversions.ToInteger(objectValue5);
					string caption3 = Conversions.ToString(objectValue6).Trim();
					this.AddDef(name7, aggregate3, caption3, false);
					return;
				}
				break;
			}
			case 4:
			{
				object objectValue7 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue8 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue9 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue10 = RuntimeHelpers.GetObjectValue(args[3]);
				if (objectValue7 is string && (objectValue8 is int || objectValue8 is AggregateEnum) && objectValue9 is string && objectValue10 is bool)
				{
					string name8 = Conversions.ToString(objectValue7).Trim();
					AggregateEnum aggregate4 = (AggregateEnum)Conversions.ToInteger(objectValue8);
					string caption4 = Conversions.ToString(objectValue9).Trim();
					bool upto4 = Conversions.ToBoolean(objectValue10);
					this.AddDef(name8, aggregate4, caption4, upto4);
				}
				break;
			}
			default:
				return;
			}
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x060020F9 RID: 8441 RVA: 0x000E8ADF File Offset: 0x000E6CDF
		public void AddDef(string Name, bool upto = false)
		{
			this.O_oO_O_0.0_o..Add(new CrossTotalOn(Name, upto));
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x060020FA RID: 8442 RVA: 0x000E8AF3 File Offset: 0x000E6CF3
		public void AddDef(string Name, AggregateEnum Aggregate, bool upto = false)
		{
			this.O_oO_O_0.0_o..Add(new CrossTotalOn(Name, Aggregate, upto));
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Caption">统计列标题</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x060020FB RID: 8443 RVA: 0x000E8B08 File Offset: 0x000E6D08
		public void AddDef(string Name, string Caption, bool upto = false)
		{
			this.O_oO_O_0.0_o..Add(new CrossTotalOn(Name, Caption, upto));
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="Caption">统计列标题</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x060020FC RID: 8444 RVA: 0x000E8B1D File Offset: 0x000E6D1D
		public void AddDef(string Name, AggregateEnum Aggregate, string Caption, bool upto = false)
		{
			this.O_oO_O_0.0_o..Add(new CrossTotalOn(Name, Aggregate, Caption, upto));
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000E8B34 File Offset: 0x000E6D34
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddExp(params object[] args)
		{
			switch (args.Length)
			{
			case 2:
			{
				object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
				if (objectValue is string && objectValue2 is string)
				{
					string name = Conversions.ToString(objectValue).Trim();
					string expression = Conversions.ToString(objectValue2).Trim();
					this.AddExp(name, expression, false);
					return;
				}
				break;
			}
			case 3:
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue4 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue5 = RuntimeHelpers.GetObjectValue(args[2]);
				if (objectValue3 is string && objectValue4 is string && objectValue5 is bool)
				{
					string name2 = Conversions.ToString(objectValue3).Trim();
					string expression2 = Conversions.ToString(objectValue4).Trim();
					bool upto = Conversions.ToBoolean(objectValue5);
					this.AddExp(name2, expression2, upto);
					return;
				}
				if (objectValue3 is string && objectValue4 is string && objectValue5 is int)
				{
					string name3 = Conversions.ToString(objectValue3).Trim();
					string expression3 = Conversions.ToString(objectValue4).Trim();
					AggregateEnum aggregate = (AggregateEnum)Conversions.ToInteger(objectValue5);
					this.AddExp(name3, expression3, aggregate, false);
					return;
				}
				if (objectValue3 is string && objectValue4 is string && objectValue5 is string)
				{
					string name4 = Conversions.ToString(objectValue3).Trim();
					string expression4 = Conversions.ToString(objectValue4).Trim();
					string caption = Conversions.ToString(objectValue5).Trim();
					this.AddExp(name4, expression4, caption, false);
					return;
				}
				break;
			}
			case 4:
			{
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue7 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue8 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue9 = RuntimeHelpers.GetObjectValue(args[3]);
				if (objectValue6 is string && objectValue7 is string && objectValue8 is int && objectValue9 is bool)
				{
					string name5 = Conversions.ToString(objectValue6).Trim();
					string expression5 = Conversions.ToString(objectValue7).Trim();
					AggregateEnum aggregate2 = (AggregateEnum)Conversions.ToInteger(objectValue8);
					bool upto2 = Conversions.ToBoolean(objectValue9);
					this.AddExp(name5, expression5, aggregate2, upto2);
					return;
				}
				if (objectValue6 is string && objectValue7 is string && objectValue8 is string && objectValue9 is bool)
				{
					string name6 = Conversions.ToString(objectValue6).Trim();
					string expression6 = Conversions.ToString(objectValue7).Trim();
					string caption2 = Conversions.ToString(objectValue8).Trim();
					bool upto3 = Conversions.ToBoolean(objectValue9);
					this.AddExp(name6, expression6, caption2, upto3);
					return;
				}
				if (objectValue6 is string && objectValue7 is string && objectValue8 is string && objectValue9 is int)
				{
					string name7 = Conversions.ToString(objectValue6).Trim();
					string expression7 = Conversions.ToString(objectValue7).Trim();
					string caption3 = Conversions.ToString(objectValue8).Trim();
					AggregateEnum aggregate3 = (AggregateEnum)Conversions.ToInteger(objectValue9);
					this.AddExp(name7, expression7, caption3, aggregate3, false);
					return;
				}
				break;
			}
			case 5:
			{
				object objectValue10 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue11 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue12 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue13 = RuntimeHelpers.GetObjectValue(args[3]);
				object objectValue14 = RuntimeHelpers.GetObjectValue(args[4]);
				if (objectValue10 is string && objectValue11 is string && objectValue12 is string && objectValue13 is int && objectValue14 is bool)
				{
					string name8 = Conversions.ToString(objectValue10).Trim();
					string expression8 = Conversions.ToString(objectValue11).Trim();
					string caption4 = Conversions.ToString(objectValue12).Trim();
					AggregateEnum aggregate4 = (AggregateEnum)Conversions.ToInteger(objectValue13);
					bool upto4 = Conversions.ToBoolean(objectValue14);
					this.AddExp(name8, expression8, caption4, aggregate4, upto4);
				}
				break;
			}
			default:
				return;
			}
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x060020FE RID: 8446 RVA: 0x000E8ECC File Offset: 0x000E70CC
		public void AddExp(string Name, string Expression, bool upto = false)
		{
			this.AddExp(Name, Expression, "", AggregateEnum.Sum, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x060020FF RID: 8447 RVA: 0x000E8EDD File Offset: 0x000E70DD
		public void AddExp(string Name, string Expression, AggregateEnum Aggregate, bool upto = false)
		{
			this.AddExp(Name, Expression, "", Aggregate, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">统计列标题</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x06002100 RID: 8448 RVA: 0x000E8EEF File Offset: 0x000E70EF
		public void AddExp(string Name, string Expression, string Caption, bool upto = false)
		{
			this.AddExp(Name, Expression, Caption, AggregateEnum.Sum, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">统计列标题</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x06002101 RID: 8449 RVA: 0x000E8F00 File Offset: 0x000E7100
		public void AddExp(string Name, string Expression, string Caption, AggregateEnum Aggregate, bool upto = false)
		{
			ExpressionTotal expressionTotal = new ExpressionTotal();
			expressionTotal.Name = Name;
			expressionTotal.Expression = Expression;
			expressionTotal.Caption = Caption;
			expressionTotal.Aggregate = Aggregate;
			expressionTotal.upto = upto;
			this.Exprs.Add(expressionTotal);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000E8F44 File Offset: 0x000E7144
		public IEnumerator<CrossTotalOn> GetEnumerator()
		{
			return (IEnumerator<CrossTotalOn>)this.O_oO_O_0.0_o..GetEnumerator();
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000E8F5B File Offset: 0x000E715B
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x000E8F63 File Offset: 0x000E7163
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<ExpressionTotal> Exprs
		{
			get
			{
				return this.O_oO_O_0.0_o.;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x000E8F6B File Offset: 0x000E716B
		public int Count
		{
			get
			{
				return this.O_oO_O_0.0_o..Count;
			}
		}

		// Token: 0x170006EF RID: 1775
		public CrossTotalOn this[int A_0]
		{
			get
			{
				return this.O_oO_O_0.0_o.[A_0];
			}
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000E8F86 File Offset: 0x000E7186
		public void RemoveAt(int index)
		{
			this.O_oO_O_0.0_o..RemoveAt(index);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000E8F94 File Offset: 0x000E7194
		public void Remove(CrossTotalOn item)
		{
			this.O_oO_O_0.0_o..Remove(item);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000E8FA3 File Offset: 0x000E71A3
		public void AddRange(IEnumerable<CrossTotalOn> items)
		{
			this.O_oO_O_0.0_o..AddRange(items);
		}

		// Token: 0x04000DD5 RID: 3541
		private List<CrossTotalOn> <<EMPTY_NAME>>;

		// Token: 0x04000DD6 RID: 3542
		private List<ExpressionTotal> <<EMPTY_NAME>>;
	}
}
