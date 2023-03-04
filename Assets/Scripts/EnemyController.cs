using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private List<GameObject> activeEnemies = new List<GameObject>();
    private float spawnPosition = 0;
    private float distanceBetweenEnemies = 5;
    private double distanceBetweenEnemyAndPlayer = 8.5;
    [SerializeField] private Transform player;
    private int enemiesCount = 3;

    void Start()
    {
        for (int i = 0; i < enemiesCount; i++)
        {
            SpawnEnemy(Random.Range(0, enemyPrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Attack()
    {

    }
    void Death()
    {

    }
    private void SpawnEnemy(int enemyIndex)
    {
        var pos = transform.position.x;
        GameObject nextEnemy = Instantiate(enemyPrefabs[enemyIndex], transform.right * spawnPosition, transform.rotation);
        activeEnemies.Add(nextEnemy);
        spawnPosition += distanceBetweenEnemies;
    }
}
