using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class generatePipe : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffSet = 10;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();

    }

    // Update is called once per frame
    void Update()
    {
        float spawnRate = Random.Range(3, 5);

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float hightPoint = transform.position.y + heightOffSet;

        Instantiate(pipe, new UnityEngine.Vector3(transform.position.x, Random.Range(lowestPoint, hightPoint), 0), transform.rotation);
    }

}
