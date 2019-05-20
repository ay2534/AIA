using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SODA;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft;
using AppInA.models;

namespace AppInA
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbldatetime.Text = DateTime.Now.ToString();
            var client = new SodaClient("https://health.data.ny.gov", "qT8KiMVFytMqdoi6OmsjOgKTN");
            //var dataset = client.GetResource<Dictionary<string, object>>("7xgt-tyms");
            var dataset = client.GetResource<ExtFac>("7xgt-tyms");

            var soql = new SoqlQuery().Select("facility_name", "main_site_name", "cooperator_name", "address1", "address2", "city", "state", "fac_zip", "fac_phone", "cnty_cd", "latitude", "longitude", "fac_desc_short")
                .Where("(fac_desc_short='HOSP-EC' OR fac_desc_short='DTC-EC') AND ((main_site_name LIKE '%Westchester Medical Center%') OR (main_site_name like '%Langone%') OR (cooperator_name LIKE '%Northwell%') OR (main_site_name like '%Presby%' AND operator_city = 'New York')) ");


            //var results = dataset.Query<Dictionary<string, object>>(soql);
            var results = dataset.Query<ExtFac>(soql);



            //lblcount.Text = " Total record count: " + results.Count().ToString();

            //var myObjectDT = JsonConvert.DeserializeObject<DataTable>(results.ToString());
            //var myObject = JsonConvert.DeserializeObject(results.ToString());
            grid1.DataSource = results;
            grid1.DataBind();


        }
    }
}