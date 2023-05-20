using GeneralApi.Models.Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Managers
{

    public sealed class UsuarioManager
    {
        #region singleton
        private readonly static UsuarioManager _instance = new UsuarioManager();

        public static UsuarioManager Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public usuario login(string user, string pass)
        {
            using (var db = new parcial_sapEntities())
            {
                var userdb = (from usua in db.usuario 
                             where usua.usuario1 == user &
                             usua.contraseña == pass
                             select usua).ToList().First();
                return userdb;
            }
        }
    }

}