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
            Debug.Log("������� ��� ������!");
        }
    }

    private void ChangesOfText()
    {
        textOfCoins.text = "������� " + currentCoins.ToString() + " / " + MaxCoins.ToString();
    }
}
