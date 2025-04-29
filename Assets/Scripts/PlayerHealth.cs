using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float MaxHealth;
    public static PlayerHealth instance;
    public GameObject gameOver;
    public GameObject player;
    private void Awake()
    {
        instance = this;
        MaxHealth = 100;
        health = MaxHealth;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            gameOver.SetActive(true);
            player.SetActive(false);
        }
    }
    
}
