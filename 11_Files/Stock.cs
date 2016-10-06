using System.Globalization;

namespace _11_Files
{
    public class Stock : IAsset
    {
        
        private string symbol;
        private double pris;
        private int antal;
        private long id;

        
        public Stock(string symbol, double pricepershare, int numshares)
        {
            this.symbol = symbol;
            this.pris = pricepershare;
            this.antal = numshares;
        }
        public Stock()
        {

        }

        
        public double GetValue()
        {
            return pris * antal;
        }

       
        public override string ToString()
        {
           
            string ppsstring = pris.ToString(CultureInfo.InvariantCulture);

            return "Stock[symbol=" + this.symbol + ",pricePerShare="
                + ppsstring + ",numShares=" + this.antal + "]";
        }

        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;
            if (this.symbol == s.Symbol && this.pris == s.Pris 
                && this.antal == s.Antal)
            { return true; }
            else
            { return false; }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public double Pris
        {
            get { return this.pris; }
            set { this.pris = value; }
        }

        public int Antal
        {
            get { return this.antal; }
            set { this.antal = value; }
        }

        public long Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}