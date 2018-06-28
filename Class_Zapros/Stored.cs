using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
    class Stored
    {
        /// <summary>
        /// ID дистрибьютора
        /// </summary>
        public string BURKS { get; set; }

        public string DATA_BSTART { get; set; }
        public string MTART { get; set; }
        public string MTART_TXT { get; set; }

        public string MTART_EINE { get; set; }
        public int BSTART { get; set; } = 0;
        private double SUMM_;
        public double SUMM
        {
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
