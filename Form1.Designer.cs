using System.Collections.Generic;

namespace LivingHellForPedestrians
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        List<object> LivingHellSelect;
        LoadFile loadFile;
        string[] AccidentType = new string[]{
            "事故件數",
            "死亡人數",
            "受傷人數",
            "酒駕事故件數",
            "酒駕死亡人數",
            "酒駕受傷人數"};
        string[] ToolAccidentType = new string[]{
            "事故件數",
            "死亡人數",
            "受傷人數"};
        string[] ToolType = new string[]{
            "大客車",
            "大貨車",
            "小客車",
            "小貨車",
            "特種車",
            "機車",
            "自行車",
            "行人",
            "乘客",
            "其他",};

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.label_ShowNumber = new System.Windows.Forms.Label();
            this.radioButton_LNN = new System.Windows.Forms.RadioButton();
            this.radioButton_KMN = new System.Windows.Forms.RadioButton();
            this.radioButton_CYI = new System.Windows.Forms.RadioButton();
            this.radioButton_HSC = new System.Windows.Forms.RadioButton();
            this.radioButton_KLU = new System.Windows.Forms.RadioButton();
            this.radioButton_PEH = new System.Windows.Forms.RadioButton();
            this.radioButton_HWA = new System.Windows.Forms.RadioButton();
            this.radioButton_TTT = new System.Windows.Forms.RadioButton();
            this.radioButton_IUH = new System.Windows.Forms.RadioButton();
            this.radioButton_CHY = new System.Windows.Forms.RadioButton();
            this.radioButton_YLH = new System.Windows.Forms.RadioButton();
            this.radioButton_NTC = new System.Windows.Forms.RadioButton();
            this.radioButton_CWH = new System.Windows.Forms.RadioButton();
            this.radioButton_MAL = new System.Windows.Forms.RadioButton();
            this.radioButton_HSH = new System.Windows.Forms.RadioButton();
            this.radioButton_ILN = new System.Windows.Forms.RadioButton();
            this.radioButton_KHH = new System.Windows.Forms.RadioButton();
            this.radioButton_TNN = new System.Windows.Forms.RadioButton();
            this.radioButton_TXG = new System.Windows.Forms.RadioButton();
            this.radioButton_TYC = new System.Windows.Forms.RadioButton();
            this.radioButton_TPE = new System.Windows.Forms.RadioButton();
            this.radioButton_TPH = new System.Windows.Forms.RadioButton();
            this.pictureBox_taiwan = new System.Windows.Forms.PictureBox();
            this.comboBox_DisplayType = new System.Windows.Forms.ComboBox();
            this.comboBox_years = new System.Windows.Forms.ComboBox();
            this.checkBox_ShowMap = new System.Windows.Forms.CheckBox();
            this.button_LoadFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_DisplayType = new System.Windows.Forms.ListBox();
            this.chart_tool = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_ToolType = new System.Windows.Forms.ComboBox();
            this.listBox_years = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox_AgeDeath = new System.Windows.Forms.ComboBox();
            this.chart_AgeDeath = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_taiwan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tool)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_AgeDeath)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(875, 545);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Controls.Add(this.comboBox_DisplayType);
            this.tabPage1.Controls.Add(this.comboBox_years);
            this.tabPage1.Controls.Add(this.checkBox_ShowMap);
            this.tabPage1.Controls.Add(this.button_LoadFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "事故總覽";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_ShowNumber);
            this.panel.Controls.Add(this.radioButton_LNN);
            this.panel.Controls.Add(this.radioButton_KMN);
            this.panel.Controls.Add(this.radioButton_CYI);
            this.panel.Controls.Add(this.radioButton_HSC);
            this.panel.Controls.Add(this.radioButton_KLU);
            this.panel.Controls.Add(this.radioButton_PEH);
            this.panel.Controls.Add(this.radioButton_HWA);
            this.panel.Controls.Add(this.radioButton_TTT);
            this.panel.Controls.Add(this.radioButton_IUH);
            this.panel.Controls.Add(this.radioButton_CHY);
            this.panel.Controls.Add(this.radioButton_YLH);
            this.panel.Controls.Add(this.radioButton_NTC);
            this.panel.Controls.Add(this.radioButton_CWH);
            this.panel.Controls.Add(this.radioButton_MAL);
            this.panel.Controls.Add(this.radioButton_HSH);
            this.panel.Controls.Add(this.radioButton_ILN);
            this.panel.Controls.Add(this.radioButton_KHH);
            this.panel.Controls.Add(this.radioButton_TNN);
            this.panel.Controls.Add(this.radioButton_TXG);
            this.panel.Controls.Add(this.radioButton_TYC);
            this.panel.Controls.Add(this.radioButton_TPE);
            this.panel.Controls.Add(this.radioButton_TPH);
            this.panel.Controls.Add(this.pictureBox_taiwan);
            this.panel.Location = new System.Drawing.Point(232, 7);
            this.panel.Name = "panel";
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel.Size = new System.Drawing.Size(629, 500);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // label_ShowNumber
            // 
            this.label_ShowNumber.AutoSize = true;
            this.label_ShowNumber.Location = new System.Drawing.Point(430, 162);
            this.label_ShowNumber.Name = "label_ShowNumber";
            this.label_ShowNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_ShowNumber.Size = new System.Drawing.Size(13, 19);
            this.label_ShowNumber.TabIndex = 23;
            this.label_ShowNumber.Text = " ";
            // 
            // radioButton_LNN
            // 
            this.radioButton_LNN.AutoSize = true;
            this.radioButton_LNN.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_LNN.Location = new System.Drawing.Point(42, 64);
            this.radioButton_LNN.Name = "radioButton_LNN";
            this.radioButton_LNN.Size = new System.Drawing.Size(75, 23);
            this.radioButton_LNN.TabIndex = 22;
            this.radioButton_LNN.TabStop = true;
            this.radioButton_LNN.Text = "連江縣";
            this.radioButton_LNN.UseVisualStyleBackColor = false;
            // 
            // radioButton_KMN
            // 
            this.radioButton_KMN.AutoSize = true;
            this.radioButton_KMN.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_KMN.Location = new System.Drawing.Point(25, 158);
            this.radioButton_KMN.Name = "radioButton_KMN";
            this.radioButton_KMN.Size = new System.Drawing.Size(75, 23);
            this.radioButton_KMN.TabIndex = 21;
            this.radioButton_KMN.TabStop = true;
            this.radioButton_KMN.Text = "金門縣";
            this.radioButton_KMN.UseVisualStyleBackColor = false;
            // 
            // radioButton_CYI
            // 
            this.radioButton_CYI.AutoSize = true;
            this.radioButton_CYI.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_CYI.Location = new System.Drawing.Point(177, 248);
            this.radioButton_CYI.Name = "radioButton_CYI";
            this.radioButton_CYI.Size = new System.Drawing.Size(75, 23);
            this.radioButton_CYI.TabIndex = 20;
            this.radioButton_CYI.TabStop = true;
            this.radioButton_CYI.Text = "嘉義市";
            this.radioButton_CYI.UseVisualStyleBackColor = false;
            // 
            // radioButton_HSC
            // 
            this.radioButton_HSC.AutoSize = true;
            this.radioButton_HSC.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_HSC.Location = new System.Drawing.Point(143, 72);
            this.radioButton_HSC.Name = "radioButton_HSC";
            this.radioButton_HSC.Size = new System.Drawing.Size(75, 23);
            this.radioButton_HSC.TabIndex = 19;
            this.radioButton_HSC.TabStop = true;
            this.radioButton_HSC.Text = "新竹市";
            this.radioButton_HSC.UseVisualStyleBackColor = false;
            // 
            // radioButton_KLU
            // 
            this.radioButton_KLU.AutoSize = true;
            this.radioButton_KLU.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_KLU.Location = new System.Drawing.Point(289, 8);
            this.radioButton_KLU.Name = "radioButton_KLU";
            this.radioButton_KLU.Size = new System.Drawing.Size(75, 23);
            this.radioButton_KLU.TabIndex = 18;
            this.radioButton_KLU.TabStop = true;
            this.radioButton_KLU.Text = "基隆市";
            this.radioButton_KLU.UseVisualStyleBackColor = false;
            // 
            // radioButton_PEH
            // 
            this.radioButton_PEH.AutoSize = true;
            this.radioButton_PEH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_PEH.Location = new System.Drawing.Point(25, 305);
            this.radioButton_PEH.Name = "radioButton_PEH";
            this.radioButton_PEH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_PEH.TabIndex = 17;
            this.radioButton_PEH.TabStop = true;
            this.radioButton_PEH.Text = "澎湖縣";
            this.radioButton_PEH.UseVisualStyleBackColor = false;
            // 
            // radioButton_HWA
            // 
            this.radioButton_HWA.AutoSize = true;
            this.radioButton_HWA.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_HWA.Location = new System.Drawing.Point(269, 216);
            this.radioButton_HWA.Name = "radioButton_HWA";
            this.radioButton_HWA.Size = new System.Drawing.Size(75, 23);
            this.radioButton_HWA.TabIndex = 16;
            this.radioButton_HWA.TabStop = true;
            this.radioButton_HWA.Text = "花蓮縣";
            this.radioButton_HWA.UseVisualStyleBackColor = false;
            // 
            // radioButton_TTT
            // 
            this.radioButton_TTT.AutoSize = true;
            this.radioButton_TTT.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TTT.Location = new System.Drawing.Point(230, 326);
            this.radioButton_TTT.Name = "radioButton_TTT";
            this.radioButton_TTT.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TTT.TabIndex = 15;
            this.radioButton_TTT.TabStop = true;
            this.radioButton_TTT.Text = "臺東縣";
            this.radioButton_TTT.UseVisualStyleBackColor = false;
            // 
            // radioButton_IUH
            // 
            this.radioButton_IUH.AutoSize = true;
            this.radioButton_IUH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_IUH.Location = new System.Drawing.Point(111, 369);
            this.radioButton_IUH.Name = "radioButton_IUH";
            this.radioButton_IUH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_IUH.TabIndex = 14;
            this.radioButton_IUH.TabStop = true;
            this.radioButton_IUH.Text = "屏東縣";
            this.radioButton_IUH.UseVisualStyleBackColor = false;
            // 
            // radioButton_CHY
            // 
            this.radioButton_CHY.AutoSize = true;
            this.radioButton_CHY.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_CHY.Location = new System.Drawing.Point(72, 248);
            this.radioButton_CHY.Name = "radioButton_CHY";
            this.radioButton_CHY.Size = new System.Drawing.Size(75, 23);
            this.radioButton_CHY.TabIndex = 13;
            this.radioButton_CHY.TabStop = true;
            this.radioButton_CHY.Text = "嘉義縣";
            this.radioButton_CHY.UseVisualStyleBackColor = false;
            // 
            // radioButton_YLH
            // 
            this.radioButton_YLH.AutoSize = true;
            this.radioButton_YLH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_YLH.Location = new System.Drawing.Point(104, 216);
            this.radioButton_YLH.Name = "radioButton_YLH";
            this.radioButton_YLH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_YLH.TabIndex = 12;
            this.radioButton_YLH.TabStop = true;
            this.radioButton_YLH.Text = "雲林縣";
            this.radioButton_YLH.UseVisualStyleBackColor = false;
            // 
            // radioButton_NTC
            // 
            this.radioButton_NTC.AutoSize = true;
            this.radioButton_NTC.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_NTC.Location = new System.Drawing.Point(180, 202);
            this.radioButton_NTC.Name = "radioButton_NTC";
            this.radioButton_NTC.Size = new System.Drawing.Size(75, 23);
            this.radioButton_NTC.TabIndex = 11;
            this.radioButton_NTC.TabStop = true;
            this.radioButton_NTC.Text = "南投縣";
            this.radioButton_NTC.UseVisualStyleBackColor = false;
            // 
            // radioButton_CWH
            // 
            this.radioButton_CWH.AutoSize = true;
            this.radioButton_CWH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_CWH.Location = new System.Drawing.Point(104, 187);
            this.radioButton_CWH.Name = "radioButton_CWH";
            this.radioButton_CWH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_CWH.TabIndex = 10;
            this.radioButton_CWH.TabStop = true;
            this.radioButton_CWH.Text = "彰化縣";
            this.radioButton_CWH.UseVisualStyleBackColor = false;
            // 
            // radioButton_MAL
            // 
            this.radioButton_MAL.AutoSize = true;
            this.radioButton_MAL.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_MAL.Location = new System.Drawing.Point(158, 112);
            this.radioButton_MAL.Name = "radioButton_MAL";
            this.radioButton_MAL.Size = new System.Drawing.Size(75, 23);
            this.radioButton_MAL.TabIndex = 9;
            this.radioButton_MAL.TabStop = true;
            this.radioButton_MAL.Text = "苗栗縣";
            this.radioButton_MAL.UseVisualStyleBackColor = false;
            // 
            // radioButton_HSH
            // 
            this.radioButton_HSH.AutoSize = true;
            this.radioButton_HSH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_HSH.Location = new System.Drawing.Point(187, 89);
            this.radioButton_HSH.Name = "radioButton_HSH";
            this.radioButton_HSH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_HSH.TabIndex = 8;
            this.radioButton_HSH.TabStop = true;
            this.radioButton_HSH.Text = "新竹縣";
            this.radioButton_HSH.UseVisualStyleBackColor = false;
            // 
            // radioButton_ILN
            // 
            this.radioButton_ILN.AutoSize = true;
            this.radioButton_ILN.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_ILN.Location = new System.Drawing.Point(287, 111);
            this.radioButton_ILN.Name = "radioButton_ILN";
            this.radioButton_ILN.Size = new System.Drawing.Size(75, 23);
            this.radioButton_ILN.TabIndex = 7;
            this.radioButton_ILN.TabStop = true;
            this.radioButton_ILN.Text = "宜蘭縣";
            this.radioButton_ILN.UseVisualStyleBackColor = false;
            // 
            // radioButton_KHH
            // 
            this.radioButton_KHH.AutoSize = true;
            this.radioButton_KHH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_KHH.Location = new System.Drawing.Point(117, 315);
            this.radioButton_KHH.Name = "radioButton_KHH";
            this.radioButton_KHH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_KHH.TabIndex = 6;
            this.radioButton_KHH.TabStop = true;
            this.radioButton_KHH.Text = "高雄市";
            this.radioButton_KHH.UseVisualStyleBackColor = false;
            // 
            // radioButton_TNN
            // 
            this.radioButton_TNN.AutoSize = true;
            this.radioButton_TNN.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TNN.Location = new System.Drawing.Point(101, 289);
            this.radioButton_TNN.Name = "radioButton_TNN";
            this.radioButton_TNN.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TNN.TabIndex = 5;
            this.radioButton_TNN.TabStop = true;
            this.radioButton_TNN.Text = "臺南市";
            this.radioButton_TNN.UseVisualStyleBackColor = false;
            // 
            // radioButton_TXG
            // 
            this.radioButton_TXG.AutoSize = true;
            this.radioButton_TXG.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TXG.Location = new System.Drawing.Point(177, 149);
            this.radioButton_TXG.Name = "radioButton_TXG";
            this.radioButton_TXG.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TXG.TabIndex = 4;
            this.radioButton_TXG.TabStop = true;
            this.radioButton_TXG.Text = "臺中市";
            this.radioButton_TXG.UseVisualStyleBackColor = false;
            // 
            // radioButton_TYC
            // 
            this.radioButton_TYC.AutoSize = true;
            this.radioButton_TYC.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TYC.Location = new System.Drawing.Point(206, 48);
            this.radioButton_TYC.Name = "radioButton_TYC";
            this.radioButton_TYC.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TYC.TabIndex = 3;
            this.radioButton_TYC.TabStop = true;
            this.radioButton_TYC.Text = "桃園市";
            this.radioButton_TYC.UseVisualStyleBackColor = false;
            // 
            // radioButton_TPE
            // 
            this.radioButton_TPE.AutoSize = true;
            this.radioButton_TPE.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TPE.Location = new System.Drawing.Point(232, 25);
            this.radioButton_TPE.Name = "radioButton_TPE";
            this.radioButton_TPE.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TPE.TabIndex = 2;
            this.radioButton_TPE.TabStop = true;
            this.radioButton_TPE.Text = "臺北市";
            this.radioButton_TPE.UseVisualStyleBackColor = false;
            // 
            // radioButton_TPH
            // 
            this.radioButton_TPH.AutoSize = true;
            this.radioButton_TPH.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TPH.Location = new System.Drawing.Point(287, 64);
            this.radioButton_TPH.Name = "radioButton_TPH";
            this.radioButton_TPH.Size = new System.Drawing.Size(75, 23);
            this.radioButton_TPH.TabIndex = 1;
            this.radioButton_TPH.TabStop = true;
            this.radioButton_TPH.Text = "新北市";
            this.radioButton_TPH.UseVisualStyleBackColor = false;
            this.radioButton_TPH.CheckedChanged += new System.EventHandler(this.radioButton_Place_CheckedChanged);
            // 
            // pictureBox_taiwan
            // 
            this.pictureBox_taiwan.Image = global::LivingHellForPedestrians.Properties.Resources._04c71e49235d60c1047229c037e61056;
            this.pictureBox_taiwan.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_taiwan.Name = "pictureBox_taiwan";
            this.pictureBox_taiwan.Size = new System.Drawing.Size(381, 494);
            this.pictureBox_taiwan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_taiwan.TabIndex = 0;
            this.pictureBox_taiwan.TabStop = false;
            // 
            // comboBox_DisplayType
            // 
            this.comboBox_DisplayType.Enabled = false;
            this.comboBox_DisplayType.FormattingEnabled = true;
            this.comboBox_DisplayType.Location = new System.Drawing.Point(7, 92);
            this.comboBox_DisplayType.Name = "comboBox_DisplayType";
            this.comboBox_DisplayType.Size = new System.Drawing.Size(121, 27);
            this.comboBox_DisplayType.TabIndex = 3;
            this.comboBox_DisplayType.SelectedIndexChanged += new System.EventHandler(this.comboBox_Place_SelectedIndexChanged);
            // 
            // comboBox_years
            // 
            this.comboBox_years.Enabled = false;
            this.comboBox_years.FormattingEnabled = true;
            this.comboBox_years.Location = new System.Drawing.Point(105, 7);
            this.comboBox_years.Name = "comboBox_years";
            this.comboBox_years.Size = new System.Drawing.Size(121, 27);
            this.comboBox_years.TabIndex = 2;
            this.comboBox_years.SelectedIndexChanged += new System.EventHandler(this.comboBox_Place_SelectedIndexChanged);
            // 
            // checkBox_ShowMap
            // 
            this.checkBox_ShowMap.AutoSize = true;
            this.checkBox_ShowMap.Enabled = false;
            this.checkBox_ShowMap.Location = new System.Drawing.Point(7, 62);
            this.checkBox_ShowMap.Name = "checkBox_ShowMap";
            this.checkBox_ShowMap.Size = new System.Drawing.Size(91, 23);
            this.checkBox_ShowMap.TabIndex = 1;
            this.checkBox_ShowMap.Text = "顯示地圖";
            this.checkBox_ShowMap.UseVisualStyleBackColor = true;
            this.checkBox_ShowMap.CheckedChanged += new System.EventHandler(this.checkBox_ShowMap_CheckedChanged);
            // 
            // button_LoadFile
            // 
            this.button_LoadFile.Location = new System.Drawing.Point(7, 7);
            this.button_LoadFile.Name = "button_LoadFile";
            this.button_LoadFile.Size = new System.Drawing.Size(75, 48);
            this.button_LoadFile.TabIndex = 0;
            this.button_LoadFile.Text = "Load\r\nFile";
            this.button_LoadFile.UseVisualStyleBackColor = true;
            this.button_LoadFile.Click += new System.EventHandler(this.button_LoadFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.listBox_DisplayType);
            this.tabPage2.Controls.Add(this.chart_tool);
            this.tabPage2.Controls.Add(this.comboBox_ToolType);
            this.tabPage2.Controls.Add(this.listBox_years);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按當事人駕駛車種";
            // 
            // listBox_DisplayType
            // 
            this.listBox_DisplayType.Enabled = false;
            this.listBox_DisplayType.FormattingEnabled = true;
            this.listBox_DisplayType.ItemHeight = 19;
            this.listBox_DisplayType.Location = new System.Drawing.Point(7, 389);
            this.listBox_DisplayType.Name = "listBox_DisplayType";
            this.listBox_DisplayType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_DisplayType.Size = new System.Drawing.Size(148, 118);
            this.listBox_DisplayType.TabIndex = 4;
            this.listBox_DisplayType.SelectedIndexChanged += new System.EventHandler(this.listBox_Tool_SelectedIndexChanged);
            // 
            // chart_tool
            // 
            chartArea6.Name = "ChartArea_tool";
            this.chart_tool.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_tool.Legends.Add(legend6);
            this.chart_tool.Location = new System.Drawing.Point(288, 7);
            this.chart_tool.Name = "chart_tool";
            series10.ChartArea = "ChartArea_tool";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series10.Legend = "Legend1";
            series10.Name = "Accident";
            series11.ChartArea = "ChartArea_tool";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Death";
            series12.ChartArea = "ChartArea_tool";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.Legend = "Legend1";
            series12.Name = "Injured";
            this.chart_tool.Series.Add(series10);
            this.chart_tool.Series.Add(series11);
            this.chart_tool.Series.Add(series12);
            this.chart_tool.Size = new System.Drawing.Size(573, 500);
            this.chart_tool.TabIndex = 3;
            this.chart_tool.Text = "chart1";
            // 
            // comboBox_ToolType
            // 
            this.comboBox_ToolType.Enabled = false;
            this.comboBox_ToolType.FormattingEnabled = true;
            this.comboBox_ToolType.Location = new System.Drawing.Point(161, 7);
            this.comboBox_ToolType.Name = "comboBox_ToolType";
            this.comboBox_ToolType.Size = new System.Drawing.Size(121, 27);
            this.comboBox_ToolType.TabIndex = 2;
            this.comboBox_ToolType.SelectedIndexChanged += new System.EventHandler(this.listBox_Tool_SelectedIndexChanged);
            // 
            // listBox_years
            // 
            this.listBox_years.Enabled = false;
            this.listBox_years.FormattingEnabled = true;
            this.listBox_years.ItemHeight = 19;
            this.listBox_years.Location = new System.Drawing.Point(7, 7);
            this.listBox_years.Name = "listBox_years";
            this.listBox_years.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_years.Size = new System.Drawing.Size(148, 365);
            this.listBox_years.TabIndex = 0;
            this.listBox_years.SelectedIndexChanged += new System.EventHandler(this.listBox_Tool_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.chart_AgeDeath);
            this.tabPage3.Controls.Add(this.comboBox_AgeDeath);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(867, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "按死亡人數 - 年齡";
            // 
            // comboBox_AgeDeath
            // 
            this.comboBox_AgeDeath.Enabled = false;
            this.comboBox_AgeDeath.FormattingEnabled = true;
            this.comboBox_AgeDeath.Location = new System.Drawing.Point(4, 4);
            this.comboBox_AgeDeath.Name = "comboBox_AgeDeath";
            this.comboBox_AgeDeath.Size = new System.Drawing.Size(121, 27);
            this.comboBox_AgeDeath.TabIndex = 0;
            this.comboBox_AgeDeath.SelectedIndexChanged += new System.EventHandler(this.comboBox_AgeDeath_SelectedIndexChanged);
            // 
            // chart_AgeDeath
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_AgeDeath.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_AgeDeath.Legends.Add(legend5);
            this.chart_AgeDeath.Location = new System.Drawing.Point(132, 4);
            this.chart_AgeDeath.Name = "chart_AgeDeath";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Death";
            this.chart_AgeDeath.Series.Add(series9);
            this.chart_AgeDeath.Size = new System.Drawing.Size(732, 506);
            this.chart_AgeDeath.TabIndex = 1;
            this.chart_AgeDeath.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "行人地獄";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_taiwan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_tool)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_AgeDeath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_ShowMap;
        private System.Windows.Forms.Button button_LoadFile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox_taiwan;
        private System.Windows.Forms.ComboBox comboBox_DisplayType;
        private System.Windows.Forms.ComboBox comboBox_years;
        private System.Windows.Forms.RadioButton radioButton_TPH;
        private System.Windows.Forms.RadioButton radioButton_KHH;
        private System.Windows.Forms.RadioButton radioButton_TNN;
        private System.Windows.Forms.RadioButton radioButton_TXG;
        private System.Windows.Forms.RadioButton radioButton_TYC;
        private System.Windows.Forms.RadioButton radioButton_TPE;
        private System.Windows.Forms.RadioButton radioButton_CHY;
        private System.Windows.Forms.RadioButton radioButton_YLH;
        private System.Windows.Forms.RadioButton radioButton_NTC;
        private System.Windows.Forms.RadioButton radioButton_CWH;
        private System.Windows.Forms.RadioButton radioButton_MAL;
        private System.Windows.Forms.RadioButton radioButton_HSH;
        private System.Windows.Forms.RadioButton radioButton_ILN;
        private System.Windows.Forms.RadioButton radioButton_KLU;
        private System.Windows.Forms.RadioButton radioButton_PEH;
        private System.Windows.Forms.RadioButton radioButton_HWA;
        private System.Windows.Forms.RadioButton radioButton_TTT;
        private System.Windows.Forms.RadioButton radioButton_IUH;
        private System.Windows.Forms.RadioButton radioButton_KMN;
        private System.Windows.Forms.RadioButton radioButton_CYI;
        private System.Windows.Forms.RadioButton radioButton_HSC;
        private System.Windows.Forms.RadioButton radioButton_LNN;
        private System.Windows.Forms.Label label_ShowNumber;
        private System.Windows.Forms.ListBox listBox_years;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tool;
        private System.Windows.Forms.ComboBox comboBox_ToolType;
        private System.Windows.Forms.ListBox listBox_DisplayType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AgeDeath;
        private System.Windows.Forms.ComboBox comboBox_AgeDeath;
    }
}

