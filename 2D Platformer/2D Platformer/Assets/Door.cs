using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameController.gameController != null)
            {
                GameController.gameController.checkKey();
            }
            else
            {
                Debug.LogWarning("GameController is not initialized.");
            }
        }
    }
}
