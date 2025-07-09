using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public int speed = 18;
    public InputAction moveAction;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // læs input
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        // skab kopi
        Vector3 newVelocity = rb.linearVelocity;
        // opdaterer vi værdier
        newVelocity.x = moveInput.x * speed;
        newVelocity.z = moveInput.y * speed;
        // Opdater den rigtige hastighed
        rb.linearVelocity = newVelocity;
    }
}
