using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject atomPrefab;
    public GameObject topLeft;
    public GameObject bottomRight;

    private float posX;
    private float posY;
    private float posZ;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            posX = Random.Range(bottomRight.transform.position.x, topLeft.transform.position.x);
            posY = Random.Range(bottomRight.transform.position.y, topLeft.transform.position.y);
            posZ = Random.Range(topLeft.transform.position.z, bottomRight.transform.position.z);
            Debug.Log(posZ);
            Instantiate(atomPrefab, new Vector3(posX, posY, posZ), Quaternion.identity);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
