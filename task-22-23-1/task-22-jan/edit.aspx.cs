using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_22_jan
{
    public partial class delete : System.Web.UI.Page
    {
        Entities6 v = new Entities6();
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                var cc = from item in v.Cities select item;
                //var x = from city in db.Cities select city;
                city.DataSource = cc.ToList();
                city.DataTextField = "City1";
                city.DataValueField = "CityID";
                city.DataBind();

                var id = Request.QueryString["id"];
                int id1 = Convert.ToInt32(id);
                var record = v.Customers.FirstOrDefault(a => a.CustomerID == id1);
                name.Text = record.CustomerName;
                age.Text = Convert.ToString(record.Age);
                phone.Text = Convert.ToString(record.Phone);
                email.Text = record.Email;
                city.SelectedValue = record.CityID.ToString();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            int id1 = Convert.ToInt32(id);
            var record = v.Customers.FirstOrDefault(a => a.CustomerID == id1);
            record.CustomerName = name.Text;
            record.Age = Convert.ToInt32(age.Text);
            record.Phone = Convert.ToInt32(phone.Text);
            record.Email = email.Text;
            record.CityID = Convert.ToInt32(city.SelectedValue);
            ///////////////
            string image = "";
            if (FileUpload1.HasFile)
            {
                image = "/pic/" + FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("/pic/") + FileUpload1.FileName);
                record.Photo = image;
            }

            
            ////////////
            v.SaveChanges();
            Response.Redirect("task-22-jan.aspx");
        }
    }
}