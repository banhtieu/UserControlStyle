using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UserControlStyle.Model;
using UserControlStyle.UserControl;

namespace UserControlStyle
{
    public partial class RepeaterDemo : System.Web.UI.Page
    {
        public List<TodoItem> TodoItems { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            // first launch, load data
            if (!IsPostBack)
            {
                TodoItems = new List<TodoItem>();

                // Getting Data and Display
                for (var i = 0; i < 10; i++)
                {
                    var item = new TodoItem
                    {
                        Name = "Todo Item #" + i
                    };

                    TodoItems.Add(item);
                }

                TodoList.DataSource = TodoItems;

                // Bind data to view
                DataBind();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // check
            var count = 0;

            foreach (Control item in TodoList.Controls)
            {
                var todoItemView = item.FindControl("Item") as TodoItemView;

                if (todoItemView != null && todoItemView.Data.IsFinished)
                {
                    count++;
                }
            }

            MessageLabel.Text = "There are #" + count + " task(s) done!";
        }
    }
}