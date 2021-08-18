using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToMySql.Classes
{
	public class JSONInputClass
	{
        private string now;

        [MySqlType("datetime(6)")]
        public string Now {
            get {
                var arrDateTime = now.Split('|');
                var arrDate = arrDateTime[1].Split('-');
                // YYYY-MM-DD HH:mm:ss
                return $"20{arrDate[2]}-{arrDate[1]}-{arrDate[0].Trim()} {arrDateTime[0].Trim()}:00";
            }
            set {
                now = value;
            }
        }

        [MySqlType("int")]
        public string Hr { get; set; }

        [MySqlType("int")]
        public string Mi { get; set; }

        [MySqlType("int")]
        public string Se { get; set; }
        
        [MySqlType("int")]
        public string Li { get; set; }

        [JsonProperty("M.a")]
        [MySqlType("int")]
        public string M_a { get; set; }

        [JsonProperty("M.s")]
        [MySqlType("double")]
        public string M_s { get; set; }
        
        [MySqlType("double")]
        public string RPM { get; set; }

        [JsonProperty("PH.a")]
        [MySqlType("int")]
        public string PH_a { get; set; }

        [JsonProperty("PH.s")]
        [MySqlType("double")]
        public double PH_s { get; set; }

        [JsonProperty("PH.v")]
        [MySqlType("double")]
        public double PH_v { get; set; }

        [JsonProperty("Te.a")]
        [MySqlType("int")]
        public string Te_a { get; set; }

        [JsonProperty("Te.s")]
        [MySqlType("double")]
        public double Te_s { get; set; }

        [JsonProperty("Te.J")]
        [MySqlType("double")]
        public double Te_J { get; set; }

        [JsonProperty("Te.T")]
        [MySqlType("double")]
        public double Te_T { get; set; }

        [JsonProperty("Ste.a")]
        [MySqlType("int")]
        public string Ste_a { get; set; }

        [JsonProperty("PH.c")]
        [MySqlType("int")]
        public string PH_c { get; set; }

        [JsonProperty("PH4.c")]
        [MySqlType("double")]
        public string PH4_c { get; set; }

        [JsonProperty("PH7.c")]
        [MySqlType("double")]
        public string PH7_c { get; set; }

        [JsonProperty("PH.Ana")]
        [MySqlType("double")]
        public string PH_Ana { get; set; }
    }
}
