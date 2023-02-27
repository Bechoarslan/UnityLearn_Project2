using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Dog"))
        {
            other.GetComponent<Bar>().FeedAnimal(1);

            Destroy(gameObject);
            
        }
    }

}
