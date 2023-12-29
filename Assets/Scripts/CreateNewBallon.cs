using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBallon : MonoBehaviour
{
    public GameObject ballonsPrefab;

    public float renderingTime = 1f; 
    private float timer = 0f;
    Vector3 newPosition;

    void Update()
    {
       
        timer += Time.deltaTime;

        
        if (timer >= renderingTime)
        {
            timer = 0f;
            CreateBallons();

        }
    }

    
    public void CreateBallons()
    {
        float randomX = Random.Range(-6.82f, 6.66f);
        Vector3 newPosition = new Vector3(randomX, 1f, 0f);
        Instantiate(ballonsPrefab, newPosition, Quaternion.identity);
    }
    
}
