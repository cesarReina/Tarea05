using UnityEngine;

namespace CesarReina
{
    public class Electrodomestico:Recipientes
    {
        private bool encendido;
        float tiempo;

        public bool Encendido() {

            encendido = true;
            return encendido;
        }
    }
    class Olla_arrocera: Electrodomestico
    {
    }
    class Licuadora: Electrodomestico
    {
        bool estado;
        public string agre;
        public int pot;
        public Licuadora( string agre, int pot)
        {
            this.agre = agre;
            this.pot = pot;
            Ingrediente anidido = new Ingrediente("");
            anidido.escribir("si esta aniadido");
        }
        public bool Accion()
        {
            estado = true;
            Debug.Log("esta licuando a una potencia de " + pot + "%" );
            return estado;
        }

    }
    class Horno_micro: Electrodomestico
    {
    }
   
}
