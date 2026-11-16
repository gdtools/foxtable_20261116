using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200032D RID: 813
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("0985")]
	public class UserFunctions
	{
		// Token: 0x06002D58 RID: 11608 RVA: 0x0014DA0D File Offset: 0x0014BC0D
		public UserFunctions()
		{
			this.O._O_O_. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.O__.00_00_o0_. = new Dictionary<string, string>();
			this.O_.o__0O0_0oo. = RuntimeHelpers.GetObjectValue(new object());
			this.ThrowException = false;
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x0014DA47 File Offset: 0x0014BC47
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0014DA4F File Offset: 0x0014BC4F
		public bool ThrowException { get; set; }

		// Token: 0x06002D5B RID: 11611 RVA: 0x0014DA58 File Offset: 0x0014BC58
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(string Name, string Code)
		{
			if (o_O_o_oOoo__.O_o_._o0.(Name, "函数名称", 32, false))
			{
				if (this.O._O_O_..ContainsKey(Name))
				{
					this.O._O_O_..Remove(Name);
				}
				this.O._O_O_..Add(Name, Code);
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x0014DA92 File Offset: 0x0014BC92
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Clear()
		{
			this.O._O_O_..Clear();
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0014DA9F File Offset: 0x0014BC9F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Remove(string Name)
		{
			this.O._O_O_..Remove(Name);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x0014DAAE File Offset: 0x0014BCAE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Complie()
		{
			this.O__.00_00_o0_.();
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x0014DAB8 File Offset: 0x0014BCB8
		internal void <<EMPTY_NAME>>()
		{
			string text = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Function.dll";
			if (OO_00oOO.FileSys.FileExists(text))
			{
				byte[] rawAssembly = File.ReadAllBytes(text);
				this.O._O_O_. = Assembly.Load(rawAssembly);
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x0014DB04 File Offset: 0x0014BD04
		internal void <<EMPTY_NAME>>(bool A_0, string A_1 = "")
		{
			int num;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.O__.00_00_o0_..Clear();
				IL_14:
				num2 = 3;
				if (Operators.CompareString(A_1, "", true) != 0)
				{
					goto IL_47;
				}
				IL_24:
				num2 = 4;
				string text = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Function.dll";
				goto IL_4B;
				IL_47:
				num2 = 6;
				text = A_1;
				IL_4B:
				num2 = 7;
				if (!OO_00oOO.FileSys.FileExists(text) || A_0)
				{
					goto IL_7C;
				}
				IL_5D:
				num2 = 8;
				byte[] rawAssembly = File.ReadAllBytes(text);
				IL_67:
				num2 = 9;
				this.O._O_O_. = Assembly.Load(rawAssembly);
				goto IL_5BC;
				IL_7C:
				num2 = 11;
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()];
				IL_95:
				num2 = 12;
				O_O0OO.O_O._Oo.();
				IL_9E:
				num2 = 13;
				this.O._O_O_. = null;
				IL_A8:
				num2 = 14;
				DataView dataView = new DataView(dataTable, "[Type] = " + Conversions.ToString(9), "", DataViewRowState.CurrentRows);
				IL_CC:
				num2 = 15;
				if (dataView.Count == 0)
				{
					goto IL_5BC;
				}
				IL_DB:
				num2 = 17;
				o0_.o0o___.Ooo__Oo. = true;
				IL_E4:
				num2 = 18;
				StringBuilder stringBuilder = new StringBuilder();
				IL_EE:
				num2 = 19;
				if (O_O0OO.O0_00o.o0__o..EncriptUserFunction || dataView.Count <= 0)
				{
					goto IL_1BA;
				}
				IL_10D:
				num2 = 20;
				O_O0OO.O0_00o.o0__o..EncriptUserFunction = true;
				IL_11B:
				num2 = 21;
				IEnumerator enumerator = dataView.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRowView dataRowView = (DataRowView)obj;
					IL_137:
					num2 = 22;
					if (!dataRowView.Row.IsNull("Config"))
					{
						IL_14D:
						num2 = 23;
						dataRowView["Config"] = O00.ooo000o_0.00o0.(dataRowView["Config"].ToString(), "UserFunction", O_O0OO.O_O._Oo.());
					}
					IL_17C:
					num2 = 24;
				}
				IL_188:
				num2 = 25;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_1A0:
				num2 = 26;
				O_O0OO.O0_00o.o0__o..O_O_.o.(false, false);
				IL_1AF:
				num2 = 27;
				Oo00.o0_o._O_.(dataTable, true);
				IL_1BA:
				num2 = 28;
				string text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				IL_1DC:
				num2 = 29;
				string text3 = O_O0OO.O_O._Oo.();
				IL_1E6:
				num2 = 30;
				string text4 = text3.Substring(text3.Length - 5, 5);
				IL_1FC:
				num2 = 31;
				text4 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text4).Substring(0, 5);
				IL_214:
				num2 = 32;
				IEnumerator enumerator2 = dataView.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRowView dataRowView2 = (DataRowView)obj2;
					IL_233:
					num2 = 33;
					string text5 = dataRowView2["Name"].ToString();
					IL_249:
					num2 = 34;
					if (text5.StartsWith("![") && text5.EndsWith("]!"))
					{
						IL_268:
						num2 = 35;
						text5 = text5.Trim(new char[]
						{
							'!'
						}).TrimStart(new char[]
						{
							'['
						}).TrimEnd(new char[]
						{
							']'
						});
					}
					else
					{
						IL_2A1:
						num2 = 37;
						text5 = o0OoOOoOOo0.OO0._Oo0o.(text5);
					}
					IL_2AD:
					num2 = 38;
					if (!dataRowView2.Row.IsNull("Config"))
					{
						IL_2C6:
						num2 = 39;
						string text6 = dataRowView2["Config"].ToString();
						IL_2DC:
						num2 = 40;
						string text7 = text3;
						IL_2E3:
						num2 = 41;
						string text8 = "";
						IL_2ED:
						num2 = 42;
						if (text6.StartsWith("![") && text6.EndsWith("]!"))
						{
							IL_30C:
							num2 = 43;
							text7 = text4;
							IL_313:
							num2 = 44;
							text6 = text6.Trim(new char[]
							{
								'!'
							}).TrimStart(new char[]
							{
								'['
							}).TrimEnd(new char[]
							{
								']'
							});
							IL_34A:
							num2 = 45;
							text8 = O00.oO_.0o_oo_0O_.(text6, text7, "UserFunction");
						}
						else
						{
							IL_35F:
							num2 = 47;
							if (text6.StartsWith("[") && text6.EndsWith("]"))
							{
								IL_37E:
								num2 = 48;
								text7 = text2;
								IL_385:
								num2 = 49;
								text6 = text6.TrimStart(new char[]
								{
									'['
								}).TrimEnd(new char[]
								{
									']'
								});
							}
							IL_3AC:
							num2 = 50;
							text8 = O00.oO_.0o_oo_0O_.(text6, "UserFunction", text7);
						}
						IL_3BF:
						num2 = 51;
						if (Operators.CompareString(text8, "", true) > 0)
						{
							IL_3D2:
							num2 = 52;
							text8 = text8.Trim(new char[]
							{
								' ',
								'\n',
								'\r',
								'\t',
								'\u3000'
							});
						}
						IL_3EF:
						num2 = 53;
						if (text8.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase))
						{
							IL_401:
							num2 = 54;
							stringBuilder.Append("Public Async Function " + text5 + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)");
						}
						else
						{
							IL_41F:
							num2 = 56;
							stringBuilder.Append("Public Function " + text5 + "(ByVal Args() As Object) As Object");
						}
						IL_43B:
						num2 = 57;
						stringBuilder.Append("\r\n");
						IL_44B:
						num2 = 58;
						stringBuilder.Append(text8);
						IL_458:
						num2 = 59;
						stringBuilder.Append("\r\n");
						IL_468:
						num2 = 60;
						stringBuilder.Append("End Function");
						IL_478:
						num2 = 61;
						stringBuilder.Append("\r\n");
						IL_488:
						num2 = 62;
						stringBuilder.AppendLine("Public Async Function ____" + text5 + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)");
						IL_4A4:
						num2 = 63;
						stringBuilder.AppendLine("Return Await Threading.Tasks.Task.Run(Async Function() ");
						IL_4B4:
						num2 = 64;
						if (text8.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase))
						{
							IL_4C6:
							num2 = 65;
							stringBuilder.AppendLine("Return Await " + text5 + "(Args)");
						}
						else
						{
							IL_4E4:
							num2 = 67;
							stringBuilder.AppendLine("Return  " + text5 + "(Args)");
						}
						IL_500:
						num2 = 68;
						stringBuilder.AppendLine("End Function)");
						IL_510:
						num2 = 69;
						stringBuilder.AppendLine("End Function");
						IL_520:
						num2 = 70;
						stringBuilder.Append("\r\n");
					}
					IL_530:
					num2 = 71;
				}
				IL_53F:
				num2 = 72;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_557:
				num2 = 73;
				string left = stringBuilder.ToString();
				IL_563:
				num2 = 74;
				if (Operators.CompareString(left, "", true) <= 0)
				{
					goto IL_5A9;
				}
				IL_576:
				num2 = 75;
				this.O._O_O_. = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), text, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
				goto IL_5B3;
				IL_5A9:
				num2 = 77;
				this.O._O_O_. = null;
				IL_5B3:
				num2 = 78;
				o0_.o0o___.Ooo__Oo. = false;
				IL_5BC:
				goto IL_74A;
				IL_5C1:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_70B:
				goto IL_73F;
				IL_70D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_71D:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_70D;
			}
			IL_73F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_74A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0014E280 File Offset: 0x0014C480
		internal void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.O__.00_00_o0_..Clear();
				IL_14:
				num2 = 3;
				StringBuilder stringBuilder = new StringBuilder();
				IL_1C:
				num2 = 4;
				this.oo0.OO_0oO0OoO. = null;
				IL_25:
				num2 = 5;
				if (this.O._O_O_..Count == 0)
				{
					goto IL_22C;
				}
				IL_37:
				num2 = 7;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.O._O_O_..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_59:
					num2 = 8;
					string str = o0OoOOoOOo0.OO0._Oo0o.(text);
					IL_64:
					num2 = 9;
					string text2 = this.O._O_O_.[text];
					IL_76:
					num2 = 10;
					if (Operators.CompareString(text2, "", true) > 0)
					{
						IL_89:
						num2 = 11;
						text2 = text2.Trim(new char[]
						{
							' ',
							'\n',
							'\r',
							'\t',
							'\u3000'
						});
					}
					IL_A6:
					num2 = 12;
					if (text2.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase))
					{
						IL_B8:
						num2 = 13;
						stringBuilder.Append("Public Async Function " + str + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)");
					}
					else
					{
						IL_D5:
						num2 = 15;
						stringBuilder.Append("Public Function " + str + "(ByVal Args() As Object) As Object");
					}
					IL_F0:
					num2 = 16;
					stringBuilder.Append("\r\n");
					IL_FF:
					num2 = 17;
					stringBuilder.Append(text2);
					IL_10B:
					num2 = 18;
					stringBuilder.Append("\r\n");
					IL_11A:
					num2 = 19;
					stringBuilder.Append("End Function");
					IL_129:
					num2 = 20;
					stringBuilder.Append("\r\n");
					IL_138:
					num2 = 21;
					stringBuilder.AppendLine("Public Async Function ____" + str + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)");
					IL_153:
					num2 = 22;
					stringBuilder.AppendLine("Return Await Threading.Tasks.Task.Run(Async Function() ");
					IL_162:
					num2 = 23;
					if (text2.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase))
					{
						IL_174:
						num2 = 24;
						stringBuilder.AppendLine("Return Await " + str + "(Args)");
					}
					else
					{
						IL_191:
						num2 = 26;
						stringBuilder.AppendLine("Return  " + str + "(Args)");
					}
					IL_1AC:
					num2 = 27;
					stringBuilder.AppendLine("End Function)");
					IL_1BB:
					num2 = 28;
					stringBuilder.AppendLine("End Function");
					IL_1CA:
					num2 = 29;
					stringBuilder.Append("\r\n");
					IL_1D9:
					num2 = 30;
				}
				IL_1E8:
				num2 = 31;
				((IDisposable)enumerator).Dispose();
				IL_1F8:
				num2 = 32;
				this.oo0.OO_0oO0OoO. = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
				IL_22C:
				goto IL_302;
				IL_231:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2C3:
				goto IL_2F7;
				IL_2C5:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2D5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2C5;
			}
			IL_2F7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_302:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0014E5B4 File Offset: 0x0014C7B4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Execute(params object[] Args)
		{
			object result;
			if (Args.Length == 0)
			{
				result = null;
			}
			else
			{
				string name = Conversions.ToString(Args[0]);
				if (Args.Length == 1)
				{
					result = this.Execute(name, new object[0]);
				}
				else
				{
					object[] array = new object[Args.Length - 2 + 1];
					int num = Args.Length - 1;
					for (int i = 1; i <= num; i++)
					{
						array[i - 1] = RuntimeHelpers.GetObjectValue(Args[i]);
					}
					result = this.Execute(name, array);
				}
			}
			return result;
		}

		/// <summary>
		/// 执行函数
		/// </summary>
		/// <param name="Name">函数名</param>
		/// <param name="Args">参数</param>
		// Token: 0x06002D63 RID: 11619 RVA: 0x0014E628 File Offset: 0x0014C828
		public object Execute(string Name, params object[] Args)
		{
			string name = this.O._O_O_.(Name);
			MethodInfo methodInfo = null;
			if (this.O._O_O_. != null)
			{
				methodInfo = this.O._O_O_..GetType("UserCode").GetMethod(name);
			}
			if (methodInfo == null)
			{
				if (this.oo0.OO_0oO0OoO. != null)
				{
					methodInfo = this.oo0.OO_0oO0OoO..GetType("UserCode").GetMethod(name);
				}
				if (methodInfo == null)
				{
					MessageBox.Show("找不到自定义函数\"" + Name + "\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return null;
				}
			}
			try
			{
				return methodInfo.Invoke(null, new object[]
				{
					Args
				});
			}
			catch (Exception ex)
			{
				if (this.ThrowException)
				{
					if (ex.InnerException != null)
					{
						throw ex.InnerException;
					}
					throw ex;
				}
				else
				{
					ooO.oOo0Oo.o.(ex, "自定义函数," + Name);
				}
			}
			return null;
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x0014E708 File Offset: 0x0014C908
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object ExecuteAsync(params object[] Args)
		{
			object result;
			if (Args.Length == 0)
			{
				result = null;
			}
			else
			{
				string a_ = Conversions.ToString(Args[0]);
				if (Args.Length == 1)
				{
					result = this.O._O_O_.(a_, new object[0]);
				}
				else
				{
					object[] array = new object[Args.Length - 2 + 1];
					int num = Args.Length - 1;
					for (int i = 1; i <= num; i++)
					{
						array[i - 1] = RuntimeHelpers.GetObjectValue(Args[i]);
					}
					result = this.O._O_O_.(a_, array);
				}
			}
			return result;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x0014E77C File Offset: 0x0014C97C
		private Task<object> <<EMPTY_NAME>>(string A_0, params object[] A_1)
		{
			UserFunctions.o0OO0_oOoo o0OO0_oOoo = default(UserFunctions.o0OO0_oOoo);
			o0OO0_oOoo.o0.O_o_. = this;
			o0OO0_oOoo.o0.O_o_. = A_0;
			o0OO0_oOoo.o0.O_o_. = A_1;
			o0OO0_oOoo.o0.O_o_. = -1;
			o0OO0_oOoo.O_.o__0O0_0oo. = AsyncTaskMethodBuilder<object>.Create();
			o0OO0_oOoo.O_.o__0O0_0oo..Start<UserFunctions.o0OO0_oOoo>(ref o0OO0_oOoo);
			return o0OO0_oOoo.O_.o__0O0_0oo..Task;
		}

		/// <summary>
		/// 判断是否存在指定名称的函数
		/// </summary>
		/// <param name="Name">函数名</param>
		// Token: 0x06002D66 RID: 11622 RVA: 0x0014E7D8 File Offset: 0x0014C9D8
		public bool Contains(string Name)
		{
			string name = this.O._O_O_.(Name);
			MethodInfo methodInfo = null;
			if (this.O._O_O_. != null)
			{
				methodInfo = this.O._O_O_..GetType("UserCode").GetMethod(name);
			}
			if (methodInfo == null && this.oo0.OO_0oO0OoO. != null)
			{
				methodInfo = this.oo0.OO_0oO0OoO..GetType("UserCode").GetMethod(name);
			}
			return methodInfo != null;
		}

		/// <summary>
		/// 异步执行函数
		/// </summary>
		/// <param name="Name">函数名</param>
		/// <param name="Args">参数</param>
		// Token: 0x06002D67 RID: 11623 RVA: 0x0014E834 File Offset: 0x0014CA34
		[oO0oooo("A3273")]
		public bool AsyncExecute(string Name, params object[] Args)
		{
			return ThreadPool.QueueUserWorkItem(new WaitCallback(new UserFunctions.O0__(Name, Args).O_.o__0O0_0oo.), null);
		}

		/// <summary>
		/// 同步执行函数，等待函数执行完毕，并获取执行结果
		/// </summary>
		/// <param name="Name">函数名</param>
		/// <param name="Args">参数</param>
		// Token: 0x06002D68 RID: 11624 RVA: 0x0014E850 File Offset: 0x0014CA50
		[oO0oooo("A3273")]
		public object SyncExecute(string Name, params object[] Args)
		{
			object result;
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				O0__00O__O0O method = new O0__00O__O0O(this.Execute);
				result = OO_00oOO.BaseMainForm.Invoke(method, new object[]
				{
					Name,
					Args
				});
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 同步执行函数，不等待函数执行完毕，所以无法获取执行结果
		/// </summary>
		/// <param name="Name">函数名</param>
		/// <param name="Args">参数</param>
		// Token: 0x06002D69 RID: 11625 RVA: 0x0014E89C File Offset: 0x0014CA9C
		[oO0oooo("A3273")]
		public void BeginSyncExecute(string Name, params object[] Args)
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				O0__00O__O0O method = new O0__00O__O0O(this.Execute);
				OO_00oOO.BaseMainForm.BeginInvoke(method, new object[]
				{
					Name,
					Args
				});
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x0014E8E4 File Offset: 0x0014CAE4
		private string <<EMPTY_NAME>>(string A_0)
		{
			object o_.o__0O0_0oo. = this.O_.o__0O0_0oo.;
			ObjectFlowControl.CheckForSyncLockOnValueType(o_.o__0O0_0oo.);
			string text;
			lock (o_.o__0O0_0oo.)
			{
				if (this.O__.00_00_o0_..ContainsKey(A_0))
				{
					text = this.O__.00_00_o0_.[A_0];
				}
				else
				{
					text = o0OoOOoOOo0.OO0._Oo0o.(A_0);
					this.O__.00_00_o0_..Add(A_0, text);
				}
			}
			return text;
		}

		// Token: 0x0400125D RID: 4701
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x0400125E RID: 4702
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x0400125F RID: 4703
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x04001260 RID: 4704
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04001261 RID: 4705
		private object <<EMPTY_NAME>>;

		// Token: 0x04001262 RID: 4706
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0200032E RID: 814
		internal class O0__
		{
			// Token: 0x06002D6B RID: 11627 RVA: 0x0014E958 File Offset: 0x0014CB58
			internal O0__(string A_0, params object[] A_1)
			{
				this.O_.o__0O0_0oo. = A_0;
				this.O_.o__0O0_0oo. = A_1;
			}

			// Token: 0x06002D6C RID: 11628 RVA: 0x0014E96E File Offset: 0x0014CB6E
			internal void <<EMPTY_NAME>>()
			{
				OO_00oOO.Functions.Execute(this.O_.o__0O0_0oo., this.O_.o__0O0_0oo.);
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x0014E987 File Offset: 0x0014CB87
			internal void <<EMPTY_NAME>>(object A_0)
			{
				OO_00oOO.Functions.Execute(this.O_.o__0O0_0oo., this.O_.o__0O0_0oo.);
			}

			// Token: 0x04001263 RID: 4707
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001264 RID: 4708
			internal object[] <<EMPTY_NAME>>;
		}
	}
}
