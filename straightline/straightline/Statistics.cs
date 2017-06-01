using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace straightline
{   // 定義統計運算之類別
    class Statistics
    {
        // 宣告輸入數據之靜態變數 _dValue
        static double _dValue;
        // 宣告XY數據交叉乘積項之靜態變數 _dCrossvalue
        static double _dCrossvalue;
        // 宣告輸入數據總和之靜態變數 _dSum
        static double _dSum;
        // 宣告數據平均數之靜態變數 _dMean
        static double _dMean;
        // 宣告相關係數之靜態變數 _dRelation
        static double _dRelation;
        // 宣告數據殘差平方項之靜態變數 _dSumofsquare
        static double _dSumofsquare;
        // 宣告數據變異數之靜態變數 _dVariance
        static double _dVariance;
  

        public static double Mean(List<int> x)
        {
            _dValue = new double();
            _dSum = new double();
           
            int iCount1 = x.Count;
            // 將輸入座標點數據做加總運算
            if (iCount1 > 0)
            {
                for (int i = 0; i < iCount1; i++)
                {
                    _dValue =_dValue + x[i];
                }
                _dSum = _dValue;                
            }
            // 傳回數據之平均數
            return Math.Round((_dSum / iCount1),3);           
        }


        public static double Variance(List<int> x)
        {
            
            int iCount2 = x.Count;

            _dMean = new double(); 
            _dMean = Mean(x);
            _dSumofsquare = new double();
            _dVariance = new double();
            // 將數據殘差平方項做加總運算
            for (int i = 0; i < iCount2; i++)
            {
                _dSumofsquare = _dSumofsquare + Math.Pow((x[i] - _dMean), 2);
            }
            // 計算數據之變異數
            if (iCount2 > 1)
            {
                _dVariance = _dSumofsquare / (iCount2 - 1);
                _dVariance = Math.Round(_dVariance, 3);                
            }
            else
            {                
                _dVariance = double.NaN;
            }
            return _dVariance;
        }




        public static double Relation(List<int> x, List<int> y)
        {   
            double dmx = new double();
            double dmy = new double();
            double ddx = new double();
            double ddy = new double();
            
            int iCount3 = x.Count;
            _dCrossvalue = new double();
            _dRelation = new double();
            
            dmx = Mean(x);
            dmy = Mean(y);
            ddx = Variance(x)*(iCount3-1);
            ddx = Math.Sqrt(ddx);
            ddy = Variance(y)*(iCount3-1);
            ddy = Math.Sqrt(ddy);
            // X與Y交叉乘積項做加總運算
            if (iCount3 > 1)
            {
                for (int i = 0; i < iCount3; i++)
                {
                    _dCrossvalue = _dCrossvalue + (x[i] - dmx) * (y[i] - dmy);
                }
                // 相關係數運算
                _dRelation = _dCrossvalue / (ddx * ddy);
                _dRelation = Math.Round(_dRelation,3);
            }
            return _dRelation;
        }
    }
}
