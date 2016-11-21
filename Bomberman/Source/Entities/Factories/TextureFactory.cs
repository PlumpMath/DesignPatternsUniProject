using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Source.Entities.Factories
{
    class TextureFactory
    {
        private static Dictionary<string, Image> textureMap = new Dictionary<string, Image>();

        public Image getTexture(string texture)
        {
            Image image = null; 
            if (textureMap.ContainsKey(texture))
            {
                image = (Image) textureMap[texture];
            } 

            if (image == null)
            {
                switch (texture)
                {
                    case "Player":
                        image = Image.FromFile("../../Resources/p_1_down.png");
                        break;
                    case "SoftWall":
                        image = Image.FromFile("../../Resources/floor.png");
                        break;
                    case "HardWall":
                        image = Image.FromFile("../../Resources/rock.png");
                        break;
                    case "SimpleBomb":
                        image = Image.FromFile("../../Resources/bomb.png");
                        break;
                    case "StrongBomb":
                        image = Image.FromFile("../../Resources/bombBonus.png");
                        break;
                    case "Explosion":
                        image = Image.FromFile("../../Resources/explosion.png");
                        break;
                    default:
                        Console.WriteLine("Error occured");
                        break;
                }
                textureMap.Add(texture, image);
                
            }
            return image;
        }
    }
}
