using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CarMoving : MonoBehaviour
{

    [SerializeField]
    public Material carMaterial;
    private Vector3 carPosition;
    private Vector3 carRotation;
    private bool firstTime = false;
    private Color colore;
    public GameObject cam_visual;
    private Vector3 cameraPosition;
    private Vector3 cameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        carPosition = transform.position;
        carRotation = transform.eulerAngles;
        colore = new Color(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

        if (carRotation.z >= -180 || carRotation.z == -360)
        {
            if (firstTime)
            {
                carRotation.z = 0;
                firstTime = false;
                colore = Color.green;
            }
            if (carPosition.x < 36)
            {
                carPosition.x += 0.1f;
            }
            else if (carPosition.x >= 36)
            {
                carPosition.x += 0.1f;
                carPosition.z += 0.05f;
                carRotation.z -= 2;
            }
        }
        if(carRotation.z < 0)
        {
            if (!firstTime)
            {
                colore = Color.cyan;
            }
            if(carPosition.x > -36)
            {
                carPosition.x -= 0.1f;
            }else if(carPosition.x <= -36)
            {
                carPosition.x -= 0.1f;
                carPosition.z -= 0.05f;
                carRotation.z -= 2;
                firstTime = true;
            }
        }

        transform.position = carPosition;
        transform.eulerAngles = carRotation;

        carMaterial.color = colore;


        cameraPosition = carPosition;
        cameraRotation = carRotation;
        cameraRotation.x = cam_visual.transform.eulerAngles.x;
        cameraPosition.y += 5f;
        cam_visual.transform.position = cameraPosition;
        cam_visual.transform.eulerAngles = cameraRotation;
    }
}
