using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{

    public GameObject circlePrefab;
    public Vector3 spawnLocation;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            float randomX = Random.Range(-0.5f, 0.5f);
            spawnLocation.x = spawnLocation.x + randomX;
            Instantiate(circlePrefab,spawnLocation,Quaternion.identity);
        }
    }
}
