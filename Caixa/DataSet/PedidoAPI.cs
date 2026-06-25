using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Caixa.DataSet
{
    internal class PedidoAPI
    {
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int id { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int company_id { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int user_company_id { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int Payment_method { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int status { get; set; }

        public string code { get; set; }
        public string order_data { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int delivery_type { get; set; }
        public string delivery_address { get; set; }


        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int payment_method { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public double exchanged { get; set; }
        public string price_exchanged {  get; set; }


    }
}
