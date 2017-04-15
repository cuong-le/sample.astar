using System;
using System.Collections.Generic;
using System.Linq;

namespace CGS.Sample.AStar
{
    public class AStar
    {
        public static Stack<Node> Find(int width, int height, Tuple<int, int, int, int> points, Map map)
        {
            var startNode = new Node(points.Item1, points.Item2, map);
            var endNode = new Node(points.Item3, points.Item4, map);
            endNode = _aStar(startNode, endNode, map);

            var path = _findPath(startNode, endNode, map);

            return path;
        }

        private static Node _aStar(Node startNode, Node endNode, Map map)
        {
            var open = new Dictionary<string, Node>();
            var closed = new Dictionary<string, Node>();

            open.Add($"{startNode.X}{startNode.Y}", startNode);

            while (true)
            {
                var current = _getSmallestOpen(open);

                if (current.Value.X == endNode.X && current.Value.Y == endNode.Y)
                    return current.Value;

                open.Remove(current.Key);
                closed.Add(current.Key, current.Value);

                foreach (var near in new Node[] {
                    new Node(current.Value.X + 1, current.Value.Y, map),
                    new Node(current.Value.X, current.Value.Y + 1, map),
                    new Node(current.Value.X - 1, current.Value.Y, map),
                    new Node(current.Value.X, current.Value.Y - 1, map)
                })
                {
                    var newKey = $"{near.X}{near.Y}";

                    if (!near.Walkable || closed.ContainsKey(newKey))
                        continue;

                    if (open.ContainsKey(newKey))
                    {
                        var node = open[newKey];

                        var g = 10 + node.Parent.G;

                        if (g < node.G)
                        {
                            node.G = g;
                            node.Parent = current.Value;
                        }
                    }
                    else
                    {
                        near.G = 10 + current.Value.G;
                        near.H = (float)Math.Sqrt(Math.Pow(near.X - endNode.X, 2) + Math.Pow(near.Y - endNode.Y, 2));
                        near.Parent = current.Value;
                        open.Add(newKey, near);
                    }
                }
            }
        }
        private static KeyValuePair<string, Node> _getSmallestOpen(Dictionary<string, Node> open)
        {
            var smallest = open.ElementAt(0);

            foreach (var item in open)
            {
                if (item.Value.F < smallest.Value.F)
                    smallest = item;
                else if (item.Value.F == smallest.Value.F && item.Value.G < smallest.Value.G)
                    smallest = item;
            }

            return smallest;
        }

        private static Stack<Node> _findPath(Node startNode, Node endNode, Map map)
        {
            var path = new Stack<Node>();

            var node = new Node(endNode.X, endNode.Y, map)
            {
                Parent = endNode.Parent
            };

            while (node.X != startNode.X || node.Y != startNode.Y)
            {
                path.Push(node);
                node = node.Parent;
            }

            path.Push(node);

            return path;
        }
    }
}
