using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Jugador jg;
    public Canvas  Derrota;
    public float killedEnemies;
    public Text enemigosmuertos;
    

    // Start is called before the first frame update
    void Start()
    {
        Derrota.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        enemigosmuertos.text = killedEnemies.ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemigo>()!= null)
        {
            Derrota.enabled = true;
            Time.timeScale = 0;

        }

    }
    public void algo()
    {


    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);

    }
}
