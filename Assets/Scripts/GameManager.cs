using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool winTrigger;//appellé autre part
    public static GameManager instance;
    public GameObject win;
    public GameObject player;
    public float score;
    public TextMeshProUGUI scoreTextWin;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        instance = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score :" + score;
        scoreTextWin.text = "tu as : " + score + "de score ";
        if (winTrigger == true)
        {
            
            win.SetActive(true);
            player.SetActive(false);
            
        }
        
    }
}
