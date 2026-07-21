using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text fpsText;

    private float deltaTime;

    void Update()
    {
        // Smooth the frame time.
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        // Calculate Thing I Dont Understand....
        float fps = 1.0f / deltaTime;

        // Update the text
        fpsText.text = $"FPS: {Mathf.RoundToInt(fps)}";

        // Change text color based on Players Frames Per Sec
        if (fps >= 72)
        {
            fpsText.color = Color.green;
        }
        else if (fps >= 50)
        {
            fpsText.color = Color.yellow;
        }
        else
        {
            fpsText.color = Color.red;
        }
    }
}