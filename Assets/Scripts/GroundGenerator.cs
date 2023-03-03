using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject[] groundPrefabs;
    private float spawnPosition = 0;
    private float groundLength = 100;
    [SerializeField] private Transform player;
    private int startGroundsCount = 3;
    void Start()
    {
       for (int i = 0; i< startGroundsCount; i++)
        {
            SpawnGround(Random.Range(0, groundPrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnGround(int groundIndex)
    {
        var pos = transform.position.x;
        Instantiate(groundPrefabs[groundIndex], transform.right * spawnPosition, transform.rotation);
         spawnPosition += groundLength;
    }
}
