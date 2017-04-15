namespace CGS.Sample.AStar
{
    public class Node
    {
        public readonly int X;
        public readonly int Y;
        public readonly bool Walkable;

        public Node(int x, int y, Map map)
        {
            X = x;
            Y = y;
            Walkable = map != null && map.IsWalkable(x, y);
        }

        public Node Parent { get; set; }
        public int G { get; set; }
        public float H { get; set; }
        public float F { get { return G + H; } }
    }
}
