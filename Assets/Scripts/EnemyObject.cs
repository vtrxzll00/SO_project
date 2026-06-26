using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    [Header("Configuração")]
    [SerializeField] private EnemyStats stats;

    private float currentHP;

    public float CurrentHP => currentHP;
    public float MaxHP => stats.maxHP;
    public float MoveSpeed => stats.moveSpeed;
    public float BaseDamage => stats.baseDamage;

    private void Awake()
    {
        currentHP = stats.maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        currentHP += amount;

        if (currentHP > stats.maxHP)
            currentHP = stats.maxHP;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}