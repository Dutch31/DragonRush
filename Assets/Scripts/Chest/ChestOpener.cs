using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    [SerializeField] private AudioClip ChestOpenSound;
    public Animator anim;
    public GameObject ChestOpen;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("chestopen", true);
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.AddPoint();
            SoundManager.instance.PlaySound(ChestOpenSound);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Player"){
            gameObject.SetActive(false);
        }

        
    }

    
}
