using UnityEngine;
using System.Collections;

public class ScaleYAxis : MonoBehaviour
{
    public float duration = 8.0f; // Duration of the scaling
    private float targetScaleY = 0.731f; // Target Y scale
    private float initialScaleY = 0f; // Initial Y scale (starting at 0)
    private float elapsedTime = 0f; // Time elapsed since the start of scaling

    void OnEnable()
    {
        ResetScale();
        StartCoroutine(ScaleOverTime());
    }

    private void ResetScale()
    {
        // Reset elapsed time
        elapsedTime = 0f;

        // Set the initial scale to 0 on the Y axis
        Vector3 initialScale = transform.localScale;
        initialScale.y = initialScaleY;
        transform.localScale = initialScale;
    }

    IEnumerator ScaleOverTime()
    {
        while (elapsedTime < duration)
        {
            // Calculate the fraction of the duration that has passed
            float t = elapsedTime / duration;

            // Use SmoothStep to interpolate the Y scale
            float newYScale = Mathf.SmoothStep(initialScaleY, targetScaleY, t);

            // Apply the new scale to the GameObject
            Vector3 newScale = transform.localScale;
            newScale.y = newYScale;
            transform.localScale = newScale;

            // Increase the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the next frame
            yield return null;
        }

        // Ensure the final scale is exactly the target scale
        Vector3 finalScale = transform.localScale;
        finalScale.y = targetScaleY;
        transform.localScale = finalScale;
    }
}
