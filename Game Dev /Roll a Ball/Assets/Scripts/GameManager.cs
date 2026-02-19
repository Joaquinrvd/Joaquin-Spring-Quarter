using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   // handling the score of this game
   // handling the UI for this game 
   // handling resetting of the level on a lose state 

   public static GameManager Instance {get; private set;}
   [SerialField, Tooltip("The score of the player (how many pickups they have collected")]
   private int playerScore = 0;
   [SerialField, Tooltip("A reference to the victory tet game object.")]
   private GameObject victoryTextObject;
   [SerialField, Tooltip("the parent game object of all pickup objects")] 
   private GameObject pickupParent;
   [SerialField, Tooltip("the ui object to keep the player score")]
   private TextMeshProUGUI scoreText;

   // A unity  specific function called once at the start of the game Before Start()
   // A great place to initialize variables in your scripts
   private void Awake()
   {
        if (Instance == null) // there is no instance of GameManager assigned yet
        {
            Instance = this; // Assign the singleton instance to this instance
        }
        else // There is already a GameManager
        {   
            // Destroy the copy
            Destroy(gameObject);
        }
   }

    private void Start()
    { 
        // Turn off the vicxtory text
        victoryTextObject.SetActive(false);
        //loop throug the pickup parent object and count the number of pickups
    }

    public void UpdateScore(int value)
    {
        // update score
        playerScore += value;
        // update score ui
        scoreText.text = "Score: " + playerScore;
    }







}

