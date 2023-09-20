using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float xPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed, 0f, 0f) * Time.deltaTime;

        if (transform.position.x >= xPos)
        {
            Destroy(this.gameObject);
        }
    }
}
