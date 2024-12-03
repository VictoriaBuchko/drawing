using System.Windows.Forms;

namespace drawing
{
    public partial class Form1 : Form
    {
        private Point? firstPoint = null; 
        private Point? secondPoint = null; 
        private string selectedShape = null;
        private Color currentColor = Color.Black; 
        private List<(string Shape, Point First, Point Second, Color Color)> shapes = new List<(string, Point, Point, Color)>(); 
        private List<(string Text, Point Location, Font Font, Color Color)> texts = new List<(string, Point, Font, Color)>();
        private bool isTextMode = false;

        public Form1()
        {
            InitializeComponent();
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (isTextMode)
            {
                return;
            }

            if (firstPoint == null)
            {
                firstPoint = e.Location;
            }
            else
            {
                secondPoint = e.Location;

                if (!string.IsNullOrEmpty(selectedShape))
                {
                    shapes.Add((selectedShape, firstPoint.Value, secondPoint.Value, currentColor));
                    firstPoint = null;
                    secondPoint = null;
                    panel1.Invalidate();
                }
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                foreach (var shape in shapes)
                {
                    using (Pen pen = new Pen(shape.Color, 2))
                    {
                        switch (shape.Shape)
                        {
                            case "Rectangle":
                                var rect = new Rectangle(
                                    Math.Min(shape.First.X, shape.Second.X),
                                    Math.Min(shape.First.Y, shape.Second.Y),
                                    Math.Abs(shape.First.X - shape.Second.X),
                                    Math.Abs(shape.First.Y - shape.Second.Y));
                                g.DrawRectangle(pen, rect);
                                break;

                            case "Ellipse":
                                var ellipse = new Rectangle(
                                    Math.Min(shape.First.X, shape.Second.X),
                                    Math.Min(shape.First.Y, shape.Second.Y),
                                    Math.Abs(shape.First.X - shape.Second.X),
                                    Math.Abs(shape.First.Y - shape.Second.Y));
                                g.DrawEllipse(pen, ellipse);
                                break;

                            case "Line":
                                g.DrawLine(pen, shape.First, shape.Second);
                                break;
                        }
                    }
                }

                foreach (var text in texts)
                {
                    using (Brush brush = new SolidBrush(text.Color))
                    {
                        g.DrawString(text.Text, text.Font, brush, text.Location);
                    }
                }
            }
        }

        private void ïðÿìîêóòíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Rectangle";
            isTextMode = false;
        }

        private void åë³ïñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Ellipse";
            isTextMode = false;
        }

        private void ë³í³ÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Line";
            isTextMode = false;
        }

        private void êîë³ðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void î÷èñòèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            texts.Clear();
            panel1.Invalidate();
        }

        private void òåêñòToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            isTextMode = true;
            int clickCount = 0;
            if (clickCount > 0)
                return;

            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    string inputText = Microsoft.VisualBasic.Interaction.InputBox("Ââåäèòå òåêñò:", "Äîáàâèòü òåêñò", "", -1, -1);
                    if (!string.IsNullOrEmpty(inputText))
                    {
                        panel1.MouseClick += new MouseEventHandler((s, args) =>
                        {
                            if (clickCount == 0)
                            {
                                texts.Add((inputText, args.Location, fontDialog.Font, currentColor));
                                panel1.Invalidate();
                                clickCount++;
                            }
                        });
                    }
                }
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                colorDialog1?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

