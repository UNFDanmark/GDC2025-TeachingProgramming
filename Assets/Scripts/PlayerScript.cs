using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private static readonly int Speed = Animator.StringToHash("Speed");
    public int speed = 18;
    public GameObject gameOverScreen;
    public Animator animator;
    public InputAction moveAction;
    public InputAction restartAction;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveAction.Enable();
        restartAction.Enable();
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
        animator.SetFloat(Speed, rb.linearVelocity.magnitude);

        if (restartAction.WasPressedThisFrame())
        {
            SceneManager.LoadScene("3D");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.SetActive(true);
        }
    }
}
