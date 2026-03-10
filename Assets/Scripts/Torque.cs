using UnityEngine;
using UnityEngine.InputSystem;

public class Torque : MonoBehaviour
{
    public float torqueForce = 10f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(torqueForce, 0, 0));
        }

    }
}
