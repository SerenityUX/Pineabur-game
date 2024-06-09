using UnityEngine;

public static class SceneData
{
    public static string NPCName;
    public static int Day = 0;
    public static Vector3 PlayerPosition = new Vector3(0, 0, 0); // Initial position
    public static Quaternion PlayerRotation = Quaternion.identity; // Initial rotation
    public static string PreviousScene;
    public static float ElapsedTime = 0f;
}
