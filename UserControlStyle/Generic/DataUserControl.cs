using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserControlStyle.Generic
{
    // DataUser Control class for generics problem
    public class DataUserControl<T>: System.Web.UI.UserControl where T : new()
    {

        // the private item that store data
        private T _data;

        // The Data Item to Display
        public T Data
        {
            // if there is data then return
            // else call CollectData to parse data
            // from view
            get
            {
                if (_data == null)
                {
                    // Collect Data from From
                    _data = CollectData();
                }

                return _data;
            }
            // set the Data and update the view
            set
            {
                _data = value;
                DataBindChildren();
            }
        }

        // Collect Data From Form
        public virtual T CollectData()
        {
            // return the default T
            return default(T);
        }
    }
}