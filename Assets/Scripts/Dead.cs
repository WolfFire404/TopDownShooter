using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public int lives = 3;


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            lives--;
            if(lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
