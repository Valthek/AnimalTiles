using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalBoard.Interfaces;
using AnimalBoard.Objects;
using AnimalBoard.Services;

namespace AnimalBoard.Forms
{
    public partial class AnimalBoard : Form
    {
        private GameService service;
        public AnimalBoard()
        {
            InitializeComponent();
            service = new GameService(20, 20);
            // Render everything once
            Render(20,20, 20, service.Board, service.Animals);


        }

        private void Render(int height, int width, int tileSize, List<Tile> tiles, List<IAnimal> animals)
        {
            Bitmap bitmap = new Bitmap(width*tileSize, height*tileSize);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Bitmap source = new Bitmap(@"E:\Projects\AnimalBoard\AnimalBoard.Forms\Textures\PrototypeTex.bmp");
                foreach (Tile t in tiles)
                {
                    graphics.DrawImage(
                        source, 
                        t.Position.x * tileSize, 
                        t.Position.y * tileSize, 
                        tileSize, 
                        tileSize);
                }
                source = new Bitmap(@"E:\Projects\AnimalBoard\AnimalBoard.Forms\Textures\chara6.bmp");

                foreach (IAnimal a in animals)
                {
                    graphics.DrawImage(
                        source,
                        a.Position.x * tileSize,
                        a.Position.y * tileSize,
                        tileSize,
                        tileSize);
                }
            }
            Canvas.Image = bitmap;
        }
    }
}
