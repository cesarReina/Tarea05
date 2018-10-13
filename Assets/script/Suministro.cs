using UnityEngine;

namespace CesarReina
{
    class Suministro
    {
        public int cantidad;
        public bool suministro;

        public bool Suministrando()
        {
            suministro = true;
            return suministro;
        }
        public Suministro(int cantidad, bool suministro)
        {
            this.cantidad = cantidad;
            this.suministro = suministro;
            Debug.Log(" todavia esta suministrando gas ");
            
        }
        public void Informe ()
        {
            Debug.LogWarning("ADVERTECNIA EL GAS SI ESTA SUMINISTRANDO " + suministro + " PERO ESTA HA " + cantidad + "%");
        }
        
    }
   class Gas
    {
        public int gas;
    }
    class Fosforo
    {
        public int fosforo;
    }
}
