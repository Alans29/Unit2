using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float VerticalInput;
    public float speed = 10.0f;


    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds

        {

            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

            VerticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Launch a projectille from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }


        }
    }
}