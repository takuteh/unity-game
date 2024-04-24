using UnityEngine;

public class ClampSide : MonoBehaviour
{
    // x軸方向の移動範囲の最小値
    [SerializeField] private float _minY = -4.5f;

    // x軸方向の移動範囲の最大値
    [SerializeField] private float _maxY = 4.5f;

    private void Update()
    {
        var pos = transform.position;

        // x軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;
    }
}
