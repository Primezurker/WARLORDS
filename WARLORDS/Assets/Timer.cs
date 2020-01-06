using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime = 30;
    float currTime = 0;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();
        currTime = startTime;
    }

    void Update()
    {
        timerText.text = currTime.ToString("F0");
        currTime -= (1 * Time.deltaTime);
        if(currTime <= 0)
        {
            //TODO Change Turn
        }
    }
}