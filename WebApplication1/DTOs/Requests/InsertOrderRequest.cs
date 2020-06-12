using APBD_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDB.DTOs.Requests
{
	public class InsertOrderRequest
	{
       
        public DateTime DateAccepted { get; set; }
        public string Notes { get; set; }
        public ICollection<ConfectionaryRequestModel> Confectionery { get; set; }

    }
}
