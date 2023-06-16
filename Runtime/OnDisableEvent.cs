using UnityEngine;
using UnityEngine.Events;

namespace AdeelRiaz.Tools
{
    public class OnDisableEvent : MonoBehaviour
    {
        public UnityEvent eventDisable;
        private void OnDisable() => eventDisable?.Invoke();

    }
}
