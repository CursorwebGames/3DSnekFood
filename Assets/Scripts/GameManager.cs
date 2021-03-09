using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;

    private bool isEnd = false;

    public float tick = 0;
    public float maxTick = 5;
    public int score = 0;

    public GameObject win;
    public GameObject lose;


    private void Update()
    {
        if (!isEnd) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;

        tick += Time.deltaTime;
        if (tick >= maxTick)
        {
            tick = 0;
            score++;
            scoreText.text = score.ToString();
        }
    }


    public void Lose()
    {
        if (isEnd) return;
        isEnd = true;
        lose.SetActive(true);
    }

    public void Win()
    {
        if (isEnd) return;
        isEnd = true;
        win.SetActive(true);
    }
}
