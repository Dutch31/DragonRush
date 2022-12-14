using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoom : MonoBehaviour
{
    [SerializeField] private GameObject BossWall;
    [SerializeField] private GameObject BossTrigger;
    [SerializeField] private AudioClip BossRoomSound;
    
    
    
    private void Awake()
    {
        BossWall.SetActive(false);
        BossTrigger.SetActive(true);
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BossWall.SetActive(true);
            BossTrigger.SetActive(false);
            SoundManager.instance.PlaySound(BossRoomSound);
            
        }
    }

    
}
