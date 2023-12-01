using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR_RLG
{
    public class Lista
    {
        private Nodo Inicio;
        private Nodo Final;

        public Lista()
        {
            Inicio = Final = null;
        }

        public bool ListaVacia()
        {
            if (Inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarCarroFlota(carro carro)
        {
            Nodo actual = new Nodo();
            actual.vehiculo= carro;
            
            if(ListaVacia())
            {
                Inicio = actual;
                Final = actual;
            }
            else
            {
                Final.Siguiente = actual;
                Final = actual;
            }
        }


        public void mostrarFlota()
        {
            if (!ListaVacia())
            {
                Nodo actual = Inicio;
                actual.vehiculo = Inicio.vehiculo;
                while (actual != null)
                {
                    Console.WriteLine
                    ($"Marca: {actual.vehiculo.Marca} | Modelo: {actual.vehiculo.Modelo} | Año de Lanzamiento: {actual.vehiculo.Año}");
                    actual = actual.Siguiente;
                }
            }
            else { Console.WriteLine("La lista esta vacia"); }
        }

        public void ordenarAño()
        {
            if (!ListaVacia())
            {
                for (int i = 0; i<5;i++) {
                    
                        Nodo actual = Inicio;
                    if (actual.vehiculo.Año > actual.Siguiente.vehiculo.Año) {
                        while (actual != null)
                        {
                            Console.WriteLine
                            ($"Marca: {actual.vehiculo.Marca} | Modelo: {actual.vehiculo.Modelo} | Año de Lanzamiento: {actual.vehiculo.Año}");
                         actual = actual.Siguiente;
                        }
                    }
                }
            }
            else { Console.WriteLine("La lista esta vacia"); }

        }

        public void busquedaMarca(string marca)
        {
            if (!ListaVacia())
            {
                Nodo actual = Inicio;
                while (actual != null)
                {
                    if (actual.vehiculo.Marca.Contains(marca))
                    {
                        Console.WriteLine($"Marca: {actual.vehiculo.Marca} | Modelo: {actual.vehiculo.Modelo} | Año de Lanzamiento: {actual.vehiculo.Año}");

                    }
                }
            }
        }
    }
}
