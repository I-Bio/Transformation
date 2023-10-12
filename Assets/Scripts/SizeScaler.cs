using UnityEngine;

public class SizeScaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = new Vector3(
            transform.localScale.x + _speed * Time.deltaTime,
            transform.localScale.y + _speed * Time.deltaTime,
            transform.localScale.z + _speed * Time.deltaTime);
    }
}
