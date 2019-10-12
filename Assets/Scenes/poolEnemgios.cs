using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolEnemgios : MonoBehaviour
{
    private List<GameObject> pool;
   // private GameObject[] pool;
    public GameObject enemigoPrefab;
    public int numeroEnemigos;
    // Start is called before the first frame update
    void Start()
    {
        pool = new List<GameObject>();
        
        for(int i=0; i<numeroEnemigos; i++)
        {
            Instantiate(enemigoPrefab, gameObject.transform.position, Quaternion.identity);
            pool.Add(enemigoPrefab);
           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SendEnemy(GameObject ene)
    {
        pool.Add(ene);
        ene.transform.position = gameObject.transform.position;

    }
    public void PullEnemy(Vector3 pos,int index)
    {

        
        pool[index].transform.position= pos;
        pool.RemoveAt(index);
        Debug.Log(index);
    }

}
