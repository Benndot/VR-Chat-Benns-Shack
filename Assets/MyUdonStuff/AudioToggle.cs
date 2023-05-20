
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

namespace benndot.audioToggle
{
    public class AudioToggle : UdonSharpBehaviour
    {

        public AudioSource audioTarget;

        void Start()
        {
            
        }

        public void toggleAudio()
        {
            if (audioTarget.isPlaying) {
                audioTarget.Pause();
            }
            else if(!audioTarget.isPlaying) {
                audioTarget.Play();
            }
        }
    }
}


