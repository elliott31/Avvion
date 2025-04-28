using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject objectToDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth.instance.health -= 5f;
            if(PlayerHealth.instance.health <= 0)
            {
                
            }
            Destroy(objectToDestroy);
        }
        else if (collision.CompareTag("Balle"))
        {
            Destroy(objectToDestroy);
        }
    }
}
