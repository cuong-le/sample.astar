namespace CGS.Sample.AStar.Const
{
    public class Symbol
    {
        public const string Walkable = null;
        public const string NotWalkable = "X";
        public const string StartPoint = "S";
        public const string EndPoint = "E";
        public const string Way = "O";

        public static readonly string[] AllowWalk = new string[] { Walkable, StartPoint, EndPoint };
        public static readonly string[] Changes = new string[] { Walkable, NotWalkable, StartPoint, EndPoint };
    }
}
