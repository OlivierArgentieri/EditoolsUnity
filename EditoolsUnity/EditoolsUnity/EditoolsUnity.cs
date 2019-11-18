using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    /// <summary>
    /// Class button of Editools
    /// </summary>
    public static class EditoolsUnity
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

    /// <summary>
    /// Class field of Editools
    /// </summary>
    public static class EditoolsField
    {
        /// <summary>
        /// Create Text field with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_output"></param>
        public static void TextField(string _label, ref string _output)
        {
            _output = EditorGUILayout.TextField(_label, _output);
        }

        /// <summary>
        /// Create Text field with return value
        /// </summary>
        /// <param name="_label"></param>
        public static string TextField(string _label, string _text)
        {
             return EditorGUILayout.TextField(_label, _text);
        }


        /// <summary>
        /// Create Vector3 field with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_vector3"></param>
        public static void Vector3Field(string _label, ref Vector3 _vector3)
        {
            _vector3 = EditorGUILayout.Vector3Field(_label, _vector3);
        }

        /// <summary>
        /// Create Vector3 field with return value
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_vector3"></param>
        /// <returns></returns>
        public static Vector3 Vector3Field(string _label, Vector3 _vector3)
        {
            return EditorGUILayout.Vector3Field(_label, _vector3);
        }

        /// <summary>
        /// Create float field with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_output"></param>
        public static void FloatField(string _label, ref float _output)
        {
            _output = EditorGUILayout.FloatField(_label, _output);
        }


        /// <summary>
        /// Create float field with return value
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        /// <returns></returns>
        public static float FloatField(string _label, float _value)
        {
            return EditorGUILayout.FloatField(_label, _value);
        }


        /// <summary>
        /// Create Int field with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_output"></param>
        public static void IntField(string _label, ref int _output)
        {
            _output = EditorGUILayout.IntField(_label, _output);
        }


        /// <summary>
        /// Create Int field with return value
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        /// <returns></returns>
        public static int IntField(string _label, int _value)
        {
            return EditorGUILayout.IntField(_label, _value);
        }


        /// <summary>
        /// Create Color field with output parameter
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="_outColor"></param>
        public static void ColorField(Color _color, ref Color _outColor)
        {
            _outColor = EditorGUILayout.ColorField(_color);
        }

        /// <summary>
        /// Create Color field with return value
        /// </summary>
        /// <param name="_color"></param>
        public static Color ColorField(Color _color)
        {
            return EditorGUILayout.ColorField(_color);
        }

        /// <summary>
        /// Create Int Slider with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        /// <param name="_leftValue"></param>
        /// <param name="_rightValue"></param>
        public static void IntSlider(string _label, ref int _value, int _leftValue, int _rightValue)
        {
            _value = EditorGUILayout.IntSlider(_label, _value, _leftValue, _rightValue);
        }

        /// <summary>
        /// Create Int Slider with return value
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        /// <param name="_leftValue"></param>
        /// <param name="_rightValue"></param>
        public static int IntSlider(string _label, int _value, int _leftValue, int _rightValue)
        {
            return EditorGUILayout.IntSlider(_label, _value, _leftValue, _rightValue);
        }



        /*
        /// <summary>
        /// Create ObjectField with output parameter
        /// </summary>
        /// <param name="_o"></param>
        /// <param name="_typeObject"></param>
        /// <param name="_allowSceneObject"></param>
        /// <returns></returns>
        public static void ObjectField(ref UnityEngine.Object _o, Type _typeObject, bool _allowSceneObject)
        {
            _o = EditorGUILayout.ObjectField(_o, _typeObject, _allowSceneObject);
        }todo fix cast issue*/


        /// <summary>
        /// Create ObjectField with return value
        /// </summary>
        /// <param name="_o"></param>
        /// <param name="_typeObject"></param>
        /// <param name="_allowSceneObject"></param>
        /// <returns></returns>
        public static UnityEngine.Object ObjectField(UnityEngine.Object _o, Type _typeObject, bool _allowSceneObject)
        {
            return EditorGUILayout.ObjectField(_o, _typeObject, _allowSceneObject);
        }

        /// <summary>
        /// Create Toggle with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        public static void Toggle(string _label, ref bool _value)
        {
            _value = EditorGUILayout.Toggle(_label, _value);
        }

        /// <summary>
        /// Create Toggle with return value
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_value"></param>
        public static bool Toggle(string _label, bool _value)
        {
            return EditorGUILayout.Toggle(_label, _value);
        }


        /*
        /// <summary>
        /// Create EnumPopup with output parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_type"></param>
        public static void EnumPopup(string _label, ref Enum _type)
        {
            _type = EditorGUILayout.EnumPopup(_label, _type);
        }todo fix cast issue*/ 


        /// <summary>
        /// Create EnumPopup with return parameter
        /// </summary>
        /// <param name="_label"></param>
        /// <param name="_type"></param>
        public static Enum EnumPopup(string _label, Enum _type)
        {
            return EditorGUILayout.EnumPopup(_label, _type);
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
        public static void Space(int _i=1)
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

    /// <summary>
    /// Control and Drawing in the 3D scene view
    /// </summary>
    public static class EditoolsHandle
    {
        /// <summary>
        /// Edit position of ref parameter in the secene view
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_rotation"></param>
        public static void PositionHandle(ref Vector3 _position, Quaternion _rotation)
        {
            _position = Handles.DoPositionHandle(_position, _rotation);
        }

        /// <summary>
        /// Edit Scale of ref parameter in the scene view 
        /// </summary>
        /// <param name="_scale"></param>
        /// <param name="_position"></param>
        /// <param name="_rotation"></param>
        /// <param name="_size"></param>
        public static void ScaleHandle(ref Vector3 _scale, Vector3 _position, Quaternion _rotation, float _size)
        {
            _scale = Handles.DoScaleHandle(_scale, _position, _rotation, _size);
        }

        /// <summary>
        /// Edit Rotation of ref parameter in the scene view 
        /// </summary>
        /// <param name="_rotation"></param>
        /// <param name="_position"></param>
        public static void RotationHandle(ref Quaternion _rotation, Vector3 _position)
        {
            _rotation = Handles.DoRotationHandle(_rotation, _position);
        }

        /// <summary>
        /// Set current Handle Color
        /// </summary>
        /// <param name="_color"></param>
        public static void SetColor(Color _color)
        {
            Handles.color = _color;
        }


        /// <summary>
        /// Draw WireCube
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_size"></param>
        public static void DrawWireCube(Vector3 _position, Vector3 _size)
        {
            Handles.DrawWireCube(_position, _size);
        }


        /// <summary>
        /// Draw Dotted Line
        /// </summary>
        /// <param name="_position1"></param>
        /// <param name="_position2"></param>
        /// <param name="_screenSpaceSize"></param>
        public static void DrawDottedLine(Vector3 _position1, Vector3 _position2, float _screenSpaceSize)
        {
            Handles.DrawDottedLine(_position1, _position2, _screenSpaceSize);
        }


        /// <summary>
        /// Draw Wire Disc
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_normal"></param>
        /// <param name="_radius"></param>
        public static void DrawWireDisc(Vector3 _position, Vector3 _normal, float _radius)
        {
            Handles.DrawWireDisc(_position, _normal, _radius);
        }

    }

    public class EditorCustom<T> : Editor where T : MonoBehaviour
    {
        protected T eTarget = default(T); // editor target

        protected virtual void OnEnable()
        {
            eTarget = (T)target;
            eTarget.name = $"{ typeof(T).Name}";
        }
    }
}