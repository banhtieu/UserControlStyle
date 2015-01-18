using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UserControlStyle.Generic;
using UserControlStyle.Model;

namespace UserControlStyle.UserControl
{
    public partial class TodoItemView : DataUserControl<TodoItem>
    {

        // page load event
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /**
         * Collect Data From View
         **/
        public override TodoItem CollectData()
        {
            var item = new TodoItem();
            item.IsFinished = IsFinishedCheckBox.Checked;
            item.Name = NameLabel.Text;
            return item;
        }
    }
}