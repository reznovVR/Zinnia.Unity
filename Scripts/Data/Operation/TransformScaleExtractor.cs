﻿namespace Zinnia.Data.Operation
{
    using UnityEngine;

    /// <summary>
    /// Extracts the scale of a<see cref="Transform"/>.
    /// </summary>
    public class TransformScaleExtractor : TransformVector3PropertyExtractor
    {
        /// <inheritdoc />
        protected override Vector3 ExtractValue()
        {
            return useLocal ? source.transform.localScale : source.transform.lossyScale;
        }
    }
}