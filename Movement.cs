using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField , Range(0, 100)] private float _speed;

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * (_speed * Time.deltaTime));
    }
}
