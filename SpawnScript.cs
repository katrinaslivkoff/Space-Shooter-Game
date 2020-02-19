using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnTime = 2;

    void Start()
    {
        InvokeRepeating("addEnemy", 0, spawnTime);
    }

    void addEnemy()
    {
        Vector3 pos = transform.position;
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        var x1 = pos.x - widthOrtho / 2;
        var x2 = pos.x + widthOrtho / 2;
        var spawnPoint = new Vector2(Random.Range(x1, x2), pos.y);
        Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
    }
}
