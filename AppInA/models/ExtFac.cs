using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppInA.models
{
    [Serializable]
    public class ExtFac
    {
        public string facility_name { get; set; }
        public string main_site_name { get; set; }
        public string cooperator_name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string fac_zip { get; set; }
        public string fac_phone { get; set; }
        public string cnty_cd { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }



    }
}