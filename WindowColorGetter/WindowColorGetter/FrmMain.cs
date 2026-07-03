using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace WindowColorGetter
{
    public partial class FrmWindowColorGetter : Form
    {
        #region 変数
        private Color lastColor;
        
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        #endregion 変数

        #region コンストラクタ
        public FrmWindowColorGetter()
        {
            InitializeComponent();
        }
        #endregion コンストラクタ

        #region イベントハンドラ
        /// <summary>
        /// ロードイベント - メインフォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWindowColorGetter_Load(object sender, EventArgs e)
        {
            // テキストボックスのフォーカス解除制御を追加
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txtbox)
                {
                    txtbox.GotFocus += this.txtbox_Entered;
                    txtbox.MouseClick += this.txtbox_Entered;
                    txtbox.MouseDown += this.txtbox_Entered;
                }
            }
        }

        /// <summary>
        /// クリックイベント - 座標取得開始モードボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGetColorMode_Click(object sender, EventArgs e)
        {
            // 色取得用の透明ウィンドウを作成
            Form frmOverlay = new Form();

            frmOverlay.FormBorderStyle = FormBorderStyle.None;
            frmOverlay.ShowInTaskbar = false;
            frmOverlay.TopMost = true;
            frmOverlay.BackColor = Color.White;
            frmOverlay.Opacity = 0.01;

            // 複数ディスプレイ向けにフォーム配置
            Rectangle totalArea = Rectangle.Empty;
            foreach (var screen in Screen.AllScreens)
            {
                totalArea = Rectangle.Union(totalArea, screen.Bounds);
            }
            frmOverlay.Bounds = totalArea;

            frmOverlay.Click += OverlayForm_Click;
            frmOverlay.Show();
        }

        /// <summary>
        /// クリックイベント - 座標取得用透明フォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OverlayForm_Click(object sender, EventArgs e)
        {
            if (sender is Form frm) frm.Close();
            // 座標取得
            Point clickPoint = Cursor.Position;
            // 座標の画面上色取得
            this.lastColor = GetColorAtPoint(clickPoint);

            string strColor = "";
            // RGB値設定
            strColor = this.lastColor.R.ToString() + "," + this.lastColor.G.ToString() + "," + this.lastColor.B.ToString();
            this.txtboxRGB.Text = strColor;

            strColor = "";
            // HEX値設定
            strColor = ColorTranslator.ToHtml(this.lastColor);
            this.txtboxHEX.Text = strColor;
        }
        #endregion イベントハンドラ

        #region メソッド
        /// <summary>
        /// 座標上の色を取得
        /// </summary>
        /// <param name="screenPoint">クリックした座標</param>
        /// <returns>Color:座標の色</returns>
        private Color GetColorAtPoint(Point screenPoint)
        {
            Color result = Color.Empty;

            // カーソル先画像用の1×1ビットマップ
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(screenPoint, Point.Empty, new Size(1, 1));
                }
                // 画像の色取得
                result = bmp.GetPixel(0, 0);
            }
            return result;
        }

        /// <summary>
        /// テキストイベントのフォーカスを解除する
        /// </summary>
        /// <returns></returns>
        private void txtbox_Entered(Object sender, EventArgs e)
        {
            // 最上位の親フォームにフォーカスを当てる
            if(sender is TextBox txtbox) HideCaret(txtbox.Handle);
        }
        #endregion メソッド

    }
}
