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
    public partial class TodoItemEdit: DataUserControl<TodoItem>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /**
         * Collect Data From View
         **/
        public override TodoItem CollectData()
        {
            int idValue = 0;
            Int32.TryParse(IdHiddenField.Value, out idValue);

            // collect the value from form
            var item = new TodoItem();            
            item.Id = idValue;
            item.IsFinished = IsFinishedCheckBox.Checked;
            item.Name = NameTextBox.Text;
            return item;
        }
    }
}