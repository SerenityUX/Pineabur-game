using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of the player movement
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Get the input from the vertical axis (W/S keys or Up/Down arrows)
        float move = Input.GetAxis("Vertical");

        // Move the player forward and backward along the Z-axis
        transform.Translate(0, 0, move * speed * Time.deltaTime);
    }
}
