using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Managers
{

    public sealed class InventarioManager
    {
        #region singleton
        private readonly static InventarioManager _instance = new InventarioManager();

        public static InventarioManager Current
        {
            get
            {
                return _instance;
            }
        }

        private InventarioManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
    }

}