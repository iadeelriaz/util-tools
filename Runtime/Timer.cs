using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdeelRiaz.Tools
{
    public class Timer : MonoBehaviour
    {
        public float timeRemaining = 60;
        public bool timerIsRunning = false;
    
        public Text timerText;

        public UnityAction timerStart, timerComplete;
        public UnityAction<float> timerTick;

        private void Update()
        {
            if (!timerIsRunning) return;
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerTick?.Invoke(timeRemaining);
                var minutes = (int)timeRemaining / 60;
                var seconds = (int)timeRemaining % 60;

                timerText.text = $"{minutes:00}:{seconds:00}";
            }
            else
            {
                timerIsRunning = false;
                timerComplete?.Invoke();
            }
        }

        public void StartTimer()
        {
            timerIsRunning = true;
            timerStart?.Invoke();
        }

        public void StopTimer()
        {
            timerIsRunning = false;
        }

        public void ResetTimer()
        {
            timeRemaining = 60;
            timerIsRunning = false;
        }
    }
}