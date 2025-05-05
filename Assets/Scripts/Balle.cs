using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Balle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse = 10f;
    private Vector3 velocity;
    public float tempsPourDespawn;
    
    
    public void Start()
    {
        
        Destroy(gameObject, tempsPourDespawn);
    }
    public void Tire()
    {
        
        // La balle avance toute seule vers l'avant

        rb.linearVelocity = transform.up * vitesse;
        
    }
    
}

