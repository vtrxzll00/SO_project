using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Parametros do inimigo")]
   [SerializeField] private string enemyName;
   [SerializeField] private float healty;
   [SerializeField] private int speed;
   [SerializeField] private float attack;

    [Header("SO do Inimigo")]
    public EnemyObject enemy;

    private void Start()
    {
        enemyName = enemy.enemyName;
        healty = enemy.healty;
        speed = enemy.speed;
        attack = enemy.attack;
    }

}
