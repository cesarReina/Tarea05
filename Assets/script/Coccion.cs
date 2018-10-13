using UnityEngine;

namespace CesarReina
{
    public class Coccion
    {
        public float potencia;
        public bool fuego;
        public bool agregado;
        
        public bool Prender()
        {
            fuego = true;
            return fuego;
        }
        public bool Agregado ()
        {
            agregado = true;
            return agregado;
        }
    }

    class Horno : Coccion
{
    }
    public class Cocina : Coccion
    {
        public int cocina;
        public string ing;

        public Cocina ()
        {
            Ingrediente anidido = new Ingrediente("Pollo");
            anidido.escribir("si esta aniadido");
            Ingrediente anidir = new Ingrediente("papa");
            anidido.escribir(" ahora a esperar ");
            Ingrediente aniado = new Ingrediente("arroz");
            aniado.escribir(" esta agregado el arroz ");
            
        }
    }
}
