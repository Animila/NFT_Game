using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField]private Image totalHealtBar;
    [SerializeField]private Image currectHealtBar;

    private void Start() {
        totalHealtBar.fillAmount = playerHealth.currectHealth / 3;
    }
    private void Update() {
        currectHealtBar.fillAmount = playerHealth.currectHealth / 3;
    }
}
