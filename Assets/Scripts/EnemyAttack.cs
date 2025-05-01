using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject[] lootable;
    public float dropChance;
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
            TryDropLoot();
            Destroy(objectToDestroy);
        }
        else if (collision.CompareTag("Balle"))
        {
            TryDropLoot();
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
