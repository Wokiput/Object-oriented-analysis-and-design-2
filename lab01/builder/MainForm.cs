using builder.Builders;
using builder.Models;

namespace builder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cB_HouseType.Items.AddRange(new string[] {
               "PoorHouse",
               "PoolHouse",
               "GarageHouse",
               "GardenHouse",
               "FancyHouse" });
            cB_HouseType.SelectedIndex = 0;
            cB_WallMaterial.Items.AddRange(new string[] {
                "Brick",
                "Wood",
                "Concrete" });
            cB_WallMaterial.SelectedIndex = 0;
            nUD_HouseLength.Minimum = 5;
            nUD_HouseLength.Maximum = 30;
            nUD_HouseLength.Value = 10;
            nUD_HouseWidth.Minimum = 2;
            nUD_HouseWidth.Maximum = 10;
            nUD_HouseWidth.Value = 3;
            rb_withBuilder.Checked = true;
            rb_withoutBuilder.Checked = false;
            UpdateArea();
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            UpdateArea();
        }
        private void UpdateArea()
        {
            double length = (double)nUD_HouseLength.Value;
            double width = (double)nUD_HouseWidth.Value;
            double area = length * width;
        }
        private void btn_Build_Click(object sender, EventArgs e)
        {
            string type = cB_HouseType.SelectedItem.ToString();
            string material = cB_WallMaterial.SelectedItem.ToString();
            double length = (double)nUD_HouseLength.Value;
            double width = (double)nUD_HouseWidth.Value;
            using (var optForm = new OptionsForm(type))
            {
                if (optForm.ShowDialog() == DialogResult.OK)
                {
                    BaseHouse currentHouse = null;
                    if (rb_withBuilder.Checked)
                    {
                        BaseHouseBuilder builder;
                        switch (type)
                        {
                            case "FancyHouse":
                                var fhb = new FancyHouseBuilder();
                                fhb.SetGarageParams(optForm.GarageWidth, optForm.GarageLength);
                                fhb.SetPoolParams(optForm.PoolWidth, optForm.PoolLength);
                                fhb.SetGardenType(optForm.GardenType);
                                fhb.SetStatueType(optForm.StatueType);
                                builder = fhb;
                                break;
                            case "PoolHouse":
                                var phb = new PoolHouseBuilder();
                                phb.SetPoolParams(optForm.PoolWidth, optForm.PoolLength);
                                builder = phb;
                                break;
                            case "GardenHouse":
                                var garhb = new GardenHouseBuilder();
                                garhb.SetGardenType(optForm.GardenType);
                                builder = garhb;
                                break;
                            case "GarageHouse":
                                var ghb = new GarageHouseBuilder();
                                ghb.SetGarageParams(optForm.GarageWidth, optForm.GarageLength);
                                builder = ghb;
                                break;
                            default: builder = new PoorHouseBuilder(); break;
                        }
                        Director director = new Director();
                        director.Construct(builder, length, width, material);
                        if (builder is PoolHouseBuilder p) currentHouse = p.GetHouse();
                        else if (builder is GarageHouseBuilder g) currentHouse = g.GetHouse();
                        else if (builder is GardenHouseBuilder gar) currentHouse = gar.GetHouse();
                        else if (builder is FancyHouseBuilder f) currentHouse = f.GetHouse();
                        else if (builder is PoorHouseBuilder po) currentHouse = po.GetHouse();
                    }
                    else
                    {
                        currentHouse = CreateHouseWithoutBuilder(type, length, width, material, optForm);
                    }
                    if (currentHouse != null)
                    {
                        BuildForm buildForm = new BuildForm(currentHouse);
                        buildForm.Show();
                    }
                }
            }
        }
        private BaseHouse CreateHouseWithoutBuilder(string type, double l, double w, string mat, OptionsForm optForm)
        {
            return type switch
            {
                "PoolHouse" => new PoolHouse { Length = l, Width = w, WallMaterial = mat, PoolWidth = optForm.PoolWidth, PoolLength = optForm.PoolLength },
                "GarageHouse" => new GarageHouse { Length = l, Width = w, WallMaterial = mat, GarageLength = optForm.GarageLength, GarageWidth = optForm.GarageWidth },
                "GardenHouse" => new GardenHouse { Length = l, Width = w, WallMaterial = mat, GardenType = optForm.GardenType},
                "FancyHouse" => new FancyHouse { Length = l, Width = w, WallMaterial = mat, GardenType = optForm.GardenType, GarageLength = optForm.GarageLength, GarageWidth = optForm.GarageWidth, PoolLength = optForm.PoolLength, PoolWidth = optForm.PoolWidth, StatueType = optForm.StatueType },
                _ => new PoorHouse { Length = l, Width = w, WallMaterial = mat}
            };
        }
    }
}
