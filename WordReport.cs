using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000478 RID: 1144
	[oO0oooo("2890")]
	public class WordReport
	{
		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x00232E67 File Offset: 0x00231067
		// (set) Token: 0x06004E0E RID: 19982 RVA: 0x00232E70 File Offset: 0x00231070
		private static Microsoft.Office.Interop.Word.Application app
		{
			[CompilerGenerated]
			get
			{
				return WordReport.O000.OO0__OoO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ApplicationEvents4_QuitEventHandler applicationEvents4_QuitEventHandler = new ApplicationEvents4_QuitEventHandler(null, (UIntPtr)ldftn(oO.0O.));
				Microsoft.Office.Interop.Word.Application o000.OO0__OoO. = WordReport.O000.OO0__OoO.;
				if (o000.OO0__OoO. != null)
				{
					o000.OO0__OoO..Quit -= applicationEvents4_QuitEventHandler;
				}
				WordReport.O000.OO0__OoO. = value;
				o000.OO0__OoO. = WordReport.O000.OO0__OoO.;
				if (o000.OO0__OoO. != null)
				{
					o000.OO0__OoO..Quit += applicationEvents4_QuitEventHandler;
				}
			}
		}

		// Token: 0x06004E0F RID: 19983
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetForegroundWindow(int A_0);

		// Token: 0x06004E10 RID: 19984
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetActiveWindow(int A_0);

		/// <param name="Table">要打印的Table</param>
		/// <param name="Template">模板文件名称，含路径</param>
		/// <param name="Report">生成的报表文件名称，含路径</param>
		// Token: 0x06004E11 RID: 19985 RVA: 0x00232EB0 File Offset: 0x002310B0
		public WordReport(Table A_0, object A_1, object A_2)
		{
			this.O_.ooO_0_OOo. = new List<string>();
			this.oO.0O_00ooO_O. = 0;
			this.O000.OO0__OoO. = new Dictionary<string, DataRow[]>();
			this.O_.ooO_0_OOo. = new Dictionary<string, DataRow>();
			this.O_.ooO_0_OOo. = new Dictionary<string, string>();
			this.OOO_Oo0o_.0_. = new Dictionary<string, string>();
			this.o__o.OOoO_. = new tempDataTableCollection();
			this.O000.OO0__OoO. = new List<O_0OO>();
			this.O000.OO0__OoO. = new List<o0__oo0OOo>();
			this.O000.OO0__OoO.(A_0, RuntimeHelpers.GetObjectValue(A_1), RuntimeHelpers.GetObjectValue(A_2));
		}

		/// <param name="TableName">要打印的Table的名称</param>
		/// <param name="Template">模板文件名称，含路径</param>
		/// <param name="Report">生成的报表文件名称，含路径</param>
		// Token: 0x06004E12 RID: 19986 RVA: 0x00232F38 File Offset: 0x00231138
		public WordReport(string A_0, object A_1, object A_2)
		{
			this.O_.ooO_0_OOo. = new List<string>();
			this.oO.0O_00ooO_O. = 0;
			this.O000.OO0__OoO. = new Dictionary<string, DataRow[]>();
			this.O_.ooO_0_OOo. = new Dictionary<string, DataRow>();
			this.O_.ooO_0_OOo. = new Dictionary<string, string>();
			this.OOO_Oo0o_.0_. = new Dictionary<string, string>();
			this.o__o.OOoO_. = new tempDataTableCollection();
			this.O000.OO0__OoO. = new List<O_0OO>();
			this.O000.OO0__OoO. = new List<o0__oo0OOo>();
			this.O000.OO0__OoO.(OO_00oOO.Tables[A_0], RuntimeHelpers.GetObjectValue(A_1), RuntimeHelpers.GetObjectValue(A_2));
		}

		/// <param name="Template">模板文件名称，含路径</param>
		/// <param name="Report">生成的报表文件名称，含路径</param>
		// Token: 0x06004E13 RID: 19987 RVA: 0x00232FC8 File Offset: 0x002311C8
		public WordReport(object A_0, object A_1)
		{
			this.O_.ooO_0_OOo. = new List<string>();
			this.oO.0O_00ooO_O. = 0;
			this.O000.OO0__OoO. = new Dictionary<string, DataRow[]>();
			this.O_.ooO_0_OOo. = new Dictionary<string, DataRow>();
			this.O_.ooO_0_OOo. = new Dictionary<string, string>();
			this.OOO_Oo0o_.0_. = new Dictionary<string, string>();
			this.o__o.OOoO_. = new tempDataTableCollection();
			this.O000.OO0__OoO. = new List<O_0OO>();
			this.O000.OO0__OoO. = new List<o0__oo0OOo>();
			this.O000.OO0__OoO.(null, RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue(A_1));
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00233050 File Offset: 0x00231250
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(Table A_0, object A_1, object A_2)
		{
			object objectValue;
			object objectValue2;
			object objectValue3;
			try
			{
				if (WordReport.app != null && (WordReport.app.Visible || !WordReport.app.Visible))
				{
					try
					{
						foreach (object obj in WordReport.app.Documents)
						{
							((Document)obj).Saved = true;
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (WordReport.app.Documents.Count > 0)
					{
						Documents documents = WordReport.app.Documents;
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
						documents.Close(ref objectValue, ref objectValue2, ref objectValue3);
					}
					_Application application = WordReport.app;
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					application.Quit(ref objectValue3, ref objectValue2, ref objectValue);
					System.Windows.Forms.Application.DoEvents();
					System.Windows.Forms.Application.DoEvents();
					System.Windows.Forms.Application.DoEvents();
					WordReport.app = null;
					GC.Collect();
					GC.Collect();
					GC.Collect();
					GC.Collect();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			if (OO_00oOO.FileIsOpened(A_2.ToString()))
			{
				MessageBox.Show("目标报表文件已经被其它进程打开，生成的报表将存为一个临时文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_2 = Path.GetTempFileName();
			}
			WordReport.app = new ApplicationClass();
			OO_00oOO.FileSys.CopyFile(A_1.ToString(), A_2.ToString(), true);
			Documents documents2 = WordReport.app.Documents;
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue15 = RuntimeHelpers.GetObjectValue(Missing.Value);
			this.O_.ooO_0_OOo. = documents2.Open(ref A_2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14, ref objectValue15);
			this.O_.ooO_0_OOo. = A_0;
			if (A_0 != null)
			{
				this.O_.ooO_0_OOo. = this.O_.ooO_0_OOo..DataTable.Name;
			}
			this.OOo_oooOo_.0Oo. = 0;
		}

		/// <summary>
		/// 将指定的内容替换为新的内容
		/// </summary>
		/// <param name="findText">字符型，指定要查找的内容</param>
		/// <param name="repaceText">字符型，指定用于替换的内容</param>
		// Token: 0x06004E15 RID: 19989 RVA: 0x0023330C File Offset: 0x0023150C
		public void Replace(string findText, string repaceText)
		{
			if (Operators.CompareString(repaceText, "", true) > 0 && repaceText.Length > 200)
			{
				this.ReplaceText(findText, repaceText);
				return;
			}
			try
			{
				WordReport.app.Selection.Start = this.o_oooOOOO.0.;
				WordReport.app.Selection.End = this.o_oooOOOO.0.;
				Find find = WordReport.app.Selection.Find;
				find.ClearFormatting();
				find.MatchCase = false;
				find.Text = findText;
				find.Forward = true;
				find.MatchWildcards = false;
				find.Replacement.ClearFormatting();
				find.Replacement.Text = repaceText;
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object obj = WdReplace.wdReplaceAll;
				object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
				find.Execute(ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref obj, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x002334BC File Offset: 0x002316BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ReplaceText(string Mark, string value)
		{
			object obj = WdMovementType.wdMove;
			Selection selection = WordReport.app.Selection;
			object obj2 = WdUnits.wdStory;
			selection.HomeKey(ref obj2, ref obj);
			object obj3 = Mark;
			if (value.IndexOf(Mark) >= 0)
			{
				value = value.Replace(Mark, Mark.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				}));
			}
			Find find = WordReport.app.Selection.Find;
			find.ClearFormatting();
			find.MatchCase = false;
			find.Forward = true;
			Selection selection2 = WordReport.app.Selection;
			obj2 = WdUnits.wdStory;
			selection2.HomeKey(ref obj2, ref obj);
			for (;;)
			{
				Find find2 = find;
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
				if (!find2.Execute(ref obj3, ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13))
				{
					break;
				}
				WordReport.app.Selection.Text = value;
				Selection selection3 = WordReport.app.Selection;
				obj2 = WdUnits.wdStory;
				selection3.HomeKey(ref obj2, ref obj);
			}
		}

		/// <summary>
		/// 将指定的内容替换为新的内容,只对下一条记录生效，需要和BuildOne配合使用
		/// </summary>
		/// <param name="findText">字符型，指定要查找的内容</param>
		/// <param name="repaceText">字符型，指定用于替换的内容</param>
		// Token: 0x06004E17 RID: 19991 RVA: 0x0023365F File Offset: 0x0023185F
		public void ReplaceOne(string findText, string repaceText)
		{
			this.O_.ooO_0_OOo..Add(findText, repaceText);
		}

		/// <summary>
		/// 将指定的内容替换为图片
		/// </summary>
		/// <param name="findText">指定要查找的内容</param>
		/// <param name="ImageFile">图片文件名，含路径</param>
		/// <param name="Width">指定图片宽度</param>
		/// <param name="Height">指定图片高度</param>
		// Token: 0x06004E18 RID: 19992 RVA: 0x00233670 File Offset: 0x00231870
		public void ReplaceWithImage(object findText, string ImageFile, int Width, int Height)
		{
			try
			{
				WordReport.app.Selection.Start = this.o_oooOOOO.0.;
				WordReport.app.Selection.End = this.o_oooOOOO.0.;
				Find find = WordReport.app.Selection.Find;
				find.ClearFormatting();
				find.MatchCase = false;
				find.MatchWildcards = false;
				find.Forward = true;
				for (;;)
				{
					Find find2 = find;
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object obj = RuntimeHelpers.GetObjectValue(Missing.Value);
					object obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find2.Execute(ref findText, ref objectValue, ref obj, ref obj2, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12))
					{
						break;
					}
					ImageFile = ooO.OoO0o_o___.O.(ImageFile);
					if (OO_00oOO.FileSys.FileExists(ImageFile))
					{
						if (Operators.CompareString(Path.GetExtension(ImageFile), ".ico", true) == 0)
						{
							Image image = OO_00oOO.GetImage(ImageFile);
							if (image == null)
							{
								break;
							}
							ImageFile += ".png";
							image.Save(ImageFile, ImageFormat.Png);
						}
						InlineShapes inlineShapes = WordReport.app.Selection.InlineShapes;
						string fileName = ImageFile;
						obj2 = false;
						obj = true;
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						InlineShape inlineShape = inlineShapes.AddPicture(fileName, ref obj2, ref obj, ref objectValue);
						if (Width == -1 && Height > 0)
						{
							Image image2 = OO_00oOO.GetImage(ImageFile);
							Width = (int)Math.Round((double)(Height * image2.Size.Width) / (double)image2.Size.Height);
						}
						else if (Height == -1 && Width > 0)
						{
							Image image3 = OO_00oOO.GetImage(ImageFile);
							Height = (int)Math.Round((double)(Width * image3.Size.Height) / (double)image3.Size.Width);
						}
						inlineShape.Width = (float)Width;
						inlineShape.Height = (float)Height;
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x002338F8 File Offset: 0x00231AF8
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (WordReport.app.StartupPath.IndexOf("wps", StringComparison.OrdinalIgnoreCase) <= 0)
				{
					goto IL_3B;
				}
				IL_21:
				num2 = 3;
				MessageBox.Show("Word报表和WPS不兼容，请参考帮助文档进行设置!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_D10;
				IL_3B:
				num2 = 5;
				this.O_.ooO_0_OOo..Clear();
				IL_48:
				num2 = 6;
				object obj = WdMovementType.wdMove;
				IL_51:
				num2 = 7;
				Selection selection = WordReport.app.Selection;
				object obj2 = WdUnits.wdStory;
				selection.HomeKey(ref obj2, ref obj);
				IL_6F:
				num2 = 8;
				Find find = WordReport.app.Selection.Find;
				IL_82:
				num2 = 9;
				find.ClearFormatting();
				IL_8C:
				num2 = 10;
				find.MatchCase = false;
				IL_97:
				num2 = 11;
				find.Forward = true;
				IL_A2:
				num2 = 12;
				find.MatchWildcards = true;
				object obj3;
				for (;;)
				{
					IL_125:
					num2 = 14;
					Find find2 = find;
					obj2 = "\\^60[!> \u3000]*[!< \u3000]\\^62";
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find2.Execute(ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref obj3))
					{
						break;
					}
					IL_AF:
					num2 = 15;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_CE:
						num2 = 16;
						string text = WordReport.app.Selection.Text;
						IL_E2:
						num2 = 17;
						text = text.Substring(text.IndexOf("<"));
						IL_FA:
						num2 = 18;
						text = text.Substring(0, text.LastIndexOf(">") + 1);
						IL_115:
						num2 = 19;
						this.O_.ooO_0_OOo..Add(text);
					}
				}
				IL_201:
				num2 = 21;
				Selection selection2 = WordReport.app.Selection;
				obj3 = WdUnits.wdStory;
				selection2.HomeKey(ref obj3, ref obj);
				for (;;)
				{
					IL_25E:
					num2 = 23;
					Find find3 = find;
					obj3 = "\\[<*>\\]";
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find3.Execute(ref obj3, ref objectValue13, ref objectValue12, ref objectValue11, ref objectValue10, ref objectValue9, ref objectValue8, ref objectValue7, ref objectValue6, ref objectValue5, ref objectValue4, ref objectValue3, ref objectValue2, ref objectValue, ref obj2))
					{
						break;
					}
					IL_222:
					num2 = 24;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_241:
						num2 = 25;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_33A:
				num2 = 27;
				Selection selection3 = WordReport.app.Selection;
				obj2 = WdUnits.wdStory;
				selection3.HomeKey(ref obj2, ref obj);
				for (;;)
				{
					IL_397:
					num2 = 29;
					Find find4 = find;
					obj2 = "\\[\\^38<*\\,*\\,*>\\]";
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find4.Execute(ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref obj3))
					{
						break;
					}
					IL_35B:
					num2 = 30;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_37A:
						num2 = 31;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_473:
				num2 = 33;
				Selection selection4 = WordReport.app.Selection;
				obj3 = WdUnits.wdStory;
				selection4.HomeKey(ref obj3, ref obj);
				for (;;)
				{
					IL_4D0:
					num2 = 35;
					Find find5 = find;
					obj3 = "\\[\\^38\\^38<*\\,*\\,*>\\]";
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find5.Execute(ref obj3, ref objectValue13, ref objectValue12, ref objectValue11, ref objectValue10, ref objectValue9, ref objectValue8, ref objectValue7, ref objectValue6, ref objectValue5, ref objectValue4, ref objectValue3, ref objectValue2, ref objectValue, ref obj2))
					{
						break;
					}
					IL_494:
					num2 = 36;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_4B3:
						num2 = 37;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_5AC:
				num2 = 39;
				Selection selection5 = WordReport.app.Selection;
				obj2 = WdUnits.wdStory;
				selection5.HomeKey(ref obj2, ref obj);
				for (;;)
				{
					IL_609:
					num2 = 41;
					Find find6 = find;
					obj2 = "\\[\\^64<*\\,*\\,*>\\]";
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find6.Execute(ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref obj3))
					{
						break;
					}
					IL_5CD:
					num2 = 42;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_5EC:
						num2 = 43;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_6E5:
				num2 = 45;
				Selection selection6 = WordReport.app.Selection;
				obj3 = WdUnits.wdStory;
				selection6.HomeKey(ref obj3, ref obj);
				for (;;)
				{
					IL_742:
					num2 = 47;
					Find find7 = find;
					obj3 = "\\[\\^64<*\\,*>\\]";
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find7.Execute(ref obj3, ref objectValue13, ref objectValue12, ref objectValue11, ref objectValue10, ref objectValue9, ref objectValue8, ref objectValue7, ref objectValue6, ref objectValue5, ref objectValue4, ref objectValue3, ref objectValue2, ref objectValue, ref obj2))
					{
						break;
					}
					IL_706:
					num2 = 48;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_725:
						num2 = 49;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_81E:
				num2 = 51;
				Selection selection7 = WordReport.app.Selection;
				obj2 = WdUnits.wdStory;
				selection7.HomeKey(ref obj2, ref obj);
				for (;;)
				{
					IL_87B:
					num2 = 53;
					Find find8 = find;
					obj2 = "\\[\\^64^38<*\\,*\\,*\\,*\\,*>\\]";
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find8.Execute(ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref obj3))
					{
						break;
					}
					IL_83F:
					num2 = 54;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_85E:
						num2 = 55;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_957:
				num2 = 57;
				Selection selection8 = WordReport.app.Selection;
				obj3 = WdUnits.wdStory;
				selection8.HomeKey(ref obj3, ref obj);
				for (;;)
				{
					IL_9B4:
					num2 = 59;
					Find find9 = find;
					obj3 = "\\[\\^64^38<*\\,*\\,*\\,*>\\]";
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find9.Execute(ref obj3, ref objectValue13, ref objectValue12, ref objectValue11, ref objectValue10, ref objectValue9, ref objectValue8, ref objectValue7, ref objectValue6, ref objectValue5, ref objectValue4, ref objectValue3, ref objectValue2, ref objectValue, ref obj2))
					{
						break;
					}
					IL_978:
					num2 = 60;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_997:
						num2 = 61;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_A90:
				num2 = 63;
				Selection selection9 = WordReport.app.Selection;
				obj2 = WdUnits.wdStory;
				selection9.HomeKey(ref obj2, ref obj);
				for (;;)
				{
					IL_AED:
					num2 = 65;
					Find find10 = find;
					obj2 = "\\[\\^37<*\\,*\\^40*\\^41\\]";
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find10.Execute(ref obj2, ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref obj3))
					{
						break;
					}
					IL_AB1:
					num2 = 66;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_AD0:
						num2 = 67;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_BC9:
				num2 = 69;
				find.MatchWildcards = false;
				IL_BD4:
				num2 = 70;
				Selection selection10 = WordReport.app.Selection;
				obj3 = WdUnits.wdStory;
				selection10.HomeKey(ref obj3, ref obj);
				for (;;)
				{
					IL_C31:
					num2 = 72;
					Find find11 = find;
					obj3 = "<Index>";
					object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					if (!find11.Execute(ref obj3, ref objectValue13, ref objectValue12, ref objectValue11, ref objectValue10, ref objectValue9, ref objectValue8, ref objectValue7, ref objectValue6, ref objectValue5, ref objectValue4, ref objectValue3, ref objectValue2, ref objectValue, ref obj2))
					{
						break;
					}
					IL_BF5:
					num2 = 73;
					if (!this.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text))
					{
						IL_C14:
						num2 = 74;
						this.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text);
					}
				}
				IL_D0D:
				find = null;
				IL_D10:
				goto IL_E96;
				IL_D15:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_E57:
				goto IL_E8B;
				IL_E59:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_E69:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_E59;
			}
			IL_E8B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E96:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 生成报表
		/// </summary>
		// Token: 0x06004E1A RID: 19994 RVA: 0x002347C0 File Offset: 0x002329C0
		public void Build()
		{
			if (this.O_.ooO_0_OOo.)
			{
				this.O.0o0O__o.();
				this.O_.ooO_0_OOo. = false;
			}
			if (this.O_.ooO_0_OOo. != null && this.O_.ooO_0_OOo..Tables.Count > 0)
			{
				try
				{
					foreach (object obj in this.O_.ooO_0_OOo..Tables[0].Rows)
					{
						DataRow a_ = (DataRow)obj;
						this.BuildOne(new DataRow(a_));
					}
					return;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			this.OOo_oooOo_.0Oo. = 0;
			int num = this.O_.ooO_0_OOo..TopPosition;
			int num2 = this.O_.ooO_0_OOo..BottomPosition;
			for (int i = num; i <= num2; i++)
			{
				DataRow dataRow = this.O_.ooO_0_OOo..Rows[i].DataRow;
				this.BuildOne(dataRow);
			}
		}

		/// <summary>
		/// 根据指定的一行数据生成报表
		/// </summary>
		/// <param name="r">Row类型，根据此行生成报表</param>
		// Token: 0x06004E1B RID: 19995 RVA: 0x002348AC File Offset: 0x00232AAC
		public void BuildOne(Row r)
		{
			this.BuildOne(r.DataRow);
		}

		/// <summary>
		/// 根据指定的一行数据生成报表
		/// </summary>
		/// <param name="dr">DataRow类型，根据此行生成报表</param>
		// Token: 0x06004E1C RID: 19996 RVA: 0x002348BC File Offset: 0x00232ABC
		public void BuildOne(DataRow dr)
		{
			int num;
			int num9;
			object obj6;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.O000.OO0__OoO..Clear();
				IL_14:
				num2 = 3;
				this.O_.ooO_0_OOo..Clear();
				IL_21:
				num2 = 4;
				this.OOo_oooOo_.0Oo.++;
				IL_31:
				num2 = 5;
				if (this.O000.OO0__OoO. <= 0)
				{
					goto IL_FB;
				}
				IL_3F:
				num2 = 6;
				object obj = WdMovementType.wdMove;
				IL_48:
				num2 = 7;
				Selection selection = WordReport.app.Selection;
				object obj2 = WdUnits.wdStory;
				selection.EndKey(ref obj2, ref obj);
				IL_66:
				num2 = 8;
				this.o_oooOOOO.0. = this.O_.ooO_0_OOo..Characters.Count;
				IL_7E:
				num2 = 9;
				if (this.O000.OO0__OoO. != 1)
				{
					goto IL_9C;
				}
				IL_8A:
				num2 = 10;
				WordReport.app.Selection.TypeParagraph();
				IL_9C:
				num2 = 11;
				if (this.RecordsOnEachPage <= 0 || this.O000.OO0__OoO. % this.RecordsOnEachPage != 0)
				{
					goto IL_D5;
				}
				IL_B7:
				num2 = 12;
				Selection selection2 = WordReport.app.Selection;
				obj2 = WdBreakType.wdPageBreak;
				selection2.InsertBreak(ref obj2);
				goto IL_E7;
				IL_D5:
				num2 = 14;
				WordReport.app.Selection.TypeParagraph();
				IL_E7:
				num2 = 15;
				WordReport.app.Selection.Paste();
				goto IL_144;
				IL_FB:
				num2 = 17;
				this.o_O0._000.();
				IL_104:
				num2 = 18;
				_Document o_.ooO_0_OOo. = this.O_.ooO_0_OOo.;
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				Range range = o_.ooO_0_OOo..Range(ref obj2, ref objectValue);
				IL_130:
				num2 = 19;
				range.Select();
				IL_13A:
				num2 = 20;
				range.Copy();
				IL_144:
				num2 = 21;
				this.O000.OO0__OoO.++;
				IL_155:
				num2 = 22;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.O_.ooO_0_OOo..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_175:
					num2 = 23;
					this.Replace(text, this.O_.ooO_0_OOo.[text]);
					IL_18D:
					num2 = 24;
				}
				IL_199:
				num2 = 25;
				((IDisposable)enumerator).Dispose();
				IL_1A9:
				num2 = 26;
				List<string>.Enumerator enumerator2 = this.O_.ooO_0_OOo..GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text2 = enumerator2.Current;
					IL_1C7:
					num2 = 27;
					string text3 = text2.Trim();
					IL_1D3:
					num2 = 28;
					if (text3.StartsWith("[") && text3.EndsWith("]"))
					{
						IL_1F8:
						num2 = 29;
						text3 = text3.Trim().Trim(new char[]
						{
							'['
						}).Trim(new char[]
						{
							']'
						});
						IL_224:
						num2 = 30;
						if (text3.StartsWith("&"))
						{
							IL_238:
							num2 = 31;
							bool flag = false;
							IL_23E:
							num2 = 32;
							text3 = text3.Substring(1);
							IL_24B:
							num2 = 33;
							if (text3.StartsWith("&"))
							{
								IL_25C:
								num2 = 34;
								flag = true;
								IL_262:
								num2 = 35;
								text3 = text3.Substring(1);
							}
							IL_26F:
							num2 = 36;
							string[] array = text3.Split(new char[]
							{
								','
							});
							IL_286:
							num2 = 37;
							if (array.Length == 3 && Versioned.IsNumeric(array[1]) && Versioned.IsNumeric(array[2]))
							{
								IL_2AF:
								num2 = 38;
								if (flag)
								{
									IL_2B6:
									num2 = 39;
									this.ReplaceWithImage(text2, array[0], Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
								}
								else
								{
									IL_2DC:
									num2 = 41;
									int num3 = 0;
									IL_2E2:
									num2 = 42;
									if (array[0].IndexOf("&") > 0)
									{
										IL_2F6:
										num2 = 43;
										int.TryParse(array[0].Substring(array[0].IndexOf("&") + 1), out num3);
										IL_31A:
										num2 = 44;
										array[0] = array[0].Substring(0, array[0].IndexOf("&"));
									}
									IL_339:
									num2 = 45;
									string[] array2 = dr[array[0]].ToString().ToString().Split(new char[]
									{
										'\n',
										'\r'
									}, StringSplitOptions.RemoveEmptyEntries);
									IL_368:
									num2 = 46;
									if (array2.Length > num3)
									{
										IL_373:
										num2 = 47;
										string remoteImageFile = Ooo_O.GetRemoteImageFile(array2[num3], dr.DataTable.DataCols[array[0]]);
										IL_396:
										num2 = 48;
										this.ReplaceWithImage(text2, remoteImageFile, Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
									}
									else
									{
										IL_3BA:
										num2 = 50;
										this.Replace(text2, "");
									}
								}
							}
						}
						else
						{
							IL_3CF:
							num2 = 52;
							if (text3.StartsWith("@"))
							{
								IL_3E3:
								num2 = 53;
								text3 = text3.Substring(1);
								IL_3F0:
								num2 = 54;
								string[] array3 = text3.Split(new char[]
								{
									','
								});
								IL_407:
								num2 = 55;
								if ((array3.Length == 3 && Versioned.IsNumeric(array3[2])) || (array3.Length == 5 && Versioned.IsNumeric(array3[2]) && Versioned.IsNumeric(array3[3]) && Versioned.IsNumeric(array3[4])))
								{
									IL_450:
									num2 = 56;
									array3[0] = array3[0].Trim();
									IL_460:
									num2 = 57;
									array3[1] = array3[1].Trim();
									IL_470:
									num2 = 58;
									bool flag2 = array3[0].StartsWith("&");
									IL_483:
									num2 = 59;
									if (flag2)
									{
										IL_48A:
										num2 = 60;
										array3[0] = array3[0].Substring(1);
									}
									IL_49B:
									num2 = 61;
									if (!this.O000.OO0__OoO..ContainsKey(array3[0]))
									{
										IL_4B2:
										num2 = 62;
										IEnumerator enumerator3 = dr.BaseRow.Table.DataSet.Relations.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											object obj3 = enumerator3.Current;
											DataRelation dataRelation = (DataRelation)obj3;
											IL_4E1:
											num2 = 63;
											if (Operators.CompareString(dataRelation.ParentTable.TableName, this.O_.ooO_0_OOo., true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, array3[0], true) == 0)
											{
												IL_516:
												num2 = 64;
												this.O000.OO0__OoO..Add(array3[0], dr.BaseRow.GetChildRows(dataRelation));
											}
											IL_535:
											num2 = 65;
										}
										IL_541:
										num2 = 66;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
									IL_559:
									num2 = 67;
									int num4 = 0;
									IL_55F:
									num2 = 68;
									if (array3[1].IndexOf("&") > 0)
									{
										IL_573:
										num2 = 69;
										int.TryParse(array3[1].Substring(array3[1].IndexOf("&") + 1), out num4);
										IL_597:
										num2 = 70;
										array3[1] = array3[1].Substring(0, array3[1].IndexOf("&"));
									}
									IL_5B6:
									num2 = 71;
									if (this.O000.OO0__OoO..ContainsKey(array3[0]) && ((OO_00oOO.DataTables.Contains(array3[0]) && OO_00oOO.DataTables[array3[0]].DataCols.Contains(array3[1])) || (this.O_.ooO_0_OOo. != null && this.O_.ooO_0_OOo..Tables.Contains(array3[0]) && this.O_.ooO_0_OOo..Tables[array3[0]].Columns.Contains(array3[1]))))
									{
										IL_646:
										num2 = 72;
										bool flag3;
										if (OO_00oOO.DataTables.Contains(array3[0]) && OO_00oOO.DataTables[array3[0]].DataCols.Contains(array3[1]))
										{
											IL_677:
											num2 = 73;
											flag3 = false;
										}
										else
										{
											IL_67F:
											num2 = 75;
											flag3 = true;
										}
										IL_685:
										num2 = 76;
										if (this.O000.OO0__OoO.[array3[0]].Length < Conversions.ToInteger(array3[2]))
										{
											IL_6A4:
											num2 = 77;
											this.Replace(text2, "");
										}
										else
										{
											IL_6B9:
											num2 = 79;
											if (this.O000.OO0__OoO.[array3[0]][Conversions.ToInteger(array3[2]) - 1].IsNull(array3[1]))
											{
												IL_6E2:
												num2 = 80;
												this.Replace(text2, "");
											}
											else
											{
												IL_6F7:
												num2 = 82;
												if (array3.Length == 3)
												{
													IL_704:
													num2 = 83;
													if (Conversions.ToInteger(array3[2]) <= this.O000.OO0__OoO.[array3[0]].Length)
													{
														IL_726:
														num2 = 84;
														if (!flag3 && OO_00oOO.DataTables[array3[0]].DataCols[array3[1]].ExtendType == ExtendTypeEnum.TimeSpan)
														{
															IL_754:
															num2 = 85;
															double a_ = Conversion.Val(this.O000.OO0__OoO.[array3[0]][Conversions.ToInteger(array3[2]) - 1][array3[1]].ToString());
															IL_787:
															num2 = 86;
															string repaceText = "";
															IL_791:
															num2 = 87;
															O_O0OO.o.00O_O.(a_, ref repaceText);
															IL_79E:
															num2 = 88;
															this.Replace(text2, repaceText);
														}
														else
														{
															IL_7B0:
															num2 = 90;
															this.Replace(text2, this.O000.OO0__OoO.[array3[0]][Conversions.ToInteger(array3[2]) - 1][array3[1]].ToString());
														}
													}
													else
													{
														IL_7E9:
														num2 = 92;
														this.Replace(text2, "");
													}
												}
												else
												{
													IL_7FE:
													num2 = 94;
													if (flag2 && array3.Length == 5)
													{
														IL_812:
														num2 = 95;
														if (Conversions.ToInteger(array3[2]) <= this.O000.OO0__OoO.[array3[0]].Length)
														{
															IL_834:
															num2 = 96;
															string[] array4 = this.O000.OO0__OoO.[array3[0]][Conversions.ToInteger(array3[2]) - 1][array3[1]].ToString().Split(new char[]
															{
																'\n',
																'\r'
															}, StringSplitOptions.RemoveEmptyEntries);
															IL_878:
															num2 = 97;
															if (array4.Length > num4)
															{
																IL_883:
																num2 = 98;
																string imageFile;
																if (!flag3)
																{
																	IL_88A:
																	num2 = 99;
																	imageFile = Ooo_O.GetRemoteImageFile(array4[num4], OO_00oOO.DataTables[array3[0]].DataCols[array3[1]]);
																}
																else
																{
																	IL_8B7:
																	num2 = 101;
																	imageFile = array4[num4];
																}
																IL_8C1:
																num2 = 102;
																this.ReplaceWithImage(text2, imageFile, Conversions.ToInteger(array3[3]), Conversions.ToInteger(array3[4]));
															}
															else
															{
																IL_8E5:
																num2 = 104;
																this.Replace(text2, "");
															}
														}
														else
														{
															IL_8FA:
															num2 = 106;
															this.Replace(text2, "");
														}
													}
												}
											}
										}
									}
								}
								else
								{
									IL_90F:
									num2 = 108;
									if (array3.Length == 2 || (array3.Length == 4 && Versioned.IsNumeric(array3[2]) && Versioned.IsNumeric(array3[3])))
									{
										IL_93F:
										num2 = 109;
										array3[0] = array3[0].Trim();
										IL_94F:
										num2 = 110;
										array3[1] = array3[1].Trim();
										IL_95F:
										num2 = 111;
										bool flag4 = array3[0].StartsWith("&");
										IL_972:
										num2 = 112;
										if (flag4)
										{
											IL_979:
											num2 = 113;
											array3[0] = array3[0].Substring(1);
										}
										IL_98A:
										num2 = 114;
										if (!this.O_.ooO_0_OOo..ContainsKey(array3[0]))
										{
											IL_9A1:
											num2 = 115;
											IEnumerator enumerator4 = dr.BaseRow.Table.DataSet.Relations.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												object obj4 = enumerator4.Current;
												DataRelation dataRelation2 = (DataRelation)obj4;
												IL_9D0:
												num2 = 116;
												if (Operators.CompareString(dataRelation2.ParentTable.TableName, array3[0], true) == 0 && Operators.CompareString(dataRelation2.ChildTable.TableName, this.O_.ooO_0_OOo., true) == 0)
												{
													IL_A05:
													num2 = 117;
													this.O_.ooO_0_OOo..Add(array3[0], dr.BaseRow.GetParentRow(dataRelation2));
												}
												IL_A24:
												num2 = 118;
											}
											IL_A30:
											num2 = 119;
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
										IL_A48:
										num2 = 120;
										int num5 = 0;
										IL_A4E:
										num2 = 121;
										if (array3[1].IndexOf("&") > 0)
										{
											IL_A62:
											num2 = 122;
											int.TryParse(array3[1].Substring(array3[1].IndexOf("&") + 1), out num5);
											IL_A86:
											num2 = 123;
											array3[1] = array3[1].Substring(0, array3[1].IndexOf("&"));
										}
										IL_AA5:
										num2 = 124;
										if (this.O_.ooO_0_OOo..ContainsKey(array3[0]) && ((OO_00oOO.DataTables.Contains(array3[0]) && OO_00oOO.DataTables[array3[0]].DataCols.Contains(array3[1])) || (this.O_.ooO_0_OOo. != null && this.O_.ooO_0_OOo..Tables.Contains(array3[0]) && this.O_.ooO_0_OOo..Tables[array3[0]].Columns.Contains(array3[1]))))
										{
											IL_B35:
											num2 = 125;
											bool flag5;
											if (OO_00oOO.DataTables.Contains(array3[0]) && OO_00oOO.DataTables[array3[0]].DataCols.Contains(array3[1]))
											{
												IL_B66:
												num2 = 126;
												flag5 = false;
											}
											else
											{
												IL_B6E:
												num2 = 128;
												flag5 = true;
											}
											IL_B77:
											num2 = 129;
											DataRow dataRow = this.O_.ooO_0_OOo.[array3[0]];
											IL_B8E:
											num2 = 130;
											if (dataRow != null)
											{
												IL_B9B:
												num2 = 131;
												if (dataRow.IsNull(array3[1]))
												{
													IL_BAE:
													num2 = 132;
													this.Replace(text2, "");
												}
												else
												{
													IL_BC6:
													num2 = 134;
													if (array3.Length == 2)
													{
														IL_BD6:
														num2 = 135;
														if (!flag5 && OO_00oOO.DataTables[array3[0]].DataCols[array3[1]].ExtendType == ExtendTypeEnum.TimeSpan)
														{
															IL_C04:
															num2 = 136;
															double a_2 = Conversion.Val(dataRow[array3[1]].ToString());
															IL_C21:
															num2 = 137;
															string repaceText2 = "";
															IL_C2E:
															num2 = 138;
															O_O0OO.o.00O_O.(a_2, ref repaceText2);
															IL_C3E:
															num2 = 139;
															this.Replace(text2, repaceText2);
														}
														else
														{
															IL_C53:
															num2 = 141;
															this.Replace(text2, dataRow[array3[1]].ToString());
														}
													}
													else
													{
														IL_C76:
														num2 = 143;
														if (flag4 && array3.Length == 4)
														{
															IL_C8D:
															num2 = 144;
															string[] array5 = dataRow[array3[1]].ToString().ToString().Split(new char[]
															{
																'\n',
																'\r'
															}, StringSplitOptions.RemoveEmptyEntries);
															IL_CC0:
															num2 = 145;
															if (array5.Length > num5)
															{
																IL_CCE:
																num2 = 146;
																string imageFile2;
																if (!flag5)
																{
																	IL_CD8:
																	num2 = 147;
																	Ooo_O.GetRemoteImageFile(array5[num5], OO_00oOO.DataTables[array3[0]].DataCols[array3[1]]);
																}
																else
																{
																	IL_D07:
																	num2 = 149;
																	imageFile2 = array5[num5];
																}
																IL_D14:
																num2 = 150;
																this.ReplaceWithImage(text2, imageFile2, Conversions.ToInteger(array3[2]), Conversions.ToInteger(array3[3]));
															}
															else
															{
																IL_D3B:
																num2 = 152;
																this.Replace(text2, "");
															}
														}
													}
												}
											}
											else
											{
												IL_D53:
												num2 = 154;
												this.Replace(text2, "");
											}
										}
									}
								}
							}
							else
							{
								IL_D6B:
								num2 = 156;
								if (text3.StartsWith("%"))
								{
									IL_D82:
									num2 = 157;
									text3 = text3.Substring(1);
									IL_D92:
									num2 = 158;
									string[] array6 = text3.Split(new char[]
									{
										','
									});
									IL_DAC:
									num2 = 159;
									if (array6.Length == 2)
									{
										IL_DBC:
										num2 = 160;
										array6[0] = array6[0].Trim();
										IL_DCF:
										num2 = 161;
										array6[1] = array6[1].Trim();
										IL_DE2:
										num2 = 162;
										IEnumerator enumerator5 = dr.BaseRow.Table.DataSet.Relations.GetEnumerator();
										while (enumerator5.MoveNext())
										{
											object obj5 = enumerator5.Current;
											DataRelation dataRelation3 = (DataRelation)obj5;
											IL_E17:
											num2 = 163;
											if (Operators.CompareString(dataRelation3.ParentTable.TableName, this.O_.ooO_0_OOo., true) == 0 && Operators.CompareString(dataRelation3.ChildTable.TableName, array6[0], true) == 0)
											{
												IL_E55:
												num2 = 164;
												string filter = Oo00.oo0o.O0O_0__.(dr.BaseRow, array6[0]);
												IL_E6C:
												num2 = 165;
												if (array6[1].StartsWith(":"))
												{
													IL_E82:
													num2 = 166;
													array6[1] = array6[1].Substring(1);
													IL_E96:
													num2 = 167;
													double a_3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRelation3.ChildTable.Compute(array6[1], filter)));
													IL_EBA:
													num2 = 168;
													string repaceText3 = "";
													IL_EC7:
													num2 = 169;
													O_O0OO.o.00O_O.(a_3, ref repaceText3);
													IL_ED7:
													num2 = 170;
													this.Replace(text2, repaceText3);
												}
												else
												{
													IL_EE9:
													num2 = 172;
													this.Replace(text2, dataRelation3.ChildTable.Compute(array6[1], filter).ToString());
												}
											}
											IL_F0E:
											num2 = 173;
										}
										IL_F20:
										num2 = 174;
										if (enumerator5 is IDisposable)
										{
											(enumerator5 as IDisposable).Dispose();
										}
									}
								}
								else
								{
									IL_F43:
									num2 = 176;
									if (dr.DataTable.DataCols.Contains(text3))
									{
										IL_F60:
										num2 = 177;
										if (dr.DataTable.DataCols[text3].IsDate)
										{
											IL_F82:
											num2 = 178;
											if (dr.get_IsNull(text3))
											{
												IL_F92:
												num2 = 179;
												text3 = "";
											}
											else
											{
												IL_FA4:
												num2 = 181;
												DateTime dateTime = Conversions.ToDate(dr[text3]);
												IL_FB9:
												num2 = 182;
												if (DateTime.Compare(dateTime.Date, dateTime) == 0)
												{
													IL_FCF:
													num2 = 183;
													text3 = Strings.Format(dateTime, "yyyy-MM-dd");
												}
												else
												{
													IL_FED:
													num2 = 185;
													text3 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss");
												}
											}
										}
										else
										{
											IL_100B:
											num2 = 187;
											if (dr.DataTable.DataCols[text3].ExtendType == ExtendTypeEnum.TimeSpan)
											{
												IL_102B:
												num2 = 188;
												if (dr.get_IsNull(text3))
												{
													IL_103B:
													num2 = 189;
													text3 = "";
												}
												else
												{
													IL_104A:
													num2 = 191;
													double a_4 = Conversion.Val(RuntimeHelpers.GetObjectValue(dr[text3]));
													IL_1064:
													num2 = 192;
													O_O0OO.o.00O_O.(a_4, ref text3);
												}
											}
											else
											{
												IL_1076:
												num2 = 194;
												if (dr.get_IsNull(text3))
												{
													IL_1086:
													num2 = 195;
													text3 = "";
												}
												else
												{
													IL_1095:
													num2 = 197;
													text3 = dr[text3].ToString();
												}
											}
										}
										IL_10AA:
										num2 = 198;
										this.Replace(text2, text3);
									}
								}
							}
						}
					}
					else
					{
						IL_10BF:
						num2 = 200;
						if (text3.StartsWith("<") && text3.EndsWith(">"))
						{
							IL_10E7:
							num2 = 201;
							if (Operators.CompareString(text3, "<index>", true) != 0)
							{
								IL_1114:
								num2 = 204;
								text3 = text3.Trim().Trim(new char[]
								{
									'<'
								}).Trim(new char[]
								{
									'>'
								});
								IL_1143:
								num2 = 205;
								bool flag6 = false;
								IL_114C:
								num2 = 206;
								int num6 = text3.IndexOf("[");
								for (;;)
								{
									IL_12B6:
									num2 = 208;
									if (num6 < 0)
									{
										break;
									}
									IL_1165:
									num2 = 209;
									int num7 = text3.IndexOf("]", num6);
									IL_117B:
									num2 = 210;
									if (num7 <= 0)
									{
										break;
									}
									IL_1189:
									num2 = 211;
									string text4 = text3.Substring(num6, num7 - num6 + 1);
									IL_11A1:
									num2 = 212;
									object objectValue2 = RuntimeHelpers.GetObjectValue(this.O.0o0O__o.(text4, dr));
									IL_11B7:
									num2 = 213;
									if (!(objectValue2 is string) || Operators.CompareString(objectValue2.ToString(), text4, true) != 0)
									{
										IL_11DA:
										num2 = 215;
										if (objectValue2 is string && Operators.CompareString(objectValue2.ToString(), "Error$$bnf", true) == 0)
										{
											goto IL_11FD;
										}
										IL_120B:
										num2 = 219;
										if (objectValue2 is string)
										{
											IL_121A:
											num2 = 220;
											text3 = text3.Replace(text4, "\"" + objectValue2.ToString() + "\"");
										}
										else
										{
											IL_1243:
											num2 = 222;
											if (objectValue2 is DateTime)
											{
												IL_1252:
												num2 = 223;
												text3 = text3.Replace(text4, "#" + objectValue2.ToString() + "#");
											}
											else
											{
												IL_127B:
												num2 = 225;
												text3 = text3.Replace(text4, objectValue2.ToString());
											}
										}
									}
									IL_1293:
									num2 = 226;
									num6 = text3.IndexOf("[", num6 + objectValue2.ToString().Length);
								}
								IL_12C4:
								num2 = 230;
								if (flag6)
								{
									IL_12CE:
									num2 = 231;
									text3 = "";
									goto IL_1329;
								}
								IL_12DD:
								num2 = 233;
								object objectValue3 = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text3.Replace("\\>", ">").Replace("\\<", "<"), dr));
								IL_1310:
								num2 = 234;
								if (objectValue3 != null)
								{
									IL_131A:
									num2 = 235;
									text3 = objectValue3.ToString();
									goto IL_1329;
								}
								goto IL_1329;
								IL_11FD:
								num2 = 216;
								flag6 = true;
								goto IL_12C4;
							}
							IL_10FC:
							num2 = 202;
							text3 = this.OOo_oooOo_.0Oo..ToString();
							IL_1329:
							num2 = 236;
							this.Replace(text2, text3);
						}
					}
					IL_1339:
					num2 = 237;
				}
				IL_134B:
				num2 = 238;
				((IDisposable)enumerator2).Dispose();
				IL_135E:
				num2 = 239;
				this.O_.ooO_0_OOo..Clear();
				IL_136F:
				goto IL_1781;
				IL_1374:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_1742:
				goto IL_1776;
				IL_1744:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1754:;
			}
			catch when (endfilter(obj6 is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj7;
				goto IL_1744;
			}
			IL_1776:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1781:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00236070 File Offset: 0x00234270
		private object <<EMPTY_NAME>>(string A_0, DataRow A_1)
		{
			int num;
			object result;
			int num6;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = A_0.Trim();
				IL_11:
				num2 = 3;
				text = text.Trim().Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				});
				IL_3C:
				num2 = 4;
				if (!text.StartsWith("@"))
				{
					goto IL_4F9;
				}
				IL_4F:
				num2 = 5;
				text = text.Substring(1);
				IL_5B:
				num2 = 6;
				string[] array = text.Split(new char[]
				{
					','
				});
				IL_71:
				num2 = 7;
				if (array.Length != 3 || !Versioned.IsNumeric(array[2]))
				{
					goto IL_2F3;
				}
				IL_8B:
				num2 = 8;
				array[0] = array[0].Trim();
				IL_9A:
				num2 = 9;
				array[1] = array[1].Trim();
				IL_AA:
				num2 = 10;
				bool flag = array[0].StartsWith("&");
				IL_BD:
				num2 = 11;
				if (!flag)
				{
					goto IL_D5;
				}
				IL_C4:
				num2 = 12;
				array[0] = array[0].Substring(1);
				IL_D5:
				num2 = 13;
				if (this.O000.OO0__OoO..ContainsKey(array[0]))
				{
					goto IL_193;
				}
				IL_EC:
				num2 = 14;
				IEnumerator enumerator = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_11B:
					num2 = 15;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, this.O_.ooO_0_OOo., true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, array[0], true) == 0)
					{
						IL_150:
						num2 = 16;
						this.O000.OO0__OoO..Add(array[0], A_1.BaseRow.GetChildRows(dataRelation));
					}
					IL_16F:
					num2 = 17;
				}
				IL_17B:
				num2 = 18;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_193:
				num2 = 19;
				int num3 = 0;
				IL_199:
				num2 = 20;
				if (array[1].IndexOf("&") <= 0)
				{
					goto IL_1F0;
				}
				IL_1AD:
				num2 = 21;
				int.TryParse(array[1].Substring(array[1].IndexOf("&") + 1), out num3);
				IL_1D1:
				num2 = 22;
				array[1] = array[1].Substring(0, array[1].IndexOf("&"));
				IL_1F0:
				num2 = 23;
				if (!this.O000.OO0__OoO..ContainsKey(array[0]) || !OO_00oOO.DataTables[array[0]].DataCols.Contains(array[1]))
				{
					goto IL_61D;
				}
				IL_228:
				num2 = 24;
				if (this.O000.OO0__OoO.[array[0]].Length >= Conversions.ToInteger(array[2]))
				{
					goto IL_255;
				}
				IL_247:
				num2 = 25;
				result = "Error$$bnf";
				goto IL_622;
				IL_255:
				num2 = 27;
				if (!this.O000.OO0__OoO.[array[0]][Conversions.ToInteger(array[2]) - 1].IsNull(array[1]))
				{
					goto IL_28C;
				}
				IL_27E:
				num2 = 28;
				result = "Error$$bnf";
				goto IL_622;
				IL_28C:
				num2 = 30;
				if (array.Length != 3)
				{
					goto IL_61D;
				}
				IL_299:
				num2 = 31;
				if (Conversions.ToInteger(array[2]) > this.O000.OO0__OoO.[array[0]].Length)
				{
					goto IL_2E5;
				}
				IL_2B8:
				num2 = 32;
				result = this.O000.OO0__OoO.[array[0]][Conversions.ToInteger(array[2]) - 1][array[1]];
				goto IL_622;
				IL_2E5:
				num2 = 34;
				result = "Error$$bnf";
				goto IL_622;
				IL_2F3:
				num2 = 36;
				if (array.Length != 2)
				{
					goto IL_61D;
				}
				IL_300:
				num2 = 37;
				array[0] = array[0].Trim();
				IL_310:
				num2 = 38;
				array[1] = array[1].Trim();
				IL_320:
				num2 = 39;
				bool flag2 = array[0].StartsWith("&");
				IL_333:
				num2 = 40;
				if (!flag2)
				{
					goto IL_34B;
				}
				IL_33A:
				num2 = 41;
				array[0] = array[0].Substring(1);
				IL_34B:
				num2 = 42;
				if (this.O_.ooO_0_OOo..ContainsKey(array[0]))
				{
					goto IL_409;
				}
				IL_362:
				num2 = 43;
				IEnumerator enumerator2 = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRelation dataRelation2 = (DataRelation)obj2;
					IL_391:
					num2 = 44;
					if (Operators.CompareString(dataRelation2.ParentTable.TableName, array[0], true) == 0 && Operators.CompareString(dataRelation2.ChildTable.TableName, this.O_.ooO_0_OOo., true) == 0)
					{
						IL_3C6:
						num2 = 45;
						this.O_.ooO_0_OOo..Add(array[0], A_1.BaseRow.GetParentRow(dataRelation2));
					}
					IL_3E5:
					num2 = 46;
				}
				IL_3F1:
				num2 = 47;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_409:
				num2 = 48;
				int num4 = 0;
				IL_40F:
				num2 = 49;
				if (array[1].IndexOf("&") <= 0)
				{
					goto IL_466;
				}
				IL_423:
				num2 = 50;
				int.TryParse(array[1].Substring(array[1].IndexOf("&") + 1), out num4);
				IL_447:
				num2 = 51;
				array[1] = array[1].Substring(0, array[1].IndexOf("&"));
				IL_466:
				num2 = 52;
				if (!this.O_.ooO_0_OOo..ContainsKey(array[0]) || !OO_00oOO.DataTables[array[0]].DataCols.Contains(array[1]))
				{
					goto IL_61D;
				}
				IL_49E:
				num2 = 53;
				DataRow dataRow = this.O_.ooO_0_OOo.[array[0]];
				IL_4B2:
				num2 = 54;
				if (dataRow == null)
				{
					goto IL_4EB;
				}
				IL_4B9:
				num2 = 55;
				if (!dataRow.IsNull(array[1]))
				{
					goto IL_4D7;
				}
				IL_4C9:
				num2 = 56;
				result = "Error$$bnf";
				goto IL_622;
				IL_4D7:
				num2 = 58;
				result = dataRow[array[1]];
				goto IL_622;
				IL_4EB:
				num2 = 60;
				result = "Error$$bnf";
				goto IL_622;
				IL_4F9:
				num2 = 62;
				if (!text.StartsWith("%"))
				{
					goto IL_61D;
				}
				IL_50D:
				num2 = 63;
				text = text.Substring(1);
				IL_51A:
				num2 = 64;
				string[] array2 = text.Split(new char[]
				{
					','
				});
				IL_531:
				num2 = 65;
				if (array2.Length != 2)
				{
					goto IL_612;
				}
				IL_53E:
				num2 = 66;
				array2[0] = array2[0].Trim();
				IL_54E:
				num2 = 67;
				array2[1] = array2[1].Trim();
				IL_55E:
				num2 = 68;
				IEnumerator enumerator3 = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					object obj3 = enumerator3.Current;
					DataRelation dataRelation3 = (DataRelation)obj3;
					IL_58D:
					num2 = 69;
					if (Operators.CompareString(dataRelation3.ParentTable.TableName, this.O_.ooO_0_OOo., true) == 0 && Operators.CompareString(dataRelation3.ChildTable.TableName, array2[0], true) == 0)
					{
						IL_5C2:
						num2 = 70;
						string filter = Oo00.oo0o.O0O_0__.(A_1.BaseRow, array2[0]);
						IL_5D6:
						num2 = 71;
						result = dataRelation3.ChildTable.Compute(array2[1], filter);
						goto IL_622;
					}
					IL_5EE:
					num2 = 72;
				}
				IL_5FA:
				num2 = 73;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				IL_612:
				num2 = 74;
				result = "Error$$bnf";
				goto IL_622;
				IL_61D:
				num2 = 75;
				result = A_0;
				IL_622:
				goto IL_7A4;
				IL_627:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_765:
				goto IL_799;
				IL_767:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_777:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_767;
			}
			IL_799:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7A4:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 退出报表，退出前会先保存
		/// </summary>
		// Token: 0x06004E1E RID: 19998 RVA: 0x00236848 File Offset: 0x00234A48
		public void Quit()
		{
			this.O_.ooO_0_OOo..Save();
			Documents documents = WordReport.app.Documents;
			object obj = 1;
			_Document document = documents[ref obj];
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			document.Close(ref objectValue, ref objectValue2, ref objectValue3);
			_Application application = WordReport.app;
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			application.Quit(ref objectValue3, ref objectValue2, ref objectValue);
			this.O_.ooO_0_OOo. = null;
			WordReport.app = null;
			GC.Collect();
			GC.Collect();
			GC.Collect();
			GC.Collect();
		}

		/// <summary>
		/// 不保存退出
		/// </summary>
		// Token: 0x06004E1F RID: 19999 RVA: 0x002368F8 File Offset: 0x00234AF8
		public void QuitWithoutSave()
		{
			Documents documents = WordReport.app.Documents;
			object obj = 1;
			_Document document = documents[ref obj];
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			document.Close(ref objectValue, ref objectValue2, ref objectValue3);
			_Application application = WordReport.app;
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			application.Quit(ref objectValue3, ref objectValue2, ref objectValue);
			this.O_.ooO_0_OOo. = null;
			WordReport.app = null;
			GC.Collect();
			GC.Collect();
			GC.Collect();
			GC.Collect();
		}

		/// <summary>
		/// 启动Word，显示生成的报表
		/// </summary>
		// Token: 0x06004E20 RID: 20000 RVA: 0x0023699C File Offset: 0x00234B9C
		public void Show()
		{
			object obj = WdMovementType.wdMove;
			Selection selection = WordReport.app.Selection;
			object obj2 = WdUnits.wdStory;
			selection.HomeKey(ref obj2, ref obj);
			this.O_.ooO_0_OOo..Save();
			WordReport.app.Visible = true;
			int num = OO_00oOO.FindAppWindow(OO_00oOO.FileSys.GetName(this.O_.ooO_0_OOo..FullName));
			if (num > 0)
			{
				WordReport.SetForegroundWindow(num);
				WordReport.SetActiveWindow(num);
			}
		}

		/// <summary>
		/// 整数型，指定每页打印的记录数
		/// </summary>
		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x00236A0E File Offset: 0x00234C0E
		// (set) Token: 0x06004E22 RID: 20002 RVA: 0x00236A16 File Offset: 0x00234C16
		public int RecordsOnEachPage
		{
			get
			{
				return this.oO.0O_00ooO_O.;
			}
			set
			{
				this.oO.0O_00ooO_O. = value;
			}
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00236A1F File Offset: 0x00234C1F
		private static void <<EMPTY_NAME>>()
		{
			WordReport.app = null;
		}

		/// <summary>
		/// 将报表保存为PDF文件
		/// </summary>
		/// <param name="fileName">文件名，含路径</param>
		// Token: 0x06004E24 RID: 20004 RVA: 0x00236A28 File Offset: 0x00234C28
		public void SaveToPDF(string fileName)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(fileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			_Document o_.ooO_0_OOo. = this.O_.ooO_0_OOo.;
			WdExportFormat exportFormat = WdExportFormat.wdExportFormatPDF;
			bool openAfterExport = false;
			WdExportOptimizeFor optimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint;
			WdExportRange range = WdExportRange.wdExportAllDocument;
			int from = 1;
			int to = 1;
			WdExportItem item = WdExportItem.wdExportDocumentContent;
			bool includeDocProps = false;
			bool keepIRM = true;
			WdExportCreateBookmarks createBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks;
			bool docStructureTags = true;
			bool bitmapMissingFonts = true;
			bool useISO19005_ = false;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			o_.ooO_0_OOo..ExportAsFixedFormat(fileName, exportFormat, openAfterExport, optimizeFor, range, from, to, item, includeDocProps, keepIRM, createBookmarks, docStructureTags, bitmapMissingFonts, useISO19005_, ref objectValue);
		}

		/// <summary>
		/// 将报表保存为网页文件
		/// </summary>
		/// <param name="fileName">文件名，含路径</param>
		// Token: 0x06004E25 RID: 20005 RVA: 0x00236A84 File Offset: 0x00234C84
		public void SaveToHTML(string fileName)
		{
			object obj = fileName;
			string parentPath = OO_00oOO.FileSys.GetParentPath(fileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			_Document o_.ooO_0_OOo. = this.O_.ooO_0_OOo.;
			object obj2 = WdSaveFormat.wdFormatHTML;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object obj3 = false;
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			o_.ooO_0_OOo..SaveAs2(ref obj, ref obj2, ref objectValue, ref objectValue2, ref obj3, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14);
		}

		/// <summary>
		/// 将报表保存为MHT文件
		/// </summary>
		/// <param name="fileName">文件名，含路径</param>
		// Token: 0x06004E26 RID: 20006 RVA: 0x00236B9C File Offset: 0x00234D9C
		public void SaveToMHT(string fileName)
		{
			object obj = fileName;
			string parentPath = OO_00oOO.FileSys.GetParentPath(fileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			_Document o_.ooO_0_OOo. = this.O_.ooO_0_OOo.;
			object obj2 = WdSaveFormat.wdFormatWebArchive;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object obj3 = false;
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			o_.ooO_0_OOo..SaveAs2(ref obj, ref obj2, ref objectValue, ref objectValue2, ref obj3, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14);
		}

		/// <summary>
		/// 打印报表
		/// </summary>
		// Token: 0x06004E27 RID: 20007 RVA: 0x00236CB4 File Offset: 0x00234EB4
		public void Print()
		{
			_Document o_.ooO_0_OOo. = this.O_.ooO_0_OOo.;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue15 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue16 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue17 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue18 = RuntimeHelpers.GetObjectValue(Missing.Value);
			o_.ooO_0_OOo..PrintOut(ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14, ref objectValue15, ref objectValue16, ref objectValue17, ref objectValue18);
		}

		/// <summary>
		/// 预览报表
		/// </summary>
		// Token: 0x06004E28 RID: 20008 RVA: 0x00236DC4 File Offset: 0x00234FC4
		public void Preview()
		{
			this.O_.ooO_0_OOo..PrintPreview();
		}

		/// <summary>
		/// 添加后台数据表，用于打印后台数据
		/// </summary>
		/// <param name="TableName">临时表的名称，必须和报表模板中的表名保持一致</param>
		/// <param name="ConnectionName">数据源名</param>
		/// <param name="SelectString">Select语句</param>
		// Token: 0x06004E29 RID: 20009 RVA: 0x00236DD4 File Offset: 0x00234FD4
		[oO0oooo("3310")]
		public void AddDataTable(string TableName, string ConnectionName, string SelectString)
		{
			this.O_.ooO_0_OOo. = true;
			o0__oo0OOo o0__oo0OOo = new o0__oo0OOo();
			o0__oo0OOo.O_0O00O0_.oOo. = ConnectionName;
			o0__oo0OOo.O_oo._o. = TableName;
			o0__oo0OOo.Oo.__0o0_. = SelectString;
			this.O000.OO0__OoO..Add(o0__oo0OOo);
		}

		/// <summary>
		/// 指定一个临时DataTable作为报表的数据来源
		/// </summary>
		/// <param name="TableName">临时表的名称，必须和报表模板中的表名保持一致</param>
		/// <param name="DataTable">一个临时DataTable，此DataTable不能是DataTables中的一员</param>
		// Token: 0x06004E2A RID: 20010 RVA: 0x00236E10 File Offset: 0x00235010
		[oO0oooo("3310")]
		public void AddDataTable(string TableName, Foxtable.DataTable DataTable)
		{
			if (DataTable.BaseTable.DataSet == null)
			{
				this.O_.ooO_0_OOo. = true;
				o0__oo0OOo o0__oo0OOo = new o0__oo0OOo();
				o0__oo0OOo.O_oo._o. = TableName;
				o0__oo0OOo.oo0_O0_000o.0o. = DataTable;
				this.O000.OO0__OoO..Add(o0__oo0OOo);
				return;
			}
			OO_00oOO.PopMessage("添加表失败，此表已属于某DataSet", "提示", PopiconEnum.Infomation, -1);
		}

		/// <summary>
		/// 在通过AddDataTable增加的临时表之间创建关联
		/// </summary>
		/// <param name="ParentTable">父表</param>
		/// <param name="ParentColumn">父表关联列</param>
		/// <param name="ChildTable">子表</param>
		/// <param name="ChildColumn">子表关联列</param>
		// Token: 0x06004E2B RID: 20011 RVA: 0x00236E63 File Offset: 0x00235063
		[oO0oooo("3310")]
		public void AddRelation(string ParentTable, string ParentColumn, string ChildTable, string ChildColumn)
		{
			this.AddRelation(ParentTable, new string[]
			{
				ParentColumn
			}, ChildTable, new string[]
			{
				ChildColumn
			});
		}

		/// <summary>
		/// 在通过AddDataTable增加的临时表之间创建关联
		/// </summary>
		/// <param name="ParentTable">父表</param>
		/// <param name="ParentColumns">一个字符数组，指定多个父表关联列</param>
		/// <param name="ChildTable">子表</param>
		/// <param name="ChildColumns">一个字符数组，指定多个子表关联列</param>
		// Token: 0x06004E2C RID: 20012 RVA: 0x00236E84 File Offset: 0x00235084
		[oO0oooo("3310")]
		public void AddRelation(string ParentTable, string[] ParentColumns, string ChildTable, string[] ChildColumns)
		{
			this.O_.ooO_0_OOo. = true;
			O_0OO o_0OO = new O_0OO();
			o_0OO.O_oo._o. = ParentTable;
			o_0OO.O_oo._o. = ParentColumns;
			o_0OO.O000000o0.oO0o. = ChildTable;
			o_0OO.O000000o0.oO0o. = ChildColumns;
			this.O000.OO0__OoO..Add(o_0OO);
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00236EC8 File Offset: 0x002350C8
		private bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				foreach (O_0OO o_0OO in this.O000.OO0__OoO.)
				{
					if (Operators.CompareString(o_0OO.O_oo._o., A_0, true) == 0 && Operators.CompareString(o_0OO.O000000o0.oO0o., A_1, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				List<O_0OO>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00236F3C File Offset: 0x0023513C
		private void <<EMPTY_NAME>>()
		{
			if (this.O_.ooO_0_OOo.)
			{
				this.O_.ooO_0_OOo. = false;
				try
				{
					foreach (o0__oo0OOo o0__oo0OOo in this.O000.OO0__OoO.)
					{
						if (this.O_.ooO_0_OOo. == null)
						{
							this.O_.ooO_0_OOo. = new DataSet();
							this.O_.ooO_0_OOo..EnforceConstraints = false;
						}
						if (Operators.CompareString(o0__oo0OOo.Oo.__0o0_., "", true) > 0)
						{
							Foxtable.DataTable dataTable = new SQLCommand(o0__oo0OOo.Oo.__0o0_., o0__oo0OOo.O_0O00O0_.oOo.).ExecuteReader(false);
							dataTable.BaseTable.TableName = o0__oo0OOo.O_oo._o.;
							this.O_.ooO_0_OOo..Tables.Add(dataTable.BaseTable);
							this.o__o.OOoO_..add(o0__oo0OOo.O_oo._o., dataTable);
						}
						else if (o0__oo0OOo.oo0_O0_000o.0o. != null)
						{
							this.O_.ooO_0_OOo..Tables.Add(o0__oo0OOo.oo0_O0_000o.0o..BaseTable);
							o0__oo0OOo.oo0_O0_000o.0o..BaseTable.TableName = o0__oo0OOo.O_oo._o.;
							this.o__o.OOoO_..add(o0__oo0OOo.O_oo._o., o0__oo0OOo.oo0_O0_000o.0o.);
						}
					}
				}
				finally
				{
					List<o0__oo0OOo>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.O000.OO0__OoO..Count > 0)
				{
					try
					{
						foreach (O_0OO o_0OO in this.O000.OO0__OoO.)
						{
							if (!this.O_.ooO_0_OOo..Tables.Contains(o_0OO.O_oo._o..ToLower()) || !this.O_.ooO_0_OOo..Tables.Contains(o_0OO.O000000o0.oO0o.) || o_0OO.O_oo._o..Length != o_0OO.O000000o0.oO0o..Length || o_0OO.O_oo._o..Length == 0)
							{
								OO_00oOO.PopMessage("创建关联失败!", "提示", PopiconEnum.Infomation, -1);
								this.O_.ooO_0_OOo..Reset();
								return;
							}
							List<DataColumn> list = new List<DataColumn>();
							List<DataColumn> list2 = new List<DataColumn>();
							int num = o_0OO.O_oo._o..Length - 1;
							for (int i = 0; i <= num; i++)
							{
								if (this.O_.ooO_0_OOo..Tables[o_0OO.O_oo._o.].Columns[o_0OO.O_oo._o.[i]].DataType != this.O_.ooO_0_OOo..Tables[o_0OO.O000000o0.oO0o.].Columns[o_0OO.O000000o0.oO0o.[i]].DataType)
								{
									OO_00oOO.PopMessage("关联列数据类型不匹配!", "提示", PopiconEnum.Infomation, -1);
									this.O_.ooO_0_OOo..Reset();
									return;
								}
								list.Add(this.O_.ooO_0_OOo..Tables[o_0OO.O_oo._o.].Columns[o_0OO.O_oo._o.[i]]);
								list2.Add(this.O_.ooO_0_OOo..Tables[o_0OO.O000000o0.oO0o.].Columns[o_0OO.O000000o0.oO0o.[i]]);
							}
							DataRelation dataRelation = new DataRelation(o_0OO.O000000o0.oO0o., list.ToArray(), list2.ToArray());
							dataRelation.RelationName = OoOo0O.OO_o.0o_O.(10);
							this.O_.ooO_0_OOo..Relations.Add(dataRelation);
						}
					}
					finally
					{
						List<O_0OO>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				try
				{
					foreach (Foxtable.DataTable dataTable2 in this.o__o.OOoO_.._List.Values)
					{
						if (OO_00oOO.DataTables.Contains(dataTable2.BaseTable.TableName))
						{
							Foxtable.DataTable dataTable3 = OO_00oOO.DataTables[dataTable2.BaseTable.TableName];
							try
							{
								foreach (DataCol dataCol in dataTable2.DataCols)
								{
									if (dataTable3.DataCols.Contains(dataCol.Name))
									{
										dataCol.ExtendType = dataTable3.DataCols[dataCol.Name].ExtendType;
										dataCol.Remote = dataTable3.DataCols[dataCol.Name].Remote;
										if (dataCol.Remote & dataTable3.DataCols[dataCol.Name].FTPClient != null)
										{
											dataCol.FTPClient = dataTable3.DataCols[dataCol.Name].FTPClient.O_O_0_O0.oOO.();
										}
									}
								}
							}
							finally
							{
								IEnumerator<DataCol> enumerator4;
								if (enumerator4 != null)
								{
									enumerator4.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<string, Foxtable.DataTable>.ValueCollection.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				this.O_.ooO_0_OOo. = this.O_.ooO_0_OOo..Tables[0].TableName;
			}
		}

		// Token: 0x04001FDD RID: 8157
		[AccessedThroughProperty("app")]
		[CompilerGenerated]
		private static Microsoft.Office.Interop.Word.Application <<EMPTY_NAME>>;

		// Token: 0x04001FDE RID: 8158
		private Document <<EMPTY_NAME>>;

		// Token: 0x04001FDF RID: 8159
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001FE0 RID: 8160
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001FE1 RID: 8161
		private string <<EMPTY_NAME>>;

		// Token: 0x04001FE2 RID: 8162
		private int <<EMPTY_NAME>>;

		// Token: 0x04001FE3 RID: 8163
		private int <<EMPTY_NAME>>;

		// Token: 0x04001FE4 RID: 8164
		private int <<EMPTY_NAME>>;

		// Token: 0x04001FE5 RID: 8165
		private Dictionary<string, DataRow[]> <<EMPTY_NAME>>;

		// Token: 0x04001FE6 RID: 8166
		private Dictionary<string, DataRow> <<EMPTY_NAME>>;

		// Token: 0x04001FE7 RID: 8167
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04001FE8 RID: 8168
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04001FE9 RID: 8169
		private int <<EMPTY_NAME>>;

		// Token: 0x04001FEA RID: 8170
		internal DataSet <<EMPTY_NAME>>;

		// Token: 0x04001FEB RID: 8171
		private tempDataTableCollection <<EMPTY_NAME>>;

		// Token: 0x04001FEC RID: 8172
		private List<O_0OO> <<EMPTY_NAME>>;

		// Token: 0x04001FED RID: 8173
		private List<o0__oo0OOo> <<EMPTY_NAME>>;

		// Token: 0x04001FEE RID: 8174
		private bool <<EMPTY_NAME>>;
	}
}
