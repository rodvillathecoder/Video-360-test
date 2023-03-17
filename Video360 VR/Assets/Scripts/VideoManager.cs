using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    [SerializeField] VideoPlayer _video;
    [SerializeField] PlayerController _player;

    public float Time { get { return (float) _video.time; } }
    public bool IsPlaying { get { return _video.isPlaying; } }



    private void Start()
    {
        PlayVideo(0);

    }




    public void PlayVideo()
    {
       
        if (IsPlaying)
            _video.Stop();
        else
        {
            if (Time == 0)
                _player.ResetRotation();


        }

        _video.Play();
    }

    public void PlayVideo(float time)
    {
        if (IsPlaying)
            _video.Stop();

        
        _video.Play();
        _video.time = time;
    }


    public void PauseVideo()
    {
        _video.Pause();
    }

    public void StopVideo()
    {
        _video.Stop();
        _player.Init();
    }



}
