using UnityEngine;
using JMRSDK.InputModule;
using TMPro;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// Shows example of accessing callbacks called during back, home and menu button press.
    /// </summary>
    /// <remarks>
    /// Requires global listener as these buttons should be called from anywhere in the scene.
    /// </remarks>
    public class ButtonManager : MonoBehaviour, IBackHandler, IHomeHandler, IMenuHandler
    {
        public TextMeshProUGUI HUDText;

        /// <summary>
        /// Added Global Listener in Start method.
        /// </summary>
        public void Start()
        {
            JMRInputManager.Instance.AddGlobalListener(gameObject);
        }

        /// <summary>
        /// Callback for Back button press
        /// </summary>
        public void OnBackAction()
        {
            HUDText.text = "Back button is pressed";
        }

        /// <summary>
        /// Callback for Home button press
        /// </summary>
        public void OnHomeAction()
        {
            HUDText.text = "Home button is pressed";
        }

        /// <summary>
        /// Callback for Menu button press
        /// </summary>
        /// <remarks>
        /// Double press Home button for menu button
        /// </remarks>
        public void OnMenuAction()
        {
            HUDText.text = "Menu button is pressed";
        }
    }
}