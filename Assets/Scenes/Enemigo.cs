using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ProyectilJugador"))
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().killedEnemies++;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("ProyectilJugadorPenetrante"))
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().killedEnemies++;

        }
    }
    public void kill()
    {
        FindObjectOfType<GameManager>().killedEnemies++;

    }

}
