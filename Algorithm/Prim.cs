using CGS.Sample.AStar.Const;
using CGS.Sample.AStar.Models;
using System;

namespace CGS.Sample.AStar.Algorithm
{
    public class Prim
    {
        public static void Generate(Map map)
        {
            _init(map);

            var startPoint = _generatePoint(map, Symbol.StartPoint);

            _generate(map, startPoint);

            _generatePoint(map, Symbol.EndPoint);
        }

        private static void _init(Map map)
        {
            for (var x = 0; x < map.Width; x++)
                for (var y = 0; y < map.Height; y++)
                    map.Current[x, y] = Symbol.NotWalkable;
        }

        private static Node _generatePoint(Map map, string symbol)
        {
            var random = new Random();

            var x = random.Next(map.Width);
            var y = random.Next(map.Height);

            if (map.IsStartPoint(x, y) || map.IsEndPoint(x, y))
                return _generatePoint(map, symbol);

            map.Current[x, y] = symbol;

            return new Node(x, y, map);
        }

        private static void _generate(Map map, Node node)
        {
            var random = new Random();

            var listNear = _getRandomNear(node);

            for (var i = 0; i < listNear.Length; i++)
            {
                var near = listNear[i];

                if (near.Direction == Direction.Up)
                {
                    var nearUp = near.Up();

                    if (!map.IsExist(nearUp.X, nearUp.Y))
                        continue;

                    if (!nearUp.Walkable)
                    {
                        map.Current[nearUp.X, nearUp.Y] = Symbol.Walkable;
                        map.Current[near.X, near.Y] = Symbol.Walkable;
                        _generate(map, nearUp);
                    }
                }
                else if (near.Direction == Direction.Down)
                {
                    var nearDown = near.Down();

                    if (!map.IsExist(nearDown.X, nearDown.Y))
                        continue;

                    if (!nearDown.Walkable)
                    {
                        map.Current[nearDown.X, nearDown.Y] = Symbol.Walkable;
                        map.Current[near.X, near.Y] = Symbol.Walkable;
                        _generate(map, nearDown);
                    }
                }
                else if (near.Direction == Direction.Left)
                {
                    var nearLeft = near.Left();

                    if (!map.IsExist(nearLeft.X, nearLeft.Y))
                        continue;

                    if (!nearLeft.Walkable)
                    {
                        map.Current[nearLeft.X, nearLeft.Y] = Symbol.Walkable;
                        map.Current[near.X, near.Y] = Symbol.Walkable;
                        _generate(map, nearLeft);
                    }
                }
                else if (near.Direction == Direction.Right)
                {
                    var nearRight = near.Right();

                    if (!map.IsExist(nearRight.X, nearRight.Y))
                        continue;

                    if (!nearRight.Walkable)
                    {
                        map.Current[nearRight.X, nearRight.Y] = Symbol.Walkable;
                        map.Current[near.X, near.Y] = Symbol.Walkable;
                        _generate(map, nearRight);
                    }
                }
            }
        }

        private static Node[] _getRandomNear(Node node)
        {
            var random = new Random();

            var listNear = new Node[] { node.Up(), node.Down(), node.Left(), node.Right() };

            for (var i = 0; i < listNear.Length; i++)
            {
                var j = random.Next(i, listNear.Length);
                var obj = listNear[i];
                listNear[i] = listNear[j];
                listNear[j] = obj;
            }

            return listNear;
        }
    }
}
