using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitAndOther : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject plane;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    

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
        GameManager.instance.win.SetActive(false);
    }
    public void NextLevel()
    {                                                                                          
        //aller au prochain niveau............. comment faire ? je ne sais point faire. on verra 
    }
}
