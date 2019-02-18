using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Security;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Property_cls;

namespace Property
{
    public partial class Detail : System.Web.UI.Page
    {
        #region Properties

        String _SearchText;
        public String SearchText
        {
            get { return _SearchText; }
            set { _SearchText = value; }
        }
        String _MinPrice;
        public String MinPrice
        {
            get { return _MinPrice; }
            set { _MinPrice = value; }
        }
        String _MaxPrice;
        public String MaxPrice
        {
            get { return _MaxPrice; }
            set { _MaxPrice = value; }
        }
        String _Beds;
        public String Beds
        {
            get { return _Beds; }
            set { _Beds = value; }
        }
        String _Baths;
        public String Baths
        {
            get { return _Baths; }
            set { _Baths = value; }
        }

        #endregion Properties
        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = "Sharan Butan : Home";
            Session["FirstName"] = null;
            Session["SearchType"] = null;
            Session["PropertySearchType"] = null;
            if (!IsPostBack)
            {
                Session["PropertyType"] = Request.QueryString["PropertyType"];
                var propertytype = Request.QueryString["PropertyType"].ToString();
                SearchResidentialProperties(Session["PropertyType"].ToString());
                divresidential.Visible = true;

            }
        }
        #endregion PageLoad
        public string GetText(string txtDescription)
        {
            if (txtDescription.Length > 150)
            {
                int i = txtDescription.IndexOf(" ", 100);
                if (i > 0)
                    txtDescription = txtDescription.Substring(0, i).Trim();
                else
                    return txtDescription;
            }
            else
            {
                return txtDescription;

            }
            return txtDescription;
        }
        void SearchResidentialProperties(string ptype)
        {
            try
            {
                Session["QueryString"] = ptype;
                if (ptype == "Dufferin")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Orangeville";
                    resicity1.Text = "Orangeville";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Shelburne";
                    resicity2.Text = "Shelburne";
                    div3.Visible = false;
                    div4.Visible = false;
                    div5.Visible = false;
                    div6.Visible = false;
                    div7.Visible = false;
                    div8.Visible = false;
                }
                else if (ptype == "Durham")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Ajax";
                    resicity1.Text = "Ajax";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Brock";
                    resicity2.Text = "Brock";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=Scugog";
                    resicity3.Text = "Scugog";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Clarington";
                    resicity4.Text = "Clarington";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Oshawa";
                    resicity5.Text = "Oshawa";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Uxbridge";
                    resicity6.Text = "Uxbridge";
                    hlresi7.NavigateUrl = "../SubDetail.aspx?City=Whitby";
                    resicity7.Text = "Whitby";
                    hlresi8.NavigateUrl = "../SubDetail.aspx?City=Pickering";
                    resicity8.Text = "Pickering";

                }
                else if (ptype == "Halton")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Burlington";
                    resicity1.Text = "Burlington";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Halton Hills";
                    resicity2.Text = "Halton Hills";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=Milton";
                    resicity3.Text = "Milton";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Oakville";
                    resicity4.Text = "Oakville";
                    div5.Visible = false;
                    div6.Visible = false;
                    div7.Visible = false;
                    div8.Visible = false;
                }
                else if (ptype == "Simcoe")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Adjala-Tosorontio";
                    resicity1.Text = "Adjala-Tosorontio";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Essa";
                    resicity2.Text = "Essa";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=Penetanguishene";
                    resicity3.Text = "Penetanguishene";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Tiny";
                    resicity4.Text = "Tiny";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Barrie";
                    resicity5.Text = "Barrie";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Innisfil";
                    resicity6.Text = "Innisfil";
                    hlresi7.NavigateUrl = "../SubDetail.aspx?City=Wasaga Beach";
                    resicity7.Text = "Wasaga Beach";
                    hlresi8.NavigateUrl = "../SubDetail.aspx?City=Bradford West Gwillimbury";
                    resicity8.Text = "Bradford West Gwillimbury";
                    div10.Visible = true;
                    div11.Visible = true;
                    div12.Visible = true;
                    div13.Visible = true;
                    div14.Visible = true;
                    div15.Visible = true;
                    div16.Visible = true;
                    div17.Visible = true;
                    div18.Visible = true;
                    div19.Visible = true;
                    div20.Visible = true;
                    HyperLink1.NavigateUrl = "../SubDetail.aspx?City=Midland";
                    Label1.Text = "Midland";
                    HyperLink2.NavigateUrl = "../SubDetail.aspx?City=Ramara";
                    Label2.Text = "Ramara";
                    HyperLink3.NavigateUrl = "../SubDetail.aspx?City=New Tecumseth";
                    Label3.Text = "New Tecumseth";
                    HyperLink4.NavigateUrl = "../SubDetail.aspx?City=Severn";
                    Label4.Text = "Severn";
                    HyperLink5.NavigateUrl = "../SubDetail.aspx?City=Clearview";
                    Label5.Text = "Clearview";
                    HyperLink6.NavigateUrl = "../SubDetail.aspx?City=Orillia";
                    Label6.Text = "Orillia";
                    HyperLink7.NavigateUrl = "../SubDetail.aspx?City=Springwater";
                    Label7.Text = "Springwater";
                    HyperLink8.NavigateUrl = "../SubDetail.aspx?City=Collingwood";
                    Label8.Text = "Collingwood";
                    HyperLink9.NavigateUrl = "../SubDetail.aspx?City=Oro-Medonte";
                    Label9.Text = "Oro-Medonte";
                    HyperLink10.NavigateUrl = "../SubDetail.aspx?City=Tay";
                    Label10.Text = "Tay";
                }
                else if (ptype == "York")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Aurora";
                    resicity1.Text = "Aurora";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Newmarket";
                    resicity2.Text = "Newmarket";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=East Gwillimbury";
                    resicity3.Text = "East Gwillimbury";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Richmond Hill";
                    resicity4.Text = "Richmond Hill";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Georgina";
                    resicity5.Text = "Georgina";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Vaughan";
                    resicity6.Text = "Vaughan";
                    hlresi7.NavigateUrl = "../SubDetail.aspx?City=Georgina Islands";
                    resicity7.Text = "Georgina Islands";
                    hlresi8.NavigateUrl = "../SubDetail.aspx?City=Whitchurch-Stouffville";
                    resicity8.Text = "Whitchurch-Stouffville";
                    div10.Visible = true;
                    div11.Visible = true;
                    HyperLink1.NavigateUrl = "../SubDetail.aspx?City=King";
                    Label1.Text = "King";
                    HyperLink2.NavigateUrl = "../SubDetail.aspx?City=Markham";
                    Label2.Text = "Markham";
                }
                else if (ptype == "Muskoka")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Bracebridge";
                    resicity1.Text = "Bracebridge";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Georgian Bay";
                    resicity2.Text = "Georgian Bay";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=Gravenhurst";
                    resicity3.Text = "Gravenhurst";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Huntsville";
                    resicity4.Text = "Huntsville";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Lake of Bays";
                    resicity5.Text = "Lake of Bays";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Muskoka Lakes";
                    resicity6.Text = "Muskoka Lakes";
                    div7.Visible = false;
                    div8.Visible = false;
                }
                else if (ptype == "Niagara")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Fort Erie";
                    resicity1.Text = "Fort Erie";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=St. Catharines";
                    resicity2.Text = "St. Catharines";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=Grimsby";
                    resicity3.Text = "Grimsby";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Thorold";
                    resicity4.Text = "Thorold";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Lincoln";
                    resicity5.Text = "Lincoln";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Wainfleet";
                    resicity6.Text = "Wainfleet";
                    hlresi7.NavigateUrl = "../SubDetail.aspx?City=Niagara Falls";
                    resicity7.Text = "Niagara Falls";
                    hlresi8.NavigateUrl = "../SubDetail.aspx?City=Welland";
                    resicity8.Text = "Welland";
                    div10.Visible = true;
                    div11.Visible = true;
                    div12.Visible = true;
                    div13.Visible = true;

                    HyperLink1.NavigateUrl = "../SubDetail.aspx?City=Niagara-on-the-Lake";
                    Label1.Text = "Niagara-on-the-Lake";
                    HyperLink2.NavigateUrl = "../SubDetail.aspx?City=West Lincoln";
                    Label2.Text = "West Lincoln";
                    HyperLink3.NavigateUrl = "../SubDetail.aspx?City=Pelham";
                    Label3.Text = "Pelham";
                    HyperLink4.NavigateUrl = "../SubDetail.aspx?City=Port Colborne";
                    Label4.Text = "Port Colborne";


                }
                else if (ptype == "Waterloo")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Cambridge";
                    resicity1.Text = "Cambridge";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Kitchener";
                    resicity2.Text = "Kitchener";
                    hlresi3.NavigateUrl = "../SubDetail.aspx?City=North Dumfries";
                    resicity3.Text = "North Dumfries";
                    hlresi4.NavigateUrl = "../SubDetail.aspx?City=Waterloo";
                    resicity4.Text = "Waterloo";
                    hlresi5.NavigateUrl = "../SubDetail.aspx?City=Wellesley";
                    resicity5.Text = "Wellesley";
                    hlresi6.NavigateUrl = "../SubDetail.aspx?City=Wilmot";
                    resicity6.Text = "Wilmot";
                    hlresi7.NavigateUrl = "../SubDetail.aspx?City=Woolwich";
                    resicity7.Text = "Woolwich";
                    div8.Visible = false;
                }
                else if (ptype == "Oxford")
                {
                    hlresi1.NavigateUrl = "../SubDetail.aspx?City=Woodstock";
                    resicity1.Text = "Woodstock";
                    hlresi2.NavigateUrl = "../SubDetail.aspx?City=Ingersoll";
                    resicity2.Text = "Ingersoll";
                    div3.Visible = false;
                    div4.Visible = false;
                    div5.Visible = false;
                    div6.Visible = false;
                    div7.Visible = false;
                    div8.Visible = false;
                }




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }



    }
}
