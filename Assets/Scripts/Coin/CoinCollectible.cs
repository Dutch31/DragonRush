using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.instance.AddPoint();
            SoundManager.instance.PlaySound(pickupSound);
            gameObject.SetActive(false);
        }
    }
}
