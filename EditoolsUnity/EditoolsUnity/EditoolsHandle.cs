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
        
}