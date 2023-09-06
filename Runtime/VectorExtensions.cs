using UnityEngine;

namespace AdeelRiaz.Tools
{
    public static class VectorExtensions
    {
        #region Vector2

        public static Vector2 WithX(this Vector2 vector, float x) {
            return new Vector2(x, vector.y);
        }

        public static Vector2 WithY(this Vector2 vector, float y) {
            return new Vector2(vector.x, y);
        }

        public static Vector2 PlusX(this Vector2 vector, float plusX) {
            return new Vector2(vector.x + plusX, vector.y);
        }

        public static Vector2 PlusY(this Vector2 vector, float plusY) {
            return new Vector2(vector.x, vector.y + plusY);
        }

        public static Vector2 TimesX(this Vector2 vector, float timesX) {
            return new Vector2(vector.x * timesX, vector.y);
        }

        public static Vector2 TimesY(this Vector2 vector, float timesY) {
            return new Vector2(vector.x, vector.y * timesY);
        }
        
        public static Vector2 ReplaceXOnly(this Vector2 v, float x) {
            return new Vector2(x, v.y);
        }
	
        public static Vector2 ReplaceYOnly(this Vector2 v, float y) {
            return new Vector2(v.x, y);
        }

        public static Vector2 Rotate(this Vector2 vector, float degrees) {
            float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
            float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);
		
            float tx = vector.x;
            float ty = vector.y;
            vector.x = (cos * tx) - (sin * ty);
            vector.y = (sin * tx) + (cos * ty);
            return vector;
        }

        #endregion
        
        // _+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+ //

        #region Vector3

        public static Vector2 To2(this Vector3 vector) {
            return vector;
        }

        public static Vector3 WithX(this Vector3 vector, float x) {
            return new Vector3(x, vector.y, vector.z);
        }

        public static Vector3 WithY(this Vector3 vector, float y) {
            return new Vector3(vector.x, y, vector.z);
        }

        public static Vector3 WithZ(this Vector3 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }

        public static Vector3 PlusX(this Vector3 vector, float plusX) {
            return new Vector3(vector.x + plusX, vector.y, vector.z);
        }

        public static Vector3 PlusY(this Vector3 vector, float plusY) {
            return new Vector3(vector.x, vector.y + plusY, vector.z);
        }

        public static Vector3 PlusZ(this Vector3 vector, float plusZ) {
            return new Vector3(vector.x, vector.y, vector.z + plusZ);
        }

        public static Vector3 TimesX(this Vector3 vector, float timesX) {
            return new Vector3(vector.x * timesX, vector.y, vector.z);
        }

        public static Vector3 TimesY(this Vector3 vector, float timesY) {
            return new Vector3(vector.x, vector.y * timesY, vector.z);
        }

        public static Vector3 TimesZ(this Vector3 vector, float timesZ) {
            return new Vector3(vector.x, vector.y, vector.z * timesZ);
        }

        public static Vector3 ReplaceXOnly(this Vector3 v, float x) {
            return new Vector3(x, v.y, v.z);
        }

        public static Vector3 ReplaceYOnly(this Vector3 v, float y) {
            return new Vector3(v.x, y, v.z);
        }

        public static Vector3 ReplaceZOnly(this Vector3 v, float z) {
            return new Vector3(v.x, v.y, z);
        }

        /// <summary>
        /// Normalized the angle. between -180 and 180 degrees
        /// </summary>
        /// <param Name="eulerAngle">Euler angle.</param>
        public static Vector3 NormalizeAngle(this Vector3 eulerAngle)
        {
            var delta = eulerAngle;

            if (delta.x > 180)
            {
                delta.x -= 360;
            }
            else if (delta.x < -180)
            {
                delta.x += 360;
            }

            if (delta.y > 180)
            {
                delta.y -= 360;
            }
            else if (delta.y < -180)
            {
                delta.y += 360;
            }

            if (delta.z > 180)
            {
                delta.z -= 360;
            }
            else if (delta.z < -180)
            {
                delta.z += 360;
            }

            return new Vector3(delta.x, delta.y, delta.z);//round values to angle;
        }

        public static Vector3 Difference(this Vector3 vector, Vector3 otherVector)
        {
            return otherVector - vector;
        }
        public static Vector3 AngleFormOtherDirection(this Vector3 directionA, Vector3 directionB)
        {
            if (directionA.normalized.magnitude == 0 || directionB.normalized.magnitude == 0) return Vector3.zero;
            return Quaternion.LookRotation(directionA).eulerAngles.AngleFormOtherEuler(Quaternion.LookRotation(directionB).eulerAngles);
        }

        public static Vector3 AngleFormOtherDirection(this Vector3 directionA, Vector3 directionB, Vector3 up)
        {
            return Quaternion.LookRotation(directionA, up).eulerAngles.AngleFormOtherEuler(Quaternion.LookRotation(directionB, up).eulerAngles);
        }
        public static Vector3 AngleFormOtherEuler(this Vector3 eulerA, Vector3 eulerB)
        {
            Vector3 angles = eulerA.NormalizeAngle().Difference(eulerB.NormalizeAngle()).NormalizeAngle();
            return angles;
        }
        public static string ToStringColor(this bool value)
        {
            if (value) return "<color=green>YES</color>";
            else return "<color=red>NO</color>";
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            do
            {
                if (angle < -360)
                {
                    angle += 360;
                }

                if (angle > 360)
                {
                    angle -= 360;
                }
            } while (angle < -360 || angle > 360);

            return Mathf.Clamp(angle, min, max);
        }

        #endregion
    }
}
