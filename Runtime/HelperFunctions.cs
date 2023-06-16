using UnityEngine;

namespace AdeelRiaz.Tools
{
    public static class HelperFunctions
    {
        #region Transform
        
        /// <summary>
        /// Resets the transform locally
        /// a bool to specify whether to reset scale
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="resetScale"></param>
        public static void LocalReset(this Transform transform, bool resetScale = true)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            if (resetScale)
            {
                transform.localScale = Vector3.one;
            }
        }

        /// <summary>
        /// Resets the local position of given transform
        /// </summary>
        /// <param name="transform"></param>
        public static void ResetLocalPos(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
        }

        /// <summary>
        /// Resets the local rotation of given transform
        /// </summary>
        /// <param name="transform"></param>
        public static void ResetLocalRot(this Transform transform)
        {
            transform.localRotation = Quaternion.identity;
        }

        /// <summary>
        /// Resets the transform
        /// a bool to specify whether to reset scale
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="resetScale"></param>
        public static void Reset(this Transform transform, bool resetScale = true)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            if (resetScale)
            {
                transform.localScale = Vector3.one;
            }
        }
        
        /// <summary>
        /// Resets the position of given transform
        /// </summary>
        /// <param name="transform"></param>
        public static void ResetPos(this Transform transform)
        {
            transform.position = Vector3.zero;
        }

        /// <summary>
        /// Resets the rotation of given transform
        /// </summary>
        /// <param name="transform"></param>
        public static void ResetRot(this Transform transform)
        {
            transform.rotation = Quaternion.identity;
        }

        /// <summary>
        /// Resets the scale of given transform
        /// </summary>
        /// <param name="transform"></param>
        public static void ResetScale(this Transform transform)
        {
            transform.localScale = Vector3.one;
        }
        
        /// <summary>
        /// Sets the x value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="x"></param>
        public static void SetX( this Transform transform, float x )
        {
            var position = transform.position;
            position = new Vector3( x, position.y, position.z );
            transform.position = position;
        }
        
        /// <summary>
        /// Sets the y value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="y"></param>
        public static void SetY( this Transform transform, float y )
        {
            var position = transform.position;
            position = new Vector3( position.x, y, position.z );
            transform.position = position;
        }
        
        /// <summary>
        /// Sets the z value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="z"></param>
        public static void SetZ( this Transform transform, float z )
        {
            var position = transform.position;
            position = new Vector3( position.x, position.y, z );
            transform.position = position;
        }
        
        /// <summary>
        /// Adds the x value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="x"></param>
        public static void AddX( this Transform transform, float x )
        {
            var position = transform.position;
            position = new Vector3(position.x + x, position.y, position.z );
            transform.position = position;
        }
        
        /// <summary>
        /// Adds the y value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="y"></param>
        public static void AddY( this Transform transform, float y )
        {
            var position = transform.position;
            position = new Vector3( position.x, position.y + y, position.z );
            transform.position = position;
        }
        
        /// <summary>
        /// Adds the z value in given transform
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="z"></param>
        public static void AddZ( this Transform transform, float z )
        {
            var position = transform.position;
            position = new Vector3( position.x, position.y, position.z + z );
            transform.position = position;
        }
        
        /// <summary>
        /// Gets the look at rotation from given target vector3
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look at rotation(Quaternion) of target vector3</returns>
        public static Quaternion GetLookAtRotation(this Transform self, Vector3 target)
        {
            return Quaternion.LookRotation(target - self.position);
        }
        
        /// <summary>
        /// Gets the look at rotation from given target transform
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look at rotation(Quaternion) of target transform</returns>
        public static Quaternion GetLookAtRotation(this Transform self, Transform target)
        {
            return GetLookAtRotation(self, target.position);
        }
        
        /// <summary>
        /// Gets the look at rotation from given target game object
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look at rotation(Quaternion) of target game object</returns>
        public static Quaternion GetLookAtRotation(this Transform self, GameObject target)
        {
            return GetLookAtRotation(self, target.transform.position);
        }
        
        /// <summary>
        /// Rotates the transform away from the given target vector3
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        public static void LookAwayFrom(this Transform self, Vector3 target)
        {
            self.rotation = GetLookAwayFromRotation(self, target);
        }
        
        /// <summary>
        /// Rotates the transform away from the given target transform
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        public static void LookAwayFrom(this Transform self, Transform target)
        {
            self.rotation = GetLookAwayFromRotation(self, target);
        }
        
        /// <summary>
        /// Rotates the transform away from the given target game object
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        public static void LookAwayFrom(this Transform self, GameObject target)
        {
            self.rotation = GetLookAwayFromRotation(self, target);
        }
        
        /// <summary>
        /// Gets look away rotation from given target vector3
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look away rotation(Quaternion) from target vector3</returns>
        public static Quaternion GetLookAwayFromRotation(this Transform self, Vector3 target)
        {
            return Quaternion.LookRotation(self.position - target);
        }
        
        /// <summary>
        /// Gets look away rotation from given target transform
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look away rotation(Quaternion) from target transform</returns>
        public static Quaternion GetLookAwayFromRotation(this Transform self, Transform target)
        {
            return GetLookAwayFromRotation(self, target.position);
        }
        
        
        /// <summary>
        /// Gets look away rotation from given target game object
        /// </summary>
        /// <param name="self"></param>
        /// <param name="target"></param>
        /// <returns>Look away rotation(Quaternion) from target game object</returns>
        public static Quaternion GetLookAwayFromRotation(this Transform self, GameObject target)
        {
            return GetLookAwayFromRotation(self, target.transform.position);
        }
        
        
        /// <summary>
        /// Copy and apply position values from given transform
        /// A bool specifies whether a local or global transform 
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="values"></param>
        /// <param name="isLocal"></param>
        public static void CopyPositionFrom(this Transform trans, Transform values, bool isLocal = false)
        {
            if (isLocal)
            {
                trans.localPosition = values.localPosition;
            }
            else
            {
                trans.position = values.position;
            }
        }
        
        
        /// <summary>
        /// Copy and apply rotation values from given transform
        /// A bool specifies whether a local or global transform 
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="values"></param>
        /// <param name="isLocal"></param>
        public static void CopyRotationFrom(this Transform trans, Transform values, bool isLocal = false)
        {
            if (isLocal)
            {
                trans.localEulerAngles = values.localEulerAngles;
            }
            else
            {
                trans.eulerAngles = values.eulerAngles;
            }
        }
        
        /// <summary>
        /// Copy and apply transform values from given transform.
        /// A bool specifies whether a local or global transform 
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="values"></param>
        /// <param name="isLocal"></param>
        public static void CopyTransformValuesFrom(this Transform trans, Transform values, bool isLocal = false)
        {
            if (isLocal)
            {
                trans.localPosition    = values.localPosition;
                trans.localEulerAngles = values.localEulerAngles;
            }
            else
            {
                trans.position    = values.position;
                trans.eulerAngles = values.eulerAngles;
            }
        }

        #endregion
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //
        
        /// <summary>
        /// Attaches a component to the given component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>Newly attached component.</returns>
        public static T AddComponent<T>(this Component component) where T : Component
        {
            return component.gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Gets a component attached to the given component's game object.
        /// If one isn't found, a new one is attached and returned.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>Previously or newly attached component.</returns>
        public static T GetOrAddComponent<T>(this Component component) where T : Component
        {
            return component.GetComponent<T>() ?? component.AddComponent<T>();
        }

        /// <summary>
        /// Checks whether a component's game object has a component of type T attached.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>True when component is attached.</returns>
        public static bool HasComponent<T>(this Component component) where T : Component
        {
            return component.GetComponent<T>() != null;
        }
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //

        #region GameObject
        
        /// <summary>
        /// Gets a component attached to the given game object.
        /// If one isn't found, a new one is attached and returned.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>Attached or newly added component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
        }
        
        /// <summary>
        /// Checks whether game object has a component of type T attached.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>True when component is attached</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }

        #endregion
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //

        #region Mask
        
        /// <summary>
        /// Checks if masks contains a specific layer number
        /// </summary>
        /// <param name="mask"></param>
        /// <param name="layerNumber"></param>
        /// <returns>True when mask contains layerNumber</returns>
        public static bool ContainsMask(this LayerMask mask, int layerNumber)
        {
            return mask == (mask | (1 << layerNumber));
        }

        #endregion

        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //

        #region Color

        /// <summary>
        /// Sets the alpha of the given color
        /// </summary>
        /// <param name="color"></param>
        /// <param name="alpha"></param>
        /// <returns>Color with new alpha (Transparency) value</returns>
        public static Color WithAlpha(this Color color, float alpha) 
        {
            color.a = alpha;
            return color;
        }

        #endregion
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //

        #region Audio
        
        /// <summary>
        /// Play the audio clip with volume and pitch set to 1
        /// </summary>
        /// <param name="audioClip"></param>
        public static void Play(this AudioClip audioClip) {
            audioClip.PlayClipAtPoint(Vector3.zero, 1.0f, 1.0f, 0.0f);
        }
        
        /// <summary>
        /// Play the audio clip at a given position
        /// </summary>
        /// <param name="audioClip"></param>
        /// <param name="position"></param>
        public static void PlayClipAtPoint(this AudioClip audioClip, Vector3 position) {
            audioClip.PlayClipAtPoint(position, 1.0f, 1.0f, 0.0f);
        }

        /// <summary>
        /// Play clip at the given position and given volume
        /// </summary>
        /// <param name="audioClip"></param>
        /// <param name="position"></param>
        /// <param name="volume"></param>
        public static void PlayClipAtPoint(this AudioClip audioClip, Vector3 position, float volume) {
            audioClip.PlayClipAtPoint(position, volume, 1.0f, 0.0f);
        }

        /// <summary>
        /// Play clip at the given position, volume, pitch and pan
        /// </summary>
        /// <param name="audioClip"></param>
        /// <param name="position"></param>
        /// <param name="volume"></param>
        /// <param name="pitch"></param>
        /// <param name="pan"></param>
        public static void PlayClipAtPoint(this AudioClip audioClip, Vector3 position, float volume, float pitch, float pan) {
            float originalTimeScale = Time.timeScale;
            Time.timeScale = 1.0f; // ensure that all audio plays

            GameObject  go       = new GameObject("One-shot audio");
            AudioSource goSource = go.AddComponent<AudioSource>();
            goSource.clip         = audioClip;
            go.transform.position = position;
            goSource.volume       = volume;
            goSource.pitch        = pitch;
            goSource.panStereo    = pan;

            goSource.Play();
            Object.Destroy(go, audioClip.length);

            Time.timeScale = originalTimeScale;
        }

        #endregion
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ //

    }
}
