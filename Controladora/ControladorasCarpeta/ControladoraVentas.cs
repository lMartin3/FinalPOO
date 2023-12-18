using Entidades;
using Microsoft.EntityFrameworkCore;
using NuevoModelo;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras
{
    public class ControladoraVentas
    {
        public IReadOnlyCollection<Venta> ListarVentas()
        {
            return ContextoPapeleria.Instancia.Ventas
                .Include(v => v.Items)
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Método para obtener todas las ventas en un periodo de dos fechas
        /// </summary>
        /// <param name="inicio">Incio del periodo (inclusivo)</param>
        /// <param name="fin">Fin del periodo (inclusivo)</param>
        /// <returns>Una lista de todas las ventas en el periodo ordenadas por fecha en orden ascendiente (mas antiguas primero)</returns>
        public IReadOnlyCollection<Venta> ListarVentasEnPeriodo(DateTime inicio, DateTime fin)
        {
            return ContextoPapeleria.Instancia.Ventas
                .Where(v => v.Fecha.Date >= inicio.Date && v.Fecha.Date <= fin.Date)
                .OrderBy(v=>v.Fecha)
                .ToList().AsReadOnly();
        }

        public Dictionary<CategoriaProducto, double> ListarIngresosPorCategoriaEnPeriodo(DateTime inicio, DateTime fin)
        {
            Dictionary<CategoriaProducto, double> resultado = new Dictionary<CategoriaProducto, double>();
            foreach (Venta venta in ListarVentasEnPeriodo(inicio, fin))
            {
                foreach (ItemProducto item in venta.Items)
                {
                    double monto = resultado.GetValueOrDefault(item.Producto.CategoriaProducto, 0);
                    monto += item.Subtotal;
                    resultado.Remove(item.Producto.CategoriaProducto);
                    resultado.Add(item.Producto.CategoriaProducto, monto);
                }
            }
            return resultado;
        }

        public Dictionary<Cliente, double> ListarIngresosPorClienteEnPeriodo(DateTime inicio, DateTime fin)
        {
            Dictionary<Cliente, double> resultado = new Dictionary<Cliente, double>();
            foreach (Venta venta in ListarVentasEnPeriodo(inicio, fin))
            {
                double monto = resultado.GetValueOrDefault(venta.Cliente, 0);
                monto += venta.Total;
                resultado.Remove(venta.Cliente);
                resultado.Add(venta.Cliente, monto);
            }
            return resultado;
        }

        public SortedDictionary<DateTime, double> ListarIngresosAgrupadosPorFechaEnPeriodo(DateTime inicio, DateTime fin)
        {
            List<Venta> ventas = new List<Venta>(ListarVentasEnPeriodo(inicio, fin));
           
            SortedDictionary<DateTime, double> montoPorFecha = new SortedDictionary<DateTime, double>();
            int indexVentas = 0;
            for (var dt = inicio; dt.Date <= fin.Date; dt = dt.AddDays(1))
            {
                double totalVendidoEnFecha = 0;
                while(true&&indexVentas<ventas.Count)
                {
                    Venta venta = ventas[indexVentas];
                    if (venta.Fecha.Date != dt.Date) break;
                    totalVendidoEnFecha += venta.Total;
                    indexVentas++;
                }
                montoPorFecha.Add(dt, totalVendidoEnFecha);
                
            }
            return montoPorFecha;



        }


        
        public ResultadoOperacion CrearVenta(Venta venta)
        {
            if(ContextoPapeleria.Instancia.Ventas.Where(v=>v.NroVenta == venta.NroVenta).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.Fallo("Ya existe una venta con ese número!");
            }

            ResultadoOperacion checkProductos = EvaluarItems(venta.Items.ToList());
            if (!checkProductos.Exito)
            {
                return checkProductos;
            }

            foreach (ItemProducto item in venta.Items.ToList())
            {
                Producto producto = item.Producto;
                producto.Stock -= item.Cantidad;
                Papeleria.Instancia.Productos.ActualizarProducto(producto);
            }

            Papeleria.Instancia.Alertas.CheckearProductosPorAlertas("roy.correo@gmail.com");

            ContextoPapeleria.Instancia.Ventas.Add(venta);
            ContextoPapeleria.Instancia.SaveChanges();
            
            return ResultadoOperacion.Exitosa();
        }
        public ResultadoOperacion EliminarVenta(Venta venta)
        {
            // TODO checks de lógica
            ContextoPapeleria.Instancia.Ventas.Remove(venta);
            ContextoPapeleria.Instancia.SaveChanges();

            foreach (ItemProducto item in venta.Items.ToList())
            {
                Producto producto = item.Producto;
                producto.Stock += item.Cantidad;
                Papeleria.Instancia.Productos.ActualizarProducto(producto);
            }

            return ResultadoOperacion.Exitosa();
        }

        private ResultadoOperacion EvaluarItems(List<ItemProducto> items)
        {
            foreach(ItemProducto item in items)
            {
                ResultadoOperacion resultado = EvaluarItem(item);
                if (!resultado.Exito)
                {
                    return resultado;
                }
            }

            return ResultadoOperacion.Exitosa();
        }

        private ResultadoOperacion EvaluarItem(ItemProducto item)
        {
            if (item.PrecioUnitario < 0)
            {
                return ResultadoOperacion.Fallo($"El precio unitario de {item.Producto.Nombre} es negativo");
            }
            if (item.Cantidad <= 0)
            {
                return ResultadoOperacion.Fallo($"La cantidad de {item.Producto.Nombre} debe ser mayor a 0!");
            }

            //TODO fijarse esto
            int stockDisponible = Papeleria.Instancia.Productos.BuscarStockPorCodigo(item.Producto.Codigo);
            if (stockDisponible < item.Cantidad)
            {
                return ResultadoOperacion.Fallo($"No hay suficiente stock de {item.Producto.Nombre}");
            }
            return ResultadoOperacion.Exitosa();
        }

    }
}
