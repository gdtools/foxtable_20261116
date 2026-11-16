using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002D9 RID: 729
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOO__0oo_oo
	{
		// Token: 0x06002829 RID: 10281 RVA: 0x00122669 File Offset: 0x00120869
		public OOO__0oo_oo()
		{
			this.OO.0o. = new List<string>();
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x0012267C File Offset: 0x0012087C
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OOO__0oo_oo.oOOO A_0)
		{
			OOO__0oo_oo.oOOO oOOO = this.OO.0o.;
			OOO__0oo_oo.oOOO oOOO2;
			do
			{
				oOOO2 = oOOO;
				OOO__0oo_oo.oOOO value = (OOO__0oo_oo.oOOO)Delegate.Combine(oOOO2, A_0);
				oOOO = Interlocked.CompareExchange<OOO__0oo_oo.oOOO>(ref this.OO.0o., value, oOOO2);
			}
			while (oOOO != oOOO2);
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x001226B4 File Offset: 0x001208B4
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OOO__0oo_oo.oOOO A_0)
		{
			OOO__0oo_oo.oOOO oOOO = this.OO.0o.;
			OOO__0oo_oo.oOOO oOOO2;
			do
			{
				oOOO2 = oOOO;
				OOO__0oo_oo.oOOO value = (OOO__0oo_oo.oOOO)Delegate.Remove(oOOO2, A_0);
				oOOO = Interlocked.CompareExchange<OOO__0oo_oo.oOOO>(ref this.OO.0o., value, oOOO2);
			}
			while (oOOO != oOOO2);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x001226E9 File Offset: 0x001208E9
		public void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			this.OO.0o. = A_0;
			this.oO0Oo0o_.o. = A_1;
			this.oO0Oo0o_.o. = A_2;
			this.OO.0o. = new Thread(new ThreadStart(this.O_o0.0oo0_o.));
			this.OO.0o..Start();
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00122724 File Offset: 0x00120924
		public bool <<EMPTY_NAME>>()
		{
			return this.OO.0o. == null;
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00122740 File Offset: 0x00120940
		public void <<EMPTY_NAME>>()
		{
			this.OO.0o. = true;
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0012274C File Offset: 0x0012094C
		public void <<EMPTY_NAME>>()
		{
			HttpWebResponse httpWebResponse = null;
			FileStream fileStream = null;
			Stream stream = null;
			try
			{
				string text = this.oO0Oo0o_.o. + ".fxdlif";
				byte[] array = new byte[1025];
				if (this.o0O_.0o0_oO. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.o0O_.0o0_oO., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(this.o0O_.0o0_oO., ref flag);
					if (this.o0O_.0o0_oO..State == 0)
					{
						this.o0O_.0o0_oO..State = 2;
						this.o0O_.0o0_oO. = null;
					}
					else if (this.o0O_.0o0_oO..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.o0O_.0o0_oO..State = 1;
					if (flag)
					{
						Monitor.Exit(this.o0O_.0o0_oO.);
					}
				}
				this.OO.0o. = false;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.OO.0o.);
				httpWebRequest.Timeout = 8000;
				httpWebRequest.ReadWriteTimeout = 8000;
				if (OO_00oOO.FileSys.FileExists(text))
				{
					if (this.OO.0o..Contains(this.OO.0o..ToLower()))
					{
						fileStream = File.Open(text, FileMode.Append);
						httpWebRequest.AddRange((int)fileStream.Length);
					}
					else
					{
						OO_00oOO.FileSys.DeleteFile(text);
						fileStream = File.Create(text);
					}
				}
				else
				{
					string parentPath = OO_00oOO.FileSys.GetParentPath(text);
					if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
					{
						OO_00oOO.FileSys.CreateDirectory(parentPath);
					}
					fileStream = File.Create(text);
				}
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				if (OO_00oOO.FileSys.FileExists(this.oO0Oo0o_.o.) && this.oO0Oo0o_.o.)
				{
					if (Operators.CompareString(this.o._O_o_Oo., OO_00oOO.ProjectFile, true) != 0 || this.o0O_.0o0_oO. == null)
					{
						this.o._O_o_Oo. = OO_00oOO.ProjectFile;
						string text2 = OO_00oOO.ProjectPath + "RemoteFiles\\_foxdownloadinfo.mdb";
						if (OO_00oOO.FileSys.FileExists(text2))
						{
							this.o0O_.0o0_oO. = new OleDbConnection(Oo00.o_._0OOo.(text2));
							this.o0O_.0o0_oO. = new OleDbDataAdapter("", this.o0O_.0o0_oO.);
						}
						else
						{
							this.o0O_.0o0_oO. = null;
							this.o0O_.0o0_oO. = null;
						}
					}
					if (this.o0O_.0o0_oO. != null)
					{
						DataTable dataTable = new DataTable();
						this.o0O_.0o0_oO..SelectCommand.CommandText = "Select * From [Files] Where [remfile] = '" + this.OO.0o. + "'";
						this.o0O_.0o0_oO..Fill(dataTable);
						if (dataTable.Rows.Count > 0)
						{
							DataRow dataRow = dataTable.Rows[0];
							FileInfo fileInfo = new FileInfo(this.oO0Oo0o_.o.);
							if (Operators.CompareString(dataRow["remtime"].ToString(), httpWebResponse.LastModified.Ticks.ToString(), true) == 0 && Operators.CompareString(dataRow["remsize"].ToString(), httpWebResponse.ContentLength.ToString(), true) == 0 && fileInfo.Length == httpWebResponse.ContentLength && Operators.CompareString(dataRow["loctime"].ToString(), fileInfo.LastWriteTime.Ticks.ToString(), true) == 0)
							{
								httpWebResponse.Close();
								fileStream.Close();
								OOO__0oo_oo.oOOO oo.0o. = this.OO.0o.;
								if (oo.0o. != null)
								{
									oo.0o.(true, this.OO.0o., this.oO0Oo0o_.o., true);
								}
								if (OO_00oOO.FileSys.FileExists(text))
								{
									OO_00oOO.FileSys.DeleteFile(text);
								}
								return;
							}
						}
					}
				}
				stream = httpWebResponse.GetResponseStream();
				if (this.OO.0o..Contains(this.OO.0o..ToLower()))
				{
					this.OO.0o..Remove(this.OO.0o..ToLower());
				}
				int i = stream.Read(array, 0, array.Length);
				while (i > 0)
				{
					fileStream.Write(array, 0, i);
					if (this.OO.0o.)
					{
						OOO__0oo_oo.oOOO oo.0o.2 = this.OO.0o.;
						if (oo.0o.2 != null)
						{
							oo.0o.2(false, this.OO.0o., this.oO0Oo0o_.o., false);
						}
						if (!this.OO.0o..Contains(this.OO.0o..ToLower()))
						{
							this.OO.0o..Add(this.OO.0o..ToLower());
							break;
						}
						break;
					}
					else
					{
						i = stream.Read(array, 0, array.Length);
					}
				}
				stream.Close();
				fileStream.Close();
				httpWebResponse.Close();
				if (OO_00oOO.FileSys.FileExists(this.oO0Oo0o_.o.))
				{
					OO_00oOO.FileSys.DeleteFile(this.oO0Oo0o_.o.);
				}
				if (!this.OO.0o.)
				{
					OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(this.oO0Oo0o_.o.));
					FileInfo fileInfo2 = new FileInfo(this.oO0Oo0o_.o.);
					Oo00.o0_o._O_.(this.OO.0o., httpWebResponse.LastModified.Ticks.ToString(), fileInfo2.Length.ToString(), fileInfo2.LastWriteTime.Ticks.ToString());
					OOO__0oo_oo.oOOO oo.0o.3 = this.OO.0o.;
					if (oo.0o.3 != null)
					{
						oo.0o.3(true, this.OO.0o., this.oO0Oo0o_.o., false);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("\"" + this.OO.0o. + "\"下载失败：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				if (fileStream != null)
				{
					fileStream.Close();
				}
				if (stream != null)
				{
					stream.Close();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
				OOO__0oo_oo.oOOO oo.0o.4 = this.OO.0o.;
				if (oo.0o.4 != null)
				{
					oo.0o.4(false, this.OO.0o., this.oO0Oo0o_.o., false);
				}
			}
			finally
			{
				this.OO.0o. = null;
				if (O_O0OO.oO_00Ooo___0._..Contains(this.OO.0o..ToLower()))
				{
					O_O0OO.oO_00Ooo___0._..Remove(this.OO.0o..ToLower());
				}
			}
		}

		// Token: 0x04001096 RID: 4246
		[CompilerGenerated]
		private OOO__0oo_oo.oOOO <<EMPTY_NAME>>;

		// Token: 0x04001097 RID: 4247
		private string <<EMPTY_NAME>>;

		// Token: 0x04001098 RID: 4248
		private string <<EMPTY_NAME>>;

		// Token: 0x04001099 RID: 4249
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400109A RID: 4250
		private Thread <<EMPTY_NAME>>;

		// Token: 0x0400109B RID: 4251
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400109C RID: 4252
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x0400109D RID: 4253
		private string <<EMPTY_NAME>>;

		// Token: 0x0400109E RID: 4254
		private OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x0400109F RID: 4255
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040010A0 RID: 4256
		private StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x020002DA RID: 730
		// (Invoke) Token: 0x06002833 RID: 10291
		public delegate void oOOO(bool A_0, string A_1, string A_2, bool A_3);
	}
}
