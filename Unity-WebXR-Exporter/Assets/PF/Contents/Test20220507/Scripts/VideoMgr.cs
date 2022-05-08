using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoMgr : MonoBehaviour
{
    enum Phase {
        Stopped,
        Prepared,
        Playing,
        Paused
    }

    Phase phase = Phase.Stopped;

    [SerializeField] VideoPlayer vp = null;
    [SerializeField] RawImage targetImage = null;

    const string videoPathPFDemo = "pfDemo_lite.mp4";
    const string videoPathVR305 = "VR3_05.mp4";

    void Start()
    {
    }

    public void Play_Streaming_PFDemo()
    {
        Debug.Log($"@Play_Streaming_PFDemo()");
        vp.source = VideoSource.Url;
        vp.url = Application.streamingAssetsPath + "/" + videoPathPFDemo;
        vp.prepareCompleted += OnPrepareCompleted;
        vp.Prepare();
//        video.Play();
    }

    void OnPrepareCompleted(VideoPlayer vp)
    {
        Debug.Log($"@OnPrepareCompleted()");
        vp.prepareCompleted -= OnPrepareCompleted;
        vp.started += OnMovieStarted;
        targetImage.texture = vp.texture;
        var rt = targetImage.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(vp.texture.width, vp.texture.height);
        phase = Phase.Prepared;
        vp.Play();
        phase = Phase.Prepared;
    }

    void OnMovieStarted(VideoPlayer vp)
    {
        Debug.Log($"@OnMovieStarted()");
        vp.started -= OnMovieStarted;
        // 再生が開始されたらイメージを表示する
        targetImage.enabled = true;
    }
}
