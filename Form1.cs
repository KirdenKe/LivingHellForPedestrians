using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingHellForPedestrians
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton_CHY.Parent = pictureBox_taiwan;
            radioButton_CWH.Parent = pictureBox_taiwan;
            radioButton_CYI.Parent = pictureBox_taiwan;
            radioButton_HSC.Parent = pictureBox_taiwan;
            radioButton_HSH.Parent = pictureBox_taiwan;
            radioButton_HWA.Parent = pictureBox_taiwan;
            radioButton_ILN.Parent = pictureBox_taiwan;
            radioButton_IUH.Parent = pictureBox_taiwan;
            radioButton_KHH.Parent = pictureBox_taiwan;
            radioButton_KLU.Parent = pictureBox_taiwan;
            radioButton_KMN.Parent = pictureBox_taiwan;
            radioButton_LNN.Parent = pictureBox_taiwan;
            radioButton_MAL.Parent = pictureBox_taiwan;
            radioButton_NTO.Parent = pictureBox_taiwan;
            radioButton_PEH.Parent = pictureBox_taiwan;
            radioButton_TNN.Parent = pictureBox_taiwan;
            radioButton_TPE.Parent = pictureBox_taiwan;
            radioButton_TPH.Parent = pictureBox_taiwan;
            radioButton_TTT.Parent = pictureBox_taiwan;
            radioButton_TXG.Parent = pictureBox_taiwan;
            radioButton_TYC.Parent = pictureBox_taiwan;
            radioButton_YLH.Parent = pictureBox_taiwan;
            loadFile = new LoadFile();
            loadFile.StateHandler += HowState;
            comboBox_DisplayType.Items.AddRange(AccidentType);
            listBox_DisplayType.Items.AddRange(ToolAccidentType);
            comboBox_ToolType.Items.AddRange(ToolType);
            comboBox_UpdateType.Items.AddRange(PlaceType);
            listBox_ShowUpdateType.Items.AddRange(AccidentType);
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            loadFile.LivingHell.Clear();
            _ = loadFile.LoadAccident();
            button_LoadFile.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadFile.Dispose();
        }
        private void HowState(object sender, StateArgs e)
        {
            if(e.isSuccessed)
            {
                checkBox_ShowMap.Enabled = true;
                comboBox_DisplayType.Enabled = true;
                comboBox_years.Enabled = true;
                comboBox_AgeDeath.Enabled = true;
                listBox_DisplayType.Enabled = true;
                listBox_years.Enabled = true;
                comboBox_ToolType.Enabled = true;
                radioButton_UpdatePlace.Enabled = true;
                radioButton_UpdateTool.Enabled = true;
                radioButton_UpdateAge.Enabled = true;
                comboBox_UpdateType.Enabled = true;
                listBox_ShowUpdateType.Enabled = true;
                dataGridView_UpdateData.Enabled = true;
                textBox_AddNumber.Enabled = true;
                button_UpdateData.Enabled = true;
                LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Place); });
                var places = LivingHellSelect.Select<object, Place>(x => (Place)x);
                minYearValue = places.Select<Place, int>(x => x.Year).Min();
                maxYearValue = places.Select<Place, int>(x => x.Year).Max();
                for(int i = minYearValue; i < maxYearValue + 1; i ++)
                {
                    comboBox_years.Items.Add(i);
                    listBox_years.Items.Add(i);
                    comboBox_AgeDeath.Items.Add(i);
                }
                comboBox_years.SelectedIndex = 0;
                comboBox_DisplayType.SelectedIndex = 0;
                comboBox_ToolType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(e.ErrorMessage, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button_LoadFile.Enabled = true;
        }

        private void checkBox_ShowMap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowMap.Checked)
                panel.Visible = true;
            else
                panel.Visible = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loadFile.LivingHell != null)
            {
                if(tabControl.SelectedIndex == 0)
                    LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Place); });
                else if(tabControl.SelectedIndex == 1)
                    LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Tool); });
                else if(tabControl.SelectedIndex == 2)
                    LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(AgeDead); });
            }
        }

        private void radioButton_Place_CheckedChanged(object sender, EventArgs e)
        {
            ChangedData();
        }
        private void ChangedData()
        {
            int AccidentTypeIndex = comboBox_DisplayType.SelectedIndex;
            int year = int.Parse(comboBox_years.Text);
            var places = LivingHellSelect.Select<object, Place>(x => (Place)x);
            foreach (Place place in places)
            {
                if (radioButton_TPH.Checked)
                {
                    if (place.county == County.TPH && place.Year == year)
                        label_ShowNumber.Text = String.Format("新北市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_KLU.Checked)
                {
                    if (place.county == County.KLU && place.Year == year)
                        label_ShowNumber.Text = String.Format("基隆市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_TPE.Checked)
                {
                    if (place.county == County.TPE && place.Year == year)
                        label_ShowNumber.Text = String.Format("臺北市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_TYC.Checked)
                {
                    if (place.county == County.TYC && place.Year == year)
                        label_ShowNumber.Text = String.Format("桃園市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_HSH.Checked)
                {
                    if (place.county == County.HSH && place.Year == year)
                        label_ShowNumber.Text = String.Format("新竹縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_HSC.Checked)
                {
                    if (place.county == County.HSC && place.Year == year)
                        label_ShowNumber.Text = String.Format("新竹市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_MAL.Checked)
                {
                    if (place.county == County.MAL && place.Year == year)
                        label_ShowNumber.Text = String.Format("苗栗縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_TXG.Checked)
                {
                    if (place.county == County.TXG && place.Year == year)
                        label_ShowNumber.Text = String.Format("臺中市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_CWH.Checked)
                {
                    if (place.county == County.CWH && place.Year == year)
                        label_ShowNumber.Text = String.Format("彰化縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_NTO.Checked)
                {
                    if (place.county == County.NTO && place.Year == year)
                        label_ShowNumber.Text = String.Format("南投縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_YLH.Checked)
                {
                    if (place.county == County.YLH && place.Year == year)
                        label_ShowNumber.Text = String.Format("雲林縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_CHY.Checked)
                {
                    if (place.county == County.CHY && place.Year == year)
                        label_ShowNumber.Text = String.Format("嘉義縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_CYI.Checked)
                {
                    if (place.county == County.CYI && place.Year == year)
                        label_ShowNumber.Text = String.Format("嘉義市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_TNN.Checked)
                {
                    if (place.county == County.TNN && place.Year == year)
                        label_ShowNumber.Text = String.Format("臺南市{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_KHH.Checked)
                {
                    if (place.county == County.KHH && place.Year == year)
                        label_ShowNumber.Text = String.Format("高雄縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_IUH.Checked)
                {
                    if (place.county == County.IUH && place.Year == year)
                        label_ShowNumber.Text = String.Format("屏東縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_ILN.Checked)
                {
                    if (place.county == County.ILN && place.Year == year)
                        label_ShowNumber.Text = String.Format("宜蘭縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_HWA.Checked)
                {
                    if (place.county == County.HWA && place.Year == year)
                        label_ShowNumber.Text = String.Format("花蓮縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_TTT.Checked)
                {
                    if (place.county == County.TTT && place.Year == year)
                        label_ShowNumber.Text = String.Format("臺東縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_PEH.Checked)
                {
                    if (place.county == County.PEH && place.Year == year)
                        label_ShowNumber.Text = String.Format("澎湖縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_KMN.Checked)
                {
                    if (place.county == County.KMN && place.Year == year)
                        label_ShowNumber.Text = String.Format("金門縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
                if (radioButton_LNN.Checked)
                {
                    if (place.county == County.LNN && place.Year == year)
                        label_ShowNumber.Text = String.Format("連江縣{0}：\r\n{1}", comboBox_DisplayType.Text, place.Number(AccidentTypeIndex));
                }
            }
        }

        private void comboBox_Place_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedData();
        }

        private void listBox_Tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadFile.LivingHell == null) return;
            var tools = LivingHellSelect.Select<object, Tool>(x => (Tool)x);
            int[] YearValue = new int[listBox_years.SelectedIndices.Count];
            int[] AccidentValue = new int[listBox_years.SelectedIndices.Count];
            int[] DeathValue = new int[listBox_years.SelectedIndices.Count];
            int[] InjuredValue = new int[listBox_years.SelectedIndices.Count];
            for (int i = 0; i < listBox_years.SelectedIndices.Count; i++)
            {
                int year = (int)listBox_years.Items[listBox_years.SelectedIndices[i]];
                YearValue[i] = year;
                foreach (Tool tool in tools)
                {
                    if(tool.Year ==  year && (int)tool.Type == comboBox_ToolType.SelectedIndex)
                    {
                        for(int j = 0; j < listBox_DisplayType.SelectedIndices.Count; j++)
                        {
                            if (listBox_DisplayType.SelectedIndices[j] == 0)
                                AccidentValue[i] = tool.Number(0);
                            if (listBox_DisplayType.SelectedIndices[j] == 1)
                                DeathValue[i] = tool.Number(1);
                            if (listBox_DisplayType.SelectedIndices[j] == 2)
                                InjuredValue[i] = tool.Number(2);
                        }
                    }
                }
            }
            var AccidentSeries = chart_tool.Series[0];
            AccidentSeries.Points.DataBindXY(YearValue, AccidentValue);
            var DeathSeries = chart_tool.Series[1];
            DeathSeries.Points.DataBindXY(YearValue, DeathValue);
            var InjuredSeries = chart_tool.Series[2];
            InjuredSeries.Points.DataBindXY(YearValue, InjuredValue);
        }

        private void comboBox_AgeDeath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadFile.LivingHell == null) return;
            var ageDeadthes = LivingHellSelect.Select<object, AgeDead>(x => (AgeDead)x);
            string[] AgeValue = new string[] { "~12", "12~17", "18~24", "25~64", "65~" };
            foreach(AgeDead ageDead in ageDeadthes)
            {
                if(ageDead.Year == int.Parse(comboBox_AgeDeath.Text))
                {
                    int[] DeathValue = new int[] { ageDead.under12years, ageDead.between12to17, ageDead.between18to24, ageDead.between25to64, ageDead.upper65 };
                    var AgeSeries = chart_AgeDeath.Series[0];
                    AgeSeries.Points.DataBindXY(AgeValue, DeathValue);
                }
            }
        }

        private void radioButton_Update_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_UpdateType.Items.Clear();
            listBox_ShowUpdateType.Items.Clear();
            textBox_AddNumber.Enabled = true;
            if(radioButton_UpdatePlace.Checked)
            {
                comboBox_UpdateType.Items.AddRange(PlaceType);
                listBox_ShowUpdateType.Items.AddRange(AccidentType);
                LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Place); });
                    
            }
            if(radioButton_UpdateTool.Checked)
            {
                comboBox_UpdateType.Items.AddRange(ToolType);
                listBox_ShowUpdateType.Items.AddRange(ToolAccidentType);
                LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Tool); });
            }
            if(radioButton_UpdateAge.Checked)
            {
                textBox_AddNumber.Enabled = false;
                LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(AgeDead); });
                dataTable = new DataTable();
                var ageDeadthes = LivingHellSelect.Select<object, AgeDead>(x => (AgeDead)x);
                for (int i = minYearValue; i < maxYearValue + 1; i++)
                {
                    dataTable.Columns.Add(i.ToString(), typeof(int));
                }
                for (int i = 0; i < AgeRange.Length; i++)
                {
                    var row = dataTable.NewRow();
                    for (int j = minYearValue; j < maxYearValue + 1; j++)
                    {
                        foreach (AgeDead ageDead in ageDeadthes)
                        {
                            if (ageDead.Year == j)
                                row[j - minYearValue] = ageDead.Number(i);
                        }
                    }
                    dataTable.Rows.Add(row);
                }
                dataGridView_UpdateData.DataSource = dataTable;
                for (int i = 0; i < dataGridView_UpdateData.Rows.Count - 1; i++)
                {
                    dataGridView_UpdateData.Rows[i].HeaderCell.Value = AgeRange[i];
                }
            }
        }

        private void Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            if(radioButton_UpdatePlace.Checked)
            {
                var places = LivingHellSelect.Select<object, Place>(x => (Place)x);
                for (int i = minYearValue; i < maxYearValue + 1; i++)
                {
                    dataTable.Columns.Add(i.ToString(), typeof(int));
                }
                for (int i = 0; i < listBox_ShowUpdateType.SelectedIndices.Count; i++)
                {
                    var row = dataTable.NewRow();
                    for (int j = 0; j < maxYearValue - minYearValue + 1; j++)
                    {
                        foreach(Place place in places)
                        {
                            if((int)place.county == comboBox_UpdateType.SelectedIndex && place.Year == minYearValue + j)
                                row[j] = place.Number(listBox_ShowUpdateType.SelectedIndices[i]);
                        }
                    }
                    dataTable.Rows.Add(row);
                }
            }
            if(radioButton_UpdateTool.Checked)
            {
                var tools = LivingHellSelect.Select<object, Tool>(x => (Tool)x);
                for (int i = minYearValue; i < maxYearValue + 1; i++)
                {
                    dataTable.Columns.Add(i.ToString(), typeof(int));
                }
                for (int i = 0; i < listBox_ShowUpdateType.SelectedIndices.Count; i++)
                {
                    var row = dataTable.NewRow();
                    for (int j = 0; j < maxYearValue - minYearValue + 1; j++)
                    {
                        foreach (Tool tool in tools)
                        {
                            if ((int)tool.Type == comboBox_UpdateType.SelectedIndex && tool.Year == minYearValue + j)
                                row[j] = tool.Number(listBox_ShowUpdateType.SelectedIndices[i]);
                        }
                    }
                    dataTable.Rows.Add(row);
                }
            }
            dataGridView_UpdateData.DataSource = dataTable;
        }

        private void button_UpdateData_Click(object sender, EventArgs e)
        {
            if(textBox_AddNumber.Text != null && textBox_AddNumber.Text != "0")
            {
                if(listBox_ShowUpdateType.SelectedIndices.Count == 1)
                {
                    if (radioButton_UpdatePlace.Checked)
                    {
                        var places = LivingHellSelect.Select<object, Place>(x => (Place)x);
                        foreach (Place place in places)
                        {
                            if ((int)place.county == comboBox_UpdateType.SelectedIndex && place.Year == maxYearValue)
                            {
                                int i = loadFile.LivingHell.IndexOf(place);
                                place.listBoxIndex = listBox_ShowUpdateType.SelectedIndex;
                                if(int.TryParse(textBox_AddNumber.Text, out int NewNumber))
                                {
                                    loadFile.LivingHell[i] = place + NewNumber;
                                }
                            }
                        }
                    }
                    if(radioButton_UpdateTool.Checked)
                    {
                        var tools = LivingHellSelect.Select<object, Tool>(x => (Tool)x);
                        foreach (Tool tool in tools)
                        {
                            if ((int)tool.Type == comboBox_UpdateType.SelectedIndex && tool.Year == maxYearValue)
                            {
                                int i = loadFile.LivingHell.IndexOf(tool);
                                tool.listBoxIndex = listBox_ShowUpdateType.SelectedIndex;
                                if (int.TryParse(textBox_AddNumber.Text, out int NewNumber))
                                {
                                    loadFile.LivingHell[i] = tool + NewNumber;
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("請只選擇一個項目！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var currenDataTable = (DataTable)dataGridView_UpdateData.DataSource;
            }
            Update_SelectedIndexChanged(sender, e);
        }
    }
}
