using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    [SerializeField]
    private Camera camarita;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
        //Raycasting es emision de rayos
        //verficacion de colision entre un rayo y un objeto en escena (que posea collider)
        //REQUISITO PARA SER DETECTABLE POR EL RAYITO
        // 1. que el objeto tenga collider


        //2 casos comunes:
        // 1. desde el puntero del mouse
        // 2. entre objetos del mundo
        if(Input.GetMouseButtonDown(0)){
            // 1. Desde el puntero del mouse, hacer un rayito. Se necesita una camara para invocar un rayito
            Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);

            //out parameeters: hay manera de mandar un parametro para que sea "rellenado" en el metodo

            RaycastHit hit;

            if(Physics.Raycast(rayito,out hit)){ //regresa un booleano si colisiono o no
                print("HUBO COLISION!"+hit.transform.name+" "+hit.point); //donde suscedio la colision entre el rayito y el colldier
            }else{
                print("NO HUBO AAAAA!");
            }
        }
        RaycastHit hit2;

        if(Physics.Raycast(transform.position,transform.forward,out hit2)){
            print("Estoy viendo a: "+hit2.transform.name);
        }else{
            print("No veo a nadie :c");
        }
    }

    //metodos de conveniencia para interaccion con el mouse TODOS sujetos a las reglas de raycast
    void OnMouseEnter(){ //el cuadro en el que el puntero empieza a estar "sobre" el objeto
    }
    void OnMouseOver(){ //cuadro donde el mouse este sobrepuesto al objeto y ya estaba asi en cuadro anterior
    }
    void OnMouseExit(){ //cuadro en donde ele puntero deja de estar sobre el objeto y en el anterior si estaba
    }
    void OnMouseDown(){ //detonado cuando se hace click sobre el objeto, solo en el frame donde sucedio
    }
    void OnMouseDrag(){ //detonado todos los frames en donde se dio click originalmente al objeto y posteriormente se desplaza el puntero, mientras que no se suelte el click
    }
    void OnMouseUp(){ //detonado al soltar el click despues de un down exitoso
    }
    void  OnMouseUpAsButton(){ // casi igual que OnMouseUp pero en este caso se tiene que soltar sobre el objeto
    }

    void OnDrawGizmos(){
        //GIZMOS: elementos graficos visibles solo en editor cuyo unico fin es unicamente informar al dev
        Gizmos.color = Color.red; //Se especifica color
        //Gizmos.DrawWireSphere(transform.position,3);
        Gizmos.DrawRay(transform.position,transform.forward);
        Gizmos.DrawLine(transform.position,transform.position+transform.forward*5);
    }
    void OnDrawGizmosSelected(){
        Gizmos.color=Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(3,3,3));
    }
}