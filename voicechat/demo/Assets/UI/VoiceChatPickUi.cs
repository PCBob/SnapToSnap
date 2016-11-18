using UnityEngine;
using System.Collections;

namespace VoiceChat.UI
{
    public class VoiceChatPickUi : MonoBehaviour
    {
        void OnGUI()
        {
            GUILayout.Window(0, new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), Window, "", GUIStyle.none);
        }

        void Window(int id)
        {
            GUI.Box(new Rect(0, 0, 100, 100), "");

            if (GUILayout.Button("Start Server"))
            {
                gameObject.GetComponent<VoiceChatUnityServer>().enabled = true;
                MonoBehaviour.Destroy(this);
            }

            if (GUILayout.Button("Start Client"))
            {
                gameObject.GetComponent<VoiceChatUnityClient>().enabled = true;
                MonoBehaviour.Destroy(this);
            }
        }
    } 
}