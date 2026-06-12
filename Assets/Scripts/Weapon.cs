using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("Parametros da arma")]
    [SerializeField] private string weaponName;
    [SerializeField] private int municao;
    [SerializeField] private float damage;

    [Header("SO da Arma")]
    public WeaponObject weapon;

    private void Start()
    {
        weaponName = weapon.weaponName;
        municao = weapon.municao;
        damage = weapon.damage;
    }

}
