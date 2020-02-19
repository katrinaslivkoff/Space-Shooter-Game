using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = -5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;

        pos.y = speed;
    }

}
