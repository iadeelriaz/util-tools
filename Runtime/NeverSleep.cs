using UnityEngine;

namespace AdeelRiaz.Tools
{
	public class NeverSleep : MonoBehaviour {
		private void Awake()
		{
			Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
			DontDestroyOnLoad (gameObject);
		}
	}
}
