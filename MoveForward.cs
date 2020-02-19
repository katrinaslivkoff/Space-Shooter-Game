using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float maxSpeed = 5f;

    GameObject scoreUITextGO;

    void Start()
    {
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime);

        pos += transform.rotation * velocity;

        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "AsteroidTag")
        {
            scoreUITextGO.GetComponent<ScoreScript>().Score += 100;
        }
    }
}
