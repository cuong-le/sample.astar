using System;
using System.Collections.Generic;
using System.Linq;

namespace CGS.Sample.AStar
{
    public class AStar
    {
        public static Stack<Node> Find(int width, int height, Tuple<int, int, int, int> points, Map map)
        {
            var startNode = new Node(points.Item1, points.Item2, false);
            var endNode = new Node(points.Item3, points.Item4, false);
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
                    new Node(current.Value.X + 1, current.Value.Y, map.IsWalkable(current.Value.X + 1, current.Value.Y)),
                    new Node(current.Value.X, current.Value.Y + 1, map.IsWalkable(current.Value.X, current.Value.Y + 1)),
                    new Node(current.Value.X - 1, current.Value.Y, map.IsWalkable(current.Value.X - 1, current.Value.Y)),
                    new Node(current.Value.X, current.Value.Y - 1, map.IsWalkable(current.Value.X, current.Value.Y - 1))
                })
                {
                    var newKey = $"{near.X}{near.Y}";

                    if (!near.Walkable || closed.ContainsKey(newKey))
                        continue;

                    if (open.ContainsKey(newKey))
                    {
                        var node = open[newKey];

                        var g = Math.Abs(near.X - startNode.X) + Math.Abs(near.Y - startNode.Y);

                        if (g < node.G)
                        {
                            node.G = g;
                            node.Parent = current.Value;
                        }
                    }
                    else
                    {
                        near.G = Math.Abs(near.X - startNode.X) + Math.Abs(near.Y - startNode.Y);
                        near.H = Math.Abs(near.X - endNode.X) + Math.Abs(near.Y - endNode.Y);
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

            var node = new Node(endNode.X, endNode.Y, map.IsWalkable(endNode.X, endNode.Y))
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
