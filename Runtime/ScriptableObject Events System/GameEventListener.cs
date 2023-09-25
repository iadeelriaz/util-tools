using UnityEngine;
using UnityEngine.Events;

namespace AdeelRiaz.Events
{
    [System.Serializable]
    public class CustomGameEvent : UnityEvent<Component, object> { }

    public class GameEventListener : MonoBehaviour
    {

        [Tooltip("Event to register with.")]
        public GameEvent gameEvent;

        [Tooltip("Response to invoke when Event with GameData is raised.")]
        public CustomGameEvent response;

        private void OnEnable()
        {
            if (gameEvent == null) return;

            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null) return;
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(Component sender, object data)
        {
            response.Invoke(sender, data);
        }

    }
}