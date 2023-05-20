using GeneralApi.Entities;
using GeneralApi.Models.Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Utils.Managers
{

    public sealed class ReportesManager
    {
        #region singleton
        private readonly static ReportesManager _instance = new ReportesManager();

        public static ReportesManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ReportesManager()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public IEnumerable<ReporteOperaciones> GetOperacionesDestino()
        {
            IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
            using (var db = new parcial_sapEntities())
            {
                var operacionesTmp = from trans in db.transaccion
                                     join det in db.Detalle_de_transaccion on trans.id_transaccion equals det.id_transaccion
                                     join user in db.usuario on trans.id_usuario equals user.id_usuario
                                     join origen in db.sucursal on trans.id_origen equals origen.id
                                     join prod in db.producto on det.id_producto equals prod.id_producto
                                     select new ReporteOperaciones
                                     {
                                         idOperacion = det.id_detalle,
                                         idTransaccion = trans.id_transaccion,
                                         idTienda = trans.id_destino.ToString(),
                                         NombreOrigen = origen.Nombre,
                                         NombreProducto = prod.Nombre,
                                         cantidad = (decimal)det.Cantidad,
                                         usuario = user.usuario1,
                                         fecha = trans.Fecha_de_transaccion.Value
                                     };
                return operacionesTmp.ToList().OrderBy(x => x.fecha);
            }
            ;
        }
        /*
        public IEnumerable<ReporteOperaciones> GetOperacionesConMasTresDia(DateTime dateTime)
        {

            IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
            using (var db = new parcial_sapEntities())
            {
                var detalle = db.transaccion.Where(x => x.Fecha_de_transaccion == dateTime
                                                   & db.Detalle_de_transaccion.Where(y => ))


            }
        }*/
        public IEnumerable<ReporteOperaciones> GetOperacionesFiltroFecha(int idDestino, DateTime inicio, DateTime final)
        {
            IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
            using (var db = new parcial_sapEntities())
            {
                var operacionesTmp = from trans in db.transaccion
                                     join det in db.Detalle_de_transaccion on trans.id_transaccion equals det.id_transaccion
                                     join user in db.usuario on trans.id_usuario equals user.id_usuario
                                     join origen in db.sucursal on trans.id_origen equals origen.id
                                     join destino in db.sucursal on trans.id_destino equals destino.id
                                     join prod in db.producto on det.id_producto equals prod.id_producto
                                     where trans.id_destino == idDestino &
                                     trans.Fecha_de_transaccion > inicio & trans.Fecha_de_transaccion < final
                                     select new ReporteOperaciones
                                     {
                                         idOperacion = det.id_detalle,
                                         idTransaccion = trans.id_transaccion,
                                         NombreOrigen = origen.Nombre,
                                         NombreDestino = destino.Nombre,
                                         NombreProducto = prod.Nombre,
                                         cantidad = (decimal)det.Cantidad,
                                         usuario = user.usuario1,
                                         fecha = trans.Fecha_de_transaccion.Value
                                     };
                return operacionesTmp.ToList().Take(10).OrderBy(x => x.fecha).Reverse();
            }
        }
        public IEnumerable<ReporteOperaciones> GetOperaciones()
        {
            IEnumerable<ReporteOperaciones> operaciones = new List<ReporteOperaciones>();
            using (var db = new parcial_sapEntities())
            {
                var operacionesTmp = from trans in db.transaccion
                                     join det in db.Detalle_de_transaccion on trans.id_transaccion equals det.id_transaccion
                                     join user in db.usuario on trans.id_usuario equals user.id_usuario
                                     join origen in db.sucursal on trans.id_origen equals origen.id
                                     join destino in db.sucursal on trans.id_destino equals destino.id
                                     join prod in db.producto on det.id_producto equals prod.id_producto
                                     select new ReporteOperaciones
                                     {
                                         idOperacion = det.id_detalle,
                                         idTransaccion = trans.id_transaccion,
                                         NombreOrigen = origen.Nombre,
                                         NombreDestino = destino.Nombre,
                                         NombreProducto = prod.Nombre,
                                         cantidad = (decimal)det.Cantidad,
                                         usuario = user.usuario1,
                                         fecha = trans.Fecha_de_transaccion.Value
                                     };
                return operacionesTmp.ToList().OrderBy(x => x.fecha);
            }
        }
    }

}