using CGS.Sample.AStar.Const;

namespace CGS.Sample.AStar.Models
{
    public class Node
    {
        private readonly Map _map;
        public readonly int X;
        public readonly int Y;
        public readonly bool Walkable;

        public Node(int x, int y, Map map)
        {
            _map = map;
            X = x;
            Y = y;
            Walkable = _map.IsWalkable(x, y);
            Direction = Direction.None;
        }

        public Node Parent { get; set; }
        public float G { get; set; }
        public float H { get; set; }
        public float F { get { return G + H; } }

        public Direction Direction { get; private set; }

        public Node Up()
        {
            var node = new Node(X, Y + 1, _map);
            node.Direction = Direction.Up;
            return node;
        }
        public Node Down()
        {
            var node = new Node(X, Y - 1, _map);
            node.Direction = Direction.Down;
            return node;
        }
        public Node Left()
        {
            var node = new Node(X - 1, Y, _map);
            node.Direction = Direction.Left;
            return node;
        }
        public Node Right()
        {
            var node = new Node(X + 1, Y, _map);
            node.Direction = Direction.Right;
            return node;
        }
    }
}
