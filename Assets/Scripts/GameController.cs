using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;
    public GameObject pilha;
    public GameObject pote;
    public GameObject garrafaP;
    public GameObject garrafaV;
    public GameObject potinho;
    public GameObject copo;
    public GameObject latinha;
    public GameObject sacola;
    public GameObject vidro;
    public GameObject banana;






    public static GameController instance;
   
    void Start()
    {
        instance = this;
        InvokeRepeating("SpawnGarrafaP", 1, 12);
        InvokeRepeating("SpawnPotinho", 3, 12);
        InvokeRepeating("SpawnPilha", 5, 12);
        InvokeRepeating("SpawnGarrafaV", 7, 12);
        InvokeRepeating("SpawnPote", 9, 12);
        InvokeRepeating("SpawnCopo", 11, 12);
        InvokeRepeating("SpawnLatinha", 13, 12);
        InvokeRepeating("SpawnSacola", 15, 12);
        InvokeRepeating("SpawnVidro", 17, 12);
        InvokeRepeating("SpawnBanana", 19, 12);
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    void SpawnPilha()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(pilha, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnPote()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(pote, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnGarrafaP()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(garrafaP, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnGarrafaV()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(garrafaV, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnPotinho()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(potinho, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnCopo()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(copo, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnLatinha()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(latinha, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnSacola()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(sacola, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnVidro()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(vidro, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }
    void SpawnBanana()
    {
        float x = Random.Range(-12.0f, 10.0f);
        float y = Random.Range(15.0f, 25.0f);
        Instantiate(banana, new Vector3(x, y, -5.2359f), Quaternion.identity);


    }


}
