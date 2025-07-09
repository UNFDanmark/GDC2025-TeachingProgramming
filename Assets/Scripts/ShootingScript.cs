using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public InputAction shoot;

    public float cooldown = 0.2f;
    float cooldownLeft;
    
    public float bulletSpeed = 10f;
    
    
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
            GameObject bullet =  Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            bulletRigidbody.linearVelocity = transform.forward * bulletSpeed;
            
            cooldownLeft = cooldown;
        }
    }
}
