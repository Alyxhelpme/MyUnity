using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //manera de informar a Unity que es requerido este otro componente. Si no existe no va a existir
public class fisicaBola : MonoBehaviour{        
    [SerializeField] //permite que aparezca en el editor de Unity
    private Rigidbody rb; //modificable desde el editor
    [SerializeField]
    float fuerzadeDisparo=10;

    // Start is called before the first frame update
    void Start(){
        //obtener referencia a un componente en el mismo gameobject
        //GetComponent en start o awake 
        rb=GetComponent<Rigidbody>();//dentro de <> va un tipo de parametro abstracto, puede regresar un null. Pero al utilizar RequireComponent ya se inicializa rigidbody  
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            //El vector de fuerza esta en espacio del mundo. No importan los ejes del objeto, la fisica sera respecto al mundo en el que este.

            //3 vectores que sirven para tomar en cuenta orientacion local en espacio global (respecto a los ejes del objeto)
            //* transform.up;
            //* transform.right;
            //* transform.forward;

            // Todo vector esta normalizado (tamaño 1): sirve para expresar direccion y sentido  
            rb.AddForce(transform.up*fuerzadeDisparo, ForceMode.Impulse); //fuerza para que al presionar espacio el objeto se vaya para arriba
        }
    }
}
