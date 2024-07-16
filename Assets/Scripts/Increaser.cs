using UnityEngine;

public class Increaser : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);

    private void Update()
    {
        transform.localScale += scaleChange * _speed;
    }
}
