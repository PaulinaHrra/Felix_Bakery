using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    private Rigidbody2D cuerpoDelJugador;
    private Animator animatorDelJugador;
    private bool EstaCaminandoEnElEspacio;
    private float speed = 3.5f;

    void Start()
    {
        cuerpoDelJugador = GetComponent<Rigidbody2D>();
        animatorDelJugador = GetComponent <Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            animatorDelJugador.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            EstaCaminandoEnElEspacio = true;
            speed = 3.5f;

        }
         if (Input.GetKeyUp (KeyCode.RightArrow))
        {
            animatorDelJugador.SetBool("esCaminando", false);
             EstaCaminandoEnElEspacio = false;
        }
          if (Input.GetKeyDown (KeyCode.LeftArrow))
        {
            animatorDelJugador.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
             EstaCaminandoEnElEspacio = true;
        }
         if (Input.GetKeyUp (KeyCode.LeftArrow))
        {
            animatorDelJugador.SetBool("esCaminando", false);
            EstaCaminandoEnElEspacio = false;
        }
        if(EstaCaminandoEnElEspacio)
        {
            cuerpoDelJugador.velocity = new Vector2(speed, cuerpoDelJugador.velocity.y);
        }
    }
}
