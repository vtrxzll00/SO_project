using UnityEngine;

[RequireComponent(typeof(EnemyObject))]
public class EnemyBehaviour : MonoBehaviour
{
    private EnemyObject enemy;

    private void Awake()
    {
        enemy = GetComponent<EnemyObject>();
    }

    private void Update()
    {
        // Move o inimigo para frente usando a velocidade definida no ScriptableObject
        transform.Translate(Vector3.forward * enemy.MoveSpeed * Time.deltaTime);
    }
}