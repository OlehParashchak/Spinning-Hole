using DG.Tweening;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timerLabel;

    private void Start()
    {
        timerLabel.text = timer.ToString();
    }

    private void Update()
    {
        TimeManager();
        timerLabel.text = Mathf.Round(timer).ToString();
    }

    private void TimeManager()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer < 0)
        {
            timer = 0;
            Game.isGameover = true;
            Camera.main.transform
                .DOShakePosition(1f, .2f, 20, 90f);
            Level.Instance.RestartLevel();

        }
    }
}
