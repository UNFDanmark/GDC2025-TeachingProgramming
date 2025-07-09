using UnityEngine;
using UnityEngine.InputSystem;

public class RotateScript : MonoBehaviour
{
    public InputAction turnAround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turnAround.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turnAround.ReadValue<float>(), 0);
    }
}