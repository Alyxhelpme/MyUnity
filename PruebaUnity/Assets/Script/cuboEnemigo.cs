using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboEnemigo : MonoBehaviour
{
    GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
        //PROBLEMA: obtener de manera dinamica una referencia a un objeto en escena

        //la facil:
        jugador=GameObject.Find("Jugador"); //si se usa, utilizar en start
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
