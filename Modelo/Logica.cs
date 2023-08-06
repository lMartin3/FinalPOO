using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Logica
    {
        public RepoClientes clientes = new RepoClientes();
        public RepoProductos productos = new RepoProductos();
        public RepoProveedores proveedores = new RepoProveedores();
        public RepoVentas ventas = new RepoVentas();
        public Logica()
        {
            //Esto esta re mal creo no se estoy probando ostra cosa
            Inicio();
        }

        private void Inicio()
        {
            DummyRepositoriesFill();
        }

        public bool IntentarRegistrarVenta(Venta venta)
        {
            return ventas.IntentarAnadirElemento(venta);
        }

        private void DummyRepositoriesFill()
        {
            //Clientes dummies
            Cliente cliente1 = new Cliente(45555515, CondicionFiscal.MONOTRIBUTISTA, "Juan Carlo Esposito", "Suipacha 2002");
            Cliente cliente2 = new Cliente(45555516, CondicionFiscal.RESPONSABLE_INSCRIPTO, "Tarlos Tabón", "Floripia 16");
            Cliente cliente3 = new Cliente(45555517, CondicionFiscal.CONSUMIDOR_FINAL, "Damian Pepino", "Mendoza 2335");
            clientes.IntentarAnadirElemento(cliente1);
            clientes.IntentarAnadirElemento(cliente2);
            clientes.IntentarAnadirElemento(cliente3);
            //Categorias Producto
            CategoriaProducto categoriaLacteos = new CategoriaProducto(0, "Lacteo", "Productos que dió la vaca.");
            CategoriaProducto categoriaCarnes = new CategoriaProducto(0, "Carne", "Productos que le sacamos a la vaca.");
            //Productos dummies
            Producto producto1 = new Producto(0, "Coca Cola 3L", "Una coca de tres litros", 1200, 20, categoriaLacteos);
            Producto producto2 = new Producto(0, "Milanesa", "1.5KG de milanesa lista para freir", 2000, 20, categoriaCarnes);
            productos.IntentarAnadirElemento(producto1);
            productos.IntentarAnadirElemento(producto2);
        }
    }
}
