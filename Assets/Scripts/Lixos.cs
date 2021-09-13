using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lixos : MonoBehaviour
{
    public int Score;
    public string nomeDaCena;
    public string nomeDaOutraCena;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao" )
        {
            Destroy(gameObject);
         
            SceneManager.LoadScene(nomeDaCena);
        }

        if (collision.gameObject.tag == "redezada" ) 
        {
            if (collision.gameObject.GetComponentInParent<Player>().redezinha)
            {
                GameController.instance.totalScore += Score;
                GameController.instance.UpdateScoreText();
                Destroy(gameObject);

            }
            if (!collision.gameObject.GetComponentInParent<Player>().redezinha)
            {
               
                Destroy(gameObject);

            }


        }
        if (GameController.instance.totalScore == 200)
        {
            SceneManager.LoadScene(nomeDaOutraCena);
        }
    }
}
