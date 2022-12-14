using System.Collections;
using UnityEngine;

public class FlagPole : MonoBehaviour
{
    [SerializeField] private GameObject VictoryScreen;
    [SerializeField] private GameObject HealthUIHolder;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioClip VictorySound;
    [SerializeField] private AudioClip VictorySound2;
    

    private void Awake()
    {
        VictoryScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        HealthUIHolder.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            VictoryScreen.SetActive(true);
            HealthUIHolder.SetActive(false);
            gameOverScreen.SetActive(false);
        }
    }

    

    

}