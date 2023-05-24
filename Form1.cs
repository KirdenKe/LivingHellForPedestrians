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
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            var loadFile = new LoadFile();
            _ = loadFile.LoadAccident();
            test = new List<object>();
            test = loadFile.LivingHell.FindAll(delegate (Object obj) { return obj.GetType() == typeof(TPH); });
        }
    }
}
