using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform lipManager;
    private float cameraOffset;
    //float offset = -6.0f;

    void Start()
    {
        cameraOffset = -10.0f;
    }

    void FixedUpdate()
    {

        transform.position = new Vector3
           (Mathf.Lerp(transform.position.x, lipManager.GetChild(0).transform.position.x, 5f * Time.deltaTime), transform.position.y, lipManager.GetChild(0).position.z + cameraOffset);
    }
}

