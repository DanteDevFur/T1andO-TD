using UnityEngine;

[CreateAssetMenu(fileName = "TowerData", menuName = "/T1andO-TD/Towers/TowerData")]
public class TowerData : ScriptableObject
{
    [field: SerializeField] public TowerSkinData TowerSkinData { get; private set; }
    
}
