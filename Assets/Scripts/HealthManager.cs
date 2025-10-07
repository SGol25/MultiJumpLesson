using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    
    public int currentHealth;
    public int MaxHealth = 3;

    public TextMeshProUGUI textHealth;

    private void Start()
    {
        currentHealth = MaxHealth;
        ChangesOfText();
    }

    public void LoseHp()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            ChangesOfText();
        }
        if (currentHealth <= 0)
        {
            Debug.Log("Игра окончена");
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void ChangesOfText()
    {
        textHealth.text = "";
        for (int i = 0; i < currentHealth; i++)
        {
            textHealth.text += "+";
        }
    }
}
