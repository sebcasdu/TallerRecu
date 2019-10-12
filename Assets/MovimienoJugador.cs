using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimienoJugador : Jugador
{
    public float velocidad, limit;
    Vector3 startPos;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 inclinacion = Input.acceleration;
     if(Mathf.Abs(inclinacion.x)  > 0.1)
        {
            movimientoLateral(inclinacion);

        }
    }
   public void movimientoLateral(Vector3 direccion)
    {
       
       
           
            Vector3 horMov;
        horMov = new Vector3(direccion.x, 0, 0);
        // transform.Translate(horMov);
        rb.AddForce(horMov * velocidad);
       
    }
    /*public bool CheckMovementRestrains()

    {
        bool resultado;

        if (gameObject.transform.position.x < startPos.x+limit && gameObject.transform.position.x > startPos.x - limit)
        {
            resultado = true;
        }else
        { resultado = false; }

        return resultado;
    }*/
}
