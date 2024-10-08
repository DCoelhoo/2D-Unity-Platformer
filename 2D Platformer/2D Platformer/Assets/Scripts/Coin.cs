using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameController.gameController != null)
            {
                GameController.gameController.IncreaseCoins(coinValue);
            }
            else
            {
                Debug.LogWarning("GameController is not initialized.");
            }
        }
    }
}
