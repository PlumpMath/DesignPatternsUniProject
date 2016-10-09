using System;
using System.Collections;
using System.Configuration;
using System.IO;
using Bomberman.Source.Entities;

namespace Bomberman.Source.Logic
{
    public class Map
    {
        public int Lenght { get; }
        public int Width { get; }

        private Node[,] nodes;

        public Map(int width = 11, int lenght = 11) {
            Lenght = lenght;
            Width = width;
            nodes = new Node[width, lenght];
            BuildMap();
        }

        public void BuildMap()
        {
            StreamReader streamReader = new StreamReader("../../Resources/Map.txt");
            string line;
            string[] walls;
            int j = 0;
            while ((line = streamReader.ReadLine())!= null)
            {
                walls = line.Split(' ');
                int i = 0;
                foreach (var wall in walls)
                {
                   
                    switch (wall)
                    {
                        case "HW": 
                            nodes[j,i] = new Node(new HardWall());
                            break;
                        case "SW":
                            nodes[j,i] = new Node(new SoftWall());
                            break;
                        case "EW":
                            nodes[j,i] = new Node(null);
                            break;
                        default:
                            Console.Write("Error occured");
                            break;
                    }
                    i++;
                }
                j++;
            }

        }

    }
}
