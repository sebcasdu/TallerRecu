using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
     poolEnemgios enemypool;
   public  int cantidadLineas;
    public GameObject linea;
     GameObject[] lineas;
    // Start is called before the first frame update
    void Start()
    {
        float sep = 0;
        enemypool = FindObjectOfType<poolEnemgios>();
        lineas = new GameObject[cantidadLineas];
        for (int i=0; i<lineas.Length;i++)
        {
            Vector3 newpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,gameObject.transform.position.z+sep);
            sep +=1.5f;

            Instantiate(linea, newpos, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    public void CreateLine()
    {

        Instantiate(linea, transform.position, Quaternion.identity);


    }
    public void moveLine()
    {

    }
   
}
