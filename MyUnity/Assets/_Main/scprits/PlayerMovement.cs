using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

        //variables

    [SerializeField] private float _jumpforce = 10f;
    [SerializeField] private float _movenentspeed = 5f;
    [SerializeField] private Rigidbody2D _rigibody2D;

    [SerializeField] private GroundCheck _groundCheck;
    private void Awake()
    {
        _rigibody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigibody2D.AddForce(Vector2.up * _jumpforce, ForceMode2D.Force);
                Debug.Log("Oprimi la tecla");

            } 
        }

        _rigibody2D.linearVelocity = Vector2.right * _movenentspeed;

    }
}
