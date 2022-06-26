using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove: MonoBehaviour
{
   public float speed;
   //Start is called before the first frame update
   private void Start()
   {
     
   }
   
   //Update is called once per frame
   void Update()
   {
       //moves forward at speed or var speed
       transform.Translate(Vector3.forward * Time.deltaTime * speed);  

       }

 

}