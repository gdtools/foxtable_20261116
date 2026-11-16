using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1GanttView;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020000ED RID: 237
	public class GanttView : C1GanttView
	{
		// Token: 0x06000D9E RID: 3486 RVA: 0x00070264 File Offset: 0x0006E464
		internal GanttView(bool A_0 = false)
		{
			base.MouseDown += this.OO0oo.o0.;
			this.oo0ooO000O.O. = new Dictionary<string, string>();
			base.BarStyles.ListChanged += this.OO0oo.o0.;
			base.AfterEditTask += this.o._00o0_.;
			base.BeforeEditTask += this.OooOOO0O_0.0.;
			base.EnablePrinting = true;
			C1FlexGrid c1FlexGrid = (C1FlexGrid)base.Controls[2];
			c1FlexGrid.BeforeEdit += this.OooOOO0O_0.0.;
			c1FlexGrid.Styles.Fixed.WordWrap = true;
			c1FlexGrid.Styles.SelectedColumnHeader.WordWrap = true;
			if (A_0)
			{
				c1FlexGrid.Styles.Normal.TextAlign = TextAlignEnum.LeftCenter;
				base.ToolStrip.ItemClicked += this.OO0oo.o0.;
				base.GridContextMenu.ItemClicked += this.OO0oo.o0.;
				base.ChartContextMenu.ItemClicked += this.OO0oo.o0.;
				base.AfterEditTask += this.OoOoOo.O.;
			}
			this.Strip.Items.Remove("tsdSort");
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0007039C File Offset: 0x0006E59C
		private void <<EMPTY_NAME>>(object A_0, ListChangedEventArgs A_1)
		{
			if (A_1.ListChangedType == ListChangedType.ItemAdded)
			{
				BarStyleCollection barStyleCollection = (BarStyleCollection)A_0;
				BarType barType = barStyleCollection[A_1.NewIndex].BarType;
				for (int i = barStyleCollection.Count - 1; i >= 0; i += -1)
				{
					if (i != A_1.NewIndex && barStyleCollection[i].BarType == barType)
					{
						barStyleCollection.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000703FD File Offset: 0x0006E5FD
		private void <<EMPTY_NAME>>(object A_0, ToolStripItemClickedEventArgs A_1)
		{
			if (base.FindForm() != null && base.FindForm() is o\u3002\u3002\u3000\u3000\u3002)
			{
				((o\u3000\u3002)base.FindForm().MdiParent).OO_._oOo. = true;
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0007042A File Offset: 0x0006E62A
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			if (base.FindForm() != null && base.FindForm() is o\u3002\u3002\u3000\u3000\u3002)
			{
				((o\u3000\u3002)base.FindForm().MdiParent).OO_._oOo. = true;
			}
		}

		// Token: 0x1700020E RID: 526
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00070458 File Offset: 0x0006E658
		public DataTable CalendarDataTable
		{
			set
			{
				((ISupportInitialize)this).BeginInit();
				((ISupportInitialize)base.DataStorage.CalendarStorage).BeginInit();
				if (value != null)
				{
					base.DataStorage.CalendarStorage.Mappings.CalendarID.MappingName = "CalendarID";
					base.DataStorage.CalendarStorage.Mappings.Data.MappingName = "Data";
					base.DataStorage.CalendarStorage.Mappings.IdMapping.MappingName = "Id";
					base.DataStorage.CalendarStorage.Mappings.Name.MappingName = "Name";
					base.DataStorage.CalendarStorage.DataSource = value.BaseTable;
				}
				((ISupportInitialize)this).EndInit();
				((ISupportInitialize)base.DataStorage.CalendarStorage).EndInit();
			}
		}

		// Token: 0x1700020F RID: 527
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x0007052C File Offset: 0x0006E72C
		public DataTable PropertyDataTable
		{
			set
			{
				((ISupportInitialize)this).BeginInit();
				((ISupportInitialize)base.DataStorage.PropertyStorage).BeginInit();
				if (value != null)
				{
					base.DataStorage.PropertyStorage.Key.MappingName = "Key";
					base.DataStorage.PropertyStorage.Value.MappingName = "Value";
					base.DataStorage.PropertyStorage.DataSource = value.BaseTable;
				}
				((ISupportInitialize)this).EndInit();
				((ISupportInitialize)base.DataStorage.PropertyStorage).EndInit();
			}
		}

		// Token: 0x17000210 RID: 528
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x000705B4 File Offset: 0x0006E7B4
		public DataTable ResourceDataTable
		{
			set
			{
				((ISupportInitialize)this).BeginInit();
				((ISupportInitialize)base.DataStorage.ResourceStorage).BeginInit();
				if (value != null)
				{
					base.DataStorage.ResourceStorage.Mappings.Cost.MappingName = "Cost";
					base.DataStorage.ResourceStorage.Mappings.IdMapping.MappingName = "Id";
					base.DataStorage.ResourceStorage.Mappings.Name.MappingName = "Name";
					base.DataStorage.ResourceStorage.Mappings.Notes.MappingName = "Notes";
					base.DataStorage.ResourceStorage.Mappings.ResourceID.MappingName = "ResourceID";
					base.DataStorage.ResourceStorage.Mappings.ResourceType.MappingName = "ResourceType";
					base.DataStorage.ResourceStorage.Mappings.UnitOfMeasure.MappingName = "UnitOfMeasure";
					base.DataStorage.ResourceStorage.DataSource = value.BaseTable;
				}
				((ISupportInitialize)this).EndInit();
				((ISupportInitialize)base.DataStorage.ResourceStorage).EndInit();
			}
		}

		// Token: 0x17000211 RID: 529
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x000706E4 File Offset: 0x0006E8E4
		public DataTable TaskDataTable
		{
			set
			{
				((ISupportInitialize)this).BeginInit();
				((ISupportInitialize)base.DataStorage.TasksStorage).BeginInit();
				if (value != null)
				{
					base.DataStorage.TasksStorage.Mappings.CalendarID.MappingName = "CalendarID";
					base.DataStorage.TasksStorage.Mappings.Parts.MappingName = "Parts";
					base.DataStorage.TasksStorage.Mappings.ConstraintDate.MappingName = "ConstraintDate";
					base.DataStorage.TasksStorage.Mappings.ConstraintType.MappingName = "ConstraintType";
					base.DataStorage.TasksStorage.Mappings.CustomFields.MappingName = "CustomFields";
					base.DataStorage.TasksStorage.Mappings.Deadline.MappingName = "Deadline";
					base.DataStorage.TasksStorage.Mappings.Duration.MappingName = "Duration";
					base.DataStorage.TasksStorage.Mappings.DurationUnits.MappingName = "DurationUnits";
					base.DataStorage.TasksStorage.Mappings.Finish.MappingName = "Finish";
					base.DataStorage.TasksStorage.Mappings.HideBar.MappingName = "HideBar";
					base.DataStorage.TasksStorage.Mappings.IdMapping.MappingName = "Id";
					base.DataStorage.TasksStorage.Mappings.Initialized.MappingName = "Initialized";
					base.DataStorage.TasksStorage.Mappings.Mode.MappingName = "Mode";
					base.DataStorage.TasksStorage.Mappings.Name.MappingName = "Name";
					base.DataStorage.TasksStorage.Mappings.NextID.MappingName = "NextID";
					base.DataStorage.TasksStorage.Mappings.Notes.MappingName = "Notes";
					base.DataStorage.TasksStorage.Mappings.OutlineParentID.MappingName = "OutlineParentID";
					base.DataStorage.TasksStorage.Mappings.PercentComplete.MappingName = "PercentComplete";
					base.DataStorage.TasksStorage.Mappings.Predecessors.MappingName = "Predecessors";
					base.DataStorage.TasksStorage.Mappings.Resources.MappingName = "Resources";
					base.DataStorage.TasksStorage.Mappings.Start.MappingName = "Start";
					base.DataStorage.TasksStorage.Mappings.Summary.MappingName = "Summary";
					base.DataStorage.TasksStorage.Mappings.TaskID.MappingName = "TaskID";
					base.DataStorage.TasksStorage.DataSource = value.BaseTable;
					this.oo0ooO000O.O. = new DataView(value.BaseTable, "", "TaskID", DataViewRowState.CurrentRows);
				}
				else
				{
					this.oo0ooO000O.O. = null;
				}
				((ISupportInitialize)this).EndInit();
				((ISupportInitialize)base.DataStorage.TasksStorage).EndInit();
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00070A28 File Offset: 0x0006EC28
		public void SaveSettings()
		{
			DayTimesKind dayTimesKind = base.DefaultWorkWeek.SundayTimes.DayTimesKind;
			if (dayTimesKind == DayTimesKind.UseDefaultTimes)
			{
				base.DefaultWorkWeek.SundayTimes.DayTimesKind = DayTimesKind.NonworkingTime;
			}
			else
			{
				base.DefaultWorkWeek.SundayTimes.DayTimesKind = DayTimesKind.UseDefaultTimes;
			}
			base.DefaultWorkWeek.SundayTimes.DayTimesKind = dayTimesKind;
			if (base.DataStorage.PropertyStorage.DataSource != null)
			{
				JArray jarray = new JArray();
				try
				{
					foreach (BarStyle barStyle in base.BarStyles)
					{
						JObject item = this.OO0oo.o0.(barStyle, new BarStyle
						{
							BarType = barStyle.BarType
						});
						jarray.Add(item);
					}
				}
				finally
				{
					IEnumerator<BarStyle> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				DataTable dataTable = (DataTable)base.DataStorage.PropertyStorage.DataSource;
				DataRow dataRow = dataTable.Rows.Find("Extend\\BarStyles");
				if (jarray.Count == 0)
				{
					if (dataRow != null)
					{
						dataRow["Value"] = DBNull.Value;
					}
				}
				else
				{
					if (dataRow == null)
					{
						dataRow = dataTable.NewRow();
						dataRow["Key"] = "Extend\\BarStyles";
						dataTable.Rows.Add(dataRow);
					}
					dataRow["Value"] = jarray.ToString(Formatting.None).Replace("\r\n", "");
				}
			}
			int num = base.Tasks.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Task task = base.Tasks[i];
				int num2 = this.oo0ooO000O.O..Find(task.ID);
				int num3 = -1;
				if (i < base.Tasks.Count - 1)
				{
					num3 = base.Tasks[i + 1].ID;
				}
				if (num2 >= 0)
				{
					DataRow row = this.oo0ooO000O.O.[num2].Row;
					if (Operators.ConditionalCompareObjectNotEqual(row["NextID"], num3, true))
					{
						row["NextID"] = num3;
					}
					if (task.Inactive)
					{
						row["Inactive"] = true;
					}
					else
					{
						row["Inactive"] = DBNull.Value;
					}
					string text = this.OO0oo.o0.(task);
					if (Operators.CompareString(text, "", true) == 0)
					{
						if (!row.IsNull("FieldStyle"))
						{
							row["FieldStyle"] = DBNull.Value;
						}
					}
					else
					{
						row["FieldStyle"] = text;
					}
				}
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00070CC4 File Offset: 0x0006EEC4
		public void LoadSettings()
		{
			if (base.DataStorage.PropertyStorage.DataSource != null)
			{
				DataRow dataRow = ((DataTable)base.DataStorage.PropertyStorage.DataSource).Rows.Find("Extend\\BarStyles");
				if (dataRow != null && !dataRow.IsNull("Value"))
				{
					this.OO0oo.o0.(dataRow["Value"].ToString(), base.BarStyles);
				}
			}
			if (base.DataStorage.TasksStorage.DataSource != null)
			{
				try
				{
					foreach (object obj in ((DataTable)base.DataStorage.TasksStorage.DataSource).Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						if (!dataRow2.IsNull("BarStyle") || !dataRow2.IsNull("FieldStyle") || !dataRow2.IsNull("Inactive"))
						{
							Task task = base.Tasks.Search(Conversions.ToInteger(dataRow2["TaskID"]));
							if (task != null)
							{
								if (!dataRow2.IsNull("BarStyle"))
								{
									this.OO0oo.o0.(dataRow2["BarStyle"].ToString(), task.BarStyles);
								}
								if (!dataRow2.IsNull("FieldStyle"))
								{
									this.OO0oo.o0.(task, dataRow2["FieldStyle"].ToString());
								}
								if (!dataRow2.IsNull("Inactive"))
								{
									task.Inactive = Conversions.ToBoolean(dataRow2["Inactive"]);
								}
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

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00070E64 File Offset: 0x0006F064
		private string <<EMPTY_NAME>>(Task A_0)
		{
			string result;
			if (A_0.FieldStyles.Count == 0)
			{
				result = "";
			}
			else
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)base.Controls[2];
				Font font = c1FlexGrid.Styles.Normal.Font;
				Color foreColor = c1FlexGrid.Styles.Normal.ForeColor;
				Color backColor = c1FlexGrid.Styles.Normal.BackColor;
				JArray jarray = new JArray();
				try
				{
					foreach (FieldStyle fieldStyle in A_0.FieldStyles)
					{
						JObject jobject = new JObject();
						jobject["Field"] = (int)fieldStyle.Field;
						if (fieldStyle.BackColor.ToArgb() != backColor.ToArgb())
						{
							jobject["BackColor"] = fieldStyle.BackColor.ToArgb();
						}
						if (fieldStyle.ForeColor.ToArgb() != foreColor.ToArgb())
						{
							jobject["ForeColor"] = fieldStyle.ForeColor.ToArgb();
						}
						if (Operators.CompareString(font.Name, fieldStyle.Font.Name, true) != 0 || font.Size != fieldStyle.Font.Size || font.Style != fieldStyle.Font.Style)
						{
							if (Operators.CompareString(font.Name, fieldStyle.Font.Name, true) != 0)
							{
								jobject["FontName"] = fieldStyle.Font.Name;
							}
							if (font.Size != fieldStyle.Font.Size)
							{
								jobject["FontSize"] = fieldStyle.Font.Size;
							}
							if (font.Style != fieldStyle.Font.Style)
							{
								jobject["FontStyle"] = (int)fieldStyle.Font.Style;
							}
						}
						if (jobject.Count > 1)
						{
							jarray.Add(jobject);
						}
					}
				}
				finally
				{
					IEnumerator<FieldStyle> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (jarray.Count > 0)
				{
					result = jarray.ToString();
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000710C4 File Offset: 0x0006F2C4
		private void <<EMPTY_NAME>>(Task A_0, string A_1)
		{
			JArray jarray = JArray.Parse(A_1);
			Font font = ((C1FlexGrid)base.Controls[2]).Styles.Normal.Font;
			try
			{
				foreach (JToken jtoken in jarray)
				{
					JObject jobject = (JObject)jtoken;
					FieldStyle fieldStyle = new FieldStyle();
					fieldStyle.Field = (StyleField)((int)jobject["Field"]);
					if (jobject.ContainsKey("BackColor"))
					{
						fieldStyle.BackColor = Color.FromArgb((int)jobject["BackColor"]);
					}
					if (jobject.ContainsKey("ForeColor"))
					{
						fieldStyle.ForeColor = Color.FromArgb((int)jobject["ForeColor"]);
					}
					if (jobject.ContainsKey("FontName") || jobject.ContainsKey("FontSize") || jobject.ContainsKey("FontStyle"))
					{
						string familyName = font.Name;
						float emSize = font.Size;
						FontStyle style = font.Style;
						if (jobject.ContainsKey("FontName"))
						{
							familyName = jobject["FontName"].ToString();
						}
						if (jobject.ContainsKey("FontSize"))
						{
							emSize = (float)jobject["FontSize"];
						}
						if (jobject.ContainsKey("FontStyle"))
						{
							style = (FontStyle)((int)jobject["FontStyle"]);
						}
						fieldStyle.Font = new Font(familyName, emSize, style);
					}
					A_0.FieldStyles.Add(fieldStyle);
				}
			}
			finally
			{
				IEnumerator<JToken> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00071274 File Offset: 0x0006F474
		private void <<EMPTY_NAME>>(DataRow A_0, Task A_1 = null)
		{
			if (A_1 == null)
			{
				A_1 = base.Tasks.Search(Conversions.ToInteger(A_0["TaskID"]));
			}
			if (A_1 == null || A_1.BarStyles.Count == 0)
			{
				A_0["BarStyle"] = DBNull.Value;
				return;
			}
			List<BarType> list = new List<BarType>();
			if (A_1.Summary)
			{
				list.Add(BarType.SummaryTask);
				list.Add(BarType.SummaryProgress);
			}
			else if (A_1.Duration == 0.0)
			{
				list.Add(BarType.Milestone);
			}
			else
			{
				if (A_1.Mode == TaskMode.Automatic)
				{
					list.Add(BarType.AutoTask);
				}
				else
				{
					list.Add(BarType.ManualTask);
				}
				list.Add(BarType.Progress);
			}
			if (list.Count != 0)
			{
				JArray jarray = new JArray();
				try
				{
					foreach (BarType barType in list)
					{
						BarStyle barStyle = A_1.BarStyles.Search(barType);
						if (barStyle != null)
						{
							BarStyle barStyle2 = base.BarStyles.Search(barType);
							if (barStyle2 == null)
							{
								barStyle2 = new BarStyle();
								barStyle2.BarType = barType;
							}
							JObject jobject = this.OO0oo.o0.(barStyle, barStyle2);
							if (jobject.Count > 1)
							{
								jarray.Add(jobject);
							}
						}
					}
				}
				finally
				{
					List<BarType>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (jarray.Count == 0)
				{
					A_0["BarStyle"] = DBNull.Value;
					return;
				}
				A_0["BarStyle"] = jarray.ToString(Formatting.None).Replace("\r\n", "");
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000713F0 File Offset: 0x0006F5F0
		private void <<EMPTY_NAME>>(string A_0, BarStyleCollection A_1)
		{
			JArray jarray = JArray.Parse(A_0);
			try
			{
				foreach (JToken jtoken in jarray)
				{
					JObject jobject = (JObject)jtoken;
					BarType barType = (BarType)((int)jobject["BarType"]);
					BarStyle barStyle = A_1.Search(barType);
					if (barStyle == null)
					{
						if (A_1 != base.BarStyles)
						{
							BarStyle barStyle2 = base.BarStyles.Search(barType);
							if (barStyle2 != null)
							{
								barStyle = (BarStyle)barStyle2.Clone();
							}
						}
						if (barStyle == null)
						{
							barStyle = new BarStyle();
							barStyle.BarType = barType;
						}
						A_1.Add(barStyle);
					}
					if (jobject.ContainsKey("BarHeight"))
					{
						barStyle.BarHeight = (int)jobject["BarHeight"];
					}
					if (jobject.ContainsKey("BottomText1_ID"))
					{
						barStyle.BottomText1_ID = (int)jobject["BottomText1_ID"];
					}
					if (jobject.ContainsKey("BottomText2_ID"))
					{
						barStyle.BottomText2_ID = (int)jobject["BottomText2_ID"];
					}
					if (jobject.ContainsKey("TopText1_ID"))
					{
						barStyle.TopText1_ID = (int)jobject["TopText1_ID"];
					}
					if (jobject.ContainsKey("TopText2_ID"))
					{
						barStyle.TopText2_ID = (int)jobject["TopText2_ID"];
					}
					if (jobject.ContainsKey("LeftText1_ID"))
					{
						barStyle.LeftText1_ID = (int)jobject["LeftText1_ID"];
					}
					if (jobject.ContainsKey("LeftText2_ID"))
					{
						barStyle.LeftText2_ID = (int)jobject["LeftText2_ID"];
					}
					if (jobject.ContainsKey("RightText1_ID"))
					{
						barStyle.RightText1_ID = (int)jobject["RightText1_ID"];
					}
					if (jobject.ContainsKey("RightText2_ID"))
					{
						barStyle.RightText2_ID = (int)jobject["RightText2_ID"];
					}
					if (jobject.ContainsKey("AdaptiveBarHeight"))
					{
						barStyle.AdaptiveBarHeight = (bool)jobject["AdaptiveBarHeight"];
					}
					if (jobject.ContainsKey("BarShape"))
					{
						barStyle.BarShape = (BarShape)((int)jobject["BarShape"]);
					}
					if (jobject.ContainsKey("BarPattern"))
					{
						barStyle.BarPattern = (HatchPattern)((int)jobject["BarPattern"]);
					}
					if (jobject.ContainsKey("BarColor"))
					{
						barStyle.BarColor = Color.FromArgb(Conversions.ToInteger(jobject["BarColor"].ToString()));
					}
					if (jobject.ContainsKey("EndShape"))
					{
						barStyle.EndShape = (int)jobject["EndShape"];
					}
					if (jobject.ContainsKey("EndPattern"))
					{
						barStyle.EndPattern = (HatchPattern)((int)jobject["BarPattern"]);
					}
					if (jobject.ContainsKey("EndColor"))
					{
						barStyle.EndColor = Color.FromArgb(Conversions.ToInteger(jobject["BarColor"].ToString()));
					}
					if (jobject.ContainsKey("StartShape"))
					{
						barStyle.StartShape = (int)jobject["StartShape"];
					}
					if (jobject.ContainsKey("StartPattern"))
					{
						barStyle.StartPattern = (HatchPattern)((int)jobject["BarPattern"]);
					}
					if (jobject.ContainsKey("StartColor"))
					{
						barStyle.StartColor = Color.FromArgb(Conversions.ToInteger(jobject["StartColor"].ToString()));
					}
				}
			}
			finally
			{
				IEnumerator<JToken> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0007177C File Offset: 0x0006F97C
		private JObject <<EMPTY_NAME>>(BarStyle A_0, BarStyle A_1)
		{
			JObject jobject = new JObject();
			jobject["BarType"] = (int)A_0.BarType;
			if (A_0.AdaptiveBarHeight != A_1.AdaptiveBarHeight)
			{
				jobject["AdaptiveBarHeight"] = A_0.AdaptiveBarHeight;
			}
			if (!A_1.AdaptiveBarHeight && A_0.BarHeight != A_1.BarHeight)
			{
				jobject["BarHeight"] = A_0.BarHeight;
			}
			if (A_0.BottomText1_ID != A_1.BottomText1_ID)
			{
				jobject["BottomText1_ID"] = A_0.BottomText1_ID;
			}
			if (A_0.BottomText2_ID != A_1.BottomText2_ID)
			{
				jobject["BottomText2_ID"] = A_0.BottomText2_ID;
			}
			if (A_0.TopText1_ID != A_1.TopText1_ID)
			{
				jobject["TopText1_ID"] = A_0.TopText1_ID;
			}
			if (A_0.TopText2_ID != A_1.TopText2_ID)
			{
				jobject["TopText2_ID"] = A_0.TopText2_ID;
			}
			if (A_0.LeftText1_ID != A_1.LeftText1_ID)
			{
				jobject["LeftText1_ID"] = A_0.LeftText1_ID;
			}
			if (A_0.LeftText2_ID != A_1.LeftText2_ID)
			{
				jobject["LeftText2_ID"] = A_0.LeftText2_ID;
			}
			if (A_0.RightText1_ID != A_1.RightText1_ID)
			{
				jobject["RightText1_ID"] = A_0.RightText1_ID;
			}
			if (A_0.RightText2_ID != A_1.RightText2_ID)
			{
				jobject["RightText2_ID"] = A_0.RightText2_ID;
			}
			if (A_0.BarShape != A_1.BarShape)
			{
				jobject["BarShape"] = (int)A_0.BarShape;
			}
			if (A_0.BarShape != BarShape.None)
			{
				if (A_0.BarPattern != A_1.BarPattern)
				{
					jobject["BarPattern"] = (int)A_0.BarPattern;
				}
				if (A_0.BarColor != A_1.BarColor)
				{
					jobject["BarColor"] = A_0.BarColor.ToArgb();
				}
			}
			if (A_0.EndShape != A_1.EndShape)
			{
				jobject["EndShape"] = A_0.EndShape;
			}
			if (A_0.EndShape != 0)
			{
				if (A_0.EndPattern != A_1.EndPattern)
				{
					jobject["EndPattern"] = (int)A_0.EndPattern;
				}
				if (A_0.EndColor != A_0.EndColor)
				{
					jobject["EndColor"] = A_0.EndColor.ToArgb();
				}
			}
			if (A_0.StartShape != A_1.StartShape)
			{
				jobject["StartShape"] = A_0.StartShape;
			}
			if (A_0.StartShape != 0)
			{
				if (A_0.StartPattern != A_1.StartPattern)
				{
					jobject["StartPattern"] = (int)A_0.StartPattern;
				}
				if (A_0.StartColor != A_0.StartColor)
				{
					jobject["StartColor"] = A_0.StartColor.ToArgb();
				}
			}
			return jobject;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00071A9C File Offset: 0x0006FC9C
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			if (A_1.Task is Task && base.DataStorage.TasksStorage.DataSource != null)
			{
				int num = this.oo0ooO000O.O..Find(A_1.Task.ID);
				if (num >= 0)
				{
					DataRow row = this.oo0ooO000O.O.[num].Row;
					this.OO0oo.o0.(row, (Task)A_1.Task);
				}
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00071B0C File Offset: 0x0006FD0C
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			if (A_1.Task != null && !A_1.Task.Initialized)
			{
				A_1.Task.Mode = TaskMode.Automatic;
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00071B2F File Offset: 0x0006FD2F
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.oo0ooO000O.O. = DateTime.Now;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00071B3C File Offset: 0x0006FD3C
		public Strip Strip
		{
			get
			{
				return new Strip(base.ToolStrip, null);
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00071B4C File Offset: 0x0006FD4C
		public void SetColumns(TaskProperty[] Properties, string[] Captions, int[] Widths, bool[] Visibles)
		{
			((ISupportInitialize)this).BeginInit();
			if (Properties.Length != Captions.Length || Captions.Length != Widths.Length || Widths.Length != Visibles.Length)
			{
				MessageBox.Show("数组长度不一致！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			base.Columns.Clear();
			int num = Properties.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				TaskPropertyColumn taskPropertyColumn = new TaskPropertyColumn();
				taskPropertyColumn.Property = Properties[i];
				taskPropertyColumn.Caption = Captions[i];
				taskPropertyColumn.Width = Widths[i];
				taskPropertyColumn.Visible = Visibles[i];
				base.Columns.Add(taskPropertyColumn);
			}
			((ISupportInitialize)this).EndInit();
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00071BE5 File Offset: 0x0006FDE5
		public void SetComboList(string Name, string ComboList)
		{
			this.oo0ooO000O.O..Add(Name, ComboList);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00071BF4 File Offset: 0x0006FDF4
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
			string name = c1FlexGrid.Cols[A_1.Col].Name;
			try
			{
				foreach (string text in this.oo0ooO000O.O..Keys)
				{
					if (Operators.CompareString(text, name, true) == 0)
					{
						c1FlexGrid.Cols[A_1.Col].ComboList = this.oo0ooO000O.O.[text];
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00071C90 File Offset: 0x0006FE90
		public void <<EMPTY_NAME>>(string A_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400054F RID: 1359
		private System.Windows.Forms.Label <<EMPTY_NAME>>;

		// Token: 0x04000550 RID: 1360
		internal DateTime <<EMPTY_NAME>>;

		// Token: 0x04000551 RID: 1361
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04000552 RID: 1362
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
