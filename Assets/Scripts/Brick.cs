using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
    //private GameObject[] broken;
    public static int i=0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            i = i + 1;
            gameObject.SetActive(false);
            GetComponentInParent<AudioSource>().Play();
            
            Debug.Log("I ldekhl HEYA ="+i);
            win();



        }
    }
    void win()
    {
        Debug.Log("I lbara HEYA =" + i);
        
        if ( i == 15 )
        {
            Debug.Log("YOU  WIN !");
            SceneManager.LoadScene("win");
            
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log("YOU  WIN !");
            SceneManager.LoadScene("win");
        }

    }
    void Update()
    {
        win();
      
    }
}
