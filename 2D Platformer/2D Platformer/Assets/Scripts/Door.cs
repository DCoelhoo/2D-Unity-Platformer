using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool canFinish = false;
    public List<Sprite> sprites;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canFinish == true)
        {
            Debug.Log("Level Finished");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GameController.gameController != null)
        {

            bool checkKey = GameController.gameController.checkKey();

            if (checkKey == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
                canFinish = true;

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
        canFinish = false;
    }
}
