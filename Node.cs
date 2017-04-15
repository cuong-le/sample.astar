namespace CGS.Sample.AStar
{
    public class Node
    {
        public readonly int X;
        public readonly int Y;
        public readonly bool Walkable;

        public Node(int x, int y, bool walkable)
        {
            X = x;
            Y = y;
            Walkable = walkable;
        }

        public Node Parent { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public int F { get { return G + H; } }
    }
}
