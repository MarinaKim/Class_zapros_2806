using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
   public enum RequestType
    {
        NONE,SALES,SALESIMS,STORED,MOVING, GOOD_RECEIPT
    }
  public  class Request
    {
        public RequestType req { get; set; }
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        /// </summary>
        public string KUNNR { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
        /// </summary>
        public string BUKRS { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP
        /// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// DATA1	Дата с начало периода
        /// </summary>
        public DateTime data1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime data2 { get; set; }
    }
}
