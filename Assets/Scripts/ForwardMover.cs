using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
