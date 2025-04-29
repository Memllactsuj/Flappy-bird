using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = -3;
    public float heightOffset = 10;
  
    void Start()
    {
        spawnPipe();
    }


    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = -3;
        }
    }

    void spawnPipe ()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPiont = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPiont), 0), transform.rotation);
    }
}
