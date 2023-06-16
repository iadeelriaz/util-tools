using UnityEngine;
using UnityEngine.Events;

namespace AdeelRiaz.Tools
{
    public class OnEnableEvent : MonoBehaviour
    {
        public UnityEvent eventEnable;
        private void OnEnable() => eventEnable?.Invoke();
    }
}