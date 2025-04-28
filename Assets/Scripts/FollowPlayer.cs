using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public float timeOffset;
    public Vector3 posOffset;
    private Vector3 velocity;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, plane.transform.position + posOffset, ref velocity, timeOffset);
    }
}
