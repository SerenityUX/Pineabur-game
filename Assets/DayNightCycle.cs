using UnityEngine;
using UnityEngine.SceneManagement;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight;
    public float duration = 90.0f; // Duration for the cycle in seconds
    public Color nightAmbientColor = Color.black; // Color of ambient light at night

    private float elapsedTime = 0.0f;
    private Color initialAmbientColor;

    void Start()
    {
        if (directionalLight == null)
        {
            directionalLight = GetComponent<Light>();
        }

        initialAmbientColor = RenderSettings.ambientLight; // Store the initial ambient light color

        // Ensure other lights are off
        Light[] allLights = FindObjectsOfType<Light>();
        foreach (Light light in allLights)
        {
            if (light != directionalLight)
            {
                light.enabled = false; // Temporarily disable other lights
            }
        }
    }

    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float lerpFactor = elapsedTime / duration;

            // Assuming starting from noon (90 degrees) to midnight (-90 degrees)
            float angle = Mathf.Lerp(90.0f, -90.0f, lerpFactor);
            directionalLight.transform.rotation = Quaternion.Euler(angle, 0, 0);

            // Adjust the light intensity to simulate dimming to complete darkness
            directionalLight.intensity = Mathf.Lerp(1.0f, 0.0f, lerpFactor);

            // Adjust ambient light color to simulate night
            RenderSettings.ambientLight = Color.Lerp(initialAmbientColor, nightAmbientColor, lerpFactor);
        }
        else
        {
            // Ensure the light is completely off and ambient light is set to night color at the end of the cycle
            directionalLight.intensity = 0.0f;
            RenderSettings.ambientLight = nightAmbientColor;

            // Transport the user to the "Dark" scene
            SceneManager.LoadScene("Dark");
        }
    }
}
