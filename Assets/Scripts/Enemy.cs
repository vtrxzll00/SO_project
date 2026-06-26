using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Stats/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    [Header("Vida")]
    public float maxHP = 100f;

    [Header("Movimento")]
    public float moveSpeed = 3.5f;

    [Header("Combate")]
    public float baseDamage = 10f;
}