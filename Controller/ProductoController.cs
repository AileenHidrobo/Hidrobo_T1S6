using System;
using System.Collections.Generic;
using System.Linq;
using Hidrobo_T1S6.Models; // Asegúrate de que esta ruta sea correcta
using Hidrobo_T1S6.DATA;   // Ruta donde está tu AppContext

namespace Hidrobo_T1S6.Controller
{
    public class ProductoController
    {
        private readonly DATA.AppContext _appContext;

        public ProductoController()
        {
            _appContext = new DATA.AppContext();
        }

        public string Insertar(ProductoModel productoModel)
        {
            try
            {
                productoModel.Create_At = DateTime.Now;
                productoModel.Update_Up = DateTime.Now;
                _appContext.Productos.Add(productoModel);
                _appContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar(ProductoModel productoModel)
        {
            var existe = _appContext.Productos.Find(productoModel.ProductoId);
            if (existe != null)
            {
                try
                {
                    existe.Nombre = productoModel.Nombre;
                    existe.Lote = productoModel.Lote;
                    existe.FechaIngreso = productoModel.FechaIngreso;
                    existe.FechaCaducidad = productoModel.FechaCaducidad;
                    existe.Proveedor = productoModel.Proveedor;
                    existe.Stock = productoModel.Stock;
                    existe.PrecioUnitario = productoModel.PrecioUnitario;
                    existe.Update_Up = DateTime.Now;
                    _appContext.SaveChanges();
                    return "ok";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "El producto no existe";
            }
        }

        public string Eliminar(int productoId)
        {
            try
            {
                var existe = _appContext.Productos.Find(productoId);
                if (existe != null)
                {
                    _appContext.Productos.Remove(existe);
                    _appContext.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "El producto no existe";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ProductoModel> ObtenerTodos()
        {
            return _appContext.Productos.ToList();
        }

        public ProductoModel ObtenerUno(int id)
        {
            var existe = _appContext.Productos.Find(id);
            if (existe != null)
            {
                return existe;
            }
            else
            {
                return new ProductoModel(); // Retorna vacío si no existe
            }
        }
    }
}
