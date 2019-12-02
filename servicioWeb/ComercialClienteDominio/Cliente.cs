using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComercialClienteDominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string cliente { get; set; }
        [DataMember]
        public string numeroDoc { get; set; }
        [DataMember]
        public int activo { get; set; }
    }
}

