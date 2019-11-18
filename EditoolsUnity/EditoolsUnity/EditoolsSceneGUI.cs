using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    public static class EditoolsSceneGUI
    {
        /// <summary>
        /// Begin  GUI
        /// </summary>
        public static void BeginGUI()
        {
            Handles.BeginGUI();
        }

        /// <summary>
        /// End GUI
        /// </summary>
        public static void EndGUI()
        {
            Handles.EndGUI();
        }


        /// <summary>
        /// Start and close GUI easily with bool parameter
        /// </summary>
        /// <param name="_begin"></param>
        public static void BeginGUI(bool _begin = true)
        {
            if (_begin)
                BeginGUI();
            else
                EndGUI();
        }

        /// <summary>
        /// Create Area
        /// </summary>
        /// <param name="_rect"></param>
        public static void BeginArea(Rect _rect)
        {
            GUILayout.BeginArea(_rect);
        }

        /// <summary>
        /// Close Area
        /// </summary>
        public static void EndArea()
        {
            GUILayout.EndArea();
        }
        
        /// <summary>
        /// Create Box
        /// </summary>
        /// <param name="_text"></param>
        public static void Box(string _text)
        {
            GUILayout.Box(_text);
        }

        /// <summary>
        /// Create Box with style
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="_guiStyle"></param>
        public static void Box(string _text, GUIStyle _guiStyle)
        {
            GUILayout.Box(_text, _guiStyle);
        }


        /// <summary>
        /// create Button
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="_callback"></param>
        public static void Button(string _text, Action _callback)
        {
            if (GUILayout.Button(_text))
                _callback?.Invoke();
        }


        /// <summary>
        /// create Button with style
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="_callback"></param>
        /// <param name="_style"></param>
        public static void Button(string _text, Action _callback, GUIStyle _style)
        {
            if (GUILayout.Button(_text, _style))
                _callback?.Invoke();
        }


        #region custom methods
        static GUIStyle GetGuiStyle(StyleMode _styleMode)
        {
            switch (_styleMode)
            {
                case StyleMode.Button:
                    return new GUIStyle(GUI.skin.button);

                case StyleMode.Label:
                    return new GUIStyle(GUI.skin.label);

                case StyleMode.Box:
                    return new GUIStyle(GUI.skin.box);
            }
            return null;
        }

        /// <summary>
        /// Set Style to GUI object
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="_alignment"></param>
        /// <param name="_styleMode"></param>
        /// <param name="_style"></param>
        /// <returns></returns>
        public static GUIStyle SetStyle(Color _color, TextAnchor _alignment, StyleMode _styleMode, FontStyle _style = FontStyle.Bold)
        {
            GUIStyle _labelStyle = GetGuiStyle(_styleMode);

            _labelStyle.normal.textColor = _color;
            _labelStyle.alignment = _alignment;
            _labelStyle.fontStyle = _style;
            return _labelStyle;
        }
        #endregion
    }
    public enum StyleMode
    {
        Button,
        Label,
        Box
    }
}
