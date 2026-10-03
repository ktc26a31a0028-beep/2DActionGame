using UnityEngine;

/// <summary>
/// 触れたプレイヤーにダメージを与えるトゲのスクリプト
/// </summary>
public class Spike : MonoBehaviour
{
    [Header("与えるダメージ")]
    [SerializeField] int damage = 1;

    /// <summary>
    /// Is Trigger の Collider に、ほかの Collider が入ったときに呼ばれる
    /// </summary>
    void OnTriggerEnter2D(Collider2D other)
    {
        // 触れた相手から Player スクリプトを探す
        Player player = other.GetComponent<Player>();

        // Player でなければ何もしない
        if (player == null)
        {
            return;
        }

        // プレイヤーにダメージを与える
        player.TakeDamage(damage);
    }
}
