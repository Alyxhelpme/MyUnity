using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonJugador : MonoBehaviour
{
    public singletonJugador Instance{
        get; //si no se pone modificador se hereda de afuera
        private set; //si se pone modificador y es mas restrictivo (private) se sobreescribe
    }

    // Start is called before the first frame update
    void Start(){
        //verificar si ya hay una instancia de singleton
        if(Instance!=null){
            //si hubiera lo destruimos
            Destroy(gameObject);
        }else{
            Instance=this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
