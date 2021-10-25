using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; set; } = null;

    private float gameTimer { get; set; } = 0;
    private const float preparationTime = 10;


    private void Awake()
    {
        instance = this;
    }

    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END,
    }

    private GameState gameState {get; set;} = GameState.PREPARATION;
    // Start is called before the first frame update
    void Start()
    {
        gameTimer = preparationTime;
    }

    // Update is called once per frame
    void Update()
    {
        switch(gameState)
    {
        case GameState.PREPARATION:
            gameTimer -= Time.deltaTime;
            UiManager.instance.SetTimer(gameTimer);
            if(gameTimer <=0)
            {
                gameTimer = preparationTime;
                gameState = GameState.RUNNING;
            }
            break;

        case GameState.RUNNING:
            
            break;

        case GameState.END:
            
            break;
    }

    }
}
