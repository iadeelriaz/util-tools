using System.Linq;
using UnityEditor;
using UnityEngine;

namespace AdeelRiaz.Editor
{
    /// <inheritdoc />
    /// <summary>
    /// Instantiate prefab in multiple gameObjects with same name
    /// </summary>
    public class InstantiateTool : EditorWindow
    {
        private GameObject _prefab;

        private GameObject[] _root;

        private string _nameToFind;

        [MenuItem("Adeel/Instantiate/Instantiate Tool")]
        public static void CreateNewCharacter()
        {
            GetWindow<InstantiateTool>();
        }

        void OnGUI()
        {
            Repaint();

            GUILayout.BeginVertical();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.HelpBox($"Select the prefab folder from project to instantiate", MessageType.Info);
            _prefab = EditorGUILayout.ObjectField("Prefab", _prefab, typeof(GameObject), true,
                GUILayout.ExpandWidth(true)) as GameObject;

            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Parent GameObject Name: ");
            _nameToFind = EditorGUILayout.TextField(_nameToFind);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space();
            EditorGUILayout.Space();

            if (GUILayout.Button("Find GameObjects With Name \'" + _nameToFind + "\'"))
            {
                if (_prefab)
                {
                    var objects = FindObjectsOfType<GameObject>().Where(obj => obj.name.Equals(_nameToFind));
                    _root = objects.ToArray();
                    Debug.Log("Total GameObject Found: " + _root.Length);
                }
            }

            EditorGUILayout.Space();
            EditorGUILayout.Space();

            if (_root != null)
            {
                EditorGUILayout.LabelField("Total GameObjects Found: " + _root.Length);
            }

            EditorGUILayout.Space();
            EditorGUILayout.Space();

            if (_prefab && _root != null)
            {
                if (GUILayout.Button("Instantiate \'" + _prefab.name + "\'"))
                {
                    Debug.Log("Instantiate " + _prefab.name);
                    for (int i = 0; i < _root.Length; i++)
                    {
                        Instantiate(_prefab, _root[i].transform).name = _prefab.name;
                    }
                }
            }

            GUILayout.EndVertical();
        }

    }
}
