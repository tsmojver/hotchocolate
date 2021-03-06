using System;
using HotChocolate.Types;

namespace HotChocolate.Utilities
{
    internal sealed class TypeInfo
    {
        public TypeInfo(Type nativeNamedType,
            Func<IType, IType> typeFactory)
        {
            NativeNamedType = nativeNamedType;
            TypeFactory = typeFactory;
        }

        public Type NativeNamedType { get; }

        public Func<IType, IType> TypeFactory { get; }
    }
}
