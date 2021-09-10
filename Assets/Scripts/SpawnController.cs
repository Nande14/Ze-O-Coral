using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    public GameObject asteroid;





    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 1, 20);


    }


    void Update()
    {

    }

    void SpawnAsteroid()
    {
        float x = Random.Range(-13.0f, 11.0f);
        float y = Random.Range(25.0f, 30.0f);
        Instantiate(asteroid, new Vector3(x, y, 2), Quaternion.identity);
        

    }




}

