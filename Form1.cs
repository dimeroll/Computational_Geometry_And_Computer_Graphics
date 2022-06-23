using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Geometry
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        private bool drawSegments = false;
        List<Point> points = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = CreateGraphics();
            OXaxisDrawingClass.DrawOXaxis(graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) => PointsDrawingClass.DrawPoints(e, drawSegments, points, graphics);

        private void button1_Click(object sender, EventArgs e)
        {
            drawSegments = true;
        }
        private void button2_Click(object sender, EventArgs e) => VisibilityMarker.MarkVisibleSegments(points.SortPoints(), graphics);
    }
}
