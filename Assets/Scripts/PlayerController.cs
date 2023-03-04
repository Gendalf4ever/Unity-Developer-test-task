using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public Transform enemy;
    public Vector3 direction;
    public CameraController camera;
    bool enemyInRange = false; //чтобы останавливался когда в поле зрения появляется враг
    float enemyDistance = 20; //расстояние между противником и слаймом
   // private Vector3 offset; //расстояние между игроком и врагом
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
       camera = GetComponent<CameraController>();
    }
    void FixedUpdate()
    {
        if(enemyInRange==false)
        controller.Move(direction * Time.fixedDeltaTime);

    }
    
}
 