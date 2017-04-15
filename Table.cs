using System;
using System.Drawing;
using System.Windows.Forms;

namespace CGS.Sample.AStar
{
    public partial class Table : Form
    {
        private readonly Form _parent;

        public Table(Form parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        #region Event

        private void AStar_Load(object sender, EventArgs e)
        {
            VerticalScroll.Visible = false;
            HorizontalScroll.Visible = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            pnl_Map.VerticalScroll.Visible = false;
            pnl_Map.HorizontalScroll.Visible = false;

            pnl_Control.BorderStyle = BorderStyle.Fixed3D;

            grid_Map.ScrollBars = ScrollBars.None;
            grid_Map.AllowUserToResizeRows = false;
            grid_Map.AllowUserToResizeColumns = false;
            grid_Map.ColumnHeadersVisible = false;
            grid_Map.RowHeadersVisible = false;
            grid_Map.MultiSelect = false;
            grid_Map.ReadOnly = true;

            _sizeChanged();
        }

        private void AStar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void txt_Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            _valiateInputSize(e);
        }

        private void txt_Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            _valiateInputSize(e);
        }

        private void btn_ChangeMap_Click(object sender, EventArgs e)
        {
            _sizeChanged();
        }

        private void grid_Map_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = grid_Map[e.ColumnIndex, e.RowIndex];
            cell.Selected = false;

            _changeNext(cell);
        }

        private void btn_FindWay_Click(object sender, EventArgs e)
        {
            _findWay();

            _fillGrid();
        }

        #endregion

        private void _valiateInputSize(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }

        private Map _map;

        private const int _sizeEdge = 25;

        private void _sizeChanged()
        {
            var width = int.Parse(txt_Width.Text);
            var height = int.Parse(txt_Height.Text);

            if (width < 1 || width > 39)
            {
                MessageBox.Show("Width between 1 and 39", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (height < 1 || height > 20)
            {
                MessageBox.Show("Height between 1 and 20", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _changeGrid(width, height);
            _changeMap(width, height);
        }
        private void _changeGrid(int width, int height)
        {
            grid_Map.Columns.Clear();
            grid_Map.Rows.Clear();

            for (var x = 0; x < width; x++)
            {
                var column = grid_Map.Columns[grid_Map.Columns.Add(null, null)];
                column.Width = _sizeEdge;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (var i = 0; i < height; i++)
            {
                var row = grid_Map.Rows[grid_Map.Rows.Add()];
                row.Height = _sizeEdge;
            }

            grid_Map.Width = _sizeEdge * width + 2;
            grid_Map.Height = _sizeEdge * height + 2;

            grid_Map.Location = new Point()
            {
                X = pnl_Map.Width / 2 - grid_Map.Width / 2,
                Y = pnl_Map.Height / 2 - grid_Map.Height / 2
            };

            grid_Map.Refresh();
        }
        private void _changeMap(int width, int height)
        {
            if (_map == null)
                _map = new Map();

            _map.Init(width, height);
        }

        private void _changeNext(DataGridViewCell cell)
        {
            cell.Value = _map.ChangeNext(cell.ColumnIndex, cell.RowIndex);
        }

        private void _findWay()
        {
            try
            {
                _map.Find();
            }
            catch (Exception ex)
            {
                if (ex is MapException)
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Can't find way!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void _fillGrid()
        {
            for (var x = 0; x < _map.Width; x++)
                for (var y = 0; y < _map.Height; y++)
                    grid_Map.Rows[y].Cells[x].Value = _map.Current[x, y];
        }
    }
}
