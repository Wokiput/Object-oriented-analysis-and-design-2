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
        private House _house;
        private double _scale = 20;
        private TextureBrush _concreteBrush;
        private TextureBrush _brickBrush;
        private TextureBrush _woodBrush;
        private TextureBrush _grassBrush;

        public BuildForm(House house)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            _house = house;
            _brickBrush = new TextureBrush(Properties.Resources.bricktexture);
            _brickBrush.WrapMode = WrapMode.Tile;
            _woodBrush = new TextureBrush(Properties.Resources.woodtexture);
            _woodBrush.WrapMode = WrapMode.Tile;
            _grassBrush = new TextureBrush(Properties.Resources.grasstexture);
            _grassBrush.WrapMode= WrapMode.Tile;
            _concreteBrush = new TextureBrush(Properties.Resources.concretetexture);
            _concreteBrush.WrapMode = WrapMode.Tile;
        }    
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.FillRectangle(_grassBrush, 0, 0, this.Width, this.Height);
            int padding = 80;
            int baseX = padding;
            int baseY = padding;
            int widthPx = (int)(_house.Width * _scale);
            int lengthPx = (int)(_house.Length * _scale);
            TextureBrush wallBrush = _woodBrush;
            switch (_house.WallMaterial)
            {
                case "Brick": wallBrush = _brickBrush; break;
                case "Wood": wallBrush = _woodBrush; break;
                case "Concrete": wallBrush = _concreteBrush; break;
            }
            Rectangle houseRect = new Rectangle(baseX, baseY, widthPx, lengthPx);
            g.FillRectangle(wallBrush, houseRect);
            Pen borderPen = new Pen(Color.Black, 4);
            g.DrawRectangle(borderPen, houseRect);
            int margin = 20;
            if (_house.HasPool) 
            {
                Rectangle poolRect = new Rectangle(baseX - 100 - margin, baseY + lengthPx / 2 - 15, 100, 30);
                g.FillRectangle(Brushes.LightBlue, poolRect);
                g.DrawRectangle(Pens.Blue, poolRect);
            }
            if (_house.HasGarage)
            {
                Rectangle garageRect = new Rectangle(baseX + widthPx + margin, baseY + lengthPx / 2 - 30, 80, 60);
                g.FillRectangle(Brushes.DarkGray, garageRect);
                g.DrawRectangle(Pens.Black, garageRect);
            }
            if (_house.HasGarden) 
            {
                Rectangle gardenRect = new Rectangle(baseX + widthPx / 2 - 30, baseY - 50 - margin, 60, 60);
                g.FillEllipse(Brushes.Green, gardenRect);
            }
            if (_house.HasStatue)
            {
                Rectangle poolRect = new Rectangle(baseX + widthPx / 2 - 20, baseY + lengthPx + margin, 40, 40);
                g.FillEllipse(Brushes.LightGray, poolRect);
            }
        }
    }
}
