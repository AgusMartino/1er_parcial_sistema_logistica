using GeneralApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Managers
{

    public sealed class TransaccionesManager
    {
        #region singleton
        private readonly static TransaccionesManager _instance = new TransaccionesManager();

        public static TransaccionesManager Current
        {
            get
            {
                return _instance;
            }
        }

        private TransaccionesManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
    }

}