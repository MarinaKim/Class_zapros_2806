using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
    public enum currency
    {
        KZT=398,RUB=256,USD=329
    }

   public enum SalesChanelTXT {
        opt, roz, net
    }

   public class Sales
    {/// <summary>
     /// ID дистрибьютора
     /// </summary>
        public string BURKS { get; set; }
/// <summary>
/// филиал
/// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// склад
        /// </summary>
        public string LGORT { get; set; }
        /// <summary>
        /// код канала сбыта
        /// </summary>
        public int SALES_CHANEL { get; private set; }

        public SalesChanelTXT SALES_CHANEL_TXT { get
            {
                return SALES_CHANEL_TXT;
            }
            set {
                SALES_CHANEL_TXT = value;
                switch (value)
                {
                    case SalesChanelTXT.opt:
                        SALES_CHANEL = 8;
                        break;
                    case SalesChanelTXT.roz:
                        SALES_CHANEL = 7;
                        break;
                    case SalesChanelTXT.net:
                        SALES_CHANEL = 12;
                        break;
                    default:
                        break;
                }
            } }

        public int KUNNR { get; set; }

        public string KUNNR_TXT { get; set; }

        public int KUNNR_BIN { get; set; }

        public string KUNNR_ADR_UR { get; set; }

        public string KUNNR_ADR_DOST { get; set; }

        public string ID_OUT_DELIVERY { get; set; }

        public string ID_OUT_DELIVERY_DATA { get; set; }

        public int BSTART { get; set; }
        public int SUMM { get; set; }

        public string SummWithCur
        {
            get
            {
                return SUMM + " " + VALUTA.ToString();
            }
        }
        public currency VALUTA { get; set; } = currency.KZT;

    }
}
