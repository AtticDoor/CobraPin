using UnityEngine;
using UnityEngine.Video;

public class AttractModeController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Call this from the BCP message handler when mode_start arrives
    public void OnModeStart(string modeName)
    {
        if (modeName == "attract")
        {
            if (videoPlayer != null && !videoPlayer.isPlaying)
            {
                videoPlayer.Play();
                Debug.Log("Attract video started");
            }
        }
        else
        {
            // Optional: stop the video when any other mode starts
            if (videoPlayer != null && videoPlayer.isPlaying)
            {
                videoPlayer.Stop();
                Debug.Log("Attract video stopped");
            }
        }
    }
}