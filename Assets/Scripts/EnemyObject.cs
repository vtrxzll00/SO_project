using UnityEngine;

[CreateAssetMenu(fileName = "enemy", menuName = "Enemy/new Enemy")]

public class EnemyObject : ScriptableObject
{
  [Header ("Parametros do inimigo")]
  public string enemyName;
  public float healty;
  public int speed;
  public float attack;
}
