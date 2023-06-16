using UnityEngine;
using UnityEngine.Events;

namespace AdeelRiaz.Tools
{
    public class CollisionEventHandler : MonoBehaviour
    {

        public string tagToCompare = "Player";

        public UnityEvent eventEnter, eventExit, eventStay;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventEnter.Invoke();
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventExit.Invoke();
            }
        }

        private void OnCollisionStay(Collision other)
        {
            if (other.gameObject.CompareTag(tagToCompare))
            {
                eventStay.Invoke();
            }
        }
    }
}
