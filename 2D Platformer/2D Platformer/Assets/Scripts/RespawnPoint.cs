using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private Vector3 respawnPosition;

    private void Start()
    {
        respawnPosition = transform.position; // Armazena a posição inicial do ponto de respawn
    }

    public void RespawnPlayer(Transform playerTransform)
    {
        playerTransform.position = respawnPosition; // Move o jogador para a posição de respawn
    }
}
