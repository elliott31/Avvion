using TMPro;
using UnityEngine;

public class AttackOfPlayer : MonoBehaviour
{
    public GameObject ballePrefab;
    public Transform shootPoint;
    public int ballCount = 20;
    public TextMeshProUGUI ballCountText;
    void Awake()
    {
        UpdateBallCountText();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ballCount > 0)
        {
            GameObject bulletInstance = Instantiate(ballePrefab, shootPoint.position, shootPoint.rotation);
            Balle balleScript = bulletInstance.GetComponent<Balle>();

            if (balleScript != null)
            {
                balleScript.Tire();
            }

            ballCount--;
            UpdateBallCountText();
        }
    }

    void UpdateBallCountText()
    {
        ballCountText.text = "" + ballCount;
    }
}


