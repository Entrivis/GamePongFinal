using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public GameObject Win1;
    public GameObject Win2;
    public float speed = 5f;
    private Rigidbody2D rb;
    public Text scoreText1;
    public Text scoreText2;
    private int score1;
    private int score2;
    public ScreenShake screenShake; 

    public void EnableScript() { enabled = true; }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score1 = 0;
        score2 = 0;
        UpdateScore();
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = direction * speed;
    }

    void Update()
    {
        float rightLimit = Screen.width;
        float leftLimit = 0f;
        Vector3 ballPos = Camera.main.WorldToScreenPoint(transform.position);

        
        if (ballPos.x > rightLimit)
        {
            
            score1++;
            UpdateScore();
            ResetBall();
        }
        else if (ballPos.x < leftLimit)
        {
            
            score2++;
            UpdateScore();
            ResetBall();

        }
    }

    void ResetBall()
    {

        transform.position = Vector3.zero;
        rb.velocity = Vector2.zero;

        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = direction * speed;
    }

    void UpdateScore()
    {

        scoreText1.text = score1.ToString();
        scoreText2.text = score2.ToString();

        if (score1 == 3)
        {
            Win1.SetActive(true);
            enabled= false;
        }
        else if (score2 == 3)
        {
            Win2.SetActive(true);
            enabled = false;
        }
    }
}