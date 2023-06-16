using UnityEngine;
using UnityEngine.Events;

namespace AdeelRiaz.Tools
{
    public class TriggerEventHandler : MonoBehaviour
    {
        public string tagToCompare = "Player";

        public UnityEvent eventEnter, eventExit, eventStay;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventEnter.Invoke();
            }
        }
        public void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventExit.Invoke();
            }
        }
        public void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventStay.Invoke();
            }
        }
    }
}
