using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed = 5f;

    private AudioSource audioSource;
    public InputAction shoot;
    public Animator animator;
    
    public float cooldown = 0.5f;
    float cooldownLeft;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownLeft -= Time.deltaTime;
        if (shoot.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulletRb = bulletClone.GetComponent<Rigidbody>();
            bulletRb.linearVelocity = transform.forward * bulletSpeed;
            
            cooldownLeft = cooldown;
            animator.SetTrigger("Shoot");

            audioSource.pitch = Random.Range(0.5f, 1.5f);
            audioSource.Play();
        }
        
    }
}
