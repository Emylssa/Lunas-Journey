using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI crystalText;
    public TextMeshProUGUI lifeText;

    private int crystals = 0;
    private int lives = 3;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCrystal()
    {
        crystals++;
        crystalText.text = "Crystal x" + crystals;
    }

    public void TakeDamage()
    {
        lives--;

        if (lives == 3)
            lifeText.text = "♥ ♥ ♥";
        else if (lives == 2)
            lifeText.text = "♥ ♥";
        else if (lives == 1)
            lifeText.text = "♥";
        else
            lifeText.text = "Game Over";
    }
}