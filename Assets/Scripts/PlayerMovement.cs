using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbComponent;
    [SerializeField] private float jumpForce;
    [SerializeField] private float minyPos;
    [SerializeField] private float maxyPos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isGrounded = rbComponent.velocity.magnitude < 0.1f;
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rbComponent.AddForce(0f, jumpForce, 0f);
        }
    }
}
