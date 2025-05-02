using UnityEngine;

public class voyons : MonoBehaviour
{
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
        Debug.Log("ab");
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("ennemie detectée");
        }
    }
}
