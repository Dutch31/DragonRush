using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    [SerializeField] private Health BossHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = BossHealth.currentHealth / 25;
    }
    private void Update()
    {
        currenthealthBar.fillAmount = BossHealth.currentHealth / 25;
    }
}