using UnityEngine;

[CreateAssetMenu(fileName = "TowerSkin", menuName = "/T1andO-TD/Towers/TowerSkinData")]
public class TowerSkinData : ScriptableObject
{
    [field: SerializeField] public Mesh TowerMesh { get; private set; }
}
