using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Dette er en kommentar
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // type navnet = startværdi;
    public int health = 10;
    public int speed = 18; 
    public Rigidbody rb;
    string navn = "Kasper";
    float weight = 13.7f;
    bool erVoksen = true;
    
    void Start()
    {
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        print(health );
    }
}
