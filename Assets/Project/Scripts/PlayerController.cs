using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // intializing private varaibles
    [Header("Input keys")]
    [SerializeField]
    private KeyCode _upKey;
    [SerializeField]
    private KeyCode _downKey;
    

    [Space]
    [Header("Varaibles:")]
    [SerializeField]
    private float _moveMentSpeed;

    // not serialized varialbles
    private Rigidbody2D rb;
    private Vector2 vector;


    // public variables for getters and setters
    public KeyCode upKey
    {
        get { return this._upKey; }
    }

    public KeyCode downKey
    {
        get { return this._downKey; }
    }

    public float moveMentSpeed
    {
        get { return this._moveMentSpeed; }
        internal set { this._moveMentSpeed = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D> ();
        if (moveMentSpeed <= 0) 
        {
            moveMentSpeed = 10f;
        }
        vector = new Vector2(0f, moveMentSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(upKey)) 
        {
            rb.velocity = vector;
        } 
        else if(Input.GetKey(downKey))
        {
            rb.velocity = -vector;
        }
        else
        {
            rb.velocity = 0 * vector;
        }        
    }
}
