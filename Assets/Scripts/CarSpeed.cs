using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour
{

    public static float speed;
    public Slider speedSlider;
    public Text playingSpeedText;
    public Rigidbody2D rb;

    void Start()
    {
        speed = Random.Range(5f, 15f);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + (forward * Time.fixedDeltaTime * speed));

    }

    public void SetSpeed() //method for the slider on intro screen
    {
        speed = speedSlider.value;
        playingSpeedText.text = speed.ToString();
    }

}
