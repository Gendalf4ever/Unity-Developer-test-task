using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] spheres;
    private List<GameObject> sphereList = new List<GameObject>();
    private CharacterController controller;
    public Vector3 direction;
    private EnemyController enemy;
    public static bool enemySpawn;
    private float spawnSpherePosition = 0;
    private float sphereLength = 1;
    void Start()
    {
        
        controller = GetComponent<CharacterController>();
      enemy = GetComponent<EnemyController>();
        enemySpawn = GameObject.Find("enemyHasSpawned");
        
        print("1:"+enemySpawn);
        
    }
    void FixedUpdate()
    {
     
      
       // if (enemySpawn==true)
        controller.Move(direction * Time.fixedDeltaTime);
       // else
        //{
          //  PlayerAttack();
        //}
       

    }
    void PlayerAttack()
    {
        for (int i = 0; i < spheres.Length; i++)
        {
           SpawnSphere(Random.Range(0, spheres.Length));
        }
    }
    private void SpawnSphere(int sphereIndex)
    {
        var position = transform.position.x;
        GameObject nextSphere = Instantiate(spheres[sphereIndex], transform.right * spawnSpherePosition, transform.rotation);
        sphereList.Add(nextSphere);
        spawnSpherePosition += sphereLength;
    }
    private void DeleteSphere()
    {
        Destroy(sphereList[0]);
        sphereList.RemoveAt(0);
    }
}
 