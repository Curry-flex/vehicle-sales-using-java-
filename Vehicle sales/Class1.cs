using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_sales
{
    class Class1
    {
        public double Modified;
        public double StereoSystem;
    
        public double Customized;
        public double LatherInterior;
        public double GlobalPositioningSystem;
        public double Tax_rate = 0.45;


        public double price_Modified = 2556000;
        public double price_StereoSystem =  1200000;
        public double price_Customized = 1700000;
        public double price_LatherInterior = 985000;
        public double price_GlobalPositioningSystem = 1230000;

        public double cost;
   
       public double getamaount()
        {
           
            cost = Modified + StereoSystem + Customized + LatherInterior + GlobalPositioningSystem;
            return cost;
        }

        public double cFindTax(double cAmount)
        {
            double findtax = (cAmount * Tax_rate)/100;
            return findtax;
        }

        public double Gettax()
        {
            cost = cFindTax(cost);
            return cost;
        }



    }
}
