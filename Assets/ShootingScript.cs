using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;

    public InputAction shoot;

    public float cooldown = 0.5f;
    float cooldownLeft;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownLeft -= Time.deltaTime;
        if (shoot.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            cooldownLeft = cooldown;
        }
        
    }
}
