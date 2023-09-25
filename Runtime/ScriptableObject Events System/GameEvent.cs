using System.Collections.Generic;
using UnityEngine;

namespace AdeelRiaz.Events
{
    [CreateAssetMenu(menuName = "Events/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        public List<GameEventListener> listeners = new List<GameEventListener>();

        public void Invoke()
        {
            Invoke(null, null);
        }

        public void Invoke(object data)
        {
            Invoke(null, data);
        }

        public void Invoke(Component sender)
        {
            Invoke(sender, null);
        }

        public void Invoke(Component sender, object data)
        {
            for (int i = 0; i < listeners.Count; i++)
            {
                listeners[i].OnEventRaised(sender, data);
            }
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }
    }
}