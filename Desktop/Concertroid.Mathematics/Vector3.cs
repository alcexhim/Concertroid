﻿/*
	CRMath Copyright (c) 2013 Justin Byers


	This file is part of CRMath.

	CRMath is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	CRMath is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with CRMath.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Mathematics
{
	/// <summary>
	/// A vector containing X,Y,Z,W components
	/// </summary>
	struct Vector4
	{
		/// <summary>
		/// Creates a new Vector4 from the specified values
		/// </summary>
		/// <param name="x">the x-value of the vector</param>
		/// <param name="y">the y-value of the vector</param>
		/// <param name="z">the z-value of the vector</param>
		/// <param name="w">the w-value of the vector</param>
		public Vector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		/// <summary>
		/// Constructs a new Vector4, copying the data from a specified float array
		/// </summary>
		/// <param name="arr">the float array to copy data from</param>
		public Vector4(float[] arr)
		{
			this.x = arr[0];
			this.y = arr[1];
			this.z = arr[2];
			this.w = arr[3];
		}
		public float x, y, z, w;
	}
	/// <summary>
	/// Represents a vector containing X,Y,Z components
	/// </summary>
	class Vector3
	{
		public float x, y, z;

		//constructors
		/// <summary>
		/// Constructs a new Vector3 filed with zeros
		/// </summary>
		public Vector3()
		{
			this.x = 0;
			this.y = 0;
			this.z = 0;
		}
		/// <summary>
		/// Constructs a new Vector3, copying the data from a specified float array
		/// </summary>
		/// <param name="arr">the float array to copy data from</param>
		public Vector3(float[] arr)
		{
			this.x = arr[0];
			this.y = arr[1];
			this.z = arr[2];
		}
		/// <summary>
		/// Constructs a new Vector3, copying the data from another Vector3
		/// </summary>
		/// <param name="vec">the vector to copy data from</param>
		public Vector3(Vector3 vec)
		{
			this.x = vec.x;
			this.y = vec.y;
			this.z = vec.z;
		}
		/// <summary>
		/// Constructs a new Vector3 using the specified coordinates
		/// </summary>
		/// <param name="x">the x-coordinate of the vector</param>
		/// <param name="y">the y-coordinate of the vector</param>
		/// <param name="z">the z-coordinate of the vector</param>
		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		//unary operators using vectors
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			Vector3 o = new Vector3();
			o.x = a.x + b.x;
			o.y = a.y + b.y;
			o.z = a.z + b.z;
			return o;
		}
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			Vector3 o = new Vector3();
			o.x = a.x - b.x;
			o.y = a.y - b.y;
			o.z = a.z - b.z;
			return o;
		}
		public static Vector3 operator -(Vector3 v)
		{
			return new Vector3(-v.x, -v.y, -v.z);
		}

		//unary operators using constants
		public static Vector3 operator +(Vector3 a, float b)
		{
			Vector3 o = new Vector3();
			o.x = a.x + b;
			o.y = a.y + b;
			o.z = a.z + b;
			return o;
		}
		public static Vector3 operator -(Vector3 a, float b)
		{
			Vector3 o = new Vector3();
			o.x = a.x - b;
			o.y = a.y - b;
			o.z = a.z - b;
			return o;
		}
		public static Vector3 operator *(Vector3 a, float b)
		{
			Vector3 o = new Vector3();
			o.x = a.x * b;
			o.y = a.y * b;
			o.z = a.z * b;
			return o;
		}
		public static Vector3 operator /(Vector3 a, float b)
		{
			Vector3 o = new Vector3();
			o.x = a.x / b;
			o.y = a.y / b;
			o.z = a.z / b;
			return o;
		}

		//comparison operators 
		public static bool operator ==(Vector3 a, Vector3 b)
		{
			return a.Equals(b);
		}
		public static bool operator !=(Vector3 a, Vector3 b)
		{
			return !a.Equals(b);
		}

		//standard .NET type methods
		/// <summary>
		/// Copies the Vector3 to another Vector3
		/// </summary>
		/// <param name="obj">vector to copy to</param>
		public void Copy(Vector3 obj)
		{
			obj.x = this.x;
			obj.y = this.y;
			obj.z = this.z;
		}
		/// <summary>
		/// Determines if this Vector3 is equivalent to another object
		/// </summary>
		/// <param name="obj">the object to compare to</param>
		/// <returns>true: the objects are of the type Vector3 and are equivalent, false: the objects are not of the type Vector3 or not equivalent</returns>
		public override bool Equals(object obj)
		{
			if (obj.GetType() != typeof(Vector3))
				return false;
			Vector3 v = obj as Vector3;
			return (this.x == v.x) && (this.y == v.y) && (this.z == v.z);
		}
		/// <summary>
		/// Serves as a hash function for the Vector3 type
		/// </summary>
		/// <returns>a hash code for the current object</returns>
		public override int GetHashCode()
		{
			return this.x.GetHashCode() + this.y.GetHashCode() + this.z.GetHashCode();
		}
		/// <summary>
		/// Converts this Vector3 to a float array
		/// </summary>
		/// <returns>a float array containing the vector data</returns>
		public float[] ToArray()
		{
			return new float[3] { this.x, this.y, this.z };
		}
		/// <summary>
		/// Converts the Vector3 into its string representation
		/// </summary>
		/// <param name="format">a numeric string format</param>
		/// <returns>the string representation of this vector</returns>
		public string ToString(string format = "0.########")
		{
			return "(" + this.x.ToString(format) + "," + this.y.ToString(format) + "," + this.z.ToString(format) + ")";
		}

		//type-specific methods
		/// <summary>
		/// Determines the cross-product of this Vector3 and a specified Vector3
		/// </summary>
		/// <param name="v">the second vector to be used in the cross-product calculation</param>
		/// <returns>the cross-product of this vector and a specified vector</returns>
		public Vector3 Cross(Vector3 v)
		{
			Vector3 o = new Vector3();
			o.x = (this.y * v.z) - (this.z * v.y);
			o.y = (this.z * v.x) - (this.x * v.z);
			o.z = (this.x * v.y) - (this.y * v.x);
			return o;

		}
		/// <summary>
		/// Determines the dot-product of this Vector3 and a specified Vector3
		/// </summary>
		/// <param name="v">the second vector to be used in the dot-product calculation</param>
		/// <returns>the dot-product of this vector and a specified vector</returns>
		public float Dot(Vector3 v)
		{
			return ((this.x * v.x) + (this.y * v.y) + (this.z * v.z));
		}
		/// <summary>
		/// Determines the length of this Vector3
		/// </summary>
		/// <returns>the length of this vector</returns>
		public float Length()
		{
			return (float)Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
		}
		/// <summary>
		/// Calculates the normalized Vector3 representation of this Vector3
		/// </summary>
		/// <returns>the normalized vector representation of this vector</returns>
		public Vector3 Normalize()
		{
			Vector3 o = new Vector3(this);
			float mag = this.Length();
			o.x /= mag;
			o.y /= mag;
			o.z /= mag;

			return o;
		}
		/// <summary>
		/// Performs a linear interpolation between this Vector3 and a specified Vector3 using a specified interpolation parameter
		/// </summary>
		/// <param name="v">the vector to be interpolated to</param>
		/// <param name="s">the interpolation parameter</param>
		/// <returns>a new vector linearly interpolated between the two vector using a specified interpolation parameter</returns>
		public Vector3 Lerp(Vector3 v, float s)
		{
			return this + ((v - this) * s);
		}
		/// <summary>
		/// Transforms this Vector3 by the specified transformation matrix in homogeneous space
		/// </summary>
		/// <param name="m">the transformation matrix</param>
		/// <returns>the vector transformed by a specified transformation matrix in homogeneous space</returns>
		public Vector4 Transform(Matrix4x4 m)
		{
			float[] hv = new float[4] { this.x, this.y, this.z, 1 };
			float[] hvo = new float[4];
			for (int c = 0; c < 4; c++)
			{
				float v = 0;
				for (int i = 0; i < 4; i++)
				{
					v += hv[i] * m[i, c];
				}
				hvo[c] = v;
			}
			return new Vector4(hvo);
		}
		/// <summary>
		/// Transforms this Vector3 by the specified transformation matrix
		/// </summary>
		/// <param name="m">the transformation matrix</param>
		/// <returns>the vector transformed by a specified transformation matrix</returns>
		public Vector3 TransformCoord(Matrix4x4 m)
		{
			Vector4 v = this.Transform(m);
			return new Vector3(v.x / v.w, v.y / v.w, v.z / v.w);
		}

		//static type-specific methods
		/// <summary>
		/// Determines the cross-product of two Vector3
		/// </summary>
		/// <param name="a">the first vector to be used in the cross-product calculation</param>
		/// <param name="b">the second vector to be used in the cross-product calculation</param>
		/// <returns>the cross-product of two vector</returns>
		public static Vector3 Cross(Vector3 a, Vector3 b)
		{
			return a.Cross(b);
		}
		/// <summary>
		/// Determines the dot-product of two Vector3
		/// </summary>
		/// <param name="a">the first vector to be used in the dot-product calculation</param>
		/// <param name="b">the second vector to be used in the dot-product calculation</param>
		/// <returns>the dot-product of two vector</returns>
		public static float Dot(Vector3 a, Vector3 b)
		{
			return a.Dot(b);
		}
		/// <summary>
		/// Determines the length of a specified Vector3
		/// </summary>
		/// <param name="v">the vector to be calculated</param>
		/// <returns>the length of a specified vector</returns>
		public static float Length(Vector3 v)
		{
			return (float)Math.Sqrt((v.x * v.x) + (v.y * v.y) + (v.z * v.z));
		}
		/// <summary>
		/// Performs a linear interpolation between two Vector3 using a specified interpolation parameter
		/// </summary>
		/// <param name="a">the vector to be interpolated from</param>
		/// <param name="b">the vector to be interpolated to</param>
		/// <param name="s">the interpolation parameter</param>
		/// <returns>a new vector linearly interpolated between two vectors using a specified interpolation parameter</returns>
		public static Vector3 Lerp(Vector3 a, Vector3 b, float s)
		{
			return a + ((b - a) * s);
		}
		/// <summary>
		/// Calculates the normalized Vector3 representation of a specified Vector3
		/// </summary>
		/// <param name="v">the vector to be normalized</param>
		/// <returns>the normalized vector representation of a specified vector</returns>
		public static Vector3 Normalize(Vector3 v)
		{
			return v.Normalize();
		}
		/// <summary>
		/// Transforms a specified Vector3 by a specified transformation matrix in homogeneous space
		/// </summary>
		/// <param name="v">the vector to be transformed</param>
		/// <param name="m">the transformation matrix</param>
		/// <returns>a specified vector transformed by a specified transformation matrix in homogeneous space</returns>
		public static Vector4 Transform(Vector3 v, Matrix4x4 m)
		{
			return v.Transform(m);
		}
		/// <summary>
		/// Transforms a specified Vector3 by a specified transformation matrix
		/// </summary>
		/// <param name="v">the vector to be transformed</param>
		/// <param name="m">the transformation matrix</param>
		/// <returns>a specified vector transformed by a specified transformation matrix</returns>
		public static Vector3 TransformCoord(Vector3 v, Matrix4x4 m)
		{
			return v.TransformCoord(m);
		}
	}

}
