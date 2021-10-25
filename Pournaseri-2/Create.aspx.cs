using Pournaseri_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pournaseri_2
{
    public partial class Create : System.Web.UI.Page
    {
        MyContext myContext;

        protected void Page_Load(object sender, EventArgs e)
        {
            myContext = new MyContext();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int kid = Convert.ToInt32(TxtID.Text);
            string kname = TxtName.Text;
            int ksalary = Convert.ToInt32(TxtSalary.Text);

            Karmand karmand = new Karmand()
            {
                KarmandId = kid,
                KarmandName = kname,
                KarmandSalary = ksalary
            };

            myContext.Karmands.Add(karmand);
            myContext.SaveChanges();

            TxtID.Text = "";
            TxtName.Text = "";
            TxtSalary.Text = "";

        }
    }
}