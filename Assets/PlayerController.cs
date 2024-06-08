using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Speed of the player movement
    public float speed = 5.0f;

    // Audio source for walking sound
    public AudioSource walkingAudio;

    // Animator component for controlling animations
    public Animator animator;

    // Boolean to check if the player is walking
    private bool isWalking = false;

    // Update is called once per frame
    void Update()
    {
        // Get the input from the vertical axis (W/S keys or Up/Down arrows)
        float move = Input.GetAxis("Vertical");

        // Move the player forward and backward along the Z-axis
        transform.Translate(0, 0, move * speed * Time.deltaTime);

        // Check if the player is pressing the "W" or "S" keys
        if (Input.GetKey(KeyCode.W))
        {
            if (!isWalking)
            {
                isWalking = true;
                walkingAudio.Play();
                animator.SetBool("IsWalking", true);
            }

            // Ensure the player is facing forward
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (!isWalking)
            {
                isWalking = true;
                walkingAudio.Play();
                animator.SetBool("IsWalking", true);
            }

            // Rotate the player to face backward
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                walkingAudio.Stop();
                animator.SetBool("IsWalking", false);
            }
        }

        SavePlayerState();
    }

    void SavePlayerState()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            SceneData.PlayerPosition = player.transform.position;
            SceneData.PlayerRotation = player.transform.rotation;
        }
    }
}
