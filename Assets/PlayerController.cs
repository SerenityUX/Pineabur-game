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

    // Reference to the armature (root object controlling the rig)
    public Transform armatureRoot;

    // Boolean to check if the player is walking
    private bool isWalking = false;

    // Initial rotation of the armature
    private Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");

        Debug.Log(SceneData.PlayerPosition);
        if (SceneData.PlayerPosition != new Vector3(0, 0, 0))
        {
            player.transform.position = SceneData.PlayerPosition;
            player.transform.rotation = SceneData.PlayerRotation;
        }
        // Ensure the player starts in the idle state
        isWalking = false;
        animator.SetBool("IsWalking", false);

        // Store the initial rotation of the armature
        initialRotation = armatureRoot.localRotation;

        Debug.Log("PlayerController started. Initial state set to idle.");
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from the vertical axis (W/S keys or Up/Down arrows)
        float move = Input.GetAxis("Vertical");

        // Move the player forward and backward along the Z-axis
        transform.Translate(0, 0, move * speed * Time.deltaTime);

        // Clamp the player's Z position between 0 and 14
        Vector3 clampedPosition = transform.position;
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, 0, 14);
        transform.position = clampedPosition;

        // Check if the player is pressing the "W" or "S" keys
        if (Input.GetKey(KeyCode.W))
        {
            if (!isWalking)
            {
                isWalking = true;
                walkingAudio.Play();
                animator.SetBool("IsWalking", true);
                Debug.Log("Started walking forward.");
            }

            // Ensure the armature is facing forward
            if (armatureRoot.localRotation == Quaternion.Euler(0, 180, 0))
            {
                armatureRoot.localPosition = armatureRoot.localPosition + new Vector3(1, 0, 4);
            }
            armatureRoot.localRotation = initialRotation;

            Debug.Log("Set armature rotation to initial forward rotation.");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (!isWalking)
            {
                isWalking = true;
                walkingAudio.Play();
                animator.SetBool("IsWalking", true);
                Debug.Log("Started walking backward.");
            }

            // Rotate the armature to face backward
            if (armatureRoot.localRotation == initialRotation)
            {
                armatureRoot.localPosition = armatureRoot.localPosition - new Vector3(1, 0, 4);
            }

            armatureRoot.localRotation = Quaternion.Euler(0, 180, 0);

            Debug.Log("Set armature rotation to initial backward rotation.");
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                walkingAudio.Stop();
                animator.SetBool("IsWalking", false);
                Debug.Log("Stopped walking.");
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
            Debug.Log("Player state saved.");
        }
        else
        {
            Debug.LogWarning("Player object not found!");
        }
    }
}
