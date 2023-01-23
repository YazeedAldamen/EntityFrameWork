using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_22_jan
{
    public partial class delete1 : System.Web.UI.Page
    {
        Entities6 tasks = new Entities6();
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            int id1 = Convert.ToInt32(id);
            var record = tasks.Customers.FirstOrDefault(a => a.CustomerID == id1);
            name.Text = record.CustomerName;
            phone.Text = Convert.ToString(record.Phone);
            email.Text = record.Email;
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            var info = tasks.Customers.Find(id);
            tasks.Customers.Remove(info);
            tasks.SaveChanges();

            Response.Redirect("task-22-jan.aspx");
        }
    }
}