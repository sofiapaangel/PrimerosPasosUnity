using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variables

[SerializeField] private float _force = 10f;
[SerializeField] private float _speed = 5f;
[SerializeField] private Rigidbody2D _rigibody2D;

private void Start()
{
   _rigibody2D = GetComponent<Rigidbody2D>();
}
private void Update()
{
    if (Input.GetKey(KeyCode.Space))
        {
            _rigibody2D.AddForce(Vector2.up *_force);
    
        }
        _rigibody2D.velocity = Vector2.right * _speed * Time.deltaTime;
        {
            
        }
}

} 