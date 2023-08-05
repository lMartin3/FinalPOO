using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Logica
    {
        RepoClientes clientes;
        RepoProductos productos;
        RepoProveedores proveedores;
        public Logica()
        {
            //Esto esta re mal creo no se estoy probando ostra cosa
            Inicio();
        }

        private void Inicio()
        {
            //Clientes dummies
            Cliente cliente1 = new Cliente(45555515, CondicionFiscal.MONOTRIBUTISTA, "Juan Carlo Esposito", "Suipacha 2002");
            Cliente cliente2 = new Cliente(45555516, CondicionFiscal.RESPONSABLE_INSCRIPTO, "Tarlos Tabón", "Floripia 16");
            Cliente cliente3 = new Cliente(45555517, CondicionFiscal.CONSUMIDOR_FINAL, "Damian Pepino", "Mendoza 2335");
            clientes.AnadirElemento(cliente1);
            clientes.AnadirElemento(cliente2);
            clientes.AnadirElemento(cliente3);
            //Categorias Producto

            //Productos dummies
            Producto producto1 = new Producto(0, "Coca Cola 3L", "Una coca de tres listros", 1200, 20, );
            clientes.AnadirElemento(cliente1);
        }
    }
}
