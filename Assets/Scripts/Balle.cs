using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Balle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse = 10f; // vitesse de la balle
    private Vector3 velocity;
    public float tempsPourDespawn;
    public TextMeshProUGUI ballCountText; // R�f�rence au composant Text
    
    void Update()
    {

        
    }
    private void Awake()
    {
        
    }
    public void Start()
    {
        
        Destroy(gameObject, tempsPourDespawn);
    }
    public void Tire()
    {
        Debug.Log("La balle a �t� tir�e !");
        // La balle avance toute seule vers l'avant

        rb.linearVelocity = transform.up * vitesse;
        
    }
    
}

