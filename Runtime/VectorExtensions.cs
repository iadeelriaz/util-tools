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

        #endregion
    }
}
