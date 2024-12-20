﻿// The following comment is required to instruct analyzers to skip this file
// <auto-generated/>

#if (NETCOREAPP && !NET5_0_OR_GREATER) || (NETFRAMEWORK) || (NETSTANDARD)
#nullable enable
// ReSharper disable RedundantUsingDirective
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart

namespace System.Diagnostics.CodeAnalysis;

// https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.dynamicallyaccessedmembersattribute
[AttributeUsage(
    AttributeTargets.Field
        | AttributeTargets.ReturnValue
        | AttributeTargets.GenericParameter
        | AttributeTargets.Parameter
        | AttributeTargets.Property
        | AttributeTargets.Method
        | AttributeTargets.Class
        | AttributeTargets.Interface
        | AttributeTargets.Struct,
    Inherited = false
)]
[ExcludeFromCodeCoverage]
internal class DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
    : Attribute
{
    public DynamicallyAccessedMemberTypes MemberTypes { get; } = memberTypes;
}
#endif
