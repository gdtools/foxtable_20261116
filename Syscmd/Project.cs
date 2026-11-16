using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using C1.C1Zip;
using C1.Win.C1Command;
using Foxtable.My;
using Foxtable.WinForm;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和项目相关的系统命令
	/// </summary>
	// Token: 0x02000543 RID: 1347
	[StandardModule]
	public sealed class Project
	{
		/// <summary>
		/// 新建项目
		/// </summary>
		// Token: 0x06005A89 RID: 23177 RVA: 0x00267290 File Offset: 0x00265490
		public static void Create()
		{
			if (Oo00.OO_O_0O0OO0_.o.())
			{
				o\u3000\u3002\u3002\u30000\u3000 o_u3000_u3002_u3002_u30000_u = new o\u3000\u3002\u3002\u30000\u3000();
				if (o_u3000_u3002_u3002_u30000_u.ShowDialog() == DialogResult.OK)
				{
					string text = string.Concat(new string[]
					{
						o_u3000_u3002_u3002_u30000_u.oO0OO__.o_.().Text,
						o_u3000_u3002_u3002_u30000_u.O_O0._0.().Text,
						"\\",
						o_u3000_u3002_u3002_u30000_u.O_O0._0.().Text,
						ooO0__OO.oo.Ooo_00.()
					});
					if (!c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(text)))
					{
						c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(text));
					}
					if (o0OoOOoOOo0.O_0_Oo_00.O.(text))
					{
						OleDbConnection a_ = new OleDbConnection(Oo00.o_._0OOo.(text));
						o_oo0 o_oo = new o_oo0(a_, false, true);
						try
						{
							foreach (object obj in o_u3000_u3002_u3002_u30000_u.O_O0._0.().TabPages)
							{
								C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj;
								oo0_o0o_0o__ oo0_o0o_0o__ = (oo0_o0o_0o__)c1DockingTabPage.Controls[0];
								if (oo0_o0o_0o__.O_oo.0oOO..Rows.Count != 0)
								{
									Oo00.OO.0O0o.(o_oo, oo0_o0o_0o__.O_oo.0oOO., c1DockingTabPage.Text, oo0_o0o_0o__.O_oo.0oOO.);
								}
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
						o_oo.o0_oo0._.(false, true);
						o0OoOOoOOo0.O_00o0.O0OO_0. = true;
						o0OoOOoOOo0.oO.0_0oOOo. = true;
						Project.Open(text, new string[0]);
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
						o0OoOOoOOo0.oO.0_0oOOo. = false;
					}
					O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				}
			}
		}

		/// <summary>
		/// 打开项目
		/// </summary>
		// Token: 0x06005A8A RID: 23178 RVA: 0x00267438 File Offset: 0x00265638
		public static void Open()
		{
			if (Oo00.OO_O_0O0OO0_.o.())
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog = new OpenFileDialog();
				string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Foxtable项目";
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				if (Project.OO.OO_0o. != null)
				{
					openFileDialog.InitialDirectory = Project.OO.OO_0o.;
				}
				else
				{
					openFileDialog.InitialDirectory = text;
				}
				openFileDialog.CheckFileExists = true;
				openFileDialog.Filter = "Table文件(*" + ooO0__OO.oo.Ooo_00.() + ")|*" + ooO0__OO.oo.Ooo_00.();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					Project.OO.OO_0o. = OO_00oOO.FileSys.GetParentPath(openFileDialog.FileName);
					Project.Open(openFileDialog.FileName, new string[0]);
				}
			}
		}

		/// <summary>
		/// 打开CaseStudy目录
		/// </summary>
		// Token: 0x06005A8B RID: 23179 RVA: 0x002674F8 File Offset: 0x002656F8
		[oO0oooo("2236")]
		public static void OpenCaseStudy()
		{
			if (Oo00.OO_O_0O0OO0_.o.())
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.CheckFileExists = true;
				openFileDialog.InitialDirectory = O_O0OO.o.00O_O.() + "CaseStudy";
				openFileDialog.Filter = "Table文件(*" + ooO0__OO.oo.Ooo_00.() + ")|*" + ooO0__OO.oo.Ooo_00.();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					Project.Open(openFileDialog.FileName, new string[0]);
				}
			}
		}

		/// <summary>
		/// 打开指定的项目文件，可以设置打开参数
		/// </summary>
		/// <param name="FileName">要打开的项目文件</param>
		/// <param name="args">参数</param>
		// Token: 0x06005A8C RID: 23180 RVA: 0x00267568 File Offset: 0x00265768
		[oO0oooo("2495")]
		public static bool Open(string FileName, params string[] args)
		{
			bool result;
			if (Path.GetFileNameWithoutExtension(FileName).IndexOf(".") >= 0)
			{
				MessageBox.Show("项目文件名不能包括符号\".\"，请改名后再打开此文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				OO_00oOO.OpenFileArgs.Clear();
				OO_00oOO.OpenFileArgs.AddRange(args);
				if (Operators.CompareString(OO_00oOO.ProjectFile, "", true) > 0 && OO_00oOO.CurrentTable != null && !Oo00.OO_O_0O0OO0_.o.())
				{
					result = false;
				}
				else
				{
					try
					{
						OO_00oOO.FileWatcher.Enabled = false;
						if (Main.OO_O.o..Visible)
						{
							Main.ProcessForm.o0__.Oo0O_O0O_.("正在打开文件，请稍候...");
							Main.ProcessForm.Show();
						}
						System.Windows.Forms.Application.DoEvents();
						OO_00oOO.SystemReady = false;
						O_O0OO.o0OoO00OO.00O. = true;
						if (o0OoOOoOOo0.oO.0_0oOOo.(FileName))
						{
							OO_00oOO.Vars.Clear();
							OO_00oOO.Functions.ThrowException = false;
							OO_00oOO.Functions.Clear();
							OO_00oOO.Functions.O__00.__0_O.(false, "");
							ooO.O._oO_0O__o__o.();
							OO_00oOO.Ports.Clear();
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Initialize", null, true, "项目", true);
							OO_00oOO.FileWatcher.initialize();
							Main.OO_O.o..o_O.o__. = true;
							Main.OO_O.o..ooo.Oo0.();
							Main.OO_O.o..o_O.o__. = false;
							Main.OO_O.o. = SplashFormStateEnum.Hide;
							Main.ProcessForm.Close();
							OO_00oOO.SystemReady = true;
							O_O0OO.o0OoO00OO.00O. = false;
							Main.OO_O.o..o_0.O.();
							List<O_0> list = new List<O_0>();
							list.AddRange(O_O0OO.o__.O.().Values);
							try
							{
								foreach (O_0 o_ in list)
								{
									if (o_.o_oo._0Oo.())
									{
										o_.o_._0O0o_OoO.();
									}
								}
							}
							finally
							{
								List<O_0>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (OO_00oOO.User.Type != UserTypeEnum.Developer || !O_O0OO.o00.0.(O_O0OO.O0_00o.o0__o.))
							{
								try
								{
									foreach (Foxtable.WinForm.Form form in OO_00oOO.Forms)
									{
										if (form.AutoOpen && form.FormStyle != FormStyleEnum.模式 && ((form.FormStyle != FormStyleEnum.主窗口 && form.FormStyle != FormStyleEnum.停靠 && form.FormStyle != FormStyleEnum.并列) || (Operators.CompareString(form.TableName, "", true) != 0 && OO_00oOO.Tables.get_Contains(form.TableName))))
										{
											Main.OO_O.o. = SplashFormStateEnum.Hide;
											form.Open(int.MaxValue, int.MaxValue);
										}
									}
								}
								finally
								{
									IEnumerator<Foxtable.WinForm.Form> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "LoadUserSetting", null, true, "项目", true);
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterOpenProject", null, false, "项目", true);
							if (c.OOOOO.o.().FileSystem.FileExists(O_O0OO.o0OoO00OO.00O.))
							{
								Operators.CompareString(O_O0OO.o0OoO00OO.00O., FileName, true);
							}
							string[] array = new string[]
							{
								"RibbonMenu",
								"UserFunctions",
								"PublicCode",
								"Timers"
							};
							bool flag = false;
							foreach (string text in array)
							{
								if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
								{
									text,
									o0_O.o0O.o_.
								}) == null)
								{
									flag = true;
									DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
									dataRow["Name"] = text;
									dataRow["Type"] = o0_O.o0O.o_.;
									dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
									O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
								}
							}
							if (o0OoOOoOOo0.oOOo_O._o0.)
							{
								o0OoOOoOOo0.oOOo_O._o0. = false;
								flag = true;
								foreach (DataRow dataRow2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Select("[Type] = " + Conversions.ToString(233) + " Or [Type] = " + Conversions.ToString(229)))
								{
									if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
									{
										dataRow2["Key"],
										o0_O.o0O.o_.
									}) == null)
									{
										DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
										dataRow["Name"] = RuntimeHelpers.GetObjectValue(dataRow2["Key"]);
										dataRow["Type"] = o0_O.o0O.o_.;
										dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
										O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
									}
								}
							}
							if (flag)
							{
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false);
							}
							if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
							{
								System.Data.DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
								string text2 = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(12, 16);
								DataRow dataRow3 = dataTable.Rows.Find(new object[]
								{
									"Logons",
									o0_O.OoOOO_._OoO.
								});
								string text3 = text2;
								if (dataRow3 == null)
								{
									dataRow3 = dataTable.NewRow();
									dataRow3["Name"] = "Logons";
									dataRow3["Type"] = o0_O.OoOOO_._OoO.;
									dataRow3["Config"] = "";
									dataTable.Rows.Add(dataRow3);
								}
								else
								{
									text3 = O00.oO_.0o_oo_0O_.(dataRow3["Config"].ToString(), "log", "log");
									string[] array4 = text3.ToString().Split(new char[]
									{
										','
									});
									if (array4.Length > 14)
									{
										string str = array4[array4.Length - 14];
										int num = array4.Length - 13;
										int num2 = array4.Length - 1;
										for (int k = num; k <= num2; k++)
										{
											str = str + "," + array4[k];
										}
										text3 = str + "," + text2;
									}
									else
									{
										text3 = text3 + "," + text2;
									}
								}
								dataRow3["Config"] = O00.ooo000o_0.00o0.(text3, "log", "log");
								Oo00.O0Oo_O.0O_0O.(dataRow3);
							}
							if (!Main.OO_O.o..IsDisposed)
							{
								try
								{
									foreach (Foxtable.Table table in OO_00oOO.Tables)
									{
										if (table.oo.o_ooO. && Operators.CompareString(table.o.Ooo__., "", true) > 0)
										{
											table.OpenLoadTree();
										}
										if (table.o0o0oOOo0__.o. && Operators.CompareString(table.O00.o_0OO__., "", true) > 0)
										{
											table.OpenFilterTree();
										}
										if (table.Oo.Oo0OoOOoo_.)
										{
											int num3 = 0;
											if (Operators.CompareString(table.ooo_O0oOo.0O., "", true) > 0)
											{
												foreach (string text4 in table.ooo_O0oOo.0O..Split(new char[]
												{
													','
												}))
												{
													if (table.Cols.Contains(text4) && table.Cols[text4].IsNumeric())
													{
														table.Cols[text4].GrandTotal = true;
														num3++;
													}
												}
											}
											if (num3 > 0)
											{
												table.GrandTotal = true;
											}
										}
									}
								}
								finally
								{
									IEnumerator<Foxtable.Table> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
								Main.OO_O.o..OO_O_0Oo.___o.().Refresh();
								try
								{
									foreach (Foxtable.Table table2 in OO_00oOO.Tables)
									{
										if (table2.foxGrid.CanFocus)
										{
											table2.foxGrid.Refresh();
										}
									}
								}
								finally
								{
									IEnumerator<Foxtable.Table> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
								try
								{
									foreach (object obj in System.Windows.Forms.Application.OpenForms)
									{
										System.Windows.Forms.Form form2 = (System.Windows.Forms.Form)obj;
										if (form2 is oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)
										{
											((oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)form2).oo._OoO.().O_OO0.00oo.();
											((oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)form2).oo._OoO.().o00.O0__0.();
										}
									}
								}
								finally
								{
									IEnumerator enumerator5;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
							result = true;
						}
						else
						{
							OO_00oOO.FileWatcher.initialize();
							result = false;
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						System.Windows.Forms.Application.Exit();
					}
					finally
					{
						OO_00oOO.SystemReady = true;
						O_O0OO.o0OoO00OO.00O. = O_O0OO.OoO_o.oO0o0O.();
						Main.ProcessForm.Close();
					}
				}
			}
			return result;
		}

		/// <summary>
		/// 设置项目属性
		/// </summary>
		// Token: 0x06005A8D RID: 23181 RVA: 0x00267EE0 File Offset: 0x002660E0
		[oO0oooo("0008")]
		public static void ModifyProperty()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.())
			{
				o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.OOO._oOooO.);
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().SelectedIndex = 0;
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 压缩项目
		/// </summary>
		/// <param name="ShowMessage">逻辑型，压缩完成后是否提示用户，默认为True</param>
		// Token: 0x06005A8E RID: 23182 RVA: 0x00267F08 File Offset: 0x00266108
		[oO0oooo("0006")]
		public static void Compact(bool ShowMessage = true)
		{
			Oo00.oO.OO.();
			if (OO_00oOO.CompactAccessFile(OO_00oOO.ProjectFile, O_O0OO.oO_00Ooo___0._., true) && ShowMessage)
			{
				MessageBox.Show("压缩完成，建议定期执行此命令！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// 备份项目
		/// </summary>
		/// <param name="Path">字符型，指定备份文件存储目录</param>
		/// <param name="Auto">逻辑型，是否自动备份</param>
		// Token: 0x06005A8F RID: 23183 RVA: 0x00267F38 File Offset: 0x00266138
		[oO0oooo("0005")]
		public static void Backup(string Path = "", bool Auto = false)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string text;
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				text = Strings.Format(DateTime.Now, "yyyyMMddHHmm") + ".zip";
			}
			else
			{
				text = Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmm") + ".zip";
			}
			if (Operators.CompareString(Path, "", true) == 0)
			{
				if (Operators.CompareString(O_O0OO.O0_00o.o0__o..BackupPath, "", true) == 0)
				{
					Path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Foxtable_backup";
				}
				else
				{
					Path = O_O0OO.O0_00o.o0__o..BackupPath;
				}
			}
			if (!OO_00oOO.FileSys.FileExists(Path))
			{
				OO_00oOO.FileSys.CreateDirectory(Path);
			}
			if (!Auto)
			{
				saveFileDialog.FileName = text;
				saveFileDialog.InitialDirectory = Path;
				saveFileDialog.Filter = "Zip 文件(*.Zip)|*.Zip";
				saveFileDialog.OverwritePrompt = true;
				saveFileDialog.CheckPathExists = true;
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				text = saveFileDialog.FileName;
			}
			else
			{
				text = Path.Trim(new char[]
				{
					'\\'
				}) + "\\" + text;
			}
			if (Operators.CompareString(OO_00oOO.FileSys.GetParentPath(text), OO_00oOO.FileSys.GetParentPath(OO_00oOO.ProjectFile), true) == 0)
			{
				MessageBox.Show("备份文件不能和管理项目处于同一文件夹下！", "备份失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			C1ZipFile c1ZipFile = new C1ZipFile(text, true);
			c1ZipFile.Entries.Add(OO_00oOO.ProjectFile);
			if (O_O0OO.O0_00o.o0__o..IncludeAttatchMents)
			{
				if (c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "Images\\"))
				{
					try
					{
						foreach (string text2 in OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Images", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[0]))
						{
							c1ZipFile.Entries.Add(text2, text2.Substring(OO_00oOO.ProjectPath.Length));
						}
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "Attachments\\"))
				{
					try
					{
						foreach (string text3 in OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Attachments", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[0]))
						{
							c1ZipFile.Entries.Add(text3, text3.Substring(OO_00oOO.ProjectPath.Length));
						}
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
			c1ZipFile.Close();
			O_O0OO.O0_00o.o0__o..LastBackUpdate = DateTime.Today;
			O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
		}

		/// <summary>
		/// 保存项目
		/// </summary>
		// Token: 0x06005A90 RID: 23184 RVA: 0x00268208 File Offset: 0x00266408
		public static void Save()
		{
			Main.OO_O.o..O0__O.OOOO.();
			O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				Project.SaveAs();
				return;
			}
			OO_00oOO.DataTables.Save();
		}

		/// <summary>
		/// 另存为
		/// </summary>
		// Token: 0x06005A91 RID: 23185 RVA: 0x00268243 File Offset: 0x00266443
		public static void SaveAs()
		{
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				O_O0OO.O0_00o.o0__o..O_O_.o.(false, true);
			}
			new O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002().ShowDialog();
			Main.O0O_.00_O0Oo_.();
		}

		/// <summary>
		/// 关闭项目
		/// </summary>
		// Token: 0x06005A92 RID: 23186 RVA: 0x00268274 File Offset: 0x00266474
		public static void Exit()
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
				Main.OO_O.o..Close();
				IL_13:
				goto IL_6E;
				IL_15:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2F:
				goto IL_63;
				IL_31:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_41:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_31;
			}
			IL_63:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 关闭项目
		/// </summary>
		/// <param name="blnSave">逻辑型，关闭前是否先保存</param>
		// Token: 0x06005A93 RID: 23187 RVA: 0x00268308 File Offset: 0x00266508
		public static void Exit(bool blnSave)
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
				if (!blnSave)
				{
					goto IL_28;
				}
				IL_0C:
				num2 = 3;
				if (!OO_00oOO.DataTables.Save())
				{
					goto IL_86;
				}
				IL_1A:
				num2 = 4;
				Main.OO_O.o..Close();
				goto IL_86;
				IL_28:
				num2 = 6;
				O_O0OO.OOOo.oo_OOOO_0.().RejectChanges();
				IL_34:
				num2 = 7;
				O_O0OO.OoO.0OO__0ooo.().RejectChanges();
				IL_40:
				num2 = 8;
				IEnumerator<Foxtable.Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Foxtable.Table table = enumerator.Current;
					IL_57:
					num2 = 9;
					table.NeedSaveSetting = false;
					IL_62:
					num2 = 10;
				}
				IL_6D:
				num2 = 11;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_79:
				num2 = 12;
				Main.OO_O.o..Close();
				IL_86:
				goto IL_10C;
				IL_8B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_CD:
				goto IL_101;
				IL_CF:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_DF:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_CF;
			}
			IL_101:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_10C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开菜单设计器
		/// </summary>
		// Token: 0x06005A94 RID: 23188 RVA: 0x0026843C File Offset: 0x0026663C
		public static void DesignRibbonMenu()
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
				if (O_O0OO.o0OoO00OO.00O. == null)
				{
					goto IL_26;
				}
				IL_10:
				num2 = 3;
				O_O0OO.o0OoO00OO.00O..oOooOoOo._0Oo.().PerformClick();
				goto IL_542;
				IL_26:
				num2 = 5;
				if (!ooO.oo__.O000_o_O.())
				{
					goto IL_542;
				}
				IL_32:
				num2 = 7;
				Ribbon ribbon = new Ribbon(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()]);
				IL_4E:
				num2 = 8;
				if (Operators.CompareString(ribbon.Developer, "", true) <= 0 || OO_00oOO.User.Type == UserTypeEnum.Developer || Operators.CompareString(OO_00oOO.User.Name, ribbon.Developer, true) == 0)
				{
					goto IL_B3;
				}
				IL_88:
				num2 = 9;
				MessageBox.Show("菜单的责任设计者为\"" + ribbon.Developer + "\", 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_542;
				IL_B3:
				num2 = 11;
				string text = "";
				IL_BD:
				num2 = 12;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"RibbonMenu",
					o0_O.o0O.o_.
				});
				IL_FB:
				num2 = 13;
				if (dataRow != null)
				{
					goto IL_1C3;
				}
				IL_105:
				num2 = 14;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_123:
				num2 = 15;
				dataRow["Name"] = "RibbonMenu";
				IL_137:
				num2 = 16;
				dataRow["Type"] = o0_O.o0O.o_.;
				IL_150:
				num2 = 17;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_174:
				num2 = 18;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_197:
				num2 = 19;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_1B4:
				num2 = 20;
				text = "";
				goto IL_4B2;
				IL_1C3:
				num2 = 22;
				OleDbCommand oleDbCommand = new OleDbCommand("Select [Config] From [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Name] = 'RibbonMenu' And [Type] =" + Conversions.ToString(129), O_O0OO.OoO.0OO__0ooo.());
				IL_1F0:
				num2 = 23;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_1FD:
				num2 = 24;
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_20E:
				num2 = 25;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_21B:
				num2 = 26;
				text = dataRow["Config"].ToString();
				IL_231:
				num2 = 27;
				if (!text.StartsWith("(") || !text.EndsWith(")"))
				{
					goto IL_25A;
				}
				IL_250:
				num2 = 28;
				text = "";
				IL_25A:
				num2 = 29;
				if (objectValue == null)
				{
					goto IL_471;
				}
				IL_264:
				num2 = 30;
				string text2 = objectValue.ToString();
				IL_270:
				num2 = 31;
				if (!text2.StartsWith("(") || !text2.EndsWith(")"))
				{
					goto IL_2B3;
				}
				IL_28F:
				num2 = 32;
				o\u3000\u3002\u3000\u3000\u3002 o_u3000_u3002_u3000_u3000_u = new o\u3000\u3002\u3000\u3000\u3002("菜单");
				IL_29E:
				num2 = 33;
				if (o_u3000_u3002_u3000_u3000_u.ShowDialog() == DialogResult.OK)
				{
					goto IL_3AE;
				}
				goto IL_542;
				IL_2B3:
				num2 = 37;
				if (Operators.CompareString(text2, dataRow["Config"].ToString(), true) == 0)
				{
					goto IL_3AE;
				}
				IL_2D4:
				num2 = 38;
				if (MessageBox.Show("已经有其他用户设计了菜单，需要重新加载菜单数据，才能设计菜单！\r\n\r\n确定要重新加载菜单数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
				{
					goto IL_542;
				}
				IL_2EF:
				num2 = 40;
				O_O0OO.OoO.0OO__0ooo.().EnforceConstraints = false;
				IL_2FD:
				num2 = 41;
				OleDbDataAdapter oleDbDataAdapter = (OleDbDataAdapter)O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()].ExtendedProperties["DataAdapter"];
				IL_32A:
				num2 = 42;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()].Rows.Clear();
				IL_34B:
				num2 = 43;
				oleDbDataAdapter.Fill(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()]);
				IL_36A:
				num2 = 44;
				O_O0OO.OoO.0OO__0ooo.().EnforceConstraints = true;
				IL_378:
				num2 = 45;
				MessageBox.Show("菜单数据已经重新加载!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_38E:
				num2 = 46;
				dataRow["Config"] = text2;
				IL_39F:
				num2 = 47;
				dataRow.AcceptChanges();
				goto IL_542;
				IL_3AE:
				num2 = 49;
				string text3 = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_3C8:
				num2 = 50;
				OleDbCommand oleDbCommand2 = new OleDbCommand(string.Concat(new string[]
				{
					"Update [",
					ooO0__OO.OOo0._00O_o00.(),
					"] Set [Config] = '",
					text3,
					"' Where [Name] = 'RibbonMenu' And [Type] =",
					Conversions.ToString(129),
					" And [Config]  = '",
					text2,
					"'"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_42A:
				num2 = 51;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_437:
				num2 = 52;
				if (oleDbCommand2.ExecuteNonQuery() != 1)
				{
					goto IL_542;
				}
				IL_447:
				num2 = 53;
				dataRow["Config"] = text3;
				IL_458:
				num2 = 54;
				dataRow.AcceptChanges();
				IL_462:
				num2 = 57;
				O_O0OO.OoO.0OO__0ooo.().Close();
				goto IL_4B2;
				IL_471:
				num2 = 59;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_495:
				num2 = 60;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_4B2:
				num2 = 61;
				o_\u3002\u3002\u3000\u3000\u3002 o__u3002_u3002_u3000_u3000_u = new o_\u3002\u3002\u3000\u3000\u3002();
				IL_4BC:
				num2 = 62;
				o__u3002_u3002_u3000_u3000_u.Owner = Main.OO_O.o.;
				IL_4CB:
				num2 = 63;
				o__u3002_u3002_u3000_u3000_u.O0.o_0.(ribbon);
				IL_4D6:
				num2 = 64;
				o__u3002_u3002_u3000_u3000_u.ShowDialog();
				IL_4E1:
				num2 = 65;
				if (o__u3002_u3002_u3000_u3000_u.oOoo_0O.oo00oO. || Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_510;
				}
				IL_4FD:
				num2 = 66;
				dataRow["Config"] = text;
				goto IL_525;
				IL_510:
				num2 = 68;
				dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
				IL_525:
				num2 = 69;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_542:
				goto IL_6AC;
				IL_547:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_66D:
				goto IL_6A1;
				IL_66F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_67F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_66F;
			}
			IL_6A1:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6AC:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开数据源管理窗口
		/// </summary>
		// Token: 0x06005A95 RID: 23189 RVA: 0x00268B1C File Offset: 0x00266D1C
		public static void ModifyOuterDataSource()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
				{
					MessageBox.Show("请先保存才能设置外部数据源!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				O\u3000\u3002 o_u3000_u = new O\u3000\u3002();
				o_u3000_u.ShowDialog();
				if (o_u3000_u.o0oo_o_0OOo_.O.)
				{
					MessageBox.Show("必须重新打开项目，对现有数据源的设置才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Project.Open(OO_00oOO.ProjectFile, new string[0]);
				}
			}
		}

		/// <summary>
		/// 导入数据
		/// </summary>
		// Token: 0x06005A96 RID: 23190 RVA: 0x00268B90 File Offset: 0x00266D90
		public static void Import()
		{
			if (ooO.oo__.O000_o_O.())
			{
				O_\u3000\u3000 o__u3000_u = new O_\u3000\u3000("");
				if (o__u3000_u.Ooo000_OO00.o.())
				{
					o__u3000_u.oO0O.OO_.();
					o__u3000_u.ShowDialog();
				}
			}
		}

		/// <summary>
		/// 从XML文件导入数据
		/// </summary>
		// Token: 0x06005A97 RID: 23191 RVA: 0x00268BC8 File Offset: 0x00266DC8
		public static void ImportFromXML()
		{
			if (ooO.oo__.O000_o_O.())
			{
				O\u3002\u3002\u3000\u3000 o_u3002_u3002_u3000_u = new O\u3002\u3002\u3000\u3000();
				if (o_u3002_u3002_u3000_u.o0.OO_OOO0oOO.().ShowDialog() == DialogResult.OK)
				{
					o_u3002_u3002_u3000_u.O_o_O.0. = o_u3002_u3002_u3000_u.o0.OO_OOO0oOO.().FileName;
					o_u3002_u3002_u3000_u.Text = o_u3002_u3002_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3002_u3002_u3000_u.O_o_O.0.);
					o_u3002_u3002_u3000_u.O0O.Oo.();
					o_u3002_u3002_u3000_u.ShowDialog();
				}
			}
		}

		/// <summary>
		/// 从文本文件导入数据
		/// </summary>
		// Token: 0x06005A98 RID: 23192 RVA: 0x00268C3C File Offset: 0x00266E3C
		public static void ImportFromText()
		{
			if (ooO.oo__.O000_o_O.())
			{
				o\u3002\u3002\u3000 o_u3002_u3002_u = new o\u3002\u3002\u3000();
				if (o_u3002_u3002_u.o._o0_.().ShowDialog() == DialogResult.OK)
				{
					o_u3002_u3002_u.O_oO.o__0o0. = o_u3002_u3002_u.o._o0_.().FileName;
					o_u3002_u3002_u.oOO0_00.O_O00O.();
					o_u3002_u3002_u.ShowDialog();
				}
			}
		}

		/// <summary>
		/// 快速导入数据
		/// </summary>
		// Token: 0x06005A99 RID: 23193 RVA: 0x00268C84 File Offset: 0x00266E84
		[oO0oooo("0184")]
		public static void QuickImport()
		{
			if (ooO.oo__.O000_o_O.())
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Excel(*.xls,*.xlsx)|*.XLS;*.XLSX|Access(*.mdb,*.accdb)|*.MDB;*.ACCDB|dBASE(*.dbf)|*.DBF|Text(*.txt)|*.TXT";
				int count = OO_00oOO.Tables.Count;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					new O\u3000\u3000\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3000(openFileDialog.FileName).ShowDialog();
					if (OO_00oOO.Tables.Count > count)
					{
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
					}
				}
			}
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00268D00 File Offset: 0x00266F00
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Export()
		{
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00268D02 File Offset: 0x00266F02
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ExportToAccess()
		{
		}

		/// <summary>
		/// 导出为Excel
		/// </summary>
		// Token: 0x06005A9C RID: 23196 RVA: 0x00268D04 File Offset: 0x00266F04
		[oO0oooo("0179")]
		public static void ExportToExcel()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel 2003文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				new O\u3002\u3002\u3000\u3002\u3002\u3000\u3000_(saveFileDialog.FileName).ShowDialog();
			}
		}

		/// <summary>
		/// 快速导出
		/// </summary>
		// Token: 0x06005A9D RID: 23197 RVA: 0x00268D3C File Offset: 0x00266F3C
		[oO0oooo("0182")]
		public static void QuickExport()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.OverwritePrompt = false;
			saveFileDialog.FileOk += Project.Oo_.0OO0O_o.;
			saveFileDialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx|Access 文件(*.mdb)|*.mdb|Access 2007文件(*.accdb)|*.accdb|dBASE文件(*.dbf)|*.dbf|Text(*.txt)|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				new O\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3000(saveFileDialog.FileName).ShowDialog();
			}
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x00268D90 File Offset: 0x00266F90
		private static void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			SaveFileDialog saveFileDialog = (SaveFileDialog)A_0;
			string extension = Path.GetExtension(saveFileDialog.FileName);
			if ((Operators.CompareString(extension, ".dbf", true) == 0 || Operators.CompareString(extension, ".txt", true) == 0) && c.OOOOO.o.().FileSystem.FileExists(saveFileDialog.FileName) && MessageBox.Show(saveFileDialog.FileName + "已经存在，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				A_1.Cancel = true;
			}
		}

		/// <summary>
		/// 打开用户管理窗口
		/// </summary>
		// Token: 0x06005A9F RID: 23199 RVA: 0x00268E0A File Offset: 0x0026700A
		public static void Users()
		{
			new o\u3002\u3000\u3002_().ShowDialog();
		}

		/// <summary>
		/// 打开用户登录窗口
		/// </summary>
		// Token: 0x06005AA0 RID: 23200 RVA: 0x00268E18 File Offset: 0x00267018
		[oO0oooo("0607")]
		public static void SwitchUser()
		{
			System.Data.DataTable a_ = O_O0OO.OoO_o.oO0o0O.();
			O\u3002\u3002\u3002\u3002\u3002\u3000\u3002 o_u3002_u3002_u3002_u3002_u3002_u3000_u = new O\u3002\u3002\u3002\u3002\u3002\u3000\u3002(a_, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], OO_00oOO.FileSys.GetParentPath(OO_00oOO.ProjectFile), O_O0OO.O0_00o.o0__o..OoOO.O0OoOoOO0.);
			if (o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Tag == null)
			{
				o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Text = O_O0OO.O0_00o.o0__o..LogTip;
			}
			o_u3002_u3002_u3002_u3002_u3002_u3000_u.o0O.OO00OOOO_0. = true;
			if (o_u3002_u3002_u3002_u3002_u3002_u3000_u.ShowDialog() == DialogResult.OK)
			{
				OO_00oOO.O0o_00Oo0.o_o. = o_u3002_u3002_u3002_u3002_u3002_u3000_u.OooO.00o.;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "LoadUserSetting", null, false, "项目", true);
				string a_2 = "LoadUserSetting_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, null, false, "菜单", false);
			}
		}

		/// <summary>
		/// 打开命令窗口
		/// </summary>
		// Token: 0x06005AA1 RID: 23201 RVA: 0x00268EE8 File Offset: 0x002670E8
		public static void CommandWindow()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (Project.oOOoOOOo._O. == null || Project.oOOoOOOo._O..IsDisposed)
				{
					Project.oOOoOOOo._O. = new oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000();
					Output.oo.oOoO0. = Project.oOOoOOOo._O.;
				}
				Project.oOOoOOOo._O..Owner = Main.OO_O.o.;
				Project.oOOoOOOo._O..Show();
				Project.oOOoOOOo._O..Activate();
			}
		}

		/// <summary>
		/// 打开执行SQL语句窗口
		/// </summary>
		// Token: 0x06005AA2 RID: 23202 RVA: 0x00268F46 File Offset: 0x00267146
		public static void ExecuteSQL()
		{
			if (ooO.oo__.O000_o_O.())
			{
				new O\u3002o_\u3002\u3002\u3002\u3000\u3002o
				{
					Owner = Main.OO_O.o.
				}.Show();
			}
		}

		/// <summary>
		/// 打开自定义函数管理窗口
		/// </summary>
		// Token: 0x06005AA3 RID: 23203 RVA: 0x00268F64 File Offset: 0x00267164
		[oO0oooo("1486")]
		public static void FunctionManager()
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!ooO.oo__.O000_o_O.())
				{
					goto IL_4C2;
				}
				IL_13:
				num2 = 4;
				string text = "";
				IL_1B:
				num2 = 5;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"UserFunctions",
					o0_O.o0O.o_.
				});
				IL_58:
				num2 = 6;
				if (dataRow != null)
				{
					goto IL_11C;
				}
				IL_61:
				num2 = 7;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_7E:
				num2 = 8;
				dataRow["Name"] = "UserFunctions";
				IL_91:
				num2 = 9;
				dataRow["Type"] = o0_O.o0O.o_.;
				IL_AA:
				num2 = 10;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_CE:
				num2 = 11;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_F1:
				num2 = 12;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_10E:
				num2 = 13;
				text = "";
				goto IL_44E;
				IL_11C:
				num2 = 15;
				OleDbCommand oleDbCommand = new OleDbCommand("Select [Config] From [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Name] = 'UserFunctions' And [Type] =" + Conversions.ToString(129), O_O0OO.OoO.0OO__0ooo.());
				IL_149:
				num2 = 16;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_156:
				num2 = 17;
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_167:
				num2 = 18;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_174:
				num2 = 19;
				text = dataRow["Config"].ToString();
				IL_189:
				num2 = 20;
				if (!text.StartsWith("(") || !text.EndsWith(")"))
				{
					goto IL_1AF;
				}
				IL_1A6:
				num2 = 21;
				text = "";
				IL_1AF:
				num2 = 22;
				if (objectValue == null)
				{
					goto IL_40D;
				}
				IL_1B9:
				num2 = 23;
				string text2 = objectValue.ToString();
				IL_1C5:
				num2 = 24;
				if (!text2.StartsWith("(") || !text2.EndsWith(")"))
				{
					goto IL_208;
				}
				IL_1E4:
				num2 = 25;
				o\u3000\u3002\u3000\u3000\u3002 o_u3000_u3002_u3000_u3000_u = new o\u3000\u3002\u3000\u3000\u3002("内部函数");
				IL_1F3:
				num2 = 26;
				if (o_u3000_u3002_u3000_u3000_u.ShowDialog() == DialogResult.OK)
				{
					goto IL_34A;
				}
				goto IL_4C2;
				IL_208:
				num2 = 30;
				if (Operators.CompareString(text2, dataRow["Config"].ToString(), true) == 0)
				{
					goto IL_34A;
				}
				IL_229:
				num2 = 31;
				DataRow[] array = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(9), "", DataViewRowState.CurrentRows);
				IL_25F:
				num2 = 32;
				foreach (DataRow row in array)
				{
					IL_272:
					num2 = 33;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Remove(row);
					IL_295:
					num2 = 34;
				}
				IL_2A6:
				num2 = 35;
				System.Data.DataTable dataTable = new System.Data.DataTable();
				IL_2B0:
				num2 = 36;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Type]  = " + Conversions.ToString(9), O_O0OO.OoO.0OO__0ooo.());
				IL_2DA:
				num2 = 37;
				oleDbDataAdapter.Fill(dataTable);
				IL_2E7:
				num2 = 38;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow row2 = (DataRow)obj;
					IL_308:
					num2 = 39;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].ImportRow(row2);
					IL_326:
					num2 = 40;
				}
				IL_332:
				num2 = 41;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_34A:
				num2 = 42;
				string text3 = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_364:
				num2 = 43;
				OleDbCommand oleDbCommand2 = new OleDbCommand(string.Concat(new string[]
				{
					"Update [",
					ooO0__OO.OOo0._00O_o00.(),
					"] Set [Config] = '",
					text3,
					"' Where [Name] = 'UserFunctions' And [Type] =",
					Conversions.ToString(129),
					" And [Config]  = '",
					text2,
					"'"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_3C6:
				num2 = 44;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_3D3:
				num2 = 45;
				if (oleDbCommand2.ExecuteNonQuery() != 1)
				{
					goto IL_4C2;
				}
				IL_3E3:
				num2 = 46;
				dataRow["Config"] = text3;
				IL_3F4:
				num2 = 47;
				dataRow.AcceptChanges();
				IL_3FE:
				num2 = 50;
				O_O0OO.OoO.0OO__0ooo.().Close();
				goto IL_44E;
				IL_40D:
				num2 = 52;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_431:
				num2 = 53;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_44E:
				num2 = 54;
				o0\u3000\u3000\u3000\u3000\u3002\u3002 o0_u3000_u3000_u3000_u3000_u3002_u = new o0\u3000\u3000\u3000\u3000\u3002\u3002();
				IL_458:
				num2 = 55;
				o0_u3000_u3000_u3000_u3000_u3002_u.ShowDialog();
				IL_463:
				num2 = 56;
				if (o0_u3000_u3000_u3000_u3000_u3002_u.Oo__0o0O._. || Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_490;
				}
				IL_47E:
				num2 = 57;
				dataRow["Config"] = text;
				goto IL_4A5;
				IL_490:
				num2 = 59;
				dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
				IL_4A5:
				num2 = 60;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_4C2:
				goto IL_608;
				IL_4C7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5C9:
				goto IL_5FD;
				IL_5CB:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5DB:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_5CB;
			}
			IL_5FD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_608:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x002695A0 File Offset: 0x002677A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Refresh()
		{
			Project.Load();
		}

		/// <summary>
		/// 同步数据
		/// </summary>
		// Token: 0x06005AA5 RID: 23205 RVA: 0x002695A8 File Offset: 0x002677A8
		public static void Load()
		{
			try
			{
				Main.ProcessForm.o0__.Oo0O_O0O_.("开始同步数据，请稍候...");
				Main.ProcessForm.Show();
				System.Windows.Forms.Application.DoEvents();
				O_O0OO.OoO.0OO__0ooo.().Open();
				try
				{
					foreach (OleDbConnection oleDbConnection in O_O0OO.O._o_.().Values)
					{
						oleDbConnection.Open();
					}
				}
				finally
				{
					Dictionary<string, OleDbConnection>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				OO_00oOO.SystemReady = false;
				ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
				try
				{
					foreach (Foxtable.DataTable dataTable in OO_00oOO.DataTables)
					{
						Main.ProcessForm.o0__.Oo0O_O0O_.("正在同步" + dataTable.Name + "，请稍候...");
						System.Windows.Forms.Application.DoEvents();
						dataTable.o0.o.(true, null);
					}
				}
				finally
				{
					IEnumerator<Foxtable.DataTable> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				OO_00oOO.SystemReady = true;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				System.Windows.Forms.Application.Exit();
			}
			finally
			{
				O_O0OO.OoO.0OO__0ooo.().Close();
				try
				{
					foreach (OleDbConnection oleDbConnection2 in O_O0OO.O._o_.().Values)
					{
						oleDbConnection2.Close();
					}
				}
				finally
				{
					Dictionary<string, OleDbConnection>.ValueCollection.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				OO_00oOO.SystemReady = true;
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				Main.ProcessForm.Close();
			}
		}

		/// <summary>
		/// 打开计划管理窗口
		/// </summary>
		// Token: 0x06005AA6 RID: 23206 RVA: 0x00269744 File Offset: 0x00267944
		[oO0oooo("0657")]
		public static void EditMyTimers()
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!ooO.oo__.O000_o_O.())
				{
					goto IL_4CE;
				}
				IL_13:
				num2 = 4;
				if (!Project.o__oOo_0___.O.())
				{
					goto IL_4CE;
				}
				IL_1F:
				num2 = 6;
				string text = "";
				IL_27:
				num2 = 7;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"Timers",
					o0_O.o0O.o_.
				});
				IL_64:
				num2 = 8;
				if (dataRow != null)
				{
					goto IL_12A;
				}
				IL_6D:
				num2 = 9;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_8B:
				num2 = 10;
				dataRow["Name"] = "Timers";
				IL_9F:
				num2 = 11;
				dataRow["Type"] = o0_O.o0O.o_.;
				IL_B8:
				num2 = 12;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_DC:
				num2 = 13;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_FF:
				num2 = 14;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_11C:
				num2 = 15;
				text = "";
				goto IL_45A;
				IL_12A:
				num2 = 17;
				OleDbCommand oleDbCommand = new OleDbCommand("Select [Config] From [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Name] = 'Timers' And [Type] =" + Conversions.ToString(129), O_O0OO.OoO.0OO__0ooo.());
				IL_157:
				num2 = 18;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_164:
				num2 = 19;
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_175:
				num2 = 20;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_182:
				num2 = 21;
				text = dataRow["Config"].ToString();
				IL_197:
				num2 = 22;
				if (!text.StartsWith("(") || !text.EndsWith(")"))
				{
					goto IL_1BD;
				}
				IL_1B4:
				num2 = 23;
				text = "";
				IL_1BD:
				num2 = 24;
				if (objectValue == null)
				{
					goto IL_419;
				}
				IL_1C7:
				num2 = 25;
				string text2 = objectValue.ToString();
				IL_1D3:
				num2 = 26;
				if (!text2.StartsWith("(") || !text2.EndsWith(")"))
				{
					goto IL_216;
				}
				IL_1F2:
				num2 = 27;
				o\u3000\u3002\u3000\u3000\u3002 o_u3000_u3002_u3000_u3000_u = new o\u3000\u3002\u3000\u3000\u3002("计划");
				IL_201:
				num2 = 28;
				if (o_u3000_u3002_u3000_u3000_u.ShowDialog() == DialogResult.OK)
				{
					goto IL_356;
				}
				goto IL_4CE;
				IL_216:
				num2 = 32;
				if (Operators.CompareString(text2, dataRow["Config"].ToString(), true) == 0)
				{
					goto IL_356;
				}
				IL_237:
				num2 = 33;
				DataRow[] array = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(3), "", DataViewRowState.CurrentRows);
				IL_26C:
				num2 = 34;
				foreach (DataRow row in array)
				{
					IL_27F:
					num2 = 35;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Remove(row);
					IL_2A2:
					num2 = 36;
				}
				IL_2B3:
				num2 = 37;
				System.Data.DataTable dataTable = new System.Data.DataTable();
				IL_2BD:
				num2 = 38;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Type]  = " + Conversions.ToString(3), O_O0OO.OoO.0OO__0ooo.());
				IL_2E6:
				num2 = 39;
				oleDbDataAdapter.Fill(dataTable);
				IL_2F3:
				num2 = 40;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow row2 = (DataRow)obj;
					IL_314:
					num2 = 41;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].ImportRow(row2);
					IL_332:
					num2 = 42;
				}
				IL_33E:
				num2 = 43;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_356:
				num2 = 44;
				string text3 = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_370:
				num2 = 45;
				OleDbCommand oleDbCommand2 = new OleDbCommand(string.Concat(new string[]
				{
					"Update [",
					ooO0__OO.OOo0._00O_o00.(),
					"] Set [Config] = '",
					text3,
					"' Where [Name] = 'Timers' And [Type] =",
					Conversions.ToString(129),
					" And [Config]  = '",
					text2,
					"'"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_3D2:
				num2 = 46;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_3DF:
				num2 = 47;
				if (oleDbCommand2.ExecuteNonQuery() != 1)
				{
					goto IL_4CE;
				}
				IL_3EF:
				num2 = 48;
				dataRow["Config"] = text3;
				IL_400:
				num2 = 49;
				dataRow.AcceptChanges();
				IL_40A:
				num2 = 52;
				O_O0OO.OoO.0OO__0ooo.().Close();
				goto IL_45A;
				IL_419:
				num2 = 54;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_43D:
				num2 = 55;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_45A:
				num2 = 56;
				O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u = new O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000();
				IL_464:
				num2 = 57;
				o_u3000_u3000_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u.ShowDialog();
				IL_46F:
				num2 = 58;
				if (o_u3000_u3000_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u.o_0Oo.0o00_O. || Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_49C;
				}
				IL_48A:
				num2 = 59;
				dataRow["Config"] = text;
				goto IL_4B1;
				IL_49C:
				num2 = 61;
				dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
				IL_4B1:
				num2 = 62;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_4CE:
				goto IL_61C;
				IL_4D3:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5DD:
				goto IL_611;
				IL_5DF:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5EF:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_5DF;
			}
			IL_611:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_61C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开项目初始化窗口
		/// </summary>
		// Token: 0x06005AA7 RID: 23207 RVA: 0x00269D94 File Offset: 0x00267F94
		[oO0oooo("0007")]
		public static void Initialize()
		{
			if (Operators.CompareString(O_O0OO.o0OoO00OO.00O., OO_00oOO.ProjectFile, true) == 0)
			{
				MessageBox.Show("这是一个未保存的临时文件，无需初始化!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Oo00.OO_O_0O0OO0_.o.() && new oo\u3000\u3000\u3000\u3002().ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("初始化结束，将重新打开项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Project.Open(OO_00oOO.ProjectFile, new string[0]);
			}
		}

		/// <summary>
		/// 打开窗口管理器
		/// </summary>
		// Token: 0x06005AA8 RID: 23208 RVA: 0x00269E00 File Offset: 0x00268000
		[oO0oooo("0698")]
		public static void FormDesigner()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (OO_00oOO.MainTable.DataTable.AddByCode)
				{
					MessageBox.Show("不能在临时表中设计窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				new g1
				{
					Owner = Main.OO_O.o.
				}.ShowDialog(Main.OO_O.o.);
			}
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00269E54 File Offset: 0x00268054
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void MainFormDesigner()
		{
			Project.FormDesigner();
		}

		/// <summary>
		/// 打开项目信息设置窗口
		/// </summary>
		// Token: 0x06005AAA RID: 23210 RVA: 0x00269E5C File Offset: 0x0026805C
		[oO0oooo("1510")]
		public static void ModiProjectInfo()
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
				if (!ooO.oo__.O000_o_O.())
				{
					goto IL_649;
				}
				IL_13:
				num2 = 4;
				ProjectInfo projectInfo = new ProjectInfo();
				IL_1B:
				num2 = 5;
				o_\u3000\u3000\u3000 o__u3000_u3000_u = new o_\u3000\u3000\u3000();
				IL_24:
				num2 = 6;
				DataRow dataRow = null;
				IL_29:
				num2 = 7;
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"ProjectInfo",
					o0_O.o0o0OOO00.0O_.
				});
				IL_63:
				num2 = 8;
				if (dataRow2 == null)
				{
					goto IL_96;
				}
				IL_69:
				num2 = 9;
				if (dataRow2.IsNull("Config"))
				{
					goto IL_96;
				}
				IL_7A:
				num2 = 10;
				o_O_o_oOoo__.OOOO_OO._oo.(projectInfo, dataRow2["Config"].ToString(), '\v');
				IL_96:
				num2 = 11;
				DataRow dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O00.MD5Encrypt(O_O0OO.O_O._Oo.()).Substring(0, 12),
					o0_O.O_o0.0_o0o_.
				});
				IL_DD:
				num2 = 12;
				if (dataRow3 == null)
				{
					goto IL_124;
				}
				IL_E4:
				num2 = 13;
				if (dataRow3.IsNull("Config"))
				{
					goto IL_124;
				}
				IL_F5:
				num2 = 14;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Value = O00.oO_.0o_oo_0O_.(dataRow3["Config"].ToString(), "fox", "fox");
				IL_124:
				num2 = 15;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().SelectedObject = projectInfo;
				IL_134:
				num2 = 16;
				if (OO_00oOO.User.Type == UserTypeEnum.Developer)
				{
					goto IL_153;
				}
				IL_143:
				num2 = 17;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Enabled = false;
				IL_153:
				num2 = 18;
				string left = o0OO__.OO0oO.o.(1925, 75, false).Trim();
				IL_16A:
				num2 = 19;
				string text = "";
				IL_174:
				num2 = 20;
				string text2 = "";
				IL_17E:
				num2 = 21;
				o0OO__.oOO.o_.(ref text, ref text2);
				IL_18A:
				num2 = 22;
				string text3 = text + text2;
				IL_198:
				num2 = 23;
				text3 = O00.ooo000o_0.00o0.(text3, text2, text);
				IL_1A8:
				num2 = 24;
				text3 = Strings.Left(O00.MD5Encrypt(text3), 75);
				IL_1BB:
				num2 = 25;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible = (Operators.CompareString(left, text3, true) == 0);
				IL_1D7:
				num2 = 26;
				if (Operators.CompareString(left, text3, true) != 0)
				{
					goto IL_2DA;
				}
				IL_1E9:
				num2 = 27;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"foxtable",
					o0_O.Oo00.0.
				});
				IL_227:
				num2 = 28;
				if (dataRow == null)
				{
					goto IL_276;
				}
				IL_22E:
				num2 = 30;
				if (dataRow.IsNull("Config"))
				{
					goto IL_276;
				}
				IL_23F:
				num2 = 31;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible = (Operators.CompareString(dataRow["Config"].ToString(), O00.MD5Encrypt(text + text2), true) == 0);
				IL_276:
				num2 = 32;
				o__u3000_u3000_u.O._0_O0_0oo.().Checked = O_O0OO.O0_00o.o0__o..o0o_oO0_o.O.;
				IL_28F:
				num2 = 33;
				o__u3000_u3000_u.o._0O0ooo0o.().Checked = O_O0OO.O0_00o.o0__o..oOO._0_0Oo.;
				IL_2A8:
				num2 = 34;
				o__u3000_u3000_u.OOo_00Oo.o__o.().Checked = O_O0OO.O0_00o.o0__o..oOO0_o_._ooO.;
				IL_2C1:
				num2 = 35;
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Checked = O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o.;
				IL_2DA:
				num2 = 36;
				if (o__u3000_u3000_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_649;
				}
				IL_2EA:
				num2 = 37;
				if (!o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible)
				{
					goto IL_3A5;
				}
				IL_2FE:
				num2 = 38;
				if (dataRow != null || o__u3000_u3000_u.OOo.O_O.)
				{
					goto IL_37C;
				}
				IL_30E:
				num2 = 39;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_32C:
				num2 = 40;
				dataRow["Name"] = "foxtable";
				IL_340:
				num2 = 41;
				dataRow["Type"] = o0_O.Oo00.0.;
				IL_359:
				num2 = 42;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_37C:
				num2 = 43;
				if (o__u3000_u3000_u.OOo.O_O.)
				{
					goto IL_3A5;
				}
				IL_388:
				num2 = 44;
				dataRow["Config"] = O00.MD5Encrypt(text + text2);
				IL_3A5:
				num2 = 45;
				if (dataRow2 != null)
				{
					goto IL_417;
				}
				IL_3AC:
				num2 = 46;
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_3CA:
				num2 = 47;
				dataRow2["Name"] = "ProjectInfo";
				IL_3DE:
				num2 = 48;
				dataRow2["Type"] = o0_O.o0o0OOO00.0O_.;
				IL_3F4:
				num2 = 49;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow2);
				IL_417:
				num2 = 50;
				dataRow2["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(projectInfo, false, '\v', false);
				IL_430:
				num2 = 51;
				if (dataRow3 != null || o__u3000_u3000_u.OOo.O_O.)
				{
					goto IL_4BA;
				}
				IL_443:
				num2 = 52;
				dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_461:
				num2 = 53;
				dataRow3["Name"] = O00.MD5Encrypt(O_O0OO.O_O._Oo.()).Substring(0, 12);
				IL_482:
				num2 = 54;
				dataRow3["Type"] = o0_O.O_o0.0_o0o_.;
				IL_497:
				num2 = 55;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow3);
				IL_4BA:
				num2 = 56;
				if (o__u3000_u3000_u.OOo.O_O.)
				{
					goto IL_543;
				}
				IL_4C6:
				num2 = 57;
				if (Operators.CompareString(o__u3000_u3000_u.o_oOOO0_o0_.0_.().Text.Trim(), "", true) != 0)
				{
					goto IL_50B;
				}
				IL_4E7:
				num2 = 58;
				dataRow3["Config"] = DBNull.Value;
				IL_4FB:
				num2 = 59;
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = false;
				goto IL_543;
				IL_50B:
				num2 = 61;
				dataRow3["Config"] = O00.ooo000o_0.00o0.(o__u3000_u3000_u.o_oOOO0_o0_.0_.().Text, "fox", "fox");
				IL_535:
				num2 = 62;
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = true;
				IL_543:
				num2 = 63;
				if (o__u3000_u3000_u.OOo.O_O.)
				{
					goto IL_5B5;
				}
				IL_54F:
				num2 = 64;
				O_O0OO.O0_00o.o0__o..o0o_oO0_o.O. = o__u3000_u3000_u.O._0_O0_0oo.().Checked;
				IL_568:
				num2 = 65;
				O_O0OO.O0_00o.o0__o..oOO._0_0Oo. = o__u3000_u3000_u.o._0O0ooo0o.().Checked;
				IL_581:
				num2 = 66;
				O_O0OO.O0_00o.o0__o..oOO0_o_._ooO. = o__u3000_u3000_u.OOo_00Oo.o__o.().Checked;
				IL_59A:
				num2 = 67;
				O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. = o__u3000_u3000_u.o_oOOO0_o0_.0_.().Checked;
				goto IL_61D;
				IL_5B5:
				num2 = 69;
				O_O0OO.O0_00o.o0__o..o0o_oO0_o.O. = false;
				IL_5C3:
				num2 = 70;
				O_O0OO.O0_00o.o0__o..oOO._0_0Oo. = false;
				IL_5D1:
				num2 = 71;
				O_O0OO.O0_00o.o0__o..oOO0_o_._ooO. = false;
				IL_5DF:
				num2 = 72;
				O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. = false;
				IL_5ED:
				num2 = 73;
				if (dataRow3 == null)
				{
					goto IL_5FE;
				}
				IL_5F4:
				num2 = 74;
				dataRow3.Delete();
				IL_5FE:
				num2 = 75;
				if (dataRow == null)
				{
					goto IL_60F;
				}
				IL_605:
				num2 = 76;
				dataRow.Delete();
				IL_60F:
				num2 = 77;
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = false;
				IL_61D:
				num2 = 78;
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				IL_62C:
				num2 = 79;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_649:
				goto IL_7DB;
				IL_64E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_79C:
				goto IL_7D0;
				IL_79E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7AE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_79E;
			}
			IL_7D0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7DB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 显示表标题
		/// </summary>
		// Token: 0x06005AAB RID: 23211 RVA: 0x0026A668 File Offset: 0x00268868
		public static void ShowTableCaption()
		{
			Main.OO_O.o..OO_O_0Oo.___o.().Padding = new System.Drawing.Point(6, 3);
		}

		/// <summary>
		/// 隐藏表标题
		/// </summary>
		// Token: 0x06005AAC RID: 23212 RVA: 0x0026A680 File Offset: 0x00268880
		public static void HideTableCaption()
		{
			Main.OO_O.o..OO_O_0Oo.___o.().Padding = new System.Drawing.Point(-5000, -100);
		}

		/// <summary>
		/// 将所有内部表导出到一个Access文件中
		/// </summary>
		// Token: 0x06005AAD RID: 23213 RVA: 0x0026A69D File Offset: 0x0026889D
		[oO0oooo("2297")]
		public static void ToAccess()
		{
			new O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002().ShowDialog();
		}

		/// <summary>
		/// 重定向
		/// </summary>
		// Token: 0x06005AAE RID: 23214 RVA: 0x0026A6AA File Offset: 0x002688AA
		[oO0oooo("2297")]
		public static void Redirect()
		{
			if (ooO.oo__.O000_o_O.())
			{
				new O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002().ShowDialog();
			}
		}

		/// <summary>
		/// 停止绘制主窗口
		/// </summary>
		// Token: 0x06005AAF RID: 23215 RVA: 0x0026A6BE File Offset: 0x002688BE
		public static void StopRedraw()
		{
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
		}

		/// <summary>
		/// 恢复绘制主窗口
		/// </summary>
		// Token: 0x06005AB0 RID: 23216 RVA: 0x0026A6D0 File Offset: 0x002688D0
		public static void ResumeRedraw()
		{
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
		}

		/// <summary>
		/// 发布项目
		/// </summary>
		// Token: 0x06005AB1 RID: 23217 RVA: 0x0026A6E0 File Offset: 0x002688E0
		[oO0oooo("1540")]
		public static void PublishProject()
		{
			if (O_O0OO.O0_00o.o0__o..oOO._0_0Oo. && !Project.oOOoOOOo._O.())
			{
				MessageBox.Show(O_O0OO.OO0._0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				MessageBox.Show("请先保存才能发布!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				O_O0OO.O0_00o.o0__o..O_O_.o.(false, true);
			}
			if (ooO.oo__.O000_o_O.())
			{
				new Thread(new ThreadStart(Project.O0O0o.Oo0OO_oO.)).Start();
				new O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000().ShowDialog();
			}
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x0026A780 File Offset: 0x00268980
		private static void <<EMPTY_NAME>>()
		{
			o0OO__.OO0oO.o.(2);
		}

		/// <summary>
		/// 打开全局变量管理窗口
		/// </summary>
		// Token: 0x06005AB3 RID: 23219 RVA: 0x0026A789 File Offset: 0x00268989
		[oO0oooo("0325")]
		public static void Variable()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.())
			{
				new gg().ShowDialog();
			}
		}

		/// <summary>
		/// 打开全局代码管理窗口
		/// </summary>
		// Token: 0x06005AB4 RID: 23220 RVA: 0x0026A7A4 File Offset: 0x002689A4
		[oO0oooo("")]
		public static void VBCode()
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!ooO.oo__.O000_o_O.())
				{
					goto IL_582;
				}
				IL_13:
				num2 = 4;
				if (Operators.CompareString(O_O0OO.o0OoO00OO.00O., OO_00oOO.ProjectFile, true) != 0)
				{
					goto IL_41;
				}
				IL_27:
				num2 = 5;
				MessageBox.Show("必须先保存项目，才能设置全局代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_582;
				IL_41:
				num2 = 7;
				if (!Project.o__oOo_0___.O.())
				{
					goto IL_582;
				}
				IL_4D:
				num2 = 9;
				string text = "";
				IL_56:
				num2 = 10;
				bool flag = false;
				IL_5C:
				num2 = 11;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"PublicCode",
					o0_O.o0O.o_.
				});
				IL_9A:
				num2 = 12;
				if (dataRow != null)
				{
					goto IL_161;
				}
				IL_A4:
				num2 = 13;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_C2:
				num2 = 14;
				dataRow["Name"] = "PublicCode";
				IL_D6:
				num2 = 15;
				dataRow["Type"] = o0_O.o0O.o_.;
				IL_EF:
				num2 = 16;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_113:
				num2 = 17;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_136:
				num2 = 18;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_153:
				num2 = 19;
				text = "";
				goto IL_499;
				IL_161:
				num2 = 21;
				OleDbCommand oleDbCommand = new OleDbCommand("Select [Config] From [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Name] = 'PublicCode' And [Type] =" + Conversions.ToString(129), O_O0OO.OoO.0OO__0ooo.());
				IL_18E:
				num2 = 22;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_19B:
				num2 = 23;
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_1AC:
				num2 = 24;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_1B9:
				num2 = 25;
				text = dataRow["Config"].ToString();
				IL_1CE:
				num2 = 26;
				if (!text.StartsWith("(") || !text.EndsWith(")"))
				{
					goto IL_1F4;
				}
				IL_1EB:
				num2 = 27;
				text = "";
				IL_1F4:
				num2 = 28;
				if (objectValue == null)
				{
					goto IL_458;
				}
				IL_1FE:
				num2 = 29;
				string text2 = objectValue.ToString();
				IL_20A:
				num2 = 30;
				if (!text2.StartsWith("(") || !text2.EndsWith(")"))
				{
					goto IL_24D;
				}
				IL_229:
				num2 = 31;
				o\u3000\u3002\u3000\u3000\u3002 o_u3000_u3002_u3000_u3000_u = new o\u3000\u3002\u3000\u3000\u3002("全局代码");
				IL_238:
				num2 = 32;
				if (o_u3000_u3002_u3000_u3000_u.ShowDialog() == DialogResult.OK)
				{
					goto IL_395;
				}
				goto IL_582;
				IL_24D:
				num2 = 36;
				if (Operators.CompareString(text2, dataRow["Config"].ToString(), true) == 0)
				{
					goto IL_395;
				}
				IL_26E:
				num2 = 37;
				DataRow[] array = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(19), "", DataViewRowState.CurrentRows);
				IL_2A4:
				num2 = 38;
				foreach (DataRow row in array)
				{
					IL_2B7:
					num2 = 39;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Remove(row);
					IL_2DA:
					num2 = 40;
				}
				IL_2EB:
				num2 = 41;
				System.Data.DataTable dataTable = new System.Data.DataTable();
				IL_2F5:
				num2 = 42;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from [" + ooO0__OO.OOo0._00O_o00.() + "] Where [Type]  = " + Conversions.ToString(19), O_O0OO.OoO.0OO__0ooo.());
				IL_31F:
				num2 = 43;
				oleDbDataAdapter.Fill(dataTable);
				IL_32C:
				num2 = 44;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow row2 = (DataRow)obj;
					IL_34D:
					num2 = 45;
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].ImportRow(row2);
					IL_36B:
					num2 = 46;
				}
				IL_377:
				num2 = 47;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_38F:
				num2 = 48;
				flag = true;
				IL_395:
				num2 = 49;
				string text3 = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_3AF:
				num2 = 50;
				OleDbCommand oleDbCommand2 = new OleDbCommand(string.Concat(new string[]
				{
					"Update [",
					ooO0__OO.OOo0._00O_o00.(),
					"] Set [Config] = '",
					text3,
					"' Where [Name] = 'PublicCode' And [Type] =",
					Conversions.ToString(129),
					" And [Config]  = '",
					text2,
					"'"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_411:
				num2 = 51;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_41E:
				num2 = 52;
				if (oleDbCommand2.ExecuteNonQuery() != 1)
				{
					goto IL_582;
				}
				IL_42E:
				num2 = 53;
				dataRow["Config"] = text3;
				IL_43F:
				num2 = 54;
				dataRow.AcceptChanges();
				IL_449:
				num2 = 57;
				O_O0OO.OoO.0OO__0ooo.().Close();
				goto IL_499;
				IL_458:
				num2 = 59;
				dataRow["Config"] = "(" + OoOo0O.OO_o.0o_O.(8) + ")";
				IL_47C:
				num2 = 60;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_499:
				num2 = 61;
				O\u3002\u30000 o_u3002_u = new O\u3002\u30000();
				IL_4A3:
				num2 = 62;
				o_u3002_u.ShowDialog();
				IL_4AE:
				num2 = 63;
				if (o_u3002_u.oO0Ooo.00O_. || Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_4DB;
				}
				IL_4C9:
				num2 = 64;
				dataRow["Config"] = text;
				goto IL_4F0;
				IL_4DB:
				num2 = 66;
				dataRow["Config"] = OoOo0O.OO_o.0o_O.(8);
				IL_4F0:
				num2 = 67;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_50D:
				num2 = 68;
				if (!o_u3002_u.oO0Ooo.00O_.)
				{
					goto IL_54A;
				}
				IL_519:
				num2 = 69;
				MessageBox.Show("全局代码编译成功，需要重新打开项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_52F:
				num2 = 70;
				Main.OO_O.o. = true;
				IL_538:
				num2 = 71;
				Project.Save();
				IL_540:
				num2 = 72;
				Project.Exit();
				goto IL_582;
				IL_54A:
				num2 = 74;
				if (!flag)
				{
					goto IL_582;
				}
				IL_551:
				num2 = 75;
				if (MessageBox.Show("其他用户已经修改过全局代码，需要重新打开项目才能生效!\r\n\r\n是否重新打开项目!", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					goto IL_582;
				}
				IL_569:
				num2 = 76;
				Main.OO_O.o. = true;
				IL_572:
				num2 = 77;
				Project.Save();
				IL_57A:
				num2 = 78;
				Project.Exit();
				IL_582:
				goto IL_710;
				IL_587:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_6D1:
				goto IL_705;
				IL_6D3:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6E3:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_6D3;
			}
			IL_705:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_710:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开外部引用管理窗口
		/// </summary>
		// Token: 0x06005AB5 RID: 23221 RVA: 0x0026AEE8 File Offset: 0x002690E8
		[oO0oooo("1936")]
		public static void Refrence()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.() && new oo\u3002\u3000\u3002\u3000\u3002(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()]).ShowDialog() == DialogResult.OK)
			{
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
			}
		}

		/// <summary>
		/// 打开报表事件窗口
		/// </summary>
		// Token: 0x06005AB6 RID: 23222 RVA: 0x0026AF40 File Offset: 0x00269140
		[oO0oooo("1953")]
		public static void ExcelVBCode()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.())
			{
				o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.OoOo_.0.);
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.Text = "报表事件";
				C1DockingTab c1DockingTab = o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.();
				c1DockingTab.TabPages[0].TabVisible = false;
				c1DockingTab.TabPages[1].TabVisible = false;
				c1DockingTab.TabPages[2].TabVisible = false;
				c1DockingTab.TabPages[3].TabVisible = true;
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 打开文件监视器窗口
		/// </summary>
		// Token: 0x06005AB7 RID: 23223 RVA: 0x0026AFC4 File Offset: 0x002691C4
		[oO0oooo("1963")]
		public static void SetFileWatcher()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.())
			{
				o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.O0o.oO.);
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.Text = "文件监视器";
				int num = o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages[i].TabVisible = (i == 4 || i == 5);
				}
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 打开设备监视器窗口
		/// </summary>
		// Token: 0x06005AB8 RID: 23224 RVA: 0x0026B038 File Offset: 0x00269238
		public static void SetDeviceWatcher()
		{
			if (ooO.oo__.O000_o_O.() && Project.o__oOo_0___.O.())
			{
				o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.O00.o__O_o000.);
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.Text = "设备监视器";
				int num = o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages[i].TabVisible = (i == 6);
				}
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x0026B0A5 File Offset: 0x002692A5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void SetPortWatcher()
		{
			Project.SetDeviceWatcher();
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x0026B0AC File Offset: 0x002692AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void SetSMSWatcher()
		{
			Project.SetDeviceWatcher();
		}

		/// <summary>
		/// 打开网络监视器窗口
		/// </summary>
		// Token: 0x06005ABB RID: 23227 RVA: 0x0026B0B4 File Offset: 0x002692B4
		public static void SetIMWatcher()
		{
			if (ooO.oo__.O000_o_O.())
			{
				o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.OOOO_0.oO00_o.);
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.Text = "网络监视器";
				int num = o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages[i].TabVisible = (i == 7);
				}
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 输出代码
		/// </summary>
		// Token: 0x06005ABC RID: 23228 RVA: 0x0026B11A File Offset: 0x0026931A
		[oO0oooo("1987")]
		public static void ViewCode()
		{
			if (ooO.oo__.O000_o_O.())
			{
				OO_00oOO.oo0oOO.o.(OO_00oOO.OoOO.O_Oo_0.0., "");
			}
		}

		/// <summary>
		/// 输出结构
		/// </summary>
		// Token: 0x06005ABD RID: 23229 RVA: 0x0026B12E File Offset: 0x0026932E
		public static void ViewStructure()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. && !Project.oOOoOOOo._O.())
				{
					MessageBox.Show(O_O0OO.OO0._0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				OO_00oOO.ExportStructure();
			}
		}

		/// <summary>
		/// 编辑目录树
		/// </summary>
		// Token: 0x06005ABE RID: 23230 RVA: 0x0026B163 File Offset: 0x00269363
		[oO0oooo("2024")]
		public static void EditTree()
		{
			new Oo\u3000\u3000\u3002\u3000\u3002\u3002().ShowDialog(Main.OO_O.o.);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x0026B175 File Offset: 0x00269375
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void QRCode()
		{
		}

		/// <summary>
		/// 批量打印条形码
		/// </summary>
		// Token: 0x06005AC0 RID: 23232 RVA: 0x0026B177 File Offset: 0x00269377
		public static void BarCode()
		{
			new o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002().ShowDialog();
		}

		/// <summary>
		/// 升级
		/// </summary>
		// Token: 0x06005AC1 RID: 23233 RVA: 0x0026B184 File Offset: 0x00269384
		[oO0oooo("2245")]
		public static void Update()
		{
			Project.Update(true, true);
		}

		/// <summary>
		/// 升级
		/// </summary>
		/// <param name="Prom1"> 可选参数，逻辑型，没有发现新版本时，是否提示用户</param>
		/// <param name="Prom2"> 可选参数，逻辑型，发现新版本时，是否提示用户升级</param>
		// Token: 0x06005AC2 RID: 23234 RVA: 0x0026B18E File Offset: 0x0026938E
		public static bool Update(bool Prom1, bool Prom2)
		{
			return Project.Update(Prom1, Prom2, true);
		}

		/// <summary>
		/// 升级
		/// </summary>
		/// <param name="Prom1"> 可选参数，逻辑型，没有发现新版本时，是否提示用户</param>
		/// <param name="Prom2"> 可选参数，逻辑型，发现新版本时，是否提示用户升级</param>
		/// <param name="ShowUI">可选参数，逻辑型型，在现在升级文件的过程中，是否显示进度</param>
		// Token: 0x06005AC3 RID: 23235 RVA: 0x0026B198 File Offset: 0x00269398
		[oO0oooo("2245")]
		public static bool Update(bool Prom1, bool Prom2, bool ShowUI)
		{
			OoOo0O.OO_o.0o_O.(5);
			bool result;
			if (Operators.CompareString(O_O0OO.O0_00o.o0__o..UpdatePath, "", true) == 0)
			{
				MessageBox.Show("未定义在线升级路径!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
				ooO.SetForegroundWindow(Main.OO_O.o..Handle);
				result = false;
			}
			else
			{
				if (O_O0OO.O0_00o.o0__o..RemoteUpdate)
				{
					try
					{
						ShareLibriay.Network.Ping("www.baidu.com");
					}
					catch (Exception ex)
					{
						MessageBox.Show("必须连接互联网才能升级!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
						ooO.SetForegroundWindow(Main.OO_O.o..Handle);
						return false;
					}
				}
				try
				{
					string text = O_O0OO.O0_00o.o0__o..UpdatePath.TrimEnd(new char[]
					{
						'/',
						'\\'
					}) + "/update.txt";
					string text2 = OO_00oOO.ProjectPath + OoOo0O.OO_o.0o_O.(6) + ".txt";
					string text3 = O_O0OO.O0_00o.o0__o..UpdatePath.TrimEnd(new char[]
					{
						'/',
						'\\'
					}) + "/update.zip";
					string text4 = OO_00oOO.ProjectPath + OoOo0O.OO_o.0o_O.(6) + ".zip";
					System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
					if (O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase))
					{
						text = text + "?rndkey=" + OoOo0O.OO_o.0o_O.(6);
						text3 = text3 + "?rndkey=" + OoOo0O.OO_o.0o_O.(6);
					}
					if (!O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) & !O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase))
					{
						text = text.Replace("/", "\\");
						text2 = text;
						text3 = text3.Replace("/", "\\");
						text4 = text3;
					}
					else
					{
						ShareLibriay.Network.DownloadFile(text, text2);
					}
					textBox.Text = OO_00oOO.FileSys.ReadAllText(text2);
					DateTime value;
					if (!DateTime.TryParse(textBox.Lines[0], out value) || DateTime.Compare(value.Date.AddHours((double)value.Hour).AddMinutes((double)value.Minute), O_O0OO.O0_00o.o0__o..PublishDate) <= 0)
					{
						if (Prom1)
						{
							MessageBox.Show("您目前已经是最新的版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
							ooO.SetForegroundWindow(Main.OO_O.o..Handle);
						}
						if (O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) || O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase))
						{
							OO_00oOO.FileSys.DeleteFile(text2);
						}
						return false;
					}
					if (Prom2)
					{
						value = value.Date.AddHours((double)value.Hour).AddMinutes((double)value.Minute);
						if (MessageBox.Show("检测到的最新版本为:" + Conversions.ToString(value) + "，是否现在升级？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.No)
						{
							if (O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) || O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase))
							{
								OO_00oOO.FileSys.DeleteFile(text2);
							}
							ooO.SetForegroundWindow(Main.OO_O.o..Handle);
							return false;
						}
					}
					if (O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) || O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase))
					{
						if (text3.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase))
						{
							if (!Project.oOOoOOOo._O.(text3, text4, ShowUI))
							{
								MessageBox.Show("远程升级包下载失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								ooO.SetForegroundWindow(Main.OO_O.o..Handle);
								return false;
							}
						}
						else
						{
							ShareLibriay.Network.DownloadFile(text3, text4, "", "", ShowUI, 300000, true);
						}
					}
					ZipFile zipFile = new ZipFile();
					zipFile.Open(text4);
					zipFile.ExtractAll(OO_00oOO.ProjectPath);
					zipFile.Close();
					if (O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) || O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase))
					{
						OO_00oOO.FileSys.DeleteFile(text2);
						OO_00oOO.FileSys.DeleteFile(text4);
					}
					MessageBox.Show("在线升级结束，将重新启动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
					Main.OO_O.o. = true;
					OO_00oOO.SystemReady = false;
					Project.Exit(false);
					return true;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "在线升级失败！");
					ooO.SetForegroundWindow(Main.OO_O.o..Handle);
				}
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 打开用户菜单
		/// </summary>
		// Token: 0x06005AC4 RID: 23236 RVA: 0x0026B678 File Offset: 0x00269878
		[oO0oooo("1466")]
		public static void OpenUserMenu()
		{
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
			Main.OO_O.o..o0_o_o_0.0O.(false);
			Main.OO_O.o..OOoO0O_o_o.0_0.();
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
		}

		/// <summary>
		/// 打开系统菜单
		/// </summary>
		// Token: 0x06005AC5 RID: 23237 RVA: 0x0026B6AB File Offset: 0x002698AB
		[oO0oooo("1466")]
		public static void OpenSystemMenu()
		{
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
			Main.OO_O.o..o0_o_o_0.0O.(true);
			Main.OO_O.o..OOoO0O_o_o.0_0.();
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
		}

		/// <summary>
		/// 关于Foxtable
		/// </summary>
		// Token: 0x06005AC6 RID: 23238 RVA: 0x0026B6DE File Offset: 0x002698DE
		public static void Version()
		{
			new O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000().ShowDialog();
		}

		/// <summary>
		/// 检测新版本
		/// </summary>
		// Token: 0x06005AC7 RID: 23239 RVA: 0x0026B6EB File Offset: 0x002698EB
		public static void UpdateFoxTable()
		{
			o0OO__.OO0oO.o.(1);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x0026B6F4 File Offset: 0x002698F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void SetUKey()
		{
			o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002 o_u3000_u3002_u3002O_u3002_u3000_u3000_u3000_u3000_u = new o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002();
			o_u3000_u3002_u3002O_u3002_u3000_u3000_u3000_u3000_u.ShowDialog();
			o_u3000_u3002_u3002O_u3002_u3000_u3000_u3000_u3000_u.Dispose();
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x0026B708 File Offset: 0x00269908
		private static bool <<EMPTY_NAME>>()
		{
			bool result;
			if (OO_00oOO.User.Type == UserTypeEnum.Developer)
			{
				result = true;
			}
			else if (Operators.CompareString(O_O0OO.O0_00o.o0__o..Developer, "", true) > 0 && Operators.CompareString(O_O0OO.O0_00o.o0__o..Developer, OO_00oOO.User.Name, true) != 0)
			{
				MessageBox.Show("此任务的责任设计者为\"" + O_O0OO.O0_00o.o0__o..Developer + "\", 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 新建Excel报表模板
		/// </summary>
		// Token: 0x06005ACA RID: 23242 RVA: 0x0026B788 File Offset: 0x00269988
		public static void NewExcelTemplate()
		{
			if (Project.O_.o__0O.() && Project.Oo_00o.OoO.())
			{
				string text = OO_00oOO.ProjectPath + "Attachments";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Excel文件|*.xls";
				saveFileDialog.InitialDirectory = text;
				saveFileDialog.Title = "新建模版";
				saveFileDialog.FileOk += Project.O0O0o.Oo0OO_oO.;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (OO_00oOO.FileSys.FileExists(saveFileDialog.FileName))
					{
						OO_00oOO.FileSys.DeleteFile(saveFileDialog.FileName);
					}
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "blank.xls", saveFileDialog.FileName);
					new o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000(saveFileDialog.FileName).Show();
				}
			}
		}

		/// <summary>
		/// 打开一个Excel报表模板
		/// </summary>
		// Token: 0x06005ACB RID: 23243 RVA: 0x0026B860 File Offset: 0x00269A60
		public static void OpenExcelTemplate()
		{
			if (Project.O_.o__0O.() && Project.Oo_00o.OoO.())
			{
				string text = OO_00oOO.ProjectPath + "Attachments";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Excel文件|*.xls;*.xlsx";
				openFileDialog.InitialDirectory = text;
				openFileDialog.FileOk += Project.O0O0o.Oo0OO_oO.;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (OO_00oOO.FileSys.FileExists(openFileDialog.FileName) && OO_00oOO.FileIsOpened(openFileDialog.FileName))
					{
						MessageBox.Show("此报表模版已经被其它进程打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					new o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000(openFileDialog.FileName).Show();
				}
			}
		}

		/// <summary>
		/// 新建Word报表模板
		/// </summary>
		// Token: 0x06005ACC RID: 23244 RVA: 0x0026B920 File Offset: 0x00269B20
		public static void NewWordTemplate()
		{
			if (Project.O_.o__0O.() && Project.Oo_.0OO0O_o.())
			{
				string text = OO_00oOO.ProjectPath + "Attachments";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Word文件|*.doc";
				saveFileDialog.Title = "新建模版";
				saveFileDialog.InitialDirectory = text;
				saveFileDialog.FileOk += Project.O0O0o.Oo0OO_oO.;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (OO_00oOO.FileSys.FileExists(saveFileDialog.FileName))
					{
						OO_00oOO.FileSys.DeleteFile(saveFileDialog.FileName);
					}
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "blank.doc", saveFileDialog.FileName);
					new O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002(saveFileDialog.FileName).Show();
				}
			}
		}

		/// <summary>
		/// 打开一个Word报表模板
		/// </summary>
		// Token: 0x06005ACD RID: 23245 RVA: 0x0026B9F8 File Offset: 0x00269BF8
		public static void OpenWordTemplate()
		{
			if (Project.O_.o__0O.() && Project.Oo_.0OO0O_o.())
			{
				string text = OO_00oOO.ProjectPath + "Attachments";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Word文件|*.doc;*.docx";
				openFileDialog.InitialDirectory = text;
				openFileDialog.FileOk += Project.O0O0o.Oo0OO_oO.;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (OO_00oOO.FileSys.FileExists(openFileDialog.FileName) && OO_00oOO.FileIsOpened(openFileDialog.FileName))
					{
						MessageBox.Show("此报表模版已经被其它进程打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					new O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002(openFileDialog.FileName).Show();
				}
			}
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x0026BAB8 File Offset: 0x00269CB8
		internal static bool <<EMPTY_NAME>>()
		{
			try
			{
				foreach (object obj in System.Windows.Forms.Application.OpenForms)
				{
					System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
					if (form is O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002 || form is o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000)
					{
						MessageBox.Show("请先关闭已经打开的报表设计器!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
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
			bool result;
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				MessageBox.Show("必须先保存项目，才能设计报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (o_O_o_oOoo__.OOOO_OO._oo.())
			{
				MessageBox.Show("本机的.NET Framework 2.0版本过低，无法启动报表设计器，建议升级到.NET Framework 2.0 SP2。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				string text = O_O0OO.o.00O_O.() + "downloadnetsp2.htm";
				if (OO_00oOO.FileSys.FileExists(text))
				{
					new Process
					{
						File = text
					}.Start();
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x0026BBB0 File Offset: 0x00269DB0
		private static bool <<EMPTY_NAME>>()
		{
			if (!Project.oOOoOOOo._O.)
			{
				Project.oOOoOOOo._O. = true;
				try
				{
					((Microsoft.Office.Interop.Excel._Application)new Microsoft.Office.Interop.Excel.ApplicationClass()).Quit();
					Project.Oo_.0OO0O_o. = true;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
			bool result;
			if (!Project.Oo_.0OO0O_o.)
			{
				MessageBox.Show("本计算机没有安装Excel或安装不正确，无法启动Excel报表设计器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x0026BC28 File Offset: 0x00269E28
		private static bool <<EMPTY_NAME>>()
		{
			if (!Project.oOOO.ooO0.)
			{
				Project.oOOO.ooO0. = true;
				try
				{
					Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.ApplicationClass();
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					application.Quit(ref objectValue, ref objectValue2, ref objectValue3);
					Project.o_OOo_o.o_oo00. = true;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
			bool result;
			if (!Project.o_OOo_o.o_oo00.)
			{
				MessageBox.Show("本计算机没有安装Word或安装不正确，无法启动Word报表设计器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x0026BCC8 File Offset: 0x00269EC8
		internal static void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			FileDialog fileDialog = (FileDialog)A_0;
			if (Operators.CompareString(OO_00oOO.FileSys.GetParentPath(fileDialog.FileName).Trim(new char[]
			{
				'\\'
			}), OO_00oOO.ProjectPath + "Attachments", true) != 0)
			{
				MessageBox.Show("报表模版必须位于Attachments文件夹中!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
			}
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x0026BD30 File Offset: 0x00269F30
		internal static bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O_O0OO.O_O._Oo.().Substring(0, 12),
					o0_O.O_o0.0_o0o_.
				});
				IL_48:
				num2 = 3;
				if ((dataRow == null || dataRow.IsNull("Config")) && !O_O0OO.O0_00o.o0__o..oO_._Ooo_0.)
				{
					goto IL_147;
				}
				IL_6B:
				num2 = 4;
				o0OO__.OO0oO.o.(1925, 75, false).Trim();
				IL_80:
				num2 = 5;
				string text = "";
				IL_89:
				num2 = 6;
				string text2 = "";
				IL_92:
				num2 = 7;
				o0OO__.oOO.o_.(ref text, ref text2);
				IL_9D:
				num2 = 8;
				string text3 = text + text2;
				IL_AA:
				num2 = 9;
				text3 = O00.ooo000o_0.00o0.(text3, text2, text);
				IL_BA:
				num2 = 10;
				text3 = Strings.Left(O00.MD5Encrypt(text3), 75);
				IL_CD:
				num2 = 11;
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"foxtable",
					o0_O.Oo00.0.
				});
				IL_10B:
				num2 = 12;
				if (dataRow2 == null || Operators.CompareString(dataRow2["Config"].ToString(), O00.MD5Encrypt(text + text2), true) != 0)
				{
					goto IL_140;
				}
				IL_139:
				num2 = 13;
				result = true;
				goto IL_14C;
				IL_140:
				num2 = 14;
				result = false;
				goto IL_14C;
				IL_147:
				num2 = 16;
				result = true;
				IL_14C:
				goto IL_1E2;
				IL_151:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1A3:
				goto IL_1D7;
				IL_1A5:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1B5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1A5;
			}
			IL_1D7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1E2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x0026BF44 File Offset: 0x0026A144
		private static bool <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			Match match = new Regex("^ftp://(.+?:.+?)@(.+?)(/.+)", RegexOptions.IgnoreCase).Match(A_0);
			bool result;
			if (match.Success && match.Groups[0].Success && match.Groups[1].Success && match.Groups[2].Success)
			{
				string[] array = match.Groups[1].Value.Split(new char[]
				{
					':'
				});
				if (array.Length == 2)
				{
					FTPClient ftpclient = new FTPClient();
					string[] array2 = match.Groups[2].Value.Split(new char[]
					{
						':'
					});
					if (array2.Length == 2)
					{
						ftpclient.Host = array2[0];
						ftpclient.Port = Conversions.ToInteger(array2[1]);
					}
					else
					{
						ftpclient.Host = match.Groups[2].Value;
					}
					ftpclient.Account = array[0];
					ftpclient.Password = array[1];
					result = ftpclient.Download(match.Groups[3].Value, A_1, A_2);
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 打开样式设置窗口
		/// </summary>
		// Token: 0x06005AD4 RID: 23252 RVA: 0x0026C072 File Offset: 0x0026A272
		[oO0oooo("3307")]
		public static void Options()
		{
			new o\u3002\u3000\u3000\u3002\u3002\u30020\u3002
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		// Token: 0x0400233D RID: 9021
		private static string <<EMPTY_NAME>>;

		// Token: 0x0400233E RID: 9022
		private static oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

		// Token: 0x0400233F RID: 9023
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04002340 RID: 9024
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04002341 RID: 9025
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04002342 RID: 9026
		private static bool <<EMPTY_NAME>>;
	}
}
