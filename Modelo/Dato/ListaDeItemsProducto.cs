using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dato
{
    public abstract class  ListaDeItemsProducto
    {
        private List<ItemProducto> items = new List<ItemProducto>();
        public ReadOnlyCollection<ItemProducto> itemsReadonly => items.AsReadOnly();

        public ListaDeItemsProducto(List<ItemProducto> items = null)
        {
            if (items == null) 
            {
                items = new List<ItemProducto>();
            }
            this.items = items;
        }

        public int ObtenerStockUtilizadoDeProducto(Producto producto)
        {
            return itemsReadonly.Where(itm => itm.Producto == producto)
                .Sum(itm => itm.Cantidad);
        }
        protected virtual bool EvaluarItem(ItemProducto itemAEvaluar)
        {
            return true;
        }
        public bool AddItem(ItemProducto itemAAgregar)
        {
            if (!EvaluarItem(itemAAgregar))
            {
                return false;
            }
            items.Add(itemAAgregar);
            return true;
        }

        public void RemoverItem(ItemProducto itemARemover)
        {
            items.Remove(itemARemover);
        }
        public void RemoverItemEn(int indice)
        {
            items.RemoveAt(indice);
        }

    }
}
