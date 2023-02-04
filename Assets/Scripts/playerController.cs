using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class playerController : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;

    [SerializeField] List<GameObject> checkPoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] private float dead = 20f;

    [SerializeField] private float jump = 20;

    public bool isJumping;

    Vector3 originPosition;
    Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        originPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void Update()
    {
        if(player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }

    }

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        player.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, player.velocity.y, _joystick.Vertical * _moveSpeed);
        
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0) 
        {
            transform.rotation = Quaternion.LookRotation(player.velocity);
        }
    }

    public void Jump()
    {
        rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trap")
        {
            gameObject.transform.position = originPosition;
        }

        vectorPoint = player.transform.position;
        Destroy(other.gameObject);
    }

}
