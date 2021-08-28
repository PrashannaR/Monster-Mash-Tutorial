using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 11f;
    public float maxVelocity = 22f;

    private float movementX;
    private Rigidbody2D myBody;
    private Animator animator;
    private SpriteRenderer sprite;

    public string Walk_Animation = "Walk";
    private bool isgrounded;
    private string Ground_Tag = "GroundTag";

    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        sprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
    }

    //Moves the sprite with the keyboard
    void PlayerMoveKeyboard(){
        
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer(){

        //movement towards the right
        if(movementX > 0){
            animator.SetBool(Walk_Animation, true);
            sprite.flipX = false;
        }
        //movement towards the left
        else if(movementX < 0){
            animator.SetBool(Walk_Animation, true);
            sprite.flipX = true;
        }
        //no movement
         else {
            animator.SetBool(Walk_Animation, false);
        }

    }
     private void FixedUpdate() {
        PlayerJump();
    }

    void PlayerJump(){

        if(Input.GetButtonDown("Jump") && isgrounded){
            isgrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag(Ground_Tag)){
                isgrounded = true;
                Debug.Log("Landed");
        }
    }

}//class
