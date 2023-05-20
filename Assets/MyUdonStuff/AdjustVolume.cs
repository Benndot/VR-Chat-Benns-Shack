using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

namespace benndot.volume
{

    public class AdjustVolume : UdonSharpBehaviour
    {
        
        public int intVar;

        public Slider _slide;

        public AudioSource audioTarget;

        void Start()
        {
            _slide = transform.GetComponent<Slider>();
            _slide.value = 0.2f;
        }

        public void SlideUpdate()
        {
            audioTarget.volume = _slide.value;
        }
    }
}