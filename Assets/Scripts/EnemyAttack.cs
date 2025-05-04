using TMPro;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject[] lootable;
    public float dropChance;
    public float speed;
    public Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            PlayerHealth.instance.health -= 5f;
            TryDropLoot();
            Destroy(objectToDestroy);
            GameManager.instance.score += 10f;
        }
        else if (collision.CompareTag("Balle"))
        {
            GameManager.instance.score += 10f;
            TryDropLoot();
            Destroy(objectToDestroy);
        }
        else if(collision.CompareTag("Mur"))
        {
            
            Destroy(objectToDestroy);
        }
    }
    void TryDropLoot()
    {
        if (lootable.Length == 0 || Random.value > dropChance)
            return;

        int randomIndex = Random.Range(0, lootable.Length);
        GameObject lootToDrop = lootable[randomIndex];

        Instantiate(lootToDrop, transform.position, Quaternion.identity);
    }
    
}
