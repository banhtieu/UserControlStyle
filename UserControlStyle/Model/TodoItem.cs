using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserControlStyle.Model
{
    /**
     * Todo Item Model
     **/
    public class TodoItem
    {

        // the Id of the object or whatever
        public int Id { get; set; }

        // Name of this Item
        public string Name { get; set; }

        // Is this Item finished
        public bool IsFinished { get; set; }

    }
}