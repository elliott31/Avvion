using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool winTrigger;//appellé autre part
    public static GameManager instance;
    public GameObject win;
    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (winTrigger == true)
        {
            Debug.Log("Gagné");
            win.SetActive(true);
            
            
        }
    }
}
