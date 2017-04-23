
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

   
    public GameObject inventory;
    public Rigidbody2D Rb;
    public float MovementSpeed = 1f;
    private bool IsGrounded = true;
    Animator anim;

    void Start () {
        Rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	void LateUpdate () {
            
        if (IsGrounded == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetInteger("State", 2);
                transform.Translate(Vector2.left * MovementSpeed);
                
            }else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetInteger("State", 1);
                transform.Translate(Vector2.right * MovementSpeed);
            }
            else
            {
                anim.SetInteger("State", 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetInteger("State", 420);
            }



        }
       
	}

    void OnCollisionStay2D(Collision2D collisionInfo)
    {
        IsGrounded = true;
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        IsGrounded = false;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.name == "Spaceship" || collider.gameObject.CompareTag("spaceship")) {
            if(inventory.GetComponent<Inventory>().hasSupplies) {
                SceneManager.LoadScene("Winner");
            }
        }
    }

}
