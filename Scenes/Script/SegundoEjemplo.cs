using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SegundoEjemplo : MonoBehaviour

{
    //Variables
    // Tipo de dato  Nombre
    int Numerodesaltos =0;
    public int Primerlogrosaltos = 10;
    public int segundologrosaltos = 20;
    public int tercerlogrosalto = 30;
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

  
    }
    private void OnCollisionEnter(Collision collision)
    {
        Numerodesaltos = Numerodesaltos + 1;

        //Debug.Log("Veces que choca"+""  + " " + gameObject.name + "he chocado con" + collision.gameObject.name);

        if (Numerodesaltos == Primerlogrosaltos)

        {
            Debug.Log("He chocado 10 veces  " + gameObject.name);
        }

        else if (Numerodesaltos == segundologrosaltos) 

        {
            Debug.Log("Choque 20 veces  " + gameObject.name);
        }

        else if (Numerodesaltos == tercerlogrosalto) 
           
        {
            Debug.Log("choque 30 veces  " + gameObject.name);
        }





    }


}
