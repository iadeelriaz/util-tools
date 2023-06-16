using UnityEngine;
using UnityEngine.UI;

namespace AdeelRiaz.Tools
{
    public class RandomGreetingMsg : MonoBehaviour
    {
        [SerializeField] private Text txtMsg;
        [SerializeField] private string[] greetingMsg;
        private void OnEnable() => txtMsg.text = greetingMsg[Random.Range(0, greetingMsg.Length)];
    }
}
