﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clienteServiciosWeb.Models
{
    public class ClienteViewModel
    {
        public int id { get; set; }
        public string cliente { get; set; }
        public string numeroDoc { get; set; }
        public int activo { get; set; }
    }
}