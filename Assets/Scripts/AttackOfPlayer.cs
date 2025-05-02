using TMPro;
using UnityEngine;

public class AttackOfPlayer : MonoBehaviour
{
    public GameObject ballePrefab;
    public Transform shootPoint;
    [HideInInspector]
    public int ballCount;
    public TextMeshProUGUI ballCountText;
    public static AttackOfPlayer instance;
    void Awake()
    {
        instance = this;
        ballCount = 0;
        UpdateBallCountText();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || (Input.GetKeyDown(KeyCode.X)))
        {
            GameObject bulletInstance = Instantiate(ballePrefab, shootPoint.position, shootPoint.rotation);
            Balle balleScript = bulletInstance.GetComponent<Balle>();

            if (balleScript != null)
            {
                balleScript.Tire();
            }

            ballCount+= 1;
            UpdateBallCountText();
        }
    }

    void UpdateBallCountText()
    {
        ballCountText.text = "" + ballCount;
    }
}


