using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.isGameActive == true)
        {
            player.transform.rotation = Quaternion.Euler(0, -90f, 0);
            player.transform.position = respawnPoint.transform.position;
            gameManager.UpdateLives(1);
        }
      
    }
}
