using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D2 RID: 466
	[StandardModule]
	internal sealed class o0___oO
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x0009B2B4 File Offset: 0x000994B4
		internal static void <<EMPTY_NAME>>()
		{
			try
			{
				bool flag = false;
				List<IMClient> list = new List<IMClient>();
				List<UDPClient> list2 = new List<UDPClient>();
				if (OO_00oOO.IMServers.Count > 0)
				{
					try
					{
						foreach (IMServer imserver in OO_00oOO.IMServers.Values)
						{
							if (!imserver.o0oo__0Oo_.o00.)
							{
								if (imserver.ooO_.O0_..Count > 0)
								{
									flag = true;
									o0___oO.O.oOo0O0O.(imserver);
								}
								List<string> list3 = new List<string>();
								object ooO_.O0_. = imserver.ooO_.O0_.;
								lock (ooO_.O0_.)
								{
									try
									{
										foreach (O_0__O_o_O o_0__O_o_O in imserver.ooO_.O0_..Values)
										{
											if (o_0__O_o_O.o_0.Oo_0O0_.())
											{
												list3.Add(o_0__O_o_O.O_OO.o0o_o0.());
											}
										}
									}
									finally
									{
										Dictionary<string, O_0__O_o_O>.ValueCollection.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								try
								{
									foreach (string key in list3)
									{
										O_0__O_o_O o_0__O_o_O2 = imserver.ooO_.O0_.[key];
										if (o_0__O_o_O2.o_0.Oo_0O0_.() == SendTypeEnum.AutoFile)
										{
											AfterSendFileEventArgs afterSendFileEventArgs = new AfterSendFileEventArgs(o_0__O_o_O2.O._O___O., o_0__O_o_O2.OOOo._0., o_0__O_o_O2.oo0_.O00.());
											O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterSendFile", new object[]
											{
												afterSendFileEventArgs
											}, true, "项目", false);
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								object ooO_.O0_.2 = imserver.ooO_.O0_.;
								lock (ooO_.O0_.2)
								{
									try
									{
										foreach (string key2 in list3)
										{
											imserver.ooO_.O0_..Remove(key2);
										}
									}
									finally
									{
										List<string>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
								}
								list3.Clear();
								object ooO_.O0_.3 = imserver.ooO_.O0_.;
								lock (ooO_.O0_.3)
								{
									try
									{
										foreach (ooOoO ooOoO in imserver.ooO_.O0_..Values)
										{
											if (ooOoO.OO.000O.())
											{
												list3.Add(ooOoO.o0OO._0.());
											}
										}
									}
									finally
									{
										Dictionary<string, ooOoO>.ValueCollection.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
								try
								{
									foreach (string key3 in list3)
									{
										ooOoO ooOoO2 = imserver.ooO_.O0_.[key3];
										if (ooOoO2.OO.000O.() == SendTypeEnum.AutoFile)
										{
											AfterReceiveFileEventArgs afterReceiveFileEventArgs = new AfterReceiveFileEventArgs(ooOoO2.OO.000O.(), ooOoO2.o_Oo_o._Oo_o_., ooOoO2.O_OOOooo_0.O.());
											O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterReveiveFile", new object[]
											{
												afterReceiveFileEventArgs
											}, true, "项目", false);
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator6;
									((IDisposable)enumerator6).Dispose();
								}
								object ooO_.O0_.4 = imserver.ooO_.O0_.;
								lock (ooO_.O0_.4)
								{
									try
									{
										foreach (string key4 in list3)
										{
											imserver.ooO_.O0_..Remove(key4);
										}
									}
									finally
									{
										List<string>.Enumerator enumerator7;
										((IDisposable)enumerator7).Dispose();
									}
								}
								list3.Clear();
							}
						}
					}
					finally
					{
						Dictionary<string, IMServer>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (OO_00oOO.IMClients.Count > 0)
				{
					try
					{
						foreach (IMClient imclient in OO_00oOO.IMClients.Values)
						{
							if (!imclient.O0_OOo.O.)
							{
								if (imclient.ooOo.oO0..Count > 0)
								{
									flag = true;
									list.Add(imclient);
								}
								List<string> list4 = new List<string>();
								if (imclient.oo.___oo__0_O..Count > 0)
								{
									try
									{
										foreach (string text in imclient.oo.___oo__0_O..Keys)
										{
											if ((imclient.oo.___oo__0_O.[text] - DateTime.Now).TotalSeconds > 30.0)
											{
												list4.Add(text);
											}
										}
									}
									finally
									{
										Dictionary<string, DateTime>.KeyCollection.Enumerator enumerator9;
										((IDisposable)enumerator9).Dispose();
									}
								}
								try
								{
									foreach (string key5 in list4)
									{
										imclient.oo.___oo__0_O..Remove(key5);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator10;
									((IDisposable)enumerator10).Dispose();
								}
								list4.Clear();
								object ooOooo.oO. = imclient.ooOooo.oO.;
								lock (ooOooo.oO.)
								{
									try
									{
										foreach (O_0__O_o_O o_0__O_o_O3 in imclient.ooOooo.oO..Values)
										{
											if (o_0__O_o_O3.o_0.Oo_0O0_.())
											{
												list4.Add(o_0__O_o_O3.O_OO.o0o_o0.());
												if (o_0__O_o_O3.O00o___0OoO.0. != null && o_0__O_o_O3.O00o___0OoO.0..FindForm() != null)
												{
													((o\u3000\u3002\u3000\u3002\u3000)o_0__O_o_O3.O00o___0OoO.0..FindForm()).oOOOO.O.(o_0__O_o_O3.O00o___0OoO.0.);
													o_0__O_o_O3.O00o___0OoO.0. = null;
												}
												if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.AutoFile)
												{
													string a_ = "";
													if (o_0__O_o_O3.o_0.Oo_0O0_.() != null)
													{
														a_ = o_0__O_o_O3.o_0.Oo_0O0_.().Name;
													}
													AfterSendFileEventArgs afterSendFileEventArgs2 = new AfterSendFileEventArgs(a_, o_0__O_o_O3.OOOo._0., o_0__O_o_O3.oo0_.O00.());
													afterSendFileEventArgs2.ServerFileName = o_0__O_o_O3.o_OoO._.();
													O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterSendFile", new object[]
													{
														afterSendFileEventArgs2
													}, true, "项目", false);
												}
												if ((o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile || (o_0__O_o_O3.o_0.Oo_0O0_.() != null && o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat)) && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
												{
													OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
												}
												if (o_0__O_o_O3.oo0_.O00.())
												{
													if (Operators.CompareString(o_0__O_o_O3.o_OoO._.(), "", true) > 0)
													{
														if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.Capture || o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile || (o_0__O_o_O3.o_0.Oo_0O0_.() != null && o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat))
														{
															string text2 = "";
															if (o_0__O_o_O3.o_0.Oo_0O0_.() is ooo0)
															{
																if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.Capture)
																{
																	text2 = "\u0002=?" + o_0__O_o_O3.o_OoO._.() + "?=";
																}
																else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
																{
																	text2 = string.Concat(new string[]
																	{
																		"\u0002<?",
																		o_0__O_o_O3.o_OoO._.(),
																		"\t",
																		o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
																		"?>"
																	});
																}
																imclient.o00O0._0O.(((ooo0)o_0__O_o_O3.o_0.Oo_0O0_.()).Oo_0__o.o.(), text2, false);
															}
															else if (o_0__O_o_O3.o_0.Oo_0O0_.() is O_0OOOoO)
															{
																if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.Capture)
																{
																	text2 = "\u0002=?" + o_0__O_o_O3.o_OoO._.() + "?=";
																}
																else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
																{
																	text2 = string.Concat(new string[]
																	{
																		"\u0002<?",
																		o_0__O_o_O3.o_OoO._.(),
																		"\t",
																		o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
																		"?>"
																	});
																}
																imclient.o00O0._0O.(((O_0OOOoO)o_0__O_o_O3.o_0.Oo_0O0_.()).O_O0_o._O0o0O.(), text2, false);
															}
															else if (o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat)
															{
																if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.Capture)
																{
																	text2 = "={\u0002=?" + o_0__O_o_O3.o_OoO._.() + "?=}=";
																}
																else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
																{
																	text2 = "={\u0002<?" + o_0__O_o_O3.o_OoO._.() + "?>}=";
																}
																else
																{
																	text2 = "\u0002<?" + o_0__O_o_O3.o_OoO._.() + "?>";
																}
																imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, true, false);
															}
															else
															{
																if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.Capture)
																{
																	text2 = "={\u0002=?" + o_0__O_o_O3.o_OoO._.() + "?=}=";
																}
																else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
																{
																	text2 = string.Concat(new string[]
																	{
																		"={\u0002<?",
																		o_0__O_o_O3.o_OoO._.(),
																		"\t",
																		o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
																		"?>}="
																	});
																}
																if (o_0__O_o_O3.o_0.Oo_0O0_.().OnLine)
																{
																	imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, true, false);
																}
																imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, true, true);
															}
															if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
															{
																if (o_0__O_o_O3.o_0.Oo_0O0_.() is ooo0 || o_0__O_o_O3.o_0.Oo_0O0_.() is O_0OOOoO)
																{
																	string a_2 = string.Concat(new string[]
																	{
																		"\u0002[我方成功上传文件\"",
																		OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.),
																		"\"(",
																		o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
																		")]\u0002"
																	});
																	imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_2, 2, 1, imclient.UserName);
																	if (o_0__O_o_O3.o_0.Oo_0O0_.() is ooo0)
																	{
																		imclient.O.00O0_O_o_oO.(((ooo0)o_0__O_o_O3.o_0.Oo_0O0_.()).Oo_0__o.o.(), text2, 2, 1, imclient.UserName);
																	}
																	else if (o_0__O_o_O3.o_0.Oo_0O0_.() is O_0OOOoO)
																	{
																		imclient.O.00O0_O_o_oO.(((O_0OOOoO)o_0__O_o_O3.o_0.Oo_0O0_.()).O_O0_o._O0o0O.(), text2, 2, 1, imclient.UserName);
																	}
																}
																else
																{
																	string a_3 = string.Concat(new string[]
																	{
																		"\u0002[我方成功离线发送文件\"",
																		OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.),
																		"\"(",
																		o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
																		")]\u0002"
																	});
																	imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_3, 2, 1, null);
																}
															}
														}
													}
													else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile)
													{
														string a_4 = string.Concat(new string[]
														{
															"\u0002[我方成功发送文件\"",
															OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.),
															"\"(",
															o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
															")]\u0002"
														});
														imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_4, 2, 1, null);
													}
												}
												else if (o_0__O_o_O3.o_0.Oo_0O0_.() == SendTypeEnum.ManualFile && o_0__O_o_O3.O._O___O.)
												{
													string a_5 = string.Concat(new string[]
													{
														"\u0002{因网络问题，文件发送失败\"",
														OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.),
														"\"(",
														o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.),
														")}\u0002"
													});
													imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_5, 2, 1, null);
												}
											}
										}
									}
									finally
									{
										Dictionary<string, O_0__O_o_O>.ValueCollection.Enumerator enumerator11;
										((IDisposable)enumerator11).Dispose();
									}
								}
								try
								{
									foreach (string key6 in list4)
									{
										imclient.ooOooo.oO..Remove(key6);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator12;
									((IDisposable)enumerator12).Dispose();
								}
								list4.Clear();
								object ooOooo.oO.2 = imclient.ooOooo.oO.;
								lock (ooOooo.oO.2)
								{
									try
									{
										foreach (ooOoO ooOoO3 in imclient.ooOooo.oO..Values)
										{
											if (ooOoO3.OO.000O.())
											{
												list4.Add(ooOoO3.o0OO._0.());
												if (ooOoO3.O0__00OoOo_O.o. != null && ooOoO3.O0__00OoOo_O.o..FindForm() != null)
												{
													((o\u3000\u3002\u3000\u3002\u3000)ooOoO3.O0__00OoOo_O.o..FindForm()).oOOOO.O.(ooOoO3.O0__00OoOo_O.o.);
													ooOoO3.O0__00OoOo_O.o. = null;
												}
												if (ooOoO3.OO.000O.() == SendTypeEnum.AutoFile)
												{
													AfterReceiveFileEventArgs afterReceiveFileEventArgs2 = new AfterReceiveFileEventArgs(ooOoO3.OO.000O.(), ooOoO3.o_Oo_o._Oo_o_., ooOoO3.O_OOOooo_0.O.());
													O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterReveiveFile", new object[]
													{
														afterReceiveFileEventArgs2
													}, true, "项目", false);
												}
												if ((ooOoO3.OO.000O.() == SendTypeEnum.ManualFile || ooOoO3.OO.000O.() == SendTypeEnum.Capture) && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
												{
													OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
												}
												if (ooOoO3.OO.000O.() == SendTypeEnum.Capture)
												{
													string text3;
													string text4;
													if (ooOoO3.O_OOOooo_0.O.())
													{
														text3 = ooOoO3.o_Oo_o._Oo_o_.;
														text4 = ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\").Length);
														text4 = "\u0002=(" + text4 + ")=";
													}
													else
													{
														text3 = "fail.png";
														text4 = "\u0002=(fail.png)=";
													}
													if (ooOoO3.OO.000O.() == null)
													{
														imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text4, 1, 0, null);
													}
													else
													{
														if (ooOoO3.OO.000O.().RowState == DataRowState.Detached)
														{
															new OleDbCommand("Update  [Messages]  set [Content] = '" + text4 + "' Where [_Identify] = " + ooOoO3.OO.000O.()["_Identify"].ToString(), imclient.oOO0O.O0O0.).ExecuteNonQuery();
														}
														else
														{
															ooOoO3.OO.000O.().RowError = null;
															ooOoO3.OO.000O.()["Content"] = text4;
															imclient.oOOOo0.oo0OoO0..Update(new DataRow[]
															{
																ooOoO3.OO.000O.()
															});
														}
														if (imclient.ooOooo.oO. != null && imclient.ooOooo.oO..Oo0_O0o.o_.)
														{
															foreach (Oo0O oo0O in new Oo0O[]
															{
																imclient.ooOooo.oO..O_0oOOO_.OO.(),
																imclient.ooOooo.oO..Oo.Oo00__oooo.()
															})
															{
																if (oo0O.Tag != null)
																{
																	Dictionary<int, int> dictionary = (Dictionary<int, int>)oo0O.Tag;
																	int key7 = Conversions.ToInteger(ooOoO3.OO.000O.()["_Identify"]);
																	if (dictionary.ContainsKey(key7))
																	{
																		int num = dictionary[key7];
																		dictionary.Remove(key7);
																		oo0O[num, 1] = null;
																		oo0O.SetCellImage(num, 1, OO_00oOO.GetImage(text3));
																		oo0O.AutoSizeRow(num);
																		oo0O.O000.o..Add(num, text3);
																	}
																}
															}
														}
													}
												}
												else
												{
													if (ooOoO3.OO.000O.() != null)
													{
														int item = Conversions.ToInteger(ooOoO3.OO.000O.()["_Identify"]);
														object oOO0_O.O__0_0. = imclient.oOO0_O.O__0_0.;
														lock (oOO0_O.O__0_0.)
														{
															if (imclient.oOO0_O.O__0_0..Contains(item))
															{
																imclient.oOO0_O.O__0_0..Remove(item);
															}
														}
													}
													if (ooOoO3.OO.000O.() == SendTypeEnum.ManualFile)
													{
														if (!ooOoO3.O_OOOooo_0.O.())
														{
															if (ooOoO3.Oo0___._oooo_O.)
															{
																if (ooOoO3.OO.000O.() == null)
																{
																	string text5 = string.Concat(new string[]
																	{
																		"\u0002{因网络问题，文件接收失败\"",
																		OO_00oOO.FileSys.GetName(ooOoO3.o_Oo_o._Oo_o_.),
																		"\"(",
																		o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.),
																		")}\u0002"
																	});
																	imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text5, 2, 1, null);
																}
																else
																{
																	string text5 = ooOoO3.OO.000O.()["Content"].ToString();
																	text5 = text5.Substring(3, text5.Length - 5);
																	string[] array2 = text5.Split(new char[]
																	{
																		'\t'
																	});
																	text5 = string.Concat(new string[]
																	{
																		"\u0002<?",
																		array2[0],
																		"\t",
																		array2[1],
																		"\t",
																		Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
																		"?>"
																	});
																	ooOoO3.OO.000O.()["Content"] = text5;
																	imclient.oOOOo0.oo0OoO0..Update(new DataRow[]
																	{
																		ooOoO3.OO.000O.()
																	});
																}
															}
														}
														else if (ooOoO3.OO.000O.() == null)
														{
															string text6 = "\u0002[我方成功接收文件]\u0002";
															imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text6, 2, 1, null);
															text6 = ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\").Length) + "\t" + o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.);
															text6 = "\u0002<" + text6 + ">\u0002";
															imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text6, 2, 0, null);
														}
														else
														{
															string text7 = string.Concat(new string[]
															{
																ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\").Length),
																"\t",
																o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.),
																"\t",
																Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss")
															});
															text7 = "\u0002|" + text7 + "|\u0002";
															ooOoO3.OO.000O.()["Content"] = text7;
															imclient.oOOOo0.oo0OoO0..Update(new DataRow[]
															{
																ooOoO3.OO.000O.()
															});
														}
													}
													if (ooOoO3.OO.000O.() != null && imclient.ooOooo.oO. != null && imclient.ooOooo.oO..Oo0_O0o.o_.)
													{
														foreach (Oo0O oo0O2 in new Oo0O[]
														{
															imclient.ooOooo.oO..O_0oOOO_.OO.(),
															imclient.ooOooo.oO..Oo.Oo00__oooo.()
														})
														{
															try
															{
																foreach (int num2 in oo0O2.oOO00oo.O..Keys)
																{
																	if (Conversions.ToInteger(oo0O2.oOO00oo.O.[num2]["_Identify"]) == Conversions.ToInteger(ooOoO3.OO.000O.()["_Identify"]))
																	{
																		if (oo0O2.oOO00oo.O.[num2] != ooOoO3.OO.000O.())
																		{
																			oo0O2.oOO00oo.O.[num2]["Content"] = RuntimeHelpers.GetObjectValue(ooOoO3.OO.000O.()["Content"]);
																		}
																		string text8 = ooOoO3.OO.000O.()["Content"].ToString();
																		if (ooOoO3.O_OOOooo_0.O.())
																		{
																			text8 = text8.Substring(2, text8.Length - 4);
																		}
																		else
																		{
																			text8 = text8.Substring(3, text8.Length - 5);
																		}
																		string[] array4 = text8.Split(new char[]
																		{
																			'\t'
																		});
																		text8 = array4[0] + "\r\n" + OO_00oOO.FileSys.GetName(array4[1]);
																		if (array4.Length == 3)
																		{
																			if (ooOoO3.O_OOOooo_0.O.())
																			{
																				text8 = text8 + "\r\n" + Strings.Format(Conversions.ToDate(array4[2]), "yyyy年MM月dd日 HH:mm:ss") + "下载成功!";
																			}
																			else
																			{
																				text8 = text8 + "\r\n" + Strings.Format(Conversions.ToDate(array4[2]), "yyyy年MM月dd日 HH:mm:ss") + "下载失败!";
																			}
																		}
																		oo0O2[num2, 1] = text8;
																		oo0O2.AutoSizeRow(num2);
																		if (ooOoO3.O_OOOooo_0.O.())
																		{
																			if (!oo0O2.O000.o..ContainsKey(num2))
																			{
																				oo0O2.O000.o..Add(num2, ooOoO3.OO.000O.());
																			}
																			if (oo0O2.oOO00oo.O..ContainsKey(num2))
																			{
																				oo0O2.oOO00oo.O..Remove(num2);
																			}
																		}
																		if (!imclient.ooOooo.oO..o_oO__.0.().Visible || imclient.ooOooo.oO..o_oO__.0.().Parent != oo0O2 || Conversions.ToInteger(imclient.ooOooo.oO..o_oO__.0.().Tag) != num2)
																		{
																			break;
																		}
																		if (ooOoO3.O_OOOooo_0.O.())
																		{
																			imclient.ooOooo.oO..o_oO__.0.().Visible = false;
																			int x = oo0O2.Width - imclient.ooOooo.oO..o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
																			int y = oo0O2.Rows[num2].Bottom - imclient.ooOooo.oO..o.0_o0_00.().Height + oo0O2.ScrollPosition.Y;
																			imclient.ooOooo.oO..o.0_o0_00.().Visible = true;
																			imclient.ooOooo.oO..o.0_o0_00.().Location = new Point(x, y);
																			imclient.ooOooo.oO..o.0_o0_00.().Tag = num2;
																			imclient.ooOooo.oO..o.0_o0_00.().Anchor = AnchorStyles.Right;
																			oo0O2.Controls.Add(imclient.ooOooo.oO..o.0_o0_00.());
																			break;
																		}
																		imclient.ooOooo.oO..O_o._o0___.().Text = "下载";
																		int x2 = oo0O2.Width - imclient.ooOooo.oO..o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
																		int y2 = oo0O2.Rows[num2].Bottom - imclient.ooOooo.oO..o_oO__.0.().Height + oo0O2.ScrollPosition.Y;
																		imclient.ooOooo.oO..o_oO__.0.().Location = new Point(x2, y2);
																		break;
																	}
																}
															}
															finally
															{
																Dictionary<int, DataRow>.KeyCollection.Enumerator enumerator14;
																((IDisposable)enumerator14).Dispose();
															}
														}
													}
												}
											}
										}
									}
									finally
									{
										Dictionary<string, ooOoO>.ValueCollection.Enumerator enumerator13;
										((IDisposable)enumerator13).Dispose();
									}
									try
									{
										foreach (string key8 in list4)
										{
											imclient.ooOooo.oO..Remove(key8);
										}
									}
									finally
									{
										List<string>.Enumerator enumerator15;
										((IDisposable)enumerator15).Dispose();
									}
									list4.Clear();
								}
							}
						}
					}
					finally
					{
						Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				if (OO_00oOO.UDPClients.Count > 0)
				{
					try
					{
						foreach (UDPClient udpclient in OO_00oOO.UDPClients.Values)
						{
							if (!udpclient.O00ooo._. && udpclient.O00ooo._..Count > 0)
							{
								flag = true;
								list2.Add(udpclient);
							}
						}
					}
					finally
					{
						Dictionary<string, UDPClient>.ValueCollection.Enumerator enumerator16;
						((IDisposable)enumerator16).Dispose();
					}
				}
				try
				{
					foreach (IMClient a_6 in list)
					{
						o0___oO.O.oOo0O0O.(a_6);
					}
				}
				finally
				{
					List<IMClient>.Enumerator enumerator17;
					((IDisposable)enumerator17).Dispose();
				}
				try
				{
					foreach (UDPClient a_7 in list2)
					{
						o0___oO.O.oOo0O0O.(a_7);
					}
				}
				finally
				{
					List<UDPClient>.Enumerator enumerator18;
					((IDisposable)enumerator18).Dispose();
				}
				if (!flag)
				{
					o0___oO.O.oOo0O0O.();
				}
			}
			catch (Exception a_8)
			{
				ooO.oOo0Oo.o.(a_8, "");
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0009CC3C File Offset: 0x0009AE3C
		private static void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.IMServers.Count > 0)
			{
				List<IMUser> list = new List<IMUser>();
				try
				{
					foreach (IMServer imserver in OO_00oOO.IMServers.Values)
					{
						if (!imserver.o0oo__0Oo_.o00. && imserver.MonitorHeartbeat)
						{
							try
							{
								foreach (IMUser imuser in imserver.Users)
								{
									if ((DateTime.Now - imuser.LastHeartbeatTime).TotalSeconds > (double)imserver.HeartbeatTimeout)
									{
										list.Add(imuser);
										Server_UserLogoutEventArgs server_UserLogoutEventArgs = new Server_UserLogoutEventArgs(imuser.Name, imserver, 3);
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", new object[]
										{
											server_UserLogoutEventArgs
										}, true, "项目", false);
									}
								}
							}
							finally
							{
								IEnumerator<IMUser> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							try
							{
								foreach (IMUser a_ in list)
								{
									imserver.Users.o_.oOoo_0.(a_);
								}
							}
							finally
							{
								List<IMUser>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							try
							{
								foreach (IMUser imuser2 in list)
								{
									string s = "!3\v" + imuser2.Name + "\v" + imuser2.OO__o_.O0_0O_0.;
									byte[] bytes = Encoding.Unicode.GetBytes(s);
									try
									{
										foreach (string name in imuser2.Buddies)
										{
											if (imserver.Users.Contains(name) && imserver.Users[name].Buddies.Contains(imuser2.Name))
											{
												imserver.ooO_.O0_..Send(bytes, bytes.Length, imserver.Users[name].WanIP);
											}
										}
									}
									finally
									{
										List<string>.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
							}
							finally
							{
								List<IMUser>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
					}
				}
				finally
				{
					Dictionary<string, IMServer>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (OO_00oOO.IMClients.Count > 0)
			{
				List<IMClient> list2 = new List<IMClient>();
				try
				{
					foreach (IMClient imclient in OO_00oOO.IMClients.Values)
					{
						if (!imclient.O0_OOo.O. && imclient.Ready && imclient.Heartbeat)
						{
							if (!imclient.o_oo0.O0Oo__oO. && (DateTime.Now - imclient.O00._Oo.).TotalSeconds > 2.0)
							{
								string a_2 = "=@\v" + imclient.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
								imclient.O.00O0_O_o_oO.(imclient.ooOo.oO0., a_2);
								imclient.o_oo0.O0Oo__oO. = true;
							}
							if ((DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > (double)imclient.HeartbeatTimeout)
							{
								Client_LogoutEventArgs client_LogoutEventArgs = new Client_LogoutEventArgs(imclient, 3);
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", new object[]
								{
									client_LogoutEventArgs
								}, true, "项目", false);
								list2.Add(imclient);
							}
							else if ((DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > (double)(imclient.HeartbeatInterval + 5))
							{
								if (!imclient.Oo0__0.ooO0__o.)
								{
									imclient.Oo0__0.ooO0__o. = true;
									string s2 = "#\v" + SysInfo.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
									byte[] bytes2 = Encoding.Unicode.GetBytes(s2);
									imclient.ooOo.oO0..Send(bytes2, bytes2.Length, imclient.ooOo.oO0.);
								}
							}
							else if ((DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > (double)(imclient.HeartbeatInterval + 10) && !imclient.O0O.Oo_.)
							{
								imclient.O0O.Oo_. = true;
								string s3 = "#\v" + SysInfo.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
								byte[] bytes3 = Encoding.Unicode.GetBytes(s3);
								imclient.ooOo.oO0..Send(bytes3, bytes3.Length, imclient.ooOo.oO0.);
							}
							try
							{
								foreach (int key in imclient.ooOo.oO0..Keys)
								{
									if ((DateTime.Now - imclient.ooOo.oO0.[key].ooO.o_Oo.).TotalSeconds > 5.0)
									{
										O0o000 o0o = imclient.ooOo.oO0.[key];
										imclient.O.00O0_O_o_oO.(o0o.Oo0O0.o..Name, "\u0002/" + o0o.ooO.o_Oo. + "\\\u0002", 1, 1, null);
										imclient.ooOo.oO0..Remove(key);
										if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
										{
											OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
											break;
										}
										break;
									}
								}
							}
							finally
							{
								Dictionary<int, O0o000>.KeyCollection.Enumerator enumerator7;
								((IDisposable)enumerator7).Dispose();
							}
							try
							{
								foreach (IMBuddy imbuddy in imclient.Buddies)
								{
									if (imbuddy.OnLine)
									{
										if ((DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > (double)imclient.HeartbeatTimeout)
										{
											imbuddy.oOo.o0__0Oo0oO. = 0;
											imbuddy.O00OO.o_. = 0;
										}
										else if ((DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > (double)(imclient.HeartbeatTimeout + 5))
										{
											if (!imbuddy.O00OO.o_.)
											{
												imbuddy.O00OO.o_. = true;
												string s4 = "#1\v" + SysInfo.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
												byte[] bytes4 = Encoding.Unicode.GetBytes(s4);
												imclient.ooOo.oO0..Send(bytes4, bytes4.Length, imbuddy.WanIP);
											}
										}
										else if ((DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > (double)(imclient.HeartbeatTimeout + 10) && !imbuddy.oO0.OooOOO00.)
										{
											imbuddy.oO0.OooOOO00. = true;
											string s5 = "#1\v" + SysInfo.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
											byte[] bytes5 = Encoding.Unicode.GetBytes(s5);
											imclient.ooOo.oO0..Send(bytes5, bytes5.Length, imbuddy.WanIP);
										}
										if (!imbuddy.oo.0o_0O0_0. && (DateTime.Now - imbuddy.O00OO.o_.).TotalSeconds > 10.0)
										{
											imbuddy.oo.0o_0O0_0. = true;
											string s6 = "#1\v" + SysInfo.UserName + "\v" + imclient.o_oo0Oooo.OOO_.;
											byte[] bytes6 = Encoding.Unicode.GetBytes(s6);
											imclient.ooOo.oO0..Send(bytes6, bytes6.Length, imbuddy.WanIP);
										}
									}
								}
							}
							finally
							{
								IEnumerator<IMBuddy> enumerator8;
								if (enumerator8 != null)
								{
									enumerator8.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				try
				{
					foreach (IMClient imclient2 in list2)
					{
						oO\u3000\u3002\u3002\u3000O\u3000 oO_u3000_u3002_u3002_u3000O_u = new oO\u3000\u3002\u3002\u3000O\u3000(imclient2, imclient2.ooOo.oO0.);
						oO_u3000_u3002_u3002_u3000O_u.O_.0OOOOO0o0.().Text = "因为心跳超时,OpenQQ失去连接。";
						imclient2.dispose();
						oO_u3000_u3002_u3002_u3000O_u.Show();
					}
				}
				finally
				{
					List<IMClient>.Enumerator enumerator9;
					((IDisposable)enumerator9).Dispose();
				}
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0009D4AC File Offset: 0x0009B6AC
		private static void <<EMPTY_NAME>>(IMServer A_0)
		{
			oO__oO_0_O oO__oO_0_O = null;
			object ooO_.O0_. = A_0.ooO_.O0_.;
			lock (ooO_.O0_.)
			{
				if (A_0.ooO_.O0_..Count > 0)
				{
					oO__oO_0_O = A_0.ooO_.O0_..Dequeue();
				}
			}
			if (oO__oO_0_O != null)
			{
				string[] array = oO__oO_0_O.Oo0oo._.().Split(new char[]
				{
					'\v'
				});
				if (array.Length == 5 && (Operators.CompareString(array[0], "@", true) == 0 || Operators.CompareString(array[0], "@1", true) == 0))
				{
					bool flag2;
					if (!o0OO__.OO0oO.o.() && A_0.Users.Count >= 20)
					{
						A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), O00.DecryptText(o0___oO.o_o.__OO00O., "my", "fox"));
						flag2 = true;
					}
					if (A_0.Users.Count >= 30000)
					{
						A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), O00.DecryptText("wrHFS8arXitNj8TCWH3qKdqJLP7LcUd5czaICHqnVRs5a3tbOpT8fw==", "fox", "table"));
						flag2 = true;
					}
					Server_UserLoggingEventArgs server_UserLoggingEventArgs = new Server_UserLoggingEventArgs(array[1], array[2], A_0, oO__oO_0_O, array);
					if (!flag2)
					{
						if (Operators.CompareString(array[0], "@1", true) == 0)
						{
							server_UserLoggingEventArgs.BuildIn = true;
						}
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogging", new object[]
						{
							server_UserLoggingEventArgs
						}, true, "项目", false);
					}
					if (!server_UserLoggingEventArgs.AsyncExecute)
					{
						o0___oO.O.oOo0O0O.(A_0, server_UserLoggingEventArgs, oO__oO_0_O, array);
					}
				}
				else
				{
					if (array.Length == 3 && Operators.CompareString(array[0], "+@", true) == 0)
					{
						if (!A_0.Users.Contains(array[1]) || Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) != 0)
						{
							goto IL_A0E;
						}
						Server_UserEventArgs server_UserEventArgs = new Server_UserEventArgs(array[1], A_0);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogged", new object[]
						{
							server_UserEventArgs
						}, true, "项目", false);
						IMUser imuser = A_0.Users[array[1]];
						try
						{
							foreach (string text in A_0.Users[array[1]].Buddies)
							{
								if (A_0.Users.Contains(text) && A_0.Users[text].Buddies.Contains(array[1]))
								{
									A_0.oOOOo._.(text, string.Concat(new string[]
									{
										"@\v",
										array[1],
										"\v",
										A_0.Users[text].OO__o_.O0_0O_0.,
										"\v",
										imuser.WanIP.ToString(),
										"\v",
										imuser.OO__o_.O0_0O_0.,
										"\v",
										imuser.LanIPAddress
									}));
								}
							}
							goto IL_A0E;
						}
						finally
						{
							List<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (array.Length == 3 && Operators.CompareString(array[0], "-@", true) == 0)
					{
						if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) == 0)
						{
							A_0.Users.o_.oOoo_0.(array[1]);
						}
					}
					else
					{
						if (array.Length == 3 && Operators.CompareString(array[0], "=@", true) == 0)
						{
							IMUser imuser2 = A_0.Users[array[1]];
							try
							{
								foreach (string text2 in A_0.Users[array[1]].Buddies)
								{
									if (A_0.Users.Contains(text2) && A_0.Users[text2].Buddies.Contains(array[1]))
									{
										A_0.oOOOo._.(text2, string.Concat(new string[]
										{
											"@\v",
											array[1],
											"\v",
											A_0.Users[text2].OO__o_.O0_0O_0.,
											"\v",
											imuser2.WanIP.ToString(),
											"\v",
											imuser2.OO__o_.O0_0O_0.,
											"\v",
											imuser2.LanIPAddress
										}));
									}
								}
								goto IL_A0E;
							}
							finally
							{
								List<string>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						if (array.Length == 3 && Operators.CompareString(array[0], "!1", true) == 0)
						{
							if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) == 0)
							{
								try
								{
									foreach (string text3 in A_0.Users[array[1]].Buddies)
									{
										if (A_0.Users.Contains(text3) && A_0.Users[text3].Buddies.Contains(array[1]))
										{
											A_0.oOOOo._.(text3, oO__oO_0_O.Oo0oo._.());
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								A_0.Users.o_.oOoo_0.(array[1]);
								Server_UserLogoutEventArgs server_UserLogoutEventArgs = new Server_UserLogoutEventArgs(array[1], A_0, 1);
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", new object[]
								{
									server_UserLogoutEventArgs
								}, true, "项目", false);
							}
						}
						else if (array.Length == 3 && Operators.CompareString(array[0], "^", true) == 0)
						{
							if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) == 0)
							{
								o0___oO.oooO0 @object = new o0___oO.oooO0(array, A_0, oO__oO_0_O);
								new Thread(new ThreadStart(@object.o_o.__OO00O.)).Start();
							}
						}
						else if (array.Length == 3 && Operators.CompareString(array[0], "+$", true) == 0)
						{
							if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) == 0)
							{
								o0___oO.o_O__o_o_o object2 = new o0___oO.o_O__o_o_o(A_0, array[1], oO__oO_0_O.Oo0oo._.());
								new Thread(new ThreadStart(object2.o_o.__OO00O.)).Start();
							}
						}
						else
						{
							if (array.Length == 2 && Operators.CompareString(array[0], "%5", true) == 0)
							{
								object ooO_.O0_.2 = A_0.ooO_.O0_.;
								lock (ooO_.O0_.2)
								{
									try
									{
										foreach (O_0__O_o_O o_0__O_o_O in A_0.ooO_.O0_..Values)
										{
											if (Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), array[1], true) == 0)
											{
												o_0__O_o_O.O0.0O0o_O. = true;
												break;
											}
										}
									}
									finally
									{
										Dictionary<string, O_0__O_o_O>.ValueCollection.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
								}
								object ooO_.O0_.3 = A_0.ooO_.O0_.;
								lock (ooO_.O0_.3)
								{
									try
									{
										foreach (ooOoO ooOoO in A_0.ooO_.O0_..Values)
										{
											if (Operators.CompareString(ooOoO.o0OO._0.(), array[1], true) == 0)
											{
												ooOoO.ooo0_.o__. = true;
												break;
											}
										}
										goto IL_A0E;
									}
									finally
									{
										Dictionary<string, ooOoO>.ValueCollection.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
							}
							if (array.Length == 5 && Operators.CompareString(array[0], ".", true) == 0)
							{
								if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[2], true) == 0)
								{
									Server_ChangeUserPasswordEventArgs server_ChangeUserPasswordEventArgs = new Server_ChangeUserPasswordEventArgs(array[1], A_0, array[3], array[4], oO__oO_0_O);
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserChangePassword", new object[]
									{
										server_ChangeUserPasswordEventArgs
									}, true, "项目", false);
									if (Operators.CompareString(server_ChangeUserPasswordEventArgs.ReturnMessage, "", true) > 0)
									{
										A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), server_ChangeUserPasswordEventArgs.ReturnMessage);
									}
								}
							}
							else if (array.Length == 4 && Operators.CompareString(array[0], "$", true) == 0)
							{
								if (A_0.Users.Contains(array[1]) && Operators.CompareString(A_0.Users[array[1]].OO__o_.O0_0O_0., array[3], true) == 0)
								{
									Server_MessageEventargs server_MessageEventargs = new Server_MessageEventargs(A_0, array[1], array[2], oO__oO_0_O, array);
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_ReceivedMessage", new object[]
									{
										server_MessageEventargs
									}, true, "项目", false);
									if (!server_MessageEventargs.AsyncExecute && Operators.CompareString(server_MessageEventargs.ReturnValue, "", true) > 0)
									{
										string a_ = "$\v\v" + server_MessageEventargs.ReturnValue + "\v" + array[3];
										A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), a_);
									}
								}
							}
							else if (array.Length == 5 && Operators.CompareString(array[0], "=$", true) == 0 && A_0.Users.Contains(array[2]) && Operators.CompareString(A_0.Users[array[2]].OO__o_.O0_0O_0., array[4], true) == 0)
							{
								array[1].Trim(new char[]
								{
									'"'
								});
								bool a_2;
								if (array[3].StartsWith("={") && array[3].EndsWith("}="))
								{
									a_2 = true;
									array[3] = array[3].Substring(2, array[3].Length - 4);
								}
								int a_3;
								if (array[3].StartsWith("\u0002=?") && array[3].EndsWith("?="))
								{
									a_3 = 1;
									array[3] = array[3].Substring(3, array[3].Length - 5);
								}
								else if (array[3].StartsWith("\u0002<?") && array[3].EndsWith("?>"))
								{
									a_3 = 2;
									array[3] = array[3].Substring(3, array[3].Length - 5);
								}
								WeChatMessageReceived weChatMessageReceived = new WeChatMessageReceived(A_0, array[2], array[1], array[3], a_3, a_2);
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_WeMessageReceived", new object[]
								{
									weChatMessageReceived
								}, true, "项目", false);
							}
						}
					}
				}
				IL_A0E:
				if (A_0.ooO_.O0_..Count > 0)
				{
					o0___oO.O.oOo0O0O.(A_0);
				}
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0009DF40 File Offset: 0x0009C140
		internal static void <<EMPTY_NAME>>(IMServer A_0, Server_UserLoggingEventArgs A_1, oO__oO_0_O A_2, string[] A_3)
		{
			if (A_1.Success)
			{
				if (A_1.Buddies.Count > 500)
				{
					A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), O00.DecryptText("sIAeellQZKFEKq5D6slLtIZlvAuH2x6+wZg3O0lan8E=", "fox", "table"));
					return;
				}
				if (A_0.Users.Contains(A_3[1]))
				{
					A_0.oOOOo._.(A_3[1], "&2\v" + A_3[1] + "\v" + A_0.Users[A_3[1]].OO__o_.O0_0O_0.);
					Server_UserLogoutEventArgs server_UserLogoutEventArgs = new Server_UserLogoutEventArgs(A_3[1], A_0, 4);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", new object[]
					{
						server_UserLogoutEventArgs
					}, true, "项目", false);
					A_0.Users.o_.oOoo_0.(A_3[1]);
				}
				A_0.Users.OO__o_.O0_0O_0.(new IMUser(A_3[1], A_2.Oo0oo._.()));
				A_0.Users[A_3[1]].OO__o_.O0_0O_0. = A_3[3];
				A_0.Users[A_3[1]].Buddies.AddRange(A_1.Buddies);
				if (Operators.CompareString(A_3[4], "None", true) != 0)
				{
					A_0.Users[A_3[1]].LanIP = o0___oO.o0__.0.(A_3[4]);
				}
				A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), string.Concat(new string[]
				{
					A_3[1],
					"\v",
					A_1.Message,
					"\v",
					Interaction.IIf(A_0.MonitorHeartbeat, 1, 0).ToString(),
					"\v",
					Conversions.ToString(A_0.HeartbeatInterval),
					"\v",
					Conversions.ToString(A_0.HeartbeatTimeout),
					"\v",
					A_2.Oo0oo._.().ToString(),
					"\v",
					Conversions.ToString(A_1.Buddies.Count)
				}));
				return;
			}
			else
			{
				if (Operators.CompareString(A_1.Message, "", true) > 0)
				{
					A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), A_1.Message);
					return;
				}
				A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), "未知错误");
				return;
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0009E16C File Offset: 0x0009C36C
		private static void <<EMPTY_NAME>>(IMClient A_0)
		{
			oO__oO_0_O oO__oO_0_O = null;
			object ooOo.oO0. = A_0.ooOo.oO0.;
			lock (ooOo.oO0.)
			{
				if (A_0.ooOo.oO0..Count > 0)
				{
					oO__oO_0_O = A_0.ooOo.oO0..Dequeue();
				}
			}
			if (oO__oO_0_O != null)
			{
				string[] array = oO__oO_0_O.Oo0oo._.().Split(new char[]
				{
					'\v'
				});
				if (array.Length == 6 && Operators.CompareString(array[0], "@", true) == 0 && Operators.CompareString(array[2], A_0.o_oo0Oooo.OOO_., true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]) && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[4], true) != 0 && Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), true) == 0)
					{
						if (A_0.Buddies[array[1]].OnLine)
						{
							Client_BuddyLogoutEventArgs client_BuddyLogoutEventArgs = new Client_BuddyLogoutEventArgs(array[1], A_0, 4);
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", new object[]
							{
								client_BuddyLogoutEventArgs
							}, true, "项目", false);
							A_0.oOO0O.O0O0.(A_0.Buddies[array[1]]);
						}
						IMBuddy imbuddy = A_0.Buddies[array[1]];
						imbuddy.WanIP = o0___oO.o0__.0.(array[3]);
						imbuddy.RandKey = array[4];
						imbuddy.oOo.o0__0Oo0oO. = 0;
						imbuddy.O00OO.o_. = 0;
						imbuddy.LastReceiveHeartbeatTime = DateTime.Now;
						imbuddy.Ready = true;
						imbuddy.O00OO.o_. = false;
						imbuddy.oO0.OooOOO00. = false;
						imbuddy.oo.0o_0O0_0. = false;
						imbuddy.O00OO.o_. = DateTime.Now;
						if (Operators.CompareString(array[5], "None", true) != 0)
						{
							imbuddy.LanIP = o0___oO.o0__.0.(array[5]);
							string text = imbuddy.WanIP.ToString();
							string text2 = A_0.WanIP.ToString();
							text = text.Substring(0, text.IndexOf(":"));
							text2 = text2.Substring(0, text2.IndexOf(":"));
							if (Operators.CompareString(text, text2, true) == 0)
							{
								A_0.O.00O0_O_o_oO.(imbuddy.LanIP, "#1\v" + A_0.UserName + "\v" + A_0.o_oo0Oooo.OOO_.);
							}
						}
						else
						{
							imbuddy.LanIP = null;
						}
						if (A_0.ooOooo.oO. != null && A_0.ooOooo.oO..Oo0_O0o.o_.)
						{
							IMBuddy imbuddy2 = A_0.Buddies[array[1]];
							try
							{
								foreach (object obj in A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages)
								{
									C1TopicPage c1TopicPage = (C1TopicPage)obj;
									C1TopicLink c1TopicLink = c1TopicPage.FindLinkByTag(imbuddy2);
									if (c1TopicLink != null)
									{
										if (c1TopicLink.TopicPage.Index == 0)
										{
											c1TopicLink.ImageIndex = 0;
										}
										else
										{
											c1TopicLink.ImageIndex = 11;
										}
										int num = 0;
										int num2 = c1TopicPage.Links.Count - 1;
										for (int i = 0; i <= num2; i++)
										{
											object objectValue = RuntimeHelpers.GetObjectValue(c1TopicPage.Links[i].Tag);
											if (i != c1TopicLink.Index && (objectValue is ooo0 || objectValue is O_0OOOoO || ((IMBuddy)objectValue).OnLine))
											{
												num++;
											}
										}
										num = Math.Min(num, c1TopicPage.Links.Count - 1);
										if (num != c1TopicLink.Index)
										{
											c1TopicPage.Links.Remove(c1TopicLink);
											c1TopicPage.Links.Insert(num, c1TopicLink);
										}
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
							if (A_0.ooOooo.oO..o.0_0_Ooo. != null && A_0.ooOooo.oO..o.0_0_Ooo..Tag == imbuddy2)
							{
								A_0.ooOooo.oO..oOoO.O_o__.("对方已经上线!");
							}
						}
						A_0.O.00O0_O_o_oO.(array[1], "#\v" + A_0.UserName + "\v" + A_0.o_oo0Oooo.OOO_.);
						Client_BuddyLoginEventArgs client_BuddyLoginEventArgs = new Client_BuddyLoginEventArgs(array[1], A_0);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogin", new object[]
						{
							client_BuddyLoginEventArgs
						}, true, "项目", false);
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "!1", true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]) && A_0.Buddies[array[1]].OnLine && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[2], true) == 0)
					{
						A_0.oOO0O.O0O0.(A_0.Buddies[array[1]]);
						Client_BuddyLogoutEventArgs client_BuddyLogoutEventArgs2 = new Client_BuddyLogoutEventArgs(array[1], A_0, 1);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", new object[]
						{
							client_BuddyLogoutEventArgs2
						}, true, "项目", false);
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "!2", true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]) && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[2], true) == 0)
					{
						A_0.oOO0O.O0O0.(A_0.Buddies[array[1]]);
						Client_BuddyLogoutEventArgs client_BuddyLogoutEventArgs3 = new Client_BuddyLogoutEventArgs(array[1], A_0, 2);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", new object[]
						{
							client_BuddyLogoutEventArgs3
						}, true, "项目", false);
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "!3", true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]) && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[2], true) == 0)
					{
						A_0.oOO0O.O0O0.(A_0.Buddies[array[1]]);
						Client_BuddyLogoutEventArgs client_BuddyLogoutEventArgs4 = new Client_BuddyLogoutEventArgs(array[1], A_0, 3);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", new object[]
						{
							client_BuddyLogoutEventArgs4
						}, true, "项目", false);
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "&1", true) == 0)
				{
					if (Operators.CompareString(A_0.UserName, array[1], true) == 0 && Operators.CompareString(A_0.o_oo0Oooo.OOO_., array[2], true) == 0)
					{
						Client_LogoutEventArgs client_LogoutEventArgs = new Client_LogoutEventArgs(A_0, 2);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", new object[]
						{
							client_LogoutEventArgs
						}, true, "项目", false);
						A_0.dispose();
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "&2", true) == 0)
				{
					if (Operators.CompareString(A_0.UserName, array[1], true) == 0 && Operators.CompareString(A_0.o_oo0Oooo.OOO_., array[2], true) == 0)
					{
						Client_LogoutEventArgs client_LogoutEventArgs2 = new Client_LogoutEventArgs(A_0, 4);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", new object[]
						{
							client_LogoutEventArgs2
						}, true, "项目", false);
						A_0.dispose();
					}
				}
				else if (array.Length == 3 && Operators.CompareString(array[0], "&3", true) == 0)
				{
					if (Operators.CompareString(A_0.UserName, array[1], true) == 0 && Operators.CompareString(A_0.o_oo0Oooo.OOO_., array[2], true) == 0)
					{
						Client_LogoutEventArgs client_LogoutEventArgs3 = new Client_LogoutEventArgs(A_0, 5);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", new object[]
						{
							client_LogoutEventArgs3
						}, true, "项目", false);
						oO\u3000\u3002\u3002\u3000O\u3000 oO_u3000_u3002_u3002_u3000O_u = new oO\u3000\u3002\u3002\u3000O\u3000(A_0, A_0.ooOo.oO0.);
						oO_u3000_u3002_u3002_u3000O_u.O_.0OOOOO0o0.().Text = "服务端QQServer关闭,OpenQQ失去连接。";
						A_0.dispose();
						oO_u3000_u3002_u3002_u3000O_u.Show();
					}
				}
				else if (array.Length == 7 && Operators.CompareString(array[0], "*", true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]))
					{
						o0___oO.o0__.0.(A_0, array[2], array[4], array[1], array[3], array[5], Conversions.ToDate(array[6]));
					}
				}
				else if (array.Length == 5 && Operators.CompareString(array[0], "*1", true) == 0)
				{
					if (A_0.oo.___oo__0_O..ContainsKey(array[3]) || A_0.oo.___oo__0_O..ContainsKey(array[3]))
					{
						int a_ = 0;
						f4 ooOooo.oO. = A_0.ooOooo.oO.;
						if (ooOooo.oO. != null && ooOooo.oO..Visible && ooOooo.oO..o.0_0_Ooo. != null)
						{
							if (ooOooo.oO..o.0_0_Ooo..Tag is ooo0)
							{
								if (Operators.CompareString(((ooo0)ooOooo.oO..o.0_0_Ooo..Tag).Oo_0__o.o.(), array[3], true) == 0)
								{
									a_ = 1;
								}
							}
							else if (ooOooo.oO..o.0_0_Ooo..Tag is O_0OOOoO && Operators.CompareString(((O_0OOOoO)ooOooo.oO..o.0_0_Ooo..Tag).O_O0_o._O0o0O.(), array[3], true) == 0)
							{
								a_ = 1;
							}
						}
						string text3 = array[4];
						if (text3.StartsWith("{!}"))
						{
							text3 = text3.Substring(3);
							OO_00oOO.PopMessage(text3, array[1], PopiconEnum.Infomation, -1);
						}
						A_0.O.00O0_O_o_oO.(array[3], text3, 1, a_, array[1]);
					}
				}
				else if (array.Length == 4 && Operators.CompareString(array[0], "*2", true) == 0)
				{
					if (A_0.oo.___oo__0_O..ContainsKey(array[3]) && Operators.CompareString(A_0.oo.___oo__0_O.[array[3]].o0O0OOo._ooO_O.().RandKey, array[2], true) == 0)
					{
						o0___oO.O.oOo0O0O.(A_0, array[3]);
					}
				}
				else if (array.Length == 6 && Operators.CompareString(array[0], "*3", true) == 0)
				{
					if (A_0.oo.___oo__0_O..ContainsKey(array[3]) && Operators.CompareString(A_0.oo.___oo__0_O.[array[3]].o0O0OOo._ooO_O.().RandKey, array[2], true) == 0)
					{
						if (Operators.CompareString(array[4], "", true) > 0)
						{
							string a_2 = "\u0002(有新用户加入会议:\r\n" + array[4] + ")\u0002";
							A_0.O.00O0_O_o_oO.(array[3], a_2, 2, 1, array[1]);
						}
						if (Operators.CompareString(array[5], "", true) > 0)
						{
							string a_2 = "\u0002(有用户被请出会议:\r\n" + array[5] + ")\u0002";
							A_0.O.00O0_O_o_oO.(array[3], a_2, 2, 1, array[1]);
						}
					}
				}
				else if (array.Length == 6 && Operators.CompareString(array[0], "%5", true) == 0)
				{
					if (A_0.Buddies.Contains(array[1]) && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[2], true) == 0)
					{
						Oo0O__ oo0O__ = new Oo0O__(A_0, A_0.Buddies[array[1]], array[4], array[3]);
						oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(array[4]);
						oo0O__.Oo0O_.o.().Text = array[5];
						if (A_0.ooOooo.oO. == null)
						{
							A_0.ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(A_0);
							A_0.ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
						}
						A_0.ooOooo.oO..O_0O_o.0.(oo0O__);
						A_0.ooOooo.oO..Show();
						string a_3 = string.Concat(new string[]
						{
							"\u0002(对方请求发送文件\"",
							array[4],
							"\"(",
							array[5],
							"))\u0002"
						});
						A_0.O.00O0_O_o_oO.(array[1], a_3, 2, 1, null);
						if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
						{
							OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
						}
					}
				}
				else
				{
					if (array.Length == 2 && Operators.CompareString(array[0], "%5", true) == 0)
					{
						if (A_0.ooOooo.oO. == null || A_0.ooOooo.oO..IsDisposed)
						{
							goto IL_15F9;
						}
						try
						{
							foreach (object obj2 in A_0.ooOooo.oO..Controls)
							{
								Control control = (Control)obj2;
								if (control is oO0 && Operators.CompareString(((oO0)control).o0O.Oo., array[1], true) == 0)
								{
									A_0.ooOooo.oO..oOOOO.O.(control);
									object ooOooo.oO.2 = A_0.ooOooo.oO.;
									bool flag3;
									lock (ooOooo.oO.2)
									{
										try
										{
											foreach (O_0__O_o_O o_0__O_o_O in A_0.ooOooo.oO..Values)
											{
												if (Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), array[1], true) == 0)
												{
													o_0__O_o_O.O0.0O0o_O. = true;
													flag3 = true;
													break;
												}
											}
										}
										finally
										{
											Dictionary<string, O_0__O_o_O>.ValueCollection.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									string name = OO_00oOO.FileSys.GetName(((oO0)control).O_oo__._O.);
									string a_4 = string.Concat(new string[]
									{
										"\u0002{对方",
										Interaction.IIf(!flag3, "拒绝", "取消").ToString(),
										"接收文件\"",
										OO_00oOO.FileSys.GetName(name),
										"\"}\u0002"
									});
									A_0.O.00O0_O_o_oO.(((oO0)control).O_oo__._O..Name, a_4, 2, 1, null);
									if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
									{
										OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
									}
								}
								if (control is Oo0O__ && Operators.CompareString(((Oo0O__)control).O_OO.o0o_o0., array[1], true) == 0)
								{
									A_0.ooOooo.oO..oOOOO.O.(control);
									object ooOooo.oO.3 = A_0.ooOooo.oO.;
									lock (ooOooo.oO.3)
									{
										try
										{
											foreach (ooOoO ooOoO in A_0.ooOooo.oO..Values)
											{
												if (Operators.CompareString(ooOoO.o0OO._0.(), array[1], true) == 0)
												{
													ooOoO.ooo0_.o__. = true;
													break;
												}
											}
										}
										finally
										{
											Dictionary<string, ooOoO>.ValueCollection.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
									}
									string name2 = OO_00oOO.FileSys.GetName(((Oo0O__)control).o_0.Oo_0O0_.);
									string a_5 = "\u0002{对方取消发送文件\"" + OO_00oOO.FileSys.GetName(name2) + "\"}\u0002";
									A_0.O.00O0_O_o_oO.(((Oo0O__)control).o_0.Oo_0O0_..Name, a_5, 2, 1, null);
								}
							}
							goto IL_15F9;
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					if (array.Length == 2 && Operators.CompareString(array[0], "%6", true) == 0)
					{
						if (A_0.ooOooo.oO. == null || A_0.ooOooo.oO..IsDisposed)
						{
							goto IL_15F9;
						}
						try
						{
							foreach (object obj3 in A_0.ooOooo.oO..Controls)
							{
								Control control2 = (Control)obj3;
								if (control2 is oO0)
								{
									oO0 oO = (oO0)control2;
									if (Operators.CompareString(oO.o0O.Oo., array[1], true) == 0 && !oO.O_oo__._O.)
									{
										oO.O_oo__._O. = true;
										oO.o.oo00_.().Visible = false;
										oO.o.oo00_.();
										string a_6 = "\u0002(我方开始发送文件\"" + OO_00oOO.FileSys.GetName(oO.O_oo__._O.) + "\")\u0002";
										A_0.O.00O0_O_o_oO.(oO.O_oo__._O..Name, a_6, 2, 1, null);
									}
								}
							}
							goto IL_15F9;
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
					if (array.Length == 2 && Operators.CompareString(array[0], "%7", true) == 0)
					{
						if (A_0.ooOooo.oO. == null || A_0.ooOooo.oO..IsDisposed)
						{
							goto IL_15F9;
						}
						try
						{
							foreach (object obj4 in A_0.ooOooo.oO..Controls)
							{
								Control control3 = (Control)obj4;
								if (control3 is Oo0O__ && Operators.CompareString(((Oo0O__)control3).O_OO.o0o_o0., array[1], true) == 0)
								{
									A_0.ooOooo.oO..oOOOO.O.(control3);
									object ooOooo.oO.4 = A_0.ooOooo.oO.;
									lock (ooOooo.oO.4)
									{
										try
										{
											foreach (ooOoO ooOoO2 in A_0.ooOooo.oO..Values)
											{
												if (Operators.CompareString(ooOoO2.o0OO._0.(), array[1], true) == 0)
												{
													ooOoO2.ooo0_.o__. = true;
													break;
												}
											}
										}
										finally
										{
											Dictionary<string, ooOoO>.ValueCollection.Enumerator enumerator7;
											((IDisposable)enumerator7).Dispose();
										}
									}
									string name3 = OO_00oOO.FileSys.GetName(((Oo0O__)control3).o_0.Oo_0O0_.);
									string a_7 = "\u0002(对方选择离线发送文件\"" + OO_00oOO.FileSys.GetName(name3) + "\")\u0002";
									A_0.O.00O0_O_o_oO.(((Oo0O__)control3).o_0.Oo_0O0_..Name, a_7, 2, 1, null);
								}
							}
							goto IL_15F9;
						}
						finally
						{
							IEnumerator enumerator6;
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
					if (array.Length == 3 && Operators.CompareString(array[0], "=$", true) == 0)
					{
						if (Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), true) == 0)
						{
							string text4 = array[2];
							if (text4.StartsWith("={") && text4.EndsWith("}="))
							{
								text4 = text4.Substring(2, text4.Length - 4);
								string[] array2 = array[1].Split(new char[]
								{
									'\t'
								});
								if (A_0.Buddies.Contains(array2[0]))
								{
									A_0.O.00O0_O_o_oO.(array2[0], text4, 1, 0, null);
								}
								else if (array2.Length == 2)
								{
									A_0.AddWeChatUser(array2[0], array2[1]);
									A_0.O.00O0_O_o_oO.(array2[0], text4, 1, 0, null);
								}
							}
							else
							{
								int a_8;
								if (text4.StartsWith("\u0002=?") && text4.EndsWith("?="))
								{
									a_8 = 1;
								}
								else if (text4.StartsWith("\u0002<?") && text4.EndsWith("?>"))
								{
									a_8 = 2;
								}
								weMessageReceived weMessageReceived = new weMessageReceived(A_0, array[1], a_8, array[2]);
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_WeMessageReceived", new object[]
								{
									weMessageReceived
								}, true, "项目", false);
							}
						}
					}
					else if (array.Length == 4 && Operators.CompareString(array[0], "$", true) == 0 && ((Operators.CompareString(array[1], "", true) == 0 && Operators.CompareString(A_0.o_oo0Oooo.OOO_., array[3], true) == 0) || (Operators.CompareString(array[1], "[System]", true) == 0 && Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), true) == 0) || (A_0.Buddies.Contains(array[1]) && Operators.CompareString(A_0.Buddies[array[1]].RandKey, array[3], true) == 0)))
					{
						if (Operators.CompareString(array[1], "", true) > 0 && array[2].StartsWith("\u0003") && array[2].EndsWith("\u0003"))
						{
							string text5 = array[2];
							text5 = text5.Substring(1, text5.Length - 2);
							int key;
							if (int.TryParse(text5, out key) && A_0.ooOo.oO0..ContainsKey(key))
							{
								A_0.ooOo.oO0..Remove(key);
							}
						}
						else if (array[2].StartsWith("={") && array[2].EndsWith("}="))
						{
							int a_9 = 0;
							if (A_0.ooOooo.oO. != null)
							{
								f4 ooOooo.oO.5 = A_0.ooOooo.oO.;
								if (ooOooo.oO.5.o.0_0_Ooo. != null && ooOooo.oO.5.o.0_0_Ooo..Tag is IMBuddy && Operators.CompareString(((IMBuddy)ooOooo.oO.5.o.0_0_Ooo..Tag).Name, array[1], true) == 0)
								{
									a_9 = 1;
								}
							}
							string text6 = array[2].Substring(2, array[2].Length - 4);
							if (Operators.CompareString(array[1], "", true) > 0 && text6.IndexOf('\u0004') > 0)
							{
								string[] array3 = text6.Split(new char[]
								{
									'\u0004'
								});
								text6 = array3[0];
								int num3;
								if (int.TryParse(array3[1], out num3))
								{
									string msg = "\u0003" + num3.ToString() + "\u0003";
									A_0.Send(array[1], msg, true, false);
								}
							}
							if (Operators.CompareString(text6, "", true) > 0 && ((text6.StartsWith("\u0002<?") && text6.EndsWith("?>")) || (text6.StartsWith("\u0002=?") && text6.EndsWith("?="))))
							{
								if (!A_0.oo.___oo__0_O..ContainsKey(text6.ToLower()) || (A_0.oo.___oo__0_O.[text6.ToLower()] - DateTime.Now).TotalSeconds > 10.0)
								{
									A_0.O.00O0_O_o_oO.(array[1], text6, 1, a_9, null);
									A_0.oo.___oo__0_O..Add(text6.ToLower(), DateTime.Now);
								}
							}
							else if (Operators.CompareString(text6, "", true) > 0 && text6.StartsWith("\u0002\u0002<?") && text6.EndsWith("?>"))
							{
								text6 = text6.Substring(1);
								A_0.O.00O0_O_o_oO.(array[1], text6, 1, a_9, null);
							}
							else if (Operators.CompareString(text6, "", true) > 0 && text6.StartsWith("\u0002\u0002=?") && text6.EndsWith("?="))
							{
								text6 = text6.Substring(1);
								A_0.O.00O0_O_o_oO.(array[1], text6, 1, a_9, null);
							}
							else
							{
								if (text6.StartsWith("{!}"))
								{
									text6 = text6.Substring(3);
									string text7 = array[1];
									if (Operators.CompareString(text7, "[System]", true) == 0)
									{
										text7 = "系统通知";
									}
									OO_00oOO.PopMessage(text6, text7, PopiconEnum.Infomation, -1);
								}
								A_0.O.00O0_O_o_oO.(array[1], text6, 1, a_9, null);
							}
						}
						else
						{
							Client_MessageEventargs client_MessageEventargs = new Client_MessageEventargs(A_0, array[1], array[2]);
							client_MessageEventargs.SendTime = DateTime.Now;
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_ReceivedMessage", new object[]
							{
								client_MessageEventargs
							}, true, "项目", false);
						}
					}
				}
				IL_15F9:
				if (A_0.ooOo.oO0..Count > 0)
				{
					o0___oO.O.oOo0O0O.(A_0);
				}
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0009F894 File Offset: 0x0009DA94
		private static void <<EMPTY_NAME>>(IMClient A_0, string A_1, string A_2, string A_3, string A_4, string A_5, DateTime A_6)
		{
			try
			{
				O_0OOOoO o_0OOOoO = new O_0OOOoO(A_1, A_2, A_0.Buddies[A_3], A_4, A_5);
				o_0OOOoO.O0O0o_.00O.(A_6);
				A_0.oo.___oo__0_O..Add(A_2, o_0OOOoO);
				if (A_0.ooOooo.oO. != null && A_0.ooOooo.oO..Oo0_O0o.o_.)
				{
					C1TopicLink c1TopicLink = new C1TopicLink();
					c1TopicLink.Text = A_1;
					c1TopicLink.Tag = o_0OOOoO;
					c1TopicLink.ImageIndex = 9;
					A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].Links.Add(c1TopicLink);
					if (!A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].PageVisible)
					{
						A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].PageVisible = true;
					}
					A_0.ooOooo.oO..o0__.O_Ooo_.(o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.O_O0_o._O0o0O.(), A_3, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.(), 0);
				}
				DataRow dataRow = A_0.oo00000_0o0.oO..NewRow();
				dataRow["MeetingKey"] = A_2;
				dataRow["Hostess"] = A_3;
				dataRow["MeetingName"] = A_1;
				dataRow["DateTime"] = A_6;
				dataRow["Description"] = A_4;
				dataRow["Members"] = A_5;
				dataRow["Finish"] = false;
				A_0.oo00000_0o0.oO..Rows.Add(dataRow);
				A_0.oo00000_0o0.oO..Update(new DataRow[]
				{
					dataRow
				});
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0009FA58 File Offset: 0x0009DC58
		private static void <<EMPTY_NAME>>(IMClient A_0, string A_1)
		{
			O_0OOOoO o_0OOOoO = A_0.oo.___oo__0_O.[A_1];
			A_0.oo.___oo__0_O..Remove(A_1);
			DataRow[] array = A_0.oo00000_0o0.oO..Select("[MeetingKey] = '" + o_0OOOoO.O_O0_o._O0o0O.() + "'", "");
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i]["Finish"] = true;
				}
				new OleDbCommand("Update Meetings Set [Finish] = True Where [MeetingKey] = '" + o_0OOOoO.O_O0_o._O0o0O.() + "'", A_0.oOO0O.O0O0.).ExecuteNonQuery();
			}
			if (A_0.ooOooo.oO. != null && A_0.ooOooo.oO..Oo0_O0o.o_.)
			{
				f4 ooOooo.oO. = A_0.ooOooo.oO.;
				if (ooOooo.oO..o.0_0_Ooo. != null && ooOooo.oO..o.0_0_Ooo..Tag == o_0OOOoO)
				{
					ooOooo.oO..O_0oOOO_.OO.().Rows.Count = 0;
					ooOooo.oO..Oo.Oo00__oooo.().Rows.Count = 0;
				}
				C1TopicLink c1TopicLink = ooOooo.oO..Oo.Oo00__oooo.().Pages[0].FindLinkByTag(o_0OOOoO);
				if (c1TopicLink != null)
				{
					ooOooo.oO..Oo.Oo00__oooo.().Pages[0].Links.Remove(c1TopicLink);
					if (ooOooo.oO..Oo.Oo00__oooo.().Pages[0].Links.Count == 0)
					{
						ooOooo.oO..Oo.Oo00__oooo.().Pages[0].PageVisible = false;
					}
				}
				if (ooOooo.oO..O_0oOOO_.OO.().Pages.Count > 0)
				{
					int num = ooOooo.oO..O_0oOOO_.OO.().Pages.Count - 1;
					for (int j = 0; j <= num; j++)
					{
						C1TopicPage c1TopicPage = ooOooo.oO..O_0oOOO_.OO.().Pages[j];
						try
						{
							foreach (object obj in c1TopicPage.Links)
							{
								C1TopicLink c1TopicLink2 = (C1TopicLink)obj;
								if (Operators.CompareString(((o0o0_oo00Oo)c1TopicLink2.Tag).OO.O_o__.(), A_1, true) == 0)
								{
									((o0o0_oo00Oo)c1TopicLink2.Tag).o.oo_o0O.(true);
									c1TopicLink2.ImageIndex = 13;
									if (ooOooo.oO..o.0_0_Ooo. == null || ooOooo.oO..o.0_0_Ooo. == c1TopicLink2)
									{
										ooOooo.oO..oOO._O.().Enabled = false;
										ooOooo.oO..oOo00_.0Oo.().Enabled = false;
										ooOooo.oO..Oo_oo._O_.().Enabled = false;
										ooOooo.oO..OO0_O0.o.().Enabled = false;
										ooOooo.oO..O._o_O0O.().Enabled = false;
									}
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
					}
				}
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0009FCE4 File Offset: 0x0009DEE4
		private static void <<EMPTY_NAME>>(UDPClient A_0)
		{
			object o00ooo._. = A_0.O00ooo._.;
			lock (o00ooo._.)
			{
				if (A_0.O00ooo._..Count > 0)
				{
					UDPClient.OO00_ oo00_ = A_0.O00ooo._..Dequeue();
					UDPClient_MessageReceived udpclient_MessageReceived = new UDPClient_MessageReceived(A_0, oo00_);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "UDPClient_ReceivedMessage", new object[]
					{
						udpclient_MessageReceived
					}, true, "项目", false);
					if (Operators.CompareString(udpclient_MessageReceived.ReturnValue, "", true) > 0)
					{
						byte[] bytes = A_0.O00ooo._..GetBytes(udpclient_MessageReceived.ReturnValue);
						A_0.O00ooo._..Send(bytes, bytes.Length, oo00_.O00ooo._.());
					}
					else if (udpclient_MessageReceived.ReturnBytes != null)
					{
						A_0.O00ooo._..Send(udpclient_MessageReceived.ReturnBytes, udpclient_MessageReceived.ReturnBytes.Length, oo00_.O00ooo._.());
					}
				}
			}
			if (A_0.O00ooo._..Count > 0)
			{
				o0___oO.O.oOo0O0O.(A_0);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0009FDE4 File Offset: 0x0009DFE4
		internal static IPEndPoint <<EMPTY_NAME>>(string A_0)
		{
			string[] array = A_0.Split(new char[]
			{
				':'
			});
			return new IPEndPoint(IPAddress.Parse(array[0]), Conversions.ToInteger(array[1]));
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0009FE18 File Offset: 0x0009E018
		internal static void <<EMPTY_NAME>>(UdpClient A_0)
		{
			A_0.Client.IOControl(-1744830452, new byte[]
			{
				Convert.ToByte(false)
			}, null);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0009FE3C File Offset: 0x0009E03C
		internal static string <<EMPTY_NAME>>()
		{
			foreach (IPAddress ipaddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
			{
				if (ipaddress.AddressFamily == AddressFamily.InterNetwork && ipaddress.ToString().StartsWith("192.168."))
				{
					return ipaddress.ToString();
				}
			}
			return "";
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0009FE96 File Offset: 0x0009E096
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return A_0.Replace("\v", "").Replace("\f", "").Trim();
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0009FEBC File Offset: 0x0009E0BC
		internal static string <<EMPTY_NAME>>(IMBuddy A_0)
		{
			string result;
			if (A_0 is ooo0)
			{
				result = ((ooo0)A_0).Oo_0__o.o.();
			}
			else if (A_0 is O_0OOOoO)
			{
				result = ((O_0OOOoO)A_0).O_O0_o._O0o0O.();
			}
			else
			{
				result = A_0.Name;
			}
			return result;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0009FF00 File Offset: 0x0009E100
		internal static string <<EMPTY_NAME>>(long A_0)
		{
			double num = (double)(A_0 / 1024L);
			string result;
			if (num < 1000.0)
			{
				result = num.ToString() + "K";
			}
			else
			{
				result = Strings.Format((double)A_0 / 1024.0 / 1024.0, "0.00") + "M";
			}
			return result;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0009FF68 File Offset: 0x0009E168
		internal static UdpClient <<EMPTY_NAME>>(IMServer A_0)
		{
			object obj = o0___oO.o_o.__OO00O.;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			UdpClient result;
			lock (obj)
			{
				int num = A_0.oo._0oo_00O.;
				int num2 = A_0.OOOOoo_0o.Oo.;
				if (num == -1 && num2 == -1)
				{
					result = o0___oO.o0__.0.(A_0, 0);
				}
				else
				{
					if (num == -1)
					{
						num = 1024;
					}
					if (num2 == -1)
					{
						num2 = 65535;
					}
					IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
					IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
					IPEndPoint[] activeUdpListeners = ipglobalProperties.GetActiveUdpListeners();
					TcpConnectionInformation[] activeTcpConnections = ipglobalProperties.GetActiveTcpConnections();
					List<int> list = new List<int>();
					foreach (IPEndPoint ipendPoint in activeTcpListeners)
					{
						list.Add(ipendPoint.Port);
					}
					foreach (IPEndPoint ipendPoint2 in activeUdpListeners)
					{
						list.Add(ipendPoint2.Port);
					}
					foreach (TcpConnectionInformation tcpConnectionInformation in activeTcpConnections)
					{
						list.Add(tcpConnectionInformation.LocalEndPoint.Port);
					}
					int num3 = num;
					int num4 = num2;
					for (int l = num3; l <= num4; l++)
					{
						if (!list.Contains(l))
						{
							UdpClient udpClient = o0___oO.o0__.0.(A_0, l);
							if (udpClient != null)
							{
								return udpClient;
							}
						}
					}
					ooO.oOo0Oo.o.(new Exception("指定的端口范围已全部占用，无法接入新的请求！"), "");
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000A00E4 File Offset: 0x0009E2E4
		internal static UdpClient <<EMPTY_NAME>>(IMServer A_0, int A_1)
		{
			if (o0___oO.a == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref o0___oO.a, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(o0___oO.a, ref flag);
				if (o0___oO.a.State == 0)
				{
					o0___oO.a.State = 2;
					o0___oO.a = new StringBuilder();
				}
				else if (o0___oO.a.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				o0___oO.a.State = 1;
				if (flag)
				{
					Monitor.Exit(o0___oO.a);
				}
			}
			UdpClient result;
			try
			{
				IPEndPoint localEP;
				if (Operators.CompareString(A_0.ServerIP, "", true) == 0)
				{
					localEP = new IPEndPoint(IPAddress.Any, A_1);
				}
				else
				{
					localEP = new IPEndPoint(IPAddress.Parse(A_0.ServerIP), A_1);
				}
				o0___oO.a.Append(Conversions.ToString(A_1) + ",");
				result = new UdpClient(localEP);
			}
			catch (Exception ex)
			{
				o0___oO.a.Append("error,");
				result = null;
			}
			return result;
		}

		// Token: 0x040008F9 RID: 2297
		internal static string <<EMPTY_NAME>> = "Yn9laz04yt+eA5JRIe5b+JeWX8onK2CJCAx9aF/UPeMoJCo+89kYkL9BsDTL8cWgpohfMeOYzG0=";

		// Token: 0x040008FA RID: 2298
		private static object <<EMPTY_NAME>> = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x040008FB RID: 2299
		private static StringBuilder a;

		// Token: 0x040008FC RID: 2300
		private static StaticLocalInitFlag a;

		// Token: 0x020001D3 RID: 467
		internal class oooO0
		{
			// Token: 0x06001663 RID: 5731 RVA: 0x000A0200 File Offset: 0x0009E400
			internal oooO0(string[] A_0, IMServer A_1, oO__oO_0_O A_2)
			{
				this.o_o.__OO00O. = A_0;
				this.o_o.__OO00O. = A_1;
				this.o_o.__OO00O. = A_2;
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x000A0220 File Offset: 0x0009E420
			internal void <<EMPTY_NAME>>()
			{
				string text = "";
				this.o_o.__OO00O..ooO_.O0_..AcquireReaderLock(-1);
				try
				{
					try
					{
						foreach (string text2 in this.o_o.__OO00O..Users[this.o_o.__OO00O.[1]].Buddies)
						{
							if (Operators.CompareString(text, "", true) > 0)
							{
								text += "\v";
							}
							IMUser imuser = null;
							object users = this.o_o.__OO00O..Users;
							lock (users)
							{
								if (this.o_o.__OO00O..Users.Contains(text2))
								{
									imuser = this.o_o.__OO00O..Users[text2];
								}
							}
							if (imuser == null)
							{
								text = text + "^\t" + text2;
							}
							else
							{
								text = string.Concat(new string[]
								{
									text,
									"^\t",
									text2,
									"\t",
									imuser.WanIP.ToString(),
									"\t",
									imuser.OO__o_.O0_0O_0.,
									"\t",
									imuser.LanIPAddress
								});
								if (text.Length > 500)
								{
									this.o_o.__OO00O..O0o_.Oo0oo.(this.o_o.__OO00O..Oo0oo._.(), text);
									text = "";
									Thread.Sleep(1);
								}
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (Operators.CompareString(text, "", true) > 0)
					{
						this.o_o.__OO00O..O0o_.Oo0oo.(this.o_o.__OO00O..Oo0oo._.(), text);
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					this.o_o.__OO00O..ooO_.O0_..ReleaseReaderLock();
				}
			}

			// Token: 0x040008FD RID: 2301
			private string[] <<EMPTY_NAME>>;

			// Token: 0x040008FE RID: 2302
			private IMServer <<EMPTY_NAME>>;

			// Token: 0x040008FF RID: 2303
			private oO__oO_0_O <<EMPTY_NAME>>;
		}

		// Token: 0x020001D4 RID: 468
		internal class o_O__o_o_o
		{
			// Token: 0x06001665 RID: 5733 RVA: 0x000A044C File Offset: 0x0009E64C
			internal o_O__o_o_o(IMServer A_0, string A_1, IPEndPoint A_2)
			{
				this.o_o.__OO00O. = A_0;
				this.o_o.__OO00O. = A_1;
				this.o_o.__OO00O. = A_2;
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x000A046C File Offset: 0x0009E66C
			internal void <<EMPTY_NAME>>()
			{
				this.o_o.__OO00O..ooO_.O0_..AcquireReaderLock(-1);
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					char value = '\v';
					try
					{
						foreach (o0o0_oo00Oo o0o0_oo00Oo in this.o_o.__OO00O..MeetingInfos.Values)
						{
							if (o0o0_oo00Oo.o.oo_o0O.().Contains(this.o_o.__OO00O.))
							{
								if (stringBuilder.Length > 0)
								{
									stringBuilder.Append('\f');
								}
								stringBuilder.Append(string.Concat(new string[]
								{
									"*",
									Conversions.ToString(value),
									o0o0_oo00Oo.O_oO._O.(),
									Conversions.ToString(value),
									o0o0_oo00Oo.oOO_00_0.o.(),
									Conversions.ToString(value),
									o0o0_oo00Oo.OO0_o.Oo0O.(),
									Conversions.ToString(value),
									o0o0_oo00Oo.OO.O_o__.(),
									Conversions.ToString(value),
									o0o0_oo00Oo.o_0o.oo_o_.(),
									Conversions.ToString(value),
									Strings.Format(o0o0_oo00Oo.o.oo_o0O.(), "MM/dd/yyyy HH:mm:ss")
								}));
							}
						}
					}
					finally
					{
						Dictionary<string, o0o0_oo00Oo>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					DataTable dataTable = new DataTable();
					this.o_o.__OO00O..O0O_.O..SelectCommand.CommandText = "Select * From [Messages] Where [Receiver] = '" + this.o_o.__OO00O. + "'";
					this.o_o.__OO00O..O0O_.O..Fill(dataTable);
					foreach (DataRow dataRow in dataTable.Select("", "[Time]"))
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append('\f');
						}
						stringBuilder.Append(dataRow["Content"].ToString() + "\v" + Strings.Format(Conversions.ToDate(dataRow["Time"]), "MM/dd/yyyy HH:mm:ss"));
					}
					if (stringBuilder.Length > 0)
					{
						if (new o0O0OOoOO(this.o_o.__OO00O., this.o_o.__OO00O., stringBuilder.ToString()).ooo_OoooOOO.0.())
						{
							new OleDbCommand("Delete From [Messages] Where [Receiver] = '" + this.o_o.__OO00O. + "'", this.o_o.__OO00O..O0O_.O.).ExecuteNonQuery();
						}
					}
					else
					{
						this.o_o.__OO00O..O0o_.Oo0oo.(this.o_o.__OO00O., "None");
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					this.o_o.__OO00O..ooO_.O0_..ReleaseReaderLock();
				}
			}

			// Token: 0x04000900 RID: 2304
			private IMServer <<EMPTY_NAME>>;

			// Token: 0x04000901 RID: 2305
			private string <<EMPTY_NAME>>;

			// Token: 0x04000902 RID: 2306
			private IPEndPoint <<EMPTY_NAME>>;
		}
	}
}
