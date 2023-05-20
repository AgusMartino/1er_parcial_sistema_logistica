using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Managers
{

    public sealed class ProductoManager
    {
        #region singleton
        private readonly static ProductoManager _instance = new ProductoManager();

        public static ProductoManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
    }

}