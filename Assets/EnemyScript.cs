using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public Animator animator;
    public NavMeshAgent agent;
    GameObject playerTarget;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTarget = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTarget.transform.position);
        animator.SetFloat("Speed", agent.velocity.magnitude);
        
        // animator.SetBool("Moving", !agent.isStopped);
        print(agent.destination);
        print(agent.remainingDistance);

        if (agent.remainingDistance <= 1.5f)
        {
            animator.SetTrigger("Attack");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
         Destroy(gameObject);
        }
    }
}
