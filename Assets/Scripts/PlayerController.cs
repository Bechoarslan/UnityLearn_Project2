using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 5.0f;
    public float rRange = 22.0f;
    public GameObject projectilePrefab;
    public float verticalInput;
    public Transform projectileSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (transform.position.x < -rRange)
        {
            transform.position = new Vector3(-rRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > rRange)
        {
            transform.position = new Vector3(rRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.z > 16)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 16);
        }
        else if (transform.position.z < -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position,
projectilePrefab.transform.rotation);

        }


    }
}
   
