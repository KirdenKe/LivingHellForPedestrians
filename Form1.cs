using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            radioButton_NTC.Parent = pictureBox_taiwan;
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
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            _ = loadFile.LoadAccident();
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
                listBox_DisplayType.Enabled = true;
                listBox_years.Enabled = true;
                comboBox_ToolType.Enabled = true;
                LivingHellSelect = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Place); });
                var places = LivingHellSelect.Select<object, Place>(x => (Place)x);
                var minValue = places.Select<Place, int>(x => x.Year).Min();
                var maxValue = places.Select<Place, int>(x => x.Year).Max();
                for(int i = minValue; i < maxValue + 1; i ++)
                {
                    comboBox_years.Items.Add(i);
                    listBox_years.Items.Add(i);
                }
                comboBox_years.SelectedIndex = 0;
                comboBox_DisplayType.SelectedIndex = 0;
                comboBox_ToolType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(e.ErrorMessage, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if(tool.Year ==  year && comboBox_ToolType.SelectedIndex == 7)
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
    }
}
