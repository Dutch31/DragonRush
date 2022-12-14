using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private AudioClip SpawnSound;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManager.instance.PlaySound(SpawnSound);
        gameObject.SetActive(false);
    }

    
}
