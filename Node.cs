namespace CGS.Sample.AStar
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
        }

        public Node Parent { get; set; }
        public float G { get; set; }
        public float H { get; set; }
        public float F { get { return G + H; } }

        public Node Up()
        {
            return new Node(X, Y + 1, _map);
        }
        public Node Down()
        {
            return new Node(X, Y - 1, _map);
        }
        public Node Left()
        {
            return new Node(X - 1, Y, _map);
        }
        public Node Right()
        {
            return new Node(X + 1, Y, _map);
        }
    }
}
