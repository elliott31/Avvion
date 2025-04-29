using UnityEngine;
using UnityEngine.SceneManagement;
public class quitAndOther : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject plane;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LauchScene()
    {
        SceneManager.LoadScene("JeuNiveau1");

    }
    public void LaunchGame()
    {
        plane.transform.position = spawnPoint;
    }
}
