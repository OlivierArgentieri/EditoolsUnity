using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
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
        /// Create position handle and returne new position
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_rotation"></param>
        /// <returns>return new vector3 P       osition</returns>
        public static Vector3 PositionHandle(Vector3 _position, Quaternion _rotation)
        {
            return Handles.DoPositionHandle(_position, _rotation);
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
        /// Create position handle and returne new Scale
        /// </summary>
        /// <param name="_scale"></param>
        /// <param name="_position"></param>
        /// <param name="_rotation"></param>
        /// <param name="_size"></param>
        /// <returns>return new vector3 Scale</returns>
        public static Vector3 ScaleHandle(Vector3 _scale, Vector3 _position, Quaternion _rotation, float _size)
        {
            return Handles.DoScaleHandle(_scale, _position, _rotation, _size);
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
        /// Create position handle and returne new Scale
        /// </summary>
        /// <param name="_rotation"></param>
        /// <param name="_position"></param>
        /// <returns> new quaternion rotation </returns>
        public static Quaternion RotationHandle(Quaternion _rotation, Vector3 _position)
        {
            return Handles.DoRotationHandle(_rotation, _position);
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


        /// <summary>
        /// Draw Solid Disc
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_normal"></param>
        /// <param name="_radius"></param>
        public static void DrawSolidDisc(Vector3 _position, Vector3 _normal, float _radius)
        {
            Handles.DrawSolidDisc(_position, _normal, _radius);
        }


        /// <summary>
        /// Draw Line
        /// </summary>
        /// <param name="_position1"></param>
        /// <param name="_position2"></param>
        public static void DrawLine(Vector3 _position1, Vector3 _position2)
        {
            Handles.DrawLine(_position1, _position2);
        }

        /// <summary>
        /// Create Label
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_message"></param>
        public static void Label(Vector3 _position, string _message)
        {
            Handles.Label(_position, _message);
        }
    }
}