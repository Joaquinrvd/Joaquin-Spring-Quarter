using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public Transform target;

    public Vector3 posOffset;

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = target.position + posOffset;
    }
}
