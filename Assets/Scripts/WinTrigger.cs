using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public static WinTrigger instance;
    private void Awake()
    {
        instance = this;
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
