using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLinea : MonoBehaviour
{
    public Transform target;
    public float velLinea;
    EnemySpawner es;
    // Start is called before the first frame update
    void Start()
    {
        es = FindObjectOfType<EnemySpawner>();
        target.position = new Vector3(transform.position.x+15, transform.position.y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 1)
        {
            es.CreateLine();
            Destroy(gameObject);


        }
        transform.position= Vector3.MoveTowards(transform.position, target.position, velLinea*Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("limites"))
        {
           
            transform.position = transform.position + Vector3.back;
            target.position = new Vector3(-target.position.x, target.position.y, target.position.z);


        }
    }
}
