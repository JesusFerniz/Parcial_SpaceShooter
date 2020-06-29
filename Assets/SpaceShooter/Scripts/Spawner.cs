
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float timeBetweenSpawns = 1f;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, timeBetweenSpawns);
    }
    void Spawn()
    {
        float x = Random.Range(-3.25f, 3.61f);
        Vector3 position = new Vector3(x, transform.position.y, 0f);

        int random = Random.Range(0, prefabs.Length);

        Instantiate(prefabs[random], position, Quaternion.identity);
    }
}