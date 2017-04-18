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
                var currentKey = current.Key;
                var currentNode = current.Value;

                if (currentNode.X == endNode.X && currentNode.Y == endNode.Y)
                    return currentNode;

                open.Remove(currentKey);
                closed.Add(currentKey, currentNode);

                foreach (var near in new Node[] {
                    currentNode.Up(), currentNode.Down(), currentNode.Left(), currentNode.Right()
                })
                {
                    var newKey = $"{near.X}{near.Y}";

                    if (!near.Walkable || closed.ContainsKey(newKey))
                        continue;

                    if (open.ContainsKey(newKey))
                    {
                        var node = open[newKey];

                        var g = _getG(node, map);

                        if (g < node.Parent.G)
                        {
                            node.G = g;
                            node.H = _getH(node, endNode);
                            node.Parent = currentNode;
                        }
                    }
                    else
                    {
                        near.G = _getG(near, map);
                        near.H = _getH(near, endNode);
                        near.Parent = currentNode;
                        open.Add(newKey, near);
                    }
                }
            }
        }
        private static int _getG(Node node, Map map)
        {
            return map.IsWalkable(node.X, node.Y) ? 9 : 1;
        }
        private static float _getH(Node node, Node endNode)
        {
            var X = node.X - endNode.X;
            var Y = node.Y - endNode.Y;
            return (float)Math.Sqrt((X * X) + (Y * Y));
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
