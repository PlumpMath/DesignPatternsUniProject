using System;
using System.Collections;
using System.Configuration;
using System.IO;
using Bomberman.Source.Entities;
using Bomberman.Source.Entities.Factories;

namespace Bomberman.Source.Logic
{
    public class Map
    {
        public int Lenght { get; }
        public int Width { get; }

        private Node[,] _nodes;

        public Map(int width = 11, int lenght = 11) {
            Lenght = lenght;
            Width = width;
            _nodes = new Node[width, lenght];
            BuildMap();
        }

        private void BuildMap()
        {
            var wallFactory = AbstractEntityFactory.CreateEntityFactory("wall");
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
                            _nodes[j,i] = new Node(wallFactory.CreateNode("hard"));
                            break;
                        case "SW":
                            _nodes[j,i] = new Node(wallFactory.CreateNode("soft"));
                            break;
                        case "EW":
                            _nodes[j,i] = new Node(null);
                            break;
                        case "PL":
                            _nodes[j,i] = new Node(new Player());
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

        public Node getNode(int x, int y)
        {
            return _nodes[x,y];
        }

    }
}
