using CGS.Sample.AStar.Algorithm;
using CGS.Sample.AStar.Const;
using CGS.Sample.AStar.Infractstructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CGS.Sample.AStar.Models
{
    public class Map
    {
        public string[,] Current { get; private set; }

        public void Init(int width, int height)
        {
            Width = width;
            Height = height;

            Current = new string[Width, Height];

            _resetPoint();
        }

        public void Generate()
        {
            Prim.Generate(this);

            _resetPoint();
        }

        public string ChangeNext(int X, int Y)
        {
            var index = Array.IndexOf(Symbol.Changes, _getCell(X, Y));

            var nextIndex = 0;

            if (index < Symbol.Changes.Length - 1)
                nextIndex = index + 1;

            var nextValue = Symbol.Changes[nextIndex];

            _setCell(X, Y, nextValue);

            return nextValue;
        }

        public void Find()
        {
            var points = _validateFind();

            var path = Algorithm.AStar.Find(Width, Height, points, this);

            _fillPath(path);
        }

        public bool IsExist(int X, int Y)
        {
            return -1 < X && X < Width && -1 < Y && Y < Height;
        }
        public bool IsWalkable(int X, int Y)
        {
            return IsExist(X, Y) && Symbol.AllowWalk.Contains(_getCell(X, Y));
        }
        public bool IsStartPoint(int X, int Y)
        {
            return IsExist(X, Y) && Symbol.StartPoint == _getCell(X, Y);
        }
        public bool IsEndPoint(int X, int Y)
        {
            return IsExist(X, Y) && Symbol.EndPoint == _getCell(X, Y);
        }

        public bool HasStartPoint { get; private set; }
        public bool HasEndPoint { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        private void _resetPoint()
        {
            HasStartPoint = false;
            HasEndPoint = false;
        }

        private Tuple<int, int, int, int> _validateFind()
        {
            var startX = 0;
            var startY = 0;
            var endX = 0;
            var endY = 0;

            _resetPoint();

            for (var x = 0; x < Width; x++)
                for (var y = 0; y < Height; y++)
                {
                    var cellValue = _getCell(x, y);

                    if (cellValue == Symbol.Way)
                        _setCell(x, y, Symbol.Walkable);
                    else if (cellValue == Symbol.StartPoint)
                    {
                        if (HasStartPoint)
                            throw new MapException("Only 1 start point!");

                        HasStartPoint = true;

                        startX = x;
                        startY = y;
                    }
                    else if (cellValue == Symbol.EndPoint)
                    {
                        if (HasEndPoint)
                            throw new MapException("Only 1 end point!");

                        HasEndPoint = true;

                        endX = x;
                        endY = y;
                    }
                }

            if (!HasStartPoint)
                throw new MapException("Need 1 start point!");

            if (!HasEndPoint)
                throw new MapException("Need 1 end point!");

            return new Tuple<int, int, int, int>(startX, startY, endX, endY);
        }
        private void _fillPath(Stack<Node> path)
        {
            foreach (var node in path)
            {
                var value = _getCell(node.X, node.Y);

                if (value == Symbol.StartPoint || value == Symbol.EndPoint)
                    continue;

                _setCell(node.X, node.Y, Symbol.Way);
            }

        }

        private string _getCell(int X, int Y)
        {
            return Current[X, Y];
        }
        private void _setCell(int X, int Y, string value)
        {
            Current[X, Y] = value;
        }
    }
}
