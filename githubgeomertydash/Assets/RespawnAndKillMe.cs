using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAndKillMe : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "RespawnTrigger" || collision.gameObject.name == "pointyspike Variant"){
          //death animation needs to go here
          player.transform.position = respawnPoint.transform.position;
      }
    }
}
