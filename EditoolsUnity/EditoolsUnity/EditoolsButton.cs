using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    /// <summary>
    /// Class button of Editools
    /// </summary>
    public static class EditoolsButton
    {
        /// <summary>
        /// Create button without parameters in callback
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        public static void Button(string _label, Color _c, Action _callback)
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
                _callback?.Invoke();
            GUI.color = Color.white;
        }

        /// <summary>
        /// Create button with parameter in callback
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        public static void Button<T>(string _label, Color _c, Action<T> _callback, T _arg0)
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
                _callback?.Invoke(_arg0);
            GUI.color = Color.white;
        }

        /// <summary>
        /// Create button with parameters in callback
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        /// <param name="_arg1"></param>
        public static void Button<T1, T2>(string _label, Color _c, Action<T1, T2> _callback, T1 _arg0, T2 _arg1)
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
                _callback?.Invoke(_arg0, _arg1);
            GUI.color = Color.white;
        }



        /// <summary>
        /// Create button with parameters in callback
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        /// <param name="_arg1"></param>
        /// <param name="_arg2"></param>
        public static void Button<T1, T2, T3>(string _label, Color _c, Action<T1, T2, T3> _callback, T1 _arg0, T2 _arg1, T3 _arg2)
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
                _callback?.Invoke(_arg0, _arg1, _arg2);
            GUI.color = Color.white;
        }


        /// <summary>
        /// Create button and confirm box without parameters in callback
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_titleConfirm"></param>
        /// <param name="_textConfirm"></param>
        /// <param name="_validTest"></param>
        /// <param name="_cancelText"></param>
        public static void ButtonWithConfirm(string _label, Color _c, Action _callback, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel")
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
            {
                bool _confirm = EditorUtility.DisplayDialog(_titleConfirm, _textConfirm, _validTest, _cancelText);
                if (_confirm)
                    _callback?.Invoke();
            }
            GUI.color = Color.white;
        }

        /// <summary>
        /// Create button and confirm box with parameter in callback
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        /// <param name="_titleConfirm"></param>
        /// <param name="_textConfirm"></param>
        /// <param name="_validTest"></param>
        /// <param name="_cancelText"></param>
        public static void ButtonWithConfirm<T>(string _label, Color _c, Action<T> _callback, T _arg0, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel")
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
            {
                bool _confirm = EditorUtility.DisplayDialog(_titleConfirm, _textConfirm, _validTest, _cancelText);
                if (_confirm)
                    _callback?.Invoke(_arg0);
            }
            GUI.color = Color.white;
        }

        /// <summary>
        /// Create button and confirm box with parameters in callback
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        /// <param name="_arg1"></param>
        /// <param name="_titleConfirm"></param>
        /// <param name="_textConfirm"></param>
        /// <param name="_validTest"></param>
        /// <param name="_cancelText"></param>
        public static void ButtonWithConfirm<T1, T2>(string _label, Color _c, Action<T1, T2> _callback, T1 _arg0, T2 _arg1, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel")
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
            {
                bool _confirm = EditorUtility.DisplayDialog(_titleConfirm, _textConfirm, _validTest, _cancelText);
                if (_confirm)
                    _callback?.Invoke(_arg0, _arg1);
            }
            GUI.color = Color.white;
        }


        /// <summary>
        /// Create button and confirm box with parameters in callback
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="_label"></param>
        /// <param name="_c"></param>
        /// <param name="_callback"></param>
        /// <param name="_arg0"></param>
        /// <param name="_arg1"></param>
        /// <param name="_arg2"></param>
        /// <param name="_titleConfirm"></param>
        /// <param name="_textConfirm"></param>
        /// <param name="_validTest"></param>
        /// <param name="_cancelText"></param>
        public static void ButtonWithConfirm<T1, T2, T3>(string _label, Color _c, Action<T1, T2, T3> _callback, T1 _arg0, T2 _arg1, T3 _arg2, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel")
        {
            GUI.color = _c;
            if (GUILayout.Button(_label))
            {
                bool _confirm = EditorUtility.DisplayDialog(_titleConfirm, _textConfirm, _validTest, _cancelText);
                if (_confirm)
                    _callback?.Invoke(_arg0, _arg1, _arg2);
            }
            GUI.color = Color.white;
        }
    }

    /// <summary>
    /// Class field of Editools
    /// </summary>
    public static class EditoolsField
    {
        /// <summary>
        /// Create Text field with out data
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_output"></param>
        public static void TextField(string _label, out string _output)
        {
            _output = EditorGUILayout.TextField(_label);
        }

        /// <summary>
        /// Create Vector3 field with return vector3 data
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_vector3"></param>
        /// <returns></returns>
        public static Vector3 Vector3Field(string _label, Vector3 _vector3)
        {
            return EditorGUILayout.Vector3Field(_label, _vector3);
        }

        /// <summary>
        /// Create Color field with out data
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="_outColor"></param>
        public static void ColorField(Color _color, out Color _outColor)
        {
            _outColor = EditorGUILayout.ColorField(_color);
        }
    }

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

    /// <summary>
    /// Class Layout of editools
    /// </summary>
    public static class EditoolsLayout
    {
        /// <summary>
        /// Create Space with repeting parameters
        /// </summary>
        /// <param name="_i"></param>
        public static void Space(int _i)
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