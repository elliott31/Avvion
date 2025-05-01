using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float MaxHealth;
    public static PlayerHealth instance;
    public GameObject gameOver;
    public GameObject player;
    public TextMeshProUGUI vie;
    public TextMeshProUGUI rPourRestart;
    public TextMeshProUGUI balle;
    public GameObject balleImage;
    private void Awake()
    {
        instance = this;
        MaxHealth = 100;
        health = MaxHealth;
        rPourRestart.alpha = 1;
        vie.alpha = 1;
        balle.alpha = 1;
        balleImage.SetActive(true);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vie.text = health + "hp";
        if (health <= 0)
        {
            gameOver.SetActive(true);
            player.SetActive(false);
            rPourRestart.alpha = 0;
            vie.alpha = 0;
            balle.alpha = 0;
            balleImage.SetActive(false);
        }
        
    }
    
}
