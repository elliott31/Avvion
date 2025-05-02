using UnityEngine;

public class MovementPlane : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public static MovementPlane instance;
    private void Awake()
    {
        instance = this;
    }
    private Vector2 velocity = Vector2.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {



        float horizontalmouvement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        MovePlayer(horizontalmouvement, verticalMovement);
    }
    void MovePlayer(float horizontalMovement,float verticalMovement)
    {
        Vector2 targetVelocity = new Vector2(horizontalMovement, verticalMovement);
        rb.linearVelocity = Vector2.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, 0.05f);
    }
}
