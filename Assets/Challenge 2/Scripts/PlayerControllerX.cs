using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;


   
    public float spawnInterval = 1.0f;
    private bool canSpawn = true;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
            Invoke("EnableSpawn", spawnInterval);
        }
    }

    void EnableSpawn()
    {
        canSpawn = true;
    }
}