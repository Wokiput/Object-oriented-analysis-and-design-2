using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    public partial class OptionsForm : Form
    {
        public double PoolWidth {  get; set; }
        public double PoolLength { get; set; }
        public double GarageWidth { get; set; }
        public double GarageLength { get; set; }
        public string GardenType { get; set; }
        public string StatueType {  get; set; }
        public OptionsForm(string houseType)
        {
            InitializeComponent();
            cB_StatueType.SelectedIndex = 0;
            cB_GardenType.SelectedIndex = 0;
            panel_Pool.Visible = (houseType == "PoolHouse" || houseType == "FancyHouse");
            panel_Garden.Visible = (houseType == "GardenHouse" || houseType == "FancyHouse");
            panel_Garage.Visible = (houseType == "GarageHouse" || houseType == "FancyHouse");
            panel_Statue.Visible = (houseType == "FancyHouse");
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (panel_Pool.Visible) { PoolLength = (double)nUD_PoolLength.Value; PoolWidth = (double)nUD_PoolWidth.Value; }
            else { PoolLength = 0; PoolWidth = 0; }
            if (panel_Garden.Visible) { GardenType = cB_GardenType.Text; }
            if (panel_Garage.Visible) { GarageLength = (double)nUD_GarageLength.Value; GarageWidth = (double)nUD_GarageWidth.Value; }
            else { GarageLength = 0; GarageWidth = 0; }
            if (panel_Statue.Visible) { StatueType = cB_StatueType.Text; }
            this.DialogResult = DialogResult.OK;
        }
    }
}
