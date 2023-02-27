using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBound : MonoBehaviour
{
    private float pos = 30.0f;
    private float low = -10.0f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > pos)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);

        }
        else if (transform.position.z < low)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);


        }
        
    }
}
