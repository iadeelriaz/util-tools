using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace AdeelRiaz.Editor
{
    public static class ToolsMenu
    {
        [MenuItem("Adeel/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            CreateDir("_Adeel", "Animations", "Audio", "Events", "Fonts", "GUI", "Prefabs", "Scripts", "Scenes");
            CreateDirectory(Combine(dataPath, "_GameData"));
            Refresh();
        }

        private static void CreateDir(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach (var newDir in dir)
            {
                CreateDirectory(Combine(fullPath, newDir));
            }
        }
    }
}
