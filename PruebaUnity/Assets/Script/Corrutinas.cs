using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    // Start is called before the first frame update
    //Todas las corrutinas pertenecen a un componente
    private IEnumerator ejemplo2a;
    private IEnumerator ejemplo2b;
    void Start(){
        ejemplo2a=ejemplo2();
        ejemplo2b=ejemplo2();
        StartCoroutine(ejemplo());
        StartCoroutine(ejemplo2a);
        StartCoroutine(ejemplo2b);
        // O J O - se pueden iniciar varias corrutinas
        // utilizando el mismo metodo   
    }

    // Metodo se adhiere al loop principal
    //1. entrada
    //2. movimiento
    void Update()
    {
        //Que pasa con las cosas que requieren suceder con cieerta frecuencia que no son ENTRADA NI MOVIMMIENTO?
        //--CORRUTINA--
        //Pseudohilo y pseudoconcurrencia

        //como detener corrutinas
        //2 cosas
        //1. detener todas
        //2. detener alguna en particular

        if (Input.GetKeyDown(KeyCode.A)){
            StopAllCoroutines();
        }
        if (Input.GetKeyDown(KeyCode.S)){
            //detener corrutina en particular
            //REQUISITO: referencia a la corrutina
            StopCoroutine(ejemplo2b);
        }

    }
     IEnumerator ejemplo(){
            //ceder el paso
            yield return new WaitForSeconds(2); //Cuando se hace esto no se termina la ejecucion de la funcion 
            print("Oa despues de 2 segunddos");
        }

    IEnumerator ejemplo2(){
        while(true){
            print("tu mama");
            yield return new WaitForSeconds(1);
        }
    }
}
