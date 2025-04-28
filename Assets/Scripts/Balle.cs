using Unity.VisualScripting;
using UnityEngine;

public class Balle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse = 10f; // vitesse de la balle
    private Vector3 velocity;
    public float tempsPourDespawn;

    void Update()
    {

        
    }
    private void Start()
    {
        Destroy(gameObject, tempsPourDespawn);
    }
    public void Tire()
    {
        Debug.Log("La balle a été tirée !");
        // La balle avance toute seule vers l'avant

        rb.linearVelocity = transform.up * vitesse;
    }
}

