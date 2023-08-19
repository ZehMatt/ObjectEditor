﻿namespace OpenLocoTool.DatFileParsing
{
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
	public class LocoArrayLengthAttribute : Attribute
	{
		public int Length { get; }

		public LocoArrayLengthAttribute(int length) => Length = length;
	}

	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
	public class LocoStructOffsetAttribute : Attribute
	{
		public LocoStructOffsetAttribute(int offset)
		{
			Offset = offset;
		}

		public int Offset { get; }
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
	public class LocoStructSizeAttribute : Attribute
	{
		public LocoStructSizeAttribute(int size)
		{
			Size = size;
		}

		public int Size { get; }
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
	public class LocoStringCountAttribute : Attribute
	{
		public LocoStringCountAttribute(int count)
		{
			Count = count;
		}

		public int Count { get; }
	}
}
