using UnityEngine;

public class FadeToNewMaterial : MonoBehaviour
{
    public Material newMaterial;
    private Material originalMaterial;
    private Renderer renderer;
    private float startTime;
    private bool isFading = false;
    private float fadeDuration = 70f; // 90 seconds total - 20 seconds delay

    void Awake()
    {
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;

        if (elapsedTime >= 60f && !isFading)
        {
            isFading = true;
            startTime = Time.time; // Reset start time for fade
        }

        if (isFading)
        {
            elapsedTime = Time.time - startTime;

            if (elapsedTime <= fadeDuration)
            {
                float t = elapsedTime / fadeDuration;
                renderer.material.Lerp(originalMaterial, newMaterial, t);
            }
            else
            {
                // Fade complete, reset for next loop
                renderer.material = newMaterial;
                originalMaterial = newMaterial;
                isFading = false;
                startTime = Time.time;
            }
        }
    }

    // Public method to set the new material
    public void SetNewMaterial(Material material)
    {
        newMaterial = material;
        isFading = false; // Reset fading process
        startTime = Time.time; // Reset start time for new material
    }
}
