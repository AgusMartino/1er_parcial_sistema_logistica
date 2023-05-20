using GeneralApi.Entities;
using GeneralApi.Models.Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils
{

    public sealed class SucursalesManager
    {
        #region singleton
        private readonly static SucursalesManager _instance = new SucursalesManager();

        public static SucursalesManager Current
        {
            get
            {
                return _instance;
            }
        }

        private SucursalesManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public sucursal GetSucursal(int id)
        {
            sucursal getSucursal = new sucursal();
            using (var db = new parcial_sapEntities())
            {
                var sucursalTmp =
                    (from sucursal in db.sucursal
                     where sucursal.id == id
                     select sucursal).ToList().First();
                getSucursal = sucursalTmp;
            }
            return getSucursal;
        }

        public List<sucursal> GetTiendas()
        {
            List<sucursal> getSucursal = new List<sucursal>();
            using (var db = new parcial_sapEntities())
            {
                var sucursalTmp =
                    (from sucursal in db.sucursal
                     where sucursal.tipo_de_sucursal == 2
                     select sucursal).ToList();
                getSucursal = sucursalTmp;
            }
            return getSucursal;
        }

        public List<sucursal> GetDepositos()
        {
            List<sucursal> getSucursal = new List<sucursal>();
            using (var db = new parcial_sapEntities())
            {
                var sucursalTmp =
                    (from sucursal in db.sucursal
                     where sucursal.tipo_de_sucursal == 1
                     select sucursal).ToList();
                getSucursal = sucursalTmp;
            }
            return getSucursal;
        }
    }

}