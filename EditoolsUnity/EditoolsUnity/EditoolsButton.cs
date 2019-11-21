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
        /// <param name="_showCondition"></param>
        public static void Button(string _label, Color _c, Action _callback, bool _showCondition = true)
        {
            if (!_showCondition) return;

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
        /// <param name="_showCondition"></param>
        public static void Button<T>(string _label, Color _c, Action<T> _callback, T _arg0, bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void Button<T1, T2>(string _label, Color _c, Action<T1, T2> _callback, T1 _arg0, T2 _arg1, bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void Button<T1, T2, T3>(string _label, Color _c, Action<T1, T2, T3> _callback, T1 _arg0, T2 _arg1, T3 _arg2, bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void ButtonWithConfirm(string _label, Color _c, Action _callback, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel", bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void ButtonWithConfirm<T>(string _label, Color _c, Action<T> _callback, T _arg0, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel", bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void ButtonWithConfirm<T1, T2>(string _label, Color _c, Action<T1, T2> _callback, T1 _arg0, T2 _arg1, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel", bool _showCondition = true)
        {
            if (!_showCondition) return;
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
        /// <param name="_showCondition"></param>
        public static void ButtonWithConfirm<T1, T2, T3>(string _label, Color _c, Action<T1, T2, T3> _callback, T1 _arg0, T2 _arg1, T3 _arg2, string _titleConfirm, string _textConfirm, string _validTest = "Ok", string _cancelText = "Cancel", bool _showCondition = true)
        {
            if (!_showCondition) return;
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
}
