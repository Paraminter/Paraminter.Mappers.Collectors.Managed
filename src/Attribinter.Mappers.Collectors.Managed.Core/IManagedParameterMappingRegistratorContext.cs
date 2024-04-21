﻿namespace Attribinter.Mappers.Collectors.Managed;

/// <summary>Provides context for <see cref="IManagedParameterMappingRegistrator{TParameter, TRecord, TData, TParameterFactory, TRecorderFactory}"/>.</summary>
/// <typeparam name="TParameter">The type of the mapped parameters.</typeparam>
/// <typeparam name="TRecord">The type of the data record to which the mapped recorders record data.</typeparam>
/// <typeparam name="TData">The type of the data recorded by the mapped recorders.</typeparam>
/// <typeparam name="TParameterFactory">The type handling creation of parameters.</typeparam>
/// <typeparam name="TRecorderFactory">The type handling creation of recorders.</typeparam>
public interface IManagedParameterMappingRegistratorContext<in TParameter, out TRecord, out TData, out TParameterFactory, out TRecorderFactory>
{
    /// <summary>Collects mappings from parameters to recorders.</summary>
    public abstract IParameterMappingCollector<TParameter, TRecord, TData> Collector { get; }

    /// <summary>Handles creation of parameters.</summary>
    public abstract TParameterFactory ParameterFactory { get; }

    /// <summary>Handles creation of recorders.</summary>
    public abstract TRecorderFactory RecorderFactory { get; }
}
