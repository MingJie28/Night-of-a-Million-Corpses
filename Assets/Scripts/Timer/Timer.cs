using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timeDuration = 0f;
    private float timer;

    [SerializeField] 
    private TextMeshProUGUI firstMinute;
    [SerializeField] 
    private TextMeshProUGUI secondMinute;
    [SerializeField] 
    private TextMeshProUGUI firstSecond;
    [SerializeField] 
    private TextMeshProUGUI secondSecond;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        UpdateTimerDisplay(timer);
    }

    private void ResetTimer()
    {
        timer = timeDuration;
    }

    private void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }
}
