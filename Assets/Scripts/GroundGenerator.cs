using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject[] groundPrefabs;
    private List<GameObject> activeGrounds = new List<GameObject>();
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


    void Update()
    {
        if (player.position.x - 60 > spawnPosition - (startGroundsCount * groundLength))
        {
            SpawnGround(Random.Range(0, groundPrefabs.Length));
            DeleteGround();
        }

    }
    private void SpawnGround(int groundIndex)
    {
        var pos = transform.position.x;
       GameObject nextGround = Instantiate(groundPrefabs[groundIndex], transform.right * spawnPosition, transform.rotation);
        activeGrounds.Add(nextGround);
        spawnPosition += groundLength;
    }

    private void DeleteGround()
    {
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }
}
