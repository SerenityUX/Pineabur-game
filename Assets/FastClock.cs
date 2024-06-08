using UnityEngine;
using TMPro;

public class FastClock : MonoBehaviour
{
    public TMP_Text clockText;
    private float elapsedTime = 0f;
    private const float duration = 90f;
    private System.DateTime startTime;
    private System.DateTime endTime;

    void Start()
    {
        // Initialize start and end times
        startTime = System.DateTime.Today.AddHours(9); // 9:00 AM
        endTime = System.DateTime.Today.AddHours(19).AddMinutes(30); // 7:30 PM

        // Check if TMP_Text is assigned
        if (clockText == null)
        {
            clockText = GetComponent<TMP_Text>();
            if (clockText == null)
            {
                Debug.LogError("TMP_Text component is not assigned or attached to the GameObject.");
            }
        }
    }

    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;

            // Calculate the current time based on interpolation
            System.DateTime currentTime = LerpDateTime(startTime, endTime, t);

            // Update the TMP text with the current time
            clockText.text = currentTime.ToString("hh:mm tt");
        }
    }

    // Custom Lerp function for DateTime
    System.DateTime LerpDateTime(System.DateTime start, System.DateTime end, float t)
    {
        long startTicks = start.Ticks;
        long endTicks = end.Ticks;
        long currentTicks = (long)(startTicks + (endTicks - startTicks) * t);
        return new System.DateTime(currentTicks);
    }
}
