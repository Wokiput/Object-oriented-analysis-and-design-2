using builder.Builders;
using builder.Models;

namespace builder
{
    public partial class MainForm : Form
    {
        private House currentHouse;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cmb_HouseType.Items.AddRange(new string[] {
               "PoorHouse",
               "PoolHouse",
               "GarageHouse",
               "GardenHouse",
               "FancyHouse" });
            cmb_HouseType.SelectedIndex = 0;
            cmb_WallMaterial.Items.AddRange(new string[] {
                "Brick",
                "Wood",
                "Concrete" });
            cmb_WallMaterial.SelectedIndex = 0;
            nud_HouseLength.Minimum = 5;
            nud_HouseLength.Maximum = 30;
            nud_HouseLength.Value = 10;
            nud_HouseWidth.Minimum = 2;
            nud_HouseWidth.Maximum = 10;
            nud_HouseWidth.Value = 3;
            UpdateArea();
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            UpdateArea();
        }
        private void UpdateArea()
        {
            double length = (double)nud_HouseLength.Value;
            double width = (double)nud_HouseWidth.Value;
            double area = length * width;
            lbl_area.Text = $"Площадь: {area:F2} м²";
        }
        private void btn_Build_Click(object sender, EventArgs e)
        {
            string type = cmb_HouseType.SelectedItem.ToString();
            string material = cmb_WallMaterial.SelectedItem.ToString();
            double lenght = (double)nud_HouseLength.Value;
            double width = (double)nud_HouseWidth.Value;
            IHouseBuilder builder;
            switch (type) {
                case "FancyHouse": builder = new FancyHouseBuilder(); break;
                case "PoolHouse": builder = new PoolHouseBuilder(); break;
                case "GardenHouse": builder = new GardenHouseBuilder(); break;
                case "GarageHouse": builder = new GarageHouseBuilder(); break;
                default: builder = new PoorHouseBuilder(); break;
            }
            Director director = new Director();
            director.Construct(builder, lenght, width, material);
            currentHouse = builder.GetResult();
            BuildForm buildform = new BuildForm(currentHouse);
            buildform.Show();
        }
    }
}
