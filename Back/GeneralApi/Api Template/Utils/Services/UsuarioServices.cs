using GeneralApi.Models.Parcial;
using GeneralApi.Utils.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Services
{

    public sealed class UsuarioServices
    {
        #region singleton
        private readonly static UsuarioServices _instance = new UsuarioServices();

        public static UsuarioServices Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioServices()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public usuario Login(string user, string password)
        {
            try
            {
                return UsuarioManager.Current.login(user, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}