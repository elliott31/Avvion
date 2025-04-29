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
    public TextMeshProUGUI ballCountText; // Référence au composant Text
    public int ballCount = 20;
    void Update()
    {

        UpdateBallCountText();
    }
    private void Start()
    {
        UpdateBallCountText();
        Destroy(gameObject, tempsPourDespawn);
    }
    public void Tire()
    {
        Debug.Log("La balle a été tirée !");
        // La balle avance toute seule vers l'avant

        rb.linearVelocity = transform.up * vitesse;
        ballCount -= 1;
    }
    public void AddBall()
    {
        ballCount++;
        UpdateBallCountText();
    }

    // Méthode pour mettre à jour le texte
    private void UpdateBallCountText()
    {
        ballCountText.text =  " " + ballCount;
    }
}

