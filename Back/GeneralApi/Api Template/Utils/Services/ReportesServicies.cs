using GeneralApi.Entities;
using GeneralApi.Utils.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Services
{

    public sealed class ReportesServicies
    {
        #region singleton
        private readonly static ReportesServicies _instance = new ReportesServicies();

        public static ReportesServicies Current
        {
            get
            {
                return _instance;
            }
        }

        private ReportesServicies()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public IEnumerable<ReporteOperaciones> GetOperacionesDestino()
        {
            try
            {
                IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
                operaciones = ReportesManager.Current.GetOperacionesDestino();
                return operaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ReporteOperaciones> GetOperacionesFiltroFecha(int idDestino, DateTime inicio, DateTime final)
        {
            try
            {
                IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
                operaciones = ReportesManager.Current.GetOperacionesFiltroFecha(idDestino, inicio, final);
                return operaciones;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<ReporteOperaciones> GetOperaciones()
        {
            try
            {
                IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
                operaciones = ReportesManager.Current.GetOperaciones();
                return operaciones;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /*
        public IEnumerable<ReporteOperaciones> GetOperacionesConMasTresDia(DateTime dateTime)
        {
            try
            {
                IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
                operaciones = ReportesManager.Current.GetOperacionesConMasTresDia(dateTime);
                return operaciones;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/
    }

}