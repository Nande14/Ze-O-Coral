using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delimitador : MonoBehaviour
{
    public float maxRange;
    public float minRange;
    public GameObject collider;
    
    private void Update()
    {
        if(transform.position.x >= maxRange - 1f || transform.position.x <= minRange + 1f)
        {
            collider.SetActive(true);
        }
    }
}
