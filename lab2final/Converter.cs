using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace laboratorka2
{
    class Converter
    {


        public static double Convert(double amountvalue, Currency currency)
        {

            double returnAmount = 0;
            double usd = 39.67; double eur = 38.64; double rub = 0.59;
            if (currency == Currency.USD)
            {
                returnAmount = amountvalue * usd;
            }
            if (currency == Currency.EUR)
            {
                returnAmount = amountvalue * eur;
            }
            if (currency == Currency.UAH)
            {
                returnAmount = amountvalue / eur;
            }
            if (currency == Currency.RUB)
            {
                returnAmount = amountvalue * rub;
            }
            return returnAmount;

        }


        public enum Currency : int
        {
            USD = 1,
            EUR = 2,
            RUB = 3,
            UAH = 4
        }


    }
}