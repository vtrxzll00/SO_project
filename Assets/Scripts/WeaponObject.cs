using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/new Weapon")]

public class WeaponObject : ScriptableObject
{
    [Header("Parametros do inimigo")]
    public string weaponName;
    public int municao;
    public float damage;
}
