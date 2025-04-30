using UnityEngine;
using UnityEngine.SceneManagement;
public class quitAndOther : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject plane;
    public GameObject tousLesEnnemis;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {

            ReLaunchGame();

        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LaunchLevel1()
    {
        SceneManager.LoadScene("JeuNiveau1");

    }
    public void LaunchMainMenu()
    {
        SceneManager.LoadScene("lancement");

    }
    public void ReLaunchGame()
    {
        plane.transform.position = spawnPoint;
        plane.SetActive(true);
        PlayerHealth.instance.gameOver.SetActive(false);
        PlayerHealth.instance.health = PlayerHealth.instance.MaxHealth;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        
    }
}
