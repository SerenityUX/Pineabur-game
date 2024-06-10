using UnityEngine;
using TMPro;

public class FastClock : MonoBehaviour
{
    public TMP_Text clockText;
    private const float duration = 45f;
    private System.DateTime startTime;
    private System.DateTime endTime;
    private System.TimeSpan loadingTime;
    private bool isNightScene = false;

    void Start()
    {
        // Initialize start and end times
        startTime = System.DateTime.Today.AddHours(9); // 9:00 AM
        endTime = System.DateTime.Today.AddHours(19).AddMinutes(30); // 7:30 PM
        loadingTime = new System.TimeSpan(19, 11, 0); // 7:11 PM

        // Check if TMP_Text is assigned
        if (clockText == null)
        {
            clockText = GetComponent<TMP_Text>();
            if (clockText == null)
            {
                Debug.LogError("TMP_Text component is not assigned or attached to the GameObject.");
            }
        }

        // Reset elapsed time if it's the night scene
        if (isNightScene)
        {
            SceneData.ElapsedTime = 0f;
        }
    }

    void Update()
    {
        if (SceneData.ElapsedTime < duration)
        {
            SceneData.ElapsedTime += Time.deltaTime;
            float t = SceneData.ElapsedTime / duration;

            // Calculate the current time based on interpolation
            System.DateTime currentTime = LerpDateTime(startTime, endTime, t);

            // Check if the current time is after 7:11 PM in the simulated time
            if (currentTime.TimeOfDay >= loadingTime)
            {
                // Set the text to "Loading..." after 7:11 PM
                clockText.text = "Loading...";
            }
            else
            {
                // Update the TMP text with the current time
                clockText.text = currentTime.ToString("hh:mm tt");
            }

            // Debug log to check values
            Debug.Log($"Elapsed Time: {SceneData.ElapsedTime}, Interpolation Factor: {t}, Current Time: {currentTime.ToString("hh:mm tt")}");
        }
    }

    // Custom Lerp function for DateTime
    System.DateTime LerpDateTime(System.DateTime start, System.DateTime end, float t)
    {
        long startTicks = start.Ticks;
        long endTicks = end.Ticks;
        long currentTicks = (long)(startTicks + (endTicks - startTicks) * Mathf.Clamp01(t)); // Ensure t is clamped between 0 and 1
        return new System.DateTime(currentTicks);
    }

    public void SwitchToNightScene()
    {
        isNightScene = true;
        SceneData.ElapsedTime = 0f;
        // Add logic here to switch to the night scene if needed
    }
}
