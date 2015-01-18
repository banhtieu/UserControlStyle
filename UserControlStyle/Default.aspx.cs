using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UserControlStyle.Model;

namespace UserControlStyle
{
    public partial class Default : System.Web.UI.Page
    {
        // the To do Item
        public TodoItem Item1;

        // Item 2
        public TodoItem Item2;

        // Load Page
        protected void Page_Load(object sender, EventArgs e)
        {

            // if first load then get from database
            if (!IsPostBack)
            {
                // considering load data from template
                Item1 = new TodoItem
                {
                    Name = "Sample Item Without Getting Back",
                    IsFinished = false
                };

                // item 2 
                Item2 = new TodoItem
                {
                    Name = "Sample Item With Getting Back",
                    IsFinished = true
                };

                // Bind data with view
                DataBind();
            }

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Item2 = SecondItemView.Data;

            if (Item2.IsFinished)
            {
                MessageLabel.Text = Item2.Name + " is Done";
            }
            else
            {
                MessageLabel.Text = Item2.Name + " is In Progress";
            }
        }
    }
}