using UnityEngine;

namespace AdeelRiaz.Tools
{
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        public bool isPersistent;
        private static T _instance;

        public static T Ins
        {
            get
            {
                if (_instance == null)
                {
                    _instance = (T) FindObjectOfType(typeof(T));
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        _instance = obj.AddComponent<T>();
                        obj.name = typeof(T).ToString();
                    }
                }
                return _instance;
            }
        }

        protected void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                if (isPersistent)
                {
                    DontDestroyOnLoad(gameObject);
                }
            }
            else
            {
                Destroy(gameObject);
            }

        }

        private void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }

    }
}