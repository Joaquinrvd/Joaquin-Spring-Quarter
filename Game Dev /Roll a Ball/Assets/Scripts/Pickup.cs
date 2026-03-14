using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField, Tooltip("Controls the rotation speed of this pickup.")]
    private float rotateSpeed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player touched the pickup
        PlayerController controller = other.GetComponentInParent<PlayerController>();

        if (controller != null)
        {
            if (GameManager.Instance != null)
            {
                // Increase score
                GameManager.Instance.UpdateScore(1);

                // Destroy pickup
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("GameManager.Instance is NULL!");
            }
        }
    }

    private void Update()
    {
        // Rotate the pickup
        transform.Rotate(new Vector3(15f, 45f, 60f) * rotateSpeed * Time.deltaTime, Space.Self);
    }
}