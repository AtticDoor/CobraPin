using UnityEngine;
using UnityEngine.Video;
using BCP; // or whatever namespace your BcpServer uses

public class AttractVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string attractModeName = "attract";

    void Start()
    {
        // Example: start looping as soon as the scene runs
        // You can later hook this to BCP events
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    // Later you can add methods that the BCP server calls
    // when it receives mode_attract_started / mode_attract_stopped
}