using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject spawnObject;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 spawnPosition = transform.position;

        spawnPosition.x += Random.Range(-5, 6);
        spawnPosition.z += Random.Range(-5, 6);
        
        Instantiate(spawnObject, spawnPosition, Quaternion.identity);
    }
}
