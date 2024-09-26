using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    //variables y poner físicas

    Rigidbody rb;
    public float jumpForce = 5f;
    public float movementSpeed = 1.5f;
    public int monedascount = 1;
    public TextMeshProUGUI coinsText;

    // para indicar la esfera

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        monedascount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // input significa cuando deja de pulsar la tecla
        // añadir erspacio y que salte

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

        }
        //vector3 es añadir eje x y z
        //
        // movement es el nombre que elijamos
        //impulso y tiempo y movimiento
        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * jumpForce, ForceMode.Impulse);
        //los float se cambian todos si esta en public void

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coinitem"))
        {
            monedascount = monedascount + 1;
            Debug.Log("He tocado la moneda " + monedascount);
        }

        //para que se elimina solo las monedas y no los objetos
        {
            if (other.tag.Contains("coin"))
            {
                coinsText.text = monedascount.ToString();
            
            other.gameObject.SetActive(false);
            }
            // que se borre la moneda
            //si estuviera el true se activaria al pasar
        }

        }
    }


