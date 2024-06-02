using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Enemy : MonoBehaviour
{
    private Movement _movement;

    private void Awake()
    {
        _movement = GetComponent<Movement>(); 
    }

    private void Update()
    {
        _movement.Move(transform.forward);     
    }
}
