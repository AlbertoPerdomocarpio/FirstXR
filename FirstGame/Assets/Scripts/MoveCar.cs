using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField]
    float speed;
    float inputX;
    float inputZ;

    private Quaternion carRotation;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        GetComponent<Rigidbody>().velocity = new Vector3(inputX * speed, 0, inputZ * speed);

        carRotation = transform.rotation;
        
    }
}
