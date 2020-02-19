using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawnScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
            HealthControl.health -= 1;
    }
}
