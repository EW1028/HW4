using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float destoryX = -12f;
    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < destoryX)
        {
            Destroy(gameObject);
        }
    }
}
