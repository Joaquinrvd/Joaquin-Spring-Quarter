using UnityEngine;

public class cameracontrolls : MonoBehaviour
{
    {
        public transform target;
        public Vector3 posoffset;   
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transformation.posistion = target.posistion + posoffset;
    }
}
