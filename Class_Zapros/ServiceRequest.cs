using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zapros
{
    class ServiceRequest
    {
        public Response GetRequestData()
        {
            Request r1 = new Request();
            Console.WriteLine("Введите тип запроса: ");
            int type_req = 0;
            Int32.TryParse(Console.ReadLine(), out type_req);
             if (type_req <= Enum.GetNames(typeof(RequestType)).Length)
            {
                r1.req = (RequestType)type_req;
            }

            Console.WriteLine("Введите код поставщика: ");
            r1.KUNNR = Console.ReadLine();

            Console.WriteLine("Введите Код БЕ в SAP ERP: ");
            r1.BUKRS = Console.ReadLine();

            Console.WriteLine("Введите завод: ");
            r1.WERKS = Console.ReadLine();

            Console.WriteLine("Введите дату начала периода: ");
            DateTime data1;
            if(DateTime.TryParse(Console.ReadLine(),out data1))
            {
                r1.data1 = data1;
            }
            else
            {
                r1.data1 = DateTime.MinValue;// 01011900, проверка на дату наличие или отсутсвие
            }

            Console.WriteLine("Введите дату конца периода: ");
            if (DateTime.TryParse(Console.ReadLine(), out data1))
            {
                r1.data2 = data1;
            }
            else
            {
                r1.data1 = DateTime.MinValue;// 01011900, проверка на дату наличие или отсутсвие
            }
            return RequestInput(r1);
        }

        public Response RequestInput(Request r1)
        {
            Response  responce=null;
            switch (r1.req)
            {
                case RequestType.NONE:
                    break;
                case RequestType.SALES:
                    {
                        List<Sales> s = null;
                        responce= GetSalesReport(r1, out s);
                    }
                    break;
                case RequestType.SALESIMS:
                    break;
                case RequestType.STORED:
                    break;
                case RequestType.MOVING:
                    break;
                case RequestType.GOOD_RECEIPT:
                    break;
                default:
                    break;
            }
            return responce;
        }

        public Response GetSalesReport (Request r, out List<Sales> SalesReport)
        {
                Response res = new Response();
                SalesReport = new List<Sales>();
                SalesReport=getSalesData(r);

            if (SalesReport.Count <= 0)
            {
                res.status = response.err;
                res.Message = "Error";
            }
            else
            {
                res.status = response.ok;
            }
                return res;
                
        }

            private List<Sales> getSalesData(Request r)
        {
            List<Sales> saleses = new List<Sales>();
            for (int i = 0; i < (r.data1 - r.data2).TotalDays; i++)
            {
                Sales sales = new Sales();
                sales.BSTART = rnd.Next(1, 1000);
                sales.BURKS = "b"+rnd.Next(0, 20);
                sales.VALUTA = (currency)rnd.Next(0, 3);
                sales.ID_OUT_DELIVERY_DATA = string.Format("{0:dd.mm..yy}", DateTime.Now.AddDays(rnd.Next(1, 30)));

                sales.KUNNR =rnd.Next(0, 20);
                sales.KUNNR_ADR_UR= "b" + rnd.Next(0, 20);
                sales.KUNNR_ADR_DOST= "b" + rnd.Next(0, 20);
                sales.KUNNR_BIN = rnd.Next(11111111, 99999999);
                sales.KUNNR_TXT= "b" + rnd.Next(0, 20);
                sales.LGORT= "b" + rnd.Next(0, 20);
                sales.SALES_CHANEL_TXT= (SalesChanelTXT) rnd.Next(0,3);
                sales.SUMM= rnd.Next();

                saleses.Add(sales);
            }
            return saleses;
        }

        private Random rnd = new Random();
    }
}
