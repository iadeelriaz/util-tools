using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class GridGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject gridBlockPrefab;
        [SerializeField] private Vector3 gridOffset;
        [SerializeField] private Vector3Int gridSize;

        [SerializeField] private Vector3 blockSize = new Vector3(1, 1, 1);
        [SerializeField] private List<GameObject> gridItems;

        public void GenerateGrid()
        {
            ClearGrid();
            gridItems = new List<GameObject>();
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                    for (int z = 0; z < gridSize.z; z++)
                    {
                        //Vector3 pos = new Vector3(x * gridOffset, 0f, z * gridOffset);
                        GameObject block = null;
#if UNITY_EDITOR
                        block = (GameObject)PrefabUtility.InstantiatePrefab(gridBlockPrefab, transform);
#endif
                        // GameObject block = Instantiate(gridBlockPrefab, transform);
                        block.transform.localPosition = new Vector3(x * gridOffset.x,
                            y * gridOffset.y, z * gridOffset.z);
                        block.name = gridBlockPrefab.name;
                        block.transform.localScale =
                            new Vector3(blockSize.x, blockSize.y, blockSize.y);
                        gridItems.Add(block);
                    }
                }
            }
        }

        public void ClearGrid()
        {
            if (gridItems.Count > 0)
            {
                foreach (var item in gridItems)
                {
                    DestroyImmediate(item);
                }

                gridItems.Clear();
            }
        }
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(GridGenerator))]
    public class GridGeneratorEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GridGenerator gridGenerator = (GridGenerator)target;

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Generate Grid"))
            {
                gridGenerator.GenerateGrid();
            }

            if (GUILayout.Button("Clear Grid"))
            {
                gridGenerator.ClearGrid();
            }

            EditorGUILayout.EndHorizontal();
        }
    }
#endif
}