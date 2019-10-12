using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisparoJugador : MonoBehaviour
{
    public GameObject proyectil,penetrante;
    Vector3 Toqueinicial, toquefinal;
   public Text tiempopaRarafaga, tiempoparaPenetrante;
    float tiempoparadisparo, tiempoSwipe, tiempoparafaga,t;
   public  Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        
    }
    bool canRafaga = true;
    // Update is called once per frame
    void Update()
    {
        tiempopaRarafaga.text = tiempoparafaga.ToString();
        tiempoparaPenetrante.text = tiempoSwipe.ToString();
        if (tiempoSwipe >0)
        {
            tiempoSwipe -= Time.deltaTime;
        }

        if (tiempoparafaga > 0)
        {   
            tiempoparafaga -= Time.deltaTime;
        }else
        { canRafaga = true; }

        if (Input.touches != null)
        {

          
            if (Input.touchCount == 3)
            {
                foreach (Touch touch in Input.touches)
                {
                    if(touch.phase== TouchPhase.Began)
                    {
                        if (canRafaga)
                        {
                           
                      InvokeRepeating("Rafaga", 0.2f, 0.3f);
                      StartCoroutine(StopRafaga());
                        canRafaga = false;
                            tiempoparafaga = 30;
                        }
                    }
                }

            }
            foreach (Touch touch in Input.touches)
            {
                if(touch.phase== TouchPhase.Began)
                {
                    Toqueinicial = touch.position;
                    shoot();
                    
                    Debug.Log("disparonormal");
                }
                if(touch.phase == TouchPhase.Ended )
                {
                    toquefinal = touch.position;
                    if(Toqueinicial.y <toquefinal.y && (toquefinal - Toqueinicial).magnitude > 150)
                    { BalaReAsesina();
                    Debug.Log("disparoasesino");
                        
                    }

                }

            }
        }
       
    }
    bool canshoot=true;
    public void shoot()
    {
        
            if (canshoot)
             {
            
            Instantiate(proyectil, spawn.position, Quaternion.identity);
        canshoot = false;
            StartCoroutine(CargaDisparo());
        }
}

    public void Rafaga()
    {
       
        Instantiate(proyectil, spawn.position, Quaternion.identity);

        
    }

   public IEnumerator StopRafaga()
    {

        yield return new WaitForSeconds(3f);
        
        CancelInvoke();
    }
    bool canshootpenetrante=true;
    public void BalaReAsesina()
    {
        if (canshootpenetrante)
        {
            tiempoSwipe = 60;
            Instantiate(penetrante, spawn.position, Quaternion.identity);
        canshootpenetrante = false;
            StartCoroutine(CargaBalaReAsesina());
        }
    }
    public IEnumerator CargaDisparo()
    {

        yield return new WaitForSeconds(0.7f);
        canshoot = true;
    }
    public IEnumerator CargaBalaReAsesina()
    {

        yield return new WaitForSeconds(60);
        canshootpenetrante = true;
    }
    /*public IEnumerator CargaDisparo()
    {
        yield return;
    }*/
}
