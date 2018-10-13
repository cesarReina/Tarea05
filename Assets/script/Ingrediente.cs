using UnityEngine;

namespace CesarReina
{
    public class Ingrediente
    {
         public string ing;

        public Ingrediente (string ing)
        {
            this.ing = ing;
        }

        public void escribir (string msj)
        {
            Debug.Log(msj);
            
        } 
    }
}
 