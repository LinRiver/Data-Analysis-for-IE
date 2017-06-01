using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace straightline
{
    public partial class Form1 : Form
    {
        #region 變數設定
        // 宣告畫布物件之變數 _gGraphics
        Graphics _gGraphics;
        // 宣告畫筆物件之變數 _pPen
        Pen _pPen;
        // 宣告繪圖矩形物件之變數 _rRectangle
        Rectangle _rRectangle;
        // 宣告座標點之變數 _pPoint
        Point _pPoint;
        // 宣告座標點次序之變數 _pOrdered
        Point _pOrdered;
        // 宣告座標點數據之變數 _pData
        PointF _pData;
        // 宣告筆刷物件之變數 _sb
        SolidBrush _sb;
        // 宣告座標系統參考點之常數 _iCenter
        int _iCenter = 200;
        // 宣告座標點半徑之變數 _ir
        int _ir = 4;
        // 宣告座標點列表之變數 _lLis
        List<Point> _lLis = new List<Point>();
        // 宣告座標點次序列表之變數 _lLis
        List<PointF> _lListordered = new List<PointF>();
        // 宣告座標點數據列表之變數 _lLis
        List<PointF> _ListData = new List<PointF>();
        // 宣告點擊座標個數之變數 _iClickcount
        int _iClickcount=0;
        // 宣告統計運算之X軸數據變數 _lPointx
        List<int> _lPointx = new List<int>();
        // 宣告統計運算之Y軸數據變數 _lPointy
        List<int> _lPointy = new List<int>();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region 繪製座標圖功能
        /// <summary>
        /// 顯示座標圖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelBroad_Paint(object sender, PaintEventArgs e)
        {
            _gGraphics = panel.CreateGraphics();
            _pPen = new Pen(Color.Black, 1);

            // 座標圖長與寬各為400單位
            _gGraphics.DrawLine(_pPen, 200, 0, 200, 400);
            _gGraphics.DrawLine(_pPen, 0, 200, 400, 200);
            // 以間隔為5單位做數線之小間隔距離
            for (int i = 0; i < panel.Size.Width / 5; i++)
            {
                _gGraphics.DrawLine(_pPen, i * 5, 198, i * 5, 202);
            }
            for (int i = 0; i < panel.Size.Height / 5; i++)
            {
                _gGraphics.DrawLine(_pPen, 198, i * 5, 202, i * 5);
            }

            _pPen = new Pen(Color.Black, 2);

            // 以間隔為10單位做數線之大間隔距離
            for (int i = 0; i < panel.Size.Width/10; i++)
            {   
                _gGraphics.DrawLine(_pPen, i * 10, 195, i * 10, 205);
            }
            for (int i = 0; i < panel.Size.Height / 10; i++)
            {
                _gGraphics.DrawLine(_pPen, 195, i * 10, 205, i * 10);
            }
        }
        #endregion

        #region 輸入座標點之三種方式介紹
        
        /// <summary>
        /// 在座標圖上點出座標點並即時顯示於ClickedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelClick_MouseDown(object sender, MouseEventArgs e)
        {
            _gGraphics = panel.CreateGraphics();
            _sb = new SolidBrush(Color.Blue);
            Font fNum = new Font("Arial", 7);
            // 呼叫函式Position載入座標點並計算各項數據
            Position(e.X - 200, 200 - e.Y);
            
            String sNumber2 = String.Empty;
            sNumber2 = (_iClickcount+1).ToString();
            // 在各座標點旁標示序號與座標數據
            _gGraphics.DrawString(sNumber2, fNum, _sb, _lListordered[_iClickcount]);
            _gGraphics.DrawString(_lLis[_iClickcount].ToString(), fNum, _sb, _ListData[_iClickcount]);

            //動態座標點並追蹤直線距離
            if(_iClickcount>0)
            {
                _pPen = new Pen(Color.Navy, 1);
                _gGraphics.DrawLine(_pPen, _lListordered[_iClickcount].X, _lListordered[_iClickcount].Y, _lListordered[_iClickcount-1].X, _lListordered[_iClickcount-1].Y);

                Double dtemp1 = new Double();
                // 極時計算座標點動態連線之距離
                dtemp1 = Math.Sqrt(Math.Pow((_lListordered[_iClickcount].X - _lListordered[_iClickcount-1].X), 2) + 
                         Math.Pow((_lListordered[_iClickcount].Y - _lListordered[_iClickcount-1].Y), 2));
                listBox.Items.Add((_iClickcount) + " 到 " + (_iClickcount+1) + " 估算距離: " + (int)dtemp1);
            }
            _iClickcount++;
        }
       
        /// <summary>
        /// 手動輸入座標點並即時顯示於ClickedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHandenter_Click(object sender, EventArgs e)
        {
            _gGraphics = panel.CreateGraphics();
            _sb = new SolidBrush(Color.Blue);
            Font fNum2 = new Font("Arial", 7);

            String sInx = tbHandx.Text;
            String sIny = tbHandy.Text;
            // 呼叫函式Position載入輸入座標點並計算各項數據
            Position(int.Parse(sInx), int.Parse(sIny));

            int iCount = _lLis.Count;

            String sNumber2 = String.Empty;
            sNumber2 = iCount.ToString();

            // 在各座標點旁標示序號與座標數據
            _gGraphics.DrawString(sNumber2, fNum2, _sb, _lListordered[iCount-1]);
            _gGraphics.DrawString("(X:"+sInx+".Y:"+sIny+")", fNum2, _sb, _ListData[iCount-1]);

            tbHandx.Clear();
            tbHandy.Clear();

        }

        /// <summary>
        /// 隨機產出座標點並即時顯示於ClickedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            _gGraphics = panel.CreateGraphics();
            _sb = new SolidBrush(Color.Blue);
            Font fNum3 = new Font("Arial", 7);

            int iCount2 = int.Parse(tbRandom.Text);
            Random rRandom = new Random();
            String[] sNumber3 = new String[iCount2];

            if (iCount2 > 0)
            {
                for (int i = 0; i < iCount2; i++)
                {   // 由Random類別亂數取出數字，在-200到200
                    int irx = rRandom.Next(-200, 200);
                    int iry = rRandom.Next(-200, 200);
                    // 呼叫函式Position載入輸入座標點並計算各項數據
                    Position(irx, iry);

                    sNumber3[i] = (i + 1).ToString();

                    // 在各座標點旁標示序號與座標數據
                    _gGraphics.DrawString(sNumber3[i], fNum3, _sb, _lListordered[i]);
                    _gGraphics.DrawString("(X:" + _lLis[i].X + ".Y:" + _lLis[i].Y + ")", fNum3, _sb, _ListData[i]);
                }
                tbRandom.Clear();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 計算座標點各項數據並即時顯示於座標系統
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void Position(int x, int y)
        {
            _gGraphics = panel.CreateGraphics();
            _sb = new SolidBrush(Color.Blue);
            Font fNum4 = new Font("Arial", 7);

            //取得點擊座標點之位置，並轉換成所需顯示之座標
            _pPoint.X = x;
            _pPoint.Y = y;

            _lPointx.Add(_pPoint.X);
            _lPointy.Add(_pPoint.Y);
            _lLis.Add(_pPoint);

            //將所設置座標點加入至CheckedListBox 
            int ix = x;
            int iy = y;
            clbExpression.Items.Add("(X:" + ix + ",Y:" + iy + ")");

            //取得點擊座標點之位置
            _pOrdered.X = ix + 200;
            _pOrdered.Y = 200 - iy;
            _lListordered.Add(_pOrdered);

            //取得座標顯示之位置
            _pData.X = ix + 200 - 10;
            _pData.Y = 200 - iy + 10;
            _ListData.Add(_pData);
            // 在座標系統中繪出座標點
            _rRectangle = new Rectangle(ix + 200 - _ir, 200 - iy - _ir, _ir * 2, _ir * 2);
            _gGraphics.FillEllipse(_sb, _rRectangle);
        }
        #endregion

        #region 座標系統之三大功能介紹

        /// <summary>
        ///  有次序顯示相鄰座標點之連線 ，並且計算其距離於ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStraightLine_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            _gGraphics = panel.CreateGraphics();
            _gGraphics.Clear(Color.White);

            panelBroad_Paint(null, null);

            _pPen = new Pen(Color.Blue, 1);
            _sb = new SolidBrush(Color.Blue);
            Font fNum5 = new Font("Arial", 7);

            int iCount3 = clbExpression.Items.Count;

            String[] sNumber4 = new String[iCount3];

            for (int i = 0; i < iCount3; i++)
            {
                sNumber4[i] = (i + 1).ToString();
            }
            // 重新載入座標系統中的座標點
            for (int i = 0; i < iCount3; i++)
            {
                _rRectangle = new Rectangle(_lPointx[i] + 200 - _ir, 200 - _lPointy[i] - _ir, _ir * 2, _ir * 2);
                _gGraphics.FillEllipse(_sb, _rRectangle);
                _gGraphics.DrawString(sNumber4[i], fNum5, _sb, _lListordered[i]);
                _gGraphics.DrawString("(X:" + _lLis[i].X + ".Y:" + _lLis[i].Y + ")", fNum5, _sb, _ListData[i]);
            }

            if (iCount3 == 1)
            {
                listBox.Items.Add("1 到 1 估算距離: 0");
            }

            if (iCount3 == 2)
            {
                Double dTemp3 = new Double();
                // 計算第一點與第二點連線之距離
                dTemp3 = Math.Sqrt(Math.Pow((_lLis[iCount3 - 2].X - _lLis[iCount3 - 1].X), 2) + Math.Pow((_lLis[iCount3 - 2].Y - _lLis[iCount3 - 1].Y), 2));

                listBox.Items.Add("1 到 2 估算距離: " + (Int32)dTemp3);

                // 連接第一點與第二點之連線
                _gGraphics.DrawLine(_pPen, _lLis[iCount3 - 2].X + _iCenter, (_iCenter - _lLis[iCount3 - 2].Y), _lLis[iCount3 - 1].X + _iCenter, (_iCenter - _lLis[iCount3 - 1].Y));
            }

            if (iCount3 > 2)
            {
                // 從第一點逐點連接至最後一點之連線
                for (int i = 0; i < iCount3 - 1; i++)
                {
                    Double dTemp1 = new Double();

                    // 計算由第一點至最後一點相鄰逐點連線之距離
                    dTemp1 = Math.Sqrt(Math.Pow((_lLis[i].X - _lLis[i + 1].X), 2) + Math.Pow((_lLis[i].Y - _lLis[i + 1].Y), 2));

                    listBox.Items.Add((i + 1) + " 到 " + (i + 2) + " 估算距離: " + (Int32)dTemp1);

                    _gGraphics.DrawLine(_pPen, _lLis[i].X + _iCenter, _iCenter - _lLis[i].Y, _lLis[i + 1].X + _iCenter, _iCenter - _lLis[i + 1].Y);
                }

                Double dTemp2 = new Double();

                // 計算最後一點與第一點連線之距離
                dTemp2 = Math.Sqrt(Math.Pow((_lLis[0].X - _lLis[iCount3 - 1].X), 2) + Math.Pow((_lLis[0].Y - _lLis[iCount3 - 1].Y), 2));

                listBox.Items.Add("5 到 1 估算距離: " + (int)dTemp2);

                // 連接最後一點與第一點之連線
                _gGraphics.DrawLine(_pPen, _lLis[iCount3 - 1].X + _iCenter, (_iCenter - _lLis[iCount3 - 1].Y), _lLis[0].X + _iCenter, (_iCenter - _lLis[0].Y));
            }
         }
 
        /// <summary>
        /// 選取所需座標並轉換成極座標表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoordinate_Click(object sender, EventArgs e)
        {
            _gGraphics = panel.CreateGraphics();

            _gGraphics.Clear(Color.White);
            panelBroad_Paint(null, null);

            Font fNum5 = new Font("Arial", 7);
            _sb = new SolidBrush(Color.Red);

            double dR = new double();
            double dAngle = new double();

            int iCount4 = clbExpression.Items.Count;

            // 繪出所選擇之座標點轉換成極座標表示
            for (int i = 0; i < iCount4; i++)
            { 
                if (clbExpression.GetItemChecked(i)==true)
                {
                    _pPen = new Pen(Color.Red, 2);
                    _pPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    _gGraphics.DrawLine(_pPen, _lListordered[i].X, _lListordered[i].Y, 200, 200);
                    _rRectangle = new Rectangle(_lLis[i].X + 200 - _ir, 200-_lLis[i].Y - _ir, _ir * 2, _ir * 2);
                    _gGraphics.FillEllipse(_sb, _rRectangle);

                    // 計算極座標長度與角度
                    dR = (int)Math.Sqrt(Math.Pow((_lListordered[i].X - _iCenter), 2) + Math.Pow((_lListordered[i].Y - _iCenter), 2));
                    dAngle =(int)(Math.Atan2(_lLis[i].Y, _lLis[i].X)*(180/Math.PI));
                    // 在座標點旁顯示其極座標
                    _gGraphics.DrawString(" (R="+dR+",Angle="+dAngle+" ) ", fNum5, _sb, _lListordered[i]);
                }              
            }
        }
       
        /// <summary>
        /// 迴歸分析之演算功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            _gGraphics = panel.CreateGraphics();
            _pPen = new Pen(Color.Red, 4);
            _pPen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            _pPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            double dmx = new double();
            double dmy = new double();
            double dsx = new double();
            double dsy = new double();
            double drxy = new double();
            double dyp100 = new double();
            double dyn100 = new double();

            // 經由統計類別之平均數函式計算得到平均數
            dmx=Statistics.Mean(_lPointx);
            dmy=Statistics.Mean(_lPointy);
            
            listBox.Items.Add("X平均數: "+ dmx);
            listBox.Items.Add("Y平均數: " + dmy);

            // 經由統計類別之變異數函式計算得到標準差
            dsx = Math.Sqrt(Statistics.Variance(_lPointx));
            dsx = Math.Round(dsx,3);
            dsy = Math.Sqrt(Statistics.Variance(_lPointy));
            dsy = Math.Round(dsy,3);

            listBox.Items.Add("X標準差: " + dsx);
            listBox.Items.Add("Y標準差: " + dsy);
            // 經由統計類別之相關係數函式計算得到相關係數
            drxy=Statistics.Relation(_lPointx, _lPointy);

            listBox.Items.Add("XY相關係數: " + drxy);

            double db = new double();
            // 經由迴歸分析得到常數參數項
            db = Math.Round(dmy - drxy * (dsx / dsy) * dmx,2);
            // 列出迴歸分析的迴歸直線方程式
            listBox.Items.Add("迴歸直線:y=" + Math.Round(drxy * (dsx / dsy),2) + "x+" + db);

            dyp100 = drxy * (dsx / dsy) * (100 - dmx) + dmy;
            dyn100 = drxy * (dsx / dsy) * ((-100) - dmx) + dmy;
            // 在座標系統中繪出迴歸直線
            _gGraphics.DrawLine(_pPen, 300, (int)(200-dyp100), 100, (int)(200-dyn100));
        }
        #endregion

        #region 還原初始設定
        /// <summary>
        /// 清除舊資料，還原初始設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            _gGraphics = panel.CreateGraphics();
            _gGraphics.Clear(Color.White);
            panelBroad_Paint(null, null);

            _lLis.Clear();
            _lListordered.Clear();
            _ListData.Clear();
            _lPointx.Clear();
            _lPointy.Clear();
            _iClickcount = 0;

            clbExpression.Items.Clear();
            listBox.Items.Clear();

            tbHandx.Text = "0";
            tbHandy.Text = "0";
            tbRandom.Text = "0";
        }
        #endregion


        #region 使用說明書
        /// <summary>
        /// 座標系統各元件功能使用說明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {

            if (cbHandbook.SelectedItem.ToString() == "座標點輸入說明")
            {
                MessageBox.Show("本系統具有三種輸入方式:\n1. 手動輸入:輸入X, Y座標\n2. 自動輸入:隨機產生\n3. 動態輸入:滑鼠點擊");
                return;            
            }

            if (cbHandbook.SelectedItem.ToString() == "直線計算說明")
            {
                MessageBox.Show("直線計算具有二種方式:\n1. 靜態計算:輸入座標點做連點計算\n2. 動態計算:點擊座標點即時計算");
                return;
            }

            if (cbHandbook.SelectedItem.ToString() == "極座標轉換說明")
            {
                MessageBox.Show("極座標選取顯示:\n1. 首先選取欲轉換之座標點\n2. 轉換顯示於座標系統");
                return;
            }

            if (cbHandbook.SelectedItem.ToString() == "迴歸分析說明")
            {
                MessageBox.Show("迴歸分析:\n1. 計算二為數據之各統計量\n2. 計算迴歸直線並顯示");
                return;
            }

        }
        #endregion

    }
}
