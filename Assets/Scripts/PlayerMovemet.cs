using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed;
    public float movementSpeed;


    public int score;
    public TextMeshProUGUI scoreTet;




    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movememtInput = Input.GetAxis("Horizontal");


        rb.linearVelocity = new Vector3(speed, rb.linearVelocity.y, -movememtInput * movementSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            score++;
            scoreTet.text = score.ToString();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }


}
