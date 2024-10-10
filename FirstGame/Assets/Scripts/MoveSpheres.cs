using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpheres : MonoBehaviour
{
    [SerializeField] private GameObject pos0;
    [SerializeField] private GameObject pos3;

    [SerializeField] private Vector3 newSpherePos;
    [SerializeField] private float intensity;
    [SerializeField] private float dirZ;
    [SerializeField] private float dirX;
    [SerializeField] private bool tapped;

    [SerializeField] private AudioSource death;


    // Start is called before the first frame update
    void Start()
    {
        intensity = 1f;
        dirZ = Random.Range(-1f, 1f)/50*intensity;
        dirX = Random.Range(-1f, 1f)/50*intensity;
        newSpherePos = transform.position;
        tapped= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!tapped)
        {
            if (transform.position.z <= pos0.transform.position.z)
            {
                dirZ *= -1;
            }
            if (transform.position.x >= pos0.transform.position.x)
            {
                dirX *= -1;
            }
            if (transform.position.z >= pos3.transform.position.z)
            {
                dirZ *= -1;
            }
            if (transform.position.x <= pos3.transform.position.x)
            {
                dirX *= -1;
            }
            newSpherePos.z += dirZ;
            newSpherePos.x += dirX;
            transform.position = newSpherePos;
        }
    }

    private void OnMouseDown()
    {
        if (!tapped)
        {
            death.Play();
        }
        tapped = true;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
    }

}
