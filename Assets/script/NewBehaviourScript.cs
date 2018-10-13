      using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CesarReina;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Cocina preprarar = new Cocina();

        Debug.Log("hay que esperar que se cocine el pollo ");
        Debug.Log("mientras eso esta, hay que licuar");

        Licuadora licuar = new Licuadora("galleta", 25);
        licuar.Accion();

        Debug.Log(" el pollito ya esta cocinado");
        Debug.Log(" ahora hay que cocinar las papas");

        Cocina papa = new Cocina();

        Debug.Log(" el licuado ya esta ");
        Debug.Log(" ahora solo falta el arroz ");

        Cocina ahorros = new Cocina();

        Suministro suministrar = new Suministro(30, true);
        suministrar.Informe();

        Debug.Log(" muy bien las papas ya estan, solo hay que esperar el arroz");
        Debug.Log(" bueno ya esta el arroz ");
        Debug.Log(" bueno se acabo TwT");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
