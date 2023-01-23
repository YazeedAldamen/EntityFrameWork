using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_22_jan
{
    public partial class task_22_jan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities6 db = new Entities6();

            if (!IsPostBack)
            {

                var cc = from item in db.Cities select item;
                //var x = from city in db.Cities select city;
                city.DataSource = cc.ToList();
                city.DataTextField = "City1";
                city.DataValueField = "CityID";
                city.DataBind();

                var joi = (from c in db.Customers
                           join ct in db.Cities on c.CityID equals ct.CityID
                           select new
                           {    c.CustomerID,
                               c.CustomerName,
                               c.Age,
                               ct.City1,
                               c.Email,
                               c.Phone,
                               c.Photo
                           }).ToList();
                GridView1.DataSource = joi.ToList();
                GridView1.DataBind();


            }

            lblCustomersNumber.Text = (from item in db.Customers select item).Count().ToString();
            double avg = double.Parse((from item in db.Customers select item.Age).Average().ToString());
            lblAvgAge.Text = Math.Round(avg, 2).ToString();
            lblMaxAge.Text = (from item in db.Customers select item.Age).Max().ToString();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Entities6 db = new Entities6();

            Customer i = new Customer();
            i.CustomerName = name.Text;
            i.Age = int.Parse(age.Text);
            i.CityID = int.Parse(city.SelectedValue);
            i.Phone = int.Parse(phone.Text);
            i.Email = email.Text;

            string image = "";
            if (FileUpload1.HasFile)
            {
                image = "/pic/" + FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("/pic/") + FileUpload1.FileName);
            }

            i.Photo = image;



            //create path for the folder where to save the image

            db.Customers.Add(i);
            db.SaveChanges();



        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Entities6 db = new Entities6();
            string searchText = search.Text.Trim();
            var joi = (from cc in db.Customers
                       join ct in db.Cities on cc.CityID equals ct.CityID
                       where cc.CustomerID.ToString().Contains(searchText) || cc.CustomerName.Contains(searchText)
                       select new
                       {   cc.CustomerID,
                           cc.CustomerName,
                           cc.Age,
                           ct.City1,
                           cc.Email,
                           cc.Phone,
                           cc.Photo
                       }).ToList();


            GridView1.DataSource = joi.ToList();
            GridView1.DataBind();


        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (GridView1 != null && GridView1.Columns.Count > 0)
            //{
            //    GridView1.Columns[0].HeaderText = "Name";
            //}

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var imagePath = (e.Row.DataItem as dynamic).Photo;
                var image = new Image();
                image.ImageUrl =  imagePath;
                image.Height = 50;
                image.Width = 100;
                e.Row.Cells[8].Controls.Add(image);

                


            }
        }

    }
}