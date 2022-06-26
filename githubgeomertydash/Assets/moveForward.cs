using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public bool CubeOnGround = true; 
    // Start is called before the first frame update
    private void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //moves forward at speed or var speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(Input.GetButtonDown("Jump") && CubeOnGround == true){
            //jump code
        
            rb.AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
            CubeOnGround = false;

        }
    }
   private void OnCollisionEnter(Collision collision){
      if(collision.gameObject.name == "basecube"){
          CubeOnGround = true;
      }
   }
}
