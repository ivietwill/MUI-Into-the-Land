using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerController : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float rotateSpeed;

    [SerializeField] List<Vector3> checkPoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] private float dead;

    [SerializeField] private float jump = 20;
    [SerializeField] private float timeWait = 0.5f;

    [SerializeField] private bool isGrounded = true;
    [SerializeField] private Animator anim;

    [SerializeField] private GameObject joystickBtn;
    [SerializeField] private float waiting = 0.5f;

    public int pointCheck = 0;

    

    //Vector3 originPosition;
    Rigidbody rb;

    public void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
        //originPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void Update()
    {
        if(player.transform.position.y <= -dead)
        {
           // rb.useGravity = false;
           //transform.position = vectorPoint  ;
        }

    }

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        player.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, player.velocity.y, _joystick.Vertical * rotateSpeed);
        
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0) 
        {
            anim.SetBool("Running", true);
            joystickBtn.SetActive(false);
            transform.rotation = Quaternion.LookRotation(player.velocity);
        }

        else
        {
            joystickBtn.SetActive(true);
            anim.SetBool("Running", false);
        }

        if (Input.GetKeyUp(KeyCode.Space)) 
        {
        
            rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
         
        }
    }

    public void Jump()
    {

        if (isGrounded == true)
        {
            isGrounded = false;
            anim.SetBool("Flap", true);
            rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
            StartCoroutine(waitJump());

        }
       
    }


    private void OnTriggerEnter(Collider CpOther)
    {


        if (CpOther.gameObject.tag == "CheckPoints")
        {

            vectorPoint = CpOther.transform.position;
            Destroy(CpOther.gameObject);
        }

        if (CpOther.gameObject.tag == "FallPoints")
        {
            rb.isKinematic = false;
            vectorPoint.y = vectorPoint.y + 10;
            transform.position = vectorPoint;
            
        }
    }

  




    IEnumerator waitJump()
    {
        
        yield return new WaitForSeconds(timeWait);
        anim.SetBool("Flap", false);
        isGrounded = true;
    }

    IEnumerator waitBack()
    {
        yield return new WaitForSeconds(waiting);
        rb.isKinematic = true;
    }


}
