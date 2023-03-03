using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform target;
    private Vector3 offset; //расстояние между игроком и камерой
    void Start()
    {
        offset = transform.position - target.position;
        print("offset:" + offset);
    }

   
    void FixedUpdate()
    {
       Vector3 camPosition = new Vector3(offset.x + target.position.x, transform.position.y, transform.position.z);
        transform.position = camPosition;
        print("camPos:" + camPosition);
    }
}
