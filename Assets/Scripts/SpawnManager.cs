using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float rangePositionX = 20.0f;
    private float positionZ = 20.0f;
    private float timeStart = 2f;
    private float eachTime = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", timeStart, eachTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal ()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-rangePositionX, rangePositionX), 0, positionZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
