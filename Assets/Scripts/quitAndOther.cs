using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitAndOther : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject plane;
    public GameObject winWave1;
    public static QuitAndOther instance;
    public GameObject winTriggerWave1;
    private void Awake()
    {
        instance = this;
    }




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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void ContinueToWave2()
    {
        Destroy(winTriggerWave1);
        winWave1.SetActive(false);
        Debug.Log("bouton apuiado");
    }
}
