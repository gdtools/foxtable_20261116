using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002A1 RID: 673
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TotalCollection : IEnumerable<TotalOn>
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x000F571B File Offset: 0x000F391B
		public TotalCollection()
		{
			this.O__.o__. = new List<TotalOn>();
			this.O__.o__. = new List<ExpressionTotal>();
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000F5739 File Offset: 0x000F3939
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(TotalOn Item)
		{
			this.O__.o__..Add(Item);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000F5748 File Offset: 0x000F3948
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
				if (objectValue2 is string && objectValue3 is string)
				{
					string name3 = Conversions.ToString(objectValue2).Trim();
					string newName = Conversions.ToString(objectValue3).Trim();
					this.AddDef(name3, newName, false);
					return;
				}
				if (objectValue2 is string && (objectValue3 is int || objectValue3 is AggregateEnum))
				{
					string name4 = Conversions.ToString(objectValue2).Trim();
					AggregateEnum aggregate = (AggregateEnum)Conversions.ToInteger(objectValue3);
					this.AddDef(name4, aggregate, false);
					return;
				}
				break;
			}
			case 3:
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue5 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[2]);
				if (objectValue4 is string && objectValue5 is string && objectValue6 is bool)
				{
					string name5 = Conversions.ToString(objectValue4).Trim();
					string newName2 = Conversions.ToString(objectValue5).Trim();
					bool upto2 = Conversions.ToBoolean(objectValue6);
					this.AddDef(name5, newName2, upto2);
					return;
				}
				if (objectValue4 is string && (objectValue5 is int || objectValue5 is AggregateEnum) && objectValue6 is bool)
				{
					string name6 = Conversions.ToString(objectValue4).Trim();
					AggregateEnum aggregate2 = (AggregateEnum)Conversions.ToInteger(objectValue5);
					bool upto3 = Conversions.ToBoolean(objectValue6);
					this.AddDef(name6, aggregate2, upto3);
					return;
				}
				if (objectValue4 is string && objectValue5 is string && objectValue6 is string)
				{
					string name7 = Conversions.ToString(objectValue4).Trim();
					string newName3 = Conversions.ToString(objectValue5).Trim();
					string newCaption = Conversions.ToString(objectValue6).Trim();
					this.AddDef(name7, newName3, newCaption, false);
					return;
				}
				if (objectValue4 is string && (objectValue5 is int || objectValue5 is AggregateEnum) && objectValue6 is string)
				{
					string name8 = Conversions.ToString(objectValue4).Trim();
					AggregateEnum aggregate3 = (AggregateEnum)Conversions.ToInteger(objectValue5);
					string newName4 = Conversions.ToString(objectValue6).Trim();
					this.AddDef(name8, aggregate3, newName4, false);
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
				if (objectValue7 is string && objectValue8 is string && objectValue9 is string && objectValue10 is bool)
				{
					string name9 = Conversions.ToString(objectValue7).Trim();
					string newName5 = Conversions.ToString(objectValue8).Trim();
					string newCaption2 = Conversions.ToString(objectValue9).Trim();
					bool upto4 = Conversions.ToBoolean(objectValue10);
					this.AddDef(name9, newName5, newCaption2, upto4);
					return;
				}
				if (objectValue7 is string && (objectValue8 is int || objectValue8 is AggregateEnum) && objectValue9 is string && objectValue10 is bool)
				{
					string name10 = Conversions.ToString(objectValue7).Trim();
					AggregateEnum aggregate4 = (AggregateEnum)Conversions.ToInteger(objectValue8);
					string newName6 = Conversions.ToString(objectValue9).Trim();
					bool upto5 = Conversions.ToBoolean(objectValue10);
					this.AddDef(name10, aggregate4, newName6, upto5);
					return;
				}
				if (objectValue7 is string && (objectValue8 is int || objectValue8 is AggregateEnum) && objectValue9 is string && objectValue10 is string)
				{
					string name11 = Conversions.ToString(objectValue7).Trim();
					AggregateEnum aggregate5 = (AggregateEnum)Conversions.ToInteger(objectValue8);
					string newName7 = Conversions.ToString(objectValue9).Trim();
					string newCaption3 = Conversions.ToString(objectValue10).Trim();
					this.AddDef(name11, aggregate5, newName7, newCaption3, false);
					return;
				}
				break;
			}
			case 5:
			{
				object objectValue11 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue12 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue13 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue14 = RuntimeHelpers.GetObjectValue(args[3]);
				object objectValue15 = RuntimeHelpers.GetObjectValue(args[4]);
				if (objectValue11 is string && (objectValue12 is int || objectValue12 is AggregateEnum) && objectValue13 is string && objectValue14 is string && objectValue15 is bool)
				{
					string name12 = Conversions.ToString(objectValue11).Trim();
					AggregateEnum aggregate6 = (AggregateEnum)Conversions.ToInteger(objectValue12);
					string newName8 = Conversions.ToString(objectValue13).Trim();
					string newCaption4 = Conversions.ToString(objectValue14).Trim();
					bool upto6 = Conversions.ToBoolean(objectValue15);
					this.AddDef(name12, aggregate6, newName8, newCaption4, upto6);
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
		// Token: 0x06002235 RID: 8757 RVA: 0x000F5BF8 File Offset: 0x000F3DF8
		public void AddDef(string Name, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="NewName">给统计列指定一个新的名称，这个名称在统计表中显示</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x06002236 RID: 8758 RVA: 0x000F5C20 File Offset: 0x000F3E20
		public void AddDef(string Name, string NewName, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name, NewName);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		/// <summary>
		///  增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="NewName">给统计列指定一个新的名称，这个名称在统计表中显示</param>
		/// <param name="NewCaption">给统计列指定标题</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x06002237 RID: 8759 RVA: 0x000F5C48 File Offset: 0x000F3E48
		public void AddDef(string Name, string NewName, string NewCaption, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name, NewName, NewCaption);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x06002238 RID: 8760 RVA: 0x000F5C74 File Offset: 0x000F3E74
		public void AddDef(string Name, AggregateEnum Aggregate, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name, Aggregate);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="NewName">给统计列指定一个新的名称，这个名称在统计表中显示</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x06002239 RID: 8761 RVA: 0x000F5C9C File Offset: 0x000F3E9C
		public void AddDef(string Name, AggregateEnum Aggregate, string NewName, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name, Aggregate, NewName);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Name">统计列名</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="NewName">给统计列指定一个新的名称，这个名称在统计表中显示</param>
		/// <param name="NewCaption">给统计列指定标题</param>
		/// <param name="upto">是否进行截止统计</param>
		// Token: 0x0600223A RID: 8762 RVA: 0x000F5CC8 File Offset: 0x000F3EC8
		public void AddDef(string Name, AggregateEnum Aggregate, string NewName, string NewCaption, bool upto = false)
		{
			TotalOn totalOn = new TotalOn(Name, Aggregate, NewName, NewCaption);
			totalOn.upto = upto;
			this.O__.o__..Add(totalOn);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000F5CF4 File Offset: 0x000F3EF4
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
				if (objectValue3 is string && objectValue4 is string)
				{
					if (objectValue5 is bool)
					{
						string name2 = Conversions.ToString(objectValue3).Trim();
						string expression2 = Conversions.ToString(objectValue4).Trim();
						bool upto = Conversions.ToBoolean(objectValue5);
						this.AddExp(name2, expression2, upto);
						return;
					}
					if (objectValue5 is string)
					{
						string name3 = Conversions.ToString(objectValue3).Trim();
						string expression3 = Conversions.ToString(objectValue4).Trim();
						string caption = Conversions.ToString(objectValue5).Trim();
						this.AddExp(name3, expression3, caption, false);
						return;
					}
					if (objectValue5 is int)
					{
						string name4 = Conversions.ToString(objectValue3).Trim();
						string expression4 = Conversions.ToString(objectValue4).Trim();
						AggregateEnum aggregate = (AggregateEnum)Conversions.ToInteger(objectValue5);
						this.AddExp(name4, expression4, aggregate, false);
						return;
					}
				}
				break;
			}
			case 4:
			{
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue7 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue8 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue9 = RuntimeHelpers.GetObjectValue(args[3]);
				if (objectValue6 is string && objectValue7 is string)
				{
					if (objectValue8 is string && objectValue9 is bool)
					{
						string name5 = Conversions.ToString(objectValue6).Trim();
						string expression5 = Conversions.ToString(objectValue7).Trim();
						string caption2 = Conversions.ToString(objectValue8).Trim();
						bool upto2 = Conversions.ToBoolean(objectValue9);
						this.AddExp(name5, expression5, caption2, upto2);
						return;
					}
					if (objectValue8 is int && objectValue9 is bool)
					{
						string name6 = Conversions.ToString(objectValue6).Trim();
						string expression6 = Conversions.ToString(objectValue7).Trim();
						AggregateEnum aggregate2 = (AggregateEnum)Conversions.ToInteger(objectValue8);
						bool upto3 = Conversions.ToBoolean(objectValue9);
						this.AddExp(name6, expression6, aggregate2, upto3);
						return;
					}
					if (objectValue8 is string && objectValue9 is int)
					{
						string name7 = Conversions.ToString(objectValue6).Trim();
						string expression7 = Conversions.ToString(objectValue7).Trim();
						string caption3 = Conversions.ToString(objectValue8).Trim();
						AggregateEnum aggregate3 = (AggregateEnum)Conversions.ToInteger(objectValue9);
						this.AddExp(name7, expression7, caption3, aggregate3, false);
						return;
					}
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
		/// 增加表达式统计列，仅对SQLGroupTableBuilder和SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x0600223C RID: 8764 RVA: 0x000F6044 File Offset: 0x000F4244
		public void AddExp(string Name, string Expression, bool upto = false)
		{
			this.AddExp(Name, Expression, "", AggregateEnum.Sum, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLGroupTableBuilder和SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x0600223D RID: 8765 RVA: 0x000F6055 File Offset: 0x000F4255
		public void AddExp(string Name, string Expression, AggregateEnum Aggregate, bool upto = false)
		{
			this.AddExp(Name, Expression, "", Aggregate, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLGroupTableBuilder有效
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">给统计列指定标题</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x0600223E RID: 8766 RVA: 0x000F6067 File Offset: 0x000F4267
		public void AddExp(string Name, string Expression, string Caption, bool upto = false)
		{
			this.AddExp(Name, Expression, Caption, AggregateEnum.Sum, upto);
		}

		/// <summary>
		/// 增加表达式统计列，仅对SQLGroupTableBuilder有效
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">给统计列指定标题</param>
		/// <param name="Aggregate">统计类型</param>
		/// <param name="upto">是否截止统计</param>
		// Token: 0x0600223F RID: 8767 RVA: 0x000F6078 File Offset: 0x000F4278
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

		// Token: 0x06002240 RID: 8768 RVA: 0x000F60BC File Offset: 0x000F42BC
		public IEnumerator<TotalOn> GetEnumerator()
		{
			return (IEnumerator<TotalOn>)this.O__.o__..GetEnumerator();
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000F60D3 File Offset: 0x000F42D3
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000F60DB File Offset: 0x000F42DB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<ExpressionTotal> Exprs
		{
			get
			{
				return this.O__.o__.;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000F60E3 File Offset: 0x000F42E3
		public int Count
		{
			get
			{
				return this.O__.o__..Count;
			}
		}

		// Token: 0x17000749 RID: 1865
		public TotalOn this[int A_0]
		{
			get
			{
				return this.O__.o__.[A_0];
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x000F60FE File Offset: 0x000F42FE
		public void RemoveAt(int index)
		{
			this.O__.o__..RemoveAt(index);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000F610C File Offset: 0x000F430C
		public void AddRange(IEnumerable<TotalOn> items)
		{
			this.O__.o__..AddRange(items);
		}

		// Token: 0x04000E3D RID: 3645
		private List<TotalOn> <<EMPTY_NAME>>;

		// Token: 0x04000E3E RID: 3646
		private List<ExpressionTotal> <<EMPTY_NAME>>;
	}
}
