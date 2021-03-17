using UnityEngine;

public class DinoController : MonoBehaviour{

    [SerializeField]private Vector2 jumpForce;
    [SerializeField]private AudioClip jumpClip;
    [SerializeField]private AudioClip deathClip;

    private bool isGround = true;

    private Animator dinoAnim;
    private Rigidbody2D dinoRb;
    private AudioSource dinoAudio;

    private void Start() {
        dinoRb = GetComponent<Rigidbody2D>();
        dinoAnim = GetComponent<Animator>();
        dinoAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        HandleInput();
    }

    private void HandleInput(){
        if(Input.GetButtonDown("Jump")){
            Jump();
        }
    }

    private void Jump(){
        if(isGround){
            dinoAnim.SetBool("isJumping", true);
            dinoRb.AddForce(jumpForce, ForceMode2D.Impulse);
            isGround = false;

            dinoAudio.clip = jumpClip;
            dinoAudio.Play();

        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Ground"){
            isGround = true;
            dinoAnim.SetBool("isJumping", false);
        }else{
            dinoAudio.clip = deathClip;
            dinoAudio.Play();
            Time.timeScale = 0;
        } 
    }
}
