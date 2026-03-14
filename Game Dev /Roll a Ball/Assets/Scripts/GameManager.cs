using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField, Tooltip("The score of the player (how many pickups they have collected)")]
    private int playerScore = 0;

    [SerializeField, Tooltip("Victory text UI object")]
    private GameObject victoryTextObject;

    [SerializeField, Tooltip("Parent object that contains all pickups")]
    private GameObject pickupParent;

    [SerializeField, Tooltip("UI text that displays the score")]
    private TextMeshProUGUI scoreText;

    private int remainingPickup;

    private void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (victoryTextObject != null)
            victoryTextObject.SetActive(false);

        if (pickupParent != null)
            remainingPickup = pickupParent.transform.childCount;

        UpdateScore(0);
    }

    public void UpdateScore(int value)
    {
        playerScore += value;

        if (scoreText != null)
            scoreText.text = "Score: " + playerScore;

        remainingPickup--;

        if (remainingPickup <= 0)
        {
            if (victoryTextObject != null)
                victoryTextObject.SetActive(true);
        }
    }
}