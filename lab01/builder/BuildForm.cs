using builder.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    public partial class BuildForm : Form
    {
        private readonly BaseHouse _house;
        private readonly double _scale = 20;
        private readonly TextureBrush _concreteBrush;
        private readonly TextureBrush _brickBrush;
        private readonly TextureBrush _woodBrush;
        private readonly TextureBrush _grassBrush;

        public BuildForm(BaseHouse house)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Text = "Визуализация и смета";
            this.Size = new Size(1000, 800);
            _house = house;
            _brickBrush = new TextureBrush(Properties.Resources.bricktexture) { WrapMode = WrapMode.Tile };
            _woodBrush = new TextureBrush(Properties.Resources.woodtexture) { WrapMode = WrapMode.Tile };
            _grassBrush = new TextureBrush(Properties.Resources.grasstexture) { WrapMode = WrapMode.Tile };
            _concreteBrush = new TextureBrush(Properties.Resources.concretetexture) { WrapMode = WrapMode.Tile };
            Button btnEstimate = new Button
            {
                Text = "Рассчитать смету",
                Location = new Point(10, 10),
                Size = new Size(120, 40),
                BackColor = Color.White
            };
            btnEstimate.Click += BtnEstimate_Click;
            this.Controls.Add(btnEstimate);
        }    
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(_grassBrush, this.ClientRectangle);
            double wallThicknessM = _house.WallMaterial switch
            {
                "Wood" => 0.15,
                "Brick" => 0.51,
                "Concrete" => 0.4,
                _ => 0.2
            };
            int startX = 400; int startY = 300;
            int wPx = (int)(_house.Width * _scale);
            int lPx = (int)(_house.Length * _scale);
            int tPx = (int)(wallThicknessM * _scale);
            Rectangle houseRect = new Rectangle(startX, startY, wPx, lPx);
            TextureBrush wallBrush = GetWallBrush(_house.WallMaterial);
            if (_house is GardenHouse || _house is FancyHouse)
            {
                bool hasGarage = _house is FancyHouse;
                double gardenWidthM = 0.5;
                int gPx = (int)(gardenWidthM * _scale);
                Rectangle gardenRect = new Rectangle(startX-gPx, startY-gPx, wPx + 2*gPx, lPx + 2*gPx);
                g.FillRectangle(Brushes.Green, gardenRect);
            }
            g.FillRectangle(wallBrush, houseRect);
            Rectangle innerRect = new Rectangle(startX + tPx, startY + tPx, wPx - 2 * tPx, lPx - 2 * tPx);
            g.FillRectangle(Brushes.LightGray, innerRect);
            g.DrawRectangle(Pens.Black, houseRect);
            g.DrawRectangle(Pens.Black, innerRect);
            if (_house is GarageHouse gh) DrawGarage(g, houseRect, gh.GarageWidth, gh.GarageLength);
            if (_house is FancyHouse fh)
            {
                DrawGarage(g, houseRect, fh.GarageWidth, fh.GarageLength);
                DrawPool(g, houseRect, fh.PoolWidth, fh.PoolLength);
                DrawStatue(g, houseRect);
            }
            if (_house is PoolHouse ph) DrawPool(g, houseRect, ph.PoolWidth, ph.PoolLength);
        }
        private void DrawGarage(Graphics g, Rectangle house, double w, double l)
        {
            int gw = (int)(w * _scale);
            int gl = (int)(l * _scale);
            Rectangle rect = new Rectangle(house.Right, house.Y, gw, gl);
            g.FillRectangle(_concreteBrush, rect);
            g.DrawRectangle(Pens.Black, rect);
        }
        private void DrawPool(Graphics g, Rectangle house, double w, double l)
        {
            int pw = (int)(w * _scale);
            int pl = (int)(l * _scale);
            int dist = (int)(2 * _scale);
            Rectangle rect = new Rectangle(house.X - pw - dist, house.Y, pw, pl);
            g.FillRectangle(Brushes.SkyBlue, rect);
            g.DrawRectangle(Pens.Blue, rect);
        }
        private void DrawStatue(Graphics g, Rectangle house)
        {
            g.FillEllipse(_concreteBrush, house.X + house.Width / 2 - 10, house.Bottom + 20, 20, 20);
        }
        private TextureBrush GetWallBrush(string material) => material switch
        {
            "Brick" => _brickBrush,
            "Wood" => _woodBrush,
            _ => _concreteBrush
        };
        private void BtnEstimate_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====Смета проекта====");
            double thickness = _house.WallMaterial switch { "Wood" => 0.15, "Brick" => 0.51, "Concrete" => 0.4, _ => 0.2 };
            double wallVolume = ((_house.Width + _house.Length) * 2) * 3 * thickness;
            sb.AppendLine($"Материал стен: {_house.WallMaterial}");
            sb.AppendLine($"Объём материалов стен: {wallVolume:F2}м^3");
            if (_house is PoolHouse ph)
                sb.AppendLine($"Объём бассейна (глубина 1.5м): {ph.PoolWidth * ph.PoolLength * 1.5:F2}м^3");
            if (_house is GardenHouse gnh)
                sb.AppendLine($"Тип сада: {gnh.GardenType}");
            if (_house is GarageHouse gh)
                sb.AppendLine($"Площадь гаража: {gh.GarageWidth * gh.GarageLength:F2}м^2");
            if (_house is FancyHouse fh)
            {
                sb.AppendLine($"Объём бассейна (глубина 1.5м): {fh.PoolWidth * fh.PoolLength * 1.5:F2}м^3");
                sb.AppendLine($"Тип сада: {fh.GardenType}");
                sb.AppendLine($"Площадь гаража: {fh.GarageWidth * fh.GarageLength:F2}м^2");
                sb.AppendLine($"Тип статуи: {fh.StatueType}");
            }
            MessageBox.Show( sb.ToString(), "Результат расчётов");
        }
    }
}
