using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent agent;
    GameObject player;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
