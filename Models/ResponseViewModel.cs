using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstHomework_INCI_KILIC.Models
{

    //Response classında sunucudan dönen cevaplaa ilişkin özellikler bulunmaktadır
    public class ResponseViewModel
    {
        public bool Success { get; set; }

        public String Error { get; set; }

        public String Data { get; set; }

        public int StatusCode { get; set; }
    }
}
