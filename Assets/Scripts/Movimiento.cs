using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float speed;
    public Rigidbody rbComponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.Space)){
            rbComponent.velocity = new Vector3(
               Input.GetAxis("Horizontal") * Time.deltaTime * speed,
               rbComponent.velocity.y +0.25f,
               Input.GetAxis("Vertical") * Time.deltaTime * speed);
        }

        //transform.position += new Vector3(
        //    Input.GetAxis("Horizontal")*Time.deltaTime*speed,
        //    0f,
        //    Input.GetAxis("Vertical") * Time.deltaTime * speed);

        rbComponent.velocity = new Vector3(
            Input.GetAxis("Horizontal")*Time.deltaTime*speed,
            rbComponent.velocity.y,
            Input.GetAxis("Vertical") * Time.deltaTime * speed);


    }
}
