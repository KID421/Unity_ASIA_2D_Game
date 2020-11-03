using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 1;

    private Rigidbody2D rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if (Input.anyKey)
        {
            rig.MovePosition(transform.position + Vector3.right * h * Time.fixedDeltaTime * speed);

            if (h == 1) transform.eulerAngles = Vector3.zero;
            else if (h == -1) transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
