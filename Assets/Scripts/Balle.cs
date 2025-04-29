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
        Debug.Log("La balle a �t� tir�e !");
        // La balle avance toute seule vers l'avant

        rb.linearVelocity = transform.up * vitesse;
        ballCount -= 1;
    }
    public void AddBall()
    {
        ballCount++;
        UpdateBallCountText();
    }

    // M�thode pour mettre � jour le texte
    private void UpdateBallCountText()
    {
        ballCountText.text =  " " + ballCount;
    }
}

