using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Stats/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    [Header("Vida")]
    public float maxHP;

    [Header("Movimento")]
    public float moveSpeed;

    [Header("Combate")]
    public float baseDamage;
}