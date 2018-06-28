using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
    class SaleSims
    {/// <summary>
     /// ID дистрибьютора
     /// </summary>
        public string BURKS { get; set; }
        /// <summary>
        /// филиал
        /// </summary>
        public string WERKS { get; set; }
         
        public string MTART { get; set; }

        public string MTART_TXT { get; set; }
        public string MTART_PROZVOD_COUNTRY { get; set; }
        public int BSTART { get; set; } = 0;
        private double SUMM_;
        public double SUMM {
            get
            {
                return SUMM_;
            }

            set
            {
                if (BSTART < 0)
                {
                    value = value * -1;
                }
            }
                
                }




    }
}
