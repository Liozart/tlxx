using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace RealTimeFaceRecognitionExample
{
    public class RealTimeFaceRecognitionEnter : MonoBehaviour
    {

        public void OnWebCamTextureRealTimeFaceRecognitionEnterButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("FaceRecognitionInfos1Scene");
            #else
			Application.LoadLevel ("FaceRecognitionInfos1Scene");
            #endif
        }
    }
}
