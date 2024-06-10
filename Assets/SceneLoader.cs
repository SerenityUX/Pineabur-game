using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public static string nextScene; // Variable to store the name of the next scene

    //public GameObject loadingScreen; // Reference to the loading screen UI
    //public Slider progressBar; // Reference to a UI Slider to show progress

    // Method to start loading a scene
    public void LoadScene(string sceneName)
    {
        nextScene = sceneName; // Set the next scene name
        SceneManager.LoadScene("Loading"); // Load the loading screen scene
    }

    // Method to be called from the LoadingScene to start loading the target scene
    public void StartLoadingNextScene()
    {
        StartCoroutine(LoadSceneAsync(nextScene));
    }

    // Coroutine to load the scene asynchronously
    IEnumerator LoadSceneAsync(string sceneName)
    {
        // Show the loading screen
        //loadingScreen.SetActive(true);

        // Start loading the scene asynchronously
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        // Disable scene activation until loading is complete
        operation.allowSceneActivation = false;

        // Update the progress bar
        while (!operation.isDone)
        {
            //// Get progress (0 to 1)
            //float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //progressBar.value = progress;

            // Check if the loading is complete
            if (operation.progress >= 0.9f)
            {
                // Allow scene activation
                operation.allowSceneActivation = true;
            }

            yield return null;
        }

        // Hide the loading screen (optional, as it will be destroyed when the scene changes)
        //loadingScreen.SetActive(false);
    }
}
