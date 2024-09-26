using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class coinbehaviour : MonoBehaviour
{

    public Vector3 speedRotation;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
        // * significa multiplicar
        // solucion errores de monedas y mapa de ajustes , space.World
        // Time.deltatime,
        //colocar el tiempo  de la moneda 
    {
        transform.Rotate(speedRotation * Time.deltaTime, Space.World );

       
    }
}
