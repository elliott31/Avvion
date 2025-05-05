using TMPro;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject[] lootable;
    public float dropChance;
    public float speed;
    public Rigidbody2D rb;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool isWaveActive = QuitAndOther.instance.winWave1.activeInHierarchy;

        speed = isWaveActive ? 0 : 2;

        

        rb.linearVelocity = new Vector2(-speed, 0);
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
