using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win.Gauges.State;

namespace POS {
    public partial class ucCardWidget : UserControl {
        Timer updateTimer = new Timer();
        public ucCardWidget() {
            InitializeComponent();
        }
        public decimal Price { get; set; }
        public double PPrice { get; set; }
        public double Delta { get; set; }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            labelControl1.StateIndex = Delta > 0 ? 0 : 1;
            if(labelControl1.StateIndex == 0)
                labelControl1.Text = Price.ToString("C1") + "<br><color=63,136,48>" + PPrice.ToString("P") + "<br><color=63,136,48><size=+8>" + Delta.ToString("F2");
            else
                labelControl1.Text = Price.ToString("C1") + "<br><color=214,5,5>" + PPrice.ToString("P") + "<br><color=214,5,5><size=+8>" + Delta.ToString("F2");
        }
    }
    public class OverviewLabel : LabelControl {
        static Color positiveColor = Color.FromArgb(63, 136, 48);
        static Color negativeColor = Color.FromArgb(214, 5, 5);
        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            labelControlAppearanceObject = null;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            labelControlAppearanceObject = null;
        }
        protected override void OnPaint(PaintEventArgs e) {
            if(IsDesignMode) return;
            using(GraphicsCache gc = new GraphicsCache(e.Graphics)) {
                gc.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var ap = GetFitAppearance(gc);
                var rect = ClientRectangle;
                //rect.Y -=3;
                rect.Height -= Padding.Bottom;
                StringPainter.Default.DrawString(gc, ap, Text, rect, ap.TextOptions, this);
                DrawStateIndicator(e, (int)ap.Font.Size + 9);
            }
        }
        void DrawStateIndicator(PaintEventArgs e, int height) {
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;
            Point p3 = Point.Empty;
            int width = (int)(2 * height / Math.Sqrt(3));
            p1.X = ClientRectangle.Left + Padding.Left + width / 2;
            p2.X = ClientRectangle.Left + Padding.Left;
            p3.X = ClientRectangle.Left + Padding.Left + width;
            int y = ClientRectangle.Bottom - Padding.Bottom;
            y -= 5;
            Color stateColor = Color.Empty;
            if(StateIndex == 0) {
                p1.Y = y - height;
                p2.Y = p3.Y = y;
                stateColor = positiveColor;
            }
            else {
                p1.Y = y;
                p2.Y = p3.Y = y - height;
                stateColor = negativeColor;
            }
            e.Graphics.FillPolygon(new SolidBrush(stateColor), new Point[] { p1, p2, p3 });
        }
        public int StateIndex { get; set; }
        StringInfo info = new StringInfo();
        LabelControlAppearanceObject labelControlAppearanceObject;
        LabelControlAppearanceObject GetFitAppearance(GraphicsCache gc) {
            if(labelControlAppearanceObject != null) return labelControlAppearanceObject; 
            LabelControlAppearanceObject obj = new LabelControlAppearanceObject();
            obj.Assign(ViewInfo.PaintAppearance);
            obj.Font = new Font(obj.Font.FontFamily, 30);
            info = StringPainter.Default.Calculate(gc.Graphics, obj, obj.TextOptions, Text, new Rectangle(0, 0, 500, 550), gc.Paint, this);
            while(info.Bounds.Height > this.ClientRectangle.Height - Padding.Bottom) {
                if(obj.Font.Size == 1) break;
                obj.Font = new Font(obj.Font.FontFamily, obj.Font.Size - 0.5f);
                info = StringPainter.Default.Calculate(gc.Graphics, obj, obj.TextOptions, Text, new Rectangle(0, 0, 500, 550), gc.Paint, this);
            }
            if(ClientRectangle.Width < info.Bounds.Width)
                Width = info.Bounds.Width;
            labelControlAppearanceObject = obj;
            return obj;
        }
    }
}
