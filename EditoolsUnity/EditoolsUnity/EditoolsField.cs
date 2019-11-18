using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{

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
}
