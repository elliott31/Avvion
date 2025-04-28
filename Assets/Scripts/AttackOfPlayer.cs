using UnityEngine;

public class AttackOfPlayer : MonoBehaviour
{
    public GameObject ballePrefab;
    public Transform shootPoint; // optional: where the bullet spawns

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletInstance = Instantiate(ballePrefab, shootPoint.position, shootPoint.rotation);
            Balle balleScript = bulletInstance.GetComponent<Balle>();

            if (balleScript != null)
            {
                balleScript.Tire();
            }
            else
            {
                Debug.LogError("No Balle script found on instantiated bullet!");
            }
        }
    }
}

