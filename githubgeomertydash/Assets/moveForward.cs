using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //moves forward at speed or var speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(Input.GetButtonDown("Jump")){
        //jump code
        
        transform.Translate(Vector3.up * Time.deltaTime * speed * 20);

        }
    }
}
