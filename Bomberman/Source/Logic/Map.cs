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
        public int PlayerXpos { get; set; }
        public int PlayerYpos { get; set; }

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
                            _nodes[j, i] = new Node(wallFactory.CreateNode("hard"));
                            _nodes[j, i].Entity.PosX = j;
                            _nodes[j, i].Entity.PosY = i;
                            break;
                        case "SW":
                            _nodes[j, i] = new Node(wallFactory.CreateNode("soft"));
                            _nodes[j, i].Entity.PosX = j;
                            _nodes[j, i].Entity.PosY = i;
                            break;
                        case "EW":
                            _nodes[j, i] = new Node(null);
                            break;
                        case "PL":
                            _nodes[j, i] = new Node(new Player(new BombFactory()));
                            _nodes[j, i].Entity.PosX = j;
                            _nodes[j, i].Entity.PosY = i;
                            PlayerXpos = j;
                            PlayerYpos = i;
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

        public Node GetNode(int x, int y)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Lenght)
            {
                return null;
            }
            return _nodes[x,y];
        }

        public void MovePlayer(string pos)
        {
            switch (pos)
            {
                case "up":
                    ChangePlayerPos(PlayerXpos, PlayerYpos-1);
                    break;
                case "down":
                    ChangePlayerPos(PlayerXpos, PlayerYpos+1);
                    break;
                case "left":
                    ChangePlayerPos(PlayerXpos-1, PlayerYpos);
                    break;
                case "right":
                    ChangePlayerPos(PlayerXpos+1, PlayerYpos);
                    break;
            }
        }

        public Player GetPlayer()
        {
            var player = (Player) GetNode(PlayerXpos, PlayerYpos).Entity;
            return player;
        }

        private void ChangePlayerPos(int x, int y)
        {
            if (!GetNode(x, y).IsEmpty())
            {
                return;
            }
            var player = (Player) GetNode(PlayerXpos, PlayerYpos).Entity;
            GetNode(x, y).Entity = player;
            var bomb = player.Pop();
            GetNode(PlayerXpos, PlayerYpos).Entity = bomb;
            if (bomb != null)
            {
                bomb.PosX = PlayerXpos;
                bomb.PosY = PlayerYpos;
            }
           
            PlayerXpos = x;
            PlayerYpos = y;
        }

    }
}
