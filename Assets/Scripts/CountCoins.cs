using TMPro;
using UnityEngine;

public class CountCoins : MonoBehaviour
{
    public int MaxCoins = 3;
    public int currentCoins;

    public TextMeshProUGUI textOfCoins;
    
    private void Start()
    {
        currentCoins = 0;
        ChangesOfText();
    }

    public void AddCoins()
    {
        if (currentCoins < MaxCoins)
        {
            currentCoins++;
            ChangesOfText();
        }
        if (currentCoins == MaxCoins)
        {
            Debug.Log("Собраны все монеты!");
        }
    }

    private void ChangesOfText()
    {
        textOfCoins.text = "Монетки " + currentCoins.ToString() + " / " + MaxCoins.ToString();
    }
}
