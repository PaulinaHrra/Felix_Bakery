using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
     private Rigidbody2D cuerpoFelix;
    
    private Animator animacion;

    private bool caminar;

    private float speed = 5f;

    //Salto
    public LayerMask capaPiso;
    
    public Transform detector;
    
    public float fuerzaSalto;
    
    private bool estaPisando;
    
    private float radioSensor=0.07f;

    void Start()
    {
        cuerpoFelix = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        estaPisando = Physics2D.OverlapCircle(detector.position, radioSensor, capaPiso);
        animacion.SetBool("esSaltando", !estaPisando);
    }

    //Cosas del update
    void Update()
    {
        
        //Movimiento Sexy
        if(Input.GetKey(KeyCode.RightArrow))
        {
            animacion.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            cuerpoFelix.velocity = new Vector2(speed, cuerpoFelix.velocity.y);
            caminar= true;
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)) 
        {
             animacion.SetBool("esCaminando", false);
             transform.localRotation = Quaternion.Euler(0, 0, 0);
             caminar = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animacion.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            cuerpoFelix.velocity = new Vector2(-speed, cuerpoFelix.velocity.y);
            caminar = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animacion.SetBool("esCaminando", false);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            caminar = false;
        }

       
        if(estaPisando) 
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                cuerpoFelix.AddForce(new Vector2(0, fuerzaSalto));
            }

        }
    
    }
}
