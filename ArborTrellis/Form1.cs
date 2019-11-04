using System.Drawing;
using System.Windows.Forms;

namespace ArborTrellis
{
    public partial class Form1 : Form
    {
        static int marginLeftInPixels = 300;
        static int marginTopInPixels = 10;

        static decimal postWidth = 3.5m;
        static decimal postHeight = 84;
        static decimal postSpacing = 18;

        decimal totalWoodWidth => (verticalSplineCount * verticalSplineWidth) + ((verticalSplineCount - 1) * interstitialSplineWidth);
        decimal totalSpacing => postSpacing - totalWoodWidth;
        decimal verticalSplineSpacing => totalSpacing / (verticalSplineCount * 2);
        decimal interstitialSplineWidth => verticalSplineWidth * interstitialSplineMultiplier;
        decimal rowSpacing => (verticalSplineSpacing * 2) + interstitialSplineWidth;

        void init()
        {
            PixelsPerInch = 9;
            VerticalSplineCount = 3;
            VerticalSplineWidth = 1.0m;
            InterSplineMult = 1.0m;
            RowHeight = VerticalSplineWidth;
            ShowInterstitials = true;
        }

        int pixelsPerInch;
        public int PixelsPerInch
        {
            get => pixelsPerInch;
            set
            {
                pixelsPerInch = value;
                nudPixelsPerInch.Value = value;
                this.Refresh();
            }
        }

        int verticalSplineCount = 4;
        public int VerticalSplineCount
        {
            get => verticalSplineCount;
            set
            {
                verticalSplineCount = value;
                nudVerticalSplineCount.Value = value;
                this.Refresh();
            }
        }

        decimal verticalSplineWidth = 1.25m;
        public decimal VerticalSplineWidth
        {
            get => verticalSplineWidth;
            set
            {
                verticalSplineWidth = value;
                nudVerticalSplineWidth.Value = value;
                RowHeight = value;
                this.Refresh();
            }
        }

        decimal interstitialSplineMultiplier = .5m;
        public decimal InterSplineMult
        {
            get => interstitialSplineMultiplier;
            set
            {
                interstitialSplineMultiplier = value;
                nudInterstitialSplineMultiplier.Value = value;
                this.Refresh();
            }
        }

        decimal rowHeight;
        public decimal RowHeight
        {
            get => rowHeight;
            set
            {
                rowHeight = value;
                nudRowHeight.Value = value;
                Refresh();
            }
        }

        bool showInterstitials;
        public bool ShowInterstitials
        {
            get => showInterstitials;
            set
            {
                showInterstitials = value;
                cbxShowInterstitials.Checked = value;
                Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            init();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPosts();
            DrawVerticalSplines();
            DrawHorizontals();
        }

        void DrawPosts()
        {
            using (Graphics g = this.CreateGraphics())
            {
                SolidBrush postBrush = new SolidBrush(Color.Brown);
                Rectangle leftPostRect = CreateRectangleFromInches(
                    0,
                    0,
                    postWidth,
                    postHeight);
                g.FillRectangle(postBrush, leftPostRect);

                Rectangle rightPostRect = CreateRectangleFromInches(
                    postWidth + postSpacing,
                    0,
                    postWidth,
                    postHeight);
                g.FillRectangle(postBrush, rightPostRect);
            }
        }

        void DrawVerticalSplines()
        {
            using (Graphics g = this.CreateGraphics())
            {
                SolidBrush brush = new SolidBrush(Color.Brown);
                decimal lastX = postWidth;
                for (int i = 0; i < verticalSplineCount + verticalSplineCount - 1; i++)
                {
                    lastX += verticalSplineSpacing;
                    decimal currentSplineWidth = (i % 2 == 0) ? verticalSplineWidth : interstitialSplineWidth;
                    Rectangle rect = CreateRectangleFromInches(
                        lastX,
                        0,
                        currentSplineWidth,
                        postHeight);

                    if(showInterstitials == true || i % 2 == 0)
                    {
                        g.FillRectangle(brush, rect);
                    }

                    lastX += currentSplineWidth;
                }
            }
        }

        void DrawHorizontals()
        {
            using (Graphics g = this.CreateGraphics())
            {
                SolidBrush brush = new SolidBrush(Color.Brown);
                decimal currentY = 0;
                while (currentY <= postHeight)
                {
                    currentY += rowSpacing;
                    Rectangle rect = CreateRectangleFromInches(
                        postWidth,
                        currentY,
                        postSpacing,
                        rowHeight);
                    g.FillRectangle(brush, rect);
                    currentY += rowHeight;
                }
            }
        }

        private int inchesToPixels(decimal inches)
        {
            return (int)(inches * pixelsPerInch);
        }

        private Rectangle CreateRectangleFromInches(decimal x, decimal y, decimal width, decimal height)
        {
            return new Rectangle(marginLeftInPixels + inchesToPixels(x), marginTopInPixels + inchesToPixels(y), inchesToPixels(width), inchesToPixels(height));
        }

        private void nudPixelsPerInch_ValueChanged(object sender, System.EventArgs e)
        {
            PixelsPerInch = (int)nudPixelsPerInch.Value;
        }

        private void nudVerticalSplineCount_ValueChanged(object sender, System.EventArgs e)
        {
            VerticalSplineCount = (int)nudVerticalSplineCount.Value;
        }

        private void nudVerticalSplineWidth_ValueChanged(object sender, System.EventArgs e)
        {
            VerticalSplineWidth = nudVerticalSplineWidth.Value;
        }

        private void nudInterstitialSplineMultiplier_ValueChanged(object sender, System.EventArgs e)
        {
            InterSplineMult = nudInterstitialSplineMultiplier.Value;
        }

        private void nudRowHeight_ValueChanged(object sender, System.EventArgs e)
        {
            RowHeight = nudRowHeight.Value;
        }

        private void cbxShowInterstitials_CheckedChanged(object sender, System.EventArgs e)
        {
            ShowInterstitials = cbxShowInterstitials.Checked;
        }
    }
}
