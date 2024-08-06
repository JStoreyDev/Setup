using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;    
public class MenuInstall : MonoBehaviour
{    
    [MenuItem("Help/Setup",false,-20)]
    public static void Shared() => Client.Add("git+https://github.com/JStoreyDev/Shared.git");
}