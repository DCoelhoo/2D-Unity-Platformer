using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameController.gameController != null)
            {
                GameController.gameController.HasKey();
            }
            else
            {
                Debug.LogWarning("GameController is not initialized.");
            }
        }
    }
}
