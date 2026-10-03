using UnityEngine;

/// <summary>
/// ライフをハート画像で表示するスクリプト
/// </summary>
public class Life : MonoBehaviour
{
    [Header("ハート 1 個分のプレハブ（UI の Image）")]
    [SerializeField] GameObject heartPrefab;

    GameObject[] lifeObjects; // 生成したハートを入れておく配列

    /// <summary>
    /// 最大ライフの数だけハートを生成して並べる（Player から呼ばれる）
    /// </summary>
    public void Setup(int maxLife)
    {
        // 最大ライフの数だけ配列を用意
        lifeObjects = new GameObject[maxLife];

        // ハートを生成して、このオブジェクトの子にする
        for (int i = 0; i < lifeObjects.Length; i++)
        {
            lifeObjects[i] = Instantiate(heartPrefab, transform);
        }
    }

    /// <summary>
    /// 残りライフの数だけハートを表示する（Player から呼ばれる）
    /// </summary>
    public void SetLife(int currentLife)
    {
        // 番号が残りライフより小さいハートだけ表示
        // 例：ライフ 2 → 0 番と 1 番を表示、2 番を消す
        for (int i = 0; i < lifeObjects.Length; i++)
        {
            lifeObjects[i].SetActive(i < currentLife);
        }
    }
}
