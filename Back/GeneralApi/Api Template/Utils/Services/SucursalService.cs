using GeneralApi.Models.Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Services
{

    public sealed class SucursalService
    {
        #region singleton
        private readonly static SucursalService _instance = new SucursalService();

        public static SucursalService Current
        {
            get
            {
                return _instance;
            }
        }

        private SucursalService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public sucursal GetSucursal(int id)
        {
            try
            {
                sucursal getSucursal = new sucursal();
                getSucursal = SucursalesManager.Current.GetSucursal(id);
                return getSucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<sucursal> GetTiendas()
        {
            try
            {
                List<sucursal> getSucursal = new List<sucursal>();
                getSucursal = SucursalesManager.Current.GetTiendas();
                return getSucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<sucursal> GetDepositos()
        {
            try
            {
                List<sucursal> getSucursal = new List<sucursal>();
                getSucursal = SucursalesManager.Current.GetDepositos();
                return getSucursal;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

}