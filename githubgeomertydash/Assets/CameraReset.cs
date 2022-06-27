using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform camera;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform cameraRespawnPoint;
    
    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "RespawnTrigger" || collision.gameObject.name == "pointyspike Variant"){
          camera.transform.position = cameraRespawnPoint.transform.position;
      }
    }
}
