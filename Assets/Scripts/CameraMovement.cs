using UnityEngine;

// This complete script can be attached to a camera to make it
// continuously point at another object.

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        //move camera
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
    }
}