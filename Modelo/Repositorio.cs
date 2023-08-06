using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;

namespace Modelo
{
    public abstract class Repositorio<T>
    {
        protected List<T> elementos = new List<T>();
        public ReadOnlyCollection<T> ElementosAlmacenados => elementos.AsReadOnly();
        public virtual bool IntentarAnadirElemento(T nuevoElemento)
        {
            if (!VerificarElemento(nuevoElemento))
            {
                return false;
            }
            AnadirElemento(nuevoElemento);
            return true;
        }
        protected virtual void AnadirElemento(T elementoAAnadir)
        {
            elementos.Add(elementoAAnadir);
        }
        public virtual void EliminarElemento(T elementoAEliminar)
        {
            elementos.Remove(elementoAEliminar);
        }

        protected abstract bool VerificarElemento(T elementoAVerificar);
    }
}