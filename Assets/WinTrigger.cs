using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mur"))
        {
            GameManager.instance.winTrigger = true;
            
        }
    }
}
