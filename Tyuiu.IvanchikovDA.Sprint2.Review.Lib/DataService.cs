using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.IvanchikovDA.Sprint2.Review.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= x * x) && ((y <= 2 - x) && (y>=0) || (y >= 2 - x)) && (y<x*x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}