using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixos : MonoBehaviour
{
    public int Score;
    
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao" );
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Redezada" ) ;
        {
            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();
            Destroy(gameObject);
            //Ir pra tela de derrota
        }

    }
}
