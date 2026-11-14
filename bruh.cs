using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlackAdderReports
{
    // Edit these values to customize the app's basic appearance.
    internal static class MarketDeskStyle
    {
        // Window and workspace backgrounds
        internal const string WindowTitle = "BlackAdder Reports";
        internal const int WindowWidth = 1280;
        internal const int WindowHeight = 720;
        internal static readonly Color WindowBackground = SystemColors.Control;
        internal static readonly Color WorkspaceBackground = Color.LightGray;

        // Menu colors
        internal static readonly Color MenuBarBackground = Color.White;
        internal static readonly Color StatusBarBackground = SystemColors.Control;
        // Space around the data connection dot, in pixels: left, top, right, bottom. The status bar's normal margin is 0, 3, 0, 2.
        // A bigger top number moves the dot down, a bigger bottom number moves it up.
        internal static readonly Padding StatusDotPadding = new Padding(5, 0, 0, 0);
        // Space between buttons inside tiles and the tile edges, in pixels: left, top, right, bottom.
        internal static readonly Padding TileButtonPadding = new Padding(8, 4, 8, 8);
        // Pulsing ring around the data connection dot: strongest opacity (percent), seconds per full pulse,
        // ring thickness and gap to the dot (pixels). It uses the dot's colour (red or green).
        internal const int StatusDotPulseOpacityPercent = 25;
        internal const double StatusDotPulseSeconds = 3.2;
        internal const float StatusDotRingThickness = 2f;
        internal const int StatusDotRingGap = 1;
        // Padding of the ring around the dot, in pixels: left, top, right, bottom. Bigger numbers push that side of the ring
        // further out from the dot, negative numbers pull it in. All 0 = a ring centred on the dot.
        internal static readonly Padding StatusDotRingPadding = new Padding(1, 1, 0, 0);
        internal static readonly Color MenuText = SystemColors.ControlText;
        internal static readonly Color DropdownBackground = Color.White;
        internal static readonly Color DropdownHover = Color.FromArgb(245, 245, 245);
        internal static readonly Color MenuItemHoverBorder = Color.White;
        internal static readonly Color DropdownItemHoverBorder = Color.White;
        internal static readonly Color DropdownBorder = Color.FromArgb(230, 230, 230);

        // Menu spacing, border, and shadow
        internal static readonly Padding MenuItemPadding = new Padding(4, 0, 4, 0);
        internal static string FontName = "Arial";
        internal static float FontSize = 8f;
        // Sizes listed in Global > Text Size. Add or remove numbers here.
        internal static readonly float[] FontSizeChoices = { 6f, 7f, 8f, 9f, 10f, 11f };
        // Fonts listed in Global > Font. Add or remove names here.
        internal static readonly string[] FontChoices = { "Segoe UI", "Arial" };
        internal const bool ShowDropdownBorder = true;
        internal const int DropdownBorderWidth = 1;
        internal const bool ShowDropdownShadow = true;
        // true = Windows 11 style ">" chevron on submenu rows. false = the classic triangle.
        internal const bool UseWindows11Dropdowns = true;
        // How round the corners are in Windows 11 mode. Hover: 2-8 (higher = rounder). Dropdown: true = small system corners, false = normal.
        internal const int HoverCornerSize = 2;
        internal const bool SmallDropdownCorners = true;
        // Minimum pixels between the longest dropdown text and the dropdown border (or the arrow on rows with one).
        internal const int TextRightPadding = 0;
        // Colour of the side popout arrows.
        internal static readonly Color SubmenuArrow = Color.Black;
        // Colours and position of the NY / UTC clocks in the bottom right.
        internal static readonly Color ClockText = Color.FromArgb(120, 120, 120);
        internal static readonly Color ClockSeparator = Color.FromArgb(180, 180, 180);
        // Space between the clocks and the right edge of the window. Raise it to move them left.
        internal const int ClockRightMargin = 1;
        // Blank column on the left of dropdown rows, reserved for icons. Set true if you add icons later.
        internal const bool ShowIconColumn = false;
        // Extra pixels between a dropdown and its side popout. 0 = touching.
        internal const int SubmenuGap = 0;
        // Small windows that open inside the workspace (like Bias Checklist).
        internal static readonly Color ToolWindowBodyBackground = Color.White;
        // Title strip at the top of every tile.
        internal static readonly Color TileTitleBackground = Color.FromArgb(240, 240, 240);
        internal static readonly Color TileTitleLine = Color.FromArgb(200, 200, 200);
        internal const int TileTitleHeight = 22;
        // Blue bar along the bottom of the title strip while a tile is loading or calculating.
        internal static readonly Color TileLoadingBarColor = Color.FromArgb(30, 110, 230);
        // How long the finished bar stays at 100% before it disappears.
        internal const int TileLoadingBarHoldMs = 700;
        // Global > Loading Bar: 0 = Bottom Bar (thin bar under the title), 1 = Title Fill (title strip turns blue as it loads).
        internal static int TileLoadingStyle = 0;
        internal static readonly string[] TileLoadingStyles = { "Bottom Bar", "Title Fill" };
        // Lighter blue for the title fill, so the black title text stays easy to read on it.
        internal static readonly Color TileLoadingFillColor = Color.FromArgb(140, 185, 240);
        internal const int TileTitlePaddingLeft = 6;
        internal const int TileTitleGap = 6; // white space between the title strip and the first dropdown
        internal static int ToolWindowWidth { get { return CompactTiles ? 400 : 420; } }
        internal static int ToolWindowHeight { get { return CompactTiles ? 340 : 400; } }
        internal static int CandleTileBodyHeight { get { return CompactTiles ? 330 : 440; } } // grid height under the title strip
        // Tiles: a 3D frame like DAS Trader. From the outside in: light grey line, dark grey line, the white/yellow band, light grey line, dark grey line.
        internal const int TileBorderThickness = 4;
        internal static readonly Color TileBorderColor = Color.FromArgb(244, 247, 252);
        internal static readonly Color TileSelectedBorderColor = Color.Yellow;
        // How opaque the selected (yellow) border is at the bottom right corner. 255 = solid, 0 = invisible. The top left is always solid.
        internal const int TileSelectedFadePercent = 70; // 0 = no fade (all yellow), 100 = fades fully to the white band colour
        internal static readonly Color TileBevelLight = Color.FromArgb(180, 180, 180);
        internal static readonly Color TileBevelDark = Color.FromArgb(140, 140, 140);
        // Invisible area in the top left corner of every tile. Drag it to move the tile, right click it for settings.
        internal const int TileHandleWidth = 100;
        // Tiles resize by dragging their border. Corner grab size and smallest allowed tile size.
        internal const int TileResizeCornerSize = 16;
        internal const int TileMinWidth = 120;
        internal const int TileMinHeight = 80;
        // Folder where Bias Checklist answers are saved. Set by the launcher; if empty, nothing is saved.
        internal static string DataFolder;
        // Bias Checklist questions. Each line is { "Question", "Answer 1", "Answer 2", ... }.
        // Add, remove or reword lines freely. Saved answers are matched by position, so delete bias-answers.txt after reordering.
        internal static readonly string[][] BiasQuestions = new string[][]
        {
            new string[] { "What is 4h liquidation bias?", "Bullish", "Bearish" },
            new string[] { "What is orderbook bias?", "Bids lower", "Asks higher" },
            new string[] { "Are any traders trapped?", "Not locally", "Shorts trapped", "Longs trapped" },
            new string[] { "What is spot CVD doing?", "Bullish trend", "Bearish trend", "Neutral", "Choppy" },
            new string[] { "What is perp CVD doing?", "Bullish divergence", "Bearish divergence", "Neutral", "Choppy" },
            new string[] { "Open interest vs price?", "OI up, price up", "OI up, price down", "OI down, price up",             "OI down, price down" },
                        new string[] { "Is there a trend and turn?", "Bullish T&T", "Bearish T&T", "None locally" },
                        new string[] { "What is 15m money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 30m money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 1h money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 90m money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 2h money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 4h money flow doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 2.5% OB delta doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is 5% OB delta doing?", "Bullish", "Bearish", "Neutral", "Choppy" },
                        new string[] { "What is EW bias?", "Bullish", "Bearish", "Neutral" },
                        new string[] { "Is there MCB divergences?", "Bullish divergence", "Bearish divergence", "None" },
                        new string[] { "Is a 4h cycle low close?", "Yes", "No" },
                        new string[] { "What is market structure?", "Higher highs / lows", "Lower highs / lows", "Ranging" },
                        new string[] { "What is 1h liquidation bias?", "Bullish", "Bearish" },
                        new string[] { "What is 15m liquidation bias?", "Bullish", "Bearish" },
                        new string[] { "What is hyperliquid stoploss bias?", "Bullish", "Bearish", "Neutral" },
                        new string[] { "What is spot orderbook bias?", "Bids lower", "Asks higher" }
                    };
        // Points for each answer above, in the same order (the "-" none choice is left out): positive = bull point,
        // negative = bear point, BiasNeutralPoints = a neutral answer (Neutral, Choppy, None, Not locally, Ranging and similar).
        // Keep each line the same length as its question's answers.
        internal const double BiasNeutralPoints = 0.5;
        internal static readonly double[][] BiasScores = new double[][]
        {
            new double[] { 3, -3 },
            new double[] { -3, 3 },
            new double[] { 0.5, 3, -3 },
            new double[] { 3, -3, 0.5, 0.5 },
            new double[] { 3, -3, 0.5, 0.5 },
            new double[] { 1, -1, 1, -1 },
            new double[] { 1, -1, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 2, -2, 0.5, 0.5 },
            new double[] { 1, -1, 0.5, 0.5 },
            new double[] { 1, -1, 0.5, 0.5 },
            new double[] { 2, -2, 0.5 },
            new double[] { 2, -2, 0.5 },
            new double[] { 1, 0 },
            new double[] { 3, -3, 0.5 },
            new double[] { 3, -3 },
            new double[] { 3, -3 },
            new double[] { 3, -3, 0.5 },
            new double[] { -3, 3 }
        };
        // Colours of the bear / bull bar that appears when Calculate is pressed.
        internal static readonly Color BearColor = Color.FromArgb(200, 40, 40);
        internal static readonly Color BullColor = Color.FromArgb(40, 160, 70);
        // Global > Tile Size: Normal or Compact. Sizes below are the pair { Normal, Compact }.
        internal static bool CompactTiles = true;
        internal static readonly string[] TileSizes = { "Normal", "Compact" };
        internal static int BiasBarHeight { get { return CompactTiles ? 14 : 18; } }
        internal static int BiasReportHeight { get { return CompactTiles ? 18 : 22; } } // text line under the bar
        internal static int BiasBarTopPadding { get { return CompactTiles ? 6 : 8; } } // white space above the bar
        internal static int BiasRowGap { get { return CompactTiles ? 4 : 8; } } // extra height around each dropdown row
        internal static int TileButtonHeight { get { return CompactTiles ? 22 : 26; } }
        internal static readonly Color BiasDividerColor = Color.FromArgb(200, 200, 200); // grey line at the top of that space
        internal static readonly string[] TileDropdownLooks = { "Old", "New" };
        // Names in Global > Tile Buttons, in order: Old = square 3D button, New = current Windows theme.
        internal static readonly string[] TileButtonLooks = { "Old", "New" };
        // While moving or resizing, a grid shows on the workspace and tiles lock to it.
        internal const int TileGridSize = 8;
        internal static readonly Color TileGridColor = Color.FromArgb(185, 185, 185);
        // Tiles snap to touch another tile when their edges are within this many pixels.
        internal const int TileSnapDistance = 10;
    }

    // The grey canvas. Shows a grid behind the tiles while one is being moved or resized.
    internal sealed class MarketDeskWorkspace : Panel
    {
        private bool showGrid;

        internal MarketDeskWorkspace()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        // Clip the tiles out of the canvas paint and draw the whole canvas off screen, so moving or
        // resizing a tile does not flicker.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x02000000;      // WS_CLIPCHILDREN
                cp.ExStyle |= 0x02000000;    // WS_EX_COMPOSITED
                return cp;
            }
        }

        internal bool ShowGrid
        {
            get { return showGrid; }
            set
            {
                if (showGrid != value)
                {
                    showGrid = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!showGrid)
            {
                return;
            }

            int size = MarketDeskStyle.TileGridSize;
            using (Pen pen = new Pen(MarketDeskStyle.TileGridColor))
            {
                for (int x = 0; x < Width; x += size)
                {
                    e.Graphics.DrawLine(pen, x, 0, x, Height);
                }
                for (int y = 0; y < Height; y += size)
                {
                    e.Graphics.DrawLine(pen, 0, y, Width, y);
                }
            }
        }
    }

    // A tile: a bordered box inside the workspace. Only the green handle in the top left corner moves it.
    // The base rows shown in a tile's settings window report its name, size and position.
    internal class TileSettingsView
    {
        private readonly MarketDeskTile tile;

        internal TileSettingsView(MarketDeskTile tile)
        {
            this.tile = tile;
        }

        [Category("Tile"), ReadOnly(true), Description("Name of the tile, shown in its title strip.")]
        public string Name { get { return tile.Name; } }

        [Category("Size and Position"), ReadOnly(true), Description("Width of the tile in pixels.")]
        public int Width { get { return tile.Width; } }

        [Category("Size and Position"), ReadOnly(true), Description("Height of the tile in pixels.")]
        public int Height { get { return tile.Height; } }

        [Category("Size and Position"), ReadOnly(true), Description("Distance of the tile from the left of the workspace, in pixels.")]
        public int Left { get { return tile.Left; } }

        [Category("Size and Position"), ReadOnly(true), Description("Distance of the tile from the top of the workspace, in pixels.")]
        public int Top { get { return tile.Top; } }

        // Applies edited values when the settings window is confirmed. Tiles with editable values override it.
        internal virtual void Commit() { }
    }

    internal sealed class CandleTileSettingsView : TileSettingsView
    {
        private readonly System.Action<bool[]> applyRowVisibility;
        private readonly bool[] rowVisible;

        internal CandleTileSettingsView(MarketDeskTile tile, bool[] rowVisible,
            System.Action<bool[]> applyRowVisibility) : base(tile)
        {
            this.rowVisible = (bool[])rowVisible.Clone();
            this.applyRowVisibility = applyRowVisibility;
        }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Change %"), Description("Show or hide the Change % row.")]
        public bool ChangePercent { get { return rowVisible[0]; } set { rowVisible[0] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Delta"), Description("Show or hide the Delta row.")]
        public bool Delta { get { return rowVisible[1]; } set { rowVisible[1] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("CVD"), Description("Show or hide the CVD row.")]
        public bool Cvd { get { return rowVisible[2]; } set { rowVisible[2] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Candle POC"), Description("Show or hide the Candle POC row.")]
        public bool CandlePoc { get { return rowVisible[3]; } set { rowVisible[3] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("VAH"), Description("Show or hide the VAH row.")]
        public bool Vah { get { return rowVisible[4]; } set { rowVisible[4] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("VAL"), Description("Show or hide the VAL row.")]
        public bool Val { get { return rowVisible[5]; } set { rowVisible[5] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Buyer POC"), Description("Show or hide the Buyer POC row.")]
        public bool BuyerPoc { get { return rowVisible[6]; } set { rowVisible[6] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Seller POC"), Description("Show or hide the Seller POC row.")]
        public bool SellerPoc { get { return rowVisible[7]; } set { rowVisible[7] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Low Sell Vol"), Description("Show or hide the Low Sell Vol row.")]
        public bool LowSellVolume { get { return rowVisible[8]; } set { rowVisible[8] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Low Seller POC"), Description("Show or hide the Low Seller POC row.")]
        public bool LowSellerPoc { get { return rowVisible[9]; } set { rowVisible[9] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("High Buy Vol"), Description("Show or hide the High Buy Vol row.")]
        public bool HighBuyVolume { get { return rowVisible[10]; } set { rowVisible[10] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("High Buyer POC"), Description("Show or hide the High Buyer POC row.")]
        public bool HighBuyerPoc { get { return rowVisible[11]; } set { rowVisible[11] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Pressure %"), Description("Show or hide the Pressure % row.")]
        public bool PressurePercent { get { return rowVisible[12]; } set { rowVisible[12] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Efficiency"), Description("Show or hide the Efficiency row.")]
        public bool Efficiency { get { return rowVisible[13]; } set { rowVisible[13] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Price / CVD"), Description("Show or hide the Price / CVD row.")]
        public bool PriceCvd { get { return rowVisible[14]; } set { rowVisible[14] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Delta Z"), Description("Show or hide the Delta Z row.")]
        public bool DeltaZ { get { return rowVisible[15]; } set { rowVisible[15] = value; } }

        [Category("Candle Data Rows"), System.ComponentModel.DisplayName("Move Surprise"), Description("Show or hide the Move Surprise row.")]
        public bool MoveSurprise { get { return rowVisible[16]; } set { rowVisible[16] = value; } }

        internal override void Commit()
        {
            applyRowVisibility((bool[])rowVisible.Clone());
        }
    }

    internal sealed class BiasChecklistTileSettingsView : TileSettingsView
    {
        private readonly System.Action<bool> applyShowConfirmButton;
        private bool showConfirmButton;

        internal BiasChecklistTileSettingsView(MarketDeskTile tile, bool showConfirmButton,
            System.Action<bool> applyShowConfirmButton) : base(tile)
        {
            this.showConfirmButton = showConfirmButton;
            this.applyShowConfirmButton = applyShowConfirmButton;
        }

        [Category("Bias Checklist"), System.ComponentModel.DisplayName("Show Confirm Button"),
            Description("Show or hide the Confirm button. Hiding it also unlocks the answers.")]
        public bool ShowConfirmButton
        {
            get { return showConfirmButton; }
            set { showConfirmButton = value; }
        }

        internal override void Commit()
        {
            applyShowConfirmButton(showConfirmButton);
        }
    }

    internal sealed class DataChartTileSettingsView : TileSettingsView
    {
        private readonly System.Action<Color, Color> applyColors;
        private Color lineColor;
        private Color backgroundColor;

        internal DataChartTileSettingsView(MarketDeskTile tile, Color lineColor, Color backgroundColor,
            System.Action<Color, Color> applyColors) : base(tile)
        {
            this.lineColor = lineColor;
            this.backgroundColor = backgroundColor;
            this.applyColors = applyColors;
        }

        [Category("Data Chart"), System.ComponentModel.DisplayName("Data Chart Colour"),
            Description("Colour of the price line.")]
        public Color DataChartColour
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        [Category("Data Chart"), System.ComponentModel.DisplayName("Data Chart Background Colour"),
            Description("Background colour of the chart.")]
        public Color DataChartBackgroundColour
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        internal override void Commit()
        {
            applyColors(lineColor, backgroundColor);
        }
    }

    // A price line on the Data Chart, such as the POC or VAH. A flat level has one price across the range;
    // a developing level has one price per minute (NaN where it is not known yet) and steps with each candle column.
    internal sealed class ChartLevel
    {
        internal ChartLevel(string name, double price, Color lineColor)
        {
            Name = name;
            Price = price;
            LineColor = lineColor;
        }

        internal ChartLevel(string name, double[] values, Color lineColor)
        {
            Name = name;
            Values = values;
            LineColor = lineColor;
            double last = double.NaN;
            foreach (double value in values)
            {
                if (!double.IsNaN(value))
                {
                    last = value;
                }
            }
            Price = last;
        }

        internal string Name { get; private set; }
        internal double Price { get; private set; }
        internal double[] Values { get; private set; }
        internal Color LineColor { get; private set; }
    }

    // Data Chart body: closes from oldest to newest, with dashed price levels across the whole range.
    internal sealed class DataChartCanvas : Panel
    {
        private string message = string.Empty;
        private double[] closes = new double[0];
        private System.Collections.Generic.List<ChartLevel> levels = new System.Collections.Generic.List<ChartLevel>();

        internal Color LineColor { get; set; }

        public DataChartCanvas()
        {
            DoubleBuffered = true;
            BackColor = MarketDeskStyle.ToolWindowBodyBackground;
            LineColor = Color.Gray;
        }

        internal void ShowMessage(string text)
        {
            message = text;
            closes = new double[0];
            levels = new System.Collections.Generic.List<ChartLevel>();
            Invalidate();
        }

        internal void SetSeries(double[] values, System.Collections.Generic.List<ChartLevel> chartLevels)
        {
            message = string.Empty;
            closes = values;
            levels = chartLevels;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            if (closes.Length < 2)
            {
                TextRenderer.DrawText(g, message, Font, ClientRectangle, Color.Gray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
                return;
            }

            double closeMin = closes[0];
            double closeMax = closes[0];
            foreach (double value in closes)
            {
                closeMin = Math.Min(closeMin, value);
                closeMax = Math.Max(closeMax, value);
            }
            double min = closeMin;
            double max = closeMax;
            foreach (ChartLevel level in levels)
            {
                if (level.Values == null)
                {
                    min = Math.Min(min, level.Price);
                    max = Math.Max(max, level.Price);
                    continue;
                }
                foreach (double value in level.Values)
                {
                    if (!double.IsNaN(value))
                    {
                        min = Math.Min(min, value);
                        max = Math.Max(max, value);
                    }
                }
            }
            if (max - min < 0.000001)
            {
                max = min + 1;
            }

            int summaryX = 4;
            foreach (ChartLevel level in levels)
            {
                summaryX = DrawSummaryPart(g, level.Name + " " + level.Price.ToString("0.00") + "   ", level.LineColor, summaryX);
            }

            Rectangle plot = new Rectangle(4, 18, Math.Max(1, Width - 8), Math.Max(1, Height - 22));
            PointF[] points = new PointF[closes.Length];
            for (int i = 0; i < closes.Length; i++)
            {
                float x = plot.Left + (float)i / (closes.Length - 1) * plot.Width;
                float y = plot.Bottom - (float)((closes[i] - min) / (max - min) * plot.Height);
                points[i] = new PointF(x, y);
            }
            using (Pen line = new Pen(LineColor, 1.5f))
            {
                g.DrawLines(line, points);
            }
            foreach (ChartLevel level in levels)
            {
                if (level.Values != null)
                {
                    using (Pen developingPen = new Pen(level.LineColor, 1.5f))
                    {
                        bool hasPrevious = false;
                        PointF previous = PointF.Empty;
                        for (int i = 0; i < level.Values.Length; i++)
                        {
                            if (double.IsNaN(level.Values[i]))
                            {
                                hasPrevious = false;
                                continue;
                            }
                            PointF current = new PointF(plot.Left + (float)i / (closes.Length - 1) * plot.Width,
                                plot.Bottom - (float)((level.Values[i] - min) / (max - min) * plot.Height));
                            if (hasPrevious)
                            {
                                g.DrawLine(developingPen, previous, current);
                            }
                            previous = current;
                            hasPrevious = true;
                        }
                    }
                    continue;
                }
                float levelY = plot.Bottom - (float)((level.Price - min) / (max - min) * plot.Height);
                using (Pen levelPen = new Pen(level.LineColor))
                {
                    levelPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    g.DrawLine(levelPen, plot.Left, levelY, plot.Right, levelY);
                }
            }
        }

        private int DrawSummaryPart(Graphics g, string text, Color color, int x)
        {
            TextRenderer.DrawText(g, text, Font, new Point(x, 2), color, TextFormatFlags.NoPadding);
            return x + TextRenderer.MeasureText(text, Font, Size.Empty, TextFormatFlags.NoPadding).Width;
        }
    }

    // Candles hold one entry per interval; cumulative delta holds one point per interval boundary, starting at zero at StartMs.
    internal sealed class MoneyFlowSeries
    {
        internal long StartMs;
        internal long EndMs;
        internal long IntervalMs;
        internal double[] Open;
        internal double[] High;
        internal double[] Low;
        internal double[] Close;
        internal double[] BuyVolume;
        internal double[] SellVolume;
        internal double[] QuoteDelta;
    }

    internal sealed class MoneyFlowCanvas : Panel
    {
        internal static readonly Color DeltaColor = Color.RoyalBlue;
        internal static readonly Color CandleColor = Color.Black;
        internal static readonly Color BuyVolumeColor = Color.FromArgb(150, 46, 139, 87);
        internal static readonly Color SellVolumeColor = Color.FromArgb(150, 205, 70, 60);
        internal static readonly Color HoverColor = Color.FromArgb(64, 64, 64);
        private MoneyFlowSeries series;
        private string message = "Loading Binance futures money flow...";
        private int hoverX = -1;
        // Plot areas from the last paint, so the self-test checks the same layout that is drawn.
        internal Rectangle PricePlotArea;
        internal Rectangle BuyVolumePlotArea;
        internal Rectangle SellVolumePlotArea;
        internal Rectangle DeltaPlotArea;

        internal MoneyFlowCanvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = MarketDeskStyle.ToolWindowBodyBackground;
        }

        internal void ShowMessage(string text)
        {
            series = null;
            message = text;
            Invalidate();
        }

        internal void SetSeries(MoneyFlowSeries values)
        {
            series = values;
            message = string.Empty;
            Invalidate();
        }

        internal static System.Collections.Generic.List<long> DayBreaks(long startMs, long endMs)
        {
            const long dayMs = 86400000;
            System.Collections.Generic.List<long> result = new System.Collections.Generic.List<long>();
            for (long day = (startMs / dayMs + 1) * dayMs; day < endMs; day += dayMs)
                result.Add(day);
            return result;
        }

        internal static string FormatUsdt(double value)
        {
            double magnitude = Math.Abs(value);
            double divisor = magnitude >= 1000000000 ? 1000000000 : magnitude >= 1000000 ? 1000000 : magnitude >= 1000 ? 1000 : 1;
            string suffix = divisor == 1000000000 ? "B" : divisor == 1000000 ? "M" : divisor == 1000 ? "K" : "";
            return (value / divisor).ToString("0.##", System.Globalization.CultureInfo.InvariantCulture) + suffix;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (series == null)
            {
                TextRenderer.DrawText(g, message, Font, ClientRectangle, Color.DimGray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
                return;
            }

            int lineHeight = Font.Height + 4;
            string candleLabel = (series.IntervalMs / 60000).ToString(System.Globalization.CultureInfo.InvariantCulture) + "m";
            TextRenderer.DrawText(g, "BTCUSDT futures price: " + candleLabel + " candles | Days UTC", Font,
                new Point(4, 2), Color.DimGray, TextFormatFlags.NoPadding);
            int lastIndex = series.QuoteDelta.Length - 1;
            TextRenderer.DrawText(g, "Cumulative taker delta (USDT): futures " + FormatUsdt(series.QuoteDelta[lastIndex]), Font,
                new Point(4, lineHeight + 2), DeltaColor, TextFormatFlags.NoPadding);

            double deltaLow = 0;
            double deltaHigh = 0;
            foreach (double value in series.QuoteDelta)
            {
                if (double.IsNaN(value)) continue;
                deltaLow = Math.Min(deltaLow, value);
                deltaHigh = Math.Max(deltaHigh, value);
            }
            double deltaPad = Math.Max((deltaHigh - deltaLow) * 0.05, 1);
            deltaLow -= deltaPad;
            deltaHigh += deltaPad;
            double volumeLimit = 1;
            for (int i = 0; i < series.Close.Length; i++)
                volumeLimit = Math.Max(volumeLimit, Math.Max(series.BuyVolume[i], series.SellVolume[i]));
            double priceMid;
            double priceHalf;
            double priceLow;
            double priceHigh;
            GetPriceScale(out priceMid, out priceHalf, out priceLow, out priceHigh);
            // All numbers sit on the right, so the left edge only needs a small inset.
            int leftMargin = 4;
            int rightMargin = 0;
            for (int tick = 0; tick <= 4; tick++)
                rightMargin = Math.Max(rightMargin, TextRenderer.MeasureText(FormatUsdt(deltaHigh - tick * (deltaHigh - deltaLow) / 4), Font).Width);
            rightMargin = Math.Max(rightMargin, TextRenderer.MeasureText(FormatUsdt(volumeLimit), Font).Width);
            rightMargin = Math.Max(rightMargin, Math.Max(TextRenderer.MeasureText(FormatPrice(priceLow), Font).Width,
                TextRenderer.MeasureText(FormatPrice(priceHigh), Font).Width)) + 8;
            int top = lineHeight * 2 + 4;
            int bottom = Height - lineHeight - 10;
            int gap = 10;
            int paneTotal = bottom - top - gap * 3;
            int priceHeight = paneTotal * 50 / 100;
            int volumeHeight = paneTotal * 14 / 100;
            int deltaHeight = paneTotal - priceHeight - 2 * volumeHeight;
            int plotWidth = Width - leftMargin - rightMargin;
            Rectangle buyPlot = new Rectangle(leftMargin, top, plotWidth, volumeHeight);
            Rectangle plot = new Rectangle(leftMargin, buyPlot.Bottom + gap, plotWidth, priceHeight);
            Rectangle sellPlot = new Rectangle(leftMargin, plot.Bottom + gap, plotWidth, volumeHeight);
            Rectangle deltaPlot = new Rectangle(leftMargin, sellPlot.Bottom + gap, plotWidth, deltaHeight);
            PricePlotArea = plot;
            BuyVolumePlotArea = buyPlot;
            SellVolumePlotArea = sellPlot;
            DeltaPlotArea = deltaPlot;
            if (plot.Width < 40 || plot.Height < 20 || volumeHeight < 10 || deltaPlot.Height < 20) return;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            using (Pen grid = new Pen(Color.FromArgb(225, 225, 225)))
            using (Pen divider = new Pen(MarketDeskStyle.BiasDividerColor))
            {
                for (int tick = 0; tick <= 4; tick++)
                {
                    float y = plot.Top + tick * plot.Height / 4f;
                    double value = 1 - tick / 2.0;
                    g.DrawLine(grid, plot.Left, y, plot.Right, y);
                    TextRenderer.DrawText(g, FormatPrice(priceMid + value * priceHalf), Font,
                        new Point(plot.Right + 4, (int)y - Font.Height / 2), Color.Black, TextFormatFlags.NoPadding);
                }
                for (int tick = 0; tick <= 4; tick++)
                {
                    float y = deltaPlot.Top + tick * deltaPlot.Height / 4f;
                    double value = deltaHigh - tick * (deltaHigh - deltaLow) / 4;
                    g.DrawLine(grid, deltaPlot.Left, y, deltaPlot.Right, y);
                    TextRenderer.DrawText(g, FormatUsdt(value), Font,
                        new Point(deltaPlot.Right + 4, (int)y - Font.Height / 2), DeltaColor, TextFormatFlags.NoPadding);
                }
                DrawVolumePaneAxis(g, buyPlot, volumeLimit, "Buy volume (USDT)", Color.FromArgb(46, 139, 87));
                DrawVolumePaneAxis(g, sellPlot, volumeLimit, "Sell volume (USDT)", Color.FromArgb(205, 70, 60));
                g.DrawRectangle(divider, plot);
                g.DrawRectangle(divider, deltaPlot);
                System.Collections.Generic.List<long> boundaries = DayBreaks(series.StartMs, series.EndMs);
                int lastLabelRight = deltaPlot.Left - 4;
                foreach (long day in boundaries)
                {
                    float x = plot.Left + (float)((day - series.StartMs) / (double)(series.EndMs - series.StartMs) * plot.Width);
                    g.DrawLine(divider, x, plot.Top, x, plot.Bottom);
                    g.DrawLine(divider, x, deltaPlot.Top, x, deltaPlot.Bottom);
                    string label = DateTimeOffset.FromUnixTimeMilliseconds(day).UtcDateTime.ToString("dd MMM",
                        System.Globalization.CultureInfo.InvariantCulture);
                    int labelWidth = TextRenderer.MeasureText(label, Font).Width;
                    int labelLeft = (int)x - labelWidth / 2;
                    if (labelLeft >= lastLabelRight + 4 && labelLeft + labelWidth <= Width)
                    {
                        TextRenderer.DrawText(g, label, Font, new Point(labelLeft, deltaPlot.Bottom + 4),
                            Color.DimGray, TextFormatFlags.NoPadding);
                        lastLabelRight = labelLeft + labelWidth;
                    }
                }
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawCandles(g, plot, priceMid, priceHalf);
            DrawTakerVolumes(g, buyPlot, sellPlot, volumeLimit);
            DrawSeries(g, deltaPlot, series.QuoteDelta, deltaLow, deltaHigh, DeltaColor);
            DrawHover(g, buyPlot, deltaPlot);
        }

        internal void SetHoverX(int x)
        {
            if (x == hoverX) return;
            hoverX = x;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            SetHoverX(e.X >= PricePlotArea.Left && e.X <= PricePlotArea.Right ? e.X : -1);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetHoverX(-1);
        }

        // Buy volume hangs down from the top of the buy pane and sell volume rises up from the bottom of the sell pane, on one shared scale.
        private void DrawTakerVolumes(Graphics g, Rectangle buyPlot, Rectangle sellPlot, double limit)
        {
            int count = series.Close.Length;
            if (limit <= 0) return;
            float slot = buyPlot.Width / (float)count;
            float barWidth = Math.Max(1f, slot * 0.7f);
            using (Brush buy = new SolidBrush(BuyVolumeColor))
            using (Brush sell = new SolidBrush(SellVolumeColor))
            {
                for (int i = 0; i < count; i++)
                {
                    float x = buyPlot.Left + (i + 0.5f) * slot - barWidth / 2;
                    float buyHeight = (float)(series.BuyVolume[i] / limit * buyPlot.Height);
                    float sellHeight = (float)(series.SellVolume[i] / limit * sellPlot.Height);
                    g.FillRectangle(buy, x, buyPlot.Top, barWidth, buyHeight);
                    g.FillRectangle(sell, x, sellPlot.Bottom - sellHeight, barWidth, sellHeight);
                }
            }
        }

        // Right-side labels for one volume pane (top = shared USDT limit, bottom = 0) and a caption in its corner.
        private void DrawVolumePaneAxis(Graphics g, Rectangle pane, double limit, string caption, Color color)
        {
            int halfFont = Font.Height / 2;
            TextRenderer.DrawText(g, FormatUsdt(limit), Font, new Point(pane.Right + 4, pane.Top - halfFont),
                Color.DimGray, TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, "0", Font, new Point(pane.Right + 4, pane.Bottom - halfFont),
                Color.DimGray, TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, caption, Font, new Point(pane.Left + 4, pane.Top + 2), color,
                TextFormatFlags.NoPadding);
        }

        // Dashed vertical line at the mouse position, spanning from the buy volume pane down to the CVD pane.
        private void DrawHover(Graphics g, Rectangle top, Rectangle bottom)
        {
            if (hoverX < top.Left || hoverX > top.Right) return;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            using (Pen pen = new Pen(HoverColor))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                float x = hoverX + 0.5f;
                g.DrawLine(pen, x, top.Top, x, bottom.Bottom);
            }
        }

        private int DrawPart(Graphics g, string text, Color color, int x, int y)
        {
            TextRenderer.DrawText(g, text, Font, new Point(x, y), color, TextFormatFlags.NoPadding);
            return x + TextRenderer.MeasureText(text, Font, Size.Empty, TextFormatFlags.NoPadding).Width;
        }

        // Pads the BTC range so the candles do not touch the plot edges.
        private void GetPriceScale(out double mid, out double half, out double low, out double high)
        {
            low = double.MaxValue;
            high = double.MinValue;
            for (int i = 0; i < series.Close.Length; i++)
            {
                low = Math.Min(low, series.Low[i]);
                high = Math.Max(high, series.High[i]);
            }
            mid = (low + high) / 2;
            half = Math.Max((high - low) / 2 * 1.05, 1);
            low = mid - half;
            high = mid + half;
        }

        internal static string FormatPrice(double value)
        {
            return value.ToString("#,##0", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void DrawCandles(Graphics g, Rectangle plot, double mid, double half)
        {
            int count = series.Close.Length;
            float slot = plot.Width / (float)count;
            float bodyWidth = Math.Max(1f, slot * 0.7f);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            for (int i = 0; i < count; i++)
            {
                float x = plot.Left + (i + 0.5f) * slot;
                float highY = PriceY(plot, series.High[i], mid, half);
                float lowY = PriceY(plot, series.Low[i], mid, half);
                float openY = PriceY(plot, series.Open[i], mid, half);
                float closeY = PriceY(plot, series.Close[i], mid, half);
                bool up = series.Close[i] >= series.Open[i];
                using (Pen wick = new Pen(CandleColor))
                using (Brush body = new SolidBrush(up ? BackColor : CandleColor))
                using (Pen outline = new Pen(CandleColor))
                {
                    g.DrawLine(wick, x, highY, x, lowY);
                    float top = Math.Min(openY, closeY);
                    float height = Math.Max(1f, Math.Abs(closeY - openY));
                    RectangleF rect = new RectangleF(x - bodyWidth / 2, top, bodyWidth, height);
                    g.FillRectangle(body, rect);
                    g.DrawRectangle(outline, rect.X, rect.Y, rect.Width, rect.Height);
                }
            }
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private static float PriceY(Rectangle plot, double price, double mid, double half)
        {
            return (float)(plot.Top + (1 - (price - mid) / half) * plot.Height / 2);
        }

        private static void DrawSeries(Graphics g, Rectangle plot, double[] values, double low, double high, Color color)
        {
            using (Pen line = new Pen(color, 1.5f))
            {
                bool hasPrevious = false;
                PointF previous = PointF.Empty;
                for (int i = 0; i < values.Length; i++)
                {
                    if (double.IsNaN(values[i]))
                    {
                        hasPrevious = false;
                        continue;
                    }
                    PointF current = new PointF(plot.Left + i * plot.Width / (float)(values.Length - 1),
                        plot.Bottom - (float)((values[i] - low) / (high - low) * plot.Height));
                    if (hasPrevious) g.DrawLine(line, previous, current);
                    previous = current;
                    hasPrevious = true;
                }
            }
        }
    }

    internal sealed class OrderBookDeltaSnapshot
    {
        internal long[] Times;
        internal double[] Values;
        internal long EndMs;
        internal string State;
    }

    internal enum OrderBookApply
    {
        Ignored,
        Applied,
        Gap
    }

    // Keeps a local copy of the Binance futures order book and reports how much resting size each update adds or removes.
    internal sealed class OrderBookDeltaBook
    {
        private static readonly System.Text.RegularExpressions.Regex LevelPattern =
            new System.Text.RegularExpressions.Regex(@"\[""([0-9.]+)"",""([0-9.]+)""\]");
        private readonly System.Collections.Generic.Dictionary<string, decimal> bids = new System.Collections.Generic.Dictionary<string, decimal>();
        private readonly System.Collections.Generic.Dictionary<string, decimal> asks = new System.Collections.Generic.Dictionary<string, decimal>();
        private bool hasSnapshot;
        private bool synced;
        private long snapshotUpdateId;
        private long previousUpdateId;

        internal void Reset()
        {
            bids.Clear();
            asks.Clear();
            hasSnapshot = false;
            synced = false;
        }

        internal void LoadSnapshot(string json)
        {
            System.Text.RegularExpressions.Match id = System.Text.RegularExpressions.Regex.Match(json, @"""lastUpdateId"":(\d+)");
            System.Text.RegularExpressions.Match sides = System.Text.RegularExpressions.Regex.Match(json, SidesPattern("bids", "asks"));
            if (!id.Success || !sides.Success) throw new FormatException("Invalid Binance order book snapshot.");
            Reset();
            ApplyLevels(sides.Groups[1].Value, bids);
            ApplyLevels(sides.Groups[2].Value, asks);
            snapshotUpdateId = long.Parse(id.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
            hasSnapshot = true;
        }

        // Follows Binance's futures rules: the first applied update must bracket the snapshot id, then each update's pu must equal the previous u.
        internal OrderBookApply Apply(string json, out decimal netChange, out long eventTimeMs)
        {
            netChange = 0;
            eventTimeMs = 0;
            if (!hasSnapshot) return OrderBookApply.Gap;
            System.Text.RegularExpressions.Match eventTime = System.Text.RegularExpressions.Regex.Match(json, @"""E"":(\d+)");
            System.Text.RegularExpressions.Match first = System.Text.RegularExpressions.Regex.Match(json, @"""U"":(\d+)");
            System.Text.RegularExpressions.Match last = System.Text.RegularExpressions.Regex.Match(json, @"""u"":(\d+)");
            System.Text.RegularExpressions.Match prior = System.Text.RegularExpressions.Regex.Match(json, @"""pu"":(\d+)");
            System.Text.RegularExpressions.Match sides = System.Text.RegularExpressions.Regex.Match(json, SidesPattern("b", "a"));
            if (!eventTime.Success || !first.Success || !last.Success || !prior.Success || !sides.Success)
                throw new FormatException("Invalid Binance order book update.");
            long firstId = long.Parse(first.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
            long lastId = long.Parse(last.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
            long priorId = long.Parse(prior.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
            eventTimeMs = long.Parse(eventTime.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
            if (lastId <= snapshotUpdateId) return OrderBookApply.Ignored;
            if (!synced)
            {
                if (firstId > snapshotUpdateId + 1) return OrderBookApply.Gap;
                synced = true;
            }
            else if (priorId != previousUpdateId)
            {
                return OrderBookApply.Gap;
            }

            decimal bidChange = ApplyLevels(sides.Groups[1].Value, bids);
            decimal askChange = ApplyLevels(sides.Groups[2].Value, asks);
            previousUpdateId = lastId;
            netChange = bidChange - askChange;
            return OrderBookApply.Applied;
        }

        private static string SidesPattern(string firstKey, string secondKey)
        {
            string levels = @"((?:\[[^\[\]]*\],?)*)";
            return "\"" + firstKey + "\":\\[" + levels + "\\],\"" + secondKey + "\":\\[" + levels + "\\]";
        }

        // Returns the change in total size on this side, and stores the new size at each price level.
        private static decimal ApplyLevels(string text, System.Collections.Generic.Dictionary<string, decimal> side)
        {
            decimal change = 0;
            foreach (System.Text.RegularExpressions.Match level in LevelPattern.Matches(text))
            {
                string price = level.Groups[1].Value;
                decimal quantity = decimal.Parse(level.Groups[2].Value, System.Globalization.CultureInfo.InvariantCulture);
                decimal previous;
                side.TryGetValue(price, out previous);
                change += quantity - previous;
                if (quantity == 0) side.Remove(price);
                else side[price] = quantity;
            }
            return change;
        }
    }

    // Streams Binance futures depth updates and keeps a running total of net resting liquidity added, sampled per minute.
    internal sealed class OrderBookDeltaFeed
    {
        internal const string StreamUrl = "wss://fstream.binance.com/ws/btcusdt@depth";
        internal const string SnapshotUrl = "https://fapi.binance.com/fapi/v1/depth?symbol=BTCUSDT&limit=1000";
        private const long MinuteMs = 60000;
        private readonly Func<string, string> download;
        private readonly object sync = new object();
        private readonly OrderBookDeltaBook book = new OrderBookDeltaBook();
        private readonly System.Collections.Generic.List<long> times = new System.Collections.Generic.List<long>();
        private readonly System.Collections.Generic.List<double> values = new System.Collections.Generic.List<double>();
        private readonly System.Threading.CancellationTokenSource stop = new System.Threading.CancellationTokenSource();
        private decimal cumulative;
        private string state = "Connecting to Binance order book...";

        internal OrderBookDeltaFeed(Func<string, string> download)
        {
            this.download = download;
            System.Threading.Tasks.Task.Run(() => RunAsync(stop.Token));
        }

        internal void Stop()
        {
            stop.Cancel();
        }

        internal OrderBookDeltaSnapshot Snapshot()
        {
            lock (sync)
            {
                OrderBookDeltaSnapshot result = new OrderBookDeltaSnapshot();
                result.Times = times.ToArray();
                result.Values = values.ToArray();
                result.EndMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                result.State = state;
                return result;
            }
        }

        private void SetState(string text)
        {
            lock (sync) state = text;
        }

        private async System.Threading.Tasks.Task RunAsync(System.Threading.CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    await ConnectOnce(token);
                }
                catch (Exception error)
                {
                    if (token.IsCancellationRequested) break;
                    SetState("Reconnecting: " + error.Message);
                }
                try
                {
                    await System.Threading.Tasks.Task.Delay(5000, token);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
            SetState("Stopped");
        }

        private async System.Threading.Tasks.Task ConnectOnce(System.Threading.CancellationToken token)
        {
            using (System.Net.WebSockets.ClientWebSocket socket = new System.Net.WebSockets.ClientWebSocket())
            {
                SetState("Connecting to Binance order book...");
                await socket.ConnectAsync(new Uri(StreamUrl), token);
                book.Reset();
                SetState("Syncing order book...");
                // Updates that arrive while the snapshot downloads are kept and replayed after it loads.
                System.Collections.Generic.List<string> pending = new System.Collections.Generic.List<string>();
                System.Threading.Tasks.Task<string> snapshot = System.Threading.Tasks.Task.Run(() => download(SnapshotUrl));
                while (!snapshot.IsCompleted) pending.Add(await Receive(socket, token));
                book.LoadSnapshot(snapshot.GetAwaiter().GetResult());
                AddPoint(0, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
                foreach (string message in pending) ProcessMessage(message);
                SetState("Live");
                while (!token.IsCancellationRequested) ProcessMessage(await Receive(socket, token));
            }
        }

        private void ProcessMessage(string message)
        {
            decimal netChange;
            long eventTimeMs;
            OrderBookApply result = book.Apply(message, out netChange, out eventTimeMs);
            if (result == OrderBookApply.Gap) throw new InvalidOperationException("Order book sequence gap; resyncing.");
            if (result == OrderBookApply.Applied) AddPoint(netChange, eventTimeMs);
        }

        private void AddPoint(decimal change, long eventTimeMs)
        {
            long minute = eventTimeMs / MinuteMs * MinuteMs;
            lock (sync)
            {
                cumulative += change;
                double value = (double)cumulative;
                if (times.Count > 0 && times[times.Count - 1] == minute) values[values.Count - 1] = value;
                else
                {
                    times.Add(minute);
                    values.Add(value);
                }
            }
        }

        private static async System.Threading.Tasks.Task<string> Receive(System.Net.WebSockets.ClientWebSocket socket, System.Threading.CancellationToken token)
        {
            byte[] buffer = new byte[65536];
            using (System.IO.MemoryStream content = new System.IO.MemoryStream())
            {
                System.Net.WebSockets.WebSocketReceiveResult result;
                do
                {
                    result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), token);
                    if (result.MessageType == System.Net.WebSockets.WebSocketMessageType.Close)
                        throw new System.IO.IOException("Binance closed the order book stream.");
                    content.Write(buffer, 0, result.Count);
                } while (!result.EndOfMessage);
                return System.Text.Encoding.UTF8.GetString(content.ToArray());
            }
        }
    }

    internal sealed class MmdMarketSeries
    {
        internal string Name;
        internal string Symbol;
        internal string Venue;
        internal long StartMs;
        internal long EndMs;
        internal long IntervalMs;
        internal double[] Open;
        internal double[] High;
        internal double[] Low;
        internal double[] Close;
        internal double[] BaseVolume;
        internal double[] QuoteVolume;
        internal double[] QuoteDelta;
        internal double[] CumulativeQuoteDelta;
        internal double[] PriceChangePercent;
        internal double[] VolumeVsAverage;
        internal double[] DeltaPercent;
        internal double[] CumulativeDeltaPercent;
    }

    internal sealed class MmdSeries
    {
        internal long StartMs;
        internal long EndMs;
        internal long IntervalMs;
        internal MmdMarketSeries EthSpot;
        internal MmdMarketSeries EthPerp;
        internal MmdMarketSeries BtcSpot;
        internal MmdMarketSeries BtcPerp;
    }

    internal sealed class MmdChartLine
    {
        internal Color Color;
        internal bool Dashed;
        internal double[] Values;
    }

    internal sealed class MmdSignalEvent
    {
        internal long TimeMs;
        internal string Signal;
        internal string Details;
        internal bool Bullish;
        internal int PreviousPivot = -1;
        internal int Pivot = -1;
        internal int PreviousBtcPivot = -1;
        internal int BtcPivot = -1;
        internal string Marker;
    }

    internal sealed class MmdOutcome
    {
        internal int EntryIndex;
        internal int ExitIndex;
        internal double NetEthPercent;
        internal double RelativePercent;
        internal double AdversePercent;
    }

    internal sealed class MmdOutcomeStats
    {
        internal string Signal;
        internal int Hours;
        internal int Pending;
        internal int Overlapping;
        internal int BaselineCount;
        internal double BaselineNet;
        internal readonly System.Collections.Generic.List<MmdOutcome> Samples =
            new System.Collections.Generic.List<MmdOutcome>();
    }

    internal sealed class MmdAnalysis
    {
        internal string Bias;
        internal string Details;
        internal Color BiasColor;
        internal System.Collections.Generic.List<MmdSignalEvent> Events;
    }

    internal sealed class MmdSwingPoint
    {
        internal int Index;
        internal double Price;
    }

    internal sealed class MmdPivotPair
    {
        internal MmdSwingPoint Eth;
        internal MmdSwingPoint Btc;
    }

    internal sealed class MmdCanvas : Panel
    {
        internal static readonly Color EthColor = Color.FromArgb(25, 125, 70);
        internal static readonly Color BtcColor = Color.FromArgb(195, 75, 35);
        private MmdSeries series;
        private MmdChartLine[][] chartLines;
        private System.Collections.Generic.List<MmdSignalEvent> signals = new System.Collections.Generic.List<MmdSignalEvent>();
        private int[] regimes;
        private int startIndex;
        private int endIndex;
        private int visibleBars = 1440;
        private bool showSpot = true;
        private bool showPerp = true;
        private string message = "Loading 30 days of ETH and BTC spot/perpetual data...";
        private readonly System.Windows.Forms.ToolTip hoverTip = new System.Windows.Forms.ToolTip();
        private int hoverX = -1;
        internal Rectangle[] PlotAreas = new Rectangle[6];
        internal event Action<int> HoverChanged;
        internal int WindowStart { get { return startIndex; } }
        internal int WindowEnd { get { return endIndex; } }

        internal MmdCanvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = MarketDeskStyle.ToolWindowBodyBackground;
        }

        internal void ShowMessage(string text)
        {
            series = null;
            chartLines = null;
            message = text;
            Invalidate();
        }

        internal void SetSeries(MmdSeries values)
        {
            series = values;
            chartLines = BuildChartLines(values);
            regimes = new int[values.EthPerp.Close.Length];
            for (int i = 12; i < regimes.Length; i++)
            {
                double ratioMove = ((values.EthPerp.Close[i] / values.BtcPerp.Close[i]) /
                    (values.EthPerp.Close[i - 12] / values.BtcPerp.Close[i - 12]) - 1) * 100;
                regimes[i] = ratioMove >= 0.30 ? 1 : ratioMove <= -0.30 ? -1 : 0;
            }
            endIndex = values.EthPerp.Close.Length - 1;
            startIndex = Math.Max(0, endIndex - visibleBars + 1);
            message = string.Empty;
            Invalidate();
        }

        internal void SetSignals(System.Collections.Generic.List<MmdSignalEvent> values)
        {
            signals = values;
            Invalidate();
        }

        internal void SetWindow(int bars)
        {
            visibleBars = bars;
            if (series == null) return;
            endIndex = series.EthPerp.Close.Length - 1;
            startIndex = Math.Max(0, endIndex - bars + 1);
            Invalidate();
        }

        internal void FocusSignal(long timeMs)
        {
            if (series == null) return;
            int index = Math.Max(0, Math.Min(series.EthPerp.Close.Length - 1,
                (int)((timeMs - series.StartMs) / series.IntervalMs) - 1));
            visibleBars = 96;
            startIndex = Math.Max(0, index - 60);
            endIndex = Math.Min(series.EthPerp.Close.Length - 1, startIndex + visibleBars - 1);
            Invalidate();
        }

        internal void Pan(int direction)
        {
            if (series == null) return;
            int count = endIndex - startIndex + 1;
            startIndex = Math.Max(0, Math.Min(series.EthPerp.Close.Length - count,
                startIndex + direction * Math.Max(1, count / 2)));
            endIndex = startIndex + count - 1;
            Invalidate();
        }

        internal void SetFlowVisibility(bool spot, bool perp)
        {
            showSpot = spot;
            showPerp = perp;
            Invalidate();
        }

        private bool LineVisible(MmdChartLine[] lines, MmdChartLine line)
        {
            return lines == chartLines[0] || (line.Dashed ? showPerp : showSpot);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            if (series == null)
            {
                TextRenderer.DrawText(g, message, Font, ClientRectangle, Color.DimGray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
                return;
            }

            int lineHeight = Font.Height + 4;
            TextRenderer.DrawText(g, "30m UTC | Shading: 6h ETH strength/weakness | Triangles: confirmed signals | " +
                DateTimeOffset.FromUnixTimeMilliseconds(series.StartMs + startIndex * series.IntervalMs).UtcDateTime.ToString("dd MMM HH:mm") +
                " - " + DateTimeOffset.FromUnixTimeMilliseconds(series.StartMs + endIndex * series.IntervalMs).UtcDateTime.ToString("dd MMM HH:mm"),
                Font, new Point(4, 2), Color.DimGray, TextFormatFlags.NoPadding);
            MmdMarketSeries[] markets = GetMarkets(series);
            int legendX = 4;
            for (int i = 0; i < markets.Length; i++)
            {
                using (Pen pen = new Pen(MarketColor(markets[i]), 2f))
                {
                    if (markets[i].Venue == "Perp")
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    g.DrawLine(pen, legendX, lineHeight + 3, legendX + 18, lineHeight + 3);
                }
                string label = markets[i].Name + "   ";
                TextRenderer.DrawText(g, label, Font, new Point(legendX + 22, lineHeight - 3),
                    MarketColor(markets[i]), TextFormatFlags.NoPadding);
                legendX += 22 + TextRenderer.MeasureText(label, Font, Size.Empty, TextFormatFlags.NoPadding).Width;
            }

            int top = lineHeight * 2 + 3;
            int bottom = Height - lineHeight - 4;
            int gap = 5;
            int paneHeight = Math.Max(1, (bottom - top - gap * 5) / 6);
            string[] titles =
            {
                "Perp price (%) + 24h candle-VWAP proxy (dashed): ETH green / BTC red",
                "ETH/BTC ratio (%) | green = spot, red dashed = perp",
                "ETH actual cumulative taker delta (USDT millions): spot solid / perp dashed",
                "BTC actual cumulative taker delta (USDT millions): spot solid / perp dashed",
                "6h taker pressure edge: ETH minus BTC (pp) | green = spot, red dashed = perp",
                "Relative volume: ETH spot solid / perp dashed, BTC spot solid / perp dashed"
            };

            for (int pane = 0; pane < PlotAreas.Length; pane++)
            {
                Rectangle area = new Rectangle(0, top + pane * (paneHeight + gap), Width, paneHeight);
                PlotAreas[pane] = DrawPane(g, area, titles[pane], chartLines[pane],
                    double.NaN, double.NaN, pane == 5 ? "x" : pane == 2 || pane == 3 ? "M" : pane == 4 ? "pp" : "%",
                    pane == 4, pane == 5);
            }
            DrawHover(g);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            bool inside = false;
            for (int i = 0; i < PlotAreas.Length; i++)
            {
                if (PlotAreas[i].Contains(e.Location))
                {
                    inside = true;
                    break;
                }
            }
            int nextX = inside ? e.X : -1;
            if (nextX != hoverX)
            {
                hoverX = nextX;
                Invalidate();
            }
            if (inside && series != null)
            {
                int index = Math.Max(startIndex, Math.Min(endIndex, startIndex +
                    (int)Math.Round((e.X - PlotAreas[0].Left) / (double)Math.Max(1, PlotAreas[0].Width) * (endIndex - startIndex))));
                hoverTip.SetToolTip(this, FormatHover(index));
                if (HoverChanged != null) HoverChanged(index);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoverX = -1;
            hoverTip.SetToolTip(this, string.Empty);
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) hoverTip.Dispose();
            base.Dispose(disposing);
        }

        private Rectangle DrawPane(Graphics g, Rectangle area, string title, MmdChartLine[] lines,
            double fixedMin, double fixedMax, string suffix, bool includeZero, bool showDates)
        {
            TextRenderer.DrawText(g, title, Font, new Point(4, area.Top), Color.Black, TextFormatFlags.NoPadding);
            int titleHeight = Font.Height + 2;
            Rectangle plot = new Rectangle(42, area.Top + titleHeight, Math.Max(1, Width - 94),
                Math.Max(1, area.Height - titleHeight - (showDates ? Font.Height + 3 : 1)));
            double min = double.IsNaN(fixedMin) ? double.MaxValue : fixedMin;
            double max = double.IsNaN(fixedMax) ? double.MinValue : fixedMax;
            if (double.IsNaN(fixedMin))
            {
                foreach (MmdChartLine line in lines)
                {
                    if (!LineVisible(lines, line)) continue;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        double value = line.Values[i];
                        if (double.IsNaN(value) || double.IsInfinity(value)) continue;
                        min = Math.Min(min, value);
                        max = Math.Max(max, value);
                    }
                }
                if (lines == chartLines[0])
                {
                    foreach (MmdMarketSeries market in new MmdMarketSeries[] { series.EthPerp, series.BtcPerp })
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            min = Math.Min(min, (market.Low[i] / market.Close[0] - 1) * 100);
                            max = Math.Max(max, (market.High[i] / market.Close[0] - 1) * 100);
                        }
                    }
                }
                if (min == double.MaxValue || max == double.MinValue)
                {
                    min = 0;
                    max = 1;
                }
                if (includeZero)
                {
                    min = Math.Min(min, 0);
                    max = Math.Max(max, 0);
                }
                double padding = Math.Max((max - min) * 0.06, 0.1);
                min -= padding;
                max += padding;
            }
            if (max - min < 0.000001)
            {
                max = min + 1;
            }

            using (Brush strengthShade = new SolidBrush(Color.FromArgb(18, EthColor)))
            using (Brush weaknessShade = new SolidBrush(Color.FromArgb(18, BtcColor)))
            {
                float slot = plot.Width / (float)Math.Max(1, endIndex - startIndex);
                for (int i = startIndex; i < endIndex; )
                {
                    int runStart = i;
                    int regime = regimes[i];
                    while (i < endIndex && regimes[i] == regime) i++;
                    if (regime != 0)
                        g.FillRectangle(regime > 0 ? strengthShade : weaknessShade,
                            plot.Left + (runStart - startIndex) * slot, plot.Top, (i - runStart) * slot, plot.Height);
                }
            }
            using (Pen grid = new Pen(Color.FromArgb(230, 230, 230)))
            using (Pen divider = new Pen(MarketDeskStyle.BiasDividerColor))
            {
                for (int tick = 0; tick <= 2; tick++)
                {
                    float y = plot.Top + tick * plot.Height / 2f;
                    double value = max - tick * (max - min) / 2;
                    g.DrawLine(grid, plot.Left, y, plot.Right, y);
                    string label = value.ToString("0.#", System.Globalization.CultureInfo.InvariantCulture) + suffix;
                    TextRenderer.DrawText(g, label, Font, new Point(plot.Right + 3, (int)y - Font.Height / 2),
                        Color.DimGray, TextFormatFlags.NoPadding);
                }
                if (min < 0 && max > 0)
                {
                    float zeroY = plot.Bottom - (float)((0 - min) / (max - min) * plot.Height);
                    using (Pen zero = new Pen(Color.FromArgb(150, 150, 150)))
                    {
                        zero.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        g.DrawLine(zero, plot.Left, zeroY, plot.Right, zeroY);
                    }
                }
                int lastDateLabelRight = plot.Left - 4;
                long visibleStart = series.StartMs + startIndex * series.IntervalMs;
                long visibleEnd = series.StartMs + endIndex * series.IntervalMs;
                foreach (long day in MoneyFlowCanvas.DayBreaks(visibleStart, visibleEnd))
                {
                    float x = plot.Left + (float)((day - visibleStart) / (double)(visibleEnd - visibleStart) * plot.Width);
                    g.DrawLine(divider, x, plot.Top, x, plot.Bottom);
                    if (showDates)
                    {
                        string label = DateTimeOffset.FromUnixTimeMilliseconds(day).UtcDateTime.ToString("dd MMM",
                            System.Globalization.CultureInfo.InvariantCulture);
                        int labelWidth = TextRenderer.MeasureText(label, Font).Width;
                        int labelLeft = (int)x - labelWidth / 2;
                        if (labelLeft >= lastDateLabelRight + 3 && labelLeft + labelWidth <= Width)
                        {
                            TextRenderer.DrawText(g, label, Font, new Point(labelLeft, area.Bottom - Font.Height),
                                Color.DimGray, TextFormatFlags.NoPadding);
                            lastDateLabelRight = labelLeft + labelWidth;
                        }
                    }
                }
                g.DrawRectangle(divider, plot);
            }

            System.Drawing.Drawing2D.SmoothingMode previousMode = g.SmoothingMode;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsState state = g.Save();
            g.SetClip(plot);
            foreach (MmdChartLine line in lines)
            {
                if (!LineVisible(lines, line)) continue;
                using (Pen pen = new Pen(line.Color, 1.4f))
                {
                    if (line.Dashed) pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    System.Collections.Generic.List<PointF> segment = new System.Collections.Generic.List<PointF>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        double value = line.Values[i];
                        if (double.IsNaN(value) || double.IsInfinity(value))
                        {
                            if (segment.Count > 1) g.DrawLines(pen, segment.ToArray());
                            segment.Clear();
                            continue;
                        }
                        PointF current = new PointF(plot.Left + (float)(i - startIndex) / Math.Max(1, endIndex - startIndex) * plot.Width,
                            plot.Bottom - (float)((value - min) / (max - min) * plot.Height));
                        segment.Add(current);
                    }
                    if (segment.Count > 1) g.DrawLines(pen, segment.ToArray());
                }
            }
            if (lines == chartLines[0] && endIndex - startIndex <= 336)
            {
                DrawPriceCandles(g, plot, series.EthPerp, EthColor, min, max);
                DrawPriceCandles(g, plot, series.BtcPerp, BtcColor, min, max);
            }
            if (lines == chartLines[0] || lines == chartLines[2])
                DrawSignals(g, plot, min, max, lines == chartLines[0]);
            g.Restore(state);
            g.SmoothingMode = previousMode;
            return plot;
        }

        private void DrawSignals(Graphics g, Rectangle plot, double min, double max, bool price)
        {
            foreach (MmdSignalEvent signal in signals)
            {
                if (signal.Pivot < 0 || !price && (signal.Marker != "S" && signal.Marker != "F" ||
                    signal.Marker == "S" && !showSpot || signal.Marker == "F" && !showPerp)) continue;
                int index = (int)((signal.TimeMs - series.StartMs) / series.IntervalMs) - 1;
                if (index < startIndex || index > endIndex) continue;
                Color color = signal.Bullish ? Color.DarkGreen : Color.Firebrick;
                float x = plot.Left + (float)(index - startIndex) / Math.Max(1, endIndex - startIndex) * plot.Width;
                float y = signal.Bullish ? plot.Bottom - 3 : plot.Top + 3;
                using (Brush marker = new SolidBrush(color))
                    g.FillPolygon(marker, new PointF[] { new PointF(x, y),
                        new PointF(x - 4, y + (signal.Bullish ? -8 : 8)), new PointF(x + 4, y + (signal.Bullish ? -8 : 8)) });
                TextRenderer.DrawText(g, signal.Marker, Font, new Point((int)x + 4,
                    (int)y - (signal.Bullish ? Font.Height + 2 : 0)), color, TextFormatFlags.NoPadding);
                if (signal.PreviousPivot >= startIndex && signal.Pivot <= endIndex)
                {
                    double first;
                    double second;
                    if (price)
                    {
                        double[] extremes = signal.Bullish ? series.EthPerp.Low : series.EthPerp.High;
                        first = (extremes[signal.PreviousPivot] / series.EthPerp.Close[0] - 1) * 100;
                        second = (extremes[signal.Pivot] / series.EthPerp.Close[0] - 1) * 100;
                    }
                    else
                    {
                        double[] pivotValues = signal.Marker == "S" ? chartLines[2][0].Values : chartLines[2][1].Values;
                        first = pivotValues[signal.PreviousPivot];
                        second = pivotValues[signal.Pivot];
                    }
                    DrawPivotLink(g, plot, min, max, signal.PreviousPivot, signal.Pivot, first, second, color);
                }
                if (price && signal.PreviousBtcPivot >= startIndex && signal.BtcPivot <= endIndex)
                {
                    double[] extremes = signal.Bullish ? series.BtcPerp.Low : series.BtcPerp.High;
                    double first = (extremes[signal.PreviousBtcPivot] / series.BtcPerp.Close[0] - 1) * 100;
                    double second = (extremes[signal.BtcPivot] / series.BtcPerp.Close[0] - 1) * 100;
                    DrawPivotLink(g, plot, min, max, signal.PreviousBtcPivot, signal.BtcPivot, first, second, BtcColor);
                }
            }
        }

        private void DrawPivotLink(Graphics g, Rectangle plot, double min, double max, int before, int current,
            double first, double second, Color color)
        {
            using (Pen link = new Pen(color, 2))
            {
                link.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(link,
                    plot.Left + (float)(before - startIndex) / Math.Max(1, endIndex - startIndex) * plot.Width,
                    plot.Bottom - (float)((first - min) / (max - min) * plot.Height),
                    plot.Left + (float)(current - startIndex) / Math.Max(1, endIndex - startIndex) * plot.Width,
                    plot.Bottom - (float)((second - min) / (max - min) * plot.Height));
            }
        }

        private void DrawPriceCandles(Graphics g, Rectangle plot, MmdMarketSeries market, Color color,
            double min, double max)
        {
            double anchor = market.Close[0];
            float slot = plot.Width / (float)Math.Max(1, endIndex - startIndex);
            using (Pen wick = new Pen(Color.FromArgb(150, color)))
            using (Brush body = new SolidBrush(Color.FromArgb(100, color)))
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    float x = plot.Left + (i - startIndex) * slot;
                    float highY = plot.Bottom - (float)(((market.High[i] / anchor - 1) * 100 - min) / (max - min) * plot.Height);
                    float lowY = plot.Bottom - (float)(((market.Low[i] / anchor - 1) * 100 - min) / (max - min) * plot.Height);
                    float openY = plot.Bottom - (float)(((market.Open[i] / anchor - 1) * 100 - min) / (max - min) * plot.Height);
                    float closeY = plot.Bottom - (float)(((market.Close[i] / anchor - 1) * 100 - min) / (max - min) * plot.Height);
                    g.DrawLine(wick, x, highY, x, lowY);
                    g.FillRectangle(body, x - Math.Max(1, slot * 0.3f), Math.Min(openY, closeY),
                        Math.Max(1, slot * 0.6f), Math.Max(1, Math.Abs(openY - closeY)));
                }
            }
        }

        private void DrawHover(Graphics g)
        {
            if (hoverX < 0) return;
            using (Pen pen = new Pen(Color.FromArgb(64, 64, 64)))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                for (int i = 0; i < PlotAreas.Length; i++)
                {
                    Rectangle plot = PlotAreas[i];
                    if (hoverX >= plot.Left && hoverX <= plot.Right)
                        g.DrawLine(pen, hoverX + 0.5f, plot.Top, hoverX + 0.5f, plot.Bottom);
                }
            }
        }

        private string FormatHover(int index)
        {
            long time = series.StartMs + index * series.IntervalMs;
            System.Text.StringBuilder text = new System.Text.StringBuilder();
            text.Append(DateTimeOffset.FromUnixTimeMilliseconds(time).UtcDateTime.ToString("dd MMM HH:mm",
                System.Globalization.CultureInfo.InvariantCulture)).Append(" UTC");
            text.Append(regimes[index] > 0 ? " | ETH relative strength" : regimes[index] < 0 ? " | ETH relative weakness" : " | Mixed");
            foreach (MmdSignalEvent signal in signals)
            {
                int signalIndex = (int)((signal.TimeMs - series.StartMs) / series.IntervalMs) - 1;
                if (Math.Abs(signalIndex - index) <= 1)
                    text.Append("\r\n").Append(signal.Signal).Append(": ").Append(signal.Details);
            }
            foreach (MmdMarketSeries market in GetMarkets(series))
            {
                text.Append("\r\n").Append(market.Name).Append(": ")
                    .Append(market.Close[index].ToString("#,##0.00", System.Globalization.CultureInfo.InvariantCulture))
                    .Append(" | Delta ").Append(market.DeltaPercent[index].ToString("+0.0;-0.0;0.0",
                        System.Globalization.CultureInfo.InvariantCulture)).Append("%")
                    .Append(" | CVD ").Append(market.CumulativeQuoteDelta[index] > 0 ? "+" : string.Empty)
                    .Append(MoneyFlowCanvas.FormatUsdt(market.CumulativeQuoteDelta[index]))
                    .Append(" | Vol ").Append(MoneyFlowCanvas.FormatUsdt(market.QuoteVolume[index]));
            }
            return text.ToString();
        }

        private static MmdMarketSeries[] GetMarkets(MmdSeries values)
        {
            return new MmdMarketSeries[] { values.EthSpot, values.EthPerp, values.BtcSpot, values.BtcPerp };
        }

        private static Color MarketColor(MmdMarketSeries market)
        {
            return market.Symbol == "ETHUSDT" ? EthColor : BtcColor;
        }

        internal static double[] RollingPressure(MmdMarketSeries market)
        {
            double[] result = new double[market.Close.Length];
            double delta = 0;
            double volume = 0;
            for (int i = 0; i < result.Length; i++)
            {
                delta += market.QuoteDelta[i];
                volume += market.QuoteVolume[i];
                if (i >= 12)
                {
                    delta -= market.QuoteDelta[i - 12];
                    volume -= market.QuoteVolume[i - 12];
                }
                result[i] = i >= 11 && volume > 0 ? delta / volume * 100 : double.NaN;
            }
            return result;
        }

        internal static double[] RollingVwap(MmdMarketSeries market)
        {
            double[] result = new double[market.Close.Length];
            double weighted = 0;
            double volume = 0;
            for (int i = 0; i < result.Length; i++)
            {
                double weight = market.BaseVolume[i];
                weighted += (market.High[i] + market.Low[i] + market.Close[i]) / 3 * weight;
                volume += weight;
                if (i >= 48)
                {
                    int old = i - 48;
                    double oldWeight = market.BaseVolume[old];
                    weighted -= (market.High[old] + market.Low[old] + market.Close[old]) / 3 * oldWeight;
                    volume -= oldWeight;
                }
                result[i] = i >= 47 && volume > 0 ? (weighted / volume / market.Close[0] - 1) * 100 : double.NaN;
            }
            return result;
        }

        private static MmdChartLine[][] BuildChartLines(MmdSeries values)
        {
            MmdMarketSeries[] markets = GetMarkets(values);
            MmdChartLine[] prices = new MmdChartLine[] {
                new MmdChartLine { Color = EthColor, Values = values.EthPerp.PriceChangePercent },
                new MmdChartLine { Color = BtcColor, Values = values.BtcPerp.PriceChangePercent },
                new MmdChartLine { Color = EthColor, Dashed = true, Values = RollingVwap(values.EthPerp) },
                new MmdChartLine { Color = BtcColor, Dashed = true, Values = RollingVwap(values.BtcPerp) }
            };
            double[] ethSpot = RollingPressure(values.EthSpot);
            double[] ethPerp = RollingPressure(values.EthPerp);
            double[] btcSpot = RollingPressure(values.BtcSpot);
            double[] btcPerp = RollingPressure(values.BtcPerp);
            for (int i = 0; i < ethSpot.Length; i++)
            {
                ethSpot[i] -= btcSpot[i];
                ethPerp[i] -= btcPerp[i];
            }
            MmdChartLine[] pressure = new MmdChartLine[] {
                new MmdChartLine { Color = EthColor, Values = ethSpot },
                new MmdChartLine { Color = BtcColor, Dashed = true, Values = ethPerp }
            };
            return new MmdChartLine[][] { prices, BuildRelativeLines(values),
                BuildCvdLines(values.EthSpot, values.EthPerp, EthColor),
                BuildCvdLines(values.BtcSpot, values.BtcPerp, BtcColor),
                pressure, BuildMarketLines(markets, delegate(MmdMarketSeries market) { return market.VolumeVsAverage; }) };
        }

        private static MmdChartLine[] BuildCvdLines(MmdMarketSeries spot, MmdMarketSeries perp, Color color)
        {
            double[] spotValues = new double[spot.Close.Length];
            double[] perpValues = new double[perp.Close.Length];
            for (int i = 0; i < spotValues.Length; i++)
            {
                spotValues[i] = spot.CumulativeQuoteDelta[i] / 1000000;
                perpValues[i] = perp.CumulativeQuoteDelta[i] / 1000000;
            }
            return new MmdChartLine[] {
                new MmdChartLine { Color = color, Values = spotValues },
                new MmdChartLine { Color = color, Dashed = true, Values = perpValues }
            };
        }

        private static MmdChartLine[] BuildMarketLines(MmdMarketSeries[] markets,
            Func<MmdMarketSeries, double[]> selectValues)
        {
            MmdChartLine[] lines = new MmdChartLine[markets.Length];
            for (int i = 0; i < markets.Length; i++)
            {
                lines[i] = new MmdChartLine {
                    Color = MarketColor(markets[i]),
                    Dashed = markets[i].Venue == "Perp",
                    Values = selectValues(markets[i])
                };
            }
            return lines;
        }

        private static MmdChartLine[] BuildRelativeLines(MmdSeries values)
        {
            double[] spot = new double[values.EthSpot.Close.Length];
            double[] perp = new double[values.EthPerp.Close.Length];
            double spotStart = values.EthSpot.Close[0] / values.BtcSpot.Close[0];
            double perpStart = values.EthPerp.Close[0] / values.BtcPerp.Close[0];
            for (int i = 0; i < spot.Length; i++)
            {
                spot[i] = ((values.EthSpot.Close[i] / values.BtcSpot.Close[i]) / spotStart - 1) * 100;
                perp[i] = ((values.EthPerp.Close[i] / values.BtcPerp.Close[i]) / perpStart - 1) * 100;
            }
            return new MmdChartLine[]
            {
                new MmdChartLine { Color = EthColor, Values = spot },
                new MmdChartLine { Color = BtcColor, Dashed = true, Values = perp }
            };
        }
    }

    internal sealed class OrderBookDeltaCanvas : Panel
    {
        internal static readonly Color LineColor = Color.DarkOrange;
        private OrderBookDeltaSnapshot data;
        private string message = "Connecting to Binance order book...";

        internal OrderBookDeltaCanvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = MarketDeskStyle.ToolWindowBodyBackground;
        }

        internal void SetSnapshot(OrderBookDeltaSnapshot snapshot)
        {
            data = snapshot;
            Invalidate();
        }

        internal void ShowMessage(string text)
        {
            data = null;
            message = text;
            Invalidate();
        }

        internal static string FormatBtc(double value)
        {
            return value.ToString("+0.000;-0.000;0.000", System.Globalization.CultureInfo.InvariantCulture);
        }

        private static float XPosition(long time, long start, long end, Rectangle plot)
        {
            return plot.Left + (float)((time - start) / (double)(end - start) * plot.Width);
        }

        private static float YPosition(double value, double limit, Rectangle plot)
        {
            return plot.Top + (float)((1 - value / limit) * plot.Height / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (data == null || data.Times.Length == 0)
            {
                TextRenderer.DrawText(g, message, Font, ClientRectangle, Color.DimGray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
                return;
            }

            int lineHeight = Font.Height + 4;
            double last = data.Values[data.Values.Length - 1];
            TextRenderer.DrawText(g, "BTCUSDT futures order book | Net resting liquidity added (BTC): + bids, - asks | UTC", Font,
                new Point(4, 2), Color.DimGray, TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, "Cumulative since start: " + FormatBtc(last) + " BTC | " + data.State, Font,
                new Point(4, lineHeight + 2), LineColor, TextFormatFlags.NoPadding);

            double limit = 0.001;
            foreach (double value in data.Values) limit = Math.Max(limit, Math.Abs(value));
            limit *= 1.1;
            int leftMargin = TextRenderer.MeasureText(FormatBtc(-limit), Font).Width + 8;
            Rectangle plot = new Rectangle(leftMargin, lineHeight * 2 + 6, Width - leftMargin - 8, Height - lineHeight * 3 - 10);
            if (plot.Width < 40 || plot.Height < 20) return;

            long startMs = data.Times[0];
            long endMs = Math.Max(data.EndMs, data.Times[data.Times.Length - 1]);
            if (endMs - startMs < 60000) endMs = startMs + 60000;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            using (Pen grid = new Pen(Color.FromArgb(225, 225, 225)))
            using (Pen divider = new Pen(MarketDeskStyle.BiasDividerColor))
            {
                for (int tick = 0; tick <= 4; tick++)
                {
                    float y = plot.Top + tick * plot.Height / 4f;
                    double value = limit - tick * 2 * limit / 4;
                    g.DrawLine(grid, plot.Left, y, plot.Right, y);
                    TextRenderer.DrawText(g, FormatBtc(value), Font,
                        new Rectangle(0, (int)y - Font.Height / 2, plot.Left - 4, Font.Height + 2), Color.DimGray,
                        TextFormatFlags.Right | TextFormatFlags.NoPadding);
                }
                g.DrawRectangle(divider, plot);
                for (int tick = 0; tick <= 4; tick++)
                {
                    long time = startMs + (endMs - startMs) * tick / 4;
                    string label = DateTimeOffset.FromUnixTimeMilliseconds(time).UtcDateTime.ToString("HH:mm",
                        System.Globalization.CultureInfo.InvariantCulture);
                    int labelWidth = TextRenderer.MeasureText(label, Font).Width;
                    int labelLeft = Math.Max(0, Math.Min(Width - labelWidth, (int)XPosition(time, startMs, endMs, plot) - labelWidth / 2));
                    TextRenderer.DrawText(g, label, Font, new Point(labelLeft, plot.Bottom + 4), Color.DimGray, TextFormatFlags.NoPadding);
                }
            }

            int count = data.Times.Length;
            bool extend = data.EndMs > data.Times[count - 1];
            PointF[] points = new PointF[count + (extend ? 1 : 0)];
            for (int i = 0; i < count; i++)
                points[i] = new PointF(XPosition(data.Times[i], startMs, endMs, plot), YPosition(data.Values[i], limit, plot));
            if (extend)
                points[count] = new PointF(XPosition(endMs, startMs, endMs, plot), YPosition(last, limit, plot));

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (points.Length >= 2)
            {
                using (Pen line = new Pen(LineColor, 1.5f))
                {
                    g.DrawLines(line, points);
                }
            }
        }
    }

    internal sealed class TradingViewSeries
    {
        internal long StartMs;
        internal long IntervalMs;
        internal double[] Open;
        internal double[] High;
        internal double[] Low;
        internal double[] Close;
        internal double[] Volume;
    }

    internal sealed class VolumeRejection
    {
        internal int Index;
        internal bool Bearish;
    }

    internal sealed class VolumeRejectionReport
    {
        internal double MinPrice;
        internal double BinSize;
        internal bool[] HighVolumeBins;
        internal System.Collections.Generic.List<VolumeRejection> Rejections = new System.Collections.Generic.List<VolumeRejection>();
    }

    // Hindsight only: a marker needs ConfirmBars of follow-through, so the newest bars are never marked.
    internal static class VolumeRejectionRules
    {
        internal const int Bins = 100;
        internal const double HighVolumeFactor = 1.5;
        internal const int AtrPeriod = 14;
        internal const int ConfirmBars = 8;
        internal const double ConfirmAtrMultiple = 1.0;

        internal static VolumeRejectionReport Detect(TradingViewSeries series)
        {
            int count = series.Close.Length;
            VolumeRejectionReport report = new VolumeRejectionReport();
            report.HighVolumeBins = new bool[Bins];
            if (count == 0) return report;

            double minPrice = LowestLow(series, 0, count - 1);
            double maxPrice = HighestHigh(series, 0, count - 1);
            if (maxPrice <= minPrice) return report;
            double binSize = (maxPrice - minPrice) / Bins;
            report.MinPrice = minPrice;
            report.BinSize = binSize;

            // Each bar's volume is spread evenly across the bins its high-low range covers.
            double[] binVolume = new double[Bins];
            for (int i = 0; i < count; i++)
            {
                int first = BinOf(series.Low[i], minPrice, binSize);
                int last = BinOf(series.High[i], minPrice, binSize);
                double share = series.Volume[i] / (last - first + 1);
                for (int bin = first; bin <= last; bin++) binVolume[bin] += share;
            }
            double average = 0;
            for (int bin = 0; bin < Bins; bin++) average += binVolume[bin] / Bins;
            for (int bin = 0; bin < Bins; bin++)
                report.HighVolumeBins[bin] = binVolume[bin] > 0 && binVolume[bin] >= HighVolumeFactor * average;

            for (int i = AtrPeriod + 1; i + ConfirmBars < count; i++)
            {
                double atr = AverageTrueRange(series, i);
                double prevClose = series.Close[i - 1];
                double close = series.Close[i];
                int bestBin = -1;
                bool bestBearish = false;
                double bestVolume = 0;
                for (int bin = 0; bin < Bins; bin++)
                {
                    if (!report.HighVolumeBins[bin]) continue;
                    double zoneLow = minPrice + bin * binSize;
                    double zoneHigh = zoneLow + binSize;
                    // First touch only: the prior bar must not have reached the zone, so chop inside a zone is not marked.
                    bool bearish = prevClose < zoneLow && series.High[i - 1] < zoneLow &&
                        series.High[i] >= zoneLow && close <= zoneLow &&
                        LowestLow(series, i + 1, i + ConfirmBars) <= close - ConfirmAtrMultiple * atr;
                    bool bullish = prevClose > zoneHigh && series.Low[i - 1] > zoneHigh &&
                        series.Low[i] <= zoneHigh && close >= zoneHigh &&
                        HighestHigh(series, i + 1, i + ConfirmBars) >= close + ConfirmAtrMultiple * atr;
                    if ((bearish || bullish) && binVolume[bin] > bestVolume)
                    {
                        bestBin = bin;
                        bestBearish = bearish;
                        bestVolume = binVolume[bin];
                    }
                }
                if (bestBin >= 0)
                {
                    VolumeRejection rejection = new VolumeRejection();
                    rejection.Index = i;
                    rejection.Bearish = bestBearish;
                    report.Rejections.Add(rejection);
                }
            }
            return report;
        }

        private static int BinOf(double price, double minPrice, double binSize)
        {
            int bin = (int)Math.Floor((price - minPrice) / binSize);
            return Math.Max(0, Math.Min(Bins - 1, bin));
        }

        private static double AverageTrueRange(TradingViewSeries series, int index)
        {
            double sum = 0;
            for (int k = index - AtrPeriod; k < index; k++)
            {
                double range = series.High[k] - series.Low[k];
                range = Math.Max(range, Math.Abs(series.High[k] - series.Close[k - 1]));
                range = Math.Max(range, Math.Abs(series.Low[k] - series.Close[k - 1]));
                sum += range;
            }
            return sum / AtrPeriod;
        }

        private static double LowestLow(TradingViewSeries series, int first, int last)
        {
            double result = double.MaxValue;
            for (int i = first; i <= last; i++) result = Math.Min(result, series.Low[i]);
            return result;
        }

        private static double HighestHigh(TradingViewSeries series, int first, int last)
        {
            double result = double.MinValue;
            for (int i = first; i <= last; i++) result = Math.Max(result, series.High[i]);
            return result;
        }
    }

    internal sealed class PerpCandle
    {
        public long Time;
        public double Open;
        public double High;
        public double Low;
        public double Close;
        public double Volume;
    }

    // Reads the appearance, workspace and pane values from AMAT's chart-state.json.
    internal sealed class PerpChartSettings
    {
        internal const string AmatStatePath = @"C:\Users\lincy\Desktop\AMAT\chart-state.json";
        private static readonly System.Text.RegularExpressions.Regex PairPattern =
            new System.Text.RegularExpressions.Regex(@"""([A-Za-z0-9_]+)""\s*:\s*(""[^""]*""|-?[0-9.eE+\-]+|true|false|null)");
        private static readonly System.Text.RegularExpressions.Regex HexPattern =
            new System.Text.RegularExpressions.Regex("^#[0-9a-fA-F]{6}$");

        private System.Collections.Generic.Dictionary<string, string> appearance =
            new System.Collections.Generic.Dictionary<string, string>(StringComparer.Ordinal);

        internal string Interval = "15m";
        internal string ChartType = "candles";
        internal double CandleWidth = 8;
        internal int Offset;
        // Negative widths and heights mean the user has not resized that pane, so AMAT's defaults apply.
        internal double VolumeHeight = -1;
        internal double BottomPanePercent = 10;
        internal double SidePanePercent = 20;
        internal double TpoWidth = -1;
        internal double VrvpWidth = -1;
        internal int VrvpRows = 300;

        internal static PerpChartSettings Load(string path)
        {
            try
            {
                return System.IO.File.Exists(path) ? Parse(System.IO.File.ReadAllText(path)) : new PerpChartSettings();
            }
            catch (System.IO.IOException)
            {
                return new PerpChartSettings();
            }
        }

        internal static PerpChartSettings Parse(string json)
        {
            PerpChartSettings result = new PerpChartSettings();
            string theme = "dark";
            string platformTheme;
            if (ReadPairs(json).TryGetValue("platformTheme", out platformTheme)) theme = platformTheme;

            string appearances = FindObject(json, "chartAppearances");
            string themed = appearances == null ? null : FindObject(appearances, theme);
            if (themed != null) result.appearance = ReadPairs(themed);

            string workspace = FindObject(json, "workspace");
            if (workspace != null)
            {
                System.Collections.Generic.Dictionary<string, string> saved = ReadPairs(workspace);
                // Profile colors and flags are stored in the workspace object, so they join the appearance lookup.
                foreach (System.Collections.Generic.KeyValuePair<string, string> pair in saved)
                {
                    if (!result.appearance.ContainsKey(pair.Key)) result.appearance[pair.Key] = pair.Value;
                }
                string text;
                if (saved.TryGetValue("interval", out text)) result.Interval = text;
                if (saved.TryGetValue("chartType", out text)) result.ChartType = text;
                double number;
                if (TryNumber(saved, "candleWidth", out number)) result.CandleWidth = Math.Max(1, Math.Min(72, number));
                if (TryNumber(saved, "offset", out number)) result.Offset = (int)Math.Round(number);
                if (TryNumber(saved, "sidePaneSizePercent", out number)) result.SidePanePercent = Math.Max(0, Math.Min(100, number));
                if (TryNumber(saved, "bottomPaneSizePercent", out number)) result.BottomPanePercent = Math.Max(5, Math.Min(40, number));
                if (TryNumber(saved, "tpoWidth", out number)) result.TpoWidth = Math.Max(72, Math.Min(10000, number));
                if (TryNumber(saved, "vrvpWidth", out number)) result.VrvpWidth = Math.Max(58, Math.Min(10000, number));
                if (TryNumber(saved, "vrvpRows", out number)) result.VrvpRows = (int)Math.Max(100, Math.Min(1000, Math.Round(number)));
                string panes = FindObject(workspace, "paneHeights");
                if (panes != null && TryNumber(ReadPairs(panes), "volume", out number))
                    result.VolumeHeight = Math.Max(56, Math.Min(600, number));
            }
            return result;
        }

        internal Color ColorOf(string key, string fallbackHex)
        {
            string hex;
            if (!appearance.TryGetValue(key, out hex) || !HexPattern.IsMatch(hex)) hex = fallbackHex;
            return Transparent(ParseHex(hex), (int)NumberOr(key + "Opacity", 100));
        }

        // AMAT draws TPO line and bar colours as raw hex, without the opacity setting.
        internal Color RawColorOf(string key, string fallbackHex)
        {
            string hex;
            if (!appearance.TryGetValue(key, out hex) || !HexPattern.IsMatch(hex)) hex = fallbackHex;
            return ParseHex(hex);
        }

        internal bool Flag(string key, bool fallback)
        {
            string raw;
            return appearance.TryGetValue(key, out raw) ? raw == "true" : fallback;
        }

        internal double NumberOr(string key, double fallback)
        {
            double number;
            return TryNumber(appearance, key, out number) ? number : fallback;
        }

        internal string TextOr(string key, string fallback)
        {
            string raw;
            return appearance.TryGetValue(key, out raw) ? raw : fallback;
        }

        internal static Color Transparent(Color color, int percent)
        {
            int alpha = Math.Max(0, Math.Min(100, percent)) * 255 / 100;
            return Color.FromArgb(alpha, color);
        }

        private static Color ParseHex(string hex)
        {
            int value = Convert.ToInt32(hex.Substring(1), 16);
            return Color.FromArgb((value >> 16) & 0xFF, (value >> 8) & 0xFF, value & 0xFF);
        }

        private static bool TryNumber(System.Collections.Generic.Dictionary<string, string> values, string key, out double number)
        {
            string raw;
            number = 0;
            return values.TryGetValue(key, out raw) &&
                double.TryParse(raw, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out number);
        }

        private static System.Collections.Generic.Dictionary<string, string> ReadPairs(string text)
        {
            System.Collections.Generic.Dictionary<string, string> values =
                new System.Collections.Generic.Dictionary<string, string>(StringComparer.Ordinal);
            foreach (System.Text.RegularExpressions.Match match in PairPattern.Matches(text))
            {
                string raw = match.Groups[2].Value;
                if (raw.Length >= 2 && raw[0] == '"') raw = raw.Substring(1, raw.Length - 2);
                values[match.Groups[1].Value] = raw;
            }
            return values;
        }

        // Returns the brace-matched object that follows the first occurrence of the key.
        private static string FindObject(string json, string key)
        {
            int keyAt = json.IndexOf("\"" + key + "\"", StringComparison.Ordinal);
            if (keyAt < 0) return null;
            int open = json.IndexOf('{', keyAt);
            if (open < 0) return null;
            int depth = 0;
            for (int i = open; i < json.Length; i++)
            {
                if (json[i] == '{') depth++;
                else if (json[i] == '}' && --depth == 0) return json.Substring(open, i - open + 1);
            }
            return null;
        }
    }

    // Visible-range volume profile: each candle's volume is spread across the rows its high-low range covers.
    // The displayed candles plus their profile and TPO sources, loaded together by one refresh.
    internal sealed class PerpChartData
    {
        internal System.Collections.Generic.List<PerpCandle> Display;
        internal System.Collections.Generic.List<PerpCandle> Profile;
        internal System.Collections.Generic.List<PerpCandle> Tpo;
        internal string TpoInterval;
    }

    internal sealed class PerpVolumeProfile
    {
        internal double Low;
        internal double Step;
        internal double[] Buy;
        internal double[] Sell;
        internal double[] Total;
        internal double TotalVolume;
        internal int Poc = -1;
        internal int ValueHigh = -1;
        internal int ValueLow = -1;

        internal const double ValueAreaPercent = 0.7;

        internal int Rows { get { return Total.Length; } }

        internal static PerpVolumeProfile Build(System.Collections.Generic.List<PerpCandle> candles, int start, int end, int rows)
        {
            PerpVolumeProfile profile = new PerpVolumeProfile();
            profile.Buy = new double[rows];
            profile.Sell = new double[rows];
            profile.Total = new double[rows];
            if (end <= start) return profile;

            double low = double.MaxValue;
            double high = double.MinValue;
            for (int i = start; i < end; i++)
            {
                low = Math.Min(low, candles[i].Low);
                high = Math.Max(high, candles[i].High);
            }
            if (!(high > low)) high = low + Math.Max(1e-8, low * 0.0005);
            profile.Low = low;
            profile.Step = (high - low) / rows;

            for (int i = start; i < end; i++)
            {
                PerpCandle candle = candles[i];
                if (candle.Volume <= 0) continue;
                if (candle.High <= candle.Low)
                {
                    profile.AddVolume(profile.RowOf(candle.Close), candle.Volume, candle.Close >= candle.Open);
                    continue;
                }
                double span = candle.High - candle.Low;
                int first = profile.RowOf(candle.Low);
                int last = profile.RowOf(candle.High);
                for (int row = first; row <= last; row++)
                {
                    double rowLow = profile.Low + row * profile.Step;
                    double overlap = Math.Min(candle.High, rowLow + profile.Step) - Math.Max(candle.Low, rowLow);
                    if (overlap <= 0) continue;
                    profile.AddVolume(row, candle.Volume * overlap / span, candle.Close >= candle.Open);
                }
            }

            profile.FindValueArea();
            return profile;
        }

        internal double RowLowPrice(int row) { return Low + row * Step; }

        internal double RowHighPrice(int row) { return Low + (row + 1) * Step; }

        private void AddVolume(int row, double volume, bool buying)
        {
            if (buying) Buy[row] += volume;
            else Sell[row] += volume;
            Total[row] += volume;
            TotalVolume += volume;
        }

        private int RowOf(double price)
        {
            int row = (int)Math.Floor((price - Low) / Step);
            return Math.Max(0, Math.Min(Rows - 1, row));
        }

        // Point of control is the largest row. The value area grows from it toward the larger neighbour until 70% of volume is covered.
        private void FindValueArea()
        {
            ComputeValueArea(Total, out Poc, out ValueHigh, out ValueLow);
        }

        internal static void ComputeValueArea(double[] counts, out int poc, out int valueHigh, out int valueLow)
        {
            poc = -1;
            valueHigh = -1;
            valueLow = -1;
            double total = 0;
            foreach (double count in counts) total += count;
            if (total <= 0) return;
            poc = 0;
            for (int row = 1; row < counts.Length; row++)
            {
                if (counts[row] > counts[poc]) poc = row;
            }
            double target = total * ValueAreaPercent;
            double included = counts[poc];
            valueHigh = poc;
            valueLow = poc;
            while (included < target)
            {
                double above = valueHigh + 1 < counts.Length ? counts[valueHigh + 1] : -1;
                double below = valueLow - 1 >= 0 ? counts[valueLow - 1] : -1;
                if (above < 0 && below < 0) break;
                if (above >= below)
                {
                    valueHigh++;
                    included += above;
                }
                else
                {
                    valueLow--;
                    included += below;
                }
            }
        }
    }

    // Time-price-opportunity counts: each source candle adds one count to every row its high-low range touches.
    internal sealed class PerpTpoProfile
    {
        internal double[] Counts;
        internal int Loaded;
        internal long Periods;
        internal double VisibleHigh = double.NegativeInfinity;
        internal double VisibleLow = double.PositiveInfinity;
        internal int Poc = -1;
        internal int ValueHigh = -1;
        internal int ValueLow = -1;

        internal PerpTpoProfile(int rows)
        {
            Counts = new double[rows];
        }

        // firstVisibleMs and lastVisibleMs bound the visible candles; source candles are counted from the aligned first source time up to now.
        internal static PerpTpoProfile Build(System.Collections.Generic.List<PerpCandle> source, long sourceMs,
            long firstVisibleMs, long lastVisibleMs, long nowMs, double min, double max, int rows)
        {
            PerpTpoProfile profile = new PerpTpoProfile(rows);
            if (sourceMs <= 0) return profile;
            long firstAligned = firstVisibleMs / sourceMs * sourceMs;
            long lastTime = Math.Min(lastVisibleMs, nowMs / sourceMs * sourceMs);
            if (lastTime < firstAligned) return profile;
            profile.Periods = (lastTime - firstAligned) / sourceMs + 1;

            double step = max > min ? (max - min) / rows : 1e-9;
            double[] delta = new double[rows + 1];
            for (int i = PerpChartCanvas.FirstIndexAtOrAfter(source, firstAligned); i < source.Count && source[i].Time <= lastTime; i++)
            {
                profile.Loaded++;
                PerpCandle candle = source[i];
                if (candle.High < min || candle.Low > max) continue;
                int first = (int)Math.Max(0, Math.Min(rows - 1, Math.Floor((candle.Low - min) / step)));
                int last = (int)Math.Max(0, Math.Min(rows - 1, Math.Floor((candle.High - min) / step)));
                delta[first]++;
                delta[last + 1]--;
                profile.VisibleHigh = Math.Max(profile.VisibleHigh, candle.High);
                profile.VisibleLow = Math.Min(profile.VisibleLow, candle.Low);
            }
            double running = 0;
            for (int row = 0; row < rows; row++)
            {
                running += delta[row];
                profile.Counts[row] = running;
            }
            PerpVolumeProfile.ComputeValueArea(profile.Counts, out profile.Poc, out profile.ValueHigh, out profile.ValueLow);
            return profile;
        }
    }


    internal sealed class PerpChartCanvas : Panel
    {
        internal const int PriceAxisWidth = 72;
        internal const int TopInset = 16;
        internal const int BottomInset = 31;
        internal const double MinCandleWidth = 1;
        internal const double MaxCandleWidth = 72;
        internal const double DefaultCandleWidth = 8;
        internal static readonly Color BackgroundColor = Color.FromArgb(21, 22, 26);
        private const int MinVolumeHeight = 56;
        private const double WheelZoomFactor = 1.12;
        private const double KeyZoomIn = 1.15;
        private const double KeyZoomOut = 0.85;
        private const int KeyPanCandles = 5;
        private const int MinProfileWidth = 58;
        private const int MinPlotWidth = 120;
        private const int MinTpoWidth = 72;
        private const int TpoInset = 18;
        private const int DrawingToolbarHeight = 34;

        private readonly PerpChartSettings settings;
        private System.Collections.Generic.List<PerpCandle> candles = new System.Collections.Generic.List<PerpCandle>();
        private System.Collections.Generic.List<PerpCandle> sourceCandles = new System.Collections.Generic.List<PerpCandle>();
        private long sourceIntervalMs;
        private System.Collections.Generic.List<PerpCandle> tpoCandles = new System.Collections.Generic.List<PerpCandle>();
        private long tpoIntervalMs;
        private string tpoIntervalName = "";
        private long intervalMs;
        private string message = "Loading BTCUSDT perpetual candles...";
        private string chartType;
        private double candleWidth;
        private int offset;
        private bool hasManualRange;
        private double manualMin;
        private double manualMax;
        private bool hasMouse;
        private Point mousePos;
        private bool panning;
        private int panStartX;
        private int panStartOffset;
        private double wheelRemainder;
        private System.Windows.Forms.Timer countdownTimer;

        internal PerpChartCanvas(PerpChartSettings chartSettings)
        {
            settings = chartSettings;
            chartType = chartSettings.ChartType;
            candleWidth = chartSettings.CandleWidth;
            offset = chartSettings.Offset;
            DoubleBuffered = true;
            ResizeRedraw = true;
            SetStyle(ControlStyles.Selectable, true);
            TabStop = true;
            BackColor = chartSettings.ColorOf("background", "#15161a");
            MouseEnter += delegate { Focus(); };
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += delegate
            {
                if (candles.Count > 0 && settings.Flag("currentPriceVisible", false)) Invalidate();
            };
            countdownTimer.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) countdownTimer.Dispose();
            base.Dispose(disposing);
        }

        internal string ChartType
        {
            get { return chartType; }
            set { chartType = value; Invalidate(); }
        }

        internal void ShowMessage(string text)
        {
            candles = new System.Collections.Generic.List<PerpCandle>();
            message = text;
            Invalidate();
        }

        internal void SetCandles(System.Collections.Generic.List<PerpCandle> values, long newIntervalMs)
        {
            bool intervalChanged = intervalMs != 0 && newIntervalMs != intervalMs;
            candles = values;
            intervalMs = newIntervalMs;
            sourceCandles = new System.Collections.Generic.List<PerpCandle>();
            sourceIntervalMs = 0;
            tpoCandles = new System.Collections.Generic.List<PerpCandle>();
            tpoIntervalMs = 0;
            tpoIntervalName = "";
            if (intervalChanged)
            {
                offset = 0;
                hasManualRange = false;
            }
            ClampOffset();
            Invalidate();
        }

        // Profiles use the finer AMAT source candles; they are set right after SetCandles for the same refresh.
        internal void SetSourceCandles(System.Collections.Generic.List<PerpCandle> values, long newSourceIntervalMs)
        {
            sourceCandles = values;
            sourceIntervalMs = newSourceIntervalMs;
            Invalidate();
        }

        // TPO counts come from AMAT's TPO source candles (30m, or 4h on daily-and-larger views).
        internal void SetTpoCandles(System.Collections.Generic.List<PerpCandle> values, long newTpoIntervalMs, string newTpoIntervalName)
        {
            tpoCandles = values;
            tpoIntervalMs = newTpoIntervalMs;
            tpoIntervalName = newTpoIntervalName;
            Invalidate();
        }

        internal void ResetView()
        {
            candleWidth = DefaultCandleWidth;
            offset = (int)Math.Round(-(PlotRect().Width * 0.25 / StepWidth() - 0.5));
            hasManualRange = false;
            ClampOffset();
            Invalidate();
        }

        private double StepWidth()
        {
            return candleWidth + Math.Max(1, Math.Min(14, candleWidth * 0.5));
        }

        private void SetCandleWidth(double value)
        {
            candleWidth = Math.Max(MinCandleWidth, Math.Min(MaxCandleWidth, value));
        }

        private void ClampOffset()
        {
            if (Width <= PriceAxisWidth + 1) return;
            int maxFuture = (int)Math.Max(0, Math.Floor(PlotRect().Width / StepWidth()) - 1);
            offset = Math.Max(-maxFuture, Math.Min(Math.Max(0, candles.Count - 1), offset));
        }

        // Mirrors AMAT layout(): TPO column, candle plot, VRVP column, then the price axis on the right.
        private sealed class PerpFrame
        {
            internal int TpoLeft;
            internal int Left;
            internal int Right;
            internal int ProfileLeft;
            internal int ProfileRight;
            internal int Top;
            internal int Bottom;
            internal int VolumeTop;
            internal int PriceBottom;
        }

        private PerpFrame Frame()
        {
            int profileRight = AxisLeft();
            double defaultProfile = Math.Max(MinProfileWidth, Width * settings.SidePanePercent / 100.0);
            double defaultTpo = Math.Max(MinTpoWidth, defaultProfile);
            double maxTpo = Math.Max(MinTpoWidth, profileRight - TpoInset - MinProfileWidth - MinPlotWidth);
            double tpo = Math.Max(MinTpoWidth, Math.Min(settings.TpoWidth >= 0 ? settings.TpoWidth : defaultTpo, maxTpo));
            int left = TpoInset + (int)Math.Round(tpo);
            double maxProfile = Math.Max(MinProfileWidth, profileRight - left - MinPlotWidth);
            double profile = Math.Max(MinProfileWidth, Math.Min(maxProfile, settings.VrvpWidth >= 0 ? settings.VrvpWidth : defaultProfile));
            int profileLeft = profileRight - (int)Math.Round(profile);
            int top = TopInset;
            int bottom = Math.Max(top + 1, Height - BottomInset);
            double span = bottom - top;
            double defaultPane = Math.Max(MinVolumeHeight, span * settings.BottomPanePercent / 100.0);
            double maxPane = Math.Max(MinVolumeHeight, span * 0.45);
            double requested = settings.VolumeHeight >= 0 ? settings.VolumeHeight : defaultPane;
            int paneHeight = (int)Math.Round(Math.Max(MinVolumeHeight, Math.Min(requested, maxPane)));
            int volumeTop = bottom - paneHeight;
            return new PerpFrame
            {
                TpoLeft = TpoInset,
                Left = left,
                Right = Math.Max(left + MinPlotWidth, profileLeft),
                ProfileLeft = profileLeft,
                ProfileRight = profileRight,
                Top = top,
                Bottom = bottom,
                VolumeTop = volumeTop,
                PriceBottom = volumeTop - DrawingToolbarHeight
            };
        }

        // The candle plot spans the full height down to the time axis; the volume pane sits at its bottom.
        private Rectangle PlotRect()
        {
            PerpFrame frame = Frame();
            return new Rectangle(frame.Left, frame.Top, Math.Max(1, frame.Right - frame.Left), Math.Max(1, frame.Bottom - frame.Top));
        }

        private int AxisLeft()
        {
            return Math.Max(1, Width - PriceAxisWidth);
        }

        private int VolumeHeight()
        {
            PerpFrame frame = Frame();
            return frame.Bottom - frame.VolumeTop;
        }

        private Rectangle VolumeRect(Rectangle plot)
        {
            int height = VolumeHeight();
            return new Rectangle(plot.Left, plot.Bottom - height, plot.Width, height);
        }

        private Rectangle PriceRect(Rectangle plot)
        {
            return new Rectangle(plot.Left, plot.Top, plot.Width, Math.Max(1, plot.Height - VolumeHeight() - DrawingToolbarHeight));
        }

        private void VisibleWindow(Rectangle plot, out int start, out int end, out int futureGap)
        {
            end = candles.Count - Math.Max(0, offset);
            futureGap = Math.Max(0, -offset);
            int count = (int)Math.Ceiling(plot.Width / StepWidth());
            start = Math.Max(0, end - Math.Max(0, count - futureGap));
        }

        private static double CandleX(Rectangle plot, double step, int end, int futureGap, int index)
        {
            return plot.Right - step / 2.0 - (futureGap + end - 1 - index) * step;
        }

        private int IndexAt(Rectangle plot, double x)
        {
            double step = StepWidth();
            int start, end, futureGap;
            VisibleWindow(plot, out start, out end, out futureGap);
            return (int)Math.Round((x - (plot.Right - step / 2.0)) / step) + end - 1 + futureGap;
        }

        private void PriceBounds(int start, int end, out double min, out double max)
        {
            if (hasManualRange)
            {
                min = manualMin;
                max = manualMax;
                return;
            }
            double low = double.MaxValue;
            double high = double.MinValue;
            for (int i = start; i < end; i++)
            {
                low = Math.Min(low, candles[i].Low);
                high = Math.Max(high, candles[i].High);
            }
            if (low > high)
            {
                low = candles[candles.Count - 1].Low;
                high = candles[candles.Count - 1].High;
            }
            double spread = Math.Max(high - low, Math.Max(high * 0.0005, 1));
            double mid = (high + low) / 2.0;
            double pad = spread * 0.075;
            min = mid - spread / 2.0 - pad;
            max = mid + spread / 2.0 + pad;
        }

        private static double PriceY(Rectangle priceArea, double min, double max, double price)
        {
            return priceArea.Top + (max - price) / (max - min) * priceArea.Height;
        }

        private Font TextFont(string key, float fallback)
        {
            return new Font(Font.FontFamily, (float)settings.NumberOr(key, fallback), FontStyle.Regular, GraphicsUnit.Point);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            Keys key = keyData & Keys.KeyCode;
            if (key == Keys.Left || key == Keys.Right) return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (candles.Count == 0) return;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    offset += KeyPanCandles;
                    break;
                case Keys.Right:
                    offset -= KeyPanCandles;
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    SetCandleWidth(candleWidth * KeyZoomIn);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    SetCandleWidth(candleWidth * KeyZoomOut);
                    break;
                case Keys.Escape:
                    ResetView();
                    e.Handled = true;
                    return;
                default:
                    return;
            }
            ClampOffset();
            e.Handled = true;
            Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (candles.Count == 0) return;
            Rectangle plot = PlotRect();
            if (e.X >= AxisLeft())
            {
                ScalePrice(Math.Exp(-e.Delta * 0.001));
            }
            else if (e.Y >= plot.Bottom)
            {
                wheelRemainder += -e.Delta / 120.0;
                int shift = (int)Math.Truncate(wheelRemainder);
                wheelRemainder -= shift;
                if (shift != 0)
                {
                    offset += shift;
                    ClampOffset();
                    Invalidate();
                }
            }
            else if (e.X >= plot.Left && e.X < plot.Right)
            {
                ZoomAt(e.X, e.Delta > 0 ? WheelZoomFactor : 1 / WheelZoomFactor);
            }
        }

        private void ZoomAt(int x, double factor)
        {
            Rectangle plot = PlotRect();
            int indexAtPointer = IndexAt(plot, x);
            SetCandleWidth(candleWidth * factor);
            double newRightIndex = indexAtPointer + (plot.Right - x) / StepWidth();
            offset = (int)Math.Round(candles.Count - 1 - newRightIndex);
            ClampOffset();
            Invalidate();
        }

        private void ScalePrice(double factor)
        {
            int start, end, futureGap;
            VisibleWindow(PlotRect(), out start, out end, out futureGap);
            double min, max;
            PriceBounds(start, end, out min, out max);
            double mid = (min + max) / 2.0;
            double half = (max - min) / 2.0 * factor;
            manualMin = mid - half;
            manualMax = mid + half;
            hasManualRange = true;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
            if (e.Button != MouseButtons.Left || candles.Count == 0) return;
            if (!PlotRect().Contains(e.Location)) return;
            panning = true;
            panStartX = e.X;
            panStartOffset = offset;
            Capture = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            panning = false;
            Capture = false;
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            Rectangle plot = PlotRect();
            if (e.X >= AxisLeft())
            {
                hasManualRange = false;
                Invalidate();
            }
            else if (e.Y >= plot.Bottom)
            {
                ResetView();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hasMouse = false;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            hasMouse = true;
            mousePos = e.Location;
            if (panning)
            {
                offset = panStartOffset + (int)Math.Round((e.X - panStartX) / StepWidth());
                ClampOffset();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            if (candles.Count == 0)
            {
                DrawCentered(g, message);
                return;
            }

            Rectangle plot = PlotRect();
            Rectangle priceArea = PriceRect(plot);
            Rectangle volumeArea = VolumeRect(plot);
            double step = StepWidth();
            int start, end, futureGap;
            VisibleWindow(plot, out start, out end, out futureGap);
            double min, max;
            PriceBounds(start, end, out min, out max);
            double maxVolume = 1;
            for (int i = start; i < end; i++) maxVolume = Math.Max(maxVolume, candles[i].Volume);

            DrawGrid(g, plot, priceArea, step, end, futureGap, min, max);
            DrawSeries(g, plot, priceArea, step, start, end, futureGap, min, max);
            DrawVolumeProfile(g, plot, priceArea, start, end, min, max);
            DrawTpoProfile(g, plot, priceArea, volumeArea, start, end, min, max);
            DrawVolume(g, plot, volumeArea, step, start, end, futureGap, maxVolume);
            DrawSeparators(g, plot, volumeArea);
            DrawCurrentPrice(g, plot, priceArea, min, max);
            DrawCrosshair(g, plot, priceArea, step, start, end, futureGap, min, max);
        }

        private void DrawGrid(Graphics g, Rectangle plot, Rectangle priceArea, double step, int end, int futureGap, double min, double max)
        {
            bool horizontal = settings.Flag("horizontalGrid", false);
            bool vertical = settings.Flag("verticalGrid", false);
            using (Font priceFont = TextFont("priceTextSize", 10))
            using (Font timeFont = TextFont("timeTextSize", 10))
            using (Brush priceText = new SolidBrush(settings.ColorOf("priceTextColor", "#666666")))
            using (Brush timeText = new SolidBrush(settings.ColorOf("timeTextColor", "#666666")))
            using (Pen horizontalPen = new Pen(settings.ColorOf("horizontalGridColor", "#24262c")))
            using (Pen verticalPen = new Pen(settings.ColorOf("verticalGridColor", "#202228")))
            {
                double raw = (max - min) / 6.0;
                double magnitude = Math.Pow(10, Math.Floor(Math.Log10(raw)));
                double tick = magnitude;
                foreach (double factor in new double[] { 1, 2, 2.5, 5, 10 })
                {
                    if (factor * magnitude >= raw) { tick = factor * magnitude; break; }
                }
                for (double price = Math.Ceiling(min / tick) * tick; price <= max; price += tick)
                {
                    float y = (float)PriceY(priceArea, min, max, price);
                    if (horizontal) g.DrawLine(horizontalPen, plot.Left, y, plot.Right, y);
                    g.DrawString(price.ToString(tick < 1 ? "F4" : (tick < 10 ? "F2" : "F0")), priceFont, priceText, AxisLeft() + 4, y - 7);
                }

                int labelEvery = Math.Max(1, (int)Math.Ceiling(90.0 / step));
                for (int i = end - 1; i >= 0; i--)
                {
                    float x = (float)CandleX(plot, step, end, futureGap, i);
                    if (x < plot.Left) break;
                    if (i % labelEvery != 0) continue;
                    if (vertical) g.DrawLine(verticalPen, x, priceArea.Top, x, plot.Bottom);
                    DrawTimeLabel(g, timeFont, timeText, plot, x, candles[i].Time);
                }
                for (int futureIndex = 1; futureIndex <= futureGap; futureIndex++)
                {
                    int index = candles.Count - 1 + futureIndex;
                    if (index % labelEvery != 0) continue;
                    float x = (float)CandleX(plot, step, candles.Count, futureGap, index);
                    if (x < plot.Left || x > plot.Right) continue;
                    if (vertical) g.DrawLine(verticalPen, x, priceArea.Top, x, plot.Bottom);
                    DrawTimeLabel(g, timeFont, timeText, plot, x, candles[candles.Count - 1].Time + futureIndex * intervalMs);
                }
            }
        }

        private void DrawTimeLabel(Graphics g, Font font, Brush brush, Rectangle plot, float x, long time)
        {
            DateTime when = DateTimeOffset.FromUnixTimeMilliseconds(time).ToLocalTime().DateTime;
            string label = intervalMs >= 86400000L ? when.ToString("MM-dd") : when.ToString("HH:mm");
            SizeF size = g.MeasureString(label, font);
            g.DrawString(label, font, brush, x - size.Width / 2f, plot.Bottom + 4);
        }

        private void DrawSeparators(Graphics g, Rectangle plot, Rectangle volumeArea)
        {
            int axisLeft = AxisLeft();
            if (settings.Flag("paneSeparators", true))
            {
                using (Pen pen = new Pen(settings.ColorOf("paneSeparatorColor", "#4d4d4d")))
                {
                    g.DrawLine(pen, plot.Left, volumeArea.Top, axisLeft, volumeArea.Top);
                }
            }
            if (settings.Flag("axisBorders", true))
            {
                using (Pen pen = new Pen(settings.ColorOf("axisBorderColor", "#4d4d4d")))
                {
                    g.DrawLine(pen, axisLeft, 0, axisLeft, Height);
                    g.DrawLine(pen, 0, plot.Bottom, axisLeft, plot.Bottom);
                }
            }
        }

        private void DrawSeries(Graphics g, Rectangle plot, Rectangle priceArea, double step, int start, int end, int futureGap, double min, double max)
        {
            g.SetClip(new Rectangle(plot.Left, priceArea.Top, plot.Width, priceArea.Height));
            if (chartType == "line")
            {
                DrawLineSeries(g, plot, priceArea, step, start, end, futureGap, min, max);
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    float x = (float)CandleX(plot, step, end, futureGap, i);
                    if (chartType == "smart" && candleWidth <= 1) DrawSmartBar(g, candles[i], x, priceArea, min, max);
                    else DrawCandle(g, candles[i], x, priceArea, min, max);
                }
            }
            g.ResetClip();
        }

        private void DrawCandle(Graphics g, PerpCandle candle, float x, Rectangle priceArea, double min, double max)
        {
            bool rising = candle.Close >= candle.Open;
            bool single = settings.Flag("candleSingleColor", false);
            string bodyKey = rising ? "upBodyColor" : "downBodyColor";
            string wickKey = single ? bodyKey : (rising ? "upWickColor" : "downWickColor");
            string borderKey = single ? bodyKey : (rising ? "upBorderColor" : "downBorderColor");
            string fallback = rising ? "#20b987" : "#ef5967";

            float high = (float)PriceY(priceArea, min, max, candle.High);
            float low = (float)PriceY(priceArea, min, max, candle.Low);
            float open = (float)PriceY(priceArea, min, max, candle.Open);
            float close = (float)PriceY(priceArea, min, max, candle.Close);
            float bodyWidth = (float)Math.Max(1, candleWidth);
            float bodyTop = Math.Min(open, close);
            float bodyHeight = Math.Max(1f, Math.Abs(close - open));

            using (Pen wickPen = new Pen(settings.ColorOf(wickKey, fallback)))
            using (Brush body = new SolidBrush(settings.ColorOf(bodyKey, fallback)))
            {
                g.DrawLine(wickPen, x, high, x, low);
                g.FillRectangle(body, x - bodyWidth / 2f, bodyTop, bodyWidth, bodyHeight);
                if (bodyWidth > 1)
                {
                    using (Pen borderPen = new Pen(settings.ColorOf(borderKey, fallback)))
                    {
                        g.DrawRectangle(borderPen, x - bodyWidth / 2f + 0.5f, bodyTop + 0.5f, bodyWidth - 1, Math.Max(0, bodyHeight - 1));
                    }
                }
            }
        }

        private void DrawSmartBar(Graphics g, PerpCandle candle, float x, Rectangle priceArea, double min, double max)
        {
            bool rising = candle.Close >= candle.Open;
            string key;
            string fallback = rising ? "#20b987" : "#ef5967";
            if (settings.Flag("smartBarSingleColor", false))
            {
                key = "smartBarColor";
                fallback = "#c5cad3";
            }
            else if (settings.Flag("candleSingleColor", false))
            {
                key = rising ? "upBodyColor" : "downBodyColor";
            }
            else
            {
                key = rising ? "upWickColor" : "downWickColor";
            }
            float tick = (float)Math.Max(1, settings.NumberOr("ohlcBarTickWidth", 2));
            float high = (float)PriceY(priceArea, min, max, candle.High);
            float low = (float)PriceY(priceArea, min, max, candle.Low);
            float open = (float)PriceY(priceArea, min, max, candle.Open);
            float close = (float)PriceY(priceArea, min, max, candle.Close);
            using (Pen pen = new Pen(settings.ColorOf(key, fallback)))
            {
                g.DrawLine(pen, x, high, x, low);
                g.DrawLine(pen, x - tick, open, x, open);
                g.DrawLine(pen, x, close, x + tick, close);
            }
        }

        private void DrawLineSeries(Graphics g, Rectangle plot, Rectangle priceArea, double step, int start, int end, int futureGap, double min, double max)
        {
            int count = end - start;
            if (count < 2) return;
            PointF[] points = new PointF[count];
            for (int k = 0; k < count; k++)
            {
                int i = start + k;
                points[k] = new PointF((float)CandleX(plot, step, end, futureGap, i), (float)PriceY(priceArea, min, max, candles[i].Close));
            }

            PointF[] area = new PointF[count + 2];
            Array.Copy(points, area, count);
            area[count] = new PointF(points[count - 1].X, priceArea.Bottom);
            area[count + 1] = new PointF(points[0].X, priceArea.Bottom);
            Color fillTop = PerpChartSettings.Transparent(settings.ColorOf("lineFillColor", "#738fff"), (int)settings.NumberOr("lineFillOpacity", 18));
            Color fillBottom = Color.FromArgb(0, fillTop);
            using (System.Drawing.Drawing2D.LinearGradientBrush fill = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Point(0, priceArea.Top), new Point(0, priceArea.Bottom), fillTop, fillBottom))
            {
                g.FillPolygon(fill, area);
            }
            using (Pen pen = new Pen(settings.ColorOf("lineColor", "#829cff"), 1.7f))
            {
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                g.DrawLines(pen, points);
            }
        }

        private void DrawVolumeProfile(Graphics g, Rectangle plot, Rectangle priceArea, int start, int end, double min, double max)
        {
            PerpFrame frame = Frame();
            int width = frame.ProfileRight - frame.ProfileLeft;
            if (width <= 0) return;
            Rectangle area = new Rectangle(frame.ProfileLeft, priceArea.Top, width, priceArea.Height);
            PerpVolumeProfile profile = BuildVisibleProfile(start, end);
            if (profile.TotalVolume <= 0) return;

            double rowMax = 0;
            for (int row = 0; row < profile.Rows; row++) rowMax = Math.Max(rowMax, profile.Total[row]);
            bool matchCandles = settings.Flag("vrvpMatchCandleColors", true);
            Color buyColor = matchCandles
                ? PerpChartSettings.Transparent(settings.ColorOf("upBodyColor", "#20b987"), 72)
                : settings.ColorOf("vrvpBuyColor", "#20b987");
            Color sellColor = matchCandles
                ? PerpChartSettings.Transparent(settings.ColorOf("downBodyColor", "#ef5967"), 72)
                : settings.ColorOf("vrvpSellColor", "#ef5967");

            g.SetClip(area);
            float barRight = area.Right - 4f;
            float maxBar = area.Width - 8f;
            using (Brush buyBrush = new SolidBrush(buyColor))
            using (Brush sellBrush = new SolidBrush(sellColor))
            {
                for (int row = 0; row < profile.Rows; row++)
                {
                    if (profile.Total[row] <= 0) continue;
                    float top = (float)PriceY(priceArea, min, max, profile.RowHighPrice(row));
                    float bottom = (float)PriceY(priceArea, min, max, profile.RowLowPrice(row));
                    float height = Math.Max(1f, bottom - top - 1f);
                    float sellWidth = (float)(profile.Sell[row] / rowMax * maxBar);
                    float buyWidth = (float)(profile.Buy[row] / rowMax * maxBar);
                    if (sellWidth > 0) g.FillRectangle(sellBrush, barRight - sellWidth, top, sellWidth, height);
                    if (buyWidth > 0) g.FillRectangle(buyBrush, barRight - buyWidth, top, buyWidth, height);
                }
            }

            float levelLeft = settings.Flag("vrvpLevelsExtendIntoChart", false) ? plot.Left : area.Left;
            if (profile.Poc >= 0)
            {
                double pocPrice = (profile.RowLowPrice(profile.Poc) + profile.RowHighPrice(profile.Poc)) / 2.0;
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, pocPrice), levelLeft, area.Right,
                    settings.ColorOf("vrvpPocColor", "#cccccc"), settings.TextOr("vrvpPocStyle", "solid"));
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, profile.RowHighPrice(profile.ValueHigh)), levelLeft, area.Right,
                    settings.ColorOf("vrvpVahColor", "#cccccc"), settings.TextOr("vrvpVahStyle", "dotted"));
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, profile.RowLowPrice(profile.ValueLow)), levelLeft, area.Right,
                    settings.ColorOf("vrvpValColor", "#cccccc"), settings.TextOr("vrvpValStyle", "dotted"));
            }
            g.ResetClip();
        }

        // Mirrors AMAT's TPO layer: a count bar per price row, POC/VAH/VAL levels, and stats in the volume pane.
        private void DrawTpoProfile(Graphics g, Rectangle plot, Rectangle priceArea, Rectangle volumeArea, int start, int end, double min, double max)
        {
            PerpFrame frame = Frame();
            int tpoLeft = frame.TpoLeft;
            int tpoRight = frame.Left;
            int paneWidth = tpoRight - tpoLeft;
            if (paneWidth <= 0 || end <= start) return;

            long nowMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            int rows = settings.VrvpRows;
            PerpTpoProfile tpo = PerpTpoProfile.Build(tpoCandles, tpoIntervalMs, candles[start].Time,
                candles[end - 1].Time + intervalMs - 1, nowMs, min, max, rows);
            double step = (max - min) / rows;
            double rowHeight = (frame.PriceBottom - plot.Top) / (double)rows;

            using (Brush background = new SolidBrush(PerpChartSettings.Transparent(BackgroundColor, 96)))
            {
                g.FillRectangle(background, tpoLeft, plot.Top, paneWidth, frame.Bottom - plot.Top);
            }

            double maxCount = 0;
            foreach (double count in tpo.Counts) maxCount = Math.Max(maxCount, count);
            if (maxCount > 0)
            {
                Color rowColor = settings.RawColorOf("tpoRowColor", "#829cff");
                float barMax = Math.Max(1, paneWidth - 10);
                float height = (float)Math.Max(0.5, rowHeight - 0.5);
                for (int row = 0; row < rows; row++)
                {
                    double count = tpo.Counts[row];
                    if (count <= 0) continue;
                    float width = (float)(barMax * count / maxCount);
                    float y = (float)(frame.PriceBottom - (row + 1) * rowHeight);
                    int alpha = (int)Math.Round((0.35 + 0.65 * count / maxCount) * 255);
                    using (Brush brush = new SolidBrush(Color.FromArgb(alpha, rowColor)))
                    {
                        g.FillRectangle(brush, tpoLeft + 5, y, width, height);
                    }
                }
            }

            if (tpo.Poc >= 0)
            {
                int levelEnd = settings.Flag("tpoLevelsExtendIntoChart", false) ? plot.Right : tpoRight;
                g.SetClip(new Rectangle(tpoLeft, plot.Top, levelEnd - tpoLeft, Math.Max(1, frame.PriceBottom - plot.Top)));
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, min + (tpo.Poc + 0.5) * step), tpoLeft, levelEnd,
                    settings.RawColorOf("tpoPocColor", "#f0b90b"), settings.TextOr("tpoPocStyle", "solid"));
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, min + (tpo.ValueHigh + 1) * step), tpoLeft, levelEnd,
                    settings.RawColorOf("tpoVahColor", "#829cff"), settings.TextOr("tpoVahStyle", "dashed"));
                DrawProfileLevel(g, (float)PriceY(priceArea, min, max, min + tpo.ValueLow * step), tpoLeft, levelEnd,
                    settings.RawColorOf("tpoValColor", "#829cff"), settings.TextOr("tpoValStyle", "dashed"));
                g.ResetClip();
            }

            using (Brush background = new SolidBrush(PerpChartSettings.Transparent(BackgroundColor, 96)))
            {
                g.FillRectangle(background, tpoLeft, volumeArea.Top, paneWidth, volumeArea.Height);
            }
            bool compact = paneWidth < 100;
            int statsTop = volumeArea.Top + 4;
            double coveredHours = tpo.Loaded * (double)tpoIntervalMs / 3600000.0;
            string coveredTime = tpo.Loaded == 0 ? "\u2014"
                : coveredHours >= 24
                    ? (coveredHours / 24).ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "d"
                    : coveredHours.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "h";
            string coverage = tpo.Loaded + "/" + tpo.Periods + (compact ? "" : " " + tpoIntervalName);
            string range = double.IsInfinity(tpo.VisibleHigh) || double.IsInfinity(tpo.VisibleLow)
                ? "\u2014" : FormatCompact(tpo.VisibleHigh - tpo.VisibleLow);
            using (Font labelFont = new Font(Font.FontFamily, 7f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (Font valueFont = new Font(Font.FontFamily, 8f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (Brush labelBrush = new SolidBrush(settings.ColorOf("priceMidpointTextColor", "#777b85")))
            using (Brush valueBrush = new SolidBrush(settings.ColorOf("priceTextColor", "#777b85")))
            {
                float left = tpoLeft + 6;
                float right = tpoRight - 6;
                DrawPaneText(g, compact ? "TPO" : "TPO STATS", labelFont, labelBrush, left, right, statsTop, false);
                DrawPaneText(g, "TIME", labelFont, labelBrush, left, right, statsTop + 13, false);
                DrawPaneText(g, "PERIODS", labelFont, labelBrush, left, right, statsTop + 26, false);
                DrawPaneText(g, "RANGE", labelFont, labelBrush, left, right, statsTop + 39, false);
                DrawPaneText(g, coveredTime, valueFont, valueBrush, left, right, statsTop + 12, true);
                DrawPaneText(g, coverage, valueFont, valueBrush, left, right, statsTop + 25, true);
                DrawPaneText(g, range, valueFont, valueBrush, left, right, statsTop + 38, true);
            }
        }

        private static void DrawPaneText(Graphics g, string text, Font font, Brush brush, float left, float right, float y, bool alignRight)
        {
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = alignRight ? StringAlignment.Far : StringAlignment.Near;
                format.FormatFlags |= StringFormatFlags.NoWrap;
                g.DrawString(text, font, brush, new RectangleF(left, y, right - left, 12f), format);
            }
        }

        // Mirrors AMAT's compact number format (en-US, up to 2 fraction digits), e.g. 1234 becomes "1.23K".
        private static string FormatCompact(double value)
        {
            double magnitude = Math.Abs(value);
            string suffix = "";
            double scaled = value;
            if (magnitude >= 1e12) { scaled = value / 1e12; suffix = "T"; }
            else if (magnitude >= 1e9) { scaled = value / 1e9; suffix = "B"; }
            else if (magnitude >= 1e6) { scaled = value / 1e6; suffix = "M"; }
            else if (magnitude >= 1e3) { scaled = value / 1e3; suffix = "K"; }
            double scaledMagnitude = Math.Abs(scaled);
            int decimals = scaledMagnitude < 10 ? 2 : scaledMagnitude < 100 ? 1 : 0;
            return Math.Round(scaled, decimals).ToString("0.##", System.Globalization.CultureInfo.InvariantCulture) + suffix;
        }

        private static void DrawProfileLevel(Graphics g, float y, float x0, float x1, Color color, string style)
        {
            // Dash patterns are in pen-width units, so the 1.25px pen gives 6px dashes and 1px dots.
            using (Pen pen = new Pen(Color.FromArgb(color.A * 92 / 100, color), 1.25f))
            {
                if (style == "dashed") pen.DashPattern = new float[] { 4.8f, 3.2f };
                else if (style == "dotted")
                {
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    pen.DashPattern = new float[] { 0.8f, 2.4f };
                }
                g.DrawLine(pen, x0, y, x1, y);
            }
        }

        // Maps the visible parent candles to their source-interval candles, as AMAT does for profiles.
        private PerpVolumeProfile BuildVisibleProfile(int start, int end)
        {
            if (sourceIntervalMs <= 0 || sourceIntervalMs >= intervalMs || sourceCandles.Count == 0 || end <= start)
                return PerpVolumeProfile.Build(candles, start, end, settings.VrvpRows);
            long fromMs = candles[start].Time;
            long toMs = candles[end - 1].Time + intervalMs;
            return PerpVolumeProfile.Build(sourceCandles,
                FirstIndexAtOrAfter(sourceCandles, fromMs), FirstIndexAtOrAfter(sourceCandles, toMs), settings.VrvpRows);
        }

        internal static int FirstIndexAtOrAfter(System.Collections.Generic.List<PerpCandle> values, long timeMs)
        {
            int low = 0;
            int high = values.Count;
            while (low < high)
            {
                int middle = (low + high) / 2;
                if (values[middle].Time < timeMs) low = middle + 1;
                else high = middle;
            }
            return low;
        }

        private void DrawVolume(Graphics g, Rectangle plot, Rectangle volumeArea, double step, int start, int end, int futureGap, double maxVolume)
        {
            float top = volumeArea.Top + 17f;
            float bottom = volumeArea.Bottom - 5f;
            float span = Math.Max(1f, bottom - top);
            float barWidth = (float)Math.Max(1, Math.Min(Math.Round(candleWidth), Math.Floor(step) - 1));
            bool matchBody = settings.Flag("volumeBodyColors", false) && chartType != "line";
            int opacity = (int)settings.NumberOr("volumeOpacity", 60);

            g.SetClip(new Rectangle(plot.Left, volumeArea.Top, plot.Width, volumeArea.Height));
            for (int i = start; i < end; i++)
            {
                PerpCandle candle = candles[i];
                bool rising = candle.Close >= candle.Open;
                string key = rising
                    ? (matchBody ? "upBodyColor" : "upVolumeColor")
                    : (matchBody ? "downBodyColor" : "downVolumeColor");
                float x = (float)CandleX(plot, step, end, futureGap, i);
                float height = (float)(candle.Volume / maxVolume * span);
                using (Brush brush = new SolidBrush(PerpChartSettings.Transparent(
                    settings.ColorOf(key, rising ? "#20b987" : "#ef5967"), opacity)))
                {
                    g.FillRectangle(brush, x - barWidth / 2f, bottom - height, barWidth, height);
                }
            }
            g.ResetClip();
        }

        private void DrawCurrentPrice(Graphics g, Rectangle plot, Rectangle priceArea, double min, double max)
        {
            if (!settings.Flag("currentPriceVisible", false)) return;
            PerpCandle last = candles[candles.Count - 1];
            float y = (float)PriceY(priceArea, min, max, last.Close);
            if (y < priceArea.Top || y > priceArea.Bottom) return;

            Color lineColor = PerpChartSettings.Transparent(settings.ColorOf("currentPriceColor", "#c94253"), 72);
            using (Pen pen = new Pen(lineColor))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, plot.Left, y, plot.Right, y);
            }

            Color labelColor = settings.Flag("currentPriceLabelDynamic", false)
                ? settings.ColorOf(last.Close >= last.Open ? "upBodyColor" : "downBodyColor", "#20b987")
                : settings.ColorOf("currentPriceLabelColor", "#c94253");
            long remaining = last.Time + intervalMs - DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            DrawAxisLabel(g, new string[] { last.Close.ToString("F2"), FormatCountdown(remaining) },
                labelColor, settings.ColorOf("currentPriceLabelTextColor", "#ffffff"), AxisLeft() + 2, y, 38f);
        }

        private static string FormatCountdown(long remainingMs)
        {
            long total = Math.Max(0, remainingMs) / 1000;
            long hours = total / 3600;
            long minutes = (total % 3600) / 60;
            long seconds = total % 60;
            return hours > 0
                ? string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds)
                : string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        private System.Drawing.Drawing2D.DashStyle CrosshairDashStyle()
        {
            string style = settings.TextOr("crosshairLineStyle", "dotted");
            if (style == "dashed") return System.Drawing.Drawing2D.DashStyle.Dash;
            if (style == "solid") return System.Drawing.Drawing2D.DashStyle.Solid;
            return System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void DrawCrosshair(Graphics g, Rectangle plot, Rectangle priceArea, double step, int start, int end, int futureGap, double min, double max)
        {
            if (!hasMouse || !plot.Contains(mousePos)) return;

            int index = (int)Math.Round((mousePos.X - (plot.Right - step / 2.0)) / step) + end - 1 + futureGap;
            float x = (float)CandleX(plot, step, end, futureGap, index);
            bool onPrice = mousePos.Y <= priceArea.Bottom;
            using (Pen pen = new Pen(settings.ColorOf("crosshairColor", "#8b91a0")))
            {
                pen.DashStyle = CrosshairDashStyle();
                g.DrawLine(pen, x, 0, x, plot.Bottom);
                if (onPrice) g.DrawLine(pen, plot.Left, mousePos.Y, plot.Right, mousePos.Y);
            }

            Color labelBack = settings.ColorOf("crosshairLabelColor", "#4d4d4d");
            Color labelText = settings.ColorOf("crosshairLabelTextColor", "#eff0f4");
            if (onPrice)
            {
                double price = max - (mousePos.Y - priceArea.Top) / (double)priceArea.Height * (max - min);
                DrawAxisLabel(g, new string[] { price.ToString("F2") }, labelBack, labelText, AxisLeft() + 2, mousePos.Y, 0f);
            }
            if (index < start || index >= end) return;

            PerpCandle candle = candles[index];
            DateTime when = DateTimeOffset.FromUnixTimeMilliseconds(candle.Time).ToLocalTime().DateTime;
            using (Font font = TextFont("timeTextSize", 10))
            using (Brush back = new SolidBrush(labelBack))
            using (Brush text = new SolidBrush(labelText))
            {
                string timeLabel = intervalMs >= 86400000L ? when.ToString("yyyy-MM-dd") : when.ToString("HH:mm");
                SizeF size = g.MeasureString(timeLabel, font);
                g.FillRectangle(back, x - size.Width / 2f - 3, plot.Bottom + 2, size.Width + 6, size.Height);
                g.DrawString(timeLabel, font, text, x - size.Width / 2f, plot.Bottom + 2);
            }

            string info = when.ToString("yyyy-MM-dd HH:mm") + "   O " + candle.Open.ToString("F2") +
                "  H " + candle.High.ToString("F2") + "  L " + candle.Low.ToString("F2") +
                "  C " + candle.Close.ToString("F2") + "  V " + candle.Volume.ToString("F2");
            using (Font font = TextFont("priceTextSize", 10))
            using (Brush brush = new SolidBrush(settings.ColorOf("priceTextColor", "#666666")))
            {
                g.DrawString(info, font, brush, plot.Left + 6, plot.Top + 4);
            }
        }

        // Draws a price-axis label box. Multi-line boxes are used for the current price and countdown.
        private void DrawAxisLabel(Graphics g, string[] lines, Color background, Color foreground, float x, float centerY, float fixedHeight)
        {
            using (Font font = TextFont("priceTextSize", 10))
            using (Brush fill = new SolidBrush(background))
            using (Brush text = new SolidBrush(foreground))
            {
                float lineHeight = font.GetHeight(g);
                float height = fixedHeight > 0 ? fixedHeight : lines.Length * lineHeight + 6f;
                RectangleF box = new RectangleF(x, centerY - height / 2f, PriceAxisWidth - 4, height);
                g.FillRectangle(fill, box);
                float lineY = box.Y + 3f;
                foreach (string line in lines)
                {
                    g.DrawString(line, font, text, box.X + 3f, lineY);
                    lineY += lineHeight;
                }
            }
        }

        private void DrawCentered(Graphics g, string text)
        {
            using (Brush brush = new SolidBrush(settings.ColorOf("priceTextColor", "#666666")))
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                g.DrawString(text, Font, brush, new RectangleF(0, 0, Width, Height), format);
            }
        }
    }

    internal sealed class TradingViewChartCanvas : Panel
    {
        internal static readonly Color BackgroundColor = Color.FromArgb(19, 23, 34);
        internal static readonly Color GridColor = Color.FromArgb(40, 46, 60);
        internal static readonly Color AxisColor = Color.Silver;
        internal static readonly Color UpColor = Color.FromArgb(38, 166, 154);
        internal static readonly Color DownColor = Color.FromArgb(239, 83, 80);
        internal static readonly Color ZoneColor = Color.FromArgb(45, 98, 255);
        internal static readonly Color BearishColor = Color.FromArgb(235, 60, 60);
        internal static readonly Color BullishColor = Color.FromArgb(40, 200, 90);
        internal const int BubbleSize = 28;
        private TradingViewSeries series;
        private VolumeRejectionReport report;
        private string message = "Loading BTCUSDT chart...";

        internal TradingViewChartCanvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = BackgroundColor;
        }

        internal void ShowMessage(string text)
        {
            series = null;
            report = null;
            message = text;
            Invalidate();
        }

        internal void SetSeries(TradingViewSeries values, VolumeRejectionReport rejections)
        {
            series = values;
            report = rejections;
            message = string.Empty;
            Invalidate();
        }

        private static float PriceToY(double price, double low, double high, Rectangle pane)
        {
            return (float)(pane.Bottom - (price - low) / (high - low) * pane.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(BackgroundColor);
            if (series == null || series.Close.Length == 0)
            {
                TextRenderer.DrawText(g, message, Font, ClientRectangle, AxisColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
                return;
            }

            int headerHeight = Font.Height + 8;
            int timeHeight = Font.Height + 8;
            int axisWidth = 72;
            Rectangle plot = new Rectangle(6, headerHeight, Width - axisWidth - 12, Height - headerHeight - timeHeight);
            if (plot.Width < 120 || plot.Height < 120) return;
            int volumeHeight = plot.Height / 5;
            Rectangle pricePane = new Rectangle(plot.X, plot.Y, plot.Width, plot.Height - volumeHeight - 6);
            Rectangle volumePane = new Rectangle(plot.X, pricePane.Bottom + 6, plot.Width, volumeHeight);

            int count = series.Close.Length;
            double low = double.MaxValue;
            double high = double.MinValue;
            double maxVolume = 0;
            for (int i = 0; i < count; i++)
            {
                low = Math.Min(low, series.Low[i]);
                high = Math.Max(high, series.High[i]);
                maxVolume = Math.Max(maxVolume, series.Volume[i]);
            }
            if (maxVolume <= 0) maxVolume = 1;
            double padding = (high - low) * 0.02;
            low -= padding;
            high += padding;
            double barWidth = pricePane.Width / (double)count;
            float bodyWidth = (float)Math.Max(1.0, barWidth * 0.7);

            using (Pen grid = new Pen(GridColor))
            using (Brush axisBrush = new SolidBrush(AxisColor))
            {
                for (int line = 0; line <= 4; line++)
                {
                    double price = low + (high - low) * line / 4.0;
                    float y = PriceToY(price, low, high, pricePane);
                    g.DrawLine(grid, pricePane.X, y, pricePane.Right, y);
                    g.DrawString(price.ToString("N2", System.Globalization.CultureInfo.InvariantCulture), Font, axisBrush,
                        pricePane.Right + 4, y - Font.Height / 2f);
                }
            }

            if (report != null)
            {
                using (Brush zone = new SolidBrush(Color.FromArgb(40, ZoneColor)))
                {
                    for (int bin = 0; bin < report.HighVolumeBins.Length; bin++)
                    {
                        if (!report.HighVolumeBins[bin]) continue;
                        float top = PriceToY(report.MinPrice + (bin + 1) * report.BinSize, low, high, pricePane);
                        float bottom = PriceToY(report.MinPrice + bin * report.BinSize, low, high, pricePane);
                        g.FillRectangle(zone, pricePane.X, top, pricePane.Width, Math.Max(1f, bottom - top));
                    }
                }
            }

            using (Pen upPen = new Pen(UpColor))
            using (Pen downPen = new Pen(DownColor))
            using (Brush upBrush = new SolidBrush(UpColor))
            using (Brush downBrush = new SolidBrush(DownColor))
            using (Brush upVolume = new SolidBrush(Color.FromArgb(120, UpColor)))
            using (Brush downVolume = new SolidBrush(Color.FromArgb(120, DownColor)))
            {
                for (int i = 0; i < count; i++)
                {
                    bool up = series.Close[i] >= series.Open[i];
                    float x = (float)(pricePane.X + (i + 0.5) * barWidth);
                    g.DrawLine(up ? upPen : downPen, x, PriceToY(series.High[i], low, high, pricePane),
                        x, PriceToY(series.Low[i], low, high, pricePane));
                    float openY = PriceToY(series.Open[i], low, high, pricePane);
                    float closeY = PriceToY(series.Close[i], low, high, pricePane);
                    g.FillRectangle(up ? upBrush : downBrush, x - bodyWidth / 2, Math.Min(openY, closeY),
                        bodyWidth, Math.Max(1f, Math.Abs(openY - closeY)));
                    float barVolume = (float)(series.Volume[i] / maxVolume * volumePane.Height);
                    g.FillRectangle(up ? upVolume : downVolume, x - bodyWidth / 2, volumePane.Bottom - barVolume,
                        bodyWidth, barVolume);
                }
            }

            int bearishCount = 0;
            int bullishCount = 0;
            if (report != null)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                foreach (VolumeRejection rejection in report.Rejections)
                {
                    if (rejection.Bearish) bearishCount++; else bullishCount++;
                    Color color = rejection.Bearish ? BearishColor : BullishColor;
                    float x = (float)(pricePane.X + (rejection.Index + 0.5) * barWidth);
                    float y = PriceToY(rejection.Bearish ? series.High[rejection.Index] : series.Low[rejection.Index],
                        low, high, pricePane);
                    RectangleF bubble = new RectangleF(x - BubbleSize / 2f, y - BubbleSize / 2f, BubbleSize, BubbleSize);
                    using (Brush fill = new SolidBrush(Color.FromArgb(90, color)))
                    using (Pen ring = new Pen(color, 2f))
                    {
                        g.FillEllipse(fill, bubble);
                        g.DrawEllipse(ring, bubble);
                    }
                }
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }

            using (Brush axisBrush = new SolidBrush(AxisColor))
            {
                for (int k = 0; k <= 4; k++)
                {
                    int index = (count - 1) * k / 4;
                    long ms = series.StartMs + index * series.IntervalMs;
                    string text = DateTimeOffset.FromUnixTimeMilliseconds(ms).UtcDateTime.ToString("dd MMM HH:mm",
                        System.Globalization.CultureInfo.InvariantCulture);
                    SizeF size = g.MeasureString(text, Font);
                    float x = (float)(pricePane.X + (index + 0.5) * barWidth - size.Width / 2);
                    x = Math.Max(plot.X, Math.Min(x, plot.Right - size.Width));
                    g.DrawString(text, Font, axisBrush, x, volumePane.Bottom + 4);
                }
            }

            string header = "BTCUSDT futures " + (series.IntervalMs / 60000).ToString(System.Globalization.CultureInfo.InvariantCulture) +
                "m | UTC | Red: bearish rejection " + bearishCount.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                " | Green: bullish rejection " + bullishCount.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                " | Blue bands: high-volume prices | Hindsight: marked only after follow-through";
            TextRenderer.DrawText(g, header, Font, new Point(6, 4), AxisColor, TextFormatFlags.NoPadding);
        }
    }

    internal sealed class MarketDeskTile : Panel
    {
        private static MarketDeskTile selectedTile;
        private bool selected;
        private bool dragging;
        private Point grabOffset;
        private int resizeEdges;
        private Rectangle resizeStartBounds;
        private Point resizeStartMouse;
        // Shows the tile's size in grid cells while it is being resized. Created on first use, in the workspace.
        private Label resizeSizeLabel;
        private readonly Panel body;
        private Panel titlePanel;
        private bool fullScreen;
        private Rectangle normalBounds;
        // Number of jobs running in this tile. The loading bar shows while it is above zero.
        private int busyCount;
        // Share of the current job that is done, from 0 to 1.
        private double loadingProgress;
        private readonly System.Windows.Forms.Timer loadingHideTimer;

        // Right clicking the green handle opens this menu.
        internal ContextMenuStrip HandleMenu { get; set; }

        // Put your content inside this panel.
        internal Panel Body { get { return body; } }

        // Returns the data this tile holds, so it can be saved with the tile layout.
        internal System.Func<string> GetData { get; set; }

        internal System.Func<object> SettingsViewFactory { get; set; }

        internal bool Selected { get { return selected; } }
        internal bool FullScreen { get { return fullScreen; } }
        internal Rectangle SavedBounds { get { return fullScreen ? normalBounds : Bounds; } }

        internal void SetNormalHeight(int height)
        {
            if (fullScreen) normalBounds.Height = height;
            else Height = height;
        }

        internal void ToggleFullScreen()
        {
            if (Parent == null) return;
            if (fullScreen)
            {
                fullScreen = false;
                Dock = DockStyle.None;
                Bounds = normalBounds;
            }
            else
            {
                foreach (Control control in Parent.Controls)
                {
                    MarketDeskTile tile = control as MarketDeskTile;
                    if (tile != null && tile != this && tile.FullScreen) tile.ToggleFullScreen();
                }
                normalBounds = Bounds;
                fullScreen = true;
                dragging = false;
                resizeEdges = 0;
                SetGridVisible(false);
                Dock = DockStyle.Fill;
            }
            SelectTile();
        }

        // Call BeginBusy before a tile starts loading or calculating, and EndBusy when it finishes. Calls can overlap.
        internal void BeginBusy()
        {
            busyCount++;
            if (busyCount == 1)
            {
                loadingHideTimer.Stop();
                loadingProgress = 0;
                titlePanel.Invalidate();
            }
        }

        // Sets how much of the running job is done, from 0 to 1. Call it on the UI thread.
        internal void SetProgress(double fraction)
        {
            loadingProgress = Math.Max(0, Math.Min(1, fraction));
            titlePanel.Invalidate();
        }

        // Fills the bar to 100%, then hides it after a short hold.
        internal void EndBusy()
        {
            if (busyCount == 0)
            {
                return;
            }
            busyCount--;
            if (busyCount == 0)
            {
                loadingProgress = 1;
                loadingHideTimer.Stop();
                loadingHideTimer.Start();
                titlePanel.Invalidate();
            }
        }

        // Raised when the settings cog on the title strip is clicked.
        internal event EventHandler SettingsRequested;

        internal MarketDeskTile(string name, Size size, Point location)
        {
            Name = name;
            Size = size;
            Location = location;
            DoubleBuffered = true;
            ResizeRedraw = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            body = new Panel();
            body.Name = "Body";
            body.BackColor = MarketDeskStyle.ToolWindowBodyBackground;
            body.Cursor = Cursors.Default;
            body.MouseDown += delegate { SelectTile(); };
            Controls.Add(body);

            loadingHideTimer = new System.Windows.Forms.Timer();
            loadingHideTimer.Interval = MarketDeskStyle.TileLoadingBarHoldMs;
            loadingHideTimer.Tick += delegate
            {
                loadingHideTimer.Stop();
                titlePanel.Invalidate();
            };
            Disposed += delegate { loadingHideTimer.Dispose(); };

            // Double-click the title strip to toggle full screen; the cog opens settings.
            Panel title = new Panel();
            titlePanel = title;
            title.Name = "Title";
            title.Dock = DockStyle.Top;
            title.Height = MarketDeskStyle.TileTitleHeight;
            title.Cursor = Cursors.Default;
            title.Paint += delegate(object sender, PaintEventArgs e)
            {
                Rectangle gear = GearBounds(title.Size);
                bool shown = busyCount > 0 || loadingHideTimer.Enabled;
                bool fill = shown && MarketDeskStyle.TileLoadingStyle == 1;
                int filled = (int)Math.Round(title.Width * loadingProgress);
                using (SolidBrush back = new SolidBrush(MarketDeskStyle.TileTitleBackground))
                using (Pen line = new Pen(MarketDeskStyle.TileTitleLine))
                using (Font bold = new Font(Font, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(back, 0, 0, title.Width, title.Height);
                    if (fill)
                    {
                        // Title Fill: the blue covers the part that is done, behind the text and icon.
                        using (SolidBrush fillBrush = new SolidBrush(MarketDeskStyle.TileLoadingFillColor))
                        {
                            e.Graphics.FillRectangle(fillBrush, 0, 0, filled, title.Height);
                        }
                    }
                    e.Graphics.DrawLine(line, 0, title.Height - 1, title.Width, title.Height - 1);
                    if (shown && !fill)
                    {
                        // Bottom Bar: a grey track along the bottom line, with the blue part showing progress.
                        Rectangle track = new Rectangle(0, title.Height - 4, title.Width, 3);
                        using (SolidBrush trackBrush = new SolidBrush(MarketDeskStyle.TileTitleLine))
                        using (SolidBrush bar = new SolidBrush(MarketDeskStyle.TileLoadingBarColor))
                        {
                            e.Graphics.FillRectangle(trackBrush, track);
                            e.Graphics.FillRectangle(bar, new Rectangle(track.Left, track.Top, filled, track.Height));
                        }
                    }
                    // While loading, the percentage follows the tile name.
                    string caption = shown ? Name + " - " + Math.Round(loadingProgress * 100).ToString("0") + "% Complete" : Name;
                    TextRenderer.DrawText(e.Graphics, caption, bold,
                        new Rectangle(MarketDeskStyle.TileTitlePaddingLeft, 0, Math.Max(0, gear.Left - MarketDeskStyle.TileTitlePaddingLeft), title.Height - 1),
                        Color.Black, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis);
                }
                // The cog sits on the blue when the fill reaches it, so its hole matches that background.
                bool gearOnFill = fill && filled > gear.Left + gear.Width / 2;
                DrawGear(e.Graphics, gear, Color.DimGray, gearOnFill ? MarketDeskStyle.TileLoadingFillColor : MarketDeskStyle.TileTitleBackground);
            };
            title.MouseClick += delegate(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left && GearBounds(title.Size).Contains(e.Location))
                {
                    EventHandler handler = SettingsRequested;
                    if (handler != null)
                    {
                        handler(this, EventArgs.Empty);
                    }
                }
            };
            title.MouseDoubleClick += delegate(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left && !GearBounds(title.Size).Contains(e.Location))
                {
                    ToggleFullScreen();
                }
            };
            ToolTip fullScreenToolTip = new ToolTip();
            fullScreenToolTip.SetToolTip(title, "Double-click to full screen / restore this tile");
            Disposed += delegate { fullScreenToolTip.Dispose(); };
            body.Controls.Add(title);
            title.SendToBack();
            LayoutBody();
            TileClickFilter.Register(this);
        }

        // Settings cog at the right end of the title strip, centred vertically.
        private Rectangle GearBounds(Size titleSize)
        {
            int side = 11;
            int right = titleSize.Width - 8;
            return new Rectangle(right - side, (titleSize.Height - 1 - side) / 2, side, side);
        }

        // Eight-tooth cog with a hole in the middle.
        private static void DrawGear(Graphics g, Rectangle area, Color color, Color holeColor)
        {
            float cx = area.Left + area.Width / 2f;
            float cy = area.Top + area.Height / 2f;
            float outer = area.Width / 2f;
            float inner = outer * 0.72f;

            System.Drawing.Drawing2D.SmoothingMode previousMode = g.SmoothingMode;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF[] points = new PointF[32];
            for (int tooth = 0; tooth < 8; tooth++)
            {
                double centre = tooth * Math.PI / 4;
                double[] angles = new double[] { -0.24, -0.14, 0.14, 0.24 };
                for (int p = 0; p < 4; p++)
                {
                    float radius = (p == 1 || p == 2) ? outer : inner;
                    double angle = centre + angles[p];
                    points[tooth * 4 + p] = new PointF(cx + radius * (float)Math.Cos(angle), cy + radius * (float)Math.Sin(angle));
                }
            }
            using (SolidBrush brush = new SolidBrush(color))
            using (SolidBrush hole = new SolidBrush(holeColor))
            {
                g.FillPolygon(brush, points);
                float holeRadius = outer * 0.32f;
                g.FillEllipse(hole, cx - holeRadius, cy - holeRadius, holeRadius * 2, holeRadius * 2);
            }
            g.SmoothingMode = previousMode;
        }

        // Clicking any control inside a tile (labels, dropdowns, buttons, scrollbars) selects that tile.
        private sealed class TileClickFilter : IMessageFilter
        {
            private static TileClickFilter instance;

            internal static void Register(MarketDeskTile tile)
            {
                if (instance == null)
                {
                    instance = new TileClickFilter();
                    Application.AddMessageFilter(instance);
                }
            }

            public bool PreFilterMessage(ref Message m)
            {
                // Left, right and middle button presses, client and non-client (scrollbars).
                if (m.Msg == 0x201 || m.Msg == 0x204 || m.Msg == 0x207 || m.Msg == 0xA1 || m.Msg == 0xA4)
                {
                    Control control = Control.FromChildHandle(m.HWnd);
                    while (control != null)
                    {
                        MarketDeskTile tile = control as MarketDeskTile;
                        if (tile != null)
                        {
                            if (!tile.selected)
                            {
                                tile.SelectTile();
                            }
                            break;
                        }
                        control = control.Parent;
                    }
                }
                return false;
            }
        }

        private Rectangle HandleBounds
        {
            get
            {
                int width = Math.Min(MarketDeskStyle.TileHandleWidth, Width - 4);
                return new Rectangle(2, 2, width, MarketDeskStyle.TileBorderThickness);
            }
        }

        // Removes the yellow highlight from the selected tile.
        internal static void ClearSelection()
        {
            if (selectedTile != null && !selectedTile.IsDisposed)
            {
                selectedTile.selected = false;
                selectedTile.Invalidate();
            }

            selectedTile = null;
        }

        // Makes this the selected tile (yellow border). Only one tile is selected at a time.
        internal void SelectTile()
        {
            if (selectedTile != null && selectedTile != this && !selectedTile.IsDisposed)
            {
                selectedTile.selected = false;
                selectedTile.Invalidate();
            }

            selectedTile = this;
            selected = true;
            BringToFront();
            Invalidate();
        }

        private void LayoutBody()
        {
            if (body == null)
            {
                return;
            }
            int inset = 4 + MarketDeskStyle.TileBorderThickness;
            body.Bounds = new Rectangle(inset, inset, Math.Max(0, Width - inset * 2), Math.Max(0, Height - inset * 2));
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x02000000;      // WS_CLIPCHILDREN, so the body does not repaint over the border while resizing.
                return cp;
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            LayoutBody();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int thickness = MarketDeskStyle.TileBorderThickness;
            Rectangle whole = new Rectangle(0, 0, Width, Height);
            Rectangle ring = new Rectangle(2, 2, Width - 4, Height - 4);
            int innerEdge = 2 + thickness;

            using (Pen lightPen = new Pen(MarketDeskStyle.TileBevelLight))
            using (Pen darkPen = new Pen(MarketDeskStyle.TileBevelDark))
            {
                // Outer frame (grey lines at the very edge). Drawn first so the yellow can cover them.
                g.DrawRectangle(lightPen, 0, 0, Width - 1, Height - 1);
                g.DrawRectangle(darkPen, 1, 1, Width - 3, Height - 3);

                using (SolidBrush borderBrush = new SolidBrush(MarketDeskStyle.TileBorderColor))
                {
                    g.FillRectangle(borderBrush, ring);
                }

                if (selected)
                {
                    // Solid at the top left, fading towards the bottom right. Painted over the outer grey lines.
                    Color solid = MarketDeskStyle.TileSelectedBorderColor;
                    Color target = MarketDeskStyle.TileBorderColor;
                    int pct = MarketDeskStyle.TileSelectedFadePercent;
                    Color faded = Color.FromArgb(
                        solid.R + (target.R - solid.R) * pct / 100,
                        solid.G + (target.G - solid.G) * pct / 100,
                        solid.B + (target.B - solid.B) * pct / 100);
                    using (System.Drawing.Drawing2D.LinearGradientBrush gradient = new System.Drawing.Drawing2D.LinearGradientBrush(
                        whole, solid, faded, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
                    {
                        g.FillRectangle(gradient, whole);
                    }
                }

                // Inner frame around the content, light line then dark line.
                g.DrawRectangle(lightPen, innerEdge, innerEdge, Width - innerEdge * 2 - 1, Height - innerEdge * 2 - 1);
                g.DrawRectangle(darkPen, innerEdge + 1, innerEdge + 1, Width - innerEdge * 2 - 3, Height - innerEdge * 2 - 3);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SelectTile();
            if (fullScreen) return;
            if (MoveAreaContains(e.Location))
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragging = true;
                    grabOffset = e.Location;
                    SetGridVisible(true);
                    Cursor = Cursors.SizeAll;
                }
                else if (e.Button == MouseButtons.Right && HandleMenu != null)
                {
                    HandleMenu.Show(this, e.Location);
                }
                return;
            }

            int edges = ResizeEdges(e.Location);
            if (edges != 0 && e.Button == MouseButtons.Left)
            {
                resizeEdges = edges;
                resizeStartBounds = Bounds;
                resizeStartMouse = Parent.PointToClient(Cursor.Position);
                // Capture keeps the mouse with this tile even when the size label or a child control is under the pointer.
                Capture = true;
                SetGridVisible(true);
                ShowResizeSize();
            }
        }

        // The top left strip (handle) that moves the tile.
        private bool MoveAreaContains(Point p)
        {
            return p.X < 2 + HandleBounds.Width && p.Y < 2 + MarketDeskStyle.TileBorderThickness;
        }

        // Which sides a point on the border grabs: 1 = left, 2 = right, 4 = top, 8 = bottom. 0 = none.
        private int ResizeEdges(Point p)
        {
            int band = 2 + MarketDeskStyle.TileBorderThickness;
            int corner = MarketDeskStyle.TileResizeCornerSize;
            bool nearTopBottom = p.Y < band || p.Y >= Height - band;
            bool nearLeftRight = p.X < band || p.X >= Width - band;
            int edges = 0;
            if (p.X < band || (nearTopBottom && p.X < corner)) edges |= 1;
            if (p.X >= Width - band || (nearTopBottom && p.X >= Width - corner)) edges |= 2;
            if (p.Y < band || (nearLeftRight && p.Y < corner)) edges |= 4;
            if (p.Y >= Height - band || (nearLeftRight && p.Y >= Height - corner)) edges |= 8;
            return edges;
        }

        // True when the edges are a corner (one horizontal side and one vertical side), not a single side.
        private static bool IsCornerEdges(int edges)
        {
            return ((edges & 1) != 0 || (edges & 2) != 0) && ((edges & 4) != 0 || (edges & 8) != 0);
        }

        private static Cursor CursorForEdges(int edges)
        {
            bool left = (edges & 1) != 0, right = (edges & 2) != 0, top = (edges & 4) != 0, bottom = (edges & 8) != 0;
            if ((left && top) || (right && bottom)) return Cursors.SizeNWSE;
            if ((right && top) || (left && bottom)) return Cursors.SizeNESW;
            if (left || right) return Cursors.SizeWE;
            if (top || bottom) return Cursors.SizeNS;
            return Cursors.Default;
        }

        private void SetGridVisible(bool visible)
        {
            MarketDeskWorkspace workspace = Parent as MarketDeskWorkspace;
            if (workspace != null)
            {
                workspace.ShowGrid = visible;
            }
        }

        // Snaps a tile's position along one axis. Locks to the grid, or to touch a nearby tile if one is close.
        private int SnapMove(int pos, int size, bool xAxis, Rectangle probe)
        {
            int grid = MarketDeskStyle.TileGridSize;
            int best = (int)Math.Round(pos / (double)grid) * grid;
            int bestDist = MarketDeskStyle.TileSnapDistance + 1;
            Rectangle near = Rectangle.Inflate(probe, MarketDeskStyle.TileSnapDistance, MarketDeskStyle.TileSnapDistance);
            foreach (Control other in Parent.Controls)
            {
                if (other == this || !(other is MarketDeskTile) || !near.IntersectsWith(other.Bounds))
                {
                    continue;
                }

                int otherNear = xAxis ? other.Right : other.Bottom;
                int otherFar = xAxis ? other.Left : other.Top;
                int d = Math.Abs(pos - otherNear);
                if (d < bestDist) { bestDist = d; best = otherNear; }
                d = Math.Abs(pos + size - otherFar);
                if (d < bestDist) { bestDist = d; best = otherFar - size; }
            }
            return best;
        }

        // Snaps one edge that is being resized. nearSide is true for the left or top edge.
        private int SnapEdge(int edge, bool xAxis, bool nearSide)
        {
            int grid = MarketDeskStyle.TileGridSize;
            int best = (int)Math.Round(edge / (double)grid) * grid;
            int bestDist = MarketDeskStyle.TileSnapDistance + 1;
            Rectangle near = Rectangle.Inflate(Bounds, MarketDeskStyle.TileSnapDistance, MarketDeskStyle.TileSnapDistance);
            foreach (Control other in Parent.Controls)
            {
                if (other == this || !(other is MarketDeskTile) || !near.IntersectsWith(other.Bounds))
                {
                    continue;
                }

                int target = nearSide ? (xAxis ? other.Right : other.Bottom) : (xAxis ? other.Left : other.Top);
                int d = Math.Abs(edge - target);
                if (d < bestDist) { bestDist = d; best = target; }
            }
            return best;
        }

        private void ResizeWithMouse()
        {
            Point mouse = Parent.PointToClient(Cursor.Position);
            int dx = mouse.X - resizeStartMouse.X;
            int dy = mouse.Y - resizeStartMouse.Y;
            int left = resizeStartBounds.Left, right = resizeStartBounds.Right;
            int top = resizeStartBounds.Top, bottom = resizeStartBounds.Bottom;
            int minW = MarketDeskStyle.TileMinWidth, minH = MarketDeskStyle.TileMinHeight;

            if ((resizeEdges & 1) != 0) left = Math.Max(0, Math.Min(SnapEdge(left + dx, true, true), right - minW));
            if ((resizeEdges & 2) != 0) right = Math.Min(Parent.ClientSize.Width, Math.Max(SnapEdge(right + dx, true, false), left + minW));
            if ((resizeEdges & 4) != 0) top = Math.Max(0, Math.Min(SnapEdge(top + dy, false, true), bottom - minH));
            if ((resizeEdges & 8) != 0) bottom = Math.Min(Parent.ClientSize.Height, Math.Max(SnapEdge(bottom + dy, false, false), top + minH));

            Rectangle target = new Rectangle(left, top, right - left, bottom - top);
            if (target != Bounds)
            {
                // One layout pass per mouse move, instead of one per child control while the size changes.
                SuspendLayout();
                Bounds = target;
                ResumeLayout(true);
            }
            ShowResizeSize();
        }

        // Writes the tile's size in grid cells next to the mouse. Cells are rounded, because edges can snap to a neighbour.
        // Only shown for corner drags; side drags leave it hidden.
        private void ShowResizeSize()
        {
            if (Parent == null || !IsCornerEdges(resizeEdges))
            {
                return;
            }
            if (resizeSizeLabel == null)
            {
                resizeSizeLabel = new Label();
                resizeSizeLabel.AutoSize = true;
                resizeSizeLabel.Font = Font;
                resizeSizeLabel.BackColor = Color.LightYellow;
                resizeSizeLabel.ForeColor = Color.Black;
                resizeSizeLabel.BorderStyle = BorderStyle.FixedSingle;
                Parent.Controls.Add(resizeSizeLabel);
            }
            int grid = MarketDeskStyle.TileGridSize;
            resizeSizeLabel.Text = Math.Round(Width / (double)grid).ToString() + " x " + Math.Round(Height / (double)grid).ToString();
            Point mouse = Parent.PointToClient(Cursor.Position);
            int x = Math.Min(mouse.X + 16, Parent.ClientSize.Width - resizeSizeLabel.Width);
            int y = Math.Min(mouse.Y + 16, Parent.ClientSize.Height - resizeSizeLabel.Height);
            resizeSizeLabel.Location = new Point(Math.Max(0, x), Math.Max(0, y));
            resizeSizeLabel.BringToFront();
            resizeSizeLabel.Visible = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (fullScreen)
            {
                Cursor = Cursors.Default;
                return;
            }
            if (resizeEdges != 0)
            {
                ResizeWithMouse();
                return;
            }

            if (!dragging)
            {
                Cursor = MoveAreaContains(e.Location) ? Cursors.Default : CursorForEdges(ResizeEdges(e.Location));
                return;
            }

            // Move with the mouse, kept inside the workspace.
            Point mouse = Parent.PointToClient(Cursor.Position);
            int rawX = mouse.X - grabOffset.X;
            int rawY = mouse.Y - grabOffset.Y;
            Rectangle probe = new Rectangle(rawX, rawY, Width, Height);
            int x = Math.Max(0, Math.Min(SnapMove(rawX, Width, true, probe), Parent.ClientSize.Width - Width));
            int y = Math.Max(0, Math.Min(SnapMove(rawY, Height, false, probe), Parent.ClientSize.Height - Height));
            Location = new Point(x, y);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            dragging = false;
            resizeEdges = 0;
            Capture = false;
            if (resizeSizeLabel != null)
            {
                resizeSizeLabel.Visible = false;
            }
            SetGridVisible(false);
            Cursor = Cursors.Default;
        }

        protected override void Dispose(bool disposing)
        {
            if (resizeSizeLabel != null)
            {
                resizeSizeLabel.Dispose();
            }
            if (selectedTile == this)
            {
                selectedTile = null;
            }

            base.Dispose(disposing);
        }
    }

    // A dropdown used inside tiles. Never shows the dotted focus box, opens with the Right arrow key,
    // and opens with the Right arrow key.
    internal sealed class MarketDeskComboBox : ComboBox
    {
        private const int WM_PAINT = 0x000F;
        private const int WM_UPDATEUISTATE = 0x0128;
        private const int WM_SETFOCUS = 0x0007;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

        private int look;
        internal bool FollowButtonLook { get; set; }

        // The mouse wheel never changes the selection (and does not scroll the tile when over a dropdown).
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            HandledMouseEventArgs handled = e as HandledMouseEventArgs;
            if (handled != null)
            {
                handled.Handled = true;
            }
        }

        // 0 Old, 1 New.
        internal int Look
        {
            get { return look; }
            set
            {
                look = value;
                if (IsHandleCreated)
                {
                    // Switching to or from New: show or hide the focus cues straight away.
                    SendMessage(Handle, WM_UPDATEUISTATE, (IntPtr)0x10001, IntPtr.Zero);
                }
                Invalidate();
            }
        }

        // The dotted focus box is hidden in every look. New draws its own blue border instead.
        protected override bool ShowFocusCues { get { return false; } }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            HideFocusDots();
        }

        // Tells Windows to hide the dotted focus rectangle (UIS_SET + UISF_HIDEFOCUS).
        private void HideFocusDots()
        {
            SendMessage(Handle, WM_UPDATEUISTATE, (IntPtr)0x10001, IntPtr.Zero);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return keyData == Keys.Right || base.IsInputKey(keyData);
        }

        // Right arrow opens the dropdown list.
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && !DroppedDown)
            {
                DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
            base.OnKeyDown(e);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_UPDATEUISTATE)
            {
                // Windows asks to show focus dots after Tab is pressed. Always answer hide instead.
                m.WParam = (IntPtr)0x10001;
            }

            base.WndProc(ref m);

            if (m.Msg == WM_SETFOCUS)
            {
                HideFocusDots();
            }
        }

        // In the New look, a blue focus border is drawn on the parent just outside the dropdown (so Tab shows where you are).
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (Parent != null)
            {
                Parent.Paint += DrawFocusBorder;
            }
        }

        private void DrawFocusBorder(object sender, PaintEventArgs e)
        {
            if (look != 1 || !Focused)
            {
                return;
            }

            using (Pen pen = new Pen(Color.FromArgb(0, 120, 215), 1f))
            {
                // One pixel line hugging the dropdown on all four sides.
                e.Graphics.DrawRectangle(pen, Left - 1, Top - 1, Width + 1, Height + 1);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Parent != null) Parent.Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (Parent != null) Parent.Invalidate();
        }
    }

    // The data connection dot. Draws a filled circle behind the dot character that fades in and out.
    internal sealed class MarketDeskStatusDot : ToolStripStatusLabel
    {
        public MarketDeskStatusDot(string text) : base(text)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            double phase = (Environment.TickCount % (int)(MarketDeskStyle.StatusDotPulseSeconds * 1000)) / (MarketDeskStyle.StatusDotPulseSeconds * 1000);
            double fade = (1 - Math.Cos(phase * 2 * Math.PI)) / 2;
            int alpha = (int)(255 * MarketDeskStyle.StatusDotPulseOpacityPercent / 100.0 * fade);

            // Same outer size as the old ring: the dot, the gap, and the ring thickness on each side.
            float diameter = 6 + 2 * MarketDeskStyle.StatusDotRingGap + 2 * MarketDeskStyle.StatusDotRingThickness;
            PointF centre = FindDotCentre(ContentRectangle.Size);
            float cx = ContentRectangle.Left + centre.X;
            float cy = ContentRectangle.Top + centre.Y;
            Padding pad = MarketDeskStyle.StatusDotRingPadding;

            // The circle is drawn first so the dot character stays solid on top of it.
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, ForeColor)))
            {
                e.Graphics.FillEllipse(brush, cx - diameter / 2f - pad.Left, cy - diameter / 2f - pad.Top,
                    diameter + pad.Left + pad.Right, diameter + pad.Top + pad.Bottom);
            }

            base.OnPaint(e);
        }

        private Size measuredSize;
        private PointF measuredCentre;

        // The dot character is not centred in its label box, so find where its pixels really are (once per size)
        // and centre the ring on that. This keeps the dot in the middle of the ring.
        private PointF FindDotCentre(Size size)
        {
            if (size == measuredSize || size.Width <= 0 || size.Height <= 0)
            {
                return measuredCentre;
            }

            using (Bitmap bmp = new Bitmap(size.Width, size.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                TextRenderer.DrawText(g, Text, Font, new Rectangle(Point.Empty, size), Color.Black,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
                int minX = size.Width, maxX = -1, minY = size.Height, maxY = -1;
                for (int y = 0; y < size.Height; y++)
                {
                    for (int x = 0; x < size.Width; x++)
                    {
                        if (bmp.GetPixel(x, y).R < 160)
                        {
                            minX = Math.Min(minX, x);
                            maxX = Math.Max(maxX, x);
                            minY = Math.Min(minY, y);
                            maxY = Math.Max(maxY, y);
                        }
                    }
                }
                measuredCentre = maxX < 0
                    ? new PointF(size.Width / 2f, size.Height / 2f)
                    : new PointF((minX + maxX + 1) / 2f, (minY + maxY + 1) / 2f);
            }
            measuredSize = size;
            return measuredCentre;
        }
    }

    // A tile button. Classic = the old square-cornered 3D look, drawn by hand because the Windows theme would round it.
    // Otherwise it is the normal Windows-themed button.
    internal sealed class MarketDeskButton : Button
    {
        private bool pressed;
        private bool classic;

        public MarketDeskButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        internal void PreventInitialSelection()
        {
            TabStop = false;
            SetStyle(ControlStyles.Selectable, false);
        }

        internal bool Classic
        {
            get { return classic; }
            set
            {
                classic = value;
                Invalidate();
            }
        }

        // Fill used when Highlighted is set. Confirm keeps the green bull colour; the Money Flow range toggle uses black.
        private bool highlighted;
        private Color highlightColor = MarketDeskStyle.BullColor;
        internal Color HighlightColor
        {
            get { return highlightColor; }
            set
            {
                highlightColor = value;
                Invalidate();
            }
        }
        internal bool Highlighted
        {
            get { return highlighted; }
            set
            {
                highlighted = value;
                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            pressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            pressed = false;
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        // No dotted focus box in any look. The Old look shows focus with a black border instead.
        protected override bool ShowFocusCues { get { return false; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!classic && !highlighted)
            {
                base.OnPaint(e);
                return;
            }

            e.Graphics.Clear(SystemColors.Control);
            Rectangle bounds = new Rectangle(0, 0, Width, Height);
            if (classic && Focused)
            {
                // Tab selects the button: the classic black frame around it.
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
                bounds.Inflate(-1, -1);
            }

            // Draw the button exactly as it normally looks, then only swap the face colour when highlighted.
            if (classic)
            {
                ControlPaint.DrawButton(e.Graphics, bounds, pressed ? ButtonState.Pushed : ButtonState.Normal);
            }
            else
            {
                ButtonRenderer.DrawButton(e.Graphics, bounds, false, pressed ? System.Windows.Forms.VisualStyles.PushButtonState.Pressed : System.Windows.Forms.VisualStyles.PushButtonState.Normal);
            }

            if (highlighted)
            {
                // Inset by the border width, so the bevel or outline stays visible around the green.
                Rectangle face = Rectangle.Inflate(bounds, -2, -2);
                using (SolidBrush fill = new SolidBrush(highlightColor))
                {
                    e.Graphics.FillRectangle(fill, face);
                }
            }

            Rectangle contentBounds = bounds;
            if (pressed)
            {
                contentBounds.Offset(1, 1);
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, contentBounds, highlighted ? Color.White : ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }
    }

    // Red (bear) on the left and green (bull) on the right. 50/50 puts the split in the middle.
    internal sealed class MarketDeskBiasBar : Control
    {
        private double bear;
        private double bull;
        private double neutral;

        public MarketDeskBiasBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Cursor = Cursors.Default;
        }

        // Neutral points sit between the red and green, so they lower the bull and bear percentages.
        internal void SetScores(double bearPoints, double bullPoints, double neutralPoints)
        {
            bear = bearPoints;
            bull = bullPoints;
            neutral = neutralPoints;
            Invalidate();
        }

        private static string FormatPoints(double points)
        {
            return points == Math.Floor(points) ? ((int)points).ToString() : points.ToString("0.0");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            double total = bear + bull + neutral;
            // Same left/right margins as the buttons (MarketDeskStyle.TileButtonPadding).
            int left = MarketDeskStyle.TileButtonPadding.Left;
            int barWidth = Width - left - MarketDeskStyle.TileButtonPadding.Right;
            int barHeight = MarketDeskStyle.BiasBarHeight;
            int top = 0;
            int split = total == 0 ? barWidth / 2 : (int)Math.Round(barWidth * bear / total);
            int greyEnd = total == 0 ? split : (int)Math.Round(barWidth * (bear + neutral) / total);

            using (SolidBrush red = new SolidBrush(MarketDeskStyle.BearColor))
            using (SolidBrush green = new SolidBrush(MarketDeskStyle.BullColor))
            using (SolidBrush grey = new SolidBrush(Color.Gray))
            {
                e.Graphics.FillRectangle(red, left, top, split, barHeight);
                e.Graphics.FillRectangle(grey, left + split, top, greyEnd - split, barHeight);
                e.Graphics.FillRectangle(green, left + greyEnd, top, barWidth - greyEnd, barHeight);
            }

            TextRenderer.DrawText(e.Graphics, "Bear " + FormatPoints(bear), Font, new Rectangle(left + 4, top, barWidth / 2, barHeight), Color.White,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
            TextRenderer.DrawText(e.Graphics, "Bull " + FormatPoints(bull), Font, new Rectangle(left + barWidth / 2 - 4, top, barWidth / 2, barHeight), Color.White,
                TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

            // Report line under the bar: bold coloured bias on the left, percentage in black on the right.
            string bias = "Neutral Bias";
            string percent = "";
            Color biasColor = Color.Black;
            if (bull > bear)
            {
                bias = "Bullish Bias";
                biasColor = MarketDeskStyle.BullColor;
                percent = (int)Math.Round(100.0 * bull / total) + "% Bullish";
            }
            else if (bear > bull)
            {
                bias = "Bearish Bias";
                biasColor = MarketDeskStyle.BearColor;
                percent = (int)Math.Round(100.0 * bear / total) + "% Bearish";
            }

            Rectangle report = new Rectangle(left, top + barHeight, barWidth, MarketDeskStyle.BiasReportHeight);
            using (Font bold = new Font(Font, FontStyle.Bold))
            {
                TextRenderer.DrawText(e.Graphics, bias, bold, report, biasColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
                if (percent.Length > 0)
                {
                    TextRenderer.DrawText(e.Graphics, percent, bold, report, biasColor,
                        TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
                }
            }
        }
    }

    internal sealed class MarketDeskMenuColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemSelectedGradientBegin { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemSelectedGradientEnd { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemPressedGradientBegin { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemPressedGradientMiddle { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemPressedGradientEnd { get { return MarketDeskStyle.DropdownHover; } }
        public override Color MenuItemBorder { get { return MarketDeskStyle.DropdownBackground; } }
        public override Color MenuBorder { get { return MarketDeskStyle.DropdownBorder; } }
        public override Color ToolStripDropDownBackground { get { return MarketDeskStyle.DropdownBackground; } }
        public override Color ImageMarginGradientBegin { get { return MarketDeskStyle.DropdownBackground; } }
        public override Color ImageMarginGradientMiddle { get { return MarketDeskStyle.DropdownBackground; } }
        public override Color ImageMarginGradientEnd { get { return MarketDeskStyle.DropdownBackground; } }
    }

    internal sealed class MarketDeskMenuRenderer : ToolStripProfessionalRenderer
    {
        public MarketDeskMenuRenderer()
            : base(new MarketDeskMenuColors())
        {
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            ToolStripItem item = e.Item;
            if (!item.Selected && !item.Pressed)
            {
                base.OnRenderMenuItemBackground(e);
                return;
            }

            // Top bar items (File, Tools...) and dropdown rows each get their own hover border.
            Color border = item.IsOnDropDown
                ? MarketDeskStyle.DropdownItemHoverBorder
                : MarketDeskStyle.MenuItemHoverBorder;
            Rectangle bounds = new Rectangle(0, 0, item.Width - 1, item.Height - 1);

            if (item.IsOnDropDown && MarketDeskStyle.UseWindows11Dropdowns)
            {
                // Windows 11 hover: a softly rounded highlight inset from the edges.
                Rectangle inset = new Rectangle(3, 1, item.Width - 7, item.Height - 3);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                using (SolidBrush fill = new SolidBrush(MarketDeskStyle.DropdownHover))
                {
                    int d = MarketDeskStyle.HoverCornerSize;
                    path.AddArc(inset.Left, inset.Top, d, d, 180, 90);
                    path.AddArc(inset.Right - d, inset.Top, d, d, 270, 90);
                    path.AddArc(inset.Right - d, inset.Bottom - d, d, d, 0, 90);
                    path.AddArc(inset.Left, inset.Bottom - d, d, d, 90, 90);
                    path.CloseFigure();
                    e.Graphics.FillPath(fill, path);
                }
                return;
            }

            using (SolidBrush fill = new SolidBrush(MarketDeskStyle.DropdownHover))
            using (Pen borderPen = new Pen(border))
            {
                e.Graphics.FillRectangle(fill, bounds);
                e.Graphics.DrawRectangle(borderPen, bounds);
            }
        }

        // Windows 11 uses a thin ">" chevron for submenus instead of a filled triangle.
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if (!MarketDeskStyle.UseWindows11Dropdowns || e.Direction != ArrowDirection.Right)
            {
                base.OnRenderArrow(e);
                return;
            }

            Rectangle r = e.ArrowRectangle;
            int cx = r.Left + r.Width / 2;
            int cy = r.Top + r.Height / 2;
            Color arrowColor = e.Item.Enabled ? MarketDeskStyle.SubmenuArrow : SystemColors.GrayText;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(arrowColor, 1.2f))
            {
                e.Graphics.DrawLines(pen, new Point[] { new Point(cx - 2, cy - 4), new Point(cx + 2, cy), new Point(cx - 2, cy + 4) });
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown && MarketDeskStyle.UseWindows11Dropdowns)
            {
                return;
            }
            if (e.ToolStrip is ToolStripDropDown && MarketDeskStyle.ShowDropdownBorder)
            {
                Rectangle bounds = e.ToolStrip.ClientRectangle;
                int inset = MarketDeskStyle.DropdownBorderWidth / 2;
                bounds.Inflate(-inset - 1, -inset - 1);

                using (Pen borderPen = new Pen(
                    MarketDeskStyle.DropdownBorder,
                    MarketDeskStyle.DropdownBorderWidth))
                {
                    e.Graphics.DrawRectangle(borderPen, bounds);
                }

                return;
            }

            base.OnRenderToolStripBorder(e);
        }
    }

    public static class MarketDeskApplication
    {
        private static ToolStripStatusLabel statusLabel;
        private static ToolStripStatusLabel dataDot;
        private static ToolStripStatusLabel dataText;
        private static string currentFontName;
        // Look of dropdowns inside tiles, as a number: 0 Old, 1 New. Global > Tile Dropdowns changes it while running.
        private static int tileDropdownLook = 1;
        // Look of buttons inside tiles, as a number: 0 Old, 1 New. Global > Tile Buttons changes it while running.
        private static int tileButtonLook = 1;
        // Dark window colors, saved in user-settings.txt. Tiles keep their own colors.
        private static bool darkMode;
        private static readonly System.Collections.Generic.List<MarketDeskButton> tileButtons = new System.Collections.Generic.List<MarketDeskButton>();
        private static readonly System.Collections.Generic.List<MarketDeskComboBox> tileDropdowns = new System.Collections.Generic.List<MarketDeskComboBox>();
        private static float currentFontSize;
        private static StatusStrip statusStrip;
        private static Panel workspacePanel;
        private static MarketDeskTile biasChecklistWindow;
        private static ToolStripStatusLabel fpsLabel;
        private static ToolStripStatusLabel ticksLabel;
        private static ToolStripStatusLabel nyClockLabel;
        private static ToolStripStatusLabel clockSeparatorLabel;
        private static ToolStripStatusLabel utcClockLabel;
        private static int frameCount;
        private static int tickCount;

        public static void Run()
        {
            MarketDeskStyle.DataFolder = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                MarketDeskStyle.WindowTitle);
            System.IO.Directory.CreateDirectory(MarketDeskStyle.DataFolder);
            System.IO.Directory.CreateDirectory(SettingsFolderPath());
            System.IO.Directory.CreateDirectory(TilesFolderPath());
            LoadUserSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = CreateForm();
            if (darkMode)
            {
                ApplyDarkMode(form);
            }
            RestoreTiles();
            form.FormClosed += delegate
            {
                SaveUserSettings();
                SaveTiles();
            };
            Application.Run(form);
        }

        private static string SettingsFolderPath()
        {
            return System.IO.Path.Combine(MarketDeskStyle.DataFolder, "settings");
        }

        // File format: one Key=Value line per setting. Unknown or invalid values are ignored and the defaults kept.
        private static void LoadUserSettings()
        {
            string path = System.IO.Path.Combine(SettingsFolderPath(), "user-settings.txt");
            if (!System.IO.File.Exists(path))
            {
                return;
            }

            try
            {
                foreach (string line in System.IO.File.ReadAllLines(path))
                {
                    int equals = line.IndexOf('=');
                    if (equals < 0)
                    {
                        continue;
                    }

                    string key = line.Substring(0, equals).Trim();
                    string value = line.Substring(equals + 1).Trim();
                    int number;
                    float size;
                    bool compact;
                    bool flag;
                    switch (key)
                    {
                        case "FontName":
                            if (System.Array.IndexOf(MarketDeskStyle.FontChoices, value) >= 0)
                            {
                                MarketDeskStyle.FontName = value;
                            }
                            break;
                        case "FontSize":
                            if (float.TryParse(value, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out size) &&
                                System.Array.IndexOf(MarketDeskStyle.FontSizeChoices, size) >= 0)
                            {
                                MarketDeskStyle.FontSize = size;
                            }
                            break;
                        case "TileDropdownLook":
                            if (int.TryParse(value, out number) && number >= 0 && number < MarketDeskStyle.TileDropdownLooks.Length)
                            {
                                tileDropdownLook = number;
                            }
                            break;
                        case "TileButtonLook":
                            if (int.TryParse(value, out number) && number >= 0 && number < MarketDeskStyle.TileButtonLooks.Length)
                            {
                                tileButtonLook = number;
                            }
                            break;
                        case "LoadingStyle":
                            if (int.TryParse(value, out number) && number >= 0 && number < MarketDeskStyle.TileLoadingStyles.Length)
                            {
                                MarketDeskStyle.TileLoadingStyle = number;
                            }
                            break;
                        case "CompactTiles":
                            if (bool.TryParse(value, out compact))
                            {
                                MarketDeskStyle.CompactTiles = compact;
                            }
                            break;
                        case "DarkMode":
                            if (bool.TryParse(value, out flag))
                            {
                                darkMode = flag;
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                // A damaged settings file should not stop the program from starting.
            }
        }

        private static void SaveUserSettings()
        {
            try
            {
                System.IO.Directory.CreateDirectory(SettingsFolderPath());
                string[] lines =
                {
                    "FontName=" + currentFontName,
                    "FontSize=" + currentFontSize.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    "TileDropdownLook=" + tileDropdownLook,
                    "TileButtonLook=" + tileButtonLook,
                    "CompactTiles=" + MarketDeskStyle.CompactTiles.ToString(),
                    "LoadingStyle=" + MarketDeskStyle.TileLoadingStyle,
                    "DarkMode=" + darkMode.ToString()
                };
                System.IO.File.WriteAllLines(System.IO.Path.Combine(SettingsFolderPath(), "user-settings.txt"), lines);
            }
            catch (Exception)
            {
                // Settings could not be written (for example, the folder is read-only). The program can still close.
            }
        }

        public static string Validate()
        {
            Form form = CreateForm();
            try
            {
                MenuStrip menu = null;
                foreach (Control control in form.Controls)
                {
                    MenuStrip candidate = control as MenuStrip;
                    if (candidate != null)
                    {
                        menu = candidate;
                        break;
                    }
                }

                if (menu == null || menu.Items.Count != 8)
                {
                    throw new InvalidOperationException("The menu bar did not initialize correctly.");
                }

                if (menu.BackColor != MarketDeskStyle.MenuBarBackground ||
                    !(menu.Renderer is MarketDeskMenuRenderer) ||
                    !MarketDeskStyle.ShowDropdownBorder ||
                    MarketDeskStyle.DropdownBorderWidth < 1 ||
                    MarketDeskStyle.DropdownBorder == Color.Empty ||
                    MarketDeskStyle.DropdownHover != Color.FromArgb(245, 245, 245))
                {
                    throw new InvalidOperationException("The customizable menu styles were not applied.");
                }

                foreach (ToolStripItem item in menu.Items)
                {
                    ToolStripMenuItem menuItem = item as ToolStripMenuItem;
                    if (menuItem != null &&
                        (menuItem.DropDown.Renderer != menu.Renderer ||
                         menuItem.DropDown.BackColor != MarketDeskStyle.DropdownBackground ||
                         menuItem.DropDown.DropShadowEnabled != (MarketDeskStyle.ShowDropdownShadow && !MarketDeskStyle.UseWindows11Dropdowns)))
                    {
                        throw new InvalidOperationException("A dropdown is missing its configured style.");
                    }
                }

                Control workspace = null;
                foreach (Control control in form.Controls)
                {
                    if (control.Name == "Workspace")
                    {
                        workspace = control;
                        break;
                    }
                }
                if (workspace == null || workspace.Controls.Count != 0)
                {
                    throw new InvalidOperationException("The main workspace is not blank.");
                }
                if (form.BackColor != MarketDeskStyle.WindowBackground ||
                    workspace.BackColor != MarketDeskStyle.WorkspaceBackground)
                {
                    throw new InvalidOperationException("The window and workspace backgrounds are not applied separately.");
                }
                ValidateCandleData();
                ValidateCandleDropdownStyle();
                ValidateTileFullScreen();
                ValidateCandleMetrics();
                ValidatePriceDataComparison();
                ValidatePriceDataConfirmation();
                ValidateMoneyFlow();
                ValidateMmd();
                ValidateOrderBookDelta();
                ValidateVolumeRejections();
                ValidatePerpChart();
                ValidateVolumeProfile();
                return "C# WinForms initialized; workspace, Candle Data, Money Flow, MMD ETH/BTC bias, strength periods and divergences, charts, Order Book Delta, TradingView volume rejections, and Perp chart verified.";
            }
            finally
            {
                form.Dispose();
            }
        }

        private static void ValidateTileFullScreen()
        {
            using (Panel workspace = new Panel())
            using (MarketDeskTile first = new MarketDeskTile("First", new Size(200, 180), new Point(20, 30)))
            using (MarketDeskTile second = new MarketDeskTile("Second", new Size(180, 160), new Point(240, 30)))
            {
                workspace.Size = new Size(800, 600);
                workspace.Controls.Add(first);
                workspace.Controls.Add(second);
                Rectangle original = first.Bounds;
                Rectangle otherOriginal = second.Bounds;
                Control title = first.Body.Controls["Title"];
                if (title.Controls.Count != 0)
                    throw new InvalidOperationException("The title strip still contains a full-screen button.");
                System.Reflection.MethodInfo doubleClick = typeof(Control).GetMethod("OnMouseDoubleClick",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                doubleClick.Invoke(title, new object[] { new MouseEventArgs(MouseButtons.Left, 2, 10, 10, 0) });
                workspace.PerformLayout();
                if (!first.FullScreen || first.Bounds != workspace.ClientRectangle ||
                    first.SavedBounds != original || second.Bounds != otherOriginal)
                    throw new InvalidOperationException("Full screen did not expand only the selected tile.");
                doubleClick.Invoke(title, new object[] { new MouseEventArgs(MouseButtons.Left, 2, 10, 10, 0) });
                if (first.FullScreen || first.Bounds != original)
                    throw new InvalidOperationException("Double-clicking the title did not restore the tile.");
                doubleClick.Invoke(title, new object[] { new MouseEventArgs(MouseButtons.Right, 2, 10, 10, 0) });
                doubleClick.Invoke(title, new object[] { new MouseEventArgs(MouseButtons.Left, 2, title.Width - 13, 10, 0) });
                if (first.FullScreen)
                    throw new InvalidOperationException("Settings or right-click incorrectly toggled full screen.");
                doubleClick.Invoke(title, new object[] { new MouseEventArgs(MouseButtons.Left, 2, 10, 10, 0) });
                workspace.Size = new Size(900, 650);
                workspace.PerformLayout();
                if (first.Bounds != workspace.ClientRectangle)
                    throw new InvalidOperationException("Full-screen tile did not follow workspace resizing.");
                second.ToggleFullScreen();
                workspace.PerformLayout();
                if (first.FullScreen || first.Bounds != original || !second.FullScreen ||
                    second.Bounds != workspace.ClientRectangle)
                    throw new InvalidOperationException("Switching full-screen tiles did not restore the previous tile.");
                second.ToggleFullScreen();
                if (second.Bounds != otherOriginal || second.FullScreen)
                    throw new InvalidOperationException("Restore did not preserve tile size and position.");
                first.ToggleFullScreen();
                first.SetNormalHeight(220);
                workspace.PerformLayout();
                if (first.Bounds != workspace.ClientRectangle || first.SavedBounds.Height != 220)
                    throw new InvalidOperationException("Global tile sizing broke full screen.");
                first.ToggleFullScreen();
                original.Height = 220;
                if (first.Bounds != original)
                    throw new InvalidOperationException("Restore lost the updated normal height.");
            }
        }

        private static void ValidateCandleDropdownStyle()
        {
            int previousButtons = tileButtonLook;
            int previousDropdowns = tileDropdownLook;
            using (MarketDeskComboBox dropdown = new MarketDeskComboBox())
            {
                dropdown.FollowButtonLook = true;
                dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
                dropdown.Items.AddRange(CandleTimeFrameLabels);
                UseTileDropdownLook(dropdown);
                try
                {
                    dropdown.CreateControl();
                    SetTileDropdownLook(1);
                    SetTileButtonLook(0);
                    if (dropdown.Look != 0 || dropdown.FlatStyle != FlatStyle.Standard ||
                        dropdown.Items.Count != CandleTimeFrameNames.Length || dropdown.Items[0].ToString() != "1 Hour" ||
                        dropdown.Items[4].ToString() != "1 Day" || dropdown.Items[5].ToString() != "1 Week")
                        throw new InvalidOperationException("The candle dropdown does not use native classic styling or full timeframe names.");
                    SetTileDropdownLook(0);
                    SetTileButtonLook(1);
                    if (dropdown.Look != 1)
                        throw new InvalidOperationException("The candle dropdown did not follow the button style change.");
                }
                finally
                {
                    SetTileButtonLook(previousButtons);
                    SetTileDropdownLook(previousDropdowns);
                }
            }
        }

        private static void ValidateCandleData()
        {
            foreach (double value in new double[] { 100.49, 100.50, 100.99 })
            {
                CandleHour candle = new CandleHour(0, value);
                candle.AddMinute(value, value, value, value, 10, 6);
                double expected = Math.Round(value, MidpointRounding.AwayFromZero);
                foreach (System.Collections.Generic.Dictionary<long, double> volumes in new[] { candle.TotalByBucket, candle.BuyByBucket, candle.SellByBucket })
                {
                    double price;
                    if (!TryFindPoc(volumes, out price) || price != expected)
                    {
                        throw new InvalidOperationException("POC prices are not rounded to the nearest dollar.");
                    }
                }
            }
            string timeFrame;
            int savedCount;
            ReadCandleSettings("1d", out timeFrame, out savedCount);
            if (timeFrame != "1d" || savedCount != CandleCount)
            {
                throw new InvalidOperationException("Legacy Candle Data settings were not preserved.");
            }
            ReadCandleSettings("1W|10", out timeFrame, out savedCount);
            if (timeFrame != "1W" || savedCount != 10)
            {
                throw new InvalidOperationException("The added period count was not restored.");
            }
            bool[] rowVisible;
            ReadCandleSettings("1W|10|False", out timeFrame, out savedCount, out rowVisible);
            if (timeFrame != "1W" || savedCount != 10 || !rowVisible[0] || rowVisible[CandleMetricStartRow])
            {
                throw new InvalidOperationException("The legacy Candle Data metric visibility setting was not restored.");
            }
            ReadCandleSettings("1W|10|10111111111111111", out timeFrame, out savedCount, out rowVisible);
            if (rowVisible[1] || !rowVisible[0] || !rowVisible[CandleMetricStartRow])
            {
                throw new InvalidOperationException("The Candle Data row visibility mask was not restored.");
            }

            Color checkLine;
            Color checkBack;
            Color expectedBack = Color.FromArgb(255, 30, 30, 30);
            ReadDataChartColors(WriteDataChartColors(Color.Red, expectedBack), out checkLine, out checkBack);
            if (checkLine.ToArgb() != Color.Red.ToArgb() || checkBack.ToArgb() != expectedBack.ToArgb())
            {
                throw new InvalidOperationException("The Data Chart colours were not restored.");
            }
            ReadDataChartColors("Teal", out checkLine, out checkBack);
            if (checkLine != Color.Gray || checkBack != MarketDeskStyle.ToolWindowBodyBackground)
            {
                throw new InvalidOperationException("Old Data Chart settings did not fall back to the default colours.");
            }

            using (TableLayoutPanel grid = new TableLayoutPanel())
            {
                int allColumns = CandleCount + 1 + CandleStatCount;
                grid.ColumnCount = allColumns + 1;
                grid.RowCount = CandleRowCount + 2;
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
                Label[] times = new Label[allColumns];
                Label[][] rows = new Label[CandleRowCount][];
                Label[] totals = new Label[CandleRowCount];
                System.Collections.Generic.List<Label> headers = new System.Collections.Generic.List<Label>();
                for (int column = 0; column < allColumns; column++)
                {
                    grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / allColumns));
                    times[column] = CreateCandleHeaderCell(column == allColumns - 3 ? "Mean" : column == allColumns - 2 ? "Median" : column == allColumns - 1 ? "Total" : "...", ContentAlignment.MiddleCenter);
                    headers.Add(times[column]);
                    grid.Controls.Add(times[column], column + 1, 0);
                }
                for (int row = 0; row < CandleRowCount; row++)
                {
                    rows[row] = new Label[allColumns];
                    grid.Controls.Add(CreateCandleHeaderCell(CandleRowNames[row], ContentAlignment.MiddleLeft), 0, row + 1);
                    for (int column = 0; column < allColumns; column++)
                    {
                        rows[row][column] = CreateCandleCell();
                        grid.Controls.Add(rows[row][column], column + 1, row + 1);
                    }
                    totals[row] = rows[row][allColumns - 1];
                    totals[row].Text = string.Empty;
                }
                Panel buttonsPanel = new Panel();
                grid.Controls.Add(buttonsPanel, 0, CandleRowCount + 1);
                MarketDeskButton[] buttons = CreateCandleButtons(buttonsPanel);
                bool compact = MarketDeskStyle.CompactTiles;
                try
                {
                    foreach (bool size in new bool[] { false, true })
                    {
                        MarketDeskStyle.CompactTiles = size;
                        buttonsPanel.Height = MarketDeskStyle.TileButtonHeight + 12;
                        LayoutCandleButtons(buttons);
                        for (int button = 0; button < buttons.Length; button++)
                        {
                            if (buttons[button].Width != buttons[button].Height ||
                                buttons[button].Width != MarketDeskStyle.TileButtonHeight ||
                                buttons[button].Left != 5 + button * (MarketDeskStyle.TileButtonHeight + 2) ||
                                buttons[button].Top != 6 ||
                                buttons[button].TabStop || buttons[button].CanSelect ||
                                buttons[button].Text != (button == 0 ? "+" : button == 1 ? "?" : button == 2 ? "<" : "-") ||
                                buttons[button].Enabled != (button < 3))
                            {
                                throw new InvalidOperationException("Candle Data buttons are not square or configured correctly.");
                            }
                        }
                    }
                }
                finally
                {
                    MarketDeskStyle.CompactTiles = compact;
                }
                Label liveHeader = times[CandleCount];
                SizeCandleTotalColumn(grid, times[times.Length - 1], totals);
                float totalWidth = grid.ColumnStyles[grid.ColumnCount - 1].Width;
                for (int count = CandleCount; count <= CandleCount + 2; count++)
                {
                    if (count > CandleCount)
                    {
                        PrependCandleColumn(grid, headers, ref times, rows);
                    }
                    if (grid.ColumnCount != count + CandleStatCount + 2 ||
                        times[count] != liveHeader || times[count + 1].Text != "Mean" || times[count + 2].Text != "Median" ||
                        times[count + 3].Text != "Total" || grid.GetColumn(totals[0]) != grid.ColumnCount - 1 ||
                        grid.ColumnStyles[grid.ColumnCount - 1].SizeType != SizeType.Absolute ||
                        grid.ColumnStyles[grid.ColumnCount - 1].Width != totalWidth ||
                        grid.GetColumn(liveHeader) != count + 1 || grid.GetColumn(buttonsPanel) != 0)
                    {
                        throw new InvalidOperationException("Adding a period moved the live, statistics or button columns incorrectly.");
                    }
                    for (int row = 0; row < rows.Length; row++)
                    {
                        if (rows[row].Length != times.Length)
                        {
                            throw new InvalidOperationException("An added period is missing data cells.");
                        }
                        for (int column = 0; column < rows[row].Length; column++)
                        {
                            if (grid.GetColumn(rows[row][column]) != column + 1 ||
                                grid.GetRow(rows[row][column]) != row + 1)
                            {
                                throw new InvalidOperationException("An added period's data cells are misaligned.");
                            }
                        }
                    }
                    foreach (int hours in CandleTimeFrameHours)
                    {
                        long candleMs = hours * HourMs;
                        long startMs = CandleBucketStart(1700000000000L, candleMs);
                        System.Text.StringBuilder json = new System.Text.StringBuilder("[");
                        for (int period = 0; period <= CandleCount + 2; period++)
                        {
                            if (period > 0) json.Append(',');
                            json.Append('[').Append(startMs + period * candleMs).Append(",\"100\",\"100\",\"100\",\"100\",\"10\",0,\"0\",0,\"6\"]");
                        }
                        json.Append(']');
                        System.Collections.Generic.List<CandleHour> candles = ParseCandles(json.ToString(), candleMs, count);
                        ShowCandles(times, rows, totals, candles, candleMs);
                        if (candles.Count != count + 1 ||
                            candles[0].OpenTimeMs != startMs + (CandleCount + 2 - count) * candleMs ||
                            times[count].ForeColor != Color.Green || times[0].ForeColor != Color.Black ||
                            times[count].Text.Contains("\u25cf") || totals[1].Text != FormatRowStat(2 * (count + 1), 1) ||
                            rows[1][count + 1].Text != "+2.00" || rows[1][count + 2].Text != "+2.00" ||
                            totals[3].Text != "100 | " + (10 * (count + 1)).ToString(System.Globalization.CultureInfo.InvariantCulture) + "B")
                        {
                            throw new InvalidOperationException("Candle Data added periods, live text or statistics failed validation.");
                        }
                    }
                    ShowCandles(times, rows, totals, null, HourMs);
                    if (rows[1][0].Text != "n/a" || rows[1][count + 1].Text != "n/a" || totals[1].Text != string.Empty)
                    {
                        throw new InvalidOperationException("Unavailable candle data left stale values visible.");
                    }
                    for (int row = CandleMetricStartRow; row < CandleRowCount; row++)
                    {
                        if (rows[row][0].Text != "n/a" ||
                            rows[row][0].BackColor != MarketDeskStyle.TileTitleBackground)
                            throw new InvalidOperationException("Unavailable metric data retained a directional colour.");
                    }
                    ClearCandleValues(times, rows, totals);
                    foreach (Label[] row in rows)
                    {
                        foreach (Label cell in row)
                        {
                            if (cell.Text.Length != 0) throw new InvalidOperationException("Clean Price Data left data visible.");
                        }
                    }
                }
                Label removedHeader = times[0];
                Label removedCell = rows[0][0];
                RemoveOldestCandleColumn(grid, headers, ref times, rows);
                int reducedCount = CandleCount + 1;
                if (times.Length != reducedCount + 1 + CandleStatCount ||
                    times[reducedCount] != liveHeader ||
                    grid.ColumnCount != reducedCount + CandleStatCount + 2 ||
                    !removedHeader.IsDisposed || !removedCell.IsDisposed ||
                    grid.GetColumn(liveHeader) != reducedCount + 1 ||
                    times[reducedCount + 1].Text != "Mean" || times[reducedCount + 2].Text != "Median" ||
                    times[reducedCount + 3].Text != "Total" || grid.GetColumn(totals[0]) != grid.ColumnCount - 1 ||
                    grid.ColumnStyles[grid.ColumnCount - 1].Width != totalWidth)
                {
                    throw new InvalidOperationException("Removing the oldest period moved the live or statistics columns incorrectly.");
                }
                totals[0].Text = "+123.45% | -123.45%";
                totals[2].Text = "+$12,345 per 1k B | 100%";
                SizeCandleTotalColumn(grid, times[times.Length - 1], totals);
                int widest = TextRenderer.MeasureText("Total", times[times.Length - 1].Font,
                    Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding).Width;
                foreach (Label total in totals)
                    widest = Math.Max(widest, TextRenderer.MeasureText(total.Text, total.Font,
                        Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding).Width);
                if (grid.ColumnStyles[grid.ColumnCount - 1].Width != widest + 8)
                    throw new InvalidOperationException("The Total column is not sized to its widest text plus padding.");
            }
        }

        private static void ValidateCandleMetrics()
        {
            using (Panel panel = new Panel())
            {
                Label[][] rows = new Label[CandleRowCount][];
                System.Collections.Generic.List<double>[] values = new System.Collections.Generic.List<double>[CandleRowCount];
                for (int row = 0; row < CandleRowCount; row++)
                {
                    rows[row] = new Label[] { CreateCandleCell() };
                    panel.Controls.Add(rows[row][0]);
                    values[row] = new System.Collections.Generic.List<double>();
                }
                System.Collections.Generic.List<double> deltas = new System.Collections.Generic.List<double>(new double[] { -10, 0, 10 });
                System.Collections.Generic.List<double> moves = new System.Collections.Generic.List<double>(new double[] { -10, 10, 30 });
                CandleHour candle = new CandleHour(0, 100);
                candle.AddMinute(100, 190, 100, 190, 50, 40);
                ShowCandleMetrics(rows, 0, candle, 30, deltas, moves, values);
                Color bullish = Color.FromArgb(195, 235, 195);
                Color bearish = Color.FromArgb(245, 195, 195);
                Color neutral = MarketDeskStyle.TileTitleBackground;
                if (rows[CandleMetricStartRow][0].Text != "+60.00%" || rows[CandleMetricStartRow + 1][0].Text != "+$3,000.00" ||
                    rows[CandleMetricStartRow + 2][0].Text != "Up/Up" || rows[CandleMetricStartRow + 3][0].Text != "+3.67" || rows[CandleMetricStartRow + 4][0].Text != "+$20.00" ||
                    deltas.Count != 3 || moves.Count != 3)
                {
                    throw new InvalidOperationException("Candle metrics calculations or prior-only baselines failed.");
                }
                for (int row = CandleMetricStartRow; row < CandleRowCount; row++)
                {
                    if (rows[row][0].BackColor != bullish)
                        throw new InvalidOperationException("A bullish candle metric is not green.");
                }
                Label[] stats = new Label[] { CreateCandleCell(), CreateCandleCell(), CreateCandleCell() };
                foreach (Label stat in stats) panel.Controls.Add(stat);
                ShowRowStats(stats, new System.Collections.Generic.List<double>(new double[] { -10, 20, 50 }), CandleMetricStartRow + 4);
                if (stats[0].Text != "+$20.00" || stats[1].Text != "+$20.00" ||
                    stats[0].BackColor != neutral)
                    throw new InvalidOperationException("Metric summaries have incorrect units or directional colours.");
                candle.Close = 30;
                ShowCandleMetrics(rows, 0, candle, -30, deltas, moves, values);
                if (rows[12][0].BackColor != bearish || rows[14][0].Text != "Down/Down" ||
                    rows[15][0].BackColor != bearish || rows[16][0].Text != "-$20.00" ||
                    rows[16][0].BackColor != bearish)
                {
                    throw new InvalidOperationException("Bearish candle metrics failed.");
                }
                ShowCandleMetrics(rows, 0, candle, 30, deltas, moves, values);
                if (rows[13][0].BackColor != neutral || rows[14][0].BackColor != neutral ||
                    rows[14][0].Text != "Down/Up")
                {
                    throw new InvalidOperationException("Ambiguous price/delta readings are not neutral.");
                }
                ShowCandleMetrics(rows, 0, candle, 0.1, deltas, moves, values);
                if (rows[13][0].Text != "n/a" || rows[13][0].BackColor != neutral)
                    throw new InvalidOperationException("Tiny delta produced unstable efficiency.");
                deltas.Clear();
                moves.Clear();
                ShowCandleMetrics(rows, 0, candle, 30, deltas, moves, values);
                if (rows[15][0].Text != "n/a" || rows[16][0].Text != "n/a")
                    throw new InvalidOperationException("Metrics used insufficient history.");
                deltas.AddRange(new double[] { 5, 5, 5 });
                moves.AddRange(new double[] { 0, 0, 0 });
                candle.Volume = 0;
                ShowCandleMetrics(rows, 0, candle, 0, deltas, moves, values);
                if (rows[12][0].Text != "n/a" || rows[13][0].Text != "n/a" ||
                    rows[15][0].Text != "n/a" || rows[16][0].Text != "n/a")
                    throw new InvalidOperationException("Zero volume or constant history produced invalid metrics.");
                Label[] times = new Label[] { CreateCandleCell(), CreateCandleCell(), CreateCandleCell() };
                foreach (Label time in times) panel.Controls.Add(time);
                ClearCandleValues(times, rows, new Label[0]);
                for (int row = CandleMetricStartRow; row < CandleRowCount; row++)
                {
                    if (rows[row][0].Text.Length != 0 ||
                        rows[row][0].BackColor != MarketDeskStyle.ToolWindowBodyBackground)
                        throw new InvalidOperationException("Cleaning retained stale metric colours.");
                }
            }
        }

        private static void ValidatePriceDataConfirmation()
        {
            using (MarketDeskTile tile = new MarketDeskTile("Test", new Size(200, 200), Point.Empty))
            {
                Label message;
                Button cancel;
                Button confirm;
                using (Form dialog = CreatePriceDataDialog(tile, "Clean Price Data",
                    "Are you sure you would like to clean price data?", out message, out cancel, out confirm))
                {
                    if (dialog.Controls.Count != 3 || dialog.CancelButton != cancel ||
                        cancel.DialogResult != DialogResult.Cancel || confirm.DialogResult != DialogResult.OK ||
                        message.Text != "Are you sure you would like to clean price data?" ||
                        confirm.Text != "Confirm" || cancel.Text != "Cancel")
                    {
                        throw new InvalidOperationException("Clean Price Data confirmation is not configured correctly.");
                    }
                }
            }
        }

        private static void ValidatePriceDataComparison()
        {
            string first = "[60000,\"100.00\",\"110\",\"90\",\"105\",\"10\",119999,\"1000\",5,\"6\",\"600\",\"0\"]";
            string second = first.Replace("60000,", "120000,").Replace("119999,", "179999,");
            string third = first.Replace("60000,", "180000,").Replace("119999,", "239999,");
            string fourth = first.Replace("60000,", "240000,").Replace("119999,", "299999,");
            string live = first.Replace("60000,", "300000,").Replace("119999,", "359999,");
            string snapshot = string.Join("\r\n", new string[] { first, first, third, fourth, live, "broken row" });
            int pages = 0;
            System.Collections.Generic.List<double> progress = new System.Collections.Generic.List<double>();
            using (System.IO.StringReader reader = new System.IO.StringReader(snapshot))
            {
                string report = ValidateSavedPrices(reader, 300000, delegate(long cursor, long last)
                {
                    pages++;
                    if (last != 240000) throw new InvalidOperationException("Validation checked beyond the saved completed range.");
                    if (cursor == 60000) return "[" + first.Replace("100.00", "100") + "," + second + "]";
                    if (cursor == 180000) return "[" + fourth.Replace("\"105\"", "\"106\"") + "]";
                    throw new InvalidOperationException("Validation pagination did not advance correctly.");
                }, delegate(double fraction) { progress.Add(fraction); });
                foreach (string expected in new string[] {
                    "Saved completed candles: 3", "Matching: 1", "Different: 1",
                    "Missing from saved data: 1", "Missing from Binance: 1",
                    "Invalid saved rows: 1", "Duplicate saved rows: 1", "Unfinished rows skipped: 1", "No saved data was changed." })
                {
                    if (!report.Contains(expected)) throw new InvalidOperationException("Price validation report is missing: " + expected);
                }
                if (pages != 2) throw new InvalidOperationException("Price validation did not check every page.");
                if (progress.Count != 4 || progress[0] != 0 || progress[1] != 0.5 || progress[2] != 1 || progress[3] != 1)
                {
                    throw new InvalidOperationException("Price validation progress did not match the checked minute range.");
                }
            }
            using (System.IO.StringReader reader = new System.IO.StringReader(first))
            {
                string report = ValidateSavedPrices(reader, 300000, delegate { return "[]"; });
                if (!report.Contains("Missing from Binance: 1")) throw new InvalidOperationException("An empty Binance range was not reported.");
            }
            bool rejected = false;
            try
            {
                using (System.IO.StringReader reader = new System.IO.StringReader(first))
                {
                    ValidateSavedPrices(reader, 300000, delegate { return "{\"error\":\"unavailable\"}"; });
                }
            }
            catch (FormatException) { rejected = true; }
            if (!rejected) throw new InvalidOperationException("A failed Binance response appeared to validate successfully.");
        }

        private static string MoneyFlowFixture(MoneyFlowRange range, long endMs, string quoteBuy, string close)
        {
            System.Collections.Generic.List<string> rows = new System.Collections.Generic.List<string>();
            for (int i = 0; i < range.Candles; i++)
            {
                long time = endMs - (range.Candles - i) * range.IntervalMs;
                rows.Add("[" + time.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    ",\"100\",\"110\",\"90\",\"" + close + "\",\"10\"," +
                    (time + range.IntervalMs - 1).ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    ",\"1000\",5,\"6\",\"" + quoteBuy + "\",\"0\"]");
            }
            return "[" + string.Join(",", rows.ToArray()) + "]";
        }

        private static void ValidateOrderBookDelta()
        {
            string snapshot = "{\"lastUpdateId\":10,\"bids\":[[\"100\",\"2\"],[\"99\",\"1\"]],\"asks\":[[\"101\",\"3\"]]}";
            OrderBookDeltaBook book = new OrderBookDeltaBook();
            book.LoadSnapshot(snapshot);
            decimal net;
            long eventTime;
            string first = "{\"e\":\"depthUpdate\",\"E\":1000,\"s\":\"BTCUSDT\",\"U\":9,\"u\":11,\"pu\":8,\"b\":[[\"100\",\"5\"],[\"99\",\"0\"]],\"a\":[[\"101\",\"1\"]]}";
            if (book.Apply(first, out net, out eventTime) != OrderBookApply.Applied || net != 4 || eventTime != 1000)
                throw new InvalidOperationException("Order book first update did not apply the expected net liquidity change.");
            string second = "{\"e\":\"depthUpdate\",\"E\":2000,\"s\":\"BTCUSDT\",\"U\":12,\"u\":12,\"pu\":11,\"b\":[],\"a\":[[\"101\",\"0\"]]}";
            if (book.Apply(second, out net, out eventTime) != OrderBookApply.Applied || net != 1)
                throw new InvalidOperationException("Order book follow-up update did not apply the expected net liquidity change.");
            string broken = "{\"e\":\"depthUpdate\",\"E\":3000,\"s\":\"BTCUSDT\",\"U\":13,\"u\":13,\"pu\":5,\"b\":[],\"a\":[]}";
            if (book.Apply(broken, out net, out eventTime) != OrderBookApply.Gap)
                throw new InvalidOperationException("Order book sequence gap was not detected.");
            string old = "{\"e\":\"depthUpdate\",\"E\":4000,\"s\":\"BTCUSDT\",\"U\":1,\"u\":5,\"pu\":0,\"b\":[],\"a\":[]}";
            OrderBookDeltaBook fresh = new OrderBookDeltaBook();
            fresh.LoadSnapshot(snapshot);
            if (fresh.Apply(old, out net, out eventTime) != OrderBookApply.Ignored)
                throw new InvalidOperationException("Order book update older than the snapshot was not ignored.");
            string late = "{\"e\":\"depthUpdate\",\"E\":5000,\"s\":\"BTCUSDT\",\"U\":12,\"u\":12,\"pu\":11,\"b\":[],\"a\":[]}";
            if (fresh.Apply(late, out net, out eventTime) != OrderBookApply.Gap)
                throw new InvalidOperationException("Order book update past the snapshot without bridging it was not treated as a gap.");

            OrderBookDeltaCanvas canvas = new OrderBookDeltaCanvas();
            canvas.Size = new Size(320, 160);
            canvas.SetSnapshot(new OrderBookDeltaSnapshot {
                Times = new long[] { 0, 60000 }, Values = new double[] { 0, 1.5 }, EndMs = 120000, State = "Live" });
            canvas.DrawToBitmap(new Bitmap(320, 160), new Rectangle(0, 0, 320, 160));
        }

        private static void ValidateMoneyFlow()
        {
            long endMs = new DateTimeOffset(2026, 11, 11, 6, 0, 0, TimeSpan.Zero).ToUnixTimeMilliseconds();
            string fixture = MoneyFlowFixture(MoneyFlowRange.Days7, endMs, "600", "105");
            MoneyFlowSeries series = ParseMoneyFlow(fixture, MoneyFlowRange.Days7, endMs);
            if (series.EndMs - series.StartMs != 7 * DayMs || series.IntervalMs != 5 * MinuteMs ||
                series.Open.Length != 2016 || series.High.Length != 2016 || series.Low.Length != 2016 || series.Close.Length != 2016 ||
                series.QuoteDelta.Length != 2017 ||
                series.Open[0] != 100 || series.High[0] != 110 || series.Low[0] != 90 || series.Close[0] != 105)
                throw new InvalidOperationException("Money Flow did not build 2016 five-minute candles for the seven-day range.");
            if (series.QuoteDelta[0] != 0 || series.QuoteDelta[1] != 200 || series.QuoteDelta[2] != 400 ||
                series.QuoteDelta[10] != 2000 || series.QuoteDelta[2016] != 403200)
                throw new InvalidOperationException("Money Flow cumulative delta was not the exact running sum of USDT taker delta.");
            if (series.BuyVolume.Length != 2016 || series.SellVolume.Length != 2016 || series.BuyVolume[0] != 600 || series.SellVolume[0] != 400)
                throw new InvalidOperationException("Money Flow taker buy and sell volumes did not match the klines.");

            MoneyFlowSeries monthly = ParseMoneyFlow(MoneyFlowFixture(MoneyFlowRange.Days30, endMs, "600", "105"), MoneyFlowRange.Days30, endMs);
            if (monthly.EndMs - monthly.StartMs != 30 * DayMs || monthly.IntervalMs != 30 * MinuteMs ||
                monthly.Close.Length != 1440 || monthly.QuoteDelta.Length != 1441 || monthly.QuoteDelta[1440] != 288000)
                throw new InvalidOperationException("Money Flow did not build 1440 thirty-minute candles for the thirty-day range.");

            System.Text.RegularExpressions.Match first = System.Text.RegularExpressions.Regex.Match(fixture, KlineLinePattern);
            string[] invalid = new string[] {
                "[]", "{\"error\":\"unavailable\"}", fixture.Remove(first.Index, first.Length + 1),
                fixture.Insert(first.Index, "broken"),
                fixture.Replace(first.Value, first.Value.Replace("\"600\"", "\"1001\"")),
                fixture.Replace(first.Value, first.Value.Replace("\"110\"", "\"99\"")),
                fixture + "broken",
                MoneyFlowFixture(MoneyFlowRange.Days30, endMs, "600", "105")
            };
            foreach (string json in invalid)
            {
                bool rejected = false;
                try { ParseMoneyFlow(json, MoneyFlowRange.Days7, endMs); }
                catch (FormatException) { rejected = true; }
                if (!rejected) throw new InvalidOperationException("Incomplete or invalid Money Flow data appeared to succeed.");
            }
            System.Collections.Generic.List<long> days = MoneyFlowCanvas.DayBreaks(series.StartMs, series.EndMs);
            if (days.Count != 7 || days[0] != series.StartMs / DayMs * DayMs + DayMs ||
                MoneyFlowCanvas.DayBreaks(0, 7 * DayMs).Count != 6)
                throw new InvalidOperationException("Money Flow daily separators do not follow UTC midnight.");
            foreach (long day in days)
                if (day % DayMs != 0 || day <= series.StartMs || day >= series.EndMs)
                    throw new InvalidOperationException("Money Flow day separators are outside the seven-day range.");

            using (MoneyFlowCanvas canvas = new MoneyFlowCanvas())
            {
                canvas.Size = new Size(640, 340);
                canvas.SetSeries(series);
                using (Bitmap image = new Bitmap(canvas.Width, canvas.Height))
                {
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    Rectangle plot = canvas.PricePlotArea;
                    Rectangle buyPlot = canvas.BuyVolumePlotArea;
                    Rectangle sellPlot = canvas.SellVolumePlotArea;
                    Rectangle deltaPlot = canvas.DeltaPlotArea;
                    int black = 0, blue = 0, buy = 0, sell = 0;
                    for (int x = plot.Left + 1; x < plot.Right; x++)
                    {
                        for (int y = plot.Top + 1; y < plot.Bottom; y++)
                        {
                            Color pixel = image.GetPixel(x, y);
                            if (pixel.R < 60 && pixel.G < 60 && pixel.B < 60) black++;
                        }
                    }
                    for (int x = buyPlot.Left + 1; x < buyPlot.Right; x++)
                    {
                        for (int y = buyPlot.Top + 1; y < buyPlot.Bottom; y++)
                        {
                            Color pixel = image.GetPixel(x, y);
                            if (pixel.G > pixel.R + 30 && pixel.G > pixel.B + 20) buy++;
                        }
                    }
                    for (int x = sellPlot.Left + 1; x < sellPlot.Right; x++)
                    {
                        for (int y = sellPlot.Top + 1; y < sellPlot.Bottom; y++)
                        {
                            Color pixel = image.GetPixel(x, y);
                            if (pixel.R > pixel.G + 40 && pixel.R > pixel.B + 40) sell++;
                        }
                    }
                    for (int x = deltaPlot.Left + 1; x < deltaPlot.Right; x++)
                    {
                        for (int y = deltaPlot.Top + 1; y < deltaPlot.Bottom; y++)
                        {
                            Color pixel = image.GetPixel(x, y);
                            if (pixel.B > pixel.R + 40 && pixel.B > pixel.G + 20) blue++;
                        }
                    }
                    if (black < 50 || blue < 50) throw new InvalidOperationException("Money Flow did not render the candles and CVD line in their panes.");
                    if (buy < 50) throw new InvalidOperationException("Money Flow did not render buy volume bars in the buy volume pane.");
                    if (sell < 50) throw new InvalidOperationException("Money Flow did not render sell volume bars in the sell volume pane.");
                    foreach (long day in days)
                    {
                        int x = (int)Math.Round(deltaPlot.Left + (day - series.StartMs) / (double)(series.EndMs - series.StartMs) * deltaPlot.Width);
                        bool drawn = false;
                        for (int offset = -1; offset <= 1; offset++)
                            for (int y = deltaPlot.Top; y < deltaPlot.Bottom; y++)
                                if (image.GetPixel(x + offset, y).ToArgb() == MarketDeskStyle.BiasDividerColor.ToArgb()) drawn = true;
                        if (!drawn)
                            throw new InvalidOperationException("Money Flow did not draw a daily vertical separator.");
                    }

                    int hover = plot.Left + plot.Width / 2;
                    canvas.SetHoverX(hover);
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    int hoverPixels = 0;
                    for (int y = plot.Top; y < deltaPlot.Bottom; y++)
                        if (image.GetPixel(hover, y).ToArgb() == MoneyFlowCanvas.HoverColor.ToArgb()) hoverPixels++;
                    if (hoverPixels < 20)
                        throw new InvalidOperationException("Money Flow did not draw the dashed hover line.");
                }
                canvas.Size = new Size(120, 80);
                using (Bitmap image = new Bitmap(canvas.Width, canvas.Height)) canvas.DrawToBitmap(image, canvas.ClientRectangle);
                canvas.ShowMessage("Download failed");
                using (Bitmap image = new Bitmap(canvas.Width, canvas.Height)) canvas.DrawToBitmap(image, canvas.ClientRectangle);
            }
            using (MenuStrip menu = CreateMenu())
            {
                ToolStripMenuItem tools = (ToolStripMenuItem)menu.Items[4];
                bool found = false;
                foreach (ToolStripItem item in tools.DropDownItems) if (item.Text == "Money Flow") found = true;
                if (!found) throw new InvalidOperationException("Money Flow is missing from the Tools menu.");
            }
        }

        private static string MmdFixture(long endMs)
        {
            long startMs = endMs - MmdCandleCount * MmdIntervalMs;
            System.Collections.Generic.List<string> rows = new System.Collections.Generic.List<string>();
            for (int i = 0; i < MmdCandleCount; i++)
            {
                long time = startMs + i * MmdIntervalMs;
                string open = (100 + i * 0.05).ToString("0.########", System.Globalization.CultureInfo.InvariantCulture);
                string close = (100.5 + i * 0.05).ToString("0.########", System.Globalization.CultureInfo.InvariantCulture);
                string high = (101 + i * 0.05).ToString("0.########", System.Globalization.CultureInfo.InvariantCulture);
                string low = (99.5 + i * 0.05).ToString("0.########", System.Globalization.CultureInfo.InvariantCulture);
                rows.Add("[" + time.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    ",\"" + open + "\",\"" + high + "\",\"" + low + "\",\"" + close +
                    "\",\"10\"," + (time + MmdIntervalMs - 1).ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    ",\"100\",1,\"5\",\"60\",\"0\"]");
            }
            return "[" + string.Join(",", rows.ToArray()) + "]";
        }

        // Fixture: 2 wide bars set the price range 90-110, then a 57-bar band trades 99-101 with heavy volume,
        // bar 60 rallies into 99-101 and closes back at 98. Follow-through drops to 91 within 8 bars; flat does not.
        private static void ValidatePerpChart()
        {
            string json = "[[0,\"1.0\",\"2.0\",\"0.5\",\"1.5\",\"10\",59999,\"0\",1,\"0\",\"0\",\"0\"]," +
                "[60000,\"1.5\",\"2.5\",\"1.0\",\"2.0\",\"12\",119999,\"0\",1,\"0\",\"0\",\"0\"]," +
                "[120000,\"2.0\",\"3.0\",\"1.5\",\"2.5\",\"14\",179999,\"0\",1,\"0\",\"0\",\"0\"]]";
            System.Collections.Generic.List<PerpCandle> closed = ParsePerpCandles(json, MinuteMs);
            if (closed.Count != 3 || closed[2].Close != 2.5 || closed[2].Volume != 14)
                throw new InvalidOperationException("Perp chart did not keep the forming candle.");

            string gapped = json.Replace("60000,", "180000,");
            bool threw = false;
            try
            {
                ParsePerpCandles(gapped, MinuteMs);
            }
            catch (FormatException)
            {
                threw = true;
            }
            if (!threw) throw new InvalidOperationException("Perp chart accepted candles with a time gap.");
        }

        private static void ValidateVolumeProfile()
        {
            System.Collections.Generic.List<PerpCandle> candles = new System.Collections.Generic.List<PerpCandle>();
            candles.Add(new PerpCandle { Open = 1, High = 10, Low = 0, Close = 9, Volume = 10 });
            candles.Add(new PerpCandle { Open = 5.5, High = 6, Low = 5, Close = 5.2, Volume = 20 });
            PerpVolumeProfile profile = PerpVolumeProfile.Build(candles, 0, candles.Count, 10);
            if (Math.Abs(profile.TotalVolume - 30) > 1e-9 || profile.Poc != 5 || profile.ValueHigh != 5 || profile.ValueLow != 5)
                throw new InvalidOperationException("Volume profile did not place the POC or value area correctly.");
            if (Math.Abs(profile.Sell[5] - 20) > 1e-9 || Math.Abs(profile.Buy[5] - 1) > 1e-9)
                throw new InvalidOperationException("Volume profile did not split buy and sell volume.");

            candles.Add(new PerpCandle { Open = 6, High = 7, Low = 7, Close = 7, Volume = 4 });
            profile = PerpVolumeProfile.Build(candles, 0, candles.Count, 10);
            if (profile.Poc != 5 || profile.ValueHigh != 7 || profile.ValueLow != 5)
                throw new InvalidOperationException("Volume profile value area did not grow toward the larger neighbour.");

            System.Collections.Generic.List<PerpCandle> source = new System.Collections.Generic.List<PerpCandle>();
            for (int i = 0; i < 6; i++) source.Add(new PerpCandle { Time = i * 60000L });
            if (PerpChartCanvas.FirstIndexAtOrAfter(source, 120000) != 2 || PerpChartCanvas.FirstIndexAtOrAfter(source, 999999) != 6 ||
                PerpChartCanvas.FirstIndexAtOrAfter(source, -1) != 0)
                throw new InvalidOperationException("Source candle window lookup did not find the first candle at or after the time.");
            if (PerpProfileSourceInterval("15m") != "5m" || PerpProfileSourceInterval("1d") != "4h" ||
                PerpProfileSourceInterval("1m") != "1m")
                throw new InvalidOperationException("Profile source intervals do not match AMAT.");
            if (PerpTpoSourceInterval("5m") != "30m" || PerpTpoSourceInterval("1d") != "4h")
                throw new InvalidOperationException("TPO source intervals do not match AMAT.");
            System.Collections.Generic.List<PerpCandle> tpoSource = new System.Collections.Generic.List<PerpCandle>();
            tpoSource.Add(new PerpCandle { Time = 0, High = 101, Low = 100 });
            tpoSource.Add(new PerpCandle { Time = 60000L, High = 106, Low = 105 });
            tpoSource.Add(new PerpCandle { Time = 120000L, High = 110, Low = 109 });
            PerpTpoProfile tpo = PerpTpoProfile.Build(tpoSource, 60000L, 0L, 120000L, 300000L, 100, 110, 10);
            if (tpo.Loaded != 3 || tpo.Periods != 3 || tpo.Counts[0] != 1 || tpo.Counts[2] != 0 || tpo.Counts[9] != 1 ||
                tpo.VisibleHigh != 110 || tpo.VisibleLow != 100)
                throw new InvalidOperationException("TPO counts do not match the three-candle fixture.");
        }

        private static void ValidateVolumeRejections()
        {
            VolumeRejectionReport bearish = VolumeRejectionRules.Detect(VolumeRejectionFixture(69, true));
            VolumeRejectionReport bullish = VolumeRejectionRules.Detect(MirrorTradingViewSeries(VolumeRejectionFixture(69, true)));
            VolumeRejectionReport flat = VolumeRejectionRules.Detect(VolumeRejectionFixture(69, false));
            VolumeRejectionReport early = VolumeRejectionRules.Detect(VolumeRejectionFixture(65, true));
            if (bearish.Rejections.Count != 1 || !bearish.Rejections[0].Bearish || bearish.Rejections[0].Index != 60 ||
                bullish.Rejections.Count != 1 || bullish.Rejections[0].Bearish || bullish.Rejections[0].Index != 60 ||
                flat.Rejections.Count != 0 || early.Rejections.Count != 0)
            {
                throw new InvalidOperationException("Volume rejection markers did not match the hindsight rules.");
            }
        }

        private static TradingViewSeries VolumeRejectionFixture(int count, bool followThrough)
        {
            TradingViewSeries series = new TradingViewSeries();
            series.StartMs = 0;
            series.IntervalMs = TradingViewIntervalMs;
            series.Open = new double[count];
            series.High = new double[count];
            series.Low = new double[count];
            series.Close = new double[count];
            series.Volume = new double[count];
            SetFixtureBar(series, 0, 100, 110, 90, 100, 1);
            SetFixtureBar(series, 1, 100, 110, 90, 100, 1);
            for (int i = 2; i <= 58; i++) SetFixtureBar(series, i, 99.5, 101, 99, 100, 1000);
            SetFixtureBar(series, 59, 95, 96, 94, 95, 1);
            SetFixtureBar(series, 60, 97, 100.5, 96.5, 98, 1);
            for (int i = 61; i < count; i++)
            {
                if (followThrough) SetFixtureBar(series, i, 98, 98, 91, 92, 1);
                else SetFixtureBar(series, i, 98, 98, 98, 98, 1);
            }
            return series;
        }

        private static void SetFixtureBar(TradingViewSeries series, int index, double open, double high, double low, double close, double volume)
        {
            series.Open[index] = open;
            series.High[index] = high;
            series.Low[index] = low;
            series.Close[index] = close;
            series.Volume[index] = volume;
        }

        // Mirroring around 100 turns every rejection into the opposite side with the same volume profile.
        private static TradingViewSeries MirrorTradingViewSeries(TradingViewSeries source)
        {
            int count = source.Close.Length;
            TradingViewSeries result = new TradingViewSeries();
            result.StartMs = source.StartMs;
            result.IntervalMs = source.IntervalMs;
            result.Open = new double[count];
            result.High = new double[count];
            result.Low = new double[count];
            result.Close = new double[count];
            result.Volume = new double[count];
            for (int i = 0; i < count; i++)
            {
                SetFixtureBar(result, i, 200 - source.Open[i], 200 - source.Low[i], 200 - source.High[i], 200 - source.Close[i], source.Volume[i]);
            }
            return result;
        }

        private static void ValidateMmd()
        {
            long endMs = new DateTimeOffset(2026, 11, 11, 6, 0, 0, TimeSpan.Zero).ToUnixTimeMilliseconds();
            long startMs = endMs - MmdCandleCount * MmdIntervalMs;
            string fixture = MmdFixture(endMs);
            MmdMarketSeries ethSpot = ParseMmdMarket("ETH Spot", "ETHUSDT", "Spot", fixture, startMs, endMs);
            MmdMarketSeries ethPerp = ParseMmdMarket("ETH Perp", "ETHUSDT", "Perp", fixture, startMs, endMs);
            MmdMarketSeries btcSpot = ParseMmdMarket("BTC Spot", "BTCUSDT", "Spot", fixture, startMs, endMs);
            MmdMarketSeries btcPerp = ParseMmdMarket("BTC Perp", "BTCUSDT", "Perp", fixture, startMs, endMs);
            if (endMs - startMs != 30 * DayMs || ethSpot.Close.Length != MmdCandleCount ||
                ethPerp.Close.Length != MmdCandleCount || btcSpot.Close.Length != MmdCandleCount ||
                btcPerp.Close.Length != MmdCandleCount || ethSpot.IntervalMs != MmdIntervalMs ||
                ethSpot.PriceChangePercent[0] != 0 ||
                Math.Abs(ethSpot.PriceChangePercent[MmdCandleCount - 1] -
                    ((172.45 / 100.5 - 1) * 100)) > 0.0001)
            {
                throw new InvalidOperationException("MMD did not build the complete 30-day, 30-minute ETH/BTC series.");
            }
            if (ethSpot.QuoteDelta[0] != 20 || ethSpot.DeltaPercent[0] != 20 ||
                ethSpot.CumulativeQuoteDelta[MmdCandleCount - 1] != 28800 ||
                ethSpot.CumulativeDeltaPercent[MmdCandleCount - 1] != 20 ||
                ethSpot.VolumeVsAverage[20] != 1 || MmdRsi(ethPerp.Close) != 100)
            {
                throw new InvalidOperationException("MMD taker delta, CVD, relative volume or RSI calculation failed.");
            }

            System.Text.RegularExpressions.Match first = System.Text.RegularExpressions.Regex.Match(fixture, KlineLinePattern);
            string[] invalid = new string[] {
                "[]",
                fixture.Remove(first.Index, first.Length + 1),
                fixture.Insert(first.Index, "broken"),
                fixture.Replace(first.Value, first.Value.Replace("\"60\"", "\"101\"")),
                fixture + "broken"
            };
            foreach (string json in invalid)
            {
                bool rejected = false;
                try { ParseMmdMarket("ETH Spot", "ETHUSDT", "Spot", json, startMs, endMs); }
                catch (FormatException) { rejected = true; }
                if (!rejected) throw new InvalidOperationException("Incomplete or invalid MMD data appeared to succeed.");
            }

            MmdSeries series = new MmdSeries {
                StartMs = startMs,
                EndMs = endMs,
                IntervalMs = MmdIntervalMs,
                EthSpot = ethSpot,
                EthPerp = ethPerp,
                BtcSpot = btcSpot,
                BtcPerp = btcPerp
            };
            using (MmdCanvas canvas = new MmdCanvas())
            {
                canvas.Size = new Size(920, 800);
                canvas.SetSeries(series);
                using (Bitmap image = new Bitmap(canvas.Width, canvas.Height))
                {
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    if (canvas.PlotAreas.Length != 6)
                        throw new InvalidOperationException("MMD did not create all six chart panels.");
                    foreach (Rectangle plot in canvas.PlotAreas)
                    {
                        if (plot.Width < 40 || plot.Height < 10)
                            throw new InvalidOperationException("An MMD chart panel has no usable plot area.");
                    }
                    canvas.SetWindow(336);
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    canvas.SetWindow(96);
                    canvas.Pan(-1);
                    if (canvas.WindowStart != MmdCandleCount - 144 || canvas.WindowEnd != MmdCandleCount - 49)
                        throw new InvalidOperationException("MMD chart panning did not preserve the 2-day window.");
                    canvas.Pan(100);
                    if (canvas.WindowEnd != MmdCandleCount - 1 || canvas.WindowEnd - canvas.WindowStart != 95)
                        throw new InvalidOperationException("MMD chart panning exceeded the available candles.");
                    canvas.SetSignals(new System.Collections.Generic.List<MmdSignalEvent> {
                        new MmdSignalEvent { TimeMs = startMs + 50 * MmdIntervalMs, Pivot = 40, PreviousPivot = 20,
                            BtcPivot = 40, PreviousBtcPivot = 20, Bullish = true, Marker = "P" },
                        new MmdSignalEvent { TimeMs = startMs + 64 * MmdIntervalMs, Pivot = 60, PreviousPivot = 40,
                            Bullish = false, Marker = "S" },
                        new MmdSignalEvent { TimeMs = startMs + 84 * MmdIntervalMs, Pivot = 80, PreviousPivot = 60,
                            Bullish = true, Marker = "F" },
                        new MmdSignalEvent { TimeMs = startMs + 91 * MmdIntervalMs, Pivot = 90,
                            Bullish = false, Marker = "A" }
                    });
                    canvas.FocusSignal(startMs + 50 * MmdIntervalMs);
                    if (canvas.WindowStart != 0 || canvas.WindowEnd != 95)
                        throw new InvalidOperationException("MMD signal focus did not include the confirmation candle.");
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    canvas.SetFlowVisibility(true, false);
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    canvas.SetFlowVisibility(false, true);
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    canvas.SetFlowVisibility(true, true);
                    canvas.SetWindow(10);
                    canvas.Pan(-1440);
                    if (canvas.WindowStart != 0 || canvas.WindowEnd != 9)
                        throw new InvalidOperationException("MMD chart panning exceeded the first candle.");
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                    canvas.Size = new Size(140, 160);
                    canvas.DrawToBitmap(image, canvas.ClientRectangle);
                }
            }
            int last = MmdCandleCount - 1;
            if (Math.Abs(MmdRelativeChange(ethSpot, btcSpot, last, last)) > 0.0001)
                throw new InvalidOperationException("MMD equal-price relative strength was not zero.");
            btcSpot.Close[last] *= 1.1;
            double strongerBtcRelative = MmdRelativeChange(ethSpot, btcSpot, last, last);
            btcSpot.Close[last] /= 1.1;
            if (Math.Abs(strongerBtcRelative - ((1.0 / 1.1 - 1) * 100)) > 0.0001)
                throw new InvalidOperationException("MMD did not calculate the direction of ETH/BTC relative strength.");
            if (BuildMmdAnalysis(series).Bias != "MIXED / NO CLEAR ETH EDGE")
                throw new InvalidOperationException("MMD did not keep neutral relative performance in a mixed state.");
            double originalEthClose = ethPerp.Close[MmdCandleCount - 1];
            ethPerp.Close[MmdCandleCount - 1] = originalEthClose * 1.02;
            MmdAnalysis bullish = BuildMmdAnalysis(series);
            MmdSignalEvent strength = bullish.Events.Find(
                delegate(MmdSignalEvent item) { return item.Signal == "ETH strength period"; });
            if (bullish.Bias != "BULLISH FOR ETH vs BTC" || strength == null || strength.TimeMs != endMs)
                throw new InvalidOperationException("MMD did not mark and timestamp an ETH relative-strength period.");
            ethPerp.Close[MmdCandleCount - 1] = originalEthClose * 0.98;
            MmdAnalysis bearish = BuildMmdAnalysis(series);
            MmdSignalEvent weakness = bearish.Events.Find(
                delegate(MmdSignalEvent item) { return item.Signal == "ETH weakness period"; });
            if (bearish.Bias != "BEARISH FOR ETH vs BTC" || weakness == null || weakness.TimeMs != endMs)
                throw new InvalidOperationException("MMD did not mark and timestamp an ETH relative-weakness period.");
            ethPerp.Close[MmdCandleCount - 1] = originalEthClose;

            double[] eventEthLows = new double[60];
            double[] eventBtcLows = new double[60];
            double[] eventEthHighs = new double[60];
            double[] eventBtcHighs = new double[60];
            for (int i = 0; i < eventEthLows.Length; i++)
            {
                eventEthLows[i] = eventBtcLows[i] = eventEthHighs[i] = eventBtcHighs[i] = 10;
            }
            eventBtcLows[10] = 5;
            eventBtcLows[30] = 4;
            eventEthLows[10] = 5;
            eventEthLows[30] = 6;
            eventBtcHighs[10] = 15;
            eventBtcHighs[30] = 17;
            eventEthHighs[10] = 16;
            eventEthHighs[30] = 15;
            MmdSeries divergenceSeries = new MmdSeries {
                StartMs = startMs,
                EndMs = startMs + 60 * MmdIntervalMs,
                IntervalMs = MmdIntervalMs,
                EthPerp = new MmdMarketSeries { Low = eventEthLows, High = eventEthHighs },
                BtcPerp = new MmdMarketSeries { Low = eventBtcLows, High = eventBtcHighs }
            };
            System.Collections.Generic.List<MmdSignalEvent> bullishDivergences = FindMmdDivergences(divergenceSeries, true);
            System.Collections.Generic.List<MmdSignalEvent> bearishDivergences = FindMmdDivergences(divergenceSeries, false);
            if (bullishDivergences.Count != 1 || bearishDivergences.Count != 1 ||
                bullishDivergences[0].TimeMs != startMs + 40 * MmdIntervalMs ||
                bearishDivergences[0].TimeMs != startMs + 40 * MmdIntervalMs)
                throw new InvalidOperationException("MMD did not detect and timestamp bullish and bearish ETH/BTC swing divergences.");
            ValidateMmdOutcomesAndCausality(series, divergenceSeries);
            using (MenuStrip menu = CreateMenu())
            {
                ToolStripMenuItem tools = (ToolStripMenuItem)menu.Items[4];
                bool found = false;
                foreach (ToolStripItem item in tools.DropDownItems) if (item.Text == "MMD") found = true;
                if (!found) throw new InvalidOperationException("MMD is missing from the Tools menu.");
            }
        }

        private static void ValidateMmdOutcomesAndCausality(MmdSeries parsed, MmdSeries divergences)
        {
            double[] pressure = MmdCanvas.RollingPressure(parsed.EthSpot);
            double[] vwap = MmdCanvas.RollingVwap(parsed.EthSpot);
            if (!double.IsNaN(pressure[10]) || Math.Abs(pressure[11] - 20) > 0.00001 ||
                !double.IsNaN(vwap[46]) || double.IsNaN(vwap[47]))
                throw new InvalidOperationException("MMD rolling indicators did not respect their warmup windows.");
            double oldClose = parsed.EthSpot.Close[100];
            parsed.EthSpot.Close[100] *= 2;
            double[] changed = MmdCanvas.RollingVwap(parsed.EthSpot);
            parsed.EthSpot.Close[100] = oldClose;
            if (Math.Abs(vwap[99] - changed[99]) > 0.000001)
                throw new InvalidOperationException("MMD candle-VWAP used a future close.");

            MmdSeries prefix = new MmdSeries {
                StartMs = divergences.StartMs, EndMs = divergences.StartMs + 40 * MmdIntervalMs, IntervalMs = MmdIntervalMs,
                EthPerp = new MmdMarketSeries { Low = new double[40], High = new double[40] },
                BtcPerp = new MmdMarketSeries { Low = new double[40], High = new double[40] }
            };
            Array.Copy(divergences.EthPerp.Low, prefix.EthPerp.Low, 40);
            Array.Copy(divergences.EthPerp.High, prefix.EthPerp.High, 40);
            Array.Copy(divergences.BtcPerp.Low, prefix.BtcPerp.Low, 40);
            Array.Copy(divergences.BtcPerp.High, prefix.BtcPerp.High, 40);
            foreach (bool lows in new bool[] { true, false })
            {
                System.Collections.Generic.List<MmdSignalEvent> before = FindMmdDivergences(prefix, lows);
                System.Collections.Generic.List<MmdSignalEvent> after = FindMmdDivergences(divergences, lows);
                if (before.Count != 1 || after.Count != 1 || before[0].TimeMs != after[0].TimeMs ||
                    before[0].Pivot != after[0].Pivot)
                    throw new InvalidOperationException("MMD divergence changed after appending future candles.");
            }

            MmdMarketSeries flow = new MmdMarketSeries { CumulativeQuoteDelta = new double[60], QuoteVolume = new double[60] };
            for (int i = 0; i < 60; i++) { flow.CumulativeQuoteDelta[i] = i * 2; flow.QuoteVolume[i] = 100; }
            System.Collections.Generic.List<MmdSignalEvent> cvd = FindMmdCvdDivergences(divergences, flow, "Spot", "S", false);
            // The bearish fixture has a lower ETH high, so it must not be a bearish price/CVD divergence.
            if (cvd.Count != 0) throw new InvalidOperationException("MMD generated a CVD divergence without the required price pattern.");
            double oldLow = divergences.EthPerp.Low[30];
            divergences.EthPerp.Low[30] = 4;
            cvd = FindMmdCvdDivergences(divergences, flow, "Spot", "S", true);
            divergences.EthPerp.Low[30] = oldLow;
            if (cvd.Count != 1 || cvd[0].TimeMs != divergences.StartMs + 34 * MmdIntervalMs)
                throw new InvalidOperationException("MMD spot CVD divergence or its confirmation delay was incorrect.");
            double oldHigh = divergences.EthPerp.High[30];
            divergences.EthPerp.High[30] = 18;
            for (int i = 0; i < 60; i++) flow.CumulativeQuoteDelta[i] = -i * 2;
            cvd = FindMmdCvdDivergences(divergences, flow, "Perp", "F", false);
            divergences.EthPerp.High[30] = oldHigh;
            if (cvd.Count != 1 || cvd[0].Bullish || cvd[0].TimeMs != divergences.StartMs + 34 * MmdIntervalMs)
                throw new InvalidOperationException("MMD perpetual bearish CVD divergence was incorrect.");

            MmdMarketSeries absorption = new MmdMarketSeries {
                Open = new double[25], Close = new double[25], High = new double[25], Low = new double[25],
                VolumeVsAverage = new double[25], DeltaPercent = new double[25]
            };
            for (int i = 20; i < 24; i++)
            {
                absorption.Open[i] = 100;
                absorption.Close[i] = i == 21 ? 92 : 108;
                absorption.High[i] = 110;
                absorption.Low[i] = 90;
                absorption.VolumeVsAverage[i] = i == 22 ? 1.4 : 2;
                absorption.DeltaPercent[i] = i == 21 || i == 23 ? 20 : -20;
            }
            System.Collections.Generic.List<MmdSignalEvent> absorbed = FindMmdAbsorption(new MmdSeries {
                StartMs = 0, IntervalMs = MmdIntervalMs, EthPerp = absorption
            });
            if (absorbed.Count != 2 || !absorbed[0].Bullish || absorbed[1].Bullish ||
                absorbed[0].TimeMs != 21 * MmdIntervalMs || absorbed[1].TimeMs != 22 * MmdIntervalMs)
                throw new InvalidOperationException("MMD absorption ignored its volume, opposing-flow or confirmation rules.");

            MmdMarketSeries eth = new MmdMarketSeries {
                Open = new double[100], Close = new double[100], High = new double[100], Low = new double[100]
            };
            MmdMarketSeries btc = new MmdMarketSeries { Open = new double[100], Close = new double[100] };
            for (int i = 0; i < 100; i++)
            {
                eth.Open[i] = eth.Close[i] = btc.Open[i] = btc.Close[i] = 100;
                eth.High[i] = 101;
                eth.Low[i] = 99;
            }
            eth.Close[9] = 50; // The confirmation close must not be used as the next-open entry.
            eth.Close[21] = 110;
            btc.Close[21] = 105;
            eth.Low[10] = 90;
            eth.High[21] = 120;
            MmdSeries outcomes = new MmdSeries { StartMs = 0, EndMs = 100 * MmdIntervalMs,
                IntervalMs = MmdIntervalMs, EthPerp = eth, BtcPerp = btc };
            MmdSignalEvent signal = new MmdSignalEvent { TimeMs = 10 * MmdIntervalMs, Bullish = true, Signal = "Test" };
            MmdOutcome sample;
            if (!TryMmdOutcome(outcomes, signal, 12, out sample) || Math.Abs(sample.NetEthPercent - 9.9) > 0.000001 ||
                Math.Abs(sample.RelativePercent - ((110.0 / 105 - 1) * 100)) > 0.000001 ||
                Math.Abs(sample.AdversePercent + 10) > 0.000001 || sample.EntryIndex != 10 || sample.ExitIndex != 21)
                throw new InvalidOperationException("MMD next-open long outcome, costs, ratio return or MAE was incorrect.");
            signal.Bullish = false;
            if (!TryMmdOutcome(outcomes, signal, 12, out sample) || Math.Abs(sample.NetEthPercent + 10.1) > 0.000001 ||
                Math.Abs(sample.AdversePercent + 20) > 0.000001)
                throw new InvalidOperationException("MMD short outcome or adverse excursion was incorrect.");
            signal.Bullish = true;
            System.Collections.Generic.List<MmdSignalEvent> events = new System.Collections.Generic.List<MmdSignalEvent> {
                signal, new MmdSignalEvent { TimeMs = 11 * MmdIntervalMs, Bullish = true, Signal = "Test" },
                new MmdSignalEvent { TimeMs = 98 * MmdIntervalMs, Bullish = true, Signal = "Test" }
            };
            MmdOutcomeStats stats = BuildMmdOutcomes(outcomes, events)[0];
            if (stats.Samples.Count != 1 || stats.Overlapping != 1 || stats.Pending != 1 || stats.BaselineCount != 4)
                throw new InvalidOperationException("MMD outcome study did not exclude overlapping or unfinished outcomes.");
            using (ListView list = new ListView())
            {
                list.View = View.Details;
                PopulateMmdOutcomes(list, outcomes, events);
                if (list.Items.Count != 2 || list.Items[0].SubItems.Count != 12)
                    throw new InvalidOperationException("MMD did not present both outcome horizons and required statistics.");
            }
        }

        private static Form CreateForm()
        {
            Font font = new Font(MarketDeskStyle.FontName, MarketDeskStyle.FontSize);
            Form form = new Form();
            form.Text = MarketDeskStyle.WindowTitle;
            form.ClientSize = new Size(MarketDeskStyle.WindowWidth, MarketDeskStyle.WindowHeight);
            form.MinimumSize = new Size(1160, 560);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Font = font;
            form.BackColor = MarketDeskStyle.WindowBackground;

            MenuStrip menu = CreateMenu();
            StatusStrip status = CreateStatusStrip();
            Panel layout = CreateWorkspace();

            form.Controls.Add(layout);
            form.Controls.Add(status);
            form.Controls.Add(menu);
            form.MainMenuStrip = menu;
            currentFontName = MarketDeskStyle.FontName;
            currentFontSize = MarketDeskStyle.FontSize;
            ApplyFont(form, currentFontName, currentFontSize);
            StartPerformanceCounters(form, layout);
            return form;
        }

        // Counts workspace repaints (FPS) and RegisterTick() calls (ticks per second), refreshed once a second.
        private static void StartPerformanceCounters(Form form, Panel workspace)
        {
            frameCount = 0;
            tickCount = 0;
            workspace.Paint += delegate { frameCount++; };

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += delegate
            {
                fpsLabel.Text = "FPS: " + frameCount;
                ticksLabel.Text = "Ticks/s: " + tickCount;
                UpdateClocks();
                frameCount = 0;
                tickCount = 0;
            };
            form.Disposed += delegate { timer.Dispose(); };
            timer.Start();
        }

        // Shows the current New York time (follows daylight saving) and UTC time in the bottom right.
        private static void UpdateClocks()
        {
            DateTime utc = DateTime.UtcNow;
            TimeZoneInfo newYork = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime ny = TimeZoneInfo.ConvertTimeFromUtc(utc, newYork);
            nyClockLabel.Text = " NYSE " + ny.ToString("HH:mm:ss") + " ";
            utcClockLabel.Text = " UTC " + utc.ToString("HH:mm:ss") + " ";
        }

        private static ToolStripStatusLabel CreateClockLabel(Color textColor, Padding margin)
        {
            ToolStripStatusLabel label = new ToolStripStatusLabel();
            label.ForeColor = textColor;
            label.Margin = margin;
            return label;
        }

        // Call this once every time your data feed delivers an update. It drives the "Ticks/s" number.
        public static void RegisterTick()
        {
            tickCount++;
        }

        private static MenuStrip CreateMenu()
        {
            MenuStrip menu = new MenuStrip();
            menu.Renderer = new MarketDeskMenuRenderer();
            menu.BackColor = MarketDeskStyle.MenuBarBackground;
            menu.ForeColor = MarketDeskStyle.MenuText;

            ToolStripMenuItem file = AddMenu(menu, "File");
            AddCommand(file, "Save Layout", delegate { SetStatus("Layout save is not implemented in this demo."); });
            AddCommand(file, "Exit", delegate
            {
                Form form = menu.FindForm();
                if (form != null)
                {
                    form.Close();
                }
            });

            ToolStripMenuItem tools = AddMenu(menu, "Tools");
            AddCommand(tools, "Bias Checklist", delegate { OpenBiasChecklist(); });
            AddCommand(tools, "Candle Data", delegate { OpenCandleData(); });
            AddCommand(tools, "Data Chart", delegate { OpenDataChart(); });
            AddCommand(tools, "Money Flow", delegate { OpenMoneyFlow(); });
            AddCommand(tools, "MMD", delegate { OpenMmd(); });
            AddCommand(tools, "Order Book Delta", delegate { OpenOrderBookDelta(); });
            AddCommand(tools, "TradingView Chart", delegate { OpenTradingView(); });
            AddCommand(tools, "Perp Chart", delegate { OpenPerpChart(); });
            AddCommand(tools, "Alerts", delegate { SetStatus("Alerts are not implemented in this demo."); });
            AddCommand(tools, "Calculator", delegate { SetStatus("Calculator is not implemented in this demo."); });

            ToolStripMenuItem globalMenu = AddMenu(menu, "Global");
            ToolStripMenuItem fontMenu = new ToolStripMenuItem("Font");
            globalMenu.DropDownItems.Add(fontMenu);
            foreach (string name in MarketDeskStyle.FontChoices)
            {
                string fontName = name;
                AddCommand(fontMenu, fontName, delegate { ApplyFont(menu.FindForm(), fontName, currentFontSize); });
            }

            ToolStripMenuItem sizeMenu = new ToolStripMenuItem("Text Size");
            globalMenu.DropDownItems.Add(sizeMenu);
            foreach (float choice in MarketDeskStyle.FontSizeChoices)
            {
                float size = choice;
                AddCommand(sizeMenu, size.ToString(), delegate { ApplyFont(menu.FindForm(), currentFontName, size); });
            }

            ToolStripMenuItem bottomBarMenu = new ToolStripMenuItem("Bottom Bar");
            globalMenu.DropDownItems.Add(bottomBarMenu);

            // One item that flips between "Hide" and "Show" depending on whether the bar is visible.
            ToolStripMenuItem toggleBar = new ToolStripMenuItem("Hide");
            toggleBar.Click += delegate
            {
                statusStrip.Visible = !statusStrip.Visible;
                toggleBar.Text = statusStrip.Visible ? "Hide" : "Show";
            };
            bottomBarMenu.DropDownItems.Add(toggleBar);
            bottomBarMenu.DropDownItems.Add(new ToolStripSeparator());
            AddCommand(bottomBarMenu, "White", delegate { statusStrip.BackColor = Color.White; });
            AddCommand(bottomBarMenu, "Default", delegate { statusStrip.BackColor = SystemColors.Control; });
            globalMenu.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem darkModeItem = new ToolStripMenuItem("Dark Mode");
            darkModeItem.Checked = darkMode;
            darkModeItem.Click += delegate
            {
                SetDarkMode(!darkMode, menu.FindForm());
                darkModeItem.Checked = darkMode;
            };
            globalMenu.DropDownItems.Add(darkModeItem);
            globalMenu.DropDownItems.Add(new ToolStripSeparator());

            // Picks the look of the dropdowns inside tiles. The names are listed in MarketDeskStyle.TileDropdownLooks.
            ToolStripMenuItem tileDropdownMenu = new ToolStripMenuItem("Tile Dropdowns");
            globalMenu.DropDownItems.Add(tileDropdownMenu);
            for (int look = 0; look < MarketDeskStyle.TileDropdownLooks.Length; look++)
            {
                int chosen = look;
                ToolStripMenuItem lookItem = new ToolStripMenuItem(MarketDeskStyle.TileDropdownLooks[look]);
                lookItem.Checked = look == tileDropdownLook;
                lookItem.Click += delegate
                {
                    SetTileDropdownLook(chosen);
                    foreach (ToolStripMenuItem other in tileDropdownMenu.DropDownItems)
                    {
                        other.Checked = other == lookItem;
                    }
                };
                tileDropdownMenu.DropDownItems.Add(lookItem);
            }

            // Picks the look of the buttons inside tiles. The names are listed in MarketDeskStyle.TileButtonLooks.
            ToolStripMenuItem tileButtonMenu = new ToolStripMenuItem("Tile Buttons");
            globalMenu.DropDownItems.Add(tileButtonMenu);
            for (int look = 0; look < MarketDeskStyle.TileButtonLooks.Length; look++)
            {
                int chosen = look;
                ToolStripMenuItem lookItem = new ToolStripMenuItem(MarketDeskStyle.TileButtonLooks[look]);
                lookItem.Checked = look == tileButtonLook;
                lookItem.Click += delegate
                {
                    SetTileButtonLook(chosen);
                    foreach (ToolStripMenuItem other in tileButtonMenu.DropDownItems)
                    {
                        other.Checked = other == lookItem;
                    }
                };
                tileButtonMenu.DropDownItems.Add(lookItem);
            }

            // Compact or Normal spacing for the tiles. The names are listed in MarketDeskStyle.TileSizes.
            ToolStripMenuItem tileSizeMenu = new ToolStripMenuItem("Tile Size");
            globalMenu.DropDownItems.Add(tileSizeMenu);
            for (int size = 0; size < MarketDeskStyle.TileSizes.Length; size++)
            {
                bool compact = size == 1;
                ToolStripMenuItem sizeItem = new ToolStripMenuItem(MarketDeskStyle.TileSizes[size]);
                sizeItem.Checked = compact == MarketDeskStyle.CompactTiles;
                sizeItem.Click += delegate
                {
                    SetTileSize(compact);
                    foreach (ToolStripMenuItem other in tileSizeMenu.DropDownItems)
                    {
                        other.Checked = other == sizeItem;
                    }
                };
                tileSizeMenu.DropDownItems.Add(sizeItem);
            }

            // Bottom Bar or Title Fill for the progress shown while a tile loads. The names are listed in MarketDeskStyle.TileLoadingStyles.
            ToolStripMenuItem loadingMenu = new ToolStripMenuItem("Loading Bar");
            globalMenu.DropDownItems.Add(loadingMenu);
            for (int style = 0; style < MarketDeskStyle.TileLoadingStyles.Length; style++)
            {
                int chosen = style;
                ToolStripMenuItem styleItem = new ToolStripMenuItem(MarketDeskStyle.TileLoadingStyles[style]);
                styleItem.Checked = style == MarketDeskStyle.TileLoadingStyle;
                styleItem.Click += delegate
                {
                    SetTileLoadingStyle(chosen);
                    foreach (ToolStripMenuItem other in loadingMenu.DropDownItems)
                    {
                        other.Checked = other == styleItem;
                    }
                };
                loadingMenu.DropDownItems.Add(styleItem);
            }

            foreach (ToolStripItem item in menu.Items)
            {
                ToolStripMenuItem menuItem = item as ToolStripMenuItem;
                if (menuItem != null)
                {
                    menuItem.Padding = MarketDeskStyle.MenuItemPadding;
                    StyleDropDown(menuItem, menu.Renderer);
                }
            }

            menu.Dock = DockStyle.Top;
            return menu;
        }

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int value, int size);

        [System.Runtime.InteropServices.DllImport("uxtheme.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string subAppName, string subIdList);

        // Makes a dropdown inside a tile use the look chosen in Global > Tile Dropdowns.
        private static void ApplyDropdownLook(MarketDeskComboBox combo)
        {
            combo.FlatStyle = FlatStyle.Standard;
            int look = combo.FollowButtonLook ? tileButtonLook : tileDropdownLook;
            combo.Look = look;
            if (combo.IsHandleCreated)
            {
                // Old uses the classic theme; New uses the current Windows theme.
                if (look == 0)
                {
                    SetWindowTheme(combo.Handle, "", "");
                }
                else
                {
                    SetWindowTheme(combo.Handle, null, null);
                }
            }
            combo.Invalidate();
        }

        // Tile dropdowns register here so Global > Tile Dropdowns can switch them all at once.
        private static void UseTileDropdownLook(MarketDeskComboBox combo)
        {
            tileDropdowns.Add(combo);
            combo.HandleCreated += delegate { ApplyDropdownLook(combo); };
            combo.Disposed += delegate { tileDropdowns.Remove(combo); };
            ApplyDropdownLook(combo);
        }

        private static void SetTileDropdownLook(int look)
        {
            tileDropdownLook = look;
            foreach (MarketDeskComboBox combo in tileDropdowns.ToArray())
            {
                ApplyDropdownLook(combo);
            }
        }

        // Tile buttons register here so Global > Tile Buttons can switch them all at once.
        private static void UseTileButtonLook(MarketDeskButton button)
        {
            tileButtons.Add(button);
            button.Disposed += delegate { tileButtons.Remove(button); };
            button.Classic = tileButtonLook == 0;
        }

        // Tiles register a layout function here so Global > Tile Size can re-space them all at once.
        private static readonly System.Collections.Generic.List<Action> tileSizeAppliers = new System.Collections.Generic.List<Action>();

        // Tiles that set their own fonts register here so Global > Font and text size reach them.
        private static readonly System.Collections.Generic.List<Action> tileFontAppliers = new System.Collections.Generic.List<Action>();

        private static void SetDarkMode(bool enabled, Form form)
        {
            darkMode = enabled;
            ApplyDarkMode(form);
        }

        // Colors the window chrome only: form, menu bar, status bar and workspace.
        private static void ApplyDarkMode(Form form)
        {
            Color windowColor = darkMode ? Color.FromArgb(32, 33, 36) : MarketDeskStyle.WindowBackground;
            Color barColor = darkMode ? Color.FromArgb(45, 46, 50) : MarketDeskStyle.MenuBarBackground;
            Color textColor = darkMode ? Color.Gainsboro : MarketDeskStyle.MenuText;
            Color statusColor = darkMode ? Color.FromArgb(45, 46, 50) : MarketDeskStyle.StatusBarBackground;

            form.BackColor = windowColor;
            foreach (Control control in form.Controls)
            {
                if (control is MenuStrip)
                {
                    control.BackColor = barColor;
                    control.ForeColor = textColor;
                }
                else if (control is StatusStrip)
                {
                    control.BackColor = statusColor;
                    control.ForeColor = textColor;
                }
                else if (control is Panel)
                {
                    control.BackColor = windowColor;
                }
            }
        }

        private static void SetTileSize(bool compact)
        {
            MarketDeskStyle.CompactTiles = compact;
            foreach (Action apply in tileSizeAppliers.ToArray())
            {
                apply();
            }
        }

        private static void SetTileLoadingStyle(int style)
        {
            MarketDeskStyle.TileLoadingStyle = style;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Invalidate(true);
            }
        }

        private static void SetTileButtonLook(int look)
        {
            tileButtonLook = look;
            foreach (MarketDeskButton button in tileButtons.ToArray())
            {
                button.Classic = look == 0;
            }
            foreach (MarketDeskComboBox combo in tileDropdowns.ToArray())
            {
                if (combo.FollowButtonLook) ApplyDropdownLook(combo);
            }
        }

        // Asks Windows 11 to round the window corners (ignored on Windows 10).
        private static void RoundCorners(IntPtr handle)
        {
            int round = MarketDeskStyle.SmallDropdownCorners ? 3 : 2; // 3 = small, 2 = normal
            try { DwmSetWindowAttribute(handle, 33, ref round, 4); } catch (Exception) { }
        }

        // Styles a dropdown and any submenus inside it (like Global > Font).
        private static void StyleDropDown(ToolStripMenuItem menuItem, ToolStripRenderer renderer)
        {
            menuItem.DropDown.Renderer = renderer;
            ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = MarketDeskStyle.ShowIconColumn;
            menuItem.DropDown.BackColor = MarketDeskStyle.DropdownBackground;
            menuItem.DropDown.DropShadowEnabled = MarketDeskStyle.ShowDropdownShadow;
            if (MarketDeskStyle.UseWindows11Dropdowns)
            {
                ToolStripDropDown dropDown = menuItem.DropDown;
                // Windows draws its own shadow and border once the corners are rounded.
                dropDown.DropShadowEnabled = false;
                dropDown.HandleCreated += delegate { RoundCorners(dropDown.Handle); };
                if (dropDown.IsHandleCreated)
                {
                    RoundCorners(dropDown.Handle);
                }
            }
            foreach (ToolStripItem dropdownItem in menuItem.DropDownItems)
            {
                Padding rowPadding = MarketDeskStyle.MenuItemPadding;
                dropdownItem.Padding = new Padding(rowPadding.Left, rowPadding.Top, MarketDeskStyle.TextRightPadding, rowPadding.Bottom);
                ToolStripMenuItem subMenu = dropdownItem as ToolStripMenuItem;
                if (subMenu != null && subMenu.HasDropDownItems)
                {
                    StyleDropDown(subMenu, renderer);
                    // Windows places the popout using the row width, so make the parent dropdown that wide to close the gap.
                    menuItem.DropDownOpening += delegate
                    {
                        ToolStripDropDown parent = subMenu.Owner as ToolStripDropDown;
                        if (parent != null)
                        {
                            // Let the dropdown re-measure itself first, otherwise a text size change leaves it too small or too wide.
                            parent.AutoSize = true;
                            parent.PerformLayout();
                            int width = subMenu.Bounds.Right + parent.Padding.Right + MarketDeskStyle.SubmenuGap;
                            parent.AutoSize = false;
                            parent.Width = width;
                        }
                    };
                }
            }
        }

        // Changes the font of the whole interface (menus, dropdowns and bottom bar).
        private static void ApplyFont(Form form, string fontName, float fontSize)
        {
            if (form == null)
            {
                return;
            }

            currentFontName = fontName;
            currentFontSize = fontSize;
            Font font = new Font(fontName, fontSize);
            form.Font = font;
            foreach (Control control in form.Controls)
            {
                ToolStrip strip = control as ToolStrip;
                if (strip != null)
                {
                    strip.Font = font;
                    foreach (ToolStripItem item in strip.Items)
                    {
                        SetItemFont(item, font);
                    }
                }
            }

            dataText.Font = new Font(fontName, fontSize, FontStyle.Bold);
            foreach (Action apply in tileFontAppliers.ToArray())
            {
                apply();
            }
        }

        private static void SetItemFont(ToolStripItem item, Font font)
        {
            item.Font = font;
            ToolStripMenuItem menuItem = item as ToolStripMenuItem;
            if (menuItem != null)
            {
                foreach (ToolStripItem child in menuItem.DropDownItems)
                {
                    SetItemFont(child, font);
                }
            }
        }

        private static ToolStripMenuItem AddMenu(MenuStrip menu, string text)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text);
            menu.Items.Add(item);
            return item;
        }

        private static void AddCommand(ToolStripMenuItem parent, string text, Action action)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text);
            item.Click += delegate { action(); };
            parent.DropDownItems.Add(item);
        }

        private static StatusStrip CreateStatusStrip()
        {
            StatusStrip status = new StatusStrip();
            statusStrip = status;
            status.Dock = DockStyle.Bottom;
            status.BackColor = MarketDeskStyle.StatusBarBackground;

            // Data connection indicator (far left). Change it with SetDataConnected(true/false).
            dataDot = new MarketDeskStatusDot("\u25CF");
            dataDot.Margin = MarketDeskStyle.StatusDotPadding;
            dataText = new ToolStripStatusLabel();
            dataText.Font = new Font(MarketDeskStyle.FontName, MarketDeskStyle.FontSize, FontStyle.Bold);
            status.Items.Add(dataDot);
            status.Items.Add(dataText);
            SetDataConnected(false);

            // Redraws the dot about 30 times a second so its ring fades smoothly.
            Timer pulseTimer = new Timer();
            pulseTimer.Interval = 33;
            pulseTimer.Tick += delegate { dataDot.Invalidate(); };
            status.Disposed += delegate { pulseTimer.Dispose(); };
            pulseTimer.Start();
            status.Items.Add(MakeDivider());

            statusLabel = new ToolStripStatusLabel("Version 1.0");
            statusLabel.ForeColor = Color.FromArgb(120, 120, 120);
            status.Items.Add(statusLabel);

            status.Items.Add(MakeDivider());
            fpsLabel = new ToolStripStatusLabel("FPS: 0");
            fpsLabel.ForeColor = Color.FromArgb(120, 120, 120);
            status.Items.Add(fpsLabel);

            status.Items.Add(MakeDivider());
            ticksLabel = new ToolStripStatusLabel("Ticks/s: 0");
            ticksLabel.ForeColor = Color.FromArgb(120, 120, 120);
            status.Items.Add(ticksLabel);

            // Empty label that stretches, pushing the clocks to the right corner.
            ToolStripStatusLabel spacer = new ToolStripStatusLabel();
            spacer.Spring = true;
            status.Items.Add(spacer);

            // NY time, separator and UTC time, placed side by side.
            nyClockLabel = CreateClockLabel(MarketDeskStyle.ClockText, new Padding(0, 4, 0, 3));
            clockSeparatorLabel = CreateClockLabel(MarketDeskStyle.ClockSeparator, new Padding(0, 4, 0, 3));
            clockSeparatorLabel.Text = "|";
            utcClockLabel = CreateClockLabel(MarketDeskStyle.ClockText, new Padding(0, 4, MarketDeskStyle.ClockRightMargin, 3));
            status.Items.Add(nyClockLabel);
            status.Items.Add(clockSeparatorLabel);
            status.Items.Add(utcClockLabel);
            UpdateClocks();
            return status;
        }

        // Divider drawn as a plain "|" character. Change the text or Margin (left, top, right, bottom) to adjust.
        private static ToolStripStatusLabel MakeDivider()
        {
            ToolStripStatusLabel divider = new ToolStripStatusLabel("|");
            divider.ForeColor = Color.FromArgb(180, 180, 180);
            divider.Margin = new Padding(6, 3, 6, 2);
            return divider;
        }

        private static Panel CreateWorkspace()
        {
            MarketDeskWorkspace layout = new MarketDeskWorkspace();
            layout.Name = "Workspace";
            layout.Dock = DockStyle.Fill;
            layout.BackColor = MarketDeskStyle.WorkspaceBackground;
            workspacePanel = layout;
            // Clicking the empty grey area deselects the tile.
            layout.MouseDown += delegate { MarketDeskTile.ClearSelection(); };
            return layout;
        }

        // Opens the Bias Checklist window in the first free space, starting from the top left corner.
        private static void OpenBiasChecklist()
        {
            if (biasChecklistWindow != null && !biasChecklistWindow.IsDisposed)
            {
                biasChecklistWindow.SelectTile();
                return;
            }

            Size size = new Size(MarketDeskStyle.ToolWindowWidth, MarketDeskStyle.ToolWindowHeight);
            biasChecklistWindow = CreateToolWindow("Bias Checklist", size, FindSpot(size));
            BuildBiasChecklist(biasChecklistWindow, null);
            workspacePanel.Controls.Add(biasChecklistWindow);
            biasChecklistWindow.SelectTile();
        }

        // Fills the Bias Checklist tile with one row per question in MarketDeskStyle.BiasQuestions:
        // the question with a standard dropdown beside it. Uses the global font.
        // Data format (saved with the tile): comma separated answer numbers, then ";" and True if Calculate was shown, then ";" and False if Confirm is hidden.
        private static void BuildBiasChecklist(MarketDeskTile tile, string data)
        {
            string[] dataParts = (data ?? string.Empty).Split(';');
            string[] savedAnswers = dataParts[0].Length == 0 ? new string[0] : dataParts[0].Split(',');
            bool calculated = dataParts.Length > 1 && dataParts[1] == "True";
            bool showConfirm = dataParts.Length < 3 || dataParts[2] != "False";

            string[][] questions = MarketDeskStyle.BiasQuestions;
            ComboBox[] combos = new ComboBox[questions.Length];
            // Group indices control display order; saved answers and scores retain their original question indices.
            int[][] questionGroups = new int[][]
            {
                new int[] { 0, 19, 20, 21, 1, 22, 2, 3, 4, 18 },
                new int[] { 12, 11, 10, 9, 8, 7, 16, 15 },
                new int[] { 5, 13, 14, 17, 6 }
            };
            string[] groupTitles = { "Class A", "Class B", "Class C" };
            // Each dropdown change is recorded (dropdown index, previous answer) so Undo can step back one answer at a time.
            System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<int, int>> undoSteps = new System.Collections.Generic.Stack<System.Collections.Generic.KeyValuePair<int, int>>();
            bool undoing = false;

            Panel rows = new Panel();
            rows.Dock = DockStyle.Fill;
            rows.AutoScroll = true;
            rows.Padding = new Padding(0, MarketDeskStyle.TileTitleGap, 0, 0);
            Label[] labels = new Label[questions.Length];
            Label[] headings = new Label[questionGroups.Length];

            Panel[] rowPanels = new Panel[questions.Length];
            for (int groupIndex = 0; groupIndex < questionGroups.Length; groupIndex++)
            {
                Label heading = new Label();
                heading.Text = groupTitles[groupIndex];
                heading.AutoSize = false;
                heading.Dock = DockStyle.Top;
                heading.Height = 26;
                heading.Padding = new Padding(4, 0, 4, 0);
                heading.TextAlign = ContentAlignment.MiddleLeft;
                headings[groupIndex] = heading;
                rows.Controls.Add(heading);
                heading.BringToFront();

                foreach (int i in questionGroups[groupIndex])
                {
                    Label question = new Label();
                    question.Text = questions[i][0];
                    question.AutoSize = false;
                    question.Dock = DockStyle.Left;
                    question.TextAlign = ContentAlignment.MiddleLeft;

                    MarketDeskComboBox combo = new MarketDeskComboBox();
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                    combo.Items.Add("-");
                    for (int o = 1; o < questions[i].Length; o++)
                    {
                        combo.Items.Add(questions[i][o]);
                    }
                    int savedAnswer;
                    if (i < savedAnswers.Length && int.TryParse(savedAnswers[i], out savedAnswer) && savedAnswer >= 0 && savedAnswer < combo.Items.Count)
                    {
                        combo.SelectedIndex = savedAnswer;
                    }
                    else
                    {
                        combo.SelectedIndex = 0;
                    }
                    combo.Dock = DockStyle.Fill;
                    UseTileDropdownLook(combo);

                    Panel row = new Panel();
                    row.Dock = DockStyle.Top;
                    row.Padding = new Padding(4, MarketDeskStyle.CompactTiles ? 1 : 3, 4, MarketDeskStyle.CompactTiles ? 1 : 3);
                    row.Height = combo.Height + MarketDeskStyle.BiasRowGap;
                    rowPanels[i] = row;
                    // The dropdown sits in a 1px-padded wrapper so its focus border is drawn on the wrapper, not covered by neighbours.
                    Panel wrap = new Panel();
                    wrap.Dock = DockStyle.Fill;
                    wrap.Padding = new Padding(1);
                    wrap.Controls.Add(combo);
                    row.Controls.Add(wrap);
                    row.Controls.Add(question);

                    labels[i] = question;
                    combos[i] = combo;
                    rows.Controls.Add(row);
                    row.BringToFront();
                }
            }

            // Every question label gets the width of the longest one, so the dropdowns line up.
            // Class titles use the question font, in bold, so they follow Global > Font changes.
            // Only the bold font made here is disposed; a label's inherited font belongs to its parent.
            Font headingFont = null;
            rows.Disposed += delegate { if (headingFont != null) headingFont.Dispose(); };
            rows.Layout += delegate
            {
                Font questionFont = labels[0].Font;
                if (headingFont == null || !headingFont.FontFamily.Equals(questionFont.FontFamily) || headingFont.Size != questionFont.Size)
                {
                    Font previousHeadingFont = headingFont;
                    headingFont = new Font(questionFont, FontStyle.Bold);
                    foreach (Label heading in headings)
                    {
                        heading.Font = headingFont;
                    }
                    if (previousHeadingFont != null) previousHeadingFont.Dispose();
                }
                int widest = 0;
                foreach (Label label in labels)
                {
                    widest = Math.Max(widest, TextRenderer.MeasureText(label.Text, label.Font).Width);
                }
                foreach (Label label in labels)
                {
                    label.Width = widest + 8;
                }
            };

            MarketDeskButton clear = new MarketDeskButton();
            UseTileButtonLook(clear);
            clear.Text = "Clear All";
            clear.Click += delegate
            {
                for (int i = 0; i < combos.Length; i++)
                {
                    combos[i].SelectedIndex = 0;
                }
                undoSteps.Clear();
            };

            // Holder that keeps the buttons away from the tile edges (MarketDeskStyle.TileButtonPadding).
            Panel clearHolder = new Panel();
            clearHolder.Dock = DockStyle.Bottom;
            clearHolder.Padding = MarketDeskStyle.TileButtonPadding;
            clearHolder.Height = MarketDeskStyle.TileButtonHeight + MarketDeskStyle.TileButtonPadding.Top + MarketDeskStyle.TileButtonPadding.Bottom;

            // Calculate and Confirm sit to the right of Clear All. The three buttons share the width equally.
            MarketDeskButton calculate = new MarketDeskButton();
            UseTileButtonLook(calculate);
            calculate.Text = "Calculate";

            MarketDeskButton confirm = new MarketDeskButton();
            UseTileButtonLook(confirm);
            confirm.Text = "Confirm";

            // Locked after Confirm: the button reads Locked, stays green, and the dropdowns are disabled.
            // Clear All and Undo unlock again.
            Action<bool> setLocked = delegate(bool locked)
            {
                confirm.Highlighted = locked;
                confirm.Text = locked ? "Locked" : "Confirm";
                foreach (ComboBox combo in combos)
                {
                    combo.Enabled = !locked;
                }
            };
            confirm.Click += delegate { setLocked(true); };

            // Steps back one dropdown answer. Also unlocks, since the answers changed.
            // Three versions with different arrow icons, so one can be picked.
            EventHandler undoClick = delegate
            {
                if (undoSteps.Count == 0)
                {
                    return;
                }
                System.Collections.Generic.KeyValuePair<int, int> step = undoSteps.Pop();
                undoing = true;
                combos[step.Key].SelectedIndex = step.Value;
                undoing = false;
                setLocked(false);
            };
            MarketDeskButton undo = new MarketDeskButton();
            UseTileButtonLook(undo);
            undo.Text = "Undo";
            undo.Click += undoClick;
            for (int i = 0; i < combos.Length; i++)
            {
                int row = i;
                int previous = combos[i].SelectedIndex;
                combos[i].SelectedIndexChanged += delegate
                {
                    if (!undoing)
                    {
                        undoSteps.Push(new System.Collections.Generic.KeyValuePair<int, int>(row, previous));
                    }
                    previous = combos[row].SelectedIndex;
                };
            }

            Action layoutButtons = delegate
            {
                Padding pad = clearHolder.Padding;
                int gap = 8;
                int height = Math.Max(0, clearHolder.ClientSize.Height - pad.Vertical);
                int width = Math.Max(0, clearHolder.ClientSize.Width - pad.Horizontal);
                // Undo, Clear All and Calculate share the row equally. Confirm joins them when it is shown.
                int buttonCount = confirm.Visible ? 4 : 3;
                int buttonWidth = Math.Max(0, (width - gap * (buttonCount - 1)) / buttonCount);
                int x = pad.Left;
                undo.SetBounds(x, pad.Top, buttonWidth, height);
                x += buttonWidth + gap;
                clear.SetBounds(x, pad.Top, buttonWidth, height);
                x += buttonWidth + gap;
                if (confirm.Visible)
                {
                    calculate.SetBounds(x, pad.Top, buttonWidth, height);
                    x += buttonWidth + gap;
                    confirm.SetBounds(x, pad.Top, Math.Max(0, pad.Left + width - x), height);
                }
                else
                {
                    calculate.SetBounds(x, pad.Top, Math.Max(0, pad.Left + width - x), height);
                }
            };
            clearHolder.Resize += delegate { layoutButtons(); };

            // Called from the Bias Checklist settings. Hiding Confirm also unlocks the answers.
            Action<bool> setConfirmVisible = delegate(bool visible)
            {
                if (showConfirm == visible)
                {
                    return;
                }
                showConfirm = visible;
                if (!visible)
                {
                    setLocked(false);
                }
                confirm.Visible = visible;
                layoutButtons();
                SaveTiles();
            };
            tile.SettingsViewFactory = delegate
            {
                return new BiasChecklistTileSettingsView(tile, showConfirm, setConfirmVisible);
            };

            clearHolder.Controls.Add(undo);
            confirm.Visible = showConfirm;
            clearHolder.Controls.Add(clear);
            clearHolder.Controls.Add(calculate);
            clearHolder.Controls.Add(confirm);
            layoutButtons();

            // Hidden until Calculate is pressed. Sits just above the buttons.
            MarketDeskBiasBar biasBar = new MarketDeskBiasBar();
            biasBar.Dock = DockStyle.Bottom;
            biasBar.Height = MarketDeskStyle.BiasBarHeight + MarketDeskStyle.BiasReportHeight;
            biasBar.Visible = false;

            calculate.Click += delegate
            {
                // Each chosen answer adds its point from MarketDeskStyle.BiasScores. Neutral-type answers add 0.5.
                // The loading bar follows the questions as they are scored.
                tile.BeginBusy();
                try
                {
                    double bear = 0;
                    double bull = 0;
                    double neutral = 0;
                    for (int i = 0; i < combos.Length; i++)
                    {
                        int index = combos[i].SelectedIndex - 1;
                        if (index >= 0)
                        {
                            double points = MarketDeskStyle.BiasScores[i][index];
                            if (points == MarketDeskStyle.BiasNeutralPoints) neutral += points;
                            else if (points > 0) bull += points;
                            else if (points < 0) bear -= points;
                        }
                        tile.SetProgress((i + 1) / (double)combos.Length);
                    }
                    biasBar.SetScores(bear, bull, neutral);
                    biasBar.Visible = true;
                }
                finally
                {
                    tile.EndBusy();
                }
            };
            clear.Click += delegate { setLocked(false); biasBar.Visible = false; };

            // Permanent white space above the bar and buttons, so the dropdowns never touch them.
            Panel topPadding = new Panel();
            topPadding.Dock = DockStyle.Bottom;
            topPadding.Height = MarketDeskStyle.BiasBarTopPadding;
            // Thin grey line at the top of the white space, dividing the dropdowns from the bar and buttons.
            topPadding.Paint += delegate(object sender, PaintEventArgs e)
            {
                using (Pen pen = new Pen(MarketDeskStyle.BiasDividerColor))
                {
                    e.Graphics.DrawLine(pen, 0, 0, topPadding.Width, 0);
                }
            };
            tile.Body.Controls.Add(rows);
            tile.Body.Controls.Add(topPadding);
            tile.Body.Controls.Add(biasBar);
            tile.Body.Controls.Add(clearHolder);
            rows.BringToFront();

            tile.GetData = delegate
            {
                string[] answers = new string[combos.Length];
                for (int i = 0; i < combos.Length; i++)
                {
                    answers[i] = combos[i].SelectedIndex.ToString();
                }
                return string.Join(",", answers) + ";" + biasBar.Visible.ToString() + ";" + showConfirm.ToString();
            };
            if (calculated)
            {
                calculate.PerformClick();
            }

            // Re-spaces this tile when Global > Tile Size changes.
            Action applySize = delegate
            {
                int pad = MarketDeskStyle.CompactTiles ? 1 : 3;
                foreach (Panel row in rowPanels)
                {
                    row.Padding = new Padding(4, pad, 4, pad);
                    row.Height = combos[0].Height + MarketDeskStyle.BiasRowGap;
                }
                clearHolder.Height = MarketDeskStyle.TileButtonHeight + MarketDeskStyle.TileButtonPadding.Top + MarketDeskStyle.TileButtonPadding.Bottom;
                biasBar.Height = MarketDeskStyle.BiasBarHeight + MarketDeskStyle.BiasReportHeight;
                topPadding.Height = MarketDeskStyle.BiasBarTopPadding;
                biasBar.Invalidate();
            };
            tileSizeAppliers.Add(applySize);
            tile.Disposed += delegate { tileSizeAppliers.Remove(applySize); };
        }

        private static string TilesFolderPath()
        {
            return System.IO.Path.Combine(MarketDeskStyle.DataFolder, "tiles");
        }

        // Saves every open tile in one line each, tab separated: Name, Left, Top, Width, Height, Selected, Data.
        private static MarketDeskTile candleDataWindow;
        private static MarketDeskTile dataChartWindow;
        private static MarketDeskTile moneyFlowWindow;
        private static MarketDeskTile tradingViewWindow;
        private static MarketDeskTile perpChartWindow;
        private static MarketDeskTile mmdWindow;
        private static MarketDeskTile orderBookDeltaWindow;

        // Raised when the Candle Data columns, its time frame or its link change. Data Chart listens for it.
        private static event EventHandler CandleDataUpdated;

        private static void RaiseCandleDataUpdated()
        {
            EventHandler handler = CandleDataUpdated;
            if (handler != null)
            {
                handler(null, EventArgs.Empty);
            }
        }

        // Candle Data starts with 8 closed candles and the live candle. The + and - buttons add or remove older periods.
        // Data comes from 1m candles, so volume can be split by price.
        private const string CandleKlinesUrl = "https://fapi.binance.com/fapi/v1/klines?symbol=BTCUSDT&interval=1m&limit=1500";
        private const int CandlePageLimit = 1500;
        private const int CandleCount = 8;
        private const int CandleStatCount = 3; // Mean, Median, Total.
        private const int CandleRowCount = 17;
        // Price rows come first (change, delta, CVD, POC, VAH, VAL, buyer POC, seller POC, low sell, low seller POC, high buy, high buyer POC); metric rows start here.
        private const int CandleMetricStartRow = 12;
        private const double ValueAreaShare = 0.7;
        private const int CandleRefreshMs = 60000;
        private const long MinuteMs = 60000;
        private const long HourMs = 3600000;
        private const string CandleMinutePattern = "\\[(\\d+),\"([\\d.]+)\",\"([\\d.]+)\",\"([\\d.]+)\",\"([\\d.]+)\",\"([\\d.]+)\",\\d+,\"[\\d.]+\",\\d+,\"([\\d.]+)\"";
        private static readonly string[] CandleTimeFrameNames = { "1h", "4h", "8h", "12h", "1D", "1W" };
        private static readonly string[] CandleTimeFrameLabels = { "1 Hour", "4 Hour", "8 Hour", "12 Hour", "1 Day", "1 Week" };
        private static readonly int[] CandleTimeFrameHours = { 1, 4, 8, 12, 24, 168 };

        // Raw 1m candles kept on disk, so a time frame only downloads the minutes it does not have yet.
        private const string PriceCacheFileName = "BTCUSDT-1m.txt";
        private const int PriceCacheDays = 65;
        private const long DayMs = 86400000;
        private const string KlineLinePattern = "\\[(\\d+),[^\\]]*\\]";
        private static readonly object priceCacheLock = new object();
        // Keyed by open time in ms. Each value is one raw kline array, exactly as Binance sent it.
        private static System.Collections.Generic.SortedDictionary<long, string> priceCache;
        private static string loadedPriceCachePath;
        // The oldest start any load has asked for this session. Trimming never goes newer than this,
        // so a shorter time frame does not throw away minutes a longer one still shows.
        private static long widestCacheStartMs = long.MaxValue;

        private static string PricesFolderPath()
        {
            return System.IO.Path.Combine(MarketDeskStyle.DataFolder, "prices");
        }

        private static string PriceCachePath()
        {
            return ResolvePriceCachePath(PricesFolderPath());
        }

        private static string ResolvePriceCachePath(string folder)
        {
            System.IO.Directory.CreateDirectory(folder);
            string legacy = System.IO.Path.Combine(folder, PriceCacheFileName);
            string initial = System.IO.Path.Combine(folder, "BTCUSDT-1m (0).txt");
            if (System.IO.File.Exists(legacy))
            {
                if (System.IO.File.Exists(initial))
                {
                    throw new System.IO.IOException("Both the original price file and (0) exist. Neither file was changed.");
                }
                System.IO.File.Move(legacy, initial);
            }
            int highest = -1;
            string selected = initial;
            foreach (string file in System.IO.Directory.GetFiles(folder, "BTCUSDT-1m (*).txt"))
            {
                System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                    System.IO.Path.GetFileName(file), @"^BTCUSDT-1m \((\d+)\)\.txt$");
                int number;
                if (match.Success && int.TryParse(match.Groups[1].Value, out number) && number > highest)
                {
                    highest = number;
                    selected = file;
                }
            }
            return selected;
        }

        private static string CreateCleanPriceCache(string folder)
        {
            string current = ResolvePriceCachePath(folder);
            if (!System.IO.File.Exists(current))
            {
                using (System.IO.FileStream stream = new System.IO.FileStream(current, System.IO.FileMode.CreateNew)) { }
            }
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                System.IO.Path.GetFileName(current), @"^BTCUSDT-1m \((\d+)\)\.txt$");
            int next = checked(int.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture) + 1);
            string path = System.IO.Path.Combine(folder, "BTCUSDT-1m (" + next.ToString(System.Globalization.CultureInfo.InvariantCulture) + ").txt");
            using (System.IO.FileStream stream = new System.IO.FileStream(path, System.IO.FileMode.CreateNew)) { }
            return path;
        }

        private static bool TryReadPriceMinute(string line, out long time, out decimal[] values)
        {
            time = 0;
            values = null;
            string text = line.Trim();
            if (!text.StartsWith("[") || !text.EndsWith("]")) return false;
            string[] fields = text.Substring(1, text.Length - 2).Split(',');
            if (fields.Length != 12 ||
                !long.TryParse(fields[0], System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out time) ||
                time < 0 || time % MinuteMs != 0) return false;
            values = new decimal[fields.Length];
            for (int field = 0; field < fields.Length; field++)
            {
                if (!decimal.TryParse(fields[field].Trim().Trim('"'), System.Globalization.NumberStyles.AllowDecimalPoint,
                    System.Globalization.CultureInfo.InvariantCulture, out values[field])) return false;
            }
            return true;
        }

        private static bool PriceMinutesEqual(decimal[] saved, decimal[] remote)
        {
            if (saved.Length != remote.Length) return false;
            for (int field = 0; field < saved.Length; field++)
            {
                if (saved[field] != remote[field]) return false;
            }
            return true;
        }

        // Checks a disk snapshot, never the in-memory cache, and never writes or repairs either one.
        // The current minute is excluded because Binance can still change its values.
        private static string ValidateSavedPrices(Action<double> reportProgress)
        {
            long currentMinute = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / MinuteMs * MinuteMs;
            string snapshot;
            lock (priceCacheLock)
            {
                snapshot = System.IO.File.ReadAllText(PriceCachePath());
            }
            using (System.IO.StringReader reader = new System.IO.StringReader(snapshot))
            {
                return ValidateSavedPrices(reader, currentMinute, DownloadValidationMinutes, reportProgress);
            }
        }

        private static string DownloadValidationMinutes(long first, long last)
        {
            string url = CandleKlinesUrl + "&startTime=" + first.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                "&endTime=" + (last + MinuteMs - 1).ToString(System.Globalization.CultureInfo.InvariantCulture);
            return DownloadBinanceKlines(url);
        }

        private static string DownloadBinanceKlines(string url)
        {
            System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            request.UserAgent = "BlackAdder Reports";
            request.Timeout = 60000;
            request.ReadWriteTimeout = 60000;
            using (System.Net.WebResponse response = request.GetResponse())
            using (System.IO.Stream stream = response.GetResponseStream())
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static string ValidateSavedPrices(System.IO.TextReader reader, long currentMinute, Func<long, long, string> download, Action<double> reportProgress = null)
        {
            System.Collections.Generic.SortedDictionary<long, decimal[]> saved = new System.Collections.Generic.SortedDictionary<long, decimal[]>();
            int invalid = 0, duplicates = 0, skipped = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                long time;
                decimal[] values;
                if (!TryReadPriceMinute(line, out time, out values))
                {
                    invalid++;
                    continue;
                }
                if (time >= currentMinute)
                {
                    skipped++;
                    continue;
                }
                if (saved.ContainsKey(time)) duplicates++;
                else saved.Add(time, values);
            }
            if (saved.Count == 0)
            {
                throw new InvalidOperationException("No valid completed minute candles were found in the saved file. Invalid rows: " + invalid + "; unfinished rows skipped: " + skipped + ".");
            }
            long first = long.MaxValue, last = 0;
            foreach (long time in saved.Keys)
            {
                first = Math.Min(first, time);
                last = Math.Max(last, time);
            }
            int matched = 0, different = 0, missingSaved = 0, missingBinance = 0;
            long expected = first;
            long cursor = first;
            long totalMinutes = (last - first) / MinuteMs + 1;
            if (reportProgress != null) reportProgress(0);
            while (cursor <= last)
            {
                string json = download(cursor, last);
                System.Text.RegularExpressions.MatchCollection minutes = System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern);
                if (minutes.Count == 0)
                {
                    if (json.Trim() != "[]") throw new FormatException("Binance returned an invalid candle response.");
                    break;
                }
                long previous = cursor - MinuteMs;
                foreach (System.Text.RegularExpressions.Match minute in minutes)
                {
                    long time;
                    decimal[] values;
                    if (!TryReadPriceMinute(minute.Value, out time, out values) || time <= previous || time < cursor || time > last)
                    {
                        throw new FormatException("Binance returned invalid or out-of-order minute candles.");
                    }
                    while (expected < time)
                    {
                        if (saved.ContainsKey(expected)) missingBinance++;
                        expected += MinuteMs;
                    }
                    decimal[] local;
                    if (!saved.TryGetValue(time, out local)) missingSaved++;
                    else if (PriceMinutesEqual(local, values)) matched++;
                    else different++;
                    expected = time + MinuteMs;
                    previous = time;
                }
                cursor = previous + MinuteMs;
                if (reportProgress != null) reportProgress((expected - first) / (double)MinuteMs / totalMinutes);
                if (cursor <= last) System.Threading.Thread.Sleep(150);
            }
            while (expected <= last)
            {
                if (saved.ContainsKey(expected)) missingBinance++;
                expected += MinuteMs;
            }
            if (reportProgress != null) reportProgress(1);
            return "Price data validation completed (BTCUSDT perpetual, 1-minute).\r\n" +
                "Saved completed candles: " + saved.Count + "\r\n" +
                "Matching: " + matched + "\r\nDifferent: " + different +
                "\r\nMissing from saved data: " + missingSaved + "\r\nMissing from Binance: " + missingBinance +
                "\r\nInvalid saved rows: " + invalid + "\r\nDuplicate saved rows: " + duplicates +
                "\r\nUnfinished rows skipped: " + skipped + "\r\nNo saved data was changed.";
        }

        // Reads the saved minutes the first time they are needed. A damaged file is skipped and the minutes are downloaded again.
        private static void EnsurePriceCacheLoaded()
        {
            string path = PriceCachePath();
            if (priceCache != null && loadedPriceCachePath == path)
            {
                return;
            }
            priceCache = new System.Collections.Generic.SortedDictionary<long, string>();
            loadedPriceCachePath = path;
            if (!System.IO.File.Exists(path))
            {
                return;
            }
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(path))
                {
                    System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(line, KlineLinePattern);
                    if (match.Success)
                    {
                        priceCache[long.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture)] = match.Value;
                    }
                }
            }
            catch (Exception)
            {
                // The minutes that were read are kept; the rest are downloaded again.
            }
        }

        private static void SavePriceCache()
        {
            try
            {
                System.IO.Directory.CreateDirectory(PricesFolderPath());
                string[] lines = new string[priceCache.Count];
                priceCache.Values.CopyTo(lines, 0);
                System.IO.File.WriteAllLines(loadedPriceCachePath, lines);
            }
            catch (Exception)
            {
                // The cache could not be written (for example, the folder is read-only). The chart still works, it just is not saved.
            }
        }

        // Returns the candles for the time frame. Only minutes from the newest saved one onward are downloaded.
        // The newest saved minute is downloaded again, because it may still have been forming when it was saved.
        private static System.Collections.Generic.List<CandleHour> LoadCandles(long startMs, long candleMs, int candleCount, Action<double> reportProgress)
        {
            bool downloadFailed;
            return LoadCandles(startMs, candleMs, candleCount, reportProgress, out downloadFailed);
        }

        // downloadFailed is true when the download failed but the saved minutes already cover the range,
        // so the candles were built from saved data only. A failed download with no cover still throws.
        private static System.Collections.Generic.List<CandleHour> LoadCandles(long startMs, long candleMs, int candleCount, Action<double> reportProgress, out bool downloadFailed)
        {
            downloadFailed = false;
            lock (priceCacheLock)
            {
                EnsurePriceCacheLoaded();
                widestCacheStartMs = Math.Min(widestCacheStartMs, startMs);
                // The saved minutes are one unbroken run, so they only need topping up at the newest end.
                // If the run does not reach back to startMs (for example, it was saved by a shorter time frame), fill in from startMs.
                long fetchFrom = startMs;
                bool covered = false;
                if (priceCache.Count > 0)
                {
                    long oldest = long.MaxValue;
                    long newest = long.MinValue;
                    foreach (long minuteMs in priceCache.Keys)
                    {
                        oldest = Math.Min(oldest, minuteMs);
                        newest = Math.Max(newest, minuteMs);
                    }
                    covered = oldest <= startMs && newest >= startMs;
                    if (covered)
                    {
                        fetchFrom = newest;
                    }
                }

                try
                {
                    string json = FetchMinuteCandles(fetchFrom, reportProgress);
                    foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern))
                    {
                        priceCache[long.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture)] = match.Value;
                    }
                }
                catch (Exception)
                {
                    if (!covered)
                    {
                        throw;
                    }
                    downloadFailed = true;
                }

                // Keep at least the visible range, including periods added beyond the normal cache window.
                long keepFrom = Math.Min(widestCacheStartMs, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - PriceCacheDays * DayMs);
                System.Collections.Generic.List<long> old = new System.Collections.Generic.List<long>();
                foreach (long minuteMs in priceCache.Keys)
                {
                    if (minuteMs >= keepFrom)
                    {
                        break;
                    }
                    old.Add(minuteMs);
                }
                foreach (long minuteMs in old)
                {
                    priceCache.Remove(minuteMs);
                }
                SavePriceCache();

                System.Text.StringBuilder minutes = new System.Text.StringBuilder();
                foreach (System.Collections.Generic.KeyValuePair<long, string> minute in priceCache)
                {
                    if (minute.Key < startMs)
                    {
                        continue;
                    }
                    if (minutes.Length > 0)
                    {
                        minutes.Append(',');
                    }
                    minutes.Append(minute.Value);
                }
                return ParseCandles("[" + minutes + "]", candleMs, candleCount);
            }
        }

        // Downloads the 1m klines from startMs to now, in pages. Returns the minutes as one list for ParseCandles.
        // reportProgress receives a 0 to 1 share after each page.
        private static string FetchMinuteCandles(long startMs, Action<double> reportProgress)
        {
            // Binance requires TLS 1.2, which older .NET defaults do not always use.
            System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
            long nowMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            long minutesNeeded = (nowMs - startMs) / MinuteMs + 1;
            long expectedPages = Math.Max(1, (minutesNeeded + CandlePageLimit - 1) / CandlePageLimit);
            System.Text.StringBuilder minutes = new System.Text.StringBuilder();
            long cursor = startMs;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Headers["User-Agent"] = "BlackAdder Reports";
                for (long page = 0; page < expectedPages && cursor < nowMs; page++)
                {
                    string json = client.DownloadString(CandleKlinesUrl + "&startTime=" + cursor.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(json, CandleMinutePattern);
                    if (matches.Count == 0)
                    {
                        break;
                    }
                    if (minutes.Length > 0)
                    {
                        minutes.Append(',');
                    }
                    // Drop the outer [ ] of each reply, so the pages join into one list.
                    minutes.Append(json, 1, json.Length - 2);
                    cursor = long.Parse(matches[matches.Count - 1].Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture) + MinuteMs;
                    reportProgress(Math.Min(1.0, (page + 1) / (double)expectedPages));
                    if (matches.Count < CandlePageLimit)
                    {
                        break;
                    }
                }
            }
            return "[" + minutes + "]";
        }
        // Weeks start on Monday, and 1 Jan 1970 was a Thursday, so weekly buckets are offset by 4 days.
        // Days and hours start at UTC midnight or the hour.
        private const long MondayOffsetMs = 4 * DayMs;

        private static long CandleBucketStart(long ms, long candleMs)
        {
            long offset = candleMs >= 7 * DayMs ? MondayOffsetMs : 0;
            return (ms - offset) / candleMs * candleMs + offset;
        }

        // $1 buckets centered on whole-dollar prices.
        private const double PocBucketSize = 1.0;
        // The outermost share of a candle's price range, used for the low sell and high buy zone rows.
        private const double ZoneShare = 0.2;

        private static void OpenCandleData()
        {
            if (candleDataWindow != null && !candleDataWindow.IsDisposed)
            {
                candleDataWindow.SelectTile();
                return;
            }

            Size size = new Size(MarketDeskStyle.ToolWindowWidth, MarketDeskStyle.TileTitleHeight + MarketDeskStyle.CandleTileBodyHeight);
            Point spot = FindSpot(size);

            candleDataWindow = CreateToolWindow("Candle Data", size, spot);
            // Add to the workspace first, so the tile has the default font before its cells copy it.
            workspacePanel.Controls.Add(candleDataWindow);
            BuildCandleData(candleDataWindow, CandleTimeFrameNames[0]);
            SaveTiles();
        }

        // Fills the Candle Data tile with completed period columns and a live column for the candle still forming.
        // The top row shows the times, and the left column names each row.
        // Rows: change %, delta (buy - sell), CVD (running total of the delta), candle POC (most volume),
        // buyer POC (most buying) and seller POC (most selling).
        private static void BuildCandleData(MarketDeskTile tile, string savedTimeFrame)
        {
            int candleCount;
            string timeFrame;
            bool[] rowVisible;
            ReadCandleSettings(savedTimeFrame, out timeFrame, out candleCount, out rowVisible);
            int candleColumnCount = candleCount + 1;
            int candleAllColumns = candleColumnCount + CandleStatCount;
            TableLayoutPanel grid = new TableLayoutPanel();
            grid.Dock = DockStyle.Fill;
            grid.ColumnCount = candleAllColumns + 1;
            grid.RowCount = CandleRowCount + 2;
            // Dock directly below the title strip without exposing the grid background as a grey band.
            grid.Padding = Padding.Empty;
            // Grid lines are the 1 px gaps between cells. The outer left, right and bottom edges have no gap, so no ring is drawn there.
            grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            grid.BackColor = SystemColors.ControlDark;
            // The label column is sized to the dropdown, row names and button row, not the tile width.
            ColumnStyle labelColumn = new ColumnStyle(SizeType.Absolute, 120f);
            grid.ColumnStyles.Add(labelColumn);
            for (int column = 0; column < candleAllColumns; column++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / candleAllColumns));
            }
            RowStyle timeFrameRow = new RowStyle(SizeType.Absolute, 30f);
            grid.RowStyles.Add(timeFrameRow);
            for (int row = 0; row < CandleRowCount; row++)
            {
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / (CandleRowCount + 1)));
            }
            RowStyle buttonRow = new RowStyle(SizeType.Absolute, MarketDeskStyle.TileButtonHeight + 4);
            grid.RowStyles.Add(buttonRow);

            System.Collections.Generic.List<Label> headerCells = new System.Collections.Generic.List<Label>();
            // Total-column cells use the regular weight, unlike the bold row names.
            System.Collections.Generic.List<Label> totalCells = new System.Collections.Generic.List<Label>();
            ToolTip metricToolTip = new ToolTip();
            metricToolTip.AutoPopDelay = 20000;
            tile.Disposed += delegate { metricToolTip.Dispose(); };
            // The top-left cell holds the saved time frame dropdown.
            int selectedFrame = 0;
            for (int frame = 0; frame < CandleTimeFrameNames.Length; frame++)
            {
                // Matches saved values case-insensitively, so tiles saved with "1d" still load as 1D.
                if (string.Equals(CandleTimeFrameNames[frame], timeFrame, StringComparison.OrdinalIgnoreCase))
                {
                    selectedFrame = frame;
                }
            }
            Action refresh = null;
            bool awaitingTimeFrame = false;
            Panel timeFramePanel = new Panel();
            timeFramePanel.Dock = DockStyle.Fill;
            timeFramePanel.Margin = Padding.Empty;
            timeFramePanel.BackColor = MarketDeskStyle.TileTitleBackground;
            grid.Controls.Add(timeFramePanel, 0, 0);
            MarketDeskComboBox timeFrameDropdown = new MarketDeskComboBox();
            timeFrameDropdown.Name = "TimeFrame";
            timeFrameDropdown.AccessibleName = "Candle Data Time Frame";
            timeFrameDropdown.TabStop = false;
            timeFrameDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            timeFrameDropdown.Items.AddRange(CandleTimeFrameLabels);
            timeFrameDropdown.SelectedIndex = selectedFrame;
            timeFrameDropdown.FollowButtonLook = true;
            UseTileDropdownLook(timeFrameDropdown);
            timeFramePanel.Controls.Add(timeFrameDropdown);
            timeFrameDropdown.DropDownClosed += delegate
            {
                Form form = tile.FindForm();
                if (form != null && form.ActiveControl == timeFrameDropdown)
                {
                    form.ActiveControl = null;
                }
            };
            Action layoutTimeFrames = delegate
            {
                timeFrameDropdown.Width = Math.Max(0, timeFramePanel.ClientSize.Width - 8);
                timeFrameDropdown.Location = new Point(4, Math.Max(0,
                    (timeFramePanel.ClientSize.Height - timeFrameDropdown.Height) / 2));
            };
            timeFramePanel.Resize += delegate { layoutTimeFrames(); };
            Action applyTimeFrameStyle = delegate
            {
                timeFrameDropdown.Font = tile.Font;
                timeFrameRow.Height = timeFrameDropdown.PreferredHeight + 6;
                int labelWidth = 5 + 4 * (MarketDeskStyle.TileButtonHeight + 2) + 4;
                foreach (string frameLabel in CandleTimeFrameLabels)
                    labelWidth = Math.Max(labelWidth, TextRenderer.MeasureText(frameLabel, tile.Font).Width
                        + SystemInformation.VerticalScrollBarWidth + 16);
                using (Font headerFont = new Font(tile.Font, FontStyle.Bold))
                {
                    foreach (string rowName in CandleRowNames)
                        labelWidth = Math.Max(labelWidth, TextRenderer.MeasureText(rowName, headerFont).Width + 8);
                }
                labelColumn.Width = labelWidth + 2;
                layoutTimeFrames();
            };
            timeFrameDropdown.SelectedIndexChanged += delegate
            {
                int frame = timeFrameDropdown.SelectedIndex;
                if (frame == selectedFrame)
                {
                    return;
                }
                selectedFrame = frame;
                awaitingTimeFrame = false;
                SaveTiles();
                refresh();
            };
            Label[] timeCells = new Label[candleAllColumns];
            for (int column = 0; column < candleAllColumns; column++)
            {
                timeCells[column] = CreateCandleHeaderCell("...", ContentAlignment.MiddleCenter);
                headerCells.Add(timeCells[column]);
                grid.Controls.Add(timeCells[column], column + 1, 0);
            }
            timeCells[candleColumnCount].Text = "Mean";
            timeCells[candleColumnCount + 1].Text = "Median";
            timeCells[candleColumnCount + 2].Text = "Total";

            Label[] rowTotals = new Label[CandleRowCount];
            Label[][] rows = new Label[CandleRowCount][];
            for (int row = 0; row < CandleRowCount; row++)
            {
                Label rowName = CreateCandleHeaderCell(CandleRowNames[row], ContentAlignment.MiddleLeft);
                if (row >= CandleMetricStartRow) metricToolTip.SetToolTip(rowName, CandleMetricDescriptions[row - CandleMetricStartRow]);
                headerCells.Add(rowName);
                grid.Controls.Add(rowName, 0, row + 1);
                rows[row] = new Label[candleAllColumns];
                for (int column = 0; column < candleAllColumns; column++)
                {
                    rows[row][column] = CreateCandleCell();
                    if (row >= CandleMetricStartRow) metricToolTip.SetToolTip(rows[row][column], CandleMetricDescriptions[row - CandleMetricStartRow]);
                    grid.Controls.Add(rows[row][column], column + 1, row + 1);
                }
                rowTotals[row] = rows[row][candleAllColumns - 1];
                rowTotals[row].Text = string.Empty;
                totalCells.Add(rowTotals[row]);
            }
            SetCandleMetricRowsVisible(grid, rows, rowVisible);
            Panel buttonPanel = new Panel();
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.BackColor = MarketDeskStyle.TileTitleBackground;
            grid.Controls.Add(buttonPanel, 0, CandleRowCount + 1);
            MarketDeskButton[] candleButtons = CreateCandleButtons(buttonPanel);
            buttonPanel.Resize += delegate { LayoutCandleButtons(candleButtons); };
            LayoutCandleButtons(candleButtons);
            for (int column = 1; column < grid.ColumnCount; column++)
            {
                Label blankCell = new Label();
                blankCell.Dock = DockStyle.Fill;
                blankCell.Margin = Padding.Empty;
                blankCell.BackColor = MarketDeskStyle.ToolWindowBodyBackground;
                grid.Controls.Add(blankCell, column, CandleRowCount + 1);
            }
            ApplyCandleGridMargins(grid);
            tile.Body.Controls.Add(grid);
            tile.Body.Controls["Title"].SendToBack();
            Label totalHeader = timeCells[timeCells.Length - 1];
            Action sizeTotals = delegate { SizeCandleTotalColumn(grid, totalHeader, rowTotals); };
            totalHeader.FontChanged += delegate { sizeTotals(); };
            foreach (Label total in rowTotals)
            {
                total.TextChanged += delegate { sizeTotals(); };
                total.FontChanged += delegate { sizeTotals(); };
            }
            sizeTotals();

            // Header cells use a bold copy of the tile font, so they follow Global > Font and text size.
            Font candleButtonFont = null;
            Action applyCandleFont = delegate
            {
                foreach (Label cell in headerCells)
                {
                    cell.Font = new Font(tile.Font, FontStyle.Bold);
                }
                foreach (Label cell in totalCells)
                {
                    cell.Font = new Font(tile.Font, FontStyle.Regular);
                }
                Font previousCandleButtonFont = candleButtonFont;
                candleButtonFont = new Font(tile.Font, FontStyle.Bold);
                foreach (MarketDeskButton button in candleButtons)
                {
                    button.Font = candleButtonFont;
                }
                if (previousCandleButtonFont != null) previousCandleButtonFont.Dispose();
                applyTimeFrameStyle();
            };
            applyCandleFont();
            tileFontAppliers.Add(applyCandleFont);

            // Changes height with Global > Tile Size, keeping the top-left position.
            Action applyCandleSize = delegate
            {
                tile.SetNormalHeight(MarketDeskStyle.TileTitleHeight + MarketDeskStyle.CandleTileBodyHeight);
                buttonRow.Height = MarketDeskStyle.TileButtonHeight + 4;
                applyTimeFrameStyle();
                LayoutCandleButtons(candleButtons);
            };
            applyCandleSize();
            tileSizeAppliers.Add(applyCandleSize);
            tile.Disposed += delegate
            {
                tileFontAppliers.Remove(applyCandleFont);
                tileSizeAppliers.Remove(applyCandleSize);
                if (candleButtonFont != null) candleButtonFont.Dispose();
            };

            // Time frame, completed-period count and row visibility are saved together; older saves contain fewer fields.
            tile.GetData = delegate
            {
                return CandleTimeFrameNames[selectedFrame] + "|"
                    + candleCount.ToString(System.Globalization.CultureInfo.InvariantCulture) + "|"
                    + WriteCandleRowMask(rowVisible);
            };
            Action<bool[]> applyRowVisibility = delegate(bool[] visible)
            {
                rowVisible = visible;
                SetCandleMetricRowsVisible(grid, rows, rowVisible);
                SaveTiles();
            };
            tile.SettingsViewFactory = delegate
            {
                return new CandleTileSettingsView(tile, rowVisible, applyRowVisibility);
            };
            candleButtons[3].Enabled = candleCount > CandleCount;
            bool confirmingClean = false;
            candleButtons[0].Click += delegate
            {
                PrependCandleColumn(grid, headerCells, ref timeCells, rows);
                for (int row = CandleMetricStartRow; row < CandleRowCount; row++)
                {
                    metricToolTip.SetToolTip(rows[row][0], CandleMetricDescriptions[row - CandleMetricStartRow]);
                }
                candleCount++;
                candleButtons[3].Enabled = true;
                applyCandleFont();
                if (awaitingTimeFrame) ClearCandleValues(timeCells, rows, rowTotals);
                SaveTiles();
                refresh();
            };
            candleButtons[1].Click += delegate { ShowPriceValidationDialog(tile); };
            candleButtons[2].Click += delegate
            {
                Label message;
                Button cancel;
                Button confirm;
                DialogResult result;
                confirmingClean = true;
                try
                {
                    using (Form dialog = CreatePriceDataDialog(tile, "Clean Price Data",
                        "Are you sure you would like to clean price data?", out message, out cancel, out confirm))
                    {
                        result = dialog.ShowDialog(tile.FindForm());
                    }
                }
                finally
                {
                    confirmingClean = false;
                }
                if (result != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    string path;
                    lock (priceCacheLock)
                    {
                        path = CreateCleanPriceCache(PricesFolderPath());
                        loadedPriceCachePath = path;
                        priceCache = new System.Collections.Generic.SortedDictionary<long, string>();
                    }
                    awaitingTimeFrame = true;
                    ClearCandleValues(timeCells, rows, rowTotals);
                    SetStatus("Created " + System.IO.Path.GetFileName(path) + ". Select a different time frame to download fresh data.");
                }
                catch (Exception error)
                {
                    SetStatus("Could not clean price data: " + error.Message);
                    MessageBox.Show(tile.FindForm(), error.Message, "Clean Price Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            candleButtons[3].Click += delegate
            {
                if (candleCount <= CandleCount)
                {
                    return;
                }
                RemoveOldestCandleColumn(grid, headerCells, ref timeCells, rows);
                candleCount--;
                candleButtons[3].Enabled = candleCount > CandleCount;
                if (awaitingTimeFrame) ClearCandleValues(timeCells, rows, rowTotals);
                SaveTiles();
                refresh();
            };

            // Downloads run on a background thread, so the window does not freeze. Only one download runs at a time.
            bool loading = false;
            refresh = delegate
            {
                if (loading || tile.IsDisposed || awaitingTimeFrame || confirmingClean)
                {
                    return;
                }
                loading = true;
                candleButtons[2].Enabled = false;
                tile.BeginBusy();
                int index = selectedFrame;
                int requestedCount = candleCount;
                long candleMs = CandleTimeFrameHours[index] * HourMs;
                // Starts at the oldest completed period requested.
                long startMs = CandleBucketStart(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(), candleMs) - requestedCount * candleMs;
                System.Threading.ThreadPool.QueueUserWorkItem(delegate
                {
                    System.Collections.Generic.List<CandleHour> candles = null;
                    // Reports progress to the UI thread. A failure here must not stop the download.
                    Action<double> reportProgress = delegate(double fraction)
                    {
                        try
                        {
                            tile.BeginInvoke(new Action(delegate { tile.SetProgress(fraction * 0.9); }));
                        }
                        catch (Exception)
                        {
                            // The tile was closed while the download was running.
                        }
                    };
                    bool savedOnly;
                    try
                    {
                        candles = LoadCandles(startMs, candleMs, requestedCount, reportProgress, out savedOnly);
                    }
                    catch (Exception)
                    {
                        // Shown as n/a below when the download fails and the saved minutes do not cover the range.
                        savedOnly = false;
                    }
                    try
                    {
                        tile.BeginInvoke(new Action(delegate
                        {
                            loading = false;
                            if (tile.IsDisposed)
                            {
                                return;
                            }
                            tile.EndBusy();
                            candleButtons[2].Enabled = true;
                            bool changed = selectedFrame != index || candleCount != requestedCount;
                            if (!changed)
                            {
                                ShowCandles(timeCells, rows, rowTotals, candles, candleMs);
                                RaiseCandleDataUpdated();
                            }
                            // Binance answered, so data is connected. A failed download (for example, no internet) means not connected,
                            // even when the saved minutes still filled the candles.
                            SetDataConnected(candles != null && !savedOnly);
                            // A changed time frame or period count needs a fresh download.
                            if (changed)
                            {
                                refresh();
                            }
                        }));
                    }
                    catch (Exception)
                    {
                        // The tile was closed while the download was running.
                    }
                });
            };

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = CandleRefreshMs;
            timer.Tick += delegate { refresh(); };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Stop();
                timer.Dispose();
            };

            refresh();
        }

        private static void OpenDataChart()
        {
            if (dataChartWindow != null && !dataChartWindow.IsDisposed)
            {
                dataChartWindow.SelectTile();
                return;
            }

            Size size = new Size(MarketDeskStyle.ToolWindowWidth, MarketDeskStyle.TileTitleHeight + MarketDeskStyle.CandleTileBodyHeight);
            Point spot = FindSpot(size);

            dataChartWindow = CreateToolWindow("Data Chart", size, spot);
            workspacePanel.Controls.Add(dataChartWindow);
            BuildDataChart(dataChartWindow, null);
            SaveTiles();
        }

        // Data Chart draws the 1m closes for the range shown in Candle Data, with one POC for the whole range.
        // It always follows the open Candle Data tile and stays empty until that tile is open.
        private static void BuildDataChart(MarketDeskTile tile, string savedColors)
        {
            DataChartCanvas canvas = new DataChartCanvas();
            canvas.Dock = DockStyle.Fill;
            tile.Body.Controls.Add(canvas);
            tile.Body.Controls["Title"].SendToBack();
            Color savedLine;
            Color savedBack;
            ReadDataChartColors(savedColors, out savedLine, out savedBack);
            canvas.LineColor = savedLine;
            canvas.BackColor = savedBack;
            tile.GetData = delegate { return WriteDataChartColors(canvas.LineColor, canvas.BackColor); };
            tile.SettingsViewFactory = delegate
            {
                return new DataChartTileSettingsView(tile, canvas.LineColor, canvas.BackColor, delegate(Color line, Color back)
                {
                    canvas.LineColor = line;
                    canvas.BackColor = back;
                    canvas.Invalidate();
                    SaveTiles();
                });
            };


            bool loading = false;
            bool pending = false;
            Action refresh = null;
            refresh = delegate
            {
                if (tile.IsDisposed)
                {
                    return;
                }
                MarketDeskTile candleTile = FindCandleDataTile();
                if (candleTile == null)
                {
                    canvas.ShowMessage("Open Candle Data to show the price.");
                    if (loading)
                    {
                        pending = true;
                    }
                    return;
                }
                if (loading)
                {
                    pending = true;
                    return;
                }

                string timeFrame;
                int candleCount;
                ReadCandleSettings(candleTile.GetData(), out timeFrame, out candleCount);
                int frame = Array.IndexOf(CandleTimeFrameNames, timeFrame);
                if (frame < 0)
                {
                    canvas.ShowMessage("Candle Data time frame is not supported.");
                    return;
                }

                long candleMs = CandleTimeFrameHours[frame] * HourMs;
                long nowMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                // Starts at the oldest column shown in Candle Data, the same start the Candle Data download uses.
                long startMs = CandleBucketStart(nowMs, candleMs) - candleCount * candleMs;
                int minuteCount = (int)Math.Min(int.MaxValue / 2, (nowMs - startMs) / MinuteMs + 1);
                loading = true;
                tile.BeginBusy();
                System.Threading.ThreadPool.QueueUserWorkItem(delegate
                {
                    System.Collections.Generic.List<CandleHour> minutes = null;
                    Action<double> reportProgress = delegate(double fraction)
                    {
                        try
                        {
                            tile.BeginInvoke(new Action(delegate { tile.SetProgress(fraction * 0.9); }));
                        }
                        catch (Exception)
                        {
                            // The tile was closed while the download was running.
                        }
                    };
                    try
                    {
                        minutes = LoadCandles(startMs, MinuteMs, minuteCount, reportProgress);
                    }
                    catch (Exception)
                    {
                        // Shown as a message below when the download fails.
                    }
                    try
                    {
                        tile.BeginInvoke(new Action(delegate
                        {
                            loading = false;
                            if (tile.IsDisposed)
                            {
                                return;
                            }
                            tile.EndBusy();
                            // A change made during the download starts a new one, so stale data is never shown.
                            if (pending)
                            {
                                pending = false;
                                refresh();
                                return;
                            }
                            ShowDataChartSeries(canvas, minutes);
                        }));
                    }
                    catch (Exception)
                    {
                        // The tile was closed while the download was running.
                    }
                });
            };

            EventHandler onCandleDataUpdated = delegate { refresh(); };
            CandleDataUpdated += onCandleDataUpdated;
            tile.Disposed += delegate
            {
                CandleDataUpdated -= onCandleDataUpdated;
                if (dataChartWindow == tile)
                {
                    dataChartWindow = null;
                }
            };

            refresh();
        }

        // Candles and cumulative taker delta for one Money Flow view.
        private sealed class MoneyFlowRange
        {
            internal readonly string Label;
            internal readonly string Interval;
            internal readonly long IntervalMs;
            internal readonly int Candles;

            internal static readonly MoneyFlowRange Days7 = new MoneyFlowRange("Past 7 days", "5m", 5 * MinuteMs, 7 * 24 * 12);
            internal static readonly MoneyFlowRange Days30 = new MoneyFlowRange("Past 30 days", "30m", 30 * MinuteMs, 30 * 24 * 2);

            private MoneyFlowRange(string label, string interval, long intervalMs, int candles)
            {
                Label = label;
                Interval = interval;
                IntervalMs = intervalMs;
                Candles = candles;
            }
        }

        // Binance returns at most 1000 klines per request, so longer ranges are fetched in consecutive chunks.
        private const int MoneyFlowKlineLimit = 1000;
        private const string MoneyFlowKlinesUrl = "https://fapi.binance.com/fapi/v1/klines?symbol=BTCUSDT";
        private const long MmdIntervalMs = 30 * MinuteMs;
        private const int MmdCandleCount = 30 * 24 * 2;
        private const string MmdSpotKlinesUrl = "https://api.binance.com/api/v3/klines";
        private const string MmdPerpKlinesUrl = "https://fapi.binance.com/fapi/v1/klines";

        private static void OpenMoneyFlow()
        {
            if (moneyFlowWindow != null && !moneyFlowWindow.IsDisposed)
            {
                moneyFlowWindow.SelectTile();
                return;
            }
            Size size = new Size(640, MarketDeskStyle.ToolWindowHeight + MarketDeskStyle.TileTitleHeight);
            Point spot = FindSpot(size);
            moneyFlowWindow = CreateToolWindow("Money Flow", size, spot);
            workspacePanel.Controls.Add(moneyFlowWindow);
            BuildMoneyFlow(moneyFlowWindow);
            SaveTiles();
        }

        private static void BuildMoneyFlow(MarketDeskTile tile)
        {
            MoneyFlowCanvas canvas = new MoneyFlowCanvas();
            canvas.Dock = DockStyle.Fill;
            Panel footer = new Panel();
            footer.Dock = DockStyle.Bottom;
            footer.Padding = MarketDeskStyle.TileButtonPadding;
            MoneyFlowRange range = MoneyFlowRange.Days7;
            MarketDeskButton sevenDayButton = new MarketDeskButton();
            sevenDayButton.Text = "7D";
            sevenDayButton.Width = 44;
            sevenDayButton.Margin = new Padding(0, 0, 4, 0);
            sevenDayButton.Highlighted = true;
            sevenDayButton.HighlightColor = Color.Black;
            UseTileButtonLook(sevenDayButton);
            MarketDeskButton thirtyDayButton = new MarketDeskButton();
            thirtyDayButton.Text = "30D";
            thirtyDayButton.Width = 44;
            thirtyDayButton.Margin = new Padding(0, 0, 4, 0);
            thirtyDayButton.HighlightColor = Color.Black;
            UseTileButtonLook(thirtyDayButton);
            MarketDeskButton refreshButton = new MarketDeskButton();
            refreshButton.Text = "Refresh";
            refreshButton.Width = 75;
            refreshButton.Margin = Padding.Empty;
            UseTileButtonLook(refreshButton);
            FlowLayoutPanel rangeButtons = new FlowLayoutPanel();
            rangeButtons.Dock = DockStyle.Right;
            rangeButtons.AutoSize = true;
            rangeButtons.WrapContents = false;
            rangeButtons.Margin = Padding.Empty;
            rangeButtons.Padding = Padding.Empty;
            rangeButtons.Controls.Add(sevenDayButton);
            rangeButtons.Controls.Add(thirtyDayButton);
            rangeButtons.Controls.Add(refreshButton);
            Label rangeLabel = new Label();
            rangeLabel.Dock = DockStyle.Fill;
            rangeLabel.TextAlign = ContentAlignment.MiddleLeft;
            rangeLabel.Text = range.Label + " | UTC";
            footer.Controls.Add(rangeLabel);
            footer.Controls.Add(rangeButtons);
            tile.Body.Controls.Add(canvas);
            tile.Body.Controls.Add(footer);
            tile.Body.Controls["Title"].SendToBack();
            Action applySize = delegate
            {
                int buttonHeight = Math.Max(MarketDeskStyle.TileButtonHeight, tile.Font.Height + 8);
                footer.Height = buttonHeight + footer.Padding.Vertical;
                sevenDayButton.Height = buttonHeight;
                thirtyDayButton.Height = buttonHeight;
                refreshButton.Height = buttonHeight;
                canvas.Invalidate();
            };
            tileSizeAppliers.Add(applySize);
            tileFontAppliers.Add(applySize);
            applySize();

            bool loading = false;
            long loadedEndMs = 0;
            Action<Exception> showFailure = delegate(Exception error)
            {
                if (tile.IsDisposed) return;
                string text = "Could not load Binance futures money flow: " + error.Message;
                canvas.ShowMessage(text + "\r\nUse Refresh to retry.");
                rangeLabel.Text = "Download failed";
                SetStatus(text);
                SetDataConnected(false);
            };
            Action refresh = null;
            refresh = async delegate
            {
                if (loading || tile.IsDisposed) return;
                MoneyFlowRange requested = range;
                long endMs = CandleBucketStart(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(), requested.IntervalMs);
                if (endMs == loadedEndMs) return;
                loading = true;
                refreshButton.Enabled = false;
                tile.BeginBusy();
                try
                {
                    MoneyFlowSeries values = await System.Threading.Tasks.Task.Run(delegate { return DownloadMoneyFlow(requested, endMs); });
                    if (tile.IsDisposed || requested != range) return;
                    canvas.SetSeries(values);
                    rangeLabel.Text = DateTimeOffset.FromUnixTimeMilliseconds(values.StartMs).UtcDateTime.ToString("dd MMM HH:mm",
                        System.Globalization.CultureInfo.InvariantCulture) + " - " +
                        DateTimeOffset.FromUnixTimeMilliseconds(values.EndMs).UtcDateTime.ToString("dd MMM HH:mm",
                        System.Globalization.CultureInfo.InvariantCulture) + " UTC";
                    loadedEndMs = endMs;
                    SetDataConnected(true);
                }
                catch (System.Net.WebException error) { showFailure(error); }
                catch (System.IO.IOException error) { showFailure(error); }
                catch (FormatException error) { showFailure(error); }
                catch (OverflowException error) { showFailure(error); }
                finally
                {
                    loading = false;
                    if (!tile.IsDisposed)
                    {
                        refreshButton.Enabled = true;
                        tile.EndBusy();
                        if (requested != range) refresh();
                    }
                }
            };
            Action<MoneyFlowRange> selectRange = delegate(MoneyFlowRange choice)
            {
                range = choice;
                sevenDayButton.Highlighted = choice == MoneyFlowRange.Days7;
                thirtyDayButton.Highlighted = choice == MoneyFlowRange.Days30;
                rangeLabel.Text = choice.Label + " | UTC";
                loadedEndMs = 0;
                refresh();
            };
            sevenDayButton.Click += delegate { selectRange(MoneyFlowRange.Days7); };
            thirtyDayButton.Click += delegate { selectRange(MoneyFlowRange.Days30); };
            refreshButton.Click += delegate
            {
                loadedEndMs = 0;
                refresh();
            };
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = CandleRefreshMs;
            timer.Tick += delegate { refresh(); };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Dispose();
                tileSizeAppliers.Remove(applySize);
                tileFontAppliers.Remove(applySize);
                if (moneyFlowWindow == tile) moneyFlowWindow = null;
            };
            refresh();
        }

        private static void OpenMmd()
        {
            if (mmdWindow != null && !mmdWindow.IsDisposed)
            {
                mmdWindow.SelectTile();
                return;
            }
            Size size = new Size(920, 520);
            Point spot = FindSpot(size);
            mmdWindow = CreateToolWindow("MMD", size, spot);
            workspacePanel.Controls.Add(mmdWindow);
            BuildMmd(mmdWindow);
            SaveTiles();
        }

        private static void BuildMmd(MarketDeskTile tile)
        {
            MmdCanvas canvas = new MmdCanvas();
            TabControl tabs = new TabControl();
            tabs.Dock = DockStyle.Fill;
            TabPage signalsPage = new TabPage("Signals & timing");
            TabPage chartsPage = new TabPage("Charts & divergences");
            TabPage outcomesPage = new TabPage("30-day outcome test");
            tabs.TabPages.Add(chartsPage);
            tabs.TabPages.Add(signalsPage);
            tabs.TabPages.Add(outcomesPage);
            Panel chartScroll = new Panel();
            chartScroll.Dock = DockStyle.Fill;
            chartScroll.AutoScroll = true;
            chartScroll.BackColor = Color.White;
            canvas.Dock = DockStyle.Top;
            canvas.Height = 800;
            chartScroll.Controls.Add(canvas);
            chartsPage.Controls.Add(chartScroll);
            Label chartReadout = new Label();
            chartReadout.Dock = DockStyle.Bottom;
            chartReadout.Height = 46;
            chartReadout.Padding = new Padding(6);
            chartReadout.Text = "P = ETH/BTC pivot divergence | S = spot CVD | F = perp CVD | A = absorption proxy.\r\n" +
                "Triangles are placed at confirmation, not at the earlier pivot. Double-click a signal to inspect its chart.";
            chartsPage.Controls.Add(chartReadout);
            FlowLayoutPanel chartTools = new FlowLayoutPanel();
            chartTools.Dock = DockStyle.Top;
            chartTools.Height = 32;
            chartTools.WrapContents = false;
            foreach (int days in new int[] { 30, 7, 2 })
            {
                int bars = days * 48;
                MarketDeskButton windowButton = new MarketDeskButton();
                UseTileButtonLook(windowButton);
                windowButton.Text = days + "D";
                windowButton.Size = new Size(48, 26);
                windowButton.Click += delegate { canvas.SetWindow(bars); };
                chartTools.Controls.Add(windowButton);
            }
            foreach (int direction in new int[] { -1, 1 })
            {
                int shift = direction;
                MarketDeskButton panButton = new MarketDeskButton();
                UseTileButtonLook(panButton);
                panButton.Text = direction < 0 ? "Earlier" : "Later";
                panButton.Size = new Size(64, 26);
                panButton.Click += delegate { canvas.Pan(shift); };
                chartTools.Controls.Add(panButton);
            }
            CheckBox spotCheck = new CheckBox();
            spotCheck.Text = "Spot flow";
            spotCheck.AutoSize = true;
            spotCheck.Checked = true;
            CheckBox perpCheck = new CheckBox();
            perpCheck.Text = "Perp flow";
            perpCheck.AutoSize = true;
            perpCheck.Checked = true;
            Action applyVisibility = delegate
            {
                spotCheck.Enabled = perpCheck.Checked;
                perpCheck.Enabled = spotCheck.Checked;
                canvas.SetFlowVisibility(spotCheck.Checked, perpCheck.Checked);
            };
            spotCheck.CheckedChanged += delegate { applyVisibility(); };
            perpCheck.CheckedChanged += delegate { applyVisibility(); };
            chartTools.Controls.Add(spotCheck);
            chartTools.Controls.Add(perpCheck);
            chartsPage.Controls.Add(chartTools);
            MmdSeries displayedValues = null;
            canvas.HoverChanged += delegate(int index)
            {
                if (displayedValues == null) return;
                chartReadout.Text = FormatMmdUtc(displayedValues.StartMs + index * displayedValues.IntervalMs) +
                    " UTC | ETH perp " + displayedValues.EthPerp.Close[index].ToString("#,##0.00",
                        System.Globalization.CultureInfo.InvariantCulture) + " | BTC perp " +
                    displayedValues.BtcPerp.Close[index].ToString("#,##0.00", System.Globalization.CultureInfo.InvariantCulture) +
                    "\r\nP = pair divergence | S = spot CVD | F = perp CVD | A = possible absorption. Hover markers for reasons.";
            };

            ListView outcomesList = new ListView();
            outcomesList.Dock = DockStyle.Fill;
            outcomesList.View = View.Details;
            outcomesList.FullRowSelect = true;
            outcomesList.GridLines = true;
            string[] outcomeColumns = { "Signal", "Hold", "N", "Pending", "Overlap skipped", "ETH win%", "ETH mean net",
                "ETH median net", "Worst ETH MAE", "Ratio mean gross", "Baseline ETH net", "Mean - baseline" };
            foreach (string column in outcomeColumns) outcomesList.Columns.Add(column, column == "Signal" ? 205 : 112);
            outcomesPage.Controls.Add(outcomesList);
            TextBox outcomeMethod = new TextBox();
            outcomeMethod.Dock = DockStyle.Top;
            outcomeMethod.Height = 100;
            outcomeMethod.Multiline = true;
            outcomeMethod.ReadOnly = true;
            outcomeMethod.ScrollBars = ScrollBars.Vertical;
            outcomeMethod.Text = "Exploratory 30-day event study, NOT proof of a tradeable edge or an out-of-sample backtest.\r\n" +
                "Entry: next ETH perp candle OPEN after confirmation. Exit: CLOSE after 6h/24h. Bullish = long ETH, bearish = short ETH. " +
                "ETH net subtracts an illustrative 0.10% round-trip cost; funding, actual slippage and borrow not modeled.\r\n" +
                "Pending outcomes are excluded. Overlap is removed within each signal family/horizon only; families are NOT independent trades. " +
                "N < 20 is flagged small. Worst MAE is the worst intrabar adverse ETH move before costs.\r\n" +
                "Ratio mean is signed ETH/BTC ratio change, gross (NOT a hedged portfolio P&L). Baseline: same-direction ETH holds on a fixed " +
                "non-overlapping grid after 24h warmup. Positive mean-minus-baseline is descriptive, not statistical significance.";
            outcomesPage.Controls.Add(outcomeMethod);

            Label biasLabel = new Label();
            biasLabel.Dock = DockStyle.Fill;
            biasLabel.TextAlign = ContentAlignment.MiddleLeft;
            biasLabel.Padding = new Padding(8, 0, 0, 0);
            biasLabel.Text = "Loading ETH vs BTC bias...";
            Label detailsLabel = new Label();
            detailsLabel.Dock = DockStyle.Fill;
            detailsLabel.AutoEllipsis = true;
            detailsLabel.TextAlign = ContentAlignment.MiddleLeft;
            detailsLabel.Padding = new Padding(8, 2, 8, 2);
            ListView eventsList = new ListView();
            eventsList.Dock = DockStyle.Fill;
            eventsList.View = View.Details;
            eventsList.FullRowSelect = true;
            eventsList.GridLines = true;
            eventsList.HideSelection = false;
            eventsList.ShowItemToolTips = true;
            eventsList.Font = tile.Font;
            eventsList.Columns.Add("Time (UTC)", 135);
            eventsList.Columns.Add("Signal", 175);
            eventsList.Columns.Add("What happened", 540);
            eventsList.ItemActivate += delegate
            {
                if (eventsList.SelectedItems.Count == 0) return;
                MmdSignalEvent signal = eventsList.SelectedItems[0].Tag as MmdSignalEvent;
                if (signal == null) return;
                canvas.FocusSignal(signal.TimeMs);
                tabs.SelectedTab = chartsPage;
                chartScroll.AutoScrollPosition = Point.Empty;
            };
            eventsList.Resize += delegate
            {
                eventsList.Columns[2].Width = Math.Max(120, eventsList.ClientSize.Width -
                    eventsList.Columns[0].Width - eventsList.Columns[1].Width -
                    SystemInformation.VerticalScrollBarWidth - 8);
            };
            TableLayoutPanel signalLayout = new TableLayoutPanel();
            signalLayout.Dock = DockStyle.Fill;
            signalLayout.ColumnCount = 1;
            signalLayout.RowCount = 3;
            signalLayout.Padding = new Padding(6);
            signalLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            signalLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82));
            signalLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            signalLayout.Controls.Add(biasLabel, 0, 0);
            signalLayout.Controls.Add(detailsLabel, 0, 1);
            signalLayout.Controls.Add(eventsList, 0, 2);
            signalsPage.Controls.Add(signalLayout);

            Panel footer = new Panel();
            footer.Dock = DockStyle.Bottom;
            footer.Padding = MarketDeskStyle.TileButtonPadding;
            Label dataStatus = new Label();
            dataStatus.Dock = DockStyle.Fill;
            dataStatus.AutoSize = false;
            dataStatus.AutoEllipsis = true;
            dataStatus.TextAlign = ContentAlignment.MiddleLeft;
            dataStatus.Text = "Loading the last 30 days...";
            MarketDeskButton refreshButton = new MarketDeskButton();
            refreshButton.Text = "Refresh";
            refreshButton.Dock = DockStyle.Right;
            refreshButton.Width = 78;
            UseTileButtonLook(refreshButton);
            footer.Controls.Add(dataStatus);
            footer.Controls.Add(refreshButton);
            tile.Body.Controls.Add(tabs);
            tile.Body.Controls.Add(footer);
            tile.Body.Controls["Title"].SendToBack();
            tile.GetData = delegate { return string.Empty; };

            Font biasFont = null;
            Action applySize = delegate
            {
                int buttonHeight = Math.Max(MarketDeskStyle.TileButtonHeight, tile.Font.Height + 8);
                footer.Height = buttonHeight + footer.Padding.Vertical;
                refreshButton.Height = buttonHeight;
                dataStatus.Font = tile.Font;
                detailsLabel.Font = tile.Font;
                eventsList.Font = tile.Font;
                outcomesList.Font = tile.Font;
                outcomeMethod.Font = tile.Font;
                chartReadout.Font = tile.Font;
                canvas.Font = tile.Font;
                canvas.Height = Math.Max(800, 54 * tile.Font.Height);
                if (biasFont != null) biasFont.Dispose();
                biasFont = new Font(tile.Font, FontStyle.Bold);
                biasLabel.Font = biasFont;
                canvas.Invalidate();
            };
            tileSizeAppliers.Add(applySize);
            tileFontAppliers.Add(applySize);
            applySize();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(biasLabel,
                "Bullish/bearish here means ETH relative to BTC, not the direction of the whole crypto market. " +
                "Bullish requires ETH/BTC perpetual relative returns >= +0.30% over both 6h and 24h; bearish requires <= -0.30% " +
                "over both. Anything else is mixed. Flow is a separate confirmation.");
            tip.SetToolTip(eventsList,
                "ETH strength/weakness periods start when the 6h ETH/BTC perpetual ratio move reaches +0.30% or -0.30%; " +
                "they end after it recedes through +0.10% or -0.10%. Divergences compare confirmed ETH and BTC swing pivots " +
                "matched within 3 hours, with >= 0.15% opposing moves. Pair signals wait for the full 3h matching window " +
                "plus 3 confirmation bars after the BTC pivot. All times are UTC.");
            tip.SetToolTip(canvas,
                "30 days of 30-minute Binance ETHUSDT/BTCUSDT spot and USD-M perpetual candles. " +
                "Taker delta is taker-buy quote volume minus taker-sell quote volume. Spot and perpetual CVD are separate " +
                "30-day cumulative totals in USDT millions, reset at the data-window start. Use the spot/perp flow controls " +
                "to isolate each venue and rescale its indicators. Volume is compared with the preceding 20 bars. " +
                "The 6h pressure edge compares delta/volume, ETH minus BTC. Dashed price overlays are rolling 24h " +
                "typical-price/base-volume candle-VWAP proxies, not trade-level VWAP. " +
                "CVD divergences require >= 0.15% price moves against >= 1% of intervening quote volume in CVD, " +
                "confirmed 3 bars after the pivot. Absorption requires >= 1.5x volume, opposing >= 10% delta and " +
                "a close in the top/bottom 30% of the range; it is only a candle-level proxy. " +
                "These are descriptive market measures, not a bottom or reversal prediction.");

            bool loading = false;
            long loadedEndMs = 0;
            Action refresh = null;
            refresh = async delegate
            {
                if (loading || tile.IsDisposed) return;
                long endMs = CandleBucketStart(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(), MmdIntervalMs);
                if (endMs == loadedEndMs) return;
                loading = true;
                refreshButton.Enabled = false;
                tile.BeginBusy();
                try
                {
                    MmdSeries values = await System.Threading.Tasks.Task.Run(delegate { return DownloadMmdSeries(endMs); });
                    if (tile.IsDisposed) return;
                    MmdAnalysis analysis = BuildMmdAnalysis(values);
                    displayedValues = values;
                    canvas.SetSeries(values);
                    canvas.SetSignals(analysis.Events);
                    biasLabel.Text = analysis.Bias;
                    biasLabel.BackColor = analysis.BiasColor;
                    biasLabel.ForeColor = analysis.Bias == "MIXED / NO CLEAR ETH EDGE" ? Color.Black : Color.White;
                    detailsLabel.Text = analysis.Details;
                    PopulateMmdEvents(eventsList, analysis.Events);
                    PopulateMmdOutcomes(outcomesList, values, analysis.Events);
                    dataStatus.Text = "Binance spot + USD-M | 30D | Latest candle closed: " +
                        DateTimeOffset.FromUnixTimeMilliseconds(values.EndMs).UtcDateTime.ToString("dd MMM HH:mm",
                            System.Globalization.CultureInfo.InvariantCulture) + " UTC";
                    loadedEndMs = endMs;
                    SetDataConnected(true);
                }
                catch (Exception error)
                {
                    if (!tile.IsDisposed)
                    {
                        string text = "Could not load MMD data: " + error.Message;
                        canvas.ShowMessage(text + "\r\nUse Refresh to retry.");
                        displayedValues = null;
                        biasLabel.Text = "DATA UNAVAILABLE";
                        biasLabel.BackColor = Color.Firebrick;
                        biasLabel.ForeColor = Color.White;
                        detailsLabel.Text = text;
                        eventsList.Items.Clear();
                        outcomesList.Items.Clear();
                        dataStatus.Text = "Use Refresh to retry.";
                        SetStatus(text);
                        SetDataConnected(false);
                    }
                }
                finally
                {
                    loading = false;
                    if (!tile.IsDisposed)
                    {
                        refreshButton.Enabled = true;
                        tile.EndBusy();
                    }
                }
            };
            refreshButton.Click += delegate
            {
                loadedEndMs = 0;
                refresh();
            };
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = CandleRefreshMs;
            timer.Tick += delegate { refresh(); };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Dispose();
                tip.Dispose();
                if (biasFont != null) biasFont.Dispose();
                tileSizeAppliers.Remove(applySize);
                tileFontAppliers.Remove(applySize);
                if (mmdWindow == tile) mmdWindow = null;
            };
            refresh();
        }

        private static MmdSeries DownloadMmdSeries(long endMs)
        {
            long startMs = endMs - MmdCandleCount * MmdIntervalMs;
            MmdSeries result = new MmdSeries {
                StartMs = startMs,
                EndMs = endMs,
                IntervalMs = MmdIntervalMs,
                EthSpot = DownloadMmdMarket("ETH Spot", "ETHUSDT", "Spot", MmdSpotKlinesUrl, startMs, endMs),
                EthPerp = DownloadMmdMarket("ETH Perp", "ETHUSDT", "Perp", MmdPerpKlinesUrl, startMs, endMs),
                BtcSpot = DownloadMmdMarket("BTC Spot", "BTCUSDT", "Spot", MmdSpotKlinesUrl, startMs, endMs),
                BtcPerp = DownloadMmdMarket("BTC Perp", "BTCUSDT", "Perp", MmdPerpKlinesUrl, startMs, endMs)
            };
            return result;
        }

        private static MmdMarketSeries DownloadMmdMarket(string name, string symbol, string venue,
            string endpoint, long startMs, long endMs)
        {
            System.Collections.Generic.List<string> rows = new System.Collections.Generic.List<string>();
            long chunkMs = MoneyFlowKlineLimit * MmdIntervalMs;
            for (long start = startMs; start < endMs; start += chunkMs)
            {
                long chunkEnd = Math.Min(endMs, start + chunkMs);
                string url = endpoint + "?symbol=" + symbol + "&interval=30m&limit=" + MoneyFlowKlineLimit +
                    "&startTime=" + start.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    "&endTime=" + (chunkEnd - 1).ToString(System.Globalization.CultureInfo.InvariantCulture);
                foreach (System.Text.RegularExpressions.Match match in
                    System.Text.RegularExpressions.Regex.Matches(DownloadBinanceKlines(url), KlineLinePattern))
                {
                    rows.Add(match.Value);
                }
            }
            return ParseMmdMarket(name, symbol, venue, "[" + string.Join(",", rows.ToArray()) + "]", startMs, endMs);
        }

        private static MmdMarketSeries ParseMmdMarket(string name, string symbol, string venue,
            string json, long startMs, long endMs)
        {
            if (endMs <= startMs || (endMs - startMs) % MmdIntervalMs != 0 ||
                startMs % MmdIntervalMs != 0)
            {
                throw new FormatException("Invalid MMD time range.");
            }
            int count = checked((int)((endMs - startMs) / MmdIntervalMs));
            System.Text.RegularExpressions.MatchCollection matches =
                System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern);
            if (matches.Count != count)
            {
                throw new FormatException(name + " did not return all 30-minute candles for the 30-day range.");
            }

            MmdMarketSeries result = new MmdMarketSeries {
                Name = name,
                Symbol = symbol,
                Venue = venue,
                StartMs = startMs,
                EndMs = endMs,
                IntervalMs = MmdIntervalMs,
                Open = new double[count],
                High = new double[count],
                Low = new double[count],
                Close = new double[count],
                BaseVolume = new double[count],
                QuoteVolume = new double[count],
                QuoteDelta = new double[count],
                CumulativeQuoteDelta = new double[count],
                PriceChangePercent = new double[count],
                VolumeVsAverage = new double[count],
                DeltaPercent = new double[count],
                CumulativeDeltaPercent = new double[count]
            };

            int cursor = 0;
            decimal cumulativeDelta = 0;
            decimal cumulativeVolume = 0;
            decimal firstClose = 0;
            for (int i = 0; i < count; i++)
            {
                System.Text.RegularExpressions.Match match = matches[i];
                long time;
                decimal[] fields;
                if (json.Substring(cursor, match.Index - cursor).Trim() != (i == 0 ? "[" : ",") ||
                    !TryReadPriceMinute(match.Value, out time, out fields) ||
                    time != startMs + i * MmdIntervalMs ||
                    fields[6] != time + MmdIntervalMs - 1 ||
                    fields[3] <= 0 || fields[2] < fields[3] ||
                    fields[1] < fields[3] || fields[1] > fields[2] ||
                    fields[4] < fields[3] || fields[4] > fields[2] ||
                    fields[5] < 0 || fields[7] < 0 ||
                    fields[9] < 0 || fields[9] > fields[5] ||
                    fields[10] < 0 || fields[10] > fields[7])
                {
                    throw new FormatException("Invalid, missing or out-of-order " + name + " candle at index " + i + ".");
                }
                cursor = match.Index + match.Length;
                decimal quoteDelta = fields[10] - (fields[7] - fields[10]);
                if (i == 0) firstClose = fields[4];
                result.Open[i] = (double)fields[1];
                result.High[i] = (double)fields[2];
                result.Low[i] = (double)fields[3];
                result.Close[i] = (double)fields[4];
                result.BaseVolume[i] = (double)fields[5];
                result.QuoteVolume[i] = (double)fields[7];
                result.QuoteDelta[i] = (double)quoteDelta;
                cumulativeDelta += quoteDelta;
                cumulativeVolume += fields[7];
                result.CumulativeQuoteDelta[i] = (double)cumulativeDelta;
                result.PriceChangePercent[i] = ((double)(fields[4] / firstClose) - 1) * 100;
                result.DeltaPercent[i] = fields[7] > 0 ? (double)(quoteDelta / fields[7] * 100) : double.NaN;
                result.CumulativeDeltaPercent[i] = cumulativeVolume > 0 ?
                    (double)(cumulativeDelta / cumulativeVolume * 100) : double.NaN;
                if (i >= 20)
                {
                    double average = 0;
                    for (int bar = i - 20; bar < i; bar++) average += result.QuoteVolume[bar];
                    average /= 20;
                    result.VolumeVsAverage[i] = average > 0 ? result.QuoteVolume[i] / average : double.NaN;
                }
                else
                {
                    result.VolumeVsAverage[i] = double.NaN;
                }
            }
            if (json.Substring(cursor).Trim() != "]")
            {
                throw new FormatException("Invalid " + name + " kline response.");
            }
            return result;
        }

        private static MmdMarketSeries[] GetMmdMarkets(MmdSeries values)
        {
            return new MmdMarketSeries[] { values.EthSpot, values.EthPerp, values.BtcSpot, values.BtcPerp };
        }

        private static double MmdRsi(double[] closes)
        {
            if (closes.Length < 15) return double.NaN;
            double gain = 0;
            double loss = 0;
            for (int i = 1; i <= 14; i++)
            {
                double change = closes[i] - closes[i - 1];
                if (change > 0) gain += change;
                else loss -= change;
            }
            gain /= 14;
            loss /= 14;
            for (int i = 15; i < closes.Length; i++)
            {
                double change = closes[i] - closes[i - 1];
                gain = (gain * 13 + Math.Max(0, change)) / 14;
                loss = (loss * 13 + Math.Max(0, -change)) / 14;
            }
            if (loss == 0) return gain == 0 ? 50 : 100;
            double relativeStrength = gain / loss;
            return 100 - 100 / (1 + relativeStrength);
        }

        private static MmdAnalysis BuildMmdAnalysis(MmdSeries values)
        {
            int last = values.EthPerp.Close.Length - 1;
            double relative6h = MmdRelativeChange(values.EthPerp, values.BtcPerp, last, 12);
            double relative24h = MmdRelativeChange(values.EthPerp, values.BtcPerp, last, 48);
            double relative30d = MmdRelativeChange(values.EthPerp, values.BtcPerp, last, last);
            double spotRelative6h = MmdRelativeChange(values.EthSpot, values.BtcSpot, last, 12);
            double spotRelative24h = MmdRelativeChange(values.EthSpot, values.BtcSpot, last, 48);
            double spotFlow = MmdDeltaPercent(values.EthSpot, 12) - MmdDeltaPercent(values.BtcSpot, 12);
            double perpFlow = MmdDeltaPercent(values.EthPerp, 12) - MmdDeltaPercent(values.BtcPerp, 12);
            string bias;
            Color color;
            if (relative6h >= 0.30 && relative24h >= 0.30)
            {
                bias = "BULLISH FOR ETH vs BTC";
                color = Color.FromArgb(25, 125, 70);
            }
            else if (relative6h <= -0.30 && relative24h <= -0.30)
            {
                bias = "BEARISH FOR ETH vs BTC";
                color = Color.FromArgb(170, 45, 45);
            }
            else
            {
                bias = "MIXED / NO CLEAR ETH EDGE";
                color = Color.FromArgb(245, 220, 150);
            }

            string flowRead = spotFlow > 0 && perpFlow > 0 ? "spot and perp flow confirm ETH"
                : spotFlow < 0 && perpFlow < 0 ? "spot and perp flow favor BTC"
                : "spot/perp flow is mixed";
            string rsi = "RSI14 30m: ETH " + MmdRsi(values.EthPerp.Close).ToString("0",
                System.Globalization.CultureInfo.InvariantCulture) + " / BTC " +
                MmdRsi(values.BtcPerp.Close).ToString("0", System.Globalization.CultureInfo.InvariantCulture) + ".";
            string details = "ETH/BTC return - perp: 6h " + MmdSignedPercent(relative6h) +
                ", 24h " + MmdSignedPercent(relative24h) + ", 30d " + MmdSignedPercent(relative30d) +
                "; spot: 6h " + MmdSignedPercent(spotRelative6h) +
                ", 24h " + MmdSignedPercent(spotRelative24h) +
                ". 6h taker-delta edge vs BTC: spot " + MmdSignedNumber(spotFlow) +
                " pp, perp " + MmdSignedNumber(perpFlow) + " pp (" + flowRead + "). " + rsi +
                "\r\nBullish: both perp horizons >= +0.30%; bearish: both <= -0.30%; otherwise mixed. " +
                "This is ETH vs BTC, not the whole market.";

            System.Collections.Generic.List<MmdSignalEvent> events = BuildMmdEvents(values);
            MmdSignalEvent latestDivergence = null;
            foreach (MmdSignalEvent item in events)
            {
                if (item.Signal.IndexOf("divergence", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    latestDivergence = item;
                    break;
                }
            }
            if (latestDivergence != null)
            {
                details += "\r\nLatest confirmed divergence: " + latestDivergence.Signal + " at " +
                    FormatMmdUtc(latestDivergence.TimeMs) + " UTC.";
            }
            return new MmdAnalysis { Bias = bias, Details = details, BiasColor = color, Events = events };
        }

        private static double MmdRelativeChange(MmdMarketSeries eth, MmdMarketSeries btc, int endIndex, int bars)
        {
            int startIndex = Math.Max(0, endIndex - bars);
            double initialRatio = eth.Close[startIndex] / btc.Close[startIndex];
            double finalRatio = eth.Close[endIndex] / btc.Close[endIndex];
            return (finalRatio / initialRatio - 1) * 100;
        }

        private static double MmdDeltaPercent(MmdMarketSeries market, int bars)
        {
            int endIndex = market.QuoteDelta.Length - 1;
            int startIndex = Math.Max(0, endIndex - bars + 1);
            double delta = 0;
            double volume = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                delta += market.QuoteDelta[i];
                volume += market.QuoteVolume[i];
            }
            return volume > 0 ? delta / volume * 100 : 0;
        }

        private static System.Collections.Generic.List<MmdSignalEvent> BuildMmdEvents(MmdSeries values)
        {
            System.Collections.Generic.List<MmdSignalEvent> events = BuildMmdRelativeStrengthPeriods(values);
            events.AddRange(FindMmdDivergences(values, true));
            events.AddRange(FindMmdDivergences(values, false));
            events.AddRange(FindMmdCvdDivergences(values, values.EthSpot, "Spot", "S", true));
            events.AddRange(FindMmdCvdDivergences(values, values.EthSpot, "Spot", "S", false));
            events.AddRange(FindMmdCvdDivergences(values, values.EthPerp, "Perp", "F", true));
            events.AddRange(FindMmdCvdDivergences(values, values.EthPerp, "Perp", "F", false));
            events.AddRange(FindMmdAbsorption(values));
            events.Sort(delegate(MmdSignalEvent left, MmdSignalEvent right)
            {
                return right.TimeMs.CompareTo(left.TimeMs);
            });
            return events;
        }

        private static System.Collections.Generic.List<MmdSignalEvent> BuildMmdRelativeStrengthPeriods(MmdSeries values)
        {
            const double enterPercent = 0.30;
            const double exitPercent = 0.10;
            System.Collections.Generic.List<MmdSignalEvent> events = new System.Collections.Generic.List<MmdSignalEvent>();
            int state = 0;
            int startIndex = -1;
            double strongestMove = 0;
            int last = values.EthPerp.Close.Length - 1;
            for (int i = 12; i <= last; i++)
            {
                double relative6h = MmdRelativeChange(values.EthPerp, values.BtcPerp, i, 12);
                bool exited = state > 0 && relative6h < exitPercent || state < 0 && relative6h > -exitPercent;
                if (exited)
                {
                    AddMmdStrengthPeriod(events, values, state, startIndex, i - 1, strongestMove, false);
                    state = 0;
                }

                int nextState = relative6h >= enterPercent ? 1 : relative6h <= -enterPercent ? -1 : 0;
                if (state == 0 && nextState != 0)
                {
                    state = nextState;
                    startIndex = i;
                    strongestMove = relative6h;
                }
                else if (state != 0)
                {
                    strongestMove = state > 0 ? Math.Max(strongestMove, relative6h) :
                        Math.Min(strongestMove, relative6h);
                }
            }
            if (state != 0)
            {
                AddMmdStrengthPeriod(events, values, state, startIndex, last, strongestMove, true);
            }
            return events;
        }

        private static void AddMmdStrengthPeriod(System.Collections.Generic.List<MmdSignalEvent> events,
            MmdSeries values, int state, int startIndex, int endIndex, double strongestMove, bool active)
        {
            long startMs = values.StartMs + (startIndex + 1) * values.IntervalMs;
            long endMs = values.StartMs + (endIndex + 1) * values.IntervalMs;
            double hours = Math.Max(0.5, (endMs - startMs) / 3600000.0);
            string extremeLabel = state > 0 ? "peak 6h ETH/BTC move " : "worst 6h ETH/BTC move ";
            string detail = (active ? "Active now; " : "Ended " + FormatMmdUtc(endMs) + " UTC; ") +
                "lasted " + hours.ToString("0.#", System.Globalization.CultureInfo.InvariantCulture) +
                "h; " + extremeLabel + MmdSignedPercent(strongestMove) + ".";
            events.Add(new MmdSignalEvent {
                TimeMs = startMs,
                Signal = state > 0 ? "ETH strength period" : "ETH weakness period",
                Details = detail,
                Bullish = state > 0
            });
        }

        private static System.Collections.Generic.List<MmdSwingPoint> FindMmdSwingPoints(double[] values, bool lows)
        {
            System.Collections.Generic.List<MmdSwingPoint> points = new System.Collections.Generic.List<MmdSwingPoint>();
            for (int i = 3; i < values.Length - 3; i++)
            {
                bool pivot = true;
                for (int offset = 1; offset <= 3; offset++)
                {
                    if (lows ? values[i] >= values[i - offset] || values[i] > values[i + offset]
                        : values[i] <= values[i - offset] || values[i] < values[i + offset])
                    {
                        pivot = false;
                        break;
                    }
                }
                if (pivot) points.Add(new MmdSwingPoint { Index = i, Price = values[i] });
            }
            return points;
        }

        private static System.Collections.Generic.List<MmdSignalEvent> FindMmdDivergences(MmdSeries values, bool lows)
        {
            const int maximumPairGap = 6;
            const double minimumDifferencePercent = 0.15;
            double[] ethValues = lows ? values.EthPerp.Low : values.EthPerp.High;
            double[] btcValues = lows ? values.BtcPerp.Low : values.BtcPerp.High;
            System.Collections.Generic.List<MmdSwingPoint> ethPoints = FindMmdSwingPoints(ethValues, lows);
            System.Collections.Generic.List<MmdSwingPoint> btcPoints = FindMmdSwingPoints(btcValues, lows);
            System.Collections.Generic.List<MmdPivotPair> pairs = new System.Collections.Generic.List<MmdPivotPair>();
            bool[] usedEthPoints = new bool[ethPoints.Count];
            int lastEthIndex = -1;
            foreach (MmdSwingPoint btcPoint in btcPoints)
            {
                // Wait out the entire +/-3h matching window plus pivot confirmation.
                // Future candles can then never replace this pair in a later refresh.
                if (btcPoint.Index + maximumPairGap + 3 >= btcValues.Length) continue;
                int best = -1;
                int bestGap = maximumPairGap + 1;
                for (int i = 0; i < ethPoints.Count; i++)
                {
                    if (usedEthPoints[i] || ethPoints[i].Index <= lastEthIndex) continue;
                    int gap = Math.Abs(ethPoints[i].Index - btcPoint.Index);
                    if (gap <= maximumPairGap && gap < bestGap)
                    {
                        best = i;
                        bestGap = gap;
                    }
                }
                if (best >= 0)
                {
                    usedEthPoints[best] = true;
                    lastEthIndex = ethPoints[best].Index;
                    pairs.Add(new MmdPivotPair { Eth = ethPoints[best], Btc = btcPoint });
                }
            }

            System.Collections.Generic.List<MmdSignalEvent> events = new System.Collections.Generic.List<MmdSignalEvent>();
            for (int i = 1; i < pairs.Count; i++)
            {
                MmdPivotPair previous = pairs[i - 1];
                MmdPivotPair current = pairs[i];
                double ethChange = (current.Eth.Price / previous.Eth.Price - 1) * 100;
                double btcChange = (current.Btc.Price / previous.Btc.Price - 1) * 100;
                bool bullish = lows && btcChange <= -minimumDifferencePercent && ethChange >= minimumDifferencePercent;
                bool bearish = !lows && btcChange >= minimumDifferencePercent && ethChange <= -minimumDifferencePercent;
                if (!bullish && !bearish) continue;
                int confirmationIndex = current.Btc.Index + maximumPairGap + 3;
                long eventTime = values.StartMs + (confirmationIndex + 1) * values.IntervalMs;
                string detail = lows
                    ? "BTC lower low " + MmdSignedPercent(btcChange) + "; ETH higher low " + MmdSignedPercent(ethChange) + "."
                    : "BTC higher high " + MmdSignedPercent(btcChange) + "; ETH lower high " + MmdSignedPercent(ethChange) + ".";
                events.Add(new MmdSignalEvent {
                    TimeMs = eventTime,
                    Signal = bullish ? "Bullish ETH/BTC divergence" : "Bearish ETH/BTC divergence",
                    Details = detail + " Both legs >= 0.15%; confirmed 30m pivots matched within 3h.",
                    Bullish = bullish,
                    PreviousPivot = previous.Eth.Index,
                    Pivot = current.Eth.Index,
                    PreviousBtcPivot = previous.Btc.Index,
                    BtcPivot = current.Btc.Index,
                    Marker = "P"
                });
            }
            return events;
        }

        private static System.Collections.Generic.List<MmdSignalEvent> FindMmdCvdDivergences(
            MmdSeries values, MmdMarketSeries flow, string venue, string marker, bool lows)
        {
            System.Collections.Generic.List<MmdSignalEvent> events = new System.Collections.Generic.List<MmdSignalEvent>();
            System.Collections.Generic.List<MmdSwingPoint> pivots = FindMmdSwingPoints(
                lows ? values.EthPerp.Low : values.EthPerp.High, lows);
            for (int p = 1; p < pivots.Count; p++)
            {
                MmdSwingPoint before = pivots[p - 1];
                MmdSwingPoint current = pivots[p];
                double priceMove = (current.Price / before.Price - 1) * 100;
                double cvdMove = flow.CumulativeQuoteDelta[current.Index] - flow.CumulativeQuoteDelta[before.Index];
                double volume = 0;
                for (int i = before.Index + 1; i <= current.Index; i++) volume += flow.QuoteVolume[i];
                if (volume <= 0) continue;
                double pressure = cvdMove / volume * 100;
                bool detected = lows ? priceMove <= -0.15 && pressure >= 1 : priceMove >= 0.15 && pressure <= -1;
                if (!detected) continue;
                events.Add(new MmdSignalEvent {
                    TimeMs = values.StartMs + (current.Index + 4) * values.IntervalMs,
                    Signal = venue + " CVD " + (lows ? "bullish divergence" : "bearish divergence"),
                    Details = "ETH " + (lows ? "lower low" : "higher high") + " " + MmdSignedPercent(priceMove) +
                        " but " + venue.ToLowerInvariant() + " CVD " + (lows ? "rose " : "fell ") +
                        MoneyFlowCanvas.FormatUsdt(Math.Abs(cvdMove)) + " USDT (" + MmdSignedPercent(pressure) +
                        " of intervening volume). Confirmed 3 bars later.",
                    Bullish = lows, PreviousPivot = before.Index, Pivot = current.Index, Marker = marker
                });
            }
            return events;
        }

        private static System.Collections.Generic.List<MmdSignalEvent> FindMmdAbsorption(MmdSeries values)
        {
            System.Collections.Generic.List<MmdSignalEvent> events = new System.Collections.Generic.List<MmdSignalEvent>();
            MmdMarketSeries market = values.EthPerp;
            for (int i = 20; i < market.Close.Length; i++)
            {
                double range = market.High[i] - market.Low[i];
                if (range <= 0 || double.IsNaN(market.VolumeVsAverage[i]) || market.VolumeVsAverage[i] < 1.5) continue;
                double closeLocation = (market.Close[i] - market.Low[i]) / range;
                bool buy = market.DeltaPercent[i] <= -10 && closeLocation >= 0.7 && market.Close[i] >= market.Open[i];
                bool sell = market.DeltaPercent[i] >= 10 && closeLocation <= 0.3 && market.Close[i] <= market.Open[i];
                if (!buy && !sell) continue;
                events.Add(new MmdSignalEvent {
                    TimeMs = values.StartMs + (i + 1) * values.IntervalMs,
                    Signal = buy ? "Possible buy absorption" : "Possible sell absorption",
                    Details = "ETH perp: " + market.VolumeVsAverage[i].ToString("0.0",
                        System.Globalization.CultureInfo.InvariantCulture) + "x volume, delta " +
                        MmdSignedPercent(market.DeltaPercent[i]) + ", close in " + (buy ? "top" : "bottom") +
                        " 30% of range against aggressive flow. Candle-level proxy, not order-book proof.",
                    Bullish = buy, Pivot = i, Marker = "A"
                });
            }
            return events;
        }

        private static string MmdSignedPercent(double value)
        {
            return MmdSignedNumber(value) + "%";
        }

        private const double MmdRoundTripCostPercent = 0.10;

        private static bool TryMmdOutcome(MmdSeries values, MmdSignalEvent signal, int bars, out MmdOutcome outcome)
        {
            outcome = null;
            long offset = signal.TimeMs - values.StartMs;
            if (bars <= 0 || offset < 0 || offset % values.IntervalMs != 0)
                throw new ArgumentException("Outcome requires an aligned confirmation time and positive horizon.");
            int entry = checked((int)(offset / values.IntervalMs));
            int exit = entry + bars - 1;
            if (exit >= values.EthPerp.Close.Length) return false;
            int direction = signal.Bullish ? 1 : -1;
            double ethEntry = values.EthPerp.Open[entry];
            double btcEntry = values.BtcPerp.Open[entry];
            double ethReturn = (values.EthPerp.Close[exit] / ethEntry - 1) * 100;
            double ratioReturn = ((values.EthPerp.Close[exit] / values.BtcPerp.Close[exit]) /
                (ethEntry / btcEntry) - 1) * 100;
            double adverse = 0;
            for (int i = entry; i <= exit; i++)
            {
                double extreme = signal.Bullish ? values.EthPerp.Low[i] : values.EthPerp.High[i];
                adverse = Math.Min(adverse, direction * (extreme / ethEntry - 1) * 100);
            }
            outcome = new MmdOutcome {
                EntryIndex = entry, ExitIndex = exit,
                NetEthPercent = direction * ethReturn - MmdRoundTripCostPercent,
                RelativePercent = direction * ratioReturn, AdversePercent = adverse
            };
            return true;
        }

        private static System.Collections.Generic.List<MmdOutcomeStats> BuildMmdOutcomes(MmdSeries values,
            System.Collections.Generic.List<MmdSignalEvent> signals)
        {
            System.Collections.Generic.List<MmdSignalEvent> chronological = new System.Collections.Generic.List<MmdSignalEvent>(signals);
            chronological.Sort(delegate(MmdSignalEvent left, MmdSignalEvent right) { return left.TimeMs.CompareTo(right.TimeMs); });
            System.Collections.Generic.SortedDictionary<string, System.Collections.Generic.List<MmdSignalEvent>> groups =
                new System.Collections.Generic.SortedDictionary<string, System.Collections.Generic.List<MmdSignalEvent>>(StringComparer.Ordinal);
            foreach (MmdSignalEvent signal in chronological)
            {
                if (!groups.ContainsKey(signal.Signal)) groups.Add(signal.Signal, new System.Collections.Generic.List<MmdSignalEvent>());
                groups[signal.Signal].Add(signal);
            }
            System.Collections.Generic.List<MmdOutcomeStats> result = new System.Collections.Generic.List<MmdOutcomeStats>();
            foreach (System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.List<MmdSignalEvent>> group in groups)
            {
                foreach (int hours in new int[] { 6, 24 })
                {
                    int bars = hours * 2;
                    MmdOutcomeStats stats = new MmdOutcomeStats { Signal = group.Key, Hours = hours };
                    int lastExit = -1;
                    foreach (MmdSignalEvent signal in group.Value)
                    {
                        MmdOutcome sample;
                        if (!TryMmdOutcome(values, signal, bars, out sample))
                        {
                            stats.Pending++;
                            continue;
                        }
                        if (sample.EntryIndex <= lastExit)
                        {
                            stats.Overlapping++;
                            continue;
                        }
                        stats.Samples.Add(sample);
                        lastExit = sample.ExitIndex;
                    }
                    for (int entry = 48; entry + bars <= values.EthPerp.Close.Length; entry += bars)
                    {
                        MmdOutcome baseline;
                        MmdSignalEvent reference = new MmdSignalEvent {
                            TimeMs = values.StartMs + entry * values.IntervalMs, Bullish = group.Value[0].Bullish
                        };
                        if (TryMmdOutcome(values, reference, bars, out baseline))
                        {
                            stats.BaselineCount++;
                            stats.BaselineNet += baseline.NetEthPercent;
                        }
                    }
                    if (stats.BaselineCount > 0) stats.BaselineNet /= stats.BaselineCount;
                    result.Add(stats);
                }
            }
            return result;
        }

        private static void PopulateMmdOutcomes(ListView list, MmdSeries values,
            System.Collections.Generic.List<MmdSignalEvent> signals)
        {
            list.BeginUpdate();
            list.Items.Clear();
            foreach (MmdOutcomeStats stats in BuildMmdOutcomes(values, signals))
            {
                int count = stats.Samples.Count;
                double mean = 0, relative = 0, worst = 0;
                int wins = 0;
                System.Collections.Generic.List<double> returns = new System.Collections.Generic.List<double>();
                foreach (MmdOutcome sample in stats.Samples)
                {
                    mean += sample.NetEthPercent;
                    relative += sample.RelativePercent;
                    worst = Math.Min(worst, sample.AdversePercent);
                    if (sample.NetEthPercent > 0) wins++;
                    returns.Add(sample.NetEthPercent);
                }
                returns.Sort();
                double median = count == 0 ? 0 : count % 2 == 0 ?
                    (returns[count / 2 - 1] + returns[count / 2]) / 2 : returns[count / 2];
                ListViewItem row = new ListViewItem(stats.Signal);
                row.SubItems.Add(stats.Hours + "h");
                row.SubItems.Add(count + (count < 20 ? " (small)" : ""));
                row.SubItems.Add(stats.Pending.ToString(System.Globalization.CultureInfo.InvariantCulture));
                row.SubItems.Add(stats.Overlapping.ToString(System.Globalization.CultureInfo.InvariantCulture));
                row.SubItems.Add(count == 0 ? "n/a" : (wins * 100.0 / count).ToString("0.0",
                    System.Globalization.CultureInfo.InvariantCulture) + "%");
                row.SubItems.Add(count == 0 ? "n/a" : MmdSignedPercent(mean / count));
                row.SubItems.Add(count == 0 ? "n/a" : MmdSignedPercent(median));
                row.SubItems.Add(count == 0 ? "n/a" : MmdSignedPercent(worst));
                row.SubItems.Add(count == 0 ? "n/a" : MmdSignedPercent(relative / count));
                row.SubItems.Add(stats.BaselineCount == 0 ? "n/a" : MmdSignedPercent(stats.BaselineNet) + " (n=" + stats.BaselineCount + ")");
                row.SubItems.Add(count == 0 || stats.BaselineCount == 0 ? "n/a" : MmdSignedPercent(mean / count - stats.BaselineNet));
                list.Items.Add(row);
            }
            if (list.Items.Count == 0) list.Items.Add("No signals detected; no outcomes to estimate.");
            list.EndUpdate();
        }

        private static string MmdSignedNumber(double value)
        {
            return value.ToString("+0.00;-0.00;0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private static string FormatMmdUtc(long timeMs)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(timeMs).UtcDateTime.ToString("dd MMM HH:mm",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        private static void PopulateMmdEvents(ListView list, System.Collections.Generic.List<MmdSignalEvent> events)
        {
            list.BeginUpdate();
            list.Items.Clear();
            int count = events.Count;
            for (int i = 0; i < count; i++)
            {
                MmdSignalEvent signal = events[i];
                ListViewItem row = new ListViewItem(FormatMmdUtc(signal.TimeMs));
                row.SubItems.Add(signal.Signal);
                row.SubItems.Add(signal.Details);
                row.Tag = signal;
                row.ToolTipText = signal.Details;
                row.ForeColor = signal.Bullish ? Color.DarkGreen : Color.Firebrick;
                list.Items.Add(row);
            }
            if (count == 0)
            {
                ListViewItem empty = new ListViewItem("No signals");
                empty.SubItems.Add("None confirmed");
                empty.SubItems.Add("No ETH strength/weakness periods or swing divergences in this 30-day sample.");
                list.Items.Add(empty);
            }
            list.EndUpdate();
        }

        private const string TradingViewTileName = "TradingView Chart";
        private const string TradingViewKlinesUrl = "https://fapi.binance.com/fapi/v1/klines?symbol=BTCUSDT&interval=15m&limit=1000";
        private const long TradingViewIntervalMs = 15 * MinuteMs;

        private static void OpenTradingView()
        {
            if (tradingViewWindow != null && !tradingViewWindow.IsDisposed)
            {
                tradingViewWindow.SelectTile();
                return;
            }
            Size size = new Size(920, 520);
            Point spot = FindSpot(size);
            tradingViewWindow = CreateToolWindow(TradingViewTileName, size, spot);
            workspacePanel.Controls.Add(tradingViewWindow);
            BuildTradingView(tradingViewWindow);
            SaveTiles();
        }

        private static void BuildTradingView(MarketDeskTile tile)
        {
            TradingViewChartCanvas canvas = new TradingViewChartCanvas();
            canvas.Dock = DockStyle.Fill;
            tile.Body.Controls.Add(canvas);
            tile.Body.Controls["Title"].SendToBack();
            Action applySize = delegate { canvas.Invalidate(); };
            tileSizeAppliers.Add(applySize);
            tileFontAppliers.Add(applySize);

            bool loading = false;
            Action<Exception> showFailure = delegate(Exception error)
            {
                if (tile.IsDisposed) return;
                string text = "Could not load Binance futures BTCUSDT candles: " + error.Message;
                canvas.ShowMessage(text + "\r\nThe chart retries every minute.");
                SetStatus(text);
                SetDataConnected(false);
            };
            Action refresh = null;
            refresh = async delegate
            {
                if (loading || tile.IsDisposed) return;
                loading = true;
                tile.BeginBusy();
                try
                {
                    TradingViewSeries values = await System.Threading.Tasks.Task.Run(delegate
                    {
                        return ParseTradingViewSeries(DownloadBinanceKlines(TradingViewKlinesUrl), DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
                    });
                    if (tile.IsDisposed) return;
                    canvas.SetSeries(values, VolumeRejectionRules.Detect(values));
                    SetDataConnected(true);
                }
                catch (System.Net.WebException error) { showFailure(error); }
                catch (System.IO.IOException error) { showFailure(error); }
                catch (FormatException error) { showFailure(error); }
                catch (OverflowException error) { showFailure(error); }
                finally
                {
                    loading = false;
                    if (!tile.IsDisposed) tile.EndBusy();
                }
            };
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = CandleRefreshMs;
            timer.Tick += delegate { refresh(); };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Dispose();
                tileSizeAppliers.Remove(applySize);
                tileFontAppliers.Remove(applySize);
                if (tradingViewWindow == tile) tradingViewWindow = null;
            };
            refresh();
        }

        // Only closed candles are kept: the newest candle is still forming and its values can change.
        private static TradingViewSeries ParseTradingViewSeries(string json, long nowMs)
        {
            System.Collections.Generic.List<long> times = new System.Collections.Generic.List<long>();
            System.Collections.Generic.List<decimal[]> rows = new System.Collections.Generic.List<decimal[]>();
            foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern))
            {
                long time;
                decimal[] fields;
                if (!TryReadPriceMinute(match.Value, out time, out fields) ||
                    (times.Count > 0 && time != times[times.Count - 1] + TradingViewIntervalMs) ||
                    fields[6] != time + TradingViewIntervalMs - 1 ||
                    fields[3] <= 0 || fields[2] < fields[3] ||
                    fields[1] < fields[3] || fields[1] > fields[2] ||
                    fields[4] < fields[3] || fields[4] > fields[2])
                    throw new FormatException("Invalid, missing or out-of-order Binance candle at index " + times.Count + ".");
                times.Add(time);
                rows.Add(fields);
            }
            int count = rows.Count;
            if (count > 0 && rows[count - 1][6] >= nowMs) count--;
            if (count < VolumeRejectionRules.AtrPeriod + VolumeRejectionRules.ConfirmBars + 2)
                throw new FormatException("Binance returned too few closed candles.");

            TradingViewSeries result = new TradingViewSeries();
            result.StartMs = times[0];
            result.IntervalMs = TradingViewIntervalMs;
            result.Open = new double[count];
            result.High = new double[count];
            result.Low = new double[count];
            result.Close = new double[count];
            result.Volume = new double[count];
            for (int i = 0; i < count; i++)
            {
                result.Open[i] = (double)rows[i][1];
                result.High[i] = (double)rows[i][2];
                result.Low[i] = (double)rows[i][3];
                result.Close[i] = (double)rows[i][4];
                result.Volume[i] = (double)rows[i][5];
            }
            return result;
        }

        private const string PerpChartTileName = "Perp Chart";
        private const string PerpChartKlinesUrl = "https://fapi.binance.com/fapi/v1/klines?symbol=BTCUSDT&limit=1500&interval=";
        private static readonly string[] PerpChartIntervals = { "1m", "5m", "15m", "30m", "1h", "2h", "4h", "1d" };
        private const string PerpChartDefaultInterval = "15m";
        private const int PerpChartToolbarHeight = 32;

        private static void OpenPerpChart()
        {
            if (perpChartWindow != null && !perpChartWindow.IsDisposed)
            {
                perpChartWindow.SelectTile();
                return;
            }
            Size size = new Size(920, 560);
            Point spot = FindSpot(size);
            perpChartWindow = CreateToolWindow(PerpChartTileName, size, spot);
            workspacePanel.Controls.Add(perpChartWindow);
            BuildPerpChart(perpChartWindow, PerpChartSettings.Load(PerpChartSettings.AmatStatePath));
            SaveTiles();
        }

        private static long PerpChartIntervalMs(string interval)
        {
            switch (interval)
            {
                case "1m": return MinuteMs;
                case "5m": return 5 * MinuteMs;
                case "15m": return 15 * MinuteMs;
                case "30m": return 30 * MinuteMs;
                case "1h": return 60 * MinuteMs;
                case "2h": return 120 * MinuteMs;
                case "4h": return 240 * MinuteMs;
                case "1d": return 1440 * MinuteMs;
                default: throw new ArgumentException("Unsupported chart interval " + interval + ".");
            }
        }

        // Same mapping as AMAT's profile source intervals; equal intervals reuse the displayed candles.
        internal static string PerpProfileSourceInterval(string interval)
        {
            switch (interval)
            {
                case "5m": return "1m";
                case "15m": return "5m";
                case "30m": return "5m";
                case "1h": return "30m";
                case "2h": return "30m";
                case "4h": return "1h";
                case "1d": return "4h";
                default: return interval;
            }
        }

        // Pages forward from fromMs so the source candles cover the whole displayed span.
        private static System.Collections.Generic.List<PerpCandle> DownloadPerpSourceCandles(string interval, long fromMs, long nowMs)
        {
            long sourceMs = PerpChartIntervalMs(interval);
            System.Collections.Generic.List<PerpCandle> result = new System.Collections.Generic.List<PerpCandle>();
            long cursor = fromMs;
            while (cursor + sourceMs <= nowMs)
            {
                System.Collections.Generic.List<PerpCandle> page = ParsePerpCandles(
                    DownloadBinanceKlines(PerpChartKlinesUrl + interval + "&startTime=" + cursor), sourceMs);
                result.AddRange(page);
                cursor = page[page.Count - 1].Time + sourceMs;
            }
            return result;
        }

        // Same mapping as AMAT's getTpoSourceInterval: 30m up to 4h, otherwise 4h.
        internal static string PerpTpoSourceInterval(string interval)
        {
            return PerpChartIntervalMs(interval) <= PerpChartIntervalMs("4h") ? "30m" : "4h";
        }

        // Source candles for one interval, downloaded once per refresh; the displayed candles are reused when the intervals match.
        private static System.Collections.Generic.List<PerpCandle> PerpSourceCandles(string sourceInterval, string displayInterval,
            System.Collections.Generic.List<PerpCandle> display, long nowMs,
            System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PerpCandle>> cache)
        {
            System.Collections.Generic.List<PerpCandle> cached;
            if (cache.TryGetValue(sourceInterval, out cached)) return cached;
            long sourceMs = PerpChartIntervalMs(sourceInterval);
            System.Collections.Generic.List<PerpCandle> result = sourceMs == PerpChartIntervalMs(displayInterval)
                ? display
                : DownloadPerpSourceCandles(sourceInterval, display[0].Time / sourceMs * sourceMs, nowMs);
            cache[sourceInterval] = result;
            return result;
        }

        // Loads the displayed candles plus the profile and TPO sources for one refresh.
        private static PerpChartData LoadPerpChartData(string url, string interval, long nowMs)
        {
            PerpChartData data = new PerpChartData();
            data.Display = ParsePerpCandles(DownloadBinanceKlines(url), PerpChartIntervalMs(interval));
            System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PerpCandle>> cache =
                new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PerpCandle>>();
            data.Profile = PerpSourceCandles(PerpProfileSourceInterval(interval), interval, data.Display, nowMs, cache);
            data.TpoInterval = PerpTpoSourceInterval(interval);
            data.Tpo = PerpSourceCandles(data.TpoInterval, interval, data.Display, nowMs, cache);
            return data;
        }

        private static void BuildPerpChart(MarketDeskTile tile, PerpChartSettings settings)
        {
            PerpChartCanvas canvas = new PerpChartCanvas(settings);
            FlowLayoutPanel toolbar = new FlowLayoutPanel();
            toolbar.BackColor = PerpChartCanvas.BackgroundColor;
            toolbar.WrapContents = false;
            toolbar.Padding = new Padding(4, 4, 4, 0);
            tile.Body.Controls.Add(canvas);
            tile.Body.Controls.Add(toolbar);

            string[] typeValues = { "candles", "line", "smart" };
            ComboBox typeBox = new ComboBox();
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.Items.AddRange(new object[] { "Candles", "Line", "Smart" });
            typeBox.SelectedIndex = Math.Max(0, Array.IndexOf(typeValues, settings.ChartType));
            typeBox.Width = 90;
            typeBox.SelectedIndexChanged += delegate { canvas.ChartType = typeValues[typeBox.SelectedIndex]; };
            toolbar.Controls.Add(typeBox);

            string interval = Array.IndexOf(PerpChartIntervals, settings.Interval) >= 0 ? settings.Interval : PerpChartDefaultInterval;
            Action refresh = null;
            System.Collections.Generic.List<Button> buttons = new System.Collections.Generic.List<Button>();
            Action highlight = delegate
            {
                foreach (Button button in buttons)
                {
                    button.BackColor = (string)button.Tag == interval ? Color.FromArgb(54, 60, 76) : PerpChartCanvas.BackgroundColor;
                }
            };
            foreach (string name in PerpChartIntervals)
            {
                string intervalName = name;
                Button button = new Button();
                button.Text = intervalName == "1d" ? "1D" : intervalName;
                button.Tag = intervalName;
                button.Width = 42;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Silver;
                button.Click += delegate
                {
                    interval = intervalName;
                    highlight();
                    refresh();
                };
                buttons.Add(button);
                toolbar.Controls.Add(button);
            }
            highlight();

            Action layoutBody = delegate
            {
                Control title = tile.Body.Controls["Title"];
                int top = title == null ? 0 : title.Bottom;
                toolbar.Bounds = new Rectangle(0, top, tile.Body.ClientSize.Width, PerpChartToolbarHeight);
                canvas.Bounds = new Rectangle(0, top + PerpChartToolbarHeight, tile.Body.ClientSize.Width,
                    Math.Max(1, tile.Body.ClientSize.Height - top - PerpChartToolbarHeight));
            };
            tile.Body.Resize += delegate { layoutBody(); };
            layoutBody();

            bool loading = false;
            bool pending = false;
            Action<Exception> showFailure = delegate(Exception error)
            {
                if (tile.IsDisposed) return;
                string text = "Could not load Binance futures BTCUSDT candles: " + error.Message;
                canvas.ShowMessage(text + "\r\nThe chart retries every minute.");
                SetStatus(text);
                SetDataConnected(false);
            };
            refresh = async delegate
            {
                if (tile.IsDisposed) return;
                if (loading)
                {
                    pending = true;
                    return;
                }
                loading = true;
                tile.BeginBusy();
                string requested = interval;
                long intervalMs = PerpChartIntervalMs(requested);
                long profileMs = PerpChartIntervalMs(PerpProfileSourceInterval(requested));
                string url = PerpChartKlinesUrl + requested;
                try
                {
                    long nowMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    PerpChartData data = await System.Threading.Tasks.Task.Run(delegate
                    {
                        return LoadPerpChartData(url, requested, nowMs);
                    });
                    if (tile.IsDisposed) return;
                    canvas.SetCandles(data.Display, intervalMs);
                    canvas.SetSourceCandles(data.Profile, profileMs < intervalMs ? profileMs : 0);
                    canvas.SetTpoCandles(data.Tpo, PerpChartIntervalMs(data.TpoInterval), data.TpoInterval);
                    SetDataConnected(true);
                }
                catch (System.Net.WebException error) { showFailure(error); }
                catch (System.IO.IOException error) { showFailure(error); }
                catch (FormatException error) { showFailure(error); }
                catch (OverflowException error) { showFailure(error); }
                finally
                {
                    loading = false;
                    if (!tile.IsDisposed) tile.EndBusy();
                }
                if (pending && !tile.IsDisposed)
                {
                    pending = false;
                    refresh();
                }
            };
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = CandleRefreshMs;
            timer.Tick += delegate { refresh(); };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Dispose();
                if (perpChartWindow == tile) perpChartWindow = null;
            };
            refresh();
        }

        // The newest candle may still be forming; it is kept, as AMAT keeps it.
        private static System.Collections.Generic.List<PerpCandle> ParsePerpCandles(string json, long intervalMs)
        {
            System.Collections.Generic.List<PerpCandle> result = new System.Collections.Generic.List<PerpCandle>();
            foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern))
            {
                long time;
                decimal[] fields;
                if (!TryReadPriceMinute(match.Value, out time, out fields) ||
                    (result.Count > 0 && time != result[result.Count - 1].Time + intervalMs) ||
                    fields[6] != time + intervalMs - 1 ||
                    fields[3] <= 0 || fields[2] < fields[3] ||
                    fields[1] < fields[3] || fields[1] > fields[2] ||
                    fields[4] < fields[3] || fields[4] > fields[2])
                    throw new FormatException("Invalid, missing or out-of-order Binance candle at index " + result.Count + ".");
                PerpCandle candle = new PerpCandle();
                candle.Time = time;
                candle.Open = (double)fields[1];
                candle.High = (double)fields[2];
                candle.Low = (double)fields[3];
                candle.Close = (double)fields[4];
                candle.Volume = (double)fields[5];
                result.Add(candle);
            }
            if (result.Count == 0) throw new FormatException("Binance returned no candles.");
            return result;
        }

        private static void OpenOrderBookDelta()
        {
            if (orderBookDeltaWindow != null && !orderBookDeltaWindow.IsDisposed)
            {
                orderBookDeltaWindow.SelectTile();
                return;
            }
            Size size = new Size(640, MarketDeskStyle.ToolWindowHeight + MarketDeskStyle.TileTitleHeight);
            Point spot = FindSpot(size);
            orderBookDeltaWindow = CreateToolWindow("Order Book Delta", size, spot);
            workspacePanel.Controls.Add(orderBookDeltaWindow);
            BuildOrderBookDelta(orderBookDeltaWindow);
            SaveTiles();
        }

        private static void BuildOrderBookDelta(MarketDeskTile tile)
        {
            OrderBookDeltaCanvas canvas = new OrderBookDeltaCanvas();
            canvas.Dock = DockStyle.Fill;
            Panel footer = new Panel();
            footer.Dock = DockStyle.Bottom;
            footer.Padding = MarketDeskStyle.TileButtonPadding;
            Label stateLabel = new Label();
            stateLabel.Dock = DockStyle.Fill;
            stateLabel.TextAlign = ContentAlignment.MiddleLeft;
            stateLabel.Text = "Connecting to Binance order book...";
            footer.Controls.Add(stateLabel);
            tile.Body.Controls.Add(canvas);
            tile.Body.Controls.Add(footer);
            tile.Body.Controls["Title"].SendToBack();
            Action applySize = delegate
            {
                footer.Height = Math.Max(MarketDeskStyle.TileButtonHeight, tile.Font.Height + 8) +
                    footer.Padding.Vertical;
                canvas.Invalidate();
            };
            tileSizeAppliers.Add(applySize);
            tileFontAppliers.Add(applySize);
            applySize();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(canvas, "Net change in resting BTCUSDT futures liquidity from order book updates: size added on bids minus size added on asks.\r\n" +
                "Includes cancellations, so it is a proxy for limit-order activity, not an exact limit-order CVD.\r\n" +
                "Starts at zero when the tile opens. Updates missed while reconnecting are not filled in.");

            OrderBookDeltaFeed feed = new OrderBookDeltaFeed(DownloadBinanceKlines);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += delegate
            {
                if (tile.IsDisposed) return;
                OrderBookDeltaSnapshot snapshot = feed.Snapshot();
                canvas.SetSnapshot(snapshot);
                stateLabel.Text = snapshot.State;
            };
            timer.Start();
            tile.Disposed += delegate
            {
                timer.Dispose();
                feed.Stop();
                tip.Dispose();
                tileSizeAppliers.Remove(applySize);
                tileFontAppliers.Remove(applySize);
                if (orderBookDeltaWindow == tile) orderBookDeltaWindow = null;
            };
        }

        private static MoneyFlowSeries DownloadMoneyFlow(MoneyFlowRange range, long endMs)
        {
            long firstMs = endMs - range.Candles * range.IntervalMs;
            return ParseMoneyFlow(DownloadMoneyFlowKlines(range, firstMs, endMs), range, endMs);
        }

        private static string DownloadMoneyFlowKlines(MoneyFlowRange range, long firstMs, long endMs)
        {
            System.Collections.Generic.List<string> rows = new System.Collections.Generic.List<string>();
            long chunkMs = MoneyFlowKlineLimit * range.IntervalMs;
            for (long start = firstMs; start < endMs; start += chunkMs)
            {
                long chunkEnd = Math.Min(endMs, start + chunkMs);
                string url = MoneyFlowKlinesUrl + "&interval=" + range.Interval + "&limit=" + MoneyFlowKlineLimit +
                    "&startTime=" + start.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    "&endTime=" + (chunkEnd - 1).ToString(System.Globalization.CultureInfo.InvariantCulture);
                foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(DownloadBinanceKlines(url), KlineLinePattern))
                    rows.Add(match.Value);
            }
            return "[" + string.Join(",", rows.ToArray()) + "]";
        }

        // Quote volumes are Binance's actual USDT notionals, not BTC volume multiplied by a candle price.
        private static MoneyFlowSeries ParseMoneyFlow(string json, MoneyFlowRange range, long endMs)
        {
            int count = range.Candles;
            long firstMs = endMs - count * range.IntervalMs;
            System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(json, KlineLinePattern);
            if (matches.Count != count) throw new FormatException("Binance did not return the complete " + range.Label.ToLowerInvariant() + " range.");
            decimal[] quoteDeltas = new decimal[count];
            MoneyFlowSeries result = new MoneyFlowSeries();
            result.StartMs = firstMs;
            result.EndMs = endMs;
            result.IntervalMs = range.IntervalMs;
            result.Open = new double[count];
            result.High = new double[count];
            result.Low = new double[count];
            result.Close = new double[count];
            result.BuyVolume = new double[count];
            result.SellVolume = new double[count];
            int cursor = 0;
            for (int i = 0; i < count; i++)
            {
                System.Text.RegularExpressions.Match match = matches[i];
                long time;
                decimal[] fields;
                if (json.Substring(cursor, match.Index - cursor).Trim() != (i == 0 ? "[" : ",") ||
                    !TryReadPriceMinute(match.Value, out time, out fields) ||
                    time != firstMs + i * range.IntervalMs || fields[6] != time + range.IntervalMs - 1 ||
                    fields[3] <= 0 || fields[2] < fields[3] ||
                    fields[1] < fields[3] || fields[1] > fields[2] ||
                    fields[4] < fields[3] || fields[4] > fields[2] ||
                    fields[9] > fields[5] || fields[10] > fields[7])
                    throw new FormatException("Invalid, missing or out-of-order Binance candle at index " + i + ".");
                cursor = match.Index + match.Length;
                quoteDeltas[i] = fields[10] - (fields[7] - fields[10]);
                result.BuyVolume[i] = (double)fields[10];
                result.SellVolume[i] = (double)(fields[7] - fields[10]);
                result.Open[i] = (double)fields[1];
                result.High[i] = (double)fields[2];
                result.Low[i] = (double)fields[3];
                result.Close[i] = (double)fields[4];
            }
            if (json.Substring(cursor).Trim() != "]") throw new FormatException("Invalid Binance kline response.");
            double[] cumulative = new double[count + 1];
            decimal running = 0;
            for (int i = 0; i < count; i++)
            {
                running += quoteDeltas[i];
                cumulative[i + 1] = (double)running;
            }
            result.QuoteDelta = cumulative;
            return result;
        }

        // Builds the closes for the chart and the POC from the volume of every minute in the range.
        private static void ShowDataChartSeries(DataChartCanvas canvas, System.Collections.Generic.List<CandleHour> minutes)
        {
            if (minutes == null || minutes.Count < 2)
            {
                canvas.ShowMessage("No price data for this range yet.");
                return;
            }

            double[] closes = new double[minutes.Count];
            System.Collections.Generic.Dictionary<long, double> total = new System.Collections.Generic.Dictionary<long, double>();
            for (int i = 0; i < minutes.Count; i++)
            {
                closes[i] = minutes[i].Close;
                MergeVolumes(total, minutes[i].TotalByBucket);
            }

            System.Collections.Generic.List<ChartLevel> levels = new System.Collections.Generic.List<ChartLevel>();
            double price;
            double high;
            double low;
            if (TryFindPoc(total, out price))
            {
                levels.Add(new ChartLevel("POC", price, Color.Gray));
            }
            if (TryFindValueArea(total, out high, out low))
            {
                levels.Add(new ChartLevel("VAH", high, Color.Blue));
                levels.Add(new ChartLevel("VAL", low, Color.Blue));
            }
            canvas.SetSeries(closes, levels);
        }


        // Saved as "lineArgb|backgroundArgb". Missing or bad values fall back to the defaults.
        private static string WriteDataChartColors(Color lineColor, Color backColor)
        {
            return lineColor.ToArgb().ToString() + "|" + backColor.ToArgb().ToString();
        }

        private static void ReadDataChartColors(string data, out Color lineColor, out Color backColor)
        {
            lineColor = Color.Gray;
            backColor = MarketDeskStyle.ToolWindowBodyBackground;
            if (string.IsNullOrEmpty(data))
            {
                return;
            }
            string[] parts = data.Split('|');
            int line;
            int back;
            if (parts.Length == 2 && int.TryParse(parts[0], out line) && int.TryParse(parts[1], out back))
            {
                lineColor = Color.FromArgb(line);
                backColor = Color.FromArgb(back);
            }
        }

        // The open Candle Data tile that the Data Chart always follows, or null when it is closed.
        private static MarketDeskTile FindCandleDataTile()
        {
            if (candleDataWindow == null || candleDataWindow.IsDisposed)
            {
                return null;
            }
            return candleDataWindow;
        }

        private static readonly string[] CandleRowNames = {
            "Change %", "Delta", "CVD", "Candle POC", "VAH", "VAL", "Buyer POC", "Seller POC", "Low Sell Vol", "Low Seller POC", "High Buy Vol", "High Buyer POC",
            "Pressure %", "Efficiency", "Price / CVD", "Delta Z", "Move Surprise"
        };
        private static readonly string[] CandleMetricDescriptions = {
            "Delta / total BTC volume x 100. Green: net buying; red: net selling.",
            "Dollar price move per 1,000 BTC of delta. n/a if absolute delta is below 1% of volume. "
                + "Green/red only when price and delta agree, coloured by price direction.",
            "This candle's price direction / CVD change direction. Up/Up is green; Down/Down is red. "
                + "Opposite or flat directions are grey, not reversal signals.",
            "Delta standard deviations above/below the average of earlier visible candles (at least 3). "
                + "Green at +2 or higher; red at -2 or lower; otherwise grey.",
            "Actual dollar move minus the move expected from a price/delta regression on earlier visible candles (at least 3). "
                + "Green: stronger than expected; red: weaker. Not a forecast. Baselines change when columns change."
        };

        private static Form CreatePriceDataDialog(MarketDeskTile tile, string title, string question,
            out Label message, out Button cancel, out Button confirm)
        {
            Form dialog = new Form();
            dialog.Text = title;
            dialog.Font = tile.Font;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.MinimizeBox = false;
            dialog.MaximizeBox = false;
            message = new Label();
            message.Text = question;
            cancel = new Button();
            cancel.Text = "Cancel";
            cancel.DialogResult = DialogResult.Cancel;
            confirm = new Button();
            confirm.Text = "Confirm";
            confirm.DialogResult = DialogResult.OK;
            dialog.Controls.AddRange(new Control[] { message, cancel, confirm });
            dialog.CancelButton = cancel;
            LayoutPriceDataDialog(dialog, message, cancel, confirm, null, null, false);
            return dialog;
        }

        private static void LayoutPriceDataDialog(Form dialog, Label message, Button cancel, Button confirm,
            Label percentage, ProgressBar bar, bool showProgress)
        {
            const int padding = 10;
            int buttonWidth = Math.Max(65, TextRenderer.MeasureText("Confirm", dialog.Font).Width + 16);
            int buttonHeight = Math.Max(24, dialog.Font.Height + 10);
            int contentWidth = Math.Max(260, buttonWidth * 2 + 8);
            int messageHeight = TextRenderer.MeasureText(message.Text, dialog.Font,
                new Size(contentWidth, int.MaxValue), TextFormatFlags.WordBreak).Height;
            message.Bounds = new Rectangle(padding, padding, contentWidth, messageHeight);
            int y = padding + messageHeight + 10;
            if (showProgress)
            {
                percentage.Bounds = new Rectangle(padding, y, contentWidth, dialog.Font.Height + 4);
                y += percentage.Height + 4;
                bar.Bounds = new Rectangle(padding, y, contentWidth, 16);
                y += bar.Height + 10;
            }
            cancel.Bounds = new Rectangle(padding + contentWidth - buttonWidth * 2 - 8, y, buttonWidth, buttonHeight);
            confirm.Bounds = new Rectangle(padding + contentWidth - buttonWidth, y, buttonWidth, buttonHeight);
            dialog.ClientSize = new Size(contentWidth + padding * 2, y + buttonHeight + padding);
        }

        private static void ShowPriceValidationDialog(MarketDeskTile tile)
        {
            Label message;
            Button cancel;
            Button confirm;
            using (Form dialog = CreatePriceDataDialog(tile, "Validate Data",
                "Are you sure you would like to validate price data?", out message, out cancel, out confirm))
            {
                confirm.DialogResult = DialogResult.None;
                Label percentage = new Label();
                percentage.Text = "0%";
                percentage.Visible = false;
                ProgressBar bar = new ProgressBar();
                bar.Maximum = 10000;
                bar.Visible = false;
                dialog.Controls.AddRange(new Control[] { percentage, bar });
                bool running = false;
                bool showProgress = false;
                Action layoutDialog = delegate
                {
                    LayoutPriceDataDialog(dialog, message, cancel, confirm, percentage, bar, showProgress);
                };
                layoutDialog();
                dialog.FormClosing += delegate(object sender, FormClosingEventArgs args)
                {
                    if (running) args.Cancel = true;
                };
                confirm.Click += async delegate
                {
                    if (running) return;
                    running = true;
                    confirm.Enabled = false;
                    cancel.Enabled = false;
                    percentage.Visible = true;
                    bar.Visible = true;
                    showProgress = true;
                    message.Text = "Validating saved price data against Binance...";
                    layoutDialog();
                    tile.BeginBusy();
                    Progress<double> progress = new Progress<double>(delegate(double fraction)
                    {
                        if (dialog.IsDisposed) return;
                        bar.Value = Math.Max(0, Math.Min(bar.Maximum, (int)(fraction * bar.Maximum)));
                        percentage.Text = (fraction * 100).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "%";
                    });
                    try
                    {
                        string report = await System.Threading.Tasks.Task.Run(delegate
                        {
                            return ValidateSavedPrices(delegate(double fraction) { ((IProgress<double>)progress).Report(fraction); });
                        });
                        bar.Value = bar.Maximum;
                        percentage.Text = "100.00%";
                        message.Text = "Validation completed. No saved data was changed.";
                        layoutDialog();
                        SetStatus("Price data validation completed.");
                        MessageBox.Show(dialog, report, "Validate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        message.Text = "Validation failed.";
                        layoutDialog();
                        SetStatus("Price data validation failed: " + error.Message);
                        MessageBox.Show(dialog, error.Message, "Validate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        running = false;
                        if (!tile.IsDisposed) tile.EndBusy();
                        cancel.Text = "Close";
                        cancel.Enabled = true;
                    }
                };
                dialog.ShowDialog(tile.FindForm());
            }
        }

        private static MarketDeskButton[] CreateCandleButtons(Panel panel)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 400;
            toolTip.AutoPopDelay = 10000;
            panel.Disposed += delegate { toolTip.Dispose(); };
            MarketDeskButton[] buttons = new MarketDeskButton[4];
            for (int button = 0; button < buttons.Length; button++)
            {
                buttons[button] = new MarketDeskButton();
                buttons[button].PreventInitialSelection();
                UseTileButtonLook(buttons[button]);
                buttons[button].Text = button == 0 ? "+" : button == 1 ? "?" : button == 2 ? "<" : "-";
                buttons[button].Enabled = button < 3;
                buttons[button].AccessibleName = button == 0 ? "Add Column" : button == 1 ? "Validate Data" : button == 2 ? "Clean Price Data" : "Remove Oldest Column";
                toolTip.SetToolTip(buttons[button], buttons[button].AccessibleName);
                panel.Controls.Add(buttons[button]);
            }
            return buttons;
        }

        private static void LayoutCandleButtons(MarketDeskButton[] buttons)
        {
            int side = MarketDeskStyle.TileButtonHeight;
            int top = Math.Max(0, (buttons[0].Parent.ClientSize.Height - side) / 2);
            for (int button = 0; button < buttons.Length; button++)
            {
                buttons[button].Bounds = new Rectangle(5 + button * (side + 2), top, side, side);
            }
        }

        private static void ClearCandleValues(Label[] times, Label[][] rows, Label[] totals)
        {
            for (int column = 0; column < times.Length - CandleStatCount; column++)
            {
                times[column].Text = string.Empty;
            }
            foreach (Label[] row in rows)
            {
                foreach (Label cell in row) SetCandleCell(cell, string.Empty, Color.DimGray);
            }
            foreach (Label total in totals) total.Text = string.Empty;
        }

        private static void ReadCandleSettings(string data, out string timeFrame, out int candleCount)
        {
            bool[] rowVisible;
            ReadCandleSettings(data, out timeFrame, out candleCount, out rowVisible);
        }

        private static void ReadCandleSettings(string data, out string timeFrame, out int candleCount,
            out bool[] rowVisible)
        {
            string[] parts = data.Split('|');
            timeFrame = parts[0];
            candleCount = CandleCount;
            rowVisible = new bool[CandleRowCount];
            for (int row = 0; row < CandleRowCount; row++)
            {
                rowVisible[row] = true;
            }
            if (parts.Length > 4 || (parts.Length >= 2 &&
                (!int.TryParse(parts[1], System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out candleCount) ||
                 candleCount < CandleCount || candleCount > int.MaxValue - CandleStatCount - 2)))
            {
                throw new FormatException("Invalid saved Candle Data period count.");
            }
            if (parts.Length >= 3)
            {
                bool legacyMetricVisibility;
                if (bool.TryParse(parts[2], out legacyMetricVisibility))
                {
                    // Older saves had one switch for the metric rows (Pressure % and below).
                    for (int row = CandleMetricStartRow; row < CandleRowCount; row++)
                    {
                        rowVisible[row] = legacyMetricVisibility;
                    }
                }
                else if (!TryReadCandleRowMask(parts[2], rowVisible))
                {
                    throw new FormatException("Invalid saved Candle Data row visibility setting.");
                }
            }
        }

        // One character per row, in CandleRowNames order: 1 = shown, 0 = hidden.
        private static string WriteCandleRowMask(bool[] rowVisible)
        {
            char[] mask = new char[CandleRowCount];
            for (int row = 0; row < CandleRowCount; row++)
            {
                mask[row] = rowVisible[row] ? '1' : '0';
            }
            return new string(mask);
        }

        private static bool TryReadCandleRowMask(string mask, bool[] rowVisible)
        {
            if (mask.Length != CandleRowCount)
            {
                return false;
            }
            for (int row = 0; row < CandleRowCount; row++)
            {
                if (mask[row] != '0' && mask[row] != '1')
                {
                    return false;
                }
                rowVisible[row] = mask[row] == '1';
            }
            return true;
        }

        private static void SetCandleMetricRowsVisible(TableLayoutPanel grid, Label[][] rows, bool[] rowVisible)
        {
            int visibleRowCount = 0;
            foreach (bool visible in rowVisible)
            {
                if (visible) visibleRowCount++;
            }
            for (int row = 0; row < CandleRowCount; row++)
            {
                bool visible = rowVisible[row];
                Control rowName = grid.GetControlFromPosition(0, row + 1);
                if (rowName != null)
                {
                    rowName.Visible = visible;
                }
                foreach (Label cell in rows[row])
                {
                    cell.Visible = visible;
                }
                RowStyle style = grid.RowStyles[row + 1];
                style.SizeType = visible ? SizeType.Percent : SizeType.Absolute;
                style.Height = visible ? 100f / visibleRowCount : 0f;
            }
        }

        private static void ApplyCandleGridMargins(TableLayoutPanel grid)
        {
            foreach (Control cell in grid.Controls)
            {
                int column = grid.GetColumn(cell);
                int row = grid.GetRow(cell);
                cell.Margin = new Padding(0, row == 0 ? 1 : 0, column < grid.ColumnCount - 1 ? 1 : 0, row < grid.RowCount - 1 ? 1 : 0);
            }
        }

        private static void PrependCandleColumn(TableLayoutPanel grid, System.Collections.Generic.List<Label> headerCells, ref Label[] timeCells, Label[][] rows)
        {
            grid.SuspendLayout();
            try
            {
                grid.ColumnCount++;
                grid.ColumnStyles.Insert(1, new ColumnStyle(SizeType.Percent));
                foreach (Control cell in grid.Controls)
                {
                    int column = grid.GetColumn(cell);
                    if (column > 0)
                    {
                        grid.SetColumn(cell, column + 1);
                    }
                }
                for (int column = 1; column < grid.ColumnCount; column++)
                {
                    if (grid.ColumnStyles[column].SizeType == SizeType.Percent)
                        grid.ColumnStyles[column].Width = 100f / (grid.ColumnCount - 1);
                }

                Label[] expandedTimes = new Label[timeCells.Length + 1];
                Array.Copy(timeCells, 0, expandedTimes, 1, timeCells.Length);
                expandedTimes[0] = CreateCandleHeaderCell("...", ContentAlignment.MiddleCenter);
                headerCells.Add(expandedTimes[0]);
                grid.Controls.Add(expandedTimes[0], 1, 0);
                timeCells = expandedTimes;
                for (int row = 0; row < rows.Length; row++)
                {
                    Label[] expandedRow = new Label[rows[row].Length + 1];
                    Array.Copy(rows[row], 0, expandedRow, 1, rows[row].Length);
                    expandedRow[0] = CreateCandleCell();
                    grid.Controls.Add(expandedRow[0], 1, row + 1);
                    rows[row] = expandedRow;
                }
                Label blankCell = CreateCandleCell();
                blankCell.Text = string.Empty;
                grid.Controls.Add(blankCell, 1, CandleRowCount + 1);
                ApplyCandleGridMargins(grid);
            }
            finally
            {
                grid.ResumeLayout();
            }
        }

        private static void RemoveOldestCandleColumn(TableLayoutPanel grid, System.Collections.Generic.List<Label> headerCells, ref Label[] timeCells, Label[][] rows)
        {
            if (timeCells.Length <= CandleCount + 1 + CandleStatCount)
            {
                return;
            }

            Label oldestHeader = timeCells[0];
            headerCells.Remove(oldestHeader);
            grid.SuspendLayout();
            try
            {
                Control[] removedCells = new Control[grid.Controls.Count];
                int removedCellCount = 0;
                foreach (Control cell in grid.Controls)
                {
                    int column = grid.GetColumn(cell);
                    if (column == 1)
                    {
                        removedCells[removedCellCount++] = cell;
                    }
                    else if (column > 1)
                    {
                        grid.SetColumn(cell, column - 1);
                    }
                }
                for (int cell = 0; cell < removedCellCount; cell++)
                {
                    grid.Controls.Remove(removedCells[cell]);
                    removedCells[cell].Dispose();
                }

                grid.ColumnStyles.RemoveAt(1);
                grid.ColumnCount--;
                for (int column = 1; column < grid.ColumnCount; column++)
                {
                    if (grid.ColumnStyles[column].SizeType == SizeType.Percent)
                        grid.ColumnStyles[column].Width = 100f / (grid.ColumnCount - 1);
                }

                Label[] reducedTimes = new Label[timeCells.Length - 1];
                Array.Copy(timeCells, 1, reducedTimes, 0, reducedTimes.Length);
                timeCells = reducedTimes;
                for (int row = 0; row < rows.Length; row++)
                {
                    Label[] reducedRow = new Label[rows[row].Length - 1];
                    Array.Copy(rows[row], 1, reducedRow, 0, reducedRow.Length);
                    rows[row] = reducedRow;
                }
                ApplyCandleGridMargins(grid);
            }
            finally
            {
                grid.ResumeLayout();
            }
        }

        private static void SizeCandleTotalColumn(TableLayoutPanel grid, Label header, Label[] totals)
        {
            int width = TextRenderer.MeasureText(header.Text, header.Font,
                Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding).Width;
            foreach (Label total in totals)
            {
                width = Math.Max(width, TextRenderer.MeasureText(total.Text, total.Font,
                    Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding).Width);
            }
            ColumnStyle column = grid.ColumnStyles[grid.GetColumn(header)];
            column.SizeType = SizeType.Absolute;
            if (column.Width != width + 8) column.Width = width + 8;
        }

        private static Label CreateCandleCell()
        {
            Label cell = new Label();
            cell.Dock = DockStyle.Fill;
            cell.Margin = Padding.Empty;
            cell.TextAlign = ContentAlignment.MiddleCenter;
            cell.BackColor = MarketDeskStyle.ToolWindowBodyBackground;
            cell.ForeColor = Color.DimGray;
            cell.Text = "...";
            return cell;
        }

        // Bold cell for the time row and row names, in the same grey as the title strip.
        private static Label CreateCandleHeaderCell(string text, ContentAlignment align)
        {
            Label cell = new Label();
            cell.Dock = DockStyle.Fill;
            cell.Margin = Padding.Empty;
            cell.TextAlign = align;
            cell.BackColor = MarketDeskStyle.TileTitleBackground;
            cell.ForeColor = Color.Black;
            cell.Text = text;
            return cell;
        }

        // One hour of candles, built from its 1m candles. Volume is split across price buckets for the POC rows.
        private sealed class CandleHour
        {
            public readonly long OpenTimeMs;
            public readonly double Open;
            public double High = double.MinValue;
            public double Low = double.MaxValue;
            public double Close;
            public double Volume;
            public double TakerBuyVolume;
            public readonly System.Collections.Generic.Dictionary<long, double> TotalByBucket = new System.Collections.Generic.Dictionary<long, double>();
            public readonly System.Collections.Generic.Dictionary<long, double> BuyByBucket = new System.Collections.Generic.Dictionary<long, double>();
            public readonly System.Collections.Generic.Dictionary<long, double> SellByBucket = new System.Collections.Generic.Dictionary<long, double>();

            public CandleHour(long openTimeMs, double open)
            {
                OpenTimeMs = openTimeMs;
                Open = open;
            }

            // Spreads one minute's volume over the buckets its range covers, in proportion to the overlap,
            // the same way the AMAT volume profile spreads each candle over its price rows.
            public void AddMinute(double open, double high, double low, double close, double volume, double takerBuyVolume)
            {
                High = Math.Max(High, high);
                Low = Math.Min(Low, low);
                Close = close;
                Volume += volume;
                TakerBuyVolume += takerBuyVolume;

                double buy = takerBuyVolume;
                double sell = volume - takerBuyVolume;
                long lowBucket = (long)Math.Floor(low / PocBucketSize + 0.5);
                long highBucket = (long)Math.Floor(high / PocBucketSize + 0.5);
                double range = high - low;
                for (long bucket = lowBucket; bucket <= highBucket; bucket++)
                {
                    double share = 1;
                    if (highBucket > lowBucket)
                    {
                        double bucketLow = (bucket - 0.5) * PocBucketSize;
                        share = (Math.Min(high, bucketLow + PocBucketSize) - Math.Max(low, bucketLow)) / range;
                    }
                    AddVolume(TotalByBucket, bucket, volume * share);
                    AddVolume(BuyByBucket, bucket, buy * share);
                    AddVolume(SellByBucket, bucket, sell * share);
                }
            }

            private static void AddVolume(System.Collections.Generic.Dictionary<long, double> volumes, long bucket, double amount)
            {
                double current;
                volumes.TryGetValue(bucket, out current);
                volumes[bucket] = current + amount;
            }
        }

        // Reads the Binance 1m klines reply and groups the minutes into candles of candleMs length, oldest first.
        // Each minute is [open time, open, high, low, close, volume, close time, quote volume, trades, taker buy base volume, ...].
        // The last candle is the one still forming, so it is the live column.
        private static System.Collections.Generic.List<CandleHour> ParseCandles(string json, long candleMs, int candleCount)
        {
            System.Collections.Generic.Dictionary<long, CandleHour> hours = new System.Collections.Generic.Dictionary<long, CandleHour>();
            System.Collections.Generic.List<long> order = new System.Collections.Generic.List<long>();
            System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(json, CandleMinutePattern);
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                long minuteMs = long.Parse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture);
                long hourMs = CandleBucketStart(minuteMs, candleMs);
                CandleHour hour;
                if (!hours.TryGetValue(hourMs, out hour))
                {
                    hour = new CandleHour(hourMs, double.Parse(match.Groups[2].Value, System.Globalization.CultureInfo.InvariantCulture));
                    hours.Add(hourMs, hour);
                    order.Add(hourMs);
                }
                hour.AddMinute(
                    double.Parse(match.Groups[2].Value, System.Globalization.CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[3].Value, System.Globalization.CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[4].Value, System.Globalization.CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[5].Value, System.Globalization.CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[6].Value, System.Globalization.CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[7].Value, System.Globalization.CultureInfo.InvariantCulture));
            }

            System.Collections.Generic.List<CandleHour> result = new System.Collections.Generic.List<CandleHour>();
            int newest = order.Count - 1;
            for (int i = Math.Max(0, newest - candleCount); i <= newest; i++)
            {
                result.Add(hours[order[i]]);
            }
            return result;
        }

        // Returns the midpoint of the bucket with the most volume in the map. Returns false if the map is empty.
        private static bool TryFindPoc(System.Collections.Generic.Dictionary<long, double> volumes, out double price)
        {
            price = 0;
            if (volumes.Count == 0)
            {
                return false;
            }

            long bestBucket = 0;
            double bestVolume = double.MinValue;
            foreach (System.Collections.Generic.KeyValuePair<long, double> pair in volumes)
            {
                if (pair.Value > bestVolume)
                {
                    bestVolume = pair.Value;
                    bestBucket = pair.Key;
                }
            }
            price = bestBucket * PocBucketSize;
            return true;
        }

        // Value area: the buckets around the POC that hold 70% of the volume, always growing toward the larger neighbour.
        // Returns the high and low prices of that area. Returns false if the map is empty.
        private static bool TryFindValueArea(System.Collections.Generic.Dictionary<long, double> volumes, out double high, out double low)
        {
            high = 0;
            low = 0;
            double pocPrice;
            if (!TryFindPoc(volumes, out pocPrice))
            {
                return false;
            }

            System.Collections.Generic.List<long> buckets = new System.Collections.Generic.List<long>(volumes.Keys);
            buckets.Sort();
            double total = 0;
            foreach (double volume in volumes.Values) total += volume;
            int pocIndex = buckets.IndexOf((long)(pocPrice / PocBucketSize));
            int lo = pocIndex;
            int hi = pocIndex;
            double included = volumes[buckets[pocIndex]];
            while (included < total * ValueAreaShare && (lo > 0 || hi < buckets.Count - 1))
            {
                double below = lo > 0 ? volumes[buckets[lo - 1]] : -1;
                double above = hi < buckets.Count - 1 ? volumes[buckets[hi + 1]] : -1;
                if (above >= below)
                {
                    hi++;
                    included += above;
                }
                else
                {
                    lo--;
                    included += below;
                }
            }
            high = buckets[hi] * PocBucketSize;
            low = buckets[lo] * PocBucketSize;
            return true;
        }

        // The sell volume in the lowest ZoneShare of the candle's range.
        private static System.Collections.Generic.Dictionary<long, double> LowZoneSellVolumes(
            System.Collections.Generic.Dictionary<long, double> sellByBucket, double low, double high)
        {
            double cutoff = low + ZoneShare * (high - low);
            System.Collections.Generic.Dictionary<long, double> zone = new System.Collections.Generic.Dictionary<long, double>();
            foreach (System.Collections.Generic.KeyValuePair<long, double> bucket in sellByBucket)
            {
                if (bucket.Key * PocBucketSize <= cutoff)
                {
                    zone[bucket.Key] = bucket.Value;
                }
            }
            return zone;
        }

        // The buy volume in the highest ZoneShare of the candle's range.
        private static System.Collections.Generic.Dictionary<long, double> HighZoneBuyVolumes(
            System.Collections.Generic.Dictionary<long, double> buyByBucket, double low, double high)
        {
            double cutoff = high - ZoneShare * (high - low);
            System.Collections.Generic.Dictionary<long, double> zone = new System.Collections.Generic.Dictionary<long, double>();
            foreach (System.Collections.Generic.KeyValuePair<long, double> bucket in buyByBucket)
            {
                if (bucket.Key * PocBucketSize >= cutoff)
                {
                    zone[bucket.Key] = bucket.Value;
                }
            }
            return zone;
        }

        private static void SetCandleCell(Label cell, string text, Color color)
        {
            cell.Text = text;
            cell.ForeColor = color;
            cell.BackColor = MarketDeskStyle.ToolWindowBodyBackground;
        }

        private static void SetMetricCell(Label cell, string text, int direction)
        {
            SetCandleCell(cell, text, SystemColors.ControlText);
            cell.BackColor = direction > 0 ? Color.FromArgb(195, 235, 195)
                : direction < 0 ? Color.FromArgb(245, 195, 195) : MarketDeskStyle.TileTitleBackground;
        }

        private static void ShowCandleMetrics(Label[][] rows, int column, CandleHour candle, double delta,
            System.Collections.Generic.List<double> priorDeltas, System.Collections.Generic.List<double> priorMoves,
            System.Collections.Generic.List<double>[] values)
        {
            double move = candle.Close - candle.Open;
            for (int row = CandleMetricStartRow; row < CandleRowCount; row++) SetMetricCell(rows[row][column], "n/a", 0);
            if (candle.Volume > 0)
            {
                double pressure = delta / candle.Volume * 100;
                values[12].Add(pressure);
                SetMetricCell(rows[12][column], FormatRowStat(pressure, 12), Math.Sign(pressure));
                if (delta != 0 && Math.Abs(delta) / candle.Volume >= 0.01)
                {
                    double efficiency = move / delta * 1000;
                    values[13].Add(efficiency);
                    SetMetricCell(rows[13][column], FormatRowStat(efficiency, 13),
                        Math.Sign(move) == Math.Sign(delta) ? Math.Sign(move) : 0);
                }
            }
            int priceDirection = Math.Sign(move);
            int cvdDirection = Math.Sign(delta);
            string priceText = priceDirection > 0 ? "Up" : priceDirection < 0 ? "Down" : "Flat";
            string cvdText = cvdDirection > 0 ? "Up" : cvdDirection < 0 ? "Down" : "Flat";
            SetMetricCell(rows[14][column], priceText + "/" + cvdText,
                priceDirection == cvdDirection ? priceDirection : 0);

            if (priorDeltas.Count >= 3)
            {
                double average = SumOf(priorDeltas) / priorDeltas.Count;
                double squared = 0;
                foreach (double previous in priorDeltas) squared += (previous - average) * (previous - average);
                double deviation = Math.Sqrt(squared / priorDeltas.Count);
                if (deviation > 0)
                {
                    double z = (delta - average) / deviation;
                    values[15].Add(z);
                    SetMetricCell(rows[15][column], FormatRowStat(z, 15), z >= 2 ? 1 : z <= -2 ? -1 : 0);
                }
                double slope;
                double intercept;
                double rSquared;
                if (TryFitPriceDelta(priorDeltas, priorMoves, out slope, out intercept, out rSquared))
                {
                    double surprise = move - (intercept + slope * delta);
                    if (Math.Abs(surprise) < 0.005) surprise = 0;
                    values[16].Add(surprise);
                    SetMetricCell(rows[16][column], FormatRowStat(surprise, 16), Math.Sign(surprise));
                }
            }
        }

        private static void SetCandleValue(Label cell, double value)
        {
            SetCandleCell(cell, value.ToString("+#,0.00;-#,0.00;0.00", System.Globalization.CultureInfo.InvariantCulture),
                value > 0 ? Color.ForestGreen : value < 0 ? Color.Firebrick : Color.DimGray);
        }

        // Row 1 shows the change % of each candle as (close - open) / open. Green is up, red is down.
        // Row 2 shows the volume delta as buy volume - sell volume, where sell = total volume - taker buy volume.
        // Row 3 shows the CVD, the running total of the delta, starting from the oldest candle shown.
        // Rows 8 and 9 show the sell volume in the lowest 20% of each candle's range, and the developing POC of that volume.
        // Rows 10 and 11 show the buy volume in the highest 20% of each candle's range, and the developing POC of that volume.
        // Rows 3 to 7 show the POC, VAH/VAL (the 70% value area), and the developing buyer and seller POCs up to that hour.
        // Rows 12 to 16 show pressure, efficiency, price/CVD agreement, delta Z and regression residual.
        // Z and residual baselines exclude the current candle and use earlier visible candles only.
        private static void ShowCandles(Label[] timeCells, Label[][] rows, Label[] rowTotals, System.Collections.Generic.List<CandleHour> candles, long candleMs)
        {
            int candleColumnCount = timeCells.Length - CandleStatCount;
            // The completed candles come first. The last column is the live candle, which is still forming.
            bool ready = candles != null && candles.Count >= candleColumnCount - 1;
            double cvd = 0;
            // Values for every price row, used for the mean and median columns.
            // Each candle's price move in dollars, paired with its delta for the CVD influence total.
            System.Collections.Generic.List<double> priceMoves = new System.Collections.Generic.List<double>();
            System.Collections.Generic.List<double>[] rowValues = new System.Collections.Generic.List<double>[CandleRowCount];
            for (int k = 0; k < rowValues.Length; k++)
            {
                rowValues[k] = new System.Collections.Generic.List<double>();
            }
            System.Collections.Generic.Dictionary<long, double> developingBuy = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> developingSell = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> developingLowSell = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> developingHighBuy = new System.Collections.Generic.Dictionary<long, double>();
            for (int column = 0; column < candleColumnCount; column++)
            {
                timeCells[column].ForeColor = column == candleColumnCount - 1 ? Color.Green : Color.Black;
                CandleHour candle = ready && column < candles.Count ? candles[column] : null;
                if (candle == null)
                {
                    timeCells[column].Text = "n/a";
                    for (int row = 0; row < CandleRowCount; row++)
                    {
                        if (row >= CandleMetricStartRow) SetMetricCell(rows[row][column], "n/a", 0);
                        else SetCandleCell(rows[row][column], "n/a", Color.DimGray);
                    }
                    continue;
                }

                double change = (candle.Close - candle.Open) / candle.Open * 100;
                rowValues[0].Add(change);
                DateTime open = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(candle.OpenTimeMs).ToLocalTime();
                // Every column shows the day name. Daily and weekly columns show the date instead of a time, e.g. "Thu 05 Nov".
                // Sub-day columns show the hour too, e.g. "Mon 14:00".
                bool dayBased = candleMs >= DayMs;
                timeCells[column].Text = open.ToString(dayBased ? "ddd dd MMM" : "ddd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                SetCandleCell(rows[0][column],
                    change.ToString("+0.00;-0.00;0.00", System.Globalization.CultureInfo.InvariantCulture) + "%",
                    change > 0 ? Color.ForestGreen : change < 0 ? Color.Firebrick : Color.DimGray);

                double sellVolume = candle.Volume - candle.TakerBuyVolume;
                double delta = candle.TakerBuyVolume - sellVolume;
                ShowCandleMetrics(rows, column, candle, delta, rowValues[1], priceMoves, rowValues);
                rowValues[1].Add(delta);
                priceMoves.Add(candle.Close - candle.Open);
                SetCandleValue(rows[1][column], delta);

                cvd += delta;
                rowValues[2].Add(cvd);
                SetCandleValue(rows[2][column], cvd);

                double price;
                if (TryFindPoc(candle.TotalByBucket, out price))
                {
                    rowValues[3].Add(price);
                    SetCandleCell(rows[3][column], price.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), SystemColors.ControlText);
                }
                else
                {
                    SetCandleCell(rows[3][column], "n/a", Color.DimGray);
                }

                double valueHigh;
                double valueLow;
                if (TryFindValueArea(candle.TotalByBucket, out valueHigh, out valueLow))
                {
                    rowValues[4].Add(valueHigh);
                    SetCandleCell(rows[4][column], valueHigh.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), SystemColors.ControlText);
                    rowValues[5].Add(valueLow);
                    SetCandleCell(rows[5][column], valueLow.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), SystemColors.ControlText);
                }
                else
                {
                    SetCandleCell(rows[4][column], "n/a", Color.DimGray);
                    SetCandleCell(rows[5][column], "n/a", Color.DimGray);
                }

                MergeVolumes(developingBuy, candle.BuyByBucket);
                MergeVolumes(developingSell, candle.SellByBucket);
                if (TryFindPoc(developingBuy, out price))
                {
                    rowValues[6].Add(price);
                    SetCandleCell(rows[6][column], price.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), Color.ForestGreen);
                }
                else
                {
                    SetCandleCell(rows[6][column], "n/a", Color.DimGray);
                }

                if (TryFindPoc(developingSell, out price))
                {
                    rowValues[7].Add(price);
                    SetCandleCell(rows[7][column], price.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), Color.Firebrick);
                }
                else
                {
                    SetCandleCell(rows[7][column], "n/a", Color.DimGray);
                }

                System.Collections.Generic.Dictionary<long, double> lowSell = LowZoneSellVolumes(candle.SellByBucket, candle.Low, candle.High);
                double lowSellVolume = 0;
                foreach (double volume in lowSell.Values) lowSellVolume += volume;
                rowValues[8].Add(lowSellVolume);
                SetCandleCell(rows[8][column], lowSellVolume.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture),
                    lowSellVolume > 0 ? Color.Firebrick : Color.DimGray);
                MergeVolumes(developingLowSell, lowSell);
                if (TryFindPoc(developingLowSell, out price))
                {
                    rowValues[9].Add(price);
                    SetCandleCell(rows[9][column], price.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), Color.Firebrick);
                }
                else
                {
                    SetCandleCell(rows[9][column], "n/a", Color.DimGray);
                }

                System.Collections.Generic.Dictionary<long, double> highBuy = HighZoneBuyVolumes(candle.BuyByBucket, candle.Low, candle.High);
                double highBuyVolume = 0;
                foreach (double volume in highBuy.Values) highBuyVolume += volume;
                rowValues[10].Add(highBuyVolume);
                SetCandleCell(rows[10][column], highBuyVolume.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture),
                    highBuyVolume > 0 ? Color.ForestGreen : Color.DimGray);
                MergeVolumes(developingHighBuy, highBuy);
                if (TryFindPoc(developingHighBuy, out price))
                {
                    rowValues[11].Add(price);
                    SetCandleCell(rows[11][column], price.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture), Color.ForestGreen);
                }
                else
                {
                    SetCandleCell(rows[11][column], "n/a", Color.DimGray);
                }
            }

            // The Total column preserves the visible-range summaries, including CVD's price/delta regression.
            // and the POCs come from the volumes of every minute in the visible range added together.
            // Change % total shows the overall move from the first visible open to the last close, then the sum of each candle's change.
            int shownCandles = ready ? Math.Min(candleColumnCount, candles.Count) : 0;
            string overallChange = shownCandles > 0 ? FormatRowStat((candles[shownCandles - 1].Close - candles[0].Open) / candles[0].Open * 100, 0) : string.Empty;
            string summedChange = rowValues[0].Count > 0 ? FormatRowStat(SumOf(rowValues[0]), 0) : string.Empty;
            rowTotals[0].Text = overallChange.Length > 0 ? overallChange + " | " + summedChange : string.Empty;
            rowTotals[1].Text = rowValues[1].Count > 0 ? FormatRowStat(SumOf(rowValues[1]), 1) : string.Empty;
            rowTotals[2].Text = FormatCvdInfluence(rowValues[1], priceMoves);

            System.Collections.Generic.Dictionary<long, double> rangeTotal = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> rangeBuy = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> rangeSell = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> rangeLowSell = new System.Collections.Generic.Dictionary<long, double>();
            System.Collections.Generic.Dictionary<long, double> rangeHighBuy = new System.Collections.Generic.Dictionary<long, double>();
            int visibleCandles = ready ? Math.Min(candleColumnCount, candles.Count) : 0;
            for (int column = 0; column < visibleCandles; column++)
            {
                MergeVolumes(rangeTotal, candles[column].TotalByBucket);
                MergeVolumes(rangeBuy, candles[column].BuyByBucket);
                MergeVolumes(rangeSell, candles[column].SellByBucket);
                MergeVolumes(rangeLowSell, LowZoneSellVolumes(candles[column].SellByBucket, candles[column].Low, candles[column].High));
                MergeVolumes(rangeHighBuy, HighZoneBuyVolumes(candles[column].BuyByBucket, candles[column].Low, candles[column].High));
            }
            rowTotals[3].Text = FormatPocTotal(rangeTotal, 3);
            double rangeHigh;
            double rangeLow;
            rowTotals[4].Text = string.Empty;
            rowTotals[5].Text = string.Empty;
            if (TryFindValueArea(rangeTotal, out rangeHigh, out rangeLow))
            {
                rowTotals[4].Text = FormatRowStat(rangeHigh, 4);
                rowTotals[5].Text = FormatRowStat(rangeLow, 5);
            }
            rowTotals[6].Text = FormatPocTotal(rangeBuy, 6);
            rowTotals[7].Text = FormatPocTotal(rangeSell, 7);
            double rangeLowSellVolume = 0;
            foreach (double volume in rangeLowSell.Values) rangeLowSellVolume += volume;
            rowTotals[8].Text = rangeLowSellVolume.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture);
            rowTotals[9].Text = FormatPocTotal(rangeLowSell, 9);
            double rangeHighBuyVolume = 0;
            foreach (double volume in rangeHighBuy.Values) rangeHighBuyVolume += volume;
            rowTotals[10].Text = rangeHighBuyVolume.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture);
            rowTotals[11].Text = FormatPocTotal(rangeHighBuy, 11);
            foreach (Label total in rowTotals) total.ForeColor = SystemColors.ControlText;

            // The statistics columns summarise every price row.
            for (int row = 0; row < CandleRowCount; row++)
            {
                ShowRowStats(rows[row], rowValues[row], row);
                if (row >= CandleMetricStartRow) rowTotals[row].Text = string.Empty;
            }
        }

        // Price of the POC, then " | " and its BTC volume, e.g. "67,200 | 1,234B".
        private static string FormatPocTotal(System.Collections.Generic.Dictionary<long, double> volumes, int row)
        {
            double price;
            if (!TryFindPoc(volumes, out price))
            {
                return string.Empty;
            }
            double volume = 0;
            foreach (System.Collections.Generic.KeyValuePair<long, double> pair in volumes)
            {
                volume = Math.Max(volume, pair.Value);
            }
            return FormatRowStat(price, row) + " | " + volume.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture) + "B";
        }

        // Regression of each candle's price move ($) on its delta (BTC) across the visible candles.
        // The slope is the $ move per 1,000 BTC of delta, so the sign shows whether delta and price moved together.
        // R² is the share of the price move that delta explains, as a %.
        private static string FormatCvdInfluence(System.Collections.Generic.List<double> deltas, System.Collections.Generic.List<double> moves)
        {
            double slope;
            double intercept;
            double rSquared;
            if (!TryFitPriceDelta(deltas, moves, out slope, out intercept, out rSquared) || double.IsNaN(rSquared))
            {
                return "n/a";
            }
            double perThousand = slope * 1000;
            string sign = perThousand >= 0 ? "+$" : "-$";
            return sign + Math.Abs(perThousand).ToString("#,0", System.Globalization.CultureInfo.InvariantCulture)
                + " per 1k B | " + (rSquared * 100).ToString("0", System.Globalization.CultureInfo.InvariantCulture) + "%";
        }

        private static bool TryFitPriceDelta(System.Collections.Generic.List<double> deltas,
            System.Collections.Generic.List<double> moves, out double slope, out double intercept, out double rSquared)
        {
            slope = intercept = rSquared = 0;
            int n = Math.Min(deltas.Count, moves.Count);
            if (n < 3)
            {
                return false;
            }
            double meanDelta = 0;
            double meanMove = 0;
            for (int i = 0; i < n; i++)
            {
                meanDelta += deltas[i];
                meanMove += moves[i];
            }
            meanDelta /= n;
            meanMove /= n;

            double sxy = 0;
            double sxx = 0;
            double syy = 0;
            for (int i = 0; i < n; i++)
            {
                double dx = deltas[i] - meanDelta;
                double dy = moves[i] - meanMove;
                sxy += dx * dy;
                sxx += dx * dx;
                syy += dy * dy;
            }
            if (sxx == 0)
            {
                return false;
            }

            slope = sxy / sxx;
            intercept = meanMove - slope * meanDelta;
            rSquared = syy > 0 ? sxy * sxy / (sxx * syy) : double.NaN;
            return true;
        }

        private static double SumOf(System.Collections.Generic.List<double> values)
        {
            double sum = 0;
            foreach (double value in values)
            {
                sum += value;
            }
            return sum;
        }

        private static void MergeVolumes(System.Collections.Generic.Dictionary<long, double> total, System.Collections.Generic.Dictionary<long, double> source)
        {
            foreach (System.Collections.Generic.KeyValuePair<long, double> bucket in source)
            {
                double current;
                total.TryGetValue(bucket.Key, out current);
                total[bucket.Key] = current + bucket.Value;
            }
        }

        // Formats a stat value the same way as its row, so Change % shows %, Delta and CVD show a sign, and POC rows show whole dollars.
        private static string FormatRowStat(double value, int row)
        {
            if (row == 0 || row == CandleMetricStartRow)
            {
                return value.ToString("+0.00;-0.00;0.00", System.Globalization.CultureInfo.InvariantCulture) + "%";
            }
            if (row <= 2)
            {
                return value.ToString("+#,0.00;-#,0.00;0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (row == 8 || row == 10)
            {
                return value.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (row == CandleMetricStartRow + 1 || row == CandleMetricStartRow + 4)
            {
                return value.ToString("+$#,0.00;-$#,0.00;$0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (row == CandleMetricStartRow + 3)
            {
                return value.ToString("+0.00;-0.00;0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
            return value.ToString("#,0", System.Globalization.CultureInfo.InvariantCulture);
        }

        // Fills the mean and median cells of one price row.
        private static void ShowRowStats(Label[] cells, System.Collections.Generic.List<double> prices, int row)
        {
            string mean = "n/a";
            string median = "n/a";
            if (prices.Count > 0)
            {
                double sum = 0;
                foreach (double price in prices)
                {
                    sum += price;
                }
                mean = FormatRowStat(sum / prices.Count, row);

                System.Collections.Generic.List<double> sorted = new System.Collections.Generic.List<double>(prices);
                sorted.Sort();
                int middle = sorted.Count / 2;
                double medianValue = sorted.Count % 2 == 1 ? sorted[middle] : (sorted[middle - 1] + sorted[middle]) / 2;
                median = FormatRowStat(medianValue, row);
            }
            SetCandleCell(cells[cells.Length - CandleStatCount], mean, mean == "n/a" ? Color.DimGray : SystemColors.ControlText);
            SetCandleCell(cells[cells.Length - CandleStatCount + 1], median, median == "n/a" ? Color.DimGray : SystemColors.ControlText);
            if (row >= CandleMetricStartRow)
            {
                SetMetricCell(cells[cells.Length - CandleStatCount], mean, 0);
                SetMetricCell(cells[cells.Length - CandleStatCount + 1], median, 0);
            }
        }

        private static void SaveTiles()
        {
            if (workspacePanel == null)
            {
                return;
            }

            try
            {
                System.IO.Directory.CreateDirectory(TilesFolderPath());
                System.Collections.Generic.List<string> lines = new System.Collections.Generic.List<string>();
                foreach (Control control in workspacePanel.Controls)
                {
                    MarketDeskTile tile = control as MarketDeskTile;
                    if (tile == null || tile.IsDisposed)
                    {
                        continue;
                    }

                    string data = tile.GetData == null ? string.Empty : tile.GetData();
                    Rectangle savedBounds = tile.SavedBounds;
                    lines.Add(string.Join("\t", new string[]
                    {
                        tile.Name,
                        savedBounds.Left.ToString(),
                        savedBounds.Top.ToString(),
                        savedBounds.Width.ToString(),
                        savedBounds.Height.ToString(),
                        tile.Selected.ToString(),
                        data
                    }));
                }
                System.IO.File.WriteAllLines(System.IO.Path.Combine(TilesFolderPath(), "tiles.txt"), lines.ToArray());
            }
            catch (Exception)
            {
                // Tiles could not be written (for example, the folder is read-only). The program can still close.
            }
        }

        // Reopens the tiles saved by SaveTiles, with their position, size, selection and data.
        private static void RestoreTiles()
        {
            string path = System.IO.Path.Combine(TilesFolderPath(), "tiles.txt");
            if (!System.IO.File.Exists(path))
            {
                return;
            }

            try
            {
                foreach (string line in System.IO.File.ReadAllLines(path))
                {
                    string[] parts = line.Split('\t');
                    if (parts.Length != 7)
                    {
                        continue;
                    }

                    int left, top, width, height;
                    if (!int.TryParse(parts[1], out left) || !int.TryParse(parts[2], out top) ||
                        !int.TryParse(parts[3], out width) || !int.TryParse(parts[4], out height))
                    {
                        continue;
                    }

                    if (parts[0] == "Candle Data" && candleDataWindow == null)
                    {
                        candleDataWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(candleDataWindow);
                        BuildCandleData(candleDataWindow, parts[6]);
                        if (parts[5] == "True")
                        {
                            candleDataWindow.SelectTile();
                        }
                    }

                    if (parts[0] == "Data Chart" && dataChartWindow == null)
                    {
                        dataChartWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(dataChartWindow);
                        BuildDataChart(dataChartWindow, parts[6]);
                        if (parts[5] == "True")
                        {
                            dataChartWindow.SelectTile();
                        }
                    }

                    if (parts[0] == "Bias Checklist" && biasChecklistWindow == null)
                    {
                        biasChecklistWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        BuildBiasChecklist(biasChecklistWindow, parts[6]);
                        workspacePanel.Controls.Add(biasChecklistWindow);
                        if (parts[5] == "True")
                        {
                            biasChecklistWindow.SelectTile();
                        }
                    }

                    if (parts[0] == "Money Flow" && moneyFlowWindow == null)
                    {
                        moneyFlowWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(moneyFlowWindow);
                        BuildMoneyFlow(moneyFlowWindow);
                        if (parts[5] == "True") moneyFlowWindow.SelectTile();
                    }

                    if (parts[0] == "MMD" && mmdWindow == null)
                    {
                        mmdWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(mmdWindow);
                        BuildMmd(mmdWindow);
                        if (parts[5] == "True") mmdWindow.SelectTile();
                    }

                    if (parts[0] == "Order Book Delta" && orderBookDeltaWindow == null)
                    {
                        orderBookDeltaWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(orderBookDeltaWindow);
                        BuildOrderBookDelta(orderBookDeltaWindow);
                        if (parts[5] == "True") orderBookDeltaWindow.SelectTile();
                    }

                    if (parts[0] == TradingViewTileName && tradingViewWindow == null)
                    {
                        tradingViewWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(tradingViewWindow);
                        BuildTradingView(tradingViewWindow);
                        if (parts[5] == "True") tradingViewWindow.SelectTile();
                    }

                    if (parts[0] == PerpChartTileName && perpChartWindow == null)
                    {
                        perpChartWindow = CreateToolWindow(parts[0], new Size(width, height), new Point(left, top));
                        workspacePanel.Controls.Add(perpChartWindow);
                        BuildPerpChart(perpChartWindow, PerpChartSettings.Load(PerpChartSettings.AmatStatePath));
                        if (parts[5] == "True") perpChartWindow.SelectTile();
                    }
                }
            }
            catch (FormatException error)
            {
                SetStatus("Could not restore the saved tile: " + error.Message);
            }
            catch (Exception)
            {
                // A damaged tiles file should not stop the program from starting.
            }
        }

        // Scans the workspace left to right, top to bottom, and returns the first spot that doesn't overlap another window.
        // If the workspace is full, returns the top-left corner so the new tile opens on top of an existing one.
        private static Point FindSpot(Size size)
        {
            const int step = 10;
            for (int y = 0; y + size.Height <= workspacePanel.ClientSize.Height; y += step)
            {
                for (int x = 0; x + size.Width <= workspacePanel.ClientSize.Width; x += step)
                {
                    Rectangle area = new Rectangle(new Point(x, y), size);
                    bool taken = false;
                    foreach (Control existing in workspacePanel.Controls)
                    {
                        if (existing.Bounds.IntersectsWith(area))
                        {
                            taken = true;
                            break;
                        }
                    }

                    if (!taken)
                    {
                        return area.Location;
                    }
                }
            }

            return Point.Empty;
        }

        // Builds a tile. Drag the green handle to move it, right click the handle for its menu. Put content in tile.Body.
        private static MarketDeskTile CreateToolWindow(string name, Size size, Point location)
        {
            MarketDeskTile tile = new MarketDeskTile(name, size, location);

            // One settings window per tile. Opening it again brings the existing window forward.
            Form settingsForm = null;
            Action openSettings = delegate
            {
                if (settingsForm != null && !settingsForm.IsDisposed)
                {
                    settingsForm.Activate();
                    return;
                }
                settingsForm = new Form();
                settingsForm.Text = name + " Settings";
                settingsForm.FormBorderStyle = FormBorderStyle.Sizable;
                settingsForm.MaximizeBox = true;
                settingsForm.MinimizeBox = true;
                settingsForm.ShowInTaskbar = true;
                settingsForm.StartPosition = FormStartPosition.CenterScreen;
                settingsForm.ClientSize = new Size(640, 440);
                settingsForm.MinimumSize = settingsForm.Size;
                settingsForm.Font = tile.Font;

                // Same layout as the DAS Trader window: sections on the left, a property grid with a description pane, buttons along the bottom.
                PropertyGrid grid = new PropertyGrid();
                grid.Dock = DockStyle.Fill;
                grid.HelpVisible = true;
                grid.ToolbarVisible = false;
                grid.SelectedObject = tile.SettingsViewFactory == null
                    ? (object)new TileSettingsView(tile) : tile.SettingsViewFactory();

                TreeView sections = new TreeView();
                sections.Dock = DockStyle.Left;
                sections.Width = 170;
                sections.HideSelection = false;
                sections.Nodes.Add(name);
                sections.SelectedNode = sections.Nodes[0];

                FlowLayoutPanel buttons = new FlowLayoutPanel();
                buttons.Dock = DockStyle.Bottom;
                buttons.Height = 44;
                buttons.Padding = new Padding(8);
                buttons.FlowDirection = FlowDirection.RightToLeft;
                Button cancel = new Button();
                cancel.Text = "Cancel";
                cancel.Width = 80;
                Button ok = new Button();
                ok.Text = "OK";
                ok.Width = 80;
                buttons.Controls.Add(cancel);
                buttons.Controls.Add(ok);
                ok.Click += delegate
                {
                    TileSettingsView settingsView = grid.SelectedObject as TileSettingsView;
                    if (settingsView != null)
                    {
                        settingsView.Commit();
                    }
                    settingsForm.Close();
                };
                cancel.Click += delegate { settingsForm.Close(); };
                settingsForm.AcceptButton = ok;
                settingsForm.CancelButton = cancel;

                settingsForm.Controls.Add(grid);
                settingsForm.Controls.Add(sections);
                settingsForm.Controls.Add(buttons);
                settingsForm.Show(tile.FindForm());
            };
            tile.SettingsRequested += delegate { openSettings(); };
            if (name == "Candle Data")
            {
                tile.Disposed += delegate
                {
                    if (candleDataWindow == tile)
                    {
                        candleDataWindow = null;
                    }
                    RaiseCandleDataUpdated();
                };
            }

            ContextMenuStrip handleMenu = new ContextMenuStrip();
            handleMenu.Items.Add("Tile Settings...").Click += delegate { openSettings(); };
            handleMenu.Items.Add("Close Tile").Click += delegate { tile.Dispose(); };
            tile.HandleMenu = handleMenu;
            return tile;
        }

        // Call SetDataConnected(true) when data is flowing, SetDataConnected(false) when it is not.
        private static void SetDataConnected(bool connected)
        {
            dataDot.ForeColor = connected ? Color.Green : Color.Red;
            dataText.Text = connected ? "Data Connected" : "Data Not Connected";
        }

        private static void SetStatus(string text)
        {
            if (statusLabel != null)
            {
                statusLabel.Text = text;
            }
        }
    }
}
