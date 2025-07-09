using Unity.Collections;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int health = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int jegVirkerKunIStart = 5;
        float etDecimalTal = 13.7f;
        
        
        print(jegVirkerKunIStart + health);
    }

    // Update is called once per frame
    void Update()
    {
        int jegVirkerKunIUpdate = 2;
        print(health + jegVirkerKunIUpdate);
    }
}
