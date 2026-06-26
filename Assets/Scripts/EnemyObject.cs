using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private EnemyStats stats;

    [Header("Runtime")]
    [SerializeField] private float currentHP;

    [Header("Stats (Somente Leitura)")]
    [SerializeField] private float maxHP;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float baseDamage;

    public float CurrentHP => currentHP;
    public float MaxHP => maxHP;
    public float MoveSpeed => moveSpeed;
    public float BaseDamage => baseDamage;

    private void Awake()
    {
        AtualizarStats();
    }

    private void OnValidate()
    {
        AtualizarStats();
    }

    private void AtualizarStats()
    {
        if (stats == null) return;

        maxHP = stats.maxHP;
        moveSpeed = stats.moveSpeed;
        baseDamage = stats.baseDamage;
        currentHP = maxHP;
    }
}