using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour
{

    public GameObject laserbeamPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GameObject b = (GameObject)(Instantiate(laserbeamPrefab, transform.position + transform.up * 0.85f, transform.rotation));

            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);

            AudioScript.PlaySound("laserSound");
        }
    }
}