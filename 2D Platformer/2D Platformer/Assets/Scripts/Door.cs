using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public List<Sprite> sprites;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GameController.gameController != null)
        {

            bool checkKey = GameController.gameController.checkKey();

            if (checkKey == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Level Finished");
                }
            }


        }
        else
        {
            Debug.LogWarning("GameController is not initialized.");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }
}
