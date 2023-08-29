using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    public Text textCoins;
    public Text textKeys;
    int score;
    public List<EnemyController> enemies;
    public bool hasKey = false;


    // Start is called before the first frame update
    void Start()
    {
        if(gameController == null)
        {
            gameController = this;
        }
    }


    public void IncreaseCoins(int value)
    {
        score += value;
        textCoins.text = "Coins:" + score.ToString();
    }

    public void RespawnEnemies()
    {
        Debug.Log("Respawn");

        foreach (EnemyController enemy in enemies)
        {
            enemy.Respawn();
        }
    }

    public void HasKey()
    {
        textKeys.text = "Key: 1";
        hasKey = true;
    }

    public bool checkKey()
    {
        if (hasKey)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
