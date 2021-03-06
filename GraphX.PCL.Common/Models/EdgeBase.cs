﻿using GraphX.Measure;
using GraphX.Models.XmlSerializer;
using GraphX.PCL.Common.Enums;
using YAXLib;

namespace GraphX
{
    /// <summary>
    /// Base class for graph edge
    /// </summary>
    /// <typeparam name="TVertex">Vertex class</typeparam>
    public abstract class EdgeBase<TVertex> : IGraphXEdge<TVertex>
    {
        /// <summary>
        /// Skip edge in algo calc and visualization
        /// </summary>
        public ProcessingOptionEnum SkipProcessing { get; set; }

        public EdgeBase(TVertex source, TVertex target, double weight = 1)
        {

            Source = source;
            Target = target;
            Weight = weight;
            ID = -1;
        }

        /// <summary>
        /// Unique edge ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Returns true if Source vertex equals Target vertex
        /// </summary>
        [YAXDontSerialize]
        public bool IsSelfLoop
        {
            get { return Source.Equals(Target); }
        }

        /// <summary>
        /// Routing points collection used to make Path visual object
        /// </summary>
        [YAXCustomSerializer(typeof(YAXPointArraySerializer))]
        public Point[] RoutingPoints { get; set; }

        public TVertex Source { get; set; }

        public TVertex Target { get; set; }

        public double Weight { get; set; }

    }
}
