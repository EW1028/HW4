using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePairPrefab;

    public float spawnInterval = 1.5f;
    public float spawnX = 10f;
    public float minY = -2f;
    public float maxY = 2f;

    private float timer;
    private void Update()
    {
        if (!GameController.Instance.IsPlaying)
            return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnPipePair();
            timer = 0f;
        }
    }

    private void SpawnPipePair()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0f);
        Instantiate(pipePairPrefab, spawnPos, Quaternion.identity);
    }
}
