using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    /// <summary>
    /// Class box of editools
    /// </summary>
    public static class EditoolsBox
    {
        /// <summary>
        /// Create HelpBox
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_messageType"></param>
        public static void HelpBox(string _message, MessageType _messageType = MessageType.None)
        {
            EditorGUILayout.HelpBox(_message, _messageType);
        }

        /// <summary>
        /// Create Warning HelpBox
        /// </summary>
        /// <param name="_message"></param>
        public static void HelpBoxWarning(string _message) => HelpBox(_message, MessageType.Warning);

        /// <summary>
        /// Create Error Warning
        /// </summary>
        /// <param name="_message"></param>
        public static void HelpBoxError(string _message) => HelpBox(_message, MessageType.Error);

        /// <summary>
        /// Create Info Helpbox
        /// </summary>
        /// <param name="_message"></param>
        public static void HelpBoxInfo(string _message) => HelpBox(_message, MessageType.Info);
    }
}
