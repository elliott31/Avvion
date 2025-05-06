using TMPro;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject[] lootable;
    public float dropChance;
    public float speed;
    public Rigidbody2D rb;
    public int life;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (QuitAndOther.instance != null && QuitAndOther.instance.winWave1 != null)
        {
            bool isWaveActive = QuitAndOther.instance.winWave1.activeInHierarchy;
            speed = isWaveActive ? 0 : 2;
        }
        else
        {
            speed = 2; // Par défaut, on avance si on ne peut pas encore accéder aux données
        }

        rb.linearVelocity = new Vector2(-speed, 0);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            PlayerHealth.instance.health -= 5f;
            life -= 10;
            if (life <= 0)
            {
                TryDropLoot();
                Destroy(objectToDestroy);
                GameManager.instance.score += 10f;
            }
            
        }
        else if (collision.CompareTag("Balle"))
        {
            GameManager.instance.score += 10f;
            life -= 5;
            if (life <= 0)
            {
                TryDropLoot();
                Destroy(objectToDestroy);
            }
            
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
