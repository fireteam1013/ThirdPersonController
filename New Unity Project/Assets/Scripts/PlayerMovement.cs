using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody rb;
    float h;
    float v;
    float walkSpeed = 40f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(h * walkSpeed * Time.deltaTime, 0, v * walkSpeed * Time.deltaTime);
    }
}
