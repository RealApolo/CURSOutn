using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]private float Speed = 0.1f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //SE CAMBIA LA POSICION EN X, HACIA LA IZQUIEDA(X)            
            //transform.Translate(x,y,z);
            transform.Translate(-Speed * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //SE CAMBIA LA POSICION EN X, HACIA LA DERECHA(X) 
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D objetoConElQueChoco)
    {
        //Destroy(this.gameObject);
        SceneManager.LoadScene("Menu");
    }
}
