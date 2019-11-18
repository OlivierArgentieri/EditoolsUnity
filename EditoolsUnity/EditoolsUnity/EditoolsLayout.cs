using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    /// <summary>
    /// Class Layout of editools
    /// </summary>
    public static class EditoolsLayout
    {
        /// <summary>
        /// Create Space with repeting parameters
        /// </summary>
        /// <param name="_i"></param>
        public static void Space(int _i = 1)
        {
            for (int i = 0; i < _i; i++)
            {
                EditorGUILayout.Space();
            }
        }

        /// <summary>
        /// Create Start or End GUILayout Horizontal
        /// </summary>
        /// <param name="_begin"></param>
        public static void Horizontal(bool _begin)
        {
            if (_begin) EditorGUILayout.BeginHorizontal();
            else EditorGUILayout.EndHorizontal();
        }

        /// <summary>
        /// Create Start or End GUILayout Vertical
        /// </summary>
        /// <param name="_begin"></param>
        public static void Vertical(bool _begin)
        {
            if (_begin) EditorGUILayout.BeginVertical();
            else EditorGUILayout.EndVertical();
        }

        /// <summary>
        /// Create Foldout and return the boolean value
        /// </summary>
        /// <param name="_foldout"></param>
        /// <param name="_text"></param>
        /// <param name="_toogleOnClick"></param>
        /// <returns></returns>
        public static bool Foldout(bool _foldout, string _text, bool _toogleOnClick = true)
        {
            return EditorGUILayout.Foldout(_foldout, _text, _toogleOnClick);
        }

        /// <summary>
        /// Create Foldout and return the boolean value by ref
        /// </summary>
        /// <param name="_value"></param>
        /// <param name="_title"></param>
        /// <param name="_isWide"></param>
        /// <returns></returns>
        public static bool Foldout(ref bool _value, string _title, bool _isWide = false) => _value = EditorGUILayout.Foldout(_value, _title, _isWide);
    }
}
