using UnityEngine;
using UnityEngine.SceneManagement;

public class DeactivateGameObjects : MonoBehaviour
{
    public GameObject[] gameObjects; // Array of game objects to be deactivated
    private int currentIndex = 0; // Index to track the current game object

    void Update()
    {
        // Check for "Enter" key press or mouse click
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            DeactivateCurrentGameObject();
        }
    }

    void DeactivateCurrentGameObject()
    {
        // Check if there are more game objects to deactivate
        if (currentIndex < gameObjects.Length - 1)
        {
            // Deactivate the current game object
            gameObjects[currentIndex].SetActive(false);
            // Move to the next game object
            currentIndex++;
        }
        else
        {
            // All game objects have been deactivated, load the "Train" scene
            SceneManager.LoadScene("Train");
        }
    }
}
