using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

// Game manager logic
public class GameManager : MonoBehaviour
{
    public Slider slider;
    public TMP_Text gameovertxt;        // Text field for game over text
    public TMP_Text healthtxt;          // Text field for the health text
    public TMP_Text scoretxt;           // Text field for player's score text

    public int maxhealth = 100;        // the player's max health
    public int health;        // the player's current health
    public bool gameover = false;   // a boolean to indicate the game over state
    public int score = 0;       //Player's current score - amount of kills

    public int EnemiesDead = 0;

    // This is a C# property - the code below isn't using it
    // as it is accessing the private static instance directly.
    // Use this property from other classes.
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    // GameManager instance
    private static GameManager instance = null;

    // Use this for initialization
    void Start()
    {
        gameovertxt.text = "";
        health = maxhealth;
        
        setHealthText(health);

    }

    // Init the game manager
    void Awake()
    {
        if (instance)
        {
            Debug.Log("already an instance so destroying new one");
            DestroyImmediate(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        score = EnemiesDead;
        scoretxt.text = "Score: " + score;
    }


    // goalreached() should set the gameover to true, and set the game over
    // text to "GAME OVER!"
    public void goalreached()
    {
        setGameOver();
    }


    // Is it game over
    public bool isGameOver()
    {
        return gameover;
    }

    // Set the game over state to true
    public void setGameOver()
    {
        gameover = true;
        if (health <= 0)
        {
            gameovertxt.text = "GAME OVER! Press escape to return to the Main Menu";
        }
        else if (health > 0)
        {
            gameovertxt.text = "YOU WIN! Press escape to return to the Main Menu";
        }
    }

    // Set the health text
    public void setHealthText(int health)
    {
        healthtxt.text = health + "%";
        slider.value = health;
    }

    // Something has attacked the player
    public void EnemyAttack()
    {
        
        health = health - 10;
        if (health < 0) health = 0;
        {
            setHealthText(health);
        }

        if (health <= 0)
        {
            setGameOver();
        }
    }

    // Get the health of the player
    public int getHealth()
    {
        return health;
    }

}