using Pournaseri_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pournaseri_2
{
    public partial class _Default : Page
    {
        MyContext myContext;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) {

                myContext = new MyContext();
                var result = myContext.Karmands;

            foreach (var itm in result)
            {
                StudentListBox.Items.Add(itm.KarmandName);
            }
            }
        }

        protected void StudentListBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            string itm = StudentListBox.SelectedItem.ToString();
            var query = myContext.Karmands.Single(a => a.KarmandName == itm);
            Response.Redirect("Edit.aspx?id=" + query.KarmandId);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

    }
}