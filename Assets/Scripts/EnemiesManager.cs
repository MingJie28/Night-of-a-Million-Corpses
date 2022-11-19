using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemyBat;
    [SerializeField] GameObject Ooze;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    GameObject player;
    float timer;

    public static bool enemy1 = true;
    public static bool enemy2 = false;
    

    private void Start()
    {
        player = GameManager.instance.playerTransform.gameObject;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f) 
        {
            if (enemy1 == true)
            {
                SpawnEnemy(Ooze);
            }
            if (enemy2 == true)
            {
                SpawnEnemy(Ooze);
            }
            timer = spawnTimer;
        }
    }

    private void SpawnEnemy(GameObject enemy)
    {
        Vector3 position = GenerateRandomPosition();

        position += player.transform.position;

        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = position;
        newEnemy.GetComponent<Enemy>().SetTarget(player);
        newEnemy.transform.parent = transform;
    }

    private Vector3 GenerateRandomPosition()
    {
        Vector3 position = new Vector3();

        float f = UnityEngine.Random.value > 0.5f ? -1f : 1f;
        if (UnityEngine.Random.value > 0.5f)
        {
            position.x = UnityEngine.Random.Range(-spawnArea.x, spawnArea.x);
            position.y = spawnArea.y * f;
        }
        else {
            position.y = UnityEngine.Random.Range(-spawnArea.y, spawnArea.y);
            position.x = spawnArea.x * f;
        }
        
        position.z = 0;

        return position; 
    }
}
