using AutoResquest.Models;
using System;
using System.Windows.Forms;

namespace AutoResquest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CmbInterval.DataSource = new Interval().GetEIntervals();
            CmbInterval.DisplayMember = "Text";
            CmbInterval.ValueMember = "value";
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            BtnPausar.Visible = false;
            BtnIniciar.Visible = true;
            PbTrabajando.Visible = false;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnPausar.Visible = true;
            BtnIniciar.Visible = false;
            PbTrabajando.Visible = true;
        }
    }
}
