using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    // CICLO DE VIDA : métodos que se ejecutan en momentos específicos
    // en la vida de un script.

    // idioms - estándares de escritura en lenguaje
    
    // se ejecuta al inicio de la vida del script una sola vez
    void Awake() { print("HOLA MUNDO"); }
    // Start is called before the first frame update
    void Start() {
        
        Debug.Log("START");

    }

    int contador = 0;
    // Update is called once p.er frame (ENGINE LOOP)
    //realtime - 30fps
    //best fr for a game - 60fps
    void Update() {

        // contador++;
        
        // print("HOLA MUNDO NUM " + contador++);

        
        // for (int j = 0; j < 500; j++) {

        //     print("Trabando el pinche programa culero");

        // }

        //input de usuario (movement and shit)


        // transform.Translate(1f * Time.deltaTime, 0, 0);

        // manejo de entrada
        // polling vs events

        // polling directo a dispositivos 

        // if (Input.GetKey(KeyCode.UpArrow)) {
            
        //     //detona cuando
        //     // cuadro anterior está libre
        //     // cuadro actual esta presionado
        //     transform.Translate(2f * Time.deltaTime, 0, 0);
        //     print("KEY");

        // }

        // if (Input.GetKey(KeyCode.DownArrow)) {
            
        //     //detona cuando
        //     // cuadro anterior está libre
        //     // cuadro actual esta presionado
        //     transform.Translate(-2f * Time.deltaTime, 0, 0);
        //     // print("KEY");

        // }

        // if(Input.GetMouseButtonDown(0)){

        //     print(Input.mousePosition);

        // }

        // limitante del sistema anterior, la logica está asociada directamente con un elemento
        // físico


        

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * (Time.deltaTime + 0.3f), 0, 0);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0, vertical * (Time.deltaTime + 0.3f), 0);

    }

    void lateUpdate() {


        // for (int j = 0; j < 500; j++) {

        //     print("ey");

        // }

    }

    void fixedUpdate() {

    

    }

}
