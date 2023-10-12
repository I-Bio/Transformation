using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0f, _speed, 0f) * Time.deltaTime);
    }
}
