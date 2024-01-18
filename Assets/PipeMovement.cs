using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = Random.Range(5, 8);
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
