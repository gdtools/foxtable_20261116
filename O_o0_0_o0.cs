using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000200 RID: 512
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O_o0_0_o0
	{
		// Token: 0x06001991 RID: 6545 RVA: 0x000B6938 File Offset: 0x000B4B38
		internal O_o0_0_o0(RequestEventArgs A_0, string A_1, string A_2, bool A_3)
		{
			this.ooO0O.0. = A_0;
			this.o.0O__0. = A_1;
			this.O_0._00_. = A_2;
			this.ooO0O.0. = A_3;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000B695D File Offset: 0x000B4B5D
		public O_o0_0_o0(DataTable A_0, RequestEventArgs A_1)
		{
			this.ooO0O.0. = A_0;
			this.ooO0O.0. = A_1;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000B6974 File Offset: 0x000B4B74
		internal void <<EMPTY_NAME>>(object A_0)
		{
			OleDbConnection oleDbConnection = null;
			if (Operators.CompareString(this.O_0._00_., "", true) > 0)
			{
				if (O_O0OO.O._o_.().ContainsKey(this.O_0._00_.))
				{
					oleDbConnection = O_O0OO.O._o_.()[this.O_0._00_.];
				}
				else
				{
					try
					{
						foreach (string text in O_O0OO.O._o_.().Keys)
						{
							if (Operators.CompareString(text, this.O_0._00_., true) == 0)
							{
								oleDbConnection = O_O0OO.O._o_.()[text];
							}
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (oleDbConnection == null)
				{
					return;
				}
			}
			else
			{
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
			}
			OleDbConnection oleDbConnection2 = oleDbConnection;
			oleDbConnection2 = new OleDbConnection(oleDbConnection.ConnectionString);
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(this.o.0O__0., oleDbConnection2);
			DataTable dataTable = new DataTable();
			dataTable.TableName = "temp";
			try
			{
				if (!this.ooO0O.0..PostValues.ContainsKey("IgnoreSchema") || this.ooO0O.0.)
				{
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
					if (this.ooO0O.0. && dataTable.PrimaryKey.Length == 0)
					{
						this.ooO0O.0..AppendCookie("Error", "Select语句不包括主键，无法生成可更新DataTable！");
						this.ooO0O.0..Response.OutputStream.Close();
						this.ooO0O.0..Response.Close();
						this.ooO0O.0..Response.Abort();
						return;
					}
				}
				oleDbDataAdapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
				this.ooO0O.0..AppendCookie("Error", ex.Message);
				this.ooO0O.0..Response.OutputStream.Close();
				this.ooO0O.0..Response.Close();
				this.ooO0O.0..Response.Abort();
				return;
			}
			DataSet dataSet = new DataSet();
			dataSet.Tables.Add(dataTable);
			if (this.ooO0O.0.)
			{
				string str = Oo00.oo_0__0.o.(this.o.0O__0.);
				List<string> list = new List<string>();
				oleDbDataAdapter = new OleDbDataAdapter("Select * From " + str, oleDbConnection2);
				DataTable dataTable2 = new DataTable();
				oleDbDataAdapter.FillSchema(dataTable2, SchemaType.Source);
				try
				{
					foreach (object obj in dataTable2.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						list.Add(dataColumn.ColumnName.ToLower());
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				DataTable dataTable3 = new DataTable();
				dataTable3.Columns.Add("Name", typeof(string));
				dataTable3.Columns.Add("Value", typeof(string));
				DataRow dataRow = dataTable3.NewRow();
				dataRow["Name"] = "UpdateColumns";
				dataRow["Value"] = string.Join("|", list.ToArray());
				dataTable3.Rows.Add(dataRow);
				dataTable3.AcceptChanges();
				dataSet.Tables.Add(dataTable3);
			}
			MemoryStream memoryStream = new MemoryStream();
			dataSet.WriteXml(memoryStream, XmlWriteMode.WriteSchema);
			oleDbConnection2.Close();
			dataSet.Tables.Clear();
			dataSet.Dispose();
			dataTable.Dispose();
			oleDbDataAdapter.Dispose();
			memoryStream.Position = 0L;
			new oOO_O__(memoryStream, this.ooO0O.0..Response).oO0o0o._0.(null);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000B6CF8 File Offset: 0x000B4EF8
		public void <<EMPTY_NAME>>(object A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			if (Operators.CompareString(this.ooO0O.0..TableName, "", true) == 0)
			{
				this.ooO0O.0..TableName = "TempDataTable";
			}
			if (this.ooO0O.0..Rows.Count == 0)
			{
				this.ooO0O.0..WriteXmlSchema(memoryStream);
			}
			else
			{
				this.ooO0O.0..WriteXml(memoryStream, XmlWriteMode.WriteSchema);
			}
			memoryStream.Position = 0L;
			new oOO_O__(memoryStream, this.ooO0O.0..Response).oO0o0o._0.(null);
		}

		// Token: 0x04000A8F RID: 2703
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A90 RID: 2704
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A91 RID: 2705
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A92 RID: 2706
		private RequestEventArgs <<EMPTY_NAME>>;

		// Token: 0x04000A93 RID: 2707
		private DataTable <<EMPTY_NAME>>;
	}
}
